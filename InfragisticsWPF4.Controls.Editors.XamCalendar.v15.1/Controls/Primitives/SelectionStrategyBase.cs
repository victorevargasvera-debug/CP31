using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x0200003E RID: 62
	internal abstract class SelectionStrategyBase
	{
		// Token: 0x06000299 RID: 665 RVA: 0x0000D278 File Offset: 0x0000B478
		protected SelectionStrategyBase(global::Infragistics.Controls.Primitives.ISelectionHost selectionHost)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(selectionHost, "selectionHost");
			this._selectionHost = selectionHost;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000D292 File Offset: 0x0000B492
		internal bool IsMouseCaptured
		{
			get
			{
				return global::Infragistics.Controls.Primitives.SelectionStrategyBase._IsMouseCaptured;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0000D299 File Offset: 0x0000B499
		public virtual bool IsMultiSelect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000D29C File Offset: 0x0000B49C
		public virtual bool IsSingleSelect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000D29F File Offset: 0x0000B49F
		public bool IsReleasingMouseCapture
		{
			get
			{
				return this._isReleasingMouseCapture;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000D2A7 File Offset: 0x0000B4A7
		protected virtual int AutoScrollHorizontalIntervalMax
		{
			get
			{
				return 300;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0000D2AE File Offset: 0x0000B4AE
		protected virtual int AutoScrollHorizontalIntervalMin
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000D2B2 File Offset: 0x0000B4B2
		protected virtual int AutoScrollVerticalIntervalMax
		{
			get
			{
				return 300;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000D2B9 File Offset: 0x0000B4B9
		protected virtual int AutoScrollVerticalIntervalMin
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000D2BD File Offset: 0x0000B4BD
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0000D2D9 File Offset: 0x0000B4D9
		protected global::Infragistics.Controls.Primitives.ISelectableItem CurrentSelectableItem
		{
			get
			{
				if (this._currentSelectableItemRef == null)
				{
					return null;
				}
				return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._currentSelectableItemRef) as global::Infragistics.Controls.Primitives.ISelectableItem;
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000D2F2 File Offset: 0x0000B4F2
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x0000D2FA File Offset: 0x0000B4FA
		protected global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState CurrentSelectionState
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000D303 File Offset: 0x0000B503
		protected virtual int DragThreshold
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000D306 File Offset: 0x0000B506
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000D30E File Offset: 0x0000B50E
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000D317 File Offset: 0x0000B517
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0000D31F File Offset: 0x0000B51F
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

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000D328 File Offset: 0x0000B528
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0000D330 File Offset: 0x0000B530
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000D339 File Offset: 0x0000B539
		// (set) Token: 0x060002AE RID: 686 RVA: 0x0000D341 File Offset: 0x0000B541
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

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0000D34A File Offset: 0x0000B54A
		protected bool IsCtrlKeyPressed
		{
			get
			{
				return global::Infragistics.Controls.PresentationUtilities.IsModifierPressed(global::System.Windows.Input.ModifierKeys.Control, global::System.Windows.Input.ModifierKeys.None);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000D353 File Offset: 0x0000B553
		protected bool IsShiftKeyPressed
		{
			get
			{
				return global::Infragistics.Controls.PresentationUtilities.IsModifierPressed(global::System.Windows.Input.ModifierKeys.Shift, global::System.Windows.Input.ModifierKeys.None);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000D35C File Offset: 0x0000B55C
		protected virtual int PixelThresholdForHorizontalAutoScroll
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000D360 File Offset: 0x0000B560
		protected virtual int PixelThresholdForVerticalAutoScroll
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000D364 File Offset: 0x0000B564
		protected global::Infragistics.Controls.Primitives.ISelectionHost SelectionHost
		{
			get
			{
				return this._selectionHost;
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000D36C File Offset: 0x0000B56C
		public virtual void CancelPendingOperations()
		{
			this.ReleaseCapture();
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

		// Token: 0x060002B5 RID: 693 RVA: 0x0000D3A3 File Offset: 0x0000B5A3
		public virtual bool CanItemBeNavigatedTo(global::Infragistics.Controls.Primitives.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown)
		{
			return item != null && item.IsTabStop;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		internal bool CaptureMouseForRoot()
		{
			global::System.Windows.FrameworkElement rootElement = this._selectionHost.RootElement;
			if (rootElement == null)
			{
				return false;
			}
			bool ignoreNextMouseMove = this.IgnoreNextMouseMove;
			this.IgnoreNextMouseMove = true;
			global::Infragistics.Controls.Primitives.SelectionStrategyBase._IsMouseCaptured = rootElement.CaptureMouse();
			if (!global::Infragistics.Controls.Primitives.SelectionStrategyBase._IsMouseCaptured)
			{
				return false;
			}
			try
			{
				rootElement.MouseLeftButtonUp += this.OnRootMouseLeftButtonUp;
				rootElement.LostMouseCapture += this.OnRootLostMouseCapture;
			}
			finally
			{
				this.IgnoreNextMouseMove = ignoreNextMouseMove;
			}
			return true;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000D430 File Offset: 0x0000B630
		public static global::Infragistics.Controls.Primitives.SelectionStrategyBase GetSelectionStrategy(global::Infragistics.Controls.Primitives.SelectionType type, global::Infragistics.Controls.Primitives.ISelectionHost host, global::Infragistics.Controls.Primitives.SelectionStrategyBase oldStrategy)
		{
			if (host == null)
			{
				throw new global::System.ArgumentNullException("host");
			}
			global::Infragistics.Controls.Primitives.SelectionStrategyBase selectionStrategyBase = (oldStrategy != null && oldStrategy._selectionHost == host) ? oldStrategy : null;
			if (selectionStrategyBase != null && global::Infragistics.Controls.Primitives.SelectionStrategyBase.GetSelectionType(selectionStrategyBase) == type)
			{
				return selectionStrategyBase;
			}
			switch (type)
			{
			default:
				selectionStrategyBase = new global::Infragistics.Controls.Primitives.SelectionStrategyNone(host);
				break;
			case global::Infragistics.Controls.Primitives.SelectionType.Single:
				selectionStrategyBase = new global::Infragistics.Controls.Primitives.SelectionStrategySingle(host);
				break;
			case global::Infragistics.Controls.Primitives.SelectionType.Extended:
				selectionStrategyBase = new global::Infragistics.Controls.Primitives.SelectionStrategyExtended(host);
				break;
			case global::Infragistics.Controls.Primitives.SelectionType.Range:
				selectionStrategyBase = new global::Infragistics.Controls.Primitives.SelectionStrategyContiguous(host);
				break;
			case global::Infragistics.Controls.Primitives.SelectionType.ExtendedAutoDrag:
				selectionStrategyBase = new global::Infragistics.Controls.Primitives.SelectionStrategyExtendedAutoDrag(host);
				break;
			case global::Infragistics.Controls.Primitives.SelectionType.SingleAutoDrag:
				selectionStrategyBase = new global::Infragistics.Controls.Primitives.SelectionStrategySingleAutoDrag(host);
				break;
			}
			return selectionStrategyBase;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000D4DC File Offset: 0x0000B6DC
		public static bool IsMultiSelectStrategy(global::Infragistics.Controls.Primitives.SelectionType selectionType)
		{
			switch (selectionType)
			{
			case global::Infragistics.Controls.Primitives.SelectionType.None:
			case global::Infragistics.Controls.Primitives.SelectionType.Single:
			case global::Infragistics.Controls.Primitives.SelectionType.SingleAutoDrag:
				return false;
			case global::Infragistics.Controls.Primitives.SelectionType.Extended:
			case global::Infragistics.Controls.Primitives.SelectionType.Range:
			case global::Infragistics.Controls.Primitives.SelectionType.ExtendedAutoDrag:
				return true;
			}
			return false;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000D514 File Offset: 0x0000B714
		public static bool IsSingleSelectStrategy(global::Infragistics.Controls.Primitives.SelectionType selectionType)
		{
			switch (selectionType)
			{
			case global::Infragistics.Controls.Primitives.SelectionType.None:
			case global::Infragistics.Controls.Primitives.SelectionType.Extended:
			case global::Infragistics.Controls.Primitives.SelectionType.Range:
			case global::Infragistics.Controls.Primitives.SelectionType.ExtendedAutoDrag:
				return false;
			case global::Infragistics.Controls.Primitives.SelectionType.Single:
			case global::Infragistics.Controls.Primitives.SelectionType.SingleAutoDrag:
				return true;
			}
			return false;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000D54C File Offset: 0x0000B74C
		internal void OnRootLostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Controls.Primitives.SelectionStrategyBase._IsMouseCaptured = false;
			this.UnwireEvents(sender);
		}

		// Token: 0x060002BB RID: 699
		public abstract bool OnMouseLeftButtonDown(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x060002BC RID: 700 RVA: 0x0000D55B File Offset: 0x0000B75B
		internal void OnRootMouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Controls.Primitives.SelectionStrategyBase._IsMouseCaptured = false;
			this.UnwireEvents(sender);
		}

		// Token: 0x060002BD RID: 701
		public abstract bool OnMouseMove(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x060002BE RID: 702
		public abstract void OnMouseLeftButtonUp(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x060002BF RID: 703 RVA: 0x0000D56A File Offset: 0x0000B76A
		public void ReleaseCapture()
		{
			global::Infragistics.Controls.Primitives.SelectionStrategyBase._IsMouseCaptured = false;
			this.UnwireEvents(this._selectionHost.RootElement);
			this.ReleaseRootElementCapture();
		}

		// Token: 0x060002C0 RID: 704
		public abstract bool SelectItemViaKeyboard(global::Infragistics.Controls.Primitives.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown, bool forceToggle);

		// Token: 0x060002C1 RID: 705 RVA: 0x0000D58C File Offset: 0x0000B78C
		private void UnwireEvents(object sender)
		{
			global::System.Windows.FrameworkElement frameworkElement = sender as global::System.Windows.FrameworkElement;
			frameworkElement.MouseLeftButtonUp -= this.OnRootMouseLeftButtonUp;
			frameworkElement.LostMouseCapture -= this.OnRootLostMouseCapture;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000D5C4 File Offset: 0x0000B7C4
		protected void DragMove(global::System.Windows.Input.MouseEventArgs e)
		{
			this.ManageTimers(e);
			this.SelectionHost.OnDragMove(e);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000D5DC File Offset: 0x0000B7DC
		protected void DragStart(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			if (this.SelectionHost != null && this.CurrentSelectableItem != null)
			{
				bool flag = this.SelectionHost.OnDragStart(this.CurrentSelectableItem, mouseEventArgs);
				flag = (flag && this.IsMouseCaptured);
				if (flag)
				{
					this.InDragMode = true;
					return;
				}
				this.OnDragStartCanceled();
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000D62A File Offset: 0x0000B82A
		protected global::System.Windows.Point GetMousePointInRootElementCoordinates(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			return mouseEventArgs.GetPosition(this.SelectionHost.RootElement);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000D640 File Offset: 0x0000B840
		protected virtual void ManageTimers(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			global::Infragistics.Controls.Primitives.AutoScrollInfo autoScrollInfo = this.SelectionHost.GetAutoScrollInfo(this.CurrentSelectableItem);
			this._autoScrollManagerHorizontal = new global::Infragistics.Controls.Primitives.SelectionStrategyBase.AutoScrollManager(this, autoScrollInfo, mouseEventArgs, false);
			if (this._autoScrollManagerHorizontal.IsScrollingRequired)
			{
				this.SetupHorizontalAutoScrollTimer(this._autoScrollManagerHorizontal.TimerInterval);
			}
			else
			{
				this.StopHorizontalAutoScrollTimer();
			}
			this._autoScrollManagerVertical = new global::Infragistics.Controls.Primitives.SelectionStrategyBase.AutoScrollManager(this, autoScrollInfo, mouseEventArgs, true);
			if (this._autoScrollManagerVertical.IsScrollingRequired)
			{
				this.SetupVerticalAutoScrollTimer(this._autoScrollManagerVertical.TimerInterval);
				return;
			}
			this.StopVerticalAutoScrollTimer();
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		protected virtual void OnDragStartCanceled()
		{
			if (global::Infragistics.Controls.Primitives.SelectionStrategyBase._IsMouseCaptured && this.SelectionHost != null)
			{
				this.SelectionHost.OnDragEnd(true);
			}
			if (global::Infragistics.Controls.Primitives.SelectionStrategyBase._IsMouseCaptured)
			{
				this.ReleaseRootElementCapture();
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000D6F2 File Offset: 0x0000B8F2
		protected virtual bool ShouldStartDrag(double x, double y)
		{
			return global::System.Math.Abs(x - this.InitialXPos) > (double)this.DragThreshold || global::System.Math.Abs(y - this.InitialYPos) > (double)this.DragThreshold;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000D723 File Offset: 0x0000B923
		protected void StopHorizontalAutoScrollTimer()
		{
			if (this._horizontalAutoScrollTimer != null && this._horizontalAutoScrollTimer.IsEnabled)
			{
				this._horizontalAutoScrollTimer.Stop();
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000D745 File Offset: 0x0000B945
		protected void StopVerticalAutoScrollTimer()
		{
			if (this._verticalAutoScrollTimer != null && this._verticalAutoScrollTimer.IsEnabled)
			{
				this._verticalAutoScrollTimer.Stop();
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000D768 File Offset: 0x0000B968
		internal void ReleaseRootElementCapture()
		{
			global::System.Windows.FrameworkElement rootElement = this._selectionHost.RootElement;
			if (rootElement != null)
			{
				rootElement.ReleaseMouseCapture();
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000D78C File Offset: 0x0000B98C
		private void ForceSynchronousMouseMove()
		{
			if (global::Infragistics.Controls.Primitives.SelectionStrategyBase._IsMouseCaptured)
			{
				this._isReleasingMouseCapture = true;
				try
				{
					this.ReleaseRootElementCapture();
					this.CaptureMouseForRoot();
				}
				finally
				{
					this._isReleasingMouseCapture = false;
				}
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		private static global::Infragistics.Controls.Primitives.SelectionType? GetSelectionType(global::Infragistics.Controls.Primitives.SelectionStrategyBase strategy)
		{
			if (strategy is global::Infragistics.Controls.Primitives.SelectionStrategyContiguous)
			{
				return new global::Infragistics.Controls.Primitives.SelectionType?(global::Infragistics.Controls.Primitives.SelectionType.Range);
			}
			if (strategy is global::Infragistics.Controls.Primitives.SelectionStrategySingleAutoDrag)
			{
				return new global::Infragistics.Controls.Primitives.SelectionType?(global::Infragistics.Controls.Primitives.SelectionType.SingleAutoDrag);
			}
			if (strategy is global::Infragistics.Controls.Primitives.SelectionStrategySingle)
			{
				return new global::Infragistics.Controls.Primitives.SelectionType?(global::Infragistics.Controls.Primitives.SelectionType.Single);
			}
			if (strategy is global::Infragistics.Controls.Primitives.SelectionStrategyExtendedAutoDrag)
			{
				return new global::Infragistics.Controls.Primitives.SelectionType?(global::Infragistics.Controls.Primitives.SelectionType.ExtendedAutoDrag);
			}
			if (strategy is global::Infragistics.Controls.Primitives.SelectionStrategyExtended)
			{
				return new global::Infragistics.Controls.Primitives.SelectionType?(global::Infragistics.Controls.Primitives.SelectionType.Extended);
			}
			if (strategy is global::Infragistics.Controls.Primitives.SelectionStrategyNone)
			{
				return new global::Infragistics.Controls.Primitives.SelectionType?(global::Infragistics.Controls.Primitives.SelectionType.None);
			}
			return null;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000D840 File Offset: 0x0000BA40
		private void OnHorizontalAutoScrollTimerTick(object sender, global::System.EventArgs e)
		{
			this.StopHorizontalAutoScrollTimer();
			if (!global::Infragistics.Controls.Primitives.SelectionStrategyBase._IsMouseCaptured)
			{
				return;
			}
			global::Infragistics.Controls.Primitives.ISelectableItem currentSelectableItem = this.CurrentSelectableItem;
			if (currentSelectableItem != null)
			{
				this._selectionHost.DoAutoScrollHorizontal(currentSelectableItem, this._autoScrollManagerHorizontal.ScrollDirection, this._autoScrollManagerHorizontal.ScrollSpeed);
				this.ForceSynchronousMouseMove();
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000D890 File Offset: 0x0000BA90
		private void OnVerticalAutoScrollTimerTick(object sender, global::System.EventArgs e)
		{
			this.StopVerticalAutoScrollTimer();
			if (!global::Infragistics.Controls.Primitives.SelectionStrategyBase._IsMouseCaptured)
			{
				return;
			}
			global::Infragistics.Controls.Primitives.ISelectableItem currentSelectableItem = this.CurrentSelectableItem;
			if (currentSelectableItem != null)
			{
				this._selectionHost.DoAutoScrollVertical(currentSelectableItem, this._autoScrollManagerVertical.ScrollDirection, this._autoScrollManagerVertical.ScrollSpeed);
				this.ForceSynchronousMouseMove();
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000D8E0 File Offset: 0x0000BAE0
		private void SetupHorizontalAutoScrollTimer(double interval)
		{
			if (this._horizontalAutoScrollTimer == null)
			{
				this._horizontalAutoScrollTimer = new global::System.Windows.Threading.DispatcherTimer();
				this._horizontalAutoScrollTimer.Tick += this.OnHorizontalAutoScrollTimerTick;
			}
			if (interval != global::System.Convert.ToDouble(this._horizontalAutoScrollTimer.Interval.Milliseconds) || !this._horizontalAutoScrollTimer.IsEnabled)
			{
				this.StopHorizontalAutoScrollTimer();
				this._horizontalAutoScrollTimer.Interval = global::System.TimeSpan.FromMilliseconds(interval);
				this._horizontalAutoScrollTimer.Start();
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000D964 File Offset: 0x0000BB64
		private void SetupVerticalAutoScrollTimer(double interval)
		{
			if (this._verticalAutoScrollTimer == null)
			{
				this._verticalAutoScrollTimer = new global::System.Windows.Threading.DispatcherTimer();
				this._verticalAutoScrollTimer.Tick += this.OnVerticalAutoScrollTimerTick;
			}
			if (interval != global::System.Convert.ToDouble(this._verticalAutoScrollTimer.Interval.Milliseconds) || !this._verticalAutoScrollTimer.IsEnabled)
			{
				this.StopVerticalAutoScrollTimer();
				this._verticalAutoScrollTimer.Interval = global::System.TimeSpan.FromMilliseconds(interval);
				this._verticalAutoScrollTimer.Start();
			}
		}

		// Token: 0x04000192 RID: 402
		private global::Infragistics.Controls.Primitives.ISelectionHost _selectionHost;

		// Token: 0x04000193 RID: 403
		private global::System.Windows.Threading.DispatcherTimer _verticalAutoScrollTimer;

		// Token: 0x04000194 RID: 404
		private global::System.Windows.Threading.DispatcherTimer _horizontalAutoScrollTimer;

		// Token: 0x04000195 RID: 405
		private bool _inDragMode;

		// Token: 0x04000196 RID: 406
		private bool _ignoreNextMouseMove;

		// Token: 0x04000197 RID: 407
		private bool _isReleasingMouseCapture;

		// Token: 0x04000198 RID: 408
		private double _initialXPos;

		// Token: 0x04000199 RID: 409
		private double _initialYPos;

		// Token: 0x0400019A RID: 410
		private global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState _currentSelectionState;

		// Token: 0x0400019B RID: 411
		private global::System.WeakReference _currentSelectableItemRef;

		// Token: 0x0400019C RID: 412
		private global::Infragistics.Controls.Primitives.SelectionStrategyBase.AutoScrollManager _autoScrollManagerVertical;

		// Token: 0x0400019D RID: 413
		private global::Infragistics.Controls.Primitives.SelectionStrategyBase.AutoScrollManager _autoScrollManagerHorizontal;

		// Token: 0x0400019E RID: 414
		[global::System.ThreadStatic]
		private static bool _IsMouseCaptured;

		// Token: 0x0200003F RID: 63
		protected enum SelectionState
		{
			// Token: 0x040001A0 RID: 416
			SingleSelect,
			// Token: 0x040001A1 RID: 417
			PreDrag,
			// Token: 0x040001A2 RID: 418
			PreEdit,
			// Token: 0x040001A3 RID: 419
			PotentialPreDrag,
			// Token: 0x040001A4 RID: 420
			ExtSelect,
			// Token: 0x040001A5 RID: 421
			ControlClick
		}

		// Token: 0x02000040 RID: 64
		protected class AutoScrollManager
		{
			// Token: 0x060002D1 RID: 721 RVA: 0x0000D9E8 File Offset: 0x0000BBE8
			public AutoScrollManager(global::Infragistics.Controls.Primitives.SelectionStrategyBase selectionStrategy, global::Infragistics.Controls.Primitives.AutoScrollInfo autoScrollInfo, global::System.Windows.Input.MouseEventArgs mouseEventArgs, bool directionIsVertical)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(selectionStrategy, "selectionStrategy");
				global::Infragistics.CoreUtilities.ValidateNotNull(mouseEventArgs, "mouseEventArgs");
				this._selectionStrategy = selectionStrategy;
				this._autoScrollInfo = autoScrollInfo;
				this._mouseEventArgs = mouseEventArgs;
				this._directionIsVertical = directionIsVertical;
				this.Initialize();
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x0000DA34 File Offset: 0x0000BC34
			private double GetAutoScrollTimerInterval(int mouseThresholdAreaPenetration)
			{
				int num = this._directionIsVertical ? this._selectionStrategy.AutoScrollVerticalIntervalMax : this._selectionStrategy.AutoScrollHorizontalIntervalMax;
				int num2 = this._directionIsVertical ? this._selectionStrategy.AutoScrollVerticalIntervalMin : this._selectionStrategy.AutoScrollHorizontalIntervalMin;
				double num3 = global::System.Math.Log((double)(num / num2));
				double num4 = (double)mouseThresholdAreaPenetration / (this._directionIsVertical ? (global::System.Windows.SystemParameters.PrimaryScreenHeight * 0.4) : (global::System.Windows.SystemParameters.PrimaryScreenWidth * 0.4));
				num4 = global::System.Math.Abs(num4 * num3);
				double val = (double)num / global::System.Math.Pow(2.718281828459045, num4);
				val = global::System.Math.Min(val, (double)num);
				return global::System.Math.Max(val, (double)num2);
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x0000DAF0 File Offset: 0x0000BCF0
			private int GetMouseThresholdAreaPenetration()
			{
				int num = this.GetMouseThresholdAreaPenetration(this._directionIsVertical);
				if (num != 0 && this._autoScrollInfo.ScrollOrientation != global::Infragistics.Controls.Primitives.ScrollOrientation.Both)
				{
					int mouseThresholdAreaPenetration = this.GetMouseThresholdAreaPenetration(!this._directionIsVertical);
					if (mouseThresholdAreaPenetration != 0)
					{
						switch (this._autoScrollInfo.ScrollOrientation)
						{
						case global::Infragistics.Controls.Primitives.ScrollOrientation.Horizontal:
							if (this._directionIsVertical)
							{
								num = 0;
							}
							break;
						case global::Infragistics.Controls.Primitives.ScrollOrientation.Vertical:
							if (!this._directionIsVertical)
							{
								num = 0;
							}
							break;
						case global::Infragistics.Controls.Primitives.ScrollOrientation.BasedOnDistance:
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

			// Token: 0x060002D4 RID: 724 RVA: 0x0000DB94 File Offset: 0x0000BD94
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

			// Token: 0x060002D5 RID: 725 RVA: 0x0000DCB4 File Offset: 0x0000BEB4
			private global::Infragistics.Controls.Primitives.ScrollSpeed GetScrollSpeedFromTimerInterval(double timerInterval)
			{
				double num;
				double num2;
				if (this._directionIsVertical)
				{
					num = (double)this._selectionStrategy.AutoScrollVerticalIntervalMin;
					num2 = (double)this._selectionStrategy.AutoScrollVerticalIntervalMax;
				}
				else
				{
					num = (double)this._selectionStrategy.AutoScrollHorizontalIntervalMin;
					num2 = (double)this._selectionStrategy.AutoScrollHorizontalIntervalMax;
				}
				if (timerInterval <= num)
				{
					return global::Infragistics.Controls.Primitives.ScrollSpeed.Slowest;
				}
				if (timerInterval >= num2)
				{
					return global::Infragistics.Controls.Primitives.ScrollSpeed.Fastest;
				}
				double num3 = (timerInterval - num) / (num2 - num);
				if (num3 < 0.14)
				{
					return global::Infragistics.Controls.Primitives.ScrollSpeed.Fastest;
				}
				if (num3 < 0.28)
				{
					return global::Infragistics.Controls.Primitives.ScrollSpeed.Faster;
				}
				if (num3 < 0.42)
				{
					return global::Infragistics.Controls.Primitives.ScrollSpeed.Fast;
				}
				if (num3 < 0.56)
				{
					return global::Infragistics.Controls.Primitives.ScrollSpeed.Medium;
				}
				if (num3 < 0.7)
				{
					return global::Infragistics.Controls.Primitives.ScrollSpeed.Slow;
				}
				if (num3 < 0.84)
				{
					return global::Infragistics.Controls.Primitives.ScrollSpeed.Slower;
				}
				return global::Infragistics.Controls.Primitives.ScrollSpeed.Slowest;
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x0000DD68 File Offset: 0x0000BF68
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
				global::System.Windows.Media.GeneralTransform generalTransform = this._autoScrollInfo.ScrollArea.TransformToVisual(this._selectionStrategy.SelectionHost.RootElement);
				this._scrollAreaRect = new global::System.Windows.Rect(generalTransform.Transform(new global::System.Windows.Point(0.0, 0.0)), new global::System.Windows.Size(this._autoScrollInfo.ScrollArea.ActualWidth, this._autoScrollInfo.ScrollArea.ActualHeight));
				this._scrollAreaInnerRect = this._scrollAreaRect;
				this._scrollAreaInnerRect.X = this._scrollAreaInnerRect.X + (double)this._selectionStrategy.PixelThresholdForHorizontalAutoScroll;
				this._scrollAreaInnerRect.Y = this._scrollAreaInnerRect.Y + (double)this._selectionStrategy.PixelThresholdForVerticalAutoScroll;
				this._scrollAreaInnerRect.Width = global::System.Math.Max(this._scrollAreaInnerRect.Width - (double)(2 * this._selectionStrategy.PixelThresholdForHorizontalAutoScroll), 0.0);
				this._scrollAreaInnerRect.Height = global::System.Math.Max(this._scrollAreaInnerRect.Height - (double)(2 * this._selectionStrategy.PixelThresholdForVerticalAutoScroll), 0.0);
				this._mousePosition = this._selectionStrategy.GetMousePointInRootElementCoordinates(this._mouseEventArgs);
				if (this._scrollAreaInnerRect.Contains(this._mousePosition))
				{
					this._isScrollingRequired = false;
					return;
				}
				this._timerInterval = -1.0;
				int mouseThresholdAreaPenetration = this.GetMouseThresholdAreaPenetration();
				if (mouseThresholdAreaPenetration != 0)
				{
					this._timerInterval = this.GetAutoScrollTimerInterval(global::System.Math.Abs(mouseThresholdAreaPenetration));
				}
				if (this._timerInterval != -1.0)
				{
					this._isScrollingRequired = true;
					this._scrollDirection = ((mouseThresholdAreaPenetration < 0) ? global::Infragistics.Controls.Primitives.ScrollDirection.Decrement : global::Infragistics.Controls.Primitives.ScrollDirection.Increment);
					this._scrollSpeed = this.GetScrollSpeedFromTimerInterval(this._timerInterval);
					return;
				}
				this._isScrollingRequired = false;
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000DF7A File Offset: 0x0000C17A
			public bool IsScrollingRequired
			{
				get
				{
					return this._isScrollingRequired;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000DF82 File Offset: 0x0000C182
			public global::Infragistics.Controls.Primitives.ScrollDirection ScrollDirection
			{
				get
				{
					return this._scrollDirection;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000DF8A File Offset: 0x0000C18A
			public global::Infragistics.Controls.Primitives.ScrollSpeed ScrollSpeed
			{
				get
				{
					return this._scrollSpeed;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060002DA RID: 730 RVA: 0x0000DF92 File Offset: 0x0000C192
			public double TimerInterval
			{
				get
				{
					return this._timerInterval;
				}
			}

			// Token: 0x040001A6 RID: 422
			private global::Infragistics.Controls.Primitives.SelectionStrategyBase _selectionStrategy;

			// Token: 0x040001A7 RID: 423
			private global::Infragistics.Controls.Primitives.AutoScrollInfo _autoScrollInfo;

			// Token: 0x040001A8 RID: 424
			private global::System.Windows.Input.MouseEventArgs _mouseEventArgs;

			// Token: 0x040001A9 RID: 425
			private bool _directionIsVertical;

			// Token: 0x040001AA RID: 426
			private bool _isScrollingRequired;

			// Token: 0x040001AB RID: 427
			private global::Infragistics.Controls.Primitives.ScrollDirection _scrollDirection;

			// Token: 0x040001AC RID: 428
			private global::Infragistics.Controls.Primitives.ScrollSpeed _scrollSpeed;

			// Token: 0x040001AD RID: 429
			private double _timerInterval;

			// Token: 0x040001AE RID: 430
			private global::System.Windows.Rect _scrollAreaRect;

			// Token: 0x040001AF RID: 431
			private global::System.Windows.Rect _scrollAreaInnerRect;

			// Token: 0x040001B0 RID: 432
			private global::System.Windows.Point _mousePosition;
		}
	}
}
