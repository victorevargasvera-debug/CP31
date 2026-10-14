using System;
using System.Collections.Generic;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.SS.Util
{
	// Token: 0x0200001A RID: 26
	public class CellUtil
	{
		// Token: 0x06000120 RID: 288 RVA: 0x0000253E File Offset: 0x0000073E
		private CellUtil()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005D5C File Offset: 0x00003F5C
		public static global::NPOI.SS.UserModel.ICell CopyCell(global::NPOI.SS.UserModel.IRow row, int sourceIndex, int targetIndex)
		{
			if (sourceIndex == targetIndex)
			{
				throw new global::System.ArgumentException("sourceIndex and targetIndex cannot be same");
			}
			global::NPOI.SS.UserModel.ICell cell = row.GetCell(sourceIndex);
			if (cell == null)
			{
				return null;
			}
			global::NPOI.SS.UserModel.ICell cell2 = row.GetCell(targetIndex);
			if (cell2 == null)
			{
				cell2 = row.CreateCell(targetIndex);
			}
			if (cell.CellStyle != null)
			{
				cell2.CellStyle = cell.CellStyle;
			}
			if (cell.CellComment != null)
			{
				cell2.CellComment = cell.CellComment;
			}
			if (cell.Hyperlink != null)
			{
				cell2.Hyperlink = cell.Hyperlink;
			}
			cell2.SetCellType(cell.CellType);
			switch (cell.CellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				cell2.SetCellValue(cell.NumericCellValue);
				break;
			case global::NPOI.SS.UserModel.CellType.String:
				cell2.SetCellValue(cell.RichStringCellValue);
				break;
			case global::NPOI.SS.UserModel.CellType.Formula:
				cell2.SetCellFormula(cell.CellFormula);
				break;
			case global::NPOI.SS.UserModel.CellType.Blank:
				cell2.SetCellValue(cell.StringCellValue);
				break;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				cell2.SetCellValue(cell.BooleanCellValue);
				break;
			case global::NPOI.SS.UserModel.CellType.Error:
				cell2.SetCellErrorValue(cell.ErrorCellValue);
				break;
			}
			return cell2;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005E5C File Offset: 0x0000405C
		public static global::NPOI.SS.UserModel.IRow GetRow(int rowIndex, global::NPOI.SS.UserModel.ISheet sheet)
		{
			global::NPOI.SS.UserModel.IRow row = sheet.GetRow(rowIndex);
			if (row == null)
			{
				row = sheet.CreateRow(rowIndex);
			}
			return row;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00005E80 File Offset: 0x00004080
		public static global::NPOI.SS.UserModel.ICell GetCell(global::NPOI.SS.UserModel.IRow row, int columnIndex)
		{
			global::NPOI.SS.UserModel.ICell cell = row.GetCell(columnIndex);
			if (cell == null)
			{
				cell = row.CreateCell(columnIndex);
			}
			return cell;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00005EA4 File Offset: 0x000040A4
		public static global::NPOI.SS.UserModel.ICell CreateCell(global::NPOI.SS.UserModel.IRow row, int column, string value, global::NPOI.SS.UserModel.ICellStyle style)
		{
			global::NPOI.SS.UserModel.ICell cell = global::NPOI.SS.Util.CellUtil.GetCell(row, column);
			cell.SetCellValue(cell.Row.Sheet.Workbook.GetCreationHelper().CreateRichTextString(value));
			if (style != null)
			{
				cell.CellStyle = style;
			}
			return cell;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005EE5 File Offset: 0x000040E5
		public static global::NPOI.SS.UserModel.ICell CreateCell(global::NPOI.SS.UserModel.IRow row, int column, string value)
		{
			return global::NPOI.SS.Util.CellUtil.CreateCell(row, column, value, null);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00005EF0 File Offset: 0x000040F0
		[global::System.Obsolete("deprecated 3.15-beta2. Use {@link #SetAlignment(ICell, HorizontalAlignment)} instead.")]
		public static void SetAlignment(global::NPOI.SS.UserModel.ICell cell, global::NPOI.SS.UserModel.IWorkbook workbook, short align)
		{
			global::NPOI.SS.Util.CellUtil.SetCellStyleProperty(cell, workbook, "alignment", align);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005F04 File Offset: 0x00004104
		public static void SetAlignment(global::NPOI.SS.UserModel.ICell cell, global::NPOI.SS.UserModel.HorizontalAlignment align)
		{
			global::NPOI.SS.Util.CellUtil.SetCellStyleProperty(cell, "alignment", align);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00005F17 File Offset: 0x00004117
		public static void SetVerticalAlignment(global::NPOI.SS.UserModel.ICell cell, global::NPOI.SS.UserModel.VerticalAlignment align)
		{
			global::NPOI.SS.Util.CellUtil.SetCellStyleProperty(cell, "verticalAlignment", align);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00005F2C File Offset: 0x0000412C
		[global::System.Obsolete("deprecated 3.15-beta2. Use {@link #SetFont(ICell, IFont)} instead.")]
		public static void SetFont(global::NPOI.SS.UserModel.ICell cell, global::NPOI.SS.UserModel.IWorkbook workbook, global::NPOI.SS.UserModel.IFont font)
		{
			short index = font.Index;
			if (!workbook.GetFontAt(index).Equals(font))
			{
				throw new global::System.ArgumentException("Font does not belong to this workbook");
			}
			global::NPOI.SS.Util.CellUtil.SetCellStyleProperty(cell, workbook, "font", index);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00005F6C File Offset: 0x0000416C
		public static void SetFont(global::NPOI.SS.UserModel.ICell cell, global::NPOI.SS.UserModel.IFont font)
		{
			global::NPOI.SS.UserModel.IWorkbook workbook = cell.Sheet.Workbook;
			short index = font.Index;
			if (!workbook.GetFontAt(index).Equals(font))
			{
				throw new global::System.ArgumentException("Font does not belong to this workbook");
			}
			global::NPOI.SS.Util.CellUtil.SetCellStyleProperty(cell, "font", index);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00005FB8 File Offset: 0x000041B8
		public static void SetCellStyleProperties(global::NPOI.SS.UserModel.ICell cell, global::System.Collections.Generic.Dictionary<string, object> properties)
		{
			global::NPOI.SS.UserModel.IWorkbook workbook = cell.Sheet.Workbook;
			global::NPOI.SS.UserModel.ICellStyle cellStyle = cell.CellStyle;
			global::NPOI.SS.UserModel.ICellStyle cellStyle2 = null;
			global::System.Collections.Generic.Dictionary<string, object> formatProperties = global::NPOI.SS.Util.CellUtil.GetFormatProperties(cellStyle);
			global::NPOI.SS.Util.CellUtil.PutAll(properties, formatProperties);
			int numCellStyles = workbook.NumCellStyles;
			for (int i = 0; i < numCellStyles; i++)
			{
				global::NPOI.SS.UserModel.ICellStyle cellStyleAt = workbook.GetCellStyleAt(i);
				if (global::NPOI.SS.Util.CellUtil.DictionaryEqual<string, object>(global::NPOI.SS.Util.CellUtil.GetFormatProperties(cellStyleAt), formatProperties, null))
				{
					cellStyle2 = cellStyleAt;
					break;
				}
			}
			if (cellStyle2 == null)
			{
				cellStyle2 = workbook.CreateCellStyle();
				cellStyle2.CloneStyleFrom(cellStyle);
				global::NPOI.SS.Util.CellUtil.SetFormatProperties(cellStyle2, workbook, formatProperties);
			}
			cell.CellStyle = cellStyle2;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00006040 File Offset: 0x00004240
		public static bool DictionaryEqual<TKey, TValue>(global::System.Collections.Generic.IDictionary<TKey, TValue> first, global::System.Collections.Generic.IDictionary<TKey, TValue> second, global::System.Collections.Generic.IEqualityComparer<TValue> valueComparer)
		{
			if (first == second)
			{
				return true;
			}
			if (first == null || second == null)
			{
				return false;
			}
			if (first.Count != second.Count)
			{
				return false;
			}
			valueComparer = (valueComparer ?? global::System.Collections.Generic.EqualityComparer<TValue>.Default);
			foreach (global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair in first)
			{
				TValue y;
				if (!second.TryGetValue(keyValuePair.Key, out y))
				{
					return false;
				}
				if (!valueComparer.Equals(keyValuePair.Value, y))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000060D8 File Offset: 0x000042D8
		public static void SetCellStyleProperty(global::NPOI.SS.UserModel.ICell cell, string propertyName, object propertyValue)
		{
			global::System.Collections.Generic.Dictionary<string, object> properties = new global::System.Collections.Generic.Dictionary<string, object>
			{
				{
					propertyName,
					propertyValue
				}
			};
			global::NPOI.SS.Util.CellUtil.SetCellStyleProperties(cell, properties);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000060FC File Offset: 0x000042FC
		[global::System.Obsolete("deprecated 3.15-beta2. Use {@link #setCellStyleProperty(Cell, String, Object)} instead.")]
		public static void SetCellStyleProperty(global::NPOI.SS.UserModel.ICell cell, global::NPOI.SS.UserModel.IWorkbook workbook, string propertyName, object propertyValue)
		{
			if (cell.Sheet.Workbook != workbook)
			{
				throw new global::System.ArgumentException("Cannot set cell style property. Cell does not belong to workbook.");
			}
			global::System.Collections.Generic.Dictionary<string, object> properties = new global::System.Collections.Generic.Dictionary<string, object>
			{
				{
					propertyName,
					propertyValue
				}
			};
			global::NPOI.SS.Util.CellUtil.SetCellStyleProperties(cell, properties);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006138 File Offset: 0x00004338
		private static void PutAll(global::System.Collections.Generic.Dictionary<string, object> src, global::System.Collections.Generic.Dictionary<string, object> dest)
		{
			foreach (string text in src.Keys)
			{
				if (global::NPOI.SS.Util.CellUtil.shortValues.Contains(text))
				{
					dest[text] = global::NPOI.SS.Util.CellUtil.GetShort(src, text);
				}
				else if (global::NPOI.SS.Util.CellUtil.intValues.Contains(text))
				{
					dest[text] = global::NPOI.SS.Util.CellUtil.GetInt(src, text);
				}
				else if (global::NPOI.SS.Util.CellUtil.booleanValues.Contains(text))
				{
					dest[text] = global::NPOI.SS.Util.CellUtil.GetBoolean(src, text);
				}
				else if (global::NPOI.SS.Util.CellUtil.borderTypeValues.Contains(text))
				{
					dest[text] = global::NPOI.SS.Util.CellUtil.GetBorderStyle(src, text);
				}
				else if ("alignment".Equals(text))
				{
					dest[text] = global::NPOI.SS.Util.CellUtil.GetHorizontalAlignment(src, text);
				}
				else if ("verticalAlignment".Equals(text))
				{
					dest[text] = global::NPOI.SS.Util.CellUtil.GetVerticalAlignment(src, text);
				}
				else if ("fillPattern".Equals(text))
				{
					dest[text] = global::NPOI.SS.Util.CellUtil.GetFillPattern(src, text);
				}
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000628C File Offset: 0x0000448C
		private static global::System.Collections.Generic.Dictionary<string, object> GetFormatProperties(global::NPOI.SS.UserModel.ICellStyle style)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "alignment", style.Alignment);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "verticalAlignment", style.VerticalAlignment);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "borderBottom", style.BorderBottom);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "borderLeft", style.BorderLeft);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "borderRight", style.BorderRight);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "borderTop", style.BorderTop);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "bottomBorderColor", style.BottomBorderColor);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "dataFormat", style.DataFormat);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "fillPattern", style.FillPattern);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "fillForegroundColor", style.FillForegroundColor);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "fillBackgroundColor", style.FillBackgroundColor);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "font", (int)style.FontIndex);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "hidden", style.IsHidden);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "indention", style.Indention);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "leftBorderColor", style.LeftBorderColor);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "locked", style.IsLocked);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "rightBorderColor", style.RightBorderColor);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "rotation", style.Rotation);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "topBorderColor", style.TopBorderColor);
			global::NPOI.SS.Util.CellUtil.Put(dictionary, "wrapText", style.WrapText);
			return dictionary;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00006458 File Offset: 0x00004658
		private static void SetFormatProperties(global::NPOI.SS.UserModel.ICellStyle style, global::NPOI.SS.UserModel.IWorkbook workbook, global::System.Collections.Generic.Dictionary<string, object> properties)
		{
			style.Alignment = global::NPOI.SS.Util.CellUtil.GetHorizontalAlignment(properties, "alignment");
			style.VerticalAlignment = global::NPOI.SS.Util.CellUtil.GetVerticalAlignment(properties, "verticalAlignment");
			style.BorderBottom = global::NPOI.SS.Util.CellUtil.GetBorderStyle(properties, "borderBottom");
			style.BorderLeft = global::NPOI.SS.Util.CellUtil.GetBorderStyle(properties, "borderLeft");
			style.BorderRight = global::NPOI.SS.Util.CellUtil.GetBorderStyle(properties, "borderRight");
			style.BorderTop = global::NPOI.SS.Util.CellUtil.GetBorderStyle(properties, "borderTop");
			style.BottomBorderColor = global::NPOI.SS.Util.CellUtil.GetShort(properties, "bottomBorderColor");
			style.DataFormat = global::NPOI.SS.Util.CellUtil.GetShort(properties, "dataFormat");
			style.FillPattern = global::NPOI.SS.Util.CellUtil.GetFillPattern(properties, "fillPattern");
			style.FillForegroundColor = global::NPOI.SS.Util.CellUtil.GetShort(properties, "fillForegroundColor");
			style.FillBackgroundColor = global::NPOI.SS.Util.CellUtil.GetShort(properties, "fillBackgroundColor");
			style.SetFont(workbook.GetFontAt(global::NPOI.SS.Util.CellUtil.GetShort(properties, "font")));
			style.IsHidden = global::NPOI.SS.Util.CellUtil.GetBoolean(properties, "hidden");
			style.Indention = global::NPOI.SS.Util.CellUtil.GetShort(properties, "indention");
			style.LeftBorderColor = global::NPOI.SS.Util.CellUtil.GetShort(properties, "leftBorderColor");
			style.IsLocked = global::NPOI.SS.Util.CellUtil.GetBoolean(properties, "locked");
			style.RightBorderColor = global::NPOI.SS.Util.CellUtil.GetShort(properties, "rightBorderColor");
			style.Rotation = global::NPOI.SS.Util.CellUtil.GetShort(properties, "rotation");
			style.TopBorderColor = global::NPOI.SS.Util.CellUtil.GetShort(properties, "topBorderColor");
			style.WrapText = global::NPOI.SS.Util.CellUtil.GetBoolean(properties, "wrapText");
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000065C0 File Offset: 0x000047C0
		private static short GetShort(global::System.Collections.Generic.Dictionary<string, object> properties, string name)
		{
			object obj = properties[name];
			short result = 0;
			if (short.TryParse(obj.ToString(), out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000065E8 File Offset: 0x000047E8
		private static int GetInt(global::System.Collections.Generic.Dictionary<string, object> properties, string name)
		{
			object obj = properties[name];
			if (global::NPOI.Util.Number.IsNumber(obj))
			{
				return int.Parse(obj.ToString());
			}
			return 0;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006614 File Offset: 0x00004814
		private static global::NPOI.SS.UserModel.BorderStyle GetBorderStyle(global::System.Collections.Generic.Dictionary<string, object> properties, string name)
		{
			object obj = properties[name];
			global::NPOI.SS.UserModel.BorderStyle result;
			if (obj is global::NPOI.SS.UserModel.BorderStyle)
			{
				result = (global::NPOI.SS.UserModel.BorderStyle)obj;
			}
			else if (obj is short || obj is int)
			{
				result = (global::NPOI.SS.UserModel.BorderStyle)short.Parse(obj.ToString());
			}
			else
			{
				if (obj != null)
				{
					throw new global::NPOI.Util.RuntimeException("Unexpected border style class. Must be BorderStyle or Short (deprecated).");
				}
				result = global::NPOI.SS.UserModel.BorderStyle.None;
			}
			return result;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000666C File Offset: 0x0000486C
		private static global::NPOI.SS.UserModel.FillPattern GetFillPattern(global::System.Collections.Generic.Dictionary<string, object> properties, string name)
		{
			object obj = properties[name];
			global::NPOI.SS.UserModel.FillPattern result;
			if (obj is global::NPOI.SS.UserModel.FillPattern)
			{
				result = (global::NPOI.SS.UserModel.FillPattern)obj;
			}
			else if (obj is short)
			{
				result = (global::NPOI.SS.UserModel.FillPattern)((short)obj);
			}
			else
			{
				if (obj != null)
				{
					throw new global::NPOI.Util.RuntimeException("Unexpected fill pattern style class. Must be FillPattern or Short (deprecated).");
				}
				result = global::NPOI.SS.UserModel.FillPattern.NoFill;
			}
			return result;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000066B8 File Offset: 0x000048B8
		private static global::NPOI.SS.UserModel.HorizontalAlignment GetHorizontalAlignment(global::System.Collections.Generic.Dictionary<string, object> properties, string name)
		{
			object obj = properties[name];
			global::NPOI.SS.UserModel.HorizontalAlignment result;
			if (obj is global::NPOI.SS.UserModel.HorizontalAlignment)
			{
				result = (global::NPOI.SS.UserModel.HorizontalAlignment)obj;
			}
			else if (obj is short)
			{
				result = (global::NPOI.SS.UserModel.HorizontalAlignment)((short)obj);
			}
			else
			{
				if (obj != null)
				{
					throw new global::NPOI.Util.RuntimeException("Unexpected horizontal alignment style class. Must be HorizontalAlignment or Short (deprecated).");
				}
				result = global::NPOI.SS.UserModel.HorizontalAlignment.General;
			}
			return result;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006704 File Offset: 0x00004904
		private static global::NPOI.SS.UserModel.VerticalAlignment GetVerticalAlignment(global::System.Collections.Generic.Dictionary<string, object> properties, string name)
		{
			object obj = properties[name];
			global::NPOI.SS.UserModel.VerticalAlignment result;
			if (obj is global::NPOI.SS.UserModel.VerticalAlignment)
			{
				result = (global::NPOI.SS.UserModel.VerticalAlignment)obj;
			}
			else if (obj is short)
			{
				result = (global::NPOI.SS.UserModel.VerticalAlignment)((short)obj);
			}
			else
			{
				if (obj != null)
				{
					throw new global::NPOI.Util.RuntimeException("Unexpected vertical alignment style class. Must be VerticalAlignment or Short (deprecated).");
				}
				result = global::NPOI.SS.UserModel.VerticalAlignment.Bottom;
			}
			return result;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006750 File Offset: 0x00004950
		private static bool GetBoolean(global::System.Collections.Generic.Dictionary<string, object> properties, string name)
		{
			object obj = properties[name];
			bool flag = false;
			return bool.TryParse(obj.ToString(), out flag) && flag;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006777 File Offset: 0x00004977
		private static void Put(global::System.Collections.Generic.Dictionary<string, object> properties, string name, object value)
		{
			properties[name] = value;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00006781 File Offset: 0x00004981
		private static void PutShort(global::System.Collections.Generic.Dictionary<string, object> properties, string name, short value)
		{
			properties[name] = value;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00006777 File Offset: 0x00004977
		private static void PutEnum(global::System.Collections.Generic.Dictionary<string, object> properties, string name, global::System.Enum value)
		{
			properties[name] = value;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00006790 File Offset: 0x00004990
		private static void PutBoolean(global::System.Collections.Generic.Dictionary<string, object> properties, string name, bool value)
		{
			properties[name] = value;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000067A0 File Offset: 0x000049A0
		public static global::NPOI.SS.UserModel.ICell TranslateUnicodeValues(global::NPOI.SS.UserModel.ICell cell)
		{
			string text = cell.RichStringCellValue.String;
			bool flag = false;
			string text2 = text.ToLower();
			foreach (global::NPOI.SS.Util.CellUtil.UnicodeMapping unicodeMapping in global::NPOI.SS.Util.CellUtil.unicodeMappings)
			{
				string entityName = unicodeMapping.entityName;
				if (text2.Contains(entityName))
				{
					text = text.Replace(entityName, unicodeMapping.resolvedValue);
					flag = true;
				}
			}
			if (flag)
			{
				cell.SetCellValue(cell.Row.Sheet.Workbook.GetCreationHelper().CreateRichTextString(text));
			}
			return cell;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006A22 File Offset: 0x00004C22
		private static global::NPOI.SS.Util.CellUtil.UnicodeMapping um(string entityName, string resolvedValue)
		{
			return new global::NPOI.SS.Util.CellUtil.UnicodeMapping(entityName, resolvedValue);
		}

		// Token: 0x0400004C RID: 76
		public const string ALIGNMENT = "alignment";

		// Token: 0x0400004D RID: 77
		public const string BORDER_BOTTOM = "borderBottom";

		// Token: 0x0400004E RID: 78
		public const string BORDER_DIAGONAL = "borderDiagonal";

		// Token: 0x0400004F RID: 79
		public const string BORDER_LEFT = "borderLeft";

		// Token: 0x04000050 RID: 80
		public const string BORDER_RIGHT = "borderRight";

		// Token: 0x04000051 RID: 81
		public const string BORDER_TOP = "borderTop";

		// Token: 0x04000052 RID: 82
		public const string BOTTOM_BORDER_COLOR = "bottomBorderColor";

		// Token: 0x04000053 RID: 83
		public const string DATA_FORMAT = "dataFormat";

		// Token: 0x04000054 RID: 84
		public const string FILL_BACKGROUND_COLOR = "fillBackgroundColor";

		// Token: 0x04000055 RID: 85
		public const string FILL_FOREGROUND_COLOR = "fillForegroundColor";

		// Token: 0x04000056 RID: 86
		public const string FILL_PATTERN = "fillPattern";

		// Token: 0x04000057 RID: 87
		public const string FONT = "font";

		// Token: 0x04000058 RID: 88
		public const string HIDDEN = "hidden";

		// Token: 0x04000059 RID: 89
		public const string INDENTION = "indention";

		// Token: 0x0400005A RID: 90
		public const string LEFT_BORDER_COLOR = "leftBorderColor";

		// Token: 0x0400005B RID: 91
		public const string LOCKED = "locked";

		// Token: 0x0400005C RID: 92
		public const string RIGHT_BORDER_COLOR = "rightBorderColor";

		// Token: 0x0400005D RID: 93
		public const string ROTATION = "rotation";

		// Token: 0x0400005E RID: 94
		public const string SHRINK_TO_FIT = "shrinkToFit";

		// Token: 0x0400005F RID: 95
		public const string TOP_BORDER_COLOR = "topBorderColor";

		// Token: 0x04000060 RID: 96
		public const string VERTICAL_ALIGNMENT = "verticalAlignment";

		// Token: 0x04000061 RID: 97
		public const string WRAP_TEXT = "wrapText";

		// Token: 0x04000062 RID: 98
		private static global::System.Collections.Generic.ISet<string> shortValues = new global::System.Collections.Generic.HashSet<string>(new string[]
		{
			"bottomBorderColor",
			"leftBorderColor",
			"rightBorderColor",
			"topBorderColor",
			"fillForegroundColor",
			"fillBackgroundColor",
			"indention",
			"dataFormat",
			"rotation"
		});

		// Token: 0x04000063 RID: 99
		private static global::System.Collections.Generic.ISet<string> intValues = new global::System.Collections.Generic.HashSet<string>(new string[]
		{
			"font"
		});

		// Token: 0x04000064 RID: 100
		private static global::System.Collections.Generic.ISet<string> booleanValues = new global::System.Collections.Generic.HashSet<string>(new string[]
		{
			"locked",
			"hidden",
			"wrapText"
		});

		// Token: 0x04000065 RID: 101
		private static global::System.Collections.Generic.ISet<string> borderTypeValues = new global::System.Collections.Generic.HashSet<string>(new string[]
		{
			"borderBottom",
			"borderLeft",
			"borderRight",
			"borderTop"
		});

		// Token: 0x04000066 RID: 102
		private static global::NPOI.SS.Util.CellUtil.UnicodeMapping[] unicodeMappings = new global::NPOI.SS.Util.CellUtil.UnicodeMapping[]
		{
			global::NPOI.SS.Util.CellUtil.um("alpha", "α"),
			global::NPOI.SS.Util.CellUtil.um("beta", "β"),
			global::NPOI.SS.Util.CellUtil.um("gamma", "γ"),
			global::NPOI.SS.Util.CellUtil.um("delta", "δ"),
			global::NPOI.SS.Util.CellUtil.um("epsilon", "ε"),
			global::NPOI.SS.Util.CellUtil.um("zeta", "ζ"),
			global::NPOI.SS.Util.CellUtil.um("eta", "η"),
			global::NPOI.SS.Util.CellUtil.um("theta", "θ"),
			global::NPOI.SS.Util.CellUtil.um("iota", "ι"),
			global::NPOI.SS.Util.CellUtil.um("kappa", "κ"),
			global::NPOI.SS.Util.CellUtil.um("lambda", "λ"),
			global::NPOI.SS.Util.CellUtil.um("mu", "μ"),
			global::NPOI.SS.Util.CellUtil.um("nu", "ν"),
			global::NPOI.SS.Util.CellUtil.um("xi", "ξ"),
			global::NPOI.SS.Util.CellUtil.um("omicron", "ο")
		};

		// Token: 0x02000553 RID: 1363
		private class UnicodeMapping
		{
			// Token: 0x06003369 RID: 13161 RVA: 0x000A0FF1 File Offset: 0x0009F1F1
			public UnicodeMapping(string pEntityName, string pResolvedValue)
			{
				this.entityName = "&" + pEntityName + ";";
				this.resolvedValue = pResolvedValue;
			}

			// Token: 0x04001866 RID: 6246
			public string entityName;

			// Token: 0x04001867 RID: 6247
			public string resolvedValue;
		}
	}
}
