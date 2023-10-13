using Model;
using Model.DTO;
using System;

namespace StewardAPI.Repository.prescription
{
    public interface IPatientMedicineRepo
    {
        Task<ServiceResponse<PatientMedicines>> CreatePatientmedicine(PatientMedicines patient);
        Task<ServiceResponse<List<PatientMedicines>>> GetPatientmedicine(int Pid);

    }
}
