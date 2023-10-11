using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.DTO;
using StewardAPI.Data;

using StewardAPI.Repository.User;
using System.Linq;
using System.Numerics;

namespace StewardAPI.Repository.PatientRepository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public PatientRepository(AppDbContext appDbContext, IUserService userService, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _userService = userService;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<PatientCreateDTO>> CreatePatient(PatientCreateDTO patientCreateDTO)
        {
            string hospitalID = _userService.GetUserID();
            var patient=_mapper.Map<Patient>(patientCreateDTO);

            var uid = await _appDbContext.Patients.Where(c => c.hospitalID == hospitalID).MaxAsync(e => e.Uhid);
              
            var maxValue = uid += 1;
            if (uid == null)
            {
                uid = 1;
            }
            patient.Uhid = uid;
            patient.hospitalID = hospitalID;
            _appDbContext.Add(patient);
            await _appDbContext.SaveChangesAsync();

            return new ServiceResponse<PatientCreateDTO>
            {
                Data = patientCreateDTO
            };
        }

        public async Task<ServiceResponse<PatientCreateDTO>> PostPatientwithUHID(PatientCreateDTO patientCreateDTO)
        {
            var patient = _mapper.Map<Patient>(patientCreateDTO);

           
        
            patient.hospitalID = _userService.GetUserID();
            _appDbContext.Add(patient);
            await _appDbContext.SaveChangesAsync();

            return new ServiceResponse<PatientCreateDTO>
            {
                Data = patientCreateDTO
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

        public async Task<ServiceResponse<List<Patient>>> GetByHospital()
        {
           var hospitalID = _userService.GetUserID();
            var patient = await _appDbContext.Patients
                .Include(d => d.Doctor)
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
                 .Include(d => d.Doctor)
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
  
      

        public async Task<ServiceResponse<Patient>> SearchPatientUhid(int uhid)
        {
            string hospitalID = _userService.GetUserID();
            var response = new ServiceResponse<Patient>();
            Patient patient = null;
            patient = await _appDbContext.Patients.Where(c=> c.hospitalID == hospitalID)
                      .Include(d => d.Doctor)
                     .FirstOrDefaultAsync(d => d.Uhid == uhid && !d.Deleted);
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
    }
}
