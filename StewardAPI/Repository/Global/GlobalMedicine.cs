using Microsoft.EntityFrameworkCore;
using Model;
using StewardAPI.Data;

namespace StewardAPI.Repository.Global
{
    public class GlobalMedicine : IGlobalMedicine
    {
        private readonly AppDbContext _appDBContext;

        public GlobalMedicine(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<ServiceResponse<GenMedicine>> Create(GenMedicine genMedicine)
        {
            var response = await _appDBContext.GenMedicine.AddAsync(genMedicine);
            var check = await _appDBContext.GenMedicine.FirstOrDefaultAsync(x => x.MedicineName == genMedicine.MedicineName);
            if (check != null)
            {
                return new ServiceResponse<GenMedicine>()
                {
                    Data = genMedicine,
                    Success = false,
                    Message = "Same item already in Database"

                };

            }
            else
            {
                await _appDBContext.SaveChangesAsync();
                return new ServiceResponse<GenMedicine>()
                {
                    Data = genMedicine,
                    Success = true
                };
            }

        }

        public async Task<ServiceResponse<List<GenMedicine>>> GetMedicine()
        {
            var result = await _appDBContext.GenMedicine.ToListAsync();
            return new ServiceResponse<List<GenMedicine>>
            {
                Data = result,
                Success = true,
            };
        }
    }
}
