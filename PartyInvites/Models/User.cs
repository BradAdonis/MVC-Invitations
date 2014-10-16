using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class User
    {
        public string Username { get; set; }
    }

    public interface IUserRepository
    {
        void add(User newUser);
        User FetchByLoginName(string userName);
        void SubmitChanges();
    }

    public class DefaultUserRepository : IUserRepository
    {

        public void add(User newUser)
        {
           
        }

        public User FetchByLoginName(string userName)
        {
            return null;
        }

        public void SubmitChanges()
        {
            
        }
    }
        
}