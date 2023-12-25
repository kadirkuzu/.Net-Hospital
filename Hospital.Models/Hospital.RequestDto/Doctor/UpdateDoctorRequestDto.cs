namespace Hospital.Models.Hospital.RequestDto.Doctor
{
    public record UpdateDoctorRequestDto
    (
        string Name,
        string Surname,
        string Email,
        string Phone
    );
}
