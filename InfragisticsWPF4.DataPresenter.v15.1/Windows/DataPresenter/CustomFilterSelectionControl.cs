using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200014D RID: 333
	[global::System.Windows.TemplatePart(Name = "PART_ConditionsGrid", Type = typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CustomFilterSelectionControl : global::System.Windows.Controls.Control
	{
		// Token: 0x060013E3 RID: 5091 RVA: 0x00058030 File Offset: 0x00056230
		static CustomFilterSelectionControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.AddConditionCommand = new global::System.Windows.Input.RoutedCommand("AddCondition", typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl));
			global::System.Windows.Input.CommandBinding commandBinding = new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.AddConditionCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ExecuteCommandHandler), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CanExecuteCommandHandler));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), commandBinding);
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelChangesCommand = new global::System.Windows.Input.RoutedCommand("CancelChanges", typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl));
			global::System.Windows.Input.CommandBinding commandBinding2 = new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelChangesCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ExecuteCommandHandler), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CanExecuteCommandHandler));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), commandBinding2);
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CommitChangesCommand = new global::System.Windows.Input.RoutedCommand("CommitChanges", typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl));
			global::System.Windows.Input.CommandBinding commandBinding3 = new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CommitChangesCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ExecuteCommandHandler), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CanExecuteCommandHandler));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), commandBinding3);
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsAndGroupCommand = new global::System.Windows.Input.RoutedCommand("GroupSelectedConditionsAsAndGroup", typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl));
			global::System.Windows.Input.CommandBinding commandBinding4 = new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsAndGroupCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ExecuteCommandHandler), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CanExecuteCommandHandler));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), commandBinding4);
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsOrGroupCommand = new global::System.Windows.Input.RoutedCommand("GroupSelectedConditionsAsOrGroup", typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl));
			global::System.Windows.Input.CommandBinding commandBinding5 = new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsOrGroupCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ExecuteCommandHandler), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CanExecuteCommandHandler));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), commandBinding5);
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RemoveSelectedConditionsCommand = new global::System.Windows.Input.RoutedCommand("RemoveSelectedConditions", typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl));
			global::System.Windows.Input.CommandBinding commandBinding6 = new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RemoveSelectedConditionsCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ExecuteCommandHandler), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CanExecuteCommandHandler));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), commandBinding6);
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ToggleSelectedGroupLogicalOperatorCommand = new global::System.Windows.Input.RoutedCommand("ToggleSelectedGroupLogicalOperator", typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl));
			global::System.Windows.Input.CommandBinding commandBinding7 = new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ToggleSelectedGroupLogicalOperatorCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ExecuteCommandHandler), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CanExecuteCommandHandler));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), commandBinding7);
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.UngroupSelectedConditionsCommand = new global::System.Windows.Input.RoutedCommand("UngroupSelectedConditionsAsAndGroup", typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl));
			global::System.Windows.Input.CommandBinding commandBinding8 = new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.UngroupSelectedConditionsCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ExecuteCommandHandler), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CanExecuteCommandHandler));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), commandBinding8);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x000586AC File Offset: 0x000568AC
		public CustomFilterSelectionControl()
		{
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.SetControl(this, this);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x000586BB File Offset: 0x000568BB
		public CustomFilterSelectionControl(global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter, global::Infragistics.Windows.DataPresenter.RecordManager recordManager) : this()
		{
			this.Initialize(recordFilter, recordManager);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x000586CC File Offset: 0x000568CC
		private static void CanExecuteCommandHandler(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl customFilterSelectionControl = sender as global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl;
			e.CanExecute = false;
			if (customFilterSelectionControl != null)
			{
				if (e.Command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.AddConditionCommand)
				{
					e.CanExecute = true;
					return;
				}
				if (e.Command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RemoveSelectedConditionsCommand)
				{
					e.CanExecute = (customFilterSelectionControl._conditionsGrid != null && (customFilterSelectionControl._conditionsGrid.SelectedItems.Records.Count > 0 || customFilterSelectionControl._conditionsGrid.ActiveRecord != null));
					return;
				}
				if (e.Command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsAndGroupCommand || e.Command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsOrGroupCommand)
				{
					e.CanExecute = (customFilterSelectionControl._currentSelectionCanBeGrouped && !customFilterSelectionControl.IsConditionInEditMode);
					return;
				}
				if (e.Command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.UngroupSelectedConditionsCommand)
				{
					e.CanExecute = (customFilterSelectionControl._currentSelectionCanBeUngrouped && !customFilterSelectionControl.IsConditionInEditMode);
					return;
				}
				if (e.Command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelChangesCommand)
				{
					e.CanExecute = true;
					return;
				}
				if (e.Command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CommitChangesCommand)
				{
					e.CanExecute = (customFilterSelectionControl._conditionInfos != null && customFilterSelectionControl._isDirty);
					return;
				}
				if (e.Command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ToggleSelectedGroupLogicalOperatorCommand)
				{
					e.CanExecute = (customFilterSelectionControl._conditionsGrid != null && (customFilterSelectionControl._conditionsGrid.SelectedItems.Records.Count > 0 || customFilterSelectionControl._conditionsGrid.ActiveRecord != null) && !customFilterSelectionControl._currentSelectionSpansMultipleGroups);
				}
			}
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00058830 File Offset: 0x00056A30
		private static void ExecuteCommandHandler(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl customFilterSelectionControl = sender as global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl;
			if (customFilterSelectionControl != null)
			{
				customFilterSelectionControl.ExecuteCommandImpl(e.Command as global::System.Windows.Input.RoutedCommand, e.Parameter, e.Source, e.OriginalSource);
			}
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0005886C File Offset: 0x00056A6C
		private bool ExecuteCommandImpl(global::System.Windows.Input.RoutedCommand command, object parameter, object source, object originalSource)
		{
			if (command == null)
			{
				throw new global::System.ArgumentNullException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_6"));
			}
			bool result = false;
			if (command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.AddConditionCommand)
			{
				result = this.ExecuteAddConditionCommand(source, originalSource, parameter);
			}
			else if (command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RemoveSelectedConditionsCommand)
			{
				result = this.ExecuteRemoveSelectedConditionsCommand(source, originalSource, parameter);
			}
			else if (command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsAndGroupCommand)
			{
				result = this.ExecuteGroupSelectedConditionsAsAndGroupCommand(source, originalSource, parameter);
			}
			else if (command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsOrGroupCommand)
			{
				result = this.ExecuteGroupSelectedConditionsAsOrGroupCommand(source, originalSource, parameter);
			}
			else if (command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.UngroupSelectedConditionsCommand)
			{
				result = this.ExecuteUngroupSelectedConditionsCommand(source, originalSource, parameter);
			}
			else if (command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelChangesCommand)
			{
				result = this.ExecuteCancelChangesCommand(source, originalSource, parameter);
			}
			else if (command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CommitChangesCommand)
			{
				result = this.ExecuteCommitChangesCommand(source, originalSource, parameter);
			}
			else if (command == global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ToggleSelectedGroupLogicalOperatorCommand)
			{
				result = this.ExecuteToggleSelectedGroupLogicalOperatorCommand(source, originalSource, parameter);
			}
			return result;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00058938 File Offset: 0x00056B38
		private bool ExecuteAddConditionCommand(object source, object originalSource, object parameter)
		{
			if (this.IsConditionInEditMode && !this.TryEndEditMode())
			{
				return true;
			}
			if (this._conditionInfos != null)
			{
				global::Infragistics.Windows.DataPresenter.ConditionInfoGroup conditionInfoGroup = this._rootConditionInfoGroup;
				if (this._currentSelectionCount > 0 && !this._currentSelectionSpansMultipleGroups)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> selectedConditionInfos = this.GetSelectedConditionInfos();
					conditionInfoGroup = selectedConditionInfos[0].Group;
				}
				else if (this._conditionsGrid.ActiveRecord != null)
				{
					global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo = ((global::Infragistics.Windows.DataPresenter.DataRecord)this._conditionsGrid.ActiveRecord).DataItem as global::Infragistics.Windows.DataPresenter.ConditionInfo;
					if (conditionInfo != null)
					{
						conditionInfoGroup = conditionInfo.Group;
					}
				}
				global::Infragistics.Windows.DataPresenter.ConditionInfo item = new global::Infragistics.Windows.DataPresenter.ConditionInfo(conditionInfoGroup, this.RecordFilter.Field.FilterOperatorDefaultValueResolved, string.Empty, null);
				conditionInfoGroup.ChildConditions.Add(item);
				this.UpdateSelectionDependentFlags();
				this.AddRemoveUnboundFieldsUsedAsGroupingIndicators();
				this.RefreshConditionsGrid();
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._conditionsGrid.RecordManager.Unsorted[this._conditionInfos.IndexOf(item)];
				if (dataRecord != null)
				{
					this._conditionsGrid.ActiveCell = dataRecord.Cells["Value"];
					this._conditionsGrid.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.StartEditMode);
				}
				return true;
			}
			return false;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00058A54 File Offset: 0x00056C54
		private bool ExecuteCancelChangesCommand(object source, object originalSource, object parameter)
		{
			if (this._isDirty)
			{
				global::System.Windows.MessageBoxResult messageBoxResult = global::Infragistics.Windows.Utilities.ShowMessageBox(this, this.CancelMessageText, this.CancelMessageTitle, global::System.Windows.MessageBoxButton.YesNo, global::System.Windows.MessageBoxImage.Exclamation);
				if (messageBoxResult == global::System.Windows.MessageBoxResult.No)
				{
					return true;
				}
			}
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this);
			if (toolWindow != null)
			{
				toolWindow.DialogResult = new bool?(false);
			}
			return true;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00058A9C File Offset: 0x00056C9C
		private bool ExecuteCommitChangesCommand(object source, object originalSource, object parameter)
		{
			if (this._tempRootConditionGroup == null || !this._isDirty)
			{
				return false;
			}
			if (this.ConditionsContainErrors)
			{
				global::Infragistics.Windows.Utilities.ShowMessageBox(this, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CustomFilterSelectionControl_ConditionErrorMessageTextProperty"), global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CustomFilterSelectionControl_ConditionErrorMessageTitleProperty"), global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Hand);
				return true;
			}
			global::Infragistics.Windows.DataPresenter.RecordFilter targetRecordFilter = this.GetTargetRecordFilter();
			if (targetRecordFilter != null)
			{
				targetRecordFilter.ApplyNewConditions(this._tempRootConditionGroup);
			}
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this);
			if (toolWindow != null)
			{
				toolWindow.DialogResult = new bool?(true);
			}
			return true;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00058B10 File Offset: 0x00056D10
		private bool ExecuteGroupSelectedConditionsAsAndGroupCommand(object source, object originalSource, object parameter)
		{
			return this.GroupSelectedConditionsHelper(global::Infragistics.Windows.Controls.LogicalOperator.And);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00058B19 File Offset: 0x00056D19
		private bool ExecuteGroupSelectedConditionsAsOrGroupCommand(object source, object originalSource, object parameter)
		{
			return this.GroupSelectedConditionsHelper(global::Infragistics.Windows.Controls.LogicalOperator.Or);
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00058B22 File Offset: 0x00056D22
		private bool ExecuteRemoveSelectedConditionsCommand(object source, object originalSource, object parameter)
		{
			return this.RemoveSelectedConditions();
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00058B2C File Offset: 0x00056D2C
		private bool ExecuteToggleSelectedGroupLogicalOperatorCommand(object source, object originalSource, object parameter)
		{
			if (this._currentSelectionSpansMultipleGroups)
			{
				return false;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> selectedConditionInfos = this.GetSelectedConditionInfos(true);
			if (selectedConditionInfos.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group = selectedConditionInfos[0].Group;
				global::Infragistics.Windows.Controls.LogicalOperator logicalOperator = (group.LogicalOperator == global::Infragistics.Windows.Controls.LogicalOperator.And) ? global::Infragistics.Windows.Controls.LogicalOperator.Or : global::Infragistics.Windows.Controls.LogicalOperator.And;
				group.LogicalOperator = logicalOperator;
				this.RefreshConditionsGrid();
				return true;
			}
			return false;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00058B80 File Offset: 0x00056D80
		private bool ExecuteUngroupSelectedConditionsCommand(object source, object originalSource, object parameter)
		{
			if (!this._currentSelectionCanBeUngrouped)
			{
				return false;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> selectedConditionInfos = this.GetSelectedConditionInfos();
			if (selectedConditionInfos.Count < 1)
			{
				return false;
			}
			foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo in selectedConditionInfos)
			{
				if (conditionInfo.Group.Level >= 1)
				{
					global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group = conditionInfo.Group;
					group.ChildConditions.Remove(conditionInfo);
					group.Group.ChildConditions.Insert(group.Group.ChildConditions.IndexOf(group), conditionInfo);
				}
			}
			this.ProcessConditionInfoGroupForCleanup(this._rootConditionInfoGroup);
			this.UpdateSelectionDependentFlags();
			this.AddRemoveUnboundFieldsUsedAsGroupingIndicators();
			this.RefreshConditionsGrid();
			return true;
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x00058C48 File Offset: 0x00056E48
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				global::System.Collections.IEnumerator logicalChildren = base.LogicalChildren;
				if (logicalChildren != null)
				{
					return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
					{
						base.LogicalChildren,
						new global::Infragistics.Collections.SingleItemEnumerator(this._comparisonOperatorSelector)
					});
				}
				return new global::Infragistics.Collections.SingleItemEnumerator(this._comparisonOperatorSelector);
			}
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00058C90 File Offset: 0x00056E90
		protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.Delete && this._conditionsGrid != null && this._conditionsGrid.ActiveRecord != null && this._conditionsGrid.IsKeyboardFocusWithin && (this._conditionsGrid.ActiveCell == null || !this._conditionsGrid.ActiveCell.IsInEditMode))
			{
				this.RemoveSelectedConditions();
				e.Handled = true;
			}
			base.OnKeyUp(e);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00058CFD File Offset: 0x00056EFD
		public override void OnApplyTemplate()
		{
			this.VerifyParts();
			base.OnApplyTemplate();
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x00058D0B File Offset: 0x00056F0B
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x00058D1D File Offset: 0x00056F1D
		[global::System.ComponentModel.Bindable(true)]
		public string AddConditionLabel
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.AddConditionLabelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.AddConditionLabelProperty, value);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x00058D2B File Offset: 0x00056F2B
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x00058D3D File Offset: 0x00056F3D
		[global::System.ComponentModel.Bindable(true)]
		public string AndGroupLegendDescription
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.AndGroupLegendDescriptionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.AndGroupLegendDescriptionProperty, value);
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x00058D4B File Offset: 0x00056F4B
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x00058D5D File Offset: 0x00056F5D
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.Brush AndLogicalOperatorBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.AndLogicalOperatorBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.AndLogicalOperatorBrushProperty, value);
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x00058D6B File Offset: 0x00056F6B
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x00058D7D File Offset: 0x00056F7D
		[global::System.ComponentModel.Bindable(true)]
		public string CancelButtonLabel
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelButtonLabelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelButtonLabelProperty, value);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x00058D8B File Offset: 0x00056F8B
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x00058D9D File Offset: 0x00056F9D
		[global::System.ComponentModel.Bindable(true)]
		public string CancelMessageText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelMessageTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelMessageTextProperty, value);
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x00058DAB File Offset: 0x00056FAB
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x00058DBD File Offset: 0x00056FBD
		[global::System.ComponentModel.Bindable(true)]
		public string CancelMessageTitle
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelMessageTitleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelMessageTitleProperty, value);
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x00058DCB File Offset: 0x00056FCB
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x00058DDD File Offset: 0x00056FDD
		[global::System.ComponentModel.Bindable(true)]
		public string FieldDescription
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.FieldDescriptionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.FieldDescriptionProperty, value);
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x00058DEB File Offset: 0x00056FEB
		[global::System.ComponentModel.Bindable(true)]
		public string FilterSummaryDescription
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.FilterSummaryDescriptionProperty);
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x00058DFD File Offset: 0x00056FFD
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x00058E0F File Offset: 0x0005700F
		[global::System.ComponentModel.Bindable(true)]
		public string GroupSelectedLabel
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedLabelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedLabelProperty, value);
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x00058E1D File Offset: 0x0005701D
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x00058E2F File Offset: 0x0005702F
		[global::System.ComponentModel.Bindable(true)]
		public string GroupSelectedConditionsAsAndGroupLabel
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsAndGroupLabelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsAndGroupLabelProperty, value);
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x00058E3D File Offset: 0x0005703D
		// (set) Token: 0x06001408 RID: 5128 RVA: 0x00058E4F File Offset: 0x0005704F
		[global::System.ComponentModel.Bindable(true)]
		public string GroupSelectedConditionsAsOrGroupLabel
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsOrGroupLabelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsOrGroupLabelProperty, value);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x00058E5D File Offset: 0x0005705D
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x00058E6F File Offset: 0x0005706F
		[global::System.ComponentModel.Bindable(true)]
		public double LogicalOperatorColumnWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.LogicalOperatorColumnWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.LogicalOperatorColumnWidthProperty, value);
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x00058E82 File Offset: 0x00057082
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x00058E94 File Offset: 0x00057094
		[global::System.ComponentModel.Bindable(true)]
		public string OkButtonLabel
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.OkButtonLabelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.OkButtonLabelProperty, value);
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x00058EA2 File Offset: 0x000570A2
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x00058EB4 File Offset: 0x000570B4
		[global::System.ComponentModel.Bindable(true)]
		public string OrGroupLegendDescription
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.OrGroupLegendDescriptionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.OrGroupLegendDescriptionProperty, value);
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x00058EC2 File Offset: 0x000570C2
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x00058ED4 File Offset: 0x000570D4
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.Brush OrLogicalOperatorBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.OrLogicalOperatorBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.OrLogicalOperatorBrushProperty, value);
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x00058EE2 File Offset: 0x000570E2
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordFilter RecordFilter
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordFilter)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RecordFilterProperty);
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x00058EF4 File Offset: 0x000570F4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordManager)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RecordManagerProperty);
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x00058F06 File Offset: 0x00057106
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x00058F18 File Offset: 0x00057118
		[global::System.ComponentModel.Bindable(true)]
		public string RemoveSelectedConditionsLabel
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RemoveSelectedConditionsLabelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RemoveSelectedConditionsLabelProperty, value);
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x00058F26 File Offset: 0x00057126
		// (set) Token: 0x06001416 RID: 5142 RVA: 0x00058F38 File Offset: 0x00057138
		[global::System.ComponentModel.Bindable(true)]
		public string TitleDescription
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.TitleDescriptionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.TitleDescriptionProperty, value);
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x00058F46 File Offset: 0x00057146
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x00058F58 File Offset: 0x00057158
		[global::System.ComponentModel.Bindable(true)]
		public string ToggleOperatorOfSelectedConditionsLabel
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ToggleOperatorOfSelectedConditionsLabelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ToggleOperatorOfSelectedConditionsLabelProperty, value);
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x00058F66 File Offset: 0x00057166
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x00058F78 File Offset: 0x00057178
		[global::System.ComponentModel.Bindable(true)]
		public string UngroupSelectedConditionsLabel
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.UngroupSelectedConditionsLabelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.UngroupSelectedConditionsLabelProperty, value);
			}
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00058F86 File Offset: 0x00057186
		internal static global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl GetControl(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl)d.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ControlProperty);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00058F98 File Offset: 0x00057198
		internal static void SetControl(global::System.Windows.DependencyObject d, global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl value)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ControlProperty, value);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00058FA8 File Offset: 0x000571A8
		private static void OnControlChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl customFilterSelectionControl = e.NewValue as global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl;
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = d as global::Infragistics.Windows.Editors.XamComboEditor;
			if (customFilterSelectionControl != null && xamComboEditor != null)
			{
				customFilterSelectionControl.InitializeComboEditor(xamComboEditor);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x00058FD6 File Offset: 0x000571D6
		internal bool IsDirty
		{
			get
			{
				return this._isDirty;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x00058FE0 File Offset: 0x000571E0
		private bool ConditionsContainErrors
		{
			get
			{
				if (this._conditionInfos == null)
				{
					return false;
				}
				foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo in this._conditionInfos)
				{
					if (!string.IsNullOrEmpty(conditionInfo.ErrorDescription))
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x00059044 File Offset: 0x00057244
		private global::Infragistics.Windows.Controls.ComparisonOperatorSelector ComparisonOperatorSelector
		{
			get
			{
				if (this._comparisonOperatorSelector == null)
				{
					this._comparisonOperatorSelector = new global::Infragistics.Windows.Controls.ComparisonOperatorSelector();
					base.AddLogicalChild(this._comparisonOperatorSelector);
					this._comparisonOperatorSelector.SetBinding(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.AllowableOperatorsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("RecordFilter.Field.FilterOperatorDropDownItemsResolved", global::System.Windows.Data.BindingMode.OneWay, this));
				}
				return this._comparisonOperatorSelector;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x00059093 File Offset: 0x00057293
		private bool IsConditionInEditMode
		{
			get
			{
				return this._conditionsGrid != null && this._conditionsGrid.ActiveCell != null && this._conditionsGrid.ActiveCell.IsInEditMode;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x000590BC File Offset: 0x000572BC
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> Operands
		{
			get
			{
				if (this._operands == null)
				{
					this._operands = new global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem>();
					if (this.RecordFilter != null && this.RecordManager != null)
					{
						bool includeFilteredOutValues = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None || this.RecordFilter.Field.Owner.RecordFiltersLogicalOperatorResolved == global::Infragistics.Windows.Controls.LogicalOperator.Or;
						global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo filterInfo = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo(this.RecordManager.RecordFiltersResolved, this.RecordFilter.Field);
						if (this._loader != null)
						{
							this._loader.Abort();
						}
						global::Infragistics.Windows.DataPresenter.Cell cell = (this._conditionsGrid != null) ? this._conditionsGrid.ActiveCell : null;
						global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = (cell != null) ? global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(cell) : null;
						global::Infragistics.Windows.Editors.XamComboEditor editor = (cellValuePresenter != null) ? global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.Editors.XamComboEditor>(cellValuePresenter, true, null) : null;
						this._loader = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader(editor, filterInfo, this._operands, true, null);
						this._loader.PopulatePhase1();
						this._loader.PopulatePhase2(includeFilteredOutValues);
						if (this._loader.EndReached)
						{
							this._loader = null;
						}
						else
						{
							this._loader.Phase2Completed += this.OnDropdownLoadCompleted;
						}
					}
				}
				return this._operands;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x000591DD File Offset: 0x000573DD
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> UnboundFields
		{
			get
			{
				if (this._unboundFields == null)
				{
					this._unboundFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>(50);
				}
				return this._unboundFields;
			}
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000591FC File Offset: 0x000573FC
		public void Initialize(global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			if (this._initializeMethodCalled)
			{
				return;
			}
			if (recordFilter == null)
			{
				throw new global::System.ArgumentNullException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_37"));
			}
			if (recordManager == null)
			{
				throw new global::System.ArgumentNullException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_38"));
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RecordFilterPropertyKey, recordFilter);
			base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RecordManagerPropertyKey, recordManager);
			base.Loaded += this.OnLoaded;
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.AddConditionLabelProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_AddConditionLabelProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RemoveSelectedConditionsLabelProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_RemoveSelectedConditionsLabelProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsAndGroupLabelProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_GroupSelectedConditionsAsAndGroupLabelProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedConditionsAsOrGroupLabelProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_GroupSelectedConditionsAsOrGroupLabelProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.UngroupSelectedConditionsLabelProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_UngroupSelectedConditionsLabelProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ToggleOperatorOfSelectedConditionsLabelProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_ToggleOperatorOfSelectedConditionsLabelProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.AndGroupLegendDescriptionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_AndGroupLegendDescriptionProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.OrGroupLegendDescriptionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_OrGroupLegendDescriptionProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.TitleDescriptionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_TitleDescriptionProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.FieldDescriptionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_FieldDescriptionProperty", new object[]
			{
				recordFilter.Field.Label
			})));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.OkButtonLabelProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_OkButtonLabelProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelButtonLabelProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_CancelButtonLabelProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelMessageTextProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_CancelMessageTextProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.CancelMessageTitleProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_CancelMessageTitleProperty")));
			base.SetBinding(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupSelectedLabelProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("CustomFilterSelectionControl_GroupSelectedLabelProperty")));
			this._initializeMethodCalled = true;
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00059470 File Offset: 0x00057670
		private void AddRemoveUnboundFieldsUsedAsGroupingIndicators()
		{
			int num = 0;
			this.ProcessConditionInfoGroupForGroupLevel(this._rootConditionInfoGroup, ref num);
			this._totalGroupLevels = num + 1;
			if (this._totalGroupLevels > this.UnboundFields.Count)
			{
				int count = this.UnboundFields.Count;
				for (int i = count; i < this._totalGroupLevels; i++)
				{
					global::Infragistics.Windows.DataPresenter.Field field = new global::Infragistics.Windows.DataPresenter.Field();
					field.BindingType = global::Infragistics.Windows.DataPresenter.BindingType.Unbound;
					field.Name = string.Format("Field {0}", i.ToString());
					field.Settings.AllowEdit = new bool?(false);
					field.Settings.AllowResize = new bool?(false);
					field.Settings.CellClickAction = global::Infragistics.Windows.DataPresenter.CellClickAction.SelectRecord;
					field.Settings.CellMinWidth = this.LogicalOperatorColumnWidth;
					field.Settings.CellMaxWidth = this.LogicalOperatorColumnWidth;
					field.Settings.CellValuePresenterStyleSelector = new global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupFieldStyleSelector(this);
					field.Tag = i;
					field.Label = " ";
					this._conditionsGrid.DefaultFieldLayout.Fields.Insert(i, field);
					this.UnboundFields.Insert(i, field);
				}
				return;
			}
			if (this._totalGroupLevels < this.UnboundFields.Count)
			{
				int count2 = this.UnboundFields.Count;
				for (int j = count2; j > this._totalGroupLevels; j--)
				{
					this._conditionsGrid.DefaultFieldLayout.Fields.Remove(this.UnboundFields[j - 1]);
					this.UnboundFields.RemoveAt(j - 1);
				}
			}
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x000595FC File Offset: 0x000577FC
		private bool IsGroupCompletelySelected(global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group)
		{
			bool result = true;
			if (group != null && group.ChildConditions != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo in group.ChildConditions)
				{
					if (conditionInfo is global::Infragistics.Windows.DataPresenter.ConditionInfoGroup || !conditionInfo.IsSelected)
					{
						result = false;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00059664 File Offset: 0x00057864
		private void EditComparisonOperatorValue(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord record = cell.Record;
			if (record == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Cell cell2 = record.Cells["ComparisonOperator"];
			global::Infragistics.Windows.DataPresenter.Cell cell3 = record.Cells["Value"];
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase = cell3.Value as global::Infragistics.Windows.Controls.SpecialFilterOperandBase;
			global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator = (global::Infragistics.Windows.Controls.ComparisonOperator)cell2.Value;
			if (specialFilterOperandBase != null)
			{
				if (!specialFilterOperandBase.SupportsOperator(comparisonOperator))
				{
					((global::Infragistics.Windows.DataPresenter.ConditionInfo)cell.Record.DataItem).SetErrorDescription(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CustomFilterSelectionControl_ConditionError_IncompatibleOperator"));
					return;
				}
			}
			else
			{
				global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = cell3.Value as global::Infragistics.Windows.Controls.ComparisonCondition;
				if (comparisonCondition != null && !string.IsNullOrEmpty(comparisonCondition.DisplayText) && comparisonOperator != global::Infragistics.Windows.Controls.ComparisonOperator.Equals)
				{
					((global::Infragistics.Windows.DataPresenter.ConditionInfo)cell.Record.DataItem).SetErrorDescription(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CustomFilterSelectionControl_ConditionError_IncompatibleOperator"));
					return;
				}
			}
			object value = cell3.Value;
			global::System.Exception ex;
			if (value != null && cell2.Field != null && this.RecordFilter != null && this.RecordFilter.Field != null && !this.RecordFilter.Field.IsFilterCellEntryValid(value, comparisonOperator, out ex))
			{
				((global::Infragistics.Windows.DataPresenter.ConditionInfo)cell.Record.DataItem).SetErrorDescription(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CustomFilterSelectionControl_ConditionError_IncompatibleOperator"));
				return;
			}
			((global::Infragistics.Windows.DataPresenter.ConditionInfo)cell.Record.DataItem).SetErrorDescription(string.Empty);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x000597A4 File Offset: 0x000579A4
		private void EditOperandValue(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			if (cell.Field.Name != "Value")
			{
				return;
			}
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase = cell.Value as global::Infragistics.Windows.Controls.SpecialFilterOperandBase;
			if (specialFilterOperandBase != null)
			{
				global::Infragistics.Windows.DataPresenter.Cell cell2 = cell.Record.Cells["ComparisonOperator"];
				global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator = (global::Infragistics.Windows.Controls.ComparisonOperator)cell2.Value;
				if (!specialFilterOperandBase.SupportsOperator(comparisonOperator))
				{
					global::Infragistics.Windows.Controls.ComparisonOperator filterOperatorDefaultValueResolved = this.RecordFilter.Field.FilterOperatorDefaultValueResolved;
					if (!specialFilterOperandBase.SupportsOperator(filterOperatorDefaultValueResolved))
					{
						if (specialFilterOperandBase.SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator.Equals))
						{
							cell2.Value = global::Infragistics.Windows.Controls.ComparisonOperator.Equals;
						}
						else
						{
							cell2.Value = filterOperatorDefaultValueResolved;
						}
					}
					else
					{
						cell2.Value = filterOperatorDefaultValueResolved;
					}
				}
				global::System.Exception ex;
				if (specialFilterOperandBase != null && this.RecordFilter.Field != null && !this.RecordFilter.Field.IsFilterCellEntryValid(specialFilterOperandBase, comparisonOperator, out ex))
				{
					global::Infragistics.Windows.Controls.ComparisonOperator filterOperatorDefaultValueResolved2 = this.RecordFilter.Field.FilterOperatorDefaultValueResolved;
					if (!specialFilterOperandBase.SupportsOperator(filterOperatorDefaultValueResolved2))
					{
						if (specialFilterOperandBase.SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator.Equals))
						{
							cell2.Value = global::Infragistics.Windows.Controls.ComparisonOperator.Equals;
						}
						else
						{
							cell2.Value = filterOperatorDefaultValueResolved2;
						}
					}
					else
					{
						cell2.Value = filterOperatorDefaultValueResolved2;
					}
				}
			}
			else
			{
				global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = cell.Value as global::Infragistics.Windows.Controls.ComparisonCondition;
				if (comparisonCondition != null && !string.IsNullOrEmpty(comparisonCondition.DisplayText))
				{
					global::Infragistics.Windows.DataPresenter.Cell cell3 = cell.Record.Cells["ComparisonOperator"];
					cell3.Value = global::Infragistics.Windows.Controls.ComparisonOperator.Equals;
				}
			}
			global::System.Exception ex2;
			if (!this.RecordFilter.Field.IsFilterCellEntryValid(cell.Value, (global::Infragistics.Windows.Controls.ComparisonOperator)cell.Record.Cells["ComparisonOperator"].Value, out ex2))
			{
				((global::Infragistics.Windows.DataPresenter.ConditionInfo)cell.Record.DataItem).SetErrorDescription(ex2.Message);
				return;
			}
			if (cell.Value == null || (cell.Value is string && string.IsNullOrEmpty((string)cell.Value)))
			{
				((global::Infragistics.Windows.DataPresenter.ConditionInfo)cell.Record.DataItem).SetErrorDescription(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CustomFilterSelectionControl_ConditionError_Empty"));
				return;
			}
			((global::Infragistics.Windows.DataPresenter.ConditionInfo)cell.Record.DataItem).SetErrorDescription(string.Empty);
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x000599D0 File Offset: 0x00057BD0
		private int GetIndexOfAdjacentRecordAtSpecificGroupLevel(int rangeStartIndex, int rangeEndIndex, int groupLevel)
		{
			if (rangeStartIndex > 0)
			{
				for (int i = rangeStartIndex - 1; i >= 0; i--)
				{
					if (this._conditionInfos[i].Group.Level == groupLevel)
					{
						return i;
					}
				}
			}
			else if (rangeEndIndex < this._conditionInfos.Count - 1)
			{
				for (int j = rangeEndIndex + 1; j < this._conditionInfos.Count; j++)
				{
					if (this._conditionInfos[j].Group.Level == groupLevel)
					{
						return j;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00059A50 File Offset: 0x00057C50
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> GetSelectedConditionInfos()
		{
			return this.GetSelectedConditionInfos(false);
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00059A5C File Offset: 0x00057C5C
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> GetSelectedConditionInfos(bool includeActiveRecordIfNoRecordsAreSelected)
		{
			if (this._conditionsGrid == null)
			{
				return new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo>();
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo>(this._conditionsGrid.SelectedItems.Records.Count);
			foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo in this._conditionInfos)
			{
				if (conditionInfo.IsSelected)
				{
					list.Add(conditionInfo);
				}
			}
			if (list.Count < 1 && includeActiveRecordIfNoRecordsAreSelected && this._conditionsGrid.ActiveRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._conditionsGrid.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null && dataRecord.DataItem is global::Infragistics.Windows.DataPresenter.ConditionInfo)
				{
					list.Add(dataRecord.DataItem as global::Infragistics.Windows.DataPresenter.ConditionInfo);
				}
			}
			return list;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00059B28 File Offset: 0x00057D28
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> GetSelectedRecordsInVisibleIndexOrder(global::Infragistics.Windows.DataPresenter.SelectedRecordCollection selectedRecords)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>(selectedRecords.ToArray());
			list.Sort(new global::Infragistics.Windows.DataPresenter.RecordVisibleIndexComparer());
			return list;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00059B50 File Offset: 0x00057D50
		private bool GroupSelectedConditionsHelper(global::Infragistics.Windows.Controls.LogicalOperator logicalOperator)
		{
			if (!this._currentSelectionCanBeGrouped)
			{
				return false;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> selectedConditionInfos = this.GetSelectedConditionInfos();
			if (selectedConditionInfos.Count < 1)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group = selectedConditionInfos[0].Group;
			global::Infragistics.Windows.DataPresenter.ConditionInfoGroup conditionInfoGroup = new global::Infragistics.Windows.DataPresenter.ConditionInfoGroup(group, logicalOperator);
			int index = group.ChildConditions.IndexOf(selectedConditionInfos[0]);
			group.ChildConditions.Insert(index, conditionInfoGroup);
			foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo item in selectedConditionInfos)
			{
				group.ChildConditions.Remove(item);
				conditionInfoGroup.ChildConditions.Add(item);
			}
			this.UpdateSelectionDependentFlags();
			this.AddRemoveUnboundFieldsUsedAsGroupingIndicators();
			this.RefreshConditionsGrid();
			return true;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00059C18 File Offset: 0x00057E18
		private global::Infragistics.Windows.DataPresenter.RecordFilter GetTargetRecordFilter()
		{
			global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = this.RecordFilter;
			if (recordFilter != null)
			{
				global::Infragistics.Windows.DataPresenter.Field field = recordFilter.Field;
				if (field != null && field.Owner != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
					global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFiltersResolved = recordManager.GetRecordFiltersResolved(field.Owner);
					recordFilter = recordFiltersResolved[field];
				}
			}
			return recordFilter;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00059C60 File Offset: 0x00057E60
		private void InitializeComboEditor(global::Infragistics.Windows.Editors.XamComboEditor editor)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = editor.Host as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
			if (cellValuePresenter == null)
			{
				return;
			}
			if (cellValuePresenter.Field.Name == "ComparisonOperator")
			{
				if (this._operatorInitializer != null)
				{
					this._operatorInitializer.Initialize(editor);
					return;
				}
			}
			else if (cellValuePresenter.Field.Name == "Value" && this._operandInitializer != null)
			{
				this._operandInitializer.Initialize(editor);
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00059CD4 File Offset: 0x00057ED4
		private void InitializeErrorDescriptions()
		{
			if (this._isDirty)
			{
				global::Infragistics.Windows.DataPresenter.Field field = this._conditionsGrid.DefaultFieldLayout.Fields["Value"];
				global::Infragistics.Windows.DataPresenter.Field field2 = this._conditionsGrid.DefaultFieldLayout.Fields["ErrorDescription"];
				global::Infragistics.Windows.DataPresenter.Cell cell = null;
				foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this._conditionsGrid.Records))
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord != null)
					{
						global::Infragistics.Windows.DataPresenter.Cell cell2 = dataRecord.Cells[field];
						this.EditOperandValue(cell2);
						if (cell == null && !string.IsNullOrEmpty(dataRecord.Cells[field2].Value as string))
						{
							cell = cell2;
						}
					}
				}
				if (cell != null)
				{
					this._conditionsGrid.ActiveCell = cell;
					this._conditionsGrid.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.StartEditMode);
				}
			}
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00059DD0 File Offset: 0x00057FD0
		private void OnConditionInfosCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this._isDirty = true;
			this.RefreshTempRootConditionGroup();
			this.UpdateSelectionDependentFlags();
			this.AddRemoveUnboundFieldsUsedAsGroupingIndicators();
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00059DEB File Offset: 0x00057FEB
		private void OnConditionInfosItemPropertyChanged(object sender, global::Infragistics.Collections.ItemPropertyChangedEventArgs e)
		{
			this._isDirty = true;
			this.RefreshTempRootConditionGroup();
			this.AddRemoveUnboundFieldsUsedAsGroupingIndicators();
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00059E00 File Offset: 0x00058000
		private void OnConditionsGridCellActivated(object sender, global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs e)
		{
			if (e.Cell.Field.Name == "Value" && this._loader != null)
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(e.Cell);
				this._loader.Editor = ((cellValuePresenter != null) ? global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.Editors.XamComboEditor>(cellValuePresenter, true, null) : null);
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00059E58 File Offset: 0x00058058
		private void OnConditionsGridEditModeStarted(object sender, global::Infragistics.Windows.DataPresenter.Events.EditModeStartedEventArgs e)
		{
			if (e.Cell.Field.Name == "Value")
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.SetIsTextSearchEnabled(e.Editor as global::Infragistics.Windows.Editors.XamComboEditor, (global::Infragistics.Windows.Controls.ComparisonOperator)e.Cell.Record.Cells["ComparisonOperator"].Value);
			}
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00059EB8 File Offset: 0x000580B8
		private void OnConditionsGridEditModeEnded(object sender, global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs e)
		{
			if (e.Cell.Field.Name == "Value")
			{
				this.EditOperandValue(e.Cell);
			}
			if (e.Cell.Field.Name == "ComparisonOperator")
			{
				this.EditComparisonOperatorValue(e.Cell);
			}
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00059F15 File Offset: 0x00058115
		private void OnDropdownLoadCompleted(object sender, global::System.EventArgs e)
		{
			if (this._loader == sender)
			{
				this._loader.Phase2Completed -= this.OnDropdownLoadCompleted;
				this._loader = null;
			}
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00059F3E File Offset: 0x0005813E
		private void OnConditionsGridRecordsDeleting(object sender, global::Infragistics.Windows.DataPresenter.Events.RecordsDeletingEventArgs e)
		{
			e.Cancel = true;
			this.RemoveSelectedConditions();
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00059F50 File Offset: 0x00058150
		private void OnFieldLayoutInitialized(object sender, global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializedEventArgs e)
		{
			if (this.RecordFilter == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field field = this.RecordFilter.Field;
			global::Infragistics.Windows.DataPresenter.Field field2 = e.FieldLayout.Fields["ComparisonOperator"];
			if (field2 != null)
			{
				field2.Label = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CustomFilterSelectionControl_OperatorFieldLabel");
				field2.Settings.EditorType = typeof(global::Infragistics.Windows.Editors.XamComboEditor);
				field2.Settings.EditAsType = typeof(global::Infragistics.Windows.Controls.ComparisonOperatorListItem);
				this._operatorInitializer = new global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ComboEditorInitializer(new global::Infragistics.Windows.Editors.ComboBoxItemsProvider
				{
					ItemsSource = this.ComparisonOperatorSelector.Items
				}, null, new global::Infragistics.Windows.Editors.DisplayValueSource?(global::Infragistics.Windows.Editors.DisplayValueSource.Value));
				field2.Converter = new global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ComparisonOperatorToListItemConverter(this.ComparisonOperatorSelector);
			}
			global::Infragistics.Windows.DataPresenter.Field field3 = e.FieldLayout.Fields["Value"];
			if (field3 != null)
			{
				field3.Label = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CustomFilterSelectionControl_OperandFieldLabel");
				field3.Settings.EditorType = field.FilterEditorTypeResolved;
				field3.Settings.EditAsType = field.FilterEditAsTypeResolved;
				global::Infragistics.Windows.DataPresenter.Field field4 = this.RecordFilter.Field;
				if (field4 != null && (field4.FilterOperandUITypeResolved == global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Combo || field4.FilterOperandUITypeResolved == global::Infragistics.Windows.DataPresenter.FilterOperandUIType.DropDownList))
				{
					this._operandInitializer = new global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ComboEditorInitializer(new global::Infragistics.Windows.Editors.ComboBoxItemsProvider
					{
						ItemsSource = this.Operands
					}, new bool?(field4.FilterOperandUITypeResolved == global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Combo), null);
				}
			}
			global::Infragistics.Windows.DataPresenter.Field field5 = e.FieldLayout.Fields["ErrorDescription"];
			if (field5 != null)
			{
				field5.Label = "";
				field5.Settings.EditorType = typeof(global::Infragistics.Windows.Editors.XamTextEditor);
				field5.Settings.EditAsType = typeof(string);
				global::System.Windows.Style style = new global::System.Windows.Style();
				style.TargetType = typeof(global::Infragistics.Windows.Editors.XamTextEditor);
				global::System.Windows.Setter setter = new global::System.Windows.Setter();
				setter.Property = global::System.Windows.Controls.TextBlock.ForegroundProperty;
				setter.Value = global::System.Windows.Media.Brushes.Red;
				style.Setters.Add(setter);
				setter = new global::System.Windows.Setter();
				setter.Property = global::Infragistics.Windows.Editors.XamTextEditor.TextWrappingProperty;
				setter.Value = global::System.Windows.TextWrapping.Wrap;
				style.Setters.Add(setter);
				setter = new global::System.Windows.Setter();
				setter.Property = global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty;
				setter.Value = global::System.Windows.HorizontalAlignment.Stretch;
				style.Setters.Add(setter);
				field5.Settings.EditorStyle = style;
			}
			e.FieldLayout.Fields["Group"].Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0005A1D8 File Offset: 0x000583D8
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._conditionInfos = new global::Infragistics.Windows.DataPresenter.ConditionInfoCollection(new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo>(5));
			if (this.RecordFilter == null)
			{
				return;
			}
			if (this.RecordFilter != this.GetTargetRecordFilter())
			{
				this._isDirty = true;
			}
			this._rootConditionInfoGroup = new global::Infragistics.Windows.DataPresenter.ConditionInfoGroup(null, this.RecordFilter.Conditions.LogicalOperator);
			if (!this.ProcessConditionGroup(this.RecordFilter.Conditions, this._rootConditionInfoGroup))
			{
				this._rootConditionInfoGroup.ChildConditions.Clear();
				this._conditionInfos.Clear();
				this._rootConditionInfoGroup = new global::Infragistics.Windows.DataPresenter.ConditionInfoGroup(null, this.RecordFilter.Conditions.LogicalOperator);
				this._tempRootConditionGroup = new global::Infragistics.Windows.Controls.ConditionGroup();
				this._tempRootConditionGroup.LogicalOperator = this.RecordFilter.Conditions.LogicalOperator;
			}
			else
			{
				this.RefreshConditionInfosCollection();
				this.RefreshTempRootConditionGroup();
			}
			if (this._conditionsGrid != null)
			{
				this._conditionsGrid.FieldLayoutSettings = new global::Infragistics.Windows.DataPresenter.FieldLayoutSettings();
				this._conditionsGrid.FieldSettings = new global::Infragistics.Windows.DataPresenter.FieldSettings();
				this._conditionsGrid.RecordContainerGenerationMode = global::Infragistics.Windows.Controls.ItemContainerGenerationMode.PreLoad;
				this._conditionsGrid.CellContainerGenerationMode = global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode.PreLoad;
				this._conditionsGrid.FieldLayoutSettings.SelectionTypeCell = global::Infragistics.Windows.Controls.SelectionType.None;
				this._conditionsGrid.FieldLayoutSettings.AllowFieldMoving = global::Infragistics.Windows.DataPresenter.AllowFieldMoving.No;
				this._conditionsGrid.FieldSettings.LabelClickAction = global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing;
				this._conditionsGrid.UpdateMode = global::Infragistics.Windows.DataPresenter.UpdateMode.OnCellChange;
				this._conditionsGrid.ScrollingMode = global::Infragistics.Windows.DataPresenter.ScrollingMode.Immediate;
				this._conditionsGrid.AutoFit = new bool?(true);
				this._conditionsGrid.SelectedItemsChanged += this.OnSelectedConditionsChanged;
				this._conditionsGrid.FieldLayoutInitialized += this.OnFieldLayoutInitialized;
				this._conditionsGrid.EditModeStarted += this.OnConditionsGridEditModeStarted;
				this._conditionsGrid.EditModeEnded += this.OnConditionsGridEditModeEnded;
				this._conditionsGrid.DataSource = this._conditionInfos;
				this._conditionsGrid.RecordsDeleting += this.OnConditionsGridRecordsDeleting;
				this._conditionsGrid.CellActivated += this.OnConditionsGridCellActivated;
			}
			this._conditionInfos.CollectionChanged += this.OnConditionInfosCollectionChanged;
			this._conditionInfos.ItemPropertyChanged += this.OnConditionInfosItemPropertyChanged;
			this.UpdateSelectionDependentFlags();
			this.AddRemoveUnboundFieldsUsedAsGroupingIndicators();
			if (this._isDirty)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Loaded, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.InitializeErrorDescriptions));
				return;
			}
			if (this._conditionsGrid.ViewableRecords.Count > 0)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Loaded, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.SelectFirstRecord));
			}
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0005A478 File Offset: 0x00058678
		private void SelectFirstRecord()
		{
			if (this._conditionsGrid.ViewableRecords.Count > 0)
			{
				this._conditionsGrid.SelectedItems.Records.Add(this._conditionsGrid.ViewableRecords[0]);
			}
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0005A4B3 File Offset: 0x000586B3
		private void OnSelectedConditionsChanged(object sender, global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs e)
		{
			this.UpdateSelectedStatusOfAllConditionInfos();
			this.UpdateSelectionDependentFlags();
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0005A4C4 File Offset: 0x000586C4
		private bool ProcessConditionGroup(global::Infragistics.Windows.Controls.ConditionGroup conditions, global::Infragistics.Windows.DataPresenter.ConditionInfoGroup parentConditionInfoGroup)
		{
			foreach (global::Infragistics.Windows.Controls.ICondition condition in conditions)
			{
				if (condition is global::Infragistics.Windows.Controls.ConditionGroup)
				{
					global::Infragistics.Windows.DataPresenter.ConditionInfoGroup conditionInfoGroup = new global::Infragistics.Windows.DataPresenter.ConditionInfoGroup(parentConditionInfoGroup, ((global::Infragistics.Windows.Controls.ConditionGroup)condition).LogicalOperator);
					parentConditionInfoGroup.ChildConditions.Add(conditionInfoGroup);
					if (!this.ProcessConditionGroup(condition as global::Infragistics.Windows.Controls.ConditionGroup, conditionInfoGroup))
					{
						return false;
					}
				}
				else
				{
					if (!(condition is global::Infragistics.Windows.Controls.ComparisonCondition))
					{
						return false;
					}
					global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = condition as global::Infragistics.Windows.Controls.ComparisonCondition;
					if (!string.IsNullOrEmpty(comparisonCondition.DisplayText))
					{
						parentConditionInfoGroup.ChildConditions.Add(new global::Infragistics.Windows.DataPresenter.ConditionInfo(parentConditionInfoGroup, global::Infragistics.Windows.Controls.ComparisonOperator.Equals, comparisonCondition, comparisonCondition.DisplayText));
					}
					else
					{
						parentConditionInfoGroup.ChildConditions.Add(new global::Infragistics.Windows.DataPresenter.ConditionInfo(parentConditionInfoGroup, comparisonCondition.Operator, comparisonCondition.Value, null));
					}
				}
			}
			return true;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0005A5AC File Offset: 0x000587AC
		private void ProcessConditionInfoGroupForCleanup(global::Infragistics.Windows.DataPresenter.ConditionInfoGroup conditionInfoGroup)
		{
			for (int i = 0; i < conditionInfoGroup.ChildConditions.Count; i++)
			{
				global::Infragistics.Windows.DataPresenter.ConditionInfoGroup conditionInfoGroup2 = conditionInfoGroup.ChildConditions[i] as global::Infragistics.Windows.DataPresenter.ConditionInfoGroup;
				if (conditionInfoGroup2 != null)
				{
					if (conditionInfoGroup2.ContainsOneGroupAndNoConditions)
					{
						this.UngroupGroupAndItsChildrenHelper(conditionInfoGroup2);
						i = -1;
					}
					else if (conditionInfoGroup2.ChildConditions.Count == 0)
					{
						conditionInfoGroup.ChildConditions.Remove(conditionInfoGroup2);
						i = -1;
					}
					else
					{
						this.ProcessConditionInfoGroupForCleanup(conditionInfoGroup2);
					}
				}
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0005A61C File Offset: 0x0005881C
		private void ProcessConditionInfoGroupForCommit(global::Infragistics.Windows.DataPresenter.ConditionInfoGroup conditionInfoGroup, global::Infragistics.Windows.Controls.ConditionGroup conditionGroup)
		{
			foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo in conditionInfoGroup.ChildConditions)
			{
				if (conditionInfo is global::Infragistics.Windows.DataPresenter.ConditionInfoGroup)
				{
					global::Infragistics.Windows.Controls.ConditionGroup conditionGroup2 = new global::Infragistics.Windows.Controls.ConditionGroup();
					conditionGroup2.LogicalOperator = ((global::Infragistics.Windows.DataPresenter.ConditionInfoGroup)conditionInfo).LogicalOperator;
					conditionGroup.Add(conditionGroup2);
					this.ProcessConditionInfoGroupForCommit(conditionInfo as global::Infragistics.Windows.DataPresenter.ConditionInfoGroup, conditionGroup2);
				}
				else
				{
					global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = conditionInfo.Value as global::Infragistics.Windows.Controls.ComparisonCondition;
					if (comparisonCondition != null)
					{
						if (comparisonCondition.Operator != conditionInfo.ComparisonOperator && string.IsNullOrEmpty(comparisonCondition.DisplayText))
						{
							global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition2 = ((global::System.ICloneable)comparisonCondition).Clone() as global::Infragistics.Windows.Controls.ComparisonCondition;
							comparisonCondition2.Operator = conditionInfo.ComparisonOperator;
							conditionGroup.Add(comparisonCondition2);
						}
						else
						{
							conditionGroup.Add(comparisonCondition);
						}
					}
					else
					{
						global::System.Exception ex;
						conditionGroup.Add(global::Infragistics.Windows.Controls.ComparisonCondition.Create(conditionInfo.ComparisonOperator, conditionInfo.Value, false, out ex));
					}
				}
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0005A714 File Offset: 0x00058914
		private void ProcessConditionInfoGroupForGroupLevel(global::Infragistics.Windows.DataPresenter.ConditionInfoGroup conditionInfoGroup, ref int highestGroupLevel)
		{
			foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo in conditionInfoGroup.ChildConditions)
			{
				if (conditionInfo is global::Infragistics.Windows.DataPresenter.ConditionInfoGroup)
				{
					highestGroupLevel = global::System.Math.Max(highestGroupLevel, ((global::Infragistics.Windows.DataPresenter.ConditionInfoGroup)conditionInfo).Level);
					this.ProcessConditionInfoGroupForGroupLevel(conditionInfo as global::Infragistics.Windows.DataPresenter.ConditionInfoGroup, ref highestGroupLevel);
				}
			}
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0005A784 File Offset: 0x00058984
		private void ProcessConditionInfoGroupForConditionInfoRefresh(global::Infragistics.Windows.DataPresenter.ConditionInfoGroup conditionInfoGroup)
		{
			foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo in conditionInfoGroup.ChildConditions)
			{
				if (conditionInfo is global::Infragistics.Windows.DataPresenter.ConditionInfoGroup)
				{
					this.ProcessConditionInfoGroupForConditionInfoRefresh(conditionInfo as global::Infragistics.Windows.DataPresenter.ConditionInfoGroup);
				}
				else
				{
					this._conditionInfos.Add(conditionInfo);
				}
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0005A7EC File Offset: 0x000589EC
		private void RefreshConditionInfosCollection()
		{
			this._conditionInfos.BeginUpdate();
			this._conditionInfos.Clear();
			this.ProcessConditionInfoGroupForConditionInfoRefresh(this._rootConditionInfoGroup);
			this._conditionInfos.EndUpdate();
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0005A81C File Offset: 0x00058A1C
		private void RefreshConditionsGrid()
		{
			this._conditionsGrid.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndAcceptChanges);
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> selectedConditionInfos = this.GetSelectedConditionInfos(true);
			this._conditionsGrid.SelectedItems.ClearAllSelected();
			this.RefreshConditionInfosCollection();
			this.RefreshTempRootConditionGroup();
			this._conditionsGrid.DataSource = null;
			this._conditionsGrid.DataSource = this._conditionInfos;
			foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this._conditionsGrid.RecordManager.Current))
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)record;
				int num = selectedConditionInfos.IndexOf(dataRecord.DataItem as global::Infragistics.Windows.DataPresenter.ConditionInfo);
				if (num > -1)
				{
					this._conditionsGrid.SelectedItems.Records.Add(dataRecord);
				}
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0005A8F0 File Offset: 0x00058AF0
		private void RefreshTempRootConditionGroup()
		{
			this._tempRootConditionGroup = new global::Infragistics.Windows.Controls.ConditionGroup();
			this._tempRootConditionGroup.LogicalOperator = this._rootConditionInfoGroup.LogicalOperator;
			this.ProcessConditionInfoGroupForCommit(this._rootConditionInfoGroup, this._tempRootConditionGroup);
			base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.FilterSummaryDescriptionPropertyKey, this._tempRootConditionGroup.ToolTip);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0005A948 File Offset: 0x00058B48
		private bool RemoveSelectedConditions()
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> selectedConditionInfos = this.GetSelectedConditionInfos(true);
			if (selectedConditionInfos.Count > 0)
			{
				int num = -1;
				if (this._conditionsGrid.ViewableRecords.Count > 0 && this._conditionsGrid.SelectedItems.Records.Count > 0)
				{
					num = this._conditionsGrid.ViewableRecords.IndexOf(this._conditionsGrid.SelectedItems.Records[0]);
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._conditionsGrid.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord != null && dataRecord.DataItem is global::Infragistics.Windows.DataPresenter.ConditionInfo)
					{
						num = this._conditionsGrid.ViewableRecords.IndexOf(dataRecord);
					}
				}
				this._conditionInfos.BeginUpdate();
				foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo in selectedConditionInfos)
				{
					global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group = conditionInfo.Group;
					group.ChildConditions.Remove(conditionInfo);
					this._conditionInfos.Remove(conditionInfo);
					if (group.ChildConditions.Count == 0 && group.Group != null && group.Group.ChildConditions.Contains(group))
					{
						group.Group.ChildConditions.Remove(group);
					}
					else if (group.ContainsOneGroupAndNoConditions)
					{
						this.UngroupGroupAndItsChildrenHelper(group.ChildConditions[0] as global::Infragistics.Windows.DataPresenter.ConditionInfoGroup);
					}
				}
				this._conditionInfos.EndUpdate();
				this.UpdateSelectionDependentFlags();
				this.AddRemoveUnboundFieldsUsedAsGroupingIndicators();
				this.RefreshConditionsGrid();
				if (num > -1)
				{
					num = global::System.Math.Min(num, this._conditionsGrid.ViewableRecords.Count - 1);
					if (num > -1)
					{
						this._conditionsGrid.SelectedItems.Records.Add(this._conditionsGrid.ViewableRecords[num]);
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0005AB2C File Offset: 0x00058D2C
		private bool TryEndEditMode()
		{
			if (this.IsConditionInEditMode)
			{
				this._conditionsGrid.ActiveCell.EndEditMode(true);
				return !this._conditionsGrid.ActiveCell.IsInEditMode;
			}
			return true;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0005AB60 File Offset: 0x00058D60
		private void UngroupGroupAndItsChildrenHelper(global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group)
		{
			global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group2 = group.Group;
			int num = group2.ChildConditions.IndexOf(group);
			bool flag = group2.ChildConditions.Count == 1;
			foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo item in group.ChildConditions)
			{
				group2.ChildConditions.Insert(num, item);
				num++;
			}
			if (flag)
			{
				group2.LogicalOperator = group.LogicalOperator;
			}
			group2.ChildConditions.Remove(group);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0005ABFC File Offset: 0x00058DFC
		private void UpdateSelectionDependentFlags()
		{
			this._currentSelectionSpansMultipleGroups = false;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> selectedConditionInfos = this.GetSelectedConditionInfos();
			global::Infragistics.Windows.DataPresenter.ConditionInfoGroup conditionInfoGroup = null;
			foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo in selectedConditionInfos)
			{
				if (conditionInfoGroup == null)
				{
					conditionInfoGroup = conditionInfo.Group;
				}
				else if (conditionInfo.Group != conditionInfoGroup)
				{
					this._currentSelectionSpansMultipleGroups = true;
					break;
				}
			}
			this._currentSelectionCanBeGrouped = false;
			this._currentSelectionCanBeUngrouped = false;
			this._currentSelectionCount = selectedConditionInfos.Count;
			if (this._conditionsGrid == null)
			{
				return;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> selectedRecordsInVisibleIndexOrder = this.GetSelectedRecordsInVisibleIndexOrder(this._conditionsGrid.SelectedItems.Records);
			int count = selectedRecordsInVisibleIndexOrder.Count;
			if (count < 1)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo2 = ((global::Infragistics.Windows.DataPresenter.DataRecord)selectedRecordsInVisibleIndexOrder[0]).DataItem as global::Infragistics.Windows.DataPresenter.ConditionInfo;
			global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group = conditionInfo2.Group;
			if (this._currentSelectionSpansMultipleGroups)
			{
				bool currentSelectionCanBeUngrouped = false;
				foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo3 in selectedConditionInfos)
				{
					if (conditionInfo3.Group.Level > 0)
					{
						currentSelectionCanBeUngrouped = true;
						break;
					}
				}
				this._currentSelectionCanBeGrouped = false;
				this._currentSelectionCanBeUngrouped = currentSelectionCanBeUngrouped;
				return;
			}
			bool flag = this.IsGroupCompletelySelected(group);
			if (flag)
			{
				this._currentSelectionCanBeGrouped = false;
				this._currentSelectionCanBeUngrouped = (group != null && group.Level != 0);
				return;
			}
			this._currentSelectionCanBeGrouped = (this._currentSelectionCount > 1);
			this._currentSelectionCanBeUngrouped = (group != null && group.Level != 0);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0005AD9C File Offset: 0x00058F9C
		private void UpdateSelectedStatusOfAllConditionInfos()
		{
			if (this._conditionsGrid == null)
			{
				return;
			}
			if (this._conditionInfos.Count < 1)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records = this._conditionsGrid.SelectedItems.Records;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo>(records.Count);
			foreach (global::Infragistics.Windows.DataPresenter.Record record in records)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)record;
				list.Add(dataRecord.DataItem as global::Infragistics.Windows.DataPresenter.ConditionInfo);
			}
			foreach (global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo in this._conditionInfos)
			{
				conditionInfo.IsSelected = list.Contains(conditionInfo);
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0005AE74 File Offset: 0x00059074
		internal void VerifyParts()
		{
			if (this._conditionsGrid == null)
			{
				this._conditionsGrid = (base.GetTemplateChild("PART_ConditionsGrid") as global::Infragistics.Windows.DataPresenter.XamDataGrid);
			}
		}

		// Token: 0x04000822 RID: 2082
		private const int MAX_GROUPLEVELS = 50;

		// Token: 0x04000823 RID: 2083
		private bool _initializeMethodCalled;

		// Token: 0x04000824 RID: 2084
		private global::Infragistics.Windows.DataPresenter.XamDataGrid _conditionsGrid;

		// Token: 0x04000825 RID: 2085
		private global::Infragistics.Windows.DataPresenter.ConditionInfoCollection _conditionInfos;

		// Token: 0x04000826 RID: 2086
		private global::Infragistics.Windows.DataPresenter.ConditionInfoGroup _rootConditionInfoGroup;

		// Token: 0x04000827 RID: 2087
		private int _totalGroupLevels;

		// Token: 0x04000828 RID: 2088
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _unboundFields;

		// Token: 0x04000829 RID: 2089
		private bool _currentSelectionCanBeGrouped;

		// Token: 0x0400082A RID: 2090
		private bool _currentSelectionCanBeUngrouped;

		// Token: 0x0400082B RID: 2091
		private bool _currentSelectionSpansMultipleGroups;

		// Token: 0x0400082C RID: 2092
		private int _currentSelectionCount;

		// Token: 0x0400082D RID: 2093
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _operands;

		// Token: 0x0400082E RID: 2094
		private bool _isDirty;

		// Token: 0x0400082F RID: 2095
		private global::Infragistics.Windows.Controls.ConditionGroup _tempRootConditionGroup;

		// Token: 0x04000830 RID: 2096
		private global::Infragistics.Windows.Controls.ComparisonOperatorSelector _comparisonOperatorSelector;

		// Token: 0x04000831 RID: 2097
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader _loader;

		// Token: 0x04000832 RID: 2098
		private global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ComboEditorInitializer _operatorInitializer;

		// Token: 0x04000833 RID: 2099
		private global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ComboEditorInitializer _operandInitializer;

		// Token: 0x04000834 RID: 2100
		public static readonly global::System.Windows.Input.RoutedCommand AddConditionCommand;

		// Token: 0x04000835 RID: 2101
		public static readonly global::System.Windows.Input.RoutedCommand CancelChangesCommand;

		// Token: 0x04000836 RID: 2102
		public static readonly global::System.Windows.Input.RoutedCommand CommitChangesCommand;

		// Token: 0x04000837 RID: 2103
		public static readonly global::System.Windows.Input.RoutedCommand GroupSelectedConditionsAsAndGroupCommand;

		// Token: 0x04000838 RID: 2104
		public static readonly global::System.Windows.Input.RoutedCommand GroupSelectedConditionsAsOrGroupCommand;

		// Token: 0x04000839 RID: 2105
		public static readonly global::System.Windows.Input.RoutedCommand RemoveSelectedConditionsCommand;

		// Token: 0x0400083A RID: 2106
		public static readonly global::System.Windows.Input.RoutedCommand ToggleSelectedGroupLogicalOperatorCommand;

		// Token: 0x0400083B RID: 2107
		public static readonly global::System.Windows.Input.RoutedCommand UngroupSelectedConditionsCommand;

		// Token: 0x0400083C RID: 2108
		public static readonly global::System.Windows.DependencyProperty AddConditionLabelProperty = global::System.Windows.DependencyProperty.Register("AddConditionLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400083D RID: 2109
		public static readonly global::System.Windows.DependencyProperty AndGroupLegendDescriptionProperty = global::System.Windows.DependencyProperty.Register("AndGroupLegendDescription", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400083E RID: 2110
		public static readonly global::System.Windows.DependencyProperty AndLogicalOperatorBrushProperty = global::System.Windows.DependencyProperty.Register("AndLogicalOperatorBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Media.Brushes.Blue));

		// Token: 0x0400083F RID: 2111
		public static readonly global::System.Windows.DependencyProperty CancelButtonLabelProperty = global::System.Windows.DependencyProperty.Register("CancelButtonLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000840 RID: 2112
		public static readonly global::System.Windows.DependencyProperty CancelMessageTextProperty = global::System.Windows.DependencyProperty.Register("CancelMessageText", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000841 RID: 2113
		public static readonly global::System.Windows.DependencyProperty CancelMessageTitleProperty = global::System.Windows.DependencyProperty.Register("CancelMessageTitle", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000842 RID: 2114
		public static readonly global::System.Windows.DependencyProperty FieldDescriptionProperty = global::System.Windows.DependencyProperty.Register("FieldDescription", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000843 RID: 2115
		private static readonly global::System.Windows.DependencyPropertyKey FilterSummaryDescriptionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FilterSummaryDescription", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000844 RID: 2116
		public static readonly global::System.Windows.DependencyProperty FilterSummaryDescriptionProperty = global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.FilterSummaryDescriptionPropertyKey.DependencyProperty;

		// Token: 0x04000845 RID: 2117
		public static readonly global::System.Windows.DependencyProperty GroupSelectedLabelProperty = global::System.Windows.DependencyProperty.Register("GroupSelectedLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000846 RID: 2118
		public static readonly global::System.Windows.DependencyProperty GroupSelectedConditionsAsAndGroupLabelProperty = global::System.Windows.DependencyProperty.Register("GroupSelectedConditionsAsAndGroupLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000847 RID: 2119
		public static readonly global::System.Windows.DependencyProperty GroupSelectedConditionsAsOrGroupLabelProperty = global::System.Windows.DependencyProperty.Register("GroupSelectedConditionsAsOrGroupLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000848 RID: 2120
		public static readonly global::System.Windows.DependencyProperty LogicalOperatorColumnWidthProperty = global::System.Windows.DependencyProperty.Register("LogicalOperatorColumnWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(12.0));

		// Token: 0x04000849 RID: 2121
		public static readonly global::System.Windows.DependencyProperty OkButtonLabelProperty = global::System.Windows.DependencyProperty.Register("OkButtonLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400084A RID: 2122
		public static readonly global::System.Windows.DependencyProperty OrGroupLegendDescriptionProperty = global::System.Windows.DependencyProperty.Register("OrGroupLegendDescription", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400084B RID: 2123
		public static readonly global::System.Windows.DependencyProperty OrLogicalOperatorBrushProperty = global::System.Windows.DependencyProperty.Register("OrLogicalOperatorBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Media.Brushes.Red));

		// Token: 0x0400084C RID: 2124
		private static readonly global::System.Windows.DependencyPropertyKey RecordFilterPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RecordFilter", typeof(global::Infragistics.Windows.DataPresenter.RecordFilter), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400084D RID: 2125
		public static readonly global::System.Windows.DependencyProperty RecordFilterProperty = global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RecordFilterPropertyKey.DependencyProperty;

		// Token: 0x0400084E RID: 2126
		private static readonly global::System.Windows.DependencyPropertyKey RecordManagerPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RecordManager", typeof(global::Infragistics.Windows.DataPresenter.RecordManager), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400084F RID: 2127
		public static readonly global::System.Windows.DependencyProperty RecordManagerProperty = global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RecordManagerPropertyKey.DependencyProperty;

		// Token: 0x04000850 RID: 2128
		public static readonly global::System.Windows.DependencyProperty RemoveSelectedConditionsLabelProperty = global::System.Windows.DependencyProperty.Register("RemoveSelectedConditionsLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000851 RID: 2129
		public static readonly global::System.Windows.DependencyProperty TitleDescriptionProperty = global::System.Windows.DependencyProperty.Register("TitleDescription", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000852 RID: 2130
		public static readonly global::System.Windows.DependencyProperty ToggleOperatorOfSelectedConditionsLabelProperty = global::System.Windows.DependencyProperty.Register("ToggleOperatorOfSelectedConditionsLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000853 RID: 2131
		public static readonly global::System.Windows.DependencyProperty UngroupSelectedConditionsLabelProperty = global::System.Windows.DependencyProperty.Register("UngroupSelectedConditionsLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000854 RID: 2132
		internal static readonly global::System.Windows.DependencyProperty ControlProperty = global::System.Windows.DependencyProperty.RegisterAttached("Control", typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.OnControlChanged)));

		// Token: 0x0200014E RID: 334
		private class GroupFieldStyleSelector : global::System.Windows.Controls.StyleSelector
		{
			// Token: 0x0600144A RID: 5194 RVA: 0x0005AE94 File Offset: 0x00059094
			internal GroupFieldStyleSelector(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl customFilterSelectionControl)
			{
				if (customFilterSelectionControl == null)
				{
					throw new global::System.ArgumentException();
				}
				this._customFilterSelectionControl = customFilterSelectionControl;
			}

			// Token: 0x0600144B RID: 5195 RVA: 0x0005AEAC File Offset: 0x000590AC
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = container as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
				if (cellValuePresenter == null)
				{
					return null;
				}
				int num = (int)cellValuePresenter.Field.Tag;
				global::Infragistics.Windows.DataPresenter.ConditionInfo conditionInfo = cellValuePresenter.Record.DataItem as global::Infragistics.Windows.DataPresenter.ConditionInfo;
				if (conditionInfo == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.ConditionInfoGroup group = conditionInfo.Group;
				int level = group.Level;
				global::Infragistics.Windows.Controls.LogicalOperator logicalOperator = group.LogicalOperator;
				if (num <= level)
				{
					global::System.Windows.Style style = new global::System.Windows.Style();
					style.TargetType = typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter);
					global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));
					global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Border));
					controlTemplate.VisualTree = frameworkElementFactory;
					global::System.Windows.FrameworkElementFactory frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.Controls.CardPanel));
					global::System.Windows.FrameworkElementFactory frameworkElementFactory3 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Shapes.Rectangle));
					global::Infragistics.Windows.DataPresenter.ConditionInfoGroup conditionInfoGroup;
					if (num == level)
					{
						conditionInfoGroup = group;
					}
					else
					{
						conditionInfoGroup = group.GetParentGroupAtLevel(num);
					}
					frameworkElementFactory3.SetValue(global::System.Windows.Shapes.Shape.FillProperty, (conditionInfoGroup.LogicalOperator == global::Infragistics.Windows.Controls.LogicalOperator.And) ? this._customFilterSelectionControl.AndLogicalOperatorBrush : this._customFilterSelectionControl.OrLogicalOperatorBrush);
					double top = (double)((conditionInfo.IsFirstInGroup && num == level) ? 2 : 0);
					double bottom = (double)((conditionInfo.IsLastInGroup && num == level) ? 2 : 0);
					frameworkElementFactory3.SetValue(global::System.Windows.FrameworkElement.MarginProperty, new global::System.Windows.Thickness(3.0, top, 3.0, bottom));
					frameworkElementFactory2.AppendChild(frameworkElementFactory3);
					frameworkElementFactory.AppendChild(frameworkElementFactory2);
					global::System.Windows.Setter setter = new global::System.Windows.Setter();
					setter.Property = global::System.Windows.Controls.Control.TemplateProperty;
					setter.Value = controlTemplate;
					style.Setters.Add(setter);
					global::System.Windows.Setter setter2 = new global::System.Windows.Setter();
					setter2.Property = global::System.Windows.FrameworkElement.CursorProperty;
					setter2.Value = global::System.Windows.Input.Cursors.Hand;
					style.Setters.Add(setter2);
					setter2 = new global::System.Windows.Setter();
					setter2.Property = global::System.Windows.FrameworkElement.ToolTipProperty;
					setter2.Value = ((conditionInfoGroup.LogicalOperator == global::Infragistics.Windows.Controls.LogicalOperator.And) ? global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CustomFilterSelectionControl_ChangeGroupLogicalOperatorTo_Or") : global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CustomFilterSelectionControl_ChangeGroupLogicalOperatorTo_And"));
					style.Setters.Add(setter2);
					setter2 = new global::System.Windows.Setter();
					setter2.Property = global::System.Windows.FrameworkElement.TagProperty;
					setter2.Value = conditionInfoGroup;
					style.Setters.Add(setter2);
					global::System.Windows.EventSetter eventSetter = new global::System.Windows.EventSetter();
					eventSetter.Event = global::System.Windows.UIElement.MouseDownEvent;
					eventSetter.Handler = new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.GroupFieldStyleSelector.OnMouseDown);
					style.Setters.Add(eventSetter);
					return style;
				}
				global::System.Windows.Style style2 = new global::System.Windows.Style();
				style2.TargetType = typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter);
				global::System.Windows.Controls.ControlTemplate controlTemplate2 = new global::System.Windows.Controls.ControlTemplate(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));
				global::System.Windows.FrameworkElementFactory visualTree = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Border));
				controlTemplate2.VisualTree = visualTree;
				global::System.Windows.Setter setter3 = new global::System.Windows.Setter();
				setter3.Property = global::System.Windows.Controls.Control.TemplateProperty;
				setter3.Value = controlTemplate2;
				style2.Setters.Add(setter3);
				return style2;
			}

			// Token: 0x0600144C RID: 5196 RVA: 0x0005B188 File Offset: 0x00059388
			private static void OnMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = sender as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
				if (cellValuePresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.ConditionInfoGroup conditionInfoGroup = cellValuePresenter.Tag as global::Infragistics.Windows.DataPresenter.ConditionInfoGroup;
					if (conditionInfoGroup != null)
					{
						global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl customFilterSelectionControl = global::Infragistics.Windows.Utilities.GetAncestorFromType(cellValuePresenter, typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), true) as global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl;
						if (customFilterSelectionControl != null)
						{
							global::Infragistics.Windows.Controls.LogicalOperator logicalOperator = (conditionInfoGroup.LogicalOperator == global::Infragistics.Windows.Controls.LogicalOperator.And) ? global::Infragistics.Windows.Controls.LogicalOperator.Or : global::Infragistics.Windows.Controls.LogicalOperator.And;
							conditionInfoGroup.LogicalOperator = logicalOperator;
							customFilterSelectionControl.RefreshConditionsGrid();
						}
					}
				}
			}

			// Token: 0x04000855 RID: 2133
			private global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl _customFilterSelectionControl;
		}

		// Token: 0x0200014F RID: 335
		private class ComparisonOperatorToListItemConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x0600144D RID: 5197 RVA: 0x0005B1E2 File Offset: 0x000593E2
			internal ComparisonOperatorToListItemConverter(global::Infragistics.Windows.Controls.ComparisonOperatorSelector selector)
			{
				this._selector = selector;
			}

			// Token: 0x0600144E RID: 5198 RVA: 0x0005B1F4 File Offset: 0x000593F4
			object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				if (value is global::Infragistics.Windows.Controls.ComparisonOperator)
				{
					global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator = (global::Infragistics.Windows.Controls.ComparisonOperator)value;
					foreach (global::Infragistics.Windows.Controls.ComparisonOperatorListItem comparisonOperatorListItem in this._selector.Items)
					{
						if (comparisonOperatorListItem.Operator == comparisonOperator)
						{
							return comparisonOperatorListItem;
						}
					}
					this._selector.SelectedOperator = new global::Infragistics.Windows.Controls.ComparisonOperator?(comparisonOperator);
					return this._selector.SelectedOperatorInfo;
				}
				return value;
			}

			// Token: 0x0600144F RID: 5199 RVA: 0x0005B27C File Offset: 0x0005947C
			object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				global::Infragistics.Windows.Controls.ComparisonOperatorListItem comparisonOperatorListItem = value as global::Infragistics.Windows.Controls.ComparisonOperatorListItem;
				if (comparisonOperatorListItem != null)
				{
					return comparisonOperatorListItem.Operator;
				}
				return value;
			}

			// Token: 0x04000856 RID: 2134
			private global::Infragistics.Windows.Controls.ComparisonOperatorSelector _selector;
		}

		// Token: 0x02000150 RID: 336
		private class ComboEditorInitializer
		{
			// Token: 0x06001450 RID: 5200 RVA: 0x0005B2A0 File Offset: 0x000594A0
			internal ComboEditorInitializer(global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider, bool? isEditable, global::Infragistics.Windows.Editors.DisplayValueSource? displayValueSource)
			{
				this._itemsProvider = itemsProvider;
				this._isEditable = isEditable;
				this._displayValueSource = displayValueSource;
			}

			// Token: 0x06001451 RID: 5201 RVA: 0x0005B2C8 File Offset: 0x000594C8
			public void Initialize(global::Infragistics.Windows.Editors.XamComboEditor editor)
			{
				if (editor != null)
				{
					editor.ItemsProvider = this._itemsProvider;
					if (this._isEditable != null)
					{
						editor.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.IsEditableProperty, this._isEditable);
					}
					if (this._displayValueSource != null)
					{
						editor.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueSourceProperty, this._displayValueSource);
					}
				}
			}

			// Token: 0x04000857 RID: 2135
			private global::Infragistics.Windows.Editors.ComboBoxItemsProvider _itemsProvider;

			// Token: 0x04000858 RID: 2136
			private object _isEditable;

			// Token: 0x04000859 RID: 2137
			private object _displayValueSource;
		}
	}
}
