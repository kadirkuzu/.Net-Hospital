namespace Hospital.Models.Hospital.RequestDto.Account
{
    public record LoginRequestDto(
        string Email,
        string Password
    );
}
