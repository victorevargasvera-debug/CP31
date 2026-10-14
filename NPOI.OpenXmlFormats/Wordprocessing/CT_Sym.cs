using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000B4 RID: 180
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Sym
	{
		// Token: 0x060004F3 RID: 1267 RVA: 0x0000E0D4 File Offset: 0x0000C2D4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Sym Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Sym
			{
				font = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:font"]),
				@char = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:char"])
			};
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000E124 File Offset: 0x0000C324
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:font", this.font);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:char", this.@char);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0000E180 File Offset: 0x0000C380
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x0000E188 File Offset: 0x0000C388
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string font
		{
			get
			{
				return this.fontField;
			}
			set
			{
				this.fontField = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0000E191 File Offset: 0x0000C391
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x0000E199 File Offset: 0x0000C399
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] @char
		{
			get
			{
				return this.charField;
			}
			set
			{
				this.charField = value;
			}
		}

		// Token: 0x04000470 RID: 1136
		private string fontField;

		// Token: 0x04000471 RID: 1137
		private byte[] charField;
	}
}
