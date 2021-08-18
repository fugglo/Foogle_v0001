using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interger {
    public partial class Integer : Form {
        string connectionString = @"Server=.\sqlexpress;Database=bdcadastro;Trusted_Connection=True;";
        public Integer()
        {
            InitializeComponent();
        }

        private void Integer_Load(object sender, EventArgs e)
        {

        }

        private void btnFunctionAtualizar(object sender, MouseEventArgs e)
        {


         if (txtNota.Text == string.Empty)
            {
                MessageBox.Show("Campo está vazio");
            }
            else
            {
                string ValidaNota = txtNota.Text;
                string NumeroNota = txtNota.Text;
                ValidaNota = Convert.ToString(ValidaNota.Length);

               if(ValidaNota == "9")
                {
                   MessageBox.Show("UPDATE LOJA_NOTA_FISCAL SET DATA_PARA_TRANSFERENCIA = GETDATE() WHERE NF_NUMERO ='"+NumeroNota+"' AND YEAR(EMISSAO) = YEAR(GETDATE())"+
                                     "AND MONTH(EMISSAO) = MONTH(GETDATE())");
                }
                else
                {
                    MessageBox.Show("Meu filho não e assim , uma nota tem nove numbers qtd len : "+ ValidaNota);
                }
              
            }
            
        }
    }
}
