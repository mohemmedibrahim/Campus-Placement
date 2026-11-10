using CampusPlacement.Application.Interfaces.Services;

namespace CampusPlacement.Application.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
