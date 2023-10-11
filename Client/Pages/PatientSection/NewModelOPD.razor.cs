﻿using Microsoft.AspNetCore.Components;
using Model;
using Model.DTO;
using Syncfusion.Blazor.Notifications;

namespace Client.Pages.PatientSection
{
    public partial class NewModelOPD : ComponentBase
    {
        SfToast ToastObj;
        private string ToastPosition = "Right";
        Patient patientModel = new Patient();

    
        protected override async Task OnInitializedAsync()
        {
          await dService.GetDoctor();
        }

     

        async Task handelCreate()
        {
          
            if(patientModel.Name==null)
            {
                await this.ToastObj.ShowAsync(Toast[4]);
            }
            if (patientModel.Phone == null)
            {
                await this.ToastObj.ShowAsync(Toast[5]);
            }
            if (patientModel.Address==null)
            {
                await this.ToastObj.ShowAsync(Toast[6]);
            }  if(patientModel.City==null)
            {
                await this.ToastObj.ShowAsync(Toast[7]);
            }
            if(patientModel.DoctorId==0)
            {
                await this.ToastObj.ShowAsync(Toast[9]);
            }if(patientModel.Opdtype==null)
            {
                await this.ToastObj.ShowAsync(Toast[8]);
            }
            
            var response = await pService.CreatePatient(patientModel);
            if (response != null)
            {
                await this.ToastObj.ShowAsync(Toast[1]);
                patientModel.Name = "";
                patientModel.Address = "";
                patientModel.City = "";
                patientModel.Phone = "";
                patientModel.Opdfess = 0;
                patientModel.Opdtype = "";
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
            patientModel.Name = "";
            patientModel.Address = "";
            patientModel.City = "";
            patientModel.Phone = "";
            patientModel.Opdfess = 0;
            patientModel.Opdtype = "";
            patientModel.DoctorId = 0;
        }
    }
}
