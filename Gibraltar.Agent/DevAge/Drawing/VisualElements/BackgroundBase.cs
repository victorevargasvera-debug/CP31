using System;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002D1 RID: 721
	[global::System.Serializable]
	internal abstract class BackgroundBase : global::DevAge.Drawing.VisualElements.VisualElementBase, global::DevAge.Drawing.VisualElements.IBackground, global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x06002336 RID: 9014 RVA: 0x0007B718 File Offset: 0x00079918
		public BackgroundBase()
		{
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0007B720 File Offset: 0x00079920
		public BackgroundBase(global::DevAge.Drawing.VisualElements.BackgroundBase other) : base(other)
		{
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x0007B72C File Offset: 0x0007992C
		public virtual global::System.Drawing.RectangleF GetBackgroundContentRectangle(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF backGroundArea)
		{
			return backGroundArea;
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x0007B730 File Offset: 0x00079930
		public virtual global::System.Drawing.SizeF GetBackgroundExtent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF contentSize)
		{
			return contentSize;
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x0007B734 File Offset: 0x00079934
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x0007B738 File Offset: 0x00079938
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			global::System.Drawing.SizeF empty = global::System.Drawing.SizeF.Empty;
			return this.GetBackgroundExtent(measure, empty);
		}
	}
}
