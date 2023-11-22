using Microsoft.AspNetCore.Components;

namespace Client.Pages
{
    public partial class Index:ComponentBase
    {
        protected async override Task OnInitializedAsync()
        {
            await appointmentService.GetAppointments();
        }
     
    }
}
