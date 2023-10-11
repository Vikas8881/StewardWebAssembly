using Model;

namespace StewardAPI.Repository.prescription
{
    public interface IAdvice
    {
        Task<ServiceResponse<pAdvice>> Create(pAdvice pAdvice);
    }
}
