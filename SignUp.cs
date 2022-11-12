using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignUpLibrary.Exceptions;

namespace ValidationPassword
{
    internal class SignUp
    {
        private static String _login;
        //private static String _password;
        //private static String _confirmPassword;
        public static string Authorization(string Login)
        {
            _login = Login;
            //_password = Password;
            //_confirmPassword = ConfirmPassword;
            return _login;
        }

        public static bool MaximumLengthForLogin(string _login)
        {
            try
            {
                if (_login.Length < 20)
                {
                    return true;
                }
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine("From 1 to 20 letters " + ex);
            }
            return false;
            
        }
       
        
    }
}

