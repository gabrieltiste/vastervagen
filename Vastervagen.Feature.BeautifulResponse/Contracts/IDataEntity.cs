using System;
using System.Collections.Generic;
using System.Text;

namespace Tiste.Feature.BeautifulResponse.Contracts
{
    public interface IDataEntity
    {
        public Dictionary<string, string> Links { get; set; }
    }
}
