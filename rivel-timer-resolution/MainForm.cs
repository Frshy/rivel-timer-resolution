using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rivel_timer_resolution {
    public partial class MainForm : MaterialForm {
        [DllImport("ntdll.dll", SetLastError = true)]
        static extern int NtSetTimerResolution(int DesiredResolution, bool SetResolution, out int CurrentResolution);

        [DllImport("ntdll.dll", SetLastError = true)]
        static extern int NtQueryTimerResolution(out int MaximumResolution, out int MinimumResolution, out int CurrentResolution);

        public readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        private static int minimumResolution;
        private static int maximumResolution;
        private static int currentResolution;
        private static int defaultResolution;

        private static MainForm instance;

        void loadConfig() {
            if (File.Exists("config.json")) {
                string configText = File.ReadAllText("config.json");
                JObject config = JObject.Parse(configText);
                darkThemeCheck.Checked = Convert.ToBoolean(config.GetValue("DarkTheme"));
                lowerAtLaunchCheck.Checked = Convert.ToBoolean(config.GetValue("LowerAtLaunch"));
            }
        }

        public MainForm() {

            InitializeComponent();
            instance = this;


            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = darkThemeCheck.Checked ? MaterialSkin.MaterialSkinManager.Themes.DARK : MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple600, MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Purple300, MaterialSkin.Accent.Purple400, MaterialSkin.TextShade.WHITE);

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.MaximizeBox = false;

            loadConfig();

            lowerTrBtn.Checked = lowerAtLaunchCheck.Checked;

            init();
        }

        static MainForm get() {
            return instance;
        }

        static void init() {
            NtQueryTimerResolution(out maximumResolution, out minimumResolution, out currentResolution);
            defaultResolution = currentResolution;
            MainForm.get().actualResolutionLbl.Text = "Actual resolution: " + convertFromRes(currentResolution).ToString() + "ms";
            MainForm.get().minResolutionLbl.Text = "Minimum resolution: " + convertFromRes(minimumResolution).ToString() + "ms";
            MainForm.get().maxResolutionLbl.Text = "Maximum resolution: " + convertFromRes(maximumResolution).ToString() + "ms";

            if (MainForm.get().lowerTrBtn.Checked) {
                set(minimumResolution);
            }
        }

        static int convertToRes(float res) {
            return (int)(res * 10000);
        }

        static float convertFromRes(int res) {
            return ((float)res / 10000);
        }

        static void set(int res) {
            int uselessProlly = 0;
            NtSetTimerResolution(res, true, out uselessProlly);
            MainForm.get().actualResolutionLbl.Text = "Actual resolution: " + convertFromRes(res).ToString() + "ms";
        }

        private void authorLbl_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/frshy/rivel-timer-resolution");
        }

        private void lowerTrBtn_CheckedChanged(object sender, EventArgs e) {
            set(lowerTrBtn.Checked ? minimumResolution : defaultResolution);
        }

        private void darkThemeCheck_CheckedChanged(object sender, EventArgs e) {
            materialSkinManager.Theme = darkThemeCheck.Checked ? MaterialSkin.MaterialSkinManager.Themes.DARK : MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void hideInTrayBtn_Click(object sender, EventArgs e) {
            ShowInTaskbar = false;
            notifyIcon.Visible = true;
        }

        private void MainWindow_Closing(object sender, FormClosingEventArgs e) {
            CultureInfo ci = CultureInfo.CurrentCulture;
            JObject config = new JObject(
                new JProperty("DarkTheme", darkThemeCheck.Checked),
                new JProperty("LowerAtLaunch", lowerAtLaunchCheck.Checked)
            );

            string newConfig = JsonConvert.SerializeObject(config);
            File.WriteAllText("config.json", newConfig);
            return;
        }
    }
}
