﻿using System;
using System.Xml.Linq;

namespace Alexa.NET.Response.Ssml
{
    public class PlainText:IParagraphSsml,ISentenceSsml
    {
        public PlainText()
        {
            
        }

        public PlainText(string text)
        {
            Text = text;
        }

        public string Text { get; set; }

        public XNode ToXml()
        {
            return new XText(Text);
        }
    }
}
