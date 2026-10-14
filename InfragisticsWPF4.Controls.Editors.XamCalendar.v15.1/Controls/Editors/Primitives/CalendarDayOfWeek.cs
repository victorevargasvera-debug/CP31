using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000016 RID: 22
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CalendarDayOfWeek : global::System.Windows.Controls.Control
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x00004DDC File Offset: 0x00002FDC
		static CalendarDayOfWeek()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.OnIsEnabledPropertyChanged)));
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00004F2F File Offset: 0x0000312F
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this._isInitialized = true;
			this.UpdateVisualStates(false);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00004F51 File Offset: 0x00003151
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			this.SelectEntireMonth();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004F60 File Offset: 0x00003160
		private void SelectEntireMonth()
		{
			global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(this);
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (parent != null) ? global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(parent) : null;
			if (calendarBase != null && calendarBase.SupportsWeekSelectionMode)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup visualAncestor = global::Infragistics.Controls.PresentationUtilities.GetVisualAncestor<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup>(this, null, null);
				if (visualAncestor != null && visualAncestor.FirstDateOfGroup != null && visualAncestor.LastDateOfGroup != null)
				{
					global::Infragistics.Controls.Editors.CalendarManager calendarManager = calendarBase.CalendarManager;
					int num;
					global::System.DateTime firstDayOfWeekForDate = calendarManager.GetFirstDayOfWeekForDate(visualAncestor.FirstDateOfGroup.Value, null, out num);
					global::System.DateTime t = calendarManager.AddDays(calendarManager.GetFirstDayOfWeekForDate(visualAncestor.LastDateOfGroup.Value, null, out num), 6);
					global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>(t.Subtract(firstDayOfWeekForDate).Days + 1);
					global::System.DateTime dateTime = firstDayOfWeekForDate;
					while (t >= dateTime)
					{
						list.Add(dateTime);
						dateTime = calendarManager.AddDays(dateTime, 1);
					}
					global::Infragistics.Collections.DateCollection selectedDates = calendarBase.SelectedDates;
					if (selectedDates.Count != list.Count || selectedDates[0] != list[0] || selectedDates[selectedDates.Count - 1] != list[list.Count - 1])
					{
						selectedDates.Reinitialize(list);
					}
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000050C1 File Offset: 0x000032C1
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000050D3 File Offset: 0x000032D3
		public global::System.Windows.Media.Brush ComputedBackground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.ComputedBackgroundProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.ComputedBackgroundPropertyKey, value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000050E1 File Offset: 0x000032E1
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000050F3 File Offset: 0x000032F3
		public global::System.Windows.Media.Brush ComputedForeground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.ComputedForegroundProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.ComputedForegroundPropertyKey, value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005101 File Offset: 0x00003301
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00005113 File Offset: 0x00003313
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DayOfWeek DayOfWeek
		{
			get
			{
				return (global::System.DayOfWeek)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.DayOfWeekProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.DayOfWeekPropertyKey, value);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005128 File Offset: 0x00003328
		private static void OnDisplayTextChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek calendarDayOfWeek = d as global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek;
			calendarDayOfWeek.InvalidateMeasure();
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00005142 File Offset: 0x00003342
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00005154 File Offset: 0x00003354
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public string DisplayText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.DisplayTextProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.DisplayTextPropertyKey, value);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005162 File Offset: 0x00003362
		internal void Initialize(global::System.DayOfWeek dow, global::Infragistics.Controls.Editors.CalendarBase cal)
		{
			this.DayOfWeek = dow;
			this.DisplayText = cal.GetDayOfWeekHeader(this.DayOfWeek);
			global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(this, cal);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005184 File Offset: 0x00003384
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (!base.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
			}
			this.SetProviderBrushes();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000051B0 File Offset: 0x000033B0
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek calendarDayOfWeek = target as global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek;
			if (calendarDayOfWeek != null)
			{
				calendarDayOfWeek.UpdateVisualStates();
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000051CD File Offset: 0x000033CD
		protected internal void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000051D6 File Offset: 0x000033D6
		protected void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				this.SetProviderBrushes();
				return;
			}
			if (!this._isInitialized)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000051FC File Offset: 0x000033FC
		private static void OnIsEnabledPropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek calendarDayOfWeek = target as global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek;
			calendarDayOfWeek.UpdateVisualStates();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00005218 File Offset: 0x00003418
		internal void SetProviderBrushes()
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(this);
			if (calendar == null)
			{
				return;
			}
			global::Infragistics.Controls.Editors.CalendarResourceProvider resourceProviderResolved = calendar.ResourceProviderResolved;
			if (resourceProviderResolved == null)
			{
				return;
			}
			bool isEnabled = base.IsEnabled;
			global::Infragistics.Controls.Editors.CalendarResourceId key;
			global::Infragistics.Controls.Editors.CalendarResourceId key2;
			if (isEnabled)
			{
				key = global::Infragistics.Controls.Editors.CalendarResourceId.DayOfWeekBackgroundBrush;
				key2 = global::Infragistics.Controls.Editors.CalendarResourceId.DayOfWeekForegroundBrush;
			}
			else
			{
				key = global::Infragistics.Controls.Editors.CalendarResourceId.DisabledDayOfWeekBackgroundBrush;
				key2 = global::Infragistics.Controls.Editors.CalendarResourceId.DisabledDayOfWeekForegroundBrush;
			}
			this.ComputedBackground = (resourceProviderResolved[key] as global::System.Windows.Media.Brush);
			this.ComputedForeground = (resourceProviderResolved[key2] as global::System.Windows.Media.Brush);
		}

		// Token: 0x0400004D RID: 77
		private bool _hasVisualStateGroups;

		// Token: 0x0400004E RID: 78
		private bool _isInitialized;

		// Token: 0x0400004F RID: 79
		private static readonly global::System.Windows.DependencyPropertyKey ComputedBackgroundPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedBackground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek), new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Transparent), null);

		// Token: 0x04000050 RID: 80
		public static readonly global::System.Windows.DependencyProperty ComputedBackgroundProperty = global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.ComputedBackgroundPropertyKey.DependencyProperty;

		// Token: 0x04000051 RID: 81
		private static readonly global::System.Windows.DependencyPropertyKey ComputedForegroundPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedForeground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek), new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Black), null);

		// Token: 0x04000052 RID: 82
		public static readonly global::System.Windows.DependencyProperty ComputedForegroundProperty = global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.ComputedForegroundPropertyKey.DependencyProperty;

		// Token: 0x04000053 RID: 83
		private static readonly global::System.Windows.DependencyPropertyKey DayOfWeekPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("DayOfWeek", typeof(global::System.DayOfWeek), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek), global::System.DayOfWeek.Sunday, null);

		// Token: 0x04000054 RID: 84
		public static readonly global::System.Windows.DependencyProperty DayOfWeekProperty = global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.DayOfWeekPropertyKey.DependencyProperty;

		// Token: 0x04000055 RID: 85
		private static readonly global::System.Windows.DependencyPropertyKey DisplayTextPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("DisplayText", typeof(string), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek), string.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.OnDisplayTextChanged));

		// Token: 0x04000056 RID: 86
		public static readonly global::System.Windows.DependencyProperty DisplayTextProperty = global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek.DisplayTextPropertyKey.DependencyProperty;
	}
}
