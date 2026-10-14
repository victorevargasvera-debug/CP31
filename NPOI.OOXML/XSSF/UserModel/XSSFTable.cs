using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;
using NPOI.XSSF.UserModel.Helpers;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x020000A1 RID: 161
	public class XSSFTable : global::NPOI.POIXMLDocumentPart, global::NPOI.SS.UserModel.ITable
	{
		// Token: 0x060009D1 RID: 2513 RVA: 0x00023F46 File Offset: 0x00022146
		public XSSFTable()
		{
			this.ctTable = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Table();
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00023F5C File Offset: 0x0002215C
		internal XSSFTable(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			global::System.Xml.XmlDocument xmlDoc = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(part.GetInputStream());
			this.ReadFrom(xmlDoc);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00023F83 File Offset: 0x00022183
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		protected XSSFTable(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00023F8C File Offset: 0x0002218C
		public void ReadFrom(global::System.Xml.XmlDocument xmlDoc)
		{
			try
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.TableDocument tableDocument = global::NPOI.OpenXmlFormats.Spreadsheet.TableDocument.Parse(xmlDoc, global::NPOI.POIXMLDocumentPart.NamespaceManager);
				this.ctTable = tableDocument.GetTable();
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00023FD0 File Offset: 0x000221D0
		public global::NPOI.XSSF.UserModel.XSSFSheet GetXSSFSheet()
		{
			return (global::NPOI.XSSF.UserModel.XSSFSheet)base.GetParent();
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00023FDD File Offset: 0x000221DD
		public void WriteTo(global::System.IO.Stream out1)
		{
			this.UpdateHeaders();
			global::NPOI.OpenXmlFormats.Spreadsheet.TableDocument tableDocument = new global::NPOI.OpenXmlFormats.Spreadsheet.TableDocument();
			tableDocument.SetTable(this.ctTable);
			tableDocument.Save(out1);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00023FFC File Offset: 0x000221FC
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.WriteTo(outputStream);
			outputStream.Close();
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00024022 File Offset: 0x00022222
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Table GetCTTable()
		{
			return this.ctTable;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0002402C File Offset: 0x0002222C
		public bool MapsTo(long id)
		{
			bool result = false;
			using (global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Helpers.XSSFXmlColumnPr>.Enumerator enumerator = this.GetXmlColumnPrs().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetMapId() == id)
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00024088 File Offset: 0x00022288
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn[] TableColumns
		{
			get
			{
				if (this.ctColumns == null)
				{
					this.ctColumns = this.ctTable.tableColumns.tableColumn.ToArray();
				}
				return this.ctColumns;
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000240B4 File Offset: 0x000222B4
		public string GetCommonXpath()
		{
			if (this.commonXPath == null)
			{
				global::System.Array array = null;
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn ct_TableColumn in this.TableColumns)
				{
					if (ct_TableColumn.xmlColumnPr != null)
					{
						string[] array2 = ct_TableColumn.xmlColumnPr.xpath.Split(new char[]
						{
							'/'
						});
						if (array == null)
						{
							array = array2;
						}
						else
						{
							int num = (array.Length > array2.Length) ? array2.Length : array.Length;
							for (int j = 0; j < num; j++)
							{
								if (!array.GetValue(j).Equals(array2[j]))
								{
									array = global::NPOI.Util.Arrays.AsList(array).GetRange(0, j).ToArray(typeof(string));
									break;
								}
							}
						}
					}
				}
				this.commonXPath = "";
				for (int k = 1; k < array.Length; k++)
				{
					string str = this.commonXPath;
					string str2 = "/";
					object value = array.GetValue(k);
					this.commonXPath = str + str2 + ((value != null) ? value.ToString() : null);
				}
			}
			return this.commonXPath;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000241CC File Offset: 0x000223CC
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Helpers.XSSFXmlColumnPr> GetXmlColumnPrs()
		{
			if (this.xmlColumnPr == null)
			{
				this.xmlColumnPr = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Helpers.XSSFXmlColumnPr>();
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn ct_TableColumn in this.ctTable.tableColumns.tableColumn)
				{
					if (ct_TableColumn.xmlColumnPr != null)
					{
						global::NPOI.XSSF.UserModel.Helpers.XSSFXmlColumnPr item = new global::NPOI.XSSF.UserModel.Helpers.XSSFXmlColumnPr(this, ct_TableColumn, ct_TableColumn.xmlColumnPr);
						this.xmlColumnPr.Add(item);
					}
				}
			}
			return this.xmlColumnPr;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x00024260 File Offset: 0x00022460
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x0002426D File Offset: 0x0002246D
		public string Name
		{
			get
			{
				return this.ctTable.name;
			}
			set
			{
				this.ctTable.name = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0002427B File Offset: 0x0002247B
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x00024288 File Offset: 0x00022488
		public string DisplayName
		{
			get
			{
				return this.ctTable.displayName;
			}
			set
			{
				this.ctTable.displayName = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00024296 File Offset: 0x00022496
		public long NumberOfMappedColumns
		{
			get
			{
				return (long)((ulong)this.ctTable.tableColumns.count);
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000242A9 File Offset: 0x000224A9
		public global::NPOI.SS.Util.CellReference StartCellReference
		{
			get
			{
				if (this.startCellReference == null)
				{
					this.SetCellReferences();
				}
				return this.startCellReference;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x000242BF File Offset: 0x000224BF
		public global::NPOI.SS.Util.CellReference EndCellReference
		{
			get
			{
				if (this.endCellReference == null)
				{
					this.SetCellReferences();
				}
				return this.endCellReference;
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000242D8 File Offset: 0x000224D8
		private void SetCellReferences()
		{
			string @ref = this.ctTable.@ref;
			if (@ref != null)
			{
				string[] array = @ref.Split(new char[]
				{
					':'
				}, 2);
				string cellRef = array[0];
				string cellRef2 = array[1];
				this.startCellReference = new global::NPOI.SS.Util.CellReference(cellRef);
				this.endCellReference = new global::NPOI.SS.Util.CellReference(cellRef2);
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00024325 File Offset: 0x00022525
		public void UpdateReferences()
		{
			this.startCellReference = null;
			this.endCellReference = null;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00024338 File Offset: 0x00022538
		public int RowCount
		{
			get
			{
				global::NPOI.SS.Util.CellReference cellReference = this.StartCellReference;
				global::NPOI.SS.Util.CellReference cellReference2 = this.EndCellReference;
				int result = 0;
				if (cellReference != null && cellReference2 != null)
				{
					result = cellReference2.Row - cellReference.Row + 1;
				}
				return result;
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0002436C File Offset: 0x0002256C
		public void UpdateHeaders()
		{
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = (global::NPOI.XSSF.UserModel.XSSFSheet)base.GetParent();
			global::NPOI.SS.Util.CellReference cellReference = this.StartCellReference;
			if (cellReference == null)
			{
				return;
			}
			int row = cellReference.Row;
			int col = (int)cellReference.Col;
			global::NPOI.XSSF.UserModel.XSSFRow xssfrow = xssfsheet.GetRow(row) as global::NPOI.XSSF.UserModel.XSSFRow;
			if (xssfrow != null && xssfrow.GetCTRow() != null)
			{
				int num = col;
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn ct_TableColumn in this.GetCTTable().tableColumns.tableColumn)
				{
					global::NPOI.XSSF.UserModel.XSSFCell xssfcell = xssfrow.GetCell(num) as global::NPOI.XSSF.UserModel.XSSFCell;
					if (xssfcell != null)
					{
						ct_TableColumn.name = xssfcell.StringCellValue;
					}
					num++;
				}
				this.ctColumns = null;
				this.columnMap = null;
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00024440 File Offset: 0x00022640
		public int FindColumnIndex(string columnHeader)
		{
			if (columnHeader == null)
			{
				return -1;
			}
			if (this.columnMap == null)
			{
				this.columnMap = new global::System.Collections.Generic.Dictionary<string, int>(this.TableColumns.Length * 3 / 2);
				int num = 0;
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn ct_TableColumn in this.TableColumns)
				{
					this.columnMap.Add(ct_TableColumn.name.ToUpper(global::System.Globalization.CultureInfo.CurrentCulture), num);
					num++;
				}
			}
			int result = -1;
			string key = columnHeader.Replace("'", "").ToUpper(global::System.Globalization.CultureInfo.CurrentCulture);
			if (this.columnMap.ContainsKey(key))
			{
				result = this.columnMap[key];
			}
			return result;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x000244EC File Offset: 0x000226EC
		public string SheetName
		{
			get
			{
				return this.GetXSSFSheet().SheetName;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x000244F9 File Offset: 0x000226F9
		public bool IsHasTotalsRow
		{
			get
			{
				return this.ctTable.totalsRowShown;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00024506 File Offset: 0x00022706
		public int StartColIndex
		{
			get
			{
				return (int)this.StartCellReference.Col;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x00024513 File Offset: 0x00022713
		public int StartRowIndex
		{
			get
			{
				return this.StartCellReference.Row;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00024520 File Offset: 0x00022720
		public int EndColIndex
		{
			get
			{
				return (int)this.EndCellReference.Col;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0002452D File Offset: 0x0002272D
		public int EndRowIndex
		{
			get
			{
				return this.EndCellReference.Row;
			}
		}

		// Token: 0x04000368 RID: 872
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Table ctTable;

		// Token: 0x04000369 RID: 873
		private global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Helpers.XSSFXmlColumnPr> xmlColumnPr;

		// Token: 0x0400036A RID: 874
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn[] ctColumns;

		// Token: 0x0400036B RID: 875
		private global::System.Collections.Generic.Dictionary<string, int> columnMap;

		// Token: 0x0400036C RID: 876
		private global::NPOI.SS.Util.CellReference startCellReference;

		// Token: 0x0400036D RID: 877
		private global::NPOI.SS.Util.CellReference endCellReference;

		// Token: 0x0400036E RID: 878
		private string commonXPath;
	}
}
