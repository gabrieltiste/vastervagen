using System;
using System.Collections.Generic;
using Tiste.Feature.BeautifulResponse.Contracts;
using Tiste.Feature.BeautifulResponse.Models;

namespace Tiste.Feature.BeautifulResponse
{
    public class BeautifulResponseService : IBeautifulResponseService
    {
        public Result GetBeautifulOkResponse(List<IDataEntity> data = null)
        {
            Result response = CreateBeautifulResult()
                .SetSuccess(true)
                .SetData(data ?? new List<IDataEntity>());

            return ValidateBeautifulResponse(response);
        }

        public Result GetBeautifulBadRequestResponse(List<Error> errors)
        {
            throw new NotImplementedException();
        }

        private Result ValidateBeautifulResponse(Result result)
        {
            if (result.Success.Equals(null))
            {
                result.Errors.Add(new Error() { Code = 1, Message = "Success must be set on the Result object!" });
            }

            return result;
        }

        private Result CreateBeautifulResult()
        {
            return new Result() { Errors = new List<Error>() };
        }
    }
}
