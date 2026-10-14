using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000180 RID: 384
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupByAreaMultiPanel : global::System.Windows.Controls.StackPanel
	{
		// Token: 0x06001873 RID: 6259 RVA: 0x00071FCF File Offset: 0x000701CF
		public GroupByAreaMultiPanel()
		{
			base.SetCurrentValue(global::Infragistics.Windows.Utilities.SnapElementToDevicePixelsProperty, global::Infragistics.KnownBoxes.TrueBox);
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00071FE8 File Offset: 0x000701E8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			int count = children.Count;
			if (count > 0)
			{
				int num = count;
				foreach (object obj in children)
				{
					global::System.Windows.UIElement element = (global::System.Windows.UIElement)obj;
					global::System.Windows.Controls.Panel.SetZIndex(element, num);
					num--;
				}
			}
			base.InvalidateVisual();
			return base.MeasureOverride(constraint);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00072068 File Offset: 0x00070268
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			base.OnRender(dc);
			double num = 1.0 / global::Infragistics.Windows.Utilities.GetDeviceMatrix(true, this).M11;
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			int count = children.Count;
			if (count < 1)
			{
				return;
			}
			global::System.Windows.Media.Pen pen = this.ConnectorLinePen;
			if (pen == null)
			{
				return;
			}
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
			global::System.Windows.Controls.Orientation orientation = base.Orientation;
			global::System.Windows.UIElement uielement = children[0];
			global::System.Windows.Rect rect = this.GetElementRect(uielement);
			object value = uielement.GetValue(global::System.Windows.FrameworkElement.DataContextProperty);
			global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo fieldLayoutGroupByInfo = value as global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo;
			global::Infragistics.Windows.DataPresenter.Field field = value as global::Infragistics.Windows.DataPresenter.Field;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (fieldLayoutGroupByInfo != null) ? fieldLayoutGroupByInfo.FieldLayout.DataPresenter : ((field != null) ? field.DataPresenter : null);
			try
			{
				if (dataPresenterBase != null && field != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo fieldLayoutGroupByInfo2 = base.DataContext as global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo;
					if (fieldLayoutGroupByInfo2 != null && fieldLayoutGroupByInfo2.FieldLayoutDescriptionVisibility == global::System.Windows.Visibility.Visible)
					{
						global::System.Windows.UIElement descriptionElement = this.GetDescriptionElement(this);
						global::System.Windows.Rect elementRect;
						if (descriptionElement != null)
						{
							elementRect = this.GetElementRect(descriptionElement);
						}
						else
						{
							elementRect = new global::System.Windows.Rect(0.0, rect.Top, 0.0, rect.Bottom);
						}
						this.DrawConnector(dc, num, elementRect, rect, pen, thickness);
						if (descriptionElement != null)
						{
							this.AddToElementLocationMap(descriptionElement, elementRect);
						}
					}
				}
				if (count >= 2)
				{
					if (fieldLayoutGroupByInfo != null)
					{
						global::System.Windows.UIElement descriptionElement2 = this.GetDescriptionElement(uielement);
						if (descriptionElement2 != null && descriptionElement2.IsVisible)
						{
							uielement = descriptionElement2;
							rect = this.GetElementRect(descriptionElement2);
						}
						if (dataPresenterBase != null && dataPresenterBase.GroupByAreaMode == global::Infragistics.Windows.DataPresenter.GroupByAreaMode.MultipleFieldLayoutsFull)
						{
							global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Windows.UIElement> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Windows.UIElement>();
							dictionary.Add(fieldLayoutGroupByInfo.FieldLayout, uielement);
							for (int i = 1; i < count; i++)
							{
								global::System.Windows.UIElement uielement2 = this.GetDescriptionElement(children[i]);
								if (uielement2 == null || !uielement2.IsVisible)
								{
									uielement2 = children[i];
								}
								global::System.Windows.Rect elementRect2 = this.GetElementRect(uielement2);
								global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo fieldLayoutGroupByInfo3 = uielement2.GetValue(global::System.Windows.FrameworkElement.DataContextProperty) as global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo;
								if (fieldLayoutGroupByInfo3 != null)
								{
									dictionary.Add(fieldLayoutGroupByInfo3.FieldLayout, uielement2);
									global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout = fieldLayoutGroupByInfo3.FieldLayout.ParentFieldLayout;
									if (parentFieldLayout != null)
									{
										if (parentFieldLayout != fieldLayoutGroupByInfo.FieldLayout)
										{
											if (!dictionary.ContainsKey(parentFieldLayout))
											{
												goto IL_2A3;
											}
											uielement = dictionary[parentFieldLayout];
											rect = this.GetElementRect(uielement);
											fieldLayoutGroupByInfo = (uielement.GetValue(global::System.Windows.FrameworkElement.DataContextProperty) as global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo);
										}
										this.DrawConnector(dc, num, rect, elementRect2, pen, thickness);
										this.AddToElementLocationMap(uielement2, elementRect2);
									}
								}
								IL_2A3:;
							}
						}
					}
					else
					{
						for (int j = 1; j < count; j++)
						{
							global::System.Windows.UIElement uielement3 = this.GetDescriptionElement(children[j]);
							if (uielement3 == null || !uielement3.IsVisible)
							{
								uielement3 = children[j];
							}
							global::System.Windows.Rect elementRect3 = this.GetElementRect(uielement3);
							this.DrawConnector(dc, num, rect, elementRect3, pen, thickness);
							this.AddToElementLocationMap(uielement3, elementRect3);
							uielement = uielement3;
							rect = elementRect3;
							fieldLayoutGroupByInfo = (uielement.GetValue(global::System.Windows.FrameworkElement.DataContextProperty) as global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo);
						}
					}
				}
			}
			finally
			{
				if (this._elementLocationMap != null && this._elementLocationMap.Count > 0 && dataPresenterBase != null)
				{
					dataPresenterBase.WireLayoutUpdated(new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnLayoutUpdated));
				}
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x000723EC File Offset: 0x000705EC
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x000723FE File Offset: 0x000705FE
		public global::System.Windows.Media.Pen ConnectorLinePen
		{
			get
			{
				return (global::System.Windows.Media.Pen)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ConnectorLinePenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ConnectorLinePenProperty, value);
			}
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0007240C File Offset: 0x0007060C
		private void AddToElementLocationMap(global::System.Windows.UIElement element, global::System.Windows.Rect rect)
		{
			if (this._elementLocationMap == null)
			{
				this._elementLocationMap = new global::System.Collections.Generic.Dictionary<global::System.Windows.UIElement, global::System.Windows.Rect>();
			}
			this._elementLocationMap[element] = rect;
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00072430 File Offset: 0x00070630
		private void DrawConnector(global::System.Windows.Media.DrawingContext dc, double dpiFactor, global::System.Windows.Rect priorElementRect, global::System.Windows.Rect elementRect, global::System.Windows.Media.Pen pen, global::System.Windows.Thickness thickness)
		{
			double num = global::System.Math.Max(elementRect.Bottom - priorElementRect.Bottom, 0.0);
			double num2 = global::System.Math.Max(elementRect.X - priorElementRect.X, 0.0);
			double num3 = global::System.Math.Max(elementRect.X - priorElementRect.Right, 0.0);
			bool flag = false;
			global::System.Windows.Point pt = default(global::System.Windows.Point);
			global::System.Windows.Point point = default(global::System.Windows.Point);
			bool flag2 = false;
			global::System.Windows.Point pt2 = default(global::System.Windows.Point);
			global::System.Windows.Point pt3 = default(global::System.Windows.Point);
			if (num3 > 0.0)
			{
				if (num > global::Infragistics.Windows.DataPresenter.GroupByAreaMultiPanel.MinOffsetY && num > 2.0 * thickness.Bottom && elementRect.Top >= priorElementRect.Top)
				{
					flag = true;
					pt = new global::System.Windows.Point(priorElementRect.Left + priorElementRect.Width / 2.0, priorElementRect.Bottom);
					double val = pt.Y + global::System.Math.Max(thickness.Bottom, (elementRect.Bottom - (thickness.Bottom + priorElementRect.Bottom)) / 2.0);
					double val2 = elementRect.Top + (thickness.Bottom + elementRect.Height) / 2.0;
					point = new global::System.Windows.Point(pt.X, global::System.Math.Max(val, val2));
				}
				else if (priorElementRect.Top > elementRect.Bottom - thickness.Bottom)
				{
					flag = true;
					pt = new global::System.Windows.Point(priorElementRect.Left + priorElementRect.Width / 2.0, priorElementRect.Top);
					double val3 = pt.Y - global::System.Math.Max(thickness.Bottom, (priorElementRect.Top - (thickness.Bottom + priorElementRect.Top)) / 2.0);
					double val4 = elementRect.Top + (thickness.Bottom + elementRect.Height) / 2.0;
					point = new global::System.Windows.Point(pt.X, global::System.Math.Min(val3, val4));
				}
				else
				{
					point = new global::System.Windows.Point(priorElementRect.Right, priorElementRect.Top + global::System.Math.Max(thickness.Bottom + elementRect.Bottom - priorElementRect.Top, 0.0) / 2.0);
				}
				if (elementRect.Left > point.X)
				{
					flag2 = true;
					pt2 = point;
					pt3 = new global::System.Windows.Point(elementRect.Left, pt2.Y);
				}
			}
			else
			{
				if (num < global::Infragistics.Windows.DataPresenter.GroupByAreaMultiPanel.MinOffsetY || num < 2.0 * global::System.Math.Max(thickness.Bottom, 1.0))
				{
					return;
				}
				if (num2 > 4.0 * global::System.Math.Max(thickness.Left, 1.0))
				{
					flag = true;
					pt = new global::System.Windows.Point(priorElementRect.Left + num2 / 2.0, priorElementRect.Bottom);
					point = new global::System.Windows.Point(pt.X, elementRect.Top + (thickness.Bottom + elementRect.Bottom - elementRect.Top) / 2.0);
					flag2 = true;
					pt2 = point;
					pt3 = new global::System.Windows.Point(elementRect.Left - dpiFactor, pt2.Y);
				}
			}
			if (flag)
			{
				global::System.Windows.Point point2 = global::Infragistics.Windows.DataPresenter.GridUtilities.AdjustPoint(pt, dpiFactor, thickness);
				global::System.Windows.Point point3 = global::Infragistics.Windows.DataPresenter.GridUtilities.AdjustPoint(point, dpiFactor, thickness);
				dc.DrawLine(pen, point2, point3);
			}
			if (flag2)
			{
				global::System.Windows.Point point4 = global::Infragistics.Windows.DataPresenter.GridUtilities.AdjustPoint(pt2, dpiFactor, thickness);
				global::System.Windows.Point point5 = global::Infragistics.Windows.DataPresenter.GridUtilities.AdjustPoint(pt3, dpiFactor, thickness);
				dc.DrawLine(pen, point4, point5);
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000727EC File Offset: 0x000709EC
		private global::System.Windows.UIElement GetConnectorLineTarget(global::System.Windows.UIElement element)
		{
			global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::System.Windows.UIElement> callback = (global::System.Windows.UIElement uielement) => global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.GetIsConnectorLineTarget(uielement);
			global::System.Windows.UIElement descendantFromType = global::Infragistics.Windows.Utilities.GetDescendantFromType<global::System.Windows.UIElement>(element, true, callback, new global::System.Type[]
			{
				typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMultiPanel)
			});
			if (descendantFromType == null)
			{
				return element;
			}
			global::System.Windows.UIElement descendantFromType2 = global::Infragistics.Windows.Utilities.GetDescendantFromType<global::System.Windows.UIElement>(descendantFromType, true, callback, new global::System.Type[]
			{
				typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMultiPanel)
			});
			if (descendantFromType2 == null)
			{
				return descendantFromType;
			}
			return descendantFromType2;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00072864 File Offset: 0x00070A64
		private global::System.Windows.UIElement GetDescriptionElement(global::System.Windows.UIElement element)
		{
			global::System.Windows.UIElement result = null;
			if (base.DataContext is global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo)
			{
				global::System.Windows.DependencyObject dependencyObject = element;
				while (dependencyObject != null)
				{
					dependencyObject = global::Infragistics.Windows.Utilities.GetParent(dependencyObject);
					if (dependencyObject is global::Infragistics.Windows.DataPresenter.GroupByAreaMultiPanel)
					{
						break;
					}
					if (dependencyObject is global::System.Windows.UIElement)
					{
						result = (dependencyObject as global::System.Windows.UIElement);
					}
				}
			}
			else
			{
				result = element;
			}
			return result;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000728AC File Offset: 0x00070AAC
		private global::System.Windows.Rect GetElementRect(global::System.Windows.UIElement element)
		{
			if ((element is global::System.Windows.Controls.ContentPresenter || element is global::System.Windows.Controls.ContentControl) && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(element) == 1)
			{
				global::System.Windows.DependencyObject child = global::System.Windows.Media.VisualTreeHelper.GetChild(element, 0);
				if (child is global::System.Windows.UIElement)
				{
					element = (child as global::System.Windows.UIElement);
				}
			}
			global::System.Windows.UIElement uielement = this.GetConnectorLineTarget(element);
			if (uielement == null)
			{
				uielement = element;
			}
			global::System.Windows.Point location = uielement.TranslatePoint(default(global::System.Windows.Point), this);
			return new global::System.Windows.Rect(location, uielement.RenderSize);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00072914 File Offset: 0x00070B14
		private void OnLayoutUpdated()
		{
			if (this._elementLocationMap == null)
			{
				return;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Windows.UIElement, global::System.Windows.Rect> keyValuePair in this._elementLocationMap)
			{
				global::System.Windows.Rect elementRect = this.GetElementRect(keyValuePair.Key);
				if (elementRect != keyValuePair.Value)
				{
					base.InvalidateVisual();
					break;
				}
			}
			this._elementLocationMap = null;
		}

		// Token: 0x04000A11 RID: 2577
		private static readonly double MinOffsetY = 5.0;

		// Token: 0x04000A12 RID: 2578
		private global::System.Collections.Generic.Dictionary<global::System.Windows.UIElement, global::System.Windows.Rect> _elementLocationMap;

		// Token: 0x04000A13 RID: 2579
		public static readonly global::System.Windows.DependencyProperty ConnectorLinePenProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ConnectorLinePenProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMultiPanel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
	}
}
