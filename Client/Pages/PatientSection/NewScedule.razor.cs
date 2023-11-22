using Microsoft.AspNetCore.Components;
using Model;
using Model.DTO;
using Syncfusion.Blazor.Calendars;
using Syncfusion.Blazor.Notifications;
using Syncfusion.Blazor.Schedule.Internal;

namespace Client.Pages.PatientSection
{
    public partial class NewScedule : ComponentBase
    {
        SfToast ToastObj;
        private string ToastPosition = "Right";
        AppointmentModel appointmentModel = new AppointmentModel();
        DateTime maxDate = new DateTime();
        
        protected override async Task OnInitializedAsync()
        {
          await dService.GetDoctor();
         
        }
     
        async Task handelCreate()
        {

            if (appointmentModel.Name == null)
            {
                await this.ToastObj.ShowAsync(Toast[4]);
            }
            if (appointmentModel.phone == null)
            {
                await this.ToastObj.ShowAsync(Toast[5]);
            }
            if (appointmentModel.Address == null)
            {
                await this.ToastObj.ShowAsync(Toast[6]);
            }
            if (appointmentModel.City == null)
            {
                await this.ToastObj.ShowAsync(Toast[7]);
            }
            if (appointmentModel.DoctorID == 0)
            {
                await this.ToastObj.ShowAsync(Toast[9]);
            }
            if (appointmentModel.AppointmentType == null)
            {
                await this.ToastObj.ShowAsync(Toast[8]);
            }
            //DateTime datetime = appointmentModel.starDateTime;
            //appointmentModel.endDateTime = datetime.AddMinutes(2);
            var response = await appointmentService.AddAppointment(appointmentModel);
            if (response != null)
            {
                await this.ToastObj.ShowAsync(Toast[1]);
                appointmentModel.Name = "";
                appointmentModel.Address = "";
                appointmentModel.City = "";
                //appointmentModel.Phone = "";
                //appointmentModel.Opdfess = 0;
                //appointmentModel.Opdtype = "";
            }
            else
            {
                await this.ToastObj.ShowAsync(Toast[2]);
            }


        }
        private List<ToastModel> Toast = new List<ToastModel>
    {
      /*0*/  new ToastModel{ Title = "Warning!", Content="There was a problem with your network connection.", CssClass="e-toast-warning", Icon="e-warning toast-icons" },
      /*1*/  new ToastModel{ Title = "Success!", Content="Patient Registred successfully.", CssClass="e-toast-success", Icon="e-success toast-icons" },
       /*2*/ new ToastModel{ Title = "Error!", Content="A problem has been occurred while submitting your data.", CssClass="e-toast-danger", Icon="e-error toast-icons" },
       /*3*/ new ToastModel{ Title = "Information!", Content="Please read the comments carefully.", CssClass="e-toast-info", Icon="e-info toast-icons" },
       /*4*/ new ToastModel{ Title = "Warning!", Content="Please Enter Patient Name.",  CssClass="e-toast-warning", Icon="e-warning toast-icons"},
       /*5*/ new ToastModel{ Title = "Warning!", Content="Please Enter Phone.",  CssClass="e-toast-warning", Icon="e-warning toast-icons" },
       /*6*/ new ToastModel{ Title = "Warning!", Content="Please Enter Address.", CssClass="e-toast-warning", Icon="e-warning toast-icons"},
       /*7*/ new ToastModel{ Title = "Warning!", Content="Please Enter City.", CssClass="e-toast-warning", Icon="e-warning toast-icons"},
       /*8*/ new ToastModel{ Title = "Warning!", Content="Please Choose Doctor.", CssClass="e-toast-warning", Icon="e-warning toast-icons"},
       /*9*/ new ToastModel{ Title = "Warning!", Content="Please Choose OPD Type.", CssClass="e-toast-warning", Icon="e-warning toast-icons"},
    };
        private void BacktoList()
        {
            navManger.NavigateTo("/Patient/");
        }
        private void reset_form()
        {
            appointmentModel.Name = "";
            appointmentModel.Address = "";
            appointmentModel.City = "";
        }
    }
}
