using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Rodder
{
    public static class MacroHandler
    {
        // WinAPI constants
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private const int WM_SYSKEYDOWN = 0x0104;
        private const int WM_SYSKEYUP = 0x0105;
        private const uint KEYEVENTF_KEYUP = 0x0002;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;

        // Hook handle and callback
        private static IntPtr hookId = IntPtr.Zero;
        private static LowLevelKeyboardProc hookCallback = HookCallback;

        // Configuration
        private static Keys swordKey;
        private static Keys rodKey;
        private static Keys macroKey;
        private static Keys toggleKey;
        private static bool backToSwordEnabled;
        private static Action onToggle;

        // State tracking
        private static bool macroEnabled = false;
        private static bool macroKeyPressed = false;

        public static void Configure(Keys sword, Keys rod, Keys macro, Keys toggle, bool backToSword, Action toggleCallback)
        {
            swordKey = sword;
            rodKey = rod;
            macroKey = macro;
            toggleKey = toggle;
            backToSwordEnabled = backToSword;
            onToggle = toggleCallback;
        }

        public static void UpdateConfiguration(Keys sword, Keys rod, Keys macro, Keys toggle, bool backToSword)
        {
            swordKey = sword;
            rodKey = rod;
            macroKey = macro;
            toggleKey = toggle;
            backToSwordEnabled = backToSword;
        }

        public static void StartListening()
        {
            if (hookId == IntPtr.Zero)
            {
                hookId = SetHook(hookCallback);
            }
            macroEnabled = true;
        }

        public static void StopListening()
        {
            macroEnabled = false;
            macroKeyPressed = false;
        }

        public static void StopListeningCompletely()
        {
            if (hookId != IntPtr.Zero)
            {
                UnhookWindowsHookEx(hookId);
                hookId = IntPtr.Zero;
                macroEnabled = false;
                macroKeyPressed = false;
            }
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;
                Keys normalizedKey = NormalizeKey(key);
                Keys normalizedToggle = NormalizeKey(toggleKey);
                Keys normalizedMacro = NormalizeKey(macroKey);

                // Handle keydown events (regular and system keys like Alt)
                if (wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN)
                {
                    // Toggle key - enable/disable macro
                    if (normalizedKey == normalizedToggle)
                    {
                        onToggle?.Invoke();
                        Console.Beep(macroEnabled ? 800 : 400, 100);
                        return (IntPtr)1;
                    }

                    // Macro key - execute macro sequence
                    if (macroEnabled && normalizedKey == normalizedMacro && !macroKeyPressed)
                    {
                        macroKeyPressed = true;
                        ExecuteMacroPress();
                        return (IntPtr)1;
                    }
                }
                // Handle keyup events
                else if (wParam == (IntPtr)WM_KEYUP || wParam == (IntPtr)WM_SYSKEYUP)
                {
                    // Macro key released - switch back to sword if enabled
                    if (normalizedKey == normalizedMacro && macroKeyPressed)
                    {
                        macroKeyPressed = false;
                        if (macroEnabled && backToSwordEnabled)
                        {
                            ExecuteMacroRelease();
                        }
                    }
                }
            }

            return CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        private static Keys NormalizeKey(Keys key)
        {
            if (key == Keys.LMenu || key == Keys.RMenu || key == Keys.Menu)
                return Keys.LMenu;
            if (key == Keys.LShiftKey || key == Keys.RShiftKey || key == Keys.ShiftKey)
                return Keys.LShiftKey;
            if (key == Keys.LControlKey || key == Keys.RControlKey || key == Keys.ControlKey)
                return Keys.LControlKey;
            return key;
        }

        private static void ExecuteMacroPress()
        {
            PressKey(rodKey);
            RightClick();
        }

        private static void ExecuteMacroRelease()
        {
            PressKey(swordKey);
        }

        private static void PressKey(Keys key)
        {
            keybd_event((byte)key, 0, 0, 0);
            keybd_event((byte)key, 0, KEYEVENTF_KEYUP, 0);
        }

        private static void RightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, UIntPtr.Zero);
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, UIntPtr.Zero);
        }

        // WinAPI imports
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);
    }
}