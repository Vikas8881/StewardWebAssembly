using Microsoft.EntityFrameworkCore;
using Model;
using StewardAPI.Data;

namespace StewardAPI.Repository.Global
{
    public class GlobalAdviceRepo : IGlobalAdvice
    {
        private readonly AppDbContext _appDBContext;

        public GlobalAdviceRepo(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<ServiceResponse<GenAdvice>> Create(GenAdvice genAdvice)
        {
            var response = await _appDBContext.GenAdvises.AddAsync(genAdvice);
            var check = await _appDBContext.GenAdvises.FirstOrDefaultAsync(x => x.AdviceName == genAdvice.AdviceName);
            if (check != null)
            {
                return new ServiceResponse<GenAdvice>()
                {
                    Data = genAdvice,
                    Success = false,
                    Message = "Same item already in Database"

                };

            }
            else
            {
                await _appDBContext.SaveChangesAsync();
                return new ServiceResponse<GenAdvice>()
                {
                    Data = genAdvice,
                    Success = true
                };
            }

        }

        public async Task<ServiceResponse<List<GenAdvice>>> GetAdvice()
        {

            var result = await _appDBContext.GenAdvises.ToListAsync();
            return new ServiceResponse<List<GenAdvice>>
            {
                Data = result,
                Success = true,
            };
        }

    }
}
