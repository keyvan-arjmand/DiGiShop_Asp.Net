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
    }
}
