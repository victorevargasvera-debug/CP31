using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000226 RID: 550
	[global::System.Windows.TemplateVisualState(GroupName = "Orientation", Name = "Top")]
	[global::System.Windows.TemplateVisualState(GroupName = "Orientation", Name = "Bottom")]
	[global::System.Windows.TemplatePart(Name = "PagerItemControl", Type = typeof(global::Infragistics.Controls.Grids.Primitives.PagerControlBase))]
	public class PagerCellControl : global::Infragistics.Controls.Grids.Primitives.CellControlBase, global::Infragistics.ICommandTarget
	{
		// Token: 0x06000F81 RID: 3969 RVA: 0x0003AF1C File Offset: 0x0003911C
		static PagerCellControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.PagerCellControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.PagerCellControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.PagerCellControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0003AF72 File Offset: 0x00039172
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._pagerControl = (base.GetTemplateChild("PagerItemControl") as global::Infragistics.Controls.Grids.Primitives.PagerControlBase);
			this.PopulatePagerControlValues();
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0003AF96 File Offset: 0x00039196
		protected override void AttachContent()
		{
			this.EnsureContent();
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0003AFA0 File Offset: 0x000391A0
		protected internal void PopulatePagerControlValues()
		{
			if (this._pagerControl != null && base.Cell != null)
			{
				global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)base.Cell.Row.Manager;
				this._pagerControl.SetCurrentPageIndexSilent(rowsManager.CurrentPageIndex);
				this._pagerControl.SetRowsManagerMaximumPagesSilent(rowsManager.PageCount);
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0003AFF8 File Offset: 0x000391F8
		protected internal override void OnAttached(global::Infragistics.Controls.Grids.CellBase cell)
		{
			base.OnAttached(cell);
			global::Infragistics.Controls.Grids.RowsManager rowsManager = base.Cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager != null)
			{
				global::Infragistics.IPagedCollectionView pagedCollectionView = rowsManager.ItemsSource as global::Infragistics.IPagedCollectionView;
				if (pagedCollectionView != null)
				{
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
					binding.Path = new global::System.Windows.PropertyPath("CanChangePage", new object[0]);
					binding.Source = pagedCollectionView;
					base.SetBinding(global::System.Windows.UIElement.IsEnabledProperty, binding);
				}
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0003B064 File Offset: 0x00039264
		protected internal override void OnReleased(global::Infragistics.Controls.Grids.CellBase cell)
		{
			base.OnReleased(cell);
			base.ClearValue(global::System.Windows.UIElement.IsEnabledProperty);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0003B078 File Offset: 0x00039278
		protected internal override void EnsureContent()
		{
			base.EnsureContent();
			this.PopulatePagerControlValues();
			if (this._pagerControl != null)
			{
				this._pagerControl.EnsureContent();
			}
			global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)base.Cell.Row.Manager;
			if (-1 != rowsManager.RegisteredBottomRows.IndexOf(base.Cell.Row))
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Bottom", true);
				return;
			}
			if (-1 != rowsManager.RegisteredTopRows.IndexOf(base.Cell.Row))
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Top", true);
			}
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0003B107 File Offset: 0x00039307
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0003B110 File Offset: 0x00039310
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0003B119 File Offset: 0x00039319
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.Primitives.PagingBaseCommand;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0003B124 File Offset: 0x00039324
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			if (source.Command is global::Infragistics.Controls.Grids.Primitives.GoToPageCommand)
			{
				if (source.Parameter != null)
				{
					return new object[]
					{
						base.Cell.Row.Manager,
						source.Parameter
					};
				}
				global::Infragistics.Controls.Grids.Primitives.PagingEventArgs pagingEventArgs = source.OriginEventArgs as global::Infragistics.Controls.Grids.Primitives.PagingEventArgs;
				if (pagingEventArgs != null)
				{
					return new object[]
					{
						base.Cell.Row.Manager,
						pagingEventArgs.NextPage
					};
				}
			}
			return base.Cell.Row.Manager;
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x0003B1B4 File Offset: 0x000393B4
		protected internal global::Infragistics.Controls.Grids.Primitives.PagerControlBase PagerControl
		{
			get
			{
				return this._pagerControl;
			}
		}

		// Token: 0x040004E5 RID: 1253
		private global::Infragistics.Controls.Grids.Primitives.PagerControlBase _pagerControl;
	}
}
