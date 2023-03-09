﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteDentalClinic.Application.Models
{
    public class ApiResult<TEntity>
        where TEntity : class
    {
        private ApiResult(bool succeeded,TEntity result, IEnumerable<string> errors)
        {
            Succeeded = succeeded;
            Result = result;
            Errors = errors;
        }
        public bool Succeeded { get; set; }
        public TEntity Result { get; }
        public IEnumerable<string> Errors { get; }

        public static ApiResult<TEntity> Success (TEntity result)
        {
            return new ApiResult<TEntity>(true, result, new List<string>());
        }
        public static ApiResult<TEntity> Failure (IEnumerable<string> errors)
        {
            return new ApiResult<TEntity>(false, default, errors);
        }
    }
}