using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200025E RID: 606
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextTabStop
	{
		// Token: 0x060018A3 RID: 6307 RVA: 0x000441D0 File Offset: 0x000423D0
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextTabStop Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextTabStop ct_TextTabStop = new global::NPOI.OpenXmlFormats.Dml.CT_TextTabStop();
			ct_TextTabStop.pos = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["pos"]);
			if (node.Attributes["algn"] != null)
			{
				ct_TextTabStop.algn = (global::NPOI.OpenXmlFormats.Dml.ST_TextTabAlignType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextTabAlignType), node.Attributes["algn"].Value);
			}
			return ct_TextTabStop;
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00044248 File Offset: 0x00042448
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pos", this.pos);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "algn", this.algn.ToString());
			sw.Write("/>");
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x000442A1 File Offset: 0x000424A1
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x000442A9 File Offset: 0x000424A9
		[global::System.Xml.Serialization.XmlAttribute]
		public int pos
		{
			get
			{
				return this.posField;
			}
			set
			{
				this.posField = value;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x000442B2 File Offset: 0x000424B2
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x000442BA File Offset: 0x000424BA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool posSpecified
		{
			get
			{
				return this.posFieldSpecified;
			}
			set
			{
				this.posFieldSpecified = value;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x000442C3 File Offset: 0x000424C3
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x000442CB File Offset: 0x000424CB
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextTabAlignType algn
		{
			get
			{
				return this.algnField;
			}
			set
			{
				this.algnField = value;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x000442D4 File Offset: 0x000424D4
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x000442DC File Offset: 0x000424DC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool algnSpecified
		{
			get
			{
				return this.algnFieldSpecified;
			}
			set
			{
				this.algnFieldSpecified = value;
			}
		}

		// Token: 0x040012CC RID: 4812
		private int posField;

		// Token: 0x040012CD RID: 4813
		private bool posFieldSpecified;

		// Token: 0x040012CE RID: 4814
		private global::NPOI.OpenXmlFormats.Dml.ST_TextTabAlignType algnField;

		// Token: 0x040012CF RID: 4815
		private bool algnFieldSpecified;
	}
}
