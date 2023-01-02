using Express.Recurrence.Builder.Interfaces;

namespace Express.Recurrence.Interfaces
{
    public sealed class SubExtensionPattern : ISubExtensionPattern
    {
        public IPattern Months()
        {
            throw new System.NotImplementedException();
        }
    }

    public sealed class SubConstrainPattern : ISubConstrainPattern
    {
        private ISubExtensionPattern subExtensionPattern;

        public SubConstrainPattern()
        {
            subExtensionPattern= new SubExtensionPattern();
        }

        public IPattern Day()
        {
            throw new System.NotImplementedException();
        }

        public ISubExtensionPattern OfEvery(int every)
        {
            throw new System.NotImplementedException();
        }

        public IPattern OfMonth(Month month)
        {
            throw new System.NotImplementedException();
        }

        public IPattern WeekDuring(params Day[] day)
        {
            throw new System.NotImplementedException();
        }

        public IPattern WeekDay()
        {
            throw new System.NotImplementedException();
        }
    }

    public sealed class RecurrenceBuilder : ISubPattern
    {
        private ISubConstrainPattern subConstrainPattern;

        public RecurrenceBuilder()
        {
            subConstrainPattern= new SubConstrainPattern();
        }

        public ISubConstrainPattern Every()
        {
            throw new System.NotImplementedException();
        }

        public ISubConstrainPattern Every(int every)
        {
            throw new System.NotImplementedException();
        }
    }
}
