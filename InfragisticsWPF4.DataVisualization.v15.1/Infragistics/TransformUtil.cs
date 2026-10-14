using System;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000BE RID: 190
	public static class TransformUtil
	{
		// Token: 0x0600081F RID: 2079 RVA: 0x00026248 File Offset: 0x00024448
		public static global::System.Windows.Media.Transform Duplicate(this global::System.Windows.Media.Transform transform)
		{
			global::System.Windows.Media.Transform transform2 = null;
			global::System.Windows.Media.MatrixTransform matrixTransform = transform as global::System.Windows.Media.MatrixTransform;
			if (matrixTransform != null)
			{
				transform2 = matrixTransform.Duplicate();
			}
			global::System.Windows.Media.RotateTransform rotateTransform = transform as global::System.Windows.Media.RotateTransform;
			if (rotateTransform != null)
			{
				transform2 = rotateTransform.Duplicate();
			}
			global::System.Windows.Media.ScaleTransform scaleTransform = transform as global::System.Windows.Media.ScaleTransform;
			if (scaleTransform != null)
			{
				transform2 = scaleTransform.Duplicate();
			}
			global::System.Windows.Media.SkewTransform skewTransform = transform as global::System.Windows.Media.SkewTransform;
			if (skewTransform != null)
			{
				transform2 = skewTransform.Duplicate();
			}
			global::System.Windows.Media.TransformGroup transformGroup = transform as global::System.Windows.Media.TransformGroup;
			if (transformGroup != null)
			{
				transform2 = transformGroup.Duplicate();
			}
			global::System.Windows.Media.TranslateTransform translateTransform = transform as global::System.Windows.Media.TranslateTransform;
			if (translateTransform != null)
			{
				transform2 = translateTransform.Duplicate();
			}
			if (transform != null && transform2 == null)
			{
				throw new global::System.NotImplementedException();
			}
			return transform2;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000262D4 File Offset: 0x000244D4
		public static global::System.Windows.Media.MatrixTransform Duplicate(this global::System.Windows.Media.MatrixTransform transform)
		{
			if (transform == null)
			{
				return null;
			}
			return new global::System.Windows.Media.MatrixTransform
			{
				Matrix = transform.Matrix.Duplicate()
			};
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00026300 File Offset: 0x00024500
		public static global::System.Windows.Media.RotateTransform Duplicate(this global::System.Windows.Media.RotateTransform transform)
		{
			if (transform == null)
			{
				return null;
			}
			return new global::System.Windows.Media.RotateTransform
			{
				Angle = transform.Angle,
				CenterX = transform.CenterX,
				CenterY = transform.CenterY
			};
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00026340 File Offset: 0x00024540
		public static global::System.Windows.Media.ScaleTransform Duplicate(this global::System.Windows.Media.ScaleTransform transform)
		{
			if (transform == null)
			{
				return null;
			}
			return new global::System.Windows.Media.ScaleTransform
			{
				CenterX = transform.CenterX,
				CenterY = transform.CenterY,
				ScaleX = transform.ScaleX,
				ScaleY = transform.ScaleY
			};
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0002638C File Offset: 0x0002458C
		public static global::System.Windows.Media.SkewTransform Duplicate(this global::System.Windows.Media.SkewTransform transform)
		{
			if (transform == null)
			{
				return null;
			}
			return new global::System.Windows.Media.SkewTransform
			{
				AngleX = transform.AngleX,
				AngleY = transform.AngleY,
				CenterX = transform.CenterX,
				CenterY = transform.CenterY
			};
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000263D8 File Offset: 0x000245D8
		public static global::System.Windows.Media.TransformGroup Duplicate(this global::System.Windows.Media.TransformGroup transform)
		{
			global::System.Windows.Media.TransformGroup transformGroup = null;
			if (transform != null)
			{
				transformGroup = new global::System.Windows.Media.TransformGroup();
				foreach (global::System.Windows.Media.Transform transform2 in transform.Children)
				{
					transformGroup.Children.Add(transform2.Duplicate());
				}
			}
			return transformGroup;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00026444 File Offset: 0x00024644
		public static global::System.Windows.Media.TranslateTransform Duplicate(this global::System.Windows.Media.TranslateTransform transform)
		{
			if (transform == null)
			{
				return null;
			}
			return new global::System.Windows.Media.TranslateTransform
			{
				X = transform.X,
				Y = transform.Y
			};
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00026478 File Offset: 0x00024678
		public static global::System.Windows.Media.MatrixTransform SetProjectionMatrix(this global::System.Windows.Media.MatrixTransform matrixTransform, global::System.Windows.Rect source, global::System.Windows.Rect target)
		{
			double left = target.Left;
			double num = target.Left + target.Width;
			double num2 = target.Top + target.Height;
			double top = target.Top;
			double left2 = source.Left;
			double num3 = source.Left + source.Width;
			double num4 = source.Top + source.Height;
			double top2 = source.Top;
			double num5 = (num - left) / (num3 - left2);
			double m = 0.0;
			double offsetX = -left2 * num5 + left;
			double m2 = 0.0;
			double num6 = (top - num2) / (top2 - num4);
			double offsetY = -num4 * num6 + num2;
			matrixTransform.Matrix = new global::System.Windows.Media.Matrix(num5, m2, m, num6, offsetX, offsetY);
			return matrixTransform;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00026544 File Offset: 0x00024744
		public static global::System.Windows.Media.Matrix GetMatrix(this global::System.Windows.Media.GeneralTransform transform)
		{
			global::System.Windows.Media.MatrixTransform matrixTransform = transform as global::System.Windows.Media.MatrixTransform;
			if (matrixTransform != null)
			{
				return matrixTransform.Matrix.Duplicate();
			}
			global::System.Windows.Point point = transform.Transform(global::Infragistics.TransformUtil.P0);
			global::System.Windows.Point point2 = transform.Transform(global::Infragistics.TransformUtil.PX);
			global::System.Windows.Point point3 = transform.Transform(global::Infragistics.TransformUtil.PY);
			return new global::System.Windows.Media.Matrix(point2.X - point.X, point3.X - point.X, point2.Y - point.Y, point3.Y - point.Y, point.X, point.Y);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000265DC File Offset: 0x000247DC
		public static global::System.Windows.Media.MatrixTransform GetInverse(this global::System.Windows.Media.GeneralTransform transform)
		{
			return new global::System.Windows.Media.MatrixTransform
			{
				Matrix = transform.GetMatrix().GetInverse()
			};
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00026604 File Offset: 0x00024804
		public static global::System.Windows.Rect Transform(this global::System.Windows.Media.GeneralTransform generalTransform, global::System.Windows.Rect rect)
		{
			global::System.Windows.Point point = generalTransform.Transform(new global::System.Windows.Point(rect.Left, rect.Top));
			global::System.Windows.Point point2 = generalTransform.Transform(new global::System.Windows.Point(rect.Right, rect.Bottom));
			return new global::System.Windows.Rect(point, point2);
		}

		// Token: 0x040002F7 RID: 759
		private static global::System.Windows.Point P0 = new global::System.Windows.Point(0.0, 0.0);

		// Token: 0x040002F8 RID: 760
		private static global::System.Windows.Point PX = new global::System.Windows.Point(1.0, 0.0);

		// Token: 0x040002F9 RID: 761
		private static global::System.Windows.Point PY = new global::System.Windows.Point(0.0, 1.0);
	}
}
