using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004FC RID: 1276
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CellAlignment
	{
		// Token: 0x06003631 RID: 13873 RVA: 0x00087450 File Offset: 0x00085650
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment ct_CellAlignment = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment();
			if (node.Attributes["horizontal"] != null)
			{
				ct_CellAlignment.horizontal = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_HorizontalAlignment)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_HorizontalAlignment), node.Attributes["horizontal"].Value);
			}
			if (node.Attributes["vertical"] != null)
			{
				ct_CellAlignment.vertical = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignment)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignment), node.Attributes["vertical"].Value);
			}
			ct_CellAlignment.textRotation = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["textRotation"]);
			ct_CellAlignment.wrapText = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["wrapText"]);
			ct_CellAlignment.indent = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["indent"]);
			ct_CellAlignment.relativeIndent = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["relativeIndent"]);
			ct_CellAlignment.justifyLastLine = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["justifyLastLine"]);
			ct_CellAlignment.shrinkToFit = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["shrinkToFit"]);
			ct_CellAlignment.readingOrder = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["readingOrder"]);
			return ct_CellAlignment;
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x000875A8 File Offset: 0x000857A8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.horizontal != global::NPOI.OpenXmlFormats.Spreadsheet.ST_HorizontalAlignment.general)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "horizontal", this.horizontal.ToString());
			}
			if (this.vertical != global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignment.bottom)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "vertical", this.vertical.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "textRotation", (double)this.textRotation);
			if (this.wrapText)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "wrapText", this.wrapText);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "indent", (double)this.indent);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "relativeIndent", this.relativeIndent);
			if (this.justifyLastLine)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "justifyLastLine", this.justifyLastLine);
			}
			if (this.shrinkToFit)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "shrinkToFit", this.shrinkToFit);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "readingOrder", (double)this.readingOrder);
			sw.Write("/>");
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x000876B2 File Offset: 0x000858B2
		public bool IsSetHorizontal()
		{
			return this.horizontalFieldSpecified;
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x000876BA File Offset: 0x000858BA
		public bool IsSetVertical()
		{
			return this.verticalFieldSpecified;
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06003635 RID: 13877 RVA: 0x000876C2 File Offset: 0x000858C2
		// (set) Token: 0x06003636 RID: 13878 RVA: 0x000876CA File Offset: 0x000858CA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_HorizontalAlignment.general)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_HorizontalAlignment horizontal
		{
			get
			{
				return this.horizontalField;
			}
			set
			{
				this.horizontalField = value;
				this.horizontalFieldSpecified = true;
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x06003637 RID: 13879 RVA: 0x000876B2 File Offset: 0x000858B2
		// (set) Token: 0x06003638 RID: 13880 RVA: 0x000876DA File Offset: 0x000858DA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool horizontalSpecified
		{
			get
			{
				return this.horizontalFieldSpecified;
			}
			set
			{
				this.horizontalFieldSpecified = value;
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x06003639 RID: 13881 RVA: 0x000876E3 File Offset: 0x000858E3
		// (set) Token: 0x0600363A RID: 13882 RVA: 0x000876EB File Offset: 0x000858EB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignment.bottom)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignment vertical
		{
			get
			{
				return this.verticalField;
			}
			set
			{
				this.verticalField = value;
				this.verticalFieldSpecified = true;
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x000876BA File Offset: 0x000858BA
		// (set) Token: 0x0600363C RID: 13884 RVA: 0x000876FB File Offset: 0x000858FB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool verticalSpecified
		{
			get
			{
				return this.verticalFieldSpecified;
			}
			set
			{
				this.verticalFieldSpecified = value;
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x0600363D RID: 13885 RVA: 0x00087704 File Offset: 0x00085904
		// (set) Token: 0x0600363E RID: 13886 RVA: 0x0008770C File Offset: 0x0008590C
		[global::System.Xml.Serialization.XmlAttribute]
		public long textRotation
		{
			get
			{
				return this.textRotationField;
			}
			set
			{
				this.textRotationField = value;
				this.textRotationFieldSpecified = true;
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x0600363F RID: 13887 RVA: 0x0008771C File Offset: 0x0008591C
		// (set) Token: 0x06003640 RID: 13888 RVA: 0x00087724 File Offset: 0x00085924
		[global::System.Xml.Serialization.XmlIgnore]
		public bool textRotationSpecified
		{
			get
			{
				return this.textRotationFieldSpecified;
			}
			set
			{
				this.textRotationFieldSpecified = value;
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06003641 RID: 13889 RVA: 0x0008772D File Offset: 0x0008592D
		// (set) Token: 0x06003642 RID: 13890 RVA: 0x00087735 File Offset: 0x00085935
		[global::System.Xml.Serialization.XmlAttribute]
		public bool wrapText
		{
			get
			{
				return this.wrapTextField;
			}
			set
			{
				this.wrapTextField = value;
				this.wrapTextSpecified = true;
			}
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06003643 RID: 13891 RVA: 0x00087745 File Offset: 0x00085945
		// (set) Token: 0x06003644 RID: 13892 RVA: 0x0008774D File Offset: 0x0008594D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool wrapTextSpecified
		{
			get
			{
				return this.wrapTextFieldSpecified;
			}
			set
			{
				this.wrapTextFieldSpecified = value;
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06003645 RID: 13893 RVA: 0x00087756 File Offset: 0x00085956
		// (set) Token: 0x06003646 RID: 13894 RVA: 0x0008775E File Offset: 0x0008595E
		[global::System.Xml.Serialization.XmlAttribute]
		public long indent
		{
			get
			{
				return this.indentField;
			}
			set
			{
				this.indentField = value;
				this.indentSpecified = true;
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06003647 RID: 13895 RVA: 0x0008776E File Offset: 0x0008596E
		// (set) Token: 0x06003648 RID: 13896 RVA: 0x00087776 File Offset: 0x00085976
		[global::System.Xml.Serialization.XmlIgnore]
		public bool indentSpecified
		{
			get
			{
				return this.indentFieldSpecified;
			}
			set
			{
				this.indentFieldSpecified = value;
			}
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x0008777F File Offset: 0x0008597F
		// (set) Token: 0x0600364A RID: 13898 RVA: 0x00087787 File Offset: 0x00085987
		[global::System.Xml.Serialization.XmlAttribute]
		public int relativeIndent
		{
			get
			{
				return this.relativeIndentField;
			}
			set
			{
				this.relativeIndentField = value;
				this.relativeIndentSpecified = true;
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x0600364B RID: 13899 RVA: 0x00087797 File Offset: 0x00085997
		// (set) Token: 0x0600364C RID: 13900 RVA: 0x0008779F File Offset: 0x0008599F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool relativeIndentSpecified
		{
			get
			{
				return this.relativeIndentFieldSpecified;
			}
			set
			{
				this.relativeIndentFieldSpecified = value;
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x000877A8 File Offset: 0x000859A8
		// (set) Token: 0x0600364E RID: 13902 RVA: 0x000877B0 File Offset: 0x000859B0
		[global::System.Xml.Serialization.XmlAttribute]
		public bool justifyLastLine
		{
			get
			{
				return this.justifyLastLineField;
			}
			set
			{
				this.justifyLastLineField = value;
				this.justifyLastLineSpecified = true;
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x0600364F RID: 13903 RVA: 0x000877C0 File Offset: 0x000859C0
		// (set) Token: 0x06003650 RID: 13904 RVA: 0x000877C8 File Offset: 0x000859C8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool justifyLastLineSpecified
		{
			get
			{
				return this.justifyLastLineFieldSpecified;
			}
			set
			{
				this.justifyLastLineFieldSpecified = value;
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06003651 RID: 13905 RVA: 0x000877D1 File Offset: 0x000859D1
		// (set) Token: 0x06003652 RID: 13906 RVA: 0x000877D9 File Offset: 0x000859D9
		[global::System.Xml.Serialization.XmlAttribute]
		public bool shrinkToFit
		{
			get
			{
				return this.shrinkToFitField;
			}
			set
			{
				this.shrinkToFitField = value;
				this.shrinkToFitSpecified = true;
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06003653 RID: 13907 RVA: 0x000877E9 File Offset: 0x000859E9
		// (set) Token: 0x06003654 RID: 13908 RVA: 0x000877F1 File Offset: 0x000859F1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool shrinkToFitSpecified
		{
			get
			{
				return this.shrinkToFitFieldSpecified;
			}
			set
			{
				this.shrinkToFitFieldSpecified = value;
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06003655 RID: 13909 RVA: 0x000877FA File Offset: 0x000859FA
		// (set) Token: 0x06003656 RID: 13910 RVA: 0x00087802 File Offset: 0x00085A02
		[global::System.Xml.Serialization.XmlAttribute]
		public long readingOrder
		{
			get
			{
				return this.readingOrderField;
			}
			set
			{
				this.readingOrderField = value;
				this.readingOrderSpecified = true;
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06003657 RID: 13911 RVA: 0x00087812 File Offset: 0x00085A12
		// (set) Token: 0x06003658 RID: 13912 RVA: 0x0008781A File Offset: 0x00085A1A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool readingOrderSpecified
		{
			get
			{
				return this.readingOrderFieldSpecified;
			}
			set
			{
				this.readingOrderFieldSpecified = value;
			}
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x00087824 File Offset: 0x00085A24
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment Copy()
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment
			{
				horizontal = this.horizontal,
				vertical = this.vertical,
				wrapText = this.wrapText,
				shrinkToFit = this.shrinkToFit,
				textRotation = this.textRotation,
				justifyLastLine = this.justifyLastLine,
				readingOrder = this.readingOrder,
				relativeIndent = this.relativeIndent,
				indent = this.indent
			};
		}

		// Token: 0x040023C1 RID: 9153
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_HorizontalAlignment horizontalField;

		// Token: 0x040023C2 RID: 9154
		private bool horizontalFieldSpecified;

		// Token: 0x040023C3 RID: 9155
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignment verticalField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignment.bottom;

		// Token: 0x040023C4 RID: 9156
		private bool verticalFieldSpecified;

		// Token: 0x040023C5 RID: 9157
		private long textRotationField;

		// Token: 0x040023C6 RID: 9158
		private bool textRotationFieldSpecified;

		// Token: 0x040023C7 RID: 9159
		private bool wrapTextField;

		// Token: 0x040023C8 RID: 9160
		private bool wrapTextFieldSpecified;

		// Token: 0x040023C9 RID: 9161
		private long indentField;

		// Token: 0x040023CA RID: 9162
		private bool indentFieldSpecified;

		// Token: 0x040023CB RID: 9163
		private int relativeIndentField;

		// Token: 0x040023CC RID: 9164
		private bool relativeIndentFieldSpecified;

		// Token: 0x040023CD RID: 9165
		private bool justifyLastLineField;

		// Token: 0x040023CE RID: 9166
		private bool justifyLastLineFieldSpecified;

		// Token: 0x040023CF RID: 9167
		private bool shrinkToFitField;

		// Token: 0x040023D0 RID: 9168
		private bool shrinkToFitFieldSpecified;

		// Token: 0x040023D1 RID: 9169
		private long readingOrderField;

		// Token: 0x040023D2 RID: 9170
		private bool readingOrderFieldSpecified;
	}
}
