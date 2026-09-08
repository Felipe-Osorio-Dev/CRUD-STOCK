namespace APP.Util.CustomArgs
{
    public class CustomEventArgs<T> : EventArgs
    {
        public T Value { get; }

        public CustomEventArgs(T value)
        {
            Value = value;
        }
    }
}
