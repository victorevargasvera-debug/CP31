using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Selection
{
	// Token: 0x020002B6 RID: 694
	public abstract class SelectionStrategyBase
	{
		// Token: 0x06001B2E RID: 6958 RVA: 0x00066BDC File Offset: 0x00064DDC
		protected SelectionStrategyBase(global::Infragistics.Windows.Selection.ISelectionHost selectionHost)
		{
			if (selectionHost == null)
			{
				throw new global::System.ArgumentNullException("selectionHost", global::SR.GetString("LE_ArgumentNullException_2"));
			}
			this._selectionHost = selectionHost;
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x00066C03 File Offset: 0x00064E03
		public virtual bool IsMultiSelect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x00066C06 File Offset: 0x00064E06
		public virtual bool IsSingleSelect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x00066C09 File Offset: 0x00064E09
		public bool IsReleasingMouseCapture
		{
			get
			{
				return this._isReleasingMouseCapture;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x00066C11 File Offset: 0x00064E11
		protected virtual int AutoScrollHorizontalIntervalMax
		{
			get
			{
				return 300;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x00066C18 File Offset: 0x00064E18
		protected virtual int AutoScrollHorizontalIntervalMin
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x00066C1C File Offset: 0x00064E1C
		protected virtual int AutoScrollVerticalIntervalMax
		{
			get
			{
				return 300;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x00066C23 File Offset: 0x00064E23
		protected virtual int AutoScrollVerticalIntervalMin
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x00066C27 File Offset: 0x00064E27
		protected virtual global::System.Windows.Threading.DispatcherPriority AutoScrollTimerDispatcherPriority
		{
			get
			{
				return global::System.Windows.Threading.DispatcherPriority.Input;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x00066C2A File Offset: 0x00064E2A
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x00066C46 File Offset: 0x00064E46
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

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x00066C5F File Offset: 0x00064E5F
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x00066C67 File Offset: 0x00064E67
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

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x00066C70 File Offset: 0x00064E70
		protected virtual int DragThreshold
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x00066C73 File Offset: 0x00064E73
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x00066C7B File Offset: 0x00064E7B
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

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x00066C84 File Offset: 0x00064E84
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x00066C8C File Offset: 0x00064E8C
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

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x00066C95 File Offset: 0x00064E95
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x00066C9D File Offset: 0x00064E9D
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

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x00066CA6 File Offset: 0x00064EA6
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x00066CAE File Offset: 0x00064EAE
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

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x00066CB7 File Offset: 0x00064EB7
		protected bool IsAnyMouseButtonDown
		{
			get
			{
				return global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed || global::System.Windows.Input.Mouse.MiddleButton == global::System.Windows.Input.MouseButtonState.Pressed || global::System.Windows.Input.Mouse.RightButton == global::System.Windows.Input.MouseButtonState.Pressed;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x00066CD3 File Offset: 0x00064ED3
		protected bool IsCtrlKeyPressed
		{
			get
			{
				return global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl) || global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl);
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x00066CE7 File Offset: 0x00064EE7
		protected bool IsLeftMouseButtonDown
		{
			get
			{
				return global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x00066CF1 File Offset: 0x00064EF1
		protected bool IsShiftKeyPressed
		{
			get
			{
				return global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftShift) || global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightShift);
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x00066D05 File Offset: 0x00064F05
		protected virtual int PixelThresholdForHorizontalAutoScroll
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00066D09 File Offset: 0x00064F09
		protected virtual int PixelThresholdForVerticalAutoScroll
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x00066D0D File Offset: 0x00064F0D
		protected global::Infragistics.Windows.Selection.ISelectionHost SelectionHost
		{
			get
			{
				return this._selectionHost;
			}
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00066D15 File Offset: 0x00064F15
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

		// Token: 0x06001B4C RID: 6988 RVA: 0x00066D46 File Offset: 0x00064F46
		public virtual bool CanItemBeNavigatedTo(global::Infragistics.Windows.Selection.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown)
		{
			return item != null && item.IsTabStop;
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00066D54 File Offset: 0x00064F54
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

		// Token: 0x06001B4E RID: 6990 RVA: 0x00066E00 File Offset: 0x00065000
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

		// Token: 0x06001B4F RID: 6991 RVA: 0x00066E38 File Offset: 0x00065038
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

		// Token: 0x06001B50 RID: 6992
		public abstract bool OnMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001B51 RID: 6993
		public abstract bool OnMouseMove(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001B52 RID: 6994
		public abstract void OnMouseLeftButtonUp(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001B53 RID: 6995
		public abstract bool SelectItemViaKeyboard(global::Infragistics.Windows.Selection.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown, bool forceToggle);

		// Token: 0x06001B54 RID: 6996 RVA: 0x00066E70 File Offset: 0x00065070
		protected void DragMove(global::System.Windows.Input.MouseEventArgs e)
		{
			this.ManageTimers(e);
			this.SelectionHost.OnDragMove(e);
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00066E88 File Offset: 0x00065088
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

		// Token: 0x06001B56 RID: 6998 RVA: 0x00066ED6 File Offset: 0x000650D6
		protected global::System.Windows.Point GetMousePointInRootElementCoordinates(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			return mouseEventArgs.GetPosition(this.SelectionHost.RootElement);
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00066EE9 File Offset: 0x000650E9
		protected internal bool IsWithinDblClickThreshold()
		{
			return this._controller == null || (!this.IsCtrlKeyPressed && !this.IsShiftKeyPressed && this._controller.IsWithinDblClickThreshold());
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00066F14 File Offset: 0x00065114
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

		// Token: 0x06001B59 RID: 7001 RVA: 0x00066F9C File Offset: 0x0006519C
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

		// Token: 0x06001B5A RID: 7002 RVA: 0x00066FF9 File Offset: 0x000651F9
		protected virtual bool ShouldStartDrag(double x, double y)
		{
			return global::System.Math.Abs(x - this.InitialXPos) > (double)this.DragThreshold || global::System.Math.Abs(y - this.InitialYPos) > (double)this.DragThreshold;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0006702A File Offset: 0x0006522A
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

		// Token: 0x06001B5C RID: 7004 RVA: 0x00067066 File Offset: 0x00065266
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

		// Token: 0x06001B5D RID: 7005 RVA: 0x000670A2 File Offset: 0x000652A2
		internal void InitializeController(global::Infragistics.Windows.Selection.SelectionController controller)
		{
			this._controller = controller;
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x000670AC File Offset: 0x000652AC
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

		// Token: 0x06001B5F RID: 7007 RVA: 0x000670F4 File Offset: 0x000652F4
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

		// Token: 0x06001B60 RID: 7008 RVA: 0x00067164 File Offset: 0x00065364
		private void OnHorizontalAutoScrollTimerTick(object sender, global::System.EventArgs e)
		{
			if (this.IsWithinDblClickThreshold())
			{
				return;
			}
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

		// Token: 0x06001B61 RID: 7009 RVA: 0x000671BC File Offset: 0x000653BC
		private void OnVerticalAutoScrollTimerTick(object sender, global::System.EventArgs e)
		{
			if (this.IsWithinDblClickThreshold())
			{
				return;
			}
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

		// Token: 0x06001B62 RID: 7010 RVA: 0x00067214 File Offset: 0x00065414
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

		// Token: 0x06001B63 RID: 7011 RVA: 0x000672D8 File Offset: 0x000654D8
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

		// Token: 0x04000D79 RID: 3449
		private global::Infragistics.Windows.Selection.ISelectionHost _selectionHost;

		// Token: 0x04000D7A RID: 3450
		private global::System.Windows.Threading.DispatcherTimer _verticalAutoScrollTimer;

		// Token: 0x04000D7B RID: 3451
		private global::System.Windows.Threading.DispatcherTimer _horizontalAutoScrollTimer;

		// Token: 0x04000D7C RID: 3452
		private bool _inDragMode;

		// Token: 0x04000D7D RID: 3453
		private bool _ignoreNextMouseMove;

		// Token: 0x04000D7E RID: 3454
		private bool _isReleasingMouseCapture;

		// Token: 0x04000D7F RID: 3455
		private double _initialXPos;

		// Token: 0x04000D80 RID: 3456
		private double _initialYPos;

		// Token: 0x04000D81 RID: 3457
		private global::Infragistics.Windows.Selection.SelectionController _controller;

		// Token: 0x04000D82 RID: 3458
		private global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState _currentSelectionState;

		// Token: 0x04000D83 RID: 3459
		private global::System.WeakReference _currentSelectableItemRef;

		// Token: 0x04000D84 RID: 3460
		private global::Infragistics.Windows.Selection.SelectionStrategyBase.AutoScrollManager _autoScrollManagerVertical;

		// Token: 0x04000D85 RID: 3461
		private global::Infragistics.Windows.Selection.SelectionStrategyBase.AutoScrollManager _autoScrollManagerHorizontal;

		// Token: 0x04000D86 RID: 3462
		private global::System.Diagnostics.Stopwatch _autoScrollStopwatchHorizontal;

		// Token: 0x04000D87 RID: 3463
		private global::System.Diagnostics.Stopwatch _autoScrollStopwatchVertical;

		// Token: 0x020002B7 RID: 695
		protected enum SelectionState
		{
			// Token: 0x04000D89 RID: 3465
			SingleSelect,
			// Token: 0x04000D8A RID: 3466
			PreDrag,
			// Token: 0x04000D8B RID: 3467
			PreEdit,
			// Token: 0x04000D8C RID: 3468
			PotentialPreDrag,
			// Token: 0x04000D8D RID: 3469
			ExtSelect,
			// Token: 0x04000D8E RID: 3470
			ControlClick
		}

		// Token: 0x020002B8 RID: 696
		protected class AutoScrollManager
		{
			// Token: 0x06001B64 RID: 7012 RVA: 0x0006739C File Offset: 0x0006559C
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

			// Token: 0x06001B65 RID: 7013 RVA: 0x00067404 File Offset: 0x00065604
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

			// Token: 0x06001B66 RID: 7014 RVA: 0x0006748C File Offset: 0x0006568C
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

			// Token: 0x06001B67 RID: 7015 RVA: 0x00067530 File Offset: 0x00065730
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

			// Token: 0x06001B68 RID: 7016 RVA: 0x00067650 File Offset: 0x00065850
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

			// Token: 0x06001B69 RID: 7017 RVA: 0x000676D8 File Offset: 0x000658D8
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
					int num = global::System.Math.Min(global::System.Math.Max(this.GetMouseThresholdAreaPenetration(), -10000), 10000);
					if (num != 0)
					{
						this._timerInterval = this.GetAutoScrollTimerInterval(global::System.Math.Abs(num));
					}
					if (this._timerInterval != -1.0)
					{
						this._isScrollingRequired = true;
						this._scrollDirection = ((num < 0) ? global::Infragistics.Windows.Selection.ScrollDirection.Decrement : global::Infragistics.Windows.Selection.ScrollDirection.Increment);
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

			// Token: 0x1700068B RID: 1675
			// (get) Token: 0x06001B6A RID: 7018 RVA: 0x00067936 File Offset: 0x00065B36
			public bool IsScrollingRequired
			{
				get
				{
					return this._isScrollingRequired;
				}
			}

			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0006793E File Offset: 0x00065B3E
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

			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0006795F File Offset: 0x00065B5F
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

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x06001B6D RID: 7021 RVA: 0x00067980 File Offset: 0x00065B80
			public global::Infragistics.Windows.Selection.ScrollDirection ScrollDirection
			{
				get
				{
					return this._scrollDirection;
				}
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x06001B6E RID: 7022 RVA: 0x00067988 File Offset: 0x00065B88
			public global::Infragistics.Windows.Selection.ScrollSpeed ScrollSpeed
			{
				get
				{
					return this._scrollSpeed;
				}
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x06001B6F RID: 7023 RVA: 0x00067990 File Offset: 0x00065B90
			public double TimerInterval
			{
				get
				{
					return this._timerInterval;
				}
			}

			// Token: 0x04000D8F RID: 3471
			private global::Infragistics.Windows.Selection.SelectionStrategyBase _selectionStrategy;

			// Token: 0x04000D90 RID: 3472
			private global::Infragistics.Windows.Selection.AutoScrollInfo _autoScrollInfo;

			// Token: 0x04000D91 RID: 3473
			private global::System.Windows.Input.MouseEventArgs _mouseEventArgs;

			// Token: 0x04000D92 RID: 3474
			private bool _directionIsVertical;

			// Token: 0x04000D93 RID: 3475
			private bool _isScrollingRequired;

			// Token: 0x04000D94 RID: 3476
			private global::Infragistics.Windows.Selection.ScrollDirection _scrollDirection;

			// Token: 0x04000D95 RID: 3477
			private global::Infragistics.Windows.Selection.ScrollSpeed _scrollSpeed;

			// Token: 0x04000D96 RID: 3478
			private double _timerInterval;

			// Token: 0x04000D97 RID: 3479
			private global::System.Windows.Rect _scrollAreaRect;

			// Token: 0x04000D98 RID: 3480
			private global::System.Windows.Rect _scrollAreaInnerRect;

			// Token: 0x04000D99 RID: 3481
			private global::System.Windows.Point _mousePosition;
		}
	}
}
