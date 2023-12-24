namespace Hospital.Models.Hospital.RequestDto.Clinic
{
    public record AddClinicRequestDto(
        string Name,
        Guid DepartmentId
    );
}
