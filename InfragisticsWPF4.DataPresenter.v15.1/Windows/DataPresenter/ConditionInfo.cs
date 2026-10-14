using System;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000153 RID: 339
	internal class ConditionInfo : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x0600145E RID: 5214 RVA: 0x0005B563 File Offset: 0x00059763
		internal ConditionInfo()
		{
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0005B56B File Offset: 0x0005976B
		internal ConditionInfo(global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group, global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, string displayText)
		{
			this._group = group;
			this._comparisonOperator = comparisonOperator;
			this._value = value;
			this._displayText = displayText;
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0005B590 File Offset: 0x00059790
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x0005B598 File Offset: 0x00059798
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

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0005B5DB File Offset: 0x000597DB
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x0005B5E3 File Offset: 0x000597E3
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

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0005B5F7 File Offset: 0x000597F7
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x0005B600 File Offset: 0x00059800
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

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0005B65D File Offset: 0x0005985D
		public string DisplayText
		{
			get
			{
				return this._displayText;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x0005B665 File Offset: 0x00059865
		public string ErrorDescription
		{
			get
			{
				return this._errorDescription;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0005B670 File Offset: 0x00059870
		internal bool IsFirstInGroup
		{
			get
			{
				return this.Group != null && this.Group.ChildConditions.Count > 0 && this.Group.ChildConditions.Contains(this) && this.Group.ChildConditions.IndexOf(this) == 0;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0005B6C4 File Offset: 0x000598C4
		internal bool IsLastInGroup
		{
			get
			{
				return this.Group != null && this.Group.ChildConditions.Count > 0 && this.Group.ChildConditions.Contains(this) && this.Group.ChildConditions.IndexOf(this) == this.Group.ChildConditions.Count - 1;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0005B726 File Offset: 0x00059926
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x0005B72E File Offset: 0x0005992E
		internal bool IsSelected { get; set; }

		// Token: 0x0600146C RID: 5228 RVA: 0x0005B737 File Offset: 0x00059937
		internal void SetErrorDescription(string errorDescription)
		{
			this._errorDescription = errorDescription;
			base.RaisePropertyChangedEvent("ErrorDescription");
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0005B74C File Offset: 0x0005994C
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

		// Token: 0x0400085A RID: 2138
		private global::Infragistics.Windows.DataPresenter.ConditionInfoGroup _group;

		// Token: 0x0400085B RID: 2139
		private global::Infragistics.Windows.Controls.ComparisonOperator _comparisonOperator;

		// Token: 0x0400085C RID: 2140
		private object _value;

		// Token: 0x0400085D RID: 2141
		private string _errorDescription;

		// Token: 0x0400085E RID: 2142
		private string _displayText;
	}
}
