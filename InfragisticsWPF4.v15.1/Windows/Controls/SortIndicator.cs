using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020002BF RID: 703
	[global::System.Windows.TemplateVisualState(Name = "SortDescending", GroupName = "SortStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unsorted", GroupName = "SortStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "SortAscending", GroupName = "SortStates")]
	public class SortIndicator : global::System.Windows.Controls.Button
	{
		// Token: 0x06001B97 RID: 7063 RVA: 0x000685DC File Offset: 0x000667DC
		static SortIndicator()
		{
			global::Infragistics.Windows.Controls.SortIndicator.SortStatusChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SortStatusChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.SortStatusChangedEventArgs>), typeof(global::Infragistics.Windows.Controls.SortIndicator));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SortIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.SortIndicator)));
			global::System.Windows.UIElement.IsHitTestVisibleProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.SortIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00068688 File Offset: 0x00066888
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x000686A4 File Offset: 0x000668A4
		private static void OnSortStatusChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SortIndicator sortIndicator = target as global::Infragistics.Windows.Controls.SortIndicator;
			if (sortIndicator != null)
			{
				sortIndicator.OnSortStatusChanged((global::Infragistics.Windows.Controls.SortStatus)e.OldValue, (global::Infragistics.Windows.Controls.SortStatus)e.NewValue);
				sortIndicator.UpdateVisualStates();
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x000686DF File Offset: 0x000668DF
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x000686F1 File Offset: 0x000668F1
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

		// Token: 0x06001B9C RID: 7068 RVA: 0x00068704 File Offset: 0x00066904
		protected virtual void OnSortStatusChanged(global::Infragistics.Windows.Controls.SortStatus previousValue, global::Infragistics.Windows.Controls.SortStatus currentValue)
		{
			base.RaiseEvent(new global::Infragistics.Windows.Controls.Events.SortStatusChangedEventArgs(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Controls.SortIndicator.SortStatusChangedEvent,
				Source = this
			});
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06001B9D RID: 7069 RVA: 0x00068732 File Offset: 0x00066932
		// (remove) Token: 0x06001B9E RID: 7070 RVA: 0x00068740 File Offset: 0x00066940
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

		// Token: 0x06001B9F RID: 7071 RVA: 0x00068750 File Offset: 0x00066950
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

		// Token: 0x06001BA0 RID: 7072 RVA: 0x000687A4 File Offset: 0x000669A4
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.SortIndicator sortIndicator = target as global::Infragistics.Windows.Controls.SortIndicator;
			sortIndicator.UpdateVisualStates();
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x000687BE File Offset: 0x000669BE
		private void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x000687C7 File Offset: 0x000669C7
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

		// Token: 0x04000DA0 RID: 3488
		private bool _hasVisualStateGroups;

		// Token: 0x04000DA1 RID: 3489
		public static readonly global::System.Windows.DependencyProperty SortStatusProperty = global::System.Windows.DependencyProperty.Register("SortStatus", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.Controls.SortIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.SortIndicator.OnSortStatusChanged)));
	}
}
