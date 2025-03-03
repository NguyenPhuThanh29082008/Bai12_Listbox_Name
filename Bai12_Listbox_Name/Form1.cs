using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai12_Listbox_Name
{
    public partial class Form1 : Form
    {
        List<string> ten = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*lstNames.Items.Add(txtName.Text);
            txtName.Text = "";
            txtName.Focus(); */

            ten.Add(txtName.Text);
            foreach (string a in ten)
            {
                lstNames.Items.Add(a);
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn tên trong danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                lstNames.Items[lstNames.SelectedIndex] = txtName.Text;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstNames.Items.Add("ABCD");
            lstNames.Items.Add("XYZT");
            lstNames.Items.Add("ABZT");
            lstNames.Items.Add("XYCD");
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex >= 0) { 
                txtName.Text = lstNames.SelectedItem.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex >= 0)
            {
                lstNames.Items.RemoveAt(lstNames.SelectedIndex);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex >= 0)
            {
                lstNames.Items.Insert(lstNames.SelectedIndex, txtName.Text);
            }
        }

        private void txtIndex_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> List = new List<string>();
            ten.Add(txtName.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var a in ten)
            {
                lstNames.Items.Add(a);
            }
        }
    }
}
