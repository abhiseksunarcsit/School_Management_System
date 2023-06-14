using SMS.WebApp.Data.Healper;
using SMS.WebApp.Data.Models.Emums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.WebApp.Data.Models.DataModels
{
    public class Students:BaseModel
    {
        //guid is more secure and work like int id 
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public GenderEnums gender { get; set; }
        public string GradeLevel { get; set; }
        public string PhoneNumber { get; set; }


    }
}
