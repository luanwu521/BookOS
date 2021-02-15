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
    public partial class Form_register : Form
    {
        public Form_register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_id_in = textBox_user_id.Text;
            string user_password_in = textBox_user_password.Text;
            Bookos_register reg = new Bookos_register();
            if (reg.user_is_exist(user_id_in))
            {
                MessageBox.Show("该用户已存在,请更换用户id");
                textBox_user_id.Text = "";
            }
            else {
                if (reg.password_is_allow(user_password_in))
                {
                    if (reg.user_register(user_id_in, user_password_in))
                    {
                        MessageBox.Show("注册成功!");
                    }
                    else {
                        MessageBox.Show("注册失败!");
                    }
                    
                }
                else {
                    MessageBox.Show("密码不符合要求或密码强度不够,请重新设置!");
                    textBox_user_password.Text = "";
                }
            }
        }
    }
}
