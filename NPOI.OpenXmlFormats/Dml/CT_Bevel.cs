using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000299 RID: 665
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Bevel
	{
		// Token: 0x06001B21 RID: 6945 RVA: 0x000497F4 File Offset: 0x000479F4
		public static global::NPOI.OpenXmlFormats.Dml.CT_Bevel Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_Bevel ct_Bevel = new global::NPOI.OpenXmlFormats.Dml.CT_Bevel();
			ct_Bevel.w = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["w"]);
			ct_Bevel.h = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["h"]);
			if (node.Attributes["prst"] != null)
			{
				ct_Bevel.prst = (global::NPOI.OpenXmlFormats.Dml.ST_BevelPresetType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_BevelPresetType), node.Attributes["prst"].Value);
			}
			return ct_Bevel;
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x00049884 File Offset: 0x00047A84
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w", (double)this.w, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "h", (double)this.h, true);
			if (this.prst != global::NPOI.OpenXmlFormats.Dml.ST_BevelPresetType.circle)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "prst", this.prst.ToString());
			}
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0004990C File Offset: 0x00047B0C
		public CT_Bevel()
		{
			this.wField = 76200L;
			this.hField = 76200L;
			this.prstField = global::NPOI.OpenXmlFormats.Dml.ST_BevelPresetType.circle;
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x00049933 File Offset: 0x00047B33
		// (set) Token: 0x06001B25 RID: 6949 RVA: 0x0004993B File Offset: 0x00047B3B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "76200")]
		public long w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x00049944 File Offset: 0x00047B44
		// (set) Token: 0x06001B27 RID: 6951 RVA: 0x0004994C File Offset: 0x00047B4C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "76200")]
		public long h
		{
			get
			{
				return this.hField;
			}
			set
			{
				this.hField = value;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x00049955 File Offset: 0x00047B55
		// (set) Token: 0x06001B29 RID: 6953 RVA: 0x0004995D File Offset: 0x00047B5D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_BevelPresetType.circle)]
		public global::NPOI.OpenXmlFormats.Dml.ST_BevelPresetType prst
		{
			get
			{
				return this.prstField;
			}
			set
			{
				this.prstField = value;
			}
		}

		// Token: 0x0400143E RID: 5182
		private long wField;

		// Token: 0x0400143F RID: 5183
		private long hField;

		// Token: 0x04001440 RID: 5184
		private global::NPOI.OpenXmlFormats.Dml.ST_BevelPresetType prstField;
	}
}
