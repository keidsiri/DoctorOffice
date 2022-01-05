using System.Collections.Generic;

namespace DoctorOffice.Models
{
  public class Specialty
  {
    public Specialty()
    {
      this.JoinEntitiesSpecialty = new HashSet<DoctorSpecialty>();
    }

    public int SpecialtyId { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<DoctorSpecialty> JoinEntitiesSpecialty { get; set; }
  }
}