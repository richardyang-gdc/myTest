﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AOBMockService.WebAPI.Web.Models
{
    /// <summary>
    /// A strongly typed JSend wrapper for Web API responses.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class JSendResponse<T>
        where T : class
    {
        private JSendResponse()
        {

        }

        [JsonConverter(typeof(StringEnumConverter))]
        public JSendResponseStatus Status { get; set; }

        public String Message { get; set; }

        public dynamic Data { get; set; }

        public Int32? Code { get; set; }

        public static JSendResponse<T> CreateError(String message)
        {
            JSendResponse<T> response = new JSendResponse<T>();
            response.Status = JSendResponseStatus.Error;
            response.Message = message;
            response.Data = null;
            response.Code = null;
            return response;
        }

        public static JSendResponse<T> CreateError(String message, Int32? code, dynamic data)
        {
            JSendResponse<T> response = new JSendResponse<T>();
            response.Status = JSendResponseStatus.Error;
            response.Message = message;
            response.Data = data;
            response.Code = code;
            return response;
        }

        public static JSendResponse<T> CreateFail(dynamic data)
        {
            JSendResponse<T> response = new JSendResponse<T>();
            response.Status = JSendResponseStatus.Fail;
            response.Data = data;
            return response;
        }
        public static JSendResponse<T> CreateFail(string message, int? code, dynamic data)
        {
            JSendResponse<T> response = new JSendResponse<T>();
            response.Status = JSendResponseStatus.Fail;
            response.Message = message;
            response.Data = data;
            response.Code = code;
            return response;
        }
       
        public static JSendResponse<T> CreateSuccess(T data)
        {
            JSendResponse<T> response = new JSendResponse<T>();
            response.Status = JSendResponseStatus.Success;
            response.Data = data;
            return response;
        }


    }
}