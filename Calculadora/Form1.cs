namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = resultTextBox;
        }

        const int initialState = 0;
        int b = initialState;

        //CloseButton
        private void Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //AddButton
        private void Button1_Click(object sender, EventArgs e)
        {
            BasicMaths bm = new BasicMaths();
            b = (bm.Add(int.Parse(resultTextBox.Text), b));
            operationTextBox.Text = b.ToString()+"+";
            resultTextBox.Text = "";
            Form1 form = new Form1();
            form.ActiveControl = resultTextBox;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            BasicMaths bm = new BasicMaths();
            b = initialState;
            resultTextBox.Text = "";
            operationTextBox.Text = "";
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            BasicMaths bm = new BasicMaths();
            b = (bm.Subtract(int.Parse(resultTextBox.Text), b));
            operationTextBox.Text = b.ToString() + "-";
            resultTextBox.Text = "";
            Form1 form = new Form1();
            form.ActiveControl = resultTextBox;

        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            operationTextBox.Text = "";
            resultTextBox.Text = b.ToString();
            Form1 form = new Form1();
            form.ActiveControl = resultTextBox;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //Aca podria poner para leer si el usuario escribe los signos de las operaciones
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            BasicMaths bm = new BasicMaths();
            b = (bm.Multiply(int.Parse(resultTextBox.Text), b));
            operationTextBox.Text = b.ToString() + "X";
            resultTextBox.Text = "";
            Form1 form = new Form1();
            form.ActiveControl = resultTextBox;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            BasicMaths bm = new BasicMaths();
            b = (bm.Divide(int.Parse(resultTextBox.Text), b));
            operationTextBox.Text = b.ToString() + "/";
            resultTextBox.Text = "";
            Form1 form = new Form1();
            form.ActiveControl = resultTextBox;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Enter Key pressed
                resultTextBox.Text = b.ToString();
            }
        }
    }
}