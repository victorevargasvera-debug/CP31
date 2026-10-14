using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.SS.Format;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200005A RID: 90
	public class DataFormatter
	{
		// Token: 0x06000354 RID: 852 RVA: 0x0000B22C File Offset: 0x0000942C
		static DataFormatter()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < 255; i++)
			{
				stringBuilder.Append('#');
			}
			global::NPOI.SS.UserModel.DataFormatter.invalidDateTimeString = stringBuilder.ToString();
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000B31A File Offset: 0x0000951A
		public DataFormatter() : this(false)
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000B323 File Offset: 0x00009523
		public DataFormatter(bool emulateCSV) : this(global::System.Globalization.CultureInfo.CurrentCulture, true, emulateCSV)
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000B332 File Offset: 0x00009532
		public DataFormatter(global::System.Globalization.CultureInfo locale) : this(locale, false)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000B33C File Offset: 0x0000953C
		public DataFormatter(global::System.Globalization.CultureInfo locale, bool emulateCSV) : this(locale, false, emulateCSV)
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000B348 File Offset: 0x00009548
		public DataFormatter(global::System.Globalization.CultureInfo culture, bool localeIsAdapting, bool emulateCSV)
		{
			this.localeIsAdapting = true;
			this.currentCulture = culture;
			this.localeIsAdapting = localeIsAdapting;
			this.emulateCSV = emulateCSV;
			this.dateSymbols = culture.DateTimeFormat;
			this.decimalSymbols = culture.NumberFormat;
			this.generalNumberFormat = new global::NPOI.SS.UserModel.ExcelGeneralNumberFormat(culture);
			this.defaultDateformat = new global::NPOI.SS.Util.SimpleDateFormat(this.dateSymbols.FullDateTimePattern, this.dateSymbols);
			this.defaultDateformat.TimeZone = global::System.TimeZoneInfo.Local;
			this.formats = new global::System.Collections.Hashtable();
			global::NPOI.SS.Util.FormatBase instance = global::NPOI.SS.Util.ZipPlusFourFormat.Instance;
			this.AddFormat("00000\\-0000", instance);
			this.AddFormat("00000-0000", instance);
			global::NPOI.SS.Util.FormatBase instance2 = global::NPOI.SS.Util.PhoneFormat.Instance;
			this.AddFormat("[<=9999999]###\\-####;\\(###\\)\\ ###\\-####", instance2);
			this.AddFormat("[<=9999999]###-####;(###) ###-####", instance2);
			this.AddFormat("###\\-####;\\(###\\)\\ ###\\-####", instance2);
			this.AddFormat("###-####;(###) ###-####", instance2);
			global::NPOI.SS.Util.FormatBase instance3 = global::NPOI.SS.Util.SSNFormat.Instance;
			this.AddFormat("000\\-00\\-0000", instance3);
			this.AddFormat("000-00-0000", instance3);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000B444 File Offset: 0x00009644
		private global::NPOI.SS.Util.FormatBase GetFormat(global::NPOI.SS.UserModel.ICell cell)
		{
			if (cell.CellStyle == null)
			{
				return null;
			}
			int dataFormat = (int)cell.CellStyle.DataFormat;
			string dataFormatString = cell.CellStyle.GetDataFormatString();
			if (dataFormatString == null || dataFormatString.Trim().Length == 0)
			{
				return null;
			}
			return this.GetFormat(cell.NumericCellValue, dataFormat, dataFormatString);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000B494 File Offset: 0x00009694
		private global::NPOI.SS.Util.FormatBase GetFormat(double cellValue, int formatIndex, string formatStrIn)
		{
			string text = formatStrIn;
			if (text.IndexOf(';') != -1 && text.IndexOf(';') != text.LastIndexOf(';'))
			{
				try
				{
					global::NPOI.SS.Format.CellFormat instance = global::NPOI.SS.Format.CellFormat.GetInstance(text);
					object obj = cellValue;
					if (global::NPOI.SS.UserModel.DateUtil.IsADateFormat(formatIndex, text) && (double)obj != 0.0)
					{
						obj = global::NPOI.SS.UserModel.DateUtil.GetJavaDate(cellValue);
					}
					return new global::NPOI.SS.UserModel.DataFormatter.CellFormatResultWrapper(instance.Apply(obj), this.emulateCSV);
				}
				catch (global::System.Exception exception)
				{
					global::NPOI.SS.UserModel.DataFormatter.logger.Log(5, "Formatting failed for format " + text + ", falling back", exception);
				}
			}
			int num = text.IndexOf(';');
			int num2 = text.LastIndexOf(';');
			if (num != -1 && num != num2)
			{
				int num3 = text.IndexOf(';', num + 1);
				if (num3 == num2)
				{
					if (cellValue == 0.0)
					{
						text = text.Substring(num2 + 1);
					}
					else
					{
						text = text.Substring(0, num2);
					}
				}
				else if (cellValue == 0.0)
				{
					text = text.Substring(num3 + 1, num2 - (num3 + 1));
				}
				else
				{
					text = text.Substring(0, num3);
				}
			}
			if (this.emulateCSV && cellValue == 0.0 && text.Contains("#") && !text.Contains("0"))
			{
				text = text.Replace("#", "");
			}
			global::NPOI.SS.Util.FormatBase formatBase = (global::NPOI.SS.Util.FormatBase)this.formats[text];
			if (formatBase != null)
			{
				return formatBase;
			}
			if (text.Equals("General", global::System.StringComparison.CurrentCultureIgnoreCase) || "@".Equals(text))
			{
				return this.generalNumberFormat;
			}
			formatBase = this.CreateFormat(cellValue, formatIndex, text);
			this.formats[text] = formatBase;
			return formatBase;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000B650 File Offset: 0x00009850
		public global::NPOI.SS.Util.FormatBase CreateFormat(global::NPOI.SS.UserModel.ICell cell)
		{
			int dataFormat = (int)cell.CellStyle.DataFormat;
			string dataFormatString = cell.CellStyle.GetDataFormatString();
			return this.CreateFormat(cell.NumericCellValue, dataFormat, dataFormatString);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000B684 File Offset: 0x00009884
		private global::NPOI.SS.Util.FormatBase CreateFormat(double cellValue, int formatIndex, string sFormat)
		{
			string text = global::NPOI.SS.UserModel.DataFormatter.colorPattern.Replace(sFormat, "");
			foreach (object obj in global::System.Text.RegularExpressions.Regex.Matches(text, global::NPOI.SS.UserModel.DataFormatter.localePatternGroup))
			{
				global::System.Text.RegularExpressions.Match match = (global::System.Text.RegularExpressions.Match)obj;
				string text2 = match.Value;
				int num = text2.IndexOf('$') + 1;
				int num2 = text2.IndexOf('-');
				string text3 = text2.Substring(num, num2 - num);
				if (text3.IndexOf('$') > -1)
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					stringBuilder.Append(text3.Substring(0, text3.IndexOf('$')));
					stringBuilder.Append('\\');
					stringBuilder.Append(text3.Substring(text3.IndexOf('$'), text3.Length));
					text3 = stringBuilder.ToString();
				}
				text2 = global::System.Text.RegularExpressions.Regex.Replace(text2, global::NPOI.SS.UserModel.DataFormatter.localePatternGroup, text3);
				text = text.Remove(match.Index, match.Length);
				text = text.Insert(match.Index, text2);
			}
			if (text == null || text.Trim().Length == 0)
			{
				return this.GetDefaultFormat(cellValue);
			}
			if ("General".Equals(text, global::System.StringComparison.CurrentCultureIgnoreCase) || "@".Equals(text))
			{
				return this.generalNumberFormat;
			}
			if (global::NPOI.SS.UserModel.DateUtil.IsADateFormat(formatIndex, text) && global::NPOI.SS.UserModel.DateUtil.IsValidExcelDate(cellValue))
			{
				return this.CreateDateFormat(text, cellValue);
			}
			if (text.IndexOf("#/") >= 0 || text.IndexOf("?/") >= 0)
			{
				string[] array = text.Split(";".ToCharArray());
				for (int i = 0; i < array.Length; i++)
				{
					string text4 = array[i].Replace("?", "#");
					text4 = global::NPOI.SS.UserModel.DataFormatter.fractionStripper.Replace(text4, " ");
					text4 = text4.Replace(" +", " ");
					global::System.Text.RegularExpressions.Match match2 = global::NPOI.SS.UserModel.DataFormatter.fractionPattern.Match(text4);
					if (match2.Success)
					{
						return new global::NPOI.SS.UserModel.FractionFormat((match2.Groups[1] == null || !match2.Groups[1].Success) ? "" : global::NPOI.SS.UserModel.DataFormatter.defaultFractionWholePartFormat, match2.Groups[3].Value);
					}
				}
				return new global::NPOI.SS.UserModel.FractionFormat(global::NPOI.SS.UserModel.DataFormatter.defaultFractionWholePartFormat, global::NPOI.SS.UserModel.DataFormatter.defaultFractionFractionPartFormat);
			}
			if (global::System.Text.RegularExpressions.Regex.IsMatch(text, global::NPOI.SS.UserModel.DataFormatter.numPattern))
			{
				return this.CreateNumberFormat(text, cellValue);
			}
			if (this.emulateCSV)
			{
				return new global::NPOI.SS.Util.ConstantStringFormat(this.cleanFormatForNumber(text));
			}
			return null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000B91C File Offset: 0x00009B1C
		private int IndexOfFraction(string format)
		{
			int num = format.IndexOf("#/#");
			int num2 = format.IndexOf("?/?");
			if (num == -1)
			{
				return num2;
			}
			if (num2 != -1)
			{
				return global::System.Math.Min(num, num2);
			}
			return num;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000B954 File Offset: 0x00009B54
		private int LastIndexOfFraction(string format)
		{
			int num = format.LastIndexOf("#/#");
			int num2 = format.LastIndexOf("?/?");
			if (num == -1)
			{
				return num2;
			}
			if (num2 != -1)
			{
				return global::System.Math.Max(num, num2);
			}
			return num;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000B98C File Offset: 0x00009B8C
		private global::NPOI.SS.Util.FormatBase CreateDateFormat(string pformatStr, double cellValue)
		{
			string text = pformatStr.Replace("\\-", "-");
			text = text.Replace("\\,", ",");
			text = text.Replace("\\.", ".");
			text = text.Replace("\\ ", " ");
			text = text.Replace("\\/", "/");
			text = text.Replace(";@", "");
			text = text.Replace("\"/\"", "/");
			text = text.Replace("\"\"", "'");
			text = text.Replace("\\\\T", "'T'");
			bool flag = global::System.Text.RegularExpressions.Regex.IsMatch(text, global::NPOI.SS.UserModel.DataFormatter.amPmPattern);
			if (flag)
			{
				text = global::System.Text.RegularExpressions.Regex.Replace(text, global::NPOI.SS.UserModel.DataFormatter.amPmPattern, "@");
			}
			text = text.Replace("@", "tt");
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			char[] array = text.ToCharArray();
			bool flag2 = true;
			bool flag3 = false;
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			for (int i = 0; i < array.Length; i++)
			{
				char c = array[i];
				if (c == '\'')
				{
					stringBuilder.Append(c);
					for (i++; i < array.Length; i++)
					{
						c = array[i];
						stringBuilder.Append(c);
						if (c == '\'')
						{
							break;
						}
					}
				}
				else if (c == '[' && !flag3)
				{
					flag3 = true;
					flag2 = false;
					stringBuilder.Append(c);
				}
				else if (c == ']' && flag3)
				{
					flag3 = false;
					stringBuilder.Append(c);
				}
				else if (flag3)
				{
					if (c == 'h' || c == 'H')
					{
						stringBuilder.Append('H');
					}
					else if (c == 'm' || c == 'M')
					{
						stringBuilder.Append('m');
					}
					else if (c == 's' || c == 'S')
					{
						stringBuilder.Append('s');
					}
					else
					{
						stringBuilder.Append(c);
					}
				}
				else if (c == 'h' || c == 'H')
				{
					flag2 = false;
					if (flag)
					{
						stringBuilder.Append('h');
					}
					else
					{
						stringBuilder.Append('H');
					}
				}
				else if (c == 'm' || c == 'M')
				{
					if (flag2)
					{
						stringBuilder.Append('M');
						list.Add(stringBuilder.Length - 1);
					}
					else
					{
						stringBuilder.Append('m');
					}
				}
				else if (c == 's' || c == 'S')
				{
					stringBuilder.Append('s');
					foreach (int index in list)
					{
						if (stringBuilder[index] == 'M')
						{
							stringBuilder[index] = 'm';
						}
					}
					flag2 = true;
					list.Clear();
				}
				else if (char.IsLetter(c))
				{
					flag2 = true;
					list.Clear();
					if (c == 'y' || c == 'Y')
					{
						stringBuilder.Append('y');
					}
					else if (c == 'd' || c == 'D')
					{
						stringBuilder.Append('d');
					}
					else
					{
						stringBuilder.Append(c);
					}
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			text = stringBuilder.ToString();
			global::NPOI.SS.Util.FormatBase result;
			try
			{
				result = new global::NPOI.SS.UserModel.ExcelStyleDateFormatter(text);
			}
			catch (global::System.ArgumentException)
			{
				result = this.GetDefaultFormat(cellValue);
			}
			return result;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000BCD8 File Offset: 0x00009ED8
		private string cleanFormatForNumber(string formatStr)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(formatStr);
			if (this.emulateCSV)
			{
				for (int i = 0; i < stringBuilder.Length; i++)
				{
					char c = stringBuilder[i];
					if ((c == '_' || c == '*' || c == '?') && (i <= 0 || stringBuilder[i - 1] != '\\'))
					{
						if (c == '?')
						{
							stringBuilder[i] = ' ';
						}
						else if (i < stringBuilder.Length - 1)
						{
							if (c == '_')
							{
								stringBuilder[i + 1] = ' ';
							}
							else
							{
								stringBuilder.Remove(i + 1, 1);
							}
							stringBuilder.Remove(i, 1);
							i--;
						}
					}
				}
			}
			else
			{
				for (int j = 0; j < stringBuilder.Length; j++)
				{
					char c2 = stringBuilder[j];
					if ((c2 == '_' || c2 == '*') && (j <= 0 || stringBuilder[j - 1] != '\\'))
					{
						if (j < stringBuilder.Length - 1)
						{
							stringBuilder.Remove(j + 1, 1);
						}
						stringBuilder.Remove(j, 1);
						j--;
					}
				}
			}
			for (int k = 0; k < stringBuilder.Length; k++)
			{
				char c3 = stringBuilder[k];
				if (c3 == '\\' || c3 == '"')
				{
					stringBuilder.Remove(k, 1);
					k--;
				}
				else if (c3 == '+' && k > 0 && stringBuilder[k - 1] == 'E')
				{
					stringBuilder.Remove(k, 1);
					k--;
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000BE40 File Offset: 0x0000A040
		private global::NPOI.SS.Util.FormatBase CreateNumberFormat(string formatStr, double cellValue)
		{
			string text = this.cleanFormatForNumber(formatStr);
			global::System.Globalization.NumberFormatInfo numberFormatInfo = this.decimalSymbols;
			global::System.Text.RegularExpressions.Match match = global::NPOI.SS.UserModel.DataFormatter.alternateGrouping.Match(text);
			if (match.Success)
			{
				char c = match.Groups[2].Value[0];
				if (c != ',')
				{
					numberFormatInfo = (this.currentCulture.NumberFormat.Clone() as global::System.Globalization.NumberFormatInfo);
					numberFormatInfo.NumberGroupSeparator = c.ToString();
					string value = match.Groups[1].Value;
					string newValue = value.Replace(c, ',');
					text = text.Replace(value, newValue);
				}
			}
			global::NPOI.SS.Util.FormatBase result;
			try
			{
				result = new global::NPOI.SS.Util.DecimalFormat(text, numberFormatInfo);
			}
			catch (global::System.ArgumentException)
			{
				result = this.GetDefaultFormat(cellValue);
			}
			return result;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000BF04 File Offset: 0x0000A104
		public global::NPOI.SS.Util.FormatBase GetDefaultFormat(global::NPOI.SS.UserModel.ICell cell)
		{
			return this.GetDefaultFormat(cell.NumericCellValue);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000BF12 File Offset: 0x0000A112
		private global::NPOI.SS.Util.FormatBase GetDefaultFormat(double cellValue)
		{
			if (this.defaultNumFormat != null)
			{
				return this.defaultNumFormat;
			}
			return this.generalNumberFormat;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000BF2C File Offset: 0x0000A12C
		private string GetFormattedDateString(global::NPOI.SS.UserModel.ICell cell)
		{
			global::NPOI.SS.Util.FormatBase format = this.GetFormat(cell);
			if (format is global::NPOI.SS.UserModel.ExcelStyleDateFormatter)
			{
				((global::NPOI.SS.UserModel.ExcelStyleDateFormatter)format).SetDateToBeFormatted(cell.NumericCellValue);
			}
			global::System.DateTime dateCellValue = cell.DateCellValue;
			return this.PerformDateFormatting(dateCellValue, format);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000BF6C File Offset: 0x0000A16C
		private string GetFormattedNumberString(global::NPOI.SS.UserModel.ICell cell)
		{
			global::NPOI.SS.Util.FormatBase format = this.GetFormat(cell);
			double numericCellValue = cell.NumericCellValue;
			if (format == null)
			{
				return numericCellValue.ToString(this.currentCulture);
			}
			string text = format.Format(numericCellValue);
			if (text.StartsWith("."))
			{
				text = "0" + text;
			}
			if (text.StartsWith("-."))
			{
				text = "-0" + text.Substring(1);
			}
			return global::System.Text.RegularExpressions.Regex.Replace(text, "E(\\d)", "E+$1");
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000BFEE File Offset: 0x0000A1EE
		public string FormatRawCellContents(double value, int formatIndex, string formatString)
		{
			return this.FormatRawCellContents(value, formatIndex, formatString, false);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000BFFA File Offset: 0x0000A1FA
		private string PerformDateFormatting(global::System.DateTime d, global::NPOI.SS.Util.FormatBase dateFormat)
		{
			if (dateFormat != null)
			{
				return dateFormat.Format(d);
			}
			return this.defaultDateformat.Format(d);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000C020 File Offset: 0x0000A220
		public string FormatRawCellContents(double value, int formatIndex, string formatString, bool use1904Windowing)
		{
			if (global::NPOI.SS.UserModel.DateUtil.IsADateFormat(formatIndex, formatString))
			{
				if (global::NPOI.SS.UserModel.DateUtil.IsValidExcelDate(value))
				{
					global::NPOI.SS.Util.FormatBase format = this.GetFormat(value, formatIndex, formatString);
					if (format is global::NPOI.SS.UserModel.ExcelStyleDateFormatter)
					{
						((global::NPOI.SS.UserModel.ExcelStyleDateFormatter)format).SetDateToBeFormatted(value);
					}
					global::System.DateTime javaDate = global::NPOI.SS.UserModel.DateUtil.GetJavaDate(value, use1904Windowing);
					return this.PerformDateFormatting(javaDate, format);
				}
				if (this.emulateCSV)
				{
					return global::NPOI.SS.UserModel.DataFormatter.invalidDateTimeString;
				}
			}
			global::NPOI.SS.Util.FormatBase format2 = this.GetFormat(value, formatIndex, formatString);
			if (format2 == null)
			{
				return value.ToString(this.currentCulture);
			}
			string text = global::NPOI.SS.Util.NumberToTextConverter.ToText(value);
			string text2;
			if (text.IndexOf('E') > -1)
			{
				text2 = format2.Format(value);
			}
			else
			{
				text2 = format2.Format(decimal.Parse(text));
			}
			if (text2.Contains("E") && !text2.Contains("E-"))
			{
				text2 = text2.Replace("E", "E+");
			}
			return text2;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000C0F8 File Offset: 0x0000A2F8
		public string FormatCellValue(global::NPOI.SS.UserModel.ICell cell)
		{
			return this.FormatCellValue(cell, null);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000C104 File Offset: 0x0000A304
		public string FormatCellValue(global::NPOI.SS.UserModel.ICell cell, global::NPOI.SS.UserModel.IFormulaEvaluator evaluator)
		{
			if (cell == null)
			{
				return "";
			}
			global::NPOI.SS.UserModel.CellType cellType = cell.CellType;
			if (evaluator != null && cellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				if (evaluator == null)
				{
					return cell.CellFormula;
				}
				cellType = evaluator.EvaluateFormulaCell(cell);
			}
			switch (cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				if (global::NPOI.SS.UserModel.DateUtil.IsCellDateFormatted(cell))
				{
					return this.GetFormattedDateString(cell);
				}
				return this.GetFormattedNumberString(cell);
			case global::NPOI.SS.UserModel.CellType.String:
				return cell.RichStringCellValue.String;
			case global::NPOI.SS.UserModel.CellType.Formula:
				return cell.CellFormula;
			case global::NPOI.SS.UserModel.CellType.Blank:
				return "";
			case global::NPOI.SS.UserModel.CellType.Boolean:
				if (!cell.BooleanCellValue)
				{
					return "FALSE";
				}
				return "TRUE";
			case global::NPOI.SS.UserModel.CellType.Error:
				return global::NPOI.SS.UserModel.FormulaError.ForInt(cell.ErrorCellValue).String;
			default:
				throw new global::System.Exception("Unexpected celltype (" + cellType.ToString() + ")");
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		public void SetDefaultNumberFormat(global::NPOI.SS.Util.FormatBase format)
		{
			foreach (object obj in this.formats.Keys)
			{
				string key = (string)obj;
				if (this.formats[key] == this.generalNumberFormat)
				{
					this.formats[key] = format;
				}
			}
			this.defaultNumFormat = format;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000C230 File Offset: 0x0000A430
		public void AddFormat(string excelformatStr, global::NPOI.SS.Util.FormatBase format)
		{
			this.formats[excelformatStr] = format;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000C240 File Offset: 0x0000A440
		public void Update(global::System.IObservable<object> observable, object localeObj)
		{
			if (!(localeObj is global::System.Globalization.CultureInfo))
			{
				return;
			}
			global::System.Globalization.CultureInfo cultureInfo = (global::System.Globalization.CultureInfo)localeObj;
			if (cultureInfo.Equals(this.currentCulture))
			{
				return;
			}
			this.currentCulture = cultureInfo;
			this.generalNumberFormat = new global::NPOI.SS.UserModel.ExcelGeneralNumberFormat(this.currentCulture);
			this.formats.Clear();
			global::NPOI.SS.Util.FormatBase instance = global::NPOI.SS.Util.ZipPlusFourFormat.Instance;
			this.AddFormat("00000\\-0000", instance);
			this.AddFormat("00000-0000", instance);
			global::NPOI.SS.Util.FormatBase instance2 = global::NPOI.SS.Util.PhoneFormat.Instance;
			this.AddFormat("[<=9999999]###\\-####;\\(###\\)\\ ###\\-####", instance2);
			this.AddFormat("[<=9999999]###-####;(###) ###-####", instance2);
			this.AddFormat("###\\-####;\\(###\\)\\ ###\\-####", instance2);
			this.AddFormat("###-####;(###) ###-####", instance2);
			global::NPOI.SS.Util.FormatBase instance3 = global::NPOI.SS.Util.SSNFormat.Instance;
			this.AddFormat("000\\-00\\-0000", instance3);
			this.AddFormat("000-00-0000", instance3);
		}

		// Token: 0x0400017D RID: 381
		private static string defaultFractionWholePartFormat = "#";

		// Token: 0x0400017E RID: 382
		private static string defaultFractionFractionPartFormat = "#/##";

		// Token: 0x0400017F RID: 383
		private static string numPattern = "[0#]+";

		// Token: 0x04000180 RID: 384
		private static string amPmPattern = "((A|P)[M/P]*)";

		// Token: 0x04000181 RID: 385
		private static string localePatternGroup = "(\\[\\$[^-\\]]*-[0-9A-Z]+\\])";

		// Token: 0x04000182 RID: 386
		private static global::System.Text.RegularExpressions.Regex colorPattern = new global::System.Text.RegularExpressions.Regex("(\\[BLACK\\])|(\\[BLUE\\])|(\\[CYAN\\])|(\\[GREEN\\])|(\\[MAGENTA\\])|(\\[RED\\])|(\\[WHITE\\])|(\\[YELLOW\\])|(\\[COLOR\\s*\\d\\])|(\\[COLOR\\s*[0-5]\\d\\])", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x04000183 RID: 387
		private static global::System.Text.RegularExpressions.Regex fractionPattern = new global::System.Text.RegularExpressions.Regex("(?:([#\\d]+)\\s+)?(#+)\\s*\\/\\s*([#\\d]+)", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x04000184 RID: 388
		private static global::System.Text.RegularExpressions.Regex fractionStripper = new global::System.Text.RegularExpressions.Regex("(\"[^\"]*\")|([^ \\?#\\d\\/]+)", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x04000185 RID: 389
		private static global::System.Text.RegularExpressions.Regex alternateGrouping = new global::System.Text.RegularExpressions.Regex("([#0]([^.#0])[#0]{3})", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x04000186 RID: 390
		private static string invalidDateTimeString;

		// Token: 0x04000187 RID: 391
		private global::System.Globalization.NumberFormatInfo decimalSymbols;

		// Token: 0x04000188 RID: 392
		private global::System.Globalization.DateTimeFormatInfo dateSymbols;

		// Token: 0x04000189 RID: 393
		private global::NPOI.SS.Util.DateFormat defaultDateformat;

		// Token: 0x0400018A RID: 394
		private global::NPOI.SS.Util.FormatBase generalNumberFormat;

		// Token: 0x0400018B RID: 395
		private global::NPOI.SS.Util.FormatBase defaultNumFormat;

		// Token: 0x0400018C RID: 396
		private global::System.Globalization.CultureInfo currentCulture;

		// Token: 0x0400018D RID: 397
		private global::System.Collections.Hashtable formats;

		// Token: 0x0400018E RID: 398
		private bool emulateCSV;

		// Token: 0x0400018F RID: 399
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.SS.UserModel.DataFormatter));

		// Token: 0x04000190 RID: 400
		private bool localeIsAdapting;

		// Token: 0x04000191 RID: 401
		private static readonly global::System.Text.RegularExpressions.Regex RegexDoubleBackslashAny = new global::System.Text.RegularExpressions.Regex("\\\\.", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x04000192 RID: 402
		private static readonly global::System.Text.RegularExpressions.Regex RegexContinueWs = new global::System.Text.RegularExpressions.Regex("\\s", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x04000193 RID: 403
		private static readonly global::System.Text.RegularExpressions.Regex RegexAnyInDoubleQuote = new global::System.Text.RegularExpressions.Regex("\"[^\"]*\"", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x0200055C RID: 1372
		private class CellFormatResultWrapper : global::NPOI.SS.Util.FormatBase
		{
			// Token: 0x06003396 RID: 13206 RVA: 0x000A1313 File Offset: 0x0009F513
			internal CellFormatResultWrapper(global::NPOI.SS.Format.CellFormatResult result, bool emulateCSV)
			{
				this.emulateCSV = emulateCSV;
				this.result = result;
			}

			// Token: 0x06003397 RID: 13207 RVA: 0x000A1329 File Offset: 0x0009F529
			protected override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, int pos)
			{
				if (this.emulateCSV)
				{
					return toAppendTo.Append(this.result.Text);
				}
				return toAppendTo.Append(this.result.Text.Trim());
			}

			// Token: 0x06003398 RID: 13208 RVA: 0x00008C75 File Offset: 0x00006E75
			public override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, global::System.Globalization.CultureInfo culture)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06003399 RID: 13209 RVA: 0x0002BE0C File Offset: 0x0002A00C
			public override object ParseObject(string source, int pos)
			{
				return null;
			}

			// Token: 0x0400187F RID: 6271
			private global::NPOI.SS.Format.CellFormatResult result;

			// Token: 0x04001880 RID: 6272
			private bool emulateCSV;
		}
	}
}
