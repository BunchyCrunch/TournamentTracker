using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {

        /// <summary>
        /// The first name of the person.
        /// </summary>
        public int FirstName { get; set; }

        /// <summary>
        /// The last name of the person. 
        /// </summary>
        public int LastName { get; set; }

        /// <summary>
        /// The primary email address of the person. 
        /// </summary>
        public int EmailAddress { get; set; }

        /// <summary>
        /// The primary cell phone number of the person. 
        /// </summary>
        public int CellphoneNumber { get; set; }
    }
}
