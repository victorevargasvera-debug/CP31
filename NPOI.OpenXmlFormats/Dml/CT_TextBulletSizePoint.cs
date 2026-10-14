using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200026B RID: 619
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextBulletSizePoint
	{
		// Token: 0x06001971 RID: 6513 RVA: 0x00045958 File Offset: 0x00043B58
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePoint Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePoint
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["val"])
			};
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x0004597F File Offset: 0x00043B7F
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x000459BF File Offset: 0x00043BBF
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x000459C7 File Offset: 0x00043BC7
		[global::System.Xml.Serialization.XmlAttribute]
		public int val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
				this.valFieldSpecified = true;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x000459D7 File Offset: 0x00043BD7
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x000459DF File Offset: 0x00043BDF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool valSpecified
		{
			get
			{
				return this.valFieldSpecified;
			}
			set
			{
				this.valFieldSpecified = value;
			}
		}

		// Token: 0x0400131B RID: 4891
		private int valField;

		// Token: 0x0400131C RID: 4892
		private bool valFieldSpecified;
	}
}
