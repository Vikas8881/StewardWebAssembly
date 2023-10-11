using Model;

namespace Client.Service.PatientRepo
{
    public interface IPatient
    {
        event Action PatientChagned;
        //List<Patient> Patients { get; set; }
        string Message { get; set; }
        int CurrentPage { get; set; }   
        int PageCount { get; set; }
        Task<Patient>CreatePatient(Patient patient);
        Task<Patient>CreatePatientUhid(Patient patient);
        Task<Patient>UpdatePatient(Patient patient);
        Task Delete(int id);
        List<Patient> PatientList { get; set; }
        Task<ServiceResponse<Patient>> GetPatientbyUhid(int uhid);
        Task<ServiceResponse<Patient>> GetPatient(int ID);
        Task GetPatientList();
    }
}
