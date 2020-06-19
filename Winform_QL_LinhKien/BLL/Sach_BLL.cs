using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Winform_QL_LinhKien.DTO;

namespace Winform_QL_LinhKien.BLL
{
    class Sach_BLL
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string filename = @"E:\LuyenTap_WinForm\Winform_QL_LinhKien\Winform_QL_LinhKien\XmlSach.xml";
        public Sach_BLL()
        {
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void them(SachDTO sachThem)
        {
            //tạo nút sách
            XmlNode sach = doc.CreateElement("sach");
            //tạo nút con của sách la masach 
            XmlElement masach = doc.CreateElement("masach");
            masach.InnerText = sachThem.MaSach; //gan giatri cho mã sách
            sach.AppendChild(masach); //thêm mã sách vào trong sách (sách nhận mã sách là con)

            XmlElement tensach = doc.CreateElement("tensach");
            tensach.InnerText = sachThem.TenSach;
            sach.AppendChild(tensach);

            XmlElement soluong = doc.CreateElement("soluong");
            soluong.InnerText = sachThem.SoLuong.ToString();
            sach.AppendChild(soluong);

            XmlElement dongia = doc.CreateElement("dongia");
            dongia.InnerText = sachThem.DonGia.ToString();
            sach.AppendChild(dongia);

            //sau khi tạo xong sách thì thêm sách vào trong root
            root.AppendChild(sach);
            doc.Save(filename); //lưu dữ liệu

        }

        public void sua(SachDTO sachSua)
        {
            //lấy vị trí cần sửa theo mã sách cũ đưa vào
            XmlNode sachcu = root.SelectSingleNode("sach[masach = '" + sachSua.MaSach + "']");
            if(sachcu != null)
            {
                XmlNode sachSuaMoi = doc.CreateElement("Sach");
                XmlElement masach = doc.CreateElement("masach");
                masach.InnerText = sachSua.MaSach; //gan giatri cho mã sách
                sachSuaMoi.AppendChild(masach); //thêm mã sách vào trong sách (sách nhận mã sách là con)

                XmlElement tensach = doc.CreateElement("tensach");
                tensach.InnerText = sachSua.TenSach;
                sachSuaMoi.AppendChild(tensach);

                XmlElement soluong = doc.CreateElement("soluong");
                soluong.InnerText = sachSua.SoLuong.ToString();
                sachSuaMoi.AppendChild(soluong);

                XmlElement dongia = doc.CreateElement("dongia");
                dongia.InnerText = sachSua.DonGia.ToString();
                sachSuaMoi.AppendChild(dongia);

                //thay thế sách cũ bằng sách mới (sửa)
                root.ReplaceChild(sachSuaMoi, sachcu);
                doc.Save(filename);

            }
        }
        public void xoa(SachDTO sachxoa)
        {
            XmlNode sachcanxoa = root.SelectSingleNode("/ds/sach[masach='" + sachxoa.MaSach + "']");
            if(sachcanxoa!=null)
            {
                root.RemoveChild(sachcanxoa);
                doc.Save(filename);
            }
        }

        public void timkiem(SachDTO sachTim, DataGridView dgv)
        {
            XmlNode sachCanTim = root.SelectSingleNode("/ds/sach[masach='" + sachTim.MaSach + "']");
            if (sachCanTim != null)
            {
                dgv.ColumnCount = 4; //khai báo cột
                dgv.Rows.Add(); // thêm dòng mới
                
                //đưa dữ liệu vào dòng vừa tạo
                XmlNode masach = sachCanTim.SelectSingleNode("masach");
                dgv.Rows[0].Cells[0].Value = masach.InnerText;

                XmlNode tensach = sachCanTim.SelectSingleNode("tensach");
                dgv.Rows[0].Cells[1].Value = tensach.InnerText;

                XmlNode soluong = sachCanTim.SelectSingleNode("soluong");
                dgv.Rows[0].Cells[2].Value = soluong.InnerText;

                XmlNode dongia = sachCanTim.SelectSingleNode("dongia");
                dgv.Rows[0].Cells[3].Value = dongia.InnerText;

            }
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            XmlNodeList ds = root.SelectNodes("sach");
            int sd = 0; //lưu chỉ số dòng
            foreach(XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("masach").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("tensach").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("soluong").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("dongia").InnerText;
                sd++;
            }    
        }


    }
}
