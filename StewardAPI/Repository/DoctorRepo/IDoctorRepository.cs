using Model;
using Model.DTO;
using Stripe;

namespace StewardAPI.Repository.IDoctorRepository
{
    public interface IDoctorRepository
    {
       
        Task<ServiceResponse<Doctor>> GetDoctor(int Id);
        Task<ServiceResponse<List<Doctor>>> GetDoctorHospital();

        Task<ServiceResponse<List<Doctor>>> GetAdminDoctors();
        Task<ServiceResponse<Doctor>> CreateDoctor(Doctor doctor);
        Task<ServiceResponse<Doctor>> UpdateDoctor(Doctor doctor);
        Task<ServiceResponse<bool>> DeleteDoctor(int doctorID);
    }
}
