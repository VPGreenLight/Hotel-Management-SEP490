﻿namespace HotelManagement.Models.ResponseDtos
{
    public class BaseResponseDto<T>
    {
        public int Status { get; set; }
        public string? Message { get; set; }
        public T? ResponseData { get; set; }
    }
}
