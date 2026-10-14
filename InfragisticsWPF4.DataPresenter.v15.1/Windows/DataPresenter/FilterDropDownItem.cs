using System;
using System.Windows.Input;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000157 RID: 343
	public class FilterDropDownItem : global::Infragistics.Windows.Editors.ComboBoxDataItem
	{
		// Token: 0x0600147B RID: 5243 RVA: 0x0005BA95 File Offset: 0x00059C95
		internal FilterDropDownItem(object value, string displayText, bool isCellValue) : base(value, global::Infragistics.Windows.DataPresenter.FilterDropDownItem.GetDisplayTextHelper(value, displayText))
		{
			this._isCellValue = isCellValue;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0005BAAC File Offset: 0x00059CAC
		public FilterDropDownItem(global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialOperand, string displayText) : this(specialOperand, displayText, false)
		{
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0005BAB7 File Offset: 0x00059CB7
		public FilterDropDownItem(global::Infragistics.Windows.Controls.ICondition condition, string displayText) : this(condition, displayText, false)
		{
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0005BAC2 File Offset: 0x00059CC2
		public FilterDropDownItem(global::System.Windows.Input.ICommand action, string displayText) : this(action, displayText, false)
		{
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x0005BACD File Offset: 0x00059CCD
		public bool IsAction
		{
			get
			{
				return !this._isCellValue && base.Value is global::System.Windows.Input.ICommand;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0005BAE7 File Offset: 0x00059CE7
		public bool IsCellValue
		{
			get
			{
				return this._isCellValue;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0005BAEF File Offset: 0x00059CEF
		public bool IsCondition
		{
			get
			{
				return !this._isCellValue && base.Value is global::Infragistics.Windows.Controls.ICondition;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0005BB09 File Offset: 0x00059D09
		public bool IsSpecialOperand
		{
			get
			{
				return !this._isCellValue && base.Value is global::Infragistics.Windows.Controls.SpecialFilterOperandBase;
			}
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x0005BB24 File Offset: 0x00059D24
		private static string GetDisplayTextHelper(object value, string displayText)
		{
			if (displayText != null)
			{
				return displayText;
			}
			global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = value as global::Infragistics.Windows.Controls.ComparisonCondition;
			if (comparisonCondition != null)
			{
				return comparisonCondition.DisplayText;
			}
			return null;
		}

		// Token: 0x04000863 RID: 2147
		private bool _isCellValue;

		// Token: 0x04000864 RID: 2148
		internal global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo _cellInfo;
	}
}
