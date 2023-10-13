using Client.Service.PatientRepo;
using Model;

namespace Client.Service.PatientComplain
{
    public interface IPatientInvestigationRepo
    {
        Task<pInvestigation> CreateInvestigation(pInvestigation pInvestigation);
    }
}
