using System;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200035D RID: 861
	public class HSSFDataValidation : global::NPOI.SS.UserModel.IDataValidation
	{
		// Token: 0x060019A2 RID: 6562 RVA: 0x0004EA14 File Offset: 0x0004CC14
		public HSSFDataValidation(global::NPOI.SS.Util.CellRangeAddressList regions, global::NPOI.SS.UserModel.IDataValidationConstraint constraint)
		{
			this._regions = regions;
			this._constraint = (global::NPOI.HSSF.UserModel.DVConstraint)constraint;
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x0004EA44 File Offset: 0x0004CC44
		public global::NPOI.SS.UserModel.IDataValidationConstraint ValidationConstraint
		{
			get
			{
				return this._constraint;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x0004EA44 File Offset: 0x0004CC44
		public global::NPOI.HSSF.UserModel.DVConstraint Constraint
		{
			get
			{
				return this._constraint;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x0004EA4C File Offset: 0x0004CC4C
		public global::NPOI.SS.Util.CellRangeAddressList Regions
		{
			get
			{
				return this._regions;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x0004EA54 File Offset: 0x0004CC54
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x0004EA5C File Offset: 0x0004CC5C
		public int ErrorStyle
		{
			get
			{
				return this._errorStyle;
			}
			set
			{
				this._errorStyle = value;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x0004EA65 File Offset: 0x0004CC65
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x0004EA6D File Offset: 0x0004CC6D
		public bool EmptyCellAllowed
		{
			get
			{
				return this._emptyCellAllowed;
			}
			set
			{
				this._emptyCellAllowed = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x0004EA76 File Offset: 0x0004CC76
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x0004EA8E File Offset: 0x0004CC8E
		public bool SuppressDropDownArrow
		{
			get
			{
				return this._constraint.GetValidationType() == 3 && this._suppress_dropdown_arrow;
			}
			set
			{
				this._suppress_dropdown_arrow = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x0004EA97 File Offset: 0x0004CC97
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x0004EA9F File Offset: 0x0004CC9F
		public bool ShowPromptBox
		{
			get
			{
				return this._ShowPromptBox;
			}
			set
			{
				this._ShowPromptBox = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x0004EAA8 File Offset: 0x0004CCA8
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x0004EAB0 File Offset: 0x0004CCB0
		public bool ShowErrorBox
		{
			get
			{
				return this._ShowErrorBox;
			}
			set
			{
				this._ShowErrorBox = value;
			}
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x0004EAB9 File Offset: 0x0004CCB9
		public void CreatePromptBox(string title, string text)
		{
			this._prompt_title = title;
			this._prompt_text = text;
			this.ShowPromptBox = true;
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x0004EAD0 File Offset: 0x0004CCD0
		public string PromptBoxTitle
		{
			get
			{
				return this._prompt_title;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x0004EAD8 File Offset: 0x0004CCD8
		public string PromptBoxText
		{
			get
			{
				return this._prompt_text;
			}
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0004EAE0 File Offset: 0x0004CCE0
		public void CreateErrorBox(string title, string text)
		{
			this._error_title = title;
			this._error_text = text;
			this.ShowErrorBox = true;
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x0004EAF7 File Offset: 0x0004CCF7
		public string ErrorBoxTitle
		{
			get
			{
				return this._error_title;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x0004EAFF File Offset: 0x0004CCFF
		public string ErrorBoxText
		{
			get
			{
				return this._error_text;
			}
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x0004EB08 File Offset: 0x0004CD08
		public global::NPOI.HSSF.Record.DVRecord CreateDVRecord(global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			global::NPOI.HSSF.UserModel.DVConstraint.FormulaPair formulaPair = this._constraint.CreateFormulas(sheet);
			return new global::NPOI.HSSF.Record.DVRecord(this._constraint.GetValidationType(), this._constraint.Operator, this._errorStyle, this._emptyCellAllowed, this.SuppressDropDownArrow, this._constraint.GetValidationType() == 3 && this._constraint.ExplicitListValues != null, this._ShowPromptBox, this._prompt_title, this._prompt_text, this._ShowErrorBox, this._error_title, this._error_text, formulaPair.Formula1, formulaPair.Formula2, this._regions);
		}

		// Token: 0x04000AF2 RID: 2802
		private string _prompt_title;

		// Token: 0x04000AF3 RID: 2803
		private string _prompt_text;

		// Token: 0x04000AF4 RID: 2804
		private string _error_title;

		// Token: 0x04000AF5 RID: 2805
		private string _error_text;

		// Token: 0x04000AF6 RID: 2806
		private int _errorStyle;

		// Token: 0x04000AF7 RID: 2807
		private bool _emptyCellAllowed = true;

		// Token: 0x04000AF8 RID: 2808
		private bool _suppress_dropdown_arrow;

		// Token: 0x04000AF9 RID: 2809
		private bool _ShowPromptBox = true;

		// Token: 0x04000AFA RID: 2810
		private bool _ShowErrorBox = true;

		// Token: 0x04000AFB RID: 2811
		private global::NPOI.SS.Util.CellRangeAddressList _regions;

		// Token: 0x04000AFC RID: 2812
		private global::NPOI.HSSF.UserModel.DVConstraint _constraint;
	}
}
