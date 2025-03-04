using Hospital.Employee.Dtos.NurseDtos;

namespace Hospital.Employee.Services.NurseServices
{
    public interface INurserService
    {
        Task<List<ResultNurseDto>> GetAllNurseAsync();
        Task CreateNurseAsync(CreateNurseDto createNurseDto);
        Task UpdateNurseAsync(UpdateNurseDto updateNurseDto);
        Task DeleteNurseAsync(int id);
        Task<GetByIdNurseDto> GetByIdNurse(int id);
    }
}