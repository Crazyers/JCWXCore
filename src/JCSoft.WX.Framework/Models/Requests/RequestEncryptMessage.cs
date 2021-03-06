﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace JCSoft.WX.Framework.Models.Requests
{
    public class RequestEncryptMessage : RequestMessage
    {
        public RequestEncryptMessage(XElement xml) : base(xml)
        {
            EncryptMessage = xml.Element("Encrypt").GetValue();
        }

        public string EncryptMessage { get; set; }

        public override MsgType MsgType => MsgType.Text;
        
    }
}
