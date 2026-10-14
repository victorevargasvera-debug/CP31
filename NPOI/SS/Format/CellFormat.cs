using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.SS.Format
{
	// Token: 0x02000245 RID: 581
	public class CellFormat
	{
		// Token: 0x06000E2E RID: 3630 RVA: 0x000288A4 File Offset: 0x00026AA4
		public static global::NPOI.SS.Format.CellFormat GetInstance(string format)
		{
			global::NPOI.SS.Format.CellFormat cellFormat = null;
			if (global::NPOI.SS.Format.CellFormat.formatCache.ContainsKey(format))
			{
				cellFormat = global::NPOI.SS.Format.CellFormat.formatCache[format];
			}
			if (cellFormat == null)
			{
				if (format.Equals("General") || format.Equals("@"))
				{
					cellFormat = global::NPOI.SS.Format.CellFormat.GENERAL_FORMAT;
				}
				else
				{
					cellFormat = new global::NPOI.SS.Format.CellFormat(format);
				}
				global::NPOI.SS.Format.CellFormat.formatCache.Add(format, cellFormat);
			}
			return cellFormat;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00028908 File Offset: 0x00026B08
		private CellFormat(string format)
		{
			this.format = format;
			global::System.Text.RegularExpressions.MatchCollection matchCollection = global::NPOI.SS.Format.CellFormat.ONE_PART.Matches(format);
			global::System.Collections.Generic.List<global::NPOI.SS.Format.CellFormatPart> list = new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellFormatPart>();
			foreach (object obj in matchCollection)
			{
				global::System.Text.RegularExpressions.Match match = (global::System.Text.RegularExpressions.Match)obj;
				try
				{
					string text = match.Groups[0].Value;
					if (text.EndsWith(";"))
					{
						text = text.Substring(0, text.Length - 1);
					}
					list.Add(new global::NPOI.SS.Format.CellFormatPart(text));
				}
				catch (global::System.Exception)
				{
					list.Add(null);
				}
			}
			this.formatPartCount = list.Count;
			switch (this.formatPartCount)
			{
			case 1:
				this.posNumFmt = list[0];
				this.negNumFmt = null;
				this.zeroNumFmt = null;
				this.textFmt = global::NPOI.SS.Format.CellFormat.DEFAULT_TEXT_FORMAT;
				return;
			case 2:
				this.posNumFmt = list[0];
				this.negNumFmt = list[1];
				this.zeroNumFmt = null;
				this.textFmt = global::NPOI.SS.Format.CellFormat.DEFAULT_TEXT_FORMAT;
				return;
			case 3:
				this.posNumFmt = list[0];
				this.negNumFmt = list[1];
				this.zeroNumFmt = list[2];
				this.textFmt = global::NPOI.SS.Format.CellFormat.DEFAULT_TEXT_FORMAT;
				return;
			}
			this.posNumFmt = list[0];
			this.negNumFmt = list[1];
			this.zeroNumFmt = list[2];
			this.textFmt = list[3];
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00028AB8 File Offset: 0x00026CB8
		public virtual global::NPOI.SS.Format.CellFormatResult Apply(object value)
		{
			if (global::NPOI.Util.Number.IsNumber(value))
			{
				double num;
				double.TryParse(value.ToString(), out num);
				if (num < 0.0 && ((this.formatPartCount == 2 && !this.posNumFmt.HasCondition && !this.negNumFmt.HasCondition) || (this.formatPartCount == 3 && !this.negNumFmt.HasCondition) || (this.formatPartCount == 4 && !this.negNumFmt.HasCondition)))
				{
					return this.negNumFmt.Apply(-num);
				}
				return this.GetApplicableFormatPart(num).Apply(num);
			}
			else
			{
				if (!(value is global::System.DateTime))
				{
					return this.textFmt.Apply(value);
				}
				double excelDate = global::NPOI.SS.UserModel.DateUtil.GetExcelDate((global::System.DateTime)value);
				if (global::NPOI.SS.UserModel.DateUtil.IsValidExcelDate(excelDate))
				{
					return this.GetApplicableFormatPart(excelDate).Apply(value);
				}
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"value ",
					excelDate.ToString(),
					" of date ",
					(value != null) ? value.ToString() : null,
					" is not a valid Excel date"
				}));
			}
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00028BE1 File Offset: 0x00026DE1
		private global::NPOI.SS.Format.CellFormatResult Apply(global::System.DateTime date, double numericValue)
		{
			return this.GetApplicableFormatPart(numericValue).Apply(date);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00028BFC File Offset: 0x00026DFC
		public global::NPOI.SS.Format.CellFormatResult Apply(global::NPOI.SS.UserModel.ICell c)
		{
			switch (global::NPOI.SS.Format.CellFormat.UltimateType(c))
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
			{
				double numericCellValue = c.NumericCellValue;
				if (this.GetApplicableFormatPart(numericCellValue).CellFormatType != global::NPOI.SS.Format.CellFormatType.DATE)
				{
					return this.Apply(numericCellValue);
				}
				if (global::NPOI.SS.UserModel.DateUtil.IsValidExcelDate(numericCellValue))
				{
					return this.Apply(c.DateCellValue, numericCellValue);
				}
				return this.Apply("###############################################################################################################################################################################################################################################################");
			}
			case global::NPOI.SS.UserModel.CellType.String:
				return this.Apply(c.StringCellValue);
			case global::NPOI.SS.UserModel.CellType.Blank:
				return this.Apply("");
			case global::NPOI.SS.UserModel.CellType.Boolean:
				return this.Apply(c.BooleanCellValue);
			}
			return this.Apply("?");
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00028CB0 File Offset: 0x00026EB0
		private global::NPOI.SS.Format.CellFormatPart GetApplicableFormatPart(object value)
		{
			if (!global::NPOI.Util.Number.IsNumber(value))
			{
				throw new global::System.ArgumentException("value must be a Number");
			}
			double num;
			double.TryParse(value.ToString(), out num);
			if (this.formatPartCount == 1)
			{
				if (!this.posNumFmt.HasCondition || (this.posNumFmt.HasCondition && this.posNumFmt.Applies(num)))
				{
					return this.posNumFmt;
				}
				return new global::NPOI.SS.Format.CellFormatPart("General");
			}
			else if (this.formatPartCount == 2)
			{
				if ((!this.posNumFmt.HasCondition && num >= 0.0) || (this.posNumFmt.HasCondition && this.posNumFmt.Applies(num)))
				{
					return this.posNumFmt;
				}
				if (!this.negNumFmt.HasCondition || (this.negNumFmt.HasCondition && this.negNumFmt.Applies(num)))
				{
					return this.negNumFmt;
				}
				return new global::NPOI.SS.Format.CellFormatPart("\"###############################################################################################################################################################################################################################################################\"");
			}
			else
			{
				if ((!this.posNumFmt.HasCondition && num > 0.0) || (this.posNumFmt.HasCondition && this.posNumFmt.Applies(num)))
				{
					return this.posNumFmt;
				}
				if ((!this.negNumFmt.HasCondition && num < 0.0) || (this.negNumFmt.HasCondition && this.negNumFmt.Applies(num)))
				{
					return this.negNumFmt;
				}
				return this.zeroNumFmt;
			}
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00028E38 File Offset: 0x00027038
		public static global::NPOI.SS.UserModel.CellType UltimateType(global::NPOI.SS.UserModel.ICell cell)
		{
			global::NPOI.SS.UserModel.CellType cellType = cell.CellType;
			if (cellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				return cell.CachedFormulaResultType;
			}
			return cellType;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00028E58 File Offset: 0x00027058
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			if (obj is global::NPOI.SS.Format.CellFormat)
			{
				global::NPOI.SS.Format.CellFormat cellFormat = (global::NPOI.SS.Format.CellFormat)obj;
				return this.format.Equals(cellFormat.format);
			}
			return false;
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00028E8D File Offset: 0x0002708D
		public override int GetHashCode()
		{
			return this.format.GetHashCode();
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00028E9A File Offset: 0x0002709A
		public override string ToString()
		{
			return this.format;
		}

		// Token: 0x0400065F RID: 1631
		private string format;

		// Token: 0x04000660 RID: 1632
		private global::NPOI.SS.Format.CellFormatPart posNumFmt;

		// Token: 0x04000661 RID: 1633
		private global::NPOI.SS.Format.CellFormatPart zeroNumFmt;

		// Token: 0x04000662 RID: 1634
		private global::NPOI.SS.Format.CellFormatPart negNumFmt;

		// Token: 0x04000663 RID: 1635
		private global::NPOI.SS.Format.CellFormatPart textFmt;

		// Token: 0x04000664 RID: 1636
		private int formatPartCount;

		// Token: 0x04000665 RID: 1637
		private static readonly global::System.Text.RegularExpressions.Regex ONE_PART = new global::System.Text.RegularExpressions.Regex(global::NPOI.SS.Format.CellFormatPart.FORMAT_PAT.ToString() + "(;|$)", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace);

		// Token: 0x04000666 RID: 1638
		private static readonly global::NPOI.SS.Format.CellFormatPart DEFAULT_TEXT_FORMAT = new global::NPOI.SS.Format.CellFormatPart("@");

		// Token: 0x04000667 RID: 1639
		private const string INVALID_VALUE_FOR_FORMAT = "###############################################################################################################################################################################################################################################################";

		// Token: 0x04000668 RID: 1640
		private const string QUOTE = "\"";

		// Token: 0x04000669 RID: 1641
		private static readonly global::NPOI.SS.Format.CellFormat GENERAL_FORMAT = new global::NPOI.SS.Format.CellFormat.GeneralCellFormat();

		// Token: 0x0400066A RID: 1642
		private static global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Format.CellFormat> formatCache = new global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Format.CellFormat>();

		// Token: 0x02000597 RID: 1431
		public class GeneralCellFormat : global::NPOI.SS.Format.CellFormat
		{
			// Token: 0x0600345A RID: 13402 RVA: 0x000A31CB File Offset: 0x000A13CB
			public GeneralCellFormat() : base("General")
			{
			}

			// Token: 0x0600345B RID: 13403 RVA: 0x000A31D8 File Offset: 0x000A13D8
			public override global::NPOI.SS.Format.CellFormatResult Apply(object value)
			{
				string text = new global::NPOI.SS.Format.CellGeneralFormatter().Format(value);
				return new global::NPOI.SS.Format.CellFormatResult(true, text, global::System.Drawing.Color.Empty);
			}
		}
	}
}
