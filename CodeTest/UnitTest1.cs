using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartyInvites.Models;
using PartyInvites.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace CodeTest
{
    [TestClass]
    public class AdminControllerTests
    {
        [TestMethod]
        public void CanChangeLoginName()
        {
            //Arrange setup the scenario

            User user = new User() { Username = "Bradley" };
            FakeRepository repository = new FakeRepository();
            repository.add(user);
            AdminController target = new AdminController(repository);
            string oldName = user.Username;
            string newName = "Braldey-John";

            //Act attempt the operation
            target.ChangeLoginName(oldName, newName);

            //Assert Verify the result
            Assert.AreEqual(user.Username, newName);
            Assert.IsTrue(repository.DidSubmitChanges);

        }
    }

    public class FakeRepository : IUserRepository
    {
        public bool DidSubmitChanges = false;
        public List<User> Users = new List<User>();

        public void add(User newUser)
        {
            Users.Add(newUser);
        }

        public User FetchByLoginName(string userName)
        {
            return Users.First(u => u.Username == userName);
        }

        public void SubmitChanges()
        {
            DidSubmitChanges = true;
        }
    }
}
