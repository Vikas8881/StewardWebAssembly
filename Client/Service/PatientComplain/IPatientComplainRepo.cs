using Client.Service.PatientRepo;
using Model;

namespace Client.Service.PatientComplain
{
    public interface IPatientComplainRepo
    {
        Task<pComplain> CreateComplain(pComplain pComplain);
        Task<ServiceResponse<List<GenComplaints>>> GetComplain(int ID);
    }
}
