using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000282 RID: 642
	[global::System.Windows.TemplateVisualState(Name = "SortAscending", GroupName = "SortStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unsorted", GroupName = "SortStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "SortDescending", GroupName = "SortStates")]
	public class SortIndicator : global::System.Windows.Controls.Button
	{
		// Token: 0x0600196A RID: 6506 RVA: 0x0006142C File Offset: 0x0005F62C
		static SortIndicator()
		{
			global::Infragistics.Windows.Controls.SortIndicator.SortStatusChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SortStatusChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.SortStatusChangedEventArgs>), typeof(global::Infragistics.Windows.Controls.SortIndicator));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SortIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.SortIndicator)));
			global::System.Windows.UIElement.IsHitTestVisibleProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SortIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x000614D8 File Offset: 0x0005F6D8
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x000614F4 File Offset: 0x0005F6F4
		private static void OnSortStatusChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SortIndicator sortIndicator = target as global::Infragistics.Windows.Controls.SortIndicator;
			if (sortIndicator != null)
			{
				sortIndicator.OnSortStatusChanged((global::Infragistics.Windows.Controls.SortStatus)e.OldValue, (global::Infragistics.Windows.Controls.SortStatus)e.NewValue);
				sortIndicator.UpdateVisualStates();
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x0006152F File Offset: 0x0005F72F
		// (set) Token: 0x0600196E RID: 6510 RVA: 0x00061541 File Offset: 0x0005F741
		public global::Infragistics.Windows.Controls.SortStatus SortStatus
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SortStatus)base.GetValue(global::Infragistics.Windows.Controls.SortIndicator.SortStatusProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SortIndicator.SortStatusProperty, value);
			}
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00061554 File Offset: 0x0005F754
		protected virtual void OnSortStatusChanged(global::Infragistics.Windows.Controls.SortStatus previousValue, global::Infragistics.Windows.Controls.SortStatus currentValue)
		{
			base.RaiseEvent(new global::Infragistics.Windows.Controls.Events.SortStatusChangedEventArgs(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Controls.SortIndicator.SortStatusChangedEvent,
				Source = this
			});
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06001970 RID: 6512 RVA: 0x00061582 File Offset: 0x0005F782
		// (remove) Token: 0x06001971 RID: 6513 RVA: 0x00061590 File Offset: 0x0005F790
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.SortStatusChangedEventArgs> SortStatusChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.SortIndicator.SortStatusChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.SortIndicator.SortStatusChangedEvent, value);
			}
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x000615A0 File Offset: 0x0005F7A0
		protected virtual void SetVisualState(bool useTransitions)
		{
			switch (this.SortStatus)
			{
			case global::Infragistics.Windows.Controls.SortStatus.Ascending:
				global::System.Windows.VisualStateManager.GoToState(this, "SortAscending", useTransitions);
				return;
			case global::Infragistics.Windows.Controls.SortStatus.Descending:
				global::System.Windows.VisualStateManager.GoToState(this, "SortDescending", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Unsorted", useTransitions);
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x000615F4 File Offset: 0x0005F7F4
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SortIndicator sortIndicator = target as global::Infragistics.Windows.Controls.SortIndicator;
			sortIndicator.UpdateVisualStates();
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x0006160E File Offset: 0x0005F80E
		private void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00061617 File Offset: 0x0005F817
		private void UpdateVisualStates(bool useTransitions)
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

		// Token: 0x04000C2D RID: 3117
		private bool _hasVisualStateGroups;

		// Token: 0x04000C2E RID: 3118
		public static readonly global::System.Windows.DependencyProperty SortStatusProperty = global::System.Windows.DependencyProperty.Register("SortStatus", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.Controls.SortIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SortIndicator.OnSortStatusChanged)));
	}
}
