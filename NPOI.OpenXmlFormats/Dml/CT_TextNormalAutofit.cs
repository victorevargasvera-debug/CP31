using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000309 RID: 777
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextNormalAutofit
	{
		// Token: 0x06001E76 RID: 7798 RVA: 0x00052514 File Offset: 0x00050714
		public CT_TextNormalAutofit()
		{
			this.fontScaleField = 100000;
			this.lnSpcReductionField = 0;
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00052530 File Offset: 0x00050730
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextNormalAutofit Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_TextNormalAutofit
			{
				fontScale = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["fontScale"]),
				lnSpcReduction = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["lnSpcReduction"])
			};
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00052580 File Offset: 0x00050780
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fontScale", this.fontScale);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lnSpcReduction", this.lnSpcReduction);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x000525DC File Offset: 0x000507DC
		// (set) Token: 0x06001E7A RID: 7802 RVA: 0x000525E4 File Offset: 0x000507E4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(100000)]
		public int fontScale
		{
			get
			{
				return this.fontScaleField;
			}
			set
			{
				this.fontScaleField = value;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x000525ED File Offset: 0x000507ED
		// (set) Token: 0x06001E7C RID: 7804 RVA: 0x000525F5 File Offset: 0x000507F5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int lnSpcReduction
		{
			get
			{
				return this.lnSpcReductionField;
			}
			set
			{
				this.lnSpcReductionField = value;
			}
		}

		// Token: 0x0400180D RID: 6157
		private int fontScaleField;

		// Token: 0x0400180E RID: 6158
		private int lnSpcReductionField;
	}
}
