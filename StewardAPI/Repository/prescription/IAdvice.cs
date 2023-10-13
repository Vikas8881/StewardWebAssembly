using Model;

namespace StewardAPI.Repository.prescription
{
    public interface IAdvice
    {
        Task<ServiceResponse<pAdvice>> Create(pAdvice pAdvice);
        Task<ServiceResponse<List<GenAdvice>>> GetPatientAdvices(int Pid);

    }
}
