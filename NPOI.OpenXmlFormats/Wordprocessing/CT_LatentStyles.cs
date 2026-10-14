using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000149 RID: 329
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LatentStyles
	{
		// Token: 0x060008F2 RID: 2290 RVA: 0x0001FE14 File Offset: 0x0001E014
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_LatentStyles Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_LatentStyles ct_LatentStyles = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_LatentStyles();
			if (node.Attributes["w:defLockedState"] != null)
			{
				ct_LatentStyles.defLockedState = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:defLockedState"].Value, true);
			}
			ct_LatentStyles.defUIPriority = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:defUIPriority"]);
			if (node.Attributes["w:defSemiHidden"] != null)
			{
				ct_LatentStyles.defSemiHidden = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:defSemiHidden"].Value, true);
			}
			if (node.Attributes["w:defUnhideWhenUsed"] != null)
			{
				ct_LatentStyles.defUnhideWhenUsed = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:defUnhideWhenUsed"].Value, true);
			}
			if (node.Attributes["w:defQFormat"] != null)
			{
				ct_LatentStyles.defQFormat = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:defQFormat"].Value, true);
			}
			ct_LatentStyles.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:count"]);
			ct_LatentStyles.lsdException = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "lsdException")
				{
					ct_LatentStyles.lsdException.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_LatentStyles;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0001FFE0 File Offset: 0x0001E1E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:defLockedState", (this.defLockedState == global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off) ? "0" : "1");
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:defUIPriority", this.defUIPriority);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:defSemiHidden", (this.defSemiHidden == global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off) ? "0" : "1");
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:defUnhideWhenUsed", (this.defUnhideWhenUsed == global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off) ? "0" : "1");
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:defQFormat", (this.defQFormat == global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off) ? "0" : "1");
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:count", this.count);
			sw.Write(">");
			if (this.lsdException != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException ex in this.lsdException)
				{
					ex.Write(sw, "lsdException");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0002010C File Offset: 0x0001E30C
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00020114 File Offset: 0x0001E314
		[global::System.Xml.Serialization.XmlElement("lsdException", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException> lsdException
		{
			get
			{
				return this.lsdExceptionField;
			}
			set
			{
				this.lsdExceptionField = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0002011D File Offset: 0x0001E31D
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00020125 File Offset: 0x0001E325
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff defLockedState
		{
			get
			{
				return this.defLockedStateField;
			}
			set
			{
				this.defLockedStateField = value;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0002012E File Offset: 0x0001E32E
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00020136 File Offset: 0x0001E336
		[global::System.Xml.Serialization.XmlIgnore]
		public bool defLockedStateSpecified
		{
			get
			{
				return this.defLockedStateFieldSpecified;
			}
			set
			{
				this.defLockedStateFieldSpecified = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0002013F File Offset: 0x0001E33F
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x00020147 File Offset: 0x0001E347
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string defUIPriority
		{
			get
			{
				return this.defUIPriorityField;
			}
			set
			{
				this.defUIPriorityField = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00020150 File Offset: 0x0001E350
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x00020158 File Offset: 0x0001E358
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff defSemiHidden
		{
			get
			{
				return this.defSemiHiddenField;
			}
			set
			{
				this.defSemiHiddenField = value;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00020161 File Offset: 0x0001E361
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x00020169 File Offset: 0x0001E369
		[global::System.Xml.Serialization.XmlIgnore]
		public bool defSemiHiddenSpecified
		{
			get
			{
				return this.defSemiHiddenFieldSpecified;
			}
			set
			{
				this.defSemiHiddenFieldSpecified = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00020172 File Offset: 0x0001E372
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x0002017A File Offset: 0x0001E37A
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff defUnhideWhenUsed
		{
			get
			{
				return this.defUnhideWhenUsedField;
			}
			set
			{
				this.defUnhideWhenUsedField = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x00020183 File Offset: 0x0001E383
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x0002018B File Offset: 0x0001E38B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool defUnhideWhenUsedSpecified
		{
			get
			{
				return this.defUnhideWhenUsedFieldSpecified;
			}
			set
			{
				this.defUnhideWhenUsedFieldSpecified = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x00020194 File Offset: 0x0001E394
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x0002019C File Offset: 0x0001E39C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff defQFormat
		{
			get
			{
				return this.defQFormatField;
			}
			set
			{
				this.defQFormatField = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x000201A5 File Offset: 0x0001E3A5
		// (set) Token: 0x06000908 RID: 2312 RVA: 0x000201AD File Offset: 0x0001E3AD
		[global::System.Xml.Serialization.XmlIgnore]
		public bool defQFormatSpecified
		{
			get
			{
				return this.defQFormatFieldSpecified;
			}
			set
			{
				this.defQFormatFieldSpecified = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x000201B6 File Offset: 0x0001E3B6
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x000201BE File Offset: 0x0001E3BE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000201C8 File Offset: 0x0001E3C8
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException AddNewLsdException()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException ex = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException();
			if (this.lsdExceptionField == null)
			{
				this.lsdExceptionField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException>();
			}
			this.lsdExceptionField.Add(ex);
			return ex;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x000201FB File Offset: 0x0001E3FB
		public int SizeOfLsdExceptionArray()
		{
			if (this.lsdExceptionField != null)
			{
				return this.lsdExceptionField.Count;
			}
			return 0;
		}

		// Token: 0x04000829 RID: 2089
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException> lsdExceptionField;

		// Token: 0x0400082A RID: 2090
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff defLockedStateField;

		// Token: 0x0400082B RID: 2091
		private bool defLockedStateFieldSpecified;

		// Token: 0x0400082C RID: 2092
		private string defUIPriorityField;

		// Token: 0x0400082D RID: 2093
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff defSemiHiddenField;

		// Token: 0x0400082E RID: 2094
		private bool defSemiHiddenFieldSpecified;

		// Token: 0x0400082F RID: 2095
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff defUnhideWhenUsedField;

		// Token: 0x04000830 RID: 2096
		private bool defUnhideWhenUsedFieldSpecified;

		// Token: 0x04000831 RID: 2097
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff defQFormatField;

		// Token: 0x04000832 RID: 2098
		private bool defQFormatFieldSpecified;

		// Token: 0x04000833 RID: 2099
		private string countField;
	}
}
