using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000293 RID: 659
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DashStop
	{
		// Token: 0x06001AEA RID: 6890 RVA: 0x00049088 File Offset: 0x00047288
		public static global::NPOI.OpenXmlFormats.Dml.CT_DashStop Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_DashStop
			{
				d = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["d"]),
				sp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["sp"])
			};
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x000490D8 File Offset: 0x000472D8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "d", this.d);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sp", this.sp);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x00049134 File Offset: 0x00047334
		// (set) Token: 0x06001AED RID: 6893 RVA: 0x0004913C File Offset: 0x0004733C
		[global::System.Xml.Serialization.XmlAttribute]
		public int d
		{
			get
			{
				return this.dField;
			}
			set
			{
				this.dField = value;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x00049145 File Offset: 0x00047345
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x0004914D File Offset: 0x0004734D
		[global::System.Xml.Serialization.XmlAttribute]
		public int sp
		{
			get
			{
				return this.spField;
			}
			set
			{
				this.spField = value;
			}
		}

		// Token: 0x04001417 RID: 5143
		private int dField;

		// Token: 0x04001418 RID: 5144
		private int spField;
	}
}
