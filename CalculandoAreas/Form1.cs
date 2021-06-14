using System;
using System.Windows.Forms;

namespace CalculandoAreas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region metodos limpar formularios
        private void btnLimparQuadrado_Click(object sender, EventArgs e)
        {
            txtLadoQuadrado.Text = string.Empty;
            txtResultadoQuadrado.Text = string.Empty;
        }

        private void btnLimparRetangulo_Click(object sender, EventArgs e)
        {
            txtBaseRetangulo.Text = string.Empty;
            txtAlturaRetangulo.Text = string.Empty;
            txtResultadoRetangulo.Text = string.Empty;
        }

        private void btnLimparTriangulo_Click(object sender, EventArgs e)
        {
            txtBaseTriangulo.Text = string.Empty;
            txtAlturaTriangulo.Text = string.Empty;
            txtResultadoTriangulo.Text = string.Empty;
        }

        private void btnLimparEsfera_Click(object sender, EventArgs e)
        {
            txtRaioDaEsfera.Text = string.Empty;
            txtResultadoDaEsfera.Text = string.Empty;
        }

        private void btnLimparCilindro_Click(object sender, EventArgs e)
        {
            txtRaioDoCilindro.Text = string.Empty;
            txtAlturaDoCilindro.Text = string.Empty;
            txtResultadoCilindro.Text = string.Empty;
        }

        private void btnLimparPiramide_Click(object sender, EventArgs e)
        {
            txtBaseDaPiramide.Text = string.Empty;
            txtAlturaPiramide.Text = string.Empty;
            txtResultadoPiramide.Text = string.Empty;
        }
        #endregion


        #region Funções com os calculos da área e do volume
        private void btnCalcularQuadrado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLadoQuadrado.Text))
            {
                MessageBox.Show("Informe o valor do lado do quadrado.", "LADO QUADRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                // Duas formas para fazer o mesmo calculo usando a biblioteca MATH e outra sem usar a biblioteca MATH.
                double lado = Convert.ToDouble(txtLadoQuadrado.Text);

                //txtResultadoQuadrado.Text = Convert.ToDouble(lado * lado).ToString("0,00");
                txtResultadoQuadrado.Text = Math.Pow(lado,2).ToString("n2");//N2 usado para formatação dos numeros.
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no calculo da área", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLadoQuadrado.Focus();
            }
        }

        private void btnCalcularRetangulo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBaseRetangulo.Text) && string.IsNullOrEmpty(txtAlturaRetangulo.Text))
            {
                MessageBox.Show("Informe o valor da Base e da Altura do retângulo", "BASE/ALTURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                try
                {
                    double baseRetangulo = Convert.ToDouble(txtBaseRetangulo.Text);
                    double alturaRetangulo = Convert.ToDouble(txtAlturaRetangulo.Text);
                    txtResultadoRetangulo.Text = Convert.ToDouble(baseRetangulo * alturaRetangulo).ToString("n2");

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro no calculo da área", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }   
        }

        private void btnCalcularTriangulo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBaseTriangulo.Text) && string.IsNullOrEmpty(txtAlturaTriangulo.Text))
            {
                MessageBox.Show("Informe o valor da Base e da Altura do triângulo", "BASE / ALTURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                double baseTriangulo = Convert.ToDouble(txtBaseTriangulo.Text);
                double alturaTriangulo = Convert.ToDouble(txtAlturaTriangulo.Text);
                txtResultadoTriangulo.Text = Convert.ToDouble((baseTriangulo * alturaTriangulo) / 2).ToString("n2");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no calculo da área", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCalcularEsfera_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRaioDaEsfera.Text))
            {
                MessageBox.Show("Informe o valor do raio da esfera.", "RAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                // Duas formas para fazer o mesmo calculo usando a biblioteca MATH e outra sem usar a biblioteca MATH.
                double raio = Convert.ToDouble(txtRaioDaEsfera.Text);

                //txtResultadoDaEsfera.Text = Convert.ToDouble((4 * PI * raio * raio * raio) / 3).ToString("0,00");
                txtResultadoDaEsfera.Text = (4 * Math.PI * Math.Pow(raio, 3) /3).ToString("n2");
                
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no calculo do volume", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcularCilindro_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtRaioDoCilindro.Text) && string.IsNullOrEmpty(txtAlturaDoCilindro.Text))
            {
                MessageBox.Show("Informe o valor do raio e da altura do cilindro.", "RAIO/ALTURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                // Duas formas para fazer o mesmo calculo usando a biblioteca MATH e outra sem usar a biblioteca MATH.
                // Usando a biblioteca MATH não preciso declara a variavel PI pois ela já existe na biblioteca por isso a variavel PI esta comentada ela e usada somente no calculo que esta comentado.

                double raioCilindro = Convert.ToDouble(txtRaioDoCilindro.Text);
                double alturaCilindro = Convert.ToDouble(txtAlturaDoCilindro.Text);
                //double PI = 3.14;
                //txtResultadoCilindro.Text = Convert.ToDouble(PI * raioCilindro * raioCilindro * alturaCilindro).ToString("0,00");
                txtResultadoCilindro.Text = (Math.PI * Math.Pow(raioCilindro, 2) * alturaCilindro).ToString("n2");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no calculo do volume do cilindro.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcularPiramide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBaseDaPiramide.Text) && string.IsNullOrEmpty(txtAlturaPiramide.Text))
            {
                MessageBox.Show("Informe o valor da base e da altura da pirâmide.", "BASE/ALTURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                // Duas formas para fazer o mesmo calculo usando a biblioteca MATH e outra sem usar a biblioteca MATH.

                double basePiramide = Convert.ToDouble(txtBaseDaPiramide.Text);
                double alturaPiramide = Convert.ToDouble(txtAlturaPiramide.Text);
                //txtResultadoPiramide.Text = Convert.ToDouble(alturaPiramide * (basePiramide * basePiramide) / 3).ToString("0,00");
                txtResultadoPiramide.Text = (alturaPiramide * Math.Pow(basePiramide, 2) / 3).ToString("0,00");
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no calculo do volume da pirâmide.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


    }
}
