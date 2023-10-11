using AutoMapper;
using Model;
using StewardAPI.Data;

namespace StewardAPI.Repository.prescription
{
    public class DiagnosisRepo : IDiagnosis
    {
        private readonly AppDbContext _appDBContext;
        private readonly IMapper _mapper;

        public DiagnosisRepo(AppDbContext appDBContext, IMapper mapper)
        {
            _appDBContext = appDBContext;
            _mapper = mapper;
        }


        public async Task<ServiceResponse<pDignosis>> Create(pDignosis pDignosis)
        {
            var patient = _mapper.Map<pDignosis>(pDignosis);
            var response = await _appDBContext.PDignosis.AddAsync(patient);

            await _appDBContext.SaveChangesAsync();
            return new ServiceResponse<pDignosis>()
            {
                Data = pDignosis,
                Success = true,
                Message = "Data Saved Successfully."
            };
        }
    }
}
