using Hospital.Employee.Dtos.DoctorDtos;
using Hospital.Employee.Services.DoctorServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _DoctorService;
        public DoctorsController(IDoctorService DoctorService)
        {
            _DoctorService = DoctorService;
        }

        [HttpGet]
        public async Task<IActionResult> DoctorList()
        {
            var value = await _DoctorService.GetAllDoctorAsync();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDoctor(CreateDoctorDto createDoctorDto)
        {
            await _DoctorService.CreateDoctorAsync(createDoctorDto);
            return Ok("Ekleme başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            await _DoctorService.DeleteDoctorAsync(id);
            return Ok("Silme Başarılı");
        }

        [HttpGet("GetDoctor")]
        public async Task<IActionResult> GetDoctor(int id)
        {
            return Ok(await _DoctorService.GetByIdDoctor(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDoctor(UpdateDoctorDto updateDoctorDto)
        {
            await _DoctorService.UpdateDoctorAsync(updateDoctorDto);
            return Ok("Güncelleme işlemi başarılı");
        }
    }
}
