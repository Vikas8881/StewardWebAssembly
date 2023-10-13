using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ServiceResponse<List<GenComplaints>>> GetPatientComplaints(int Pid)
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
            var response = new ServiceResponse<List<GenComplaints>>
            {
                Data = await _appDBContext.GenComplaintsLists.FromSqlRaw($"SP_Get_Complaints @PID={Pid}").ToListAsync()

            };
            return response;
        }
    }
}
