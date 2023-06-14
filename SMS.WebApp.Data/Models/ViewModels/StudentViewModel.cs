using SMS.WebApp.Data.Models.Emums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.WebApp.Data.Models.ViewModels
{
    public class StudentViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DOB { get; set; }
        public GenderEnums Gender { get; set; }
        public string GradeLevel { get; set; }
        public String PhoneNumber{ get; set; }
    }
}
