using Be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Be.Users;

namespace Dal
{
    public class usersDal
    {
        DB db = new DB();

        public void Create(Beusers c)
        {
            db.users.Add(c);
            db.SaveChanges();
        }

        public List<Beusers> Read()
        {

            return db.users.ToList();

        }
        public void EditUser(Beusers h)
        {
            Beusers user = ReadById(h.Id);

            user.name = h.name;
            user.family = h.family;
            user.email = h.email;
            user.password = h.password;
            user.phoneNumber = h.phoneNumber;
            user.username = h.username;
            user.admin = h.admin;
            if (h.pic != "")
            {
                user.pic = h.pic;
            }
            db.SaveChanges();

        }
        public Beusers SearchUserName(string username)
        {
            DB db = new DB();
            var q = from i in db.users
                    where i.username == username
                    select i;
            return q.Single();



        }

        public int gettotal()
        {
            return db.users.Count();
        }
        public List<Beusers> getskip(int c)
        {
            int t = c * 10;
            var q = db.users.Skip(t).Take(10);
            return q.ToList();
        }
        public void userFactor(int factorCode, string username)
        {
            var q = from i in db.factors
                    where i.FactorCode == factorCode
                    select i;
            List<Products.Factor> factor = q.ToList();

            var u = from i in db.users
                    where i.username == username
                    select i;
            var user = u.Single();


            db.SaveChanges();
        }
        public int CountUsers()
        {
            var count = db.users.Count();
            return count;

        }
        public List<Beusers> SearchUsers(string info)
        {

            List<Beusers> users = new List<Beusers>();

            if (info == "ادمین" || info == "admin")
            {
                var q = from i in db.users
                        where i.admin == 0
                        select i;
                users = q.ToList();
                return users;
            }
            else if (info == "کاربر" || info == "user")
            {
                var q = from i in db.users
                        where i.admin == 1
                        select i;
                users = q.ToList();
                return users;
            }
            else
            {
                var q = from i in db.users
                        where i.name.Contains(info) || i.family.Contains(info) || i.email.Contains(info) || i.phoneNumber.Contains(info) || i.username.Contains(info)
                        select i;
                users = q.ToList();


                if (users.Count() > 0)
                {
                    return users;
                }
                else
                {
                    users.Add(new Beusers
                    {
                        Id = 00,
                        admin = 404,
                        name = "کاربر مورد نظر یافت نشد",
                        family = "کاربر مورد نظر یافت نشد",

                    });

                }
                return users;
            }




        }
        public List<Products.Factor> UserFactors(int id)
        {
            var q = from i in db.factors
                    where i.userid == id
                    select i;
            var list = q.ToList();
            return list;
        }
        public Beusers ReadById(int id)
        {
            var q = from i in db.users
                    where i.Id == id
                    select i;
            Beusers user = q.Single();
            return user;
        }


    }
}
