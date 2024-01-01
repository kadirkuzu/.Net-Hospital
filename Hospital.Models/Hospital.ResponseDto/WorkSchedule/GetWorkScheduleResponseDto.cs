namespace Hospital.Models.Hospital.ResponseDto
{
    public class GetWorkScheduleResponseDto
    {
        public Guid Id { get; set; }
        public ICollection<Doctor>? Doctors { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public GetWorkScheduleResponseDto(WorkSchedule workSchedule)
        {
            Id = workSchedule.Id;
            Doctors = workSchedule.Doctors ?? new List<Doctor>();
            Day = workSchedule.Day;
            StartTime = workSchedule.StartTime;
            EndTime = workSchedule.EndTime;
        }
        public GetWorkScheduleResponseDto()
        {
            
        }
    }
}
