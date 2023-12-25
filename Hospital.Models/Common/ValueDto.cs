namespace Hospital.Models.Common
{
    public class ValueDto
    {
        public object Value { get; set; }
        public ValueDto(Guid value)
        {
            Value = value;
        }
        public ValueDto(string value)
        {
            Value = value;
        }
        public ValueDto(int value)
        {
            Value = value;
        }
    }
}
