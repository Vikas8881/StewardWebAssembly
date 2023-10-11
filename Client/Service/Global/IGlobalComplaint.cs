using Model;

namespace Client.Service.Global
{
    public interface IGlobalComplaint
    {
        Task<GenComplaints> Create(GenComplaints genComplaint);
        Task<ServiceResponse<List<GenComplaints>>> GetComplaints();
    }
}
