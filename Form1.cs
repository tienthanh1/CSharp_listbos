using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_listbos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            lbsketqua.Items.Add(txtName.Text);
            txtName.Text = string.Empty;
        }

            private void btnxoa_Click(object sender, EventArgs e)
            {
                lbsketqua.Items.RemoveAt(lbsketqua.SelectedIndex);
            }

            private void btnsua_Click(object sender, EventArgs e)
            {
                if (lbsketqua.SelectedIndex < 0) return;
                lbsketqua.Items[lbsketqua.SelectedIndex] = txtName.Text;
            }

            private void lbsketqua_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (lbsketqua.SelectedIndex>=0)
                {
                    txtName.Text = lbsketqua.Items[lbsketqua.SelectedIndex].ToString();
                }
            
            }
        }
    }

