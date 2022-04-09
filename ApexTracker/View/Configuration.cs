using ApexTracker.Model;
using ApexTracker.Properties;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ApexTracker.View
{
    public partial class Configuration : Form
    {
        Card card;
        Player player = null;

        string platform = null;
        string username = null;

        Thread thread_updatePlayer;

        public Configuration()
        {
            InitializeComponent();
        }

        private async void search()
        {
            while (true)
            {
                if (!String.IsNullOrEmpty(platform) && !String.IsNullOrEmpty(username))
                {
                    player = await new ApexLegends(platform, username).SearchPlayer();

                    if (player != null)
                    {
                        card.lb_username.Invoke((MethodInvoker)delegate { card.lb_username.Text = player.global.name.ToUpper(); });
                        card.lb_points.Invoke((MethodInvoker)delegate { card.lb_points.Text = $"{player.global.rank.rankScore} pts".ToUpper(); });
                        card.pb_rank.Invoke((MethodInvoker)delegate { card.pb_rank.Load(player.global.rank.rankImg); });

                        Settings.Default.username = username;
                        cb_platform.Invoke((MethodInvoker)delegate { Settings.Default.platform = cb_platform.SelectedIndex; });
                        Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show($"{username} from {platform} not found");
                        username = null;
                        platform = null;

                        Settings.Default.username = username;
                        Settings.Default.platform = 0;
                        Settings.Default.Save();
                    }
                }

                btn_search.Invoke((MethodInvoker)delegate { btn_search.Enabled = true; });
                cb_platform.Invoke((MethodInvoker)delegate { cb_platform.Enabled = true; });
                txtb_username.Invoke((MethodInvoker)delegate { txtb_username.Enabled = true; });

                Thread.Sleep(5000);
            }
        }

        private void loadSettings()
        {
            username = Settings.Default.username.ToString();
            platform = cb_platform.Items[Settings.Default.platform].ToString();

            txtb_username.Text = username;
            cb_platform.SelectedIndex = Settings.Default.platform;
            cb_darkMode.Checked = Settings.Default.darkMode;

            colorDialog_viewColor.Color = Settings.Default.color;
            panel_colorPicker.BackColor = Settings.Default.color;
            changeColor();
        }

        private void changeColor()
        {
            Settings.Default.color = colorDialog_viewColor.Color;
            Settings.Default.Save();

            panel_colorPicker.BackColor = colorDialog_viewColor.Color;
            card.lb_points.ForeColor = colorDialog_viewColor.Color;
            card.lb_username.ForeColor = colorDialog_viewColor.Color;
            card.panel_topBar.BackColor = colorDialog_viewColor.Color;
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            card = new Card();
            card.Show();
            loadSettings();
            thread_updatePlayer = new Thread(search);
            thread_updatePlayer.Start();
        }

        private void Configuration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void panel_colorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            if (colorDialog_viewColor.ShowDialog() == DialogResult.OK)
            {
                changeColor();
            }
        }

        private void cb_darkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_darkMode.Checked) { card.panel_container.BackColor = Color.Black; }
            else { card.panel_container.BackColor = Color.White; }

            Settings.Default.darkMode = cb_darkMode.Checked;
            Settings.Default.Save();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            btn_search.Enabled = false;
            cb_platform.Enabled = false;
            txtb_username.Enabled = false;


            if (cb_platform.SelectedIndex >= 0 && !String.IsNullOrEmpty(txtb_username.Text))
            {
                platform = cb_platform.Text;
                username = txtb_username.Text;
            }
        }
    }
}
