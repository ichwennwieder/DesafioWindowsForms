namespace DesafioWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNumero.Text, out int numero);

            if (numero > 0)
            {
                if (Convert.ToInt32(txtNumero.Text) % 2 == 0)
                    MessageBox.Show("O n�mero � par");
                else
                    MessageBox.Show("O n�mero � impar");
            }
            else if (!string.IsNullOrEmpty(txtNumero.Text))
                MessageBox.Show("Por favor digite um somente n�meros!");
            else
                MessageBox.Show("Por favor digite um n�mero!");
        }

        private void btData_Click(object sender, EventArgs e)
        {
            DateTime.TryParse(calData.SelectionRange.Start.ToString(), out DateTime dtData);

            if (dtData.Year > 2015)
            {
                MessageBox.Show("Datas acima de 2015 s�o inv�lidas!");
                return;
            }
            else
            {
                TimeSpan difData = DateTime.Now - dtData;

                int idade = Convert.ToInt32(difData.TotalDays / 365);

                MessageBox.Show("A pessoa tem " + idade + " anos!");
                return;
            }

        }

        private void btTemperatura_Click(object sender, EventArgs e)
        {
            Double.TryParse(txtTemperatura.Text, out Double dcTemperatura);

            Double dcKelvin = dcTemperatura + 273.15;

            Double dcFahrenheit = (dcTemperatura - 32) * 5 / 9;

            MessageBox.Show("A temperatura " + dcTemperatura + "�C convertido para Kelvin �: " +
                dcKelvin + "�K e para Fahrenheit �: " + dcFahrenheit + "�F");
        }

        private void btPositivo_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>()
            {
                -34, 77, -89, -25, -19, 14, -20, 46, -32, 91
            };

            for (int x = 0; x < list.Count; x++)
            {
                if (list[x] < 0)
                    list[x] = Math.Abs(list[x]);
            }

            var strLista = string.Empty;

            foreach (int y in list)
            {
                strLista += y.ToString() + ", ";
            }

            if (strLista.EndsWith(", "))
                strLista = strLista.Substring(0, strLista.Length - 2);

            MessageBox.Show("A nova lista �: " + strLista);
        }

        private void btNegativo_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>()
            {
                -34, 77, -89, -25, -19, 14, -20, 46, -32, 91
            };

            for (int x = 0; x < list.Count; x++)
            {
                if (list[x] > 0)
                    list[x] = - list[x];
            }

            var strLista = string.Empty;

            foreach (int y in list)
            {
                strLista += y.ToString() + ", ";
            }

            if (strLista.EndsWith(", "))
                strLista = strLista.Substring(0, strLista.Length - 2);

            MessageBox.Show("A nova lista �: " + strLista);
        }
    }
}
