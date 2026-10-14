using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000082 RID: 130
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocGrid
	{
		// Token: 0x06000398 RID: 920 RVA: 0x0000B0E0 File Offset: 0x000092E0
		public CT_DocGrid()
		{
			this.type = global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocGrid.@default;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000B0F0 File Offset: 0x000092F0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocGrid Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocGrid ct_DocGrid = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocGrid();
			if (node.Attributes["w:type"] != null)
			{
				ct_DocGrid.type = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocGrid)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocGrid), node.Attributes["w:type"].Value);
			}
			ct_DocGrid.linePitch = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:linePitch"]);
			ct_DocGrid.charSpace = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:charSpace"]);
			return ct_DocGrid;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000B180 File Offset: 0x00009380
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			if (this.type != global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocGrid.@default)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:type", this.type.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:linePitch", this.linePitch);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:charSpace", this.charSpace);
			sw.Write("/>");
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000B1F2 File Offset: 0x000093F2
		// (set) Token: 0x0600039C RID: 924 RVA: 0x0000B1FA File Offset: 0x000093FA
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocGrid type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0000B203 File Offset: 0x00009403
		// (set) Token: 0x0600039E RID: 926 RVA: 0x0000B20B File Offset: 0x0000940B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool typeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000B214 File Offset: 0x00009414
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x0000B21C File Offset: 0x0000941C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string linePitch
		{
			get
			{
				return this.linePitchField;
			}
			set
			{
				this.linePitchField = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000B225 File Offset: 0x00009425
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x0000B22D File Offset: 0x0000942D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string charSpace
		{
			get
			{
				return this.charSpaceField;
			}
			set
			{
				this.charSpaceField = value;
			}
		}

		// Token: 0x0400034D RID: 845
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocGrid typeField;

		// Token: 0x0400034E RID: 846
		private bool typeFieldSpecified;

		// Token: 0x0400034F RID: 847
		private string linePitchField;

		// Token: 0x04000350 RID: 848
		private string charSpaceField;
	}
}
