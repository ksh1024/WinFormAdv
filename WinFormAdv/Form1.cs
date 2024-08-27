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
        public static int PROGRESS_BAR_STEP= 10;
        private string currentFilePath = string.Empty;

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
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = System.IO.File.ReadAllText(ofd.FileName);
            }
        }

        private void 확대하기축소하기기본값복원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 50;
        }

        private void 확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(toolStripProgressBar1.Value + PROGRESS_BAR_STEP >= 100)
            {
                toolStripProgressBar1.Value = 100;
            }
            else
                toolStripProgressBar1.Value += PROGRESS_BAR_STEP;
        }

        private void 축소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value < PROGRESS_BAR_STEP)
            {
                toolStripProgressBar1.Value = 0;
            }
            else
                toolStripProgressBar1.Value -= PROGRESS_BAR_STEP;
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                System.IO.File.WriteAllText(currentFilePath, textBox1.Text);
                toolStripStatusLabelFilename.Text = $"파일이 저장되었습니다: {currentFilePath}";
            }
            else
            {
                다른이름으로저장ToolStripMenuItem_Click(sender, e);
            }
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, textBox1.Text);
                currentFilePath = sfd.FileName;
                toolStripStatusLabelFilename.Text = $"파일이 저장되었습니다: {currentFilePath}";
            }
        }

        private void toolStripStatusLabelFilename_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                MessageBox.Show($"현재 파일명: {System.IO.Path.GetFileName(currentFilePath)}", "파일명 정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("저장된 파일이 없습니다.", "파일명 정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
