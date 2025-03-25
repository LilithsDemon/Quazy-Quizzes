using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Status
{
    class CodeStatus
    {
        public int _statusCode { get; protected set; } = 0;
        public string _statusMessage { get; protected set; } = "";

        public CodeStatus(int statusCode, string statusMessage)
        {
            this._statusCode = statusCode;
            this._statusMessage = statusMessage;
        }
    }
}