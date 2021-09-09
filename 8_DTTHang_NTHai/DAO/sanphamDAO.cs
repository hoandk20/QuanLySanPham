using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DTTHang_NTHai.DAO
{
    class sanphamDAO
    {
        //tao LinQ
        LinQDataContext db = new LinQDataContext();
        public List<sanpham> getList()
        {
            List<sanpham> list = db.sanphams.ToList();
            return list;
        }
        //them san pham
        public void insert(sanpham d)
        {
            db.sanphams.InsertOnSubmit(d);
            db.SubmitChanges();
        }
        //edit san pham
        public void edit(sanpham d)
        {
            sanpham edit = db.sanphams.Where(p => p.masp.Equals(d.masp)).SingleOrDefault();
            edit.masp = d.masp;
            edit.manhacc = d.manhacc;
            edit.tensp = d.tensp;
            edit.soluong = d.soluong;
            edit.dongia = d.dongia;
            edit.thanhtien = d.thanhtien;
            edit.hangsp = d.hangsp;
            db.SubmitChanges();

        }
        //lay san pham bang id
        public sanpham getspByID(int  id)
        {
            sanpham d = new sanpham();
            d = db.sanphams.Where(p => p.masp.Equals(id)).SingleOrDefault();
            return d;
        }
        public void remove(int id)
        {
            try
            {
                sanpham d = new sanpham();
                d = db.sanphams.Where(p => p.masp.Equals(id)).SingleOrDefault();
                db.sanphams.DeleteOnSubmit(d);
                db.SubmitChanges();
            }
            catch
            {

            }
            
        }
        public List<sanpham> getListSearch(string tensp, string hangsp)
        {
            List<sanpham> list = db.sanphams.Where(p=> p.hangsp.Trim().Contains(hangsp)||p.tensp.Trim().Contains(tensp)).ToList();
            return list;
        }
        public List<sanpham> getListTensp(string tensp)
        {
            List<sanpham> list = db.sanphams.Where(p => p.tensp.Trim().Contains(tensp)).ToList();
            return list;
        }
        public List<sanpham> getListHangsp(string hangsp)
        {
            List<sanpham> list = db.sanphams.Where(p => p.hangsp.Trim().Contains(hangsp) ).ToList();
            return list;
        }

    }
}
