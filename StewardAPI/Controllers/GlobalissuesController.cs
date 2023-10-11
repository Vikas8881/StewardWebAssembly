using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using StewardAPI.Repository.Global;

namespace StewardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GlobalissuesController : ControllerBase
    {
        private readonly IGlobalComplaint _globalComplaint;
        private readonly IGlobalAdvice _globalAdvice;
        private readonly IGlobalDignosis _globalDignosis;
        private readonly IGlobalInvestigation _globalInvestigation;
        private readonly IGlobalMedicine _globalMedicine;

        public GlobalissuesController(IGlobalComplaint globalComplaint,IGlobalAdvice globalAdvice,IGlobalDignosis globalDignosis,IGlobalInvestigation globalInvestigation,IGlobalMedicine globalMedicine)
        {
            _globalComplaint = globalComplaint;
            _globalAdvice = globalAdvice;
            _globalDignosis = globalDignosis;
            _globalInvestigation = globalInvestigation;
            _globalMedicine = globalMedicine;
        }
        //Complain
        [HttpPost]
        [Route("GComplainCreate")]
        public async Task<ActionResult<ServiceResponse<GenComplaints>>> Create(GenComplaints genComplaints)
        {
            var response=await _globalComplaint.Create(genComplaints);
            return response;
        }
        [HttpGet]
        [Route("GComplainget")]
        public async Task<ActionResult<ServiceResponse<List<GenComplaints>>>>GetComplaint()
        {
            var result = await _globalComplaint.GetComplaints();
            return result;
        }

        //Advice
        [HttpPost]
        [Route("GAdviceCreate")]
        public async Task<ActionResult<ServiceResponse<GenAdvice>>> Create(GenAdvice genGenAdvice)
        {
            var response = await _globalAdvice.Create(genGenAdvice);
            return response;
        }
        [HttpGet]
        [Route("GAdviceget")]
        public async Task<ActionResult<ServiceResponse<List<GenAdvice>>>> GetAdvice()
        {
            var result = await _globalAdvice.GetAdvice();
            return result;
        }

        //Dignosis
        [HttpPost]
        [Route("GDignosisCreate")]
        public async Task<ActionResult<ServiceResponse<GenDignosis>>> Create(GenDignosis genGenDignosis)
        {
            var response = await _globalDignosis.Create(genGenDignosis);
            return response;
        }
        [HttpGet]
        [Route("GDignosisget")]
        public async Task<ActionResult<ServiceResponse<List<GenDignosis>>>> GetDignosis()
        {
            var result = await _globalDignosis.GetDignosis();
            return result;
        }

        //Investigations
        [HttpPost]
        [Route("GInvestigationCreate")]
        public async Task<ActionResult<ServiceResponse<GenLabInvestigation>>> Create(GenLabInvestigation genGenInvestigation)
        {
            var response = await _globalInvestigation.Create(genGenInvestigation);
            return response;
        }
        [HttpGet]
        [Route("GInvestigationget")]
        public async Task<ActionResult<ServiceResponse<List<GenLabInvestigation>>>> GetInvestigation()
        {
            var result = await _globalInvestigation.GetInvestigation();
            return result;
        }

        //Medicine
        [HttpPost]
        [Route("GMedicineCreate")]
        public async Task<ActionResult<ServiceResponse<GenMedicine>>> Create(GenMedicine genMedicine)
        {
            var response = await _globalMedicine.Create(genMedicine);
            return response;
        }
        [HttpGet]
        [Route("GMedicineget")]
        public async Task<ActionResult<ServiceResponse<List<GenMedicine>>>> GetMedicine()
        {
            var result = await _globalMedicine.GetMedicine();
            return result;
        }
    }
}
