using PatientsManager.Entities.Patients;

public class Patient
{
    public int PatientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }
    public ICollection<Visit> Visits { get; set; }
}
