using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002DE RID: 734
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AdjPoint2D
	{
		// Token: 0x06001C9F RID: 7327 RVA: 0x0004E36C File Offset: 0x0004C56C
		public static global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D
			{
				x = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["x"]),
				y = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["y"])
			};
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0004E3BC File Offset: 0x0004C5BC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "x", this.x);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "y", this.y);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x0004E418 File Offset: 0x0004C618
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x0004E420 File Offset: 0x0004C620
		[global::System.Xml.Serialization.XmlAttribute]
		public string x
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xField = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x0004E429 File Offset: 0x0004C629
		// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x0004E431 File Offset: 0x0004C631
		[global::System.Xml.Serialization.XmlAttribute]
		public string y
		{
			get
			{
				return this.yField;
			}
			set
			{
				this.yField = value;
			}
		}

		// Token: 0x04001734 RID: 5940
		private string xField;

		// Token: 0x04001735 RID: 5941
		private string yField;
	}
}
