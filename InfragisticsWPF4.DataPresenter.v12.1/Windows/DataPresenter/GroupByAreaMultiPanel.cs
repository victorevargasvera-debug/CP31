using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000164 RID: 356
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupByAreaMultiPanel : global::System.Windows.Controls.StackPanel
	{
		// Token: 0x060014FA RID: 5370 RVA: 0x0006002C File Offset: 0x0005E22C
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

		// Token: 0x060014FB RID: 5371 RVA: 0x000600AC File Offset: 0x0005E2AC
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			base.OnRender(dc);
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			int count = children.Count;
			if (count < 1)
			{
				return;
			}
			global::System.Windows.Media.Pen connectorLinePen = this.ConnectorLinePen;
			if (connectorLinePen == null)
			{
				return;
			}
			global::System.Windows.Thickness thickness = new global::System.Windows.Thickness(connectorLinePen.Thickness);
			if (thickness.Bottom < 1.0)
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
						this.DrawConnector(dc, elementRect, rect, connectorLinePen, thickness);
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
												goto IL_244;
											}
											uielement = dictionary[parentFieldLayout];
											rect = this.GetElementRect(uielement);
											fieldLayoutGroupByInfo = (uielement.GetValue(global::System.Windows.FrameworkElement.DataContextProperty) as global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo);
										}
										this.DrawConnector(dc, rect, elementRect2, connectorLinePen, thickness);
										this.AddToElementLocationMap(uielement2, elementRect2);
									}
								}
								IL_244:;
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
							this.DrawConnector(dc, rect, elementRect3, connectorLinePen, thickness);
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

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x000603CC File Offset: 0x0005E5CC
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x000603DE File Offset: 0x0005E5DE
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

		// Token: 0x060014FE RID: 5374 RVA: 0x000603EC File Offset: 0x0005E5EC
		private void AddToElementLocationMap(global::System.Windows.UIElement element, global::System.Windows.Rect rect)
		{
			if (this._elementLocationMap == null)
			{
				this._elementLocationMap = new global::System.Collections.Generic.Dictionary<global::System.Windows.UIElement, global::System.Windows.Rect>();
			}
			this._elementLocationMap[element] = rect;
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00060410 File Offset: 0x0005E610
		private static global::System.Windows.Point AdjustPoint(global::System.Windows.Point pt, global::System.Windows.Thickness thickness)
		{
			double left = thickness.Left;
			pt.X -= -(thickness.Left * 0.5);
			pt.Y -= thickness.Bottom * 0.5;
			return pt;
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00060468 File Offset: 0x0005E668
		private void DrawConnector(global::System.Windows.Media.DrawingContext dc, global::System.Windows.Rect priorElementRect, global::System.Windows.Rect elementRect, global::System.Windows.Media.Pen pen, global::System.Windows.Thickness thickness)
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
					pt3 = new global::System.Windows.Point(elementRect.Left - 1.0, pt2.Y);
				}
			}
			if (flag)
			{
				point.Y += thickness.Bottom / 2.0;
				dc.DrawLine(pen, global::Infragistics.Windows.DataPresenter.GroupByAreaMultiPanel.AdjustPoint(pt, thickness), global::Infragistics.Windows.DataPresenter.GroupByAreaMultiPanel.AdjustPoint(point, thickness));
			}
			if (flag2)
			{
				dc.DrawLine(pen, global::Infragistics.Windows.DataPresenter.GroupByAreaMultiPanel.AdjustPoint(pt2, thickness), global::Infragistics.Windows.DataPresenter.GroupByAreaMultiPanel.AdjustPoint(pt3, thickness));
			}
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0006083C File Offset: 0x0005EA3C
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

		// Token: 0x06001502 RID: 5378 RVA: 0x000608B4 File Offset: 0x0005EAB4
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

		// Token: 0x06001503 RID: 5379 RVA: 0x000608FC File Offset: 0x0005EAFC
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

		// Token: 0x06001504 RID: 5380 RVA: 0x00060964 File Offset: 0x0005EB64
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

		// Token: 0x0400085C RID: 2140
		private static readonly double MinOffsetY = 5.0;

		// Token: 0x0400085D RID: 2141
		private global::System.Collections.Generic.Dictionary<global::System.Windows.UIElement, global::System.Windows.Rect> _elementLocationMap;

		// Token: 0x0400085E RID: 2142
		public static readonly global::System.Windows.DependencyProperty ConnectorLinePenProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ConnectorLinePenProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMultiPanel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
	}
}
