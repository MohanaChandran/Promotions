namespace Promotion.Response
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseResponse<T>
    {
        public BaseResponse()
        {
            Data = default(T);
        }


        public BaseResponse(T t)
        {
            Data = t;
        }

        public T Data { get; }
        public ErrorDetails ErrorDetails { get; set; }
    }



    public class ErrorDetails
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
