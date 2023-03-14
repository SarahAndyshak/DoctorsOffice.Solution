using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoctorsOffice.Models
{
  public class Doctor
  {
    public int DoctorId { get; set; }
    [Required(ErrorMessage = "The doctor must have a name!!")]
    public string Name { get; set; }
    //[Range(1, int.MaxValue, ErrorMessage = "Your doctor must have a specialty. Have you created a specialty yet?")]
    // public int SpecialtyId { get; set; }
    // public Specialty Specialty { get; set; }
    public List<DoctorPatient> JoinEntities { get; }
    public List<DoctorSpecialty> JoinEntities2 { get; }
  }
}