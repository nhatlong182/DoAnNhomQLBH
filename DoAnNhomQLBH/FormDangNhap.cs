using DoAnNhomQLBH.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomQLBH
{
    public partial class FormDangNhap : Form
    {
        BUS_DangNhap buDN;
        public FormDangNhap()
        {
            buDN = new BUS_DangNhap();
            InitializeComponent();
        }
        public static int maNV;
        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            string email = txtUserName.Text;
            string pw = txtPass.Text;
            if(buDN.dangNhap(email,pw))
            {
                
                MessageBox.Show("Đăng nhập thành công");
                //MessageBox.Show("a += " + getID());
                FHomeAdmin h = new FHomeAdmin(getID());
                this.Hide();
                h.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại !");
            }
        }
        public int getID()
        {
            int id;
            try
            {
                string email = txtUserName.Text;
                string pw = txtPass.Text;
                if (buDN.dangNhap(email, pw))
                {
                    id = buDN.GetID(email,pw);
                    return id;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            return 0;
        }

        private void chkSavePw_CheckedChanged(object sender, EventArgs e)
        {
            if(txtPass.Text != "" && txtUserName.Text != "")
            {
                if(chkSavePw.Checked == true)
                {
                    string users = txtUserName.Text;
                    string pw = txtPass.Text;
                    Properties.Settings.Default.username = users;
                    Properties.Settings.Default.password = pw;
                    Properties.Settings.Default.Save();
                }else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Properties.Settings.Default.username;
            txtPass.Text = Properties.Settings.Default.password;
            
            if (Properties.Settings.Default.username != "")
            {
                Properties.Settings.Default.Reset();
            }
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            FDangKy f = new FDangKy();
            this.Hide();
            f.ShowDialog();
           
        }
    }
}
