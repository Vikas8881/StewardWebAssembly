using Model;
using Model.DTO;

namespace StewardAPI.Repository.prescription
{
    public interface IComplaintRepo
    {
        Task<ServiceResponse<pComplain>> Create(pComplain complain);
        Task<ServiceResponse<List<GenComplaints>>> GetPatientComplaints(int Pid);

    }
}
