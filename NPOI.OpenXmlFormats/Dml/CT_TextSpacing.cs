using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000262 RID: 610
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextSpacing
	{
		// Token: 0x060018BC RID: 6332 RVA: 0x00044534 File Offset: 0x00042734
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing ct_TextSpacing = new global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "spcPct")
				{
					ct_TextSpacing.spcPct = global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPercent.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spcPts")
				{
					ct_TextSpacing.spcPts = global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPoint.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TextSpacing;
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x000445D4 File Offset: 0x000427D4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}>", nodeName));
			if (this.spcPct != null)
			{
				this.spcPct.Write(sw, "spcPct");
			}
			if (this.spcPts != null)
			{
				this.spcPts.Write(sw, "spcPts");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x00044635 File Offset: 0x00042835
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x0004463D File Offset: 0x0004283D
		public global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPercent spcPct
		{
			get
			{
				return this.spcPctField;
			}
			set
			{
				this.spcPctField = value;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x00044646 File Offset: 0x00042846
		// (set) Token: 0x060018C1 RID: 6337 RVA: 0x0004464E File Offset: 0x0004284E
		public global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPoint spcPts
		{
			get
			{
				return this.spcPtsField;
			}
			set
			{
				this.spcPtsField = value;
			}
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00044657 File Offset: 0x00042857
		public global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPercent AddNewSpcPct()
		{
			this.spcPctField = new global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPercent();
			return this.spcPctField;
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0004466A File Offset: 0x0004286A
		public global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPoint AddNewSpcPts()
		{
			this.spcPtsField = new global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPoint();
			return this.spcPtsField;
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0004467D File Offset: 0x0004287D
		public bool IsSetSpcPct()
		{
			return this.spcPctField != null;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00044688 File Offset: 0x00042888
		public bool IsSetSpcPts()
		{
			return this.spcPtsField != null;
		}

		// Token: 0x040012D7 RID: 4823
		private global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPercent spcPctField;

		// Token: 0x040012D8 RID: 4824
		private global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPoint spcPtsField;
	}
}
