namespace CampusPlacement.Application.Interfaces.Services;

/// <summary>
/// Abstraction for accessing details of the currently authenticated user.
/// </summary>
public interface ICurrentUserService
{
    string? UserId { get; }
    string? UserName { get; }
    string? Email { get; }
    bool IsAuthenticated { get; }
    IReadOnlyList<string> Roles { get; }
}
