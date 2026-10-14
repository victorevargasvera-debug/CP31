using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Infragistics
{
	// Token: 0x02000030 RID: 48
	public abstract class ComparisonConditionBase : global::Infragistics.IFilterCondition, global::Infragistics.IExpressConditions, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000D371 File Offset: 0x0000B571
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0000D379 File Offset: 0x0000B579
		public global::Infragistics.IRecordFilter Parent
		{
			get
			{
				return this._parent;
			}
			protected internal set
			{
				this._parent = value;
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000D382 File Offset: 0x0000B582
		protected virtual global::System.Linq.Expressions.Expression GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			return null;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000D385 File Offset: 0x0000B585
		protected virtual global::System.Linq.Expressions.Expression GetCurrentExpression()
		{
			return null;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000D388 File Offset: 0x0000B588
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0000D390 File Offset: 0x0000B590
		global::Infragistics.IRecordFilter global::Infragistics.IFilterCondition.Parent
		{
			get
			{
				return this.Parent;
			}
			set
			{
				this.Parent = value;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000D399 File Offset: 0x0000B599
		global::System.Linq.Expressions.Expression global::Infragistics.IExpressConditions.GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			return this.GetCurrentExpression(context);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000D3A2 File Offset: 0x0000B5A2
		global::System.Linq.Expressions.Expression global::Infragistics.IExpressConditions.GetCurrentExpression()
		{
			return this.GetCurrentExpression();
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000240 RID: 576 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		// (remove) Token: 0x06000241 RID: 577 RVA: 0x0000D3E4 File Offset: 0x0000B5E4
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000242 RID: 578 RVA: 0x0000D419 File Offset: 0x0000B619
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x040000F6 RID: 246
		private global::Infragistics.IRecordFilter _parent;
	}
}
