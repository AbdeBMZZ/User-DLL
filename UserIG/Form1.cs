using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User;

namespace UserIG
{
    public partial class Form1 : Form
    {
        User.User user = new User.User();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String name = this.textBox1.Text;
            String password = this.textBox2.Text;
            DateTime date_naissance = this.dateTimePicker1.Value.Date;

            if (name != "" && password != "")
            {
                user.Name = name;
                user.Password = password;
                user.Date_naissance = date_naissance;

                MessageBox.Show("age: " + user.getAge().ToString());
                MessageBox.Show("password: " + user.Password);
            }
            else
                MessageBox.Show("check your infos");


        }
    }
}
