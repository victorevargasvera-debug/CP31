using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200026F RID: 623
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextCharBullet
	{
		// Token: 0x06001985 RID: 6533 RVA: 0x00045B2B File Offset: 0x00043D2B
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextCharBullet Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_TextCharBullet
			{
				@char = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["char"])
			};
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00045B52 File Offset: 0x00043D52
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "char", this.@char);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x00045B92 File Offset: 0x00043D92
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x00045B9A File Offset: 0x00043D9A
		[global::System.Xml.Serialization.XmlAttribute]
		public string @char
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

		// Token: 0x0400134B RID: 4939
		private string charField;
	}
}
