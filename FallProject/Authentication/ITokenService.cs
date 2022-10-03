
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERVICES.DTO;

namespace API.Authentication
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, string user);
    }
}