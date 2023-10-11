using AutoMapper;
using Model;
using StewardAPI.Data;

namespace StewardAPI.Repository.prescription
{
    public class InvestigationsRepo : Iinvestigations
    {
        private readonly AppDbContext _appDBContext;
        private readonly IMapper _mapper;

        public InvestigationsRepo(AppDbContext appDBContext, IMapper mapper)
        {
            _appDBContext = appDBContext;
            _mapper = mapper;
        }


        public async Task<ServiceResponse<pInvestigation>> Create(pInvestigation pDignosis)
        {
            var patient = _mapper.Map<pInvestigation>(pDignosis);
            var response = await _appDBContext.PInvestigation.AddAsync(patient);

            await _appDBContext.SaveChangesAsync();
            return new ServiceResponse<pInvestigation>()
            {
                Data = pDignosis,
                Success = true,
                Message = "Data Saved Successfully."
            };
        }
    }
}
