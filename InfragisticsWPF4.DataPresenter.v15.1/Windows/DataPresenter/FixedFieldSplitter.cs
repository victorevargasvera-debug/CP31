using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000169 RID: 361
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FixedFieldSplitter : global::System.Windows.Controls.Primitives.Thumb
	{
		// Token: 0x06001670 RID: 5744 RVA: 0x00063820 File Offset: 0x00061A20
		static FixedFieldSplitter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter)));
			global::System.Windows.Input.Cursor defaultValue = global::Infragistics.Windows.Utilities.LoadCursor(typeof(global::Infragistics.Windows.Utilities), "ResourceSets/Cursors/verticalSplitter.cur") ?? global::System.Windows.Input.Cursors.SizeWE;
			global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.VerticalCursorProperty = global::System.Windows.DependencyProperty.Register("VerticalCursor", typeof(global::System.Windows.Input.Cursor), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(defaultValue));
			global::System.Windows.Input.Cursor defaultValue2 = global::Infragistics.Windows.Utilities.LoadCursor(typeof(global::Infragistics.Windows.Utilities), "ResourceSets/Cursors/horizontalSplitter.cur") ?? global::System.Windows.Input.Cursors.SizeNS;
			global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.HorizontalCursorProperty = global::System.Windows.DependencyProperty.Register("HorizontalCursor", typeof(global::System.Windows.Input.Cursor), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(defaultValue2));
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00063A09 File Offset: 0x00061C09
		public FixedFieldSplitter()
		{
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00063A11 File Offset: 0x00061C11
		internal FixedFieldSplitter(bool isInHeader, global::System.Windows.Controls.Orientation orientation, global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType splitterType) : this()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsInHeaderPropertyKey, global::Infragistics.KnownBoxes.FromValue(isInHeader));
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.OrientationPropertyKey, global::Infragistics.KnownBoxes.FromValue(orientation));
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterTypePropertyKey, splitterType);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00063A4C File Offset: 0x00061C4C
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.FixedFieldSplitterAutomationPeer(this);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00063A54 File Offset: 0x00061C54
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			base.DragStarted += this.OnDragStarted;
			base.DragDelta += this.OnDragDelta;
			base.DragCompleted += this.OnDragCompleted;
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), true) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (virtualizingDataRecordCellPanel != null) ? virtualizingDataRecordCellPanel.FieldLayout : null;
			if (fieldLayout != null)
			{
				global::System.Windows.DependencyProperty dp = (this.SplitterType == global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Far) ? global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverFarSplitterProperty : global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverNearSplitterProperty;
				base.SetBinding(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsOverAnySplitterProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(dp, global::System.Windows.Data.BindingMode.OneWay, fieldLayout));
			}
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00063AEF File Offset: 0x00061CEF
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnMouseEnterLeave(true);
			base.OnMouseEnter(e);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00063AFF File Offset: 0x00061CFF
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnMouseEnterLeave(false);
			base.OnMouseLeave(e);
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x00063B0F File Offset: 0x00061D0F
		// (set) Token: 0x06001678 RID: 5752 RVA: 0x00063B21 File Offset: 0x00061D21
		public global::System.Windows.Input.Cursor HorizontalCursor
		{
			get
			{
				return (global::System.Windows.Input.Cursor)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.HorizontalCursorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.HorizontalCursorProperty, value);
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x00063B2F File Offset: 0x00061D2F
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsHighlighted
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsHighlightedProperty);
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00063B41 File Offset: 0x00061D41
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsInHeader
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsInHeaderProperty);
			}
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00063B53 File Offset: 0x00061D53
		internal void SetIsInHeader(bool value)
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsInHeaderPropertyKey, value);
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x00063B66 File Offset: 0x00061D66
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.OrientationProperty);
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x00063B78 File Offset: 0x00061D78
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType SplitterType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterTypeProperty);
			}
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00063B8A File Offset: 0x00061D8A
		internal void SetSplitterType(global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType value)
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterTypePropertyKey, value);
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00063B9D File Offset: 0x00061D9D
		// (set) Token: 0x06001680 RID: 5760 RVA: 0x00063BAF File Offset: 0x00061DAF
		public global::System.Windows.Input.Cursor VerticalCursor
		{
			get
			{
				return (global::System.Windows.Input.Cursor)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.VerticalCursorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.VerticalCursorProperty, value);
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00063BBD File Offset: 0x00061DBD
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				if (this._dragInfo.fieldLayout == null)
				{
					this._dragInfo.fieldLayout = this.VirtualizingDataRecordCellPanel.FieldLayout;
				}
				return this._dragInfo.fieldLayout;
			}
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00063BED File Offset: 0x00061DED
		private static void OnIsOverAnySplitterChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsHighlightedPropertyKey, e.NewValue);
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x00063C01 File Offset: 0x00061E01
		internal global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel VirtualizingDataRecordCellPanel
		{
			get
			{
				if (this._dragInfo.virtualizingDataRecordCellPanel == null)
				{
					this._dragInfo.virtualizingDataRecordCellPanel = (base.Parent as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel);
				}
				return this._dragInfo.virtualizingDataRecordCellPanel;
			}
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00063C34 File Offset: 0x00061E34
		private void AddDropLocations(global::Infragistics.Windows.DataPresenter.FixedFieldLocation currentLocation, global::Infragistics.Windows.DataPresenter.FixedFieldLocation newLocation)
		{
			if (this._dragInfo == null || this._dragInfo.virtualCellInfos == null || this._dragInfo.virtualizingDataRecordCellPanel == null)
			{
				return;
			}
			if (this._dragInfo.dropInfos == null)
			{
				this._dragInfo.dropInfos = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo>();
			}
			global::System.Windows.Controls.Orientation orientation = this.Orientation;
			global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode splitterMode;
			global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection splitterDragDirection;
			if (this.SplitterType == global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Near)
			{
				if (newLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
				{
					splitterMode = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsUnfixingNear;
					splitterDragDirection = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection.TowardsNearEdge;
				}
				else
				{
					splitterMode = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsFixingNear;
					splitterDragDirection = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection.TowardsFarEdge;
				}
			}
			else if (newLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
			{
				splitterMode = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsUnfixingFar;
				splitterDragDirection = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection.TowardsFarEdge;
			}
			else
			{
				splitterMode = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsFixingFar;
				splitterDragDirection = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection.TowardsNearEdge;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VirtualCellInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VirtualCellInfo>();
			foreach (global::Infragistics.Windows.DataPresenter.VirtualCellInfo virtualCellInfo in this._dragInfo.virtualCellInfos)
			{
				if (virtualCellInfo.FixedLocation == currentLocation && virtualCellInfo.Field.IsFixedLocationAllowed(newLocation))
				{
					list.Add(virtualCellInfo);
				}
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo>();
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.VirtualCellInfo virtualCellInfo2 = list[i];
				global::System.Windows.Rect clipRect = virtualCellInfo2.ClipRect;
				double num;
				double splitterPosition;
				double midPt;
				if (orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					num = clipRect.Left;
					splitterPosition = clipRect.Right;
					midPt = num + (clipRect.Right - clipRect.Left) / 2.0;
				}
				else
				{
					num = clipRect.Top;
					splitterPosition = clipRect.Bottom;
					midPt = num + (clipRect.Bottom - clipRect.Top) / 2.0;
				}
				global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo splitterDropInfo = new global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo();
				splitterDropInfo.midPt = midPt;
				splitterDropInfo.dragDirection = splitterDragDirection;
				if (splitterDragDirection == global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection.TowardsNearEdge)
				{
					splitterDropInfo.splitterPosition = num;
				}
				else
				{
					splitterDropInfo.splitterPosition = splitterPosition;
				}
				list2.Add(splitterDropInfo);
				i++;
			}
			if (list2.Count > 1)
			{
				list2.Sort(global::Infragistics.CoreUtilities.CreateComparer<global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo>(new global::System.Comparison<global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo>(this.CompareDropInfos)));
				list2.Reverse();
				double splitterPosition2 = list2[list2.Count - 1].splitterPosition;
				for (int j = list2.Count - 2; j >= 0; j--)
				{
					global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo splitterDropInfo2 = list2[j];
					if (splitterDropInfo2.splitterPosition == splitterPosition2)
					{
						list2.RemoveAt(j);
					}
					else
					{
						splitterPosition2 = splitterDropInfo2.splitterPosition;
					}
				}
			}
			foreach (global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo splitterDropInfo3 in list2)
			{
				double splitterPosition3 = splitterDropInfo3.splitterPosition;
				global::System.Windows.Rect affectedFieldsRect = this.GetAffectedFieldsRect(splitterMode, splitterPosition3);
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list3 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
				foreach (global::Infragistics.Windows.DataPresenter.VirtualCellInfo virtualCellInfo3 in list)
				{
					if (!affectedFieldsRect.IsEmpty && global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.DoesRectContainRect(affectedFieldsRect, virtualCellInfo3.ClipRect))
					{
						list3.Add(virtualCellInfo3.Field);
					}
				}
				if (list3.Count != 0)
				{
					if (newLocation != global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
					{
						bool flag;
						double num2 = this._dragInfo.virtualizingDataRecordCellPanel.CalculateSplitterLayout(list3, this.SplitterType, out flag);
						if ((flag && num2 <= 40.0) || (!flag && num2 < 0.0))
						{
							continue;
						}
					}
					splitterDropInfo3.affectedFields = list3;
					this._dragInfo.dropInfos.Add(splitterDropInfo3);
				}
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00063F94 File Offset: 0x00062194
		private void CancelDragStarted()
		{
			this._dragInfo = null;
			if (base.IsMouseCaptured)
			{
				base.ReleaseMouseCapture();
				return;
			}
			if (base.IsDragging)
			{
				base.CancelDrag();
			}
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00063FBC File Offset: 0x000621BC
		private int CompareDropInfos(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo x, global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo y)
		{
			if (x == y)
			{
				return 0;
			}
			int num = x.splitterPosition.CompareTo(y.splitterPosition);
			if (num == 0 && x.midPt != y.midPt)
			{
				num = x.midPt.CompareTo(y.midPt);
				if (x.dragDirection == global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection.TowardsFarEdge)
				{
					num = ((num == 1) ? -1 : 1);
				}
			}
			return num;
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00064018 File Offset: 0x00062218
		private void CreateFixedAreaElementAdorner(global::System.Windows.FrameworkElement fixedAreaElement)
		{
			this._dragInfo.fixedAreaElementAdorner = new global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.FixedAreaElementAdorner(fixedAreaElement);
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(fixedAreaElement);
			if (adornerLayer != null)
			{
				adornerLayer.Add(this._dragInfo.fixedAreaElementAdorner);
			}
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00064054 File Offset: 0x00062254
		private bool CreateSplitterPreviewRectangleInAdornerLayer()
		{
			global::System.Windows.Shapes.Rectangle rectangle = new global::System.Windows.Shapes.Rectangle();
			rectangle.Opacity = 0.18;
			rectangle.Fill = global::System.Windows.Media.Brushes.Black;
			if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				rectangle.Height = this._dragInfo.fixedFieldInfo.FixedAreaElement.ActualHeight;
				rectangle.Width = base.ActualWidth;
				global::System.Windows.Controls.Canvas.SetTop(rectangle, 0.0);
				global::System.Windows.Controls.Canvas.SetLeft(rectangle, this.TranslateLeftCoordinate(this, this._dragInfo.fixedFieldInfo.FixedAreaElement, 0.0, true));
			}
			else
			{
				rectangle.Height = base.ActualHeight;
				rectangle.Width = this._dragInfo.fixedFieldInfo.FixedAreaElement.ActualWidth;
				global::System.Windows.Controls.Canvas.SetLeft(rectangle, 0.0);
				global::System.Windows.Controls.Canvas.SetTop(rectangle, this.TranslateTopCoordinate(this, this._dragInfo.fixedFieldInfo.FixedAreaElement, 0.0, true));
			}
			this.CreateFixedAreaElementAdorner(this._dragInfo.fixedFieldInfo.FixedAreaElement);
			if (this._dragInfo.fixedAreaElementAdorner == null)
			{
				this._dragInfo = null;
				return false;
			}
			this._dragInfo.fixedAreaElementAdorner.AddChildElement(rectangle);
			this._dragInfo.splitterPreview = rectangle;
			return true;
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00064190 File Offset: 0x00062390
		private static bool DoesRectContainRect(global::System.Windows.Rect containingRect, global::System.Windows.Rect containedRect)
		{
			return (containingRect.X <= containedRect.X || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(containingRect.X, containedRect.X)) && (containingRect.Y <= containedRect.Y || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(containingRect.Y, containedRect.Y)) && (containingRect.X + containingRect.Width >= containedRect.X + containedRect.Width || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(containingRect.X + containingRect.Width, containedRect.X + containedRect.Width)) && (containingRect.Y + containingRect.Height >= containedRect.Y + containedRect.Height || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(containingRect.Y + containingRect.Height, containedRect.Y + containedRect.Height));
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x0006427C File Offset: 0x0006247C
		private global::System.Windows.Rect GetAffectedFieldsRect(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode splitterMode, double nearestCellEdge)
		{
			global::System.Windows.Rect scrollableAreaRect = this.VirtualizingDataRecordCellPanel.ScrollableAreaRect;
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				switch (splitterMode)
				{
				case global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsFixingNear:
				case global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsUnfixingFar:
					num = scrollableAreaRect.Left;
					num2 = scrollableAreaRect.Top;
					num3 = nearestCellEdge - num;
					num4 = scrollableAreaRect.Height;
					break;
				case global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsFixingFar:
				case global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsUnfixingNear:
					num = nearestCellEdge;
					num2 = scrollableAreaRect.Top;
					num3 = scrollableAreaRect.Right - nearestCellEdge;
					num4 = scrollableAreaRect.Height;
					break;
				}
			}
			else
			{
				switch (splitterMode)
				{
				case global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsFixingNear:
				case global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsUnfixingFar:
					num = scrollableAreaRect.Left;
					num2 = scrollableAreaRect.Top;
					num3 = scrollableAreaRect.Width;
					num4 = nearestCellEdge - num2;
					break;
				case global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsFixingFar:
				case global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsUnfixingNear:
					num = scrollableAreaRect.Left;
					num2 = nearestCellEdge;
					num3 = scrollableAreaRect.Width;
					num4 = scrollableAreaRect.Bottom - nearestCellEdge;
					break;
				}
			}
			num3 = global::System.Math.Max(num3, 0.0);
			num4 = global::System.Math.Max(num4, 0.0);
			if (num != 0.0 && num2 != 0.0 && num3 != 0.0 && num4 != 0.0)
			{
				return global::System.Windows.Rect.Empty;
			}
			return new global::System.Windows.Rect(num, num2, num3, num4);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x000643E4 File Offset: 0x000625E4
		private double GetOtherSplitterPosInVDRCPCoords()
		{
			if (this.SplitterType == global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Near)
			{
				if (this.VirtualizingDataRecordCellPanel.FarSplitter == null || this.VirtualizingDataRecordCellPanel.FarSplitter.Visibility != global::System.Windows.Visibility.Visible)
				{
					return double.NaN;
				}
				if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					return this.TranslateLeftCoordinate(this.VirtualizingDataRecordCellPanel.FarSplitter, this.VirtualizingDataRecordCellPanel, 0.0, true);
				}
				return this.TranslateTopCoordinate(this.VirtualizingDataRecordCellPanel.FarSplitter, this.VirtualizingDataRecordCellPanel, 0.0, true);
			}
			else
			{
				if (this.VirtualizingDataRecordCellPanel.NearSplitter == null || this.VirtualizingDataRecordCellPanel.NearSplitter.Visibility != global::System.Windows.Visibility.Visible)
				{
					return double.NaN;
				}
				if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					return this.TranslateLeftCoordinate(this.VirtualizingDataRecordCellPanel.NearSplitter, this.VirtualizingDataRecordCellPanel, this.VirtualizingDataRecordCellPanel.NearSplitter.ActualWidth, true);
				}
				return this.TranslateTopCoordinate(this.VirtualizingDataRecordCellPanel.NearSplitter, this.VirtualizingDataRecordCellPanel, this.VirtualizingDataRecordCellPanel.NearSplitter.ActualHeight, true);
			}
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x000644F2 File Offset: 0x000626F2
		private void OnDragCompleted(object sender, global::System.Windows.Controls.Primitives.DragCompletedEventArgs e)
		{
			this.ProcessOnDragCompleted();
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x000644FC File Offset: 0x000626FC
		private void ProcessOnDragCompleted()
		{
			if (this._dragInfo == null)
			{
				return;
			}
			this._dragInfo.fixedAreaElementAdorner.RemoveChildElement(this._dragInfo.splitterPreview);
			this.RemoveFixedAreaElementAdorner(this._dragInfo.fixedFieldInfo.FixedAreaElement);
			if (this._dragInfo.affectedFields.Count > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this._dragInfo.affectedFields)
				{
					field.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsFixedStateChangingPropertyKey, false);
				}
				this.VirtualizingDataRecordCellPanel.ProcessFixedFieldSplitterAction(this._dragInfo.affectedFields, this.SplitterType);
			}
			this._dragInfo = null;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x000645D0 File Offset: 0x000627D0
		private void OnDragDelta(object sender, global::System.Windows.Controls.Primitives.DragDeltaEventArgs e)
		{
			this.ProcessOnDragDelta(e.HorizontalChange, e.VerticalChange);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x000645E4 File Offset: 0x000627E4
		private void ProcessOnDragDelta(double horizontalChange, double verticalChange)
		{
			if (this._dragInfo == null)
			{
				return;
			}
			if (this._dragInfo.splitterPreview == null || this._dragInfo.fixedFieldInfo == null)
			{
				return;
			}
			if (this._dragInfo.dropInfos == null)
			{
				return;
			}
			double num;
			if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				num = horizontalChange;
			}
			else
			{
				num = verticalChange;
			}
			global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode splitterMode;
			if (this.SplitterType == global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Near)
			{
				if (num > 0.0)
				{
					splitterMode = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsFixingNear;
				}
				else
				{
					splitterMode = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsUnfixingNear;
				}
			}
			else if (num > 0.0)
			{
				splitterMode = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsUnfixingFar;
			}
			else
			{
				splitterMode = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsFixingFar;
			}
			global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection splitterDragDirection;
			if (num < 0.0)
			{
				splitterDragDirection = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection.TowardsNearEdge;
			}
			else
			{
				splitterDragDirection = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection.TowardsFarEdge;
			}
			double num2;
			if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				num2 = this.TranslateLeftCoordinate(this, this.VirtualizingDataRecordCellPanel, horizontalChange, true);
			}
			else
			{
				num2 = this.TranslateTopCoordinate(this, this.VirtualizingDataRecordCellPanel, verticalChange, true);
			}
			double num3 = double.NaN;
			switch (splitterMode)
			{
			case global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsFixingNear:
				new global::Infragistics.Windows.DataPresenter.FixedFieldLocation?(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge);
				break;
			case global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsFixingFar:
				new global::Infragistics.Windows.DataPresenter.FixedFieldLocation?(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge);
				break;
			case global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsUnfixingNear:
			case global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterMode.IsUnfixingFar:
				new global::Infragistics.Windows.DataPresenter.FixedFieldLocation?(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable);
				break;
			}
			double num4 = (this.Orientation == global::System.Windows.Controls.Orientation.Vertical) ? this.TranslateLeftCoordinate(this, this.VirtualizingDataRecordCellPanel, 0.0, true) : this.TranslateTopCoordinate(this, this.VirtualizingDataRecordCellPanel, 0.0, true);
			global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo splitterDropInfo = null;
			foreach (global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo splitterDropInfo2 in this._dragInfo.dropInfos)
			{
				if (splitterDragDirection == global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection.TowardsNearEdge)
				{
					if (splitterDropInfo2.midPt < num4 && splitterDropInfo2.midPt > num2 && (double.IsNaN(num3) || splitterDropInfo2.splitterPosition < num3))
					{
						num3 = splitterDropInfo2.splitterPosition;
						splitterDropInfo = splitterDropInfo2;
					}
				}
				else if (splitterDropInfo2.midPt > num4 && splitterDropInfo2.midPt < num2 && (double.IsNaN(num3) || splitterDropInfo2.splitterPosition > num3))
				{
					num3 = splitterDropInfo2.splitterPosition;
					splitterDropInfo = splitterDropInfo2;
				}
			}
			if (splitterDropInfo == null)
			{
				num3 = num4;
			}
			if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				global::System.Windows.Controls.Canvas.SetLeft(this._dragInfo.splitterPreview, this.TranslateLeftCoordinate(this.VirtualizingDataRecordCellPanel, this._dragInfo.fixedAreaElementAdorner, num3, true));
			}
			else
			{
				global::System.Windows.Controls.Canvas.SetTop(this._dragInfo.splitterPreview, this.TranslateTopCoordinate(this.VirtualizingDataRecordCellPanel, this._dragInfo.fixedAreaElementAdorner, num3, true));
			}
			this._dragInfo.fixedAreaElementAdorner.InvalidateArrange();
			this._dragInfo.fixedAreaElementAdorner.UpdateLayout();
			this._dragInfo.affectedFields.Clear();
			foreach (global::Infragistics.Windows.DataPresenter.VirtualCellInfo virtualCellInfo in this._dragInfo.virtualCellInfos)
			{
				if (splitterDropInfo != null && splitterDropInfo.affectedFields.Contains(virtualCellInfo.Field))
				{
					virtualCellInfo.Field.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsFixedStateChangingPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					virtualCellInfo.Field.ClearValue(global::Infragistics.Windows.DataPresenter.Field.IsFixedStateChangingPropertyKey);
				}
			}
			if (splitterDropInfo != null)
			{
				this._dragInfo.affectedFields.AddRange(splitterDropInfo.affectedFields);
			}
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00064918 File Offset: 0x00062B18
		private void OnDragStarted(object sender, global::System.Windows.Controls.Primitives.DragStartedEventArgs e)
		{
			if (!this.ProcessOnDragStarted())
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00064938 File Offset: 0x00062B38
		private bool ProcessOnDragStarted()
		{
			if (this._dragInfo != null)
			{
				return false;
			}
			this._dragInfo = new global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.FixedFieldSplitterDragInfo();
			if (this.VirtualizingDataRecordCellPanel == null || this.FieldLayout == null)
			{
				this.CancelDragStarted();
				return false;
			}
			this._dragInfo.fixedFieldInfo = null;
			if (this.FieldLayout.DataPresenter != null && this.FieldLayout.DataPresenter.CurrentViewInternal != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = null;
				if (!this.VirtualizingDataRecordCellPanel.IsHeaderArea)
				{
					recordPresenter = this.VirtualizingDataRecordCellPanel.Record.AssociatedRecordPresenter;
				}
				if (recordPresenter == null)
				{
					recordPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this.VirtualizingDataRecordCellPanel, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
				}
				if (recordPresenter != null)
				{
					this._dragInfo.fixedFieldInfo = this.FieldLayout.DataPresenter.CurrentViewInternal.GetFixedFieldInfo(recordPresenter);
				}
			}
			if (this._dragInfo.fixedFieldInfo == null || this._dragInfo.fixedFieldInfo.FixedAreaElement == null)
			{
				this.CancelDragStarted();
				return false;
			}
			if (!this.FieldLayout.DataPresenter.EndEditMode(true, false))
			{
				this.CancelDragStarted();
				return false;
			}
			this._dragInfo.virtualCellInfos = this.VirtualizingDataRecordCellPanel.GetCellInfo(true);
			this._dragInfo.affectedFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			if (!this.CreateSplitterPreviewRectangleInAdornerLayer())
			{
				this.CancelDragStarted();
				return false;
			}
			this._dragInfo.dropInfos = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo>();
			global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation = (this.SplitterType == global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Far) ? global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge : global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge;
			this.AddDropLocations(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable, fixedFieldLocation);
			this.AddDropLocations(fixedFieldLocation, global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable);
			return this._dragInfo.dropInfos.Count > 0;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00064ABC File Offset: 0x00062CBC
		private void OnMouseEnterLeave(bool enter)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), true) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (virtualizingDataRecordCellPanel != null) ? virtualizingDataRecordCellPanel.FieldLayout : null;
			if (fieldLayout != null)
			{
				global::System.Windows.DependencyProperty dp = (this.SplitterType == global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Far) ? global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverFarSplitterProperty : global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverNearSplitterProperty;
				fieldLayout.SetCurrentValue(dp, enter ? global::Infragistics.KnownBoxes.TrueBox : global::Infragistics.KnownBoxes.FalseBox);
			}
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00064B1C File Offset: 0x00062D1C
		internal void PerformMove(double x, double y)
		{
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointFromScreenSafe(this, new global::System.Windows.Point(x, y));
			if (this.ProcessOnDragStarted())
			{
				this.ProcessOnDragDelta(point.X, point.Y);
				this.ProcessOnDragCompleted();
			}
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00064B5C File Offset: 0x00062D5C
		private void RemoveFixedAreaElementAdorner(global::System.Windows.FrameworkElement fixedAreaElement)
		{
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(fixedAreaElement);
			if (adornerLayer != null)
			{
				adornerLayer.Remove(this._dragInfo.fixedAreaElementAdorner);
			}
			this._dragInfo.fixedAreaElementAdorner = null;
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00064B90 File Offset: 0x00062D90
		private double TranslateLeftCoordinate(global::System.Windows.FrameworkElement from, global::System.Windows.FrameworkElement relativeTo, double left, bool constrainToBounds)
		{
			global::System.Windows.Point point = new global::System.Windows.Point(left, 0.0);
			double num = from.TranslatePoint(point, relativeTo).X;
			if (constrainToBounds)
			{
				num = global::System.Math.Min(global::System.Math.Max(num, 0.0), relativeTo.ActualWidth - base.ActualWidth);
			}
			return num;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00064BE8 File Offset: 0x00062DE8
		private double TranslateTopCoordinate(global::System.Windows.FrameworkElement from, global::System.Windows.FrameworkElement relativeTo, double top, bool constrainToBounds)
		{
			global::System.Windows.Point point = new global::System.Windows.Point(0.0, top);
			double num = from.TranslatePoint(point, relativeTo).Y;
			if (constrainToBounds)
			{
				num = global::System.Math.Min(global::System.Math.Max(num, 0.0), relativeTo.ActualHeight - base.ActualHeight);
			}
			return num;
		}

		// Token: 0x040008DD RID: 2269
		private global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.FixedFieldSplitterDragInfo _dragInfo;

		// Token: 0x040008DE RID: 2270
		public static readonly global::System.Windows.DependencyProperty HorizontalCursorProperty;

		// Token: 0x040008DF RID: 2271
		private static readonly global::System.Windows.DependencyPropertyKey IsHighlightedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsHighlighted", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040008E0 RID: 2272
		public static readonly global::System.Windows.DependencyProperty IsHighlightedProperty = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsHighlightedPropertyKey.DependencyProperty;

		// Token: 0x040008E1 RID: 2273
		private static readonly global::System.Windows.DependencyPropertyKey IsInHeaderPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsInHeader", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(false));

		// Token: 0x040008E2 RID: 2274
		public static readonly global::System.Windows.DependencyProperty IsInHeaderProperty = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsInHeaderPropertyKey.DependencyProperty;

		// Token: 0x040008E3 RID: 2275
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.OrientationVerticalBox));

		// Token: 0x040008E4 RID: 2276
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.OrientationPropertyKey.DependencyProperty;

		// Token: 0x040008E5 RID: 2277
		private static readonly global::System.Windows.DependencyPropertyKey SplitterTypePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SplitterType", typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Near));

		// Token: 0x040008E6 RID: 2278
		public static readonly global::System.Windows.DependencyProperty SplitterTypeProperty = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterTypePropertyKey.DependencyProperty;

		// Token: 0x040008E7 RID: 2279
		public static readonly global::System.Windows.DependencyProperty VerticalCursorProperty;

		// Token: 0x040008E8 RID: 2280
		private static readonly global::System.Windows.DependencyProperty IsOverAnySplitterProperty = global::System.Windows.DependencyProperty.Register("IsOverAnySplitter", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.OnIsOverAnySplitterChanged)));

		// Token: 0x0200016A RID: 362
		private class FixedFieldSplitterDragInfo
		{
			// Token: 0x06001697 RID: 5783 RVA: 0x00064C3E File Offset: 0x00062E3E
			internal FixedFieldSplitterDragInfo()
			{
			}

			// Token: 0x040008E9 RID: 2281
			internal global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel;

			// Token: 0x040008EA RID: 2282
			internal global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout;

			// Token: 0x040008EB RID: 2283
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VirtualCellInfo> virtualCellInfos;

			// Token: 0x040008EC RID: 2284
			internal global::Infragistics.Windows.DataPresenter.FixedFieldInfo fixedFieldInfo;

			// Token: 0x040008ED RID: 2285
			internal global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.FixedAreaElementAdorner fixedAreaElementAdorner;

			// Token: 0x040008EE RID: 2286
			internal global::System.Windows.Shapes.Rectangle splitterPreview;

			// Token: 0x040008EF RID: 2287
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> affectedFields;

			// Token: 0x040008F0 RID: 2288
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo> dropInfos;
		}

		// Token: 0x0200016B RID: 363
		private class SplitterDropInfo
		{
			// Token: 0x040008F1 RID: 2289
			internal double midPt;

			// Token: 0x040008F2 RID: 2290
			internal double splitterPosition;

			// Token: 0x040008F3 RID: 2291
			internal global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection dragDirection;

			// Token: 0x040008F4 RID: 2292
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> affectedFields;
		}

		// Token: 0x0200016C RID: 364
		private class FixedAreaElementAdorner : global::Infragistics.Windows.Internal.AdornerEx
		{
			// Token: 0x06001699 RID: 5785 RVA: 0x00064C4E File Offset: 0x00062E4E
			internal FixedAreaElementAdorner(global::System.Windows.FrameworkElement fixedAreaElement) : base(fixedAreaElement)
			{
			}

			// Token: 0x0600169A RID: 5786 RVA: 0x00064C58 File Offset: 0x00062E58
			protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
			{
				if (this.Children.Count > 0)
				{
					global::System.Windows.UIElement uielement = this.Children[0];
					if (uielement != null)
					{
						global::System.Windows.Rect finalRect = new global::System.Windows.Rect(global::System.Windows.Controls.Canvas.GetLeft(uielement), global::System.Windows.Controls.Canvas.GetTop(uielement), uielement.DesiredSize.Width, uielement.DesiredSize.Height);
						uielement.Arrange(finalRect);
					}
				}
				return finalSize;
			}

			// Token: 0x0600169B RID: 5787 RVA: 0x00064CBA File Offset: 0x00062EBA
			protected override global::System.Windows.Media.Visual GetVisualChild(int index)
			{
				if (index < 0 || index >= this.Children.Count)
				{
					return null;
				}
				return this.Children[index];
			}

			// Token: 0x170005DD RID: 1501
			// (get) Token: 0x0600169C RID: 5788 RVA: 0x00064CDC File Offset: 0x00062EDC
			protected override int VisualChildrenCount
			{
				get
				{
					return this.Children.Count;
				}
			}

			// Token: 0x170005DE RID: 1502
			// (get) Token: 0x0600169D RID: 5789 RVA: 0x00064CE9 File Offset: 0x00062EE9
			private global::System.Collections.Generic.List<global::System.Windows.UIElement> Children
			{
				get
				{
					if (this._children == null)
					{
						this._children = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(3);
					}
					return this._children;
				}
			}

			// Token: 0x0600169E RID: 5790 RVA: 0x00064D05 File Offset: 0x00062F05
			internal void AddChildElement(global::System.Windows.UIElement childElement)
			{
				base.AddVisualChild(childElement);
				this.Children.Add(childElement);
			}

			// Token: 0x0600169F RID: 5791 RVA: 0x00064D1A File Offset: 0x00062F1A
			internal void RemoveChildElement(global::System.Windows.UIElement childElement)
			{
				base.RemoveVisualChild(childElement);
				this.Children.Remove(childElement);
			}

			// Token: 0x040008F5 RID: 2293
			private global::System.Collections.Generic.List<global::System.Windows.UIElement> _children;
		}

		// Token: 0x0200016D RID: 365
		private enum SplitterMode
		{
			// Token: 0x040008F7 RID: 2295
			Inactive,
			// Token: 0x040008F8 RID: 2296
			IsFixingNear,
			// Token: 0x040008F9 RID: 2297
			IsFixingFar,
			// Token: 0x040008FA RID: 2298
			IsUnfixingNear,
			// Token: 0x040008FB RID: 2299
			IsUnfixingFar
		}

		// Token: 0x0200016E RID: 366
		private enum SplitterDragDirection
		{
			// Token: 0x040008FD RID: 2301
			NotMoving,
			// Token: 0x040008FE RID: 2302
			TowardsNearEdge,
			// Token: 0x040008FF RID: 2303
			TowardsFarEdge
		}
	}
}
