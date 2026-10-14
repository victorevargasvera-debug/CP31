using System;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200004D RID: 77
	public class XWPFStyle
	{
		// Token: 0x06000336 RID: 822 RVA: 0x0000CE78 File Offset: 0x0000B078
		public XWPFStyle(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style style) : this(style, null)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000CE82 File Offset: 0x0000B082
		public XWPFStyle(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style style, global::NPOI.XWPF.UserModel.XWPFStyles styles)
		{
			this.ctStyle = style;
			this.styles = styles;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000CE98 File Offset: 0x0000B098
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000CEA5 File Offset: 0x0000B0A5
		public string StyleId
		{
			get
			{
				return this.ctStyle.styleId;
			}
			set
			{
				this.ctStyle.styleId = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000CEB3 File Offset: 0x0000B0B3
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000CEC0 File Offset: 0x0000B0C0
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_StyleType StyleType
		{
			get
			{
				return this.ctStyle.type;
			}
			set
			{
				this.ctStyle.type = value;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000CECE File Offset: 0x0000B0CE
		public void SetStyle(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style style)
		{
			this.ctStyle = style;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000CED7 File Offset: 0x0000B0D7
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style GetCTStyle()
		{
			return this.ctStyle;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000CEDF File Offset: 0x0000B0DF
		public global::NPOI.XWPF.UserModel.XWPFStyles GetStyles()
		{
			return this.styles;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0000CEE7 File Offset: 0x0000B0E7
		public string BasisStyleID
		{
			get
			{
				if (this.ctStyle.basedOn != null)
				{
					return this.ctStyle.basedOn.val;
				}
				return null;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000CF08 File Offset: 0x0000B108
		public string LinkStyleID
		{
			get
			{
				if (this.ctStyle.link != null)
				{
					return this.ctStyle.link.val;
				}
				return null;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000CF29 File Offset: 0x0000B129
		public string NextStyleID
		{
			get
			{
				if (this.ctStyle.next != null)
				{
					return this.ctStyle.next.val;
				}
				return null;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000CF4A File Offset: 0x0000B14A
		public string Name
		{
			get
			{
				if (this.ctStyle.IsSetName())
				{
					return this.ctStyle.name.val;
				}
				return null;
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000CF6B File Offset: 0x0000B16B
		public bool HasSameName(global::NPOI.XWPF.UserModel.XWPFStyle compStyle)
		{
			return compStyle.GetCTStyle().name.val.Equals(this.ctStyle.name.val);
		}

		// Token: 0x04000222 RID: 546
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style ctStyle;

		// Token: 0x04000223 RID: 547
		protected global::NPOI.XWPF.UserModel.XWPFStyles styles;
	}
}
