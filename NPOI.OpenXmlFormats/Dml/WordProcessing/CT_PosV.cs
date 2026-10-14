using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x02000355 RID: 853
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PosV
	{
		// Token: 0x060021CA RID: 8650 RVA: 0x00058AD4 File Offset: 0x00056CD4
		public static global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PosV Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PosV ct_PosV = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PosV();
			if (node.Attributes["relativeFrom"] != null)
			{
				ct_PosV.relativeFrom = (global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_RelFromV)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_RelFromV), node.Attributes["relativeFrom"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "posOffset")
				{
					int value;
					ct_PosV.posOffset = (int.TryParse(xmlNode.InnerText, out value) ? new int?(value) : null);
				}
				else if (xmlNode.LocalName == "align")
				{
					ct_PosV.align = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_AlignV?((global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_AlignV)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_AlignV), xmlNode.InnerText));
				}
			}
			return ct_PosV;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00058BEC File Offset: 0x00056DEC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<wp:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "relativeFrom", this.relativeFrom.ToString());
			sw.Write(">");
			if (this.posOffset != null)
			{
				sw.Write(string.Format("<wp:posOffset>{0}</wp:posOffset>", this.posOffset.Value));
			}
			if (this.align != null)
			{
				sw.Write(string.Format("<wp:align>{0}</wp:align>", this.align.Value));
			}
			sw.Write(string.Format("</wp:{0}>", nodeName));
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x00058CAB File Offset: 0x00056EAB
		// (set) Token: 0x060021CD RID: 8653 RVA: 0x00058CB3 File Offset: 0x00056EB3
		public int? posOffset
		{
			get
			{
				return this.posOffsetField;
			}
			set
			{
				this.posOffsetField = value;
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x00058CBC File Offset: 0x00056EBC
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x00058CC4 File Offset: 0x00056EC4
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_AlignV? align
		{
			get
			{
				return this.alignField;
			}
			set
			{
				this.alignField = value;
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x00058CCD File Offset: 0x00056ECD
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x00058CD5 File Offset: 0x00056ED5
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_RelFromV relativeFrom
		{
			get
			{
				return this.relativeFromField;
			}
			set
			{
				this.relativeFromField = value;
			}
		}

		// Token: 0x040019CB RID: 6603
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_RelFromV relativeFromField;

		// Token: 0x040019CC RID: 6604
		private int? posOffsetField;

		// Token: 0x040019CD RID: 6605
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_AlignV? alignField;
	}
}
