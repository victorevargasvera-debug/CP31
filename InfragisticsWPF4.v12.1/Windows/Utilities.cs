using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Reporting;

namespace Infragistics.Windows
{
	// Token: 0x02000284 RID: 644
	public class Utilities : global::Infragistics.CoreUtilities
	{
		// Token: 0x06001979 RID: 6521 RVA: 0x000616F0 File Offset: 0x0005F8F0
		static Utilities()
		{
			global::Infragistics.Windows.Utilities.UIElement3DType = global::System.Type.GetType("System.Windows.UIElement3D, " + typeof(global::System.Windows.UIElement).Assembly.FullName, false);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x000617A0 File Offset: 0x0005F9A0
		protected Utilities()
		{
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x000617A8 File Offset: 0x0005F9A8
		private static global::System.Random Rnd
		{
			get
			{
				if (global::Infragistics.Windows.Utilities._rnd == null)
				{
					global::Infragistics.Windows.Utilities._rnd = new global::System.Random();
				}
				return global::Infragistics.Windows.Utilities._rnd;
			}
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x000617C0 File Offset: 0x0005F9C0
		public static bool AllowsAsyncOperations(global::System.Windows.DependencyObject d)
		{
			return !global::Infragistics.Windows.Reporting.ReportSection.GetIsInReport(d);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x000617CC File Offset: 0x0005F9CC
		public static void AnimateTranslateTransform(global::System.Windows.Media.TranslateTransform translateTransform, double fromX, double toX, double fromY, double toY, int durationMilliseconds, bool autoReverse, global::System.EventHandler callbackHandler)
		{
			global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(fromX, toX, global::System.TimeSpan.FromMilliseconds((double)durationMilliseconds), global::System.Windows.Media.Animation.FillBehavior.HoldEnd);
			doubleAnimation.BeginTime = null;
			doubleAnimation.AutoReverse = autoReverse;
			doubleAnimation.AccelerationRatio = 0.5;
			doubleAnimation.DecelerationRatio = 0.5;
			global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation2 = new global::System.Windows.Media.Animation.DoubleAnimation(fromY, toY, global::System.TimeSpan.FromMilliseconds((double)durationMilliseconds), global::System.Windows.Media.Animation.FillBehavior.HoldEnd);
			doubleAnimation2.BeginTime = null;
			doubleAnimation2.AutoReverse = autoReverse;
			doubleAnimation2.AccelerationRatio = 0.5;
			doubleAnimation2.DecelerationRatio = 0.5;
			global::System.Windows.Media.Animation.AnimationClock animationClock = doubleAnimation.CreateClock();
			global::System.Windows.Media.Animation.AnimationClock animationClock2 = doubleAnimation2.CreateClock();
			translateTransform.ApplyAnimationClock(global::System.Windows.Media.TranslateTransform.XProperty, animationClock);
			translateTransform.ApplyAnimationClock(global::System.Windows.Media.TranslateTransform.YProperty, animationClock2);
			if (callbackHandler != null)
			{
				animationClock.CurrentStateInvalidated += callbackHandler;
			}
			animationClock.Controller.Begin();
			animationClock2.Controller.Begin();
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000618BC File Offset: 0x0005FABC
		public static bool CanExecuteCommand(global::System.Windows.Input.ICommandSource commandSource)
		{
			if (commandSource == null)
			{
				throw new global::System.ArgumentNullException("commandSource");
			}
			bool result = false;
			global::System.Windows.Input.ICommand command = commandSource.Command;
			if (command != null)
			{
				global::System.Windows.Input.RoutedCommand routedCommand = command as global::System.Windows.Input.RoutedCommand;
				object commandParameter = commandSource.CommandParameter;
				if (routedCommand != null)
				{
					global::System.Windows.IInputElement target = commandSource.CommandTarget ?? (commandSource as global::System.Windows.IInputElement);
					result = routedCommand.CanExecute(commandParameter, target);
				}
				else
				{
					result = command.CanExecute(commandParameter);
				}
			}
			return result;
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x0006191C File Offset: 0x0005FB1C
		public static global::System.Windows.Thickness CalculateTotalMarginAndPadding(global::System.Windows.DependencyObject ancestor, global::System.Windows.DependencyObject descendant)
		{
			if (ancestor == null)
			{
				throw new global::System.ArgumentNullException("ancestor");
			}
			if (descendant == null)
			{
				throw new global::System.ArgumentNullException("descendant");
			}
			global::System.Windows.Thickness result = default(global::System.Windows.Thickness);
			global::System.Windows.Media.Visual visual = ancestor as global::System.Windows.Media.Visual;
			if (visual != null && !visual.IsAncestorOf(descendant))
			{
				return result;
			}
			for (global::System.Windows.DependencyObject dependencyObject = descendant; dependencyObject != null; dependencyObject = global::Infragistics.Windows.Utilities.GetParent(dependencyObject))
			{
				global::System.Windows.DependencyProperty dependencyProperty = null;
				global::System.Windows.DependencyProperty dependencyProperty2 = null;
				if (dependencyObject is global::System.Windows.Documents.AnchoredBlock)
				{
					dependencyProperty = global::System.Windows.Documents.AnchoredBlock.MarginProperty;
					dependencyProperty2 = global::System.Windows.Documents.AnchoredBlock.PaddingProperty;
				}
				else if (dependencyObject is global::System.Windows.Documents.Block)
				{
					dependencyProperty = global::System.Windows.Documents.Block.MarginProperty;
					dependencyProperty2 = global::System.Windows.Documents.Block.PaddingProperty;
				}
				else if (dependencyObject is global::System.Windows.FrameworkElement)
				{
					dependencyProperty = global::System.Windows.FrameworkElement.MarginProperty;
				}
				else if (dependencyObject is global::System.Windows.Documents.ListItem)
				{
					dependencyProperty = global::System.Windows.Documents.ListItem.MarginProperty;
					dependencyProperty2 = global::System.Windows.Documents.ListItem.PaddingProperty;
				}
				else if (dependencyObject is global::System.Windows.Controls.Border)
				{
					dependencyProperty2 = global::System.Windows.Controls.Border.PaddingProperty;
				}
				else if (dependencyObject is global::System.Windows.Controls.Control)
				{
					dependencyProperty2 = global::System.Windows.Controls.Control.PaddingProperty;
				}
				else if (dependencyObject is global::System.Windows.Documents.TableCell)
				{
					dependencyProperty2 = global::System.Windows.Documents.TableCell.PaddingProperty;
				}
				else if (dependencyObject is global::System.Windows.Controls.TextBlock)
				{
					dependencyProperty2 = global::System.Windows.Controls.TextBlock.PaddingProperty;
				}
				if (dependencyProperty != null)
				{
					global::System.Windows.Thickness thickness = (global::System.Windows.Thickness)dependencyObject.GetValue(dependencyProperty);
					result.Top += thickness.Top;
					result.Left += thickness.Left;
					result.Bottom += thickness.Bottom;
					result.Right += thickness.Right;
				}
				if (dependencyProperty2 != null)
				{
					global::System.Windows.Thickness thickness2 = (global::System.Windows.Thickness)dependencyObject.GetValue(dependencyProperty2);
					result.Top += thickness2.Top;
					result.Left += thickness2.Left;
					result.Bottom += thickness2.Bottom;
					result.Right += thickness2.Right;
				}
				if (dependencyObject == ancestor)
				{
					break;
				}
			}
			return result;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00061AE6 File Offset: 0x0005FCE6
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static int ConvertFromLogicalPixels(double logicalPixelValue)
		{
			return global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(logicalPixelValue, null);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00061AF0 File Offset: 0x0005FCF0
		public static int ConvertFromLogicalPixels(double logicalPixelValue, global::System.Windows.Media.Visual relativeVisual)
		{
			return (int)(global::Infragistics.Windows.Utilities.GetDeviceMatrix(true, relativeVisual).M22 * logicalPixelValue);
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00061B0F File Offset: 0x0005FD0F
		internal static global::System.Windows.Rect ConvertFromLogicalPixels(global::System.Windows.Rect deviceRect, global::System.Windows.Media.Visual relativeElement)
		{
			return new global::System.Windows.Rect((double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(deviceRect.X, relativeElement), (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(deviceRect.Y, relativeElement), (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(deviceRect.Width, relativeElement), (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(deviceRect.Height, relativeElement));
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00061B4E File Offset: 0x0005FD4E
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static double ConvertToLogicalPixels(int pixelValue)
		{
			return global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(pixelValue, null);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00061B58 File Offset: 0x0005FD58
		public static double ConvertToLogicalPixels(int pixelValue, global::System.Windows.Media.Visual relativeVisual)
		{
			return global::Infragistics.Windows.Utilities.GetDeviceMatrix(false, relativeVisual).M11 * (double)pixelValue;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00061B78 File Offset: 0x0005FD78
		internal static global::System.Windows.Point ConvertToLogicalPixels(int pixelX, int pixelY, global::System.Windows.Media.Visual relativeElement)
		{
			return global::Infragistics.Windows.Utilities.GetDeviceMatrix(false, relativeElement).Transform(new global::System.Windows.Point((double)pixelX, (double)pixelY));
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00061B9D File Offset: 0x0005FD9D
		internal static global::System.Windows.Rect ConvertToLogicalPixels(global::System.Windows.Rect deviceRect, global::System.Windows.Media.Visual relativeElement)
		{
			return new global::System.Windows.Rect(global::Infragistics.Windows.Utilities.ConvertToLogicalPixels((int)deviceRect.Left, (int)deviceRect.Top, relativeElement), global::Infragistics.Windows.Utilities.ConvertToLogicalPixels((int)deviceRect.Right, (int)deviceRect.Bottom, relativeElement));
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00061BD0 File Offset: 0x0005FDD0
		public static void CopyPropertyValues(global::System.Windows.FrameworkElementFactory target, global::System.Windows.DependencyObject source)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			global::System.Windows.LocalValueEnumerator localValueEnumerator = source.GetLocalValueEnumerator();
			while (localValueEnumerator.MoveNext())
			{
				global::System.Windows.LocalValueEntry localValueEntry = localValueEnumerator.Current;
				if (localValueEntry.Value is global::System.Windows.Data.BindingExpressionBase)
				{
					global::System.Windows.LocalValueEntry localValueEntry2 = localValueEnumerator.Current;
					global::System.Windows.DependencyProperty property = localValueEntry2.Property;
					global::System.Windows.LocalValueEntry localValueEntry3 = localValueEnumerator.Current;
					target.SetBinding(property, ((global::System.Windows.Data.BindingExpressionBase)localValueEntry3.Value).ParentBindingBase);
				}
				else
				{
					global::System.Windows.LocalValueEntry localValueEntry4 = localValueEnumerator.Current;
					if (localValueEntry4.Value is global::System.Windows.Data.BindingBase)
					{
						global::System.Windows.LocalValueEntry localValueEntry5 = localValueEnumerator.Current;
						global::System.Windows.DependencyProperty property2 = localValueEntry5.Property;
						global::System.Windows.LocalValueEntry localValueEntry6 = localValueEnumerator.Current;
						target.SetBinding(property2, (global::System.Windows.Data.BindingBase)localValueEntry6.Value);
					}
					else
					{
						global::System.Windows.LocalValueEntry localValueEntry7 = localValueEnumerator.Current;
						global::System.Windows.DependencyProperty property3 = localValueEntry7.Property;
						global::System.Windows.LocalValueEntry localValueEntry8 = localValueEnumerator.Current;
						target.SetValue(property3, localValueEntry8.Value);
					}
				}
			}
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00061CC4 File Offset: 0x0005FEC4
		public static void CopyPropertyValues(global::System.Windows.DependencyObject target, global::System.Windows.DependencyObject source)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			global::System.Windows.LocalValueEnumerator localValueEnumerator = source.GetLocalValueEnumerator();
			while (localValueEnumerator.MoveNext())
			{
				global::System.Windows.LocalValueEntry localValueEntry = localValueEnumerator.Current;
				if (localValueEntry.Value is global::System.Windows.Data.BindingExpressionBase)
				{
					global::System.Windows.LocalValueEntry localValueEntry2 = localValueEnumerator.Current;
					global::System.Windows.DependencyProperty property = localValueEntry2.Property;
					global::System.Windows.LocalValueEntry localValueEntry3 = localValueEnumerator.Current;
					global::System.Windows.Data.BindingOperations.SetBinding(target, property, ((global::System.Windows.Data.BindingExpressionBase)localValueEntry3.Value).ParentBindingBase);
				}
				else
				{
					global::System.Windows.LocalValueEntry localValueEntry4 = localValueEnumerator.Current;
					if (localValueEntry4.Value is global::System.Windows.Data.BindingBase)
					{
						global::System.Windows.FrameworkElement frameworkElement = target as global::System.Windows.FrameworkElement;
						if (frameworkElement != null)
						{
							global::System.Windows.FrameworkElement frameworkElement2 = frameworkElement;
							global::System.Windows.LocalValueEntry localValueEntry5 = localValueEnumerator.Current;
							global::System.Windows.DependencyProperty property2 = localValueEntry5.Property;
							global::System.Windows.LocalValueEntry localValueEntry6 = localValueEnumerator.Current;
							frameworkElement2.SetBinding(property2, (global::System.Windows.Data.BindingBase)localValueEntry6.Value);
						}
						else
						{
							global::System.Windows.FrameworkContentElement frameworkContentElement = target as global::System.Windows.FrameworkContentElement;
							if (frameworkContentElement != null)
							{
								global::System.Windows.FrameworkContentElement frameworkContentElement2 = frameworkContentElement;
								global::System.Windows.LocalValueEntry localValueEntry7 = localValueEnumerator.Current;
								global::System.Windows.DependencyProperty property3 = localValueEntry7.Property;
								global::System.Windows.LocalValueEntry localValueEntry8 = localValueEnumerator.Current;
								frameworkContentElement2.SetBinding(property3, (global::System.Windows.Data.BindingBase)localValueEntry8.Value);
							}
						}
					}
					else
					{
						global::System.Windows.LocalValueEntry localValueEntry9 = localValueEnumerator.Current;
						global::System.Windows.DependencyProperty property4 = localValueEntry9.Property;
						global::System.Windows.LocalValueEntry localValueEntry10 = localValueEnumerator.Current;
						target.SetValue(property4, localValueEntry10.Value);
					}
				}
			}
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00061E00 File Offset: 0x00060000
		public static global::System.Windows.FrameworkElementFactory Create2by2Grid()
		{
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Grid));
			frameworkElementFactory.SetValue(global::System.Windows.Controls.Grid.ShowGridLinesProperty, global::Infragistics.KnownBoxes.FalseBox);
			for (int i = 0; i < 2; i++)
			{
				global::System.Windows.FrameworkElementFactory frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.ColumnDefinition));
				frameworkElementFactory2.SetValue(global::System.Windows.Controls.ColumnDefinition.WidthProperty, (i == 0) ? new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star) : new global::System.Windows.GridLength(0.0, global::System.Windows.GridUnitType.Auto));
				frameworkElementFactory.AppendChild(frameworkElementFactory2);
			}
			for (int i = 0; i < 2; i++)
			{
				global::System.Windows.FrameworkElementFactory frameworkElementFactory3 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.RowDefinition));
				frameworkElementFactory3.SetValue(global::System.Windows.Controls.RowDefinition.HeightProperty, (i == 0) ? new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star) : new global::System.Windows.GridLength(0.0, global::System.Windows.GridUnitType.Auto));
				frameworkElementFactory.AppendChild(frameworkElementFactory3);
			}
			return frameworkElementFactory;
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00061EDA File Offset: 0x000600DA
		public static global::System.Windows.Media.Geometry CreateRoundedRectGeometry(global::System.Windows.Rect rect, global::Infragistics.Windows.Controls.RoundedRectCorners roundedCorners, double radiusX, double radiusY, double edgeThickness)
		{
			return global::Infragistics.Windows.Utilities.CreateRoundedRectGeometry(rect, roundedCorners, radiusX, radiusY, edgeThickness, global::Infragistics.Windows.Controls.RoundedRectSide.Left, global::Infragistics.Windows.Controls.RoundedRectSide.Left);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00061EEC File Offset: 0x000600EC
		public static global::System.Windows.Media.Geometry CreateRoundedRectGeometry(global::System.Windows.Rect rect, global::Infragistics.Windows.Controls.RoundedRectCorners roundedCorners, double radiusX, double radiusY, double edgeThickness, global::Infragistics.Windows.Controls.RoundedRectSide startSide, global::Infragistics.Windows.Controls.RoundedRectSide endSide)
		{
			double num = edgeThickness / 2.0;
			if (startSide == endSide)
			{
				rect.Inflate(-num, -num);
				radiusX = global::System.Math.Min(radiusX, rect.Width / 2.0);
				radiusY = global::System.Math.Min(radiusY, rect.Height / 2.0);
			}
			else
			{
				int num2 = (int)endSide;
				if (num2 <= (int)startSide)
				{
					num2 += 4;
				}
				bool flag = global::Infragistics.Windows.Controls.RoundedRectSide.Left >= startSide || 4 <= num2;
				bool flag2 = global::Infragistics.Windows.Controls.RoundedRectSide.Top >= startSide || 5 <= num2;
				bool flag3 = global::Infragistics.Windows.Controls.RoundedRectSide.Right >= startSide || 6 <= num2;
				bool flag4 = global::Infragistics.Windows.Controls.RoundedRectSide.Bottom >= startSide || 7 <= num2;
				if (flag)
				{
					rect.X += num;
					rect.Width = global::System.Math.Max(rect.Width - num, 0.0);
				}
				if (flag2)
				{
					rect.Y += num;
					rect.Height = global::System.Math.Max(rect.Height - num, 0.0);
				}
				if (flag3)
				{
					rect.Width = global::System.Math.Max(rect.Width - num, 0.0);
				}
				if (flag4)
				{
					rect.Height = global::System.Math.Max(rect.Height - num, 0.0);
				}
				radiusX = global::System.Math.Min(radiusX, (flag && flag3) ? (rect.Width / 2.0) : rect.Width);
				radiusY = global::System.Math.Min(radiusY, (flag2 && flag4) ? (rect.Height / 2.0) : rect.Height);
			}
			if (rect.IsEmpty)
			{
				return null;
			}
			global::System.Windows.Media.StreamGeometry streamGeometry = new global::System.Windows.Media.StreamGeometry();
			bool flag5 = (roundedCorners & global::Infragistics.Windows.Controls.RoundedRectCorners.TopLeft) == global::Infragistics.Windows.Controls.RoundedRectCorners.TopLeft;
			bool flag6 = (roundedCorners & global::Infragistics.Windows.Controls.RoundedRectCorners.TopRight) == global::Infragistics.Windows.Controls.RoundedRectCorners.TopRight;
			bool flag7 = (roundedCorners & global::Infragistics.Windows.Controls.RoundedRectCorners.BottomLeft) == global::Infragistics.Windows.Controls.RoundedRectCorners.BottomLeft;
			bool flag8 = (roundedCorners & global::Infragistics.Windows.Controls.RoundedRectCorners.BottomRight) == global::Infragistics.Windows.Controls.RoundedRectCorners.BottomRight;
			global::System.Windows.Size size = new global::System.Windows.Size(radiusX, radiusY);
			global::System.Windows.Point[] array = new global::System.Windows.Point[]
			{
				flag7 ? new global::System.Windows.Point(rect.Left, rect.Bottom - radiusY) : rect.BottomLeft,
				flag5 ? new global::System.Windows.Point(rect.Left, rect.Top + radiusY) : rect.TopLeft,
				flag5 ? new global::System.Windows.Point(rect.X + radiusX, rect.Top) : rect.TopLeft,
				flag6 ? new global::System.Windows.Point(rect.Right - radiusX, rect.Top) : rect.TopRight,
				flag6 ? new global::System.Windows.Point(rect.Right, rect.Top + radiusY) : rect.TopRight,
				flag8 ? new global::System.Windows.Point(rect.Right, rect.Bottom - radiusY) : rect.BottomRight,
				flag8 ? new global::System.Windows.Point(rect.Right - radiusX, rect.Bottom) : rect.BottomRight,
				flag7 ? new global::System.Windows.Point(rect.Left + radiusX, rect.Bottom) : rect.BottomLeft
			};
			using (global::System.Windows.Media.StreamGeometryContext streamGeometryContext = streamGeometry.Open())
			{
				int num3 = (int)(startSide * global::Infragistics.Windows.Controls.RoundedRectSide.Right);
				int num4 = (int)((endSide == startSide) ? ((global::Infragistics.Windows.Controls.RoundedRectSide)8) : (endSide * global::Infragistics.Windows.Controls.RoundedRectSide.Right + 1));
				if (num4 < num3)
				{
					num4 += 8;
				}
				global::System.Windows.Point point = array[num3];
				streamGeometryContext.BeginFigure(point, true, false);
				for (int i = num3 + 1; i <= num4; i++)
				{
					int num5 = i % 8;
					global::System.Windows.Point point2 = array[num5];
					if (num5 % 2 == 1)
					{
						streamGeometryContext.LineTo(point2, true, false);
					}
					else if (point2 != point)
					{
						streamGeometryContext.ArcTo(point2, size, 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true, false);
					}
					point = point2;
				}
			}
			return streamGeometry;
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00062318 File Offset: 0x00060518
		public static string StringFromNonDefaultProperties(global::System.Windows.DependencyObject obj)
		{
			if (obj == null)
			{
				return string.Empty;
			}
			global::System.Type type = obj.GetType();
			global::System.Collections.Generic.SortedDictionary<string, object> sortedDictionary = null;
			global::System.Windows.LocalValueEnumerator localValueEnumerator = obj.GetLocalValueEnumerator();
			while (localValueEnumerator.MoveNext())
			{
				global::System.Windows.LocalValueEntry localValueEntry = localValueEnumerator.Current;
				global::System.Type ownerType = localValueEntry.Property.OwnerType;
				if ((type == ownerType || ownerType.IsAssignableFrom(type)) && !object.Equals(localValueEntry.Property.DefaultMetadata.DefaultValue, localValueEntry.Value))
				{
					if (sortedDictionary == null)
					{
						sortedDictionary = new global::System.Collections.Generic.SortedDictionary<string, object>();
					}
					sortedDictionary.Add(localValueEntry.Property.Name, localValueEntry.Value);
				}
			}
			if (sortedDictionary == null)
			{
				return string.Empty;
			}
			global::System.Text.StringBuilder stringBuilder = null;
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in sortedDictionary)
			{
				if (stringBuilder == null)
				{
					stringBuilder = new global::System.Text.StringBuilder();
				}
				else
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(keyValuePair.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00062434 File Offset: 0x00060634
		internal static bool DoesElementContainPoint(global::System.Windows.FrameworkElement elem, global::System.Windows.Point p)
		{
			return p.X >= 0.0 && p.Y >= 0.0 && p.X < elem.ActualWidth && p.Y < elem.ActualHeight;
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00062488 File Offset: 0x00060688
		internal static global::System.Windows.Point EnsureInElementBounds(global::System.Windows.Point point, global::System.Windows.FrameworkElement elem)
		{
			point.X = global::Infragistics.Windows.Utilities.EnsureInRange(point.X, 0.0, elem.ActualWidth);
			point.Y = global::Infragistics.Windows.Utilities.EnsureInRange(point.Y, 0.0, elem.ActualHeight);
			return point;
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x000624DA File Offset: 0x000606DA
		internal static double EnsureInRange(double val, double min, double max)
		{
			return global::System.Math.Min(global::System.Math.Max(val, min), max);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x000624E9 File Offset: 0x000606E9
		public static bool DoubleIsZero(double value)
		{
			return global::System.Math.Abs(value) < 2.220446049250313E-13;
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00062500 File Offset: 0x00060700
		public static global::System.Windows.Data.Binding CreateBindingObjectLikeAlias(global::System.Windows.DependencyProperty dp)
		{
			return new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(dp),
				Mode = global::System.Windows.Data.BindingMode.OneWay,
				RelativeSource = global::System.Windows.Data.RelativeSource.TemplatedParent
			};
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00062534 File Offset: 0x00060734
		public static global::System.Windows.Data.Binding CreateBindingObject(global::System.Windows.DependencyProperty dp, global::System.Windows.Data.BindingMode bindingMode, global::System.Windows.Data.RelativeSource relativeSource)
		{
			return new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(dp),
				Mode = bindingMode,
				RelativeSource = relativeSource
			};
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00062564 File Offset: 0x00060764
		public static global::System.Windows.Data.Binding CreateBindingObject(global::System.Windows.DependencyProperty dp, global::System.Windows.Data.BindingMode bindingMode, object source)
		{
			return new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(dp),
				Mode = bindingMode,
				Source = source
			};
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00062594 File Offset: 0x00060794
		public static global::System.Windows.Data.Binding CreateBindingObject(global::System.Windows.DependencyProperty dp, global::System.Windows.Data.BindingMode bindingMode, object source, global::System.Windows.Data.IValueConverter converter)
		{
			return new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(dp),
				Mode = bindingMode,
				Source = source,
				Converter = converter
			};
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x000625CC File Offset: 0x000607CC
		public static global::System.Windows.Data.Binding CreateBindingObject(string path, global::System.Windows.Data.BindingMode bindingMode, object source)
		{
			return new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(path, new object[0]),
				Mode = bindingMode,
				Source = source
			};
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00062600 File Offset: 0x00060800
		public static global::System.Windows.Data.Binding CreateBindingObject(string path, global::System.Windows.Data.BindingMode bindingMode, object source, global::System.Windows.Data.IValueConverter converter)
		{
			return new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(path, new object[0]),
				Mode = bindingMode,
				Source = source,
				Converter = converter
			};
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0006263C File Offset: 0x0006083C
		public static void ExecuteCommand(global::System.Windows.Input.ICommandSource commandSource)
		{
			if (commandSource == null)
			{
				throw new global::System.ArgumentNullException("commandSource");
			}
			if (global::Infragistics.Windows.Utilities.CanExecuteCommand(commandSource))
			{
				global::System.Windows.Input.ICommand command = commandSource.Command;
				global::System.Windows.Input.RoutedCommand routedCommand = command as global::System.Windows.Input.RoutedCommand;
				object commandParameter = commandSource.CommandParameter;
				if (routedCommand != null)
				{
					global::System.Windows.IInputElement target = commandSource.CommandTarget ?? (commandSource as global::System.Windows.IInputElement);
					routedCommand.Execute(commandParameter, target);
					return;
				}
				command.Execute(commandParameter);
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00062698 File Offset: 0x00060898
		internal static global::System.Windows.Media.Transform FindLayoutTransform(global::System.Windows.FrameworkElement element, global::System.Type transformType)
		{
			if (element.LayoutTransform == null)
			{
				return null;
			}
			if (element.LayoutTransform.GetType() == transformType)
			{
				return element.LayoutTransform;
			}
			if (element.LayoutTransform.GetType() == typeof(global::System.Windows.Media.TransformGroup))
			{
				global::System.Windows.Media.TransformGroup transformGroup = element.LayoutTransform as global::System.Windows.Media.TransformGroup;
				foreach (global::System.Windows.Media.Transform transform in transformGroup.Children)
				{
					if (transform.GetType() == transformType)
					{
						return transform;
					}
				}
			}
			return null;
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00062748 File Offset: 0x00060948
		internal static global::System.Windows.Media.Transform FindRenderTransform(global::System.Windows.UIElement element, global::System.Type transformType)
		{
			if (element.RenderTransform == null)
			{
				return null;
			}
			if (element.RenderTransform.GetType() == transformType)
			{
				return element.RenderTransform;
			}
			if (element.RenderTransform.GetType() == typeof(global::System.Windows.Media.TransformGroup))
			{
				global::System.Windows.Media.TransformGroup transformGroup = element.RenderTransform as global::System.Windows.Media.TransformGroup;
				foreach (global::System.Windows.Media.Transform transform in transformGroup.Children)
				{
					if (transform.GetType() == transformType)
					{
						return transform;
					}
				}
			}
			return null;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x000627F8 File Offset: 0x000609F8
		public static global::System.Windows.FrameworkElement GetAncestorFromName(global::System.Windows.DependencyObject descendant, string name)
		{
			for (global::System.Windows.DependencyObject dependencyObject = descendant; dependencyObject != null; dependencyObject = global::Infragistics.Windows.Utilities.GetParent(dependencyObject))
			{
				global::System.Windows.FrameworkElement frameworkElement = dependencyObject as global::System.Windows.FrameworkElement;
				if (frameworkElement != null && frameworkElement.Name == name)
				{
					return frameworkElement;
				}
			}
			return null;
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0006282E File Offset: 0x00060A2E
		public static global::System.Windows.DependencyObject GetAncestorFromType(global::System.Windows.DependencyObject descendant, global::System.Type type, bool allowSubclassOfType)
		{
			return global::Infragistics.Windows.Utilities.GetAncestorFromType(descendant, type, allowSubclassOfType, null);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x00062839 File Offset: 0x00060A39
		public static global::System.Windows.DependencyObject GetAncestorFromType(global::System.Windows.DependencyObject descendant, global::System.Type type, bool allowSubclassOfType, global::System.Windows.DependencyObject stopAtVisual)
		{
			return global::Infragistics.Windows.Utilities.GetAncestorFromType(descendant, type, allowSubclassOfType, stopAtVisual, null);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x00062848 File Offset: 0x00060A48
		public static global::System.Windows.DependencyObject GetAncestorFromType(global::System.Windows.DependencyObject descendant, global::System.Type type, bool allowSubclassOfType, global::System.Windows.DependencyObject stopAtVisual, global::System.Type stopAtType)
		{
			global::System.Windows.DependencyObject parent;
			for (global::System.Windows.DependencyObject child = descendant; child != null; child = parent)
			{
				parent = global::Infragistics.Windows.Utilities.GetParent(child);
				if (parent != null)
				{
					if (parent == stopAtVisual)
					{
						return null;
					}
					if (stopAtType != null && stopAtType == parent.GetType())
					{
						return null;
					}
					global::System.Type type2 = parent.GetType();
					if (type2 == type)
					{
						return parent;
					}
					if (allowSubclassOfType && type.IsAssignableFrom(type2))
					{
						return parent;
					}
				}
			}
			return null;
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000628AC File Offset: 0x00060AAC
		public static object GetAncestorPropertyValue(global::System.Windows.DependencyObject descendant, global::System.Windows.DependencyProperty dp, global::System.Windows.DependencyObject stopAtVisual)
		{
			global::System.Windows.DependencyObject parent;
			for (global::System.Windows.DependencyObject child = descendant; child != null; child = parent)
			{
				parent = global::Infragistics.Windows.Utilities.GetParent(child);
				if (parent != null)
				{
					if (parent == stopAtVisual)
					{
						return null;
					}
					object value = parent.GetValue(dp);
					if (value != null)
					{
						return value;
					}
				}
			}
			return null;
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x000628E0 File Offset: 0x00060AE0
		internal static global::System.Windows.Markup.XmlLanguage GetNonDefaultLanguage(global::System.Windows.DependencyObject element)
		{
			global::System.Windows.Markup.XmlLanguage xmlLanguage = element.GetValue(global::System.Windows.FrameworkElement.LanguageProperty) as global::System.Windows.Markup.XmlLanguage;
			if (xmlLanguage != null && global::System.Windows.DependencyPropertyHelper.GetValueSource(element, global::System.Windows.FrameworkElement.LanguageProperty).BaseValueSource == global::System.Windows.BaseValueSource.Default && xmlLanguage.GetEquivalentCulture().IetfLanguageTag == "en-US")
			{
				return null;
			}
			return xmlLanguage;
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x00062934 File Offset: 0x00060B34
		public static global::System.Globalization.CultureInfo GetNonNeutralCulture(global::System.Windows.IFrameworkInputElement element)
		{
			global::System.Windows.Markup.XmlLanguage xmlLanguage = null;
			if (element is global::System.Windows.FrameworkElement)
			{
				xmlLanguage = global::Infragistics.Windows.Utilities.GetNonDefaultLanguage((global::System.Windows.FrameworkElement)element);
			}
			else if (element is global::System.Windows.FrameworkContentElement)
			{
				xmlLanguage = global::Infragistics.Windows.Utilities.GetNonDefaultLanguage((global::System.Windows.FrameworkContentElement)element);
			}
			else if (element == null)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_NonNeutralCultureRequiresElement"), "element");
			}
			global::System.Globalization.CultureInfo cultureInfo = null;
			if (xmlLanguage != null)
			{
				try
				{
					cultureInfo = xmlLanguage.GetEquivalentCulture();
				}
				catch (global::System.InvalidOperationException)
				{
				}
			}
			if (cultureInfo == null)
			{
				cultureInfo = global::System.Globalization.CultureInfo.CurrentCulture;
				if (cultureInfo == null)
				{
					cultureInfo = global::System.Globalization.CultureInfo.InvariantCulture;
				}
			}
			return global::Infragistics.Windows.Utilities.GetNonNeutralCulture(cultureInfo);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x000629C0 File Offset: 0x00060BC0
		public static global::System.Globalization.CultureInfo GetNonNeutralCulture(global::System.Globalization.CultureInfo culture)
		{
			if (culture == null)
			{
				throw new global::System.ArgumentNullException("culture", global::SR.GetString("LE_NonNeutralCultureRequiresCulture"));
			}
			if (culture.IsNeutralCulture)
			{
				global::System.Globalization.CultureInfo cultureInfo = null;
				try
				{
					global::System.Globalization.CultureInfo[] cultures = global::System.Globalization.CultureInfo.GetCultures(global::System.Globalization.CultureTypes.SpecificCultures);
					foreach (global::System.Globalization.CultureInfo cultureInfo2 in cultures)
					{
						if (culture.Equals(cultureInfo2.Parent))
						{
							cultureInfo = cultureInfo2;
							break;
						}
					}
				}
				catch (global::System.Security.SecurityException)
				{
				}
				if (cultureInfo == null)
				{
					cultureInfo = global::System.Globalization.CultureInfo.CurrentCulture;
				}
				if (cultureInfo == null || cultureInfo.IsNeutralCulture)
				{
					cultureInfo = global::System.Globalization.CultureInfo.InvariantCulture;
				}
				culture = cultureInfo;
			}
			return culture;
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00062A54 File Offset: 0x00060C54
		public static global::System.Windows.FrameworkElement GetDescendantFromName(global::System.Windows.DependencyObject parent, string name)
		{
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(parent);
			if (childrenCount < 1)
			{
				return null;
			}
			for (int i = 0; i < childrenCount; i++)
			{
				global::System.Windows.FrameworkElement frameworkElement = global::System.Windows.Media.VisualTreeHelper.GetChild(parent, i) as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					if (frameworkElement.Name == name)
					{
						return frameworkElement;
					}
					frameworkElement = global::Infragistics.Windows.Utilities.GetDescendantFromName(frameworkElement, name);
					if (frameworkElement != null)
					{
						return frameworkElement;
					}
				}
			}
			return null;
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00062AA8 File Offset: 0x00060CA8
		public static global::System.Windows.DependencyObject GetDescendantFromType(global::System.Windows.DependencyObject parent, global::System.Type type, bool allowSubclassOfType)
		{
			return global::Infragistics.Windows.Utilities.GetDescendantFromType<global::System.Windows.DependencyObject>(parent, type, allowSubclassOfType, null, null);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00062AB4 File Offset: 0x00060CB4
		public static T GetDescendantFromType<T>(global::System.Windows.DependencyObject parent, bool allowSubclassOfType, global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<T> callback) where T : global::System.Windows.DependencyObject
		{
			return global::Infragistics.Windows.Utilities.GetDescendantFromType<T>(parent, allowSubclassOfType, callback, null);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00062ABF File Offset: 0x00060CBF
		public static T GetDescendantFromType<T>(global::System.Windows.DependencyObject parent, bool allowSubclassOfType, global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<T> callback, global::System.Type[] typesToIgnore) where T : global::System.Windows.DependencyObject
		{
			return global::Infragistics.Windows.Utilities.GetDescendantFromType<T>(parent, typeof(T), allowSubclassOfType, callback, typesToIgnore);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00062AD4 File Offset: 0x00060CD4
		private static T GetDescendantFromType<T>(global::System.Windows.DependencyObject parent, global::System.Type type, bool allowSubclassOfType, global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<T> callback, global::System.Type[] typesToIgnore) where T : global::System.Windows.DependencyObject
		{
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(parent);
			if (childrenCount < 1)
			{
				return default(T);
			}
			for (int i = 0; i < childrenCount; i++)
			{
				T t = global::System.Windows.Media.VisualTreeHelper.GetChild(parent, i) as T;
				if (t != null)
				{
					global::System.Type type2 = t.GetType();
					if ((type2 == type || (allowSubclassOfType && type.IsAssignableFrom(type2))) && (callback == null || callback(t)))
					{
						return t;
					}
				}
			}
			for (int j = 0; j < childrenCount; j++)
			{
				global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetChild(parent, j);
				if (dependencyObject != null && (typesToIgnore == null || !global::Infragistics.Windows.Utilities.ContainsType(typesToIgnore, dependencyObject.GetType())))
				{
					dependencyObject = global::Infragistics.Windows.Utilities.GetDescendantFromType<T>(dependencyObject, type, allowSubclassOfType, callback, typesToIgnore);
					if (dependencyObject != null)
					{
						return (T)((object)dependencyObject);
					}
				}
			}
			return default(T);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00062BA8 File Offset: 0x00060DA8
		private static bool ContainsType(global::System.Type[] types, global::System.Type typeToLocate)
		{
			for (int i = 0; i < types.Length; i++)
			{
				if (typeToLocate == types[i] || types[i].IsAssignableFrom(typeToLocate))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00062BDC File Offset: 0x00060DDC
		private static global::System.Windows.UIElement GetElementToAdorn(global::System.Windows.Documents.AdornerLayer layer, global::System.Windows.UIElement adornedElement)
		{
			if (layer != null)
			{
				global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(layer);
				int i = 0;
				int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(parent);
				while (i < childrenCount)
				{
					global::System.Windows.Media.Visual visual = global::System.Windows.Media.VisualTreeHelper.GetChild(parent, i) as global::System.Windows.Media.Visual;
					if (visual != null && visual.IsAncestorOf(adornedElement))
					{
						return visual as global::System.Windows.UIElement;
					}
					i++;
				}
			}
			return null;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00062C27 File Offset: 0x00060E27
		public static char GetFirstMnemonicChar(string text)
		{
			return global::Infragistics.Windows.Utilities.GetFirstMnemonicChar(text, global::System.Globalization.CultureInfo.CurrentUICulture);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x00062C34 File Offset: 0x00060E34
		public static char GetFirstMnemonicChar(string text, global::System.Globalization.CultureInfo culture)
		{
			if (text == null || text.Length < 1)
			{
				return '\0';
			}
			int num = text.IndexOf('_');
			if (num < 0)
			{
				return '\0';
			}
			int i = num;
			while (i <= text.Length - 2)
			{
				char c = text[i + 1];
				if (char.IsLetterOrDigit(c))
				{
					if (culture != null)
					{
						return char.ToUpper(c, culture);
					}
					return c;
				}
				else
				{
					num = text.IndexOf('_', i + 2);
					if (num <= i)
					{
						break;
					}
					i = num;
				}
			}
			return '\0';
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00062CA0 File Offset: 0x00060EA0
		public static global::System.Windows.DependencyObject GetItemsHostFromItem(global::System.Windows.DependencyObject item)
		{
			global::System.Windows.DependencyObject parent;
			for (global::System.Windows.DependencyObject dependencyObject = item; dependencyObject != null; dependencyObject = parent)
			{
				parent = global::Infragistics.Windows.Utilities.GetParent(dependencyObject);
				if (parent == null)
				{
					parent = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
				}
				if (parent != null)
				{
					global::System.Windows.Controls.Panel panel = parent as global::System.Windows.Controls.Panel;
					if (panel != null && panel.IsItemsHost)
					{
						return parent;
					}
				}
				if (parent is global::System.Windows.Controls.ItemsControl)
				{
					return null;
				}
			}
			return null;
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00062CE9 File Offset: 0x00060EE9
		public static global::System.Windows.DependencyObject GetParent(global::System.Windows.DependencyObject child)
		{
			return global::Infragistics.Windows.Utilities.GetParent(child, true);
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00062CF4 File Offset: 0x00060EF4
		public static global::System.Windows.DependencyObject GetParent(global::System.Windows.DependencyObject child, bool includeLogicalParent)
		{
			if (child == null)
			{
				throw new global::System.ArgumentNullException("child");
			}
			global::System.Windows.Media.Visual visual = child as global::System.Windows.Media.Visual;
			if (visual != null)
			{
				global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(visual);
				if (parent != null)
				{
					return parent;
				}
				if (includeLogicalParent)
				{
					global::System.Windows.FrameworkElement frameworkElement = child as global::System.Windows.FrameworkElement;
					if (frameworkElement != null)
					{
						return frameworkElement.Parent;
					}
				}
				return null;
			}
			else
			{
				if (includeLogicalParent)
				{
					global::System.Windows.FrameworkContentElement frameworkContentElement = child as global::System.Windows.FrameworkContentElement;
					if (frameworkContentElement != null)
					{
						return frameworkContentElement.Parent;
					}
				}
				global::System.Windows.Media.Media3D.Visual3D visual3D = child as global::System.Windows.Media.Media3D.Visual3D;
				if (visual3D != null)
				{
					return global::System.Windows.Media.VisualTreeHelper.GetParent(visual3D);
				}
				return null;
			}
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00062D64 File Offset: 0x00060F64
		public static object GetPropertyValueFromStyle(global::System.Windows.Style style, global::System.Windows.DependencyProperty property, bool walkUpBasedOnChain, bool returnBindingAsBinding)
		{
			object propertyValueFromStyleHelper = global::Infragistics.Windows.Utilities.GetPropertyValueFromStyleHelper(style, property, walkUpBasedOnChain);
			if (!returnBindingAsBinding)
			{
				global::System.Windows.Data.BindingExpressionBase bindingExpressionBase = propertyValueFromStyleHelper as global::System.Windows.Data.BindingExpressionBase;
				if (bindingExpressionBase != null)
				{
					return bindingExpressionBase.ParentBindingBase.ProvideValue(null);
				}
				global::System.Windows.Data.BindingBase bindingBase = propertyValueFromStyleHelper as global::System.Windows.Data.BindingBase;
				if (bindingBase != null)
				{
					return bindingBase.ProvideValue(null);
				}
			}
			return propertyValueFromStyleHelper;
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00062DA8 File Offset: 0x00060FA8
		private static object GetPropertyValueFromStyleHelper(global::System.Windows.Style style, global::System.Windows.DependencyProperty property, bool walkUpBasedOnChain)
		{
			if (style == null)
			{
				throw new global::System.ArgumentNullException("style");
			}
			if (property == null)
			{
				throw new global::System.ArgumentNullException("property");
			}
			foreach (global::System.Windows.SetterBase setterBase in style.Setters)
			{
				global::System.Windows.Setter setter = setterBase as global::System.Windows.Setter;
				if (setter != null && setter.Property == property)
				{
					return setter.Value;
				}
			}
			object result = null;
			if (walkUpBasedOnChain)
			{
				global::System.Windows.Style basedOn = style.BasedOn;
				if (basedOn != null)
				{
					result = global::Infragistics.Windows.Utilities.GetPropertyValueFromStyleHelper(basedOn, property, true);
				}
			}
			return result;
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00062E48 File Offset: 0x00061048
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static string GetPublicKeyToken(global::System.Type type)
		{
			if (type == null)
			{
				throw new global::System.ArgumentNullException("type");
			}
			global::System.Reflection.Assembly assembly = global::System.Reflection.Assembly.GetAssembly(type);
			return global::Infragistics.Windows.Utilities.GetPublicKeyToken(assembly);
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00062E78 File Offset: 0x00061078
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static string GetPublicKeyToken(global::System.Reflection.Assembly assemblyToCheck)
		{
			if (assemblyToCheck == null)
			{
				throw new global::System.ArgumentNullException("assemblyToCheck");
			}
			string[] array = assemblyToCheck.FullName.Split(new char[]
			{
				'='
			});
			for (int i = array.Length - 1; i > 0; i--)
			{
				if (array[i - 1].Length >= "PublicKeyToken".Length)
				{
					string text = array[i - 1].Substring(array[i - 1].Length - "PublicKeyToken".Length);
					if (text.Equals("PublicKeyToken"))
					{
						if (array[i].Length < 17)
						{
							return array[i];
						}
						return array[i].Substring(0, 16);
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00062F28 File Offset: 0x00061128
		internal static global::System.Windows.Documents.AdornerLayer GetRootAdornerLayer(global::System.Windows.UIElement adornedElement, out global::System.Windows.UIElement elementToAdorn)
		{
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(adornedElement);
			if (adornerLayer != null)
			{
				global::System.Windows.Documents.AdornerLayer adornerLayer2 = null;
				while (adornerLayer != null && adornerLayer != adornerLayer2)
				{
					adornerLayer2 = adornerLayer;
					global::System.Windows.Media.Visual visual = global::System.Windows.Media.VisualTreeHelper.GetParent(adornerLayer) as global::System.Windows.Media.Visual;
					if (visual == null)
					{
						break;
					}
					adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(visual);
				}
				adornerLayer = adornerLayer2;
			}
			elementToAdorn = global::Infragistics.Windows.Utilities.GetElementToAdorn(adornerLayer, adornedElement);
			return adornerLayer;
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00062F6E File Offset: 0x0006116E
		public static T GetTemplateChild<T>(global::System.Windows.FrameworkElement templatedParent) where T : global::System.Windows.DependencyObject
		{
			return global::Infragistics.Windows.Utilities.GetTemplateChild<T>(templatedParent, templatedParent, null);
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00062F78 File Offset: 0x00061178
		public static T GetTemplateChild<T>(global::System.Windows.FrameworkElement templatedParent, global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<T> callback) where T : global::System.Windows.DependencyObject
		{
			return global::Infragistics.Windows.Utilities.GetTemplateChild<T>(templatedParent, templatedParent, callback);
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00062F84 File Offset: 0x00061184
		private static T GetTemplateChild<T>(global::System.Windows.FrameworkElement templatedParent, global::System.Windows.DependencyObject parent, global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<T> callback) where T : global::System.Windows.DependencyObject
		{
			global::Infragistics.Windows.Helpers.HashSet processedChildren = new global::Infragistics.Windows.Helpers.HashSet();
			return global::Infragistics.Windows.Utilities.GetTemplateChild<T>(templatedParent, parent, callback, processedChildren);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00062FA0 File Offset: 0x000611A0
		private static T GetTemplateChild<T>(global::System.Windows.FrameworkElement templatedParent, global::System.Windows.DependencyObject parent, global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<T> callback, global::Infragistics.Windows.Helpers.HashSet processedChildren) where T : global::System.Windows.DependencyObject
		{
			if (parent == null)
			{
				return default(T);
			}
			global::System.Windows.DependencyObject dependencyObject = null;
			foreach (object obj in global::System.Windows.LogicalTreeHelper.GetChildren(parent))
			{
				global::System.Windows.DependencyObject dependencyObject2 = obj as global::System.Windows.DependencyObject;
				T result;
				if ((!global::Infragistics.Windows.Utilities.GetTemplatedParent(dependencyObject2, out dependencyObject) || dependencyObject == templatedParent) && global::Infragistics.Windows.Utilities.GetTemplateChild<T>(templatedParent, callback, dependencyObject2, processedChildren, out result))
				{
					return result;
				}
			}
			if (!global::Infragistics.Windows.Utilities.IsVisual(parent))
			{
				return default(T);
			}
			int i = 0;
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(parent);
			while (i < childrenCount)
			{
				global::System.Windows.DependencyObject child = global::System.Windows.Media.VisualTreeHelper.GetChild(parent, i);
				if (global::Infragistics.Windows.Utilities.GetTemplatedParent(child, out dependencyObject) && dependencyObject != templatedParent)
				{
					return default(T);
				}
				T result;
				if (global::Infragistics.Windows.Utilities.GetTemplateChild<T>(templatedParent, callback, child, processedChildren, out result))
				{
					return result;
				}
				i++;
			}
			return default(T);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0006309C File Offset: 0x0006129C
		private static bool GetTemplateChild<T>(global::System.Windows.FrameworkElement templatedParent, global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<T> callback, global::System.Windows.DependencyObject child, global::Infragistics.Windows.Helpers.HashSet processedChildren, out T targetChild) where T : global::System.Windows.DependencyObject
		{
			if (child != null && !processedChildren.Exists(child))
			{
				targetChild = (child as T);
				if (targetChild != null && (callback == null || callback(targetChild)))
				{
					return true;
				}
				processedChildren.Add(child);
				targetChild = global::Infragistics.Windows.Utilities.GetTemplateChild<T>(templatedParent, child, callback, processedChildren);
				if (targetChild != null)
				{
					return true;
				}
			}
			targetChild = default(T);
			return false;
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0006311C File Offset: 0x0006131C
		internal static global::System.Windows.DependencyObject GetTemplatedParent(global::System.Windows.DependencyObject reference)
		{
			global::System.Windows.DependencyObject result;
			global::Infragistics.Windows.Utilities.GetTemplatedParent(reference, out result);
			return result;
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00063134 File Offset: 0x00061334
		private static bool GetTemplatedParent(global::System.Windows.DependencyObject reference, out global::System.Windows.DependencyObject templatedParent)
		{
			global::System.Windows.FrameworkElement frameworkElement = reference as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				templatedParent = frameworkElement.TemplatedParent;
				return true;
			}
			global::System.Windows.FrameworkContentElement frameworkContentElement = reference as global::System.Windows.FrameworkContentElement;
			if (frameworkContentElement != null)
			{
				templatedParent = frameworkContentElement.TemplatedParent;
				return true;
			}
			templatedParent = null;
			return false;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00063170 File Offset: 0x00061370
		public static bool HasLoadedAncestor(global::System.Windows.DependencyObject d)
		{
			global::System.Windows.DependencyObject dependencyObject = d;
			while (dependencyObject != null)
			{
				global::System.Windows.FrameworkElement frameworkElement = dependencyObject as global::System.Windows.FrameworkElement;
				if (frameworkElement != null && frameworkElement.IsLoaded)
				{
					return true;
				}
				global::System.Windows.DependencyObject dependencyObject2 = dependencyObject;
				dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
				if (dependencyObject == null && (dependencyObject2 is global::System.Windows.Media.Visual || dependencyObject2 is global::System.Windows.Media.Media3D.Visual3D))
				{
					dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject2);
				}
			}
			return false;
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x000631C0 File Offset: 0x000613C0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static bool HasSamePublicKey(global::System.Type type)
		{
			if (type == null)
			{
				return false;
			}
			string publicKeyToken = global::Infragistics.Windows.Utilities.GetPublicKeyToken(type);
			if (string.Equals("7dd5c3163f2cd0cb", publicKeyToken))
			{
				return true;
			}
			string publicKeyToken2 = global::Infragistics.Windows.Utilities.GetPublicKeyToken(typeof(global::Infragistics.Windows.Utilities));
			return publicKeyToken.Equals(publicKeyToken2);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00063208 File Offset: 0x00061408
		internal static void InvalidateMeasure(global::System.Windows.UIElement descendant, global::System.Windows.UIElement ancestor)
		{
			for (;;)
			{
				global::System.Windows.UIElement uielement = global::System.Windows.Media.VisualTreeHelper.GetParent(descendant) as global::System.Windows.UIElement;
				if (uielement == null)
				{
					return;
				}
				if (uielement == ancestor)
				{
					break;
				}
				uielement.InvalidateMeasure();
				descendant = uielement;
			}
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00063234 File Offset: 0x00061434
		public static bool IsDescendantOf(global::System.Windows.DependencyObject ancestor, global::System.Windows.DependencyObject descendant)
		{
			return global::Infragistics.Windows.Utilities.IsDescendantOf(ancestor, descendant, false);
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0006323E File Offset: 0x0006143E
		public static bool IsDescendantOf(global::System.Windows.DependencyObject ancestor, global::System.Windows.DependencyObject descendant, bool preferLogicalTree)
		{
			return global::Infragistics.Windows.Utilities.IsDescendantOf(ancestor, descendant, preferLogicalTree, false);
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0006324C File Offset: 0x0006144C
		internal static bool IsDescendantOf(global::System.Windows.DependencyObject ancestor, global::System.Windows.DependencyObject descendant, bool preferLogicalTree, bool usePopupTarget)
		{
			if (ancestor == null)
			{
				throw new global::System.ArgumentNullException("ancestor");
			}
			while (descendant != null)
			{
				if (usePopupTarget && descendant is global::System.Windows.Controls.Primitives.Popup && ((global::System.Windows.Controls.Primitives.Popup)descendant).PlacementTarget != null)
				{
					descendant = ((global::System.Windows.Controls.Primitives.Popup)descendant).PlacementTarget;
				}
				else if (!preferLogicalTree)
				{
					descendant = global::Infragistics.Windows.Utilities.GetParent(descendant);
				}
				else
				{
					descendant = (global::System.Windows.LogicalTreeHelper.GetParent(descendant) ?? global::Infragistics.Windows.Utilities.GetParent(descendant, false));
				}
				if (ancestor == descendant)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x000632B8 File Offset: 0x000614B8
		private static bool IsVisual(object reference)
		{
			return reference is global::System.Windows.Media.Visual || reference is global::System.Windows.Media.Media3D.Visual3D;
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x000632D0 File Offset: 0x000614D0
		public static global::System.Windows.Input.Cursor LoadCursor(global::System.Type typeInAssembly, string cursorPath)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(typeInAssembly, "typeInAssembly");
			global::Infragistics.Windows.Utilities.ThrowIfNullOrEmpty(cursorPath, "cursorPath");
			global::System.Uri uri = global::Infragistics.CoreUtilities.BuildEmbeddedResourceUri(typeInAssembly.Assembly, cursorPath);
			global::System.Windows.Input.Cursor result;
			try
			{
				result = global::Infragistics.Windows.Utilities.LoadCursor(uri);
			}
			catch (global::System.IO.IOException)
			{
				result = null;
			}
			catch (global::System.UnauthorizedAccessException)
			{
				result = null;
			}
			catch (global::System.Security.SecurityException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00063344 File Offset: 0x00061544
		internal static global::System.Windows.Input.Cursor LoadCursor(global::System.Uri uri)
		{
			global::System.Windows.Resources.StreamResourceInfo resourceStream = global::System.Windows.Application.GetResourceStream(uri);
			return new global::System.Windows.Input.Cursor(resourceStream.Stream);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00063364 File Offset: 0x00061564
		public static void RemoveAll(global::System.Collections.ArrayList list, object itemToRemove)
		{
			int num = 0;
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				if (itemToRemove == list[i])
				{
					num++;
				}
				else if (num != 0)
				{
					list[i - num] = list[i];
				}
			}
			list.RemoveRange(count - num, num);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x000633D4 File Offset: 0x000615D4
		internal static void SetFocusedElement(global::System.Windows.DependencyObject focusScope, global::System.Windows.UIElement newFocusedElement)
		{
			global::System.Windows.Input.KeyboardFocusChangedEventHandler handler = delegate(object s, global::System.Windows.Input.KeyboardFocusChangedEventArgs se)
			{
				if (se.NewFocus == newFocusedElement)
				{
					se.Handled = true;
				}
			};
			newFocusedElement.AddHandler(global::System.Windows.Input.Keyboard.PreviewGotKeyboardFocusEvent, handler);
			newFocusedElement.AddHandler(global::System.Windows.Input.Keyboard.PreviewLostKeyboardFocusEvent, handler);
			global::System.Windows.Input.FocusManager.SetFocusedElement(focusScope, newFocusedElement);
			newFocusedElement.RemoveHandler(global::System.Windows.Input.Keyboard.PreviewLostKeyboardFocusEvent, handler);
			newFocusedElement.RemoveHandler(global::System.Windows.Input.Keyboard.PreviewGotKeyboardFocusEvent, handler);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0006344C File Offset: 0x0006164C
		public static bool SetPropertyFromStyle(global::System.Windows.DependencyObject target, global::System.Windows.DependencyProperty targetProperty, global::System.Windows.Style source, global::System.Windows.DependencyProperty sourceProperty, bool walkUpBasedOnChain)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			if (sourceProperty == null)
			{
				throw new global::System.ArgumentNullException("sourceProperty");
			}
			if (targetProperty == null)
			{
				throw new global::System.ArgumentNullException("targetProperty");
			}
			if (!targetProperty.PropertyType.IsAssignableFrom(sourceProperty.PropertyType))
			{
				throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_10"));
			}
			object propertyValueFromStyle = global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(source, sourceProperty, walkUpBasedOnChain, true);
			global::System.Windows.Data.BindingExpressionBase bindingExpressionBase = propertyValueFromStyle as global::System.Windows.Data.BindingExpressionBase;
			if (bindingExpressionBase != null)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(target, targetProperty, bindingExpressionBase.ParentBindingBase);
				return true;
			}
			global::System.Windows.Data.BindingBase bindingBase = propertyValueFromStyle as global::System.Windows.Data.BindingBase;
			if (bindingBase != null)
			{
				if (target is global::System.Windows.FrameworkElement)
				{
					((global::System.Windows.FrameworkElement)target).SetBinding(targetProperty, bindingBase);
					return true;
				}
				if (target is global::System.Windows.FrameworkContentElement)
				{
					((global::System.Windows.FrameworkContentElement)target).SetBinding(targetProperty, bindingBase);
					return true;
				}
				return false;
			}
			else
			{
				if (propertyValueFromStyle == null)
				{
					return false;
				}
				bool flag = targetProperty.PropertyType.IsAssignableFrom(propertyValueFromStyle.GetType());
				if (flag)
				{
					target.SetValue(targetProperty, propertyValueFromStyle);
				}
				return flag;
			}
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0006352C File Offset: 0x0006172C
		public static void SortMerge(global::System.Collections.ArrayList arrayList, global::System.Collections.IComparer comparer)
		{
			if (arrayList == null)
			{
				throw new global::System.ArgumentNullException("arrayList");
			}
			if (comparer == null)
			{
				throw new global::System.ArgumentNullException("comparer");
			}
			object[] array = arrayList.ToArray();
			global::Infragistics.CoreUtilities.SortMerge(array, null, comparer);
			arrayList.Clear();
			arrayList.AddRange(array);
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00063574 File Offset: 0x00061774
		public static string StripMnemonics(string text, bool escapeRemainingMnemonics)
		{
			if (text == null || text.Length < 2)
			{
				return text;
			}
			int num = text.IndexOf('_');
			if (num < 0)
			{
				return text;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (num > 0)
			{
				stringBuilder.Append(text.Substring(0, num));
			}
			bool flag = false;
			int i = num;
			int num2 = text.Length - 1;
			while (i < num2)
			{
				char c = text[i];
				if (c == '_')
				{
					char c2 = text[i + 1];
					if (c2 == '_')
					{
						if (escapeRemainingMnemonics)
						{
							stringBuilder.Append('_');
						}
					}
					else if (flag)
					{
						if (escapeRemainingMnemonics)
						{
							stringBuilder.Append('_');
						}
						stringBuilder.Append('_');
					}
					else
					{
						flag = true;
					}
					stringBuilder.Append(c2);
					i++;
				}
				else
				{
					stringBuilder.Append(c);
				}
				if (i == num2 - 1)
				{
					char c2 = text[i + 1];
					stringBuilder.Append(c2);
				}
				i++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x0006365C File Offset: 0x0006185C
		public static global::System.Windows.Point TransformPointToAncestorCoordinates(global::System.Windows.Point pointToTransform, global::System.Windows.Media.Visual descendantVisual, global::System.Windows.Media.Visual ancestorVisual)
		{
			global::System.Windows.Media.MatrixTransform matrixTransform = descendantVisual.TransformToAncestor(ancestorVisual) as global::System.Windows.Media.MatrixTransform;
			return matrixTransform.Matrix.Transform(pointToTransform);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00063688 File Offset: 0x00061888
		public static global::System.Windows.Point TransformPointToDescendantCoordinates(global::System.Windows.Point pointToTransform, global::System.Windows.Media.Visual descendantVisual, global::System.Windows.Media.Visual ancestorVisual)
		{
			global::System.Windows.Media.MatrixTransform matrixTransform = ancestorVisual.TransformToDescendant(descendantVisual) as global::System.Windows.Media.MatrixTransform;
			return matrixTransform.Matrix.Transform(pointToTransform);
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x000636B4 File Offset: 0x000618B4
		public static object GetDefaultValue(global::System.Windows.DependencyProperty dependencyProperty, global::System.Windows.DependencyObject obj)
		{
			global::System.Windows.PropertyMetadata metadata = dependencyProperty.GetMetadata(obj);
			if (metadata == null)
			{
				return dependencyProperty.DefaultMetadata.DefaultValue;
			}
			return metadata.DefaultValue;
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x000636E0 File Offset: 0x000618E0
		public static bool ShouldSerialize(global::System.Windows.DependencyProperty dependencyProperty, global::System.Windows.DependencyObject obj)
		{
			object defaultValue = global::Infragistics.Windows.Utilities.GetDefaultValue(dependencyProperty, obj);
			object value = obj.GetValue(dependencyProperty);
			return !object.Equals(defaultValue, value);
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00063708 File Offset: 0x00061908
		public static global::System.Windows.ResourceDictionary CreateResourceSetDictionary(global::System.Reflection.Assembly assembly, string resourcePath)
		{
			if (assembly == null)
			{
				throw new global::System.ArgumentNullException("assembly");
			}
			if (resourcePath == null)
			{
				throw new global::System.ArgumentNullException("resourcePath");
			}
			global::System.Windows.ResourceDictionary resourceDictionary = new global::System.Windows.ResourceDictionary();
			string[] array = resourcePath.Split(new char[]
			{
				';'
			});
			if (array.Length == 1)
			{
				global::System.Uri source = global::Infragistics.CoreUtilities.BuildEmbeddedResourceUri(assembly, array[0]);
				resourceDictionary.Source = source;
			}
			else
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Length != 0)
					{
						global::System.Windows.ResourceDictionary resourceDictionary2 = new global::System.Windows.ResourceDictionary();
						global::System.Uri source2 = global::Infragistics.CoreUtilities.BuildEmbeddedResourceUri(assembly, array[i]);
						resourceDictionary2.Source = source2;
						resourceDictionary.MergedDictionaries.Add(resourceDictionary2);
					}
				}
			}
			return resourceDictionary;
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x000637AE File Offset: 0x000619AE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static int CaretBlinkTime
		{
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.CaretBlinkTime;
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x000637B5 File Offset: 0x000619B5
		public static global::System.Windows.Point PointFromScreenSafe(global::System.Windows.Media.Visual element, global::System.Windows.Point point)
		{
			return global::Infragistics.Windows.Utilities.PointFromScreenSafe(element, point, null);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x000637C0 File Offset: 0x000619C0
		public static global::System.Windows.Point PointFromScreenSafe(global::System.Windows.Media.Visual element, global::System.Windows.Point point, global::System.Windows.Media.Visual refElement)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				try
				{
					return element.PointFromScreen(point);
				}
				catch (global::System.InvalidOperationException)
				{
					return new global::System.Windows.Point(-1.0, -1.0);
				}
			}
			global::System.Windows.Media.Visual commonAncestor = global::Infragistics.Windows.Utilities.GetCommonAncestor(element, refElement);
			if (commonAncestor == null || commonAncestor == element)
			{
				return point;
			}
			global::System.Windows.FrameworkElement frameworkElement = element as global::System.Windows.FrameworkElement;
			global::System.Windows.FrameworkElement frameworkElement2 = commonAncestor as global::System.Windows.FrameworkElement;
			if (frameworkElement != null && frameworkElement2 != null)
			{
				return frameworkElement2.TranslatePoint(point, frameworkElement);
			}
			global::System.Windows.Media.GeneralTransform generalTransform = element.TransformToAncestor(commonAncestor);
			if (generalTransform != null)
			{
				generalTransform.Transform(point);
			}
			return point;
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00063860 File Offset: 0x00061A60
		internal static global::System.Windows.Media.Visual GetCommonAncestor(global::System.Windows.Media.Visual element, global::System.Windows.Media.Visual refElement)
		{
			global::System.Windows.Media.Visual visual = null;
			if (refElement != null)
			{
				visual = (refElement.FindCommonVisualAncestor(element) as global::System.Windows.Media.Visual);
			}
			if (visual == null)
			{
				global::System.Windows.Media.Visual visual3;
				for (global::System.Windows.Media.Visual visual2 = global::System.Windows.Media.VisualTreeHelper.GetParent(element) as global::System.Windows.Media.Visual; visual2 != null; visual2 = visual3)
				{
					visual = visual2;
					visual3 = (global::System.Windows.Media.VisualTreeHelper.GetParent(visual2) as global::System.Windows.Media.Visual);
					if (visual3 == null)
					{
						visual3 = (global::System.Windows.LogicalTreeHelper.GetParent(visual2) as global::System.Windows.Media.Visual);
						if (visual3 is global::System.Windows.Controls.Primitives.Popup && global::System.Windows.Media.VisualTreeHelper.GetParent(visual3) == null)
						{
							global::Infragistics.Windows.Controls.ToolWindowHostPopup host = global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetHost(visual3 as global::System.Windows.Controls.Primitives.Popup);
							if (host != null && host.Child is global::Infragistics.Windows.Controls.ToolWindow)
							{
								visual3 = ((global::Infragistics.Windows.Controls.ToolWindow)host.Child).Owner;
							}
							else
							{
								visual3 = null;
							}
						}
					}
				}
			}
			return visual;
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x000638F4 File Offset: 0x00061AF4
		public static global::System.Windows.Point PointToScreenSafe(global::System.Windows.Media.Visual element, global::System.Windows.Point point)
		{
			return global::Infragistics.Windows.Utilities.PointToScreenSafe(element, point, null);
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00063900 File Offset: 0x00061B00
		public static global::System.Windows.Point PointToScreenSafe(global::System.Windows.Media.Visual element, global::System.Windows.Point point, global::System.Windows.Media.Visual refElement)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				return element.PointToScreen(point);
			}
			global::System.Windows.Media.Visual commonAncestor = global::Infragistics.Windows.Utilities.GetCommonAncestor(element, refElement);
			if (commonAncestor == null || commonAncestor == element)
			{
				return point;
			}
			global::System.Windows.FrameworkElement frameworkElement = element as global::System.Windows.FrameworkElement;
			global::System.Windows.FrameworkElement frameworkElement2 = commonAncestor as global::System.Windows.FrameworkElement;
			if (frameworkElement != null && frameworkElement2 != null)
			{
				return frameworkElement.TranslatePoint(point, frameworkElement2);
			}
			global::System.Windows.Media.GeneralTransform generalTransform = element.TransformToAncestor(commonAncestor);
			if (generalTransform != null)
			{
				generalTransform.Transform(point);
			}
			return point;
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0006396C File Offset: 0x00061B6C
		public static global::System.Windows.Rect GetWorkArea(global::System.Windows.Media.Visual element)
		{
			return global::Infragistics.Windows.Utilities.GetWorkArea(element, null);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00063978 File Offset: 0x00061B78
		public static global::System.Windows.Rect GetWorkArea(global::System.Windows.Media.Visual element, global::System.Windows.Media.Visual refElement)
		{
			return global::Infragistics.Windows.Utilities.GetWorkArea(element, default(global::System.Windows.Point), refElement);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00063998 File Offset: 0x00061B98
		public static global::System.Windows.Rect GetWorkArea(global::System.Windows.Media.Visual element, global::System.Windows.Point point, global::System.Windows.Media.Visual refElement)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWorkArea(global::Infragistics.Windows.Utilities.PointToScreenSafe(element, point, refElement));
			}
			global::System.Windows.FrameworkElement frameworkElement = element as global::System.Windows.FrameworkElement;
			global::System.Windows.Media.Visual commonAncestor = global::Infragistics.Windows.Utilities.GetCommonAncestor(element, refElement);
			if (commonAncestor == null || commonAncestor == element)
			{
				if (frameworkElement != null)
				{
					return new global::System.Windows.Rect(frameworkElement.RenderSize);
				}
				return default(global::System.Windows.Rect);
			}
			else
			{
				global::System.Windows.Window window = commonAncestor as global::System.Windows.Window;
				if (window != null)
				{
					global::System.Windows.FrameworkElement frameworkElement2 = (global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(window) > 0) ? (global::System.Windows.Media.VisualTreeHelper.GetChild(window, 0) as global::System.Windows.FrameworkElement) : null;
					if (frameworkElement2 != null)
					{
						return new global::System.Windows.Rect(frameworkElement2.RenderSize);
					}
				}
				global::System.Windows.FrameworkElement frameworkElement3 = commonAncestor as global::System.Windows.FrameworkElement;
				if (frameworkElement3 != null)
				{
					return new global::System.Windows.Rect(frameworkElement3.RenderSize);
				}
				return default(global::System.Windows.Rect);
			}
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00063A50 File Offset: 0x00061C50
		public static global::System.Windows.Rect RectFromPoints(global::System.Windows.Point point1, global::System.Windows.Point point2)
		{
			double x = global::System.Math.Min(point1.X, point2.X);
			double y = global::System.Math.Min(point1.Y, point2.Y);
			double width = global::System.Math.Abs(point2.X - point1.X);
			double height = global::System.Math.Abs(point2.Y - point1.Y);
			return new global::System.Windows.Rect(x, y, width, height);
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00063AB8 File Offset: 0x00061CB8
		internal static void VerifyCanBeModified(global::System.Windows.ResourceDictionary dictionary)
		{
			if (dictionary.IsReadOnly)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_ResourceDictionaryReadOnly"));
			}
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00063AD4 File Offset: 0x00061CD4
		internal static void ThrowIfInvalidEnum(global::System.Enum parameter, string parameterName)
		{
			global::System.Type type = parameter.GetType();
			if (!global::System.Enum.IsDefined(type, parameter))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(parameterName, global::System.Convert.ToInt32(parameter), type);
			}
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00063AFF File Offset: 0x00061CFF
		internal static void ThrowIfNull(object parameter, string parameterName)
		{
			if (parameter == null)
			{
				throw new global::System.ArgumentNullException(parameterName);
			}
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00063B0B File Offset: 0x00061D0B
		internal static void ThrowIfNullOrEmpty(string parameter, string parameterName)
		{
			if (string.IsNullOrEmpty(parameter))
			{
				throw new global::System.ArgumentNullException(parameterName);
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00063B1C File Offset: 0x00061D1C
		public static bool IsNumericType(global::System.Type type)
		{
			return (type.IsPrimitive || type == typeof(decimal)) && (type != typeof(bool) && type != typeof(char));
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00063B6C File Offset: 0x00061D6C
		public static bool GetSnapElementToDevicePixels(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Utilities.SnapElementToDevicePixelsProperty);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00063B7E File Offset: 0x00061D7E
		public static void SetSnapElementToDevicePixels(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Utilities.SnapElementToDevicePixelsProperty, value);
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00063B94 File Offset: 0x00061D94
		private static void OnSnapElementToDevicePixelsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.FrameworkElement frameworkElement = d as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				if (e.Property == global::Infragistics.Windows.Utilities.SnapElementToDevicePixelsProperty)
				{
					frameworkElement.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::System.Windows.Threading.DispatcherOperationCallback(global::Infragistics.Windows.Utilities.OnSyncSnapElementActual), d);
					return;
				}
				global::System.Windows.RoutedEventHandler value = new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.Utilities.OnSnappedElementLoadChanged);
				if (true.Equals(e.NewValue))
				{
					if (frameworkElement.IsLoaded)
					{
						frameworkElement.Unloaded += value;
						global::Infragistics.Windows.Utilities.SnapInfo.Add(frameworkElement);
						return;
					}
					frameworkElement.Loaded += value;
					return;
				}
				else
				{
					frameworkElement.Loaded -= value;
					frameworkElement.Unloaded -= value;
					global::Infragistics.Windows.Utilities.SnapInfo.Remove(frameworkElement);
				}
			}
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00063C28 File Offset: 0x00061E28
		private static object OnSyncSnapElementActual(object param)
		{
			global::System.Windows.DependencyObject dependencyObject = param as global::System.Windows.DependencyObject;
			dependencyObject.SetValue(global::Infragistics.Windows.Utilities.SnapElementToDevicePixelsActualProperty, dependencyObject.GetValue(global::Infragistics.Windows.Utilities.SnapElementToDevicePixelsProperty));
			return null;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00063C54 File Offset: 0x00061E54
		private static void OnSnappedElementLoadChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			bool flag = e.RoutedEvent == global::System.Windows.FrameworkElement.LoadedEvent;
			global::System.Windows.FrameworkElement frameworkElement = sender as global::System.Windows.FrameworkElement;
			global::System.Windows.RoutedEventHandler value = new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.Utilities.OnSnappedElementLoadChanged);
			if (flag)
			{
				frameworkElement.Loaded -= value;
				frameworkElement.Unloaded += value;
				global::Infragistics.Windows.Utilities.SnapInfo.Add(frameworkElement);
				return;
			}
			frameworkElement.Unloaded -= value;
			frameworkElement.Loaded += value;
			global::Infragistics.Windows.Utilities.SnapInfo.Remove(frameworkElement);
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00063CB0 File Offset: 0x00061EB0
		public static global::System.Windows.MessageBoxResult ShowMessageBox(global::System.Windows.DependencyObject element, string messageBoxText, string caption, global::System.Windows.MessageBoxButton button, global::System.Windows.MessageBoxImage icon)
		{
			global::System.Windows.Window window = (element != null) ? global::System.Windows.Window.GetWindow(element) : null;
			if (window == null)
			{
				return global::System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);
			}
			return global::System.Windows.MessageBox.Show(window, messageBoxText, caption, button, icon);
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00063CE4 File Offset: 0x00061EE4
		public static int GetLineCount(string text)
		{
			int result = 0;
			if (!string.IsNullOrEmpty(text))
			{
				string[] array = text.Split(new string[]
				{
					"\r\n",
					"\r",
					"\n"
				}, global::System.StringSplitOptions.None);
				result = array.Length;
			}
			return result;
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00063D28 File Offset: 0x00061F28
		internal static bool IsBrowserWindow(global::System.Windows.Window window)
		{
			return global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted && window is global::System.Windows.Navigation.NavigationWindow && window.GetType().Name == "RootBrowserWindow";
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00063D54 File Offset: 0x00061F54
		internal static bool IsContainedBy(global::System.Windows.Rect containerRect, global::System.Windows.Rect rectToTest, bool checkWidth)
		{
			if (checkWidth)
			{
				return containerRect.Left <= rectToTest.Left && containerRect.Right >= rectToTest.Right;
			}
			return containerRect.Top <= rectToTest.Top && containerRect.Bottom >= rectToTest.Bottom;
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00063DB0 File Offset: 0x00061FB0
		public static void ValidateTargetTypeOfStyle(global::System.Windows.Style style, global::System.Type targetType, string propertyName)
		{
			if (style == null)
			{
				throw new global::System.ArgumentNullException("style");
			}
			if (targetType == null)
			{
				throw new global::System.ArgumentNullException("targetType");
			}
			if (propertyName == null)
			{
				throw new global::System.ArgumentNullException("propertyName");
			}
			global::System.Type targetType2 = style.TargetType;
			if (targetType2 == null || targetType2 == targetType || targetType2.IsAssignableFrom(targetType) || targetType.IsAssignableFrom(targetType2))
			{
				return;
			}
			throw new global::System.ArgumentException(global::SR.GetString("LE_TargetTypeInvalid", new object[]
			{
				propertyName,
				targetType.Name,
				targetType2.Name
			}), propertyName);
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00063E48 File Offset: 0x00062048
		internal static global::System.Windows.Media.Matrix GetDeviceMatrix(bool toDevice, global::System.Windows.Media.Visual relativeVisual)
		{
			if (global::Infragistics.Windows.Utilities._canGetHwndSource && relativeVisual != null)
			{
				try
				{
					return global::Infragistics.Windows.Utilities.GetDeviceMatrixImpl(toDevice, relativeVisual);
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Utilities._canGetHwndSource = false;
				}
			}
			return global::Infragistics.Windows.Utilities.GetDeviceMatrixImpl(toDevice);
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00063E8C File Offset: 0x0006208C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.Windows.Media.Matrix GetDeviceMatrixImpl(bool toDevice, global::System.Windows.Media.Visual relativeElement)
		{
			global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.PresentationSource.FromVisual(relativeElement) as global::System.Windows.Interop.HwndSource;
			if (hwndSource == null)
			{
				return global::Infragistics.Windows.Utilities.GetDeviceMatrixImpl(toDevice);
			}
			if (toDevice)
			{
				return hwndSource.CompositionTarget.TransformToDevice;
			}
			return hwndSource.CompositionTarget.TransformFromDevice;
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x00063ECC File Offset: 0x000620CC
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.Windows.Media.Matrix GetDeviceMatrixImpl(bool toDevice)
		{
			global::System.Windows.Size primaryMonitorSize = global::Infragistics.Windows.Helpers.NativeWindowMethods.PrimaryMonitorSize;
			double primaryScreenWidth = global::System.Windows.SystemParameters.PrimaryScreenWidth;
			double primaryScreenHeight = global::System.Windows.SystemParameters.PrimaryScreenHeight;
			if (toDevice)
			{
				return new global::System.Windows.Media.Matrix(primaryMonitorSize.Width / primaryScreenWidth, 0.0, 0.0, primaryMonitorSize.Height / primaryScreenHeight, 0.0, 0.0);
			}
			return new global::System.Windows.Media.Matrix(primaryScreenWidth / primaryMonitorSize.Width, 0.0, 0.0, primaryScreenHeight / primaryMonitorSize.Height, 0.0, 0.0);
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00063F68 File Offset: 0x00062168
		internal static void RandomizeList<T>(global::System.Collections.Generic.IList<T> list)
		{
			int count = list.Count;
			if (count < 2)
			{
				return;
			}
			global::System.Random rnd = global::Infragistics.Windows.Utilities.Rnd;
			for (int i = count - 1; i >= 0; i--)
			{
				int index = rnd.Next(0, i);
				T value = list[i];
				list[i] = list[index];
				list[index] = value;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x00063FBE File Offset: 0x000621BE
		public static int SystemDoubleClickTime
		{
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.DoubleClickTime;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x00063FC5 File Offset: 0x000621C5
		public static global::System.Windows.Size SystemDoubleClickSize
		{
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.DoubleClickSize;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x00063FCC File Offset: 0x000621CC
		public static global::System.Windows.Size SystemDragSize
		{
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.DragSize;
			}
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00063FD4 File Offset: 0x000621D4
		internal static global::Infragistics.Windows.Licensing.UltraLicense ValidateLicense(global::System.Type type, object instance)
		{
			global::Infragistics.Windows.Licensing.UltraLicense result;
			try
			{
				result = (global::System.ComponentModel.LicenseManager.Validate(type, instance) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00064008 File Offset: 0x00062208
		internal static T[] Combine<T>(params global::System.Collections.Generic.IEnumerable<T>[] lists)
		{
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			if (lists != null)
			{
				foreach (global::System.Collections.Generic.IList<T> list2 in lists)
				{
					if (list2 != null)
					{
						list.AddRange(list2);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00064048 File Offset: 0x00062248
		public static global::System.Globalization.CultureInfo GetLanguageCultureInfo(global::System.Windows.FrameworkElement element)
		{
			global::System.Windows.Markup.XmlLanguage nonDefaultLanguage = global::Infragistics.Windows.Utilities.GetNonDefaultLanguage(element);
			if (nonDefaultLanguage != null)
			{
				global::System.Globalization.CultureInfo cultureInfo = null;
				bool flag = false;
				if (global::Infragistics.Windows.Utilities.g_LanguageCultureMap == null)
				{
					global::Infragistics.Windows.Utilities.g_LanguageCultureMap = new global::System.Collections.Generic.Dictionary<global::System.Windows.Markup.XmlLanguage, global::System.Globalization.CultureInfo>();
				}
				else if (global::Infragistics.Windows.Utilities.g_LanguageCultureMap.TryGetValue(nonDefaultLanguage, out cultureInfo))
				{
					flag = true;
				}
				if (!flag)
				{
					cultureInfo = global::Infragistics.Windows.Utilities.GetNonNeutralCulture(element);
					global::Infragistics.Windows.Utilities.g_LanguageCultureMap.Add(nonDefaultLanguage, cultureInfo);
				}
				if (cultureInfo != null)
				{
					return cultureInfo;
				}
			}
			global::System.Globalization.CultureInfo cultureInfo2 = global::System.Globalization.CultureInfo.CurrentCulture;
			if (cultureInfo2 == null)
			{
				cultureInfo2 = global::System.Globalization.CultureInfo.InvariantCulture;
			}
			return global::Infragistics.Windows.Utilities.GetNonNeutralCulture(cultureInfo2);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x000640D8 File Offset: 0x000622D8
		internal static void SetFocusedElement(global::System.Windows.DependencyObject focusScope, global::System.Windows.IInputElement focusedElement)
		{
			global::System.Windows.Input.KeyboardFocusChangedEventHandler handler = delegate(object s, global::System.Windows.Input.KeyboardFocusChangedEventArgs se)
			{
				if (se.NewFocus == focusedElement)
				{
					se.Handled = true;
				}
			};
			global::System.Windows.Input.Keyboard.AddPreviewGotKeyboardFocusHandler(focusScope, handler);
			global::System.Windows.Input.Keyboard.AddPreviewLostKeyboardFocusHandler(focusScope, handler);
			try
			{
				global::System.Windows.Input.FocusManager.SetFocusedElement(focusScope, focusedElement);
			}
			finally
			{
				global::System.Windows.Input.Keyboard.RemovePreviewGotKeyboardFocusHandler(focusScope, handler);
				global::System.Windows.Input.Keyboard.RemovePreviewLostKeyboardFocusHandler(focusScope, handler);
			}
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0006413C File Offset: 0x0006233C
		internal static bool IsUIElementOrUIElement3D(global::System.Windows.DependencyObject d)
		{
			return d is global::System.Windows.UIElement || (d != null && null != global::Infragistics.Windows.Utilities.UIElement3DType && global::Infragistics.Windows.Utilities.UIElement3DType.IsAssignableFrom(d.GetType()));
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00064170 File Offset: 0x00062370
		internal static global::System.Windows.Rect Intersect(global::System.Windows.Rect rect1, global::System.Windows.Rect rect2)
		{
			global::System.Windows.Rect result = global::System.Windows.Rect.Intersect(rect1, rect2);
			if (result.IsEmpty)
			{
				return global::System.Windows.Rect.Empty;
			}
			if (result.Y == rect1.Bottom || result.Y == rect2.Bottom)
			{
				return global::System.Windows.Rect.Empty;
			}
			if (result.X == rect1.Right || result.X == rect2.Right)
			{
				return global::System.Windows.Rect.Empty;
			}
			return result;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x000641E4 File Offset: 0x000623E4
		internal static global::System.Windows.Point? CalculateOnScreenLocation(global::System.Windows.Rect logicalScreenRect, global::System.Windows.Media.Visual relativeElement, bool fullyInView)
		{
			global::System.Windows.Rect rect = global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(logicalScreenRect, relativeElement);
			global::System.Windows.Rect rect2;
			if (global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				rect2 = global::Infragistics.Windows.Utilities.GetWorkArea(relativeElement);
			}
			else
			{
				rect2 = global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWorkArea(rect), relativeElement);
			}
			global::System.Windows.Rect rect3 = global::Infragistics.Windows.Utilities.Intersect(rect2, logicalScreenRect);
			if (fullyInView && rect3 == logicalScreenRect)
			{
				return null;
			}
			if (!fullyInView && !rect3.IsEmpty)
			{
				return null;
			}
			global::System.Windows.Rect rect4;
			if (global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				rect4 = rect2;
			}
			else
			{
				rect4 = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWorkArea(logicalScreenRect.TopLeft);
				rect4.Union(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWorkArea(logicalScreenRect.TopRight));
				rect4.Union(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWorkArea(logicalScreenRect.BottomLeft));
				rect4.Union(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWorkArea(logicalScreenRect.BottomRight));
				if (!fullyInView && !global::Infragistics.Windows.Utilities.Intersect(rect, rect4).IsEmpty)
				{
					return null;
				}
				rect4 = global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(rect4, relativeElement);
			}
			global::System.Windows.Point location = logicalScreenRect.Location;
			if (logicalScreenRect.Right < rect2.Left || (fullyInView && logicalScreenRect.Width < rect2.Width && logicalScreenRect.Left < rect2.Left))
			{
				location.X = rect2.Left;
			}
			else if (logicalScreenRect.Left >= rect2.Right || (fullyInView && logicalScreenRect.Width < rect2.Width && logicalScreenRect.Right > rect2.Right))
			{
				location.X = rect2.Right - 1.0 - logicalScreenRect.Width;
			}
			else if (fullyInView && rect3.Width != logicalScreenRect.Width)
			{
				if (logicalScreenRect.Left < rect4.Left)
				{
					location.X = rect4.Left;
				}
				else if (logicalScreenRect.Right > rect4.Right)
				{
					location.X = rect4.Right - 1.0 - logicalScreenRect.Width;
				}
			}
			if (logicalScreenRect.Bottom < rect2.Top || (fullyInView && logicalScreenRect.Height < rect2.Height && logicalScreenRect.Top < rect2.Top))
			{
				location.Y = rect2.Top;
			}
			else if (logicalScreenRect.Top >= rect2.Bottom || (fullyInView && logicalScreenRect.Height < rect2.Height && logicalScreenRect.Bottom > rect2.Bottom))
			{
				location.Y = rect2.Bottom - 1.0 - logicalScreenRect.Height;
			}
			else if (fullyInView && rect3.Height != logicalScreenRect.Height)
			{
				if (logicalScreenRect.Top < rect4.Top)
				{
					location.Y = rect4.Top;
				}
				else if (logicalScreenRect.Bottom > rect4.Bottom)
				{
					location.Y = rect4.Bottom - 1.0 - logicalScreenRect.Height;
				}
			}
			return new global::System.Windows.Point?(location);
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x000644D1 File Offset: 0x000626D1
		public static void EnableModelessKeyboardInterop()
		{
			global::Infragistics.Windows.Utilities._modelessKeyboardInteropEnabled = true;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x000644DC File Offset: 0x000626DC
		internal static void EnableModelessKeyboardInteropForWindow(global::System.Windows.Window window)
		{
			if (!global::Infragistics.Windows.Utilities._modelessKeyboardInteropEnabled)
			{
				return;
			}
			try
			{
				global::Infragistics.Windows.Utilities.EnableModelessKeyboardInteropForWindowHelper(window);
			}
			catch
			{
			}
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0006450C File Offset: 0x0006270C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void EnableModelessKeyboardInteropForWindowHelper(global::System.Windows.Window window)
		{
			string fullName = typeof(global::System.Windows.DependencyObject).Assembly.FullName;
			int startIndex = fullName.IndexOf("Version=");
			string b = "WindowsFormsIntegration, " + fullName.Substring(startIndex);
			global::System.Reflection.Assembly[] assemblies = global::System.AppDomain.CurrentDomain.GetAssemblies();
			global::System.Reflection.Assembly[] array = assemblies;
			int i = 0;
			while (i < array.Length)
			{
				global::System.Reflection.Assembly assembly = array[i];
				if (assembly.FullName == b)
				{
					global::System.Type type = assembly.GetType("System.Windows.Forms.Integration.ElementHost");
					if (!(null != type))
					{
						break;
					}
					global::System.Reflection.MethodInfo method = type.GetMethod("EnableModelessKeyboardInterop");
					if (null != method)
					{
						method.Invoke(null, new object[]
						{
							window
						});
						return;
					}
					break;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x04000C30 RID: 3120
		private const double SMALLEST_DOUBLE = 2.220446049250313E-13;

		// Token: 0x04000C31 RID: 3121
		private const string publicKeyTokenLiteral = "PublicKeyToken";

		// Token: 0x04000C32 RID: 3122
		[global::System.ThreadStatic]
		private static global::System.Random _rnd;

		// Token: 0x04000C33 RID: 3123
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::System.Windows.Markup.XmlLanguage, global::System.Globalization.CultureInfo> g_LanguageCultureMap;

		// Token: 0x04000C34 RID: 3124
		private static readonly global::System.Type UIElement3DType;

		// Token: 0x04000C35 RID: 3125
		[global::System.ThreadStatic]
		private static bool _modelessKeyboardInteropEnabled;

		// Token: 0x04000C36 RID: 3126
		public static readonly global::System.Windows.DependencyProperty SnapElementToDevicePixelsProperty = global::System.Windows.DependencyProperty.RegisterAttached("SnapElementToDevicePixels", typeof(bool), typeof(global::Infragistics.Windows.Utilities), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Utilities.OnSnapElementToDevicePixelsChanged)));

		// Token: 0x04000C37 RID: 3127
		private static readonly global::System.Windows.DependencyProperty SnapElementToDevicePixelsActualProperty = global::System.Windows.DependencyProperty.RegisterAttached("SnapElementToDevicePixelsActual", typeof(bool), typeof(global::Infragistics.Windows.Utilities), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Utilities.OnSnapElementToDevicePixelsChanged)));

		// Token: 0x04000C38 RID: 3128
		private static bool _canGetHwndSource = true;

		// Token: 0x02000285 RID: 645
		// (Invoke) Token: 0x060019F8 RID: 6648
		public delegate bool DependencyObjectSearchCallback<T>(T dependencyObject) where T : global::System.Windows.DependencyObject;

		// Token: 0x02000286 RID: 646
		private class SnapInfo
		{
			// Token: 0x060019FB RID: 6651 RVA: 0x000645CC File Offset: 0x000627CC
			private SnapInfo(global::System.Windows.FrameworkElement rootLoadedElement)
			{
				if (rootLoadedElement == null)
				{
					throw new global::System.ArgumentNullException();
				}
				this._rootLoadElement = rootLoadedElement;
			}

			// Token: 0x060019FC RID: 6652 RVA: 0x000645EF File Offset: 0x000627EF
			private static global::Infragistics.Windows.Utilities.SnapInfo GetInfo(global::System.Windows.DependencyObject d)
			{
				return (global::Infragistics.Windows.Utilities.SnapInfo)d.GetValue(global::Infragistics.Windows.Utilities.SnapInfo.InfoProperty);
			}

			// Token: 0x060019FD RID: 6653 RVA: 0x00064601 File Offset: 0x00062801
			private static void SetInfo(global::System.Windows.DependencyObject d, global::Infragistics.Windows.Utilities.SnapInfo value)
			{
				d.SetValue(global::Infragistics.Windows.Utilities.SnapInfo.InfoPropertyKey, value);
			}

			// Token: 0x060019FE RID: 6654 RVA: 0x0006460F File Offset: 0x0006280F
			private static global::System.Windows.FrameworkElement GetOwner(global::System.Windows.DependencyObject d)
			{
				return (global::System.Windows.FrameworkElement)d.GetValue(global::Infragistics.Windows.Utilities.SnapInfo.OwnerProperty);
			}

			// Token: 0x060019FF RID: 6655 RVA: 0x00064621 File Offset: 0x00062821
			private static void SetOwner(global::System.Windows.DependencyObject d, global::System.Windows.FrameworkElement value)
			{
				d.SetValue(global::Infragistics.Windows.Utilities.SnapInfo.OwnerPropertyKey, value);
			}

			// Token: 0x06001A00 RID: 6656 RVA: 0x00064630 File Offset: 0x00062830
			private void AddDescendant(global::System.Windows.FrameworkElement snapToElement)
			{
				this.VerifyCompacted();
				this._loadedElements.Add(snapToElement);
				if (this._loadedElements.Count == 1)
				{
					global::System.Windows.DependencyObject dependencyObject;
					global::System.Windows.DependencyObject rootVisual = global::Infragistics.Windows.Utilities.SnapInfo.GetRootVisual(this._rootLoadElement, out dependencyObject);
					if (rootVisual != null)
					{
						this._rootVisual = new global::System.WeakReference(rootVisual);
						this._rootLoadElement.LayoutUpdated += this.OnRootLayoutUpdated;
					}
					else
					{
						this._rootVisual = null;
					}
				}
				snapToElement.RenderTransform = null;
			}

			// Token: 0x06001A01 RID: 6657 RVA: 0x000646A2 File Offset: 0x000628A2
			private void CompactList(object param)
			{
				this.VerifyCompacted();
			}

			// Token: 0x06001A02 RID: 6658 RVA: 0x000646AA File Offset: 0x000628AA
			private void GetDeviceMatrixes(global::System.Windows.Media.Visual rootVisual, out global::System.Windows.Media.Matrix toDeviceMatrix, out global::System.Windows.Media.Matrix fromDeviceMatrix)
			{
				toDeviceMatrix = global::Infragistics.Windows.Utilities.GetDeviceMatrix(true, rootVisual);
				fromDeviceMatrix = global::Infragistics.Windows.Utilities.GetDeviceMatrix(false, rootVisual);
			}

			// Token: 0x06001A03 RID: 6659 RVA: 0x000646C8 File Offset: 0x000628C8
			private static global::System.Windows.DependencyObject GetRootVisual(global::System.Windows.DependencyObject descendant, out global::System.Windows.DependencyObject ancestorForLoaded)
			{
				global::System.Windows.DependencyObject dependencyObject = descendant;
				ancestorForLoaded = null;
				while (descendant != null)
				{
					if (descendant is global::System.Windows.Controls.Page || descendant is global::System.Windows.Controls.Frame)
					{
						ancestorForLoaded = descendant;
					}
					dependencyObject = descendant;
					descendant = global::System.Windows.Media.VisualTreeHelper.GetParent(descendant);
				}
				if (ancestorForLoaded == null)
				{
					ancestorForLoaded = dependencyObject;
				}
				return dependencyObject;
			}

			// Token: 0x06001A04 RID: 6660 RVA: 0x00064704 File Offset: 0x00062904
			private void OnRootLayoutUpdated(object sender, global::System.EventArgs e)
			{
				if (this._rootVisual != null)
				{
					global::System.Windows.Media.Visual visual = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._rootVisual) as global::System.Windows.Media.Visual;
					if (visual != null)
					{
						this.VerifyCompacted();
						global::System.Windows.Media.Matrix matrix;
						global::System.Windows.Media.Matrix matrix2;
						this.GetDeviceMatrixes(visual, out matrix, out matrix2);
						int i = 0;
						int count = this._loadedElements.Count;
						while (i < count)
						{
							global::System.Windows.FrameworkElement frameworkElement = this._loadedElements[i];
							if (frameworkElement != null && visual.IsAncestorOf(frameworkElement))
							{
								global::System.Windows.Point point = default(global::System.Windows.Point);
								try
								{
									global::System.Windows.Media.GeneralTransform generalTransform = frameworkElement.TransformToAncestor(visual);
									if (generalTransform == null)
									{
										goto IL_274;
									}
									point = generalTransform.Transform(default(global::System.Windows.Point));
								}
								catch (global::System.InvalidOperationException)
								{
									goto IL_274;
								}
								point = matrix.Transform(point);
								double num = global::System.Math.Round(point.X) - point.X;
								double num2 = global::System.Math.Round(point.Y) - point.Y;
								bool flag = !global::Infragistics.CoreUtilities.AreClose(num, 0.0);
								bool flag2 = !global::Infragistics.CoreUtilities.AreClose(num2, 0.0);
								if (flag || flag2)
								{
									global::System.Windows.Media.TranslateTransform translateTransform = frameworkElement.RenderTransform as global::System.Windows.Media.TranslateTransform;
									global::System.Windows.Media.Transform transform = global::System.Windows.Media.VisualTreeHelper.GetTransform(frameworkElement);
									if (translateTransform != null && transform != null)
									{
										try
										{
											point = default(global::System.Windows.Point);
											point = transform.Inverse.Transform(point);
											global::System.Windows.Media.GeneralTransform generalTransform2 = frameworkElement.TransformToAncestor(visual);
											if (generalTransform2 == null)
											{
												goto IL_274;
											}
											point = generalTransform2.Transform(point);
										}
										catch (global::System.InvalidOperationException)
										{
											goto IL_274;
										}
										point = matrix.Transform(point);
									}
									point.X = global::System.Math.Round(point.X);
									point.Y = global::System.Math.Round(point.Y);
									point = matrix2.Transform(point);
									global::System.Windows.Media.GeneralTransform generalTransform3 = visual.TransformToDescendant(frameworkElement);
									if (generalTransform3 != null)
									{
										point = generalTransform3.Transform(point);
										if (translateTransform != null && transform != null)
										{
											point = transform.Transform(point);
										}
										num = point.X;
										num2 = point.Y;
										if (translateTransform != null)
										{
											flag = !global::Infragistics.CoreUtilities.AreClose(num, translateTransform.X);
											flag2 = !global::Infragistics.CoreUtilities.AreClose(num2, translateTransform.Y);
										}
										if (num != 0.0 || num2 != 0.0)
										{
											if (translateTransform == null || translateTransform.IsSealed)
											{
												translateTransform = new global::System.Windows.Media.TranslateTransform(num, num2);
												frameworkElement.RenderTransform = translateTransform;
											}
											else
											{
												if (flag)
												{
													translateTransform.X = num;
												}
												if (flag2)
												{
													translateTransform.Y = num2;
												}
											}
										}
										else if (translateTransform != null)
										{
											frameworkElement.RenderTransform = null;
										}
									}
								}
							}
							IL_274:
							i++;
						}
					}
				}
			}

			// Token: 0x06001A05 RID: 6661 RVA: 0x000649B0 File Offset: 0x00062BB0
			private void RemoveDescendant(global::System.Windows.FrameworkElement snapToElement)
			{
				int num = this._loadedElements.IndexOf(snapToElement);
				if (num >= 0)
				{
					this._loadedElements[num] = null;
				}
				this._compactPending = true;
				this._rootLoadElement.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::System.Threading.SendOrPostCallback(this.CompactList), this._loadedElements);
				snapToElement.ClearValue(global::System.Windows.UIElement.RenderTransformProperty);
			}

			// Token: 0x06001A06 RID: 6662 RVA: 0x00064A14 File Offset: 0x00062C14
			private void VerifyCompacted()
			{
				if (this._compactPending)
				{
					this._compactPending = false;
					int count = this._loadedElements.Count;
					this._loadedElements.Compact();
					if (count > 0 && this._loadedElements.Count == 0)
					{
						this._rootLoadElement.LayoutUpdated -= this.OnRootLayoutUpdated;
					}
				}
			}

			// Token: 0x06001A07 RID: 6663 RVA: 0x00064A70 File Offset: 0x00062C70
			internal static void Add(global::System.Windows.FrameworkElement fe)
			{
				global::System.Windows.DependencyObject dependencyObject;
				global::Infragistics.Windows.Utilities.SnapInfo.GetRootVisual(fe, out dependencyObject);
				global::System.Windows.FrameworkElement frameworkElement = dependencyObject as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					global::Infragistics.Windows.Utilities.SnapInfo snapInfo = global::Infragistics.Windows.Utilities.SnapInfo.GetInfo(dependencyObject);
					if (snapInfo == null)
					{
						snapInfo = new global::Infragistics.Windows.Utilities.SnapInfo(frameworkElement);
						global::Infragistics.Windows.Utilities.SnapInfo.SetInfo(dependencyObject, snapInfo);
					}
					snapInfo.AddDescendant(fe);
					global::Infragistics.Windows.Utilities.SnapInfo.SetOwner(fe, frameworkElement);
				}
			}

			// Token: 0x06001A08 RID: 6664 RVA: 0x00064AB8 File Offset: 0x00062CB8
			internal static void Remove(global::System.Windows.FrameworkElement fe)
			{
				global::System.Windows.FrameworkElement owner = global::Infragistics.Windows.Utilities.SnapInfo.GetOwner(fe);
				if (owner != null)
				{
					global::Infragistics.Windows.Utilities.SnapInfo info = global::Infragistics.Windows.Utilities.SnapInfo.GetInfo(owner);
					fe.ClearValue(global::Infragistics.Windows.Utilities.SnapInfo.OwnerPropertyKey);
					info.RemoveDescendant(fe);
				}
			}

			// Token: 0x04000C39 RID: 3129
			private global::System.WeakReference _rootVisual;

			// Token: 0x04000C3A RID: 3130
			private global::System.Windows.FrameworkElement _rootLoadElement;

			// Token: 0x04000C3B RID: 3131
			private global::Infragistics.Collections.WeakList<global::System.Windows.FrameworkElement> _loadedElements = new global::Infragistics.Collections.WeakList<global::System.Windows.FrameworkElement>();

			// Token: 0x04000C3C RID: 3132
			private bool _compactPending;

			// Token: 0x04000C3D RID: 3133
			private static readonly global::System.Windows.DependencyPropertyKey InfoPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("Info", typeof(global::Infragistics.Windows.Utilities.SnapInfo), typeof(global::Infragistics.Windows.Utilities.SnapInfo), new global::System.Windows.FrameworkPropertyMetadata(null));

			// Token: 0x04000C3E RID: 3134
			internal static readonly global::System.Windows.DependencyProperty InfoProperty = global::Infragistics.Windows.Utilities.SnapInfo.InfoPropertyKey.DependencyProperty;

			// Token: 0x04000C3F RID: 3135
			private static readonly global::System.Windows.DependencyPropertyKey OwnerPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("Owner", typeof(global::System.Windows.FrameworkElement), typeof(global::Infragistics.Windows.Utilities.SnapInfo), new global::System.Windows.FrameworkPropertyMetadata(null));

			// Token: 0x04000C40 RID: 3136
			internal static readonly global::System.Windows.DependencyProperty OwnerProperty = global::Infragistics.Windows.Utilities.SnapInfo.OwnerPropertyKey.DependencyProperty;
		}

		// Token: 0x02000287 RID: 647
		internal interface IMeetsCriteria
		{
			// Token: 0x06001A0A RID: 6666
			bool MeetsCriteria(object item);
		}

		// Token: 0x02000288 RID: 648
		// (Invoke) Token: 0x06001A0C RID: 6668
		internal delegate void MethodDelegate();
	}
}
