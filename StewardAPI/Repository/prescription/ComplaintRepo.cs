using AutoMapper;
using Model;
using StewardAPI.Data;

namespace StewardAPI.Repository.prescription
{
    public class ComplaintRepo : IComplaintRepo
    {
        private readonly AppDbContext _appDBContext;
        private readonly IMapper _mapper;

        public ComplaintRepo(AppDbContext appDBContext,IMapper mapper)
        {
              _appDBContext = appDBContext;
            _mapper = mapper;
        }


        public async Task<ServiceResponse<pComplain>> Create(pComplain complain)
        {
            var patient = _mapper.Map<pComplain>(complain);
            var response = await _appDBContext.PComplains.AddAsync(patient);

            await _appDBContext.SaveChangesAsync();
            return new ServiceResponse<pComplain>()
            {
                Data = complain,
                Success = true,
                Message = "Data Saved Successfully."
            };
        }
    }
}
