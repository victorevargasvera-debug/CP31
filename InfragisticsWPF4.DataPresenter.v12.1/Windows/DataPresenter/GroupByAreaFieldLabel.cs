using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;
using Infragistics.Windows.Automation.Peers.DataPresenter;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002D8 RID: 728
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupByAreaFieldLabel : global::System.Windows.Controls.Primitives.Thumb
	{
		// Token: 0x060022D3 RID: 8915 RVA: 0x000984F8 File Offset: 0x000966F8
		static GroupByAreaFieldLabel()
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.AddedToAvailableListEvent = global::System.Windows.EventManager.RegisterRoutedEvent("AddedToAvailableList", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel));
			global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.AddedToGroupedListEvent = global::System.Windows.EventManager.RegisterRoutedEvent("AddedToGroupedList", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel));
			global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.RemovedFromAvailableListEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RemovedFromAvailableList", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel)));
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00098606 File Offset: 0x00096806
		internal GroupByAreaFieldLabel(global::Infragistics.Windows.DataPresenter.GroupByArea groupByArea, global::Infragistics.Windows.DataPresenter.Field field, global::System.Windows.Style defaultStyle)
		{
			this._groupByArea = groupByArea;
			base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.FieldPropertyKey, field);
			this.SetStyle(defaultStyle);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00098628 File Offset: 0x00096828
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaFieldLabelAutomationPeer(this);
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x00098630 File Offset: 0x00096830
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Field)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.FieldProperty);
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x00098644 File Offset: 0x00096844
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

		// Token: 0x060022D8 RID: 8920 RVA: 0x00098704 File Offset: 0x00096904
		private static void StyleVersionNumberChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel = target as global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel;
			if (groupByAreaFieldLabel != null && groupByAreaFieldLabel._groupByArea != null)
			{
				groupByAreaFieldLabel.SetStyle(groupByAreaFieldLabel._groupByArea.GetDefaultGroupByFieldLabelStyle());
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x00098734 File Offset: 0x00096934
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x00098746 File Offset: 0x00096946
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

		// Token: 0x060022DB RID: 8923 RVA: 0x0009875C File Offset: 0x0009695C
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

		// Token: 0x060022DC RID: 8924 RVA: 0x000987DC File Offset: 0x000969DC
		protected internal virtual void OnAddedToAvailableList()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.AddedToAvailableListEvent, this);
			base.RaiseEvent(e);
		}

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x060022DD RID: 8925 RVA: 0x000987FC File Offset: 0x000969FC
		// (remove) Token: 0x060022DE RID: 8926 RVA: 0x0009880A File Offset: 0x00096A0A
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

		// Token: 0x060022DF RID: 8927 RVA: 0x00098818 File Offset: 0x00096A18
		protected internal virtual void OnAddedToGroupedList()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.AddedToGroupedListEvent, this);
			base.RaiseEvent(e);
		}

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x060022E0 RID: 8928 RVA: 0x00098838 File Offset: 0x00096A38
		// (remove) Token: 0x060022E1 RID: 8929 RVA: 0x00098846 File Offset: 0x00096A46
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

		// Token: 0x060022E2 RID: 8930 RVA: 0x00098854 File Offset: 0x00096A54
		protected internal virtual void OnRemovedFromAvailableList()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.RemovedFromAvailableListEvent, this);
			base.RaiseEvent(e);
		}

		// Token: 0x14000071 RID: 113
		// (add) Token: 0x060022E3 RID: 8931 RVA: 0x00098874 File Offset: 0x00096A74
		// (remove) Token: 0x060022E4 RID: 8932 RVA: 0x00098882 File Offset: 0x00096A82
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

		// Token: 0x040010F0 RID: 4336
		private global::Infragistics.Windows.DataPresenter.GroupByArea _groupByArea;

		// Token: 0x040010F1 RID: 4337
		private static readonly global::System.Windows.DependencyPropertyKey FieldPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040010F2 RID: 4338
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.FieldPropertyKey.DependencyProperty;

		// Token: 0x040010F3 RID: 4339
		internal static readonly global::System.Windows.DependencyProperty StyleVersionNumberProperty = global::System.Windows.DependencyProperty.Register("StyleVersionNumber", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.StyleVersionNumberChanged)));
	}
}
