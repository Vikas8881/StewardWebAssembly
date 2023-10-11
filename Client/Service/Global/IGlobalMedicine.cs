using Model;

namespace Client.Service.Global
{
    public interface IGlobalMedicine
    {
        Task<GenMedicine> Create(GenMedicine genMedicine);
        Task<ServiceResponse<List<GenMedicine>>> GetMedicine();
    }
}
