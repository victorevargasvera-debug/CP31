using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000213 RID: 531
	internal class TreeLineRenderer : global::Infragistics.Windows.Internal.AdornerEx
	{
		// Token: 0x06001FEE RID: 8174 RVA: 0x0008A53E File Offset: 0x0008873E
		static TreeLineRenderer()
		{
			global::System.Windows.UIElement.IsHitTestVisibleProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.TreeLineRenderer), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x0008A560 File Offset: 0x00088760
		internal TreeLineRenderer(global::System.Windows.Controls.Panel panel, global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter, global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area area, global::System.Func<global::Infragistics.Windows.DataPresenter.GridViewSettingsBase> settingsFunc, global::System.Func<global::System.Windows.Media.Pen> penFunc, global::System.Func<double> horizontalOffsetFunc) : base(panel)
		{
			this._panel = panel;
			this._presenter = presenter;
			this._area = area;
			this._settingsFunc = settingsFunc;
			this._penFunc = penFunc;
			this._horizontalOffsetFunc = horizontalOffsetFunc;
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0008A5AC File Offset: 0x000887AC
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Size result = base.ArrangeOverride(finalSize);
			global::Infragistics.Windows.DataPresenter.TreeViewSettings treeViewSettings = this._settingsFunc() as global::Infragistics.Windows.DataPresenter.TreeViewSettings;
			if (treeViewSettings == null || treeViewSettings.TreeLineVisibility != global::System.Windows.Visibility.Visible)
			{
				return result;
			}
			if (this._presenter == null)
			{
				return result;
			}
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = null;
			global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter treeCellValuePresenter = null;
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter2 = null;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> list = null;
			foreach (global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter3 in this.GetRecordPresenters())
			{
				if (!recordPresenter3.IsHeaderRecord)
				{
					global::Infragistics.Windows.DataPresenter.Record record = recordPresenter3.Record;
					if (record == null || record.IsSpecialRecord)
					{
						if (record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord)
						{
							if (list == null)
							{
								list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter>();
							}
							list.Add(recordPresenter3);
						}
					}
					else
					{
						recordPresenter2 = recordPresenter3;
						global::System.Windows.FrameworkElement treeExpander = recordPresenter3.TreeExpander;
						if (treeExpander != null)
						{
							global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter treeCellValuePresenter2 = global::Infragistics.Windows.Utilities.GetAncestorFromType(treeExpander, typeof(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter), true, recordPresenter3) as global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter;
							if (treeCellValuePresenter == null)
							{
								treeCellValuePresenter = treeCellValuePresenter2;
								if (treeCellValuePresenter != null)
								{
									recordPresenter = recordPresenter3;
									if (this._area == global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area.All)
									{
										break;
									}
								}
							}
						}
					}
				}
			}
			if (treeCellValuePresenter != null)
			{
				global::System.Windows.Point location = treeCellValuePresenter.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this._panel);
				double y = location.Y;
				if (recordPresenter.HasHeaderContent)
				{
					global::System.Windows.FrameworkElement recordContentSite = recordPresenter.GetRecordContentSite();
					if (recordContentSite != null)
					{
						y = recordContentSite.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this._panel).Y;
					}
				}
				double num = this._panel.ActualHeight - y;
				if (recordPresenter2 != null && this._area != global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area.All)
				{
					global::System.Windows.FrameworkElement recordContentSite2 = recordPresenter2.GetRecordContentSite();
					global::System.Windows.FrameworkElement frameworkElement = recordContentSite2 ?? recordPresenter2;
					num = frameworkElement.TranslatePoint(new global::System.Windows.Point(0.0, frameworkElement.ActualHeight), this._panel).Y - y;
				}
				switch (this._area)
				{
				case global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area.ScrollableOnly:
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.RecordPresenter> enumerator2 = this.GetFixedRecordPresenters(false).GetEnumerator())
					{
						if (enumerator2.MoveNext())
						{
							global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter4 = enumerator2.Current;
							double val = recordPresenter4.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this._panel).Y - y;
							num = global::System.Math.Min(num, val);
						}
					}
					break;
				}
				num = global::System.Math.Max(num, 0.0);
				global::System.Windows.Rect rect = new global::System.Windows.Rect(location.X, y, treeCellValuePresenter.ActualWidth, num);
				this._lastClipRect = rect;
				global::System.Windows.Media.Geometry geometry = new global::System.Windows.Media.RectangleGeometry(rect);
				if (list != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter5 in list)
					{
						location = recordPresenter5.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this._panel);
						global::System.Windows.Rect rect2 = new global::System.Windows.Rect(location, recordPresenter5.RenderSize);
						if (rect2.IntersectsWith(rect))
						{
							geometry = global::System.Windows.Media.Geometry.Combine(geometry, new global::System.Windows.Media.RectangleGeometry(rect2), global::System.Windows.Media.GeometryCombineMode.Exclude, null);
						}
					}
				}
				base.Clip = geometry;
				return result;
			}
			if (!this._lastClipRect.IsEmpty)
			{
				this._lastClipRect = global::System.Windows.Rect.Empty;
				base.ClearValue(global::System.Windows.UIElement.ClipProperty);
			}
			return result;
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0008A928 File Offset: 0x00088B28
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			global::Infragistics.Windows.DataPresenter.TreeViewSettings treeViewSettings = this._settingsFunc() as global::Infragistics.Windows.DataPresenter.TreeViewSettings;
			if (treeViewSettings == null || treeViewSettings.TreeLineVisibility != global::System.Windows.Visibility.Visible)
			{
				return;
			}
			global::System.Windows.Media.Pen pen = this._penFunc();
			if (pen == null)
			{
				return;
			}
			if (this._presenter == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout = this._presenter.DefaultFieldLayout;
			if (defaultFieldLayout == null)
			{
				return;
			}
			double num = 1.0 / global::Infragistics.Windows.Utilities.GetDeviceMatrix(true, this).M11;
			if (num != 1.0)
			{
				double num2 = global::Infragistics.Windows.DataPresenter.GridUtilities.RoundToIntegralDevicePixel(num, pen.Thickness);
				if (num2 >= num && num2 != pen.Thickness)
				{
					pen = pen.Clone();
					pen.Thickness = num2;
					pen.Freeze();
				}
			}
			global::System.Windows.Thickness thickness = new global::System.Windows.Thickness(pen.Thickness);
			if (thickness.Bottom < num)
			{
				return;
			}
			double indentPerLevel = treeViewSettings.IndentPerLevel;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter>(this.GetRecordPresenters());
			int count = list.Count;
			global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.TreeLineRenderer.StackEntry> stack = null;
			global::System.Collections.Generic.List<double> list2 = new global::System.Collections.Generic.List<double>();
			bool flag;
			bool flag2;
			switch (this._area)
			{
			case global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area.TopFixedOnly:
			case global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area.BottomFixedOnly:
				flag = false;
				flag2 = false;
				break;
			default:
				flag = true;
				flag2 = true;
				break;
			}
			double y = 0.0;
			bool flag3 = defaultFieldLayout.ChildRecordsDisplayOrderResolved == global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.AfterParent;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = list[i];
				if (!recordPresenter.IsHeaderRecord)
				{
					global::Infragistics.Windows.DataPresenter.Record record = recordPresenter.Record;
					if (record != null && !record.IsSpecialRecord)
					{
						y = recordPresenter.TranslatePoint(default(global::System.Windows.Point), this._panel).Y;
						break;
					}
				}
			}
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this._presenter.ViewableRecords;
			int num3 = flag3 ? 0 : (count - 1);
			int num4 = flag3 ? count : -1;
			int num5 = flag3 ? 1 : -1;
			int num6 = 0;
			global::Infragistics.Windows.DataPresenter.Record record2 = null;
			for (int num7 = num3; num7 != num4; num7 += num5)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter2 = list[num7];
				if (recordPresenter2.IsHeaderRecord)
				{
					y = recordPresenter2.TranslatePoint(default(global::System.Windows.Point), this._panel).Y + recordPresenter2.ActualHeight;
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.Record record3 = recordPresenter2.Record;
					if (record3 != null)
					{
						record2 = record3;
						if (!record3.IsSpecialRecord)
						{
							global::System.Windows.FrameworkElement treeExpander = recordPresenter2.TreeExpander;
							if (treeExpander != null)
							{
								bool flag4 = treeExpander.Visibility == global::System.Windows.Visibility.Visible;
								if (flag4)
								{
									num6++;
								}
								global::System.Windows.Point point = treeExpander.TranslatePoint(default(global::System.Windows.Point), this._panel);
								double num8 = this._horizontalOffsetFunc();
								point.X += num8;
								double actualHeight = treeExpander.ActualHeight;
								double actualWidth = treeExpander.ActualWidth;
								double y2 = point.Y;
								double num9 = point.Y + actualHeight;
								double num10 = point.X + actualWidth / 2.0;
								double num11 = point.Y + actualHeight / 2.0;
								global::System.Windows.Point point2 = recordPresenter2.TranslatePoint(default(global::System.Windows.Point), this._panel);
								double y3 = point2.Y;
								double num12 = y3 + recordPresenter2.ActualHeight;
								int j = record3.NestingDepthOfDataRcds;
								if (stack == null)
								{
									flag = this.IsLineContinuationRequired(flag, true, flag3, viewableRecords, record3);
									global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list3 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
									global::Infragistics.Windows.DataPresenter.Record record4 = record3;
									while (j > list3.Count)
									{
										record4 = record4.ParentDataRecord;
										list3.Add(record4);
									}
									list3.Reverse();
									stack = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.TreeLineRenderer.StackEntry>();
									for (int k = 0; k < list3.Count; k++)
									{
										list2.Add(flag3 ? y3 : num12);
										stack.Push(new global::Infragistics.Windows.DataPresenter.TreeLineRenderer.StackEntry(new global::System.Windows.Point(num10 - indentPerLevel * (double)(j - stack.Count), point2.Y), list3[k], flag4));
									}
									if (flag4)
									{
										if (flag)
										{
											this.DrawLine(drawingContext, pen, num, thickness, new global::System.Windows.Point(num10, flag3 ? y3 : num12), new global::System.Windows.Point(num10, flag3 ? y2 : num9));
										}
										stack.Push(new global::Infragistics.Windows.DataPresenter.TreeLineRenderer.StackEntry(new global::System.Windows.Point(num10, flag3 ? num9 : y2), record3, flag4));
									}
									else
									{
										stack.Push(new global::Infragistics.Windows.DataPresenter.TreeLineRenderer.StackEntry(new global::System.Windows.Point(num10, flag3 ? y3 : num12), record3, flag4));
									}
								}
								else if (j >= stack.Count)
								{
									if (flag4)
									{
										this.DrawLine(drawingContext, pen, num, thickness, new global::System.Windows.Point(num10, flag3 ? y3 : num12), new global::System.Windows.Point(num10, flag3 ? y2 : num9));
										stack.Push(new global::Infragistics.Windows.DataPresenter.TreeLineRenderer.StackEntry(new global::System.Windows.Point(num10, flag3 ? num9 : y2), record3, flag4));
									}
									else
									{
										this.DrawLine(drawingContext, pen, num, thickness, new global::System.Windows.Point(num10, flag3 ? y3 : num12), new global::System.Windows.Point(num10, num11));
										stack.Push(new global::Infragistics.Windows.DataPresenter.TreeLineRenderer.StackEntry(new global::System.Windows.Point(num10, num11), record3, flag4));
									}
								}
								else
								{
									global::Infragistics.Windows.DataPresenter.TreeLineRenderer.StackEntry stackEntry;
									while (stack.Count > j + 1)
									{
										stackEntry = stack.Pop();
										if (stack.Count < list2.Count)
										{
											double num13 = list2[stack.Count];
											if (!double.IsNaN(num13))
											{
												bool flag5 = flag3 ? (num13 > stackEntry._lineStartPoint.Y) : (num13 < stackEntry._lineStartPoint.Y);
												if (flag5)
												{
													this.DrawLine(drawingContext, pen, num, thickness, stackEntry._lineStartPoint, new global::System.Windows.Point(stackEntry._lineStartPoint.X, num13));
												}
											}
										}
									}
									stackEntry = stack.Pop();
									if (flag4)
									{
										this.DrawLine(drawingContext, pen, num, thickness, stackEntry._lineStartPoint, new global::System.Windows.Point(num10, flag3 ? y2 : num9));
										stack.Push(new global::Infragistics.Windows.DataPresenter.TreeLineRenderer.StackEntry(new global::System.Windows.Point(num10, flag3 ? num9 : y2), record3, flag4));
									}
									else
									{
										this.DrawLine(drawingContext, pen, num, thickness, stackEntry._lineStartPoint, new global::System.Windows.Point(num10, num11));
										stack.Push(new global::Infragistics.Windows.DataPresenter.TreeLineRenderer.StackEntry(new global::System.Windows.Point(num10, num11), record3, flag4));
									}
								}
								double num14 = treeExpander.Margin.Right + 2.0;
								global::System.Windows.Point point3 = new global::System.Windows.Point(point.X + actualWidth + num14, num11);
								global::System.Windows.Point point4 = flag4 ? new global::System.Windows.Point(point.X + actualWidth, num11) : new global::System.Windows.Point(num10, num11);
								this.DrawLine(drawingContext, pen, num, thickness, point4, point3);
								if (!flag4)
								{
									while (list2.Count < j + 1)
									{
										list2.Add(double.NaN);
									}
									list2[j] = num11;
								}
							}
						}
					}
				}
			}
			if (record2 != null && num6 > 0)
			{
				flag2 = this.IsLineContinuationRequired(flag2, false, flag3, viewableRecords, record2);
			}
			if (stack != null && flag2)
			{
				while (stack.Count > 0)
				{
					global::Infragistics.Windows.DataPresenter.TreeLineRenderer.StackEntry stackEntry2 = stack.Pop();
					if (flag3)
					{
						if (stackEntry2._record.IsLastVisibleSibling)
						{
							if (list2.Count > stack.Count)
							{
								double num15 = list2[stack.Count];
								if (!double.IsNaN(num15) && num15 > stackEntry2._lineStartPoint.Y)
								{
									this.DrawLine(drawingContext, pen, num, thickness, stackEntry2._lineStartPoint, new global::System.Windows.Point(stackEntry2._lineStartPoint.X, num15));
								}
							}
						}
						else
						{
							this.DrawLine(drawingContext, pen, num, thickness, stackEntry2._lineStartPoint, new global::System.Windows.Point(stackEntry2._lineStartPoint.X, base.ActualHeight));
						}
					}
					else if (stackEntry2._record.IsFirstVisibleSibling)
					{
						if (list2.Count > stack.Count)
						{
							double num16 = list2[stack.Count];
							if (!double.IsNaN(num16) && num16 < stackEntry2._lineStartPoint.Y)
							{
								this.DrawLine(drawingContext, pen, num, thickness, stackEntry2._lineStartPoint, new global::System.Windows.Point(stackEntry2._lineStartPoint.X, num16));
							}
						}
					}
					else
					{
						this.DrawLine(drawingContext, pen, num, thickness, stackEntry2._lineStartPoint, new global::System.Windows.Point(stackEntry2._lineStartPoint.X, y));
					}
				}
			}
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x0008B188 File Offset: 0x00089388
		private void DrawLine(global::System.Windows.Media.DrawingContext drawingContext, global::System.Windows.Media.Pen pen, double dpiFactor, global::System.Windows.Thickness thickness, global::System.Windows.Point point1, global::System.Windows.Point point2)
		{
			global::System.Windows.Point point3 = global::Infragistics.Windows.DataPresenter.GridUtilities.AdjustPoint(point1, dpiFactor, thickness);
			global::System.Windows.Point point4 = global::Infragistics.Windows.DataPresenter.GridUtilities.AdjustPoint(point2, dpiFactor, thickness);
			drawingContext.DrawLine(pen, point3, point4);
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x0008B378 File Offset: 0x00089578
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.RecordPresenter> GetFixedRecordPresenters(bool top)
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection rootvrc = this._presenter.ViewableRecords;
			int count = rootvrc.Count;
			int bottomFixedCount = rootvrc.CountOfFixedRecordsOnBottom;
			int topFixedCount = rootvrc.CountOfFixedRecordsOnTop;
			int start = top ? 0 : (count - bottomFixedCount);
			int end = top ? topFixedCount : count;
			for (int i = start; i < end; i++)
			{
				global::Infragistics.Windows.DataPresenter.Record record = rootvrc[i];
				if (record != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordPresenter rp = record.AssociatedRecordPresenter;
					if (rp != null)
					{
						yield return rp;
					}
				}
			}
			yield break;
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0008B39C File Offset: 0x0008959C
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.RecordPresenter> GetRecordPresenters()
		{
			switch (this._area)
			{
			case global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area.TopFixedOnly:
				return this.GetFixedRecordPresenters(true);
			case global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area.BottomFixedOnly:
				return this.GetFixedRecordPresenters(false);
			case global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area.ScrollableOnly:
				return this.GetScrollableRecordPresenters();
			default:
				return this._presenter.GetRecordPresentersInView(true, true, true, true);
			}
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0008B5BC File Offset: 0x000897BC
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.RecordPresenter> GetScrollableRecordPresenters()
		{
			foreach (global::Infragistics.Windows.DataPresenter.RecordPresenter rp in this._presenter.GetRecordPresentersInView(true, true, true, true))
			{
				global::Infragistics.Windows.DataPresenter.Record record = rp.Record;
				if (record != null && (record.ParentRecord != null || !record.IsFixed))
				{
					yield return rp;
				}
			}
			yield break;
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0008B5DC File Offset: 0x000897DC
		private bool IsLineContinuationRequired(bool continueLines, bool start, bool forward, global::Infragistics.Windows.DataPresenter.ViewableRecordCollection rootVrc, global::Infragistics.Windows.DataPresenter.Record record)
		{
			switch (this._area)
			{
			case global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area.TopFixedOnly:
				return !start && forward && record.IsExpanded && record.HasChildrenInternal;
			case global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area.BottomFixedOnly:
				return start && !forward && record.IsExpanded && record.HasChildrenInternal;
			default:
			{
				if (!continueLines)
				{
					return false;
				}
				bool flag = start;
				if (!forward)
				{
					flag = !flag;
				}
				if (flag)
				{
					return record.OverallScrollPosition > rootVrc.CountOfFixedRecordsOnTop;
				}
				return record.OverallScrollPosition != ((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this._presenter).OverallScrollCount - (rootVrc.CountOfFixedRecordsOnBottom + 1);
			}
			}
		}

		// Token: 0x04000D65 RID: 3429
		private global::System.Windows.Controls.Panel _panel;

		// Token: 0x04000D66 RID: 3430
		private global::System.Windows.Rect _lastClipRect = global::System.Windows.Rect.Empty;

		// Token: 0x04000D67 RID: 3431
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _presenter;

		// Token: 0x04000D68 RID: 3432
		private global::System.Func<global::Infragistics.Windows.DataPresenter.GridViewSettingsBase> _settingsFunc;

		// Token: 0x04000D69 RID: 3433
		private global::System.Func<global::System.Windows.Media.Pen> _penFunc;

		// Token: 0x04000D6A RID: 3434
		private global::System.Func<double> _horizontalOffsetFunc;

		// Token: 0x04000D6B RID: 3435
		private global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area _area;

		// Token: 0x02000214 RID: 532
		private struct StackEntry
		{
			// Token: 0x06001FF7 RID: 8183 RVA: 0x0008B676 File Offset: 0x00089876
			internal StackEntry(global::System.Windows.Point lineStartPoint, global::Infragistics.Windows.DataPresenter.Record record, bool isExpanderVisible)
			{
				this._lineStartPoint = lineStartPoint;
				this._record = record;
				this._isExpanderVisible = isExpanderVisible;
			}

			// Token: 0x04000D6C RID: 3436
			internal readonly global::System.Windows.Point _lineStartPoint;

			// Token: 0x04000D6D RID: 3437
			internal readonly global::Infragistics.Windows.DataPresenter.Record _record;

			// Token: 0x04000D6E RID: 3438
			internal readonly bool _isExpanderVisible;
		}

		// Token: 0x02000215 RID: 533
		internal enum Area
		{
			// Token: 0x04000D70 RID: 3440
			TopFixedOnly,
			// Token: 0x04000D71 RID: 3441
			BottomFixedOnly,
			// Token: 0x04000D72 RID: 3442
			ScrollableOnly,
			// Token: 0x04000D73 RID: 3443
			All
		}
	}
}
