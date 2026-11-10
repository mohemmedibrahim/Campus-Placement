namespace CampusPlacement.Application.Interfaces.Services;

/// <summary>
/// Abstraction for system clock to ensure deterministic testing.
/// </summary>
public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
