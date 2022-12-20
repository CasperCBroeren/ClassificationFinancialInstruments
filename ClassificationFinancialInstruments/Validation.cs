
namespace ClassificationFinancialInstruments
{
    public record CfiError(string Message);

    public class CfiValidation
    {
        public bool Success { get; }
        public bool Failed => !Success;

        public ClassificationFinancialInstrument? Data { get; }

        public CfiError? Error { get; }

        public CfiValidation(ClassificationFinancialInstrument data)
        {
            Success = true;
            Data = data;
        }

        public void Apply(Action<ClassificationFinancialInstrument> onSuccess, Action<CfiError> onError)
        {
            if (Success)
            {
                onSuccess(Data!);
            }
            else 
            {
                onError(Error!);
            }
        }

        public void Apply(Action<ClassificationFinancialInstrument> onSuccess)
        {
            if (Success)
            {
                onSuccess(Data!);
            }            
        }

        public T Apply<T>(Func<ClassificationFinancialInstrument, T> onSuccess, Func<CfiError, T> onError)
        {
            if (Success)
            {
                return onSuccess(Data!);
            }
            else
            {
                return onError(Error!);
            }
        }

        public T Apply<T>(Func<ClassificationFinancialInstrument, T> onSuccess)
        {
            if (Success)
            {
                return onSuccess(Data!);
            }
            return default!;
        }

        public CfiValidation(CfiError error)
        { 
            Error = error;
        }

    }
}
