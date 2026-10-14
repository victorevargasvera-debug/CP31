using System;
using System.ComponentModel;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x02000303 RID: 771
	[global::System.Serializable]
	internal class Icon : global::DevAge.Drawing.VisualElements.VisualElementBase, global::DevAge.Drawing.VisualElements.IIcon, global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x060024C8 RID: 9416 RVA: 0x00080484 File Offset: 0x0007E684
		public Icon()
		{
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x0008048C File Offset: 0x0007E68C
		public Icon(global::System.Drawing.Icon value)
		{
			this.Value = value;
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x0008049C File Offset: 0x0007E69C
		public Icon(global::DevAge.Drawing.VisualElements.Icon other) : base(other)
		{
			if (other.Value != null)
			{
				this.Value = (global::System.Drawing.Icon)other.Value.Clone();
				return;
			}
			this.Value = null;
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060024CB RID: 9419 RVA: 0x000804E0 File Offset: 0x0007E6E0
		// (set) Token: 0x060024CC RID: 9420 RVA: 0x000804E8 File Offset: 0x0007E6E8
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Drawing.Icon Value
		{
			get
			{
				return this.mValue;
			}
			set
			{
				this.mValue = value;
			}
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x000804F4 File Offset: 0x0007E6F4
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (this.Value != null)
			{
				graphics.Graphics.DrawIcon(this.Value, global::System.Drawing.Rectangle.Round(area));
			}
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x00080528 File Offset: 0x0007E728
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			if (this.Value != null)
			{
				return this.Value.Size;
			}
			return global::System.Drawing.SizeF.Empty;
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x0008054C File Offset: 0x0007E74C
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.Icon(this);
		}

		// Token: 0x04000CDF RID: 3295
		private global::System.Drawing.Icon mValue;
	}
}
