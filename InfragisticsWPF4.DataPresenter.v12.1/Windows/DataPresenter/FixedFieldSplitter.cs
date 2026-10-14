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
	// Token: 0x0200014D RID: 333
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FixedFieldSplitter : global::System.Windows.Controls.Primitives.Thumb
	{
		// Token: 0x060012F8 RID: 4856 RVA: 0x00051A98 File Offset: 0x0004FC98
		static FixedFieldSplitter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter)));
			global::System.Windows.Input.Cursor defaultValue = global::Infragistics.Windows.Utilities.LoadCursor(typeof(global::Infragistics.Windows.Utilities), "ResourceSets/Cursors/verticalSplitter.cur") ?? global::System.Windows.Input.Cursors.SizeWE;
			global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.VerticalCursorProperty = global::System.Windows.DependencyProperty.Register("VerticalCursor", typeof(global::System.Windows.Input.Cursor), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(defaultValue));
			global::System.Windows.Input.Cursor defaultValue2 = global::Infragistics.Windows.Utilities.LoadCursor(typeof(global::Infragistics.Windows.Utilities), "ResourceSets/Cursors/horizontalSplitter.cur") ?? global::System.Windows.Input.Cursors.SizeNS;
			global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.HorizontalCursorProperty = global::System.Windows.DependencyProperty.Register("HorizontalCursor", typeof(global::System.Windows.Input.Cursor), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(defaultValue2));
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00051C81 File Offset: 0x0004FE81
		public FixedFieldSplitter()
		{
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00051C89 File Offset: 0x0004FE89
		internal FixedFieldSplitter(bool isInHeader, global::System.Windows.Controls.Orientation orientation, global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType splitterType) : this()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsInHeaderPropertyKey, global::Infragistics.KnownBoxes.FromValue(isInHeader));
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.OrientationPropertyKey, global::Infragistics.KnownBoxes.FromValue(orientation));
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterTypePropertyKey, splitterType);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00051CC4 File Offset: 0x0004FEC4
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.FixedFieldSplitterAutomationPeer(this);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00051CCC File Offset: 0x0004FECC
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

		// Token: 0x060012FD RID: 4861 RVA: 0x00051D67 File Offset: 0x0004FF67
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnMouseEnterLeave(true);
			base.OnMouseEnter(e);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00051D77 File Offset: 0x0004FF77
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnMouseEnterLeave(false);
			base.OnMouseLeave(e);
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00051D87 File Offset: 0x0004FF87
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x00051D99 File Offset: 0x0004FF99
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

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00051DA7 File Offset: 0x0004FFA7
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsHighlighted
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsHighlightedProperty);
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00051DB9 File Offset: 0x0004FFB9
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsInHeader
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsInHeaderProperty);
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00051DCB File Offset: 0x0004FFCB
		internal void SetIsInHeader(bool value)
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsInHeaderPropertyKey, value);
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x00051DDE File Offset: 0x0004FFDE
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.OrientationProperty);
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00051DF0 File Offset: 0x0004FFF0
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType SplitterType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterTypeProperty);
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00051E02 File Offset: 0x00050002
		internal void SetSplitterType(global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType value)
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterTypePropertyKey, value);
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x00051E15 File Offset: 0x00050015
		// (set) Token: 0x06001308 RID: 4872 RVA: 0x00051E27 File Offset: 0x00050027
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

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x00051E35 File Offset: 0x00050035
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

		// Token: 0x0600130A RID: 4874 RVA: 0x00051E65 File Offset: 0x00050065
		private static void OnIsOverAnySplitterChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsHighlightedPropertyKey, e.NewValue);
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00051E79 File Offset: 0x00050079
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

		// Token: 0x0600130C RID: 4876 RVA: 0x00051EAC File Offset: 0x000500AC
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

		// Token: 0x0600130D RID: 4877 RVA: 0x0005220C File Offset: 0x0005040C
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

		// Token: 0x0600130E RID: 4878 RVA: 0x00052234 File Offset: 0x00050434
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

		// Token: 0x0600130F RID: 4879 RVA: 0x00052290 File Offset: 0x00050490
		private void CreateFixedAreaElementAdorner(global::System.Windows.FrameworkElement fixedAreaElement)
		{
			this._dragInfo.fixedAreaElementAdorner = new global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.FixedAreaElementAdorner(fixedAreaElement);
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(fixedAreaElement);
			if (adornerLayer != null)
			{
				adornerLayer.Add(this._dragInfo.fixedAreaElementAdorner);
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000522CC File Offset: 0x000504CC
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

		// Token: 0x06001311 RID: 4881 RVA: 0x00052408 File Offset: 0x00050608
		private static bool DoesRectContainRect(global::System.Windows.Rect containingRect, global::System.Windows.Rect containedRect)
		{
			return (containingRect.X <= containedRect.X || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(containingRect.X, containedRect.X)) && (containingRect.Y <= containedRect.Y || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(containingRect.Y, containedRect.Y)) && (containingRect.X + containingRect.Width >= containedRect.X + containedRect.Width || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(containingRect.X + containingRect.Width, containedRect.X + containedRect.Width)) && (containingRect.Y + containingRect.Height >= containedRect.Y + containedRect.Height || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(containingRect.Y + containingRect.Height, containedRect.Y + containedRect.Height));
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x000524F4 File Offset: 0x000506F4
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

		// Token: 0x06001313 RID: 4883 RVA: 0x0005265C File Offset: 0x0005085C
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

		// Token: 0x06001314 RID: 4884 RVA: 0x0005276A File Offset: 0x0005096A
		private void OnDragCompleted(object sender, global::System.Windows.Controls.Primitives.DragCompletedEventArgs e)
		{
			this.ProcessOnDragCompleted();
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00052774 File Offset: 0x00050974
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

		// Token: 0x06001316 RID: 4886 RVA: 0x00052848 File Offset: 0x00050A48
		private void OnDragDelta(object sender, global::System.Windows.Controls.Primitives.DragDeltaEventArgs e)
		{
			this.ProcessOnDragDelta(e.HorizontalChange, e.VerticalChange);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0005285C File Offset: 0x00050A5C
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

		// Token: 0x06001318 RID: 4888 RVA: 0x00052B90 File Offset: 0x00050D90
		private void OnDragStarted(object sender, global::System.Windows.Controls.Primitives.DragStartedEventArgs e)
		{
			if (!this.ProcessOnDragStarted())
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00052BB0 File Offset: 0x00050DB0
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

		// Token: 0x0600131A RID: 4890 RVA: 0x00052D34 File Offset: 0x00050F34
		private void OnMouseEnterLeave(bool enter)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), true) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (virtualizingDataRecordCellPanel != null) ? virtualizingDataRecordCellPanel.FieldLayout : null;
			if (fieldLayout != null)
			{
				global::System.Windows.DependencyProperty dp = (this.SplitterType == global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Far) ? global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverFarSplitterProperty : global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverNearSplitterProperty;
				fieldLayout.SetValue(dp, enter ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
			}
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00052D94 File Offset: 0x00050F94
		internal void PerformMove(double x, double y)
		{
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointFromScreenSafe(this, new global::System.Windows.Point(x, y));
			if (this.ProcessOnDragStarted())
			{
				this.ProcessOnDragDelta(point.X, point.Y);
				this.ProcessOnDragCompleted();
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00052DD4 File Offset: 0x00050FD4
		private void RemoveFixedAreaElementAdorner(global::System.Windows.FrameworkElement fixedAreaElement)
		{
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(fixedAreaElement);
			if (adornerLayer != null)
			{
				adornerLayer.Remove(this._dragInfo.fixedAreaElementAdorner);
			}
			this._dragInfo.fixedAreaElementAdorner = null;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00052E08 File Offset: 0x00051008
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

		// Token: 0x0600131E RID: 4894 RVA: 0x00052E60 File Offset: 0x00051060
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

		// Token: 0x0400072B RID: 1835
		private global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.FixedFieldSplitterDragInfo _dragInfo;

		// Token: 0x0400072C RID: 1836
		public static readonly global::System.Windows.DependencyProperty HorizontalCursorProperty;

		// Token: 0x0400072D RID: 1837
		private static readonly global::System.Windows.DependencyPropertyKey IsHighlightedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsHighlighted", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400072E RID: 1838
		public static readonly global::System.Windows.DependencyProperty IsHighlightedProperty = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsHighlightedPropertyKey.DependencyProperty;

		// Token: 0x0400072F RID: 1839
		private static readonly global::System.Windows.DependencyPropertyKey IsInHeaderPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsInHeader", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(false));

		// Token: 0x04000730 RID: 1840
		public static readonly global::System.Windows.DependencyProperty IsInHeaderProperty = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.IsInHeaderPropertyKey.DependencyProperty;

		// Token: 0x04000731 RID: 1841
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.OrientationVerticalBox));

		// Token: 0x04000732 RID: 1842
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.OrientationPropertyKey.DependencyProperty;

		// Token: 0x04000733 RID: 1843
		private static readonly global::System.Windows.DependencyPropertyKey SplitterTypePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SplitterType", typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Near));

		// Token: 0x04000734 RID: 1844
		public static readonly global::System.Windows.DependencyProperty SplitterTypeProperty = global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterTypePropertyKey.DependencyProperty;

		// Token: 0x04000735 RID: 1845
		public static readonly global::System.Windows.DependencyProperty VerticalCursorProperty;

		// Token: 0x04000736 RID: 1846
		private static readonly global::System.Windows.DependencyProperty IsOverAnySplitterProperty = global::System.Windows.DependencyProperty.Register("IsOverAnySplitter", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.OnIsOverAnySplitterChanged)));

		// Token: 0x0200014E RID: 334
		private class FixedFieldSplitterDragInfo
		{
			// Token: 0x0600131F RID: 4895 RVA: 0x00052EB6 File Offset: 0x000510B6
			internal FixedFieldSplitterDragInfo()
			{
			}

			// Token: 0x04000737 RID: 1847
			internal global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel;

			// Token: 0x04000738 RID: 1848
			internal global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout;

			// Token: 0x04000739 RID: 1849
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VirtualCellInfo> virtualCellInfos;

			// Token: 0x0400073A RID: 1850
			internal global::Infragistics.Windows.DataPresenter.FixedFieldInfo fixedFieldInfo;

			// Token: 0x0400073B RID: 1851
			internal global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.FixedAreaElementAdorner fixedAreaElementAdorner;

			// Token: 0x0400073C RID: 1852
			internal global::System.Windows.Shapes.Rectangle splitterPreview;

			// Token: 0x0400073D RID: 1853
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> affectedFields;

			// Token: 0x0400073E RID: 1854
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDropInfo> dropInfos;
		}

		// Token: 0x0200014F RID: 335
		private class SplitterDropInfo
		{
			// Token: 0x0400073F RID: 1855
			internal double midPt;

			// Token: 0x04000740 RID: 1856
			internal double splitterPosition;

			// Token: 0x04000741 RID: 1857
			internal global::Infragistics.Windows.DataPresenter.FixedFieldSplitter.SplitterDragDirection dragDirection;

			// Token: 0x04000742 RID: 1858
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> affectedFields;
		}

		// Token: 0x02000150 RID: 336
		private class FixedAreaElementAdorner : global::Infragistics.Windows.Internal.AdornerEx
		{
			// Token: 0x06001321 RID: 4897 RVA: 0x00052EC6 File Offset: 0x000510C6
			internal FixedAreaElementAdorner(global::System.Windows.FrameworkElement fixedAreaElement) : base(fixedAreaElement)
			{
			}

			// Token: 0x06001322 RID: 4898 RVA: 0x00052ED0 File Offset: 0x000510D0
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

			// Token: 0x06001323 RID: 4899 RVA: 0x00052F32 File Offset: 0x00051132
			protected override global::System.Windows.Media.Visual GetVisualChild(int index)
			{
				if (index < 0 || index >= this.Children.Count)
				{
					return null;
				}
				return this.Children[index];
			}

			// Token: 0x17000497 RID: 1175
			// (get) Token: 0x06001324 RID: 4900 RVA: 0x00052F54 File Offset: 0x00051154
			protected override int VisualChildrenCount
			{
				get
				{
					return this.Children.Count;
				}
			}

			// Token: 0x17000498 RID: 1176
			// (get) Token: 0x06001325 RID: 4901 RVA: 0x00052F61 File Offset: 0x00051161
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

			// Token: 0x06001326 RID: 4902 RVA: 0x00052F7D File Offset: 0x0005117D
			internal void AddChildElement(global::System.Windows.UIElement childElement)
			{
				base.AddVisualChild(childElement);
				this.Children.Add(childElement);
			}

			// Token: 0x06001327 RID: 4903 RVA: 0x00052F92 File Offset: 0x00051192
			internal void RemoveChildElement(global::System.Windows.UIElement childElement)
			{
				base.RemoveVisualChild(childElement);
				this.Children.Remove(childElement);
			}

			// Token: 0x04000743 RID: 1859
			private global::System.Collections.Generic.List<global::System.Windows.UIElement> _children;
		}

		// Token: 0x02000151 RID: 337
		private enum SplitterMode
		{
			// Token: 0x04000745 RID: 1861
			Inactive,
			// Token: 0x04000746 RID: 1862
			IsFixingNear,
			// Token: 0x04000747 RID: 1863
			IsFixingFar,
			// Token: 0x04000748 RID: 1864
			IsUnfixingNear,
			// Token: 0x04000749 RID: 1865
			IsUnfixingFar
		}

		// Token: 0x02000152 RID: 338
		private enum SplitterDragDirection
		{
			// Token: 0x0400074B RID: 1867
			NotMoving,
			// Token: 0x0400074C RID: 1868
			TowardsNearEdge,
			// Token: 0x0400074D RID: 1869
			TowardsFarEdge
		}
	}
}
