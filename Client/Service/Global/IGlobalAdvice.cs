using Model;

namespace Client.Service.Global
{
    public interface IGlobalAdvice
    {
        Task<GenAdvice> Create(GenAdvice genAdvice);
        Task<ServiceResponse<List<GenAdvice>>> GetAdvice();
    }
}
