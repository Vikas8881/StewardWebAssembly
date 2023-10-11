using Microsoft.EntityFrameworkCore;
using Model;
using StewardAPI.Data;

namespace StewardAPI.Repository.Global
{
    public class GlobalDignosisRepo : IGlobalDignosis
    {
        private readonly AppDbContext _appDBContext;

        public GlobalDignosisRepo(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<ServiceResponse<GenDignosis>> Create(GenDignosis GenDignosis)
        {
            var response = await _appDBContext.GenDiagnos.AddAsync(GenDignosis);
            var check = await _appDBContext.GenDiagnos.FirstOrDefaultAsync(x => x.DignosisName == GenDignosis.DignosisName);
            if (check != null)
            {
                return new ServiceResponse<GenDignosis>()
                {
                    Data = GenDignosis,
                    Success = false,
                    Message = "Same item already in Database"

                };

            }
            else
            {
                await _appDBContext.SaveChangesAsync();
                return new ServiceResponse<GenDignosis>()
                {
                    Data = GenDignosis,
                    Success = true
                };
            }

        }

        public async Task<ServiceResponse<List<GenDignosis>>> GetDignosis()
        {

            var result = await _appDBContext.GenDiagnos.ToListAsync();
            return new ServiceResponse<List<GenDignosis>>
            {
                Data = result,
                Success = true,
            };
        }

    }
}
