using Microsoft.AspNetCore.Components;
using Model;
using Syncfusion.Blazor.Schedule;
using System.Collections.Generic;

namespace Client.Pages.PatientSection
{
    public partial class AppointmentSlot:ComponentBase
    {
        public View CurrentView { get; set; } = View.Week;
        private int CurrentYear;
        private DateTime CurrentDate { get; set; }
    
        private List<Doctor> Doctors = new List<Doctor>();
        protected override void OnInitialized()
        {
            CurrentDate = DateTime.Now;
            base.OnInitialized();
            CurrentYear = DateTime.Today.Year;
            appointmentService.GetAppointments();
          
        }

        public void OnPopupOpen(PopupOpenEventArgs<AppointmentModel> args)
        {
            if (args.Type == PopupType.Editor || args.Type == PopupType.QuickInfo)
            {

                args.Cancel = true;
            }
        }
        //public List<AppointmentModel> getscheduledata()
        //{
        //    List<AppointmentModel> appdata = new list<AppointmentModel>();
        //    appdata.add(new AppointmentModel
        //    {
        //        id = 1,
        //        subject = "explosion of betelgeuse star",
        //        location = "space centre usa",
        //        starttime = new datetime(currentyear, 1, 4, 9, 30, 0),
        //        endtime = new datetime(currentyear, 1, 4, 11, 0, 0),
        //        categorycolor = "#1aaa55"
        //    });

        //    return appdata;
        //}
      
    }
}
