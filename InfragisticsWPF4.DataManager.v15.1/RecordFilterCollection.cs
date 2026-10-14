using System;
using System.ComponentModel;
using System.Linq.Expressions;
using Infragistics.Collections;

namespace Infragistics
{
	// Token: 0x02000036 RID: 54
	public class RecordFilterCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.IRecordFilter>, global::Infragistics.IGroupFilterConditions, global::Infragistics.IExpressConditions, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0000DAE0 File Offset: 0x0000BCE0
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		public global::Infragistics.LogicalOperator LogicalOperator
		{
			get
			{
				return this._logicalOperator;
			}
			set
			{
				if (this._logicalOperator != value)
				{
					this._logicalOperator = value;
					this.OnPropertyChanged("LogicalOperator");
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000DB05 File Offset: 0x0000BD05
		global::Infragistics.LogicalOperator global::Infragistics.IGroupFilterConditions.LogicalOperator
		{
			get
			{
				return this.LogicalOperator;
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000DB0D File Offset: 0x0000BD0D
		global::System.Linq.Expressions.Expression global::Infragistics.IExpressConditions.GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			return this.GetCurrentExpression(context);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000DB16 File Offset: 0x0000BD16
		global::System.Linq.Expressions.Expression global::Infragistics.IExpressConditions.GetCurrentExpression()
		{
			return this.GetCurrentExpression();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000DB1E File Offset: 0x0000BD1E
		protected virtual global::System.Linq.Expressions.Expression GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			return context.CreateExpression(this);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000DB27 File Offset: 0x0000BD27
		protected virtual global::System.Linq.Expressions.Expression GetCurrentExpression()
		{
			throw new global::System.NotImplementedException("");
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000DB33 File Offset: 0x0000BD33
		protected internal void AddItemSilently(global::Infragistics.IRecordFilter item)
		{
			base.AddItemSilently(this.Items.Count, item);
			item.PropertyChanged -= this.ProvidesChanged_PropertyChanged;
			item.PropertyChanged += this.ProvidesChanged_PropertyChanged;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000DB6B File Offset: 0x0000BD6B
		protected override void AddItem(int index, global::Infragistics.IRecordFilter item)
		{
			base.AddItem(index, item);
			item.PropertyChanged -= this.ProvidesChanged_PropertyChanged;
			item.PropertyChanged += this.ProvidesChanged_PropertyChanged;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000DB99 File Offset: 0x0000BD99
		protected override bool RemoveItem(int index)
		{
			base[index].PropertyChanged -= this.ProvidesChanged_PropertyChanged;
			return base.RemoveItem(index);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		protected override void ResetItems()
		{
			foreach (global::Infragistics.IRecordFilter recordFilter in this.Items)
			{
				recordFilter.PropertyChanged -= this.ProvidesChanged_PropertyChanged;
			}
			base.ResetItems();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000DC1C File Offset: 0x0000BE1C
		protected override void InsertItem(int index, global::Infragistics.IRecordFilter item)
		{
			this.AddItem(index, item);
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000289 RID: 649 RVA: 0x0000DC28 File Offset: 0x0000BE28
		// (remove) Token: 0x0600028A RID: 650 RVA: 0x0000DC60 File Offset: 0x0000BE60
		public event global::System.EventHandler<global::System.EventArgs> CollectionItemChanged;

		// Token: 0x0600028B RID: 651 RVA: 0x0000DC95 File Offset: 0x0000BE95
		protected virtual void OnCollectionItemChanged()
		{
			if (this.CollectionItemChanged != null)
			{
				this.CollectionItemChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		private void ProvidesChanged_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnCollectionItemChanged();
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600028D RID: 653 RVA: 0x0000DCB8 File Offset: 0x0000BEB8
		// (remove) Token: 0x0600028E RID: 654 RVA: 0x0000DCF0 File Offset: 0x0000BEF0
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600028F RID: 655 RVA: 0x0000DD25 File Offset: 0x0000BF25
		protected new virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000102 RID: 258
		private global::Infragistics.LogicalOperator _logicalOperator;
	}
}
