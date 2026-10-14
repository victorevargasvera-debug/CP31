using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200026A RID: 618
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextBulletSizePercent
	{
		// Token: 0x0600196A RID: 6506 RVA: 0x000458C8 File Offset: 0x00043AC8
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePercent Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_TextBulletSizePercent
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["val"])
			};
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x000458EF File Offset: 0x00043AEF
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x0004592F File Offset: 0x00043B2F
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x00045937 File Offset: 0x00043B37
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

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x00045947 File Offset: 0x00043B47
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x0004594F File Offset: 0x00043B4F
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

		// Token: 0x04001319 RID: 4889
		private int valField;

		// Token: 0x0400131A RID: 4890
		private bool valFieldSpecified;
	}
}
