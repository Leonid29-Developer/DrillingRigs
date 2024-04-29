using System;
using System.Windows.Forms;

namespace DrillingRigs
{
    public partial class PDF_Register : Form
    {
        public PDF_Register() => InitializeComponent();

        private void Button_Path_Register_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog File = new OpenFileDialog())
            {
                File.Filter = "Документ PDF|*.pdf";
                File.RestoreDirectory = true;

                if (File.ShowDialog() == DialogResult.OK)
                    Label_Path.Text = File.FileName;
            }
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            Docks.DockName = TB_Name.Text;
            Docks.DockPath = Label_Path.Text;
            DialogResult = DialogResult.OK; Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        => Close();
    }
}