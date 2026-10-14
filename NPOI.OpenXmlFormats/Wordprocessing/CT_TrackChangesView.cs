using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200018D RID: 397
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TrackChangesView
	{
		// Token: 0x06000E3F RID: 3647 RVA: 0x0002FAA0 File Offset: 0x0002DCA0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangesView Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangesView ct_TrackChangesView = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangesView();
			if (node.Attributes["w:markup"] != null)
			{
				ct_TrackChangesView.markup = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:markup"].Value, true);
			}
			if (node.Attributes["w:comments"] != null)
			{
				ct_TrackChangesView.comments = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:comments"].Value, true);
			}
			if (node.Attributes["w:insDel"] != null)
			{
				ct_TrackChangesView.insDel = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:insDel"].Value, true);
			}
			if (node.Attributes["w:formatting"] != null)
			{
				ct_TrackChangesView.formatting = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:formatting"].Value, true);
			}
			if (node.Attributes["w:inkAnnotations"] != null)
			{
				ct_TrackChangesView.inkAnnotations = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:inkAnnotations"].Value, true);
			}
			return ct_TrackChangesView;
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0002FC04 File Offset: 0x0002DE04
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:markup", this.markup.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:comments", this.comments.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:insDel", this.insDel.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:formatting", this.formatting.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:inkAnnotations", this.inkAnnotations.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0002FCD9 File Offset: 0x0002DED9
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x0002FCE1 File Offset: 0x0002DEE1
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff markup
		{
			get
			{
				return this.markupField;
			}
			set
			{
				this.markupField = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x0002FCEA File Offset: 0x0002DEEA
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x0002FCF2 File Offset: 0x0002DEF2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool markupSpecified
		{
			get
			{
				return this.markupFieldSpecified;
			}
			set
			{
				this.markupFieldSpecified = value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0002FCFB File Offset: 0x0002DEFB
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x0002FD03 File Offset: 0x0002DF03
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0002FD0C File Offset: 0x0002DF0C
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x0002FD14 File Offset: 0x0002DF14
		[global::System.Xml.Serialization.XmlIgnore]
		public bool commentsSpecified
		{
			get
			{
				return this.commentsFieldSpecified;
			}
			set
			{
				this.commentsFieldSpecified = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x0002FD1D File Offset: 0x0002DF1D
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x0002FD25 File Offset: 0x0002DF25
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff insDel
		{
			get
			{
				return this.insDelField;
			}
			set
			{
				this.insDelField = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0002FD2E File Offset: 0x0002DF2E
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x0002FD36 File Offset: 0x0002DF36
		[global::System.Xml.Serialization.XmlIgnore]
		public bool insDelSpecified
		{
			get
			{
				return this.insDelFieldSpecified;
			}
			set
			{
				this.insDelFieldSpecified = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0002FD3F File Offset: 0x0002DF3F
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x0002FD47 File Offset: 0x0002DF47
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff formatting
		{
			get
			{
				return this.formattingField;
			}
			set
			{
				this.formattingField = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0002FD50 File Offset: 0x0002DF50
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x0002FD58 File Offset: 0x0002DF58
		[global::System.Xml.Serialization.XmlIgnore]
		public bool formattingSpecified
		{
			get
			{
				return this.formattingFieldSpecified;
			}
			set
			{
				this.formattingFieldSpecified = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0002FD61 File Offset: 0x0002DF61
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x0002FD69 File Offset: 0x0002DF69
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff inkAnnotations
		{
			get
			{
				return this.inkAnnotationsField;
			}
			set
			{
				this.inkAnnotationsField = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0002FD72 File Offset: 0x0002DF72
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x0002FD7A File Offset: 0x0002DF7A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool inkAnnotationsSpecified
		{
			get
			{
				return this.inkAnnotationsFieldSpecified;
			}
			set
			{
				this.inkAnnotationsFieldSpecified = value;
			}
		}

		// Token: 0x04000BFA RID: 3066
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff markupField;

		// Token: 0x04000BFB RID: 3067
		private bool markupFieldSpecified;

		// Token: 0x04000BFC RID: 3068
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff commentsField;

		// Token: 0x04000BFD RID: 3069
		private bool commentsFieldSpecified;

		// Token: 0x04000BFE RID: 3070
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff insDelField;

		// Token: 0x04000BFF RID: 3071
		private bool insDelFieldSpecified;

		// Token: 0x04000C00 RID: 3072
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff formattingField;

		// Token: 0x04000C01 RID: 3073
		private bool formattingFieldSpecified;

		// Token: 0x04000C02 RID: 3074
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff inkAnnotationsField;

		// Token: 0x04000C03 RID: 3075
		private bool inkAnnotationsFieldSpecified;
	}
}
