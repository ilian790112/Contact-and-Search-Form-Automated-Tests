using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        //default values in case setter are omitted by the data access layer
        private string firstName = "";
        private string lastName = "";
        private string email = "";
        private string product = "";
        private string category = "";
        private string subCategory = "";
        private string message = "";
        private string file = "";


        public User()
        {
        }


        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Product
        {
            get { return this.product; }
            set { this.product = value; }
        }

       public string Category
        {
            get { return this.category; }
            set { this.category = value; }

        }


        public string SubCategory
        {
            get { return this.subCategory; }
            set { this.subCategory = value; }
        }


        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        public string File
        {
            get { return this.file; }
            set { this.file = value; }
        }

    }
}
