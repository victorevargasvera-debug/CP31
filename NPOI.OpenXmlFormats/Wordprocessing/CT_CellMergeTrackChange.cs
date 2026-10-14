using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001C0 RID: 448
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CellMergeTrackChange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
	{
		// Token: 0x06001108 RID: 4360 RVA: 0x00038DDC File Offset: 0x00036FDC
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_CellMergeTrackChange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_CellMergeTrackChange ct_CellMergeTrackChange = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_CellMergeTrackChange();
			if (node.Attributes["w:vMerge"] != null)
			{
				ct_CellMergeTrackChange.vMerge = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_AnnotationVMerge)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_AnnotationVMerge), node.Attributes["w:vMerge"].Value);
			}
			if (node.Attributes["w:vMergeOrig"] != null)
			{
				ct_CellMergeTrackChange.vMergeOrig = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_AnnotationVMerge)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_AnnotationVMerge), node.Attributes["w:vMergeOrig"].Value);
			}
			ct_CellMergeTrackChange.author = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:author"]);
			ct_CellMergeTrackChange.date = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:date"]);
			ct_CellMergeTrackChange.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			return ct_CellMergeTrackChange;
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00038EC8 File Offset: 0x000370C8
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:vMerge", this.vMerge.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:vMergeOrig", this.vMergeOrig.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:author", base.author);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:date", base.date);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", base.id);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x00038F73 File Offset: 0x00037173
		// (set) Token: 0x0600110B RID: 4363 RVA: 0x00038F7B File Offset: 0x0003717B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_AnnotationVMerge vMerge
		{
			get
			{
				return this.vMergeField;
			}
			set
			{
				this.vMergeField = value;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x00038F84 File Offset: 0x00037184
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x00038F8C File Offset: 0x0003718C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool vMergeSpecified
		{
			get
			{
				return this.vMergeFieldSpecified;
			}
			set
			{
				this.vMergeFieldSpecified = value;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x00038F95 File Offset: 0x00037195
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x00038F9D File Offset: 0x0003719D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_AnnotationVMerge vMergeOrig
		{
			get
			{
				return this.vMergeOrigField;
			}
			set
			{
				this.vMergeOrigField = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x00038FA6 File Offset: 0x000371A6
		// (set) Token: 0x06001111 RID: 4369 RVA: 0x00038FAE File Offset: 0x000371AE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool vMergeOrigSpecified
		{
			get
			{
				return this.vMergeOrigFieldSpecified;
			}
			set
			{
				this.vMergeOrigFieldSpecified = value;
			}
		}

		// Token: 0x04000D60 RID: 3424
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_AnnotationVMerge vMergeField;

		// Token: 0x04000D61 RID: 3425
		private bool vMergeFieldSpecified;

		// Token: 0x04000D62 RID: 3426
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_AnnotationVMerge vMergeOrigField;

		// Token: 0x04000D63 RID: 3427
		private bool vMergeOrigFieldSpecified;
	}
}
