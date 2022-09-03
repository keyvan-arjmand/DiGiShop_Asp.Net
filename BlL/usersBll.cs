using Be;
using Dal;
using System;
using System.Collections.Generic;
using static Be.Users;

namespace BlL
{
    public class usersBll
    {

        usersDal dl = new usersDal();

        public void create(Beusers c)
        {

            dl.Create(c);



        }
        public List<Beusers> Read()
        {
            return dl.Read();

        }
        public Beusers SearchUserName(string username)
        {
            return dl.SearchUserName(username);

        }
        public int gettotal()
        {
            return dl.gettotal();
        }
        public List<Beusers> getskip(int c)
        {
            return dl.getskip(c);
        }
        public void userFactor(int factorCode, string username)
        {
            dl.userFactor(factorCode, username);
        }
        public int CountUsers()
        {
            return dl.CountUsers();
        }

        public List<Beusers> SearchUsers(string info)
        {
            return dl.SearchUsers(info);
        }
        public List<Products.Factor> UserFactors(int id)
        {

            return dl.UserFactors(id);
        }
        public Beusers ReadById(int id)
        {
            return dl.ReadById(id);
        }
        public void EditUser(Beusers h)
        {
            dl.EditUser(h);
        }
    }
}
