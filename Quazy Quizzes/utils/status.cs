using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Status
{
    class CodeStatus
    {
        protected int _statusCode = 0;
        protected string _statusMessage = "";

        public CodeStatus(int statusCode, string statusMessage)
        {
            this._statusCode = statusCode;
            this._statusMessage = statusMessage;
        }
    }
}

