using AutoMapper;
using Hospital.Employee.Context;
using Hospital.Employee.Dtos.DoctorDtos;
using Hospital.Employee.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Employee.Services.DoctorServices
{
    public class DoctorService : IDoctorService
    {
        private readonly IMapper _mapper;
        private readonly EmployeeContext _context;
        public DoctorService(IMapper mapper, EmployeeContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task CreateDoctorAsync(CreateDoctorDto createDoctorDto)
        {
            var values = _mapper.Map<Doctor>(createDoctorDto);
            await _context.Doctors.AddAsync(values);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteDoctorAsync(int id)
        {
            var value = await _context.Doctors.FindAsync(id);
            _context.Doctors.Remove(value);
            await _context.SaveChangesAsync();
        }
        public async Task<List<ResultDoctorDto>> GetAllDoctorAsync()
        {
            var values = await _context.Doctors.ToListAsync();
            return _mapper.Map<List<ResultDoctorDto>>(values);
        }
        public async Task<GetByIdDoctorDto> GetByIdDoctor(int id)
        {
            var values = await _context.Doctors.FindAsync(id);
            return _mapper.Map<GetByIdDoctorDto>(values);
        }
        public async Task UpdateDoctorAsync(UpdateDoctorDto updateDoctorDto)
        {
            var values = _mapper.Map<Doctor>(updateDoctorDto);
            _context.Doctors.Update(values);
            await _context.SaveChangesAsync();
        }
    }
}
