using Model;
using Stripe;

namespace StewardAPI.Repository.IDoctorRepository
{
    public interface IDoctorRepository
    {
       
        Task<ServiceResponse<Doctor>> GetDoctor(int Id);
        Task<ServiceResponse<List<Doctor>>> GetDoctorHospital(/*string hospitalID*/);
        //Task<ServiceResponse<List<Doctor>>> GetDoctorByDepartment(string departmentUrl);
        //Task<ServiceResponse<List<string>>> GetDoctorSearchSuggestions(string SearchText);
        //Task<ServiceResponse<List<Product>>> GetFeaturedProduct();

        Task<ServiceResponse<List<Doctor>>> GetAdminDoctors();
        Task<ServiceResponse<Doctor>> CreateDoctor(Doctor doctor);
        Task<ServiceResponse<Doctor>> UpdateDoctor(Doctor doctor);
        Task<ServiceResponse<bool>> DeleteDoctor(int doctorID);
    }
}
