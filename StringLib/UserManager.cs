using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringLib
{
    public class UserManager
    {
        public bool CorrectData(string userId, string pass)
        {
            if (string.IsNullOrEmpty(userId))  throw new Exception("Ошибка в вводе email/номер телефона");
            string regex = @"^(((8|\+7)[\-]?)?(\(?\d{3}\)?[\-]?)?[\d- ]{7,10})|(([a-zA-Z0-9_-]+\.)*[a-zA-Z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6})$";
            if (!Regex.Match(userId, regex).Success)
            {
                throw new Exception("Ошибка в вводе email/номер телефона");
            }


            if (string.IsNullOrEmpty(pass))  throw new Exception("Ошибка в вводе пароля");
            if (pass.Length >= 8 && pass.Length <= 15) { }
            else return false;
            string regex2 = @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15})";
            if (!Regex.Match(pass, regex2).Success)
            {
                throw new Exception("Ошибка в вводе пароля");
            }
            return true;
        }
    }
}
