using Client.Service.PatientRepo;
using Model;

namespace Client.Service.PatientComplain
{
    public interface IPatientDiagnosisRepo
    {
        Task<pDignosis> CreateDiagnosis(pDignosis pDignosis);
    }
}
