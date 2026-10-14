using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200008D RID: 141
	public class XSSFName : global::NPOI.SS.UserModel.IName
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x00018880 File Offset: 0x00016A80
		public XSSFName(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName name, global::NPOI.XSSF.UserModel.XSSFWorkbook workbook)
		{
			this._workbook = workbook;
			this._ctName = name;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00018896 File Offset: 0x00016A96
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName GetCTName()
		{
			return this._ctName;
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x0001889E File Offset: 0x00016A9E
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x000188AC File Offset: 0x00016AAC
		public string NameName
		{
			get
			{
				return this._ctName.name;
			}
			set
			{
				global::NPOI.XSSF.UserModel.XSSFName.ValidateName(value);
				string nameName = this.NameName;
				int sheetIndex = this.SheetIndex;
				foreach (global::NPOI.SS.UserModel.IName name in this._workbook.GetNames(value))
				{
					global::NPOI.XSSF.UserModel.XSSFName xssfname = (global::NPOI.XSSF.UserModel.XSSFName)name;
					if (xssfname != this && sheetIndex == xssfname.SheetIndex)
					{
						throw new global::System.ArgumentException("The " + ((sheetIndex == -1) ? "workbook" : "sheet") + " already contains this name: " + value);
					}
				}
				this._ctName.name = value;
				this._workbook.UpdateName(this, nameName);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00018960 File Offset: 0x00016B60
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00018988 File Offset: 0x00016B88
		public string RefersToFormula
		{
			get
			{
				string value = this._ctName.Value;
				if (value == null || value.Length < 1)
				{
					return null;
				}
				return value;
			}
			set
			{
				global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook workbook = global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook.Create(this._workbook);
				global::NPOI.SS.Formula.FormulaParser.Parse(value, workbook, global::NPOI.SS.Formula.FormulaType.NamedRange, this.SheetIndex, -1);
				this._ctName.Value = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x000189C0 File Offset: 0x00016BC0
		public bool IsDeleted
		{
			get
			{
				string refersToFormula = this.RefersToFormula;
				if (refersToFormula == null)
				{
					return false;
				}
				global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook workbook = global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook.Create(this._workbook);
				return global::NPOI.SS.Formula.PTG.Ptg.DoesFormulaReferToDeletedCell(global::NPOI.SS.Formula.FormulaParser.Parse(refersToFormula, workbook, global::NPOI.SS.Formula.FormulaType.NamedRange, this.SheetIndex, -1));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x000189F9 File Offset: 0x00016BF9
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00018A18 File Offset: 0x00016C18
		public int SheetIndex
		{
			get
			{
				if (!this._ctName.IsSetLocalSheetId())
				{
					return -1;
				}
				return (int)this._ctName.localSheetId;
			}
			set
			{
				int num = this._workbook.NumberOfSheets - 1;
				if (value < -1 || value > num)
				{
					throw new global::System.ArgumentException("Sheet index (" + value.ToString() + ") is out of range" + ((num == -1) ? "" : (" (0.." + num.ToString() + ")")));
				}
				if (value == -1)
				{
					if (this._ctName.IsSetLocalSheetId())
					{
						this._ctName.UnsetLocalSheetId();
						return;
					}
				}
				else
				{
					this._ctName.localSheetId = (uint)value;
					this._ctName.localSheetIdSpecified = true;
				}
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00018AAD File Offset: 0x00016CAD
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00018ABA File Offset: 0x00016CBA
		public bool Function
		{
			get
			{
				return this._ctName.function;
			}
			set
			{
				this._ctName.function = value;
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00018AC8 File Offset: 0x00016CC8
		public void SetFunction(bool value)
		{
			this.Function = value;
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00018AD1 File Offset: 0x00016CD1
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00018ADE File Offset: 0x00016CDE
		public int FunctionGroupId
		{
			get
			{
				return (int)this._ctName.functionGroupId;
			}
			set
			{
				this._ctName.functionGroupId = (uint)value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00018AEC File Offset: 0x00016CEC
		public string SheetName
		{
			get
			{
				if (this._ctName.IsSetLocalSheetId())
				{
					int localSheetId = (int)this._ctName.localSheetId;
					return this._workbook.GetSheetName(localSheetId);
				}
				return new global::NPOI.SS.Util.AreaReference(this.RefersToFormula).FirstCell.SheetName;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00018B34 File Offset: 0x00016D34
		public bool IsFunctionName
		{
			get
			{
				return this.Function;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00018B3C File Offset: 0x00016D3C
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00018B49 File Offset: 0x00016D49
		public string Comment
		{
			get
			{
				return this._ctName.comment;
			}
			set
			{
				this._ctName.comment = value;
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00018B57 File Offset: 0x00016D57
		public override int GetHashCode()
		{
			return this._ctName.ToString().GetHashCode();
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00018B6C File Offset: 0x00016D6C
		public override bool Equals(object o)
		{
			if (o == this)
			{
				return true;
			}
			if (!(o is global::NPOI.XSSF.UserModel.XSSFName))
			{
				return false;
			}
			global::NPOI.XSSF.UserModel.XSSFName xssfname = (global::NPOI.XSSF.UserModel.XSSFName)o;
			return this._ctName.name == xssfname.GetCTName().name && this._ctName.localSheetId == xssfname.GetCTName().localSheetId && this._ctName.Value == xssfname.RefersToFormula;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00018BE0 File Offset: 0x00016DE0
		private static void ValidateName(string name)
		{
			if (name.Length == 0)
			{
				throw new global::System.ArgumentException("Name cannot be blank");
			}
			char c = name[0];
			string text = "_";
			if (!char.IsLetter(c) && text.IndexOf(c) == -1)
			{
				throw new global::System.ArgumentException("Invalid name: '" + name + "': first character must be underscore or a letter");
			}
			text = "_\\";
			foreach (char c2 in name.ToCharArray())
			{
				if (!char.IsLetterOrDigit(c2) && text.IndexOf(c2) == -1)
				{
					throw new global::System.ArgumentException("Invalid name: '" + name + "'");
				}
			}
		}

		// Token: 0x040002EA RID: 746
		public static string BUILTIN_PRINT_AREA = "_xlnm.Print_Area";

		// Token: 0x040002EB RID: 747
		public static string BUILTIN_PRINT_TITLE = "_xlnm.Print_Titles";

		// Token: 0x040002EC RID: 748
		public static string BUILTIN_CRITERIA = "_xlnm.Criteria:";

		// Token: 0x040002ED RID: 749
		public static string BUILTIN_EXTRACT = "_xlnm.Extract:";

		// Token: 0x040002EE RID: 750
		public static string BUILTIN_FILTER_DB = "_xlnm._FilterDatabase";

		// Token: 0x040002EF RID: 751
		public static string BUILTIN_CONSOLIDATE_AREA = "_xlnm.Consolidate_Area";

		// Token: 0x040002F0 RID: 752
		public static string BUILTIN_DATABASE = "_xlnm.Database";

		// Token: 0x040002F1 RID: 753
		public static string BUILTIN_SHEET_TITLE = "_xlnm.Sheet_Title";

		// Token: 0x040002F2 RID: 754
		private global::NPOI.XSSF.UserModel.XSSFWorkbook _workbook;

		// Token: 0x040002F3 RID: 755
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName _ctName;
	}
}
