using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace OnlyFiles
{
    public partial class MainMenu : MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        // Tab Control
        private void metroTabControl_Click(object sender, EventArgs e)
        {
            if (this.metroTabControl1.SelectedTab == metroTabPage1)
            {
                //Main Menu
            }

            if (this.metroTabControl1.SelectedTab == metroTabPage2)
            {
                //Add
            }
            if (this.metroTabControl1.SelectedTab == metroTabPage3)
            {
                //Browse
            }

            if (this.metroTabControl1.SelectedTab == metroTabPage4)
            {
                //Settings
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(Owner, "jotain", "Otsikko");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(Owner, "jotain", "Otsikko");
        }

        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = this.searchBox.Text.ToString();
                MetroMessageBox.Show(Owner, searchText, "Search");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string searchText = this.searchBox.Text.ToString();
            MetroMessageBox.Show(Owner, searchText, "Search");
        }
    }
}
