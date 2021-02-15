using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOS
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form_register = new Form_register();
            Form_register.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Bookos_login lg = new Bookos_login();
            string user_id_in = textBox_user_id.Text;
            string user_psw_in = textBox_user_password.Text;
            string user_psw = lg.get_user_password(user_id_in);

            if (user_psw_in.Equals(user_psw))
            {
                int user_type = lg.get_user_type(user_id_in);
                MessageBox.Show("登录成功!");
                this.Close();
                if (user_type == 1) {
                    Form form_main = new Form_main(user_id_in, user_type);
                    form_main.Show();
                }
                if (user_type == 0) {
                    Form form_admin = new Form_admin();
                    form_admin.Show();
                }
            }
            else {
                MessageBox.Show("登录失败,请重试!");
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
