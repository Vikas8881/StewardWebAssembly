using Client.Service.Appointment;
using Microsoft.AspNetCore.Components;
using Model;
using Syncfusion.Blazor.HeatMap.Internal;
using Syncfusion.Blazor.Schedule;
using Syncfusion.Blazor.Schedule.Internal;

namespace Client.Pages
{
    public partial class Schedule : ComponentBase
    {
        public View CurrentView { get; set; } = View.Week;
        private int CurrentYear;
        private DateTime CurrentDate { get; set; }
        //private List<AppointmentData> dataSource = new List<AppointmentData>();
        private List<AppointmentModel> dataSource = new List<AppointmentModel>();
        private List<Doctor> Doctors = new List<Doctor>();
        protected override void OnInitialized()
        {
            CurrentDate = DateTime.Now;
            base.OnInitialized();
            CurrentYear = DateTime.Today.Year;
         
            //dataSource = GetScheduleData();
        }

        public void OnPopupOpen(PopupOpenEventArgs<AppointmentData> args)
        {
            //if (args.Type == PopupType.Editor || args.Type == PopupType.QuickInfo)
            //{

            //    args.Cancel = true;
            //}
        }
        //public List<AppointmentModel> GetScheduleData()
        //{
        //    List<AppointmentModel> appData = new List<AppointmentModel>();
        //    appData.Add(new AppointmentModel
        //    {
        //        Id = 1,
        //        Subject = "Explosion of Betelgeuse Star",
        //        Location = "Space Centre USA",
        //        StartTime = new DateTime(CurrentYear, 1, 4, 9, 30, 0),
        //        EndTime = new DateTime(CurrentYear, 1, 4, 11, 0, 0),
        //        CategoryColor = "#1aaa55"
        //    });
        //    appData.Add(new AppointmentData
        //    {
        //        Id = 2,
        //        Subject = "Thule Air Crash Report",
        //        Location = "Newyork City",
        //        StartTime = new DateTime(CurrentYear, 1, 5, 12, 0, 0),
        //        EndTime = new DateTime(CurrentYear, 1, 5, 14, 0, 0),
        //        CategoryColor = "#357cd2"
        //    });
        //    appData.Add(new AppointmentData
        //    {
        //        Id = 3,
        //        Subject = "Blue Moon Eclipse",
        //        Location = "Space Centre USA",
        //        StartTime = new DateTime(CurrentYear, 1, 6, 9, 30, 0),
        //        EndTime = new DateTime(CurrentYear, 1, 6, 11, 0, 0),
        //        CategoryColor = "#7fa900"
        //    });
        //    appData.Add(new AppointmentData
        //    {
        //        Id = 4,
        //        Subject = "Meteor Showers in 2022",
        //        Location = "Space Centre USA",
        //        StartTime = new DateTime(CurrentYear, 1, 7, 13, 0, 0),
        //        EndTime = new DateTime(CurrentYear, 1, 7, 14, 30, 0),
        //        CategoryColor = "#ea7a57"
        //    });
        //    appData.Add(new AppointmentData
        //    {
        //        Id = 5,
        //        Subject = "Milky Way as Melting pot",
        //        Location = "Space Centre USA",
        //        StartTime = new DateTime(CurrentYear, 1, 8, 12, 0, 0),
        //        EndTime = new DateTime(CurrentYear, 1, 8, 14, 0, 0),
        //        CategoryColor = "#00bdae"
        //    });
        //    return appData;
        //}
        public void OnEventRendered(EventRenderedArgs<AppointmentData> args)
        {
            Dictionary<string, object> attributes = new Dictionary<string, object>();
            if (CurrentView == View.Agenda)
            {
                attributes.Add("style", "border-left-color: " + args.Data.CategoryColor);
            }
            else
            {
                attributes.Add("style", "background: " + args.Data.CategoryColor);
            }
            args.Attributes = attributes;
        }
        public class AppointmentData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public Nullable<bool> IsAllDay { get; set; }
            public string CategoryColor { get; set; }
            public string RecurrenceRule { get; set; }
            public Nullable<int> RecurrenceID { get; set; }
            public string RecurrenceException { get; set; }
            public string StartTimezone { get; set; }
            public string EndTimezone { get; set; }
        }
    }
}
