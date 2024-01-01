namespace Hospital.Models.Hospital.RequestDto.WorkSchedules
{
    public class AddWorkScheduleRequestDto
    {
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
