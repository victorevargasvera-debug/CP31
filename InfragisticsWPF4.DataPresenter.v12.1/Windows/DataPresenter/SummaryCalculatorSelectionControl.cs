using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001A2 RID: 418
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryCalculatorSelectionControl : global::System.Windows.Controls.Control
	{
		// Token: 0x06001715 RID: 5909 RVA: 0x000661A8 File Offset: 0x000643A8
		static SummaryCalculatorSelectionControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), global::System.Windows.Input.Keyboard.PreviewLostKeyboardFocusEvent, new global::System.Windows.Input.KeyboardFocusChangedEventHandler(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl.OnPreviousLostKeyboardFocus));
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x000662AA File Offset: 0x000644AA
		// (set) Token: 0x06001718 RID: 5912 RVA: 0x000662BC File Offset: 0x000644BC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowMultipleSummaries
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl.AllowMultipleSummariesProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl.AllowMultipleSummariesProperty, value);
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x000662CF File Offset: 0x000644CF
		// (set) Token: 0x0600171A RID: 5914 RVA: 0x000662E1 File Offset: 0x000644E1
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Field)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl.FieldProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl.FieldProperty, value);
			}
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000662F0 File Offset: 0x000644F0
		private static void OnFieldChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl summaryCalculatorSelectionControl = (global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl)dependencyObject;
			summaryCalculatorSelectionControl.UpdateSettings();
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x0006630A File Offset: 0x0006450A
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x0006631C File Offset: 0x0006451C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder> SummaryCalculatorHolders
		{
			get
			{
				return (global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder>)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl.SummaryCalculatorHoldersProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl.SummaryCalculatorHoldersProperty, value);
			}
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0006632C File Offset: 0x0006452C
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder> GetApplicableSummaryCalculators(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder>();
			if (field == null)
			{
				return list;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitionCollection = (owner != null) ? owner.SummaryDefinitionsIfAllocated : null;
			bool flag = false;
			foreach (global::Infragistics.Windows.DataPresenter.SummaryCalculator summaryCalculator in global::Infragistics.Windows.DataPresenter.SummaryCalculator.RegisteredCalculators)
			{
				if (summaryCalculator.CanProcessDataType(field.EditAsTypeResolved))
				{
					global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryDefinition> e = (summaryDefinitionCollection == null) ? null : summaryDefinitionCollection.GetMatchingSummaries(summaryCalculator, field);
					bool flag2 = global::Infragistics.Windows.DataPresenter.GridUtilities.HasItems(e);
					flag = (flag || flag2);
					list.Add(new global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder(this, summaryCalculator, flag2));
				}
			}
			if (!this.AllowMultipleSummaries)
			{
				global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder item = new global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder(this, new global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl.NonePlaceHolder(), !flag);
				list.Insert(0, item);
			}
			return list;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00066400 File Offset: 0x00064600
		internal void OnClosed(bool canceled)
		{
			this.OnOpenedClosedHelper(false, canceled);
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0006642C File Offset: 0x0006462C
		private bool OnOpenedClosedHelper(bool opened, bool closeCanceled)
		{
			if (opened)
			{
				this.UpdateSettings();
			}
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (field != null) ? field.Owner : null;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (fieldLayout != null) ? fieldLayout.DataPresenter : null;
			if (dataPresenterBase != null)
			{
				if (opened)
				{
					global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlOpeningEventArgs summarySelectionControlOpeningEventArgs = new global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlOpeningEventArgs(field, this);
					dataPresenterBase.RaiseSummarySelectionControlOpening(summarySelectionControlOpeningEventArgs);
					if (summarySelectionControlOpeningEventArgs.Cancel)
					{
						return false;
					}
					global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder> summaryCalculatorHolders = this.SummaryCalculatorHolders;
					if (summaryCalculatorHolders != null)
					{
						foreach (global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder holder in summaryCalculatorHolders)
						{
							this.SyncHolderWithSummaries(field, holder);
						}
					}
					global::System.Windows.Threading.DispatcherOperationCallback method = delegate(object param)
					{
						if (base.IsVisible && global::System.Windows.Input.Keyboard.FocusedElement == param)
						{
							this.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
						}
						return null;
					};
					base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, method, global::System.Windows.Input.Keyboard.FocusedElement);
				}
				else
				{
					bool summariesChanged = false;
					if (!closeCanceled)
					{
						global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder> summaryCalculatorHolders2 = this.SummaryCalculatorHolders;
						if (summaryCalculatorHolders2 != null)
						{
							global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryDefinition> oldDefinitionList = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition>(fieldLayout.SummaryDefinitions);
							global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsRemoved = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition>();
							global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsAdded = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition>();
							foreach (global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder holder2 in summaryCalculatorHolders2)
							{
								if (this.SyncSummariesWithHolder(field, holder2, definitionsRemoved, definitionsAdded))
								{
									summariesChanged = true;
								}
							}
							global::Infragistics.Windows.DataPresenter.SummaryAction summaryAction = global::Infragistics.Windows.DataPresenter.SummaryAction.Create(field, oldDefinitionList, definitionsRemoved, definitionsAdded);
							if (summaryAction != null && dataPresenterBase.IsUndoEnabled)
							{
								dataPresenterBase.History.AddUndoActionInternal(summaryAction);
							}
						}
					}
					global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlClosedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlClosedEventArgs(field, summariesChanged);
					dataPresenterBase.RaiseSummarySelectionControlClosed(args);
				}
			}
			return true;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x000665C0 File Offset: 0x000647C0
		internal bool OnOpenning()
		{
			return this.OnOpenedClosedHelper(true, false);
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x000665CC File Offset: 0x000647CC
		private static void OnPreviousLostKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl dependencyObject = sender as global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl;
			if (e.NewFocus is global::System.Windows.Window && global::System.Windows.Media.VisualTreeHelper.GetParent((global::System.Windows.Window)e.NewFocus) == null && global::System.Windows.Window.GetWindow(dependencyObject) == e.NewFocus)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00066614 File Offset: 0x00064814
		internal void SyncHolderWithSummaries(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder holder)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (field != null) ? field.Owner : null;
			bool isChecked = false;
			if (fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitionsIfAllocated = fieldLayout.SummaryDefinitionsIfAllocated;
				global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = (summaryDefinitionsIfAllocated == null) ? null : global::Infragistics.Windows.DataPresenter.GridUtilities.GetFirstItem<global::Infragistics.Windows.DataPresenter.SummaryDefinition>(summaryDefinitionsIfAllocated.GetMatchingSummaries(holder.Calculator, field));
				if (summaryDefinition != null)
				{
					isChecked = true;
				}
			}
			holder.IsChecked = isChecked;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00066660 File Offset: 0x00064860
		private bool SyncSummariesWithHolder(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder holder, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsRemoved, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsAdded)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (field != null) ? field.Owner : null;
			if (fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitionCollection = fieldLayout.SummaryDefinitionsIfAllocated;
				global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = (summaryDefinitionCollection == null) ? null : global::Infragistics.Windows.DataPresenter.GridUtilities.GetFirstItem<global::Infragistics.Windows.DataPresenter.SummaryDefinition>(summaryDefinitionCollection.GetMatchingSummaries(holder.Calculator, field));
				if (holder.IsChecked)
				{
					if (holder.Calculator is global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl.NonePlaceHolder)
					{
						if (summaryDefinitionCollection != null)
						{
							foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition item in global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.SummaryDefinition>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryDefinition>[]
							{
								summaryDefinitionCollection.GetMatchingSummaries(null, field)
							}))
							{
								definitionsRemoved.Add(item);
								summaryDefinitionCollection.Remove(item);
							}
							return true;
						}
					}
					else if (summaryDefinition == null)
					{
						summaryDefinitionCollection = fieldLayout.SummaryDefinitions;
						global::Infragistics.Windows.DataPresenter.SummaryDefinition item2 = summaryDefinitionCollection.Add(holder.Calculator, field.Name);
						definitionsAdded.Add(item2);
						return true;
					}
				}
				else if (summaryDefinition != null)
				{
					if (summaryDefinitionCollection != null)
					{
						definitionsRemoved.Add(summaryDefinition);
						summaryDefinitionCollection.Remove(summaryDefinition);
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00066748 File Offset: 0x00064948
		private void UpdateSettings()
		{
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			global::Infragistics.Windows.DataPresenter.SummaryUIType summaryUIType = (field != null) ? field.SummaryUITypeResolved : global::Infragistics.Windows.DataPresenter.SummaryUIType.Default;
			this.AllowMultipleSummaries = (global::Infragistics.Windows.DataPresenter.SummaryUIType.MultiSelect == summaryUIType || global::Infragistics.Windows.DataPresenter.SummaryUIType.MultiSelectForNumericsOnly == summaryUIType);
			this.SummaryCalculatorHolders = this.GetApplicableSummaryCalculators(field);
		}

		// Token: 0x04000907 RID: 2311
		public static readonly global::System.Windows.DependencyProperty AllowMultipleSummariesProperty = global::System.Windows.DependencyProperty.Register("AllowMultipleSummaries", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000908 RID: 2312
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl.OnFieldChanged)));

		// Token: 0x04000909 RID: 2313
		public static readonly global::System.Windows.DependencyProperty SummaryCalculatorHoldersProperty = global::System.Windows.DependencyProperty.Register("SummaryCalculatorHolders", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder>), typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x020001A5 RID: 421
		private class NonePlaceHolder : global::Infragistics.Windows.DataPresenter.SummaryCalculator
		{
			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x06001746 RID: 5958 RVA: 0x00066CA4 File Offset: 0x00064EA4
			public override string Description
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("SummarySelectionControl_None_Entry_Tooltip");
				}
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x06001747 RID: 5959 RVA: 0x00066CB0 File Offset: 0x00064EB0
			public override string DisplayName
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("SummarySelectionControl_None_Entry_Text");
				}
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x06001748 RID: 5960 RVA: 0x00066CBC File Offset: 0x00064EBC
			public override string Name
			{
				get
				{
					return "None";
				}
			}

			// Token: 0x06001749 RID: 5961 RVA: 0x00066CC3 File Offset: 0x00064EC3
			public override void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
			{
			}

			// Token: 0x0600174A RID: 5962 RVA: 0x00066CC5 File Offset: 0x00064EC5
			public override void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
			{
			}

			// Token: 0x0600174B RID: 5963 RVA: 0x00066CC7 File Offset: 0x00064EC7
			public override bool CanProcessDataType(global::System.Type dataType)
			{
				return false;
			}

			// Token: 0x0600174C RID: 5964 RVA: 0x00066CCA File Offset: 0x00064ECA
			public override object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
			{
				return null;
			}
		}
	}
}
