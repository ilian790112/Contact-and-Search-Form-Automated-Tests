using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Search
    {
        //default values in case setter are omitted by the data access layer

        private string location = "";



        public Search()
        {
        }


        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }
            

    }
}
