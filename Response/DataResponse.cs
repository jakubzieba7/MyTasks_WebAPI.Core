namespace MyTasks_WebAPI.Core.Response
{
    public class DataResponse<T> : Response
    {
        public T Data { get; set; }
    }
}
