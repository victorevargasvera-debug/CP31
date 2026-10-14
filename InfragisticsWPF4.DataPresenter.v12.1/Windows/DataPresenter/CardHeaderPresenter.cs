using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000045 RID: 69
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Changed", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unchanged", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "Expanded", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Collapsed", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "DataRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilterRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "AddRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	public class CardHeaderPresenter : global::System.Windows.Controls.ContentControl, global::Infragistics.Windows.Selection.ISelectableElement
	{
		// Token: 0x0600029E RID: 670 RVA: 0x0000B240 File Offset: 0x00009440
		static CardHeaderPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentCenterBox));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000B331 File Offset: 0x00009531
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000B34C File Offset: 0x0000954C
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.CardHeaderPresenterAutomationPeer(this);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000B354 File Offset: 0x00009554
		protected override void OnMouseDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDoubleClick(e);
			if (e.ChangedButton == global::System.Windows.Input.MouseButton.Left)
			{
				if (e.OriginalSource is global::System.Windows.FrameworkElement || e.OriginalSource.GetType().IsAssignableFrom(typeof(global::System.Windows.FrameworkElement)))
				{
					global::System.Windows.Controls.Primitives.ButtonBase buttonBase = global::Infragistics.Windows.Utilities.GetAncestorFromType((global::System.Windows.DependencyObject)e.OriginalSource, typeof(global::System.Windows.Controls.Primitives.ButtonBase), true, this) as global::System.Windows.Controls.Primitives.ButtonBase;
					if (buttonBase != null)
					{
						return;
					}
				}
				global::Infragistics.Windows.DataPresenter.Record record = base.DataContext as global::Infragistics.Windows.DataPresenter.Record;
				if (record != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = record.DataPresenter;
					if (dataPresenter != null && dataPresenter.CurrentViewInternal is global::Infragistics.Windows.DataPresenter.CardView)
					{
						((global::Infragistics.Windows.DataPresenter.CardView)dataPresenter.CurrentViewInternal).ViewSettings.CardHeight = double.NaN;
						((global::Infragistics.Windows.DataPresenter.CardView)dataPresenter.CurrentViewInternal).ViewSettings.CardWidth = double.NaN;
					}
				}
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000B424 File Offset: 0x00009624
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000B433 File Offset: 0x00009633
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000B444 File Offset: 0x00009644
		private static void OnCardChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CardHeaderPresenter cardHeaderPresenter = target as global::Infragistics.Windows.DataPresenter.CardHeaderPresenter;
			if (cardHeaderPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = e.OldValue as global::Infragistics.Windows.DataPresenter.CardViewCard;
				if (cardViewCard != null)
				{
					cardViewCard.ClearHeader(cardHeaderPresenter);
				}
				global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard2 = e.NewValue as global::Infragistics.Windows.DataPresenter.CardViewCard;
				if (cardViewCard2 != null)
				{
					cardViewCard2.InitializeHeader(cardHeaderPresenter);
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000B489 File Offset: 0x00009689
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0000B49B File Offset: 0x0000969B
		public global::Infragistics.Windows.DataPresenter.CardViewCard Card
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.CardViewCard)base.GetValue(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter.CardProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter.CardProperty, value);
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000B4AC File Offset: 0x000096AC
		protected virtual void SetVisualState(bool useTransitions)
		{
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
			global::Infragistics.Windows.DataPresenter.CardViewCard card = this.Card;
			if (card != null)
			{
				global::Infragistics.Windows.DataPresenter.CardViewCard.SetVisualStateHelper(card, this, useTransitions);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000B504 File Offset: 0x00009704
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CardHeaderPresenter cardHeaderPresenter = target as global::Infragistics.Windows.DataPresenter.CardHeaderPresenter;
			if (cardHeaderPresenter != null)
			{
				cardHeaderPresenter.UpdateVisualStates();
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000B521 File Offset: 0x00009721
		protected internal void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000B52A File Offset: 0x0000972A
		protected internal void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				return;
			}
			if (!base.IsLoaded)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000B548 File Offset: 0x00009748
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectableElement.SelectableItem
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = this.Card.Content as global::Infragistics.Windows.DataPresenter.RecordPresenter;
				if (recordPresenter != null)
				{
					return recordPresenter.Record;
				}
				return null;
			}
		}

		// Token: 0x040000B3 RID: 179
		private bool _hasVisualStateGroups;

		// Token: 0x040000B4 RID: 180
		public static readonly global::System.Windows.ResourceKey CollapseEmptyCellsButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), "CollapseEmptyCellsButtonStyleKey");

		// Token: 0x040000B5 RID: 181
		public static readonly global::System.Windows.ResourceKey CollapseCardButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), "CollapseCardButtonStyleKey");

		// Token: 0x040000B6 RID: 182
		public static readonly global::System.Windows.DependencyProperty CardProperty = global::System.Windows.DependencyProperty.Register("Card", typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter.OnCardChanged)));
	}
}
