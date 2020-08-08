using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace LeetCode_Checker
{
    public partial class Menu : Form
    {
        public static List<LeetCode> leetCodeClass = new List<LeetCode>();
        public static List<LeetCode> leetCodeShow = new List<LeetCode>();

        private int ind = 0;

        private int countSolved = 0;
        private int countUnsolved = 0;

        public class LeetCode
        {
            
            private string number = "";
            private string name = "";
            private string url = "";
            private string checker = "";
            private int index = 0;

            public string Number
            {
                get { return number; }
                set { number = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Url
            {
                get { return url; }
                set { url = value; }
            }
            public string Checker
            {
                get { return checker; }
                set { checker = value; }
            }

            public int Index
            {
                get { return index; }
                set { index = value; }
            }
        }


        private static string filePath = @"C:\LeetCode\Questions.txt";



        public Menu()
        {
            InitializeComponent();

            btOK.Enabled = false;
            tbQuestionNumber.MaxLength = 4;
            tbFind.MaxLength = 4;
            tbQuestionNumber.Select();
            tbLink.KeyPress += TextBox2_KeyPress;

            if (!Directory.Exists(@"C:\LeetCode"))
            {
                Directory.CreateDirectory(@"C:\LeetCode");
            }

            if (!File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);
                fs.Close();
            }

            if (!File.Exists(@"C:\LeetCode\QuestionsClone.txt"))
            {
                FileStream fs = File.Create(@"C:\LeetCode\QuestionsClone.txt");
                fs.Close();
                File.Copy(filePath, @"C:\LeetCode\QuestionsClone.txt", true);
            }
            else
            {
                File.Copy(filePath, @"C:\LeetCode\QuestionsClone.txt", true);
            }

            loadQuestions();
            disPlayQuestions();


            if (!File.Exists(@"C:\LeetCode\Register.txt"))
            {
                FileStream fs = File.Create(@"C:\LeetCode\Register.txt");
                fs.Close();
                StreamWriter registerCode = new StreamWriter(@"C:\LeetCode\Register.txt");
                registerCode.WriteLine("0");
                registerCode.Close();

                RegistryKey reg = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                reg.SetValue("Chau's LeetCode Checher", Application.ExecutablePath.ToString());
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                EnterKeyPress();

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                AddQuestion();
        }

        private void EnterKeyPress()
        {
            for (int i = 0; i < leetCodeClass.Count; i++)
            {
                if (tbQuestionNumber.Text == leetCodeClass[i].Number)
                {
                    DialogResult res = MessageBox.Show("This Question Number Is Already Added!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbQuestionNumber.Select();
                    return;
                }
            }
            if (tbQuestionNumber.TextLength == 0 || tbQuestionName.TextLength == 0 || tbLink.TextLength == 0)
            {
                DialogResult res = MessageBox.Show("You Need to Fill All Properties?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbQuestionNumber.Select();
            }
            else
            {
                LeetCode leetcode = new LeetCode();

                leetcode.Number = tbQuestionNumber.Text;
                leetcode.Name = tbQuestionName.Text;
                leetcode.Url = tbLink.Text;

                if (cbSolved.Checked)
                {
                    leetcode.Checker = "Yes";
                }
                else
                {
                    leetcode.Checker = "No";
                }

                int indexes = leetCodeClass.Count;
                leetcode.Index = indexes;
                string leet = "";

                if (!cbSolved.Checked)
                {
                    leet = "No           " + tbQuestionNumber.Text + "           " + tbQuestionName.Text;
                    lbQuestionBox.Items.Add(leet);
                }
                else
                {
                    leet = "Yes           " + tbQuestionNumber.Text + "           " + tbQuestionName.Text;
                    lbQuestionBox.Items.Add(leet);
                }

                tbQuestionName.Clear();
                tbQuestionNumber.Clear();
                tbQuestionNumber.Select();
                tbLink.Clear();
                cbSolved.Checked = false;

                leetCodeClass.Add(leetcode);

                WriteToFile(1);
            }
        }

        public void WriteToFile(int check)
        {
            StreamWriter leetWrite = new StreamWriter(filePath);
            for (int i = 0; i < leetCodeClass.Count; i++)
            {
                leetWrite.WriteLine(leetCodeClass[i].Number);
                leetWrite.WriteLine(leetCodeClass[i].Name);
                leetWrite.WriteLine(leetCodeClass[i].Url);
                leetWrite.WriteLine(leetCodeClass[i].Checker);
                leetWrite.WriteLine(leetCodeClass[i].Index);
            }

            leetWrite.Close();

            if (check == 1)
            {
                if (!File.Exists(@"C:\LeetCode\QuestionsClone.txt"))
                {
                    FileStream fs = File.Create(@"C:\LeetCode\QuestionsClone.txt");
                    fs.Close();
                    File.Copy(filePath, @"C:\LeetCode\QuestionsClone.txt", true);
                }
                else
                {
                    File.Copy(filePath, @"C:\LeetCode\QuestionsClone.txt", true);
                }
            }
        }


        public void loadQuestions()
        {
            if (File.Exists(filePath))
            {
                StreamReader questionRead = new StreamReader(filePath);

                while (!questionRead.EndOfStream)
                {
                    LeetCode leetcode = new LeetCode();
                   
                    string number = questionRead.ReadLine();
                    leetcode.Number = number;
                    string name = questionRead.ReadLine();
                    leetcode.Name = name;
                    string url = questionRead.ReadLine();
                    leetcode.Url = url;
                    string checker = questionRead.ReadLine();
                    leetcode.Checker = checker;
                    int index = int.Parse(questionRead.ReadLine());
                    leetcode.Index = index;
                    leetCodeClass.Add(leetcode);
                    leetCodeShow.Add(leetcode);
                }

                questionRead.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAddQuestions_Click(object sender, EventArgs e)
        {
            AddQuestion();
        }


        public void AddQuestion()
        {
            for (int i = 0; i < leetCodeClass.Count; i++)
            {
                if (tbQuestionNumber.Text == leetCodeClass[i].Number)
                {
                    MessageBox.Show("This Question Number Is Already Added!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbQuestionNumber.Select();
                    return;
                }
            }

            if (tbQuestionNumber.TextLength == 0 || tbQuestionName.TextLength == 0 || tbLink.TextLength == 0)
            {
                MessageBox.Show("You Need to Fill All Properties?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbQuestionNumber.Select();
            }
            else
                EnterKeyPress();
        }

        private void btGoQuestion_Click(object sender, EventArgs e)
        {
            if (lbQuestionBox.SelectedItems.Count > 1)
            {
                DialogResult res = MessageBox.Show("You Open Multiple Questions At The Same Time!", "OOPPP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lbQuestionBox.SelectedItem != null)
            {
                string editItem = lbQuestionBox.SelectedItem.ToString();
                Regex r = new Regex(" +");
                string[] item = r.Split(editItem);

                string url = "";

                for (int i = 0; i < leetCodeClass.Count; i++)
                {
                    if (item[1].ToString() == leetCodeClass[i].Number)
                    {
                        url = leetCodeClass[i].Url.ToString();
                        break;
                    }
                }

                try
                {
                    Process.Start(url);
                }
                catch
                {
                    MessageBox.Show("InValid URL", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("You Did Not Select Any Question!", "OOPPP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbQuestionNumber.Select();
            }
        }

        private void btDelAll_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to remove all questions?", "Remove All", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if(res == DialogResult.Yes)
            {
                leetCodeClass.Clear();
                leetCodeShow.Clear();
                WriteToFile(0);
                loadQuestions();
                disPlayQuestions();
            }
        
        }

        private void tbLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void btFind_Click(object sender, EventArgs e)
        {
            FindQuestion();
        }

        private void FindQuestion()
        {
            for (int i = 0; i < leetCodeClass.Count; i++)
            {
                if (tbFind.Text == leetCodeClass[i].Number)
                {
                    lbQuestionBox.SetSelected(i, true);
                    tbFind.Clear();
                    tbQuestionNumber.Select();
                    return;
                }
            }
            MessageBox.Show("Can't Find The Question!", "Oh-Oh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbFind.Clear();
            tbQuestionNumber.Select();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == DialogResult.Yes)
            {
                Dispose(true);
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = MessageBox.Show("Do you want to quit?", "Quit...", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            return res;
        }

        private void btDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (lbQuestionBox.SelectedItems.Count > 1)
            {
                DialogResult res = MessageBox.Show("You Can't Delete Multiple Questions At The Same Time!", "OOPPP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lbQuestionBox.SelectedItem != null)
            {
                DialogResult res = MessageBox.Show("Do you want to remove this question?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (res == DialogResult.Yes)
                {
                    string editItem = lbQuestionBox.SelectedItem.ToString();
                    Regex r = new Regex(" +");
                    string[] item = r.Split(editItem);

                    for (int i = 0; i < leetCodeClass.Count; i++)
                    {
                        if (int.Parse(item[1]) == int.Parse(leetCodeClass[i].Number))
                        {
                            leetCodeClass.RemoveAt(i);
                            break;
                        }

                    }

                    WriteToFile(0);
                    leetCodeShow.Clear();
                    leetCodeClass.Clear();
                    loadQuestions();

                    disPlayQuestions();
                }
                tbQuestionNumber.Select();
            }
            else
            {
                DialogResult res = MessageBox.Show("You Did Not Select Any Question!", "OOPPP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbQuestionNumber.Select();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        public void disPlayQuestions()
        {
            lbQuestionBox.Items.Clear();
            countSolved = 0;
            countUnsolved = 0;
            for (int i = 0; i < leetCodeShow.Count; i++)
            {
                int num = int.Parse(leetCodeShow[i].Number);
                string leet = "";

                if(num >= 10 && num < 100)
                {
                    leet = leetCodeShow[i].Checker.PadRight(10) + leetCodeShow[i].Number.PadRight(19) + leetCodeShow[i].Name;
                }
                else if(num >= 100 && num < 1000)
                {
                    leet = leetCodeShow[i].Checker.PadRight(10) + leetCodeShow[i].Number.PadRight(18) + leetCodeShow[i].Name;
                }
                else if(num >= 1000)
                {
                    leet = leetCodeShow[i].Checker.PadRight(10) + leetCodeShow[i].Number.PadRight(17) + leetCodeShow[i].Name;
                }
                else
                {
                    leet = leetCodeShow[i].Checker.PadRight(10) + leetCodeShow[i].Number.PadRight(20) + leetCodeShow[i].Name;
                }

                lbQuestionBox.Items.Add(leet);

                if(leetCodeShow[i].Checker == "Yes")
                {
                    countSolved++;
                }
                else
                {
                    countUnsolved++;
                }
            }

            lbNoti.Text = "Total Question: " + (countSolved + countUnsolved).ToString() + "  |  Solved: " + countSolved.ToString() + "   |   Unsolved: " + countUnsolved.ToString();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            tbQuestionNumber.Enabled = false;
            btClear.Enabled = true;
            btOK.Enabled = true;

            if (lbQuestionBox.SelectedItems.Count > 1)
            {
                DialogResult res = MessageBox.Show("You Can't Edit Multiple Questions At The Same Time!", "OOPPP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if(lbQuestionBox.SelectedItem != null)
            {
                string editItem = lbQuestionBox.SelectedItem.ToString();
                Regex r = new Regex(" +");
                string[] item = r.Split(editItem);

                string name = "";
                for(int i = 2; i < item.Length; i++)
                {
                    name += item[i] + " ";
                }

                tbQuestionNumber.Text = item[1].ToString();
                tbQuestionName.Text = name;

                if (item[0] == "Yes")
                {
                    cbSolved.Checked = true;
                }
                else
                {
                    cbSolved.Checked = false;
                }

                for (int i = 0; i < leetCodeClass.Count; i++)
                {
                    if (int.Parse(item[1]) == int.Parse(leetCodeClass[i].Number))
                    {
                        tbLink.Text = leetCodeClass[i].Url.ToString();
                        ind = i;
                        break;
                    }
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("You Did Not Select Any Question!", "OOPPP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbQuestionNumber.Select();
            }
    
        }

        private void EnterKeyPress(int i)
        {
            if (tbQuestionNumber.TextLength == 0 || tbQuestionName.TextLength == 0 || tbLink.TextLength == 0)
            {
                DialogResult res = MessageBox.Show("You Need to Fill All Properties?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbQuestionNumber.Select();
            }
            else
            {
                leetCodeClass[i].Name = tbQuestionName.Text;
                leetCodeClass[i].Number = tbQuestionNumber.Text;
                leetCodeClass[i].Url = tbLink.Text;

                if (cbSolved.Checked)
                {
                    leetCodeClass[i].Checker = "Yes";
                }
                else
                {
                    leetCodeClass[i].Checker = "No";
                }

                leetCodeClass[i].Index = i;

                tbQuestionName.Clear();
                tbQuestionNumber.Clear();
                tbQuestionNumber.Select();
                tbLink.Clear();
                cbSolved.Checked = false;


                WriteToFile(1);
                leetCodeShow.Clear();
                leetCodeClass.Clear();
                loadQuestions();

                disPlayQuestions();
            }
    
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if(res == DialogResult.Yes)
            {
                tbLink.Clear();
                tbQuestionName.Clear();
                tbQuestionNumber.Clear();
                cbSolved.Checked = false;
                tbQuestionNumber.Select();
                tbFind.Clear();
                tbQuestionNumber.Enabled = true;

                for (int i = 0; i < leetCodeClass.Count; i++)
                {         
                    lbQuestionBox.SetSelected(i, false);
                }
            }    
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (tbQuestionNumber.TextLength == 0 || tbQuestionName.TextLength == 0 || tbLink.TextLength == 0)
            {
                DialogResult res = MessageBox.Show("You Did Not Fill In All Properties", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult res = MessageBox.Show("Are You Sure?", "Change", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (res == DialogResult.Yes)
                    EnterKeyPress(ind);
                else
                {

                    for (int j = 0; j < leetCodeClass.Count; j++)
                    {
                        lbQuestionBox.SetSelected(j, false);
                        tbLink.Clear();
                        tbQuestionName.Clear();
                        tbQuestionNumber.Clear();
                        cbSolved.Checked = false;
                        tbQuestionNumber.Select();
                        tbFind.Clear();
                    }

                }
            }
            tbQuestionNumber.Enabled = true;
        }

        private void btGotoDocument_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.google.com/document/d/1V0V0fFCWXVtcN_n1BKh1JUp4IDKxHlB7UxPu_i4-sVQ/edit");
            tbQuestionNumber.Select();
        }

        private void tbQuestionNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btGetBackQuestions_Click(object sender, EventArgs e)
        {
            DialogResult res1 = MessageBox.Show("Are You Sure?", "Restore Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(res1 == DialogResult.Yes)
            {
                if (File.Exists(@"C:\LeetCode\QuestionsClone.txt") && File.Exists(@"C:\LeetCode\Questions.txt"))
                {
                    File.Copy(@"C:\LeetCode\QuestionsClone.txt", filePath, true);
                    leetCodeShow.Clear();
                    leetCodeClass.Clear();
                    loadQuestions();

                    disPlayQuestions();
                }
                else
                {
                    DialogResult res = MessageBox.Show("Sorry, You Lost It!!", "OH-NO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btSolved_Click(object sender, EventArgs e)
        {
            lbQuestionBox.SelectionMode = SelectionMode.MultiSimple;
            for (int i = 0; i < leetCodeClass.Count; i++)
            {
                if (leetCodeClass[i].Checker == "Yes")
                {
                    lbQuestionBox.SetSelected(i, true);
                }
            }

            tbFind.Clear();
            tbQuestionNumber.Select();
        }

        private void btUnSolved_Click(object sender, EventArgs e)
        {
            lbQuestionBox.SelectionMode = SelectionMode.MultiSimple;
            for (int i = 0; i < leetCodeClass.Count; i++)
            {
                if (leetCodeClass[i].Checker == "No")
                {
                    lbQuestionBox.SetSelected(i, true);
                }
            }
           
            tbFind.Clear();
            tbQuestionNumber.Select();
        }

        private void btPickRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            List<LeetCode> randomly = new List<LeetCode>();

            for(int i = 0; i < leetCodeClass.Count; i++)
            {
                if(leetCodeClass[i].Checker == "No")
                {
                    randomly.Add(leetCodeClass[i]);
                }
            }

            int randomQuestion = rand.Next(randomly.Count);

            string temp = randomly[randomQuestion].Number;


            for(int k = 0; k < leetCodeShow.Count; k++)
            {
                if(leetCodeShow[k].Number == temp)
                {
                    lbQuestionBox.SetSelected(k, true);
                    break;
                }
            }

            tbFind.Clear();
            tbQuestionNumber.Select();

        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
