using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace San11Helper
{
    public partial class Form1 : Form
    {
        public List<string> skills = new List<string>();
        static Nation currentNation = null;

        public Form1()
        {
            InitializeComponent();


            // init skill list
            string skillPath = "skills.skill";
            loadSkills(skillPath);
        }


        void loadSkills(string path)
        {
            skills.Clear();

            foreach (string line in File.ReadLines(path))
            {
                string[] parts = line.Split(',');
                if (parts.Length > 2)
                    skills.Add(parts[2]);
            }
        }

        private void nationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @".";
            ofd.Title = "請選擇國家之icon";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image icon = Image.FromFile(ofd.FileName);
                ToolStripItem tsi = nationMenuStrip.Items.Add(icon);

                currentNation = new Nation(icon);
            }
        }
    }
}
