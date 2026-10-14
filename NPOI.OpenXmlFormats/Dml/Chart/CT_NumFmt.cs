using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000418 RID: 1048
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NumFmt
	{
		// Token: 0x060029EC RID: 10732 RVA: 0x000697D8 File Offset: 0x000679D8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt
			{
				formatCode = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["formatCode"]),
				sourceLinked = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["sourceLinked"])
			};
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x00069828 File Offset: 0x00067A28
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "formatCode", this.formatCode);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sourceLinked", this.sourceLinked, false);
			sw.Write("/>");
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x060029EE RID: 10734 RVA: 0x00069874 File Offset: 0x00067A74
		// (set) Token: 0x060029EF RID: 10735 RVA: 0x0006987C File Offset: 0x00067A7C
		[global::System.Xml.Serialization.XmlAttribute]
		public string formatCode
		{
			get
			{
				return this.formatCodeField;
			}
			set
			{
				this.formatCodeField = value;
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x00069885 File Offset: 0x00067A85
		// (set) Token: 0x060029F1 RID: 10737 RVA: 0x0006988D File Offset: 0x00067A8D
		[global::System.Xml.Serialization.XmlAttribute]
		public bool sourceLinked
		{
			get
			{
				return this.sourceLinkedField;
			}
			set
			{
				this.sourceLinkedField = value;
			}
		}

		// Token: 0x04001E05 RID: 7685
		private string formatCodeField;

		// Token: 0x04001E06 RID: 7686
		private bool sourceLinkedField;
	}
}
