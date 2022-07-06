using System.Threading.Tasks;

namespace SmartCCV.SharedKernel
{
    public interface ICardValidator
    {
        Task<ValidationResult> Validate(IValidationRequest request);
    }
}
