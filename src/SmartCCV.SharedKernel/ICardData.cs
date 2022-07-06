using System.Collections.Generic;

namespace SmartCCV.SharedKernel
{
    public interface ICardData
    {
        List<Rule> Rules { get; set; }
        int CvvLength { get; set; }
        string CardBrandName { get; set; }
    }
}
