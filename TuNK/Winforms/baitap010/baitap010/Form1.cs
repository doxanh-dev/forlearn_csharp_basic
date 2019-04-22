using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap010
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listWeb.Items.Add(webGoogle);
            listWeb.Items.Add(webFacebook);
            listWeb.Items.Add(webYoutube);
            listWeb.Items.Add(webDantri);
            listWeb.Items.Add(web24h);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listWebShow.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listWebShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            listWebShow.Items.Add(listWeb.SelectedItem);
        }
    }
}
