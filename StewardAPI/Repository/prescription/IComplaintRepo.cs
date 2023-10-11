using Model;
using Model.DTO;

namespace StewardAPI.Repository.prescription
{
    public interface IComplaintRepo
    {
        Task<ServiceResponse<pComplain>> Create(pComplain complain);
    }
}
