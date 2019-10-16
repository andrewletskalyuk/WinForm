using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_Text_Box
{
    public partial class Main : Form
    {
        string current_login, current_password;
        Dictionary<string, string> accounts = new Dictionary<string, string>();
        public Main()
        {
            InitializeComponent();
        }       

        private void tbLogin_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter login", tbLogin);
        }

        private void tbpassword_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter password", tbpassword);
        }


        private void tbLogin_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbLogin.Text))
            {
                MessageBox.Show("Логін не може бути порожнім");
                tbLogin.Focus();
            }

            current_login = tbLogin.Text;
            tbpassword.Enabled = true;
                
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            accounts["user"] = "1234";
            accounts["admin"] = "admin";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accounts.ContainsKey(current_login) && accounts[current_login]==tbpassword.Text)
            {
                MessageBox.Show("Валідація пройшла успішно");
            }
            else
            {
                MessageBox.Show("Валідація пройшла не успішно");
            }
        }
            int a = 3;

        private void tbpassword_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("У вас є три спроби на введення паролю");
            //тут закінчив
            if (accounts. != null ) 
            {
                MessageBox.Show("Пароль не може бути порожнім");
                a--;
            }
            else if (a<=0 )
            {
                MessageBox.Show("Пароль може бути введено тільки 3 рази");
               
            }
     
            current_password = tbpassword.Text;
            this.Close();
        }
    }
}
