using AutoMapper;
using Model;
using StewardAPI.Data;

namespace StewardAPI.Repository.prescription
{
    public class AdviceRepo : IAdvice
    {
        private readonly AppDbContext _appDBContext;
        private readonly IMapper _mapper;

        public AdviceRepo(AppDbContext appDBContext, IMapper mapper)
        {
            _appDBContext = appDBContext;
            _mapper = mapper;
        }


        public async Task<ServiceResponse<pAdvice>> Create(pAdvice pAdvice)
        {
            var patient = _mapper.Map<pAdvice>(pAdvice);
            var response = await _appDBContext.PAdvice.AddAsync(patient);

            await _appDBContext.SaveChangesAsync();
            return new ServiceResponse<pAdvice>()
            {
                Data = pAdvice,
                Success = true,
                Message = "Data Saved Successfully."
            };
        }
    }
}
