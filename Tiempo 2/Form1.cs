using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiempo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Convertir_Click(object sender, EventArgs e)
        {
            int dia;
            int mes;
            int año;
            
            int resultadomess;
            int sumaaño;
            int resultadodia;
            int diacambio;
            
            
            
            
            
            
            
            
            
            

            
            
            
            
            dia= System.Convert.ToInt32(textBox1.Text);
            mes= System.Convert.ToInt32(textBox2.Text);
            año= System.Convert.ToInt32(textBox3.Text);
            resultadomess = System.Convert.ToInt32(textBox2.Text);
            sumaaño = System.Convert.ToInt32(textBox3.Text);
            resultadodia = System.Convert.ToInt32(textBox1.Text);
            
            

            
            diacambio = System.Convert.ToInt32(textBox2.Text);




            if (textBox1.Text == "")
            {
                MessageBox.Show("Error");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Error");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Error");
            }
            if (dia <31)
            {
                resultadodia = dia + 1;

            }

            else if (dia >30)
            {
                resultadomess = mes + 1;



                resultadodia = 1;

                
                
            }
            if (mes >11)
            {
                resultadodia = 1;
                resultadomess = 01;
                sumaaño = año + 1;



            
            }
           








            switch (resultadomess)
            {
                case 01:
                    

                    Resultadomes.Text = "De Enero";

                    break;

                case 02:

                    Resultadomes.Text = "De Febrero";

                    if (dia >= 30)
                    {
                        Resultadomes.Text = "De Marzo";
                        resultadodia = 1;

                    }

                    else if (dia < 30)
                    {
                        Resultadomes.Text = "de Febrero";
                    }

                    break;

                case 03:

                    Resultadomes.Text = "De Marzo";

                    break;

                case 04:
                    if (dia>=30)
                    {
                        Resultadomes.Text = "De Mayo";
                        resultadodia = 1;
                        
                    }

                    else if (dia<30)
                    {
                        Resultadomes.Text = "de Abril";
                    } 

                        
                    
                  

                    break;

                case 05:

                    Resultadomes.Text = "De Mayo";

                    break;

                case 06:
                    Resultadomes.Text = "De junio";

                    if (dia >= 30)
                    {
                        Resultadomes.Text = "De Julio";
                        resultadodia = 1;

                    }

                    else if (dia < 30)
                    {
                        Resultadomes.Text = "de Junio";
                    }

                    break;

                case 07:

                    Resultadomes.Text = "De Julio";

                   

                    break;

                case 08:

                    Resultadomes.Text = "De Agosto";

                   
                    

                    break;

                case 09:

                    Resultadomes.Text = "De septiembre";

                    if (dia >= 30)
                    {
                        Resultadomes.Text = "De Octubre";
                        resultadodia = 1;

                    }

                    else if (dia < 30)
                    {
                        Resultadomes.Text = "de Septiembre";
                    }

                    break;

                case 10:

                    Resultadomes.Text = "De Octubre";

                   

                    break;

                case 11:

                    Resultadomes.Text = "De Noviembre";

                    if (dia >= 30)
                    {
                        Resultadomes.Text = "De Diciembre";
                        resultadodia = 1;

                    }

                    else if (dia < 30)
                    {
                        Resultadomes.Text = "De Noviembre";
                    }

                    break;

                case 12:

                    Resultadomes.Text = "De Diciembre";



                    break;

                    


            }
            
            Resultadoaño.Text = System.Convert.ToString(sumaaño);
            Resultadodia.Text = System.Convert.ToString(resultadodia);

            













        }

        private void Resultadodia_Click(object sender, EventArgs e)
        {

        }

        private void Resultadomes_Click(object sender, EventArgs e)
        {

        }

        private void Resultadoaño_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
