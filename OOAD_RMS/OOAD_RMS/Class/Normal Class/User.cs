using System;
using System.Collections.Generic;
using System.Text;

namespace OOAD_RMS
{
    public class User
    {
        private string _account;
        private string _password;
        private string _identity;

        public User()
        {
        } 

        public string UserAccount
        {
            get
            {
                return _account;
            }
            set
            {
                _account = value;
            }
        }

        public string UserPassword
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        
        public string UserIdentity
        {
            get
            {
                return _identity;
            }
            set
            {
                _identity = value;
            }
        }
    }
}