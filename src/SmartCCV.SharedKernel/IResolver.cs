namespace SmartCCV.SharedKernel
{
    /// <summary>
    /// This interface should be implemented by different
    /// DI extensions.
    /// </summary>
    public interface IResolver
    {
        /// <summary>Gets the instance.</summary>
        /// <typeparam name="T">Generic Type.</typeparam>
        /// <returns>
        ///   <br />
        /// </returns>
        T Resolve<T>();
    }
}
