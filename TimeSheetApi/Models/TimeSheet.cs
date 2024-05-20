namespace SimpleTimeSheets.Models
{
    public class TimeSheet
    {
        public int Id { get; set; }
        public int WeekNumber { get; set; }
        public double HoursWorkedOnSunday { get; set; }
        public double HoursWorkedOnMonday { get; set; }
        public double HoursWorkedOnTuesday { get; set; }
        public double HoursWorkedOnWednesday { get; set; }
        public double HoursWorkedOnThursday { get; set; }
        public double HoursWorkedOnFriday { get; set; }
        public double HoursWorkedOnSaturday { get; set; }

    }
}
