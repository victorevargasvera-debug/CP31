using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200001D RID: 29
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CalendarItemAreaPanel : global::System.Windows.Controls.Panel, global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea, global::Infragistics.Controls.Editors.Primitives.ICalendarElement
	{
		// Token: 0x0600013D RID: 317 RVA: 0x0000736C File Offset: 0x0000556C
		public CalendarItemAreaPanel()
		{
			base.Loaded += this.OnLoaded;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00007394 File Offset: 0x00005594
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(default(global::System.Windows.Point), finalSize);
			for (int i = 0; i < this._areas.Count; i++)
			{
				this._areas[i].Arrange(finalRect);
			}
			base.Clip = new global::System.Windows.Media.RectangleGeometry
			{
				Rect = new global::System.Windows.Rect(default(global::System.Windows.Point), finalSize)
			};
			return finalSize;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00007400 File Offset: 0x00005600
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (!this._isInitialized)
			{
				this._isInitialized = true;
				((global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea)this).InitializeItems();
				this.InitializeSizingGroupPanel();
			}
			global::System.Windows.Size result = default(global::System.Windows.Size);
			bool flag;
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this, out flag);
			int i = 0;
			int count = this._areas.Count;
			while (i < count)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemArea calendarItemArea = this._areas[i];
				if (flag)
				{
					global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(calendarItemArea, calendar);
					calendarItemArea.InvalidateMeasure();
				}
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

		// Token: 0x06000140 RID: 320 RVA: 0x000074C4 File Offset: 0x000056C4
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = base.TemplatedParent as global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup;
			if (calendarItemGroup != null)
			{
				this.InitializeGroup(calendarItemGroup);
			}
			base.OnVisualParentChanged(oldParent);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000074F0 File Offset: 0x000056F0
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemArea CurrentArea
		{
			get
			{
				return this.CreateItemArea(this._areaIndex, null);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00007514 File Offset: 0x00005714
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemArea OldArea
		{
			get
			{
				int index = (this._areaIndex == 0) ? 1 : 0;
				return this.CreateItemArea(index, null);
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00007540 File Offset: 0x00005740
		internal bool LoadItemsLazily(bool loadDays)
		{
			if (this._group == null || this._group.IsGroupForSizing)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
			if (calendar == null)
			{
				return false;
			}
			int num = (this._areaIndex == 0) ? 1 : 0;
			if (num >= this._areas.Count)
			{
				this._areas.AddRange(new global::Infragistics.Controls.Editors.Primitives.CalendarItemArea[1 + num - this._areas.Count]);
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarItemArea calendarItemArea = this._areas[num];
			bool flag = false;
			if (calendarItemArea == null)
			{
				calendarItemArea = (this._areas[num] = new global::Infragistics.Controls.Editors.Primitives.CalendarItemArea());
				((global::System.ComponentModel.ISupportInitialize)calendarItemArea).BeginInit();
				global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(calendarItemArea, calendar);
				calendarItemArea.InitializeGroup(this._group);
				base.Children.Add(calendarItemArea);
				((global::System.ComponentModel.ISupportInitialize)calendarItemArea).EndInit();
				calendarItemArea.ApplyTemplate();
				flag = true;
			}
			bool result = calendarItemArea.LoadItemsLazily(loadDays);
			if (!loadDays && this.CurrentArea.LoadItemsLazily(false))
			{
				result = true;
			}
			if (flag)
			{
				calendarItemArea.Opacity = 0.0;
				calendarItemArea.IsHitTestVisible = false;
			}
			return result;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00007640 File Offset: 0x00005840
		private static void AddFadeAnimation(global::System.Windows.Duration duration, bool isNew, global::System.Windows.Media.Animation.Storyboard sb)
		{
			global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
			doubleAnimation.SetValue(isNew ? global::System.Windows.Media.Animation.DoubleAnimation.ToProperty : global::System.Windows.Media.Animation.DoubleAnimation.FromProperty, 1.0);
			doubleAnimation.SetValue(isNew ? global::System.Windows.Media.Animation.DoubleAnimation.FromProperty : global::System.Windows.Media.Animation.DoubleAnimation.ToProperty, 0.0);
			doubleAnimation.Duration = duration;
			global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath(global::System.Windows.UIElement.OpacityProperty));
			sb.Children.Add(doubleAnimation);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000076BC File Offset: 0x000058BC
		private static void AddOpacityAnimation(global::System.Windows.Media.Animation.Storyboard sb, global::System.Windows.Duration duration)
		{
			global::System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames objectAnimationUsingKeyFrames = new global::System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames();
			global::System.Windows.Media.Animation.DiscreteObjectKeyFrame discreteObjectKeyFrame = new global::System.Windows.Media.Animation.DiscreteObjectKeyFrame();
			discreteObjectKeyFrame.Value = 1.0;
			discreteObjectKeyFrame.KeyTime = global::System.Windows.Media.Animation.KeyTime.FromTimeSpan(global::System.TimeSpan.FromMilliseconds(0.0));
			global::System.Windows.Media.Animation.DiscreteObjectKeyFrame discreteObjectKeyFrame2 = new global::System.Windows.Media.Animation.DiscreteObjectKeyFrame();
			discreteObjectKeyFrame2.Value = 0.0;
			discreteObjectKeyFrame2.KeyTime = global::System.Windows.Media.Animation.KeyTime.FromTimeSpan(duration.TimeSpan);
			objectAnimationUsingKeyFrames.KeyFrames.Add(discreteObjectKeyFrame);
			objectAnimationUsingKeyFrames.KeyFrames.Add(discreteObjectKeyFrame2);
			global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(objectAnimationUsingKeyFrames, new global::System.Windows.PropertyPath(global::System.Windows.UIElement.OpacityProperty));
			objectAnimationUsingKeyFrames.Duration = duration;
			sb.Children.Add(objectAnimationUsingKeyFrames);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000776C File Offset: 0x0000596C
		private void ClearPreviousAnimations()
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemArea oldArea = this.OldArea;
			global::Infragistics.Controls.Editors.Primitives.CalendarItemArea currentArea = this.CurrentArea;
			global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel.RemoveStoryboard(ref this._sbOldArea, oldArea);
			global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel.RemoveStoryboard(ref this._sbNewArea, currentArea);
			oldArea.ClearValue(global::System.Windows.UIElement.RenderTransformProperty);
			currentArea.ClearValue(global::System.Windows.UIElement.RenderTransformProperty);
			oldArea.ClearValue(global::System.Windows.UIElement.OpacityProperty);
			currentArea.ClearValue(global::System.Windows.UIElement.OpacityProperty);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000077CC File Offset: 0x000059CC
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemArea CreateItemArea(int index, global::Infragistics.Controls.Editors.CalendarZoomMode? mode)
		{
			if (index >= this._areas.Count)
			{
				this._areas.AddRange(new global::Infragistics.Controls.Editors.Primitives.CalendarItemArea[1 + index - this._areas.Count]);
			}
			if (this._areas[index] == null)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemArea calendarItemArea = this._areas[index] = new global::Infragistics.Controls.Editors.Primitives.CalendarItemArea();
				((global::System.ComponentModel.ISupportInitialize)calendarItemArea).BeginInit();
				global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
				if (calendar != null)
				{
					global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(calendarItemArea, calendar);
				}
				if (mode != null)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.SetCurrentMode(calendarItemArea, mode.Value);
				}
				else if (index == 0)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.SetCurrentMode(calendarItemArea, global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GetCurrentMode(this));
				}
				calendarItemArea.InitializeGroup(this._group);
				base.Children.Add(calendarItemArea);
				((global::System.ComponentModel.ISupportInitialize)calendarItemArea).EndInit();
				base.InvalidateMeasure();
			}
			return this._areas[index];
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00007898 File Offset: 0x00005A98
		private static global::System.Windows.Media.Animation.Storyboard CreateFadeStoryboard(global::System.Windows.Duration duration, bool isNew, global::Infragistics.Controls.Editors.Primitives.CalendarItemArea area)
		{
			global::System.Windows.Media.Animation.Storyboard storyboard = new global::System.Windows.Media.Animation.Storyboard();
			storyboard.Duration = duration;
			storyboard.FillBehavior = global::System.Windows.Media.Animation.FillBehavior.Stop;
			global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel.AddFadeAnimation(duration, isNew, storyboard);
			return storyboard;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000078C4 File Offset: 0x00005AC4
		private static global::System.Windows.Media.Animation.Storyboard CreateScrollStoryboard(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea area, bool scrollLeft, bool isNew, double offset, global::System.Windows.Duration duration)
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
				global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel.AddOpacityAnimation(storyboard, duration);
			}
			return storyboard;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000797C File Offset: 0x00005B7C
		private static global::System.Windows.Media.Animation.Storyboard CreateZoomStoryboard(global::Infragistics.Controls.Editors.Primitives.CalendarItem referenceItem, bool zoomOut, global::System.Windows.Duration duration, bool isNew, global::Infragistics.Controls.Editors.Primitives.CalendarItemArea area)
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
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
				doubleAnimation.From = new double?(isNew ? num : 1.0);
				doubleAnimation.To = new double?(isNew ? 1.0 : num);
				doubleAnimation.Duration = duration;
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath("(0).(1)[0].(2)", new object[]
				{
					global::System.Windows.UIElement.RenderTransformProperty,
					global::System.Windows.Media.TransformGroup.ChildrenProperty,
					global::System.Windows.Media.ScaleTransform.ScaleXProperty
				}));
				storyboard.Children.Add(doubleAnimation);
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation2 = new global::System.Windows.Media.Animation.DoubleAnimation();
				doubleAnimation2.From = new double?(isNew ? num2 : 1.0);
				doubleAnimation2.To = new double?(isNew ? 1.0 : num2);
				doubleAnimation2.Duration = duration;
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
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation3 = new global::System.Windows.Media.Animation.DoubleAnimation();
				doubleAnimation3.From = new double?(isNew ? point.X : 0.0);
				doubleAnimation3.To = new double?(isNew ? 0.0 : point.X);
				doubleAnimation3.Duration = duration;
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation3, new global::System.Windows.PropertyPath("(0).(1)[1].(2)", new object[]
				{
					global::System.Windows.UIElement.RenderTransformProperty,
					global::System.Windows.Media.TransformGroup.ChildrenProperty,
					global::System.Windows.Media.TranslateTransform.XProperty
				}));
				storyboard.Children.Add(doubleAnimation3);
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation4 = new global::System.Windows.Media.Animation.DoubleAnimation();
				doubleAnimation4.From = new double?(isNew ? point.Y : 0.0);
				doubleAnimation4.To = new double?(isNew ? 0.0 : point.Y);
				doubleAnimation4.Duration = duration;
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation4, new global::System.Windows.PropertyPath("(0).(1)[1].(2)", new object[]
				{
					global::System.Windows.UIElement.RenderTransformProperty,
					global::System.Windows.Media.TransformGroup.ChildrenProperty,
					global::System.Windows.Media.TranslateTransform.YProperty
				}));
				storyboard.Children.Add(doubleAnimation4);
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel.AddFadeAnimation(duration, isNew, storyboard);
			return storyboard;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00007C99 File Offset: 0x00005E99
		private bool HasItemArea(int index)
		{
			return index < this._areas.Count && this._areas[index] != null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00007CC0 File Offset: 0x00005EC0
		internal void InitializeGroup(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group)
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
				if (group == global::Infragistics.Controls.PresentationUtilities.GetTemplatedParent(this))
				{
					this._group.RegisterItemArea(this);
				}
				if (group.IsGroupForSizing)
				{
					this.InitializeSizingGroupPanel();
				}
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00007D48 File Offset: 0x00005F48
		private void InitializeSizingGroupPanel()
		{
			if (!this._isInitialized)
			{
				return;
			}
			if (this._group != null && this._group.IsGroupForSizing)
			{
				int currentMode = (int)this._group.CurrentMode;
				int num = 4;
				this.CreateItemArea(0, null);
				int num2 = num - currentMode;
				for (int i = 1; i <= num2; i++)
				{
					global::Infragistics.Controls.Editors.CalendarZoomMode value = (global::Infragistics.Controls.Editors.CalendarZoomMode)(i + currentMode);
					global::Infragistics.Controls.Editors.Primitives.CalendarItemArea target = this.CreateItemArea(i, new global::Infragistics.Controls.Editors.CalendarZoomMode?(value));
					global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.SetCurrentMode(target, value);
				}
				for (int j = this._areas.Count - 1; j > num2; j--)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItemArea element = this._areas[j];
					this._areas.RemoveAt(j);
					base.Children.Remove(element);
				}
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00007E10 File Offset: 0x00006010
		internal void OnCurrentModeChanged(global::Infragistics.Controls.Editors.CalendarZoomMode newMode, global::Infragistics.Controls.Editors.CalendarZoomMode oldMode)
		{
			if (this._group != null && this._group.IsGroupForSizing)
			{
				this.InitializeSizingGroupPanel();
				return;
			}
			if (this._areas.Count > 1 || (this._group != null && !this._group.IsGroupForSizing && !this._group.AllowAnimation))
			{
				this.CurrentArea.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.CurrentModePropertyKey, newMode);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00007E7F File Offset: 0x0000607F
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OnLoaded;
			if (this._group != null)
			{
				if (this._group.IsGroupForSizing)
				{
					this.InitializeSizingGroupPanel();
					return;
				}
				((global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea)this).InitializeItems();
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00007EB5 File Offset: 0x000060B5
		private static void RemoveStoryboard(ref global::System.Windows.Media.Animation.Storyboard sb, global::Infragistics.Controls.Editors.Primitives.CalendarItemArea area)
		{
			if (sb != null)
			{
				sb.Stop(area);
				sb.Remove(area);
				sb = null;
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00007ED0 File Offset: 0x000060D0
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.InitializeItems()
		{
			if (!this._isInitialized)
			{
				return;
			}
			if (this.HasItemArea(this._areaIndex))
			{
				((global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea)this.CurrentArea).InitializeItems();
				return;
			}
			this.CreateItemArea(this._areaIndex, null);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00007F18 File Offset: 0x00006118
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.InitializeWeekNumbers()
		{
			foreach (global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea calendarItemArea in this._areas)
			{
				if (calendarItemArea != null)
				{
					calendarItemArea.InitializeWeekNumbers();
				}
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00007F70 File Offset: 0x00006170
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.InitializeDaysOfWeek()
		{
			foreach (global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea calendarItemArea in this._areas)
			{
				if (calendarItemArea != null)
				{
					calendarItemArea.InitializeDaysOfWeek();
				}
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00007FC8 File Offset: 0x000061C8
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.InitializeFirstItemOffset()
		{
			((global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea)this.CurrentArea).InitializeFirstItemOffset();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00007FD8 File Offset: 0x000061D8
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.InitializeRowColCount()
		{
			foreach (global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea calendarItemArea in this._areas)
			{
				if (calendarItemArea != null)
				{
					calendarItemArea.InitializeRowColCount();
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00008030 File Offset: 0x00006230
		global::System.Collections.Generic.IList<global::Infragistics.Controls.Editors.Primitives.CalendarItem> global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.Items
		{
			get
			{
				return ((global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea)this.CurrentArea).Items;
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00008040 File Offset: 0x00006240
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.ReinitializeItems(global::Infragistics.Controls.Editors.CalendarItemChange change)
		{
			if (change == global::Infragistics.Controls.Editors.CalendarItemChange.Resources)
			{
				using (global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.CalendarItemArea>.Enumerator enumerator = this._areas.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Infragistics.Controls.Editors.Primitives.CalendarItemArea calendarItemArea = enumerator.Current;
						((global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea)calendarItemArea).ReinitializeItems(change);
					}
					return;
				}
			}
			((global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea)this.CurrentArea).ReinitializeItems(change);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000080A8 File Offset: 0x000062A8
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.PrepareForAnimationAction(global::Infragistics.Controls.Editors.CalendarAnimation action)
		{
			if (this._pendingAnimation == null)
			{
				this.ClearPreviousAnimations();
				this._areaIndex = ((this._areaIndex == 0) ? 1 : 0);
				this.CreateItemArea(this._areaIndex, null);
				this._pendingAnimation = new global::Infragistics.Controls.Editors.CalendarAnimation?(action);
				this.OldArea.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.CurrentModePropertyKey, global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GetCurrentMode(this));
				this.CurrentArea.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.CurrentModePropertyKey, global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GetCurrentMode(this));
				this.CurrentArea.Opacity = 0.0;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000814C File Offset: 0x0000634C
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.PerformAnimationAction(global::Infragistics.Controls.Editors.CalendarAnimation action)
		{
			if (action == this._pendingAnimation)
			{
				this._pendingAnimation = null;
				((global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea)this).InitializeItems();
				global::Infragistics.Controls.Editors.Primitives.CalendarItemArea oldArea = this.OldArea;
				global::Infragistics.Controls.Editors.Primitives.CalendarItemArea currentArea = this.CurrentArea;
				global::Infragistics.DateRange? dateRange = oldArea.GroupRange;
				global::Infragistics.DateRange? dateRange2 = currentArea.GroupRange;
				if (dateRange2 == null)
				{
					currentArea.VerifyItemsInitialized();
					dateRange2 = currentArea.GroupRange;
				}
				global::System.Windows.Media.Animation.Storyboard storyboard = null;
				global::System.Windows.Media.Animation.Storyboard storyboard2 = null;
				global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
				bool flag = false;
				if (dateRange != null && dateRange2 != null)
				{
					if (dateRange != dateRange2)
					{
						flag = true;
					}
					else if (oldArea.CurrentMode != currentArea.CurrentMode && (oldArea.FirstItemColumnOffset != currentArea.FirstItemColumnOffset || oldArea.FirstItemRowOffset != currentArea.FirstItemRowOffset || oldArea.ItemRows != currentArea.ItemRows || oldArea.ItemColumns != currentArea.ItemColumns || oldArea.Items.Count != currentArea.Items.Count))
					{
						flag = true;
					}
				}
				else if (dateRange2 != null || dateRange != null)
				{
					flag = true;
					if (action == global::Infragistics.Controls.Editors.CalendarAnimation.Scroll)
					{
						action = global::Infragistics.Controls.Editors.CalendarAnimation.Fade;
					}
					else if (action != global::Infragistics.Controls.Editors.CalendarAnimation.Fade)
					{
						if (dateRange == null)
						{
							dateRange = dateRange2;
						}
						else
						{
							dateRange2 = dateRange;
						}
					}
				}
				if (!base.IsVisible)
				{
					flag = false;
				}
				if (flag && !calendar.DisableAnimations)
				{
					global::System.Windows.Duration duration = new global::System.Windows.Duration(new global::System.TimeSpan(3333333L));
					switch (action)
					{
					case global::Infragistics.Controls.Editors.CalendarAnimation.Fade:
						storyboard = global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel.CreateFadeStoryboard(duration, false, oldArea);
						storyboard2 = global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel.CreateFadeStoryboard(duration, true, currentArea);
						break;
					case global::Infragistics.Controls.Editors.CalendarAnimation.Scroll:
					{
						base.UpdateLayout();
						bool scrollLeft = dateRange.Value.End < dateRange2.Value.Start;
						double actualWidth = base.ActualWidth;
						storyboard = global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel.CreateScrollStoryboard(oldArea, scrollLeft, false, actualWidth, duration);
						storyboard2 = global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel.CreateScrollStoryboard(currentArea, scrollLeft, true, actualWidth, duration);
						if (calendar != null)
						{
							calendar.VerifySelectedDayStatesAsync();
						}
						break;
					}
					case global::Infragistics.Controls.Editors.CalendarAnimation.ZoomIn:
					case global::Infragistics.Controls.Editors.CalendarAnimation.ZoomOut:
					{
						base.UpdateLayout();
						global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = null;
						bool flag2 = action == global::Infragistics.Controls.Editors.CalendarAnimation.ZoomOut;
						if (dateRange2 == dateRange)
						{
							if (flag2)
							{
								calendarItem = currentArea.GetItem(dateRange.Value.Start);
							}
							else
							{
								calendarItem = oldArea.GetItem(dateRange2.Value.Start);
							}
						}
						else if (dateRange != null && dateRange2 != null)
						{
							if (dateRange2.Value.Contains(dateRange.Value) || flag2)
							{
								calendarItem = currentArea.GetItem(dateRange.Value.Start);
							}
							else if (dateRange.Value.Contains(dateRange2.Value) || !flag2)
							{
								calendarItem = oldArea.GetItem(dateRange2.Value.Start);
							}
						}
						if (calendarItem == null && calendar != null)
						{
							global::System.DateTime date = flag2 ? dateRange.Value.Start : dateRange2.Value.Start;
							foreach (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup in calendar.GetGroups())
							{
								global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel calendarItemAreaPanel = calendarItemGroup.ItemArea as global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel;
								if (calendarItemAreaPanel != null && this != calendarItemAreaPanel)
								{
									global::Infragistics.Controls.Editors.Primitives.CalendarItemArea calendarItemArea = flag2 ? calendarItemAreaPanel.CurrentArea : calendarItemAreaPanel.OldArea;
									calendarItem = calendarItemArea.GetItem(date);
									if (calendarItem != null)
									{
										break;
									}
								}
							}
						}
						storyboard = global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel.CreateZoomStoryboard(calendarItem, flag2, duration, false, oldArea);
						storyboard2 = global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel.CreateZoomStoryboard(calendarItem, flag2, duration, true, currentArea);
						break;
					}
					}
				}
				if (calendar != null && (base.IsKeyboardFocusWithin || calendar.IsKeyboardFocused))
				{
					calendar.FocusActiveItemWithDelay();
				}
				oldArea.Opacity = 0.0;
				oldArea.IsHitTestVisible = false;
				currentArea.Opacity = 1.0;
				currentArea.ClearValue(global::System.Windows.UIElement.IsHitTestVisibleProperty);
				this._sbOldArea = storyboard;
				this._sbNewArea = storyboard2;
				if (storyboard != null)
				{
					global::System.Windows.Media.Animation.Storyboard.SetTarget(storyboard, oldArea);
				}
				if (storyboard2 != null)
				{
					global::System.Windows.Media.Animation.Storyboard.SetTarget(storyboard2, currentArea);
				}
				if (this._group != null)
				{
					this._group.ClearQueuedAnimations();
					this._group.EnqueueAnimation(storyboard, oldArea, true);
					this._group.EnqueueAnimation(storyboard2, currentArea, false);
					return;
				}
				if (storyboard != null)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.BeginStoryboard(storyboard, oldArea, true);
				}
				if (storyboard2 != null)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.BeginStoryboard(storyboard2, currentArea, false);
				}
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000861C File Offset: 0x0000681C
		global::Infragistics.Controls.Editors.Primitives.CalendarItem global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.GetItem(global::System.DateTime date)
		{
			return ((global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea)this.CurrentArea).GetItem(date);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000862A File Offset: 0x0000682A
		global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.GetWeekNumber(int weekNumber)
		{
			return ((global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea)this.CurrentArea).GetWeekNumber(weekNumber);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00008638 File Offset: 0x00006838
		void global::Infragistics.Controls.Editors.Primitives.ICalendarElement.OnCalendarChanged(global::Infragistics.Controls.Editors.CalendarBase newValue, global::Infragistics.Controls.Editors.CalendarBase oldValue)
		{
			foreach (global::Infragistics.Controls.Editors.Primitives.CalendarItemArea d in this._areas)
			{
				global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(d, newValue);
			}
		}

		// Token: 0x04000077 RID: 119
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup _group;

		// Token: 0x04000078 RID: 120
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.CalendarItemArea> _areas = new global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.CalendarItemArea>();

		// Token: 0x04000079 RID: 121
		private int _areaIndex;

		// Token: 0x0400007A RID: 122
		private global::Infragistics.Controls.Editors.CalendarAnimation? _pendingAnimation;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Media.Animation.Storyboard _sbOldArea;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Media.Animation.Storyboard _sbNewArea;

		// Token: 0x0400007D RID: 125
		private bool _isInitialized;
	}
}
