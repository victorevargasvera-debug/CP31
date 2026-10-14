using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000291 RID: 657
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PresetLineDashProperties
	{
		// Token: 0x06001AE3 RID: 6883 RVA: 0x00048FC0 File Offset: 0x000471C0
		public static global::NPOI.OpenXmlFormats.Dml.CT_PresetLineDashProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_PresetLineDashProperties ct_PresetLineDashProperties = new global::NPOI.OpenXmlFormats.Dml.CT_PresetLineDashProperties();
			if (node.Attributes["val"] != null)
			{
				ct_PresetLineDashProperties.val = (global::NPOI.OpenXmlFormats.Dml.ST_PresetLineDashVal)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_PresetLineDashVal), node.Attributes["val"].Value);
			}
			return ct_PresetLineDashProperties;
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0004901C File Offset: 0x0004721C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x00049064 File Offset: 0x00047264
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x0004906C File Offset: 0x0004726C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_PresetLineDashVal val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x00049075 File Offset: 0x00047275
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x0004907D File Offset: 0x0004727D
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

		// Token: 0x04001409 RID: 5129
		private global::NPOI.OpenXmlFormats.Dml.ST_PresetLineDashVal valField;

		// Token: 0x0400140A RID: 5130
		private bool valFieldSpecified;
	}
}
