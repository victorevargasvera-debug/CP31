using System;
using System.ComponentModel;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002FD RID: 765
	[global::System.Serializable]
	internal class Image : global::DevAge.Drawing.VisualElements.VisualElementBase, global::DevAge.Drawing.VisualElements.IImage, global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x0600248A RID: 9354 RVA: 0x0007F640 File Offset: 0x0007D840
		public Image()
		{
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x0007F650 File Offset: 0x0007D850
		public Image(global::System.Drawing.Image value)
		{
			this.Value = value;
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x0007F668 File Offset: 0x0007D868
		public Image(global::DevAge.Drawing.VisualElements.Image other) : base(other)
		{
			if (other.Value != null)
			{
				this.Value = (global::System.Drawing.Image)other.Value.Clone();
			}
			else
			{
				this.Value = null;
			}
			this.Enabled = other.Enabled;
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x0007F6C0 File Offset: 0x0007D8C0
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x0007F6C8 File Offset: 0x0007D8C8
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Drawing.Image Value
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

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x0007F6D4 File Offset: 0x0007D8D4
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x0007F6DC File Offset: 0x0007D8DC
		public bool Enabled
		{
			get
			{
				return this.mEnabled;
			}
			set
			{
				this.mEnabled = value;
			}
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x0007F6E8 File Offset: 0x0007D8E8
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (this.Value != null)
			{
				if (this.Enabled)
				{
					graphics.Graphics.DrawImage(this.Value, area);
					return;
				}
				using (global::System.Drawing.Image image = global::DevAge.Drawing.Utilities.CreateDisabledImage(this.Value, global::System.Drawing.Color.White))
				{
					graphics.Graphics.DrawImage(image, area);
				}
			}
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x0007F760 File Offset: 0x0007D960
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			if (this.Value != null)
			{
				return this.Value.Size;
			}
			return global::System.Drawing.SizeF.Empty;
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x0007F784 File Offset: 0x0007D984
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.Image(this);
		}

		// Token: 0x04000CD9 RID: 3289
		private global::System.Drawing.Image mValue;

		// Token: 0x04000CDA RID: 3290
		private bool mEnabled = true;
	}
}
