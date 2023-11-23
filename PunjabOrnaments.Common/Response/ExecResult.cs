namespace PunjabOrnaments.Common.Response
{

    public class ExecResult<TDataType>
    {
        public bool HasErrors { get; set; }

        public bool IsSystemError { get; set; }

        public string Message { get; set; }

        public TDataType Data { get; set; }
    }
}

