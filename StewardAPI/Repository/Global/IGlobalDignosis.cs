using Model;

namespace StewardAPI.Repository.Global
{
    public interface IGlobalDignosis
    {
        Task<ServiceResponse<GenDignosis>> Create(GenDignosis genDignosis);
        Task<ServiceResponse<List<GenDignosis>>> GetDignosis();
    }
}
