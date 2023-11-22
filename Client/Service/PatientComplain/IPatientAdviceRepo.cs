using Client.Service.PatientRepo;
using Model;

namespace Client.Service.PatientComplain
{
    public interface IPatientAdviceRepo
    {
        Task<pAdvice> CreateAdvice(pAdvice pAdvice);
        Task<ServiceResponse<List<GenAdvice>>> GetAdvice(int ID);

    }
}
