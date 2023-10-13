using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.DTO;
using StewardAPI.Models;
using StewardAPI.Repository.prescription;
using StewardAPI.Repository.User;

namespace StewardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientComplaintController : ControllerBase
    {
        private readonly IComplaintRepo _complaintRepo;
        private readonly IAdvice _advice;
        private readonly IDiagnosis _diagnosis;
        private readonly Iinvestigations _iinvestigations;
        private readonly IPatientMedicineRepo _medicineRepo;

        public PatientComplaintController(IComplaintRepo complaintRepo,IAdvice advice,IDiagnosis diagnosis,Iinvestigations iinvestigations,IPatientMedicineRepo medicineRepo)
        {
            _complaintRepo = complaintRepo;
            _advice = advice;
            _diagnosis = diagnosis;
            _iinvestigations = iinvestigations;
            _medicineRepo = medicineRepo;
        }
        [HttpPost("ComplaintCreate")]
        public async Task<ActionResult<ServiceResponse<pComplain>>> Create(pComplain complain)
        {
            var response = await _complaintRepo.Create(complain);
            return Ok(response);
        }  
        [HttpPost("AdviceCreate")]
        public async Task<ActionResult<ServiceResponse<pAdvice>>> Create(pAdvice padvice)
        {
            var response = await _advice.Create(padvice);
            return Ok(response);
        } 
        [HttpPost("DiagnosisCreate")]
        public async Task<ActionResult<ServiceResponse<pDignosis>>> Create(pDignosis pdignosis)
        {
            var response = await _diagnosis.Create(pdignosis);
            return Ok(response);
        }
        [HttpPost("InvestigationCreate")]
        public async Task<ActionResult<ServiceResponse<pInvestigation>>> Create(pInvestigation pinvestigation)
        {
            var response = await _iinvestigations.Create(pinvestigation);
            return Ok(response);
        } 
        [HttpPost("PatientMedicineCreate")]
        public async Task<ActionResult<ServiceResponse<PatientMedicines>>> Create(PatientMedicines patientMedicines)
        {
            var response = await _medicineRepo.CreatePatientmedicine(patientMedicines);
            return Ok(response);
        }
        [HttpGet("getMedicines")]
        public async Task<ActionResult<ServiceResponse<List<PatientMedicines>>>> GetMedicinesID(int PID)
        {
            var result = await _medicineRepo.GetPatientmedicine(PID);
            return Ok(result);
        } 
        [HttpGet("getInvestigations")]
        public async Task<ActionResult<ServiceResponse<List<GenLabInvestigation>>>> GetInvestigationsID(int PID)
        {
            var result = await _iinvestigations.GetPatientInvestigations(PID);
            return Ok(result);
        } 
        [HttpGet("getComplaints")]
        public async Task<ActionResult<ServiceResponse<List<GenComplaints>>>> GetComplaintsID(int PID)
        {
            var result = await _complaintRepo.GetPatientComplaints(PID);
            return Ok(result);
        } 
        [HttpGet("getAdvices")]
        public async Task<ActionResult<ServiceResponse<List<GenAdvice>>>> GetAdvicesID(int PID)
        {
            var result = await _advice.GetPatientAdvices(PID);
            return Ok(result);
        }
         [HttpGet("getDiagnosis")]
        public async Task<ActionResult<ServiceResponse<List<GenDignosis>>>> GetDiagnosisID(int PID)
        {
            var result = await _diagnosis.GetPatientDiagnosis(PID);
            return Ok(result);
        }

    }
}
