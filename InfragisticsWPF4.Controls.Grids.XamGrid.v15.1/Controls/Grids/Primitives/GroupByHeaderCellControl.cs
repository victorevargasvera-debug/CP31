using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000217 RID: 535
	[global::System.Windows.TemplateVisualState(GroupName = "FirstStates", Name = "NotFirst")]
	[global::System.Windows.TemplateVisualState(GroupName = "FirstStates", Name = "First")]
	[global::System.Windows.TemplateVisualState(GroupName = "LastStates", Name = "NotLast")]
	[global::System.Windows.TemplateVisualState(GroupName = "LastStates", Name = "Last")]
	public class GroupByHeaderCellControl : global::Infragistics.Controls.Grids.Primitives.HeaderCellControl
	{
		// Token: 0x06000F2D RID: 3885 RVA: 0x0003A225 File Offset: 0x00038425
		public GroupByHeaderCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl);
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x0003A23D File Offset: 0x0003843D
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x0003A245 File Offset: 0x00038445
		public bool IsFirst
		{
			get
			{
				return this._isFirst;
			}
			set
			{
				this._isFirst = value;
				if (this._isFirst)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "First", false);
					return;
				}
				global::System.Windows.VisualStateManager.GoToState(this, "NotFirst", false);
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x0003A271 File Offset: 0x00038471
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x0003A279 File Offset: 0x00038479
		public bool IsLast
		{
			get
			{
				return this._isLast;
			}
			set
			{
				this._isLast = value;
				if (this._isLast)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "Last", false);
					return;
				}
				global::System.Windows.VisualStateManager.GoToState(this, "NotLast", false);
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0003A2A8 File Offset: 0x000384A8
		public void UpdateState()
		{
			global::Infragistics.Controls.Grids.Column column = this.ResolveColumn();
			if (column != null)
			{
				if (column.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Ascending)
				{
					base.GoToState("Ascending", false);
					return;
				}
				if (column.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Descending)
				{
					base.GoToState("Descending", false);
					return;
				}
				base.GoToState("NotSorted", false);
			}
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0003A2FA File Offset: 0x000384FA
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			if (base.Cell != null)
			{
				base.GoToState(base.Cell.MouseOverState, true);
			}
			base.OnMouseEnter(e);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0003A31E File Offset: 0x0003851E
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			if (base.Cell != null)
			{
				base.GoToState(base.Cell.NormalState, false);
			}
			base.OnMouseLeave(e);
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0003A342 File Offset: 0x00038542
		protected override void OnLoaded()
		{
			this.UpdateState();
			base.OnLoaded();
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0003A350 File Offset: 0x00038550
		protected override void OnMouseLeftButtonUpColumnMoving(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!base.IsDragging)
			{
				this.BaseMouseLeftButtonUpColumnMoving(e);
				return;
			}
			if (!(base.GetCellControlFromPoint(e.GetPosition(base.Cell.Row.ColumnLayout.Grid), typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl), false) is global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl))
			{
				this.ResolveColumn().IsGroupBy = false;
				base.Cell.Row.ColumnLayout.Grid.OnColumnDragCanceled(this.ResolveColumn(), global::Infragistics.Controls.Grids.DragCancelType.ColumnUngrouped);
				this.EndDrag();
				return;
			}
			this.BaseMouseLeftButtonUpColumnMoving(e);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0003A3DD File Offset: 0x000385DD
		private void BaseMouseLeftButtonUpColumnMoving(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUpColumnMoving(e);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0003A3E6 File Offset: 0x000385E6
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase ResolveDropHeader(global::System.Windows.Point rootPoint, global::System.Windows.Rect draggingElementBounds)
		{
			return base.GetCellControlFromPoint(rootPoint, typeof(global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl), true);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0003A3FA File Offset: 0x000385FA
		protected override void ReactToMouseOverDroppableHeader(global::System.Windows.Input.MouseEventArgs e, global::System.Windows.Rect dropHeaderBounds, global::System.Windows.Rect currentHeaderBounds)
		{
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0003A3FC File Offset: 0x000385FC
		protected override global::Infragistics.Controls.Grids.Column ResolveColumn()
		{
			if (base.Cell != null)
			{
				return ((global::Infragistics.Controls.Grids.RowsManager)base.Cell.Row.Manager).GroupedColumn;
			}
			return null;
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0003A424 File Offset: 0x00038624
		protected override global::Infragistics.Controls.Grids.Primitives.HeaderCellControl GenerateDragHeader()
		{
			global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl groupByHeaderCellControl = new global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl();
			groupByHeaderCellControl.OnAttached(base.Cell);
			groupByHeaderCellControl.IsFirst = this.IsFirst;
			groupByHeaderCellControl.IsLast = this.IsLast;
			return groupByHeaderCellControl;
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0003A45C File Offset: 0x0003865C
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.IsFirst = this.IsFirst;
			this.IsLast = this.IsLast;
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0003A47C File Offset: 0x0003867C
		protected override void MarkColumnAsMoving()
		{
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x0003A47E File Offset: 0x0003867E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::System.Windows.Controls.Primitives.Popup Indicator
		{
			get
			{
				if (base.Cell != null)
				{
					return base.Cell.Row.ColumnLayout.GroupBySettings.IndicatorContainer;
				}
				return null;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x0003A4A4 File Offset: 0x000386A4
		protected override bool ValidateWidthInArrange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0003A4A8 File Offset: 0x000386A8
		protected internal override void EnsureContent()
		{
			global::Infragistics.Controls.Grids.Column column = this.ResolveColumn();
			if (column != null)
			{
				base.EnsureContent();
				if (column.DataField.GroupName != null)
				{
					base.Content = column.DataField.GroupName;
				}
			}
		}

		// Token: 0x040004DB RID: 1243
		private bool _isFirst;

		// Token: 0x040004DC RID: 1244
		private bool _isLast;
	}
}
