using System;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002CE RID: 718
	[global::System.Serializable]
	internal abstract class VisualElementBase : global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x0600231F RID: 8991 RVA: 0x0007B4AC File Offset: 0x000796AC
		protected VisualElementBase()
		{
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x0007B4B4 File Offset: 0x000796B4
		public VisualElementBase(global::DevAge.Drawing.VisualElements.VisualElementBase other)
		{
			if (other.AnchorArea != null)
			{
				this.AnchorArea = (global::DevAge.Drawing.AnchorArea)other.AnchorArea.Clone();
				return;
			}
			this.AnchorArea = null;
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x0007B4FC File Offset: 0x000796FC
		// (set) Token: 0x06002322 RID: 8994 RVA: 0x0007B504 File Offset: 0x00079704
		public virtual global::DevAge.Drawing.AnchorArea AnchorArea
		{
			get
			{
				return this.mAnchorArea;
			}
			set
			{
				this.mAnchorArea = value;
			}
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x0007B510 File Offset: 0x00079710
		protected virtual bool ShouldSerializeAnchorArea()
		{
			return this.AnchorArea != null && !this.AnchorArea.IsEmpty;
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x0007B534 File Offset: 0x00079734
		public global::System.Drawing.SizeF Measure(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF minSize, global::System.Drawing.SizeF maxSize)
		{
			global::System.Drawing.SizeF measureSize = this.OnMeasureContent(measure, maxSize);
			return global::DevAge.Drawing.Utilities.CheckMeasure(measureSize, minSize, maxSize);
		}

		// Token: 0x06002325 RID: 8997
		protected abstract global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize);

		// Token: 0x06002326 RID: 8998 RVA: 0x0007B558 File Offset: 0x00079758
		public void Draw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area, out global::System.Drawing.RectangleF drawingArea)
		{
			using (global::DevAge.Drawing.MeasureHelper measureHelper = new global::DevAge.Drawing.MeasureHelper(graphics))
			{
				drawingArea = this.GetDrawingArea(measureHelper, area);
				this.OnDraw(graphics, drawingArea);
			}
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x0007B5AC File Offset: 0x000797AC
		public void Draw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			global::System.Drawing.RectangleF rectangleF;
			this.Draw(graphics, area, out rectangleF);
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x0007B5C8 File Offset: 0x000797C8
		public global::System.Drawing.RectangleF GetDrawingArea(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF area)
		{
			global::System.Drawing.RectangleF result = area;
			if (this.AnchorArea != null && !this.AnchorArea.IsEmpty)
			{
				global::System.Drawing.SizeF content = this.Measure(measure, global::System.Drawing.SizeF.Empty, global::System.Drawing.SizeF.Empty);
				result = global::DevAge.Drawing.AnchorArea.CalculateArea(area, content, this.AnchorArea);
			}
			return result;
		}

		// Token: 0x06002329 RID: 9001
		protected abstract void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area);

		// Token: 0x0600232A RID: 9002 RVA: 0x0007B620 File Offset: 0x00079820
		public virtual global::DevAge.Drawing.VisualElements.VisualElementList GetElementsAtPoint(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF area, global::System.Drawing.PointF point)
		{
			global::DevAge.Drawing.VisualElements.VisualElementList visualElementList = new global::DevAge.Drawing.VisualElements.VisualElementList();
			if (this.GetDrawingArea(measure, area).Contains(point))
			{
				visualElementList.Add(this);
			}
			return visualElementList;
		}

		// Token: 0x0600232B RID: 9003
		public abstract object Clone();

		// Token: 0x04000C8E RID: 3214
		private global::DevAge.Drawing.AnchorArea mAnchorArea;
	}
}
