﻿using Maxis.Database;
using Maxis.Infrastructure.Repositories.Abstract;
using Maxis.Services.Abstract;
using Maxis.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maxis.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<EditUserViewModel> GetAllUsers()
        {
            return _userRepository.SelectAll();
        }

        public List<EditUserViewModel> SelectById(long id)
        {
            return _userRepository.SelectById(id);
        }


        public void EditUser(EditUserViewModel editUserModel)
        {
            _userRepository.Update(editUserModel);
        }

        public void CreateUser(LoginViewModel loginViewModel)
        {
            _userRepository.Insert(loginViewModel);
        }
    }
}