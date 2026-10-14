using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003E0 RID: 992
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FirstSliceAng
	{
		// Token: 0x06002750 RID: 10064 RVA: 0x000627E3 File Offset: 0x000609E3
		public CT_FirstSliceAng()
		{
			this.valField = 0;
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x000627F4 File Offset: 0x000609F4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_FirstSliceAng Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_FirstSliceAng ct_FirstSliceAng = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_FirstSliceAng();
			if (node.Attributes["val"] != null)
			{
				ct_FirstSliceAng.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUShort(node.Attributes["val"]);
			}
			return ct_FirstSliceAng;
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x0006283A File Offset: 0x00060A3A
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x0006287A File Offset: 0x00060A7A
		// (set) Token: 0x06002754 RID: 10068 RVA: 0x00062882 File Offset: 0x00060A82
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(ushort), "0")]
		public ushort val
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

		// Token: 0x04001CFB RID: 7419
		private ushort valField;
	}
}
