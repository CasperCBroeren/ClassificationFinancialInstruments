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

        public CfiValidation(CfiError error)
        { 
            Error = error;
        }

    }
}
