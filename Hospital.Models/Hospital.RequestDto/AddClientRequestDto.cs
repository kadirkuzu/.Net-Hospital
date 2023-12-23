namespace Hospital.Models.Hospital.RequestDto
{
    public record AddClinicRequestDto (
        string Name ,
        Guid DepartmentId
    );
}
