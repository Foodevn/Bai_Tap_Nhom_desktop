using quan_ly_shop_quan_ao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_Shop_Quan_ao_1
{
	public partial class formDangNhap : Form
	{
		public formDangNhap()
		{
			InitializeComponent();
			
			
			
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(textBox1.Text)||string.IsNullOrWhiteSpace(textBox2.Text))
			{
				lbThongBao.Text = "Vui lòng nhập tên và mật khẩu";
				lbThongBao.ForeColor=Color.Red;
			}
			else { 
			Form form = new formShop();
			form.ShowDialog();
				Form formDN=new formDangNhap();
				formDN.Close();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void formDangNhap_Load(object sender, EventArgs e)
		{
			
			this.KeyPreview = true;
			this.AcceptButton = button1;
		}
	}
}
