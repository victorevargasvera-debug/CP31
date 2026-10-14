using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000154 RID: 340
	internal class ConditionInfoGroup : global::Infragistics.Windows.DataPresenter.ConditionInfo
	{
		// Token: 0x0600146E RID: 5230 RVA: 0x0005B7A9 File Offset: 0x000599A9
		internal ConditionInfoGroup(global::Infragistics.Windows.DataPresenter.ConditionInfoGroup parentGroup, global::Infragistics.Windows.Controls.LogicalOperator logicalOperator)
		{
			base.Group = parentGroup;
			this.LogicalOperator = logicalOperator;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0005B7C0 File Offset: 0x000599C0
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

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x0005B838 File Offset: 0x00059A38
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

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0005B85F File Offset: 0x00059A5F
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x0005B867 File Offset: 0x00059A67
		internal global::Infragistics.Windows.Controls.LogicalOperator LogicalOperator { get; set; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0005B870 File Offset: 0x00059A70
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

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x0005B8A8 File Offset: 0x00059AA8
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

		// Token: 0x06001475 RID: 5237 RVA: 0x0005B910 File Offset: 0x00059B10
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

		// Token: 0x06001476 RID: 5238 RVA: 0x0005B93C File Offset: 0x00059B3C
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

		// Token: 0x04000860 RID: 2144
		private global::Infragistics.Windows.DataPresenter.ConditionInfoCollection _childConditions;
	}
}
