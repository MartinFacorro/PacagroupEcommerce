using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pacagroup.Ecommerce.Domain.Core
{
    public class UsersDomain : IUsersDomain
    {
        private readonly IUsersRepository _userRepository;
        public UsersDomain(IUsersRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Users Authenticate(string username, string password)
        { 
            return _userRepository.Authenticate(username, password);
        }
    }
}
