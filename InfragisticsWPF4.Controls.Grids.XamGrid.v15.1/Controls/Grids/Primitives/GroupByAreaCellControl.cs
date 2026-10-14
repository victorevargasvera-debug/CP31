using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000210 RID: 528
	[global::System.Windows.TemplateVisualState(GroupName = "DraggingStates", Name = "DraggingOver")]
	[global::System.Windows.TemplateVisualState(GroupName = "ExpansionStates", Name = "Expanded")]
	[global::System.Windows.TemplatePart(Name = "Panel", Type = typeof(global::System.Windows.Controls.Panel))]
	[global::System.Windows.TemplateVisualState(GroupName = "DisplayStates", Name = "Empty")]
	[global::System.Windows.TemplateVisualState(GroupName = "DisplayStates", Name = "NonEmpty")]
	[global::System.Windows.TemplateVisualState(GroupName = "DraggingStates", Name = "NotDragging")]
	[global::System.Windows.TemplateVisualState(GroupName = "DraggingStates", Name = "Dragging")]
	[global::System.Windows.TemplateVisualState(GroupName = "GroupByAreaLocation", Name = "Bottom")]
	[global::System.Windows.TemplateVisualState(GroupName = "ExpansionStates", Name = "Collapsed")]
	[global::System.Windows.TemplateVisualState(GroupName = "GroupByAreaLocation", Name = "Top")]
	public class GroupByAreaCellControl : global::Infragistics.Controls.Grids.Primitives.CellControlBase, global::Infragistics.ICommandTarget
	{
		// Token: 0x06000EFC RID: 3836 RVA: 0x00038CF4 File Offset: 0x00036EF4
		static GroupByAreaCellControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00038DB0 File Offset: 0x00036FB0
		public GroupByAreaCellControl()
		{
			this._groupedColumns = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Column>();
			this._isDesignTime = global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x00038DCF File Offset: 0x00036FCF
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x00038DDC File Offset: 0x00036FDC
		public object EmptyContent
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl.EmptyContentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl.EmptyContentProperty, value);
			}
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00038DEA File Offset: 0x00036FEA
		private static void EmptyContentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00038DEC File Offset: 0x00036FEC
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00038DFE File Offset: 0x00036FFE
		public bool IsExpanded
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl.IsExpandedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl.IsExpandedProperty, value);
			}
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00038E14 File Offset: 0x00037014
		private static void IsExpandedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl groupByAreaCellControl = (global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl)obj;
			global::Infragistics.Controls.Grids.CellBase cell = groupByAreaCellControl.Cell;
			if (cell != null)
			{
				groupByAreaCellControl.Cell.Row.ColumnLayout.Grid.GroupBySettings.IsGroupByAreaExpanded = (bool)e.NewValue;
				groupByAreaCellControl.Cell.Row.ColumnLayout.Grid.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00038E78 File Offset: 0x00037078
		public override void OnApplyTemplate()
		{
			this._panel = (base.GetTemplateChild("Panel") as global::System.Windows.Controls.Panel);
			this.EnsureContent();
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00038E96 File Offset: 0x00037096
		protected internal override void OnAttached(global::Infragistics.Controls.Grids.CellBase cell)
		{
			base.OnAttached(cell);
			this.IsExpanded = cell.Row.ColumnLayout.Grid.GroupBySettings.IsGroupByAreaExpanded;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00038EC0 File Offset: 0x000370C0
		protected internal override void EnsureContent()
		{
			base.EnsureContent();
			if (this._panel != null && base.Cell != null)
			{
				global::Infragistics.Controls.Grids.XamGrid grid = base.Cell.Row.ColumnLayout.Grid;
				global::Infragistics.Controls.Grids.GroupByColumnsCollection groupByColumns = grid.GroupBySettings.GroupByColumns;
				if (grid.GroupBySettings.AllowGroupByArea == global::Infragistics.Controls.Grids.GroupByAreaLocation.Bottom)
				{
					base.GoToState("Bottom", false);
				}
				else
				{
					base.GoToState("Top", true);
				}
				bool isGroupByAreaExpanded = grid.GroupBySettings.IsGroupByAreaExpanded;
				if (!this._isDesignTime)
				{
					this.IsExpanded = isGroupByAreaExpanded;
				}
				if (grid.GroupBySettings.ExpansionIndicatorVisibility == global::System.Windows.Visibility.Visible)
				{
					base.GoToState("ExpansionVisible", false);
					if (isGroupByAreaExpanded)
					{
						base.GoToState("Expanded", true);
					}
					else
					{
						base.GoToState("Collapsed", true);
						base.Cell.Row.ActualHeight = 0.0;
					}
				}
				else
				{
					base.GoToState("Expanded", true);
					base.GoToState("ExpansionHidden", false);
				}
				this.EmptyContent = grid.GroupBySettings.EmptyGroupByAreaContent;
				if (groupByColumns.Count == 0)
				{
					base.GoToState("Empty", false);
				}
				else
				{
					base.GoToState("NonEmpty", false);
				}
				if (this._gbcDirtyFlag != groupByColumns.DirtyFlag)
				{
					this._gbcDirtyFlag = groupByColumns.DirtyFlag;
					base.Cell.Row.ActualHeight = 0.0;
					this._panel.Children.Clear();
					this._groupedColumns.Clear();
					foreach (global::Infragistics.Controls.Grids.Column column in groupByColumns)
					{
						global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection = groupByColumns[column.ColumnLayout];
						global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl groupByHeaderCellControl = new global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl();
						global::Infragistics.Controls.Grids.RowsManager rowsManager = new global::Infragistics.Controls.Grids.RowsManager(0, column.ColumnLayout, null)
						{
							GroupedColumn = column
						};
						rowsManager.UnregisterRowsManager(false, false, false);
						groupByHeaderCellControl.OnAttached(new global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCell(new global::Infragistics.Controls.Grids.Row(0, rowsManager, null), rowsManager.GroupByColumn));
						groupByHeaderCellControl.Cell.Control = groupByHeaderCellControl;
						global::Infragistics.Controls.Grids.ColumnLayout columnLayout = column.ColumnLayout;
						int num = readOnlyCollection.IndexOf(column);
						string key = columnLayout.Key;
						int level = columnLayout.Level;
						if (level > 0)
						{
							if (num == 0)
							{
								global::Infragistics.Controls.Grids.Primitives.GroupByColumnLayoutHeaderCellControl groupByColumnLayoutHeaderCellControl = new global::Infragistics.Controls.Grids.Primitives.GroupByColumnLayoutHeaderCellControl();
								groupByColumnLayoutHeaderCellControl.OnAttached(new global::Infragistics.Controls.Grids.Primitives.GroupByColumnLayoutHeaderCell(new global::Infragistics.Controls.Grids.Row(0, rowsManager, null), new global::Infragistics.Controls.Grids.Primitives.GroupByColumn
								{
									IsMovable = false
								}));
								groupByColumnLayoutHeaderCellControl.Cell.Control = groupByColumnLayoutHeaderCellControl;
								global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.SetIndex(groupByColumnLayoutHeaderCellControl, 0);
								global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.SetLevel(groupByColumnLayoutHeaderCellControl, level);
								global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.SetLevelKey(groupByColumnLayoutHeaderCellControl, key);
								this._panel.Children.Add(groupByColumnLayoutHeaderCellControl);
							}
							num++;
						}
						global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.SetIndex(groupByHeaderCellControl, num);
						global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.SetLevel(groupByHeaderCellControl, level);
						global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.SetLevelKey(groupByHeaderCellControl, key);
						this._panel.Children.Add(groupByHeaderCellControl);
						this._groupedColumns.Add(column);
					}
				}
				this._panel.InvalidateMeasure();
			}
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000391D4 File Offset: 0x000373D4
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.Primitives.GroupByAreaCommandBase;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x000391DF File Offset: 0x000373DF
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this;
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x000391E2 File Offset: 0x000373E2
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x000391EB File Offset: 0x000373EB
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x040004CD RID: 1229
		private global::System.Windows.Controls.Panel _panel;

		// Token: 0x040004CE RID: 1230
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Column> _groupedColumns;

		// Token: 0x040004CF RID: 1231
		private int _gbcDirtyFlag;

		// Token: 0x040004D0 RID: 1232
		private bool _isDesignTime;

		// Token: 0x040004D1 RID: 1233
		public static readonly global::System.Windows.DependencyProperty EmptyContentProperty = global::System.Windows.DependencyProperty.Register("EmptyContent", typeof(object), typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl.EmptyContentChanged)));

		// Token: 0x040004D2 RID: 1234
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty = global::System.Windows.DependencyProperty.Register("IsExpanded", typeof(bool), typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl.IsExpandedChanged)));
	}
}
