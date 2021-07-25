using System;

namespace Exceptions
{
    public class BaseException: Exception
    {
        public string ErrorCode { get; set; }


        public BaseException(string message, Exception ex) : base(message, ex)
        {

        }

        public BaseException(string message) : base(message)
        {

        }


        public BaseException(string message, string errorCode, Exception ex) : base(message, ex)
        {
            ErrorCode = errorCode;
        }
    }
}
