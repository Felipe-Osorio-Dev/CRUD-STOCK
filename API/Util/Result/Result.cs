namespace API.Util.Result
{
    public class Result
    {
        public bool IsSuccess { get; }
        public string MessageError { get; }

        protected Result(bool isSuccess, string messageError)
        {
            IsSuccess = isSuccess;
            MessageError = messageError;
        }

        public static Result Success() => new(true, string.Empty);
        public static Result Failure(string messageError) => new(false, messageError);
    }

    public class Result<T> : Result
    {
        public T Data { get; }

        private Result(bool isSuccess, string messageError, T data) : base(isSuccess, messageError)
        {
            Data = data;
        }

        public static Result<T> Success(T data) => new(true, string.Empty, data);
        public static new Result<T> Failure(string messageError) => new(true, string.Empty, default!);
    }
}
