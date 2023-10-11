using Microsoft.EntityFrameworkCore;
using Model;
using StewardAPI.Data;

namespace StewardAPI.Repository.Global
{
    public class GlobalComplaint : IGlobalComplaint
    {
        private readonly AppDbContext _appDBContext;

        public GlobalComplaint(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<ServiceResponse<GenComplaints>> Create(GenComplaints genComplaint)
        {
            var response = await _appDBContext.GenComplaintsLists.AddAsync(genComplaint);
            var check = await _appDBContext.GenComplaintsLists.FirstOrDefaultAsync(x => x.ComplaintsName == genComplaint.ComplaintsName);
            if (check != null)
            {
                return new ServiceResponse<GenComplaints>()
                {
                    Data = genComplaint,
                    Success = false,
                    Message = "Same item already in Database"

                };

            }
            else
            {
                await _appDBContext.SaveChangesAsync();
                return new ServiceResponse<GenComplaints>()
                {
                    Data = genComplaint,
                    Success = true
                };
            }

        }

        public async Task<ServiceResponse<List<GenComplaints>>> GetComplaints()
        {
            var result = await _appDBContext.GenComplaintsLists.ToListAsync();
            return new ServiceResponse<List<GenComplaints>>
            {
                Data = result,
                Success = true,
            };
        }
    }
}
