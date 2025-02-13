namespace Domain.Entities.BaseResponse
{
    public class ObjectResponse<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public T Item { get; set; }

    }
}
