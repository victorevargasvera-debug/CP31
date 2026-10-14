using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.XSSF.UserModel.Extensions;

namespace NPOI.XSSF.Model
{
	// Token: 0x020000E8 RID: 232
	public class StylesTable : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x000311F4 File Offset: 0x0002F3F4
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x000311FC File Offset: 0x0002F3FC
		public int MaxNumberOfDataFormats
		{
			get
			{
				return this.MAXIMUM_NUMBER_OF_DATA_FORMATS;
			}
			set
			{
				if (value >= this.NumDataFormats)
				{
					this.MAXIMUM_NUMBER_OF_DATA_FORMATS = value;
					return;
				}
				if (value < 0)
				{
					throw new global::System.ArgumentException("Maximum Number of Data Formats must be greater than or equal to 0");
				}
				throw new global::System.InvalidOperationException("Cannot set the maximum number of data formats less than the current quantity.Data formats must be explicitly removed (via StylesTable.removeNumberFormat) before the limit can be decreased.");
			}
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00031228 File Offset: 0x0002F428
		public StylesTable()
		{
			this.doc = new global::NPOI.OpenXmlFormats.Spreadsheet.StyleSheetDocument();
			this.doc.AddNewStyleSheet();
			this.Initialize();
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x000312C4 File Offset: 0x0002F4C4
		internal StylesTable(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			global::System.Xml.XmlDocument xmldoc = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(part.GetInputStream());
			this.ReadFrom(xmldoc);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00031358 File Offset: 0x0002F558
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public StylesTable(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00031361 File Offset: 0x0002F561
		public void SetWorkbook(global::NPOI.XSSF.UserModel.XSSFWorkbook wb)
		{
			this.workbook = wb;
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0003136A File Offset: 0x0002F56A
		public global::NPOI.XSSF.Model.ThemesTable GetTheme()
		{
			return this.theme;
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00031374 File Offset: 0x0002F574
		public void SetTheme(global::NPOI.XSSF.Model.ThemesTable theme)
		{
			this.theme = theme;
			foreach (global::NPOI.XSSF.UserModel.XSSFFont xssffont in this.fonts)
			{
				xssffont.SetThemesTable(theme);
			}
			foreach (global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder xssfcellBorder in this.borders)
			{
				xssfcellBorder.SetThemesTable(theme);
			}
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0003140C File Offset: 0x0002F60C
		public void EnsureThemesTable()
		{
			if (this.theme != null)
			{
				return;
			}
			this.theme = (global::NPOI.XSSF.Model.ThemesTable)this.workbook.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.THEME, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance());
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00031438 File Offset: 0x0002F638
		protected void ReadFrom(global::System.Xml.XmlDocument xmldoc)
		{
			try
			{
				this.doc = global::NPOI.OpenXmlFormats.Spreadsheet.StyleSheetDocument.Parse(xmldoc, global::NPOI.POIXMLDocumentPart.NamespaceManager);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Stylesheet styleSheet = this.doc.GetStyleSheet();
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmts numFmts = styleSheet.numFmts;
				if (numFmts != null)
				{
					foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt ct_NumFmt in numFmts.numFmt)
					{
						short key = (short)ct_NumFmt.numFmtId;
						this.numberFormats.Add(key, ct_NumFmt.formatCode);
					}
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fonts ct_Fonts = styleSheet.fonts;
				if (ct_Fonts != null)
				{
					int num = 0;
					foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font font in ct_Fonts.font)
					{
						global::NPOI.XSSF.UserModel.XSSFFont item = new global::NPOI.XSSF.UserModel.XSSFFont(font, num);
						this.fonts.Add(item);
						num++;
					}
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fills ct_Fills = styleSheet.fills;
				if (ct_Fills != null)
				{
					foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill fill in ct_Fills.fill)
					{
						this.fills.Add(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill(fill));
					}
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Borders ct_Borders = styleSheet.borders;
				if (ct_Borders != null)
				{
					foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border border in ct_Borders.border)
					{
						this.borders.Add(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(border));
					}
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellXfs cellXfs = styleSheet.cellXfs;
				if (cellXfs != null)
				{
					this.xfs.AddRange(cellXfs.xf);
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyleXfs cellStyleXfs = styleSheet.cellStyleXfs;
				if (cellStyleXfs != null)
				{
					this.styleXfs.AddRange(cellStyleXfs.xf);
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxfs ct_Dxfs = styleSheet.dxfs;
				if (ct_Dxfs != null)
				{
					this.dxfs.AddRange(ct_Dxfs.dxf);
				}
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00031694 File Offset: 0x0002F894
		[global::System.Obsolete("deprecated POI 3.14-beta2. Use {@link #getNumberFormatAt(short)} instead.")]
		public string GetNumberFormatAt(int idx)
		{
			return this.GetNumberFormatAt((short)idx);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0003169E File Offset: 0x0002F89E
		public string GetNumberFormatAt(short fmtId)
		{
			if (this.numberFormats.ContainsKey(fmtId))
			{
				return this.numberFormats[fmtId];
			}
			return null;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000316BC File Offset: 0x0002F8BC
		private short GetNumberFormatId(string fmt)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<short, string> keyValuePair in this.numberFormats)
			{
				if (keyValuePair.Value.Equals(fmt))
				{
					return keyValuePair.Key;
				}
			}
			throw new global::System.InvalidOperationException("Number format not in style table: " + fmt);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00031734 File Offset: 0x0002F934
		public int PutNumberFormat(string fmt)
		{
			if (this.numberFormats.ContainsValue(fmt))
			{
				try
				{
					return (int)this.GetNumberFormatId(fmt);
				}
				catch (global::System.InvalidOperationException)
				{
					throw new global::System.InvalidOperationException("Found the format, but couldn't figure out where - should never happen!");
				}
			}
			if (this.numberFormats.Count >= this.MAXIMUM_NUMBER_OF_DATA_FORMATS)
			{
				throw new global::System.InvalidOperationException("The maximum number of Data Formats was exceeded. You can define up to " + this.MAXIMUM_NUMBER_OF_DATA_FORMATS.ToString() + " formats in a .xlsx Workbook.");
			}
			short num;
			if (this.numberFormats.Count == 0)
			{
				num = global::NPOI.XSSF.Model.StylesTable.FIRST_USER_DEFINED_NUMBER_FORMAT_ID;
			}
			else
			{
				short num2 = this.numberFormats.Last<global::System.Collections.Generic.KeyValuePair<short, string>>().Key + 1;
				if (num2 < 0)
				{
					throw new global::System.InvalidOperationException("Cowardly avoiding creating a number format with a negative id.This is probably due to arithmetic overflow.");
				}
				num = global::System.Math.Max(num2, global::NPOI.XSSF.Model.StylesTable.FIRST_USER_DEFINED_NUMBER_FORMAT_ID);
			}
			if (this.numberFormats.ContainsKey(num))
			{
				this.numberFormats[num] = fmt;
			}
			else
			{
				this.numberFormats.Add(num, fmt);
			}
			return (int)num;
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00031820 File Offset: 0x0002FA20
		public void PutNumberFormat(short index, string fmt)
		{
			if (this.numberFormats.ContainsKey(index))
			{
				this.numberFormats[index] = fmt;
				return;
			}
			this.numberFormats.Add(index, fmt);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0003184C File Offset: 0x0002FA4C
		public bool RemoveNumberFormat(short index)
		{
			string text = this.numberFormats[index];
			bool flag = this.numberFormats.Remove(index);
			if (flag)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf ct_Xf in this.xfs)
				{
					if (ct_Xf.numFmtIdSpecified && (ulong)ct_Xf.numFmtId == (ulong)((long)index))
					{
						ct_Xf.applyNumberFormat = false;
						ct_Xf.numFmtId = 0U;
						ct_Xf.numFmtIdSpecified = false;
					}
				}
			}
			return flag;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x000318E0 File Offset: 0x0002FAE0
		public bool RemoveNumberFormat(string fmt)
		{
			short numberFormatId = this.GetNumberFormatId(fmt);
			return this.RemoveNumberFormat(numberFormatId);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x000318FC File Offset: 0x0002FAFC
		public global::NPOI.XSSF.UserModel.XSSFFont GetFontAt(int idx)
		{
			return this.fonts[idx];
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0003190C File Offset: 0x0002FB0C
		public int PutFont(global::NPOI.XSSF.UserModel.XSSFFont font, bool forceRegistration)
		{
			int num = -1;
			if (!forceRegistration)
			{
				num = this.fonts.IndexOf(font);
			}
			if (num != -1)
			{
				return num;
			}
			num = this.fonts.Count;
			this.fonts.Add(font);
			return num;
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0003194A File Offset: 0x0002FB4A
		public int PutFont(global::NPOI.XSSF.UserModel.XSSFFont font)
		{
			return this.PutFont(font, false);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00031954 File Offset: 0x0002FB54
		public global::NPOI.XSSF.UserModel.XSSFCellStyle GetStyleAt(int idx)
		{
			int cellStyleXfId = 0;
			if (this.xfs.Count == 0)
			{
				return null;
			}
			if (this.xfs[idx].xfId > 0U)
			{
				cellStyleXfId = (int)this.xfs[idx].xfId;
			}
			return new global::NPOI.XSSF.UserModel.XSSFCellStyle(idx, cellStyleXfId, this, this.theme);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000319A8 File Offset: 0x0002FBA8
		public int PutStyle(global::NPOI.XSSF.UserModel.XSSFCellStyle style)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf coreXf = style.GetCoreXf();
			if (!this.xfs.Contains(coreXf))
			{
				this.xfs.Add(coreXf);
			}
			return this.xfs.IndexOf(coreXf);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000319E2 File Offset: 0x0002FBE2
		public global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder GetBorderAt(int idx)
		{
			return this.borders[idx];
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x000319F0 File Offset: 0x0002FBF0
		public int PutBorder(global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder border)
		{
			int num = this.borders.IndexOf(border);
			if (num != -1)
			{
				return num;
			}
			this.borders.Add(border);
			border.SetThemesTable(this.theme);
			return this.borders.Count - 1;
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00031A35 File Offset: 0x0002FC35
		public global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill GetFillAt(int idx)
		{
			return this.fills[idx];
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00031A43 File Offset: 0x0002FC43
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder> GetBorders()
		{
			return this.borders.AsReadOnly();
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00031A50 File Offset: 0x0002FC50
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill> GetFills()
		{
			return this.fills.AsReadOnly();
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00031A5D File Offset: 0x0002FC5D
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::NPOI.XSSF.UserModel.XSSFFont> GetFonts()
		{
			return this.fonts.AsReadOnly();
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00031A6A File Offset: 0x0002FC6A
		public global::System.Collections.Generic.IDictionary<short, string> GetNumberFormats()
		{
			return this.numberFormats;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00031A74 File Offset: 0x0002FC74
		public int PutFill(global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill fill)
		{
			int num = this.fills.IndexOf(fill);
			if (num != -1)
			{
				return num;
			}
			this.fills.Add(fill);
			return this.fills.Count - 1;
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00031AAD File Offset: 0x0002FCAD
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf GetCellXfAt(int idx)
		{
			return this.xfs[idx];
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00031ABB File Offset: 0x0002FCBB
		internal int PutCellXf(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf cellXf)
		{
			this.xfs.Add(cellXf);
			return this.xfs.Count;
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00031AD4 File Offset: 0x0002FCD4
		internal void ReplaceCellXfAt(int idx, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf cellXf)
		{
			this.xfs[idx] = cellXf;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00031AE3 File Offset: 0x0002FCE3
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf GetCellStyleXfAt(int idx)
		{
			if (idx < 0 || idx > this.styleXfs.Count)
			{
				return null;
			}
			return this.styleXfs[idx];
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00031B05 File Offset: 0x0002FD05
		internal int PutCellStyleXf(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf cellStyleXf)
		{
			this.styleXfs.Add(cellStyleXf);
			return this.styleXfs.Count;
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00031B1E File Offset: 0x0002FD1E
		internal void ReplaceCellStyleXfAt(int idx, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf cellStyleXf)
		{
			this.styleXfs[idx] = cellStyleXf;
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00031B2D File Offset: 0x0002FD2D
		public int NumCellStyles
		{
			get
			{
				return this.xfs.Count;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00031B3A File Offset: 0x0002FD3A
		public int NumDataFormats
		{
			get
			{
				return this.numberFormats.Count;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00031B3A File Offset: 0x0002FD3A
		[global::System.Obsolete("deprecated POI 3.14 beta 2. Use {@link #getNumDataFormats()} instead.")]
		internal int NumberFormatSize
		{
			get
			{
				return this.numberFormats.Count;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00031B2D File Offset: 0x0002FD2D
		internal int XfsSize
		{
			get
			{
				return this.xfs.Count;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00031B47 File Offset: 0x0002FD47
		internal int StyleXfsSize
		{
			get
			{
				return this.styleXfs.Count;
			}
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00031B54 File Offset: 0x0002FD54
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_Stylesheet GetCTStylesheet()
		{
			return this.doc.GetStyleSheet();
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x00031B61 File Offset: 0x0002FD61
		internal int DXfsSize
		{
			get
			{
				return this.dxfs.Count;
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00031B70 File Offset: 0x0002FD70
		public void WriteTo(global::System.IO.Stream out1)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Stylesheet styleSheet = this.doc.GetStyleSheet();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmts ct_NumFmts = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmts();
			ct_NumFmts.count = (uint)this.numberFormats.Count;
			foreach (global::System.Collections.Generic.KeyValuePair<short, string> keyValuePair in this.numberFormats)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt ct_NumFmt = ct_NumFmts.AddNewNumFmt();
				ct_NumFmt.numFmtId = (uint)keyValuePair.Key;
				ct_NumFmt.formatCode = keyValuePair.Value;
			}
			styleSheet.numFmts = ct_NumFmts;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fonts ct_Fonts = styleSheet.fonts;
			if (ct_Fonts == null)
			{
				ct_Fonts = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fonts();
			}
			ct_Fonts.count = (uint)this.fonts.Count;
			if (ct_Fonts.count > 0U)
			{
				ct_Fonts.countSpecified = true;
			}
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font> list = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font>(this.fonts.Count);
			foreach (global::NPOI.XSSF.UserModel.XSSFFont xssffont in this.fonts)
			{
				list.Add(xssffont.GetCTFont());
			}
			ct_Fonts.SetFontArray(list);
			styleSheet.fonts = ct_Fonts;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fills ct_Fills = styleSheet.fills;
			if (ct_Fills == null)
			{
				ct_Fills = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fills();
			}
			ct_Fills.count = (uint)this.fills.Count;
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill> list2 = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill>(this.fills.Count);
			foreach (global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill xssfcellFill in this.fills)
			{
				list2.Add(xssfcellFill.GetCTFill());
			}
			ct_Fills.SetFillArray(list2);
			if (ct_Fills.count > 0U)
			{
				ct_Fills.countSpecified = true;
			}
			styleSheet.fills = ct_Fills;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Borders ct_Borders = styleSheet.borders;
			if (ct_Borders == null)
			{
				ct_Borders = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Borders();
			}
			ct_Borders.count = (uint)this.borders.Count;
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border> list3 = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border>(this.borders.Count);
			foreach (global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder xssfcellBorder in this.borders)
			{
				list3.Add(xssfcellBorder.GetCTBorder());
			}
			ct_Borders.SetBorderArray(list3);
			styleSheet.borders = ct_Borders;
			if (this.xfs.Count > 0)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellXfs ct_CellXfs = styleSheet.cellXfs;
				if (ct_CellXfs == null)
				{
					ct_CellXfs = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellXfs();
				}
				ct_CellXfs.count = (uint)this.xfs.Count;
				if (ct_CellXfs.count > 0U)
				{
					ct_CellXfs.countSpecified = true;
				}
				ct_CellXfs.xf = this.xfs;
				styleSheet.cellXfs = ct_CellXfs;
			}
			if (this.styleXfs.Count > 0)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyleXfs ct_CellStyleXfs = styleSheet.cellStyleXfs;
				if (ct_CellStyleXfs == null)
				{
					ct_CellStyleXfs = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyleXfs();
				}
				ct_CellStyleXfs.count = (uint)this.styleXfs.Count;
				if (ct_CellStyleXfs.count > 0U)
				{
					ct_CellStyleXfs.countSpecified = true;
				}
				ct_CellStyleXfs.xf = this.styleXfs;
				styleSheet.cellStyleXfs = ct_CellStyleXfs;
			}
			if (this.dxfs.Count > 0)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxfs ct_Dxfs = styleSheet.dxfs;
				if (ct_Dxfs == null)
				{
					ct_Dxfs = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxfs();
				}
				ct_Dxfs.count = (uint)this.dxfs.Count;
				if (ct_Dxfs.count > 0U)
				{
					ct_Dxfs.countSpecified = true;
				}
				ct_Dxfs.dxf = this.dxfs;
				styleSheet.dxfs = ct_Dxfs;
			}
			this.doc.Save(out1);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00031EF4 File Offset: 0x000300F4
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.WriteTo(outputStream);
			outputStream.Close();
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00031F1C File Offset: 0x0003011C
		private void Initialize()
		{
			global::NPOI.XSSF.UserModel.XSSFFont item = global::NPOI.XSSF.Model.StylesTable.CreateDefaultFont();
			this.fonts.Add(item);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill[] array = global::NPOI.XSSF.Model.StylesTable.CreateDefaultFills();
			this.fills.Add(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill(array[0]));
			this.fills.Add(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill(array[1]));
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border border = global::NPOI.XSSF.Model.StylesTable.CreateDefaultBorder();
			this.borders.Add(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(border));
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf item2 = global::NPOI.XSSF.Model.StylesTable.CreateDefaultXf();
			this.styleXfs.Add(item2);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf ct_Xf = global::NPOI.XSSF.Model.StylesTable.CreateDefaultXf();
			ct_Xf.xfId = 0U;
			this.xfs.Add(ct_Xf);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00031FAC File Offset: 0x000301AC
		private static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf CreateDefaultXf()
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf
			{
				numFmtId = 0U,
				fontId = 0U,
				fillId = 0U,
				borderId = 0U
			};
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00031FCF File Offset: 0x000301CF
		private static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border CreateDefaultBorder()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ct_Border = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border();
			ct_Border.AddNewLeft();
			ct_Border.AddNewRight();
			ct_Border.AddNewTop();
			ct_Border.AddNewBottom();
			ct_Border.AddNewDiagonal();
			return ct_Border;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00031FF9 File Offset: 0x000301F9
		private static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill[] CreateDefaultFills()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill[] array = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill[]
			{
				new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill(),
				new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill()
			};
			array[0].AddNewPatternFill().patternType = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType?(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType.none);
			array[1].AddNewPatternFill().patternType = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType?(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType.darkGray);
			return array;
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00032038 File Offset: 0x00030238
		private static global::NPOI.XSSF.UserModel.XSSFFont CreateDefaultFont()
		{
			global::NPOI.XSSF.UserModel.XSSFFont xssffont = new global::NPOI.XSSF.UserModel.XSSFFont(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font(), 0);
			xssffont.FontHeightInPoints = 11.0;
			xssffont.Color = global::NPOI.XSSF.UserModel.XSSFFont.DEFAULT_FONT_COLOR;
			xssffont.FontName = "Calibri";
			xssffont.SetFamily(global::NPOI.SS.UserModel.FontFamily.SWISS);
			xssffont.SetScheme(global::NPOI.SS.UserModel.FontScheme.MINOR);
			return xssffont;
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0003208B File Offset: 0x0003028B
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf GetDxfAt(int idx)
		{
			return this.dxfs[idx];
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00032099 File Offset: 0x00030299
		public int PutDxf(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf dxf)
		{
			this.dxfs.Add(dxf);
			return this.dxfs.Count;
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x000320B4 File Offset: 0x000302B4
		public global::NPOI.XSSF.UserModel.XSSFCellStyle CreateCellStyle()
		{
			if (this.NumCellStyles > global::NPOI.XSSF.Model.StylesTable.MAXIMUM_STYLE_ID)
			{
				throw new global::System.InvalidOperationException("The maximum number of Cell Styles was exceeded. You can define up to " + global::NPOI.XSSF.Model.StylesTable.MAXIMUM_STYLE_ID.ToString() + " style in a .xlsx Workbook");
			}
			int count = this.styleXfs.Count;
			return new global::NPOI.XSSF.UserModel.XSSFCellStyle(this.PutCellXf(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf
			{
				numFmtId = 0U,
				fontId = 0U,
				fillId = 0U,
				borderId = 0U,
				xfId = 0U
			}) - 1, count - 1, this, this.theme);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0003213C File Offset: 0x0003033C
		[global::System.Obsolete("deprecated POI 3.15 beta 2. Use {@link #findFont(boolean, short, short, String, boolean, boolean, short, byte)} instead.")]
		public global::NPOI.XSSF.UserModel.XSSFFont FindFont(short boldWeight, short color, short fontHeight, string name, bool italic, bool strikeout, global::NPOI.SS.UserModel.FontSuperScript typeOffset, global::NPOI.SS.UserModel.FontUnderlineType underline)
		{
			foreach (global::NPOI.XSSF.UserModel.XSSFFont xssffont in this.fonts)
			{
				if (xssffont.Boldweight == boldWeight && xssffont.Color == color && xssffont.FontHeight == (double)fontHeight && xssffont.FontName.Equals(name) && xssffont.IsItalic == italic && xssffont.IsStrikeout == strikeout && xssffont.TypeOffset == typeOffset && xssffont.Underline == underline)
				{
					return xssffont;
				}
			}
			return null;
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x000321E4 File Offset: 0x000303E4
		public global::NPOI.XSSF.UserModel.XSSFFont FindFont(bool bold, short color, short fontHeight, string name, bool italic, bool strikeout, global::NPOI.SS.UserModel.FontSuperScript typeOffset, global::NPOI.SS.UserModel.FontUnderlineType underline)
		{
			foreach (global::NPOI.XSSF.UserModel.XSSFFont xssffont in this.fonts)
			{
				if (xssffont.IsBold == bold && xssffont.Color == color && xssffont.FontHeight == (double)fontHeight && xssffont.FontName.Equals(name) && xssffont.IsItalic == italic && xssffont.IsStrikeout == strikeout && xssffont.TypeOffset == typeOffset && xssffont.Underline == underline)
				{
					return xssffont;
				}
			}
			return null;
		}

		// Token: 0x04000427 RID: 1063
		private global::System.Collections.Generic.SortedDictionary<short, string> numberFormats = new global::System.Collections.Generic.SortedDictionary<short, string>();

		// Token: 0x04000428 RID: 1064
		private bool[] usedNumberFormats = new bool[global::NPOI.SS.SpreadsheetVersion.EXCEL2007.MaxCellStyles];

		// Token: 0x04000429 RID: 1065
		private global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFFont> fonts = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFFont>();

		// Token: 0x0400042A RID: 1066
		private global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill> fills = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill>();

		// Token: 0x0400042B RID: 1067
		private global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder> borders = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder>();

		// Token: 0x0400042C RID: 1068
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf> styleXfs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf>();

		// Token: 0x0400042D RID: 1069
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf> xfs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf>();

		// Token: 0x0400042E RID: 1070
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf> dxfs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf>();

		// Token: 0x0400042F RID: 1071
		public static int FIRST_CUSTOM_STYLE_ID = 165;

		// Token: 0x04000430 RID: 1072
		private static int MAXIMUM_STYLE_ID = global::NPOI.SS.SpreadsheetVersion.EXCEL2007.MaxCellStyles;

		// Token: 0x04000431 RID: 1073
		private static short FIRST_USER_DEFINED_NUMBER_FORMAT_ID = 164;

		// Token: 0x04000432 RID: 1074
		private int MAXIMUM_NUMBER_OF_DATA_FORMATS = 250;

		// Token: 0x04000433 RID: 1075
		private global::NPOI.OpenXmlFormats.Spreadsheet.StyleSheetDocument doc;

		// Token: 0x04000434 RID: 1076
		private global::NPOI.XSSF.UserModel.XSSFWorkbook workbook;

		// Token: 0x04000435 RID: 1077
		private global::NPOI.XSSF.Model.ThemesTable theme;
	}
}
