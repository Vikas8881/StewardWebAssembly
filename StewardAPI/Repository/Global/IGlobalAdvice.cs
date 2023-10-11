using Model;

namespace StewardAPI.Repository.Global
{
    public interface IGlobalAdvice
    {
        Task<ServiceResponse<GenAdvice>> Create(GenAdvice genAdvice);
        Task<ServiceResponse<List<GenAdvice>>> GetAdvice();
    }
}
