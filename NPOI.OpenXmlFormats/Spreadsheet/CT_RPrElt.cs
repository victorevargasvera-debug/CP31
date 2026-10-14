using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004F7 RID: 1271
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_RPrElt
	{
		// Token: 0x060035AB RID: 13739 RVA: 0x000862D0 File Offset: 0x000844D0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt ct_RPrElt = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rFont")
				{
					ct_RPrElt.rFont = global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "charset")
				{
					ct_RPrElt.charset = global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "family")
				{
					ct_RPrElt.family = global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "b")
				{
					ct_RPrElt.b = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "i")
				{
					ct_RPrElt.i = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "strike")
				{
					ct_RPrElt.strike = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "outline")
				{
					ct_RPrElt.outline = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shadow")
				{
					ct_RPrElt.shadow = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "condense")
				{
					ct_RPrElt.condense = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extend")
				{
					ct_RPrElt.extend = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "color")
				{
					ct_RPrElt.color = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sz")
				{
					ct_RPrElt.sz = global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "u")
				{
					ct_RPrElt.u = global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vertAlign")
				{
					ct_RPrElt.vertAlign = global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "scheme")
				{
					ct_RPrElt.scheme = global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_RPrElt;
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x00086550 File Offset: 0x00084750
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.sz != null)
			{
				this.sz.Write(sw, "sz");
			}
			if (this.color != null)
			{
				this.color.Write(sw, "color");
			}
			if (this.rFont != null)
			{
				this.rFont.Write(sw, "rFont");
			}
			if (this.family != null)
			{
				this.family.Write(sw, "family");
			}
			if (this.charset != null)
			{
				this.charset.Write(sw, "charset");
			}
			if (this.b != null)
			{
				this.b.Write(sw, "b");
			}
			if (this.i != null)
			{
				this.i.Write(sw, "i");
			}
			if (this.strike != null)
			{
				this.strike.Write(sw, "strike");
			}
			if (this.outline != null)
			{
				this.outline.Write(sw, "outline");
			}
			if (this.shadow != null)
			{
				this.shadow.Write(sw, "shadow");
			}
			if (this.condense != null)
			{
				this.condense.Write(sw, "condense");
			}
			if (this.extend != null)
			{
				this.extend.Write(sw, "extend");
			}
			if (this.u != null)
			{
				this.u.Write(sw, "u");
			}
			if (this.vertAlign != null)
			{
				this.vertAlign.Write(sw, "vertAlign");
			}
			if (this.scheme != null)
			{
				this.scheme.Write(sw, "scheme");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x00086701 File Offset: 0x00084901
		// (set) Token: 0x060035AE RID: 13742 RVA: 0x00086709 File Offset: 0x00084909
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName rFont
		{
			get
			{
				return this.rFontField;
			}
			set
			{
				this.rFontField = value;
			}
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x060035AF RID: 13743 RVA: 0x00086712 File Offset: 0x00084912
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rFontSpecified
		{
			get
			{
				return this.rFontField != null;
			}
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x0008671D File Offset: 0x0008491D
		public int SizeOfRFontArray()
		{
			if (this.rFontField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x0008672A File Offset: 0x0008492A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName AddNewRFont()
		{
			this.rFontField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName();
			return this.rFontField;
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x0008673D File Offset: 0x0008493D
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName GetRFontArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.rFontField;
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x00086753 File Offset: 0x00084953
		// (set) Token: 0x060035B4 RID: 13748 RVA: 0x0008675B File Offset: 0x0008495B
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty charset
		{
			get
			{
				return this.charsetField;
			}
			set
			{
				this.charsetField = value;
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x00086764 File Offset: 0x00084964
		[global::System.Xml.Serialization.XmlIgnore]
		public bool charsetSpecified
		{
			get
			{
				return this.charsetField != null;
			}
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x0008676F File Offset: 0x0008496F
		public int sizeOfCharsetArray()
		{
			if (this.charsetField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x0008677C File Offset: 0x0008497C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty AddNewCharset()
		{
			this.charsetField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty();
			return this.charsetField;
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x0008678F File Offset: 0x0008498F
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty GetCharsetArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.charsetField;
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x060035B9 RID: 13753 RVA: 0x000867A5 File Offset: 0x000849A5
		// (set) Token: 0x060035BA RID: 13754 RVA: 0x000867AD File Offset: 0x000849AD
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty family
		{
			get
			{
				return this.familyField;
			}
			set
			{
				this.familyField = value;
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x060035BB RID: 13755 RVA: 0x000867B6 File Offset: 0x000849B6
		[global::System.Xml.Serialization.XmlIgnore]
		public bool familySpecified
		{
			get
			{
				return this.familyField != null;
			}
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x000867C1 File Offset: 0x000849C1
		public int SizeOfFamilyArray()
		{
			if (this.familyField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x000867CE File Offset: 0x000849CE
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty AddNewFamily()
		{
			this.familyField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty();
			return this.familyField;
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x000867E1 File Offset: 0x000849E1
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty GetFamilyArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.familyField;
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x060035BF RID: 13759 RVA: 0x000867F7 File Offset: 0x000849F7
		// (set) Token: 0x060035C0 RID: 13760 RVA: 0x000867FF File Offset: 0x000849FF
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty b
		{
			get
			{
				return this.bField;
			}
			set
			{
				this.bField = value;
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x060035C1 RID: 13761 RVA: 0x00086808 File Offset: 0x00084A08
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bSpecified
		{
			get
			{
				return this.bField != null;
			}
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00086813 File Offset: 0x00084A13
		public int SizeOfBArray()
		{
			if (this.bField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00086820 File Offset: 0x00084A20
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewB()
		{
			this.bField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			return this.bField;
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00086833 File Offset: 0x00084A33
		public void SetBArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty[] array)
		{
			this.bField = ((array.Length != 0) ? array[0] : null);
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00086845 File Offset: 0x00084A45
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetBArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.bField;
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x0008685B File Offset: 0x00084A5B
		// (set) Token: 0x060035C7 RID: 13767 RVA: 0x00086863 File Offset: 0x00084A63
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty i
		{
			get
			{
				return this.iField;
			}
			set
			{
				this.iField = value;
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x060035C8 RID: 13768 RVA: 0x0008686C File Offset: 0x00084A6C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool iSpecified
		{
			get
			{
				return this.iField != null;
			}
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x00086877 File Offset: 0x00084A77
		public int SizeOfIArray()
		{
			if (this.iField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x00086884 File Offset: 0x00084A84
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewI()
		{
			this.iField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			return this.iField;
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x00086897 File Offset: 0x00084A97
		public void SetIArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty[] array)
		{
			this.iField = ((array.Length != 0) ? array[0] : null);
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x000868A9 File Offset: 0x00084AA9
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetIArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.iField;
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x000868BF File Offset: 0x00084ABF
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x000868C7 File Offset: 0x00084AC7
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty strike
		{
			get
			{
				return this.strikeField;
			}
			set
			{
				this.strikeField = value;
			}
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x000868D0 File Offset: 0x00084AD0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool strikeSpecified
		{
			get
			{
				return this.strikeField != null;
			}
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x000868DB File Offset: 0x00084ADB
		public int sizeOfStrikeArray()
		{
			if (this.strikeField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x000868E8 File Offset: 0x00084AE8
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewStrike()
		{
			this.strikeField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			return this.strikeField;
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x000868FB File Offset: 0x00084AFB
		public void SetStrikeArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty[] array)
		{
			this.strikeField = ((array.Length != 0) ? array[0] : null);
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x0008690D File Offset: 0x00084B0D
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetStrikeArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.strikeField;
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x060035D4 RID: 13780 RVA: 0x00086923 File Offset: 0x00084B23
		// (set) Token: 0x060035D5 RID: 13781 RVA: 0x0008692B File Offset: 0x00084B2B
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty outline
		{
			get
			{
				return this.outlineField;
			}
			set
			{
				this.outlineField = value;
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x060035D6 RID: 13782 RVA: 0x00086934 File Offset: 0x00084B34
		[global::System.Xml.Serialization.XmlIgnore]
		public bool outlineSpecified
		{
			get
			{
				return this.outlineField != null;
			}
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x0008693F File Offset: 0x00084B3F
		public int sizeOfOutlineArray()
		{
			if (this.outlineField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x0008694C File Offset: 0x00084B4C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewOutline()
		{
			this.outlineField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			return this.outlineField;
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x0008695F File Offset: 0x00084B5F
		public void SetOutlineArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty[] array)
		{
			this.outlineField = ((array.Length != 0) ? array[0] : null);
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x00086971 File Offset: 0x00084B71
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetOutlineArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.outlineField;
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x060035DB RID: 13787 RVA: 0x00086987 File Offset: 0x00084B87
		// (set) Token: 0x060035DC RID: 13788 RVA: 0x0008698F File Offset: 0x00084B8F
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty shadow
		{
			get
			{
				return this.shadowField;
			}
			set
			{
				this.shadowField = value;
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x060035DD RID: 13789 RVA: 0x00086998 File Offset: 0x00084B98
		[global::System.Xml.Serialization.XmlIgnore]
		public bool shadowSpecified
		{
			get
			{
				return this.shadowField != null;
			}
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x000869A3 File Offset: 0x00084BA3
		public int sizeOfShadowArray()
		{
			if (this.shadowField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x000869B0 File Offset: 0x00084BB0
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewShadow()
		{
			this.shadowField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			return this.shadowField;
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x000869C3 File Offset: 0x00084BC3
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetShadowArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.shadowField;
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x060035E1 RID: 13793 RVA: 0x000869D9 File Offset: 0x00084BD9
		// (set) Token: 0x060035E2 RID: 13794 RVA: 0x000869E1 File Offset: 0x00084BE1
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty condense
		{
			get
			{
				return this.condenseField;
			}
			set
			{
				this.condenseField = value;
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x060035E3 RID: 13795 RVA: 0x000869EA File Offset: 0x00084BEA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool condenseSpecified
		{
			get
			{
				return this.condenseField != null;
			}
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x000869F5 File Offset: 0x00084BF5
		public int sizeOfCondenseArray()
		{
			if (this.condenseField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x00086A02 File Offset: 0x00084C02
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewCondense()
		{
			this.condenseField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			return this.condenseField;
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x00086A15 File Offset: 0x00084C15
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetCondenseArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.condenseField;
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x060035E7 RID: 13799 RVA: 0x00086A2B File Offset: 0x00084C2B
		// (set) Token: 0x060035E8 RID: 13800 RVA: 0x00086A33 File Offset: 0x00084C33
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty extend
		{
			get
			{
				return this.extendField;
			}
			set
			{
				this.extendField = value;
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x060035E9 RID: 13801 RVA: 0x00086A3C File Offset: 0x00084C3C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extendSpecified
		{
			get
			{
				return this.extendField != null;
			}
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x00086A47 File Offset: 0x00084C47
		public int sizeOfExtendArray()
		{
			if (this.extendField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x00086A54 File Offset: 0x00084C54
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewExtend()
		{
			this.extendField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			return this.extendField;
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x00086A67 File Offset: 0x00084C67
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetExtendArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.extendField;
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x00086A7D File Offset: 0x00084C7D
		// (set) Token: 0x060035EE RID: 13806 RVA: 0x00086A85 File Offset: 0x00084C85
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x060035EF RID: 13807 RVA: 0x00086A8E File Offset: 0x00084C8E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool colorSpecified
		{
			get
			{
				return this.colorField != null;
			}
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x00086A99 File Offset: 0x00084C99
		public int SizeOfColorArray()
		{
			if (this.colorField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x00086AA6 File Offset: 0x00084CA6
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color GetColorArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.colorField;
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x00086ABC File Offset: 0x00084CBC
		public void SetColorArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color[] array)
		{
			this.colorField = ((array.Length != 0) ? array[0] : null);
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x00086ACE File Offset: 0x00084CCE
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color AddNewColor()
		{
			this.colorField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color();
			return this.colorField;
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x060035F4 RID: 13812 RVA: 0x00086AE1 File Offset: 0x00084CE1
		// (set) Token: 0x060035F5 RID: 13813 RVA: 0x00086AE9 File Offset: 0x00084CE9
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize sz
		{
			get
			{
				return this.szField;
			}
			set
			{
				this.szField = value;
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x060035F6 RID: 13814 RVA: 0x00086AF2 File Offset: 0x00084CF2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool szSpecified
		{
			get
			{
				return this.szField != null;
			}
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x00086AFD File Offset: 0x00084CFD
		public int SizeOfSzArray()
		{
			if (this.szField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x00086B0A File Offset: 0x00084D0A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize AddNewSz()
		{
			this.szField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize();
			return this.szField;
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x00086B1D File Offset: 0x00084D1D
		public void SetSzArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize[] array)
		{
			this.szField = ((array.Length != 0) ? array[0] : null);
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x00086B2F File Offset: 0x00084D2F
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize GetSzArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.szField;
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x00086B45 File Offset: 0x00084D45
		// (set) Token: 0x060035FC RID: 13820 RVA: 0x00086B4D File Offset: 0x00084D4D
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty u
		{
			get
			{
				return this.uField;
			}
			set
			{
				this.uField = value;
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x060035FD RID: 13821 RVA: 0x00086B56 File Offset: 0x00084D56
		[global::System.Xml.Serialization.XmlIgnore]
		public bool uSpecified
		{
			get
			{
				return this.uField != null;
			}
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x00086B61 File Offset: 0x00084D61
		public int SizeOfUArray()
		{
			if (this.uField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x00086B6E File Offset: 0x00084D6E
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty AddNewU()
		{
			this.uField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty();
			return this.uField;
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x00086B81 File Offset: 0x00084D81
		public void SetUArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty[] array)
		{
			this.uField = ((array.Length != 0) ? array[0] : null);
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x00086B93 File Offset: 0x00084D93
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty GetUArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.uField;
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x06003602 RID: 13826 RVA: 0x00086BA9 File Offset: 0x00084DA9
		// (set) Token: 0x06003603 RID: 13827 RVA: 0x00086BB1 File Offset: 0x00084DB1
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty vertAlign
		{
			get
			{
				return this.vertAlignField;
			}
			set
			{
				this.vertAlignField = value;
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06003604 RID: 13828 RVA: 0x00086BBA File Offset: 0x00084DBA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool vertAlignSpecified
		{
			get
			{
				return this.vertAlignField != null;
			}
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x00086BC5 File Offset: 0x00084DC5
		public int sizeOfVertAlignArray()
		{
			if (this.vertAlignField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x00086BD2 File Offset: 0x00084DD2
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty AddNewVertAlign()
		{
			this.vertAlignField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty();
			return this.vertAlignField;
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x00086BE5 File Offset: 0x00084DE5
		public void SetVertAlignArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty[] array)
		{
			this.vertAlignField = ((array.Length != 0) ? array[0] : null);
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x00086BF7 File Offset: 0x00084DF7
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty GetVertAlignArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.vertAlignField;
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x00086C0D File Offset: 0x00084E0D
		// (set) Token: 0x0600360A RID: 13834 RVA: 0x00086C15 File Offset: 0x00084E15
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme scheme
		{
			get
			{
				return this.schemeField;
			}
			set
			{
				this.schemeField = value;
			}
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x00086C1E File Offset: 0x00084E1E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool schemeSpecified
		{
			get
			{
				return this.schemeField != null;
			}
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x00086C29 File Offset: 0x00084E29
		public int sizeOfSchemeArray()
		{
			if (this.schemeField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x00086C36 File Offset: 0x00084E36
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme AddNewScheme()
		{
			this.schemeField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme();
			return this.schemeField;
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x00086C49 File Offset: 0x00084E49
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme GetSchemeArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.schemeField;
		}

		// Token: 0x04002398 RID: 9112
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName rFontField;

		// Token: 0x04002399 RID: 9113
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty charsetField;

		// Token: 0x0400239A RID: 9114
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty familyField;

		// Token: 0x0400239B RID: 9115
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty bField;

		// Token: 0x0400239C RID: 9116
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty iField;

		// Token: 0x0400239D RID: 9117
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty strikeField;

		// Token: 0x0400239E RID: 9118
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty outlineField;

		// Token: 0x0400239F RID: 9119
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty shadowField;

		// Token: 0x040023A0 RID: 9120
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty condenseField;

		// Token: 0x040023A1 RID: 9121
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty extendField;

		// Token: 0x040023A2 RID: 9122
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color colorField;

		// Token: 0x040023A3 RID: 9123
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize szField;

		// Token: 0x040023A4 RID: 9124
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty uField;

		// Token: 0x040023A5 RID: 9125
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty vertAlignField;

		// Token: 0x040023A6 RID: 9126
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme schemeField;
	}
}
