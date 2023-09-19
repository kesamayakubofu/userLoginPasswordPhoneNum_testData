using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringLib
{
    public class StringClass
    {
        /// <summary>
        /// В качестве параметра передается строка, которая может быть пустой или содержать произвольные символы.
        /// </summary>
        /// <param name="textString"></param>
        /// <returns>
        /// Метод возвращает true, если переданная строка соответствует email В противном случае возвращается false.
        /// </returns>
        public bool IsEmail(string textString)
        {
            if (string.IsNullOrEmpty(textString)) return false;
            string regex = @"^([a-zA-Z0-9_-]+\.)*[a-zA-Z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
            if (!Regex.Match(textString, regex).Success)
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// В качестве параметра передается строка, которая может быть пустой или содержать произвольные символы.
        /// </summary>
        /// <param name="textString"></param>
        /// <returns>
        /// Метод возвращает true, если переданная строка соответствует условиям выше и является корректным номером телефона. В противном случае возвращается false.
        /// </returns>
        public bool IsPhoneNumber(string textString)
        {
            if (string.IsNullOrEmpty(textString)) return false;
            string regex = @"^((8|\+7)[\-]?)?(\(?\d{3}\)?[\-]?)?[\d- ]{7,10}$";
            if (!Regex.Match(textString, regex, RegexOptions.IgnoreCase).Success)
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// В качестве параметра передается строка, которая может быть пустой или содержать произвольные символы.
        /// </summary>
        /// <param name="textString"></param>
        /// <returns>
        /// Метод возвращает true, если переданная строка соответствует условиям выше и является корректным паролем. В противном случае возвращается false.
        /// </returns>
        public bool IsPassword(string textString)
        {
            if (string.IsNullOrEmpty(textString)) return false;
            if (textString.Length >= 8 && textString.Length <= 15) { }
            else return false;
            string regex = @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15})";
            if (!Regex.Match(textString, regex).Success)
            {
                return false;
            }
            return true;
        }
        
    }
}
