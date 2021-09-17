using System;

namespace SpeedTypingASP.Service.Errors
{
    [Serializable]
    public class CoincidencesNotFoundException : Exception
    {
        public CoincidencesNotFoundException(string message)
            : base(message) { }
    }
}
