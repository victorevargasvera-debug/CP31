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
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Unchanged", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Changed", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "Collapsed", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Expanded", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "DataRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilterRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "AddRecord", GroupName = "RecordStates")]
	public class CardHeaderPresenter : global::System.Windows.Controls.ContentControl, global::Infragistics.Windows.Selection.ISelectableElement
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x0000BC54 File Offset: 0x00009E54
		static CardHeaderPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentCenterBox));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000BD45 File Offset: 0x00009F45
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000BD60 File Offset: 0x00009F60
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.CardHeaderPresenterAutomationPeer(this);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000BD68 File Offset: 0x00009F68
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

		// Token: 0x060002B9 RID: 697 RVA: 0x0000BE38 File Offset: 0x0000A038
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000BE47 File Offset: 0x0000A047
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000BE58 File Offset: 0x0000A058
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

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000BE9D File Offset: 0x0000A09D
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000BEAF File Offset: 0x0000A0AF
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

		// Token: 0x060002BE RID: 702 RVA: 0x0000BEC0 File Offset: 0x0000A0C0
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

		// Token: 0x060002BF RID: 703 RVA: 0x0000BF18 File Offset: 0x0000A118
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CardHeaderPresenter cardHeaderPresenter = target as global::Infragistics.Windows.DataPresenter.CardHeaderPresenter;
			if (cardHeaderPresenter != null)
			{
				cardHeaderPresenter.UpdateVisualStates();
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000BF35 File Offset: 0x0000A135
		protected internal void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000BF3E File Offset: 0x0000A13E
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000BF5C File Offset: 0x0000A15C
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

		// Token: 0x040000C5 RID: 197
		private bool _hasVisualStateGroups;

		// Token: 0x040000C6 RID: 198
		public static readonly global::System.Windows.ResourceKey CollapseEmptyCellsButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), "CollapseEmptyCellsButtonStyleKey");

		// Token: 0x040000C7 RID: 199
		public static readonly global::System.Windows.ResourceKey CollapseCardButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), "CollapseCardButtonStyleKey");

		// Token: 0x040000C8 RID: 200
		public static readonly global::System.Windows.DependencyProperty CardProperty = global::System.Windows.DependencyProperty.Register("Card", typeof(global::Infragistics.Windows.DataPresenter.CardViewCard), typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter.OnCardChanged)));
	}
}
