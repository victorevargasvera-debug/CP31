using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Collections;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Resizing;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200020A RID: 522
	[global::System.Windows.TemplateVisualState(Name = "Collapsed", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilterRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "AddRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "DataRecord", GroupName = "RecordStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Changed", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unchanged", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "Expanded", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	public sealed class CardViewCard : global::System.Windows.Controls.ContentControl, global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer, global::Infragistics.Windows.Resizing.IResizableElement
	{
		// Token: 0x06001D17 RID: 7447 RVA: 0x0007F3BC File Offset: 0x0007D5BC
		static CardViewCard()
		{
			if (global::Infragistics.Windows.DataPresenter.CardView.s_HeaderStringFormatProperty != null)
			{
				global::Infragistics.Windows.DataPresenter.CardViewCard.s_HeaderStringFormatProperty = global::Infragistics.Windows.DataPresenter.CardView.s_HeaderStringFormatProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CardViewCard));
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.CardViewCard.s_HeaderStringFormatProperty = global::System.Windows.DependencyProperty.Register("HeaderStringFormat", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(null));
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardViewCard)));
			global::System.Windows.UIElement.RenderTransformProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.CoerceRenderTransform)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), global::System.Windows.UIElement.MouseWheelEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DataPresenter.CardViewCard.OnMouseWheelEvent), true);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DataPresenter.CardViewCard.OnRequestBringIntoView), true);
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x0007F73D File Offset: 0x0007D93D
		global::Infragistics.Windows.DataPresenter.RecordPresenter global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer.RecordPresenter
		{
			get
			{
				return base.Content as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x0007F74A File Offset: 0x0007D94A
		protected override bool HandlesScrolling
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0007F750 File Offset: 0x0007D950
		protected override global::System.Windows.Media.HitTestResult HitTestCore(global::System.Windows.Media.PointHitTestParameters hitTestParameters)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
			if (rect.Contains(hitTestParameters.HitPoint))
			{
				return new global::System.Windows.Media.PointHitTestResult(this, hitTestParameters.HitPoint);
			}
			return base.HitTestCore(hitTestParameters);
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x0007F798 File Offset: 0x0007D998
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				global::System.Windows.DependencyObject dependencyObject = base.Content as global::System.Windows.DependencyObject;
				bool flag = dependencyObject != null && global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject) == this;
				if (this.HasHeader)
				{
					if (flag)
					{
						return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
						{
							new global::Infragistics.Collections.SingleItemEnumerator(dependencyObject),
							new global::Infragistics.Collections.SingleItemEnumerator(this.Header)
						});
					}
					return new global::Infragistics.Collections.SingleItemEnumerator(this.Header);
				}
				else
				{
					if (flag)
					{
						return new global::Infragistics.Collections.SingleItemEnumerator(dependencyObject);
					}
					return global::Infragistics.Collections.EmptyEnumerator.Instance;
				}
			}
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0007F80C File Offset: 0x0007DA0C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			global::System.Windows.Size result = base.MeasureOverride(constraint);
			if (constraint.Width != 0.0 && constraint.Height != 0.0)
			{
				if (this.IsCollapsed)
				{
					if (this._panel != null && !double.IsNaN(this._panel.UncollapsedCardWidth) && this.View != null && double.IsNaN(this.View.ViewSettings.CardWidth))
					{
						return new global::System.Windows.Size(this._panel.UncollapsedCardWidth, result.Height);
					}
				}
				else if (this._panel != null)
				{
					this._panel.UncollapsedCardWidth = result.Width;
					if (double.IsNaN(this.View.ViewSettings.CardWidth))
					{
						return new global::System.Windows.Size(this._panel.UncollapsedCardWidth, result.Height);
					}
				}
			}
			return result;
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0007F8F4 File Offset: 0x0007DAF4
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x0007F90F File Offset: 0x0007DB0F
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.CardViewCardAutomationPeer(this);
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x0007F917 File Offset: 0x0007DB17
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0007F926 File Offset: 0x0007DB26
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x0007F938 File Offset: 0x0007DB38
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::System.Windows.UIElement.RenderTransformProperty && e.NewValue == null)
			{
				this._explicitTransformGroupClones = null;
				this._explicitTransformGroupOriginal = null;
				base.CoerceValue(global::System.Windows.UIElement.RenderTransformProperty);
				return;
			}
			if (e.Property == global::Infragistics.Windows.DataPresenter.CardViewCard.IsCollapsedProperty && (bool)e.NewValue)
			{
				this._lastCollapseTickCount = global::System.Environment.TickCount;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x0007F9A4 File Offset: 0x0007DBA4
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0007F9B6 File Offset: 0x0007DBB6
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility CollapseCardButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.CollapseCardButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.CollapseCardButtonVisibilityProperty, value);
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0007F9C9 File Offset: 0x0007DBC9
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0007F9DB File Offset: 0x0007DBDB
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility CollapseEmptyCellsButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.CollapseEmptyCellsButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.CollapseEmptyCellsButtonVisibilityProperty, value);
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x0007F9EE File Offset: 0x0007DBEE
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool HasHeader
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HasHeaderProperty);
			}
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x0007FA00 File Offset: 0x0007DC00
		private static void OnHeaderChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = target as global::Infragistics.Windows.DataPresenter.CardViewCard;
			cardViewCard.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HasHeaderPropertyKey, global::Infragistics.KnownBoxes.FromValue(e.NewValue != null));
			cardViewCard.OnHeaderChanged(e.OldValue, e.NewValue);
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x0007FA45 File Offset: 0x0007DC45
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0007FA52 File Offset: 0x0007DC52
		[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.Label)]
		[global::System.ComponentModel.Bindable(true)]
		public object Header
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderProperty, value);
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x0007FA60 File Offset: 0x0007DC60
		public static global::System.Windows.DependencyProperty HeaderStringFormatProperty
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CardViewCard.s_HeaderStringFormatProperty;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x0007FA67 File Offset: 0x0007DC67
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x0007FA79 File Offset: 0x0007DC79
		[global::System.ComponentModel.Bindable(true)]
		public string HeaderStringFormat
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderStringFormatProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderStringFormatProperty, value);
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x0007FA87 File Offset: 0x0007DC87
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x0007FA99 File Offset: 0x0007DC99
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate HeaderTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderTemplateProperty, value);
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x0007FAA7 File Offset: 0x0007DCA7
		// (set) Token: 0x06001D31 RID: 7473 RVA: 0x0007FAB9 File Offset: 0x0007DCB9
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector HeaderTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderTemplateSelectorProperty, value);
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x0007FAC7 File Offset: 0x0007DCC7
		// (set) Token: 0x06001D33 RID: 7475 RVA: 0x0007FAD9 File Offset: 0x0007DCD9
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility HeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderVisibilityProperty, value);
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x0007FAEC File Offset: 0x0007DCEC
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsAddRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsAddRecordProperty);
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x0007FAFE File Offset: 0x0007DCFE
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0007FB10 File Offset: 0x0007DD10
		[global::System.ComponentModel.Bindable(true)]
		public bool IsActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsActiveProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsActiveProperty, value);
			}
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x0007FB24 File Offset: 0x0007DD24
		private static object CoerceIsCollapsed(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = target as global::Infragistics.Windows.DataPresenter.CardViewCard;
			if (cardViewCard != null)
			{
				bool flag = false;
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = cardViewCard.Content as global::Infragistics.Windows.DataPresenter.RecordPresenter;
				if (recordPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.Record record = recordPresenter.Record;
					if (record != null)
					{
						flag = record.IsContainingCardCollapsedResolved;
					}
				}
				return flag;
			}
			return value;
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x0007FB65 File Offset: 0x0007DD65
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x0007FB77 File Offset: 0x0007DD77
		[global::System.ComponentModel.Bindable(true)]
		public bool IsCollapsed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsCollapsedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsCollapsedProperty, value);
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x0007FB8A File Offset: 0x0007DD8A
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFilterRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsFilterRecordProperty);
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x0007FB9C File Offset: 0x0007DD9C
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x0007FBAE File Offset: 0x0007DDAE
		[global::System.ComponentModel.Bindable(true)]
		public bool IsSelected
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsSelectedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsSelectedProperty, value);
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x0007FBC1 File Offset: 0x0007DDC1
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x0007FBD3 File Offset: 0x0007DDD3
		[global::System.ComponentModel.Bindable(true)]
		public bool ShouldCollapseEmptyCells
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.ShouldCollapseEmptyCellsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.ShouldCollapseEmptyCellsProperty, value);
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x0007FBE6 File Offset: 0x0007DDE6
		internal global::Infragistics.Windows.DataPresenter.CardHeaderPresenter HeaderPresenter
		{
			get
			{
				if (this._cardHeaderPresenter == null)
				{
					return null;
				}
				return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._cardHeaderPresenter) as global::Infragistics.Windows.DataPresenter.CardHeaderPresenter;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x0007FC02 File Offset: 0x0007DE02
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x0007FC0A File Offset: 0x0007DE0A
		internal global::Infragistics.Windows.DataPresenter.CardViewPanel Panel
		{
			get
			{
				return this._panel;
			}
			set
			{
				this._panel = value;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0007FC13 File Offset: 0x0007DE13
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x0007FC1B File Offset: 0x0007DE1B
		internal global::Infragistics.Windows.DataPresenter.CardView View
		{
			get
			{
				return this._view;
			}
			set
			{
				this._view = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x0007FC24 File Offset: 0x0007DE24
		private global::System.Windows.Controls.ScrollViewer ScrollViewer
		{
			get
			{
				if (this._scrollViewer != null && (global::System.Windows.Media.VisualTreeHelper.GetParent(this._scrollViewer) == null || !this._scrollViewer.IsLoaded))
				{
					this._scrollViewer = null;
				}
				if (this._scrollViewer == null)
				{
					this._scrollViewer = (global::Infragistics.Windows.Utilities.GetDescendantFromType(this, typeof(global::System.Windows.Controls.ScrollViewer), true) as global::System.Windows.Controls.ScrollViewer);
				}
				return this._scrollViewer;
			}
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x0007FC84 File Offset: 0x0007DE84
		private bool BindPathProperty(object item, global::Infragistics.Windows.DataPresenter.CardViewCard card, string sourcePropertyName, global::System.Windows.DependencyProperty dpTarget, string stringFormat)
		{
			if (sourcePropertyName != null && sourcePropertyName.Length > 0)
			{
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
				binding.Source = item;
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsXmlNodeOptimized(item))
				{
					binding.XPath = sourcePropertyName;
				}
				else
				{
					binding.Path = new global::System.Windows.PropertyPath(sourcePropertyName, new object[0]);
				}
				if (stringFormat != null && global::Infragistics.Windows.DataPresenter.CardView.s_BindingStringFormatInfo != null)
				{
					global::Infragistics.Windows.DataPresenter.CardView.s_BindingStringFormatInfo.SetValue(binding, stringFormat, null);
				}
				card.SetBinding(dpTarget, binding);
				return true;
			}
			return false;
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0007FD00 File Offset: 0x0007DF00
		internal void ClearHeader(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter header)
		{
			if (this.Header == header)
			{
				this._cardHeaderPresenter = null;
			}
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x0007FD14 File Offset: 0x0007DF14
		private global::System.Globalization.CultureInfo GetCulture(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			if (global::Infragistics.Windows.DataPresenter.CardViewCard.s_culture == null)
			{
				global::Infragistics.Windows.DataPresenter.CardViewCard.s_culture = ((dp != null) ? dp.DefaultConverterCulture : null);
				if (global::Infragistics.Windows.DataPresenter.CardViewCard.s_culture == null)
				{
					global::Infragistics.Windows.DataPresenter.CardViewCard.s_culture = global::System.Threading.Thread.CurrentThread.CurrentCulture;
					if (global::Infragistics.Windows.DataPresenter.CardViewCard.s_culture == null)
					{
						global::Infragistics.Windows.DataPresenter.CardViewCard.s_culture = global::System.Globalization.CultureInfo.InvariantCulture;
					}
				}
			}
			return global::Infragistics.Windows.DataPresenter.CardViewCard.s_culture;
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x0007FD65 File Offset: 0x0007DF65
		internal void InitializeHeader(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter header)
		{
			this._cardHeaderPresenter = new global::System.WeakReference(header);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x0007FD74 File Offset: 0x0007DF74
		private static void OnMouseWheelEvent(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (!e.Handled)
			{
				return;
			}
			global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
			while (dependencyObject is global::System.Windows.ContentElement)
			{
				dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
			}
			if (dependencyObject == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = sender as global::Infragistics.Windows.DataPresenter.CardViewCard;
			if (cardViewCard == null)
			{
				return;
			}
			global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
			bool flag = false;
			bool flag2 = false;
			while (parent != null && parent != cardViewCard)
			{
				global::System.Windows.Controls.ScrollViewer scrollViewer = parent as global::System.Windows.Controls.ScrollViewer;
				if (scrollViewer != null && (scrollViewer.ComputedHorizontalScrollBarVisibility == global::System.Windows.Visibility.Visible || scrollViewer.ComputedVerticalScrollBarVisibility == global::System.Windows.Visibility.Visible))
				{
					flag = true;
					break;
				}
				flag2 = (parent == cardViewCard);
				parent = global::System.Windows.Media.VisualTreeHelper.GetParent(parent);
			}
			if (parent == null && !flag2)
			{
				e.Handled = true;
				return;
			}
			if (!flag)
			{
				e.Handled = false;
			}
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0007FE18 File Offset: 0x0007E018
		private static void OnRequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = e.TargetObject as global::Infragistics.Windows.DataPresenter.CardViewCard;
			if (cardViewCard != null && cardViewCard.IsCollapsed)
			{
				int num = global::System.Environment.TickCount - cardViewCard._lastCollapseTickCount;
				if (num < 200)
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x0007FE58 File Offset: 0x0007E058
		private void ResolveIsCollapsed()
		{
			base.InvalidateProperty(global::Infragistics.Windows.DataPresenter.CardViewCard.IsCollapsedProperty);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x0007FE68 File Offset: 0x0007E068
		internal void Initialize(global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			if (this.ScrollViewer != null)
			{
				if (this.ScrollViewer.VerticalOffset > 0.0)
				{
					this.ScrollViewer.ScrollToTop();
				}
				if (this.ScrollViewer.HorizontalOffset > 0.0)
				{
					this.ScrollViewer.ScrollToLeftEnd();
				}
			}
			if (this._panel != null && recordPresenter != null && recordPresenter.FieldLayout != null)
			{
				this._panel.SetupSpecialRecordsVersionTracker(recordPresenter.FieldLayout);
			}
			if (recordPresenter != null)
			{
				if (recordPresenter.FieldLayout != null)
				{
					this._layoutVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(recordPresenter.FieldLayout, "SpecialRecordsVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ResolveIsCollapsed));
					this._layoutSortVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(recordPresenter.FieldLayout, "SortOperationVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ResolveIsCollapsed));
					this._primaryFieldTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(recordPresenter.FieldLayout, "PrimaryField", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ResolveHeader));
					if (recordPresenter.FieldLayout.DataPresenter != null)
					{
						if (recordPresenter.FieldLayout.DataPresenter.CurrentViewInternal is global::Infragistics.Windows.DataPresenter.CardView)
						{
							this._headerPathTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(recordPresenter.FieldLayout.DataPresenter.CurrentViewInternal, "CachedHeaderPath", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ResolveHeader));
						}
						this._overallSortVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(recordPresenter.FieldLayout.DataPresenter, "OverallSortVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ResolveHeader), true);
					}
				}
				if (recordPresenter.Record != null)
				{
					this._isCardCollapsedTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(recordPresenter.Record, "IsContainingCardCollapsedResolved", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ResolveIsCollapsed));
					this._recordDataTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(recordPresenter.Record, "IsDataChanged", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ResolveHeader));
					this.ResolveAddNewAndFilterRecordStatus(recordPresenter.Record);
				}
			}
			this.ResolveIsCollapsed();
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00080030 File Offset: 0x0007E230
		internal void ResolveAddNewAndFilterRecordStatus(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record is global::Infragistics.Windows.DataPresenter.DataRecord && ((global::Infragistics.Windows.DataPresenter.DataRecord)record).IsAddRecord)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsAddRecordPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
			else
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsAddRecordPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
			}
			if (record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsFilterRecordPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				return;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsFilterRecordPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x000800A0 File Offset: 0x0007E2A0
		internal void ResolveHeader()
		{
			try
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = base.Content as global::Infragistics.Windows.DataPresenter.RecordPresenter;
				global::Infragistics.Windows.DataPresenter.Record record = (recordPresenter != null) ? recordPresenter.Record : null;
				if (recordPresenter != null && record != null && (record.IsDataRecord || ((global::Infragistics.Windows.DataPresenter.DataRecord)record).IsAddRecord || record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord))
				{
					if (((global::Infragistics.Windows.DataPresenter.DataRecord)recordPresenter.Record).IsAddRecord)
					{
						base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderProperty, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Card_AddNewRecordTitle", new object[0], this.GetCulture(recordPresenter.DataPresenter)));
					}
					else if (recordPresenter.Record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord)
					{
						base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderProperty, global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Card_FilterRecordTitle", new object[0], this.GetCulture(recordPresenter.DataPresenter)));
					}
					else
					{
						string stringFormat = (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.s_HeaderStringFormatProperty);
						bool flag = false;
						global::Infragistics.Windows.DataPresenter.CardView view = this.View;
						if (view != null && !string.IsNullOrEmpty(this.View.CachedHeaderPath))
						{
							flag = this.BindPathProperty(((global::Infragistics.Windows.DataPresenter.DataRecord)recordPresenter.Record).DataItem, this, view.CachedHeaderPath, global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderProperty, stringFormat);
						}
						if (!flag)
						{
							if (recordPresenter.FieldLayout != null && recordPresenter.FieldLayout.PrimaryField != null)
							{
								this.BindPathProperty(((global::Infragistics.Windows.DataPresenter.DataRecord)recordPresenter.Record).DataItem, this, recordPresenter.FieldLayout.PrimaryField.Name, global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderProperty, stringFormat);
							}
							else
							{
								global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderProperty);
								base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderProperty);
							}
						}
						this.ResolveAddNewAndFilterRecordStatus(recordPresenter.Record);
					}
				}
				else
				{
					global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderProperty);
					base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderProperty);
				}
			}
			finally
			{
				this.UpdateVisualStates();
			}
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00080268 File Offset: 0x0007E468
		internal void UpdateTransform(global::System.Windows.Rect original, global::System.Windows.Rect current, global::System.Windows.Rect target, global::System.Windows.Vector offset, bool calledFromArrange)
		{
			if (this._translateTransform == null || this._translateTransform.IsSealed)
			{
				this._translateTransform = new global::System.Windows.Media.TranslateTransform();
				base.CoerceValue(global::System.Windows.UIElement.RenderTransformProperty);
			}
			global::System.Windows.Rect rect = global::System.Windows.Rect.Offset(current, offset);
			this._translateTransform.X = rect.X;
			this._translateTransform.Y = rect.Y;
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x000802D0 File Offset: 0x0007E4D0
		private static bool AreTransformGroupsEqual(global::System.Windows.Media.TransformCollection group1Children, global::System.Windows.Media.TransformCollection group2Children)
		{
			if (group1Children.Count == group2Children.Count)
			{
				for (int i = 0; i < group1Children.Count; i++)
				{
					if (!group1Children[i].Equals(group2Children[i]))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00080318 File Offset: 0x0007E518
		private static object CoerceRenderTransform(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = target as global::Infragistics.Windows.DataPresenter.CardViewCard;
			global::System.Windows.Media.Transform transform = value as global::System.Windows.Media.Transform;
			if (transform == null)
			{
				return cardViewCard._translateTransform;
			}
			if (transform is global::System.Windows.Media.TransformGroup)
			{
				global::System.Windows.Media.TransformGroup transformGroup = transform as global::System.Windows.Media.TransformGroup;
				if (cardViewCard._explicitTransformGroupClones == null || !global::Infragistics.Windows.DataPresenter.CardViewCard.AreTransformGroupsEqual(transformGroup.Children, cardViewCard._explicitTransformGroupOriginal.Children))
				{
					cardViewCard._explicitTransformGroupClones = new global::System.Windows.Media.TransformGroup();
					cardViewCard._explicitTransformGroupOriginal = new global::System.Windows.Media.TransformGroup();
					foreach (global::System.Windows.Media.Transform transform2 in ((global::System.Windows.Media.TransformGroup)transform).Children)
					{
						if (transform2.IsFrozen)
						{
							cardViewCard._explicitTransformGroupClones.Children.Add(transform2.Clone());
						}
						else
						{
							cardViewCard._explicitTransformGroupClones.Children.Add(transform2);
						}
						cardViewCard._explicitTransformGroupOriginal.Children.Add(transform2);
					}
					if (cardViewCard._translateTransform != null)
					{
						cardViewCard._explicitTransformGroupClones.Children.Add(cardViewCard._translateTransform);
						cardViewCard._explicitTransformGroupOriginal.Children.Add(cardViewCard._translateTransform);
					}
					else
					{
						cardViewCard._explicitTransformGroupClones.Children.Add(new global::System.Windows.Media.TranslateTransform());
						cardViewCard._explicitTransformGroupOriginal.Children.Add(new global::System.Windows.Media.TranslateTransform());
					}
				}
				return cardViewCard._explicitTransformGroupClones;
			}
			if (cardViewCard._translateTransform == null)
			{
				return transform;
			}
			if (cardViewCard._internalTransformGroup == null || !cardViewCard._internalTransformGroup.Children.Contains(cardViewCard._translateTransform) || !cardViewCard._internalTransformGroup.Children.Contains(transform))
			{
				cardViewCard._internalTransformGroup = new global::System.Windows.Media.TransformGroup();
				cardViewCard._internalTransformGroup.Children.Add(cardViewCard._translateTransform);
				cardViewCard._internalTransformGroup.Children.Add(transform);
			}
			return cardViewCard._internalTransformGroup;
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x000804EC File Offset: 0x0007E6EC
		private void OnHeaderChanged(object oldHeader, object newHeader)
		{
			base.RemoveLogicalChild(oldHeader);
			base.AddLogicalChild(newHeader);
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x000804FC File Offset: 0x0007E6FC
		private void SetVisualState(bool useTransitions)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = base.Content as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (((recordPresenter != null) ? recordPresenter.Record : null) == null)
			{
				return;
			}
			if (base.IsMouseOver)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"MouseOver",
					"Normal"
				});
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
			}
			global::Infragistics.Windows.DataPresenter.CardViewCard.SetVisualStateHelper(this, this, useTransitions);
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00080564 File Offset: 0x0007E764
		internal static void SetVisualStateHelper(global::Infragistics.Windows.DataPresenter.CardViewCard card, global::System.Windows.Controls.Control ctrl, bool useTransitions)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = card.Content as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			global::Infragistics.Windows.DataPresenter.Record record = (recordPresenter != null) ? recordPresenter.Record : null;
			if (record == null)
			{
				return;
			}
			if (card.IsActive)
			{
				global::System.Windows.VisualStateManager.GoToState(ctrl, "Active", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(ctrl, "Inactive", useTransitions);
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null && dataRecord.IsDataChanged)
			{
				global::System.Windows.VisualStateManager.GoToState(ctrl, "Changed", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(ctrl, "Unchanged", useTransitions);
			}
			if (card.IsCollapsed)
			{
				global::System.Windows.VisualStateManager.GoToState(ctrl, "Collapsed", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(ctrl, "Expanded", useTransitions);
			}
			if (card.IsFilterRecord)
			{
				global::System.Windows.VisualStateManager.GoToState(ctrl, "FilterRecord", useTransitions);
			}
			else if (card.IsAddRecord)
			{
				global::System.Windows.VisualStateManager.GoToState(ctrl, "AddRecord", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(ctrl, "DataRecord", useTransitions);
			}
			if (card.IsSelected)
			{
				global::System.Windows.VisualStateManager.GoToState(ctrl, "Selected", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(ctrl, "Unselected", useTransitions);
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00080664 File Offset: 0x0007E864
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = target as global::Infragistics.Windows.DataPresenter.CardViewCard;
			if (cardViewCard != null)
			{
				cardViewCard.UpdateVisualStates();
			}
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00080681 File Offset: 0x0007E881
		private void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x0008068C File Offset: 0x0007E88C
		private void UpdateVisualStates(bool useTransitions)
		{
			if (!base.IsLoaded)
			{
				useTransitions = false;
			}
			if (this._hasVisualStateGroups)
			{
				this.SetVisualState(useTransitions);
			}
			global::Infragistics.Windows.DataPresenter.CardHeaderPresenter headerPresenter = this.HeaderPresenter;
			if (headerPresenter != null)
			{
				headerPresenter.UpdateVisualStates(useTransitions);
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x000806C4 File Offset: 0x0007E8C4
		object global::Infragistics.Windows.Resizing.IResizableElement.ResizeContext
		{
			get
			{
				return base.Content;
			}
		}

		// Token: 0x04000C18 RID: 3096
		private global::System.Windows.Media.TransformGroup _explicitTransformGroupOriginal;

		// Token: 0x04000C19 RID: 3097
		private global::System.Windows.Media.TransformGroup _explicitTransformGroupClones;

		// Token: 0x04000C1A RID: 3098
		private global::System.Windows.Media.TransformGroup _internalTransformGroup;

		// Token: 0x04000C1B RID: 3099
		private global::System.Windows.Media.TranslateTransform _translateTransform;

		// Token: 0x04000C1C RID: 3100
		private global::Infragistics.Windows.Internal.PropertyValueTracker _layoutVersionTracker;

		// Token: 0x04000C1D RID: 3101
		private global::Infragistics.Windows.Internal.PropertyValueTracker _layoutSortVersionTracker;

		// Token: 0x04000C1E RID: 3102
		private global::Infragistics.Windows.Internal.PropertyValueTracker _isCardCollapsedTracker;

		// Token: 0x04000C1F RID: 3103
		private global::Infragistics.Windows.Internal.PropertyValueTracker _primaryFieldTracker;

		// Token: 0x04000C20 RID: 3104
		private global::Infragistics.Windows.Internal.PropertyValueTracker _headerPathTracker;

		// Token: 0x04000C21 RID: 3105
		private global::Infragistics.Windows.Internal.PropertyValueTracker _recordDataTracker;

		// Token: 0x04000C22 RID: 3106
		private global::Infragistics.Windows.Internal.PropertyValueTracker _overallSortVersionTracker;

		// Token: 0x04000C23 RID: 3107
		private static global::System.Globalization.CultureInfo s_culture;

		// Token: 0x04000C24 RID: 3108
		private global::Infragistics.Windows.DataPresenter.CardView _view;

		// Token: 0x04000C25 RID: 3109
		private global::Infragistics.Windows.DataPresenter.CardViewPanel _panel;

		// Token: 0x04000C26 RID: 3110
		private global::System.Windows.Controls.ScrollViewer _scrollViewer;

		// Token: 0x04000C27 RID: 3111
		private global::System.WeakReference _cardHeaderPresenter;

		// Token: 0x04000C28 RID: 3112
		private bool _hasVisualStateGroups;

		// Token: 0x04000C29 RID: 3113
		private int _lastCollapseTickCount;

		// Token: 0x04000C2A RID: 3114
		public static readonly global::System.Windows.DependencyProperty CollapseCardButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("CollapseCardButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));

		// Token: 0x04000C2B RID: 3115
		public static readonly global::System.Windows.DependencyProperty CollapseEmptyCellsButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("CollapseEmptyCellsButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));

		// Token: 0x04000C2C RID: 3116
		private static readonly global::System.Windows.DependencyPropertyKey HasHeaderPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasHeader", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000C2D RID: 3117
		public static readonly global::System.Windows.DependencyProperty HasHeaderProperty = global::Infragistics.Windows.DataPresenter.CardViewCard.HasHeaderPropertyKey.DependencyProperty;

		// Token: 0x04000C2E RID: 3118
		public static readonly global::System.Windows.DependencyProperty HeaderProperty = global::System.Windows.Controls.HeaderedContentControl.HeaderProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.OnHeaderChanged)));

		// Token: 0x04000C2F RID: 3119
		private static global::System.Windows.DependencyProperty s_HeaderStringFormatProperty;

		// Token: 0x04000C30 RID: 3120
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateProperty = global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CardViewCard));

		// Token: 0x04000C31 RID: 3121
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateSelectorProperty = global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CardViewCard));

		// Token: 0x04000C32 RID: 3122
		public static readonly global::System.Windows.DependencyProperty HeaderVisibilityProperty = global::System.Windows.DependencyProperty.Register("HeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000C33 RID: 3123
		private static readonly global::System.Windows.DependencyPropertyKey IsAddRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsAddRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.OnVisualStatePropertyChanged)));

		// Token: 0x04000C34 RID: 3124
		public static readonly global::System.Windows.DependencyProperty IsAddRecordProperty = global::Infragistics.Windows.DataPresenter.CardViewCard.IsAddRecordPropertyKey.DependencyProperty;

		// Token: 0x04000C35 RID: 3125
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::System.Windows.DependencyProperty.Register("IsActive", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.OnVisualStatePropertyChanged)));

		// Token: 0x04000C36 RID: 3126
		public static readonly global::System.Windows.DependencyProperty IsCollapsedProperty = global::System.Windows.DependencyProperty.Register("IsCollapsed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.OnVisualStatePropertyChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.CoerceIsCollapsed)));

		// Token: 0x04000C37 RID: 3127
		private static readonly global::System.Windows.DependencyPropertyKey IsFilterRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFilterRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.OnVisualStatePropertyChanged)));

		// Token: 0x04000C38 RID: 3128
		public static readonly global::System.Windows.DependencyProperty IsFilterRecordProperty = global::Infragistics.Windows.DataPresenter.CardViewCard.IsFilterRecordPropertyKey.DependencyProperty;

		// Token: 0x04000C39 RID: 3129
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.OnVisualStatePropertyChanged)));

		// Token: 0x04000C3A RID: 3130
		public static readonly global::System.Windows.DependencyProperty ShouldCollapseEmptyCellsProperty = global::System.Windows.DependencyProperty.Register("ShouldCollapseEmptyCells", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure));
	}
}
