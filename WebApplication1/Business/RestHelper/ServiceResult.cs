namespace Business.RestHelper
{
    public class ServiceResult<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResult{T}"/> class.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <param name="successMessage">The success message.</param>
        public ServiceResult(T result, string successMessage = "")
        {
            this.Result = result;
            this.HasError = false;
            this.HasSuccessMessage = !string.IsNullOrEmpty(successMessage);
            this.Message = successMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResult{T}"/> class.
        /// </summary>
        /// <param name="errorMessage">The error message.</param>
        public ServiceResult(string errorMessage)
        {
            this.Message = errorMessage;
            this.HasError = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResult{T}"/> class.
        /// </summary>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="errorcode">The errorcode.</param>
        public ServiceResult(string errorMessage, int errorcode)
        {
            if (errorcode != 0)
            {
                this.ErrorCode = errorcode.ToString();
            }

            this.Message = errorMessage;
            this.HasError = true;
        }

        /// <summary>
        /// Gets the error code.
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public string ErrorCode { get; private set; }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public T Result { get; private set; }

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance has error.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has error; otherwise, <c>false</c>.
        /// </value>
        public bool HasError { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance has success message.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has success message; otherwise, <c>false</c>.
        /// </value>
        public bool HasSuccessMessage { get; private set; }
    }
}
