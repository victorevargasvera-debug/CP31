using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002D8 RID: 728
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GraphicalObjectData
	{
		// Token: 0x06001C86 RID: 7302 RVA: 0x0004E058 File Offset: 0x0004C258
		public static global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData ct_GraphicalObjectData = new global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData();
			ct_GraphicalObjectData.uri = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uri"]);
			ct_GraphicalObjectData.Any = new global::System.Collections.Generic.List<string>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				ct_GraphicalObjectData.Any.Add(xmlNode.OuterXml);
			}
			return ct_GraphicalObjectData;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0004E0F0 File Offset: 0x0004C2F0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uri", this.uri);
			sw.Write(">");
			foreach (string value in this.Any)
			{
				sw.Write(value);
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0004E184 File Offset: 0x0004C384
		public void AddChartElement(string el)
		{
			this.anyField.Add(el);
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0004E184 File Offset: 0x0004C384
		public void AddPicElement(string el)
		{
			this.anyField.Add(el);
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x0004E192 File Offset: 0x0004C392
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x0004E19A File Offset: 0x0004C39A
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<string> Any
		{
			get
			{
				return this.anyField;
			}
			set
			{
				this.anyField = value;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x0004E1A3 File Offset: 0x0004C3A3
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x0004E1AB File Offset: 0x0004C3AB
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string uri
		{
			get
			{
				return this.uriField;
			}
			set
			{
				this.uriField = value;
			}
		}

		// Token: 0x04001647 RID: 5703
		private global::System.Collections.Generic.List<string> anyField = new global::System.Collections.Generic.List<string>();

		// Token: 0x04001648 RID: 5704
		private string uriField;
	}
}
