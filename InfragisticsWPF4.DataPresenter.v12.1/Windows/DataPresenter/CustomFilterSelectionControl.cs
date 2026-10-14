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
	// Token: 0x02000131 RID: 305
	[global::System.Windows.TemplatePart(Name = "PART_ConditionsGrid", Type = typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CustomFilterSelectionControl : global::System.Windows.Controls.Control
	{
		// Token: 0x0600107A RID: 4218 RVA: 0x00046D4C File Offset: 0x00044F4C
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

		// Token: 0x0600107B RID: 4219 RVA: 0x000473C8 File Offset: 0x000455C8
		public CustomFilterSelectionControl()
		{
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.SetControl(this, this);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x000473D7 File Offset: 0x000455D7
		public CustomFilterSelectionControl(global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter, global::Infragistics.Windows.DataPresenter.RecordManager recordManager) : this()
		{
			this.Initialize(recordFilter, recordManager);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x000473E8 File Offset: 0x000455E8
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
					e.CanExecute = (customFilterSelectionControl._conditionsGrid != null && !customFilterSelectionControl.IsConditionInEditMode && (customFilterSelectionControl._conditionsGrid.SelectedItems.Records.Count > 0 || customFilterSelectionControl._conditionsGrid.ActiveRecord != null));
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
					e.CanExecute = (customFilterSelectionControl._conditionsGrid != null && !customFilterSelectionControl.IsConditionInEditMode && (customFilterSelectionControl._conditionsGrid.SelectedItems.Records.Count > 0 || customFilterSelectionControl._conditionsGrid.ActiveRecord != null) && !customFilterSelectionControl._currentSelectionSpansMultipleGroups);
				}
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0004755C File Offset: 0x0004575C
		private static void ExecuteCommandHandler(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl customFilterSelectionControl = sender as global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl;
			if (customFilterSelectionControl != null)
			{
				customFilterSelectionControl.ExecuteCommandImpl(e.Command as global::System.Windows.Input.RoutedCommand, e.Parameter, e.Source, e.OriginalSource);
			}
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00047598 File Offset: 0x00045798
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

		// Token: 0x06001080 RID: 4224 RVA: 0x00047664 File Offset: 0x00045864
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

		// Token: 0x06001081 RID: 4225 RVA: 0x00047780 File Offset: 0x00045980
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

		// Token: 0x06001082 RID: 4226 RVA: 0x000477C8 File Offset: 0x000459C8
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

		// Token: 0x06001083 RID: 4227 RVA: 0x0004783C File Offset: 0x00045A3C
		private bool ExecuteGroupSelectedConditionsAsAndGroupCommand(object source, object originalSource, object parameter)
		{
			return this.GroupSelectedConditionsHelper(global::Infragistics.Windows.Controls.LogicalOperator.And);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00047845 File Offset: 0x00045A45
		private bool ExecuteGroupSelectedConditionsAsOrGroupCommand(object source, object originalSource, object parameter)
		{
			return this.GroupSelectedConditionsHelper(global::Infragistics.Windows.Controls.LogicalOperator.Or);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0004784E File Offset: 0x00045A4E
		private bool ExecuteRemoveSelectedConditionsCommand(object source, object originalSource, object parameter)
		{
			return this.RemoveSelectedConditions();
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00047858 File Offset: 0x00045A58
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

		// Token: 0x06001087 RID: 4231 RVA: 0x000478AC File Offset: 0x00045AAC
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

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x00047974 File Offset: 0x00045B74
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

		// Token: 0x06001089 RID: 4233 RVA: 0x000479BC File Offset: 0x00045BBC
		protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.Delete && this._conditionsGrid != null && this._conditionsGrid.ActiveRecord != null && this._conditionsGrid.IsKeyboardFocusWithin)
			{
				this.RemoveSelectedConditions();
				e.Handled = true;
			}
			base.OnKeyUp(e);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00047A0A File Offset: 0x00045C0A
		public override void OnApplyTemplate()
		{
			this.VerifyParts();
			base.OnApplyTemplate();
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x00047A18 File Offset: 0x00045C18
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x00047A2A File Offset: 0x00045C2A
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

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x00047A38 File Offset: 0x00045C38
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x00047A4A File Offset: 0x00045C4A
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

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x00047A58 File Offset: 0x00045C58
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x00047A6A File Offset: 0x00045C6A
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

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x00047A78 File Offset: 0x00045C78
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x00047A8A File Offset: 0x00045C8A
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

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x00047A98 File Offset: 0x00045C98
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x00047AAA File Offset: 0x00045CAA
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

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x00047AB8 File Offset: 0x00045CB8
		// (set) Token: 0x06001096 RID: 4246 RVA: 0x00047ACA File Offset: 0x00045CCA
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

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x00047AD8 File Offset: 0x00045CD8
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x00047AEA File Offset: 0x00045CEA
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

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x00047AF8 File Offset: 0x00045CF8
		[global::System.ComponentModel.Bindable(true)]
		public string FilterSummaryDescription
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.FilterSummaryDescriptionProperty);
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x00047B0A File Offset: 0x00045D0A
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x00047B1C File Offset: 0x00045D1C
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

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00047B2A File Offset: 0x00045D2A
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x00047B3C File Offset: 0x00045D3C
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

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00047B4A File Offset: 0x00045D4A
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x00047B5C File Offset: 0x00045D5C
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

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00047B6A File Offset: 0x00045D6A
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x00047B7C File Offset: 0x00045D7C
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

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x00047B8F File Offset: 0x00045D8F
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x00047BA1 File Offset: 0x00045DA1
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

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00047BAF File Offset: 0x00045DAF
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00047BC1 File Offset: 0x00045DC1
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

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00047BCF File Offset: 0x00045DCF
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00047BE1 File Offset: 0x00045DE1
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

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x00047BEF File Offset: 0x00045DEF
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.RecordFilter RecordFilter
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordFilter)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RecordFilterProperty);
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x00047C01 File Offset: 0x00045E01
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordManager)base.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RecordManagerProperty);
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x00047C13 File Offset: 0x00045E13
		// (set) Token: 0x060010AB RID: 4267 RVA: 0x00047C25 File Offset: 0x00045E25
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

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x00047C33 File Offset: 0x00045E33
		// (set) Token: 0x060010AD RID: 4269 RVA: 0x00047C45 File Offset: 0x00045E45
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

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x00047C53 File Offset: 0x00045E53
		// (set) Token: 0x060010AF RID: 4271 RVA: 0x00047C65 File Offset: 0x00045E65
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

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x00047C73 File Offset: 0x00045E73
		// (set) Token: 0x060010B1 RID: 4273 RVA: 0x00047C85 File Offset: 0x00045E85
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

		// Token: 0x060010B2 RID: 4274 RVA: 0x00047C93 File Offset: 0x00045E93
		internal static global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl GetControl(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl)d.GetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ControlProperty);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00047CA5 File Offset: 0x00045EA5
		internal static void SetControl(global::System.Windows.DependencyObject d, global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl value)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ControlProperty, value);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00047CB4 File Offset: 0x00045EB4
		private static void OnControlChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl customFilterSelectionControl = e.NewValue as global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl;
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = d as global::Infragistics.Windows.Editors.XamComboEditor;
			if (customFilterSelectionControl != null && xamComboEditor != null)
			{
				customFilterSelectionControl.InitializeComboEditor(xamComboEditor);
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00047CE2 File Offset: 0x00045EE2
		internal bool IsDirty
		{
			get
			{
				return this._isDirty;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x00047CEC File Offset: 0x00045EEC
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

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00047D50 File Offset: 0x00045F50
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

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x00047D9F File Offset: 0x00045F9F
		private bool IsConditionInEditMode
		{
			get
			{
				return this._conditionsGrid != null && this._conditionsGrid.ActiveCell != null && this._conditionsGrid.ActiveCell.IsInEditMode;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x00047DC8 File Offset: 0x00045FC8
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
						this._loader = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader(editor, filterInfo, this._operands, true);
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

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x00047EE8 File Offset: 0x000460E8
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

		// Token: 0x060010BB RID: 4283 RVA: 0x00047F08 File Offset: 0x00046108
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

		// Token: 0x060010BC RID: 4284 RVA: 0x0004817C File Offset: 0x0004637C
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
					global::Infragistics.Windows.DataPresenter.Field field = new global::Infragistics.Windows.DataPresenter.UnboundField();
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

		// Token: 0x060010BD RID: 4285 RVA: 0x00048300 File Offset: 0x00046500
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

		// Token: 0x060010BE RID: 4286 RVA: 0x00048368 File Offset: 0x00046568
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

		// Token: 0x060010BF RID: 4287 RVA: 0x000484A8 File Offset: 0x000466A8
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

		// Token: 0x060010C0 RID: 4288 RVA: 0x000486D4 File Offset: 0x000468D4
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

		// Token: 0x060010C1 RID: 4289 RVA: 0x00048754 File Offset: 0x00046954
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> GetSelectedConditionInfos()
		{
			return this.GetSelectedConditionInfos(false);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00048760 File Offset: 0x00046960
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

		// Token: 0x060010C3 RID: 4291 RVA: 0x0004882C File Offset: 0x00046A2C
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> GetSelectedRecordsInVisibleIndexOrder(global::Infragistics.Windows.DataPresenter.SelectedRecordCollection selectedRecords)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>(selectedRecords.ToArray());
			list.Sort(new global::Infragistics.Windows.DataPresenter.RecordVisibleIndexComparer());
			return list;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00048854 File Offset: 0x00046A54
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

		// Token: 0x060010C5 RID: 4293 RVA: 0x0004891C File Offset: 0x00046B1C
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

		// Token: 0x060010C6 RID: 4294 RVA: 0x00048964 File Offset: 0x00046B64
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

		// Token: 0x060010C7 RID: 4295 RVA: 0x000489D8 File Offset: 0x00046BD8
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

		// Token: 0x060010C8 RID: 4296 RVA: 0x00048AD4 File Offset: 0x00046CD4
		private void OnConditionInfosCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this._isDirty = true;
			this.RefreshTempRootConditionGroup();
			this.UpdateSelectionDependentFlags();
			this.AddRemoveUnboundFieldsUsedAsGroupingIndicators();
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00048AEF File Offset: 0x00046CEF
		private void OnConditionInfosItemPropertyChanged(object sender, global::Infragistics.Collections.ItemPropertyChangedEventArgs e)
		{
			this._isDirty = true;
			this.RefreshTempRootConditionGroup();
			this.AddRemoveUnboundFieldsUsedAsGroupingIndicators();
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00048B04 File Offset: 0x00046D04
		private void OnConditionsGridCellActivated(object sender, global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs e)
		{
			if (e.Cell.Field.Name == "Value" && this._loader != null)
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(e.Cell);
				this._loader.Editor = ((cellValuePresenter != null) ? global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.Editors.XamComboEditor>(cellValuePresenter, true, null) : null);
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00048B5C File Offset: 0x00046D5C
		private void OnConditionsGridEditModeStarted(object sender, global::Infragistics.Windows.DataPresenter.Events.EditModeStartedEventArgs e)
		{
			if (e.Cell.Field.Name == "Value")
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.SetIsTextSearchEnabled(e.Editor as global::Infragistics.Windows.Editors.XamComboEditor, (global::Infragistics.Windows.Controls.ComparisonOperator)e.Cell.Record.Cells["ComparisonOperator"].Value);
			}
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00048BBC File Offset: 0x00046DBC
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

		// Token: 0x060010CD RID: 4301 RVA: 0x00048C19 File Offset: 0x00046E19
		private void OnDropdownLoadCompleted(object sender, global::System.EventArgs e)
		{
			if (this._loader == sender)
			{
				this._loader.Phase2Completed -= this.OnDropdownLoadCompleted;
				this._loader = null;
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00048C42 File Offset: 0x00046E42
		private void OnConditionsGridRecordsDeleting(object sender, global::Infragistics.Windows.DataPresenter.Events.RecordsDeletingEventArgs e)
		{
			e.Cancel = true;
			this.RemoveSelectedConditions();
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00048C54 File Offset: 0x00046E54
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

		// Token: 0x060010D0 RID: 4304 RVA: 0x00048EDC File Offset: 0x000470DC
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

		// Token: 0x060010D1 RID: 4305 RVA: 0x0004917C File Offset: 0x0004737C
		private void SelectFirstRecord()
		{
			if (this._conditionsGrid.ViewableRecords.Count > 0)
			{
				this._conditionsGrid.SelectedItems.Records.Add(this._conditionsGrid.ViewableRecords[0]);
			}
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x000491B7 File Offset: 0x000473B7
		private void OnSelectedConditionsChanged(object sender, global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs e)
		{
			this.UpdateSelectedStatusOfAllConditionInfos();
			this.UpdateSelectionDependentFlags();
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x000491C8 File Offset: 0x000473C8
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

		// Token: 0x060010D4 RID: 4308 RVA: 0x000492B0 File Offset: 0x000474B0
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

		// Token: 0x060010D5 RID: 4309 RVA: 0x00049320 File Offset: 0x00047520
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

		// Token: 0x060010D6 RID: 4310 RVA: 0x00049418 File Offset: 0x00047618
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

		// Token: 0x060010D7 RID: 4311 RVA: 0x00049488 File Offset: 0x00047688
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

		// Token: 0x060010D8 RID: 4312 RVA: 0x000494F0 File Offset: 0x000476F0
		private void RefreshConditionInfosCollection()
		{
			this._conditionInfos.BeginUpdate();
			this._conditionInfos.Clear();
			this.ProcessConditionInfoGroupForConditionInfoRefresh(this._rootConditionInfoGroup);
			this._conditionInfos.EndUpdate();
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00049520 File Offset: 0x00047720
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

		// Token: 0x060010DA RID: 4314 RVA: 0x000495F4 File Offset: 0x000477F4
		private void RefreshTempRootConditionGroup()
		{
			this._tempRootConditionGroup = new global::Infragistics.Windows.Controls.ConditionGroup();
			this._tempRootConditionGroup.LogicalOperator = this._rootConditionInfoGroup.LogicalOperator;
			this.ProcessConditionInfoGroupForCommit(this._rootConditionInfoGroup, this._tempRootConditionGroup);
			base.SetValue(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.FilterSummaryDescriptionPropertyKey, this._tempRootConditionGroup.ToolTip);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0004964C File Offset: 0x0004784C
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

		// Token: 0x060010DC RID: 4316 RVA: 0x00049830 File Offset: 0x00047A30
		private bool TryEndEditMode()
		{
			if (this.IsConditionInEditMode)
			{
				this._conditionsGrid.ActiveCell.EndEditMode(true);
				return !this._conditionsGrid.ActiveCell.IsInEditMode;
			}
			return true;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00049864 File Offset: 0x00047A64
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

		// Token: 0x060010DE RID: 4318 RVA: 0x00049900 File Offset: 0x00047B00
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

		// Token: 0x060010DF RID: 4319 RVA: 0x00049AA0 File Offset: 0x00047CA0
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

		// Token: 0x060010E0 RID: 4320 RVA: 0x00049B78 File Offset: 0x00047D78
		internal void VerifyParts()
		{
			if (this._conditionsGrid == null)
			{
				this._conditionsGrid = (base.GetTemplateChild("PART_ConditionsGrid") as global::Infragistics.Windows.DataPresenter.XamDataGrid);
			}
		}

		// Token: 0x0400067C RID: 1660
		private const int MAX_GROUPLEVELS = 50;

		// Token: 0x0400067D RID: 1661
		private bool _initializeMethodCalled;

		// Token: 0x0400067E RID: 1662
		private global::Infragistics.Windows.DataPresenter.XamDataGrid _conditionsGrid;

		// Token: 0x0400067F RID: 1663
		private global::Infragistics.Windows.DataPresenter.ConditionInfoCollection _conditionInfos;

		// Token: 0x04000680 RID: 1664
		private global::Infragistics.Windows.DataPresenter.ConditionInfoGroup _rootConditionInfoGroup;

		// Token: 0x04000681 RID: 1665
		private int _totalGroupLevels;

		// Token: 0x04000682 RID: 1666
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _unboundFields;

		// Token: 0x04000683 RID: 1667
		private bool _currentSelectionCanBeGrouped;

		// Token: 0x04000684 RID: 1668
		private bool _currentSelectionCanBeUngrouped;

		// Token: 0x04000685 RID: 1669
		private bool _currentSelectionSpansMultipleGroups;

		// Token: 0x04000686 RID: 1670
		private int _currentSelectionCount;

		// Token: 0x04000687 RID: 1671
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _operands;

		// Token: 0x04000688 RID: 1672
		private bool _isDirty;

		// Token: 0x04000689 RID: 1673
		private global::Infragistics.Windows.Controls.ConditionGroup _tempRootConditionGroup;

		// Token: 0x0400068A RID: 1674
		private global::Infragistics.Windows.Controls.ComparisonOperatorSelector _comparisonOperatorSelector;

		// Token: 0x0400068B RID: 1675
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader _loader;

		// Token: 0x0400068C RID: 1676
		private global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ComboEditorInitializer _operatorInitializer;

		// Token: 0x0400068D RID: 1677
		private global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.ComboEditorInitializer _operandInitializer;

		// Token: 0x0400068E RID: 1678
		public static readonly global::System.Windows.Input.RoutedCommand AddConditionCommand;

		// Token: 0x0400068F RID: 1679
		public static readonly global::System.Windows.Input.RoutedCommand CancelChangesCommand;

		// Token: 0x04000690 RID: 1680
		public static readonly global::System.Windows.Input.RoutedCommand CommitChangesCommand;

		// Token: 0x04000691 RID: 1681
		public static readonly global::System.Windows.Input.RoutedCommand GroupSelectedConditionsAsAndGroupCommand;

		// Token: 0x04000692 RID: 1682
		public static readonly global::System.Windows.Input.RoutedCommand GroupSelectedConditionsAsOrGroupCommand;

		// Token: 0x04000693 RID: 1683
		public static readonly global::System.Windows.Input.RoutedCommand RemoveSelectedConditionsCommand;

		// Token: 0x04000694 RID: 1684
		public static readonly global::System.Windows.Input.RoutedCommand ToggleSelectedGroupLogicalOperatorCommand;

		// Token: 0x04000695 RID: 1685
		public static readonly global::System.Windows.Input.RoutedCommand UngroupSelectedConditionsCommand;

		// Token: 0x04000696 RID: 1686
		public static readonly global::System.Windows.DependencyProperty AddConditionLabelProperty = global::System.Windows.DependencyProperty.Register("AddConditionLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000697 RID: 1687
		public static readonly global::System.Windows.DependencyProperty AndGroupLegendDescriptionProperty = global::System.Windows.DependencyProperty.Register("AndGroupLegendDescription", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000698 RID: 1688
		public static readonly global::System.Windows.DependencyProperty AndLogicalOperatorBrushProperty = global::System.Windows.DependencyProperty.Register("AndLogicalOperatorBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Media.Brushes.Blue));

		// Token: 0x04000699 RID: 1689
		public static readonly global::System.Windows.DependencyProperty CancelButtonLabelProperty = global::System.Windows.DependencyProperty.Register("CancelButtonLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400069A RID: 1690
		public static readonly global::System.Windows.DependencyProperty CancelMessageTextProperty = global::System.Windows.DependencyProperty.Register("CancelMessageText", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400069B RID: 1691
		public static readonly global::System.Windows.DependencyProperty CancelMessageTitleProperty = global::System.Windows.DependencyProperty.Register("CancelMessageTitle", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400069C RID: 1692
		public static readonly global::System.Windows.DependencyProperty FieldDescriptionProperty = global::System.Windows.DependencyProperty.Register("FieldDescription", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400069D RID: 1693
		private static readonly global::System.Windows.DependencyPropertyKey FilterSummaryDescriptionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FilterSummaryDescription", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400069E RID: 1694
		public static readonly global::System.Windows.DependencyProperty FilterSummaryDescriptionProperty = global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.FilterSummaryDescriptionPropertyKey.DependencyProperty;

		// Token: 0x0400069F RID: 1695
		public static readonly global::System.Windows.DependencyProperty GroupSelectedLabelProperty = global::System.Windows.DependencyProperty.Register("GroupSelectedLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040006A0 RID: 1696
		public static readonly global::System.Windows.DependencyProperty GroupSelectedConditionsAsAndGroupLabelProperty = global::System.Windows.DependencyProperty.Register("GroupSelectedConditionsAsAndGroupLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040006A1 RID: 1697
		public static readonly global::System.Windows.DependencyProperty GroupSelectedConditionsAsOrGroupLabelProperty = global::System.Windows.DependencyProperty.Register("GroupSelectedConditionsAsOrGroupLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040006A2 RID: 1698
		public static readonly global::System.Windows.DependencyProperty LogicalOperatorColumnWidthProperty = global::System.Windows.DependencyProperty.Register("LogicalOperatorColumnWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(12.0));

		// Token: 0x040006A3 RID: 1699
		public static readonly global::System.Windows.DependencyProperty OkButtonLabelProperty = global::System.Windows.DependencyProperty.Register("OkButtonLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040006A4 RID: 1700
		public static readonly global::System.Windows.DependencyProperty OrGroupLegendDescriptionProperty = global::System.Windows.DependencyProperty.Register("OrGroupLegendDescription", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040006A5 RID: 1701
		public static readonly global::System.Windows.DependencyProperty OrLogicalOperatorBrushProperty = global::System.Windows.DependencyProperty.Register("OrLogicalOperatorBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Media.Brushes.Red));

		// Token: 0x040006A6 RID: 1702
		private static readonly global::System.Windows.DependencyPropertyKey RecordFilterPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RecordFilter", typeof(global::Infragistics.Windows.DataPresenter.RecordFilter), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040006A7 RID: 1703
		public static readonly global::System.Windows.DependencyProperty RecordFilterProperty = global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RecordFilterPropertyKey.DependencyProperty;

		// Token: 0x040006A8 RID: 1704
		private static readonly global::System.Windows.DependencyPropertyKey RecordManagerPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RecordManager", typeof(global::Infragistics.Windows.DataPresenter.RecordManager), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040006A9 RID: 1705
		public static readonly global::System.Windows.DependencyProperty RecordManagerProperty = global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.RecordManagerPropertyKey.DependencyProperty;

		// Token: 0x040006AA RID: 1706
		public static readonly global::System.Windows.DependencyProperty RemoveSelectedConditionsLabelProperty = global::System.Windows.DependencyProperty.Register("RemoveSelectedConditionsLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040006AB RID: 1707
		public static readonly global::System.Windows.DependencyProperty TitleDescriptionProperty = global::System.Windows.DependencyProperty.Register("TitleDescription", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040006AC RID: 1708
		public static readonly global::System.Windows.DependencyProperty ToggleOperatorOfSelectedConditionsLabelProperty = global::System.Windows.DependencyProperty.Register("ToggleOperatorOfSelectedConditionsLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040006AD RID: 1709
		public static readonly global::System.Windows.DependencyProperty UngroupSelectedConditionsLabelProperty = global::System.Windows.DependencyProperty.Register("UngroupSelectedConditionsLabel", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040006AE RID: 1710
		internal static readonly global::System.Windows.DependencyProperty ControlProperty = global::System.Windows.DependencyProperty.RegisterAttached("Control", typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.OnControlChanged)));

		// Token: 0x02000132 RID: 306
		private class GroupFieldStyleSelector : global::System.Windows.Controls.StyleSelector
		{
			// Token: 0x060010E1 RID: 4321 RVA: 0x00049B98 File Offset: 0x00047D98
			internal GroupFieldStyleSelector(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl customFilterSelectionControl)
			{
				if (customFilterSelectionControl == null)
				{
					throw new global::System.ArgumentException();
				}
				this._customFilterSelectionControl = customFilterSelectionControl;
			}

			// Token: 0x060010E2 RID: 4322 RVA: 0x00049BB0 File Offset: 0x00047DB0
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

			// Token: 0x060010E3 RID: 4323 RVA: 0x00049E8C File Offset: 0x0004808C
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

			// Token: 0x040006AF RID: 1711
			private global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl _customFilterSelectionControl;
		}

		// Token: 0x02000133 RID: 307
		private class ComparisonOperatorToListItemConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x060010E4 RID: 4324 RVA: 0x00049EE6 File Offset: 0x000480E6
			internal ComparisonOperatorToListItemConverter(global::Infragistics.Windows.Controls.ComparisonOperatorSelector selector)
			{
				this._selector = selector;
			}

			// Token: 0x060010E5 RID: 4325 RVA: 0x00049EF8 File Offset: 0x000480F8
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

			// Token: 0x060010E6 RID: 4326 RVA: 0x00049F80 File Offset: 0x00048180
			object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				global::Infragistics.Windows.Controls.ComparisonOperatorListItem comparisonOperatorListItem = value as global::Infragistics.Windows.Controls.ComparisonOperatorListItem;
				if (comparisonOperatorListItem != null)
				{
					return comparisonOperatorListItem.Operator;
				}
				return value;
			}

			// Token: 0x040006B0 RID: 1712
			private global::Infragistics.Windows.Controls.ComparisonOperatorSelector _selector;
		}

		// Token: 0x02000134 RID: 308
		private class ComboEditorInitializer
		{
			// Token: 0x060010E7 RID: 4327 RVA: 0x00049FA4 File Offset: 0x000481A4
			internal ComboEditorInitializer(global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider, bool? isEditable, global::Infragistics.Windows.Editors.DisplayValueSource? displayValueSource)
			{
				this._itemsProvider = itemsProvider;
				this._isEditable = isEditable;
				this._displayValueSource = displayValueSource;
			}

			// Token: 0x060010E8 RID: 4328 RVA: 0x00049FCC File Offset: 0x000481CC
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

			// Token: 0x040006B1 RID: 1713
			private global::Infragistics.Windows.Editors.ComboBoxItemsProvider _itemsProvider;

			// Token: 0x040006B2 RID: 1714
			private object _isEditable;

			// Token: 0x040006B3 RID: 1715
			private object _displayValueSource;
		}
	}
}
