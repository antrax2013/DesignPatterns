namespace Adapter;

public record User(Guid Id, string FirstName, string LastName, string? ExternalId = null);