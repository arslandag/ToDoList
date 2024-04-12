using ToDoList.Core.Models;

namespace ToDoList.Application.Interfaces
{
    public interface ITargetsService
    {
        Task<Guid> CreateTarget(Target target);
        Task<Guid> DeleteTarget(Guid id);
        Task<List<Target>> GetAllTarget();
        Task<Guid> UpdateTarget(Guid id, string name, string description);
    }
}