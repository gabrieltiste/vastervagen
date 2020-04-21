using System;
using System.Collections.Generic;
using System.Text;
using Tiste.Feature.BeautifulResponse.Models;

namespace Tiste.Feature.BeautifulResponse.Contracts
{
    public interface IBeautifulResponseService
    {
        public Result GetBeautifulOkResponse(List<IDataEntity> data = null);

        public Result GetBeautifulBadRequestResponse(List<Error> errors);
    }
}
