using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENUISLEMSELLUYGULAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Rich Text Format| *.rtf";
            saveFileDialog1.Filter = "Rich Text Format| *.rtf";

            ////to add fonts
            //List<FontFamily> fonts = FontFamily.Families.ToList();
            //foreach (FontFamily item in fonts)
            //{
            //    toolStripComboBox1.Items.Add(item.Name);
            //}
            //FontFamily activefont = richTextBox1.Font.FontFamily;
            //toolStripComboBox1.SelectedItem = activefont.Name;

            ////to change fontsize (wich i still struggle to do.)
            //float fontsize = richTextBox1.Font.Size;
            //toolStripComboBox2.SelectedItem = fontsize.ToString();
        }
        //to bold

            //save the file
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("The file could not be saved.", "Error." , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            //open a file
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult results = openFileDialog1.ShowDialog();
            if (results == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("The file has been not found.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FontStyle fs = richTextBox1.Font.Style;
            if (fs == FontStyle.Bold)
            {
                kalinbuton.BackColor = SystemColors.Control;
                Font yeni_fnt = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, fs | FontStyle.Regular);
                richTextBox1.Font = yeni_fnt;
            }
            ////Font yeni_fnt = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, fs | FontStyle.Bold);
            ////richTextBox1.Font = yeni_fnt;
            #region
            //if (richTextBox1.SelectedText != "")
            //{
            //    richTextBox1.SelectionFont = yeni_fnt;
            //}
            //else
            //{
            //    richTextBox1.Font = yeni_fnt;
            //}
            #endregion
        }

        private void italikbuton_Click(object sender, EventArgs e)
        {
            FontStyle fs = richTextBox1.Font.Style;
            Font yeni_fnt = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, fs | FontStyle.Italic);
            richTextBox1.Font = yeni_fnt;
            #region
            //if (richTextBox1.SelectedText != "")
            //{
            //    richTextBox1.SelectionFont = yeni_fnt2;
            //}
            //else
            //{
            //    richTextBox1.Font = yeni_fnt2;
            //}
            #endregion
        }

        private void alticizili_Click(object sender, EventArgs e)
        {
            FontStyle fs = richTextBox1.Font.Style;
            Font yeni_fnt = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, fs | FontStyle.Underline);
            richTextBox1.Font = yeni_fnt;
            #region
            //if (richTextBox1.SelectedText != "")
            //{
            //    richTextBox1.SelectionFont = yeni_fnt3;
            //}
            //else
            //{
            //    richTextBox1.Font = yeni_fnt3;
            //}
            #endregion
        }
    }
}
