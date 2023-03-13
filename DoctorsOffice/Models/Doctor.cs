using System.Collections.Generic;

namespace DoctorsOffice.Models
{
  public class Doctor
  {
    public int DoctorId { get; set; }
    public string Name { get; set; }

    public int SpecialtyId { get; set; }
    public Specialty Specialty { get; set; }
    public List<DoctorPatient> JoinEntities { get; }
  }
}