using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAC.API.Responses
{
    public class ApiResponse<T>
    {

        public T Data  { get; set; }

        public  int Size { get; set; }

        public ApiResponse(T data)
        {
            Data = data;
        }

        public ApiResponse(T data, int size)
        {
            Data = data;
            Size = size;
        }
    }
}
