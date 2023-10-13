using Client.Service.Global;
using Client.Service.Static;
using Microsoft.AspNetCore.Components;
using Model;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Notifications;
using Syncfusion.Blazor.RichTextEditor;

namespace Client.Pages.PatientSection
{
    public partial class Prescription : ComponentBase
    {
        SfToast ToastObj;
        private string ToastPosition = "Right";
        [Parameter]

        public int ID { get; set; }

        private Patient patientModel = new Patient();
        private PatientMedicines _patientMedicines = new PatientMedicines();
        List<GenMedicine> _genMedicines { get; set; } = new List<GenMedicine>();
        List<PatientMedicines> _patientMedicinesList = new()
        {
            new PatientMedicines()
            { },
        };

        //Complain
        private pComplain _pComplain = new pComplain();
        SfMultiSelect<string[], GenComplaints> MultiComplain;
        public string[] MultiCom { get; set; } = new string[] { };
        public List<GenComplaints> GenComplaintsList { get; set; }
        private GenComplaints _complaints = new GenComplaints();

        //Advice
        private pAdvice _pAdvice = new pAdvice();
        SfMultiSelect<string[], GenAdvice> MultiAdvice;
        public string[] MultiAdv { get; set; } = new string[] { };
        public List<GenAdvice> GenAdviceList { get; set; }
        private GenAdvice _advice = new GenAdvice();

        //Diagnosis
        private pDignosis _pDiagnosis = new pDignosis();
        SfMultiSelect<string[], GenDignosis> MultiDignosis;
        public string[] MultiDig { get; set; } = new string[] { };
        public List<GenDignosis> GenDignosisList { get; set; }
        private GenDignosis _dignosis = new GenDignosis();

        //Investigation
        private pInvestigation _pInvestigation = new pInvestigation();
        SfMultiSelect<string[], GenLabInvestigation> MultiInvestigation;
        public string[] MultiInv { get; set; } = new string[] { };
        public List<GenLabInvestigation> GenInvestigationList { get; set; }
        private GenLabInvestigation _investigation = new GenLabInvestigation();
        //Medicine
        //private pComplain _pComplain = new pComplain();
        SfMultiSelect<string[], GenMedicine> MultiMedicine;
        public string[] MultiMed { get; set; } = new string[] { };
        public List<GenMedicine> GenMedicineList { get; set; }
        private GenMedicine _Medicine = new GenMedicine();

        protected override async Task OnInitializedAsync()
        {
            var response = await pService.GetPatient(ID);
            if (response.Success)
            {
                patientModel.Name = response.Data.Name;
                patientModel.Uhid = response.Data.Uhid;
            }
            //Get Medicine
            var response2 = await gMedicine.GetMedicine();
            if (response2.Success)
            {

                _genMedicines = response2.Data;

            }

            //Complain
            var complain = await gComplaint.GetComplaints();
            if (complain.Success)
            {
                GenComplaintsList = complain.Data;
            }
            //Advice
            var advice = await gAdvice.GetAdvice();
            if (advice.Success)
            {
                GenAdviceList = advice.Data;
            }
            //Dignosis
            var dignosis = await gDignosis.GetDignosis();
            if (dignosis.Success)
            {
                GenDignosisList = dignosis.Data;
            }
            //Investigation
            var investigation = await gInvestigation.GetlabInvestigation();
            if (investigation.Success)
            {
                GenInvestigationList = investigation.Data;
            }


        }
        async Task createComplain()
        {
            CreateComplaint();
            CreateDiagnosis();
            CreateAdvice();
            CreateInvestigation();
            CreateMedicine();
            CreatePatientMedicine();

        }
        private async Task CreatePatientMedicine()
        {
            //Medicine
            var patientMedicine = _patientMedicinesList;
            patientMedicine.ToArray();
            foreach (PatientMedicines patientMedicines in _patientMedicinesList)
            {
                if (patientMedicines != null)
                {
                    if (patientMedicines.Medicines == null)
                    {
                        await this.ToastObj.ShowAsync(Toast[4]);
                    }
                    else
                    {
                        int uhid = Convert.ToInt32(patientModel.Uhid);
                        patientMedicines.Pid = ID;
                        patientMedicines.Uhid = uhid;
                        var medi = patientMedicines.Medicines;

                        await pMedicine.CreatePatientMedicine(patientMedicines);

                        if (medi != null)
                        {

                            Guid valueID = Guid.NewGuid();
                            _Medicine.valueID = valueID.ToString();
                            _Medicine.MedicineName = patientMedicines.Medicines;
                            await gMedicine.Create(_Medicine);
                        }
                        await this.ToastObj.ShowAsync(Toast[1]);
                    }


                }
            }
        }
        private async Task CreateMedicine()
        {
            IEnumerable<GenMedicine> SelectedMedicines = await MultiMedicine.GetItemsAsync();
            if (SelectedMedicines != null)
            {
                foreach (var selectedMedicine in SelectedMedicines)
                {
                    if (Guid.TryParse(selectedMedicine.valueID, out Guid outputGuid))
                    {
                        int uhid = Convert.ToInt32(patientModel.Uhid);
                        _pComplain.pID = ID;
                        _pComplain.uID = uhid;
                        _pComplain.valueID = selectedMedicine.valueID;
                        await pComplain.CreateComplain(_pComplain);
                    }
                    else
                    {
                        //handle non valid guid format.
                        Guid valueID = Guid.NewGuid();
                        _Medicine.valueID = valueID.ToString();
                        _Medicine.MedicineName = selectedMedicine.MedicineName;
                        await gMedicine.Create(_Medicine);
                        int uhid = Convert.ToInt32(patientModel.Uhid);
                        _pComplain.pID = ID;
                        _pComplain.uID = uhid;
                        _pComplain.valueID = valueID.ToString();
                        await pComplain.CreateComplain(_pComplain);

                    }
                }
            }
        }

        private async Task CreateComplaint()
        {

            IEnumerable<GenComplaints> SelectedComplains = await this.MultiComplain.GetItemsAsync();
            if (SelectedComplains != null)
            {
                foreach (var selectedcomplain in SelectedComplains)
                {
                    if (Guid.TryParse(selectedcomplain.valueID, out Guid outputGuid))
                    {
                        int uhid = Convert.ToInt32(patientModel.Uhid);
                        _pComplain.pID = ID;
                        _pComplain.uID = uhid;
                        _pComplain.valueID = selectedcomplain.valueID;
                        await pComplain.CreateComplain(_pComplain);
                    }
                    else
                    {
                        //handle non valid guid format.
                        Guid valueID = Guid.NewGuid();
                        _complaints.valueID = valueID.ToString();
                        _complaints.ComplaintsName = selectedcomplain.ComplaintsName;
                        await gComplaint.Create(_complaints);
                        int uhid = Convert.ToInt32(patientModel.Uhid);
                        _pComplain.pID = ID;
                        _pComplain.uID = uhid;
                        _pComplain.valueID = valueID.ToString();
                        await pComplain.CreateComplain(_pComplain);
                    }
                }
            }
        }

        private async Task CreateInvestigation()
        {
            IEnumerable<GenLabInvestigation> SelectedInvestigations = await this.MultiInvestigation.GetItemsAsync();
            if (SelectedInvestigations != null)
            {
                foreach (var selectedInvestigation in SelectedInvestigations)
                {
                    if (Guid.TryParse(selectedInvestigation.valueID, out Guid outputGuid))
                    {
                        int uhid = Convert.ToInt32(patientModel.Uhid);
                        _pInvestigation.pID = ID;
                        _pInvestigation.uID = uhid;
                        _pInvestigation.valueID = selectedInvestigation.valueID;
                        await pInvestigation.CreateInvestigation(_pInvestigation);
                    }
                    else
                    {
                        //handle non valid guid format.
                        Guid valueID = Guid.NewGuid();
                        _investigation.valueID = valueID.ToString();
                        _investigation.InvestigationName = selectedInvestigation.InvestigationName;
                        await gInvestigation.Create(_investigation);
                        int uhid = Convert.ToInt32(patientModel.Uhid);
                        _pInvestigation.pID = ID;
                        _pInvestigation.uID = uhid;
                        _pInvestigation.valueID = valueID.ToString();
                        await pInvestigation.CreateInvestigation(_pInvestigation);
                    }
                }
            }
        }

        private async Task CreateAdvice()
        {
            IEnumerable<GenAdvice> SelectedAdvices = await this.MultiAdvice.GetItemsAsync();
            if (SelectedAdvices != null)
            {
                foreach (var selectedAdvice in SelectedAdvices)
                {
                    if (Guid.TryParse(selectedAdvice.valueID, out Guid outputGuid))
                    {
                        int uhid = Convert.ToInt32(patientModel.Uhid);
                        _pAdvice.pID = ID;
                        _pAdvice.uID = uhid;
                        _pAdvice.valueID = selectedAdvice.valueID;
                        await pAdvice.CreateAdvice(_pAdvice);
                    }
                    else
                    {
                        //handle non valid guid format.
                        Guid valueID = Guid.NewGuid();
                        _advice.valueID = valueID.ToString();
                        _advice.AdviceName = selectedAdvice.AdviceName;
                        await gAdvice.Create(_advice);
                        int uhid = Convert.ToInt32(patientModel.Uhid);
                        _pAdvice.pID = ID;
                        _pAdvice.uID = uhid;
                        _pAdvice.valueID = valueID.ToString();
                        await pAdvice.CreateAdvice(_pAdvice);
                    }
                }
            }
        }

        //Diagnosis
        private async Task CreateDiagnosis()
        {
            IEnumerable<GenDignosis> SelectedDignosiss = await this.MultiDignosis.GetItemsAsync();
            if (SelectedDignosiss != null)
            {
                foreach (var selecteddignosis in SelectedDignosiss)
                {
                    if (Guid.TryParse(selecteddignosis.valueID, out Guid outputGuid))
                    {
                        int uhid = Convert.ToInt32(patientModel.Uhid);
                        _pDiagnosis.pID = ID;
                        _pDiagnosis.uID = uhid;
                        _pDiagnosis.valueID = selecteddignosis.valueID;
                        await pDaignosis.CreateDiagnosis(_pDiagnosis);
                    }
                    else
                    {
                        //handle non valid guid format.
                        Guid valueID = Guid.NewGuid();
                        _dignosis.valueID = valueID.ToString();
                        _dignosis.DignosisName = selecteddignosis.DignosisName;
                        await gDignosis.Create(_dignosis);
                        int uhid = Convert.ToInt32(patientModel.Uhid);
                        _pDiagnosis.pID = ID;
                        _pDiagnosis.uID = uhid;
                        _pDiagnosis.valueID = valueID.ToString();
                        await pDaignosis.CreateDiagnosis(_pDiagnosis);
                    }
                }
            }
        }

        //Static Content
        List<WhenTake> LocalData = new List<WhenTake>
        {
    new WhenTake() { ID= "1-1-1-1", Text= "1-1-1-1" },
    new WhenTake() { ID= "1-0-0-1", Text= "1-0-0-1" },
         };

        private List<ToastModel> Toast = new List<ToastModel>
    {
      /*0*/  new ToastModel{ Title = "Warning!", Content="There was a problem with your network connection.", CssClass="e-toast-warning", Icon="e-warning toast-icons" },
      /*1*/  new ToastModel{ Title = "Success!", Content="Patient Registred Successfully.", CssClass="e-toast-success", Icon="e-success toast-icons" },
       /*2*/ new ToastModel{ Title = "Error!", Content="A problem has been occurred while submitting your data.", CssClass="e-toast-danger", Icon="e-error toast-icons" },
       /*3*/ new ToastModel{ Title = "Information!", Content="Please read the comments carefully.", CssClass="e-toast-info", Icon="e-info toast-icons" },
       /*4*/ new ToastModel{ Title = "Warning!", Content="Please Enter Medicine Name.",  CssClass="e-toast-warning", Icon="e-warning toast-icons"},
       /*5*/ new ToastModel{ Title = "Warning!", Content="Please Enter Phone.",  CssClass="e-toast-warning", Icon="e-warning toast-icons" },
       /*6*/ new ToastModel{ Title = "Warning!", Content="Please Enter Address.", CssClass="e-toast-warning", Icon="e-warning toast-icons"},
       /*7*/ new ToastModel{ Title = "Warning!", Content="Please Enter City.", CssClass="e-toast-warning", Icon="e-warning toast-icons"},
       /*8*/ new ToastModel{ Title = "Warning!", Content="Please Choose Doctor.", CssClass="e-toast-warning", Icon="e-warning toast-icons"},
       /*9*/ new ToastModel{ Title = "Warning!", Content="Please Choose OPD Type.", CssClass="e-toast-warning", Icon="e-warning toast-icons"},
    };
    }


}
