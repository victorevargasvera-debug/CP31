using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;
using Infragistics.Windows.Automation.Peers.DataPresenter;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000317 RID: 791
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupByAreaFieldLabel : global::System.Windows.Controls.Primitives.Thumb
	{
		// Token: 0x06002672 RID: 9842 RVA: 0x000ABD84 File Offset: 0x000A9F84
		static GroupByAreaFieldLabel()
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.AddedToAvailableListEvent = global::System.Windows.EventManager.RegisterRoutedEvent("AddedToAvailableList", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel));
			global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.AddedToGroupedListEvent = global::System.Windows.EventManager.RegisterRoutedEvent("AddedToGroupedList", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel));
			global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.RemovedFromAvailableListEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RemovedFromAvailableList", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel)));
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x000ABE92 File Offset: 0x000AA092
		internal GroupByAreaFieldLabel(global::Infragistics.Windows.DataPresenter.GroupByArea groupByArea, global::Infragistics.Windows.DataPresenter.Field field, global::System.Windows.Style defaultStyle)
		{
			this._groupByArea = groupByArea;
			base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.FieldPropertyKey, field);
			this.SetStyle(defaultStyle);
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x000ABEB4 File Offset: 0x000AA0B4
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaFieldLabelAutomationPeer(this);
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x000ABEBC File Offset: 0x000AA0BC
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Field)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.FieldProperty);
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x000ABED0 File Offset: 0x000AA0D0
		internal global::System.Windows.Rect RectInGroupByAreaCoordinates
		{
			get
			{
				global::System.Windows.Point location = global::Infragistics.Windows.Utilities.TransformPointToAncestorCoordinates(new global::System.Windows.Point(0.0, 0.0), this, this._groupByArea);
				if (location.X < 0.0)
				{
					location.X += 0.0;
				}
				location = base.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this._groupByArea);
				if (location.X < 0.0)
				{
					location.X += 0.0;
				}
				return new global::System.Windows.Rect(location, new global::System.Windows.Size(base.ActualWidth, base.ActualHeight));
			}
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x000ABF90 File Offset: 0x000AA190
		private static void StyleVersionNumberChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel = target as global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel;
			if (groupByAreaFieldLabel != null && groupByAreaFieldLabel._groupByArea != null)
			{
				groupByAreaFieldLabel.SetStyle(groupByAreaFieldLabel._groupByArea.GetDefaultGroupByFieldLabelStyle());
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x000ABFC0 File Offset: 0x000AA1C0
		// (set) Token: 0x06002679 RID: 9849 RVA: 0x000ABFD2 File Offset: 0x000AA1D2
		internal int StyleVersionNumber
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.StyleVersionNumberProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.StyleVersionNumberProperty, value);
			}
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x000ABFE8 File Offset: 0x000AA1E8
		private void SetStyle(global::System.Windows.Style defaultStyle)
		{
			global::System.Windows.Style style = null;
			if (this._groupByArea.DataPresenter.GroupByAreaFieldLabelStyleSelector != null)
			{
				style = this._groupByArea.DataPresenter.GroupByAreaFieldLabelStyleSelector.SelectStyle(this.Field, this);
			}
			if (style == null)
			{
				style = this._groupByArea.DataPresenter.GroupByAreaFieldLabelStyle;
			}
			if (style != null)
			{
				base.SetValue(global::System.Windows.FrameworkElement.StyleProperty, style);
				return;
			}
			if (defaultStyle != null)
			{
				base.SetValue(global::System.Windows.FrameworkElement.StyleProperty, defaultStyle);
				return;
			}
			base.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x000AC068 File Offset: 0x000AA268
		protected internal virtual void OnAddedToAvailableList()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.AddedToAvailableListEvent, this);
			base.RaiseEvent(e);
		}

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x0600267C RID: 9852 RVA: 0x000AC088 File Offset: 0x000AA288
		// (remove) Token: 0x0600267D RID: 9853 RVA: 0x000AC096 File Offset: 0x000AA296
		public event global::System.Windows.RoutedEventHandler AddedToAvailableList
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.AddedToAvailableListEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.AddedToAvailableListEvent, value);
			}
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x000AC0A4 File Offset: 0x000AA2A4
		protected internal virtual void OnAddedToGroupedList()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.AddedToGroupedListEvent, this);
			base.RaiseEvent(e);
		}

		// Token: 0x14000071 RID: 113
		// (add) Token: 0x0600267F RID: 9855 RVA: 0x000AC0C4 File Offset: 0x000AA2C4
		// (remove) Token: 0x06002680 RID: 9856 RVA: 0x000AC0D2 File Offset: 0x000AA2D2
		public event global::System.Windows.RoutedEventHandler AddedToGroupedList
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.AddedToGroupedListEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.AddedToGroupedListEvent, value);
			}
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x000AC0E0 File Offset: 0x000AA2E0
		protected internal virtual void OnRemovedFromAvailableList()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.RemovedFromAvailableListEvent, this);
			base.RaiseEvent(e);
		}

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x06002682 RID: 9858 RVA: 0x000AC100 File Offset: 0x000AA300
		// (remove) Token: 0x06002683 RID: 9859 RVA: 0x000AC10E File Offset: 0x000AA30E
		public event global::System.Windows.RoutedEventHandler RemovedFromAvailableList
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.RemovedFromAvailableListEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.RemovedFromAvailableListEvent, value);
			}
		}

		// Token: 0x04001309 RID: 4873
		private global::Infragistics.Windows.DataPresenter.GroupByArea _groupByArea;

		// Token: 0x0400130A RID: 4874
		private static readonly global::System.Windows.DependencyPropertyKey FieldPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400130B RID: 4875
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.FieldPropertyKey.DependencyProperty;

		// Token: 0x0400130C RID: 4876
		internal static readonly global::System.Windows.DependencyProperty StyleVersionNumberProperty = global::System.Windows.DependencyProperty.Register("StyleVersionNumber", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.StyleVersionNumberChanged)));
	}
}
