using System;

namespace SmartCCV.SharedKernel
{
    public interface IValidationRequest
    {
        /// <summary>
        /// Gets or sets the card number.
        /// </summary>
        /// <value>
        /// The card number.
        /// </value>
        string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the security code.
        /// </summary>
        /// <value>
        /// The security code.
        /// </value>
        string SecurityCode { get; set; }     

        /// <summary>
        /// Gets or sets a value indicating whether [validate credit card numbers against card type].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [validate credit card numbers against card type]; otherwise, <c>false</c>.
        /// </value>
        bool ValidateCreditCardNumbersAgainstCardType { get; set; }
    }
}
