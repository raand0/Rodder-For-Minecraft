using System;
using System.Windows.Forms;

namespace Rodder
{
    public partial class Rodder : Form
    {
        DefaultPage d = new DefaultPage();
        HowPage h = new HowPage();
        private bool isEnabled = false;

        public Rodder()
        {
            InitializeComponent();
            MacroPageButton_Click(MacroPageButton, EventArgs.Empty);
            UpdateState();

            // make sure it stops listening when the app closes
            this.FormClosing += Rodder_FormClosing;
        }
        public static Keys MapKey(string keyName)
        {
            switch (keyName.ToUpper())
            {
                case "LALT":
                    return Keys.LMenu;
                case "LSHIFT":
                    return Keys.ShiftKey;
                case "LCTRL":
                    return Keys.ControlKey;
                case "SPACE":
                    return Keys.Space;
                case "TAB":
                    return Keys.Tab;

                case "A":
                    return Keys.A;
                case "B":
                    return Keys.B;
                case "C":
                    return Keys.C;
                case "D":
                    return Keys.D;
                case "E":
                    return Keys.E;
                case "F":
                    return Keys.F;
                case "G":
                    return Keys.G;
                case "H":
                    return Keys.H;
                case "I":
                    return Keys.I;
                case "J":
                    return Keys.J;
                case "K":
                    return Keys.K;
                case "L":
                    return Keys.L;
                case "M":
                    return Keys.M;
                case "N":
                    return Keys.N;
                case "O":
                    return Keys.O;
                case "P":
                    return Keys.P;
                case "Q":
                    return Keys.Q;
                case "R":
                    return Keys.R;
                case "S":
                    return Keys.S;
                case "T":
                    return Keys.T;
                case "U":
                    return Keys.U;
                case "V":
                    return Keys.V;
                case "W":
                    return Keys.W;
                case "X":
                    return Keys.X;
                case "Y":
                    return Keys.Y;
                case "Z":
                    return Keys.Z;

                case "1":
                    return Keys.D1;
                case "2":
                    return Keys.D2;
                case "3":
                    return Keys.D3;
                case "4":
                    return Keys.D4;
                case "5":
                    return Keys.D5;
                case "6":
                    return Keys.D6;
                case "7":
                    return Keys.D7;
                case "8":
                    return Keys.D8;
                case "9":
                    return Keys.D9;
                case "0":
                    return Keys.D0;

                default:
                    return Keys.None;
            }
        }

        private void UpdateState()
        {
            if (isEnabled)
            {
                Switch.Text = "ON";
                Switch.ForeColor = System.Drawing.Color.Green;
                Switch.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                Switch.Text = "OFF";
                Switch.ForeColor = System.Drawing.Color.Maroon;
                Switch.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            }
        }

        private void MacroPageButton_Click(object sender, EventArgs e)
        {
            HowPageButton.BackColor = System.Drawing.Color.FromArgb(255, 34, 34, 34);
            MacroPageButton.BackColor = System.Drawing.Color.FromArgb(255, 54, 54, 54);

            ContentPanel.Controls.Clear();
            d.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(d);
        }

        private void HowPageButton_Click(object sender, EventArgs e)
        {
            MacroPageButton.BackColor = System.Drawing.Color.FromArgb(255, 34, 34, 34);
            HowPageButton.BackColor = System.Drawing.Color.FromArgb(255, 54, 54, 54);

            ContentPanel.Controls.Clear();
            h.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(h);
        }

        public void UpdateMacroConfig()
        {
            if (isEnabled)
            {
                var swordKey = MapKey(d.SwordKey.SelectedItem.ToString());
                var rodKey = MapKey(d.RodKey.SelectedItem.ToString());
                var macroKey = MapKey(d.MacroKey.SelectedItem.ToString());
                var toggleKey = MapKey(d.ToggleKey.SelectedItem.ToString());
                bool backToSword = d.SwordCheck.Checked;

                MacroHandler.UpdateConfiguration(swordKey, rodKey, macroKey, toggleKey, backToSword);
            }
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            isEnabled = !isEnabled;
            UpdateState();

            if (isEnabled)
            {
                try
                {
                    var swordKey = MapKey(d.SwordKey.SelectedItem.ToString());
                    var rodKey = MapKey(d.RodKey.SelectedItem.ToString());
                    var macroKey = MapKey(d.MacroKey.SelectedItem.ToString());
                    var toggleKey = MapKey(d.ToggleKey.SelectedItem.ToString());
                    bool backToSword = d.SwordCheck.Checked;

                    // Pass a callback so the toggle key can trigger the switch button
                    MacroHandler.Configure(swordKey, rodKey, macroKey, toggleKey, backToSword, () => {
                        this.Invoke((MethodInvoker)delegate {
                            Switch_Click(null, EventArgs.Empty);
                        });
                    });

                    MacroHandler.StartListening();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    isEnabled = false;
                    UpdateState();
                }
            }
            else
            {
                MacroHandler.StopListening();
            }
        }

        private void Rodder_FormClosing(object sender, FormClosingEventArgs e)
        {
            // clean shutdown
            MacroHandler.StopListeningCompletely();
        }
    }
}
