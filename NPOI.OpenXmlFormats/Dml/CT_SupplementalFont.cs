using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200027D RID: 637
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SupplementalFont
	{
		// Token: 0x06001A64 RID: 6756 RVA: 0x00047870 File Offset: 0x00045A70
		public static global::NPOI.OpenXmlFormats.Dml.CT_SupplementalFont Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_SupplementalFont
			{
				script = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["script"]),
				typeface = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["typeface"])
			};
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x000478C0 File Offset: 0x00045AC0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "script", this.script);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "typeface", this.typeface, true);
			sw.Write("/>");
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x0004790C File Offset: 0x00045B0C
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x00047914 File Offset: 0x00045B14
		[global::System.Xml.Serialization.XmlAttribute]
		public string script
		{
			get
			{
				return this.scriptField;
			}
			set
			{
				this.scriptField = value;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0004791D File Offset: 0x00045B1D
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x00047925 File Offset: 0x00045B25
		[global::System.Xml.Serialization.XmlAttribute]
		public string typeface
		{
			get
			{
				return this.typefaceField;
			}
			set
			{
				this.typefaceField = value;
			}
		}

		// Token: 0x040013BD RID: 5053
		private string scriptField;

		// Token: 0x040013BE RID: 5054
		private string typefaceField;
	}
}
