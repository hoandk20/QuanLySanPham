using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DTTHang_NTHai.DAO
{
    class dangnhapDAO
    {
        //tao LinQ
        LinQDataContext db = new LinQDataContext();
        //lay data tu database thong qua name and pass
        public dangnhap getuser(string name,string pass)
        {
            dangnhap d = new dangnhap();
            d = db.dangnhaps.Where(p => p.username.Equals(name) && p.password.Equals(pass)).SingleOrDefault();
            return d;
        }
        //lay data tu database thong qua  pass
        public dangnhap getuser(string name)
        {
            dangnhap d = new dangnhap();
            d = db.dangnhaps.Where(p => p.username.Equals(name)).SingleOrDefault();
            return d;
        }
        //lay tat ca account
        public List<dangnhap> getList()
        {
            List<dangnhap> list = db.dangnhaps.ToList();
            return list;
        }
        //them account 
        public void insert(dangnhap d)
        {
            db.dangnhaps.InsertOnSubmit(d);
            db.SubmitChanges();
        }
        //edit account
        public void edit(dangnhap d)
        {
            dangnhap edit = db.dangnhaps.Where(p => p.username.Equals(d.username)).SingleOrDefault();
            edit.username = d.username;
            edit.password = d.password;
            edit.mod = d.mod;
            edit.email = d.email;
            edit.fullname = d.fullname;
            edit.state = d.state;
            db.SubmitChanges();
            
        }
        //xoa account by name
        public void remove(string username)
        {
            try
            {
                dangnhap d = new dangnhap();
                d = db.dangnhaps.Where(p => p.username.Equals(username)).SingleOrDefault();
                db.dangnhaps.DeleteOnSubmit(d);
                db.SubmitChanges();
            }
            catch
            {
                
            }
           
        }

    }
}
