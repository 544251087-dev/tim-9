using System;
using System.Collections.Generic;
using System.Text;
using Project_Klp_9.Models;
using Project_Klp_9.Views;

namespace Project_Klp_9.Presenter
{
    public class LoginPresenters
    {
        private readonly IView _view;
        private readonly UserRepository _userRepository;

        public LoginPresenters(IView view, UserRepository userRepository)
        {
            _view = view;
            _userRepository = userRepository;
            _view.LoginEvent += OnLogin;
        }

        private void OnLogin(object sender, EventArgs e)
        {
            var user = _userRepository.authenticate(_view.users, _view.Password, _view.role);
            if (user != null)
            {
                _view.Message = "Login Berhasil! Selamat datang, " + user.users;
                _view.isLoginSuccesful = true;
            }
            else
            {
                _view.Message = "Login Gagal! Periksa kembali Email, Password, atau Role Anda.";
                _view.isLoginSuccesful = false;
            }
        }
    }
}
