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
using System.Xml;
using System.Xml.Serialization;


namespace San11Helper
{
    public partial class Form1 : Form
    {
        static Nation currentNation = null;

        static List<Skill> skills = new List<Skill>();

        int onceCount = 24, dimensionStart = 48;


        public Form1()
        {
            InitializeComponent();

            
            // init saved nation
        }


        void loadSkills()
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = @".",
                Title = "請選擇skills檔案",
                Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
            };
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                skills.Clear();

                if (Path.GetExtension(ofd.FileName) == ".skill")
                    foreach (string line in File.ReadLines(ofd.FileName))
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length > 2)
                            skills.Add(new Skill(parts[2], parts[3], (SkillRank)int.Parse(parts[5])));
                    }
                else
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Skill>));
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                    skills = (List<Skill>)serializer.Deserialize(fs);
                    fs.Close();
                }
            }
        }

        void showEditSkillsUI()
        {
            BindingList<Skill> bindingSkills = new BindingList<Skill>(skills);
            BindingSource bs = new BindingSource(bindingSkills, null);
            dataGridView1.DataSource = bs;

            DataGridViewComboBoxColumn rankColumn = new DataGridViewComboBoxColumn();
            rankColumn.DataSource = Enum.GetValues(typeof(SkillRank)).Cast<SkillRank>();
            rankColumn.DataPropertyName = "Rank";
            dataGridView1.Columns.Insert(3, rankColumn);


            DataGridViewComboBoxColumn typeColumn = new DataGridViewComboBoxColumn();
            typeColumn.DataSource = Enum.GetValues(typeof(SkillType)).Cast<SkillType>();
            typeColumn.DataPropertyName = "Type";
            dataGridView1.Columns.Insert(5, typeColumn);
        }

        void saveSkills()
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = @".",
                Title = "請選擇skills儲存地方",
                Filter = "xml files (*.xml)|*.xml"
            };
            

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Skill>));
                serializer.Serialize(fs, skills);
                fs.Close();
            }
        }

        void loadGeneral(string dimensionPath, string skillPath)
        {
            if (currentNation == null)
                return;

            currentNation.Generals.Clear();


            List<List<int>> dimensionList = new List<List<int>>(onceCount);
            for (int i = 0; i < onceCount; ++i)
                dimensionList[i] = new List<int>(5);
            
            IEnumerator<string> dimensionLines = File.ReadLines(dimensionPath).GetEnumerator();
            // skip
            for (int i = 0; i < dimensionStart; ++i) dimensionLines.MoveNext();

            for (int j = 0; j < 5; ++j)
            {
                for (int i = 0; i < onceCount; ++j)
                {
                    dimensionLines.MoveNext();
                    dimensionList[i][j] = int.Parse(dimensionLines.Current);
                }
            }
            
            
            IEnumerator<string> skillLines = File.ReadLines(skillPath).GetEnumerator();
            List<General> generals = new List<General>();

            for (int i = 0; i < onceCount; ++i)
            {
                // unexcepted situaction
                if (!skillLines.MoveNext())
                    return;
                string name = skillLines.Current;

                // unexpected situation
                if (!skillLines.MoveNext())
                    return;
                string skill = skillLines.Current;

                generals.Add(new General()
                {
                    Name = name,
                    Skill = skill,
                    Dimensions = new List<int>(dimensionList[i])
                });
            }
        }

        private void genaralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd0 = new OpenFileDialog()
            {

                InitialDirectory = @".",
                Title = "請選擇武將四維之txt"
            };

            OpenFileDialog ofd1 = new OpenFileDialog()
            {
                InitialDirectory = @".",
                Title = "請選擇武將特技之txt"
            };

            if (ofd0.ShowDialog() == DialogResult.OK && ofd1.ShowDialog() == DialogResult.OK)
            {
                loadGeneral(ofd0.FileName, ofd1.FileName);
            }
        }

        private void loadSkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if skills exist

            // init skill list
            //string skillPath = "skills.skill";
            loadSkills();
        }

        private void editSkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showEditSkillsUI();
        }

        private void saveSkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSkills();
        }

        private void nationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = @".",
                Title = "請選擇國家之icon"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image icon = Image.FromFile(ofd.FileName);
                ToolStripItem tsi = nationMenuStrip.Items.Add(icon);

                currentNation = new Nation(icon);
            }
        }
    }
}
