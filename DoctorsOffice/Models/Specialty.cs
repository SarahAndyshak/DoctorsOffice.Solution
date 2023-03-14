using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoctorsOffice.Models
{
  public class Specialty
  {
    
    public int SpecialtyId { get; set; }
    
    //[Required(ErrorMessage = "The specialty's name can't be empty!")]
    public string Name { get; set; }
    // public List<Doctor> Doctors { get; set; }
    public List<DoctorSpecialty> JoinEntities2 { get; }
  }
}