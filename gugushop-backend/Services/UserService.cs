using MongoDB.Driver;
using gugushop_backend.Models;
using gugushop_backend.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gugushop_backend.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IUserDbSetting settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<User>(settings.UserCollectionName);
        }

        public List<User> Get() =>
            _users.Find(user => true).ToList();

        public User Get(string id) =>
            _users.Find<User>(user => user.UserId == id).FirstOrDefault();

        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public void Update(string id, User userIn) =>
            _users.ReplaceOne(user => user.UserId == id, userIn);

        public void Remove(User userIn) =>
            _users.DeleteOne(user => user.UserId == userIn.UserId);

        public void Remove(string id) =>
            _users.DeleteOne(user => user.UserId == id);
    }
}
