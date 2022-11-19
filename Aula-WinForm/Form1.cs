using System.IO;

namespace Aula_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxJanela_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(); 
        }



        private void saveOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string caminho = saveFileDialog1.FileName;
            File.WriteAllText(caminho, textBoxJanela.Text);

            if(caminho != null && textBoxJanela.Text != null)
            {

            }
        }
    }
}