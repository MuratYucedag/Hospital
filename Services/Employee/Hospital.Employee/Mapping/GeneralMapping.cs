using AutoMapper;
using Hospital.Employee.Dtos.DepartmentDtos;
using Hospital.Employee.Dtos.DoctorDtos;
using Hospital.Employee.Entities;

namespace Hospital.Employee.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Department, ResultDepartmentDto>().ReverseMap();
            CreateMap<Department, CreateDepartmentDto>().ReverseMap();
            CreateMap<Department, UpdateDepartmentDto>().ReverseMap();
            CreateMap<Department, GetByIdDepartmentDto>().ReverseMap();

            CreateMap<Doctor, ResultDoctorDto>().ReverseMap();
            CreateMap<Doctor, CreateDoctorDto>().ReverseMap();
            CreateMap<Doctor, UpdateDoctorDto>().ReverseMap();
            CreateMap<Doctor, GetByIdDoctorDto>().ReverseMap();
        }
    }
}
