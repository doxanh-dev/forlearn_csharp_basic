using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap003
{
    public partial class Form1 : Form
    {
        private string webGoogle = "www.google.com.vn";
        private string webFacebook = "www.facebook.com";
        private string webYoutube = "www.youtube.com";
        private string webDantri = "www.dantri.com.vn";
        private string web24h = "www.24h.com.vn";

        public Form1()
        {
            InitializeComponent();
            InitializeListItem();
        }

        private void InitializeListItem()
        {
            listWeb.Items.Add(webGoogle);
            listWeb.Items.Add(webFacebook);
            listWeb.Items.Add(webYoutube);
            listWeb.Items.Add(webDantri);
            listWeb.Items.Add(web24h);
            listWeb.SelectedIndex = 0;
            txtShowWeb.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var webSelect = listWeb.Text;

            var result = "Bạn đã chọn Website: \n" + webSelect;
            txtShowWeb.Text = result;
            txtShowWeb.Enabled = true;
        }

        private void txtShowWeb_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtShowWeb.Text = "";
            txtShowWeb.Enabled = false;
        }
    }
}
