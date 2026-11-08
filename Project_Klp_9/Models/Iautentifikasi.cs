using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Klp_9.Models
{
    public interface Iautentifikasi
    {
        Model authenticate(string users, string password, string role);
    }
}
