using System;

namespace Express.Recurrence
{
    public class DayReccurance : BasePattern
    {
        public Every Every { get; set; }
        public int Next { get; set; }
    }

    public class WeeklyReccurance : BasePattern
    {
        public int Next { get; set; }
        public bool Sunday { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
    }

    public class MonthlyReccurance : BasePattern
    {
        public int Next { get; set; }
        public int DayOfMonth { get; set; }
        public CONSTRAIN Constrain { get; set; }
        public SpecialDay LogicalStart { get; set; }
        public Day LogicalDay { get; set; }
        public int AdjustDays { get; set; }
    }

    public class YearlyReccurance : BasePattern
    {
        public int DayOfMonth { get; set; }
        public Month Month { get; set; }
        public CONSTRAIN Constrain { get; set; }
        public SpecialDay LogicalStart { get; set; }
        public Day LogicalDay { get; set; }
        public int AdjustDays { get; set; }
    }

    public class BasePattern
    {
        public DateTime StartDate { get; set; }
        public int MaxOccurance { get; set; }
        public EndMode EndMode { get; set; }
        public DateTime EndDate { get; set; }
    }

    public enum EndMode
    {
        ByOccurance,
        ByDate
    }

    public enum CONSTRAIN
    {
        SpecificDay,
        Logical,
    }
    public enum SpecialDay
    {
        First,
        Second,
        Third,
        Fourth,
        Last
    }
    public enum Day
    {
        Day, 
        Weekday, 
        WeekendDay, 
        Sunday, 
        Monday, 
        Tuesday, 
        Wednesday, 
        Thursday, 
        Friday, 
        Saturday
    }

    public enum Every
    {
        NDay,
        WeekDay
    }

    public enum Month
    {
        Jan,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec,
    }
}
