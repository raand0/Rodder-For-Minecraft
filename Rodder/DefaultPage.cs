using System;
using System.Windows.Forms;

namespace Rodder
{
    public partial class DefaultPage : UserControl
    {
        public DefaultPage()
        {
            InitializeComponent();

            // Load saved config
            LoadConfig();

            ToolTip tool = new ToolTip();
            tool.SetToolTip(label2, "Your minecraft sword hotkey");
            tool.SetToolTip(label3, "Your minecraft rod hotkey");
            tool.SetToolTip(label4, "Hotkey to execute the macro");
            tool.SetToolTip(label1, "Hotkey to enable or disable the program");
            tool.SetToolTip(SwordCheck, "Whether to change back to sword or not");

            // Hook up change events to update configuration on the fly
            SwordKey.SelectedIndexChanged += ComboBox_Changed;
            RodKey.SelectedIndexChanged += ComboBox_Changed;
            MacroKey.SelectedIndexChanged += ComboBox_Changed;
            ToggleKey.SelectedIndexChanged += ComboBox_Changed;
            SwordCheck.CheckedChanged += ComboBox_Changed;
        }

        private void LoadConfig()
        {
            var config = ConfigManager.LoadConfig();

            // Set selections from config
            SwordKey.SelectedItem = config.SwordKey;
            RodKey.SelectedItem = config.RodKey;
            MacroKey.SelectedItem = config.MacroKey;
            ToggleKey.SelectedItem = config.ToggleKey;
            SwordCheck.Checked = config.BackToSword;

            // If items not found, default to first item
            if (SwordKey.SelectedIndex == -1) SwordKey.SelectedIndex = 0;
            if (RodKey.SelectedIndex == -1) RodKey.SelectedIndex = 0;
            if (MacroKey.SelectedIndex == -1) MacroKey.SelectedIndex = 0;
            if (ToggleKey.SelectedIndex == -1) ToggleKey.SelectedIndex = 0;
        }

        public void SaveConfig()
        {
            var config = new MacroConfig
            {
                SwordKey = SwordKey.SelectedItem?.ToString() ?? "A",
                RodKey = RodKey.SelectedItem?.ToString() ?? "A",
                MacroKey = MacroKey.SelectedItem?.ToString() ?? "A",
                ToggleKey = ToggleKey.SelectedItem?.ToString() ?? "NONE",
                BackToSword = SwordCheck.Checked
            };

            ConfigManager.SaveConfig(config);
        }

        private void ComboBox_Changed(object sender, EventArgs e)
        {
            // Save config whenever something changes
            SaveConfig();

            // Update configuration while running
            var form = this.FindForm() as Rodder;
            if (form != null)
            {
                form.UpdateMacroConfig();
            }
        }
    }
}