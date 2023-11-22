using Client.Service.PatientRepo;
using Model;

namespace Client.Service.PatientComplain
{
    public interface IPatientInvestigationRepo
    {
        Task<pInvestigation> CreateInvestigation(pInvestigation pInvestigation);
        Task<ServiceResponse<List<GenLabInvestigation>>> GetInvestigation(int ID);
    }
}
