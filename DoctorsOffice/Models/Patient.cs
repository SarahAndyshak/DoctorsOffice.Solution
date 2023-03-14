using System.Collections.Generic;

namespace DoctorsOffice.Models
{
  public class Patient
  {
    public int PatientId { get; set; }
    public string Name { get; set; }
    public string Birthdate { get; set; }
    public string Phone { get; set; }
    // public int DoctorId { get; set; }
    // public Doctor Doctor { get; set; }
    // comment these out so that each patient can have multiple doctors, use the List<DoctorPatient> instead
    public List<DoctorPatient> JoinEntities { get; }
  }
}