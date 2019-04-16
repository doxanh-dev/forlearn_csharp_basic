using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap006
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var hoTen = Form1.HoTen;
            TextHoTen.Text = hoTen;
            txtKyTu.Focus();
        }
        
        private void btnTim_Click(object sender, EventArgs e)
        {
            var hoTen = Form1.HoTen.ToString();
            var kyTu = txtKyTu.Text;
            if (string.IsNullOrEmpty(kyTu))
            {
                MessageBox.Show("Vui lòng điền ký tự");
            }
            else
            {
                var temp = NonUnicode(hoTen);
                int count = temp.Count(f => f == char.Parse(kyTu));
                MessageBox.Show("Tìm thấy " + count + " ký tự trong khung trên", "Thông báo");
            }
        }

        private void btnViTri_Click(object sender, EventArgs e)
        {
            var hoTen = Form1.HoTen;
            var kyTu = txtKyTu.Text;
            if (string.IsNullOrEmpty(kyTu))
            {
                MessageBox.Show("Vui lòng điền ký tự");
            }
            else
            {
                var index = hoTen.IndexOf(kyTu);
                if (index > -1)
                {
                    TextViTri.Text = kyTu + " xuất hiện tại vị trí " + index;
                }
                else
                {
                    TextViTri.Text = "Ký tự " + kyTu + " không xuất hiện trong họ tên";
                }
            }
        }

        //convert text sang không dấu
        private string NonUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                                           "đ",
                                           "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
                                           "í","ì","ỉ","ĩ","ị",
                                           "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                                           "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
                                           "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                                           "d",
                                           "e","e","e","e","e","e","e","e","e","e","e",
                                           "i","i","i","i","i",
                                           "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                                           "u","u","u","u","u","u","u","u","u","u","u",
                                           "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        //close (X) button
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
