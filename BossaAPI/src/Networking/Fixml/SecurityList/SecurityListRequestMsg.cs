﻿using System.Xml;

namespace pjank.BossaAPI.Fixml
{
    public class SecurityListRequestMsg : FixmlMsg
    {
        private readonly string symbol;

        private static uint nextId = 0;

        public uint Id;
        public string Username;
        public string Password;
        public string NewPassword;

        public SecurityListRequestMsg(string symbol)
        {
            this.symbol = symbol;
            Id = nextId++;
        }

        protected override void PrepareXmlMessage(string name)
        {
            base.PrepareXmlMessage("SecListReq");
            xml.SetAttribute("ReqID", Id.ToString());
            xml.SetAttribute("ListReqTyp", "4");

           var node = xmlDoc.CreateNode(XmlNodeType.Element, "Instrmt", "");
           XmlAttribute attr = xmlDoc.CreateAttribute("Sym");
           attr.Value = symbol;
           node.Attributes.Append(attr);
           // xml.AppendChild(node);
        }



    }
}