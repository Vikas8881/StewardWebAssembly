using Model;
using Model.DTO;

namespace Client.Service.DoctorRepo
{
    public interface iDoctorRepo
    {
        event Action OnChange;
        List<Doctor> Doctors { get; set; }
        List<Doctor> AdminDoctors { get; set; }
        Task GetAdminDoctor();
        Task AddDoctor(Doctor AddDoctor);
        Task UpdateDoctor(Doctor UpdateDoctor);
        Task DeleteDoctor(int doctorId);
        Doctor CreateNewDoctor();
        Task GetDoctor();
    }
}
