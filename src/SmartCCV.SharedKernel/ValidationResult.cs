using System.Collections.Generic;

namespace SmartCCV.SharedKernel
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> Errors { get; set; }
        public ValidationResult()
        {
            IsValid = true;
            Errors = new List<string>();
        }

        public void AddError(string errorMessage)
        {
            Errors.Add(errorMessage);
        }
    }
}