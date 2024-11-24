using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btvn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lv_account.SelectedItems.Count > 0)
            {
                lv_account.Items.Remove(lv_account.SelectedItems[0]);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ListViewItem lv = new ListViewItem(txt_name.Text);
           
            lv.SubItems.Add(txt_password.Text);
            lv.SubItems.Add(txt_phone.Text);

            lv_account.Items.Add(lv);
        }

        private void lv_account_SelectedIndexChanged(object sender, EventArgs e)
        {
              
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(lv_account.SelectedItems.Count > 0)
            {
                ListViewItem selecteditem = lv_account.SelectedItems[0];

                selecteditem.SubItems[0].Text= txt_name.Text;
                selecteditem.SubItems[1].Text = txt_password.Text;
                selecteditem.SubItems[2].Text = txt_phone.Text;

            }    
        }
    }
}
