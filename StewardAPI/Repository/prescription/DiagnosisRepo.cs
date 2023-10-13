using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ServiceResponse<List<GenDignosis>>> GetPatientDiagnosis(int Pid)
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
            var response = new ServiceResponse<List<GenDignosis>>
            {
                Data = await _appDBContext.GenDiagnos.FromSqlRaw($"SP_Get_Diagnosis @PID={Pid}").ToListAsync()

            };
            return response;
        }
    }
}
