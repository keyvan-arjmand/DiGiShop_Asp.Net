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
    }
}
