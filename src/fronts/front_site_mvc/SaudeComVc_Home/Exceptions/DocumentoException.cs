﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SaudeComVc_Home.Exceptions
{
    public class DocumentoException : Exception
    {
        public DocumentoException()
        {
        }

        public DocumentoException(string message) : base(message)
        {
        }

        public DocumentoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DocumentoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}