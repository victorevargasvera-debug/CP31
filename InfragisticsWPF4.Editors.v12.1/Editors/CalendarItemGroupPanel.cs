using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000036 RID: 54
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CalendarItemGroupPanel : global::System.Windows.FrameworkElement
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		static CalendarItemGroupPanel()
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar.MonthCalendarPropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.OnMonthCalendarChanged)));
			global::System.Windows.FrameworkElement.LanguageProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.OnLanguageChanged)));
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000FBE9 File Offset: 0x0000DDE9
		public CalendarItemGroupPanel()
		{
			this._groups = new global::System.Collections.Generic.List<global::Infragistics.Windows.Editors.CalendarItemGroup>();
			this._logicalChildren = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000FC08 File Offset: 0x0000DE08
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			int count = this._groups.Count;
			double num = this.GroupWidth;
			double num2 = this.GroupHeight;
			bool flag = double.IsNaN(num);
			bool flag2 = double.IsNaN(num2);
			if (flag2 || flag)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup itemGroupForSizing = this.ItemGroupForSizing;
				itemGroupForSizing.Arrange(new global::System.Windows.Rect(itemGroupForSizing.DesiredSize));
				if (flag)
				{
					num = itemGroupForSizing.ActualWidth;
				}
				if (flag2)
				{
					num2 = itemGroupForSizing.ActualHeight;
				}
			}
			global::Infragistics.Windows.Editors.CalendarDimensions dimensions = this.Dimensions;
			global::System.Windows.Size availableSize = new global::System.Windows.Size(num, num2);
			int num3 = dimensions.Columns * dimensions.Rows;
			if (this.AutoAdjustDimensions)
			{
				this.AdjustDimensions(ref finalSize, ref dimensions, ref availableSize, ref num3);
			}
			for (int i = count; i < num3; i++)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = new global::Infragistics.Windows.Editors.CalendarItemGroup();
				((global::System.ComponentModel.ISupportInitialize)calendarItemGroup).BeginInit();
				calendarItemGroup.ReferenceGroupOffset = i;
				this._groups.Add(calendarItemGroup);
			}
			for (int j = count; j > num3; j--)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup2 = this._groups[j - 1];
				this._groups.RemoveAt(j - 1);
				base.RemoveVisualChild(calendarItemGroup2);
				this.RemoveLogicalChildHelper(calendarItemGroup2);
			}
			bool showLeadingAndTrailing = this.ShowLeadingAndTrailing;
			global::System.Windows.HorizontalAlignment horizontalContentAlignment = this.HorizontalContentAlignment;
			global::System.Windows.VerticalAlignment verticalContentAlignment = this.VerticalContentAlignment;
			double num4;
			double num5;
			global::Infragistics.Windows.Editors.CalendarItemGroupPanel.CalculateOffset(ref finalSize, ref dimensions, ref availableSize, horizontalContentAlignment, verticalContentAlignment, out num4, out num5);
			global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(this);
			object value = base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ScrollButtonVisibilityProperty);
			object obj = global::System.Windows.Visibility.Collapsed.Equals(value) ? global::Infragistics.KnownBoxes.VisibilityCollapsedBox : global::Infragistics.KnownBoxes.VisibilityHiddenBox;
			int k = 0;
			int num6 = this._groups.Count - 1;
			while (k <= num6)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup3 = this._groups[k];
				this._groupBeingMeasured = calendarItemGroup3;
				calendarItemGroup3.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ShowLeadingDatesProperty, global::Infragistics.KnownBoxes.FromValue(showLeadingAndTrailing && k == 0));
				calendarItemGroup3.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ShowTrailingDatesProperty, global::Infragistics.KnownBoxes.FromValue(showLeadingAndTrailing && k == num6));
				calendarItemGroup3.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ScrollPreviousButtonVisibilityProperty, (k == 0) ? value : obj);
				calendarItemGroup3.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ScrollNextButtonVisibilityProperty, (k == dimensions.Columns - 1) ? value : obj);
				if (k >= count)
				{
					base.AddVisualChild(calendarItemGroup3);
					this.AddLogicalChildHelper(calendarItemGroup3);
					((global::System.ComponentModel.ISupportInitialize)calendarItemGroup3).EndInit();
				}
				calendarItemGroup3.Measure(availableSize);
				int num7 = k / dimensions.Columns;
				int num8 = k % dimensions.Columns;
				global::System.Windows.Rect finalRect = new global::System.Windows.Rect((double)num8 * availableSize.Width, (double)num7 * availableSize.Height, availableSize.Width, availableSize.Height);
				switch (horizontalContentAlignment)
				{
				case global::System.Windows.HorizontalAlignment.Center:
				case global::System.Windows.HorizontalAlignment.Right:
					finalRect.X += num4;
					break;
				case global::System.Windows.HorizontalAlignment.Stretch:
					finalRect.X += num4 * (double)(num8 + 1);
					break;
				}
				switch (verticalContentAlignment)
				{
				case global::System.Windows.VerticalAlignment.Center:
				case global::System.Windows.VerticalAlignment.Bottom:
					finalRect.Y += num5;
					break;
				case global::System.Windows.VerticalAlignment.Stretch:
					finalRect.Y += num5 * (double)(num7 + 1);
					break;
				}
				calendarItemGroup3.Arrange(finalRect);
				this._groupBeingMeasured = null;
				k++;
			}
			if (num3 != count && monthCalendar != null)
			{
				monthCalendar.OnAutoGeneratedGroupsChanged();
			}
			global::System.Windows.Size size = new global::System.Windows.Size(availableSize.Width * (double)dimensions.Columns, availableSize.Height * (double)dimensions.Rows);
			if (finalSize.Width < size.Width)
			{
				finalSize.Width = size.Width;
			}
			if (finalSize.Height < size.Height)
			{
				finalSize.Height = size.Height;
			}
			return finalSize;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000FFAA File Offset: 0x0000E1AA
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (this._itemGroupForSizing != null)
			{
				if (index == 0)
				{
					return this._itemGroupForSizing;
				}
				index--;
			}
			return this._groups[index];
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0000FFCF File Offset: 0x0000E1CF
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return this._logicalChildren.GetEnumerator();
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000FFE1 File Offset: 0x0000E1E1
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (child == this._groupBeingMeasured)
			{
				return;
			}
			if (child != this._itemGroupForSizing)
			{
				return;
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00010000 File Offset: 0x0000E200
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			double num = this.GroupWidth;
			double num2 = this.GroupHeight;
			bool flag = double.IsNaN(num);
			bool flag2 = double.IsNaN(num2);
			if (flag2 || flag)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup itemGroupForSizing = this.ItemGroupForSizing;
				global::System.Windows.Size size = default(global::System.Windows.Size);
				if (itemGroupForSizing != null)
				{
					itemGroupForSizing.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
					size = itemGroupForSizing.DesiredSize;
				}
				if (flag)
				{
					num = size.Width;
				}
				if (flag2)
				{
					num2 = size.Height;
				}
			}
			else
			{
				this.ReleaseSizingGroup();
			}
			global::Infragistics.Windows.Editors.CalendarDimensions dimensions = this.Dimensions;
			global::System.Windows.Size result = new global::System.Windows.Size((double)dimensions.Columns * num, (double)dimensions.Rows * num2);
			if (result.Width > availableSize.Width)
			{
				result.Width = availableSize.Width;
			}
			if (result.Height > availableSize.Height)
			{
				result.Height = availableSize.Height;
			}
			return result;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003CA RID: 970 RVA: 0x000100EC File Offset: 0x0000E2EC
		protected override int VisualChildrenCount
		{
			get
			{
				int num = this._groups.Count;
				if (this._itemGroupForSizing != null)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00010112 File Offset: 0x0000E312
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00010124 File Offset: 0x0000E324
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.HorizontalContentAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.HorizontalContentAlignmentProperty, value);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00010137 File Offset: 0x0000E337
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00010149 File Offset: 0x0000E349
		[global::System.ComponentModel.Bindable(true)]
		public double GroupHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.GroupHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.GroupHeightProperty, value);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0001015C File Offset: 0x0000E35C
		private static bool ValidateWidthHeight(object newValue)
		{
			double num = (double)newValue;
			return double.IsNaN(num) || (num >= 0.0 && !double.IsInfinity(num));
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00010191 File Offset: 0x0000E391
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x000101A3 File Offset: 0x0000E3A3
		[global::System.ComponentModel.Bindable(true)]
		public double GroupWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.GroupWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.GroupWidthProperty, value);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x000101B6 File Offset: 0x0000E3B6
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x000101C8 File Offset: 0x0000E3C8
		[global::System.ComponentModel.Bindable(true)]
		public int MaxGroups
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.MaxGroupsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.MaxGroupsProperty, value);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000101DB File Offset: 0x0000E3DB
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x000101ED File Offset: 0x0000E3ED
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return (global::System.Windows.VerticalAlignment)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.VerticalContentAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.VerticalContentAlignmentProperty, value);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00010200 File Offset: 0x0000E400
		private bool AutoAdjustDimensions
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.AutoAdjustCalendarDimensionsProperty);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00010212 File Offset: 0x0000E412
		private global::Infragistics.Windows.Editors.CalendarDimensions Dimensions
		{
			get
			{
				return (global::Infragistics.Windows.Editors.CalendarDimensions)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.CalendarDimensionsProperty);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00010224 File Offset: 0x0000E424
		internal global::Infragistics.Windows.Editors.CalendarManager CalendarManager
		{
			get
			{
				global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(this);
				if (monthCalendar == null)
				{
					return global::Infragistics.Windows.Editors.CalendarManager.CurrentCulture;
				}
				return monthCalendar.CalendarManager;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00010248 File Offset: 0x0000E448
		private global::Infragistics.Windows.Editors.CalendarItemGroup ItemGroupForSizing
		{
			get
			{
				if (this._itemGroupForSizing == null)
				{
					this._itemGroupForSizing = new global::Infragistics.Windows.Editors.CalendarItemGroup(null, true);
					((global::System.ComponentModel.ISupportInitialize)this._itemGroupForSizing).BeginInit();
					this._itemGroupForSizing.Name = "GroupForSizing";
					this._itemGroupForSizing.Visibility = global::System.Windows.Visibility.Hidden;
					base.AddVisualChild(this._itemGroupForSizing);
					this.AddLogicalChildHelper(this._itemGroupForSizing);
					((global::System.ComponentModel.ISupportInitialize)this._itemGroupForSizing).EndInit();
				}
				return this._itemGroupForSizing;
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000102C4 File Offset: 0x0000E4C4
		private static void OnShowLeadingAndTrailingDatesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroupPanel calendarItemGroupPanel = (global::Infragistics.Windows.Editors.CalendarItemGroupPanel)d;
			calendarItemGroupPanel.InvalidateMeasure();
			if (0 < calendarItemGroupPanel._groups.Count)
			{
				bool flag = (bool)e.NewValue;
				calendarItemGroupPanel._groups[0].ShowLeadingDates = flag;
				calendarItemGroupPanel._groups[calendarItemGroupPanel._groups.Count - 1].ShowTrailingDates = flag;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00010329 File Offset: 0x0000E529
		private bool ShowLeadingAndTrailing
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.ShowLeadingAndTrailingDatesProperty);
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0001033B File Offset: 0x0000E53B
		private void AddLogicalChildHelper(object newChild)
		{
			if (newChild != null)
			{
				this._logicalChildren.Add(newChild);
				base.AddLogicalChild(newChild);
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00010354 File Offset: 0x0000E554
		private void AdjustDimensions(ref global::System.Windows.Size finalSize, ref global::Infragistics.Windows.Editors.CalendarDimensions dims, ref global::System.Windows.Size itemSize, ref int requiredGroups)
		{
			global::Infragistics.Windows.Editors.CalendarDimensions calendarDimensions = dims;
			int num = (this.MaxGroups > 0) ? global::System.Math.Max(calendarDimensions.Columns * calendarDimensions.Rows, this.MaxGroups) : 0;
			dims.Columns = global::System.Math.Max(1, global::System.Math.Max(calendarDimensions.Columns, (int)global::System.Math.Round(finalSize.Width / itemSize.Width, 8)));
			dims.Rows = global::System.Math.Max(1, global::System.Math.Max(calendarDimensions.Rows, (int)global::System.Math.Round(finalSize.Height / itemSize.Height, 8)));
			requiredGroups = dims.Columns * dims.Rows;
			if (num > 0 && requiredGroups > num)
			{
				int i = requiredGroups - num;
				while (i > 0)
				{
					int num2 = i;
					if ((dims.Columns == calendarDimensions.Columns || dims.Rows >= dims.Columns) && dims.Rows > calendarDimensions.Rows && i >= dims.Columns)
					{
						dims.Rows--;
						i -= global::System.Math.Min(i, dims.Columns);
					}
					if ((dims.Rows == calendarDimensions.Rows || dims.Columns >= dims.Rows) && dims.Columns > calendarDimensions.Columns && i >= dims.Rows)
					{
						dims.Columns--;
						i -= global::System.Math.Min(i, dims.Rows);
					}
					if (num2 == i)
					{
						break;
					}
				}
				requiredGroups = num;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000104C8 File Offset: 0x0000E6C8
		private static void CalculateOffset(ref global::System.Windows.Size finalSize, ref global::Infragistics.Windows.Editors.CalendarDimensions dims, ref global::System.Windows.Size itemSize, global::System.Windows.HorizontalAlignment hAlign, global::System.Windows.VerticalAlignment vAlign, out double xOffset, out double yOffset)
		{
			if (dims.Columns > 0)
			{
				switch (hAlign)
				{
				case global::System.Windows.HorizontalAlignment.Left:
					xOffset = 0.0;
					break;
				default:
					xOffset = (finalSize.Width - itemSize.Width * (double)dims.Columns) / 2.0;
					break;
				case global::System.Windows.HorizontalAlignment.Right:
					xOffset = finalSize.Width - itemSize.Width * (double)dims.Columns;
					break;
				case global::System.Windows.HorizontalAlignment.Stretch:
					xOffset = (finalSize.Width - (double)dims.Columns * itemSize.Width) / (double)(dims.Columns + 1);
					break;
				}
			}
			else
			{
				xOffset = 0.0;
			}
			if (dims.Rows <= 0)
			{
				yOffset = 0.0;
				return;
			}
			switch (vAlign)
			{
			case global::System.Windows.VerticalAlignment.Top:
				yOffset = 0.0;
				return;
			default:
				yOffset = (finalSize.Height - itemSize.Height * (double)dims.Rows) / 2.0;
				return;
			case global::System.Windows.VerticalAlignment.Bottom:
				yOffset = finalSize.Height - itemSize.Height * (double)dims.Rows;
				return;
			case global::System.Windows.VerticalAlignment.Stretch:
				yOffset = (finalSize.Height - (double)dims.Rows * itemSize.Height) / (double)(dims.Rows + 1);
				return;
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00010614 File Offset: 0x0000E814
		private static void OnLanguageChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroupPanel calendarItemGroupPanel = d as global::Infragistics.Windows.Editors.CalendarItemGroupPanel;
			for (int i = calendarItemGroupPanel._groups.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = calendarItemGroupPanel._groups[i];
				calendarItemGroupPanel._groups.RemoveAt(i);
				calendarItemGroupPanel.RemoveVisualChild(calendarItemGroup);
				calendarItemGroupPanel.RemoveLogicalChildHelper(calendarItemGroup);
			}
			if (calendarItemGroupPanel._itemGroupForSizing != null)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup itemGroupForSizing = calendarItemGroupPanel._itemGroupForSizing;
				calendarItemGroupPanel._itemGroupForSizing = null;
				calendarItemGroupPanel.RemoveVisualChild(itemGroupForSizing);
				calendarItemGroupPanel.RemoveLogicalChildHelper(itemGroupForSizing);
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0001068C File Offset: 0x0000E88C
		private static void OnMonthCalendarChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroupPanel calendarItemGroupPanel = (global::Infragistics.Windows.Editors.CalendarItemGroupPanel)d;
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = e.NewValue as global::Infragistics.Windows.Editors.XamMonthCalendar;
			if (xamMonthCalendar != null)
			{
				calendarItemGroupPanel.SetBinding(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.ShowLeadingAndTrailingDatesProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Editors.XamMonthCalendar.ShowLeadingAndTrailingDatesProperty, global::System.Windows.Data.BindingMode.OneWay, xamMonthCalendar));
				calendarItemGroupPanel.SetBinding(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.CalendarDimensionsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarDimensionsProperty, global::System.Windows.Data.BindingMode.OneWay, xamMonthCalendar));
				calendarItemGroupPanel.SetBinding(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.AutoAdjustCalendarDimensionsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Editors.XamMonthCalendar.AutoAdjustCalendarDimensionsProperty, global::System.Windows.Data.BindingMode.OneWay, xamMonthCalendar));
				calendarItemGroupPanel.SetBinding(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.ScrollButtonVisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Editors.XamMonthCalendar.ScrollButtonVisibilityProperty, global::System.Windows.Data.BindingMode.OneWay, xamMonthCalendar));
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00010710 File Offset: 0x0000E910
		private void ReleaseSizingGroup()
		{
			if (this._itemGroupForSizing != null)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup itemGroupForSizing = this._itemGroupForSizing;
				this._itemGroupForSizing = null;
				base.RemoveVisualChild(itemGroupForSizing);
				this.RemoveLogicalChildHelper(itemGroupForSizing);
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00010741 File Offset: 0x0000E941
		private void RemoveLogicalChildHelper(object oldChild)
		{
			if (oldChild != null)
			{
				this._logicalChildren.Remove(oldChild);
				base.RemoveLogicalChild(oldChild);
			}
		}

		// Token: 0x04000154 RID: 340
		private const string SizingGroupName = "GroupForSizing";

		// Token: 0x04000155 RID: 341
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Editors.CalendarItemGroup> _groups;

		// Token: 0x04000156 RID: 342
		private global::Infragistics.Windows.Editors.CalendarItemGroup _itemGroupForSizing;

		// Token: 0x04000157 RID: 343
		private global::System.Collections.Generic.List<object> _logicalChildren;

		// Token: 0x04000158 RID: 344
		private global::Infragistics.Windows.Editors.CalendarItemGroup _groupBeingMeasured;

		// Token: 0x04000159 RID: 345
		public static readonly global::System.Windows.DependencyProperty HorizontalContentAlignmentProperty = global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));

		// Token: 0x0400015A RID: 346
		public static readonly global::System.Windows.DependencyProperty GroupHeightProperty = global::System.Windows.DependencyProperty.Register("GroupHeight", typeof(double), typeof(global::Infragistics.Windows.Editors.CalendarItemGroupPanel), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.ValidateWidthHeight));

		// Token: 0x0400015B RID: 347
		public static readonly global::System.Windows.DependencyProperty GroupWidthProperty = global::System.Windows.DependencyProperty.Register("GroupWidth", typeof(double), typeof(global::Infragistics.Windows.Editors.CalendarItemGroupPanel), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.ValidateWidthHeight));

		// Token: 0x0400015C RID: 348
		public static readonly global::System.Windows.DependencyProperty MaxGroupsProperty = global::System.Windows.DependencyProperty.Register("MaxGroups", typeof(int), typeof(global::Infragistics.Windows.Editors.CalendarItemGroupPanel), new global::System.Windows.FrameworkPropertyMetadata(12), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.Utils.ValidateIntZeroOrMore));

		// Token: 0x0400015D RID: 349
		public static readonly global::System.Windows.DependencyProperty VerticalContentAlignmentProperty = global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));

		// Token: 0x0400015E RID: 350
		private static readonly global::System.Windows.DependencyProperty AutoAdjustCalendarDimensionsProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.AutoAdjustCalendarDimensionsProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));

		// Token: 0x0400015F RID: 351
		private static readonly global::System.Windows.DependencyProperty CalendarDimensionsProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarDimensionsProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::Infragistics.Windows.Editors.CalendarDimensions(1, 1), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));

		// Token: 0x04000160 RID: 352
		private static readonly global::System.Windows.DependencyProperty ShowLeadingAndTrailingDatesProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.ShowLeadingAndTrailingDatesProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroupPanel.OnShowLeadingAndTrailingDatesChanged)));

		// Token: 0x04000161 RID: 353
		private static readonly global::System.Windows.DependencyProperty ScrollButtonVisibilityProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.ScrollButtonVisibilityProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));
	}
}
