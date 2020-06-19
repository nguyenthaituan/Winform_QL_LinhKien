using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_QL_LinhKien.DTO
{
   public class SachDTO
    {
        private String _MaSach;
        private String _TenSach;
        private int _SoLuong;
        private double _DonGia;


        public string MaSach { get => _MaSach; set => _MaSach = value; }
        public string TenSach { get => _TenSach; set => _TenSach = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public double DonGia { get => _DonGia; set => _DonGia = value; }
    }
}
