namespace Slat.Core
{
    public class ApiResponse
    {
        public bool Successful => ErrorMessage == null;

        public string ErrorMessage { get; set; }

        public object Result { get; set; }

        public object WarningResult { get; set; }

        public object ErrorResult { get; set; }
    }

    public class ApiResponse<TResult, TWarningResult, TErrorResult> : ApiResponse
        where TWarningResult : WarningResult
        where TErrorResult : ErrorResult, new()
    {
        public new TResult Result { get; set; }

        public new TWarningResult WarningResult { get; set; }

        public new TErrorResult ErrorResult { get; set; }
    }
}
