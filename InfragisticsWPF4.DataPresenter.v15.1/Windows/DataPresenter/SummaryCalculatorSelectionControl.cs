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
	// Token: 0x020001C5 RID: 453
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryCalculatorSelectionControl : global::System.Windows.Controls.Control
	{
		// Token: 0x06001AD2 RID: 6866 RVA: 0x00078D40 File Offset: 0x00076F40
		static SummaryCalculatorSelectionControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), global::System.Windows.Input.Keyboard.PreviewLostKeyboardFocusEvent, new global::System.Windows.Input.KeyboardFocusChangedEventHandler(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl.OnPreviousLostKeyboardFocus));
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x00078E42 File Offset: 0x00077042
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x00078E54 File Offset: 0x00077054
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x00078E67 File Offset: 0x00077067
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x00078E79 File Offset: 0x00077079
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00078E88 File Offset: 0x00077088
		private static void OnFieldChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl summaryCalculatorSelectionControl = (global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl)dependencyObject;
			summaryCalculatorSelectionControl.UpdateSettings();
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x00078EA2 File Offset: 0x000770A2
		// (set) Token: 0x06001ADA RID: 6874 RVA: 0x00078EB4 File Offset: 0x000770B4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x00078EC2 File Offset: 0x000770C2
		internal bool HideInsteadOfRemove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00078EC8 File Offset: 0x000770C8
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

		// Token: 0x06001ADD RID: 6877 RVA: 0x00078F9C File Offset: 0x0007719C
		internal void OnClosed(bool canceled)
		{
			this.OnOpenedClosedHelper(false, canceled);
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00078FC8 File Offset: 0x000771C8
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
							global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsShown = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition>();
							global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsHidden = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition>();
							foreach (global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder holder2 in summaryCalculatorHolders2)
							{
								if (this.SyncSummariesWithHolder(field, holder2, definitionsRemoved, definitionsAdded, definitionsShown, definitionsHidden))
								{
									summariesChanged = true;
								}
							}
							global::Infragistics.Windows.DataPresenter.SummaryAction summaryAction = global::Infragistics.Windows.DataPresenter.SummaryAction.Create(field, oldDefinitionList, definitionsRemoved, definitionsAdded, definitionsShown, definitionsHidden);
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

		// Token: 0x06001ADF RID: 6879 RVA: 0x00079174 File Offset: 0x00077374
		internal bool OnOpenning()
		{
			return this.OnOpenedClosedHelper(true, false);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00079180 File Offset: 0x00077380
		private static void OnPreviousLostKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl dependencyObject = sender as global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl;
			if (e.NewFocus is global::System.Windows.Window && global::System.Windows.Media.VisualTreeHelper.GetParent((global::System.Windows.Window)e.NewFocus) == null && global::System.Windows.Window.GetWindow(dependencyObject) == e.NewFocus)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x000791C8 File Offset: 0x000773C8
		internal void SyncHolderWithSummaries(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder holder)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (field != null) ? field.Owner : null;
			bool isChecked = false;
			if (fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitionsIfAllocated = fieldLayout.SummaryDefinitionsIfAllocated;
				global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = (summaryDefinitionsIfAllocated == null) ? null : global::Infragistics.Windows.DataPresenter.GridUtilities.GetFirstItem<global::Infragistics.Windows.DataPresenter.SummaryDefinition>(summaryDefinitionsIfAllocated.GetMatchingSummaries(holder.Calculator, field));
				if (summaryDefinition != null && (!this.HideInsteadOfRemove || summaryDefinition.IsVisible))
				{
					isChecked = true;
				}
			}
			holder.IsChecked = isChecked;
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00079224 File Offset: 0x00077424
		private bool SyncSummariesWithHolder(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder holder, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsRemoved, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsAdded, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsShown, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsHidden)
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
							foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition2 in global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.SummaryDefinition>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryDefinition>[]
							{
								summaryDefinitionCollection.GetMatchingSummaries(null, field)
							}))
							{
								if (this.HideInsteadOfRemove)
								{
									definitionsHidden.Add(summaryDefinition2);
									summaryDefinition2.IsVisible = false;
								}
								else
								{
									definitionsRemoved.Add(summaryDefinition2);
									summaryDefinitionCollection.Remove(summaryDefinition2);
								}
							}
							return true;
						}
					}
					else
					{
						if (summaryDefinition == null)
						{
							summaryDefinitionCollection = fieldLayout.SummaryDefinitions;
							global::Infragistics.Windows.DataPresenter.SummaryDefinition item = summaryDefinitionCollection.AddInternal(null, holder.Calculator, field.Name, true);
							definitionsAdded.Add(item);
							return true;
						}
						if (this.HideInsteadOfRemove && !summaryDefinition.IsVisible)
						{
							summaryDefinition.IsVisible = true;
							return true;
						}
					}
				}
				else if (summaryDefinition != null)
				{
					int num = 0;
					if (summaryDefinitionCollection != null)
					{
						if (this.HideInsteadOfRemove)
						{
							if (summaryDefinition.IsVisible)
							{
								definitionsHidden.Add(summaryDefinition);
								summaryDefinition.IsVisible = false;
								num++;
							}
						}
						else
						{
							definitionsRemoved.Add(summaryDefinition);
							summaryDefinitionCollection.Remove(summaryDefinition);
							num++;
						}
					}
					return num > 0;
				}
			}
			return false;
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00079374 File Offset: 0x00077574
		private void UpdateSettings()
		{
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			global::Infragistics.Windows.DataPresenter.SummaryUIType summaryUIType = (field != null) ? field.SummaryUITypeResolved : global::Infragistics.Windows.DataPresenter.SummaryUIType.Default;
			this.AllowMultipleSummaries = (global::Infragistics.Windows.DataPresenter.SummaryUIType.MultiSelect == summaryUIType || global::Infragistics.Windows.DataPresenter.SummaryUIType.MultiSelectForNumericsOnly == summaryUIType);
			this.SummaryCalculatorHolders = this.GetApplicableSummaryCalculators(field);
		}

		// Token: 0x04000AD1 RID: 2769
		public static readonly global::System.Windows.DependencyProperty AllowMultipleSummariesProperty = global::System.Windows.DependencyProperty.Register("AllowMultipleSummaries", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000AD2 RID: 2770
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl.OnFieldChanged)));

		// Token: 0x04000AD3 RID: 2771
		public static readonly global::System.Windows.DependencyProperty SummaryCalculatorHoldersProperty = global::System.Windows.DependencyProperty.Register("SummaryCalculatorHolders", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder>), typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x020001C8 RID: 456
		private class NonePlaceHolder : global::Infragistics.Windows.DataPresenter.SummaryCalculator
		{
			// Token: 0x1700078B RID: 1931
			// (get) Token: 0x06001B04 RID: 6916 RVA: 0x000798D0 File Offset: 0x00077AD0
			public override string Description
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("SummarySelectionControl_None_Entry_Tooltip");
				}
			}

			// Token: 0x1700078C RID: 1932
			// (get) Token: 0x06001B05 RID: 6917 RVA: 0x000798DC File Offset: 0x00077ADC
			public override string DisplayName
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("SummarySelectionControl_None_Entry_Text");
				}
			}

			// Token: 0x1700078D RID: 1933
			// (get) Token: 0x06001B06 RID: 6918 RVA: 0x000798E8 File Offset: 0x00077AE8
			public override string Name
			{
				get
				{
					return "None";
				}
			}

			// Token: 0x06001B07 RID: 6919 RVA: 0x000798EF File Offset: 0x00077AEF
			public override void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
			{
			}

			// Token: 0x06001B08 RID: 6920 RVA: 0x000798F1 File Offset: 0x00077AF1
			public override void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
			{
			}

			// Token: 0x06001B09 RID: 6921 RVA: 0x000798F3 File Offset: 0x00077AF3
			public override bool CanProcessDataType(global::System.Type dataType)
			{
				return false;
			}

			// Token: 0x06001B0A RID: 6922 RVA: 0x000798F6 File Offset: 0x00077AF6
			public override object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
			{
				return null;
			}
		}
	}
}
