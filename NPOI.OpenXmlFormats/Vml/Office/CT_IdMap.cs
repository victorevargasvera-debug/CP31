using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000219 RID: 537
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_IdMap
	{
		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x00041E68 File Offset: 0x00040068
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x00041E70 File Offset: 0x00040070
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.ST_Ext ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x00041E79 File Offset: 0x00040079
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x00041E84 File Offset: 0x00040084
		// (set) Token: 0x0600161B RID: 5659 RVA: 0x00041E8C File Offset: 0x0004008C
		[global::System.Xml.Serialization.XmlAttribute]
		public string data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				this.dataField = value;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x00041E95 File Offset: 0x00040095
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dataSpecified
		{
			get
			{
				return this.dataField != null;
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00041EA0 File Offset: 0x000400A0
		public static global::NPOI.OpenXmlFormats.Vml.Office.CT_IdMap Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.Office.CT_IdMap ct_IdMap = new global::NPOI.OpenXmlFormats.Vml.Office.CT_IdMap();
			if (node.Attributes["v:ext"] != null)
			{
				ct_IdMap.ext = (global::NPOI.OpenXmlFormats.Vml.ST_Ext)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_Ext), node.Attributes["v:ext"].Value);
			}
			ct_IdMap.data = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["data"]);
			return ct_IdMap;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00041F18 File Offset: 0x00040118
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<o:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "v:ext", this.ext.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "data", this.data);
			sw.Write("/>");
		}

		// Token: 0x04001163 RID: 4451
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x04001164 RID: 4452
		private string dataField;
	}
}
