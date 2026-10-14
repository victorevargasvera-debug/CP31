using System;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x0200006B RID: 107
	public static class BrushUtil
	{
		// Token: 0x060005F5 RID: 1525 RVA: 0x0001727C File Offset: 0x0001547C
		public static global::System.Windows.Media.Brush Duplicate(this global::System.Windows.Media.Brush brush)
		{
			global::System.Windows.Media.SolidColorBrush solidColorBrush = brush as global::System.Windows.Media.SolidColorBrush;
			if (solidColorBrush != null)
			{
				return solidColorBrush.Duplicate();
			}
			global::System.Windows.Media.LinearGradientBrush linearGradientBrush = brush as global::System.Windows.Media.LinearGradientBrush;
			if (linearGradientBrush != null)
			{
				return linearGradientBrush.Duplicate();
			}
			global::System.Windows.Media.RadialGradientBrush radialGradientBrush = brush as global::System.Windows.Media.RadialGradientBrush;
			if (radialGradientBrush != null)
			{
				return radialGradientBrush.Duplicate();
			}
			global::System.Windows.Media.ImageBrush imageBrush = brush as global::System.Windows.Media.ImageBrush;
			if (imageBrush != null)
			{
				return imageBrush.Duplicate();
			}
			return null;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000172D0 File Offset: 0x000154D0
		private static global::System.Windows.Media.GradientStopCollection GradientStops(global::System.Windows.Media.Color min, double p, global::System.Windows.Media.GradientStopCollection max, global::Infragistics.InterpolationMode interpolationMode)
		{
			global::System.Windows.Media.GradientStopCollection gradientStopCollection = new global::System.Windows.Media.GradientStopCollection();
			for (int i = 0; i < max.Count; i++)
			{
				gradientStopCollection.Add(new global::System.Windows.Media.GradientStop
				{
					Offset = max[i].Offset,
					Color = min.GetInterpolation(p, max[i].Color, interpolationMode)
				});
			}
			return gradientStopCollection;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00017330 File Offset: 0x00015530
		private static global::System.Windows.Media.GradientStopCollection GradientStops(global::System.Windows.Media.GradientStopCollection min, double p, global::System.Windows.Media.GradientStopCollection max, global::Infragistics.InterpolationMode interpolationMode)
		{
			global::System.Windows.Media.GradientStopCollection gradientStopCollection = new global::System.Windows.Media.GradientStopCollection();
			int i;
			for (i = 0; i < global::System.Math.Min(min.Count, max.Count); i++)
			{
				gradientStopCollection.Add(new global::System.Windows.Media.GradientStop
				{
					Offset = (1.0 - p) * min[i].Offset + p * max[i].Offset,
					Color = min[i].Color.GetInterpolation(p, max[i].Color, interpolationMode)
				});
			}
			while (i < min.Count)
			{
				gradientStopCollection.Add(new global::System.Windows.Media.GradientStop
				{
					Offset = (1.0 - p) * min[i].Offset + p * max[max.Count - 1].Offset,
					Color = min[i].Color.GetInterpolation(p, max[max.Count - 1].Color, interpolationMode)
				});
				i++;
			}
			while (i < max.Count)
			{
				gradientStopCollection.Add(new global::System.Windows.Media.GradientStop
				{
					Offset = (1.0 - p) * min[min.Count - 1].Offset + p * max[i].Offset,
					Color = min[min.Count - 1].Color.GetInterpolation(p, max[i].Color, interpolationMode)
				});
				i++;
			}
			return gradientStopCollection;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000174C0 File Offset: 0x000156C0
		private static global::System.Windows.Media.Brush SolidSolid(global::System.Windows.Media.SolidColorBrush min, double p, global::System.Windows.Media.SolidColorBrush max, global::Infragistics.InterpolationMode interpolationMode)
		{
			return new global::System.Windows.Media.SolidColorBrush
			{
				Color = min.Color.GetInterpolation(p, max.Color, interpolationMode),
				Opacity = (1.0 - p) * min.Opacity + p * max.Opacity
			};
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00017510 File Offset: 0x00015710
		private static global::System.Windows.Media.Brush LinearLinear(global::System.Windows.Media.LinearGradientBrush min, double p, global::System.Windows.Media.LinearGradientBrush max, global::Infragistics.InterpolationMode interpolationMode)
		{
			return new global::System.Windows.Media.LinearGradientBrush
			{
				ColorInterpolationMode = max.ColorInterpolationMode,
				EndPoint = new global::System.Windows.Point((1.0 - p) * min.EndPoint.X + p * max.EndPoint.X, (1.0 - p) * min.EndPoint.Y + p * max.EndPoint.Y),
				GradientStops = global::Infragistics.BrushUtil.GradientStops(min.GradientStops, p, max.GradientStops, interpolationMode),
				MappingMode = max.MappingMode,
				Opacity = (1.0 - p) * min.Opacity + p * max.Opacity,
				SpreadMethod = max.SpreadMethod,
				StartPoint = new global::System.Windows.Point(min.StartPoint.X + p * (max.StartPoint.X - min.StartPoint.X), min.StartPoint.Y + p * (max.StartPoint.Y - min.StartPoint.Y))
			};
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00017654 File Offset: 0x00015854
		private static global::System.Windows.Media.Brush RadialRadial(global::System.Windows.Media.RadialGradientBrush min, double p, global::System.Windows.Media.RadialGradientBrush max, global::Infragistics.InterpolationMode interpolationMode)
		{
			return new global::System.Windows.Media.RadialGradientBrush
			{
				Center = new global::System.Windows.Point((1.0 - p) * min.Center.X + p * max.Center.X, (1.0 - p) * min.Center.Y + p * max.Center.Y),
				ColorInterpolationMode = max.ColorInterpolationMode,
				GradientOrigin = max.GradientOrigin,
				GradientStops = global::Infragistics.BrushUtil.GradientStops(min.GradientStops, p, max.GradientStops, interpolationMode),
				MappingMode = max.MappingMode,
				Opacity = (1.0 - p) * min.Opacity + p * max.Opacity,
				RadiusX = (1.0 - p) * min.RadiusX + p * max.RadiusX,
				RadiusY = (1.0 - p) * min.RadiusY + p * max.RadiusY,
				RelativeTransform = max.RelativeTransform.Duplicate(),
				SpreadMethod = max.SpreadMethod,
				Transform = max.RelativeTransform.Duplicate()
			};
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00017798 File Offset: 0x00015998
		private static global::System.Windows.Media.Brush SolidLinear(global::System.Windows.Media.SolidColorBrush min, double p, global::System.Windows.Media.LinearGradientBrush max, global::Infragistics.InterpolationMode interpolationMode)
		{
			return new global::System.Windows.Media.LinearGradientBrush
			{
				ColorInterpolationMode = max.ColorInterpolationMode,
				EndPoint = max.EndPoint,
				GradientStops = global::Infragistics.BrushUtil.GradientStops(min.Color, p, max.GradientStops, interpolationMode),
				MappingMode = max.MappingMode,
				Opacity = (1.0 - p) * min.Opacity + p * max.Opacity,
				RelativeTransform = max.RelativeTransform.Duplicate(),
				SpreadMethod = max.SpreadMethod,
				StartPoint = max.StartPoint,
				Transform = max.Transform.Duplicate()
			};
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00017844 File Offset: 0x00015A44
		private static global::System.Windows.Media.Brush SolidRadial(global::System.Windows.Media.SolidColorBrush min, double p, global::System.Windows.Media.RadialGradientBrush max, global::Infragistics.InterpolationMode interpolationMode)
		{
			return new global::System.Windows.Media.RadialGradientBrush
			{
				Center = max.Center,
				ColorInterpolationMode = max.ColorInterpolationMode,
				GradientOrigin = max.GradientOrigin,
				GradientStops = global::Infragistics.BrushUtil.GradientStops(min.Color, p, max.GradientStops, interpolationMode),
				MappingMode = max.MappingMode,
				Opacity = (1.0 - p) * min.Opacity + p * max.Opacity,
				RadiusX = max.RadiusX,
				RadiusY = max.RadiusY,
				RelativeTransform = max.RelativeTransform.Duplicate(),
				SpreadMethod = max.SpreadMethod,
				Transform = max.Transform.Duplicate()
			};
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00017908 File Offset: 0x00015B08
		public static global::System.Windows.Media.Brush GetInterpolation(this global::System.Windows.Media.Brush minimum, double interpolation, global::System.Windows.Media.Brush maximum, global::Infragistics.InterpolationMode interpolationMode)
		{
			global::System.Windows.Media.SolidColorBrush solidColorBrush = minimum as global::System.Windows.Media.SolidColorBrush;
			global::System.Windows.Media.SolidColorBrush solidColorBrush2 = maximum as global::System.Windows.Media.SolidColorBrush;
			global::System.Windows.Media.LinearGradientBrush linearGradientBrush = maximum as global::System.Windows.Media.LinearGradientBrush;
			global::System.Windows.Media.RadialGradientBrush radialGradientBrush = maximum as global::System.Windows.Media.RadialGradientBrush;
			if (solidColorBrush != null && solidColorBrush2 != null)
			{
				return global::Infragistics.BrushUtil.SolidSolid(solidColorBrush, interpolation, solidColorBrush2, interpolationMode);
			}
			if (solidColorBrush != null && linearGradientBrush != null)
			{
				return global::Infragistics.BrushUtil.SolidLinear(solidColorBrush, interpolation, linearGradientBrush, interpolationMode);
			}
			if (solidColorBrush != null && radialGradientBrush != null)
			{
				return global::Infragistics.BrushUtil.SolidRadial(solidColorBrush, interpolation, radialGradientBrush, interpolationMode);
			}
			global::System.Windows.Media.LinearGradientBrush linearGradientBrush2 = minimum as global::System.Windows.Media.LinearGradientBrush;
			if (linearGradientBrush2 != null && solidColorBrush2 != null)
			{
				return global::Infragistics.BrushUtil.SolidLinear(solidColorBrush2, 1.0 - interpolation, linearGradientBrush2, interpolationMode);
			}
			if (linearGradientBrush2 != null && linearGradientBrush != null)
			{
				return global::Infragistics.BrushUtil.LinearLinear(linearGradientBrush2, interpolation, linearGradientBrush, interpolationMode);
			}
			global::System.Windows.Media.RadialGradientBrush radialGradientBrush2 = minimum as global::System.Windows.Media.RadialGradientBrush;
			if (radialGradientBrush2 != null && solidColorBrush2 != null)
			{
				return global::Infragistics.BrushUtil.SolidRadial(solidColorBrush2, 1.0 - interpolation, radialGradientBrush2, interpolationMode);
			}
			if (radialGradientBrush2 != null && radialGradientBrush != null)
			{
				return global::Infragistics.BrushUtil.RadialRadial(radialGradientBrush2, interpolation, radialGradientBrush, interpolationMode);
			}
			if (minimum != null)
			{
				global::System.Windows.Media.Brush brush = minimum.Duplicate();
				brush.Opacity = (1.0 - interpolation) * minimum.Opacity + interpolation * ((maximum != null) ? maximum.Opacity : 0.0);
				return brush;
			}
			if (maximum != null)
			{
				global::System.Windows.Media.Brush brush2 = maximum.Duplicate();
				brush2.Opacity = (1.0 - interpolation) * ((minimum != null) ? minimum.Opacity : 0.0) + interpolation * maximum.Opacity;
				return brush2;
			}
			return minimum;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00017A4C File Offset: 0x00015C4C
		public static global::System.Windows.Media.Brush GetLightened(this global::System.Windows.Media.Brush brush, double interpolation)
		{
			interpolation = global::Infragistics.MathUtil.Clamp(interpolation, -1.0, 1.0);
			global::System.Windows.Media.SolidColorBrush solidColorBrush = brush as global::System.Windows.Media.SolidColorBrush;
			if (solidColorBrush != null)
			{
				return solidColorBrush.GetLightened(interpolation);
			}
			global::System.Windows.Media.LinearGradientBrush linearGradientBrush = brush as global::System.Windows.Media.LinearGradientBrush;
			if (linearGradientBrush != null)
			{
				return linearGradientBrush.GetLightened(interpolation);
			}
			global::System.Windows.Media.RadialGradientBrush radialGradientBrush = brush as global::System.Windows.Media.RadialGradientBrush;
			if (radialGradientBrush != null)
			{
				return radialGradientBrush.GetLightened(interpolation);
			}
			global::System.Windows.Media.ImageBrush imageBrush = brush as global::System.Windows.Media.ImageBrush;
			if (imageBrush != null)
			{
				return imageBrush.GetLightened(interpolation);
			}
			return null;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00017ABC File Offset: 0x00015CBC
		public static global::System.Windows.Media.SolidColorBrush Duplicate(this global::System.Windows.Media.SolidColorBrush brush)
		{
			return new global::System.Windows.Media.SolidColorBrush
			{
				Color = brush.Color,
				Opacity = brush.Opacity,
				RelativeTransform = brush.RelativeTransform.Duplicate(),
				Transform = brush.Transform.Duplicate()
			};
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00017B0C File Offset: 0x00015D0C
		public static global::System.Windows.Media.SolidColorBrush GetInterpolation(this global::System.Windows.Media.SolidColorBrush minimum, double interpolation, global::System.Windows.Media.SolidColorBrush maximum, global::Infragistics.InterpolationMode interpolationMode)
		{
			interpolation = global::Infragistics.MathUtil.Clamp(interpolation, 0.0, 1.0);
			global::System.Windows.Media.SolidColorBrush solidColorBrush = minimum.Duplicate();
			if (maximum != null)
			{
				solidColorBrush.Color = minimum.Color.GetInterpolation(interpolation, maximum.Color, interpolationMode);
				solidColorBrush.Opacity = minimum.Opacity + interpolation * (maximum.Opacity - minimum.Opacity);
			}
			return solidColorBrush;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00017B74 File Offset: 0x00015D74
		public static global::System.Windows.Media.SolidColorBrush GetLightened(this global::System.Windows.Media.SolidColorBrush brush, double interpolation)
		{
			return new global::System.Windows.Media.SolidColorBrush
			{
				Color = brush.Color.GetLightened(interpolation),
				Opacity = brush.Opacity,
				RelativeTransform = brush.RelativeTransform.Duplicate(),
				Transform = brush.Transform.Duplicate()
			};
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00017BCC File Offset: 0x00015DCC
		public static global::System.Windows.Media.LinearGradientBrush Duplicate(this global::System.Windows.Media.LinearGradientBrush brush)
		{
			global::System.Windows.Media.LinearGradientBrush linearGradientBrush = new global::System.Windows.Media.LinearGradientBrush
			{
				Opacity = brush.Opacity,
				RelativeTransform = brush.RelativeTransform.Duplicate(),
				Transform = brush.Transform.Duplicate(),
				ColorInterpolationMode = brush.ColorInterpolationMode,
				EndPoint = brush.EndPoint,
				MappingMode = brush.MappingMode,
				SpreadMethod = brush.SpreadMethod,
				StartPoint = brush.StartPoint
			};
			foreach (global::System.Windows.Media.GradientStop gradientStop in brush.GradientStops)
			{
				linearGradientBrush.GradientStops.Add(gradientStop.Duplicate());
			}
			return linearGradientBrush;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00017C9C File Offset: 0x00015E9C
		public static global::System.Windows.Media.LinearGradientBrush GetInterpolation(this global::System.Windows.Media.LinearGradientBrush minimum, double interpolation, global::System.Windows.Media.LinearGradientBrush maximum, global::Infragistics.InterpolationMode interpolationMode)
		{
			interpolation = global::Infragistics.MathUtil.Clamp(interpolation, 0.0, 1.0);
			global::System.Windows.Media.LinearGradientBrush linearGradientBrush = new global::System.Windows.Media.LinearGradientBrush
			{
				RelativeTransform = minimum.RelativeTransform.Duplicate(),
				Transform = minimum.Transform.Duplicate(),
				ColorInterpolationMode = minimum.ColorInterpolationMode,
				MappingMode = minimum.MappingMode,
				SpreadMethod = minimum.SpreadMethod
			};
			if (maximum != null && minimum.GradientStops.Count == maximum.GradientStops.Count)
			{
				linearGradientBrush.Opacity = minimum.Opacity + interpolation * (maximum.Opacity - minimum.Opacity);
				linearGradientBrush.EndPoint = new global::System.Windows.Point(minimum.EndPoint.X + interpolation * (maximum.EndPoint.X - minimum.EndPoint.X), minimum.EndPoint.Y + interpolation * (maximum.EndPoint.Y - minimum.EndPoint.Y));
				linearGradientBrush.StartPoint = new global::System.Windows.Point(minimum.StartPoint.X + interpolation * (maximum.StartPoint.X - minimum.StartPoint.X), minimum.StartPoint.Y + interpolation * (maximum.StartPoint.Y - minimum.StartPoint.Y));
				for (int i = 0; i < global::System.Math.Min(minimum.GradientStops.Count, maximum.GradientStops.Count); i++)
				{
					linearGradientBrush.GradientStops.Add(minimum.GradientStops[i].GetInterpolation(interpolation, maximum.GradientStops[i], interpolationMode));
				}
			}
			return linearGradientBrush;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00017E78 File Offset: 0x00016078
		public static global::System.Windows.Media.LinearGradientBrush GetLightened(this global::System.Windows.Media.LinearGradientBrush brush, double interpolation)
		{
			global::System.Windows.Media.LinearGradientBrush linearGradientBrush = new global::System.Windows.Media.LinearGradientBrush
			{
				Opacity = brush.Opacity,
				RelativeTransform = brush.RelativeTransform.Duplicate(),
				Transform = brush.Transform.Duplicate(),
				ColorInterpolationMode = brush.ColorInterpolationMode,
				EndPoint = brush.EndPoint,
				MappingMode = brush.MappingMode,
				SpreadMethod = brush.SpreadMethod,
				StartPoint = brush.StartPoint
			};
			foreach (global::System.Windows.Media.GradientStop gradientStop in brush.GradientStops)
			{
				linearGradientBrush.GradientStops.Add(gradientStop.GetLightened(interpolation));
			}
			return linearGradientBrush;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00017F4C File Offset: 0x0001614C
		public static global::System.Windows.Media.RadialGradientBrush Duplicate(this global::System.Windows.Media.RadialGradientBrush brush)
		{
			global::System.Windows.Media.RadialGradientBrush radialGradientBrush = new global::System.Windows.Media.RadialGradientBrush
			{
				Opacity = brush.Opacity,
				RelativeTransform = brush.RelativeTransform.Duplicate(),
				Transform = brush.Transform.Duplicate(),
				Center = brush.Center,
				ColorInterpolationMode = brush.ColorInterpolationMode,
				GradientOrigin = brush.GradientOrigin,
				MappingMode = brush.MappingMode,
				RadiusX = brush.RadiusX,
				RadiusY = brush.RadiusY,
				SpreadMethod = brush.SpreadMethod
			};
			foreach (global::System.Windows.Media.GradientStop gradientStop in brush.GradientStops)
			{
				radialGradientBrush.GradientStops.Add(gradientStop.Duplicate());
			}
			return radialGradientBrush;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00018034 File Offset: 0x00016234
		public static global::System.Windows.Media.RadialGradientBrush GetInterpolation(this global::System.Windows.Media.RadialGradientBrush minimum, double interpolation, global::System.Windows.Media.RadialGradientBrush maximum, global::Infragistics.InterpolationMode interpolationMode)
		{
			interpolation = global::Infragistics.MathUtil.Clamp(interpolation, 0.0, 1.0);
			global::System.Windows.Media.RadialGradientBrush radialGradientBrush = minimum.Duplicate();
			if (maximum != null && minimum.GradientStops.Count == maximum.GradientStops.Count)
			{
				radialGradientBrush.Opacity = minimum.Opacity + interpolation * (maximum.Opacity - minimum.Opacity);
				radialGradientBrush.Center = new global::System.Windows.Point(minimum.Center.X + interpolation * (maximum.Center.X - minimum.Center.X), minimum.Center.Y + interpolation * (maximum.Center.Y - minimum.Center.Y));
				radialGradientBrush.RadiusX = minimum.RadiusX + interpolation * (maximum.RadiusX - minimum.RadiusX);
				radialGradientBrush.RadiusY = minimum.RadiusY + interpolation * (maximum.RadiusY - minimum.RadiusY);
				for (int i = 0; i < radialGradientBrush.GradientStops.Count; i++)
				{
					radialGradientBrush.GradientStops[i].Color = minimum.GradientStops[i].Color.GetInterpolation(interpolation, maximum.GradientStops[i].Color, interpolationMode);
					radialGradientBrush.GradientStops[i].Offset = minimum.GradientStops[i].Offset + interpolation * (maximum.GradientStops[i].Offset - minimum.GradientStops[i].Offset);
				}
			}
			return radialGradientBrush;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000181E4 File Offset: 0x000163E4
		public static global::System.Windows.Media.RadialGradientBrush GetLightened(this global::System.Windows.Media.RadialGradientBrush brush, double interpolation)
		{
			global::System.Windows.Media.RadialGradientBrush radialGradientBrush = new global::System.Windows.Media.RadialGradientBrush
			{
				Opacity = brush.Opacity,
				RelativeTransform = brush.RelativeTransform.Duplicate(),
				Transform = brush.Transform.Duplicate(),
				Center = brush.Center,
				ColorInterpolationMode = brush.ColorInterpolationMode,
				GradientOrigin = brush.GradientOrigin,
				MappingMode = brush.MappingMode,
				RadiusX = brush.RadiusX,
				RadiusY = brush.RadiusY,
				SpreadMethod = brush.SpreadMethod
			};
			foreach (global::System.Windows.Media.GradientStop gradientStop in brush.GradientStops)
			{
				radialGradientBrush.GradientStops.Add(gradientStop.GetLightened(interpolation));
			}
			return radialGradientBrush;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000182D0 File Offset: 0x000164D0
		public static global::System.Windows.Media.ImageBrush Duplicate(this global::System.Windows.Media.ImageBrush brush)
		{
			return new global::System.Windows.Media.ImageBrush
			{
				Opacity = brush.Opacity,
				RelativeTransform = brush.RelativeTransform.Duplicate(),
				Transform = brush.Transform.Duplicate(),
				AlignmentX = brush.AlignmentX,
				AlignmentY = brush.AlignmentY,
				ImageSource = brush.ImageSource,
				Stretch = brush.Stretch
			};
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00018344 File Offset: 0x00016544
		public static global::System.Windows.Media.ImageBrush GetInterpolation(this global::System.Windows.Media.ImageBrush minimum, double interpolation, global::System.Windows.Media.ImageBrush maximum, global::Infragistics.InterpolationMode interpolationMode)
		{
			interpolation = global::Infragistics.MathUtil.Clamp(interpolation, 0.0, 1.0);
			global::System.Windows.Media.ImageBrush imageBrush = minimum.Duplicate();
			if (maximum != null)
			{
				imageBrush.Opacity = minimum.Opacity + interpolation * (maximum.Opacity - minimum.Opacity);
			}
			return imageBrush;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00018394 File Offset: 0x00016594
		public static global::System.Windows.Media.ImageBrush GetLightened(this global::System.Windows.Media.ImageBrush brush, double interpolation)
		{
			return brush.Duplicate();
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000183AC File Offset: 0x000165AC
		public static global::System.Windows.Media.GradientStop Duplicate(this global::System.Windows.Media.GradientStop gradientStop)
		{
			return new global::System.Windows.Media.GradientStop
			{
				Color = gradientStop.Color,
				Offset = gradientStop.Offset
			};
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000183DC File Offset: 0x000165DC
		public static global::System.Windows.Media.GradientStop GetInterpolation(this global::System.Windows.Media.GradientStop minimum, double interpolation, global::System.Windows.Media.GradientStop maximum, global::Infragistics.InterpolationMode interpolationMode)
		{
			interpolation = global::Infragistics.MathUtil.Clamp(interpolation, 0.0, 1.0);
			return new global::System.Windows.Media.GradientStop
			{
				Color = minimum.Color.GetInterpolation(interpolation, maximum.Color, interpolationMode),
				Offset = minimum.Offset + interpolation * (maximum.Offset - minimum.Offset)
			};
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00018444 File Offset: 0x00016644
		public static global::System.Windows.Media.GradientStop GetLightened(this global::System.Windows.Media.GradientStop gradientStop, double interpolation)
		{
			return new global::System.Windows.Media.GradientStop
			{
				Color = gradientStop.Color.GetLightened(interpolation),
				Offset = gradientStop.Offset
			};
		}
	}
}
