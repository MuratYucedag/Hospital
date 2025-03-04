using AutoMapper;
using Hospital.Employee.Context;
using Hospital.Employee.Dtos.DepartmentDtos;
using Hospital.Employee.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Employee.Services.DepartmentServices
{
    public class DepartmentService : IDepartmentService
    {
        private readonly EmployeeContext _context;
        private readonly IMapper _mapper;
        public DepartmentService(EmployeeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreateDepartmentAsync(CreateDepartmentDto createDepartmentDto)
        {
            var values = _mapper.Map<Department>(createDepartmentDto);
            await _context.Departments.AddAsync(values);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteDepartmentAsync(int id)
        {
            var values = await _context.Departments.FindAsync(id);
            _context.Departments.Remove(values);
            await _context.SaveChangesAsync();
        }
        public async Task<List<ResultDepartmentDto>> GetAllDepartmentAsync()
        {
            var values = await _context.Departments.ToListAsync();
            return _mapper.Map<List<ResultDepartmentDto>>(values);
        }
        public async Task<GetByIdDepartmentDto> GetByIdDepartment(int id)
        {
            var values = await _context.Departments.FindAsync(id);
            return _mapper.Map<GetByIdDepartmentDto>(values);
        }
        public async Task UpdateDepartmentAsync(UpdateDepartmentDto updateDepartmentDto)
        {
            var values = _mapper.Map<Department>(updateDepartmentDto);
            _context.Departments.Update(values);
            await _context.SaveChangesAsync();
        }
    }
}
