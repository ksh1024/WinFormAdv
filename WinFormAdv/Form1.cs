using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAdv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 끝내ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "새로 만들기 메뉴를 선택했습니다.";
        }

        private void 도움말보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bing.com/search?q=windows%ec%9d%98+%eb%a9%94%eb%aa%a8%ec%9e%a5%ec%97%90+%eb%8c%80%ed%95%9c+%eb%8f%84%ec%9b%80%eb%a7%90+%eb%b3%b4%ea%b8%b0&filters=guid:%224466414-ko-dia%22%20lang:%22ko%22&form=T00032&ocid=HelpPane-BingIA");
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                textBox1.Text = System.IO.File.ReadAllText(fileName);
            }
        }
    }
}
