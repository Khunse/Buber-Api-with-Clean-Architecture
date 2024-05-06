namespace BuberApi.Contracts.Authentication;

public record LoginRequest(
    string Email,
    string Password
);