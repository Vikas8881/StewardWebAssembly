using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.DTO;
using StewardAPI.Data;
using Stripe;
using System;

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

        public async Task<ServiceResponse<List<GenLabInvestigation>>> GetPatientInvestigations(int Pid)
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
            var response = new ServiceResponse<List<GenLabInvestigation>>
            {
                Data = await _appDBContext.GenlabInvestigation.FromSqlRaw($"SP_GetInvestigation @PID={Pid}").ToListAsync()

            };
            return response;
        }
    }
}
