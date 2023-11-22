using Model;

namespace Client.Service.PatientComplain
{
    public interface IPatientMedicineRepo
    {
        Task<PatientMedicines> CreatePatientMedicine(PatientMedicines patientMedicines);
        Task<ServiceResponse<List<PatientMedicines>>> GetMedicines (int ID);
    }
}
