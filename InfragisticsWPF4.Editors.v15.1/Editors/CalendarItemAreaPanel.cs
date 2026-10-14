using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000036 RID: 54
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CalendarItemAreaPanel : global::System.Windows.FrameworkElement, global::Infragistics.Windows.Editors.ICalendarItemArea
	{
		// Token: 0x06000376 RID: 886 RVA: 0x0000E1C4 File Offset: 0x0000C3C4
		static CalendarItemAreaPanel()
		{
			global::System.Windows.UIElement.ClipToBoundsProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemAreaPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
			global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModePropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemAreaPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemAreaPanel.OnCurrentCalendarModeChanged)));
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000E228 File Offset: 0x0000C428
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(finalSize);
			for (int i = 0; i < this._areas.Count; i++)
			{
				this._areas[i].Arrange(finalRect);
			}
			return finalSize;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000E266 File Offset: 0x0000C466
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index < 0 || index >= this._areas.Count)
			{
				throw new global::System.ArgumentOutOfRangeException();
			}
			return this._areas[index];
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000E28C File Offset: 0x0000C48C
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return this._areas.GetEnumerator();
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000E2A0 File Offset: 0x0000C4A0
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = default(global::System.Windows.Size);
			int i = 0;
			int count = this._areas.Count;
			while (i < count)
			{
				global::Infragistics.Windows.Editors.CalendarItemArea calendarItemArea = this._areas[i];
				calendarItemArea.Measure(availableSize);
				global::System.Windows.Size desiredSize = calendarItemArea.DesiredSize;
				if (desiredSize.Width > result.Width)
				{
					result.Width = desiredSize.Width;
				}
				if (desiredSize.Height > result.Height)
				{
					result.Height = desiredSize.Height;
				}
				i++;
			}
			return result;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000E326 File Offset: 0x0000C526
		protected override void OnInitialized(global::System.EventArgs e)
		{
			if (this._group != null)
			{
				if (this._group.IsGroupForSizing)
				{
					this.InitializeSizingGroupPanel();
				}
				else
				{
					((global::Infragistics.Windows.Editors.ICalendarItemArea)this).InitializeItems();
				}
			}
			base.OnInitialized(e);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000E354 File Offset: 0x0000C554
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = base.TemplatedParent as global::Infragistics.Windows.Editors.CalendarItemGroup;
			if (calendarItemGroup != null)
			{
				this.InitializeGroup(calendarItemGroup);
			}
			base.OnVisualParentChanged(oldParent);
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000E37E File Offset: 0x0000C57E
		protected override int VisualChildrenCount
		{
			get
			{
				return this._areas.Count;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000E38C File Offset: 0x0000C58C
		private global::Infragistics.Windows.Editors.CalendarItemArea CurrentArea
		{
			get
			{
				return this.CreateItemArea(this._areaIndex, null);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
		private global::Infragistics.Windows.Editors.CalendarItemArea OldArea
		{
			get
			{
				int index = (this._areaIndex == 0) ? 1 : 0;
				return this.CreateItemArea(index, null);
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000E3DC File Offset: 0x0000C5DC
		private static void AddFadeAnimation(global::System.Windows.Duration duration, bool isNew, global::System.Windows.Media.Animation.Storyboard sb)
		{
			global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
			doubleAnimation.SetValue(isNew ? global::System.Windows.Media.Animation.DoubleAnimation.ToProperty : global::System.Windows.Media.Animation.DoubleAnimation.FromProperty, 1.0);
			doubleAnimation.SetValue(isNew ? global::System.Windows.Media.Animation.DoubleAnimation.FromProperty : global::System.Windows.Media.Animation.DoubleAnimation.ToProperty, 0.0);
			doubleAnimation.Duration = duration;
			global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath(global::System.Windows.UIElement.OpacityProperty));
			sb.Children.Add(doubleAnimation);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000E458 File Offset: 0x0000C658
		private static void AddVisibilityAnimation(global::System.Windows.Media.Animation.Storyboard sb, global::System.Windows.Duration duration)
		{
			global::System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames objectAnimationUsingKeyFrames = new global::System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames();
			global::System.Windows.Media.Animation.DiscreteObjectKeyFrame keyFrame = new global::System.Windows.Media.Animation.DiscreteObjectKeyFrame(global::Infragistics.KnownBoxes.VisibilityVisibleBox, global::System.Windows.Media.Animation.KeyTime.FromPercent(0.0));
			global::System.Windows.Media.Animation.DiscreteObjectKeyFrame keyFrame2 = new global::System.Windows.Media.Animation.DiscreteObjectKeyFrame(global::Infragistics.KnownBoxes.VisibilityHiddenBox, global::System.Windows.Media.Animation.KeyTime.FromPercent(1.0));
			objectAnimationUsingKeyFrames.KeyFrames.Add(keyFrame);
			objectAnimationUsingKeyFrames.KeyFrames.Add(keyFrame2);
			global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(objectAnimationUsingKeyFrames, new global::System.Windows.PropertyPath(global::System.Windows.UIElement.VisibilityProperty));
			objectAnimationUsingKeyFrames.Duration = duration;
			sb.Children.Add(objectAnimationUsingKeyFrames);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000E4DC File Offset: 0x0000C6DC
		private void ClearPreviousAnimations()
		{
			global::Infragistics.Windows.Editors.CalendarItemArea oldArea = this.OldArea;
			global::Infragistics.Windows.Editors.CalendarItemArea currentArea = this.CurrentArea;
			global::Infragistics.Windows.Editors.CalendarItemAreaPanel.RemoveStoryboard(ref this._sbOldArea, oldArea);
			global::Infragistics.Windows.Editors.CalendarItemAreaPanel.RemoveStoryboard(ref this._sbNewArea, currentArea);
			oldArea.ClearValue(global::System.Windows.UIElement.RenderTransformProperty);
			currentArea.ClearValue(global::System.Windows.UIElement.RenderTransformProperty);
			oldArea.ClearValue(global::System.Windows.UIElement.OpacityProperty);
			currentArea.ClearValue(global::System.Windows.UIElement.OpacityProperty);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000E53C File Offset: 0x0000C73C
		private global::Infragistics.Windows.Editors.CalendarItemArea CreateItemArea(int index, global::Infragistics.Windows.Editors.CalendarMode? mode)
		{
			if (index >= this._areas.Count)
			{
				this._areas.AddRange(new global::Infragistics.Windows.Editors.CalendarItemArea[1 + index - this._areas.Count]);
			}
			if (this._areas[index] == null)
			{
				global::Infragistics.Windows.Editors.CalendarItemArea calendarItemArea = this._areas[index] = new global::Infragistics.Windows.Editors.CalendarItemArea();
				((global::System.ComponentModel.ISupportInitialize)calendarItemArea).BeginInit();
				if (mode != null)
				{
					global::Infragistics.Windows.Editors.CalendarItemGroup.SetCurrentCalendarMode(calendarItemArea, mode.Value);
				}
				calendarItemArea.InitializeGroup(this._group);
				base.AddVisualChild(calendarItemArea);
				base.AddLogicalChild(calendarItemArea);
				((global::System.ComponentModel.ISupportInitialize)calendarItemArea).EndInit();
				base.InvalidateMeasure();
			}
			return this._areas[index];
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
		private static global::System.Windows.Media.Animation.Storyboard CreateFadeStoryboard(global::System.Windows.Duration duration, bool isNew, global::Infragistics.Windows.Editors.CalendarItemArea area)
		{
			global::System.Windows.Media.Animation.Storyboard storyboard = new global::System.Windows.Media.Animation.Storyboard();
			storyboard.Duration = duration;
			storyboard.FillBehavior = global::System.Windows.Media.Animation.FillBehavior.Stop;
			global::Infragistics.Windows.Editors.CalendarItemAreaPanel.AddFadeAnimation(duration, isNew, storyboard);
			if (!isNew)
			{
				global::Infragistics.Windows.Editors.CalendarItemAreaPanel.AddVisibilityAnimation(storyboard, duration);
			}
			return storyboard;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000E61C File Offset: 0x0000C81C
		private static global::System.Windows.Media.Animation.Storyboard CreateScrollStoryboard(global::Infragistics.Windows.Editors.CalendarItemArea area, bool scrollLeft, bool isNew, double offset, global::System.Windows.Duration duration)
		{
			global::System.Windows.Media.TranslateTransform renderTransform = new global::System.Windows.Media.TranslateTransform();
			area.RenderTransform = renderTransform;
			global::System.Windows.Media.Animation.Storyboard storyboard = new global::System.Windows.Media.Animation.Storyboard();
			storyboard.FillBehavior = global::System.Windows.Media.Animation.FillBehavior.Stop;
			global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
			doubleAnimation.From = new double?(isNew ? (scrollLeft ? offset : (-offset)) : 0.0);
			doubleAnimation.To = new double?(isNew ? 0.0 : (scrollLeft ? (-offset) : offset));
			doubleAnimation.Duration = duration;
			global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath("(0).(1)", new object[]
			{
				global::System.Windows.UIElement.RenderTransformProperty,
				global::System.Windows.Media.TranslateTransform.XProperty
			}));
			storyboard.Children.Add(doubleAnimation);
			if (!isNew)
			{
				global::Infragistics.Windows.Editors.CalendarItemAreaPanel.AddVisibilityAnimation(storyboard, duration);
			}
			return storyboard;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
		private static global::System.Windows.Media.Animation.Storyboard CreateZoomStoryboard(global::Infragistics.Windows.Editors.CalendarItem referenceItem, bool zoomOut, global::System.Windows.Duration duration, bool isNew, global::Infragistics.Windows.Editors.CalendarItemArea area)
		{
			global::System.Windows.Media.Animation.Storyboard storyboard = new global::System.Windows.Media.Animation.Storyboard();
			storyboard.Duration = duration;
			storyboard.FillBehavior = global::System.Windows.Media.Animation.FillBehavior.Stop;
			if (referenceItem != null)
			{
				global::System.Windows.Media.TransformGroup transformGroup = new global::System.Windows.Media.TransformGroup();
				global::System.Windows.Media.ScaleTransform value = new global::System.Windows.Media.ScaleTransform();
				global::System.Windows.Media.TranslateTransform value2 = new global::System.Windows.Media.TranslateTransform();
				transformGroup.Children.Add(value);
				transformGroup.Children.Add(value2);
				area.RenderTransform = transformGroup;
				double num = referenceItem.ActualWidth / area.ActualWidth;
				double num2 = referenceItem.ActualHeight / area.ActualHeight;
				if (isNew == zoomOut)
				{
					num = 1.0 / num;
					num2 = 1.0 / num2;
				}
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(isNew ? num : 1.0, isNew ? 1.0 : num, duration);
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath("(0).(1)[0].(2)", new object[]
				{
					global::System.Windows.UIElement.RenderTransformProperty,
					global::System.Windows.Media.TransformGroup.ChildrenProperty,
					global::System.Windows.Media.ScaleTransform.ScaleXProperty
				}));
				storyboard.Children.Add(doubleAnimation);
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation2 = new global::System.Windows.Media.Animation.DoubleAnimation(isNew ? num2 : 1.0, isNew ? 1.0 : num2, duration);
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation2, new global::System.Windows.PropertyPath("(0).(1)[0].(2)", new object[]
				{
					global::System.Windows.UIElement.RenderTransformProperty,
					global::System.Windows.Media.TransformGroup.ChildrenProperty,
					global::System.Windows.Media.ScaleTransform.ScaleYProperty
				}));
				storyboard.Children.Add(doubleAnimation2);
				global::System.Windows.Point point = referenceItem.TransformToVisual(area).Transform(default(global::System.Windows.Point));
				if (isNew == zoomOut)
				{
					point.X *= -num;
					point.Y *= -num2;
				}
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation3 = new global::System.Windows.Media.Animation.DoubleAnimation(isNew ? point.X : 0.0, isNew ? 0.0 : point.X, duration);
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation3, new global::System.Windows.PropertyPath("(0).(1)[1].(2)", new object[]
				{
					global::System.Windows.UIElement.RenderTransformProperty,
					global::System.Windows.Media.TransformGroup.ChildrenProperty,
					global::System.Windows.Media.TranslateTransform.XProperty
				}));
				storyboard.Children.Add(doubleAnimation3);
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation4 = new global::System.Windows.Media.Animation.DoubleAnimation(isNew ? point.Y : 0.0, isNew ? 0.0 : point.Y, duration);
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation4, new global::System.Windows.PropertyPath("(0).(1)[1].(2)", new object[]
				{
					global::System.Windows.UIElement.RenderTransformProperty,
					global::System.Windows.Media.TransformGroup.ChildrenProperty,
					global::System.Windows.Media.TranslateTransform.YProperty
				}));
				storyboard.Children.Add(doubleAnimation4);
			}
			global::Infragistics.Windows.Editors.CalendarItemAreaPanel.AddFadeAnimation(duration, isNew, storyboard);
			if (!isNew)
			{
				global::Infragistics.Windows.Editors.CalendarItemAreaPanel.AddVisibilityAnimation(storyboard, duration);
			}
			return storyboard;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000E97F File Offset: 0x0000CB7F
		private bool HasItemArea(int index)
		{
			return index < this._areas.Count && this._areas[index] != null;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000E9A4 File Offset: 0x0000CBA4
		internal void InitializeGroup(global::Infragistics.Windows.Editors.CalendarItemGroup group)
		{
			if (this._group == group)
			{
				return;
			}
			if (this._group != null)
			{
				this._group.UnregisterItemArea(this);
			}
			this._group = group;
			if (this._group != null)
			{
				int i = 0;
				int count = this._areas.Count;
				while (i < count)
				{
					this._areas[i].InitializeGroup(group);
					i++;
				}
				if (group == base.TemplatedParent)
				{
					this._group.RegisterItemArea(this);
				}
				if (group.IsGroupForSizing)
				{
					this.InitializeSizingGroupPanel();
				}
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000EA2C File Offset: 0x0000CC2C
		private void InitializeSizingGroupPanel()
		{
			if (!base.IsInitialized)
			{
				return;
			}
			if (this._group != null && this._group.IsGroupForSizing)
			{
				int currentCalendarMode = (int)this._group.CurrentCalendarMode;
				int num = 4;
				this.CreateItemArea(0, null);
				int num2 = num - currentCalendarMode;
				for (int i = 1; i <= num2; i++)
				{
					global::Infragistics.Windows.Editors.CalendarMode calendarMode = (global::Infragistics.Windows.Editors.CalendarMode)(i + currentCalendarMode);
					global::Infragistics.Windows.Editors.CalendarItemArea d = this.CreateItemArea(i, new global::Infragistics.Windows.Editors.CalendarMode?(calendarMode));
					global::Infragistics.Windows.Editors.CalendarItemGroup.SetCurrentCalendarMode(d, calendarMode);
				}
				for (int j = this._areas.Count - 1; j > num2; j--)
				{
					global::Infragistics.Windows.Editors.CalendarItemArea child = this._areas[j];
					this._areas.RemoveAt(j);
					base.RemoveVisualChild(child);
					base.RemoveLogicalChild(child);
				}
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000EAF4 File Offset: 0x0000CCF4
		private static void OnCurrentCalendarModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemAreaPanel calendarItemAreaPanel = (global::Infragistics.Windows.Editors.CalendarItemAreaPanel)d;
			if (calendarItemAreaPanel._group != null && calendarItemAreaPanel._group.IsGroupForSizing)
			{
				calendarItemAreaPanel.InitializeSizingGroupPanel();
				return;
			}
			if (calendarItemAreaPanel._areas.Count > 1)
			{
				calendarItemAreaPanel.CurrentArea.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModePropertyKey, e.NewValue);
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000EB49 File Offset: 0x0000CD49
		private static void RemoveStoryboard(ref global::System.Windows.Media.Animation.Storyboard sb, global::Infragistics.Windows.Editors.CalendarItemArea area)
		{
			if (sb != null)
			{
				sb.Stop(area);
				sb.Remove(area);
				sb = null;
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000EB64 File Offset: 0x0000CD64
		void global::Infragistics.Windows.Editors.ICalendarItemArea.InitializeItems()
		{
			if (!base.IsInitialized)
			{
				return;
			}
			if (this.HasItemArea(this._areaIndex))
			{
				((global::Infragistics.Windows.Editors.ICalendarItemArea)this.CurrentArea).InitializeItems();
				return;
			}
			this.CreateItemArea(this._areaIndex, null);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000EBAA File Offset: 0x0000CDAA
		void global::Infragistics.Windows.Editors.ICalendarItemArea.InitializeWeekNumbers()
		{
			((global::Infragistics.Windows.Editors.ICalendarItemArea)this.CurrentArea).InitializeWeekNumbers();
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000EBB7 File Offset: 0x0000CDB7
		void global::Infragistics.Windows.Editors.ICalendarItemArea.InitializeFirstItemOffset()
		{
			((global::Infragistics.Windows.Editors.ICalendarItemArea)this.CurrentArea).InitializeFirstItemOffset();
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
		void global::Infragistics.Windows.Editors.ICalendarItemArea.InitializeRowColCount()
		{
			foreach (global::Infragistics.Windows.Editors.ICalendarItemArea calendarItemArea in this._areas)
			{
				if (calendarItemArea != null)
				{
					calendarItemArea.InitializeRowColCount();
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0000EC1C File Offset: 0x0000CE1C
		global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItem> global::Infragistics.Windows.Editors.ICalendarItemArea.Items
		{
			get
			{
				return ((global::Infragistics.Windows.Editors.ICalendarItemArea)this.CurrentArea).Items;
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000EC29 File Offset: 0x0000CE29
		void global::Infragistics.Windows.Editors.ICalendarItemArea.ReinitializeItems(global::Infragistics.Windows.Editors.CalendarItemChange change)
		{
			((global::Infragistics.Windows.Editors.ICalendarItemArea)this.CurrentArea).ReinitializeItems(change);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000EC38 File Offset: 0x0000CE38
		void global::Infragistics.Windows.Editors.ICalendarItemArea.PrepareForAnimationAction(global::Infragistics.Windows.Editors.CalendarAnimation action)
		{
			if (this._pendingAnimation == null)
			{
				this.ClearPreviousAnimations();
				this._areaIndex = ((this._areaIndex == 0) ? 1 : 0);
				this.CreateItemArea(this._areaIndex, null);
				this._pendingAnimation = new global::Infragistics.Windows.Editors.CalendarAnimation?(action);
				this.OldArea.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModePropertyKey, global::Infragistics.Windows.Editors.CalendarItemGroup.GetCurrentCalendarMode(this));
				this.CurrentArea.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModePropertyKey, global::Infragistics.Windows.Editors.CalendarItemGroup.GetCurrentCalendarMode(this));
				this.CurrentArea.Visibility = global::System.Windows.Visibility.Hidden;
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		void global::Infragistics.Windows.Editors.ICalendarItemArea.PerformAnimationAction(global::Infragistics.Windows.Editors.CalendarAnimation action)
		{
			if (action == this._pendingAnimation)
			{
				this._pendingAnimation = null;
				((global::Infragistics.Windows.Editors.ICalendarItemArea)this).InitializeItems();
				global::Infragistics.Windows.Editors.CalendarItemArea oldArea = this.OldArea;
				global::Infragistics.Windows.Editors.CalendarItemArea currentArea = this.CurrentArea;
				global::Infragistics.Windows.Editors.CalendarDateRange? groupRange = oldArea.GroupRange;
				global::Infragistics.Windows.Editors.CalendarDateRange? groupRange2 = currentArea.GroupRange;
				global::System.Windows.Media.Animation.Storyboard storyboard = null;
				global::System.Windows.Media.Animation.Storyboard storyboard2 = null;
				global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(this);
				bool flag = false;
				if (groupRange != null && groupRange2 != null && base.IsVisible)
				{
					if (groupRange != groupRange2)
					{
						flag = true;
					}
					else if (oldArea.CurrentCalendarMode != currentArea.CurrentCalendarMode && (oldArea.FirstItemColumnOffset != currentArea.FirstItemColumnOffset || oldArea.FirstItemRowOffset != currentArea.FirstItemRowOffset || oldArea.ItemRows != currentArea.ItemRows || oldArea.ItemColumns != currentArea.ItemColumns || oldArea.Items.Count != currentArea.Items.Count))
					{
						flag = true;
					}
				}
				if (flag)
				{
					global::System.Windows.Duration duration = new global::System.Windows.Duration(new global::System.TimeSpan(3333333L));
					switch (action)
					{
					case global::Infragistics.Windows.Editors.CalendarAnimation.Fade:
						storyboard = global::Infragistics.Windows.Editors.CalendarItemAreaPanel.CreateFadeStoryboard(duration, false, oldArea);
						storyboard2 = global::Infragistics.Windows.Editors.CalendarItemAreaPanel.CreateFadeStoryboard(duration, true, currentArea);
						break;
					case global::Infragistics.Windows.Editors.CalendarAnimation.Scroll:
					{
						bool scrollLeft = groupRange.Value.End < groupRange2.Value.Start;
						double actualWidth = base.ActualWidth;
						storyboard = global::Infragistics.Windows.Editors.CalendarItemAreaPanel.CreateScrollStoryboard(oldArea, scrollLeft, false, actualWidth, duration);
						storyboard2 = global::Infragistics.Windows.Editors.CalendarItemAreaPanel.CreateScrollStoryboard(currentArea, scrollLeft, true, actualWidth, duration);
						break;
					}
					case global::Infragistics.Windows.Editors.CalendarAnimation.ZoomIn:
					case global::Infragistics.Windows.Editors.CalendarAnimation.ZoomOut:
					{
						base.UpdateLayout();
						global::Infragistics.Windows.Editors.CalendarItem calendarItem = null;
						bool flag2 = action == global::Infragistics.Windows.Editors.CalendarAnimation.ZoomOut;
						if (groupRange2 == groupRange)
						{
							if (flag2)
							{
								calendarItem = currentArea.GetItem(groupRange.Value.Start);
							}
							else
							{
								calendarItem = oldArea.GetItem(groupRange2.Value.Start);
							}
						}
						else if (groupRange2.Value.Contains(groupRange.Value) || flag2)
						{
							calendarItem = currentArea.GetItem(groupRange.Value.Start);
						}
						else if (groupRange.Value.Contains(groupRange2.Value) || !flag2)
						{
							calendarItem = oldArea.GetItem(groupRange2.Value.Start);
						}
						if (calendarItem == null && monthCalendar != null)
						{
							global::System.DateTime date = flag2 ? groupRange.Value.Start : groupRange2.Value.Start;
							foreach (global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup in monthCalendar.GetGroups())
							{
								global::Infragistics.Windows.Editors.CalendarItemAreaPanel calendarItemAreaPanel = calendarItemGroup.ItemArea as global::Infragistics.Windows.Editors.CalendarItemAreaPanel;
								if (calendarItemAreaPanel != null && this != calendarItemAreaPanel)
								{
									global::Infragistics.Windows.Editors.CalendarItemArea calendarItemArea = flag2 ? calendarItemAreaPanel.CurrentArea : calendarItemAreaPanel.OldArea;
									calendarItem = calendarItemArea.GetItem(date);
									if (calendarItem != null)
									{
										break;
									}
								}
							}
						}
						storyboard = global::Infragistics.Windows.Editors.CalendarItemAreaPanel.CreateZoomStoryboard(calendarItem, flag2, duration, false, oldArea);
						storyboard2 = global::Infragistics.Windows.Editors.CalendarItemAreaPanel.CreateZoomStoryboard(calendarItem, flag2, duration, true, currentArea);
						break;
					}
					}
				}
				if (monthCalendar != null && (base.IsKeyboardFocusWithin || monthCalendar.IsKeyboardFocused))
				{
					monthCalendar.FocusActiveItemWithDelay();
				}
				oldArea.Visibility = global::System.Windows.Visibility.Hidden;
				currentArea.Visibility = global::System.Windows.Visibility.Visible;
				this._sbOldArea = storyboard;
				this._sbNewArea = storyboard2;
				if (storyboard != null)
				{
					storyboard.Begin(oldArea, global::System.Windows.Media.Animation.HandoffBehavior.Compose, true);
				}
				if (storyboard2 != null)
				{
					storyboard2.Begin(currentArea, global::System.Windows.Media.Animation.HandoffBehavior.Compose, true);
				}
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000F0BC File Offset: 0x0000D2BC
		global::Infragistics.Windows.Editors.CalendarItem global::Infragistics.Windows.Editors.ICalendarItemArea.GetItem(global::System.DateTime date)
		{
			return ((global::Infragistics.Windows.Editors.ICalendarItemArea)this.CurrentArea).GetItem(date);
		}

		// Token: 0x0400014C RID: 332
		private global::Infragistics.Windows.Editors.CalendarItemGroup _group;

		// Token: 0x0400014D RID: 333
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Editors.CalendarItemArea> _areas = new global::System.Collections.Generic.List<global::Infragistics.Windows.Editors.CalendarItemArea>();

		// Token: 0x0400014E RID: 334
		private int _areaIndex;

		// Token: 0x0400014F RID: 335
		private global::Infragistics.Windows.Editors.CalendarAnimation? _pendingAnimation;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Media.Animation.Storyboard _sbOldArea;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Media.Animation.Storyboard _sbNewArea;
	}
}
