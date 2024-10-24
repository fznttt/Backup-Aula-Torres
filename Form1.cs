using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resposta = openFileDialog1.ShowDialog();
            //armazena o arquivo na memoria
            StreamReader sr = null;
            try
            {
                //tenta executar o codigo do TRY
                if(resposta ==DialogResult.OK && openFileDialog1.FileName.Length > 0)
                {
                    sr = new StreamReader(openFileDialog1.FileName);
                    //textBox1.Text = sr.ReadToEnd(); //le o arquivo ate o fim
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
            catch (ReadOnlyException E)
            {

            }
            catch (Exception ex)
            {
                //se der erro executa o código da EXCEPTION correspondente
            }
            finally
            {
                //sempre finaliza execultando este codigo, independentemente se deu erro ou não
                sr.Close(); //fecha o arquivo independentemente da treta
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
