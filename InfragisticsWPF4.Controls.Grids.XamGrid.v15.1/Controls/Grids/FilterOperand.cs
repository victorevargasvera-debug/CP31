using System;
using System.Linq.Expressions;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000090 RID: 144
	public abstract class FilterOperand
	{
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0001B328 File Offset: 0x00019528
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0001B33F File Offset: 0x0001953F
		public virtual string DisplayName
		{
			get
			{
				if (this._displayName == null)
				{
					return this.DefaultDisplayName;
				}
				return this._displayName;
			}
			set
			{
				this._displayName = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0001B348 File Offset: 0x00019548
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x0001B350 File Offset: 0x00019550
		public global::System.Windows.DataTemplate Icon { get; set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0001B35C File Offset: 0x0001955C
		public global::System.Windows.DataTemplate IconResolved
		{
			get
			{
				if (this.Icon != null)
				{
					return this.Icon;
				}
				if (this.XamWebGrid != null && this.ComparisonOperatorValue != null)
				{
					global::Infragistics.ComparisonOperator value = this.ComparisonOperatorValue.Value;
					if (this.XamWebGrid.FilterIcons.ContainsKey(value))
					{
						return this.XamWebGrid.FilterIcons[value];
					}
				}
				return null;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0001B3C5 File Offset: 0x000195C5
		public virtual bool RequiresFilteringInput
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0001B3C8 File Offset: 0x000195C8
		protected virtual string DefaultDisplayName
		{
			get
			{
				return "";
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0001B3D0 File Offset: 0x000195D0
		protected internal virtual string DisplayNameWithInputFormat
		{
			get
			{
				if (this.ComparisonOperatorValue != null)
				{
					string @string = global::SR.GetString(this.ComparisonOperatorValue.Value + "WithInput");
					if (@string != null)
					{
						return @string;
					}
				}
				if (!this.RequiresFilteringInput)
				{
					return this.DisplayName;
				}
				return this.DisplayName + " '{0}'";
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0001B434 File Offset: 0x00019634
		public virtual global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0001B44A File Offset: 0x0001964A
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0001B473 File Offset: 0x00019673
		internal global::Infragistics.Controls.Grids.XamGrid XamWebGrid
		{
			get
			{
				if (this._grid != null && this._grid.IsAlive)
				{
					return (global::Infragistics.Controls.Grids.XamGrid)this._grid.Target;
				}
				return null;
			}
			set
			{
				if (this._grid == null || this._grid.Target != value)
				{
					if (value != null)
					{
						this._grid = new global::System.WeakReference(value);
						return;
					}
					this._grid = null;
				}
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0001B4A2 File Offset: 0x000196A2
		public virtual global::System.Linq.Expressions.Expression FilteringExpression(object value)
		{
			return null;
		}

		// Token: 0x0400017B RID: 379
		private string _displayName;

		// Token: 0x0400017C RID: 380
		private global::System.WeakReference _grid;
	}
}
