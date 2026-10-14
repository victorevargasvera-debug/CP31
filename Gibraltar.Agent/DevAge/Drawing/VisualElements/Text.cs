using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002D8 RID: 728
	[global::System.Serializable]
	internal class Text : global::DevAge.Drawing.VisualElements.VisualElementBase, global::DevAge.Drawing.VisualElements.IText, global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x06002362 RID: 9058 RVA: 0x0007C0B4 File Offset: 0x0007A2B4
		public Text()
		{
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x0007C0DC File Offset: 0x0007A2DC
		public Text(string value)
		{
			this.Value = value;
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x0007C108 File Offset: 0x0007A308
		public Text(global::DevAge.Drawing.VisualElements.Text other) : base(other)
		{
			this.Value = other.Value;
			this.Font = other.Font;
			this.ForeColor = other.ForeColor;
			this.Enabled = other.Enabled;
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x0007C170 File Offset: 0x0007A370
		// (set) Token: 0x06002366 RID: 9062 RVA: 0x0007C178 File Offset: 0x0007A378
		public virtual global::System.Drawing.Font Font
		{
			get
			{
				return this.mFont;
			}
			set
			{
				this.mFont = value;
			}
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x0007C184 File Offset: 0x0007A384
		private bool ShouldSerializeFont()
		{
			return this.Font.ToString() != global::System.Windows.Forms.Control.DefaultFont.ToString();
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x0007C1A0 File Offset: 0x0007A3A0
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x0007C1A8 File Offset: 0x0007A3A8
		public virtual global::System.Drawing.Color ForeColor
		{
			get
			{
				return this.mForeColor;
			}
			set
			{
				this.mForeColor = value;
			}
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x0007C1B4 File Offset: 0x0007A3B4
		private bool ShouldSerializeForeColor()
		{
			return this.ForeColor != global::System.Windows.Forms.Control.DefaultForeColor;
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x0007C1C8 File Offset: 0x0007A3C8
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x0007C1D0 File Offset: 0x0007A3D0
		[global::System.ComponentModel.DefaultValue(null)]
		public virtual string Value
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

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x0007C1DC File Offset: 0x0007A3DC
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x0007C1E4 File Offset: 0x0007A3E4
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

		// Token: 0x0600236F RID: 9071 RVA: 0x0007C1F0 File Offset: 0x0007A3F0
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			if (maxSize != global::System.Drawing.SizeF.Empty)
			{
				return measure.Graphics.MeasureString(this.Value, this.Font, maxSize);
			}
			return measure.Graphics.MeasureString(this.Value, this.Font);
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x0007C244 File Offset: 0x0007A444
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			global::System.Drawing.SolidBrush brush;
			if (this.Enabled)
			{
				brush = graphics.BrushsCache.GetBrush(this.ForeColor);
			}
			else
			{
				brush = graphics.BrushsCache.GetBrush(global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.GrayText));
			}
			graphics.Graphics.DrawString(this.Value, this.Font, brush, area);
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x0007C2A4 File Offset: 0x0007A4A4
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.Text(this);
		}

		// Token: 0x04000C99 RID: 3225
		private global::System.Drawing.Font mFont = global::System.Windows.Forms.Control.DefaultFont;

		// Token: 0x04000C9A RID: 3226
		private global::System.Drawing.Color mForeColor = global::System.Windows.Forms.Control.DefaultForeColor;

		// Token: 0x04000C9B RID: 3227
		private string mValue;

		// Token: 0x04000C9C RID: 3228
		private bool mEnabled = true;
	}
}
