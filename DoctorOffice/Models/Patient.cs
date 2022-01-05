using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models
{
    public class Patient
    {
        public Patient()
        {
            this.JoinEntities = new HashSet<DoctorPatient>();
        }

        public int PatientId { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime Birthdate { get; set; }

        public virtual ICollection<DoctorPatient> JoinEntities { get;}
    }
}