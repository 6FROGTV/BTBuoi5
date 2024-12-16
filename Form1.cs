using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                FontStyle style = richText.SelectionFont.Style;
                if (richText.SelectionFont.Bold)
                {
                    // Nếu văn bản đã đậm, xóa thuộc tính Bold ra khỏi FontStyle hiện tại
                    style &= FontStyle.Bold;
                }
                else
                {
                    // Nếu văn bản chưa đậm, thêm thuộc tính Bold vào FontStyle hiện tại
                    style |= FontStyle.Bold;
                }
                richText.SelectionFont = new Font(richText.SelectionFont, style);
            }
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmbFont_Click(object sender, EventArgs e)
        {

            foreach (FontFamily fontFamily in new InstalledFontCollection().Families)
            {
                cmbFont.Items.Add(fontFamily.Name);
            }
            cmbFont.SelectedItem = "Tahoma";
        }

        private void cmbSize_Click(object sender, EventArgs e)
        {
            int[] sizeValues = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            cmbSize.ComboBox.DataSource = sizeValues;
            cmbSize.SelectedItem = 14;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFont.Text = "Tahoma";
            cmbSize.Text = "14";
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cmbFont.Items.Add(font.Name);
            }
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                cmbSize.Items.Add(s);
            }
        }

    }
}
