﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK.VocationalSchoolAutomason.Common.ResponsObjects
{
    public class Response<T> : Response, IResponse<T>
    {
        public T Data { get; set; }
        public List<CustomValidationError> ValidationErrors { get; set; }
        public Response(ResponseType responseType,T data) : base(responseType)
        {
            Data = data;
        }

        public Response(ResponseType responseType, string Message) : base(responseType, Message)
        {

        }

        public Response(ResponseType responseType, T data, List<CustomValidationError> errors) : base(responseType)
        {
            ValidationErrors = errors;
            Data = data;
        }
    }

}
