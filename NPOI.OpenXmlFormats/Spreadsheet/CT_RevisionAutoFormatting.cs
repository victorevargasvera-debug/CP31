using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200055E RID: 1374
	public class CT_RevisionAutoFormatting
	{
		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06003B88 RID: 15240 RVA: 0x00092E01 File Offset: 0x00091001
		// (set) Token: 0x06003B89 RID: 15241 RVA: 0x00092E09 File Offset: 0x00091009
		public uint sheetId
		{
			get
			{
				return this.sheetIdField;
			}
			set
			{
				this.sheetIdField = value;
			}
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06003B8A RID: 15242 RVA: 0x00092E12 File Offset: 0x00091012
		// (set) Token: 0x06003B8B RID: 15243 RVA: 0x00092E1A File Offset: 0x0009101A
		public uint autoFormatId
		{
			get
			{
				return this.autoFormatIdField;
			}
			set
			{
				this.autoFormatIdField = value;
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06003B8C RID: 15244 RVA: 0x00092E23 File Offset: 0x00091023
		// (set) Token: 0x06003B8D RID: 15245 RVA: 0x00092E2B File Offset: 0x0009102B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool autoFormatIdSpecified
		{
			get
			{
				return this.autoFormatIdFieldSpecified;
			}
			set
			{
				this.autoFormatIdFieldSpecified = value;
			}
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06003B8E RID: 15246 RVA: 0x00092E34 File Offset: 0x00091034
		// (set) Token: 0x06003B8F RID: 15247 RVA: 0x00092E3C File Offset: 0x0009103C
		public bool applyNumberFormats
		{
			get
			{
				return this.applyNumberFormatsField;
			}
			set
			{
				this.applyNumberFormatsField = value;
			}
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06003B90 RID: 15248 RVA: 0x00092E45 File Offset: 0x00091045
		// (set) Token: 0x06003B91 RID: 15249 RVA: 0x00092E4D File Offset: 0x0009104D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool applyNumberFormatsSpecified
		{
			get
			{
				return this.applyNumberFormatsFieldSpecified;
			}
			set
			{
				this.applyNumberFormatsFieldSpecified = value;
			}
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06003B92 RID: 15250 RVA: 0x00092E56 File Offset: 0x00091056
		// (set) Token: 0x06003B93 RID: 15251 RVA: 0x00092E5E File Offset: 0x0009105E
		public bool applyBorderFormats
		{
			get
			{
				return this.applyBorderFormatsField;
			}
			set
			{
				this.applyBorderFormatsField = value;
			}
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x00092E67 File Offset: 0x00091067
		// (set) Token: 0x06003B95 RID: 15253 RVA: 0x00092E6F File Offset: 0x0009106F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool applyBorderFormatsSpecified
		{
			get
			{
				return this.applyBorderFormatsFieldSpecified;
			}
			set
			{
				this.applyBorderFormatsFieldSpecified = value;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06003B96 RID: 15254 RVA: 0x00092E78 File Offset: 0x00091078
		// (set) Token: 0x06003B97 RID: 15255 RVA: 0x00092E80 File Offset: 0x00091080
		public bool applyFontFormats
		{
			get
			{
				return this.applyFontFormatsField;
			}
			set
			{
				this.applyFontFormatsField = value;
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06003B98 RID: 15256 RVA: 0x00092E89 File Offset: 0x00091089
		// (set) Token: 0x06003B99 RID: 15257 RVA: 0x00092E91 File Offset: 0x00091091
		[global::System.Xml.Serialization.XmlIgnore]
		public bool applyFontFormatsSpecified
		{
			get
			{
				return this.applyFontFormatsFieldSpecified;
			}
			set
			{
				this.applyFontFormatsFieldSpecified = value;
			}
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06003B9A RID: 15258 RVA: 0x00092E9A File Offset: 0x0009109A
		// (set) Token: 0x06003B9B RID: 15259 RVA: 0x00092EA2 File Offset: 0x000910A2
		public bool applyPatternFormats
		{
			get
			{
				return this.applyPatternFormatsField;
			}
			set
			{
				this.applyPatternFormatsField = value;
			}
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06003B9C RID: 15260 RVA: 0x00092EAB File Offset: 0x000910AB
		// (set) Token: 0x06003B9D RID: 15261 RVA: 0x00092EB3 File Offset: 0x000910B3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool applyPatternFormatsSpecified
		{
			get
			{
				return this.applyPatternFormatsFieldSpecified;
			}
			set
			{
				this.applyPatternFormatsFieldSpecified = value;
			}
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06003B9E RID: 15262 RVA: 0x00092EBC File Offset: 0x000910BC
		// (set) Token: 0x06003B9F RID: 15263 RVA: 0x00092EC4 File Offset: 0x000910C4
		public bool applyAlignmentFormats
		{
			get
			{
				return this.applyAlignmentFormatsField;
			}
			set
			{
				this.applyAlignmentFormatsField = value;
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06003BA0 RID: 15264 RVA: 0x00092ECD File Offset: 0x000910CD
		// (set) Token: 0x06003BA1 RID: 15265 RVA: 0x00092ED5 File Offset: 0x000910D5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool applyAlignmentFormatsSpecified
		{
			get
			{
				return this.applyAlignmentFormatsFieldSpecified;
			}
			set
			{
				this.applyAlignmentFormatsFieldSpecified = value;
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06003BA2 RID: 15266 RVA: 0x00092EDE File Offset: 0x000910DE
		// (set) Token: 0x06003BA3 RID: 15267 RVA: 0x00092EE6 File Offset: 0x000910E6
		public bool applyWidthHeightFormats
		{
			get
			{
				return this.applyWidthHeightFormatsField;
			}
			set
			{
				this.applyWidthHeightFormatsField = value;
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06003BA4 RID: 15268 RVA: 0x00092EEF File Offset: 0x000910EF
		// (set) Token: 0x06003BA5 RID: 15269 RVA: 0x00092EF7 File Offset: 0x000910F7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool applyWidthHeightFormatsSpecified
		{
			get
			{
				return this.applyWidthHeightFormatsFieldSpecified;
			}
			set
			{
				this.applyWidthHeightFormatsFieldSpecified = value;
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06003BA6 RID: 15270 RVA: 0x00092F00 File Offset: 0x00091100
		// (set) Token: 0x06003BA7 RID: 15271 RVA: 0x00092F08 File Offset: 0x00091108
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x04002635 RID: 9781
		private uint sheetIdField;

		// Token: 0x04002636 RID: 9782
		private uint autoFormatIdField;

		// Token: 0x04002637 RID: 9783
		private bool autoFormatIdFieldSpecified;

		// Token: 0x04002638 RID: 9784
		private bool applyNumberFormatsField;

		// Token: 0x04002639 RID: 9785
		private bool applyNumberFormatsFieldSpecified;

		// Token: 0x0400263A RID: 9786
		private bool applyBorderFormatsField;

		// Token: 0x0400263B RID: 9787
		private bool applyBorderFormatsFieldSpecified;

		// Token: 0x0400263C RID: 9788
		private bool applyFontFormatsField;

		// Token: 0x0400263D RID: 9789
		private bool applyFontFormatsFieldSpecified;

		// Token: 0x0400263E RID: 9790
		private bool applyPatternFormatsField;

		// Token: 0x0400263F RID: 9791
		private bool applyPatternFormatsFieldSpecified;

		// Token: 0x04002640 RID: 9792
		private bool applyAlignmentFormatsField;

		// Token: 0x04002641 RID: 9793
		private bool applyAlignmentFormatsFieldSpecified;

		// Token: 0x04002642 RID: 9794
		private bool applyWidthHeightFormatsField;

		// Token: 0x04002643 RID: 9795
		private bool applyWidthHeightFormatsFieldSpecified;

		// Token: 0x04002644 RID: 9796
		private string refField;
	}
}
