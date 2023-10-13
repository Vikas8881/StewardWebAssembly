using Model;

namespace StewardAPI.Repository.prescription
{
    public interface IDiagnosis
    {
        Task<ServiceResponse<pDignosis>> Create(pDignosis pDignosis);
        Task<ServiceResponse<List<GenDignosis>>> GetPatientDiagnosis(int Pid);

    }
}
