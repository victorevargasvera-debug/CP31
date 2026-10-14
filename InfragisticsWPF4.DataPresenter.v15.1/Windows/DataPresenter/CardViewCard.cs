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
	// Token: 0x0200023E RID: 574
	[global::System.Windows.TemplateVisualState(Name = "DataRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilterRecord", GroupName = "RecordStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unchanged", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "Expanded", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Collapsed", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Changed", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "AddRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	public sealed class CardViewCard : global::System.Windows.Controls.ContentControl, global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer, global::Infragistics.Windows.Resizing.IResizableElement
	{
		// Token: 0x06002196 RID: 8598 RVA: 0x00095948 File Offset: 0x00093B48
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

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x00095D05 File Offset: 0x00093F05
		global::Infragistics.Windows.DataPresenter.RecordPresenter global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer.RecordPresenter
		{
			get
			{
				return base.Content as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06002199 RID: 8601 RVA: 0x00095D12 File Offset: 0x00093F12
		protected override bool HandlesScrolling
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00095D18 File Offset: 0x00093F18
		protected override global::System.Windows.Media.HitTestResult HitTestCore(global::System.Windows.Media.PointHitTestParameters hitTestParameters)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
			if (rect.Contains(hitTestParameters.HitPoint))
			{
				return new global::System.Windows.Media.PointHitTestResult(this, hitTestParameters.HitPoint);
			}
			return base.HitTestCore(hitTestParameters);
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x00095D60 File Offset: 0x00093F60
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

		// Token: 0x0600219C RID: 8604 RVA: 0x00095DD4 File Offset: 0x00093FD4
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

		// Token: 0x0600219D RID: 8605 RVA: 0x00095EBC File Offset: 0x000940BC
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00095ED7 File Offset: 0x000940D7
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.CardViewCardAutomationPeer(this);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00095EDF File Offset: 0x000940DF
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x00095EEE File Offset: 0x000940EE
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00095F00 File Offset: 0x00094100
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

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x00095F6C File Offset: 0x0009416C
		// (set) Token: 0x060021A3 RID: 8611 RVA: 0x00095F7E File Offset: 0x0009417E
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

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x00095F91 File Offset: 0x00094191
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x00095FA3 File Offset: 0x000941A3
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

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x00095FB6 File Offset: 0x000941B6
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasHeader
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HasHeaderProperty);
			}
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00095FC8 File Offset: 0x000941C8
		private static void OnHeaderChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = target as global::Infragistics.Windows.DataPresenter.CardViewCard;
			cardViewCard.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.HasHeaderPropertyKey, global::Infragistics.KnownBoxes.FromValue(e.NewValue != null));
			cardViewCard.OnHeaderChanged(e.OldValue, e.NewValue);
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x0009600D File Offset: 0x0009420D
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x0009601A File Offset: 0x0009421A
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

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x00096028 File Offset: 0x00094228
		public static global::System.Windows.DependencyProperty HeaderStringFormatProperty
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CardViewCard.s_HeaderStringFormatProperty;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x0009602F File Offset: 0x0009422F
		// (set) Token: 0x060021AC RID: 8620 RVA: 0x00096041 File Offset: 0x00094241
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

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x0009604F File Offset: 0x0009424F
		// (set) Token: 0x060021AE RID: 8622 RVA: 0x00096061 File Offset: 0x00094261
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

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x0009606F File Offset: 0x0009426F
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x00096081 File Offset: 0x00094281
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

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x0009608F File Offset: 0x0009428F
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x000960A1 File Offset: 0x000942A1
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

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x000960B4 File Offset: 0x000942B4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsAddRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsAddRecordProperty);
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x000960C6 File Offset: 0x000942C6
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x000960D8 File Offset: 0x000942D8
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

		// Token: 0x060021B6 RID: 8630 RVA: 0x000960EC File Offset: 0x000942EC
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

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x0009612D File Offset: 0x0009432D
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x0009613F File Offset: 0x0009433F
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

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00096152 File Offset: 0x00094352
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFilterRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsFilterRecordProperty);
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x00096164 File Offset: 0x00094364
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsOpacityReduced
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsOpacityReducedProperty);
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x00096176 File Offset: 0x00094376
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x00096188 File Offset: 0x00094388
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

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x0009619B File Offset: 0x0009439B
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x000961AD File Offset: 0x000943AD
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

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x000961C0 File Offset: 0x000943C0
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

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x000961DC File Offset: 0x000943DC
		// (set) Token: 0x060021C1 RID: 8641 RVA: 0x000961E4 File Offset: 0x000943E4
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

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x000961ED File Offset: 0x000943ED
		// (set) Token: 0x060021C3 RID: 8643 RVA: 0x000961F5 File Offset: 0x000943F5
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

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x00096200 File Offset: 0x00094400
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

		// Token: 0x060021C5 RID: 8645 RVA: 0x00096260 File Offset: 0x00094460
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

		// Token: 0x060021C6 RID: 8646 RVA: 0x000962DC File Offset: 0x000944DC
		internal void ClearHeader(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter header)
		{
			if (this.Header == header)
			{
				this._cardHeaderPresenter = null;
			}
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000962F0 File Offset: 0x000944F0
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

		// Token: 0x060021C8 RID: 8648 RVA: 0x00096341 File Offset: 0x00094541
		internal void InitializeHeader(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter header)
		{
			this._cardHeaderPresenter = new global::System.WeakReference(header);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00096350 File Offset: 0x00094550
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

		// Token: 0x060021CA RID: 8650 RVA: 0x000963F4 File Offset: 0x000945F4
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

		// Token: 0x060021CB RID: 8651 RVA: 0x00096434 File Offset: 0x00094634
		private void ResolveIsCollapsed()
		{
			base.InvalidateProperty(global::Infragistics.Windows.DataPresenter.CardViewCard.IsCollapsedProperty);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00096444 File Offset: 0x00094644
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
					this._isOpacityReducedTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(recordPresenter, "IsOpacityReduced", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ResolveIsOpacityReduced));
				}
				if (recordPresenter.Record != null)
				{
					this._isCardCollapsedTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(recordPresenter.Record, "IsContainingCardCollapsedResolved", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ResolveIsCollapsed));
					this._recordDataTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(recordPresenter.Record, "IsDataChanged", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ResolveHeader));
					this.ResolveAddNewAndFilterRecordStatus(recordPresenter.Record);
				}
			}
			this.ResolveIsCollapsed();
			this.ResolveIsOpacityReduced();
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00096630 File Offset: 0x00094830
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

		// Token: 0x060021CE RID: 8654 RVA: 0x000966A0 File Offset: 0x000948A0
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

		// Token: 0x060021CF RID: 8655 RVA: 0x00096868 File Offset: 0x00094A68
		internal void ResolveIsOpacityReduced()
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = base.Content as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewCard.IsOpacityReducedPropertyKey, recordPresenter.IsOpacityReduced);
			}
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x0009689C File Offset: 0x00094A9C
		internal void UpdateTransform(global::System.Windows.Rect original, global::System.Windows.Rect current, global::System.Windows.Rect target, global::System.Windows.Vector offset, bool calledFromArrange)
		{
			bool flag = false;
			if (this._translateTransform == null || this._translateTransform.IsSealed)
			{
				this._translateTransform = new global::System.Windows.Media.TranslateTransform();
				flag = true;
			}
			global::System.Windows.Rect rect = global::System.Windows.Rect.Offset(current, offset);
			this._translateTransform.X = rect.X;
			this._translateTransform.Y = rect.Y;
			if (flag)
			{
				base.CoerceValue(global::System.Windows.UIElement.RenderTransformProperty);
			}
			if (calledFromArrange && !base.IsArrangeValid)
			{
				base.Arrange(new global::System.Windows.Rect(target.Size));
			}
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00096928 File Offset: 0x00094B28
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

		// Token: 0x060021D2 RID: 8658 RVA: 0x00096970 File Offset: 0x00094B70
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

		// Token: 0x060021D3 RID: 8659 RVA: 0x00096B44 File Offset: 0x00094D44
		private void OnHeaderChanged(object oldHeader, object newHeader)
		{
			base.RemoveLogicalChild(oldHeader);
			base.AddLogicalChild(newHeader);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00096B54 File Offset: 0x00094D54
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

		// Token: 0x060021D5 RID: 8661 RVA: 0x00096BBC File Offset: 0x00094DBC
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

		// Token: 0x060021D6 RID: 8662 RVA: 0x00096CBC File Offset: 0x00094EBC
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = target as global::Infragistics.Windows.DataPresenter.CardViewCard;
			if (cardViewCard != null)
			{
				cardViewCard.UpdateVisualStates();
			}
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00096CD9 File Offset: 0x00094ED9
		private void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00096CE4 File Offset: 0x00094EE4
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

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x00096D1C File Offset: 0x00094F1C
		object global::Infragistics.Windows.Resizing.IResizableElement.ResizeContext
		{
			get
			{
				return base.Content;
			}
		}

		// Token: 0x04000E35 RID: 3637
		private global::System.Windows.Media.TransformGroup _explicitTransformGroupOriginal;

		// Token: 0x04000E36 RID: 3638
		private global::System.Windows.Media.TransformGroup _explicitTransformGroupClones;

		// Token: 0x04000E37 RID: 3639
		private global::System.Windows.Media.TransformGroup _internalTransformGroup;

		// Token: 0x04000E38 RID: 3640
		private global::System.Windows.Media.TranslateTransform _translateTransform;

		// Token: 0x04000E39 RID: 3641
		private global::Infragistics.Windows.Internal.PropertyValueTracker _layoutVersionTracker;

		// Token: 0x04000E3A RID: 3642
		private global::Infragistics.Windows.Internal.PropertyValueTracker _layoutSortVersionTracker;

		// Token: 0x04000E3B RID: 3643
		private global::Infragistics.Windows.Internal.PropertyValueTracker _isCardCollapsedTracker;

		// Token: 0x04000E3C RID: 3644
		private global::Infragistics.Windows.Internal.PropertyValueTracker _primaryFieldTracker;

		// Token: 0x04000E3D RID: 3645
		private global::Infragistics.Windows.Internal.PropertyValueTracker _headerPathTracker;

		// Token: 0x04000E3E RID: 3646
		private global::Infragistics.Windows.Internal.PropertyValueTracker _recordDataTracker;

		// Token: 0x04000E3F RID: 3647
		private global::Infragistics.Windows.Internal.PropertyValueTracker _overallSortVersionTracker;

		// Token: 0x04000E40 RID: 3648
		private global::Infragistics.Windows.Internal.PropertyValueTracker _isOpacityReducedTracker;

		// Token: 0x04000E41 RID: 3649
		private static global::System.Globalization.CultureInfo s_culture;

		// Token: 0x04000E42 RID: 3650
		private global::Infragistics.Windows.DataPresenter.CardView _view;

		// Token: 0x04000E43 RID: 3651
		private global::Infragistics.Windows.DataPresenter.CardViewPanel _panel;

		// Token: 0x04000E44 RID: 3652
		private global::System.Windows.Controls.ScrollViewer _scrollViewer;

		// Token: 0x04000E45 RID: 3653
		private global::System.WeakReference _cardHeaderPresenter;

		// Token: 0x04000E46 RID: 3654
		private bool _hasVisualStateGroups;

		// Token: 0x04000E47 RID: 3655
		private int _lastCollapseTickCount;

		// Token: 0x04000E48 RID: 3656
		public static readonly global::System.Windows.DependencyProperty CollapseCardButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("CollapseCardButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));

		// Token: 0x04000E49 RID: 3657
		public static readonly global::System.Windows.DependencyProperty CollapseEmptyCellsButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("CollapseEmptyCellsButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));

		// Token: 0x04000E4A RID: 3658
		private static readonly global::System.Windows.DependencyPropertyKey HasHeaderPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasHeader", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000E4B RID: 3659
		public static readonly global::System.Windows.DependencyProperty HasHeaderProperty = global::Infragistics.Windows.DataPresenter.CardViewCard.HasHeaderPropertyKey.DependencyProperty;

		// Token: 0x04000E4C RID: 3660
		public static readonly global::System.Windows.DependencyProperty HeaderProperty = global::System.Windows.Controls.HeaderedContentControl.HeaderProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.OnHeaderChanged)));

		// Token: 0x04000E4D RID: 3661
		private static global::System.Windows.DependencyProperty s_HeaderStringFormatProperty;

		// Token: 0x04000E4E RID: 3662
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateProperty = global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CardViewCard));

		// Token: 0x04000E4F RID: 3663
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateSelectorProperty = global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CardViewCard));

		// Token: 0x04000E50 RID: 3664
		public static readonly global::System.Windows.DependencyProperty HeaderVisibilityProperty = global::System.Windows.DependencyProperty.Register("HeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000E51 RID: 3665
		private static readonly global::System.Windows.DependencyPropertyKey IsAddRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsAddRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.OnVisualStatePropertyChanged)));

		// Token: 0x04000E52 RID: 3666
		public static readonly global::System.Windows.DependencyProperty IsAddRecordProperty = global::Infragistics.Windows.DataPresenter.CardViewCard.IsAddRecordPropertyKey.DependencyProperty;

		// Token: 0x04000E53 RID: 3667
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::System.Windows.DependencyProperty.Register("IsActive", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.OnVisualStatePropertyChanged)));

		// Token: 0x04000E54 RID: 3668
		public static readonly global::System.Windows.DependencyProperty IsCollapsedProperty = global::System.Windows.DependencyProperty.Register("IsCollapsed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.OnVisualStatePropertyChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.CoerceIsCollapsed)));

		// Token: 0x04000E55 RID: 3669
		private static readonly global::System.Windows.DependencyPropertyKey IsFilterRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFilterRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.OnVisualStatePropertyChanged)));

		// Token: 0x04000E56 RID: 3670
		public static readonly global::System.Windows.DependencyProperty IsFilterRecordProperty = global::Infragistics.Windows.DataPresenter.CardViewCard.IsFilterRecordPropertyKey.DependencyProperty;

		// Token: 0x04000E57 RID: 3671
		private static readonly global::System.Windows.DependencyPropertyKey IsOpacityReducedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsOpacityReduced", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000E58 RID: 3672
		public static readonly global::System.Windows.DependencyProperty IsOpacityReducedProperty = global::Infragistics.Windows.DataPresenter.CardViewCard.IsOpacityReducedPropertyKey.DependencyProperty;

		// Token: 0x04000E59 RID: 3673
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardViewCard.OnVisualStatePropertyChanged)));

		// Token: 0x04000E5A RID: 3674
		public static readonly global::System.Windows.DependencyProperty ShouldCollapseEmptyCellsProperty = global::System.Windows.DependencyProperty.Register("ShouldCollapseEmptyCells", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure));
	}
}
