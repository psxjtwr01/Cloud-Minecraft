using System.Security.Cryptography.X509Certificates;
using WinFormsApp2;
namespace WinFormsApp2
{
    public partial class keyauth : Form
    {
        public string key = "123";
        public string entered_Key;
        public bool logged_in;
        public bool pickedanswer = false;
        public bool continue_A = false;

        public keyauth()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            entered_Key = KeyBox.Text;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (logged_in)
            {

                while (!pickedanswer)
                {
                    DialogResult result = MessageBox.Show("You are already logged in continue anyway?", "Dialog", MessageBoxButtons.YesNo);


                    if (result == DialogResult.Yes)
                    {
                        continue_A = true;
                        pickedanswer = true;


                    }
                    else if (result == DialogResult.No)
                    {
                        continue_A = false;
                        pickedanswer = true;
                    }
                    else
                    {
                        MessageBox.Show("You must pick 'yes' or 'no'");
                        pickedanswer = false;
                    }


                }

            }
            else
            {
                if (entered_Key == key)
                {
                    MessageBox.Show("Logged in!");
                    logged_in = true;

                }
                else if (entered_Key != key)
                {
                    MessageBox.Show("Wrong credentials!");
                    logged_in = false;

                }

            }
        }
        private void cls()
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (logged_in)
            {
                Form1 form1 = new Form1();
                form1.Show();
                cls();
            }
            else
            {
                MessageBox.Show("You must be logged in!");
            }
           
        }
    }
}
