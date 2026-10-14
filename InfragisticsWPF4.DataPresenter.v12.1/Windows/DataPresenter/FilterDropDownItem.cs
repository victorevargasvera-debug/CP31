using System;
using System.Windows.Input;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200013B RID: 315
	public class FilterDropDownItem : global::Infragistics.Windows.Editors.ComboBoxDataItem
	{
		// Token: 0x06001112 RID: 4370 RVA: 0x0004A799 File Offset: 0x00048999
		internal FilterDropDownItem(object value, string displayText, bool isCellValue) : base(value, global::Infragistics.Windows.DataPresenter.FilterDropDownItem.GetDisplayTextHelper(value, displayText))
		{
			this._isCellValue = isCellValue;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0004A7B0 File Offset: 0x000489B0
		public FilterDropDownItem(global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialOperand, string displayText) : this(specialOperand, displayText, false)
		{
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0004A7BB File Offset: 0x000489BB
		public FilterDropDownItem(global::Infragistics.Windows.Controls.ICondition condition, string displayText) : this(condition, displayText, false)
		{
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0004A7C6 File Offset: 0x000489C6
		public FilterDropDownItem(global::System.Windows.Input.ICommand action, string displayText) : this(action, displayText, false)
		{
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0004A7D1 File Offset: 0x000489D1
		public bool IsAction
		{
			get
			{
				return !this._isCellValue && base.Value is global::System.Windows.Input.ICommand;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x0004A7EB File Offset: 0x000489EB
		public bool IsCellValue
		{
			get
			{
				return this._isCellValue;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0004A7F3 File Offset: 0x000489F3
		public bool IsCondition
		{
			get
			{
				return !this._isCellValue && base.Value is global::Infragistics.Windows.Controls.ICondition;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x0004A80D File Offset: 0x00048A0D
		public bool IsSpecialOperand
		{
			get
			{
				return !this._isCellValue && base.Value is global::Infragistics.Windows.Controls.SpecialFilterOperandBase;
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0004A828 File Offset: 0x00048A28
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

		// Token: 0x040006BD RID: 1725
		private bool _isCellValue;

		// Token: 0x040006BE RID: 1726
		internal global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo _cellInfo;
	}
}
