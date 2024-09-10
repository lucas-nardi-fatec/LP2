using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PImc
{
    public partial class Form1 : Form
    {

        double peso, altura, IMC;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxAltura.Text = "";
            mskbxPeso.Text = "";
            txtIMC.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(!Double.TryParse(mskbxAltura.Text, out altura) || altura <= 0){
                MessageBox.Show("Insira uma altura válida!");
                mskbxAltura.Text = "";

            } else if (Double.TryParse(mskbxPeso.Text, out peso) && peso > 0){
                IMC = peso / (altura * altura);
                IMC = Math.Round(IMC, 1);
                txtIMC.Text = IMC.ToString();

                if(IMC < 18.5) {
                    MessageBox.Show("O IMC é de " + IMC + ";\nEste valor é classificado como \"Magreza\".");
                    
                } else if (IMC <= 24.9) {
                    MessageBox.Show("O IMC é de " + IMC + ";\nEste valor é classificado como \"Normal\".");

                } else if (IMC <= 29.9){
                    MessageBox.Show("O IMC é de " + IMC + ";\nEste valor é classificado como \"Sobrepeso\".");

                } else if (IMC <= 39.9){
                    MessageBox.Show("O IMC é de " + IMC + ";\nEste valor é classificado como \"Obesidade\".");

                } else {
                    MessageBox.Show("O IMC é de " + IMC + ";\nEste valor é classificado como \"Obesidade Grave\".");

                }

            } else {
                MessageBox.Show("Insira um peso válido!");
                mskbxPeso.Text = "";
                
            }

        }
    }
}
