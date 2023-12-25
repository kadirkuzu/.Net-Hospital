namespace Hospital.Models.Hospital.RequestDto.Doctor
{
    public record AddDoctorRequestDto
    (
        string Name,
        string SurName,
        string Email,
        string Phone,
        Guid ClinicId
    );
}
