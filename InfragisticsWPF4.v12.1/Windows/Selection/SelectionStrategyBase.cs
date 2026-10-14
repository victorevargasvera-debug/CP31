using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Selection
{
	// Token: 0x02000279 RID: 633
	public abstract class SelectionStrategyBase
	{
		// Token: 0x06001903 RID: 6403 RVA: 0x0005FACE File Offset: 0x0005DCCE
		protected SelectionStrategyBase(global::Infragistics.Windows.Selection.ISelectionHost selectionHost)
		{
			if (selectionHost == null)
			{
				throw new global::System.ArgumentNullException("selectionHost", global::SR.GetString("LE_ArgumentNullException_2"));
			}
			this._selectionHost = selectionHost;
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x0005FAF5 File Offset: 0x0005DCF5
		public virtual bool IsMultiSelect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x0005FAF8 File Offset: 0x0005DCF8
		public virtual bool IsSingleSelect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x0005FAFB File Offset: 0x0005DCFB
		public bool IsReleasingMouseCapture
		{
			get
			{
				return this._isReleasingMouseCapture;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x0005FB03 File Offset: 0x0005DD03
		protected virtual int AutoScrollHorizontalIntervalMax
		{
			get
			{
				return 300;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0005FB0A File Offset: 0x0005DD0A
		protected virtual int AutoScrollHorizontalIntervalMin
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x0005FB0E File Offset: 0x0005DD0E
		protected virtual int AutoScrollVerticalIntervalMax
		{
			get
			{
				return 300;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x0005FB15 File Offset: 0x0005DD15
		protected virtual int AutoScrollVerticalIntervalMin
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x0005FB19 File Offset: 0x0005DD19
		protected virtual global::System.Windows.Threading.DispatcherPriority AutoScrollTimerDispatcherPriority
		{
			get
			{
				return global::System.Windows.Threading.DispatcherPriority.Input;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x0005FB1C File Offset: 0x0005DD1C
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x0005FB38 File Offset: 0x0005DD38
		protected global::Infragistics.Windows.Selection.ISelectableItem CurrentSelectableItem
		{
			get
			{
				if (this._currentSelectableItemRef == null)
				{
					return null;
				}
				return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._currentSelectableItemRef) as global::Infragistics.Windows.Selection.ISelectableItem;
			}
			set
			{
				if (value == null)
				{
					this._currentSelectableItemRef = null;
					return;
				}
				this._currentSelectableItemRef = new global::System.WeakReference(value);
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x0005FB51 File Offset: 0x0005DD51
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x0005FB59 File Offset: 0x0005DD59
		protected global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState CurrentSelectionState
		{
			get
			{
				return this._currentSelectionState;
			}
			set
			{
				this._currentSelectionState = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x0005FB62 File Offset: 0x0005DD62
		protected virtual int DragThreshold
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x0005FB65 File Offset: 0x0005DD65
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x0005FB6D File Offset: 0x0005DD6D
		protected internal bool IgnoreNextMouseMove
		{
			get
			{
				return this._ignoreNextMouseMove;
			}
			set
			{
				this._ignoreNextMouseMove = value;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x0005FB76 File Offset: 0x0005DD76
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x0005FB7E File Offset: 0x0005DD7E
		protected bool InDragMode
		{
			get
			{
				return this._inDragMode;
			}
			set
			{
				this._inDragMode = value;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0005FB87 File Offset: 0x0005DD87
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x0005FB8F File Offset: 0x0005DD8F
		protected double InitialXPos
		{
			get
			{
				return this._initialXPos;
			}
			set
			{
				this._initialXPos = value;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x0005FB98 File Offset: 0x0005DD98
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x0005FBA0 File Offset: 0x0005DDA0
		protected double InitialYPos
		{
			get
			{
				return this._initialYPos;
			}
			set
			{
				this._initialYPos = value;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x0005FBA9 File Offset: 0x0005DDA9
		protected bool IsAnyMouseButtonDown
		{
			get
			{
				return global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed || global::System.Windows.Input.Mouse.MiddleButton == global::System.Windows.Input.MouseButtonState.Pressed || global::System.Windows.Input.Mouse.RightButton == global::System.Windows.Input.MouseButtonState.Pressed;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0005FBC5 File Offset: 0x0005DDC5
		protected bool IsCtrlKeyPressed
		{
			get
			{
				return global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl) || global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl);
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x0005FBD9 File Offset: 0x0005DDD9
		protected bool IsLeftMouseButtonDown
		{
			get
			{
				return global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x0005FBE3 File Offset: 0x0005DDE3
		protected bool IsShiftKeyPressed
		{
			get
			{
				return global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftShift) || global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightShift);
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x0005FBF7 File Offset: 0x0005DDF7
		protected virtual int PixelThresholdForHorizontalAutoScroll
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x0005FBFB File Offset: 0x0005DDFB
		protected virtual int PixelThresholdForVerticalAutoScroll
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x0005FBFF File Offset: 0x0005DDFF
		protected global::Infragistics.Windows.Selection.ISelectionHost SelectionHost
		{
			get
			{
				return this._selectionHost;
			}
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0005FC07 File Offset: 0x0005DE07
		public virtual void CancelPendingOperations()
		{
			if (this.InDragMode)
			{
				if (this.SelectionHost != null)
				{
					this.SelectionHost.OnDragEnd(true);
				}
				this.InDragMode = false;
			}
			this.StopHorizontalAutoScrollTimer();
			this.StopVerticalAutoScrollTimer();
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0005FC38 File Offset: 0x0005DE38
		public virtual bool CanItemBeNavigatedTo(global::Infragistics.Windows.Selection.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown)
		{
			return item != null && item.IsTabStop;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0005FC48 File Offset: 0x0005DE48
		public static global::Infragistics.Windows.Selection.SelectionStrategyBase GetSelectionStrategy(global::Infragistics.Windows.Controls.SelectionType type, global::Infragistics.Windows.Selection.ISelectionHost host, global::Infragistics.Windows.Selection.SelectionStrategyBase oldStrategy)
		{
			if (host == null)
			{
				throw new global::System.ArgumentNullException("host");
			}
			global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyBase = (oldStrategy != null && oldStrategy._selectionHost == host) ? oldStrategy : null;
			if (selectionStrategyBase != null && global::Infragistics.Windows.Selection.SelectionStrategyBase.GetSelectionType(selectionStrategyBase) == type)
			{
				return selectionStrategyBase;
			}
			switch (type)
			{
			default:
				selectionStrategyBase = new global::Infragistics.Windows.Selection.SelectionStrategyNone(host);
				break;
			case global::Infragistics.Windows.Controls.SelectionType.Single:
				selectionStrategyBase = new global::Infragistics.Windows.Selection.SelectionStrategySingle(host);
				break;
			case global::Infragistics.Windows.Controls.SelectionType.Extended:
				selectionStrategyBase = new global::Infragistics.Windows.Selection.SelectionStrategyExtended(host);
				break;
			case global::Infragistics.Windows.Controls.SelectionType.Range:
				selectionStrategyBase = new global::Infragistics.Windows.Selection.SelectionStrategyContiguous(host);
				break;
			case global::Infragistics.Windows.Controls.SelectionType.ExtendedAutoDrag:
				selectionStrategyBase = new global::Infragistics.Windows.Selection.SelectionStrategyExtendedAutoDrag(host);
				break;
			case global::Infragistics.Windows.Controls.SelectionType.SingleAutoDrag:
				selectionStrategyBase = new global::Infragistics.Windows.Selection.SelectionStrategySingleAutoDrag(host);
				break;
			}
			return selectionStrategyBase;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0005FCF4 File Offset: 0x0005DEF4
		public static bool IsMultiSelectStrategy(global::Infragistics.Windows.Controls.SelectionType selectionType)
		{
			switch (selectionType)
			{
			case global::Infragistics.Windows.Controls.SelectionType.None:
			case global::Infragistics.Windows.Controls.SelectionType.Single:
			case global::Infragistics.Windows.Controls.SelectionType.SingleAutoDrag:
				return false;
			case global::Infragistics.Windows.Controls.SelectionType.Extended:
			case global::Infragistics.Windows.Controls.SelectionType.Range:
			case global::Infragistics.Windows.Controls.SelectionType.ExtendedAutoDrag:
				return true;
			}
			return false;
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x0005FD2C File Offset: 0x0005DF2C
		public static bool IsSingleSelectStrategy(global::Infragistics.Windows.Controls.SelectionType selectionType)
		{
			switch (selectionType)
			{
			case global::Infragistics.Windows.Controls.SelectionType.None:
			case global::Infragistics.Windows.Controls.SelectionType.Extended:
			case global::Infragistics.Windows.Controls.SelectionType.Range:
			case global::Infragistics.Windows.Controls.SelectionType.ExtendedAutoDrag:
				return false;
			case global::Infragistics.Windows.Controls.SelectionType.Single:
			case global::Infragistics.Windows.Controls.SelectionType.SingleAutoDrag:
				return true;
			}
			return false;
		}

		// Token: 0x06001925 RID: 6437
		public abstract bool OnMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001926 RID: 6438
		public abstract bool OnMouseMove(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001927 RID: 6439
		public abstract void OnMouseLeftButtonUp(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001928 RID: 6440
		public abstract bool SelectItemViaKeyboard(global::Infragistics.Windows.Selection.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown, bool forceToggle);

		// Token: 0x06001929 RID: 6441 RVA: 0x0005FD64 File Offset: 0x0005DF64
		protected void DragMove(global::System.Windows.Input.MouseEventArgs e)
		{
			this.ManageTimers(e);
			this.SelectionHost.OnDragMove(e);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x0005FD7C File Offset: 0x0005DF7C
		protected void DragStart(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			if (this.SelectionHost != null && this.CurrentSelectableItem != null)
			{
				bool flag = this.SelectionHost.OnDragStart(this.CurrentSelectableItem, mouseEventArgs);
				flag = (flag && this.IsAnyMouseButtonDown);
				if (flag)
				{
					this.InDragMode = true;
					return;
				}
				this.OnDragStartCanceled();
			}
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0005FDCA File Offset: 0x0005DFCA
		protected global::System.Windows.Point GetMousePointInRootElementCoordinates(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			return mouseEventArgs.GetPosition(this.SelectionHost.RootElement);
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0005FDE0 File Offset: 0x0005DFE0
		protected virtual void ManageTimers(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			global::Infragistics.Windows.Selection.AutoScrollInfo autoScrollInfo = this.SelectionHost.GetAutoScrollInfo(this.CurrentSelectableItem);
			this._autoScrollManagerHorizontal = new global::Infragistics.Windows.Selection.SelectionStrategyBase.AutoScrollManager(this, autoScrollInfo, mouseEventArgs, false);
			if (this._autoScrollManagerHorizontal.IsScrollingRequired)
			{
				this.SetupHorizontalAutoScrollTimer(this._autoScrollManagerHorizontal.TimerInterval);
			}
			else
			{
				this.StopHorizontalAutoScrollTimer();
			}
			this._autoScrollManagerVertical = new global::Infragistics.Windows.Selection.SelectionStrategyBase.AutoScrollManager(this, autoScrollInfo, mouseEventArgs, true);
			if (this._autoScrollManagerVertical.IsScrollingRequired)
			{
				this.SetupVerticalAutoScrollTimer(this._autoScrollManagerVertical.TimerInterval);
				return;
			}
			this.StopVerticalAutoScrollTimer();
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0005FE68 File Offset: 0x0005E068
		protected virtual void OnDragStartCanceled()
		{
			if (this.SelectionHost.RootElement.IsMouseCaptured && !this.IsAnyMouseButtonDown && this.SelectionHost != null)
			{
				this.SelectionHost.OnDragEnd(true);
			}
			if (this.SelectionHost.RootElement.IsMouseCaptured)
			{
				this.SelectionHost.RootElement.ReleaseMouseCapture();
			}
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x0005FEC5 File Offset: 0x0005E0C5
		protected virtual bool ShouldStartDrag(double x, double y)
		{
			return global::System.Math.Abs(x - this.InitialXPos) > (double)this.DragThreshold || global::System.Math.Abs(y - this.InitialYPos) > (double)this.DragThreshold;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0005FEF6 File Offset: 0x0005E0F6
		protected void StopHorizontalAutoScrollTimer()
		{
			if (this._autoScrollStopwatchHorizontal != null)
			{
				this._autoScrollStopwatchHorizontal.Stop();
				this._autoScrollStopwatchHorizontal = null;
			}
			if (this._horizontalAutoScrollTimer != null && this._horizontalAutoScrollTimer.IsEnabled)
			{
				this._horizontalAutoScrollTimer.Stop();
			}
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x0005FF32 File Offset: 0x0005E132
		protected void StopVerticalAutoScrollTimer()
		{
			if (this._autoScrollStopwatchVertical != null)
			{
				this._autoScrollStopwatchVertical.Stop();
				this._autoScrollStopwatchVertical = null;
			}
			if (this._verticalAutoScrollTimer != null && this._verticalAutoScrollTimer.IsEnabled)
			{
				this._verticalAutoScrollTimer.Stop();
			}
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x0005FF70 File Offset: 0x0005E170
		private void ForceSynchronousMouseMove()
		{
			global::System.Windows.IInputElement captured = global::System.Windows.Input.Mouse.Captured;
			if (captured != null)
			{
				this._isReleasingMouseCapture = true;
				try
				{
					global::System.Windows.Input.Mouse.Capture(null);
					global::System.Windows.Input.Mouse.Capture(captured, global::System.Windows.Input.CaptureMode.Element);
				}
				finally
				{
					this._isReleasingMouseCapture = false;
				}
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0005FFB8 File Offset: 0x0005E1B8
		private static global::Infragistics.Windows.Controls.SelectionType? GetSelectionType(global::Infragistics.Windows.Selection.SelectionStrategyBase strategy)
		{
			if (strategy is global::Infragistics.Windows.Selection.SelectionStrategyContiguous)
			{
				return new global::Infragistics.Windows.Controls.SelectionType?(global::Infragistics.Windows.Controls.SelectionType.Range);
			}
			if (strategy is global::Infragistics.Windows.Selection.SelectionStrategySingleAutoDrag)
			{
				return new global::Infragistics.Windows.Controls.SelectionType?(global::Infragistics.Windows.Controls.SelectionType.SingleAutoDrag);
			}
			if (strategy is global::Infragistics.Windows.Selection.SelectionStrategySingle)
			{
				return new global::Infragistics.Windows.Controls.SelectionType?(global::Infragistics.Windows.Controls.SelectionType.Single);
			}
			if (strategy is global::Infragistics.Windows.Selection.SelectionStrategyExtendedAutoDrag)
			{
				return new global::Infragistics.Windows.Controls.SelectionType?(global::Infragistics.Windows.Controls.SelectionType.ExtendedAutoDrag);
			}
			if (strategy is global::Infragistics.Windows.Selection.SelectionStrategyExtended)
			{
				return new global::Infragistics.Windows.Controls.SelectionType?(global::Infragistics.Windows.Controls.SelectionType.Extended);
			}
			if (strategy is global::Infragistics.Windows.Selection.SelectionStrategyNone)
			{
				return new global::Infragistics.Windows.Controls.SelectionType?(global::Infragistics.Windows.Controls.SelectionType.None);
			}
			return null;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00060028 File Offset: 0x0005E228
		private void OnHorizontalAutoScrollTimerTick(object sender, global::System.EventArgs e)
		{
			this.StopHorizontalAutoScrollTimer();
			if (global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Released)
			{
				return;
			}
			global::Infragistics.Windows.Selection.ISelectableItem currentSelectableItem = this.CurrentSelectableItem;
			if (currentSelectableItem != null)
			{
				this._selectionHost.DoAutoScrollHorizontal(currentSelectableItem, this._autoScrollManagerHorizontal.ScrollDirection, this._autoScrollManagerHorizontal.ScrollSpeed);
				this.ForceSynchronousMouseMove();
			}
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00060078 File Offset: 0x0005E278
		private void OnVerticalAutoScrollTimerTick(object sender, global::System.EventArgs e)
		{
			this.StopVerticalAutoScrollTimer();
			if (global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Released)
			{
				return;
			}
			global::Infragistics.Windows.Selection.ISelectableItem currentSelectableItem = this.CurrentSelectableItem;
			if (currentSelectableItem != null)
			{
				this._selectionHost.DoAutoScrollVertical(currentSelectableItem, this._autoScrollManagerVertical.ScrollDirection, this._autoScrollManagerVertical.ScrollSpeed);
				this.ForceSynchronousMouseMove();
			}
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x000600C8 File Offset: 0x0005E2C8
		private void SetupHorizontalAutoScrollTimer(double interval)
		{
			if (this._horizontalAutoScrollTimer == null)
			{
				this._horizontalAutoScrollTimer = new global::System.Windows.Threading.DispatcherTimer(this.AutoScrollTimerDispatcherPriority);
				this._horizontalAutoScrollTimer.Tick += this.OnHorizontalAutoScrollTimerTick;
			}
			global::System.TimeSpan timeSpan = global::System.TimeSpan.FromMilliseconds(interval);
			if (timeSpan != this._horizontalAutoScrollTimer.Interval || !this._horizontalAutoScrollTimer.IsEnabled)
			{
				global::System.Diagnostics.Stopwatch autoScrollStopwatchHorizontal = this._autoScrollStopwatchHorizontal ?? global::System.Diagnostics.Stopwatch.StartNew();
				if (this._autoScrollStopwatchHorizontal != null)
				{
					timeSpan = global::System.TimeSpan.FromTicks(global::System.Math.Max(timeSpan.Ticks - this._autoScrollStopwatchHorizontal.ElapsedTicks, 0L));
					this._autoScrollStopwatchHorizontal = null;
				}
				this._horizontalAutoScrollTimer.Interval = timeSpan;
				this._autoScrollStopwatchHorizontal = autoScrollStopwatchHorizontal;
				this._horizontalAutoScrollTimer.Start();
			}
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x0006018C File Offset: 0x0005E38C
		private void SetupVerticalAutoScrollTimer(double interval)
		{
			if (this._verticalAutoScrollTimer == null)
			{
				this._verticalAutoScrollTimer = new global::System.Windows.Threading.DispatcherTimer(this.AutoScrollTimerDispatcherPriority);
				this._verticalAutoScrollTimer.Tick += this.OnVerticalAutoScrollTimerTick;
			}
			global::System.TimeSpan timeSpan = global::System.TimeSpan.FromMilliseconds(interval);
			if (timeSpan != this._verticalAutoScrollTimer.Interval || !this._verticalAutoScrollTimer.IsEnabled)
			{
				global::System.Diagnostics.Stopwatch autoScrollStopwatchVertical = this._autoScrollStopwatchVertical ?? global::System.Diagnostics.Stopwatch.StartNew();
				if (this._autoScrollStopwatchVertical != null)
				{
					timeSpan = global::System.TimeSpan.FromTicks(global::System.Math.Max(timeSpan.Ticks - this._autoScrollStopwatchVertical.ElapsedTicks, 0L));
					this._autoScrollStopwatchVertical = null;
				}
				this._verticalAutoScrollTimer.Interval = timeSpan;
				this._autoScrollStopwatchVertical = autoScrollStopwatchVertical;
				this._verticalAutoScrollTimer.Start();
			}
		}

		// Token: 0x04000C07 RID: 3079
		private global::Infragistics.Windows.Selection.ISelectionHost _selectionHost;

		// Token: 0x04000C08 RID: 3080
		private global::System.Windows.Threading.DispatcherTimer _verticalAutoScrollTimer;

		// Token: 0x04000C09 RID: 3081
		private global::System.Windows.Threading.DispatcherTimer _horizontalAutoScrollTimer;

		// Token: 0x04000C0A RID: 3082
		private bool _inDragMode;

		// Token: 0x04000C0B RID: 3083
		private bool _ignoreNextMouseMove;

		// Token: 0x04000C0C RID: 3084
		private bool _isReleasingMouseCapture;

		// Token: 0x04000C0D RID: 3085
		private double _initialXPos;

		// Token: 0x04000C0E RID: 3086
		private double _initialYPos;

		// Token: 0x04000C0F RID: 3087
		private global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState _currentSelectionState;

		// Token: 0x04000C10 RID: 3088
		private global::System.WeakReference _currentSelectableItemRef;

		// Token: 0x04000C11 RID: 3089
		private global::Infragistics.Windows.Selection.SelectionStrategyBase.AutoScrollManager _autoScrollManagerVertical;

		// Token: 0x04000C12 RID: 3090
		private global::Infragistics.Windows.Selection.SelectionStrategyBase.AutoScrollManager _autoScrollManagerHorizontal;

		// Token: 0x04000C13 RID: 3091
		private global::System.Diagnostics.Stopwatch _autoScrollStopwatchHorizontal;

		// Token: 0x04000C14 RID: 3092
		private global::System.Diagnostics.Stopwatch _autoScrollStopwatchVertical;

		// Token: 0x0200027A RID: 634
		protected enum SelectionState
		{
			// Token: 0x04000C16 RID: 3094
			SingleSelect,
			// Token: 0x04000C17 RID: 3095
			PreDrag,
			// Token: 0x04000C18 RID: 3096
			PreEdit,
			// Token: 0x04000C19 RID: 3097
			PotentialPreDrag,
			// Token: 0x04000C1A RID: 3098
			ExtSelect,
			// Token: 0x04000C1B RID: 3099
			ControlClick
		}

		// Token: 0x0200027B RID: 635
		protected class AutoScrollManager
		{
			// Token: 0x06001937 RID: 6455 RVA: 0x00060250 File Offset: 0x0005E450
			public AutoScrollManager(global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategy, global::Infragistics.Windows.Selection.AutoScrollInfo autoScrollInfo, global::System.Windows.Input.MouseEventArgs mouseEventArgs, bool directionIsVertical)
			{
				if (selectionStrategy == null)
				{
					throw new global::System.ArgumentNullException("selectionStrategy", global::SR.GetString("LE_ArgumentNullException_3"));
				}
				if (mouseEventArgs == null)
				{
					throw new global::System.ArgumentNullException("mouseEventArgs", global::SR.GetString("LE_ArgumentNullException_4"));
				}
				this._selectionStrategy = selectionStrategy;
				this._autoScrollInfo = autoScrollInfo;
				this._mouseEventArgs = mouseEventArgs;
				this._directionIsVertical = directionIsVertical;
				this.Initialize();
			}

			// Token: 0x06001938 RID: 6456 RVA: 0x000602B8 File Offset: 0x0005E4B8
			private double GetAutoScrollTimerInterval(int mouseThresholdAreaPenetration)
			{
				int maxTimerInterval = this.MaxTimerInterval;
				int minTimerInterval = this.MinTimerInterval;
				double num = global::System.Math.Log((double)(maxTimerInterval / minTimerInterval));
				double num2 = (double)mouseThresholdAreaPenetration / (this._directionIsVertical ? (global::System.Windows.SystemParameters.PrimaryScreenHeight * 0.4) : (global::System.Windows.SystemParameters.PrimaryScreenWidth * 0.4));
				num2 = global::System.Math.Abs(num2 * num);
				double val = (double)maxTimerInterval / global::System.Math.Pow(2.718281828459045, num2);
				val = global::System.Math.Min(val, (double)maxTimerInterval);
				return global::System.Math.Max(val, (double)minTimerInterval);
			}

			// Token: 0x06001939 RID: 6457 RVA: 0x00060340 File Offset: 0x0005E540
			private int GetMouseThresholdAreaPenetration()
			{
				int num = this.GetMouseThresholdAreaPenetration(this._directionIsVertical);
				if (num != 0 && this._autoScrollInfo.ScrollOrientation != global::Infragistics.Windows.Selection.ScrollOrientation.Both)
				{
					int mouseThresholdAreaPenetration = this.GetMouseThresholdAreaPenetration(!this._directionIsVertical);
					if (mouseThresholdAreaPenetration != 0)
					{
						switch (this._autoScrollInfo.ScrollOrientation)
						{
						case global::Infragistics.Windows.Selection.ScrollOrientation.Horizontal:
							if (this._directionIsVertical)
							{
								num = 0;
							}
							break;
						case global::Infragistics.Windows.Selection.ScrollOrientation.Vertical:
							if (!this._directionIsVertical)
							{
								num = 0;
							}
							break;
						case global::Infragistics.Windows.Selection.ScrollOrientation.BasedOnDistance:
						{
							int num2 = global::System.Math.Abs(num).CompareTo(global::System.Math.Abs(mouseThresholdAreaPenetration));
							if (num2 > 0 || (num2 == 0 && !this._directionIsVertical))
							{
								num = 0;
							}
							break;
						}
						}
					}
				}
				return num;
			}

			// Token: 0x0600193A RID: 6458 RVA: 0x000603E4 File Offset: 0x0005E5E4
			private int GetMouseThresholdAreaPenetration(bool vertical)
			{
				int result = 0;
				if (vertical)
				{
					if (this._mousePosition.Y < this._scrollAreaInnerRect.Top)
					{
						if (this._autoScrollInfo.CanScrollUp)
						{
							result = (int)(this._mousePosition.Y - this._scrollAreaInnerRect.Top);
						}
					}
					else if (this._mousePosition.Y > this._scrollAreaInnerRect.Bottom && this._autoScrollInfo.CanScrollDown)
					{
						result = (int)(this._mousePosition.Y - this._scrollAreaInnerRect.Bottom);
					}
				}
				else if (this._mousePosition.X < this._scrollAreaInnerRect.Left)
				{
					if (this._autoScrollInfo.CanScrollLeft)
					{
						result = (int)(this._mousePosition.X - this._scrollAreaInnerRect.Left);
					}
				}
				else if (this._mousePosition.X > this._scrollAreaInnerRect.Right && this._autoScrollInfo.CanScrollRight)
				{
					result = (int)(this._mousePosition.X - this._scrollAreaInnerRect.Right);
				}
				return result;
			}

			// Token: 0x0600193B RID: 6459 RVA: 0x00060504 File Offset: 0x0005E704
			private global::Infragistics.Windows.Selection.ScrollSpeed GetScrollSpeedFromTimerInterval(double timerInterval)
			{
				double num = (double)this.MinTimerInterval;
				double num2 = (double)this.MaxTimerInterval;
				if (timerInterval <= num)
				{
					return global::Infragistics.Windows.Selection.ScrollSpeed.Fastest;
				}
				if (timerInterval >= num2)
				{
					return global::Infragistics.Windows.Selection.ScrollSpeed.Slowest;
				}
				double num3 = (timerInterval - num) / (num2 - num);
				if (num3 < 0.14)
				{
					return global::Infragistics.Windows.Selection.ScrollSpeed.Fastest;
				}
				if (num3 < 0.28)
				{
					return global::Infragistics.Windows.Selection.ScrollSpeed.Faster;
				}
				if (num3 < 0.42)
				{
					return global::Infragistics.Windows.Selection.ScrollSpeed.Fast;
				}
				if (num3 < 0.56)
				{
					return global::Infragistics.Windows.Selection.ScrollSpeed.Medium;
				}
				if (num3 < 0.7)
				{
					return global::Infragistics.Windows.Selection.ScrollSpeed.Slow;
				}
				if (num3 < 0.84)
				{
					return global::Infragistics.Windows.Selection.ScrollSpeed.Slower;
				}
				return global::Infragistics.Windows.Selection.ScrollSpeed.Slowest;
			}

			// Token: 0x0600193C RID: 6460 RVA: 0x0006058C File Offset: 0x0005E78C
			private void Initialize()
			{
				if (this._directionIsVertical)
				{
					if (!this._autoScrollInfo.CanScrollUp && !this._autoScrollInfo.CanScrollDown)
					{
						this._isScrollingRequired = false;
						return;
					}
				}
				else if (!this._autoScrollInfo.CanScrollLeft && !this._autoScrollInfo.CanScrollRight)
				{
					this._isScrollingRequired = false;
					return;
				}
				this._scrollAreaRect = new global::System.Windows.Rect(this._autoScrollInfo.ScrollArea.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this._selectionStrategy.SelectionHost.RootElement), new global::System.Windows.Size(this._autoScrollInfo.ScrollArea.ActualWidth, this._autoScrollInfo.ScrollArea.ActualHeight));
				this._scrollAreaInnerRect = this._scrollAreaRect;
				this._scrollAreaInnerRect.Inflate((double)(-(double)this._selectionStrategy.PixelThresholdForHorizontalAutoScroll), (double)(-(double)this._selectionStrategy.PixelThresholdForVerticalAutoScroll));
				this._mousePosition = this._selectionStrategy.GetMousePointInRootElementCoordinates(this._mouseEventArgs);
				this._isScrollingRequired = false;
				if (!this._scrollAreaInnerRect.Contains(this._mousePosition))
				{
					this._timerInterval = -1.0;
					int mouseThresholdAreaPenetration = this.GetMouseThresholdAreaPenetration();
					if (mouseThresholdAreaPenetration != 0)
					{
						this._timerInterval = this.GetAutoScrollTimerInterval(global::System.Math.Abs(mouseThresholdAreaPenetration));
					}
					if (this._timerInterval != -1.0)
					{
						this._isScrollingRequired = true;
						this._scrollDirection = ((mouseThresholdAreaPenetration < 0) ? global::Infragistics.Windows.Selection.ScrollDirection.Decrement : global::Infragistics.Windows.Selection.ScrollDirection.Increment);
					}
				}
				if (this._autoScrollInfo.AdjustScrollInfoCallback != null)
				{
					global::Infragistics.Windows.Selection.ScrollDirection? scrollDirection = this._isScrollingRequired ? new global::Infragistics.Windows.Selection.ScrollDirection?(this._scrollDirection) : null;
					double val = this._isScrollingRequired ? this._timerInterval : ((double)this.MaxTimerInterval);
					this._autoScrollInfo.AdjustScrollInfoCallback(!this._directionIsVertical, this._mouseEventArgs, this._selectionStrategy.CurrentSelectableItem, ref scrollDirection, ref val);
					this._isScrollingRequired = (scrollDirection != null);
					this._scrollDirection = (scrollDirection ?? global::Infragistics.Windows.Selection.ScrollDirection.Decrement);
					this._timerInterval = global::System.Math.Max(global::System.Math.Min(val, (double)this.MaxTimerInterval), (double)this.MinTimerInterval);
				}
				if (this._isScrollingRequired)
				{
					this._scrollSpeed = this.GetScrollSpeedFromTimerInterval(this._timerInterval);
				}
			}

			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x0600193D RID: 6461 RVA: 0x000607D6 File Offset: 0x0005E9D6
			public bool IsScrollingRequired
			{
				get
				{
					return this._isScrollingRequired;
				}
			}

			// Token: 0x170005FE RID: 1534
			// (get) Token: 0x0600193E RID: 6462 RVA: 0x000607DE File Offset: 0x0005E9DE
			private int MaxTimerInterval
			{
				get
				{
					if (!this._directionIsVertical)
					{
						return this._selectionStrategy.AutoScrollHorizontalIntervalMax;
					}
					return this._selectionStrategy.AutoScrollVerticalIntervalMax;
				}
			}

			// Token: 0x170005FF RID: 1535
			// (get) Token: 0x0600193F RID: 6463 RVA: 0x000607FF File Offset: 0x0005E9FF
			private int MinTimerInterval
			{
				get
				{
					if (!this._directionIsVertical)
					{
						return this._selectionStrategy.AutoScrollHorizontalIntervalMin;
					}
					return this._selectionStrategy.AutoScrollVerticalIntervalMin;
				}
			}

			// Token: 0x17000600 RID: 1536
			// (get) Token: 0x06001940 RID: 6464 RVA: 0x00060820 File Offset: 0x0005EA20
			public global::Infragistics.Windows.Selection.ScrollDirection ScrollDirection
			{
				get
				{
					return this._scrollDirection;
				}
			}

			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x06001941 RID: 6465 RVA: 0x00060828 File Offset: 0x0005EA28
			public global::Infragistics.Windows.Selection.ScrollSpeed ScrollSpeed
			{
				get
				{
					return this._scrollSpeed;
				}
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x06001942 RID: 6466 RVA: 0x00060830 File Offset: 0x0005EA30
			public double TimerInterval
			{
				get
				{
					return this._timerInterval;
				}
			}

			// Token: 0x04000C1C RID: 3100
			private global::Infragistics.Windows.Selection.SelectionStrategyBase _selectionStrategy;

			// Token: 0x04000C1D RID: 3101
			private global::Infragistics.Windows.Selection.AutoScrollInfo _autoScrollInfo;

			// Token: 0x04000C1E RID: 3102
			private global::System.Windows.Input.MouseEventArgs _mouseEventArgs;

			// Token: 0x04000C1F RID: 3103
			private bool _directionIsVertical;

			// Token: 0x04000C20 RID: 3104
			private bool _isScrollingRequired;

			// Token: 0x04000C21 RID: 3105
			private global::Infragistics.Windows.Selection.ScrollDirection _scrollDirection;

			// Token: 0x04000C22 RID: 3106
			private global::Infragistics.Windows.Selection.ScrollSpeed _scrollSpeed;

			// Token: 0x04000C23 RID: 3107
			private double _timerInterval;

			// Token: 0x04000C24 RID: 3108
			private global::System.Windows.Rect _scrollAreaRect;

			// Token: 0x04000C25 RID: 3109
			private global::System.Windows.Rect _scrollAreaInnerRect;

			// Token: 0x04000C26 RID: 3110
			private global::System.Windows.Point _mousePosition;
		}
	}
}
