using ToDoList.Application.Interfaces;
using ToDoList.Core.Models;

namespace ToDoList.Application.Servicies;

public class TargetsService : ITargetsService
{
    private readonly ITargetRepository _targetRepository;

    public TargetsService(ITargetRepository targetRepository)
    {
        _targetRepository = targetRepository;
    }

    public async Task<Guid> CreateTarget(Target target)
    {
        return await _targetRepository.Create(target);
    }

    public async Task<List<Target>> GetAllTarget()
    {
        return await _targetRepository.Get();
    }

    public async Task<Guid> UpdateTarget(
        Guid id,
        string name,
        string description
        )
    {
        return await _targetRepository.Update(id, name, description);
    }

    public async Task<Guid> DeleteTarget(Guid id)
    {
        return await _targetRepository.Delete(id);
    }
}
