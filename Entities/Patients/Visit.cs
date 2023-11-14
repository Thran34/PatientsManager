using System.Text.Json.Serialization;

namespace PatientsManager.Entities.Patients
{
    public class Visit
    {
        [JsonIgnore]
        public int VisitId { get; set; }
        public DateTime VisitDate { get; set; }
        public string Purpose { get; set; }
        [JsonIgnore]
        public int? PatientId { get; set; }

        [JsonIgnore]
        public Patient? Patient { get; set; }
    }

}
