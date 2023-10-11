using Model;

namespace Client.Service.Global
{
    public interface IGlobalInvestigation
    {
        Task<GenLabInvestigation> Create(GenLabInvestigation genlabInvestigation);
        Task<ServiceResponse<List<GenLabInvestigation>>> GetlabInvestigation();
    }
}
