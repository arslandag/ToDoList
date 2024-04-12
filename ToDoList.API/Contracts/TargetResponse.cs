namespace ToDoList.API.Contracts;
public record TargetResponse(
    Guid Id,
    string Name,
    string Description
    );
