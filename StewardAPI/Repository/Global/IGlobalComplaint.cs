using Model;

namespace StewardAPI.Repository.Global
{
    public interface IGlobalComplaint
    {
        Task<ServiceResponse<GenComplaints>> Create(GenComplaints genComplaint);
        Task<ServiceResponse<List<GenComplaints>>> GetComplaints();
    }
}
