using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002DC RID: 732
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GeomGuide
	{
		// Token: 0x06001C95 RID: 7317 RVA: 0x0004E2AC File Offset: 0x0004C4AC
		public static global::NPOI.OpenXmlFormats.Dml.CT_GeomGuide Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_GeomGuide
			{
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]),
				fmla = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["fmla"])
			};
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0004E2F9 File Offset: 0x0004C4F9
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fmla", this.fmla);
			sw.Write("/>");
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x0004E339 File Offset: 0x0004C539
		// (set) Token: 0x06001C98 RID: 7320 RVA: 0x0004E341 File Offset: 0x0004C541
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x0004E34A File Offset: 0x0004C54A
		// (set) Token: 0x06001C9A RID: 7322 RVA: 0x0004E352 File Offset: 0x0004C552
		[global::System.Xml.Serialization.XmlAttribute]
		public string fmla
		{
			get
			{
				return this.fmlaField;
			}
			set
			{
				this.fmlaField = value;
			}
		}

		// Token: 0x04001731 RID: 5937
		private string nameField;

		// Token: 0x04001732 RID: 5938
		private string fmlaField;
	}
}
