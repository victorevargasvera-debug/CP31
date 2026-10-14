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
using Infragistics.Shared;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Reporting;

namespace Infragistics.Windows
{
	// Token: 0x020002C1 RID: 705
	public class Utilities : global::Infragistics.CoreUtilities
	{
		// Token: 0x06001BA6 RID: 7078 RVA: 0x000688B4 File Offset: 0x00066AB4
		static Utilities()
		{
			global::Infragistics.Windows.Utilities.UIElement3DType = global::System.Type.GetType("System.Windows.UIElement3D, " + typeof(global::System.Windows.UIElement).Assembly.FullName, false);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00068964 File Offset: 0x00066B64
		protected Utilities()
		{
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x0006896C File Offset: 0x00066B6C
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

		// Token: 0x06001BA9 RID: 7081 RVA: 0x00068984 File Offset: 0x00066B84
		public static bool AllowsAsyncOperations(global::System.Windows.DependencyObject d)
		{
			return !global::Infragistics.Windows.Reporting.ReportSection.GetIsInReport(d);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00068990 File Offset: 0x00066B90
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

		// Token: 0x06001BAB RID: 7083 RVA: 0x00068A80 File Offset: 0x00066C80
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

		// Token: 0x06001BAC RID: 7084 RVA: 0x00068AE0 File Offset: 0x00066CE0
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

		// Token: 0x06001BAD RID: 7085 RVA: 0x00068CAA File Offset: 0x00066EAA
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static int ConvertFromLogicalPixels(double logicalPixelValue)
		{
			return global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(logicalPixelValue, null);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00068CB4 File Offset: 0x00066EB4
		public static int ConvertFromLogicalPixels(double logicalPixelValue, global::System.Windows.Media.Visual relativeVisual)
		{
			return (int)(global::Infragistics.Windows.Utilities.GetDeviceMatrix(true, relativeVisual).M22 * logicalPixelValue);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00068CD3 File Offset: 0x00066ED3
		internal static global::System.Windows.Rect ConvertFromLogicalPixels(global::System.Windows.Rect deviceRect, global::System.Windows.Media.Visual relativeElement)
		{
			return new global::System.Windows.Rect((double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(deviceRect.X, relativeElement), (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(deviceRect.Y, relativeElement), (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(deviceRect.Width, relativeElement), (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(deviceRect.Height, relativeElement));
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00068D12 File Offset: 0x00066F12
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static double ConvertToLogicalPixels(int pixelValue)
		{
			return global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(pixelValue, null);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00068D1C File Offset: 0x00066F1C
		public static double ConvertToLogicalPixels(int pixelValue, global::System.Windows.Media.Visual relativeVisual)
		{
			return global::Infragistics.Windows.Utilities.GetDeviceMatrix(false, relativeVisual).M11 * (double)pixelValue;
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00068D3C File Offset: 0x00066F3C
		internal static global::System.Windows.Point ConvertToLogicalPixels(int pixelX, int pixelY, global::System.Windows.Media.Visual relativeElement)
		{
			return global::Infragistics.Windows.Utilities.GetDeviceMatrix(false, relativeElement).Transform(new global::System.Windows.Point((double)pixelX, (double)pixelY));
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00068D61 File Offset: 0x00066F61
		internal static global::System.Windows.Rect ConvertToLogicalPixels(global::System.Windows.Rect deviceRect, global::System.Windows.Media.Visual relativeElement)
		{
			return new global::System.Windows.Rect(global::Infragistics.Windows.Utilities.ConvertToLogicalPixels((int)deviceRect.Left, (int)deviceRect.Top, relativeElement), global::Infragistics.Windows.Utilities.ConvertToLogicalPixels((int)deviceRect.Right, (int)deviceRect.Bottom, relativeElement));
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00068D94 File Offset: 0x00066F94
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

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00068E88 File Offset: 0x00067088
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

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00068FC4 File Offset: 0x000671C4
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

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0006909E File Offset: 0x0006729E
		public static global::System.Windows.Media.Geometry CreateRoundedRectGeometry(global::System.Windows.Rect rect, global::Infragistics.Windows.Controls.RoundedRectCorners roundedCorners, double radiusX, double radiusY, double edgeThickness)
		{
			return global::Infragistics.Windows.Utilities.CreateRoundedRectGeometry(rect, roundedCorners, radiusX, radiusY, edgeThickness, global::Infragistics.Windows.Controls.RoundedRectSide.Left, global::Infragistics.Windows.Controls.RoundedRectSide.Left);
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x000690B0 File Offset: 0x000672B0
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

		// Token: 0x06001BB9 RID: 7097 RVA: 0x000694DC File Offset: 0x000676DC
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

		// Token: 0x06001BBA RID: 7098 RVA: 0x000695F8 File Offset: 0x000677F8
		internal static bool DoesElementContainPoint(global::System.Windows.FrameworkElement elem, global::System.Windows.Point p)
		{
			return p.X >= 0.0 && p.Y >= 0.0 && p.X < elem.ActualWidth && p.Y < elem.ActualHeight;
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0006964C File Offset: 0x0006784C
		internal static global::System.Windows.Point EnsureInElementBounds(global::System.Windows.Point point, global::System.Windows.FrameworkElement elem)
		{
			point.X = global::Infragistics.Windows.Utilities.EnsureInRange(point.X, 0.0, elem.ActualWidth);
			point.Y = global::Infragistics.Windows.Utilities.EnsureInRange(point.Y, 0.0, elem.ActualHeight);
			return point;
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0006969E File Offset: 0x0006789E
		internal static double EnsureInRange(double val, double min, double max)
		{
			return global::System.Math.Min(global::System.Math.Max(val, min), max);
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x000696AD File Offset: 0x000678AD
		public static bool DoubleIsZero(double value)
		{
			return global::System.Math.Abs(value) < 2.220446049250313E-13;
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000696C4 File Offset: 0x000678C4
		public static global::System.Windows.Data.Binding CreateBindingObjectLikeAlias(global::System.Windows.DependencyProperty dp)
		{
			return new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(dp),
				Mode = global::System.Windows.Data.BindingMode.OneWay,
				RelativeSource = global::System.Windows.Data.RelativeSource.TemplatedParent
			};
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000696F8 File Offset: 0x000678F8
		public static global::System.Windows.Data.Binding CreateBindingObject(global::System.Windows.DependencyProperty dp, global::System.Windows.Data.BindingMode bindingMode, global::System.Windows.Data.RelativeSource relativeSource)
		{
			return new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(dp),
				Mode = bindingMode,
				RelativeSource = relativeSource
			};
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00069728 File Offset: 0x00067928
		public static global::System.Windows.Data.Binding CreateBindingObject(global::System.Windows.DependencyProperty dp, global::System.Windows.Data.BindingMode bindingMode, object source)
		{
			return new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(dp),
				Mode = bindingMode,
				Source = source
			};
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00069758 File Offset: 0x00067958
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

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00069790 File Offset: 0x00067990
		public static global::System.Windows.Data.Binding CreateBindingObject(string path, global::System.Windows.Data.BindingMode bindingMode, object source)
		{
			return new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(path, new object[0]),
				Mode = bindingMode,
				Source = source
			};
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x000697C4 File Offset: 0x000679C4
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

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00069800 File Offset: 0x00067A00
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

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0006985C File Offset: 0x00067A5C
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

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0006990C File Offset: 0x00067B0C
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

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000699BC File Offset: 0x00067BBC
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

		// Token: 0x06001BC8 RID: 7112 RVA: 0x000699F2 File Offset: 0x00067BF2
		public static global::System.Windows.DependencyObject GetAncestorFromType(global::System.Windows.DependencyObject descendant, global::System.Type type, bool allowSubclassOfType)
		{
			return global::Infragistics.Windows.Utilities.GetAncestorFromType(descendant, type, allowSubclassOfType, null);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000699FD File Offset: 0x00067BFD
		public static global::System.Windows.DependencyObject GetAncestorFromType(global::System.Windows.DependencyObject descendant, global::System.Type type, bool allowSubclassOfType, global::System.Windows.DependencyObject stopAtVisual)
		{
			return global::Infragistics.Windows.Utilities.GetAncestorFromType(descendant, type, allowSubclassOfType, stopAtVisual, null);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00069A0C File Offset: 0x00067C0C
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

		// Token: 0x06001BCB RID: 7115 RVA: 0x00069A70 File Offset: 0x00067C70
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

		// Token: 0x06001BCC RID: 7116 RVA: 0x00069AA4 File Offset: 0x00067CA4
		internal static global::System.Windows.Markup.XmlLanguage GetNonDefaultLanguage(global::System.Windows.DependencyObject element)
		{
			global::System.Windows.Markup.XmlLanguage xmlLanguage = element.GetValue(global::System.Windows.FrameworkElement.LanguageProperty) as global::System.Windows.Markup.XmlLanguage;
			if (xmlLanguage != null && global::System.Windows.DependencyPropertyHelper.GetValueSource(element, global::System.Windows.FrameworkElement.LanguageProperty).BaseValueSource == global::System.Windows.BaseValueSource.Default && xmlLanguage.GetEquivalentCulture().IetfLanguageTag == "en-US")
			{
				return null;
			}
			return xmlLanguage;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00069AF8 File Offset: 0x00067CF8
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

		// Token: 0x06001BCE RID: 7118 RVA: 0x00069B84 File Offset: 0x00067D84
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

		// Token: 0x06001BCF RID: 7119 RVA: 0x00069C18 File Offset: 0x00067E18
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

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00069C6C File Offset: 0x00067E6C
		public static global::System.Windows.DependencyObject GetDescendantFromType(global::System.Windows.DependencyObject parent, global::System.Type type, bool allowSubclassOfType)
		{
			return global::Infragistics.Windows.Utilities.GetDescendantFromType<global::System.Windows.DependencyObject>(parent, type, allowSubclassOfType, null, null);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00069C78 File Offset: 0x00067E78
		public static T GetDescendantFromType<T>(global::System.Windows.DependencyObject parent, bool allowSubclassOfType, global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<T> callback) where T : global::System.Windows.DependencyObject
		{
			return global::Infragistics.Windows.Utilities.GetDescendantFromType<T>(parent, allowSubclassOfType, callback, null);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00069C83 File Offset: 0x00067E83
		public static T GetDescendantFromType<T>(global::System.Windows.DependencyObject parent, bool allowSubclassOfType, global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<T> callback, global::System.Type[] typesToIgnore) where T : global::System.Windows.DependencyObject
		{
			return global::Infragistics.Windows.Utilities.GetDescendantFromType<T>(parent, typeof(T), allowSubclassOfType, callback, typesToIgnore);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00069C98 File Offset: 0x00067E98
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

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00069D6C File Offset: 0x00067F6C
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

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00069DA0 File Offset: 0x00067FA0
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

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00069DEB File Offset: 0x00067FEB
		public static char GetFirstMnemonicChar(string text)
		{
			return global::Infragistics.Windows.Utilities.GetFirstMnemonicChar(text, global::System.Globalization.CultureInfo.CurrentUICulture);
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00069DF8 File Offset: 0x00067FF8
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

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00069E64 File Offset: 0x00068064
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

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00069EAD File Offset: 0x000680AD
		public static global::System.Windows.DependencyObject GetParent(global::System.Windows.DependencyObject child)
		{
			return global::Infragistics.Windows.Utilities.GetParent(child, true);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00069EB8 File Offset: 0x000680B8
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

		// Token: 0x06001BDB RID: 7131 RVA: 0x00069F28 File Offset: 0x00068128
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

		// Token: 0x06001BDC RID: 7132 RVA: 0x00069F6C File Offset: 0x0006816C
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

		// Token: 0x06001BDD RID: 7133 RVA: 0x0006A00C File Offset: 0x0006820C
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

		// Token: 0x06001BDE RID: 7134 RVA: 0x0006A03A File Offset: 0x0006823A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static string GetPublicKeyToken(global::System.Reflection.Assembly assemblyToCheck)
		{
			if (assemblyToCheck == null)
			{
				throw new global::System.ArgumentNullException("assemblyToCheck");
			}
			return global::Infragistics.Windows.Utilities.GetPublicKeyToken(assemblyToCheck.FullName);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0006A05C File Offset: 0x0006825C
		internal static string GetPublicKeyToken(string assemblyFullName)
		{
			string[] array = assemblyFullName.Split(new char[]
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

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0006A0F4 File Offset: 0x000682F4
		internal static global::System.Windows.Documents.AdornerLayer GetRootAdornerLayer(global::System.Windows.UIElement adornedElement, out global::System.Windows.UIElement elementToAdorn)
		{
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(adornedElement);
			if (adornerLayer != null)
			{
				bool isInDesignMode = global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(adornedElement);
				global::System.Windows.Documents.AdornerLayer adornerLayer2 = null;
				while (adornerLayer != null && adornerLayer != adornerLayer2)
				{
					adornerLayer2 = adornerLayer;
					global::System.Windows.Media.Visual visual = global::System.Windows.Media.VisualTreeHelper.GetParent(adornerLayer) as global::System.Windows.Media.Visual;
					if (visual == null)
					{
						break;
					}
					if (isInDesignMode)
					{
						global::System.Windows.Documents.AdornerDecorator adornerDecorator = visual as global::System.Windows.Documents.AdornerDecorator;
						if (adornerDecorator != null && adornerDecorator.Child != null && adornerDecorator.Child.GetType().FullName == "Microsoft.Expression.Platform.WPF.InstanceBuilders.WindowInstance")
						{
							break;
						}
					}
					adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(visual);
				}
				adornerLayer = adornerLayer2;
			}
			elementToAdorn = global::Infragistics.Windows.Utilities.GetElementToAdorn(adornerLayer, adornedElement);
			return adornerLayer;
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0006A176 File Offset: 0x00068376
		public static T GetTemplateChild<T>(global::System.Windows.FrameworkElement templatedParent) where T : global::System.Windows.DependencyObject
		{
			return global::Infragistics.Windows.Utilities.GetTemplateChild<T>(templatedParent, templatedParent, null);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0006A180 File Offset: 0x00068380
		public static T GetTemplateChild<T>(global::System.Windows.FrameworkElement templatedParent, global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<T> callback) where T : global::System.Windows.DependencyObject
		{
			return global::Infragistics.Windows.Utilities.GetTemplateChild<T>(templatedParent, templatedParent, callback);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0006A18C File Offset: 0x0006838C
		private static T GetTemplateChild<T>(global::System.Windows.FrameworkElement templatedParent, global::System.Windows.DependencyObject parent, global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<T> callback) where T : global::System.Windows.DependencyObject
		{
			global::Infragistics.Windows.Helpers.HashSet processedChildren = new global::Infragistics.Windows.Helpers.HashSet();
			return global::Infragistics.Windows.Utilities.GetTemplateChild<T>(templatedParent, parent, callback, processedChildren);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0006A1A8 File Offset: 0x000683A8
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

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0006A2A4 File Offset: 0x000684A4
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

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0006A324 File Offset: 0x00068524
		internal static global::System.Windows.DependencyObject GetTemplatedParent(global::System.Windows.DependencyObject reference)
		{
			global::System.Windows.DependencyObject result;
			global::Infragistics.Windows.Utilities.GetTemplatedParent(reference, out result);
			return result;
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0006A33C File Offset: 0x0006853C
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

		// Token: 0x06001BE8 RID: 7144 RVA: 0x0006A378 File Offset: 0x00068578
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

		// Token: 0x06001BE9 RID: 7145 RVA: 0x0006A3C8 File Offset: 0x000685C8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static bool HasSamePublicKey(global::System.Type type)
		{
			if (type == null)
			{
				return false;
			}
			string publicKeyToken = global::Infragistics.Windows.Utilities.GetPublicKeyToken(type);
			return global::Infragistics.Windows.Utilities.HasSamePublicKey(publicKeyToken);
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0006A3F0 File Offset: 0x000685F0
		internal static bool HasSamePublicKey(string publicKeyToken)
		{
			if (string.Equals("7dd5c3163f2cd0cb", publicKeyToken))
			{
				return true;
			}
			string publicKeyToken2 = global::Infragistics.Windows.Utilities.GetPublicKeyToken(typeof(global::Infragistics.Windows.Utilities));
			return publicKeyToken.Equals(publicKeyToken2);
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0006A424 File Offset: 0x00068624
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

		// Token: 0x06001BEC RID: 7148 RVA: 0x0006A450 File Offset: 0x00068650
		public static bool IsDescendantOf(global::System.Windows.DependencyObject ancestor, global::System.Windows.DependencyObject descendant)
		{
			return global::Infragistics.Windows.Utilities.IsDescendantOf(ancestor, descendant, false);
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0006A45A File Offset: 0x0006865A
		public static bool IsDescendantOf(global::System.Windows.DependencyObject ancestor, global::System.Windows.DependencyObject descendant, bool preferLogicalTree)
		{
			return global::Infragistics.Windows.Utilities.IsDescendantOf(ancestor, descendant, preferLogicalTree, false);
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0006A468 File Offset: 0x00068668
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

		// Token: 0x06001BEF RID: 7151 RVA: 0x0006A4D4 File Offset: 0x000686D4
		private static bool IsVisual(object reference)
		{
			return reference is global::System.Windows.Media.Visual || reference is global::System.Windows.Media.Media3D.Visual3D;
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0006A4EC File Offset: 0x000686EC
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

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0006A560 File Offset: 0x00068760
		internal static global::System.Windows.Input.Cursor LoadCursor(global::System.Uri uri)
		{
			global::System.Windows.Resources.StreamResourceInfo resourceStream = global::System.Windows.Application.GetResourceStream(uri);
			return new global::System.Windows.Input.Cursor(resourceStream.Stream);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0006A580 File Offset: 0x00068780
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

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0006A5F0 File Offset: 0x000687F0
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

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0006A668 File Offset: 0x00068868
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

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0006A748 File Offset: 0x00068948
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

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0006A790 File Offset: 0x00068990
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

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0006A878 File Offset: 0x00068A78
		public static global::System.Windows.Point TransformPointToAncestorCoordinates(global::System.Windows.Point pointToTransform, global::System.Windows.Media.Visual descendantVisual, global::System.Windows.Media.Visual ancestorVisual)
		{
			global::System.Windows.Media.MatrixTransform matrixTransform = descendantVisual.TransformToAncestor(ancestorVisual) as global::System.Windows.Media.MatrixTransform;
			return matrixTransform.Matrix.Transform(pointToTransform);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0006A8A4 File Offset: 0x00068AA4
		public static global::System.Windows.Point TransformPointToDescendantCoordinates(global::System.Windows.Point pointToTransform, global::System.Windows.Media.Visual descendantVisual, global::System.Windows.Media.Visual ancestorVisual)
		{
			global::System.Windows.Media.MatrixTransform matrixTransform = ancestorVisual.TransformToDescendant(descendantVisual) as global::System.Windows.Media.MatrixTransform;
			return matrixTransform.Matrix.Transform(pointToTransform);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0006A8D0 File Offset: 0x00068AD0
		public static object GetDefaultValue(global::System.Windows.DependencyProperty dependencyProperty, global::System.Windows.DependencyObject obj)
		{
			global::System.Windows.PropertyMetadata metadata = dependencyProperty.GetMetadata(obj);
			if (metadata == null)
			{
				return dependencyProperty.DefaultMetadata.DefaultValue;
			}
			return metadata.DefaultValue;
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0006A8FC File Offset: 0x00068AFC
		public static bool ShouldSerialize(global::System.Windows.DependencyProperty dependencyProperty, global::System.Windows.DependencyObject obj)
		{
			object defaultValue = global::Infragistics.Windows.Utilities.GetDefaultValue(dependencyProperty, obj);
			object value = obj.GetValue(dependencyProperty);
			return !object.Equals(defaultValue, value);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0006A924 File Offset: 0x00068B24
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

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x0006A9CA File Offset: 0x00068BCA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static int CaretBlinkTime
		{
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.CaretBlinkTime;
			}
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0006A9D1 File Offset: 0x00068BD1
		public static global::System.Windows.Point PointFromScreenSafe(global::System.Windows.Media.Visual element, global::System.Windows.Point point)
		{
			return global::Infragistics.Windows.Utilities.PointFromScreenSafe(element, point, null);
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0006A9DC File Offset: 0x00068BDC
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

		// Token: 0x06001BFF RID: 7167 RVA: 0x0006AA7C File Offset: 0x00068C7C
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

		// Token: 0x06001C00 RID: 7168 RVA: 0x0006AB10 File Offset: 0x00068D10
		public static global::System.Windows.Point PointToScreenSafe(global::System.Windows.Media.Visual element, global::System.Windows.Point point)
		{
			return global::Infragistics.Windows.Utilities.PointToScreenSafe(element, point, null);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0006AB1C File Offset: 0x00068D1C
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

		// Token: 0x06001C02 RID: 7170 RVA: 0x0006AB88 File Offset: 0x00068D88
		public static global::System.Windows.Rect GetWorkArea(global::System.Windows.Media.Visual element)
		{
			return global::Infragistics.Windows.Utilities.GetWorkArea(element, null);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0006AB94 File Offset: 0x00068D94
		public static global::System.Windows.Rect GetWorkArea(global::System.Windows.Media.Visual element, global::System.Windows.Media.Visual refElement)
		{
			return global::Infragistics.Windows.Utilities.GetWorkArea(element, default(global::System.Windows.Point), refElement);
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0006ABB4 File Offset: 0x00068DB4
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

		// Token: 0x06001C05 RID: 7173 RVA: 0x0006AC6C File Offset: 0x00068E6C
		public static global::System.Windows.Rect RectFromPoints(global::System.Windows.Point point1, global::System.Windows.Point point2)
		{
			double x = global::System.Math.Min(point1.X, point2.X);
			double y = global::System.Math.Min(point1.Y, point2.Y);
			double width = global::System.Math.Abs(point2.X - point1.X);
			double height = global::System.Math.Abs(point2.Y - point1.Y);
			return new global::System.Windows.Rect(x, y, width, height);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0006ACD4 File Offset: 0x00068ED4
		internal static void VerifyCanBeModified(global::System.Windows.ResourceDictionary dictionary)
		{
			if (dictionary.IsReadOnly)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_ResourceDictionaryReadOnly"));
			}
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0006ACF0 File Offset: 0x00068EF0
		internal static void ThrowIfInvalidEnum(global::System.Enum parameter, string parameterName)
		{
			global::System.Type type = parameter.GetType();
			if (!global::System.Enum.IsDefined(type, parameter))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(parameterName, global::System.Convert.ToInt32(parameter), type);
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0006AD1B File Offset: 0x00068F1B
		internal static void ThrowIfNull(object parameter, string parameterName)
		{
			if (parameter == null)
			{
				throw new global::System.ArgumentNullException(parameterName);
			}
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0006AD27 File Offset: 0x00068F27
		internal static void ThrowIfNullOrEmpty(string parameter, string parameterName)
		{
			if (string.IsNullOrEmpty(parameter))
			{
				throw new global::System.ArgumentNullException(parameterName);
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0006AD38 File Offset: 0x00068F38
		public static bool IsNumericType(global::System.Type type)
		{
			return (type.IsPrimitive || type == typeof(decimal)) && (type != typeof(bool) && type != typeof(char));
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0006AD88 File Offset: 0x00068F88
		public static bool GetSnapElementToDevicePixels(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Utilities.SnapElementToDevicePixelsProperty);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0006AD9A File Offset: 0x00068F9A
		public static void SetSnapElementToDevicePixels(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Utilities.SnapElementToDevicePixelsProperty, value);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0006ADB0 File Offset: 0x00068FB0
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

		// Token: 0x06001C0E RID: 7182 RVA: 0x0006AE44 File Offset: 0x00069044
		private static object OnSyncSnapElementActual(object param)
		{
			global::System.Windows.DependencyObject dependencyObject = param as global::System.Windows.DependencyObject;
			dependencyObject.SetValue(global::Infragistics.Windows.Utilities.SnapElementToDevicePixelsActualProperty, dependencyObject.GetValue(global::Infragistics.Windows.Utilities.SnapElementToDevicePixelsProperty));
			return null;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0006AE70 File Offset: 0x00069070
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

		// Token: 0x06001C10 RID: 7184 RVA: 0x0006AECC File Offset: 0x000690CC
		public static global::System.Windows.MessageBoxResult ShowMessageBox(global::System.Windows.DependencyObject element, string messageBoxText, string caption, global::System.Windows.MessageBoxButton button, global::System.Windows.MessageBoxImage icon)
		{
			global::System.Windows.Window window = (element != null) ? global::System.Windows.Window.GetWindow(element) : null;
			if (window == null)
			{
				return global::System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);
			}
			return global::System.Windows.MessageBox.Show(window, messageBoxText, caption, button, icon);
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0006AF00 File Offset: 0x00069100
		internal static global::System.Windows.MessageBoxResult ShowMessageBox(global::System.Windows.DependencyObject element, string messageBoxText, string caption, global::System.Windows.MessageBoxButton button, global::System.Windows.MessageBoxImage icon, global::System.Windows.MessageBoxResult defaultResult)
		{
			global::System.Windows.Window window = (element != null) ? global::System.Windows.Window.GetWindow(element) : null;
			if (window == null)
			{
				return global::System.Windows.MessageBox.Show(messageBoxText, caption, button, icon, defaultResult);
			}
			return global::System.Windows.MessageBox.Show(window, messageBoxText, caption, button, icon, defaultResult);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0006AF38 File Offset: 0x00069138
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

		// Token: 0x06001C13 RID: 7187 RVA: 0x0006AF7C File Offset: 0x0006917C
		internal static bool IsBrowserWindow(global::System.Windows.Window window)
		{
			return global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted && window is global::System.Windows.Navigation.NavigationWindow && window.GetType().Name == "RootBrowserWindow";
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0006AFA8 File Offset: 0x000691A8
		internal static bool IsContainedBy(global::System.Windows.Rect containerRect, global::System.Windows.Rect rectToTest, bool checkWidth)
		{
			if (checkWidth)
			{
				return containerRect.Left <= rectToTest.Left && containerRect.Right >= rectToTest.Right;
			}
			return containerRect.Top <= rectToTest.Top && containerRect.Bottom >= rectToTest.Bottom;
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0006B004 File Offset: 0x00069204
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

		// Token: 0x06001C16 RID: 7190 RVA: 0x0006B09C File Offset: 0x0006929C
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

		// Token: 0x06001C17 RID: 7191 RVA: 0x0006B0E0 File Offset: 0x000692E0
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

		// Token: 0x06001C18 RID: 7192 RVA: 0x0006B120 File Offset: 0x00069320
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

		// Token: 0x06001C19 RID: 7193 RVA: 0x0006B1BC File Offset: 0x000693BC
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

		// Token: 0x06001C1A RID: 7194 RVA: 0x0006B212 File Offset: 0x00069412
		public static void RefreshLocalizedResources()
		{
			global::Infragistics.Shared.ResourceCustomizer.RefreshLocalizedResources();
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0006B219 File Offset: 0x00069419
		public static int SystemDoubleClickTime
		{
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.DoubleClickTime;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x0006B220 File Offset: 0x00069420
		public static global::System.Windows.Size SystemDoubleClickSize
		{
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.DoubleClickSize;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x0006B227 File Offset: 0x00069427
		public static global::System.Windows.Size SystemDragSize
		{
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.DragSize;
			}
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0006B230 File Offset: 0x00069430
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

		// Token: 0x06001C1F RID: 7199 RVA: 0x0006B264 File Offset: 0x00069464
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

		// Token: 0x06001C20 RID: 7200 RVA: 0x0006B2A4 File Offset: 0x000694A4
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

		// Token: 0x06001C21 RID: 7201 RVA: 0x0006B334 File Offset: 0x00069534
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

		// Token: 0x06001C22 RID: 7202 RVA: 0x0006B398 File Offset: 0x00069598
		internal static bool IsUIElementOrUIElement3D(global::System.Windows.DependencyObject d)
		{
			return d is global::System.Windows.UIElement || (d != null && null != global::Infragistics.Windows.Utilities.UIElement3DType && global::Infragistics.Windows.Utilities.UIElement3DType.IsAssignableFrom(d.GetType()));
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0006B3CC File Offset: 0x000695CC
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

		// Token: 0x06001C24 RID: 7204 RVA: 0x0006B440 File Offset: 0x00069640
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

		// Token: 0x06001C25 RID: 7205 RVA: 0x0006B72D File Offset: 0x0006992D
		public static void EnableModelessKeyboardInterop()
		{
			global::Infragistics.Windows.Utilities._modelessKeyboardInteropEnabled = true;
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0006B738 File Offset: 0x00069938
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

		// Token: 0x06001C27 RID: 7207 RVA: 0x0006B768 File Offset: 0x00069968
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

		// Token: 0x04000DA3 RID: 3491
		private const double SMALLEST_DOUBLE = 2.220446049250313E-13;

		// Token: 0x04000DA4 RID: 3492
		private const string publicKeyTokenLiteral = "PublicKeyToken";

		// Token: 0x04000DA5 RID: 3493
		[global::System.ThreadStatic]
		private static global::System.Random _rnd;

		// Token: 0x04000DA6 RID: 3494
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::System.Windows.Markup.XmlLanguage, global::System.Globalization.CultureInfo> g_LanguageCultureMap;

		// Token: 0x04000DA7 RID: 3495
		private static readonly global::System.Type UIElement3DType;

		// Token: 0x04000DA8 RID: 3496
		[global::System.ThreadStatic]
		private static bool _modelessKeyboardInteropEnabled;

		// Token: 0x04000DA9 RID: 3497
		public static readonly global::System.Windows.DependencyProperty SnapElementToDevicePixelsProperty = global::System.Windows.DependencyProperty.RegisterAttached("SnapElementToDevicePixels", typeof(bool), typeof(global::Infragistics.Windows.Utilities), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Utilities.OnSnapElementToDevicePixelsChanged)));

		// Token: 0x04000DAA RID: 3498
		private static readonly global::System.Windows.DependencyProperty SnapElementToDevicePixelsActualProperty = global::System.Windows.DependencyProperty.RegisterAttached("SnapElementToDevicePixelsActual", typeof(bool), typeof(global::Infragistics.Windows.Utilities), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Utilities.OnSnapElementToDevicePixelsChanged)));

		// Token: 0x04000DAB RID: 3499
		private static bool _canGetHwndSource = true;

		// Token: 0x020002C2 RID: 706
		// (Invoke) Token: 0x06001C29 RID: 7209
		public delegate bool DependencyObjectSearchCallback<T>(T dependencyObject) where T : global::System.Windows.DependencyObject;

		// Token: 0x020002C3 RID: 707
		private class SnapInfo
		{
			// Token: 0x06001C2C RID: 7212 RVA: 0x0006B828 File Offset: 0x00069A28
			private SnapInfo(global::System.Windows.FrameworkElement rootLoadedElement)
			{
				if (rootLoadedElement == null)
				{
					throw new global::System.ArgumentNullException();
				}
				this._rootLoadElement = rootLoadedElement;
			}

			// Token: 0x06001C2D RID: 7213 RVA: 0x0006B84B File Offset: 0x00069A4B
			private static global::Infragistics.Windows.Utilities.SnapInfo GetInfo(global::System.Windows.DependencyObject d)
			{
				return (global::Infragistics.Windows.Utilities.SnapInfo)d.GetValue(global::Infragistics.Windows.Utilities.SnapInfo.InfoProperty);
			}

			// Token: 0x06001C2E RID: 7214 RVA: 0x0006B85D File Offset: 0x00069A5D
			private static void SetInfo(global::System.Windows.DependencyObject d, global::Infragistics.Windows.Utilities.SnapInfo value)
			{
				d.SetValue(global::Infragistics.Windows.Utilities.SnapInfo.InfoPropertyKey, value);
			}

			// Token: 0x06001C2F RID: 7215 RVA: 0x0006B86B File Offset: 0x00069A6B
			private static global::System.Windows.FrameworkElement GetOwner(global::System.Windows.DependencyObject d)
			{
				return (global::System.Windows.FrameworkElement)d.GetValue(global::Infragistics.Windows.Utilities.SnapInfo.OwnerProperty);
			}

			// Token: 0x06001C30 RID: 7216 RVA: 0x0006B87D File Offset: 0x00069A7D
			private static void SetOwner(global::System.Windows.DependencyObject d, global::System.Windows.FrameworkElement value)
			{
				d.SetValue(global::Infragistics.Windows.Utilities.SnapInfo.OwnerPropertyKey, value);
			}

			// Token: 0x06001C31 RID: 7217 RVA: 0x0006B88C File Offset: 0x00069A8C
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

			// Token: 0x06001C32 RID: 7218 RVA: 0x0006B8FE File Offset: 0x00069AFE
			private void CompactList(object param)
			{
				this.VerifyCompacted();
			}

			// Token: 0x06001C33 RID: 7219 RVA: 0x0006B906 File Offset: 0x00069B06
			private void GetDeviceMatrixes(global::System.Windows.Media.Visual rootVisual, out global::System.Windows.Media.Matrix toDeviceMatrix, out global::System.Windows.Media.Matrix fromDeviceMatrix)
			{
				toDeviceMatrix = global::Infragistics.Windows.Utilities.GetDeviceMatrix(true, rootVisual);
				fromDeviceMatrix = global::Infragistics.Windows.Utilities.GetDeviceMatrix(false, rootVisual);
			}

			// Token: 0x06001C34 RID: 7220 RVA: 0x0006B924 File Offset: 0x00069B24
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

			// Token: 0x06001C35 RID: 7221 RVA: 0x0006B960 File Offset: 0x00069B60
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

			// Token: 0x06001C36 RID: 7222 RVA: 0x0006BC0C File Offset: 0x00069E0C
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

			// Token: 0x06001C37 RID: 7223 RVA: 0x0006BC70 File Offset: 0x00069E70
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

			// Token: 0x06001C38 RID: 7224 RVA: 0x0006BCCC File Offset: 0x00069ECC
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

			// Token: 0x06001C39 RID: 7225 RVA: 0x0006BD14 File Offset: 0x00069F14
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

			// Token: 0x04000DAC RID: 3500
			private global::System.WeakReference _rootVisual;

			// Token: 0x04000DAD RID: 3501
			private global::System.Windows.FrameworkElement _rootLoadElement;

			// Token: 0x04000DAE RID: 3502
			private global::Infragistics.Collections.WeakList<global::System.Windows.FrameworkElement> _loadedElements = new global::Infragistics.Collections.WeakList<global::System.Windows.FrameworkElement>();

			// Token: 0x04000DAF RID: 3503
			private bool _compactPending;

			// Token: 0x04000DB0 RID: 3504
			private static readonly global::System.Windows.DependencyPropertyKey InfoPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("Info", typeof(global::Infragistics.Windows.Utilities.SnapInfo), typeof(global::Infragistics.Windows.Utilities.SnapInfo), new global::System.Windows.FrameworkPropertyMetadata(null));

			// Token: 0x04000DB1 RID: 3505
			internal static readonly global::System.Windows.DependencyProperty InfoProperty = global::Infragistics.Windows.Utilities.SnapInfo.InfoPropertyKey.DependencyProperty;

			// Token: 0x04000DB2 RID: 3506
			private static readonly global::System.Windows.DependencyPropertyKey OwnerPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("Owner", typeof(global::System.Windows.FrameworkElement), typeof(global::Infragistics.Windows.Utilities.SnapInfo), new global::System.Windows.FrameworkPropertyMetadata(null));

			// Token: 0x04000DB3 RID: 3507
			internal static readonly global::System.Windows.DependencyProperty OwnerProperty = global::Infragistics.Windows.Utilities.SnapInfo.OwnerPropertyKey.DependencyProperty;
		}

		// Token: 0x020002C4 RID: 708
		internal interface IMeetsCriteria
		{
			// Token: 0x06001C3B RID: 7227
			bool MeetsCriteria(object item);
		}

		// Token: 0x020002C5 RID: 709
		// (Invoke) Token: 0x06001C3D RID: 7229
		internal delegate void MethodDelegate();
	}
}
