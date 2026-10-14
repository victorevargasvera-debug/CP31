using System;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000137 RID: 311
	internal class ConditionInfo : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x060010F5 RID: 4341 RVA: 0x0004A267 File Offset: 0x00048467
		internal ConditionInfo()
		{
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0004A26F File Offset: 0x0004846F
		internal ConditionInfo(global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group, global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, string displayText)
		{
			this._group = group;
			this._comparisonOperator = comparisonOperator;
			this._value = value;
			this._displayText = displayText;
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0004A294 File Offset: 0x00048494
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x0004A29C File Offset: 0x0004849C
		public global::Infragistics.Windows.Controls.ComparisonOperator ComparisonOperator
		{
			get
			{
				return this._comparisonOperator;
			}
			set
			{
				this._comparisonOperator = value;
				base.RaisePropertyChangedEvent("ComparisonOperator");
				global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = this._value as global::Infragistics.Windows.Controls.ComparisonCondition;
				if (comparisonCondition != null && !global::Infragistics.Windows.DataPresenter.RecordFilter.IsOperatorCompatibleWithCondition(comparisonCondition, this._comparisonOperator))
				{
					this.Value = null;
				}
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0004A2DF File Offset: 0x000484DF
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x0004A2E7 File Offset: 0x000484E7
		public global::Infragistics.Windows.DataPresenter.ConditionInfoGroup Group
		{
			get
			{
				return this._group;
			}
			set
			{
				this._group = value;
				base.RaisePropertyChangedEvent("Group");
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0004A2FB File Offset: 0x000484FB
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x0004A304 File Offset: 0x00048504
		public object Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
				base.RaisePropertyChangedEvent("Value");
				global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = this._value as global::Infragistics.Windows.Controls.ComparisonCondition;
				if (comparisonCondition != null && !global::Infragistics.Windows.DataPresenter.RecordFilter.IsOperatorCompatibleWithCondition(comparisonCondition, this._comparisonOperator))
				{
					if (!string.IsNullOrEmpty(comparisonCondition.DisplayText))
					{
						this.ComparisonOperator = global::Infragistics.Windows.Controls.ComparisonOperator.Equals;
						return;
					}
					this.ComparisonOperator = comparisonCondition.Operator;
				}
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0004A361 File Offset: 0x00048561
		public string DisplayText
		{
			get
			{
				return this._displayText;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x0004A369 File Offset: 0x00048569
		public string ErrorDescription
		{
			get
			{
				return this._errorDescription;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0004A374 File Offset: 0x00048574
		internal bool IsFirstInGroup
		{
			get
			{
				return this.Group != null && this.Group.ChildConditions.Count > 0 && this.Group.ChildConditions.Contains(this) && this.Group.ChildConditions.IndexOf(this) == 0;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0004A3C8 File Offset: 0x000485C8
		internal bool IsLastInGroup
		{
			get
			{
				return this.Group != null && this.Group.ChildConditions.Count > 0 && this.Group.ChildConditions.Contains(this) && this.Group.ChildConditions.IndexOf(this) == this.Group.ChildConditions.Count - 1;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x0004A42A File Offset: 0x0004862A
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x0004A432 File Offset: 0x00048632
		internal bool IsSelected { get; set; }

		// Token: 0x06001103 RID: 4355 RVA: 0x0004A43B File Offset: 0x0004863B
		internal void SetErrorDescription(string errorDescription)
		{
			this._errorDescription = errorDescription;
			base.RaisePropertyChangedEvent("ErrorDescription");
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0004A450 File Offset: 0x00048650
		public override string ToString()
		{
			if (!string.IsNullOrEmpty(this._displayText))
			{
				return this._displayText;
			}
			return string.Format("ComparisonOperator: {0}, Value: {1}, Group: <<<{2}>>>", new object[]
			{
				this.ComparisonOperator.ToString(),
				this.Value,
				this.Group.ToString()
			});
		}

		// Token: 0x040006B4 RID: 1716
		private global::Infragistics.Windows.DataPresenter.ConditionInfoGroup _group;

		// Token: 0x040006B5 RID: 1717
		private global::Infragistics.Windows.Controls.ComparisonOperator _comparisonOperator;

		// Token: 0x040006B6 RID: 1718
		private object _value;

		// Token: 0x040006B7 RID: 1719
		private string _errorDescription;

		// Token: 0x040006B8 RID: 1720
		private string _displayText;
	}
}
