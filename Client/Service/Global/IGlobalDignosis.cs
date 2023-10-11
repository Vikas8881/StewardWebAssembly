using Model;

namespace Client.Service.Global
{
    public interface IGlobalDignosis
    {
        Task<GenDignosis> Create(GenDignosis genDignosis);
        Task<ServiceResponse<List<GenDignosis>>> GetDignosis();
    }
}
