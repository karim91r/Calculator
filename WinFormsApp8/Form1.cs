namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "0";


        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "1";
                Button1.BackColor = Color.White;
            }
            else
            {
                Screen.Text = Screen.Text + "1";
                Button1.BackColor = Color.White;

            }

            Button1.BackColor = Color.Teal;

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "2";
            }
            else
            {
                Screen.Text = Screen.Text + "2";
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "3";
            }
            else
            {
                Screen.Text = Screen.Text + "3";
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "4";
            }
            else
            {
                Screen.Text = Screen.Text + "4";
            }
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "5";
            }
            else
            {
                Screen.Text = Screen.Text + "5";
            }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "6";
            }
            else
            {
                Screen.Text = Screen.Text + "6";
            }
        }



        private void Button7_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "7";
            }
            else
            {
                Screen.Text = Screen.Text + "7";
            }

        }
        private void Button8_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "8";
            }
            else
            {
                Screen.Text = Screen.Text + "8";
            }
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "9";
            }
            else
            {
                Screen.Text = Screen.Text + "9";
            }
        }
        private void ButtonSum_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screen.Text);
            Screen.Text = "";
            Operation = "+";

        }
        private void ButtonMult_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screen.Text);
            Screen.Text = "";
            Operation = "*";
        }
        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screen.Text);
            Screen.Text = "";
            Operation = "/";
        }
        private void ButtonSub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screen.Text);
            Screen.Text = "";
            Operation = "-";
        }
        private void ButtonDot_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + ".";
        }
        private void ButtonPre_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screen.Text);
            Screen.Text = "";
            Operation = "%";
        }
        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(Screen.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                Screen.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                Screen.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                Screen.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    Screen.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    Screen.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == "%")
            {
                Result = (FirstNumber / SecondNumber) * 100;
                Screen.Text = Convert.ToString(Result + "%");
                FirstNumber = Result;
            }
        }
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Screen.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
        
    
