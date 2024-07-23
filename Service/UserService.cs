using Domain.User.Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService
    {
        private UserRepository _repository;

        public UserService() {
            _repository = new UserRepository();
        }

        public  IEnumerable<User> GetAll()
        {
            var users = _repository.GetAll();
            return users;
        }
    }
}
