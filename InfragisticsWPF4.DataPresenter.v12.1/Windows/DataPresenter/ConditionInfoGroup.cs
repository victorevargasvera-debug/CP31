using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000138 RID: 312
	internal class ConditionInfoGroup : global::Infragistics.Windows.DataPresenter.ConditionInfo
	{
		// Token: 0x06001105 RID: 4357 RVA: 0x0004A4AD File Offset: 0x000486AD
		internal ConditionInfoGroup(global::Infragistics.Windows.DataPresenter.ConditionInfoGroup parentGroup, global::Infragistics.Windows.Controls.LogicalOperator logicalOperator)
		{
			base.Group = parentGroup;
			this.LogicalOperator = logicalOperator;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0004A4C4 File Offset: 0x000486C4
		public override string ToString()
		{
			return string.Format("Level: {0}, LogicalOperator: {1}, ParentGroup: <<<{2}>>>, ChildConditionCount: {3}", new object[]
			{
				this.Level.ToString(),
				this.LogicalOperator.ToString(),
				(base.Group == null) ? "??" : base.Group.ToString(),
				this.ChildConditions.Count.ToString()
			});
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x0004A53C File Offset: 0x0004873C
		internal int Level
		{
			get
			{
				int num = 0;
				for (global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group = base.Group; group != null; group = group.Group)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0004A563 File Offset: 0x00048763
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x0004A56B File Offset: 0x0004876B
		internal global::Infragistics.Windows.Controls.LogicalOperator LogicalOperator { get; set; }

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x0004A574 File Offset: 0x00048774
		internal global::Infragistics.Windows.DataPresenter.ConditionInfoCollection ChildConditions
		{
			get
			{
				if (this._childConditions == null)
				{
					this._childConditions = new global::Infragistics.Windows.DataPresenter.ConditionInfoCollection(new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo>(5));
					this._childConditions.CollectionChanged += this.OnChildConditionsCollectionChanged;
				}
				return this._childConditions;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x0004A5AC File Offset: 0x000487AC
		internal bool ContainsOneGroupAndNoConditions
		{
			get
			{
				int num = 0;
				bool flag = false;
				foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo in this.ChildConditions)
				{
					if (!(conditionInfo is global::Infragistics.Windows.DataPresenter.ConditionInfoGroup))
					{
						flag = true;
						break;
					}
					num++;
				}
				return num == 1 && !flag;
			}
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0004A614 File Offset: 0x00048814
		internal global::Infragistics.Windows.DataPresenter.ConditionInfoGroup GetParentGroupAtLevel(int level)
		{
			for (global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group = base.Group; group != null; group = group.Group)
			{
				if (group.Level == level)
				{
					return group;
				}
			}
			return null;
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0004A640 File Offset: 0x00048840
		private void OnChildConditionsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo = (global::Infragistics.Windows.DataPresenter.ConditionInfo)obj;
						conditionInfo.Group = this;
					}
					return;
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				goto IL_A3;
			default:
				return;
			}
			using (global::System.Collections.IEnumerator enumerator2 = e.OldItems.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo2 = (global::Infragistics.Windows.DataPresenter.ConditionInfo)obj2;
					conditionInfo2.Group = null;
				}
				return;
			}
			IL_A3:
			foreach (object obj3 in e.OldItems)
			{
				global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo3 = (global::Infragistics.Windows.DataPresenter.ConditionInfo)obj3;
				conditionInfo3.Group = this;
			}
		}

		// Token: 0x040006BA RID: 1722
		private global::Infragistics.Windows.DataPresenter.ConditionInfoCollection _childConditions;
	}
}
