using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCompression
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
        FileCompression mobjFileCompression = new FileCompression();

        private void butBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (DlgOpen.ShowDialog(this) == DialogResult.OK)
                {
                    txtFileToZip.Text = DlgOpen.FileName;
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButGZFile_Click(object sender, EventArgs e)
        {

            try
            {
               txtGZFile.Text =  mobjFileCompression.GZipFile(txtFileToZip.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
