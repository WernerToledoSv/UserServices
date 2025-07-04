﻿namespace Domain.Entities.BaseResponse
{
    public class ListResponse<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public IList<T> Items { get; set; }
    }
}
