namespace Calculater.Models
{
    public class Calculation
    {
        public int Id { get; set; }
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Operation { get; set; }
        public double Result { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
