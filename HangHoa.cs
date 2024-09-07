using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_Shop_Quan_ao_1
{
	internal class HangHoa
	{
		public string MaHang { get; set; }
		public string TenHang { get; set; }
		public int Gia {  get; set; }
		public HangHoa()
		{

		}
		public HangHoa(string MaHang, string TenHang,int Gia)
		{
			this.MaHang = MaHang;
			this.TenHang = TenHang;
			this.Gia = Gia;
		}

	}
}
