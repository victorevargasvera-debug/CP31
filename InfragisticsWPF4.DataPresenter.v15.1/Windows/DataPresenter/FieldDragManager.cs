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
	// Token: 0x020000A4 RID: 164
	internal class FieldDragManager
	{
		// Token: 0x06000830 RID: 2096 RVA: 0x00022CFC File Offset: 0x00020EFC
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
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.GetAllFields(true))
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

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00022EA8 File Offset: 0x000210A8
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00022EB0 File Offset: 0x000210B0
		internal global::Infragistics.Windows.DataPresenter.Field DragField
		{
			get
			{
				return this._dragField;
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00022EB8 File Offset: 0x000210B8
		private int AdjustGroupByAreaMultiInsertAtIndex(int insertAtIndex, global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType dropType, global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields)
		{
			if (dropType == global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType.Regrouping)
			{
				int num = sortedFields.IndexOf(this._dragField, new bool?(true));
				if (num < insertAtIndex)
				{
					insertAtIndex--;
				}
			}
			return insertAtIndex;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00022EE8 File Offset: 0x000210E8
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

		// Token: 0x06000835 RID: 2101 RVA: 0x0002326C File Offset: 0x0002146C
		private global::Infragistics.Windows.Selection.ScrollSpeed CalcScrollSpeed(double distance)
		{
			double num = 200.0;
			int val = 0;
			int num2 = 6;
			return (global::Infragistics.Windows.Selection.ScrollSpeed)global::System.Math.Max(val, global::System.Math.Min(num2, (int)((double)num2 * (distance / num))));
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0002329C File Offset: 0x0002149C
		internal static void ChangeFieldVisibilityViaFieldChooser(global::Infragistics.Windows.DataPresenter.Field field, bool newVisibility)
		{
			global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager = new global::Infragistics.Windows.DataPresenter.FieldDragManager(field, null, null);
			global::Infragistics.Windows.DataPresenter.FieldChooserDropType fieldChooserDropType = newVisibility ? global::Infragistics.Windows.DataPresenter.FieldChooserDropType.ShowField : global::Infragistics.Windows.DataPresenter.FieldChooserDropType.HideField;
			global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo dropInfo = new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(dragManager, fieldChooserDropType);
			dropInfo.ApplyDrop();
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000232CC File Offset: 0x000214CC
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

		// Token: 0x06000838 RID: 2104 RVA: 0x00023358 File Offset: 0x00021558
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

		// Token: 0x06000839 RID: 2105 RVA: 0x000234FC File Offset: 0x000216FC
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

		// Token: 0x0600083A RID: 2106 RVA: 0x000237CC File Offset: 0x000219CC
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

		// Token: 0x0600083B RID: 2107 RVA: 0x00023804 File Offset: 0x00021A04
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

		// Token: 0x0600083C RID: 2108 RVA: 0x00023968 File Offset: 0x00021B68
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
						num = sortedFields.IndexOf(labelPresenter2.Field, new bool?(true));
						num = this.AdjustGroupByAreaMultiInsertAtIndex(num, dropType, sortedFields);
						break;
					}
				}
				if (frameworkElement == null)
				{
					frameworkElement = labelPresenters[labelPresenters.Count - 1];
					dropLocation = global::Infragistics.Windows.Controls.DropLocation.RightOfTarget;
					num = sortedFields.IndexOf(labelPresenters[labelPresenters.Count - 1].Field, new bool?(true)) + 1;
					num = this.AdjustGroupByAreaMultiInsertAtIndex(num, dropType, sortedFields);
				}
			}
			return new global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo(this, dropType, new global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo(this, new global::System.Windows.Rect(frameworkElement.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), groupByAreaMulti), new global::System.Windows.Size(frameworkElement.ActualWidth, frameworkElement.ActualHeight)), groupByAreaMulti), dropLocation, num, false);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00023C84 File Offset: 0x00021E84
		private global::Infragistics.Windows.DataPresenter.ItemLayoutInfo GetItemLayoutInfo(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this._layoutInfo[field];
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00023C94 File Offset: 0x00021E94
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

		// Token: 0x0600083F RID: 2111 RVA: 0x00023D0C File Offset: 0x00021F0C
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

		// Token: 0x06000840 RID: 2112 RVA: 0x00023D80 File Offset: 0x00021F80
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

		// Token: 0x06000841 RID: 2113 RVA: 0x00023EE0 File Offset: 0x000220E0
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

		// Token: 0x06000842 RID: 2114 RVA: 0x000240E2 File Offset: 0x000222E2
		internal void HideDragIndicator()
		{
			if (this._dragIndicatorWindow != null)
			{
				this._dragIndicatorWindow.Close();
				this._dragIndicatorShown = false;
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00024100 File Offset: 0x00022300
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

		// Token: 0x06000844 RID: 2116 RVA: 0x00024150 File Offset: 0x00022350
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

		// Token: 0x06000845 RID: 2117 RVA: 0x000241A4 File Offset: 0x000223A4
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

		// Token: 0x06000846 RID: 2118 RVA: 0x00024238 File Offset: 0x00022438
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

		// Token: 0x06000847 RID: 2119 RVA: 0x00024284 File Offset: 0x00022484
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

		// Token: 0x06000848 RID: 2120 RVA: 0x00024330 File Offset: 0x00022530
		internal void OnMouseMove(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo mouseLoc = new global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo(this, mouseEventArgs.GetPosition(this._dataPresenter), this._dataPresenter);
			this.DragHelper(mouseLoc, false);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00024360 File Offset: 0x00022560
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

		// Token: 0x0600084A RID: 2122 RVA: 0x00024504 File Offset: 0x00022704
		private void PositionToolWindow(global::Infragistics.Windows.DataPresenter.DragToolWindow toolWindow, global::System.Windows.Point screenPoint)
		{
			global::System.Windows.Point relativePoint = global::Infragistics.Windows.Utilities.PointFromScreenSafe(this._dataPresenter, screenPoint);
			global::System.Windows.FrameworkElement owner = toolWindow.Owner ?? this._dataPresenter;
			relativePoint = global::Infragistics.Windows.Controls.ToolWindow.GetScreenPoint(owner, relativePoint, this._dataPresenter, toolWindow._toolWindowHostType);
			toolWindow.Left = relativePoint.X;
			toolWindow.Top = relativePoint.Y;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00024560 File Offset: 0x00022760
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
				if (frameworkElement is global::System.Windows.Controls.Control)
				{
					dragToolWindow.FontSize = ((global::System.Windows.Controls.Control)frameworkElement).FontSize;
				}
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

		// Token: 0x0600084C RID: 2124 RVA: 0x000246D4 File Offset: 0x000228D4
		private void ShowDropIndicator(global::Infragistics.Windows.DataPresenter.FieldDragManager.DropInfo dropInfo)
		{
			if (this._dropIndicatorWindow == null)
			{
				global::Infragistics.Windows.DataPresenter.DragToolWindow dragToolWindow = new global::Infragistics.Windows.DataPresenter.DragToolWindow(this._dataPresenter);
				global::Infragistics.Windows.Controls.DropIndicator content = new global::Infragistics.Windows.Controls.DropIndicator();
				dragToolWindow.Content = content;
				if (global::Infragistics.Windows.DataPresenter.DropIndicatorClipBehavior.Clip == this._dataPresenter.DropIndicatorClipBehaviorResolved)
				{
					dragToolWindow._toolWindowHostType = global::Infragistics.Windows.Controls.ToolWindowHostType.Adorner;
				}
				this._dropIndicatorWindow = dragToolWindow;
			}
			bool flag = dropInfo.InitializeDropIndicator(this._dropIndicatorWindow);
			if (flag)
			{
				if (!this._dropIndicatorShown)
				{
					this._dropIndicatorWindow.Show(this._dataPresenter, false, this._dropIndicatorWindow._toolWindowHostType);
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

		// Token: 0x0600084D RID: 2125 RVA: 0x0002478C File Offset: 0x0002298C
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

		// Token: 0x0400035A RID: 858
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x0400035B RID: 859
		private global::Infragistics.Windows.DataPresenter.Field _dragField;

		// Token: 0x0400035C RID: 860
		private global::Infragistics.Windows.DataPresenter.ItemLayoutInfo _dragItemLayoutInfo;

		// Token: 0x0400035D RID: 861
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x0400035E RID: 862
		private global::System.Windows.FrameworkElement _dragElement;

		// Token: 0x0400035F RID: 863
		private global::Infragistics.Windows.DataPresenter.DragToolWindow _dragIndicatorWindow;

		// Token: 0x04000360 RID: 864
		private global::System.Windows.Point _dragIndicatorWindow_OffsetFromMouse;

		// Token: 0x04000361 RID: 865
		private global::Infragistics.Windows.DataPresenter.DragToolWindow _dropIndicatorWindow;

		// Token: 0x04000362 RID: 866
		private global::Infragistics.Windows.DataPresenter.LayoutInfo _layoutInfo;

		// Token: 0x04000363 RID: 867
		private bool _dropIndicatorShown;

		// Token: 0x04000364 RID: 868
		private bool _dragIndicatorShown;

		// Token: 0x04000365 RID: 869
		private global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer _layoutContainerToUse;

		// Token: 0x04000366 RID: 870
		private global::System.Windows.Threading.DispatcherTimer _scrollTimer;

		// Token: 0x04000367 RID: 871
		private bool _isGroupByMultiEnabled;

		// Token: 0x04000368 RID: 872
		internal global::System.Windows.Input.MouseEventArgs _selectionHost_LastDragMoveEventArgs;

		// Token: 0x04000369 RID: 873
		private global::Infragistics.Windows.DataPresenter.FieldChooser _sourceFieldChooser;

		// Token: 0x0400036A RID: 874
		private bool _isDraggingFromFieldChooser;

		// Token: 0x0400036B RID: 875
		private bool _isDraggingFromGroupByArea;

		// Token: 0x0400036C RID: 876
		private global::Infragistics.Windows.DataPresenter.FieldChooser _lastFieldChooserWithMouseOver;

		// Token: 0x0400036D RID: 877
		private bool _scrollTimer_hasMouseBeenInDataPresenter;

		// Token: 0x020000A5 RID: 165
		private class DropInfo
		{
			// Token: 0x0600084E RID: 2126 RVA: 0x000247F4 File Offset: 0x000229F4
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

			// Token: 0x0600084F RID: 2127 RVA: 0x00024870 File Offset: 0x00022A70
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

			// Token: 0x06000850 RID: 2128 RVA: 0x00024918 File Offset: 0x00022B18
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

			// Token: 0x06000851 RID: 2129 RVA: 0x00024968 File Offset: 0x00022B68
			internal DropInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer layoutContainer, bool isDragAreaInvalid)
			{
				this._isDragAreaInvalid = isDragAreaInvalid;
				this.Initialize(dragManager, layoutContainer, global::Infragistics.Windows.Controls.DropLocation.None, null, null);
			}

			// Token: 0x06000852 RID: 2130 RVA: 0x00024982 File Offset: 0x00022B82
			internal DropInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType groupByAreaMultiDropType, global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo targetRect, global::Infragistics.Windows.Controls.DropLocation dropLocation, int groupByAreaMultiInsertAtIndex, bool isDropNOOP)
			{
				this._dragManager = dragManager;
				this._groupByAreaMultiDropType = groupByAreaMultiDropType;
				this._dropTargetRect = targetRect;
				this._dropLocation = dropLocation;
				this._groupByAreaMultiInsertAtIndex = groupByAreaMultiInsertAtIndex;
				this._isDropNOOP = isDropNOOP;
			}

			// Token: 0x06000853 RID: 2131 RVA: 0x000249B8 File Offset: 0x00022BB8
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

			// Token: 0x06000854 RID: 2132 RVA: 0x00024A00 File Offset: 0x00022C00
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

			// Token: 0x06000855 RID: 2133 RVA: 0x00024BF0 File Offset: 0x00022DF0
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

			// Token: 0x06000856 RID: 2134 RVA: 0x00024CAC File Offset: 0x00022EAC
			private void EnsureProcessed()
			{
				if (!this._isProcessed)
				{
					this.ProcessHelper();
					this._isProcessed = true;
				}
			}

			// Token: 0x06000857 RID: 2135 RVA: 0x00024CC4 File Offset: 0x00022EC4
			internal static global::Infragistics.Windows.Controls.DropIndicator GetDropIndicator(global::Infragistics.Windows.DataPresenter.DragToolWindow indicatorWindow)
			{
				global::Infragistics.Windows.Controls.DropIndicator dropIndicator = (global::Infragistics.Windows.Controls.DropIndicator)global::Infragistics.Windows.Utilities.GetDescendantFromType(indicatorWindow, typeof(global::Infragistics.Windows.Controls.DropIndicator), true);
				if (dropIndicator == null)
				{
					dropIndicator = (indicatorWindow.Content as global::Infragistics.Windows.Controls.DropIndicator);
				}
				return dropIndicator;
			}

			// Token: 0x06000858 RID: 2136 RVA: 0x00024CF8 File Offset: 0x00022EF8
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

			// Token: 0x06000859 RID: 2137 RVA: 0x00024D64 File Offset: 0x00022F64
			private static bool HasLogicalColumnChanged(global::Infragistics.Windows.DataPresenter.LayoutInfo origInfo, global::Infragistics.Windows.DataPresenter.LayoutInfo newInfo)
			{
				bool result;
				bool flag;
				origInfo.HasLogicalColumnOrRowChanged(newInfo, out result, out flag);
				return result;
			}

			// Token: 0x0600085A RID: 2138 RVA: 0x00024D80 File Offset: 0x00022F80
			private static bool HasLogicalRowChanged(global::Infragistics.Windows.DataPresenter.LayoutInfo origInfo, global::Infragistics.Windows.DataPresenter.LayoutInfo newInfo)
			{
				bool flag;
				bool result;
				origInfo.HasLogicalColumnOrRowChanged(newInfo, out flag, out result);
				return result;
			}

			// Token: 0x0600085B RID: 2139 RVA: 0x00024D99 File Offset: 0x00022F99
			private void Initialize(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer layoutContainer, global::Infragistics.Windows.Controls.DropLocation dropLocation, global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutItem dropTargetItem, global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo dropTargetRect)
			{
				this._dragManager = dragManager;
				this._layoutContainer = layoutContainer;
				this._dropLocation = dropLocation;
				this._dropTargetItem = dropTargetItem;
				this._dropTargetRect = dropTargetRect;
			}

			// Token: 0x0600085C RID: 2140 RVA: 0x00024DC0 File Offset: 0x00022FC0
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

			// Token: 0x0600085D RID: 2141 RVA: 0x00024EE4 File Offset: 0x000230E4
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

			// Token: 0x0600085E RID: 2142 RVA: 0x00025010 File Offset: 0x00023210
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

			// Token: 0x0600085F RID: 2143 RVA: 0x000250B8 File Offset: 0x000232B8
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
				if (!this._dragManager._dragField.IsValid)
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

			// Token: 0x06000860 RID: 2144 RVA: 0x00025250 File Offset: 0x00023450
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

			// Token: 0x17000215 RID: 533
			// (get) Token: 0x06000861 RID: 2145 RVA: 0x0002540C File Offset: 0x0002360C
			internal global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType GroupByAreaMultiDropType
			{
				get
				{
					return this._groupByAreaMultiDropType;
				}
			}

			// Token: 0x17000216 RID: 534
			// (get) Token: 0x06000862 RID: 2146 RVA: 0x00025414 File Offset: 0x00023614
			internal bool IsDragAreaInvalid
			{
				get
				{
					return this._isDragAreaInvalid;
				}
			}

			// Token: 0x17000217 RID: 535
			// (get) Token: 0x06000863 RID: 2147 RVA: 0x0002541C File Offset: 0x0002361C
			internal bool IsDropNOOP
			{
				get
				{
					this.EnsureProcessed();
					return this._isDropNOOP;
				}
			}

			// Token: 0x17000218 RID: 536
			// (get) Token: 0x06000864 RID: 2148 RVA: 0x0002542A File Offset: 0x0002362A
			internal bool IsDropValid
			{
				get
				{
					this.EnsureProcessed();
					return this._isDropValid;
				}
			}

			// Token: 0x0400036E RID: 878
			private global::Infragistics.Windows.DataPresenter.FieldDragManager _dragManager;

			// Token: 0x0400036F RID: 879
			private global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer _layoutContainer;

			// Token: 0x04000370 RID: 880
			private global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutItem _dropTargetItem;

			// Token: 0x04000371 RID: 881
			private global::Infragistics.Windows.Controls.DropLocation _dropLocation;

			// Token: 0x04000372 RID: 882
			private global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo _dropTargetRect;

			// Token: 0x04000373 RID: 883
			private global::Infragistics.Windows.DataPresenter.ItemLayoutInfo _newDragItemLayoutInfo;

			// Token: 0x04000374 RID: 884
			private global::Infragistics.Windows.DataPresenter.LayoutInfo _origLayoutInfo;

			// Token: 0x04000375 RID: 885
			private global::Infragistics.Windows.DataPresenter.LayoutInfo _newLayoutInfo;

			// Token: 0x04000376 RID: 886
			private bool _isProcessed;

			// Token: 0x04000377 RID: 887
			private bool _isDropValid;

			// Token: 0x04000378 RID: 888
			private bool _isDropNOOP;

			// Token: 0x04000379 RID: 889
			private bool _isDragAreaInvalid;

			// Token: 0x0400037A RID: 890
			private global::Infragistics.Windows.DataPresenter.GroupByAreaMultiDropType _groupByAreaMultiDropType;

			// Token: 0x0400037B RID: 891
			private int _groupByAreaMultiInsertAtIndex;

			// Token: 0x0400037C RID: 892
			internal global::Infragistics.Windows.DataPresenter.FieldChooserDropType _fieldChooserDropType;

			// Token: 0x020000C5 RID: 197
			private class MeetsCriteria_IntersectingItems : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
			{
				// Token: 0x06000987 RID: 2439 RVA: 0x00028D21 File Offset: 0x00026F21
				public MeetsCriteria_IntersectingItems(int col, int row, int colSpan, int rowSpan, bool fullyContainedItemsOnly)
				{
					this._col = col;
					this._row = row;
					this._colSpan = colSpan;
					this._rowSpan = rowSpan;
					this._fullyContainedItemsOnly = fullyContainedItemsOnly;
				}

				// Token: 0x06000988 RID: 2440 RVA: 0x00028D50 File Offset: 0x00026F50
				public bool MeetsCriteria(object itemObj)
				{
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo)itemObj;
					if (this._fullyContainedItemsOnly)
					{
						return itemLayoutInfo.Column >= this._col && itemLayoutInfo.Column + itemLayoutInfo.ColumnSpan <= this._col + this._colSpan && itemLayoutInfo.Row >= this._row && itemLayoutInfo.Row + itemLayoutInfo.RowSpan <= this._row + this._rowSpan;
					}
					return global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(this._col, this._colSpan, itemLayoutInfo.Column, itemLayoutInfo.ColumnSpan) && global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(this._row, this._rowSpan, itemLayoutInfo.Row, itemLayoutInfo.RowSpan);
				}

				// Token: 0x040003C3 RID: 963
				private int _col;

				// Token: 0x040003C4 RID: 964
				private int _row;

				// Token: 0x040003C5 RID: 965
				private int _colSpan;

				// Token: 0x040003C6 RID: 966
				private int _rowSpan;

				// Token: 0x040003C7 RID: 967
				private bool _fullyContainedItemsOnly;
			}
		}

		// Token: 0x020000C6 RID: 198
		private class LayoutContainer
		{
			// Token: 0x06000989 RID: 2441 RVA: 0x00028E04 File Offset: 0x00027004
			internal LayoutContainer(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel layoutContainerElem)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dragManager);
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(layoutContainerElem);
				this._dragManager = dragManager;
				this._layoutContainerElem = layoutContainerElem;
				this.InitializeLogicalRowColDims();
			}

			// Token: 0x0600098A RID: 2442 RVA: 0x00028E2C File Offset: 0x0002702C
			private void AdjustCellRect(int row, int col, ref global::System.Windows.Rect rect)
			{
				global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation = this.GetFixedLocation(row, col);
				global::System.Windows.Vector fixedAreaOffset = this._layoutContainerElem.GetFixedAreaOffset(fixedLocation, false);
				rect.Offset(fixedAreaOffset);
			}

			// Token: 0x0600098B RID: 2443 RVA: 0x00028E58 File Offset: 0x00027058
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

			// Token: 0x0600098C RID: 2444 RVA: 0x00028EE8 File Offset: 0x000270E8
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

			// Token: 0x0600098D RID: 2445 RVA: 0x00028F68 File Offset: 0x00027168
			internal global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo GetLayoutAreaRect()
			{
				global::System.Windows.Rect rectHelper = this.GetRectHelper(0, 0, this._logicalRowHeights.Length, this._logicalColumnWidths.Length, new global::System.Windows.Size(0.0, 0.0));
				return new global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo(this._dragManager, rectHelper, this._layoutContainerElem);
			}

			// Token: 0x0600098E RID: 2446 RVA: 0x00028FB8 File Offset: 0x000271B8
			internal void GetLogicalCellFromPoint(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo point, out int row, out int col)
			{
				global::System.Windows.Point position = point.GetPosition(this._layoutContainerElem);
				this._layoutContainerElem.AdjustDragPoint(ref position);
				row = this.GetLogicalRow(position.Y);
				col = this.GetLogicalColumn(position.X);
			}

			// Token: 0x0600098F RID: 2447 RVA: 0x00028FFD File Offset: 0x000271FD
			private int GetLogicalColumn(double x)
			{
				return global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer.GetSlotContainingPoint(this._logicalColumnWidths, x - this._offsetFromContainerX);
			}

			// Token: 0x06000990 RID: 2448 RVA: 0x00029012 File Offset: 0x00027212
			private int GetLogicalRow(double y)
			{
				return global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer.GetSlotContainingPoint(this._logicalRowHeights, y - this._offsetFromContainerY);
			}

			// Token: 0x06000991 RID: 2449 RVA: 0x00029028 File Offset: 0x00027228
			private global::System.Windows.Rect GetRectHelper(int row, int col, int rowSpan, int colSpan, global::System.Windows.Size defSize)
			{
				double num = global::Infragistics.Windows.DataPresenter.GridUtilities.ArrSum(this._logicalColumnWidths, 0, global::System.Math.Min(col, this._logicalColumnWidths.Length));
				double num2 = global::Infragistics.Windows.DataPresenter.GridUtilities.ArrSum(this._logicalRowHeights, 0, global::System.Math.Min(row, this._logicalRowHeights.Length));
				double width = (col + colSpan <= this._logicalColumnWidths.Length) ? global::Infragistics.Windows.DataPresenter.GridUtilities.ArrSum(this._logicalColumnWidths, col, colSpan) : defSize.Width;
				double height = (row + rowSpan <= this._logicalRowHeights.Length) ? global::Infragistics.Windows.DataPresenter.GridUtilities.ArrSum(this._logicalRowHeights, row, rowSpan) : defSize.Height;
				return new global::System.Windows.Rect(num + this._offsetFromContainerX, num2 + this._offsetFromContainerY, width, height);
			}

			// Token: 0x06000992 RID: 2450 RVA: 0x000290CC File Offset: 0x000272CC
			internal global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo GetRect(int row, int col, int rowSpan, int colSpan, global::System.Windows.Size defSize)
			{
				global::System.Windows.Rect rectHelper = this.GetRectHelper(row * 2 + 1, col * 2 + 1, rowSpan * 2 - 1, colSpan * 2 - 1, defSize);
				this.AdjustCellRect(row, col, ref rectHelper);
				return new global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo(this._dragManager, rectHelper, this._layoutContainerElem);
			}

			// Token: 0x06000993 RID: 2451 RVA: 0x00029114 File Offset: 0x00027314
			private static int GetSlotContainingPoint(double[] extents, double p)
			{
				int slotContainingPointImpl = global::Infragistics.Windows.DataPresenter.FieldDragManager.LayoutContainer.GetSlotContainingPointImpl(extents, p);
				return slotContainingPointImpl / 2;
			}

			// Token: 0x06000994 RID: 2452 RVA: 0x0002912C File Offset: 0x0002732C
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

			// Token: 0x06000995 RID: 2453 RVA: 0x00029160 File Offset: 0x00027360
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

			// Token: 0x06000996 RID: 2454 RVA: 0x000291C0 File Offset: 0x000273C0
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

			// Token: 0x06000997 RID: 2455 RVA: 0x0002924C File Offset: 0x0002744C
			private void InitializeLogicalRowColDims()
			{
				global::System.Collections.Generic.List<double> list = new global::System.Collections.Generic.List<double>();
				global::System.Collections.Generic.List<double> list2 = new global::System.Collections.Generic.List<double>();
				this._layoutContainerElem.GetLogicalCellDimensions(list, list2);
				this._logicalColumnWidths = list2.ToArray();
				this._logicalRowHeights = list.ToArray();
				this._offsetFromContainerX = (this._offsetFromContainerY = 0.0);
			}

			// Token: 0x17000232 RID: 562
			// (get) Token: 0x06000998 RID: 2456 RVA: 0x000292A2 File Offset: 0x000274A2
			internal global::Infragistics.Windows.DataPresenter.FieldDragManager DragManager
			{
				get
				{
					return this._dragManager;
				}
			}

			// Token: 0x040003C8 RID: 968
			private global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel _layoutContainerElem;

			// Token: 0x040003C9 RID: 969
			private global::Infragistics.Windows.DataPresenter.FieldDragManager _dragManager;

			// Token: 0x040003CA RID: 970
			private double[] _logicalColumnWidths;

			// Token: 0x040003CB RID: 971
			private double[] _logicalRowHeights;

			// Token: 0x040003CC RID: 972
			private double _offsetFromContainerX;

			// Token: 0x040003CD RID: 973
			private double _offsetFromContainerY;
		}

		// Token: 0x020000C7 RID: 199
		private class LayoutItem
		{
			// Token: 0x06000999 RID: 2457 RVA: 0x000292AA File Offset: 0x000274AA
			internal LayoutItem(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::System.Windows.FrameworkElement element, global::System.Windows.Rect elementRect, global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(element);
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dragManager);
				this._element = element;
				this._dragManager = dragManager;
				this._elementRect = elementRect;
				this._field = field;
			}

			// Token: 0x17000233 RID: 563
			// (get) Token: 0x0600099A RID: 2458 RVA: 0x000292DB File Offset: 0x000274DB
			internal double ActualWidth
			{
				get
				{
					return this._elementRect.Width;
				}
			}

			// Token: 0x17000234 RID: 564
			// (get) Token: 0x0600099B RID: 2459 RVA: 0x000292E8 File Offset: 0x000274E8
			internal double ActualHeight
			{
				get
				{
					return this._elementRect.Height;
				}
			}

			// Token: 0x17000235 RID: 565
			// (get) Token: 0x0600099C RID: 2460 RVA: 0x000292F8 File Offset: 0x000274F8
			internal global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo Rect
			{
				get
				{
					global::System.Windows.Rect elementRect = this._elementRect;
					return new global::Infragistics.Windows.DataPresenter.FieldDragManager.RectInfo(this._dragManager, elementRect, this._element);
				}
			}

			// Token: 0x17000236 RID: 566
			// (get) Token: 0x0600099D RID: 2461 RVA: 0x0002931E File Offset: 0x0002751E
			internal global::Infragistics.Windows.DataPresenter.Field Field
			{
				get
				{
					return this._field;
				}
			}

			// Token: 0x040003CE RID: 974
			private global::System.Windows.FrameworkElement _element;

			// Token: 0x040003CF RID: 975
			private global::Infragistics.Windows.DataPresenter.FieldDragManager _dragManager;

			// Token: 0x040003D0 RID: 976
			private global::System.Windows.Rect _elementRect;

			// Token: 0x040003D1 RID: 977
			private global::Infragistics.Windows.DataPresenter.Field _field;
		}

		// Token: 0x020000C8 RID: 200
		internal class RectInfo
		{
			// Token: 0x0600099E RID: 2462 RVA: 0x00029326 File Offset: 0x00027526
			internal RectInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::System.Windows.Rect rect, global::System.Windows.FrameworkElement relativeTo)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dragManager);
				this._dragManager = dragManager;
				this._rect = rect;
				this._relativeTo = relativeTo;
			}

			// Token: 0x0600099F RID: 2463 RVA: 0x00029349 File Offset: 0x00027549
			internal global::System.Windows.Rect GetRectInScreen()
			{
				return this.GetRect(null);
			}

			// Token: 0x060009A0 RID: 2464 RVA: 0x00029352 File Offset: 0x00027552
			internal global::System.Windows.Rect GetRect()
			{
				return this.GetRect(this._dragManager._dataPresenter);
			}

			// Token: 0x060009A1 RID: 2465 RVA: 0x00029368 File Offset: 0x00027568
			internal global::System.Windows.Rect GetRect(global::System.Windows.UIElement relativeTo)
			{
				global::System.Windows.Point point = global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo.TranslatePointHelper(this._rect.TopLeft, this._relativeTo, relativeTo);
				global::System.Windows.Point point2 = global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo.TranslatePointHelper(this._rect.BottomRight, this._relativeTo, relativeTo);
				return global::Infragistics.Windows.Utilities.RectFromPoints(point, point2);
			}

			// Token: 0x060009A2 RID: 2466 RVA: 0x000293AC File Offset: 0x000275AC
			internal bool Contains(global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo point)
			{
				global::System.Windows.Rect rect = this.GetRect();
				global::System.Windows.Point position = point.GetPosition();
				return rect.Contains(position);
			}

			// Token: 0x040003D2 RID: 978
			private global::Infragistics.Windows.DataPresenter.FieldDragManager _dragManager;

			// Token: 0x040003D3 RID: 979
			private global::System.Windows.Rect _rect;

			// Token: 0x040003D4 RID: 980
			private global::System.Windows.FrameworkElement _relativeTo;
		}

		// Token: 0x020000C9 RID: 201
		internal class PointInfo
		{
			// Token: 0x060009A3 RID: 2467 RVA: 0x000293CF File Offset: 0x000275CF
			internal PointInfo(global::Infragistics.Windows.DataPresenter.FieldDragManager dragManager, global::System.Windows.Point point, global::System.Windows.FrameworkElement relativeTo)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dragManager);
				this._dragManager = dragManager;
				this._point = point;
				this._relativeTo = relativeTo;
			}

			// Token: 0x060009A4 RID: 2468 RVA: 0x000293F2 File Offset: 0x000275F2
			internal global::System.Windows.Point GetPosition()
			{
				return this.GetPosition(this._dragManager._dataPresenter);
			}

			// Token: 0x060009A5 RID: 2469 RVA: 0x00029405 File Offset: 0x00027605
			internal global::System.Windows.Point GetPositionInScreen()
			{
				return this.GetPosition(null);
			}

			// Token: 0x060009A6 RID: 2470 RVA: 0x0002940E File Offset: 0x0002760E
			internal global::System.Windows.Point GetPosition(global::System.Windows.UIElement relativeTo)
			{
				return global::Infragistics.Windows.DataPresenter.FieldDragManager.PointInfo.TranslatePointHelper(this._point, this._relativeTo, relativeTo);
			}

			// Token: 0x060009A7 RID: 2471 RVA: 0x00029424 File Offset: 0x00027624
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

			// Token: 0x060009A8 RID: 2472 RVA: 0x00029488 File Offset: 0x00027688
			internal bool IsInsideDataPresenter()
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.DoesElementContainPoint(this._dragManager._dataPresenter, this.GetPosition());
			}

			// Token: 0x060009A9 RID: 2473 RVA: 0x000294A0 File Offset: 0x000276A0
			internal bool IsMouseOverFieldChooser()
			{
				global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser;
				return this.IsMouseOverFieldChooser(out fieldChooser);
			}

			// Token: 0x060009AA RID: 2474 RVA: 0x000294B8 File Offset: 0x000276B8
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

			// Token: 0x060009AB RID: 2475 RVA: 0x00029568 File Offset: 0x00027768
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

			// Token: 0x040003D5 RID: 981
			private global::Infragistics.Windows.DataPresenter.FieldDragManager _dragManager;

			// Token: 0x040003D6 RID: 982
			private global::System.Windows.Point _point;

			// Token: 0x040003D7 RID: 983
			private global::System.Windows.FrameworkElement _relativeTo;
		}
	}
}
