using System;
using System.Collections.Generic;

namespace Express.Recurrence.Builder.Interfaces
{
    public interface IPattern
    {
        IEnumerable<DateTime> Generate(DateTime startDate, DateTime endDate);
        IEnumerable<DateTime> Generate(DateTime startDate, int endByOccurances);
    }

        public interface IAdvancedSubPattern
    {
        ISubExtensionPattern Every(SpecialDay logicalStart, Day day);
        IPattern OfMonth(Month month);
    }

    public interface ISubPattern
    {
        ISubConstrainPattern Every();
        ISubConstrainPattern Every(int every);
    }

    public interface ISubConstrainPattern
    {
        IPattern OfMonth(Month month);
        IPattern Day();
        IPattern WeekDay();
        IPattern WeekDuring(params Day[] day);
        ISubExtensionPattern OfEvery(int every);
    }

    public interface ISubExtensionPattern
    {
        IPattern Months();
    }
}
