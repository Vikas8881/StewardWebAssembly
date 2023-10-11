using Model;
using Model.DTO;


namespace StewardAPI.Repository.PatientRepository
{
    public interface IPatientRepository
    {
        Task<ServiceResponse<Patient>> GetPatient(int ID);
        Task<ServiceResponse<Patient>> SearchPatientUhid(int uhid);

        Task<ServiceResponse<List<Patient>>> GetByHospital();
     
        Task<ServiceResponse<PatientCreateDTO>> CreatePatient(PatientCreateDTO patient);
        Task<ServiceResponse<PatientCreateDTO>> PostPatientwithUHID(PatientCreateDTO patientCreateDTO);
        Task<ServiceResponse<Patient>> UpdatePatient(Patient patient);
        Task<ServiceResponse<bool>> DeletePatient(int Id);
    }
}
