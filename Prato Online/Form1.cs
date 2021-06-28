using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prato_Online
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Projeto básico Prato Online, Aula - Etec de São Paulo   - Curso Técnico 
        //Jonas Valereo - Técnico em informática 

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            //Declarando o código, buttom Adicionar, váriavel, decisão if

            int seleTeste = lstPratos.FindString(lstIngrediente.SelectedItem.ToString());

            if (seleTeste == -1)
            {
                lstPratos.Items.Add(lstIngrediente.SelectedItem);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //Declarano do código buttom excluir 

            if(lstIngrediente.SelectedIndex >=0 )
            {
                lstPratos.Items.RemoveAt(lstPratos.SelectedIndex);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando limpar tela lstPratos

            lstPratos.Items.Clear();
            chkPlastico.Checked = false;
            chkIsopor.Checked = false;
            chkAluminio.Checked = false;
            chkLocal.Checked = false;
            chkViagem.Checked = false;
            chkSuco.Checked = false;
            chkRefrigerante.Checked = false;
            chkAgua.Checked = false;
          
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            //Declarando condição if, menssage, buttom Novo

            if(MessageBox.Show("Quer outro Prato?", "Prato Online",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lstPratos.Items.Clear();
                
            }
        }

        private void BtnEspecial_Click(object sender, EventArgs e)
        {
            //Declarando o código finalizar prato, buttom Especial

            string espPrato = Microsoft.VisualBasic.Interaction.InputBox("Digite ingrediente",
                "Prato Online", "*", 150, 150);

            {
                lstPratos.Items.Add(espPrato.ToString());
            }
        }

        private void chkLocal_CheckedChanged(object sender, EventArgs e)
        {
            //Declarando código radio buttom chkLocal, condição if 
            if (chkLocal.Checked == true)
            {
                btnFinalizar.Enabled = true;
                chkPlastico.Checked = false;
                chkIsopor.Checked = false;
                chkAluminio.Checked = false;
               

   
            }
            else{
                btnFinalizar.Enabled = false;
               
            }

          
        }

        private void chkViagem_CheckedChanged(object sender, EventArgs e)
        {

            //Declarando código radio buttom chkViagem, condição if 

            if(chkViagem.Checked == true)
            {
                gbrEmbalagem.Enabled = true;

            }
            else
            {
                gbrEmbalagem.Enabled = false;
            }
        }

        private void chkPlastico_CheckedChanged(object sender, EventArgs e)
        {

            //Declarando código radio buttom chkPlastico, condição if 

            btnFinalizar.Enabled = true;

        }

        private void chkIsopor_CheckedChanged(object sender, EventArgs e)
        {
            //Declarando código radio buttom chkIsopor, buttom finalizar

            btnFinalizar.Enabled = true;

        }

        private void chkAluminio_CheckedChanged(object sender, EventArgs e)
        {
            //Declarando código radio buttom chkAluminio, buttom finalizar

            btnFinalizar.Enabled = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //Declarando buttom Finalizar, messagemBox,

            MessageBox.Show("Pedido Realização Com Sucesso", "Messagem", MessageBoxButtons.OK);

           
            //Declarando limpar tela lstPratos, buttons

            lstPratos.Items.Clear();
            chkPlastico.Checked = false;
            chkIsopor.Checked = false;
            chkAluminio.Checked = false;
            chkLocal.Checked = false;
            chkViagem.Checked = false;
            chkSuco.Checked = false;
            chkRefrigerante.Checked = false;
            chkAgua.Checked = false;
             

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Declarando código button sair,  close //

            Close();
        }

            //fim do programa

    }
}
