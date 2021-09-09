using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DTTHang_NTHai.DAO
{
    class nhaccDAO
    {
        //tao LinQ
        LinQDataContext db = new LinQDataContext();
        public List<nhacungcap> getList()
        {
            List<nhacungcap> list = db.nhacungcaps.ToList();
            return list;
        }
        public void insert(nhacungcap d)
        {
            db.nhacungcaps.InsertOnSubmit(d);
            db.SubmitChanges();
        }
        public void edit(nhacungcap d)
        {
            nhacungcap edit = db.nhacungcaps.Where(p => p.manhacc.Equals(d.manhacc)).SingleOrDefault();
            edit.emailnhacc = d.emailnhacc;
            edit.dienthoai = d.dienthoai;
            edit.tennhacc = d.tennhacc;
            db.SubmitChanges();

        }
        //xoa nhac cung cap dua theo id
        public bool remove(int id)
        {
            try
            {
                nhacungcap d = new nhacungcap();
                d = db.nhacungcaps.Where(p => p.manhacc.Equals(id)).SingleOrDefault();
                db.nhacungcaps.DeleteOnSubmit(d);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        //tim va tra ve nha cc theo ten
        public List<nhacungcap> getListSearch(string tennhacc)
        {
            List<nhacungcap> list = db.nhacungcaps.Where(p => p.tennhacc.Trim().Contains(tennhacc) ).ToList();
            return list;
        }

    }
}
