﻿/* Copyright (c) 2016 Acrolinx GmbH */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Acrolinx.Sdk.Sidebar.Documents
{
    public class Document : Acrolinx.Sdk.Sidebar.Documents.IDocument
    {
        public Document() : this("",Format.Text, "")
        {
        }
        public Document(string content, Format format, string reference)
        {
            Content = content;
            Format = format;
            Reference = reference;
        }

        public string Content
        {
            get;
            set;
        }

        public Format Format
        {
            get;
            set;
        }

        public string Reference
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Format.ToString() + ": " + Content;
        }
    }
}