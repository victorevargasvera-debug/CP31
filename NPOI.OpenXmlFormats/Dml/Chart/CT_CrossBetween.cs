using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200042C RID: 1068
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CrossBetween
	{
		// Token: 0x06002AB0 RID: 10928 RVA: 0x0006B22C File Offset: 0x0006942C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_CrossBetween Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_CrossBetween ct_CrossBetween = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_CrossBetween();
			if (node.Attributes["val"] != null)
			{
				ct_CrossBetween.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_CrossBetween)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_CrossBetween), node.Attributes["val"].Value);
			}
			return ct_CrossBetween;
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x0006B288 File Offset: 0x00069488
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06002AB2 RID: 10930 RVA: 0x0006B2E1 File Offset: 0x000694E1
		// (set) Token: 0x06002AB3 RID: 10931 RVA: 0x0006B2E9 File Offset: 0x000694E9
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_CrossBetween val
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

		// Token: 0x04001E67 RID: 7783
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_CrossBetween valField;
	}
}
