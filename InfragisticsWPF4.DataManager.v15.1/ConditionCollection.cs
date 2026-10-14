using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq.Expressions;
using Infragistics.Collections;

namespace Infragistics
{
	// Token: 0x02000033 RID: 51
	public class ConditionCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.IFilterCondition>, global::Infragistics.IFilterCondition, global::System.ComponentModel.INotifyPropertyChanged, global::Infragistics.IGroupFilterConditions, global::Infragistics.IExpressConditions, global::Infragistics.IProvidePersistenceLookupKeys
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000D5FA File Offset: 0x0000B7FA
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0000D604 File Offset: 0x0000B804
		public global::Infragistics.IRecordFilter Parent
		{
			get
			{
				return this._parent;
			}
			set
			{
				if (this._parent != value)
				{
					this._parent = value;
					foreach (global::Infragistics.IFilterCondition filterCondition in this.Items)
					{
						filterCondition.Parent = value;
					}
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000D664 File Offset: 0x0000B864
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0000D66C File Offset: 0x0000B86C
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

		// Token: 0x06000254 RID: 596 RVA: 0x0000D689 File Offset: 0x0000B889
		private void Item_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnCollectionItemChanged();
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000D694 File Offset: 0x0000B894
		protected override bool RemoveItem(int index)
		{
			this.Items[index].Parent = null;
			this.Items[index].PropertyChanged -= this.Item_PropertyChanged;
			this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, this.Items[index], index));
			return base.RemoveItem(index);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000D6F0 File Offset: 0x0000B8F0
		protected internal bool RemoveItemSilently(global::Infragistics.IFilterCondition item)
		{
			int num = this.Items.IndexOf(item);
			if (num != -1)
			{
				item.Parent = null;
				item.PropertyChanged -= this.Item_PropertyChanged;
				base.RemoveItemSilently(num);
			}
			return false;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000D730 File Offset: 0x0000B930
		protected override void AddItem(int index, global::Infragistics.IFilterCondition item)
		{
			base.AddItemSilently(index, item);
			item.Parent = this.Parent;
			item.PropertyChanged += this.Item_PropertyChanged;
			this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, item, index));
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000D768 File Offset: 0x0000B968
		protected override void ResetItems()
		{
			foreach (global::Infragistics.IFilterCondition filterCondition in this.Items)
			{
				filterCondition.PropertyChanged -= this.Item_PropertyChanged;
			}
			this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			base.ResetItems();
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000D7D4 File Offset: 0x0000B9D4
		protected override void InsertItem(int index, global::Infragistics.IFilterCondition item)
		{
			this.AddItem(index, item);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
		protected override void ResetItemsSilently()
		{
			foreach (global::Infragistics.IFilterCondition filterCondition in this.Items)
			{
				filterCondition.PropertyChanged -= this.Item_PropertyChanged;
			}
			base.ResetItemsSilently();
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000D840 File Offset: 0x0000BA40
		protected virtual global::System.Linq.Expressions.Expression GetCurrentExpression()
		{
			if (this.Parent != null)
			{
				global::Infragistics.FilterContext context = global::Infragistics.FilterContext.CreateGenericFilter(this.Parent.ObjectTypedInfo, this.Parent.FieldType, false, false);
				return this.GetCurrentExpression(context);
			}
			return null;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000D87C File Offset: 0x0000BA7C
		protected virtual global::System.Linq.Expressions.Expression GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			return context.CreateExpression(this);
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000D885 File Offset: 0x0000BA85
		// (set) Token: 0x0600025E RID: 606 RVA: 0x0000D88D File Offset: 0x0000BA8D
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

		// Token: 0x0600025F RID: 607 RVA: 0x0000D896 File Offset: 0x0000BA96
		global::System.Linq.Expressions.Expression global::Infragistics.IExpressConditions.GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			return this.GetCurrentExpression(context);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000D89F File Offset: 0x0000BA9F
		global::System.Linq.Expressions.Expression global::Infragistics.IExpressConditions.GetCurrentExpression()
		{
			return this.GetCurrentExpression();
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0000D8A7 File Offset: 0x0000BAA7
		global::Infragistics.LogicalOperator global::Infragistics.IGroupFilterConditions.LogicalOperator
		{
			get
			{
				return this.LogicalOperator;
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000262 RID: 610 RVA: 0x0000D8B0 File Offset: 0x0000BAB0
		// (remove) Token: 0x06000263 RID: 611 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
		public event global::System.EventHandler<global::System.EventArgs> CollectionItemChanged;

		// Token: 0x06000264 RID: 612 RVA: 0x0000D91D File Offset: 0x0000BB1D
		protected virtual void OnCollectionItemChanged()
		{
			if (this.CollectionItemChanged != null)
			{
				this.CollectionItemChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000D938 File Offset: 0x0000BB38
		protected new virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000266 RID: 614 RVA: 0x0000D954 File Offset: 0x0000BB54
		// (remove) Token: 0x06000267 RID: 615 RVA: 0x0000D98C File Offset: 0x0000BB8C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000268 RID: 616 RVA: 0x0000D9C1 File Offset: 0x0000BBC1
		protected internal void ClearSilently()
		{
			this.ResetItemsSilently();
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000D9C9 File Offset: 0x0000BBC9
		protected internal void AddItemSilently(global::Infragistics.IFilterCondition item)
		{
			base.AddItemSilently(this.Items.Count, item);
			item.Parent = this.Parent;
			item.PropertyChanged += this.Item_PropertyChanged;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000D9FC File Offset: 0x0000BBFC
		protected virtual global::System.Collections.ObjectModel.Collection<string> GetLookupKeys()
		{
			return new global::System.Collections.ObjectModel.Collection<string>
			{
				this.LogicalOperator.ToString()
			};
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000DA26 File Offset: 0x0000BC26
		protected virtual bool CanRehydrate(global::System.Collections.ObjectModel.Collection<string> lookupKeys)
		{
			if (lookupKeys.Count > 0)
			{
				this.LogicalOperator = (global::Infragistics.LogicalOperator)global::System.Enum.Parse(typeof(global::Infragistics.LogicalOperator), lookupKeys[0], true);
			}
			return false;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000DA54 File Offset: 0x0000BC54
		global::System.Collections.ObjectModel.Collection<string> global::Infragistics.IProvidePersistenceLookupKeys.GetLookupKeys()
		{
			return this.GetLookupKeys();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000DA5C File Offset: 0x0000BC5C
		bool global::Infragistics.IProvidePersistenceLookupKeys.CanRehydrate(global::System.Collections.ObjectModel.Collection<string> lookupKeys)
		{
			return this.CanRehydrate(lookupKeys);
		}

		// Token: 0x040000FB RID: 251
		private global::Infragistics.IRecordFilter _parent;

		// Token: 0x040000FC RID: 252
		private global::Infragistics.LogicalOperator _logicalOperator;
	}
}
