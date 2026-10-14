using System;
using System.Collections.Generic;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002E8 RID: 744
	[global::System.Serializable]
	internal abstract class ContainerBase : global::DevAge.Drawing.VisualElements.VisualElementBase, global::DevAge.Drawing.VisualElements.IContainer, global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x060023C1 RID: 9153 RVA: 0x0007CC98 File Offset: 0x0007AE98
		public ContainerBase()
		{
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x0007CCB4 File Offset: 0x0007AEB4
		public ContainerBase(global::DevAge.Drawing.VisualElements.ContainerBase other) : base(other)
		{
			if (other.Background != null)
			{
				this.Background = (global::DevAge.Drawing.VisualElements.IVisualElement)other.Background.Clone();
			}
			else
			{
				this.Background = null;
			}
			this.ElementsDrawMode = other.ElementsDrawMode;
			this.Padding = other.Padding;
			if (other.Border != null)
			{
				this.Border = (global::DevAge.Drawing.IBorder)other.Border.Clone();
				return;
			}
			this.Border = null;
		}

		// Token: 0x060023C3 RID: 9155
		protected abstract global::System.Collections.Generic.IEnumerable<global::DevAge.Drawing.VisualElements.IVisualElement> GetElements();

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x0007CD4C File Offset: 0x0007AF4C
		// (set) Token: 0x060023C5 RID: 9157 RVA: 0x0007CD54 File Offset: 0x0007AF54
		protected global::DevAge.Drawing.ElementsDrawMode ElementsDrawMode
		{
			get
			{
				return this.mDrawMode;
			}
			set
			{
				this.mDrawMode = value;
			}
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0007CD60 File Offset: 0x0007AF60
		protected virtual bool ShouldSerializeElementsDrawMode()
		{
			return this.ElementsDrawMode != global::DevAge.Drawing.ElementsDrawMode.Covering;
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x0007CD70 File Offset: 0x0007AF70
		// (set) Token: 0x060023C8 RID: 9160 RVA: 0x0007CD78 File Offset: 0x0007AF78
		protected global::DevAge.Drawing.VisualElements.IVisualElement Background
		{
			get
			{
				return this.mBackground;
			}
			set
			{
				this.mBackground = value;
			}
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0007CD84 File Offset: 0x0007AF84
		protected virtual bool ShouldSerializeBackground()
		{
			return this.Background != null;
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x0007CD94 File Offset: 0x0007AF94
		// (set) Token: 0x060023CB RID: 9163 RVA: 0x0007CD9C File Offset: 0x0007AF9C
		protected global::DevAge.Drawing.Padding Padding
		{
			get
			{
				return this.mPadding;
			}
			set
			{
				this.mPadding = value;
			}
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x0007CDA8 File Offset: 0x0007AFA8
		protected virtual bool ShouldSerializePadding()
		{
			return this.Padding != global::DevAge.Drawing.Padding.Empty;
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x0007CDBC File Offset: 0x0007AFBC
		// (set) Token: 0x060023CE RID: 9166 RVA: 0x0007CDC4 File Offset: 0x0007AFC4
		protected global::DevAge.Drawing.IBorder Border
		{
			get
			{
				return this.mBorder;
			}
			set
			{
				this.mBorder = value;
			}
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x0007CDD0 File Offset: 0x0007AFD0
		protected virtual bool ShouldSerializeBorder()
		{
			return this.Border != null;
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x0007CDE0 File Offset: 0x0007AFE0
		public global::System.Drawing.RectangleF GetContentRectangle(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF backGroundArea)
		{
			if (this.Border != null)
			{
				backGroundArea = this.Border.GetContentRectangle(backGroundArea);
			}
			if (!this.Padding.IsEmpty)
			{
				backGroundArea = this.Padding.GetContentRectangle(backGroundArea);
			}
			if (this.Background is global::DevAge.Drawing.VisualElements.IBackground)
			{
				backGroundArea = ((global::DevAge.Drawing.VisualElements.IBackground)this.Background).GetBackgroundContentRectangle(measure, backGroundArea);
			}
			return backGroundArea;
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x0007CE54 File Offset: 0x0007B054
		public global::System.Drawing.SizeF GetExtent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF contentSize)
		{
			if (this.Background is global::DevAge.Drawing.VisualElements.IBackground)
			{
				contentSize = ((global::DevAge.Drawing.VisualElements.IBackground)this.Background).GetBackgroundExtent(measure, contentSize);
			}
			if (!this.Padding.IsEmpty)
			{
				contentSize = this.Padding.GetExtent(contentSize);
			}
			if (this.Border != null)
			{
				contentSize = this.Border.GetExtent(contentSize);
			}
			return contentSize;
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0007CEC8 File Offset: 0x0007B0C8
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			this.OnDrawBackground(graphics, area);
			using (global::DevAge.Drawing.MeasureHelper measureHelper = new global::DevAge.Drawing.MeasureHelper(graphics))
			{
				global::System.Drawing.RectangleF contentRectangle = this.GetContentRectangle(measureHelper, area);
				this.OnDrawContent(graphics, contentRectangle);
			}
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x0007CF18 File Offset: 0x0007B118
		protected virtual void OnDrawBackground(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (this.Border != null)
			{
				this.Border.Draw(graphics, area);
				area = this.Border.GetContentRectangle(area);
			}
			if (this.Background != null)
			{
				this.Background.Draw(graphics, area);
			}
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0007CF68 File Offset: 0x0007B168
		protected virtual void OnDrawContent(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (this.ElementsDrawMode == global::DevAge.Drawing.ElementsDrawMode.Covering)
			{
				using (global::System.Collections.Generic.IEnumerator<global::DevAge.Drawing.VisualElements.IVisualElement> enumerator = this.GetElements().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::DevAge.Drawing.VisualElements.IVisualElement visualElement = enumerator.Current;
						visualElement.Draw(graphics, area);
					}
					return;
				}
			}
			if (this.ElementsDrawMode == global::DevAge.Drawing.ElementsDrawMode.Align)
			{
				using (new global::DevAge.Drawing.MeasureHelper(graphics))
				{
					foreach (global::DevAge.Drawing.VisualElements.IVisualElement visualElement2 in this.GetElements())
					{
						global::System.Drawing.RectangleF contentArea;
						visualElement2.Draw(graphics, area, out contentArea);
						area = global::DevAge.Drawing.VisualElements.ContainerBase.CalculateRemainingArea(area, visualElement2.AnchorArea, contentArea);
					}
					return;
				}
			}
			throw new global::System.ApplicationException("DrawMode not supported");
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0007D064 File Offset: 0x0007B264
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(0f, 0f);
			if (this.ElementsDrawMode == global::DevAge.Drawing.ElementsDrawMode.Covering)
			{
				using (global::System.Collections.Generic.IEnumerator<global::DevAge.Drawing.VisualElements.IVisualElement> enumerator = this.GetElements().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::DevAge.Drawing.VisualElements.IVisualElement visualElement = enumerator.Current;
						global::System.Drawing.SizeF contentSize = visualElement.Measure(measure, global::System.Drawing.Size.Empty, maxSize);
						contentSize = global::DevAge.Drawing.VisualElements.ContainerBase.CalculateSizeWithAnchor(contentSize, visualElement.AnchorArea, maxSize);
						if (contentSize.Width > sizeF.Width)
						{
							sizeF.Width = contentSize.Width;
						}
						if (contentSize.Height > sizeF.Height)
						{
							sizeF.Height = contentSize.Height;
						}
					}
					goto IL_13E;
				}
			}
			if (this.ElementsDrawMode == global::DevAge.Drawing.ElementsDrawMode.Align)
			{
				global::DevAge.Drawing.AnchorArea contentAnchor = null;
				using (global::System.Collections.Generic.IEnumerator<global::DevAge.Drawing.VisualElements.IVisualElement> enumerator2 = this.GetElements().GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::DevAge.Drawing.VisualElements.IVisualElement visualElement2 = enumerator2.Current;
						global::System.Drawing.SizeF contentSize2 = visualElement2.Measure(measure, global::System.Drawing.Size.Empty, maxSize);
						contentSize2 = global::DevAge.Drawing.VisualElements.ContainerBase.CalculateSizeWithAnchor(contentSize2, visualElement2.AnchorArea, maxSize);
						sizeF = global::DevAge.Drawing.VisualElements.ContainerBase.CalculateSizeWithContent(sizeF, contentAnchor, contentSize2);
						contentAnchor = visualElement2.AnchorArea;
					}
					goto IL_13E;
				}
			}
			throw new global::System.ApplicationException("DrawMode not supported");
			IL_13E:
			return this.GetExtent(measure, sizeF);
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x0007D1D4 File Offset: 0x0007B3D4
		public override global::DevAge.Drawing.VisualElements.VisualElementList GetElementsAtPoint(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF area, global::System.Drawing.PointF point)
		{
			global::DevAge.Drawing.VisualElements.VisualElementList elementsAtPoint = base.GetElementsAtPoint(measure, area, point);
			area = this.GetContentRectangle(measure, area);
			if (this.ElementsDrawMode == global::DevAge.Drawing.ElementsDrawMode.Covering)
			{
				using (global::System.Collections.Generic.IEnumerator<global::DevAge.Drawing.VisualElements.IVisualElement> enumerator = this.GetElements().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::DevAge.Drawing.VisualElements.IVisualElement visualElement = enumerator.Current;
						elementsAtPoint.AddRange(visualElement.GetElementsAtPoint(measure, area, point));
					}
					return elementsAtPoint;
				}
			}
			if (this.ElementsDrawMode == global::DevAge.Drawing.ElementsDrawMode.Align)
			{
				using (global::System.Collections.Generic.IEnumerator<global::DevAge.Drawing.VisualElements.IVisualElement> enumerator2 = this.GetElements().GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::DevAge.Drawing.VisualElements.IVisualElement visualElement2 = enumerator2.Current;
						elementsAtPoint.AddRange(visualElement2.GetElementsAtPoint(measure, area, point));
						global::System.Drawing.RectangleF drawingArea = visualElement2.GetDrawingArea(measure, area);
						area = global::DevAge.Drawing.VisualElements.ContainerBase.CalculateRemainingArea(area, visualElement2.AnchorArea, drawingArea);
					}
					return elementsAtPoint;
				}
			}
			throw new global::System.ApplicationException("DrawMode not supported");
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0007D2D8 File Offset: 0x0007B4D8
		public static global::System.Drawing.RectangleF CalculateRemainingArea(global::System.Drawing.RectangleF parentArea, global::DevAge.Drawing.AnchorArea contentAnchor, global::System.Drawing.RectangleF contentArea)
		{
			if (contentAnchor != null)
			{
				float y;
				float height;
				if (contentAnchor.HasTop && !contentAnchor.HasBottom)
				{
					y = contentArea.Bottom;
					height = parentArea.Height - contentArea.Height;
				}
				else if (contentAnchor.HasBottom && !contentAnchor.HasTop)
				{
					y = parentArea.Top;
					height = parentArea.Height - contentArea.Height;
				}
				else
				{
					y = parentArea.Top;
					height = parentArea.Height;
				}
				float x;
				float width;
				if (contentAnchor.HasLeft && !contentAnchor.HasRight)
				{
					x = contentArea.Right;
					width = parentArea.Width - contentArea.Width;
				}
				else if (contentAnchor.HasRight && !contentAnchor.HasLeft)
				{
					x = parentArea.Left;
					width = parentArea.Width - contentArea.Width;
				}
				else
				{
					x = parentArea.Left;
					width = parentArea.Width;
				}
				global::System.Drawing.RectangleF result = new global::System.Drawing.RectangleF(x, y, width, height);
				result.Intersect(parentArea);
				return result;
			}
			return parentArea;
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0007D3F8 File Offset: 0x0007B5F8
		public static global::System.Drawing.SizeF CalculateSizeWithContent(global::System.Drawing.SizeF currentSize, global::DevAge.Drawing.AnchorArea contentAnchor, global::System.Drawing.SizeF contentSize)
		{
			if (contentAnchor != null && (contentAnchor.HasLeft || contentAnchor.HasRight))
			{
				currentSize.Width += contentSize.Width;
			}
			else if (contentSize.Width > currentSize.Width)
			{
				currentSize.Width = contentSize.Width;
			}
			if (contentAnchor != null && (contentAnchor.HasTop || contentAnchor.HasBottom))
			{
				currentSize.Height += contentSize.Height;
			}
			else if (contentSize.Height > currentSize.Height)
			{
				currentSize.Height = contentSize.Height;
			}
			return currentSize;
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x0007D4C4 File Offset: 0x0007B6C4
		public static global::System.Drawing.SizeF CalculateSizeWithAnchor(global::System.Drawing.SizeF contentSize, global::DevAge.Drawing.AnchorArea contentAnchor, global::System.Drawing.SizeF clientSize)
		{
			if (contentAnchor == null)
			{
				return contentSize;
			}
			if (contentAnchor.HasLeft && contentAnchor.HasRight)
			{
				if (!clientSize.IsEmpty)
				{
					contentSize.Width = clientSize.Width - (contentAnchor.Left + contentAnchor.Right);
				}
			}
			else if (contentAnchor.HasLeft)
			{
				contentSize.Width += contentAnchor.Left;
			}
			else if (contentAnchor.HasRight)
			{
				contentSize.Width += contentAnchor.Right;
			}
			if (contentSize.Width < 0f)
			{
				contentSize.Width = 0f;
			}
			if (contentAnchor.HasTop && contentAnchor.HasBottom)
			{
				if (!clientSize.IsEmpty)
				{
					contentSize.Height = clientSize.Height - (contentAnchor.Top + contentAnchor.Bottom);
				}
			}
			else if (contentAnchor.HasTop)
			{
				contentSize.Height += contentAnchor.Top;
			}
			else if (contentAnchor.HasBottom)
			{
				contentSize.Height += contentAnchor.Bottom;
			}
			if (contentSize.Height < 0f)
			{
				contentSize.Height = 0f;
			}
			return contentSize;
		}

		// Token: 0x04000CAD RID: 3245
		private global::DevAge.Drawing.ElementsDrawMode mDrawMode = global::DevAge.Drawing.ElementsDrawMode.Covering;

		// Token: 0x04000CAE RID: 3246
		private global::DevAge.Drawing.VisualElements.IVisualElement mBackground;

		// Token: 0x04000CAF RID: 3247
		private global::DevAge.Drawing.Padding mPadding = global::DevAge.Drawing.Padding.Empty;

		// Token: 0x04000CB0 RID: 3248
		private global::DevAge.Drawing.IBorder mBorder;
	}
}
