using Model;

namespace StewardAPI.Repository.prescription
{
    public interface Iinvestigations
    {
        Task<ServiceResponse<pInvestigation>> Create(pInvestigation pDignosis);
    }
}
