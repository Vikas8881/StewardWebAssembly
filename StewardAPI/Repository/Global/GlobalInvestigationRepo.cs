using Microsoft.EntityFrameworkCore;
using Model;
using StewardAPI.Data;

namespace StewardAPI.Repository.Global
{
    public class GlobalInvestigationRepo : IGlobalInvestigation
    {
        private readonly AppDbContext _appDBContext;

        public GlobalInvestigationRepo(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<ServiceResponse<GenLabInvestigation>> Create(GenLabInvestigation genInvestigation)
        {
            var response = await _appDBContext.GenlabInvestigation.AddAsync(genInvestigation);
            var check = await _appDBContext.GenlabInvestigation.FirstOrDefaultAsync(x => x.InvestigationName == genInvestigation.InvestigationName);
            if (check != null)
            {
                return new ServiceResponse<GenLabInvestigation>()
                {
                    Data = genInvestigation,
                    Success = false,
                    Message = "Same item already in Database"

                };

            }
            else
            {
                await _appDBContext.SaveChangesAsync();
                return new ServiceResponse<GenLabInvestigation>()
                {
                    Data = genInvestigation,
                    Success = true
                };
            }

        }

     
        public async Task<ServiceResponse<List<GenLabInvestigation>>> GetInvestigation()
        {

            var result = await _appDBContext.GenlabInvestigation.ToListAsync();
            return new ServiceResponse<List<GenLabInvestigation>>
            {
                Data = result,
                Success = true,
            };
        }

    }
}
