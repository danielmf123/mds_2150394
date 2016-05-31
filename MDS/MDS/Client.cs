using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS
{
    class Client
    {

        private String _Name;
        private String _Username;
        private String _Password;
        private String _Address;
        private String _Gender;

        


        public Client(String Name , String Username , String Password , String Address , String Gender){

            this._Name = Name;
            this._Username = Username;
            this._Password = Password;
            this._Address = Address;
            this._Gender = Gender;

            List<Client> myList = new List<Client>();



    }


        public override string ToString()
        {

            return _Name + "(" + _Username + ")";

        }

    }
}
