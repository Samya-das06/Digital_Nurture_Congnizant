using System;
using System.Collections.Generic;
using System.Linq;
using Asp.Versioning;
using DatabaseContextRetailStore1.Application.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseContextRetailStore1.WebApi.Controllers.v1
{
    [ApiVersion("1")]
    public class DocController : BaseApiController
    {
        [HttpGet]
        public Dictionary<string, string> GetErrorCodes()
        {
            return Enum.GetValues(typeof(ErrorCode))
                 .Cast<ErrorCode>()
                 .ToDictionary(t => ((int)t).ToString(), t => t.ToString());
        }
    }
}
