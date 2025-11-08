using System;
using System.IO;
using Newtonsoft.Json;

namespace Rodder
{
    public class MacroConfig
    {
        public string SwordKey { get; set; }
        public string RodKey { get; set; }
        public string MacroKey { get; set; }
        public string ToggleKey { get; set; }
        public bool BackToSword { get; set; }
    }

    public static class ConfigManager
    {
        private static readonly string ConfigPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Rodder",
            "config.json"
        );

        public static void SaveConfig(MacroConfig config)
        {
            try
            {
                // Create directory if it doesn't exist
                string directory = Path.GetDirectoryName(ConfigPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Serialize and save
                string json = JsonConvert.SerializeObject(config, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(ConfigPath, json);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error saving config: " + ex.Message);
            }
        }

        public static MacroConfig LoadConfig()
        {
            try
            {
                if (File.Exists(ConfigPath))
                {
                    string json = File.ReadAllText(ConfigPath);
                    return JsonConvert.DeserializeObject<MacroConfig>(json);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error loading config: " + ex.Message);
            }

            // Return default config
            return new MacroConfig
            {
                SwordKey = "A",
                RodKey = "A",
                MacroKey = "A",
                ToggleKey = "NONE",
                BackToSword = false
            };
        }
    }
}