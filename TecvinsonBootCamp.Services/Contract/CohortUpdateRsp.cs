namespace TecvinsonBootCamp.Services.Contract
{
    public class CohortUpdateRsp<T> : BaseResponse
    {
        public T? Result { get; set; }
    }
}
