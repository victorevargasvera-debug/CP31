using System;
using System.ComponentModel;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002E6 RID: 742
	[global::System.Serializable]
	internal class TextGDI : global::DevAge.Drawing.VisualElements.Text
	{
		// Token: 0x060023B4 RID: 9140 RVA: 0x0007CADC File Offset: 0x0007ACDC
		public TextGDI()
		{
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x0007CAF4 File Offset: 0x0007ACF4
		public TextGDI(string value)
		{
			this.Value = value;
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x0007CB14 File Offset: 0x0007AD14
		public TextGDI(global::DevAge.Drawing.VisualElements.TextGDI other) : base(other)
		{
			if (other.StringFormat != null)
			{
				this.StringFormat = (global::System.Drawing.StringFormat)other.StringFormat.Clone();
				return;
			}
			this.StringFormat = null;
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060023B7 RID: 9143 RVA: 0x0007CB68 File Offset: 0x0007AD68
		// (set) Token: 0x060023B8 RID: 9144 RVA: 0x0007CB70 File Offset: 0x0007AD70
		[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
		public virtual global::System.Drawing.StringFormat StringFormat
		{
			get
			{
				return this.mStringFormat;
			}
			set
			{
				this.mStringFormat = value;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x0007CB7C File Offset: 0x0007AD7C
		// (set) Token: 0x060023BA RID: 9146 RVA: 0x0007CB8C File Offset: 0x0007AD8C
		public virtual global::DevAge.Drawing.ContentAlignment Alignment
		{
			get
			{
				return global::DevAge.Drawing.Utilities.StringFormatToContentAlignment(this.StringFormat);
			}
			set
			{
				global::DevAge.Drawing.Utilities.ApplyContentAlignmentToStringFormat(value, this.StringFormat);
			}
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x0007CB9C File Offset: 0x0007AD9C
		protected virtual bool ShouldSerializeAlignment()
		{
			return false;
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x0007CBA0 File Offset: 0x0007ADA0
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (this.Value == null || this.Value.Length == 0)
			{
				return;
			}
			global::System.Drawing.SolidBrush brush;
			if (base.Enabled)
			{
				brush = graphics.BrushsCache.GetBrush(this.ForeColor);
			}
			else
			{
				brush = graphics.BrushsCache.GetBrush(global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.GrayText));
			}
			graphics.Graphics.DrawString(this.Value, this.Font, brush, area, this.StringFormat);
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x0007CC24 File Offset: 0x0007AE24
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			if (maxSize != global::System.Drawing.SizeF.Empty)
			{
				return measure.Graphics.MeasureString(this.Value, this.Font, maxSize, this.StringFormat);
			}
			return measure.Graphics.MeasureString(this.Value, this.Font, new global::System.Drawing.SizeF(5000f, 5000f), this.StringFormat);
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x0007CC90 File Offset: 0x0007AE90
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.TextGDI(this);
		}

		// Token: 0x04000CAC RID: 3244
		private global::System.Drawing.StringFormat mStringFormat = new global::System.Drawing.StringFormat(global::System.Drawing.StringFormat.GenericDefault);
	}
}
