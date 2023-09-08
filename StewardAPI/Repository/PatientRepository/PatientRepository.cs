using Microsoft.EntityFrameworkCore;
using Model;
using StewardAPI.Data;
using StewardAPI.Repository.User;
using System.Numerics;

namespace StewardAPI.Repository.PatientRepository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IUserService _userService;

        public PatientRepository(AppDbContext appDbContext, IUserService userService)
        {
            _appDbContext = appDbContext;
            _userService = userService;
        }
        public async Task<ServiceResponse<Patient>> CreatePatient(Patient patient)
        {
            var uid = await _appDbContext.Patients.MaxAsync(e => e.Uhid);
            var maxValue = uid += 1;
            if (uid == null)
            {
                uid = 1;
            }
            patient.Uhid = uid;
            _appDbContext.Add(patient);
            await _appDbContext.SaveChangesAsync();

            return new ServiceResponse<Patient>
            {
                Data = patient
            };
        }

        public async Task<ServiceResponse<bool>> DeletePatient(int Id)
        {
            var dbPatient = await _appDbContext.Patients.FindAsync(Id);
            if (dbPatient == null)
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                    Success = false,
                    Message = "Patient Not Found."
                };
            }
            dbPatient.Deleted = true;
            await _appDbContext.SaveChangesAsync();
            return new ServiceResponse<bool>
            {
                Data = true
            };
        }

        //public Task<ServiceResponse<List<Patient>>> GetByDoctor(string doctorID)
        //{
        //    //var doctorID = _userService.GetUserID();
        //    //var patient = await _appDbContext.Patients
        //    //    .Where(p => p.hospitalID == hospitalID && !p.Deleted).ToListAsync();
        //    //return new ServiceResponse<List<Patient>>
        //    //{
        //    //    Data = patient
        //    //};
        //}

        public async Task<ServiceResponse<List<Patient>>> GetByHospital()
        {
           var hospitalID = _userService.GetUserID();
            var patient = await _appDbContext.Patients
                .Where(p => p.hospitalID == hospitalID && !p.Deleted).ToListAsync();
           return new ServiceResponse<List<Patient>>
           { 
               Data = patient 
           };
        }

        public async Task<ServiceResponse<Patient>> GetPatient(int ID)
        {
            var response = new ServiceResponse<Patient>();
            Patient patient = null;
            patient = await _appDbContext.Patients
                     .FirstOrDefaultAsync(d => d.Id == ID && !d.Deleted);
            if (patient == null)
            {
                response.Success = false;
                response.Message = "Sorry patient not exists.";
            }
            else
            {
                response.Data = patient;
            }
            return response;
        }

        public async Task<ServiceResponse<Patient>> UpdatePatient(Patient patient)
        {
            var dbPatient = await _appDbContext.Patients.FirstOrDefaultAsync(d => d.Id == patient.Id);
            if (dbPatient == null)
            {
                return new ServiceResponse<Patient>
                {
                    Success = false,
                    Message = "Patient not found!"
                };
            }
            dbPatient.Name = patient.Name;
            dbPatient.Address = dbPatient.Address;
            dbPatient.Opdtype = dbPatient.Opdtype;
            dbPatient.City = dbPatient.City;
            dbPatient.Phone = dbPatient.Phone;
            await _appDbContext.SaveChangesAsync();
            return new ServiceResponse<Patient>
            {
                Success = true,
                Data = patient
            };
        }
    }
}
