using System.Text.RegularExpressions;

namespace programa4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtnum1_KeyPress(object sender, KeyPressEventArgs e)
        {

            Regex exp = new Regex(@"^[0-9,]*$");
            if (exp.IsMatch(e.KeyChar.ToString()) || e.KeyChar == (char)Keys.Back

                || e.KeyChar == (char)Keys.Delete)
            {
            }
            else
            {
                txtnum1.Tag = "Solo se aceptan numeros";
                // errorProvider1.SetError(textBox1, "solo numeros");
                e.Handled = true;


            }

        }
        ErrorProvider errorProvider1 = new ErrorProvider();

        private void txtnum1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            var textBox = sender as TextBox;
            try
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Tag = "No puede ser vacio";

                    errorProvider1.SetError(textBox, (string)textBox.Tag);
                    e.Cancel = true;
                }
                else
                {
                    //double.TryParse(textBox.Text, out double value);
                    if (textBox.Text.StartsWith(",")|| textBox.Text.StartsWith("."))
                    {
                        errorProvider1.SetError(textBox, "NO puedes iniciar con ,");
                        e.Cancel = true;
                    }

                   
                }
            }
            catch (Exception a)
            {
                if (a.TargetSite.Name == "StringToNumber")
                {

                    errorProvider1.SetError(textBox, "no se aceptan numeros con punto");
                    e.Cancel = true;
                }
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                double num1;
                double num2;
                double cambio;
                num1 = double.Parse(txtnum1.Text);
                num2 = double.Parse(txtnum2.Text);

                cambio = num1 / num2;
                lblDivision.Text = cambio.ToString();


                cambio = num2 * num1;
                lblMultiplicacion.Text = cambio.ToString();
                cambio = num2 + num1;
                lblSuma.Text = cambio.ToString();
                cambio = num1 - num2;
                lblResta.Text = cambio.ToString();

            }
            catch (Exception a)
            {
                if(a.Message== "Input string was not in a correct format.")
                {
                    errorProvider1.SetError(txtnum1, "vuelve a escribir corectamente el numero");
                    errorProvider1.SetError(txtnum2, "vuelve a escribir corectamente el numero");


                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}