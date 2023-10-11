using Client.Service.Global;
using Microsoft.AspNetCore.Components;
using Model;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.RichTextEditor;

namespace Client.Pages.PatientSection
{
    public partial class Prescription : ComponentBase
    {
        [Parameter]
     
        public int ID { get; set; }
       
        private Patient patientModel = new Patient();

        //Complain
        private pComplain _pComplain = new pComplain();
        SfMultiSelect<string[], GenComplaints> MultiComplain;
        public string[] MultiCom { get; set; } = new string[] { };
        public List<GenComplaints> GenComplaintsList { get; set; }
        private GenComplaints _complaints = new GenComplaints();

        //Advice
        //private pComplain _pComplain = new pComplain();
        SfMultiSelect<string[], GenAdvice> MultiAdvice;
        public string[] MultiAdv { get; set; } = new string[] { };
        public List<GenAdvice> GenAdviceList { get; set; }
        private GenAdvice _advice = new GenAdvice();
        
        //Diagnosis
        //private pComplain _pComplain = new pComplain();
        SfMultiSelect<string[], GenDignosis> MultiDignosis;
        public string[] MultiDig { get; set; } = new string[] { };
        public List<GenDignosis> GenDignosisList { get; set; }
        private GenDignosis _dignosis = new GenDignosis();

        //Investigation
        //private pComplain _pComplain = new pComplain();
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
        async Task handelCreate()
        {
            var response = await pService.CreatePatient(patientModel);
            if (response != null)
            {

                patientModel.Name = "";
                patientModel.Address = "";
                patientModel.City = "";
                patientModel.Phone = "";
                patientModel.Opdfess = 0;
                patientModel.Opdtype = "";
            }
            else
            {

            }
        }
        async Task createComplain()
        {
            CreateComplaint();
            CreateDiagnosis();
            CreateAdvice();
            CreateInvestigation();
            CreateMedicine();
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
            if(SelectedComplains !=null)
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
            if(SelectedInvestigations !=null)
            { 
            foreach (var selectedInvestigation in SelectedInvestigations)
            {
                if (Guid.TryParse(selectedInvestigation.valueID, out Guid outputGuid))
                {
                    int uhid = Convert.ToInt32(patientModel.Uhid);
                    _pComplain.pID = ID;
                    _pComplain.uID = uhid;
                    _pComplain.valueID = selectedInvestigation.valueID;
                    await pComplain.CreateComplain(_pComplain);
                }
                else
                {
                    //handle non valid guid format.
                    Guid valueID = Guid.NewGuid();
                    _investigation.valueID = valueID.ToString();
                    _investigation.InvestigationName = selectedInvestigation.InvestigationName;
                    await gInvestigation.Create(_investigation);
                    int uhid = Convert.ToInt32(patientModel.Uhid);
                    _pComplain.pID = ID;
                    _pComplain.uID = uhid;
                    _pComplain.valueID = valueID.ToString();
                    await pComplain.CreateComplain(_pComplain);
                }
            }
            }
        }

        private async Task CreateAdvice()
        {
            IEnumerable<GenAdvice> SelectedAdvices = await this.MultiAdvice.GetItemsAsync();
            if(SelectedAdvices !=null)
            { 
            foreach (var selectedAdvice in SelectedAdvices)
            {
                if (Guid.TryParse(selectedAdvice.valueID, out Guid outputGuid))
                {
                    int uhid = Convert.ToInt32(patientModel.Uhid);
                    _pComplain.pID = ID;
                    _pComplain.uID = uhid;
                    _pComplain.valueID = selectedAdvice.valueID;
                    await pComplain.CreateComplain(_pComplain);
                }
                else
                {
                    //handle non valid guid format.
                    Guid valueID = Guid.NewGuid();
                    _advice.valueID = valueID.ToString();
                    _advice.AdviceName = selectedAdvice.AdviceName;
                    await gAdvice.Create(_advice);
                    int uhid = Convert.ToInt32(patientModel.Uhid);
                    _pComplain.pID = ID;
                    _pComplain.uID = uhid;
                    _pComplain.valueID = valueID.ToString();
                    await pComplain.CreateComplain(_pComplain);
                }
            }
            }
        }

        //Diagnosis
        private async Task CreateDiagnosis()
        {
            IEnumerable<GenDignosis> SelectedDignosiss = await this.MultiDignosis.GetItemsAsync();
            if(SelectedDignosiss !=null)
            { 
            foreach (var selecteddignosis in SelectedDignosiss)
            {
                if (Guid.TryParse(selecteddignosis.valueID, out Guid outputGuid))
                {
                    int uhid = Convert.ToInt32(patientModel.Uhid);
                    _pComplain.pID = ID;
                    _pComplain.uID = uhid;
                    _pComplain.valueID = selecteddignosis.valueID;
                    await pComplain.CreateComplain(_pComplain);
                }
                else
                {
                    //handle non valid guid format.
                    Guid valueID = Guid.NewGuid();
                    _dignosis.valueID = valueID.ToString();
                    _dignosis.DignosisName = selecteddignosis.DignosisName;
                    await gDignosis.Create(_dignosis);
                    int uhid = Convert.ToInt32(patientModel.Uhid);
                    _pComplain.pID = ID;
                    _pComplain.uID = uhid;
                    _pComplain.valueID = valueID.ToString();
                    await pComplain.CreateComplain(_pComplain);
                }
            }
            }
        }
    }
}
