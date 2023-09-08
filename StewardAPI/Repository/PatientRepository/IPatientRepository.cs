using Model;

namespace StewardAPI.Repository.PatientRepository
{
    public interface IPatientRepository
    {
        Task<ServiceResponse<Patient>> GetPatient(int ID);
        Task<ServiceResponse<List<Patient>>> GetByHospital();
        //Task<ServiceResponse<List<Patient>>> GetByDoctor(string doctorID);

        //Task<ServiceResponse<Patient>> GetPatient(int Id);
        //Task<ServiceResponse<List<Patient>>> GetDoctorHospital(/*string hospitalID*/);
        ////Task<ServiceResponse<List<Doctor>>> GetDoctorByDepartment(string departmentUrl);
        ////Task<ServiceResponse<List<string>>> GetDoctorSearchSuggestions(string SearchText);
        ////Task<ServiceResponse<List<Product>>> GetFeaturedProduct();

        //Task<ServiceResponse<List<Patient>>> GetAdminDoctors();
        Task<ServiceResponse<Patient>> CreatePatient(Patient patient);
        Task<ServiceResponse<Patient>> UpdatePatient(Patient patient);
        Task<ServiceResponse<bool>> DeletePatient(int Id);
    }
}
