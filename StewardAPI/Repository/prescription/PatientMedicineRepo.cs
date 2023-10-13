using Microsoft.EntityFrameworkCore;
using Model;
using StewardAPI.Data;

namespace StewardAPI.Repository.prescription
{
    public class PatientMedicineRepo : IPatientMedicineRepo
    {
        private readonly AppDbContext _appDbContext;

        public PatientMedicineRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ServiceResponse<PatientMedicines>> CreatePatientmedicine(PatientMedicines patient)
        {
            var response = await _appDbContext.PatientMedicines.AddAsync(patient);
            await _appDbContext.SaveChangesAsync();
            return new ServiceResponse<PatientMedicines>()
            {
                Data = patient,
                Success = true
            };
        }

        public async Task<ServiceResponse<List<PatientMedicines>>> GetPatientmedicine(int Pid)
        {
            var response = new ServiceResponse<List<PatientMedicines>>();
            List<PatientMedicines> patient = null;
            patient = await _appDbContext.PatientMedicines.Where(d => d.Pid == Pid).ToListAsync();
            if (patient == null)
            {
                response.Success = false;
                response.Message = "Sorry Medicines not exists.";
            }
            else
            {
                response.Data = patient;
            }
            return response;
        }
    }
}
