﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.WX.Framework.Models.Exceptions
{
    public struct WXErrorCode
    {
        public const int AccessTokenIsExpired = 99;
        public const int CreateRequestFaild = 80;
        public const int FileNotFind = 82;
        public const int GetResponseFaild = 81;
        public const int InvalidReturnCode = 83;
    }
}
