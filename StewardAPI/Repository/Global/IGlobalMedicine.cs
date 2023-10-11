using Model;

namespace StewardAPI.Repository.Global
{
    public interface IGlobalMedicine
    {
        Task<ServiceResponse<GenMedicine>> Create(GenMedicine genMedicine);
        Task<ServiceResponse<List<GenMedicine>>> GetMedicine();
    }
}
