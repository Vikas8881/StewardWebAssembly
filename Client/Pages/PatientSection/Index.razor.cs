using Client.Service.PatientRepo;
using Microsoft.AspNetCore.Components;
using Model;
using Newtonsoft.Json.Serialization;
using Syncfusion.Blazor.Grids;

namespace Client.Pages.PatientSection
{
    public partial class Index:ComponentBase
    {
        private SfGrid<Patient> DefaultGrid;
      
        protected override void OnInitialized()
        {
            pService.PatientChagned += StateHasChanged;
        }
        protected override async Task OnInitializedAsync()
        {
            await pService.GetPatientList();
        }
     
        public int pagesize { get; set; } = 10;
        public object[] pagesizes = new object[] { 10, 20, 30, 50, 100, "All" };
      
    }

}
