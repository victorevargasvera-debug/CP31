using System;
using NPOI.HSSF.UserModel;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel.Helpers;

namespace NPOI.XSSF.UserModel.Extensions
{
	// Token: 0x020000B5 RID: 181
	public abstract class XSSFHeaderFooter : global::NPOI.SS.UserModel.IHeaderFooter
	{
		// Token: 0x06000B5A RID: 2906 RVA: 0x0002AB35 File Offset: 0x00028D35
		public XSSFHeaderFooter(global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooter)
		{
			this.headerFooter = headerFooter;
			this.helper = new global::NPOI.XSSF.UserModel.Helpers.HeaderFooterHelper();
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0002AB4F File Offset: 0x00028D4F
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter GetHeaderFooter()
		{
			return this.headerFooter;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0002AB58 File Offset: 0x00028D58
		public string GetValue()
		{
			string text = this.Text;
			if (text == null)
			{
				return "";
			}
			return text;
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0002AB76 File Offset: 0x00028D76
		public bool AreFieldsStripped()
		{
			return this.stripFields;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0002AB7E File Offset: 0x00028D7E
		public void SetAreFieldsStripped(bool stripFields)
		{
			this.stripFields = stripFields;
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000B5F RID: 2911
		// (set) Token: 0x06000B60 RID: 2912
		public abstract string Text { get; set; }

		// Token: 0x06000B61 RID: 2913 RVA: 0x0002AB87 File Offset: 0x00028D87
		public static string StripFields(string text)
		{
			return global::NPOI.HSSF.UserModel.HeaderFooter.StripFields(text);
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0002AB90 File Offset: 0x00028D90
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x0002ABBF File Offset: 0x00028DBF
		public string Center
		{
			get
			{
				string centerSection = this.helper.GetCenterSection(this.Text);
				if (this.stripFields)
				{
					return global::NPOI.XSSF.UserModel.Extensions.XSSFHeaderFooter.StripFields(centerSection);
				}
				return centerSection;
			}
			set
			{
				this.Text = this.helper.SetCenterSection(this.Text, value);
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0002ABDC File Offset: 0x00028DDC
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0002AC0B File Offset: 0x00028E0B
		public string Left
		{
			get
			{
				string leftSection = this.helper.GetLeftSection(this.Text);
				if (this.stripFields)
				{
					return global::NPOI.XSSF.UserModel.Extensions.XSSFHeaderFooter.StripFields(leftSection);
				}
				return leftSection;
			}
			set
			{
				this.Text = this.helper.SetLeftSection(this.Text, value);
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0002AC28 File Offset: 0x00028E28
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x0002AC57 File Offset: 0x00028E57
		public string Right
		{
			get
			{
				string rightSection = this.helper.GetRightSection(this.Text);
				if (this.stripFields)
				{
					return global::NPOI.XSSF.UserModel.Extensions.XSSFHeaderFooter.StripFields(rightSection);
				}
				return rightSection;
			}
			set
			{
				this.Text = this.helper.SetRightSection(this.Text, value);
			}
		}

		// Token: 0x040003BA RID: 954
		private global::NPOI.XSSF.UserModel.Helpers.HeaderFooterHelper helper;

		// Token: 0x040003BB RID: 955
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooter;

		// Token: 0x040003BC RID: 956
		private bool stripFields;
	}
}
