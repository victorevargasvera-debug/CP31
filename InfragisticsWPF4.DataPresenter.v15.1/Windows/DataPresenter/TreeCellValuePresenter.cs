using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000067 RID: 103
	[global::System.Windows.TemplateVisualState(Name = "Expanded", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Collapsed", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplatePart(Name = "PART_Expander", Type = typeof(global::System.Windows.FrameworkElement))]
	public class TreeCellValuePresenter : global::Infragistics.Windows.DataPresenter.CellValuePresenter
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x00015D7C File Offset: 0x00013F7C
		static TreeCellValuePresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter)));
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00015EB4 File Offset: 0x000140B4
		internal override bool IsCellEnabled
		{
			get
			{
				bool isCellEnabled = base.IsCellEnabled;
				if (isCellEnabled != this._isContentEnabled)
				{
					this._isContentEnabled = isCellEnabled;
					base.SetValue(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.IsContentEnabledPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._isContentEnabled));
				}
				return true;
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00015EEF File Offset: 0x000140EF
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.InitializeTreeExpander();
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00015F00 File Offset: 0x00014100
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::System.Windows.FrameworkElement.DataContextProperty)
			{
				this._inDataContextChanged = true;
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				if (record != null)
				{
					this.IsExpanded = record.IsExpanded;
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
					binding.Path = new global::System.Windows.PropertyPath("ExpansionIndicatorVisibility", new object[0]);
					binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
					binding.Source = base.Record;
					base.SetBinding(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.ExpansionIndicatorVisibilityProperty, binding);
					int nestingDepthOfDataRcds = record.NestingDepthOfDataRcds;
					if (nestingDepthOfDataRcds < 1)
					{
						if (this._indentPerLevelTracker != null)
						{
							this._indentPerLevelTracker = null;
						}
						base.SetValue(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.IndentPropertyKey, 0.0);
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = record.DataPresenter;
						global::Infragistics.Windows.DataPresenter.TreeView treeView = (dataPresenter != null) ? (dataPresenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.TreeView) : null;
						if (this._indentPerLevelTracker == null && treeView != null)
						{
							this._indentPerLevelTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(treeView, "ViewSettings.IndentPerLevel", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.CalculateIndent));
						}
						this.CalculateIndent();
					}
				}
				else
				{
					global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.ExpansionIndicatorVisibilityProperty);
				}
				this._inDataContextChanged = false;
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00016014 File Offset: 0x00014214
		protected override void OnRecordPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnRecordPropertyChanged(e);
			if (base.Record == null)
			{
				return;
			}
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (!(propertyName == "IsExpanded"))
				{
					return;
				}
				this.IsExpanded = base.Record.IsExpanded;
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0001605C File Offset: 0x0001425C
		protected override void ProcessPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
			global::Infragistics.Windows.Controls.ExpansionIndicator expansionIndicator = (dependencyObject != null) ? (global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::Infragistics.Windows.Controls.ExpansionIndicator), true, this) as global::Infragistics.Windows.Controls.ExpansionIndicator) : null;
			if (expansionIndicator != null)
			{
				return;
			}
			base.ProcessPreviewMouseLeftButtonDown(e);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0001609E File Offset: 0x0001429E
		protected override void SetVisualState(bool useTransitions)
		{
			base.SetVisualState(useTransitions);
			if (this.IsExpanded)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Expanded", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Collapsed", useTransitions);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000160CC File Offset: 0x000142CC
		private static void OnExpansionIndicatorVisibilityChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter treeCellValuePresenter = target as global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter;
			if (treeCellValuePresenter != null && !treeCellValuePresenter._inDataContextChanged && treeCellValuePresenter.Record != null && !treeCellValuePresenter.Record.DataPresenter.IsSynchronousControl)
			{
				global::Infragistics.Windows.DataPresenter.TreeViewPanel treeViewPanel = global::Infragistics.Windows.Utilities.GetAncestorFromType(treeCellValuePresenter, typeof(global::Infragistics.Windows.DataPresenter.TreeViewPanel), true) as global::Infragistics.Windows.DataPresenter.TreeViewPanel;
				if (treeViewPanel != null)
				{
					treeViewPanel.InvalidateLines();
				}
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00016125 File Offset: 0x00014325
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00016137 File Offset: 0x00014337
		public global::System.Windows.Visibility ExpansionIndicatorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.ExpansionIndicatorVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.ExpansionIndicatorVisibilityProperty, value);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0001614A File Offset: 0x0001434A
		public double Indent
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.IndentProperty);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0001615C File Offset: 0x0001435C
		public bool IsContentEnabled
		{
			get
			{
				return this._isContentEnabled;
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00016164 File Offset: 0x00014364
		private static object CoerceIsExpanded(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter treeCellValuePresenter = target as global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter;
			if (treeCellValuePresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = treeCellValuePresenter.Record;
				if (record != null && treeCellValuePresenter.DataPresenter != null)
				{
					if (record.IsExpanded != (bool)value)
					{
						record.IsExpanded = (bool)value;
					}
					if (record.IsExpanded != (bool)value)
					{
						if (record.DataPresenter.IsSynchronousControl)
						{
							treeCellValuePresenter.ResyncIsExpandedState();
						}
						else
						{
							treeCellValuePresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(treeCellValuePresenter.ResyncIsExpandedState));
						}
					}
				}
			}
			return (bool)value;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000161EE File Offset: 0x000143EE
		private void ResyncIsExpandedState()
		{
			if (base.Record != null && base.Record.IsExpanded != this.IsExpanded)
			{
				this.IsExpanded = base.Record.IsExpanded;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0001621C File Offset: 0x0001441C
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x0001623B File Offset: 0x0001443B
		public bool IsExpanded
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record record = base.Record;
				return record != null && record.IsExpanded;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.IsExpandedProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00016250 File Offset: 0x00014450
		private void CalculateIndent()
		{
			global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
			if (record != null)
			{
				int nestingDepthOfDataRcds = record.NestingDepthOfDataRcds;
				if (nestingDepthOfDataRcds > 0)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = record.DataPresenter;
					if (dataPresenter != null)
					{
						base.SetValue(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.IndentPropertyKey, dataPresenter.CurrentViewInternal.LevelIndentationResolved * (double)nestingDepthOfDataRcds);
						return;
					}
				}
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.IndentPropertyKey, 0.0);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000162B4 File Offset: 0x000144B4
		private void InitializeTreeExpander()
		{
			this._expander = (base.GetTemplateChild("PART_Expander") as global::System.Windows.FrameworkElement);
			if (this._expander != null)
			{
				this._recordPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
				if (this._recordPresenter != null)
				{
					this._recordPresenter.TreeExpander = this._expander;
					if (base.IsLoaded)
					{
						base.Unloaded += this.OnUnloaded;
					}
				}
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0001632E File Offset: 0x0001452E
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OnLoaded;
			this.InitializeTreeExpander();
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00016348 File Offset: 0x00014548
		private void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Unloaded -= this.OnUnloaded;
			if (this._recordPresenter != null)
			{
				if (this._recordPresenter.TreeExpander == this._expander)
				{
					this._recordPresenter.TreeExpander = null;
					this._recordPresenter = null;
				}
				this._expander = null;
				base.Loaded += this.OnLoaded;
			}
		}

		// Token: 0x040001BA RID: 442
		private global::Infragistics.Windows.DataPresenter.RecordPresenter _recordPresenter;

		// Token: 0x040001BB RID: 443
		private global::System.Windows.FrameworkElement _expander;

		// Token: 0x040001BC RID: 444
		private global::Infragistics.Windows.Internal.PropertyValueTracker _indentPerLevelTracker;

		// Token: 0x040001BD RID: 445
		private bool _isContentEnabled = true;

		// Token: 0x040001BE RID: 446
		private bool _inDataContextChanged;

		// Token: 0x040001BF RID: 447
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityHiddenBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.OnExpansionIndicatorVisibilityChanged)));

		// Token: 0x040001C0 RID: 448
		internal static readonly global::System.Windows.DependencyPropertyKey IndentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Indent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(0.0));

		// Token: 0x040001C1 RID: 449
		public static readonly global::System.Windows.DependencyProperty IndentProperty = global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.IndentPropertyKey.DependencyProperty;

		// Token: 0x040001C2 RID: 450
		private static readonly global::System.Windows.DependencyPropertyKey IsContentEnabledPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsContentEnabled", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040001C3 RID: 451
		public static readonly global::System.Windows.DependencyProperty IsContentEnabledProperty = global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.IsContentEnabledPropertyKey.DependencyProperty;

		// Token: 0x040001C4 RID: 452
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty = global::System.Windows.DependencyProperty.Register("IsExpanded", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.CoerceIsExpanded)));
	}
}
