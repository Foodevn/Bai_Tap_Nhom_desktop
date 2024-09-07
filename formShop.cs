using Quan_ly_Shop_Quan_ao_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_shop_quan_ao
{
	public partial class formShop : Form
	{
		public formShop()
		{
			InitializeComponent();
			start();
			TaiDanhSach();
		}
		public void TaiDanhSach()
		{
			List<string[]> danhSachSanPham = new List<string[]>
			{
				new string[] { "MH003", "quần tây 3", "150.000","1%", "10" },
				new string[] { "Mt004", "áo thun 4", "250.000", "0%", "2" },
				new string[] { "MH005", "áo dj 6", "250.000", "1%", "21" },
				new string[] { "Mk006", "quần què 5", "250.000", "12%", "22" },
				new string[] { "Mk007", "áo caro 7", "250.000",    "4%", "27" }

			};

			foreach (string[] sanPham in danhSachSanPham)
			{
				ListViewItem item = new ListViewItem(sanPham);
				listView1.Items.Add(item);
			}

		}
		public void start()
		{

		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string searchText = txtbTimKiem.Text.Trim().ToLower();

			List<ListViewItem> ketQuaTimKiem = new List<ListViewItem>();
			if (string.IsNullOrEmpty(searchText))
			{
				listView1.Items.Clear();
				TaiDanhSach();
				return;
			}

			foreach (ListViewItem item in listView1.Items)
			{

				string maHang = item.SubItems[0].Text.ToLower();
				string tenHang = item.SubItems[1].Text.ToLower();

				if (maHang.Contains(searchText) || tenHang.Contains(searchText))
				{

					ketQuaTimKiem.Add((ListViewItem)item.Clone());
				}
			}
			listView1.Items.Clear();
			foreach (ListViewItem resultItem in ketQuaTimKiem)
			{
				listView1.Items.Add(resultItem);
			}


			if (ketQuaTimKiem.Count == 0)
			{
				MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private void btnTaiLaiDanhSach_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			TaiDanhSach();
		}

		private void btnXoaBoLoc_Click(object sender, EventArgs e)
		{
			txtbTimKiem.Clear();
		}


	}
}
