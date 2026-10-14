using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200009E RID: 158
	internal class FieldDragManager
	{
		// Token: 0x060007A3 RID: 1955 RVA: 0x0001FC4C File Offset: 0x0001DE4C
		internal FieldDragManager(global::Infragistics.Windows.DataPresenter.Field dragField, global::System.Windows.FrameworkElement dragElement, global::Infragistics.Windows.DataPresenter.FieldChooser sourceFieldChooser)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dragField);
			this._dragField = dragField;
			this._fieldLayout = this._dragField.Owner;
			this._dataPresenter = dragField.DataPresenter;
			this._dragElement = dragElement;
			this._sourceFieldChooser = sourceFieldChooser;
			this._isDraggingFromFieldChooser = (null != sourceFieldChooser);
			this._isDraggingFromGroupByArea = (dragElement is global::Infragistics.Windows.DataPresenter.LabelPresenter && ((global::Infragistics.Windows.DataPresenter.LabelPresenter)dragElement).IsInGroupByArea);
			if (this._fieldLayout.GetFieldLayoutInfo(true, false) == null)
			{
				this._fieldLayout.VerifyStyleGeneratorTemplates();
			}
			this._layoutInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo(this._fieldLayout);
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.Fields)
			{
				if (field.IsVisibleInCellArea || this._dragField == field)
				{
					global::Infragistics.Windows.DataPresenter.FieldPosition actualPosition = field.ActualPosition;
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(actualPosition.Column, actualPosition.Row, actualPosition.ColumnSpan, actualPosition.RowSpan);
					itemLayoutInfo.Visibility = field.VisibilityInCellArea;
					itemLayoutInfo._fixedLocation = field.FixedLocation;
					this._layoutInfo.Add(field, itemLayoutInfo);
					if (this._dragField == field)
					{
						this._dragItemLayoutInfo = itemLayoutInfo;
					}
				}
			}
			if (this._dragItemLayoutInfo == null)
			{
				this._dragItemLayoutInfo = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(0, 0, 1, 1);
				this._dragItemLayoutInfo._fixedLocation = dragField.FixedLocation;
			}
			this._isGroupByMultiEnabled = ((this._dataPresenter != null && this._dataPresenter.GroupByAreaMode == global::Infragistics.Windows.DataPresenter.GroupByAreaMode.MultipleFieldLayoutsCompact) || this._dataPresenter.GroupByAreaMode == global::Infragistics.Windows.DataPresenter.GroupByAreaMode.MultipleFieldLayoutsFull);
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0001FDF8 File Offset: 0x0001DFF8
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0001FE00 File Offset: 0x0001E000
		internal global::Infragistics.Windows.DataPresenter.Field DragField
		{
			get
			{
				return this._dragField;
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0001FE08 File Offset: 0x0001E008
		private int AdjustGroupByAreaMultiInsertAtIndex(int insertAtIndex, global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType dropType, global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields)
		{
			if (dropType == global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Regrouping)
			{
				int num = sortedFields.IndexOf(this._dragField);
				if (num < insertAtIndex)
				{
					insertAtIndex--;
				}
			}
			return insertAtIndex;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0001FE30 File Offset: 0x0001E030
		private global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer AdjustMouseLocationHelper(ref global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo mouseLoc, out global::System.Windows.Point dragIndicatorLocation)
		{
			global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer layoutContainer = (this._layoutContainerToUse != null) ? this._layoutContainerToUse : this.GetLayoutContainerFromPoint(mouseLoc);
			dragIndicatorLocation = mouseLoc.GetPositionInScreen();
			dragIndicatorLocation.Offset(-this._dragIndicatorWindow_OffsetFromMouse.X, -this._dragIndicatorWindow_OffsetFromMouse.Y);
			bool flag = layoutContainer != null && layoutContainer.GetLayoutAreaRect().Contains(mouseLoc);
			bool flag2 = mouseLoc.IsMouseOverGroupByAreaMulti();
			bool flag3 = mouseLoc.IsMouseOverFieldChooser();
			bool flag4 = mouseLoc.IsInsideDataPresenter();
			global::Infragistics.Windows.DataPresenter.AllowFieldMoving allowFieldMovingResolved = this._fieldLayout.AllowFieldMovingResolved;
			bool flag5 = global::Infragistics.Windows.DataPresenter.AllowFieldMoving.WithinLogicalRow == allowFieldMovingResolved;
			bool flag6 = global::Infragistics.Windows.DataPresenter.AllowFieldMoving.WithinLogicalColumn == allowFieldMovingResolved;
			if (flag5 || flag6)
			{
				bool flag7 = this._isDraggingFromFieldChooser || this._isDraggingFromGroupByArea;
				if (flag2 && this._dragField.AllowGroupByResolved)
				{
					flag7 = true;
				}
				if (flag3 && global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Never != this._dragField.AllowHidingResolved)
				{
					flag7 = true;
				}
				if (!flag4 && global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Always == this._dragField.AllowHidingResolved)
				{
					flag7 = true;
				}
				if (flag7)
				{
					flag5 = (flag6 = false);
					if (!flag)
					{
						return null;
					}
				}
			}
			if (flag5 || flag6)
			{
				this._layoutContainerToUse = layoutContainer;
				global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo rectInfo = (layoutContainer != null) ? layoutContainer.GetRect(this._dragItemLayoutInfo.Row, this._dragItemLayoutInfo.Column, 1, 1, new global::System.Windows.Size(20.0, 20.0)) : null;
				if (rectInfo != null)
				{
					global::System.Windows.Rect rect = rectInfo.GetRect();
					global::System.Windows.Point position = mouseLoc.GetPosition();
					global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo layoutAreaRect = layoutContainer.GetLayoutAreaRect();
					global::System.Windows.Rect rect2 = layoutAreaRect.GetRect();
					global::System.Windows.Rect rectInScreen = layoutAreaRect.GetRectInScreen();
					if (flag5)
					{
						position.Y = (rect.Y + rect.Bottom) / 2.0;
						dragIndicatorLocation.Y = rectInfo.GetRectInScreen().Y;
						if (position.X < rect2.X)
						{
							position.X = rect2.X + 1.0;
						}
						else if (position.X > rect2.Right)
						{
							position.X = rect2.Right - 1.0;
						}
						if (this._dragIndicatorWindow != null)
						{
							double actualWidth = this._dragIndicatorWindow.ActualWidth;
							if (dragIndicatorLocation.X + actualWidth < rectInScreen.X)
							{
								dragIndicatorLocation.X = rectInScreen.X - actualWidth;
							}
							else if (dragIndicatorLocation.X > rectInScreen.Right)
							{
								dragIndicatorLocation.X = rectInScreen.Right;
							}
						}
					}
					else if (flag6)
					{
						position.X = (rect.X + rect.Right) / 2.0;
						dragIndicatorLocation.X = rectInfo.GetRectInScreen().X;
						if (position.Y < rect2.Y)
						{
							position.Y = rect2.Y + 1.0;
						}
						else if (position.Y > rect2.Bottom)
						{
							position.Y = rect2.Bottom - 1.0;
						}
						if (this._dragIndicatorWindow != null)
						{
							double actualHeight = this._dragIndicatorWindow.ActualHeight;
							if (dragIndicatorLocation.Y + actualHeight < rectInScreen.Y)
							{
								dragIndicatorLocation.Y = rectInScreen.Y - actualHeight;
							}
							else if (dragIndicatorLocation.Y > rectInScreen.Bottom)
							{
								dragIndicatorLocation.Y = rectInScreen.Bottom;
							}
						}
					}
					mouseLoc = new global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo(this, position, this._dataPresenter);
				}
			}
			else if (this._fieldLayout.UseCellPresenters)
			{
				this._layoutContainerToUse = layoutContainer;
				if (!flag)
				{
					return null;
				}
			}
			return layoutContainer;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000201B4 File Offset: 0x0001E3B4
		private global::Infragistics.Windows.Selection.ScrollSpeed CalcScrollSpeed(double distance)
		{
			double num = 200.0;
			int val = 0;
			int num2 = 6;
			return (global::Infragistics.Windows.Selection.ScrollSpeed)global::System.Math.Max(val, global::System.Math.Min(num2, (int)((double)num2 * (distance / num))));
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000201E4 File Offset: 0x0001E3E4
		internal static void ChangeFieldVisibilityViaFieldChooser(global::Infragistics.Windows.DataPresenter.Field field, bool newVisibility)
		{
			global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager = new global::Infragistics.Windows.DataPresenter.FieldDragManager(field, null, null);
			global::Infragistics.Windows.DataPresenter.FieldChooserDropType fieldChooserDropType = newVisibility ? global::Infragistics.Windows.DataPresenter.FieldChooserDropType.ShowField : global::Infragistics.Windows.DataPresenter.FieldChooserDropType.HideField;
			global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo dropInfo = new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(dragManager, fieldChooserDropType);
			dropInfo.ApplyDrop();
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00020214 File Offset: 0x0001E414
		private static int CompareLabelPresenters(global::Infragistics.Windows.DataPresenter.LabelPresenter lp1, global::Infragistics.Windows.DataPresenter.LabelPresenter lp2)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = global::Infragistics.Windows.Utilities.GetAncestorFromType(lp1, typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), false) as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti;
			if (groupByAreaMulti == null)
			{
				return 0;
			}
			global::System.Windows.Point point = lp1.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), groupByAreaMulti);
			global::System.Windows.Point point2 = lp2.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), groupByAreaMulti);
			if (point.X < point2.X)
			{
				return -1;
			}
			if (point.X != point2.X)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000202A0 File Offset: 0x0001E4A0
		private void DragHelper(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo mouseLoc, bool apply)
		{
			if (!apply)
			{
				this.ManagerScrollTimerHelper(mouseLoc);
			}
			global::System.Windows.Point point;
			global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo dropInfo = this.DragHelper_GetDropInfoHelper(mouseLoc, out point);
			if (!this._dragIndicatorShown)
			{
				this._dragIndicatorWindow_OffsetFromMouse = ((this._dragElement != null) ? global::Infragistics.Windows.DataPresenter.GridUtilities.EnsureInElementBounds(mouseLoc.GetPosition(this._dragElement), this._dragElement) : new global::System.Windows.Point(0.0, 0.0));
				dropInfo = this.DragHelper_GetDropInfoHelper(mouseLoc, out point);
				this.ShowDragIndicator(point);
			}
			if (this._dragIndicatorWindow != null)
			{
				this.PositionToolWindow(this._dragIndicatorWindow, point);
			}
			bool flag = dropInfo != null && dropInfo.IsDropNOOP;
			bool flag2 = dropInfo != null && dropInfo.IsDropValid;
			bool flag3 = dropInfo != null && dropInfo.IsDragAreaInvalid;
			if (apply && this._dataPresenter.GroupByAreaMulti != null)
			{
				this._dataPresenter.GroupByAreaMulti.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.FieldLabelDragInProgressPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
			}
			if (flag3)
			{
				global::System.Windows.Input.Mouse.OverrideCursor = global::System.Windows.Input.Cursors.No;
			}
			else if (dropInfo.GroupByAreaMultiDropType == global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Ungrouping && flag2)
			{
				global::System.Windows.Input.Mouse.OverrideCursor = (global::Infragistics.Windows.Utilities.LoadCursor(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), "Cursors/Ungroup.cur") ?? global::System.Windows.Input.Cursors.UpArrow);
			}
			else if (flag2 && !flag && global::Infragistics.Windows.DataPresenter.FieldChooserDropType.HideField == dropInfo._fieldChooserDropType && !mouseLoc.IsMouseOverFieldChooser())
			{
				global::System.Windows.Input.Mouse.OverrideCursor = (global::Infragistics.Windows.Utilities.LoadCursor(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), "Cursors/HideField.cur") ?? global::System.Windows.Input.Cursors.UpArrow);
			}
			else
			{
				global::System.Windows.Input.Mouse.OverrideCursor = null;
			}
			if (dropInfo == null || flag || !flag2 || flag3 || (dropInfo.GroupByAreaMultiDropType == global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Ungrouping && flag2 && !apply))
			{
				this.HideDropIndicator();
				return;
			}
			if (!flag && flag2)
			{
				if (dropInfo.GroupByAreaMultiDropType != global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Ungrouping)
				{
					this.ShowDropIndicator(dropInfo);
				}
				if (apply)
				{
					dropInfo.ApplyDrop();
				}
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00020444 File Offset: 0x0001E644
		private global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo DragHelper_GetDropInfoHelper(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo mouseLoc, out global::System.Windows.Point dragIndicatorLocation)
		{
			global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer layoutContainer = this.AdjustMouseLocationHelper(ref mouseLoc, out dragIndicatorLocation);
			this.ManageFieldChooserIsDragItemOver(mouseLoc);
			global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo dropInfo = null;
			bool flag = mouseLoc.IsMouseOverFieldChooser();
			bool flag2 = !flag && mouseLoc.IsMouseOverGroupByAreaMulti();
			bool flag3 = !flag && mouseLoc.IsInsideDataPresenter();
			if (this._isDraggingFromGroupByArea && !this._dragField.AllowUnGrouping)
			{
				return new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(this, null, true);
			}
			if ((flag || !flag3) && !this._isDraggingFromGroupByArea && !this._isDraggingFromFieldChooser)
			{
				dropInfo = new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(this, global::Infragistics.Windows.DataPresenter.FieldChooserDropType.HideField);
			}
			if ((dropInfo == null || !dropInfo.IsDropValid) && layoutContainer != null && flag3)
			{
				global::Infragistics.Windows.DataPresenter.FixedFieldSplitter splitterFromPoint = layoutContainer.GetSplitterFromPoint(mouseLoc);
				if (splitterFromPoint != null)
				{
					dropInfo = this.GetSplitterDropInfo(layoutContainer, mouseLoc, splitterFromPoint);
				}
			}
			if ((dropInfo == null || !dropInfo.IsDropValid) && layoutContainer != null && flag3)
			{
				global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutItem itemFromPoint = layoutContainer.GetItemFromPoint(mouseLoc);
				if (itemFromPoint != null)
				{
					global::Infragistics.Windows.Controls.DropLocation relativeDropLocation = this.GetRelativeDropLocation(itemFromPoint.Rect.GetRect(), mouseLoc.GetPosition());
					if (relativeDropLocation != global::Infragistics.Windows.Controls.DropLocation.None)
					{
						dropInfo = new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(layoutContainer, relativeDropLocation, itemFromPoint);
					}
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo rectInfo = null;
					int num;
					int num2;
					layoutContainer.GetLogicalCellFromPoint(mouseLoc, out num, out num2);
					if (num >= 0 && num2 >= 0 && !layoutContainer.HasItemAtLogicalCell(num, num2, true))
					{
						rectInfo = layoutContainer.GetRect(num, num2, this._dragItemLayoutInfo.ColumnSpan, this._dragItemLayoutInfo.RowSpan, (this._dragElement != null) ? new global::System.Windows.Size(this._dragElement.ActualWidth, this._dragElement.ActualHeight) : global::System.Windows.Size.Empty);
					}
					if (rectInfo != null && !rectInfo.GetRect().IsEmpty)
					{
						dropInfo = new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(layoutContainer, num, num2);
					}
				}
			}
			if ((dropInfo == null || !dropInfo.IsDropValid) && this._isGroupByMultiEnabled)
			{
				if (flag2)
				{
					this.ExpandGroupByAreaMultiIfNecessary();
				}
				global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType groupByAreaMultiDropType = global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.None;
				if (flag2 && this._dragField.AllowGroupByResolved)
				{
					groupByAreaMultiDropType = (this._dragField.IsGroupBy ? global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Regrouping : global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Grouping);
				}
				else if (this._dragField.IsGroupBy && this._dragElement is global::Infragistics.Windows.DataPresenter.LabelPresenter && ((global::Infragistics.Windows.DataPresenter.LabelPresenter)this._dragElement).IsInGroupByArea)
				{
					groupByAreaMultiDropType = global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Ungrouping;
				}
				if (this.DataPresenter.GroupByAreaMulti != null)
				{
					if (groupByAreaMultiDropType != global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.None)
					{
						if (groupByAreaMultiDropType == global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Ungrouping || flag2)
						{
							this._dataPresenter.GroupByAreaMulti.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.FieldLabelDragInProgressPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
						}
						else
						{
							this._dataPresenter.GroupByAreaMulti.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.FieldLabelDragInProgressPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
						}
						dropInfo = this.GetGroupByAreaMultiDropInfo(mouseLoc, groupByAreaMultiDropType);
					}
					else
					{
						this._dataPresenter.GroupByAreaMulti.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.FieldLabelDragInProgressPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
					}
				}
			}
			if ((dropInfo == null || !dropInfo.IsDropValid) && this._isDraggingFromFieldChooser && flag3)
			{
				dropInfo = new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(this, global::Infragistics.Windows.DataPresenter.FieldChooserDropType.ShowField);
			}
			if (dropInfo == null && (layoutContainer == null || !flag3))
			{
				bool isDragAreaInvalid = true;
				if (this._isDraggingFromFieldChooser)
				{
					isDragAreaInvalid = false;
				}
				dropInfo = new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(this, null, isDragAreaInvalid);
			}
			if (dropInfo == null)
			{
				dropInfo = new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(this, layoutContainer, false);
			}
			return dropInfo;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00020714 File Offset: 0x0001E914
		private void ExpandGroupByAreaMultiIfNecessary()
		{
			if (!this._isGroupByMultiEnabled)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = this._dataPresenter.GroupByAreaMulti;
			if (groupByAreaMulti == null)
			{
				return;
			}
			if (!groupByAreaMulti.IsExpanded)
			{
				groupByAreaMulti.IsExpanded = true;
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0002074C File Offset: 0x0001E94C
		internal static global::System.Windows.FrameworkElement GetDescendantElementContainingPoint(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo point, global::System.Windows.FrameworkElement ancestor, global::System.Type frameworkElementType, bool getLowestLevelElement)
		{
			global::System.Windows.FrameworkElement result = null;
			global::System.Collections.IEnumerable trivialDescendantsOfType = global::Infragistics.Windows.DataPresenter.GridUtilities.GetTrivialDescendantsOfType(ancestor, frameworkElementType, true);
			foreach (object obj in trivialDescendantsOfType)
			{
				global::System.Windows.FrameworkElement frameworkElement = obj as global::System.Windows.FrameworkElement;
				if (frameworkElement != null && frameworkElement.IsVisible)
				{
					global::System.Windows.Point position = point.GetPosition(frameworkElement);
					if (new global::System.Windows.Rect(0.0, 0.0, frameworkElement.ActualWidth, frameworkElement.ActualHeight).Contains(position))
					{
						if (!getLowestLevelElement)
						{
							return frameworkElement;
						}
						result = frameworkElement;
					}
				}
			}
			return result;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000208B0 File Offset: 0x0001EAB0
		private global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo GetGroupByAreaMultiDropInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo mouseLoc, global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType dropType)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = null;
			if (this.DataPresenter != null)
			{
				groupByAreaMulti = this.DataPresenter.GroupByAreaMulti;
			}
			if (dropType == global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Ungrouping || dropType == global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.None || groupByAreaMulti == null)
			{
				return new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(this, dropType, new global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo(this, new global::System.Windows.Rect(new global::System.Windows.Size(0.0, 0.0)), this.DataPresenter.GroupByAreaMulti), global::Infragistics.Windows.Controls.DropLocation.None, -1, false);
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.LabelPresenter> labelPresenters = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.LabelPresenter>();
			global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::Infragistics.Windows.DataPresenter.LabelPresenter> callback = delegate(global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter)
			{
				if (labelPresenter.Field.Owner == this._fieldLayout && labelPresenter.Field != this._dragField)
				{
					labelPresenters.Add(labelPresenter);
				}
				return false;
			};
			global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.DataPresenter.LabelPresenter>(groupByAreaMulti, true, callback);
			global::System.Windows.FrameworkElement frameworkElement = null;
			global::Infragistics.Windows.Controls.DropLocation dropLocation = global::Infragistics.Windows.Controls.DropLocation.None;
			int num = 0;
			if (labelPresenters.Count == 0)
			{
				global::System.Collections.Generic.List<global::System.Windows.Controls.ItemsControl> itemsControls = new global::System.Collections.Generic.List<global::System.Windows.Controls.ItemsControl>();
				global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::System.Windows.Controls.ItemsControl> callback2 = delegate(global::System.Windows.Controls.ItemsControl itemsControl)
				{
					if (itemsControl.DataContext is global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo && ((global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo)itemsControl.DataContext).FieldLayout == this._fieldLayout && itemsControl.ItemsSource == ((global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo)itemsControl.DataContext).GroupByFields)
					{
						itemsControls.Add(itemsControl);
					}
					return false;
				};
				global::Infragistics.Windows.Utilities.GetDescendantFromType<global::System.Windows.Controls.ItemsControl>(groupByAreaMulti, true, callback2);
				if (itemsControls.Count != 1)
				{
					bool isGroupBy = this._dragField.IsGroupBy;
					return new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(this, dropType, new global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo(this, new global::System.Windows.Rect(new global::System.Windows.Size(this.DataPresenter.GroupByAreaMulti.ActualWidth, this.DataPresenter.GroupByAreaMulti.ActualHeight)), this.DataPresenter.GroupByAreaMulti), global::Infragistics.Windows.Controls.DropLocation.OverTarget, 0, isGroupBy);
				}
				frameworkElement = itemsControls[0];
				dropLocation = global::Infragistics.Windows.Controls.DropLocation.RightOfTarget;
				num = 0;
			}
			if (labelPresenters.Count > 0 && frameworkElement == null)
			{
				labelPresenters.Sort(new global::System.Comparison<global::Infragistics.Windows.DataPresenter.LabelPresenter>(global::Infragistics.Windows.DataPresenter.FieldDragManager.CompareLabelPresenters));
				global::System.Windows.Point position = mouseLoc.GetPosition(groupByAreaMulti);
				global::System.Windows.Rect rect = global::System.Windows.Rect.Empty;
				global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = this._fieldLayout.SortedFields;
				foreach (global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter2 in labelPresenters)
				{
					rect = new global::System.Windows.Rect(labelPresenter2.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), groupByAreaMulti), new global::System.Windows.Size(labelPresenter2.ActualWidth, labelPresenter2.ActualHeight));
					if (position.X < rect.Left + rect.Width / 2.0)
					{
						frameworkElement = labelPresenter2;
						dropLocation = global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget;
						num = sortedFields.IndexOf(labelPresenter2.Field);
						num = this.AdjustGroupByAreaMultiInsertAtIndex(num, dropType, sortedFields);
						break;
					}
				}
				if (frameworkElement == null)
				{
					frameworkElement = labelPresenters[labelPresenters.Count - 1];
					dropLocation = global::Infragistics.Windows.Controls.DropLocation.RightOfTarget;
					num = sortedFields.IndexOf(labelPresenters[labelPresenters.Count - 1].Field) + 1;
					num = this.AdjustGroupByAreaMultiInsertAtIndex(num, dropType, sortedFields);
				}
			}
			return new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(this, dropType, new global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo(this, new global::System.Windows.Rect(frameworkElement.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), groupByAreaMulti), new global::System.Windows.Size(frameworkElement.ActualWidth, frameworkElement.ActualHeight)), groupByAreaMulti), dropLocation, num, false);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00020BC0 File Offset: 0x0001EDC0
		private global::Infragistics.Windows.DataPresenter.ItemLayoutInfo GetItemLayoutInfo(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this._layoutInfo[field];
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00020BD0 File Offset: 0x0001EDD0
		private global::System.Windows.UIElement GetLayoutContainerFromPointHelper(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo point, global::System.Type containerElemType)
		{
			global::System.Windows.FrameworkElement frameworkElement = null;
			if (!point.IsInsideDataPresenter())
			{
				return null;
			}
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this._dataPresenter.CurrentPanel);
			if (adornerLayer != null)
			{
				frameworkElement = global::Infragistics.Windows.DataPresenter.FieldDragManager.GetDescendantElementContainingPoint(point, adornerLayer, containerElemType, true);
			}
			if (frameworkElement == null)
			{
				frameworkElement = global::Infragistics.Windows.DataPresenter.FieldDragManager.GetDescendantElementContainingPoint(point, this._dataPresenter, containerElemType, true);
			}
			if (frameworkElement == null)
			{
				global::System.Windows.DependencyObject dependencyObject = this._dataPresenter.InputHitTest(point.GetPosition()) as global::System.Windows.DependencyObject;
				if (dependencyObject != null)
				{
					frameworkElement = (global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, containerElemType, true) as global::System.Windows.FrameworkElement);
				}
			}
			return frameworkElement;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00020C48 File Offset: 0x0001EE48
		private global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer GetLayoutContainerFromPoint(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo point)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = this.GetLayoutContainerFromPointHelper(point, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel)) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
			if (virtualizingDataRecordCellPanel != null)
			{
				if ((global::Infragistics.Windows.DataPresenter.RecordPresenter)global::Infragistics.Windows.Utilities.GetAncestorFromType(virtualizingDataRecordCellPanel, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) == null)
				{
					return null;
				}
				if (virtualizingDataRecordCellPanel != null && virtualizingDataRecordCellPanel.FieldLayout == this._fieldLayout && (!this._fieldLayout.HasSeparateHeader || virtualizingDataRecordCellPanel.IsHeaderArea))
				{
					return new global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer(this, virtualizingDataRecordCellPanel);
				}
			}
			return null;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00020CBC File Offset: 0x0001EEBC
		private global::Infragistics.Windows.Controls.DropLocation GetRelativeDropLocation(global::System.Windows.Rect rect, global::System.Windows.Point mousePos)
		{
			global::Infragistics.Windows.DataPresenter.AllowFieldMoving allowFieldMovingResolved = this._fieldLayout.AllowFieldMovingResolved;
			bool flag = global::Infragistics.Windows.DataPresenter.AllowFieldMoving.WithinLogicalRow == allowFieldMovingResolved;
			bool flag2 = global::Infragistics.Windows.DataPresenter.AllowFieldMoving.WithinLogicalColumn == allowFieldMovingResolved;
			global::Infragistics.Windows.Controls.DropLocation result = global::Infragistics.Windows.Controls.DropLocation.None;
			if (rect.Contains(mousePos))
			{
				global::System.Windows.Point point = new global::System.Windows.Point(rect.X + rect.Width / 2.0, rect.Y + rect.Height / 2.0);
				double num = (!flag2 && !flag) ? 0.25 : 0.5;
				if (rect.Width > rect.Height)
				{
					if (!flag2 && mousePos.X < rect.X + rect.Width * num)
					{
						result = global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget;
					}
					else if (!flag2 && mousePos.X >= rect.Right - rect.Width * num)
					{
						result = global::Infragistics.Windows.Controls.DropLocation.RightOfTarget;
					}
					else if (!flag && mousePos.Y < point.Y)
					{
						result = global::Infragistics.Windows.Controls.DropLocation.AboveTarget;
					}
					else if (!flag)
					{
						result = global::Infragistics.Windows.Controls.DropLocation.BelowTarget;
					}
				}
				else if (!flag && mousePos.Y < rect.Y + rect.Height * num)
				{
					result = global::Infragistics.Windows.Controls.DropLocation.AboveTarget;
				}
				else if (!flag && mousePos.Y >= rect.Bottom - rect.Height * num)
				{
					result = global::Infragistics.Windows.Controls.DropLocation.BelowTarget;
				}
				else if (!flag2 && mousePos.X < point.X)
				{
					result = global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget;
				}
				else if (!flag2)
				{
					result = global::Infragistics.Windows.Controls.DropLocation.RightOfTarget;
				}
			}
			return result;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00020E1C File Offset: 0x0001F01C
		private global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo GetSplitterDropInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer layoutContainer, global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo mouseLoc, global::Infragistics.Windows.DataPresenter.FixedFieldSplitter splitter)
		{
			global::Infragistics.Windows.DataPresenter.AllowFieldFixing allowFixingResolved = this._dragField.AllowFixingResolved;
			global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType splitterType = splitter.SplitterType;
			global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation = (splitterType == global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Far) ? global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge : global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge;
			if (fixedFieldLocation == this._dragField.FixedLocation)
			{
				fixedFieldLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable;
			}
			if (!this._dragField.IsFixedLocationAllowed(fixedFieldLocation))
			{
				return new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(this, layoutContainer, true);
			}
			bool flag = splitter.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			int num;
			int num2;
			layoutContainer.GetLogicalCellFromPoint(mouseLoc, out num, out num2);
			global::Infragistics.Windows.Controls.DropLocation dropLocation;
			if (flag)
			{
				if (splitterType == global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Near ^ fixedFieldLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
				{
					dropLocation = global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget;
				}
				else
				{
					dropLocation = global::Infragistics.Windows.Controls.DropLocation.RightOfTarget;
				}
			}
			else if (splitterType == global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Near ^ fixedFieldLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
			{
				dropLocation = global::Infragistics.Windows.Controls.DropLocation.AboveTarget;
			}
			else
			{
				dropLocation = global::Infragistics.Windows.Controls.DropLocation.BelowTarget;
			}
			int num3 = flag ? this._dragItemLayoutInfo.ColumnSpan : this._dragItemLayoutInfo.RowSpan;
			for (int i = 0; i < num3; i++)
			{
				int num4;
				int num5;
				switch (dropLocation)
				{
				case global::Infragistics.Windows.Controls.DropLocation.AboveTarget:
					num4 = num - (num3 - i);
					num5 = num2;
					break;
				case global::Infragistics.Windows.Controls.DropLocation.BelowTarget:
					num4 = num - i;
					num5 = num2;
					break;
				case global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget:
					num5 = num2 - (num3 - i);
					num4 = num;
					break;
				case global::Infragistics.Windows.Controls.DropLocation.RightOfTarget:
					num5 = num2 - i;
					num4 = num;
					break;
				default:
					num4 = (num5 = -1);
					break;
				}
				if (num5 >= 0 && num4 >= 0 && !this._layoutInfo.HasOverlappingItem(num5, num4, this._dragItemLayoutInfo.ColumnSpan, this._dragItemLayoutInfo.RowSpan, this._dragItemLayoutInfo, new global::Infragistics.Windows.DataPresenter.FixedFieldLocation?(fixedFieldLocation)))
				{
					return new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(layoutContainer, num4, num5);
				}
			}
			global::System.Windows.Rect rect = new global::System.Windows.Rect(splitter.RenderSize);
			global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo rect2 = layoutContainer.GetRect(num, num2, this._dragItemLayoutInfo.RowSpan, this._dragItemLayoutInfo.ColumnSpan, default(global::System.Windows.Size));
			global::System.Windows.Rect rect3 = rect2.GetRect(splitter);
			if (flag)
			{
				rect.Y = rect3.Y;
				rect.Height = rect3.Height;
			}
			else
			{
				rect.X = rect3.X;
				rect.Width = rect3.Width;
			}
			global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo rect4 = new global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo(layoutContainer.DragManager, rect, splitter);
			return new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(layoutContainer, dropLocation, rect4, num, num2, fixedFieldLocation);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0002101E File Offset: 0x0001F21E
		internal void HideDragIndicator()
		{
			if (this._dragIndicatorWindow != null)
			{
				this._dragIndicatorWindow.Close();
				this._dragIndicatorShown = false;
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0002103C File Offset: 0x0001F23C
		private void HideDropIndicator()
		{
			if (this._dropIndicatorWindow != null)
			{
				global::Infragistics.Windows.Controls.DropIndicator dropIndicator = global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo.GetDropIndicator(this._dropIndicatorWindow);
				if (dropIndicator != null)
				{
					dropIndicator.DropLocation = new global::Infragistics.Windows.Controls.DropLocation?(global::Infragistics.Windows.Controls.DropLocation.None);
				}
				this._dropIndicatorWindow.Close();
				this._dropIndicatorWindow.Tag = null;
				this._dropIndicatorShown = false;
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0002108C File Offset: 0x0001F28C
		internal void ManageFieldChooserIsDragItemOver(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo mouseLoc)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = null;
			if (mouseLoc != null)
			{
				mouseLoc.IsMouseOverFieldChooser(out fieldChooser);
			}
			if (this._lastFieldChooserWithMouseOver != fieldChooser)
			{
				if (this._lastFieldChooserWithMouseOver != null)
				{
					this._lastFieldChooserWithMouseOver.InternalSetIsDragItemOver(false);
				}
				this._lastFieldChooserWithMouseOver = fieldChooser;
				if (fieldChooser != null && !this._isDraggingFromFieldChooser)
				{
					fieldChooser.InternalSetIsDragItemOver(true);
				}
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000210E0 File Offset: 0x0001F2E0
		private void ManagerScrollTimerHelper(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo mouseLoc)
		{
			bool flag = mouseLoc.IsInsideDataPresenter();
			this._scrollTimer_hasMouseBeenInDataPresenter = (this._scrollTimer_hasMouseBeenInDataPresenter || flag);
			if (flag || (this._isDraggingFromFieldChooser && !this._scrollTimer_hasMouseBeenInDataPresenter))
			{
				if (this._scrollTimer != null)
				{
					this._scrollTimer.Stop();
					return;
				}
			}
			else
			{
				if (this._scrollTimer == null)
				{
					global::System.TimeSpan interval = global::System.TimeSpan.FromMilliseconds(100.0);
					this._scrollTimer = new global::System.Windows.Threading.DispatcherTimer(interval, global::System.Windows.Threading.DispatcherPriority.Input, new global::System.EventHandler(this.OnScrollTimer_Tick), this._dataPresenter.Dispatcher);
				}
				this._scrollTimer.Start();
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00021174 File Offset: 0x0001F374
		internal void OnDragEnd(global::System.Windows.Input.MouseEventArgs mouseEventArgs, bool cancel)
		{
			try
			{
				this.OnDragEndHelper(mouseEventArgs, cancel);
			}
			finally
			{
				if (this._isDraggingFromFieldChooser)
				{
					this._sourceFieldChooser.SetFieldDragManagerHelper(null);
				}
				else
				{
					this._dataPresenter.SetFieldDragManagerHelper(null);
				}
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000211C0 File Offset: 0x0001F3C0
		private void OnDragEndHelper(global::System.Windows.Input.MouseEventArgs mouseEventArgs, bool cancel)
		{
			if (this._scrollTimer != null)
			{
				global::System.Windows.Threading.DispatcherTimer scrollTimer = this._scrollTimer;
				this._scrollTimer = null;
				scrollTimer.Stop();
			}
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = this._dragElement as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			if (labelPresenter != null)
			{
				labelPresenter.IsDragSource = false;
			}
			if (!cancel)
			{
				global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo mouseLoc = new global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo(this, mouseEventArgs.GetPosition(this._dataPresenter), this._dataPresenter);
				this.DragHelper(mouseLoc, true);
			}
			global::System.Windows.Input.Mouse.OverrideCursor = null;
			this.HideDragIndicator();
			this.HideDropIndicator();
			if (this._dragIndicatorWindow != null)
			{
				this._dragIndicatorWindow.Dispose();
				this._dragIndicatorWindow = null;
			}
			if (this._dropIndicatorWindow != null)
			{
				this._dropIndicatorWindow.Dispose();
				this._dropIndicatorWindow = null;
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0002126C File Offset: 0x0001F46C
		internal void OnMouseMove(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo mouseLoc = new global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo(this, mouseEventArgs.GetPosition(this._dataPresenter), this._dataPresenter);
			this.DragHelper(mouseLoc, false);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0002129C File Offset: 0x0001F49C
		private void OnScrollTimer_Tick(object sender, global::System.EventArgs e)
		{
			if (this._scrollTimer == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._dataPresenter;
			global::System.Windows.Point position = global::System.Windows.Input.Mouse.GetPosition(this._dataPresenter);
			global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, dataPresenter.ActualWidth, dataPresenter.ActualHeight);
			if (rect.Contains(position))
			{
				return;
			}
			double num = 0.0;
			double num2 = 0.0;
			if (position.X < rect.X)
			{
				num = position.X - rect.X;
			}
			else if (position.X > rect.Right)
			{
				num = position.X - rect.Right;
			}
			if (position.Y < rect.Y)
			{
				num2 = position.Y - rect.Y;
			}
			else if (position.Y > rect.Bottom)
			{
				num2 = position.Y - rect.Bottom;
			}
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
			global::System.Windows.Controls.Orientation orientation = (currentViewInternal != null) ? currentViewInternal.LogicalOrientation : global::System.Windows.Controls.Orientation.Vertical;
			bool flag = global::System.Windows.Controls.Orientation.Vertical == orientation;
			bool flag2 = global::System.Windows.Controls.Orientation.Horizontal == orientation;
			bool flag3 = false;
			if (num != 0.0 && flag)
			{
				((global::Infragistics.Windows.Selection.ISelectionHost)dataPresenter).DoAutoScrollHorizontal(null, (num < 0.0) ? global::Infragistics.Windows.Selection.ScrollDirection.Decrement : global::Infragistics.Windows.Selection.ScrollDirection.Increment, this.CalcScrollSpeed(global::System.Math.Abs(num)));
				flag3 = true;
			}
			if (num2 != 0.0 && flag2)
			{
				((global::Infragistics.Windows.Selection.ISelectionHost)dataPresenter).DoAutoScrollVertical(null, (num2 < 0.0) ? global::Infragistics.Windows.Selection.ScrollDirection.Decrement : global::Infragistics.Windows.Selection.ScrollDirection.Increment, this.CalcScrollSpeed(global::System.Math.Abs(num2)));
				flag3 = true;
			}
			if (flag3)
			{
				this.DragHelper(new global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo(this, position, this._dataPresenter), false);
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00021440 File Offset: 0x0001F640
		private void PositionToolWindow(global::Infragistics.Windows.Controls.ToolWindow toolWindow, global::System.Windows.Point screenPoint)
		{
			global::System.Windows.Point relativePoint = global::Infragistics.Windows.Utilities.PointFromScreenSafe(this._dataPresenter, screenPoint);
			global::System.Windows.FrameworkElement owner = toolWindow.Owner ?? this._dataPresenter;
			relativePoint = global::Infragistics.Windows.Controls.ToolWindow.GetScreenPoint(owner, relativePoint, this._dataPresenter);
			toolWindow.Left = relativePoint.X;
			toolWindow.Top = relativePoint.Y;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00021494 File Offset: 0x0001F694
		internal void ShowDragIndicator(global::System.Windows.Point dragIndicatorLocation)
		{
			global::Infragistics.Windows.DataPresenter.DragToolWindow dragToolWindow = new global::Infragistics.Windows.DataPresenter.DragToolWindow(this._dataPresenter);
			global::Infragistics.Windows.DataPresenter.FieldDragIndicator fieldDragIndicator = new global::Infragistics.Windows.DataPresenter.FieldDragIndicator();
			fieldDragIndicator.Field = this._dragField;
			fieldDragIndicator.IsSourceFromFieldChooser = this._isDraggingFromFieldChooser;
			fieldDragIndicator.IsSourceFromGroupByArea = this._isDraggingFromGroupByArea;
			global::Infragistics.Windows.DataPresenter.CellPresenterBase cellPresenterBase = null;
			if (this._dragElement != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(this._dragElement, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter;
				if (recordPresenter != null)
				{
					fieldDragIndicator.DataContext = recordPresenter.DataContext;
				}
				fieldDragIndicator.IncludeCell = (recordPresenter != null && this._fieldLayout.UseCellPresenters);
				cellPresenterBase = ((this._dragElement as global::Infragistics.Windows.DataPresenter.CellPresenterBase) ?? (global::Infragistics.Windows.Utilities.GetAncestorFromType(this._dragElement, typeof(global::Infragistics.Windows.DataPresenter.CellPresenterBase), true) as global::Infragistics.Windows.DataPresenter.CellPresenterBase));
				global::System.Windows.FrameworkElement frameworkElement = cellPresenterBase ?? this._dragElement;
				fieldDragIndicator.MinWidth = frameworkElement.ActualWidth;
				fieldDragIndicator.MinHeight = frameworkElement.ActualHeight;
			}
			dragToolWindow.Content = fieldDragIndicator;
			this._dragIndicatorWindow = dragToolWindow;
			if (cellPresenterBase != null)
			{
				global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.ApplyTemplateRecursively(fieldDragIndicator);
				global::Infragistics.Windows.DataPresenter.CellPresenterBase cellPresenterBase2 = global::Infragistics.Windows.Utilities.GetDescendantFromType(fieldDragIndicator, typeof(global::Infragistics.Windows.DataPresenter.CellPresenterBase), true) as global::Infragistics.Windows.DataPresenter.CellPresenterBase;
				if (cellPresenterBase2 != null)
				{
					cellPresenterBase2.CellRect = cellPresenterBase.CellRect;
					cellPresenterBase2.LabelRect = cellPresenterBase.LabelRect;
				}
			}
			this.PositionToolWindow(this._dragIndicatorWindow, dragIndicatorLocation);
			this._dragIndicatorWindow.Show(this._dataPresenter, false);
			this._dragIndicatorShown = true;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000215EC File Offset: 0x0001F7EC
		private void ShowDropIndicator(global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo dropInfo)
		{
			if (this._dropIndicatorWindow == null)
			{
				global::Infragistics.Windows.DataPresenter.DragToolWindow dragToolWindow = new global::Infragistics.Windows.DataPresenter.DragToolWindow(this._dataPresenter);
				global::Infragistics.Windows.Controls.DropIndicator content = new global::Infragistics.Windows.Controls.DropIndicator();
				dragToolWindow.Content = content;
				this._dropIndicatorWindow = dragToolWindow;
			}
			bool flag = dropInfo.InitializeDropIndicator(this._dropIndicatorWindow);
			if (flag)
			{
				if (!this._dropIndicatorShown)
				{
					this._dropIndicatorWindow.Show(this._dataPresenter, false);
					if (this._dropIndicatorWindow.Tag == null)
					{
						dropInfo.InitializeDropIndicator(this._dropIndicatorWindow);
						this._dropIndicatorWindow.Tag = new object();
					}
					this._dropIndicatorShown = true;
					return;
				}
			}
			else
			{
				this.HideDropIndicator();
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00021684 File Offset: 0x0001F884
		internal void StartDrag(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			if (this._isDraggingFromFieldChooser)
			{
				this._sourceFieldChooser.SetFieldDragManagerHelper(this);
			}
			else
			{
				this._dataPresenter.SetFieldDragManagerHelper(this);
			}
			global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo mouseLoc = new global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo(this, mouseEventArgs.GetPosition(this._dataPresenter), this._dataPresenter);
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = this._dragElement as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			if (labelPresenter != null)
			{
				labelPresenter.IsDragSource = true;
			}
			this.DragHelper(mouseLoc, false);
		}

		// Token: 0x04000313 RID: 787
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04000314 RID: 788
		private global::Infragistics.Windows.DataPresenter.Field _dragField;

		// Token: 0x04000315 RID: 789
		private global::Infragistics.Windows.DataPresenter.ItemLayoutInfo _dragItemLayoutInfo;

		// Token: 0x04000316 RID: 790
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000317 RID: 791
		private global::System.Windows.FrameworkElement _dragElement;

		// Token: 0x04000318 RID: 792
		private global::Infragistics.Windows.DataPresenter.DragToolWindow _dragIndicatorWindow;

		// Token: 0x04000319 RID: 793
		private global::System.Windows.Point _dragIndicatorWindow_OffsetFromMouse;

		// Token: 0x0400031A RID: 794
		private global::Infragistics.Windows.DataPresenter.DragToolWindow _dropIndicatorWindow;

		// Token: 0x0400031B RID: 795
		private global::Infragistics.Windows.DataPresenter.LayoutInfo _layoutInfo;

		// Token: 0x0400031C RID: 796
		private bool _dropIndicatorShown;

		// Token: 0x0400031D RID: 797
		private bool _dragIndicatorShown;

		// Token: 0x0400031E RID: 798
		private global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer _layoutContainerToUse;

		// Token: 0x0400031F RID: 799
		private global::System.Windows.Threading.DispatcherTimer _scrollTimer;

		// Token: 0x04000320 RID: 800
		private bool _isGroupByMultiEnabled;

		// Token: 0x04000321 RID: 801
		internal global::System.Windows.Input.MouseEventArgs _selectionHost_LastDragMoveEventArgs;

		// Token: 0x04000322 RID: 802
		private global::Infragistics.Windows.DataPresenter.FieldChooser _sourceFieldChooser;

		// Token: 0x04000323 RID: 803
		private bool _isDraggingFromFieldChooser;

		// Token: 0x04000324 RID: 804
		private bool _isDraggingFromGroupByArea;

		// Token: 0x04000325 RID: 805
		private global::Infragistics.Windows.DataPresenter.FieldChooser _lastFieldChooserWithMouseOver;

		// Token: 0x04000326 RID: 806
		private bool _scrollTimer_hasMouseBeenInDataPresenter;

		// Token: 0x0200009F RID: 159
		private class DropInfo
		{
			// Token: 0x060007C1 RID: 1985 RVA: 0x000216EC File Offset: 0x0001F8EC
			internal DropInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer layoutContainer, global::Infragistics.Windows.Controls.DropLocation dropLocation, global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutItem dropTargetItem)
			{
				if (global::Infragistics.Windows.Controls.DropLocation.AboveTarget != dropLocation && global::Infragistics.Windows.Controls.DropLocation.BelowTarget != dropLocation && global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget != dropLocation && global::Infragistics.Windows.Controls.DropLocation.RightOfTarget != dropLocation)
				{
					throw new global::System.ArgumentException();
				}
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(layoutContainer);
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dropTargetItem);
				this.Initialize(layoutContainer.DragManager, layoutContainer, dropLocation, dropTargetItem, dropTargetItem.Rect);
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = this._dragManager.GetItemLayoutInfo(this._dropTargetItem.Field);
				this._newDragItemLayoutInfo = ((itemLayoutInfo != null) ? this.GetNewDragLayoutInfo(itemLayoutInfo, this._dropLocation) : null);
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x00021768 File Offset: 0x0001F968
			internal DropInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer layoutContainer, int newRow, int newColumn)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(layoutContainer);
				global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager = layoutContainer.DragManager;
				global::System.Windows.FrameworkElement dragElement = dragManager._dragElement;
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = dragManager._dragItemLayoutInfo.Clone();
				itemLayoutInfo.Row = newRow;
				itemLayoutInfo.Column = newColumn;
				itemLayoutInfo._fixedLocation = layoutContainer.GetFixedLocation(newRow, newColumn);
				itemLayoutInfo.Visibility = global::System.Windows.Visibility.Visible;
				global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo rect = layoutContainer.GetRect(itemLayoutInfo.Row, itemLayoutInfo.Column, itemLayoutInfo.RowSpan, itemLayoutInfo.ColumnSpan, (dragElement != null) ? new global::System.Windows.Size(dragElement.ActualWidth, dragElement.ActualHeight) : global::System.Windows.Size.Empty);
				this.Initialize(layoutContainer.DragManager, layoutContainer, global::Infragistics.Windows.Controls.DropLocation.OverTarget, null, rect);
				this._newDragItemLayoutInfo = itemLayoutInfo;
			}

			// Token: 0x060007C3 RID: 1987 RVA: 0x00021810 File Offset: 0x0001FA10
			internal DropInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer layoutContainer, global::Infragistics.Windows.Controls.DropLocation dropLocation, global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo rect, int newRow, int newCol, global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation)
			{
				global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager = layoutContainer.DragManager;
				this.Initialize(dragManager, layoutContainer, dropLocation, null, rect);
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = dragManager._dragItemLayoutInfo.Clone();
				itemLayoutInfo.Row = newRow;
				itemLayoutInfo.Column = newCol;
				itemLayoutInfo._fixedLocation = fixedLocation;
				this._newDragItemLayoutInfo = itemLayoutInfo;
			}

			// Token: 0x060007C4 RID: 1988 RVA: 0x00021860 File Offset: 0x0001FA60
			internal DropInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer layoutContainer, bool isDragAreaInvalid)
			{
				this._isDragAreaInvalid = isDragAreaInvalid;
				this.Initialize(dragManager, layoutContainer, global::Infragistics.Windows.Controls.DropLocation.None, null, null);
			}

			// Token: 0x060007C5 RID: 1989 RVA: 0x0002187A File Offset: 0x0001FA7A
			internal DropInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType groupByAreaMultiDropType, global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo targetRect, global::Infragistics.Windows.Controls.DropLocation dropLocation, int groupByAreaMultiInsertAtIndex, bool isDropNOOP)
			{
				this._dragManager = dragManager;
				this._groupByAreaMultiDropType = groupByAreaMultiDropType;
				this._dropTargetRect = targetRect;
				this._dropLocation = dropLocation;
				this._groupByAreaMultiInsertAtIndex = groupByAreaMultiInsertAtIndex;
				this._isDropNOOP = isDropNOOP;
			}

			// Token: 0x060007C6 RID: 1990 RVA: 0x000218B0 File Offset: 0x0001FAB0
			internal DropInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::Infragistics.Windows.DataPresenter.FieldChooserDropType fieldChooserDropType)
			{
				this._dragManager = dragManager;
				this._fieldChooserDropType = fieldChooserDropType;
				if (fieldChooserDropType != global::Infragistics.Windows.DataPresenter.FieldChooserDropType.None)
				{
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = dragManager._dragItemLayoutInfo.Clone();
					itemLayoutInfo.Visibility = ((global::Infragistics.Windows.DataPresenter.FieldChooserDropType.HideField == fieldChooserDropType) ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
					this._newDragItemLayoutInfo = itemLayoutInfo;
				}
			}

			// Token: 0x060007C7 RID: 1991 RVA: 0x000218F8 File Offset: 0x0001FAF8
			internal bool ApplyDrop()
			{
				this.EnsureProcessed();
				global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType groupByAreaMultiDropType = this._groupByAreaMultiDropType;
				if (groupByAreaMultiDropType == global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.None && this._dragManager._isDraggingFromGroupByArea && this._dragManager._dragField.AllowGroupByResolved)
				{
					groupByAreaMultiDropType = global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Ungrouping;
				}
				if (groupByAreaMultiDropType != global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.None && !this.ApplyDrop_ProcessGroupBy(groupByAreaMultiDropType, this._groupByAreaMultiInsertAtIndex))
				{
					return false;
				}
				if (this._newLayoutInfo != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._dragManager._dataPresenter;
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo dragItemLayoutInfo = this._dragManager._dragItemLayoutInfo;
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = this._newLayoutInfo[this._dragManager._dragField];
					global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason fieldPositionChangeReason = global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Moved;
					global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation = this._dragManager._dragField.FixedLocation;
					if (itemLayoutInfo != null && itemLayoutInfo._fixedLocation != dragItemLayoutInfo._fixedLocation)
					{
						fixedLocation = itemLayoutInfo._fixedLocation;
						if (itemLayoutInfo._fixedLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
						{
							fieldPositionChangeReason = global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Unfixed;
						}
						else
						{
							fieldPositionChangeReason = global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Fixed;
						}
					}
					if (dragItemLayoutInfo != null && itemLayoutInfo != null && dragItemLayoutInfo.Visibility != itemLayoutInfo.Visibility)
					{
						fieldPositionChangeReason = ((itemLayoutInfo.Visibility == global::System.Windows.Visibility.Visible) ? global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Displayed : global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Hidden);
					}
					if (dataPresenter != null)
					{
						global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs fieldPositionChangingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs(this._dragManager._dragField, fieldPositionChangeReason);
						dataPresenter.RaiseFieldPositionChanging(fieldPositionChangingEventArgs);
						if (fieldPositionChangingEventArgs.Cancel)
						{
							return false;
						}
					}
					new global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager(this._newLayoutInfo, this._dragManager._dragField, global::Infragistics.Windows.DataPresenter.FieldChooserDropType.None != this._fieldChooserDropType).OffsetCollapsedItems();
					if (dataPresenter != null && dataPresenter.IsUndoEnabled)
					{
						global::Infragistics.Windows.DataPresenter.FieldPositionAction action = new global::Infragistics.Windows.DataPresenter.FieldPositionAction(new global::Infragistics.Windows.DataPresenter.Field[]
						{
							this._dragManager._dragField
						}, this._dragManager._fieldLayout.GetFieldLayoutInfo(true, true), global::Infragistics.Windows.DataPresenter.FieldPositionAction.GetUndoReason(fieldPositionChangeReason), dragItemLayoutInfo._fixedLocation);
						dataPresenter.History.AddUndoActionInternal(action);
					}
					this._dragManager._fieldLayout.SetFieldLayoutInfo(this._newLayoutInfo, true, true);
					this._dragManager._dragField.SetFixedLocation(fixedLocation);
					if (dataPresenter != null)
					{
						this._dragManager._fieldLayout.InvalidateGeneratedStyles(false, false);
						dataPresenter.RaiseFieldPositionChanged(new global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangedEventArgs(this._dragManager._dragField, fieldPositionChangeReason));
					}
					return true;
				}
				return false;
			}

			// Token: 0x060007C8 RID: 1992 RVA: 0x00021AE8 File Offset: 0x0001FCE8
			private bool ApplyDrop_ProcessGroupBy(global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType groupByDropType, int groupByAreaMultiInsertAtIndex)
			{
				bool flag = false;
				global::Infragistics.Windows.DataPresenter.GroupingHelper groupingHelper = new global::Infragistics.Windows.DataPresenter.GroupingHelper(this._dragManager._fieldLayout);
				switch (groupByDropType)
				{
				case global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Grouping:
					if (groupingHelper.ProcessTryGrouping(this._dragManager.DragField, groupByAreaMultiInsertAtIndex))
					{
						groupingHelper.ProcessApplyGrouping(this._dragManager.DragField, groupByAreaMultiInsertAtIndex);
						flag = true;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Ungrouping:
					if (groupingHelper.ProcessTryUnGroup(this._dragManager.DragField))
					{
						groupingHelper.ProcessApplyUnGroup(this._dragManager.DragField);
						flag = true;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Regrouping:
					if (groupingHelper.ProcessTryReGroup(this._dragManager.DragField, groupByAreaMultiInsertAtIndex))
					{
						groupingHelper.ProcessApplyReGroup(this._dragManager.DragField, groupByAreaMultiInsertAtIndex);
						flag = true;
					}
					break;
				}
				if (flag)
				{
					groupingHelper.RaiseGroupedEventHelper();
				}
				return flag;
			}

			// Token: 0x060007C9 RID: 1993 RVA: 0x00021BA4 File Offset: 0x0001FDA4
			private void EnsureProcessed()
			{
				if (!this._isProcessed)
				{
					this.ProcessHelper();
					this._isProcessed = true;
				}
			}

			// Token: 0x060007CA RID: 1994 RVA: 0x00021BBC File Offset: 0x0001FDBC
			internal static global::Infragistics.Windows.Controls.DropIndicator GetDropIndicator(global::Infragistics.Windows.DataPresenter.DragToolWindow indicatorWindow)
			{
				global::Infragistics.Windows.Controls.DropIndicator dropIndicator = (global::Infragistics.Windows.Controls.DropIndicator)global::Infragistics.Windows.Utilities.GetDescendantFromType(indicatorWindow, typeof(global::Infragistics.Windows.Controls.DropIndicator), true);
				if (dropIndicator == null)
				{
					dropIndicator = (indicatorWindow.Content as global::Infragistics.Windows.Controls.DropIndicator);
				}
				return dropIndicator;
			}

			// Token: 0x060007CB RID: 1995 RVA: 0x00021BF0 File Offset: 0x0001FDF0
			private global::Infragistics.Windows.DataPresenter.ItemLayoutInfo GetNewDragLayoutInfo(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo targetLayoutInfo, global::Infragistics.Windows.Controls.DropLocation dropLocation)
			{
				int num = targetLayoutInfo.Column;
				int num2 = targetLayoutInfo.Row;
				if (global::Infragistics.Windows.Controls.DropLocation.RightOfTarget == dropLocation)
				{
					num += targetLayoutInfo.ColumnSpan;
				}
				if (global::Infragistics.Windows.Controls.DropLocation.BelowTarget == dropLocation)
				{
					num2 += targetLayoutInfo.RowSpan;
				}
				return new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(num, num2, this._dragManager._dragItemLayoutInfo.ColumnSpan, this._dragManager._dragItemLayoutInfo.RowSpan)
				{
					_fixedLocation = targetLayoutInfo._fixedLocation
				};
			}

			// Token: 0x060007CC RID: 1996 RVA: 0x00021C5C File Offset: 0x0001FE5C
			private static bool HasLogicalColumnChanged(global::Infragistics.Windows.DataPresenter.LayoutInfo origInfo, global::Infragistics.Windows.DataPresenter.LayoutInfo newInfo)
			{
				bool result;
				bool flag;
				origInfo.HasLogicalColumnOrRowChanged(newInfo, out result, out flag);
				return result;
			}

			// Token: 0x060007CD RID: 1997 RVA: 0x00021C78 File Offset: 0x0001FE78
			private static bool HasLogicalRowChanged(global::Infragistics.Windows.DataPresenter.LayoutInfo origInfo, global::Infragistics.Windows.DataPresenter.LayoutInfo newInfo)
			{
				bool flag;
				bool result;
				origInfo.HasLogicalColumnOrRowChanged(newInfo, out flag, out result);
				return result;
			}

			// Token: 0x060007CE RID: 1998 RVA: 0x00021C91 File Offset: 0x0001FE91
			private void Initialize(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer layoutContainer, global::Infragistics.Windows.Controls.DropLocation dropLocation, global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutItem dropTargetItem, global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo dropTargetRect)
			{
				this._dragManager = dragManager;
				this._layoutContainer = layoutContainer;
				this._dropLocation = dropLocation;
				this._dropTargetItem = dropTargetItem;
				this._dropTargetRect = dropTargetRect;
			}

			// Token: 0x060007CF RID: 1999 RVA: 0x00021CB8 File Offset: 0x0001FEB8
			internal bool InitializeDropIndicator(global::Infragistics.Windows.DataPresenter.DragToolWindow indicatorWindow)
			{
				global::Infragistics.Windows.Controls.DropIndicator dropIndicator = global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo.GetDropIndicator(indicatorWindow);
				if (this._dropTargetRect == null)
				{
					return false;
				}
				global::System.Windows.Rect rectInScreen = this._dropTargetRect.GetRectInScreen();
				if (dropIndicator != null)
				{
					dropIndicator.DropLocation = new global::Infragistics.Windows.Controls.DropLocation?(this._dropLocation);
					dropIndicator.DropTargetWidth = rectInScreen.Width;
					dropIndicator.DropTargetHeight = rectInScreen.Height;
					indicatorWindow.UpdateLayout();
					global::System.Windows.UIElement descendantFromName = global::Infragistics.Windows.Utilities.GetDescendantFromName(indicatorWindow, "PART_Offset");
					if (descendantFromName != null)
					{
						global::System.Windows.Point point = descendantFromName.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), indicatorWindow);
						rectInScreen.Offset(-point.X, -point.Y);
						global::System.Windows.FlowDirection flowDirection = this._dragManager.DataPresenter.FlowDirection;
						if ((global::Infragistics.Windows.Controls.DropLocation.RightOfTarget == this._dropLocation && flowDirection == global::System.Windows.FlowDirection.LeftToRight) || (global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget == this._dropLocation && flowDirection == global::System.Windows.FlowDirection.RightToLeft))
						{
							rectInScreen.Offset(rectInScreen.Width, 0.0);
						}
						else if (global::Infragistics.Windows.Controls.DropLocation.BelowTarget == this._dropLocation)
						{
							rectInScreen.Offset(0.0, rectInScreen.Height);
						}
					}
				}
				this._dragManager.PositionToolWindow(indicatorWindow, rectInScreen.Location);
				return true;
			}

			// Token: 0x060007D0 RID: 2000 RVA: 0x00021DDC File Offset: 0x0001FFDC
			internal static bool IsDropValidHelper(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::Infragistics.Windows.DataPresenter.LayoutInfo origLayoutInfo, global::Infragistics.Windows.DataPresenter.LayoutInfo newLayoutInfo, ref bool isDragAreaInvalid)
			{
				global::Infragistics.Windows.DataPresenter.Field dragField = dragManager._dragField;
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo dragItemLayoutInfo = dragManager._dragItemLayoutInfo;
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = newLayoutInfo[dragField];
				if (itemLayoutInfo != null && itemLayoutInfo._fixedLocation != dragItemLayoutInfo._fixedLocation && !dragField.IsFixedLocationAllowed(itemLayoutInfo._fixedLocation))
				{
					isDragAreaInvalid = true;
					return false;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dragManager._fieldLayout;
				switch (fieldLayout.AllowFieldMovingResolved)
				{
				case global::Infragistics.Windows.DataPresenter.AllowFieldMoving.No:
					if (origLayoutInfo.HasLogicalColumnOrRowChanged(newLayoutInfo))
					{
						return false;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.AllowFieldMoving.WithinLogicalRow:
					if (global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo.HasLogicalRowChanged(origLayoutInfo, newLayoutInfo))
					{
						return false;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.AllowFieldMoving.WithinLogicalColumn:
					if (global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo.HasLogicalColumnChanged(origLayoutInfo, newLayoutInfo))
					{
						return false;
					}
					break;
				}
				int fieldMovingMaxColumnsResolved = fieldLayout.FieldMovingMaxColumnsResolved;
				int fieldMovingMaxRowsResolved = fieldLayout.FieldMovingMaxRowsResolved;
				if (fieldMovingMaxColumnsResolved > 0 || fieldMovingMaxRowsResolved > 0)
				{
					int num;
					int num2;
					origLayoutInfo.GetLogicalRowAndColumnCount(out num, out num2);
					int num3;
					int num4;
					newLayoutInfo.GetLogicalRowAndColumnCount(out num3, out num4);
					if (fieldMovingMaxColumnsResolved > 0 && num3 > fieldMovingMaxColumnsResolved && num3 > num)
					{
						return false;
					}
					if (fieldMovingMaxRowsResolved > 0 && num4 > fieldMovingMaxRowsResolved && num4 > num2)
					{
						return false;
					}
				}
				if (dragItemLayoutInfo != null && itemLayoutInfo != null && dragItemLayoutInfo.Visibility != itemLayoutInfo.Visibility)
				{
					global::Infragistics.Windows.DataPresenter.AllowFieldHiding allowHidingResolved = dragField.AllowHidingResolved;
					bool flag = null != dragManager._lastFieldChooserWithMouseOver;
					if (global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Never == allowHidingResolved)
					{
						return false;
					}
					if (itemLayoutInfo.Visibility != global::System.Windows.Visibility.Visible && global::Infragistics.Windows.DataPresenter.AllowFieldHiding.ViaFieldChooserOnly == allowHidingResolved && !flag)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x060007D1 RID: 2001 RVA: 0x00021F08 File Offset: 0x00020108
			internal static void OffsetItems(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> items, int colDelta, int rowDelta)
			{
				foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo in items)
				{
					if (itemLayoutInfo.Row + rowDelta < 0 || itemLayoutInfo.Column + colDelta < 0)
					{
						return;
					}
				}
				foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2 in items)
				{
					itemLayoutInfo2.Column += colDelta;
					itemLayoutInfo2.Row += rowDelta;
				}
			}

			// Token: 0x060007D2 RID: 2002 RVA: 0x00021FB0 File Offset: 0x000201B0
			private void ProcessHelper()
			{
				if (this._groupByAreaMultiDropType != global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.None)
				{
					this._isDropValid = true;
					return;
				}
				global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = null;
				global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo2 = null;
				bool flag = null != this._newDragItemLayoutInfo;
				if (this._dragManager._dragField.Index < 0)
				{
					flag = false;
				}
				if (flag && this._dropTargetItem != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field = this._dropTargetItem.Field;
					if (field == null || field.Owner != this._dragManager._fieldLayout)
					{
						flag = false;
					}
				}
				bool isDropNOOP;
				bool isDropValid;
				if (flag)
				{
					bool flag2 = !global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.HasSamePosition(this._newDragItemLayoutInfo, this._dragManager._dragItemLayoutInfo);
					layoutInfo = this._dragManager._layoutInfo.Clone();
					layoutInfo2 = layoutInfo.Clone();
					layoutInfo2[this._dragManager._dragField] = this._newDragItemLayoutInfo;
					global::Infragistics.Windows.DataPresenter.AllowFieldMoving allowFieldMovingResolved = this._dragManager._fieldLayout.AllowFieldMovingResolved;
					if (flag2)
					{
						this.ShiftUpLeftHelper(layoutInfo, layoutInfo2);
					}
					bool shiftBelowFirst = global::Infragistics.Windows.Controls.DropLocation.AboveTarget == this._dropLocation || global::Infragistics.Windows.Controls.DropLocation.BelowTarget == this._dropLocation || (global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget != this._dropLocation && global::Infragistics.Windows.Controls.DropLocation.RightOfTarget != this._dropLocation && global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom == this._dragManager._fieldLayout.AutoArrangeCellsResolved);
					layoutInfo2.EnsureItemDoesntOverlap(this._newDragItemLayoutInfo, global::Infragistics.Windows.DataPresenter.AllowFieldMoving.WithinLogicalColumn != allowFieldMovingResolved, global::Infragistics.Windows.DataPresenter.AllowFieldMoving.WithinLogicalRow != allowFieldMovingResolved, shiftBelowFirst);
					if (flag2)
					{
						layoutInfo2.PackLayout();
						layoutInfo.PackLayout();
					}
					isDropNOOP = layoutInfo2.IsSame(layoutInfo);
					isDropValid = global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo.IsDropValidHelper(this._dragManager, layoutInfo, layoutInfo2, ref this._isDragAreaInvalid);
				}
				else
				{
					isDropValid = false;
					isDropNOOP = false;
				}
				this._origLayoutInfo = layoutInfo;
				this._newLayoutInfo = layoutInfo2;
				this._isDropNOOP = isDropNOOP;
				this._isDropValid = isDropValid;
			}

			// Token: 0x060007D3 RID: 2003 RVA: 0x00022148 File Offset: 0x00020348
			private void ShiftUpLeftHelper(global::Infragistics.Windows.DataPresenter.LayoutInfo origLayoutInfo, global::Infragistics.Windows.DataPresenter.LayoutInfo newLayoutInfo)
			{
				global::Infragistics.Windows.DataPresenter.Field dragField = this._dragManager._dragField;
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = newLayoutInfo[dragField];
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2 = origLayoutInfo[dragField];
				if (itemLayoutInfo != null && itemLayoutInfo2 != null && itemLayoutInfo._fixedLocation != itemLayoutInfo2._fixedLocation)
				{
					return;
				}
				bool flag = global::System.Windows.Visibility.Visible == dragField.VisibilityResolved;
				bool flag2 = origLayoutInfo.DoesItemOverlap(itemLayoutInfo2, null);
				if (flag && !flag2)
				{
					int num = -1;
					int num2 = -1;
					int rowSpan = -1;
					int colSpan = -1;
					int rowDelta = 0;
					int colDelta = 0;
					bool flag3 = false;
					if (global::Infragistics.Windows.Controls.DropLocation.AboveTarget == this._dropLocation || global::Infragistics.Windows.Controls.DropLocation.BelowTarget == this._dropLocation)
					{
						if (itemLayoutInfo2.Column == itemLayoutInfo.Column && itemLayoutInfo2.ColumnSpan == itemLayoutInfo.ColumnSpan && itemLayoutInfo2.Row < itemLayoutInfo.Row)
						{
							num2 = itemLayoutInfo.Column;
							colSpan = itemLayoutInfo.ColumnSpan;
							num = itemLayoutInfo2.Row;
							rowSpan = itemLayoutInfo.Row - num;
							rowDelta = -itemLayoutInfo2.RowSpan;
							flag3 = true;
						}
					}
					else if ((global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget == this._dropLocation || global::Infragistics.Windows.Controls.DropLocation.RightOfTarget == this._dropLocation) && itemLayoutInfo2.Row == itemLayoutInfo.Row && itemLayoutInfo2.RowSpan == itemLayoutInfo.RowSpan && itemLayoutInfo2.Column < itemLayoutInfo.Column)
					{
						num = itemLayoutInfo.Row;
						rowSpan = itemLayoutInfo.RowSpan;
						num2 = itemLayoutInfo2.Column;
						colSpan = itemLayoutInfo.Column - num2;
						colDelta = -itemLayoutInfo2.ColumnSpan;
						flag3 = true;
					}
					if (flag3)
					{
						global::Infragistics.Windows.Helpers.HashSet y = global::Infragistics.Windows.DataPresenter.GridUtilities.ToSet(global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(newLayoutInfo.Values, new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo.MeetsCriteria_IntersectingItems(num2, num, colSpan, rowSpan, false)));
						global::Infragistics.Windows.Helpers.HashSet hashSet = global::Infragistics.Windows.DataPresenter.GridUtilities.ToSet(global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(newLayoutInfo.Values, new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo.MeetsCriteria_IntersectingItems(num2, num, colSpan, rowSpan, true)));
						if (global::Infragistics.Windows.Helpers.HashSet.AreEqual(hashSet, y))
						{
							hashSet.Add(itemLayoutInfo);
							global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo.OffsetItems(new global::Infragistics.Collections.TypedEnumerable<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(hashSet), colDelta, rowDelta);
						}
					}
				}
			}

			// Token: 0x170001EF RID: 495
			// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00022304 File Offset: 0x00020504
			internal global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType GroupByAreaMultiDropType
			{
				get
				{
					return this._groupByAreaMultiDropType;
				}
			}

			// Token: 0x170001F0 RID: 496
			// (get) Token: 0x060007D5 RID: 2005 RVA: 0x0002230C File Offset: 0x0002050C
			internal bool IsDragAreaInvalid
			{
				get
				{
					return this._isDragAreaInvalid;
				}
			}

			// Token: 0x170001F1 RID: 497
			// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00022314 File Offset: 0x00020514
			internal bool IsDropNOOP
			{
				get
				{
					this.EnsureProcessed();
					return this._isDropNOOP;
				}
			}

			// Token: 0x170001F2 RID: 498
			// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00022322 File Offset: 0x00020522
			internal bool IsDropValid
			{
				get
				{
					this.EnsureProcessed();
					return this._isDropValid;
				}
			}

			// Token: 0x04000327 RID: 807
			private global::Infragistics.Windows.DataPresenter.FieldDragManager _dragManager;

			// Token: 0x04000328 RID: 808
			private global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer _layoutContainer;

			// Token: 0x04000329 RID: 809
			private global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutItem _dropTargetItem;

			// Token: 0x0400032A RID: 810
			private global::Infragistics.Windows.Controls.DropLocation _dropLocation;

			// Token: 0x0400032B RID: 811
			private global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo _dropTargetRect;

			// Token: 0x0400032C RID: 812
			private global::Infragistics.Windows.DataPresenter.ItemLayoutInfo _newDragItemLayoutInfo;

			// Token: 0x0400032D RID: 813
			private global::Infragistics.Windows.DataPresenter.LayoutInfo _origLayoutInfo;

			// Token: 0x0400032E RID: 814
			private global::Infragistics.Windows.DataPresenter.LayoutInfo _newLayoutInfo;

			// Token: 0x0400032F RID: 815
			private bool _isProcessed;

			// Token: 0x04000330 RID: 816
			private bool _isDropValid;

			// Token: 0x04000331 RID: 817
			private bool _isDropNOOP;

			// Token: 0x04000332 RID: 818
			private bool _isDragAreaInvalid;

			// Token: 0x04000333 RID: 819
			private global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType _groupByAreaMultiDropType;

			// Token: 0x04000334 RID: 820
			private int _groupByAreaMultiInsertAtIndex;

			// Token: 0x04000335 RID: 821
			internal global::Infragistics.Windows.DataPresenter.FieldChooserDropType _fieldChooserDropType;

			// Token: 0x020000BC RID: 188
			private class MeetsCriteria_IntersectingItems : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
			{
				// Token: 0x060008DA RID: 2266 RVA: 0x00025239 File Offset: 0x00023439
				public MeetsCriteria_IntersectingItems(int col, int row, int colSpan, int rowSpan, bool fullyContainedItemsOnly)
				{
					this._col = col;
					this._row = row;
					this._colSpan = colSpan;
					this._rowSpan = rowSpan;
					this._fullyContainedItemsOnly = fullyContainedItemsOnly;
				}

				// Token: 0x060008DB RID: 2267 RVA: 0x00025268 File Offset: 0x00023468
				public bool MeetsCriteria(object itemObj)
				{
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo)itemObj;
					if (this._fullyContainedItemsOnly)
					{
						return itemLayoutInfo.Column >= this._col && itemLayoutInfo.Column + itemLayoutInfo.ColumnSpan <= this._col + this._colSpan && itemLayoutInfo.Row >= this._row && itemLayoutInfo.Row + itemLayoutInfo.RowSpan <= this._row + this._rowSpan;
					}
					return global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(this._col, this._colSpan, itemLayoutInfo.Column, itemLayoutInfo.ColumnSpan) && global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(this._row, this._rowSpan, itemLayoutInfo.Row, itemLayoutInfo.RowSpan);
				}

				// Token: 0x04000368 RID: 872
				private int _col;

				// Token: 0x04000369 RID: 873
				private int _row;

				// Token: 0x0400036A RID: 874
				private int _colSpan;

				// Token: 0x0400036B RID: 875
				private int _rowSpan;

				// Token: 0x0400036C RID: 876
				private bool _fullyContainedItemsOnly;
			}
		}

		// Token: 0x020000BD RID: 189
		private class LayoutContainer
		{
			// Token: 0x060008DC RID: 2268 RVA: 0x0002531C File Offset: 0x0002351C
			internal LayoutContainer(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel layoutContainerElem)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dragManager);
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(layoutContainerElem);
				this._dragManager = dragManager;
				this._layoutContainerElem = layoutContainerElem;
				this.InitializeLogicalRowColDims();
			}

			// Token: 0x060008DD RID: 2269 RVA: 0x00025344 File Offset: 0x00023544
			private void AdjustCellRect(int row, int col, ref global::System.Windows.Rect rect)
			{
				global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation = this.GetFixedLocation(row, col);
				global::System.Windows.Vector fixedAreaOffset = this._layoutContainerElem.GetFixedAreaOffset(fixedLocation, false);
				rect.Offset(fixedAreaOffset);
			}

			// Token: 0x060008DE RID: 2270 RVA: 0x00025370 File Offset: 0x00023570
			internal global::Infragistics.Windows.DataPresenter.FixedFieldLocation GetFixedLocation(int row, int col)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._dragManager._fieldLayout;
				bool isHorizontal = fieldLayout.IsHorizontal;
				if (isHorizontal)
				{
					col = 0;
				}
				else
				{
					row = 0;
				}
				if (fieldLayout.DataPresenter != null && fieldLayout.DataPresenter.IsFixedFieldsSupportedResolved)
				{
					if (this._layoutContainerElem.GetFixedArea(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge).Contains(row, col))
					{
						return global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge;
					}
					global::Infragistics.Windows.DataPresenter.FieldPosition fixedArea = this._layoutContainerElem.GetFixedArea(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge);
					if (fixedArea.Contains(row, col) || (isHorizontal && row >= fixedArea.Row) || (!isHorizontal && col >= fixedArea.Column))
					{
						return global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge;
					}
				}
				return global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable;
			}

			// Token: 0x060008DF RID: 2271 RVA: 0x00025400 File Offset: 0x00023600
			internal global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutItem GetItemFromPoint(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo point)
			{
				global::System.Windows.Point position = point.GetPosition(this._layoutContainerElem);
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VirtualCellInfo> cellInfo = this._layoutContainerElem.GetCellInfo(false);
				int i = 0;
				int count = cellInfo.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DataPresenter.VirtualCellInfo virtualCellInfo = cellInfo[i];
					if (virtualCellInfo.ClipRect.Contains(position) && virtualCellInfo.Element != null)
					{
						return new global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutItem(this._dragManager, this._layoutContainerElem, virtualCellInfo.ElementRect, virtualCellInfo.Field);
					}
					i++;
				}
				return null;
			}

			// Token: 0x060008E0 RID: 2272 RVA: 0x00025480 File Offset: 0x00023680
			internal global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo GetLayoutAreaRect()
			{
				global::System.Windows.Rect rectHelper = this.GetRectHelper(0, 0, this._logicalRowHeights.Length, this._logicalColumnWidths.Length, new global::System.Windows.Size(0.0, 0.0));
				return new global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo(this._dragManager, rectHelper, this._layoutContainerElem);
			}

			// Token: 0x060008E1 RID: 2273 RVA: 0x000254D0 File Offset: 0x000236D0
			internal void GetLogicalCellFromPoint(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo point, out int row, out int col)
			{
				global::System.Windows.Point position = point.GetPosition(this._layoutContainerElem);
				this._layoutContainerElem.AdjustDragPoint(ref position);
				row = this.GetLogicalRow(position.Y);
				col = this.GetLogicalColumn(position.X);
			}

			// Token: 0x060008E2 RID: 2274 RVA: 0x00025515 File Offset: 0x00023715
			private int GetLogicalColumn(double x)
			{
				return global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer.GetSlotContainingPoint(this._logicalColumnWidths, x - this._offsetFromContainerX);
			}

			// Token: 0x060008E3 RID: 2275 RVA: 0x0002552A File Offset: 0x0002372A
			private int GetLogicalRow(double y)
			{
				return global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer.GetSlotContainingPoint(this._logicalRowHeights, y - this._offsetFromContainerY);
			}

			// Token: 0x060008E4 RID: 2276 RVA: 0x00025540 File Offset: 0x00023740
			private global::System.Windows.Rect GetRectHelper(int row, int col, int rowSpan, int colSpan, global::System.Windows.Size defSize)
			{
				double num = global::Infragistics.Windows.DataPresenter.GridUtilities.ArrSum(this._logicalColumnWidths, 0, global::System.Math.Min(col, this._logicalColumnWidths.Length));
				double num2 = global::Infragistics.Windows.DataPresenter.GridUtilities.ArrSum(this._logicalRowHeights, 0, global::System.Math.Min(row, this._logicalRowHeights.Length));
				double width = (col + colSpan <= this._logicalColumnWidths.Length) ? global::Infragistics.Windows.DataPresenter.GridUtilities.ArrSum(this._logicalColumnWidths, col, colSpan) : defSize.Width;
				double height = (row + rowSpan <= this._logicalRowHeights.Length) ? global::Infragistics.Windows.DataPresenter.GridUtilities.ArrSum(this._logicalRowHeights, row, rowSpan) : defSize.Height;
				return new global::System.Windows.Rect(num + this._offsetFromContainerX, num2 + this._offsetFromContainerY, width, height);
			}

			// Token: 0x060008E5 RID: 2277 RVA: 0x000255E4 File Offset: 0x000237E4
			internal global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo GetRect(int row, int col, int rowSpan, int colSpan, global::System.Windows.Size defSize)
			{
				global::System.Windows.Rect rectHelper = this.GetRectHelper(row * 2 + 1, col * 2 + 1, rowSpan * 2 - 1, colSpan * 2 - 1, defSize);
				this.AdjustCellRect(row, col, ref rectHelper);
				return new global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo(this._dragManager, rectHelper, this._layoutContainerElem);
			}

			// Token: 0x060008E6 RID: 2278 RVA: 0x0002562C File Offset: 0x0002382C
			private static int GetSlotContainingPoint(double[] extents, double p)
			{
				int slotContainingPointImpl = global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer.GetSlotContainingPointImpl(extents, p);
				return slotContainingPointImpl / 2;
			}

			// Token: 0x060008E7 RID: 2279 RVA: 0x00025644 File Offset: 0x00023844
			private static int GetSlotContainingPointImpl(double[] extents, double p)
			{
				double num = 0.0;
				int i;
				for (i = 0; i < extents.Length; i++)
				{
					num += extents[i];
					if (p < num)
					{
						return i;
					}
				}
				return i;
			}

			// Token: 0x060008E8 RID: 2280 RVA: 0x00025678 File Offset: 0x00023878
			internal global::Infragistics.Windows.DataPresenter.FixedFieldSplitter GetSplitterFromPoint(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo point)
			{
				global::System.Windows.Media.HitTestResult hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(this._layoutContainerElem, point.GetPosition(this._layoutContainerElem));
				global::Infragistics.Windows.DataPresenter.FixedFieldSplitter fixedFieldSplitter = null;
				if (hitTestResult != null && hitTestResult.VisualHit != null)
				{
					fixedFieldSplitter = (hitTestResult.VisualHit as global::Infragistics.Windows.DataPresenter.FixedFieldSplitter);
					if (fixedFieldSplitter == null)
					{
						fixedFieldSplitter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(hitTestResult.VisualHit, typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), true) as global::Infragistics.Windows.DataPresenter.FixedFieldSplitter);
					}
				}
				return fixedFieldSplitter;
			}

			// Token: 0x060008E9 RID: 2281 RVA: 0x000256D8 File Offset: 0x000238D8
			internal bool HasItemAtLogicalCell(int row, int col, bool ignoreDragItem)
			{
				global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = this._dragManager._layoutInfo;
				if (layoutInfo != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.Field field in layoutInfo.Keys)
					{
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = layoutInfo[field];
						if (itemLayoutInfo.Column == col && itemLayoutInfo.Row == row && (!ignoreDragItem || field != this._dragManager._dragField))
						{
							return true;
						}
					}
					return false;
				}
				return false;
			}

			// Token: 0x060008EA RID: 2282 RVA: 0x00025764 File Offset: 0x00023964
			private void InitializeLogicalRowColDims()
			{
				global::System.Collections.Generic.List<double> list = new global::System.Collections.Generic.List<double>();
				global::System.Collections.Generic.List<double> list2 = new global::System.Collections.Generic.List<double>();
				this._layoutContainerElem.GetLogicalCellDimensions(list, list2);
				this._logicalColumnWidths = list2.ToArray();
				this._logicalRowHeights = list.ToArray();
				this._offsetFromContainerX = (this._offsetFromContainerY = 0.0);
			}

			// Token: 0x17000205 RID: 517
			// (get) Token: 0x060008EB RID: 2283 RVA: 0x000257BA File Offset: 0x000239BA
			internal global::Infragistics.Windows.DataPresenter.FieldDragManager DragManager
			{
				get
				{
					return this._dragManager;
				}
			}

			// Token: 0x0400036D RID: 877
			private global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel _layoutContainerElem;

			// Token: 0x0400036E RID: 878
			private global::Infragistics.Windows.DataPresenter.FieldDragManager _dragManager;

			// Token: 0x0400036F RID: 879
			private double[] _logicalColumnWidths;

			// Token: 0x04000370 RID: 880
			private double[] _logicalRowHeights;

			// Token: 0x04000371 RID: 881
			private double _offsetFromContainerX;

			// Token: 0x04000372 RID: 882
			private double _offsetFromContainerY;
		}

		// Token: 0x020000BE RID: 190
		private class LayoutItem
		{
			// Token: 0x060008EC RID: 2284 RVA: 0x000257C2 File Offset: 0x000239C2
			internal LayoutItem(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::System.Windows.FrameworkElement element, global::System.Windows.Rect elementRect, global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(element);
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dragManager);
				this._element = element;
				this._dragManager = dragManager;
				this._elementRect = elementRect;
				this._field = field;
			}

			// Token: 0x17000206 RID: 518
			// (get) Token: 0x060008ED RID: 2285 RVA: 0x000257F3 File Offset: 0x000239F3
			internal double ActualWidth
			{
				get
				{
					return this._elementRect.Width;
				}
			}

			// Token: 0x17000207 RID: 519
			// (get) Token: 0x060008EE RID: 2286 RVA: 0x00025800 File Offset: 0x00023A00
			internal double ActualHeight
			{
				get
				{
					return this._elementRect.Height;
				}
			}

			// Token: 0x17000208 RID: 520
			// (get) Token: 0x060008EF RID: 2287 RVA: 0x00025810 File Offset: 0x00023A10
			internal global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo Rect
			{
				get
				{
					global::System.Windows.Rect elementRect = this._elementRect;
					return new global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo(this._dragManager, elementRect, this._element);
				}
			}

			// Token: 0x17000209 RID: 521
			// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00025836 File Offset: 0x00023A36
			internal global::Infragistics.Windows.DataPresenter.Field Field
			{
				get
				{
					return this._field;
				}
			}

			// Token: 0x04000373 RID: 883
			private global::System.Windows.FrameworkElement _element;

			// Token: 0x04000374 RID: 884
			private global::Infragistics.Windows.DataPresenter.FieldDragManager _dragManager;

			// Token: 0x04000375 RID: 885
			private global::System.Windows.Rect _elementRect;

			// Token: 0x04000376 RID: 886
			private global::Infragistics.Windows.DataPresenter.Field _field;
		}

		// Token: 0x020000BF RID: 191
		internal class RectInfo
		{
			// Token: 0x060008F1 RID: 2289 RVA: 0x0002583E File Offset: 0x00023A3E
			internal RectInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::System.Windows.Rect rect, global::System.Windows.FrameworkElement relativeTo)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dragManager);
				this._dragManager = dragManager;
				this._rect = rect;
				this._relativeTo = relativeTo;
			}

			// Token: 0x060008F2 RID: 2290 RVA: 0x00025861 File Offset: 0x00023A61
			internal global::System.Windows.Rect GetRectInScreen()
			{
				return this.GetRect(null);
			}

			// Token: 0x060008F3 RID: 2291 RVA: 0x0002586A File Offset: 0x00023A6A
			internal global::System.Windows.Rect GetRect()
			{
				return this.GetRect(this._dragManager._dataPresenter);
			}

			// Token: 0x060008F4 RID: 2292 RVA: 0x00025880 File Offset: 0x00023A80
			internal global::System.Windows.Rect GetRect(global::System.Windows.UIElement relativeTo)
			{
				global::System.Windows.Point point = global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo.TranslatePointHelper(this._rect.TopLeft, this._relativeTo, relativeTo);
				global::System.Windows.Point point2 = global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo.TranslatePointHelper(this._rect.BottomRight, this._relativeTo, relativeTo);
				return global::Infragistics.Windows.Utilities.RectFromPoints(point, point2);
			}

			// Token: 0x060008F5 RID: 2293 RVA: 0x000258C4 File Offset: 0x00023AC4
			internal bool Contains(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo point)
			{
				global::System.Windows.Rect rect = this.GetRect();
				global::System.Windows.Point position = point.GetPosition();
				return rect.Contains(position);
			}

			// Token: 0x04000377 RID: 887
			private global::Infragistics.Windows.DataPresenter.FieldDragManager _dragManager;

			// Token: 0x04000378 RID: 888
			private global::System.Windows.Rect _rect;

			// Token: 0x04000379 RID: 889
			private global::System.Windows.FrameworkElement _relativeTo;
		}

		// Token: 0x020000C0 RID: 192
		internal class PointInfo
		{
			// Token: 0x060008F6 RID: 2294 RVA: 0x000258E7 File Offset: 0x00023AE7
			internal PointInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::System.Windows.Point point, global::System.Windows.FrameworkElement relativeTo)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dragManager);
				this._dragManager = dragManager;
				this._point = point;
				this._relativeTo = relativeTo;
			}

			// Token: 0x060008F7 RID: 2295 RVA: 0x0002590A File Offset: 0x00023B0A
			internal global::System.Windows.Point GetPosition()
			{
				return this.GetPosition(this._dragManager._dataPresenter);
			}

			// Token: 0x060008F8 RID: 2296 RVA: 0x0002591D File Offset: 0x00023B1D
			internal global::System.Windows.Point GetPositionInScreen()
			{
				return this.GetPosition(null);
			}

			// Token: 0x060008F9 RID: 2297 RVA: 0x00025926 File Offset: 0x00023B26
			internal global::System.Windows.Point GetPosition(global::System.Windows.UIElement relativeTo)
			{
				return global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo.TranslatePointHelper(this._point, this._relativeTo, relativeTo);
			}

			// Token: 0x060008FA RID: 2298 RVA: 0x0002593C File Offset: 0x00023B3C
			internal static global::System.Windows.Point TranslatePointHelper(global::System.Windows.Point p, global::System.Windows.UIElement currentRelativeTo, global::System.Windows.UIElement relativeTo)
			{
				if (currentRelativeTo != relativeTo)
				{
					if (relativeTo == null)
					{
						try
						{
							return global::Infragistics.Windows.Utilities.PointToScreenSafe(currentRelativeTo, p);
						}
						catch
						{
							p = new global::System.Windows.Point(double.MinValue, double.MinValue);
							return p;
						}
					}
					if (currentRelativeTo != null)
					{
						p = currentRelativeTo.TranslatePoint(p, relativeTo);
					}
					else
					{
						p = global::Infragistics.Windows.Utilities.PointFromScreenSafe(relativeTo, p);
					}
				}
				return p;
			}

			// Token: 0x060008FB RID: 2299 RVA: 0x000259A0 File Offset: 0x00023BA0
			internal bool IsInsideDataPresenter()
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.DoesElementContainPoint(this._dragManager._dataPresenter, this.GetPosition());
			}

			// Token: 0x060008FC RID: 2300 RVA: 0x000259B8 File Offset: 0x00023BB8
			internal bool IsMouseOverFieldChooser()
			{
				global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser;
				return this.IsMouseOverFieldChooser(out fieldChooser);
			}

			// Token: 0x060008FD RID: 2301 RVA: 0x000259D0 File Offset: 0x00023BD0
			internal bool IsMouseOverFieldChooser(out global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._dragManager._dataPresenter;
				global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.FieldChooser> registeredFieldChoosers = dataPresenter._registeredFieldChoosers;
				if (registeredFieldChoosers != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser2 in registeredFieldChoosers)
					{
						if (fieldChooser2.IsVisible)
						{
							global::System.Windows.Media.HitTestResult hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(fieldChooser2, this.GetPosition(fieldChooser2));
							if (hitTestResult != null && hitTestResult.VisualHit != null)
							{
								global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser3 = (global::Infragistics.Windows.DataPresenter.FieldChooser)global::Infragistics.Windows.Utilities.GetAncestorFromType(hitTestResult.VisualHit, typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), true);
								if (fieldChooser3 == fieldChooser2)
								{
									fieldChooser = fieldChooser3;
									return true;
								}
							}
						}
					}
				}
				fieldChooser = null;
				return false;
			}

			// Token: 0x060008FE RID: 2302 RVA: 0x00025A80 File Offset: 0x00023C80
			internal bool IsMouseOverGroupByAreaMulti()
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._dragManager._dataPresenter;
				global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = dataPresenter.GroupByAreaMulti;
				if (groupByAreaMulti == null || !groupByAreaMulti.IsVisible)
				{
					return false;
				}
				global::System.Windows.Media.HitTestResult hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(groupByAreaMulti, this.GetPosition(groupByAreaMulti));
				global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti2 = null;
				if (hitTestResult != null && hitTestResult.VisualHit != null)
				{
					groupByAreaMulti2 = (hitTestResult.VisualHit as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti);
					if (groupByAreaMulti2 == null)
					{
						groupByAreaMulti2 = (global::Infragistics.Windows.Utilities.GetAncestorFromType(hitTestResult.VisualHit, typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), true) as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti);
					}
				}
				return groupByAreaMulti2 == groupByAreaMulti;
			}

			// Token: 0x0400037A RID: 890
			private global::Infragistics.Windows.DataPresenter.FieldDragManager _dragManager;

			// Token: 0x0400037B RID: 891
			private global::System.Windows.Point _point;

			// Token: 0x0400037C RID: 892
			private global::System.Windows.FrameworkElement _relativeTo;
		}
	}
}
