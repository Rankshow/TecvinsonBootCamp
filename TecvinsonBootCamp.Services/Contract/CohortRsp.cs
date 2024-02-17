namespace TecvinsonBootCamp.Services.Contract
{
    public class CohortRsp<T> : BaseResponse
    {
        public T? Result { get; set; }
    }
}
