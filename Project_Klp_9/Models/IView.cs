using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Klp_9.Models
{
    public interface IView
    {
        string users { get; set; }
        string Password { get; set; }
        string role { get; set; }
        string Message { get; set; }

        bool isLoginSuccesful { get; set; }
        event EventHandler LoginEvent;
        void Show();
        void Close();
    }
}
