using Model;

namespace StewardAPI.Repository.Global
{
    public interface IGlobalInvestigation
    {
        Task<ServiceResponse<GenLabInvestigation>> Create(GenLabInvestigation genInvestigation);
        Task<ServiceResponse<List<GenLabInvestigation>>> GetInvestigation();
    }
}
