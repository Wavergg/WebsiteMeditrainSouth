using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeditrainSouth.Models
{
    public class Message
    {
        //FirstNamePropertyStart
        [Required(ErrorMessage = "First Name Cannot be Empty")]
        public string FirstName { get; set; }

        //LastNamePropertyStart
        public string LastName { get; set; }
        
        //EmailPropertyStart
        [Required(ErrorMessage = "Email Address Cannot be Empty")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Not a Valid Email Address")]
        public string Email { get; set; }

        //PhonePropertyStart
        public string Phone { get; set; }

        //RegionPropertyStart
        public string Region { get; set; }

        //MessageBodyStart
        [Required(ErrorMessage = "Please Enter your Message")]
        [MinLength(5,ErrorMessage = "Message should be at least 5 characters Long")]
        public string MessageContent { get; set; }

        //CurrentTimeStart
        public DateTime CurrentTime { get; set; }
    }
}
