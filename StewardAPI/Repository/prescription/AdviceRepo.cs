using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ServiceResponse<List<GenAdvice>>> GetPatientAdvices(int Pid)
        {
            //var response = new ServiceResponse<List<pInvestigation>>();
            //List<pInvestigation> patient = null;
            ////patient = await _appDBContext.PInvestigation.Where(d => d.pID == Pid).ToListAsync();
            //patient = await _appDBContext.PInvestigation.FromSqlRaw("SP_GetInvestigation").Where(d => d.pID == Pid).ToListAsync();
            //if (patient == null)
            //{
            //    response.Success = false;
            //    response.Message = "Sorry Medicines not exists.";
            //}
            //else
            //{
            //    response.Data = patient;
            //}
            //return response;
            var response = new ServiceResponse<List<GenAdvice>>
            {
                Data = await _appDBContext.GenAdvises.FromSqlRaw($"SP_Get_Advice @PID={Pid}").ToListAsync()

            };
            return response;
        }
    }
}
