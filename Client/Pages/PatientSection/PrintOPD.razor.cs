using Microsoft.AspNetCore.Components;
using Model;

namespace Client.Pages.PatientSection
{
    public partial class PrintOPD : ComponentBase
    {
        [Parameter]

        public int ID { get; set; }

        private Patient patientModel = new Patient();
        List<PatientMedicines> _genMedicines { get; set; } = new List<PatientMedicines>();
        List<GenComplaints> _ComplaintsList { get; set; } = new List<GenComplaints>();
        List<GenAdvice> _pAdviceList { get; set; } = new List<GenAdvice>();
        List<GenDignosis> _pDignosisList { get; set; } = new List<GenDignosis>();
        List<GenLabInvestigation> _pInvestigationList { get; set; } = new List<GenLabInvestigation>();
        protected override async Task OnInitializedAsync()
        {
            //Patient
            var response = await pService.GetPatient(ID);
            if (response.Success)
            {
                patientModel.Name = response.Data.Name;
                patientModel.Uhid = response.Data.Uhid;
            }
            //Medicine
            var responseMedicine = await _PatientMedicineRepo.GetMedicines(ID);
            if (responseMedicine.Success)
            {
                _genMedicines = responseMedicine.Data;
            }

            //Investigation
            var responseInvestigation = await _PatientInvestigationRepo.GetInvestigation(ID);
            if (responseInvestigation.Success)
            {
                _pInvestigationList = responseInvestigation.Data;
            }
            //Diagnosis
            var responseDiagnosis = await _PatientDiagnosisRepo.GetDiagnosis(ID);
            if (responseDiagnosis.Success)
            {
                _pDignosisList = responseDiagnosis.Data;
            }

            //Advice
            var responseAdvice = await _PatientAdviceRepo.GetAdvice(ID);
            if (responseAdvice.Success)
            {
                _pAdviceList = responseAdvice.Data;
            }

            //Complaints
            var responseComplaint = await _PatientComplainRepo.GetComplain(ID);
            if (responseComplaint.Success)
            {
                _ComplaintsList = responseComplaint.Data;
            }
        }

    }
}
