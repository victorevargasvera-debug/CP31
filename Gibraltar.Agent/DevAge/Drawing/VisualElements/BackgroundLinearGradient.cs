using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x02000328 RID: 808
	[global::System.Serializable]
	internal class BackgroundLinearGradient : global::DevAge.Drawing.VisualElements.VisualElementBase
	{
		// Token: 0x06002622 RID: 9762 RVA: 0x00084338 File Offset: 0x00082538
		public BackgroundLinearGradient()
		{
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x00084358 File Offset: 0x00082558
		public BackgroundLinearGradient(global::System.Drawing.Color firstColor, global::System.Drawing.Color secondColor, float angle)
		{
			this.FirstColor = firstColor;
			this.SecondColor = secondColor;
			this.Angle = angle;
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x0008439C File Offset: 0x0008259C
		public BackgroundLinearGradient(global::DevAge.Drawing.VisualElements.BackgroundLinearGradient other) : base(other)
		{
			this.FirstColor = other.FirstColor;
			this.SecondColor = other.SecondColor;
			this.Angle = other.Angle;
			this.BlendFactors = other.BlendFactors;
			this.BlendPositions = other.BlendPositions;
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002625 RID: 9765 RVA: 0x00084408 File Offset: 0x00082608
		// (set) Token: 0x06002626 RID: 9766 RVA: 0x00084410 File Offset: 0x00082610
		public virtual global::System.Drawing.Color FirstColor
		{
			get
			{
				return this.mFirstColor;
			}
			set
			{
				this.mFirstColor = value;
			}
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x0008441C File Offset: 0x0008261C
		protected virtual bool ShouldSerializeFirstColor()
		{
			return this.FirstColor != global::System.Drawing.Color.Empty;
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x00084430 File Offset: 0x00082630
		// (set) Token: 0x06002629 RID: 9769 RVA: 0x00084438 File Offset: 0x00082638
		public virtual global::System.Drawing.Color SecondColor
		{
			get
			{
				return this.mSecondColor;
			}
			set
			{
				this.mSecondColor = value;
			}
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00084444 File Offset: 0x00082644
		protected virtual bool ShouldSerializeSecondColor()
		{
			return this.SecondColor != global::System.Drawing.Color.Empty;
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x00084458 File Offset: 0x00082658
		// (set) Token: 0x0600262C RID: 9772 RVA: 0x00084460 File Offset: 0x00082660
		public virtual float Angle
		{
			get
			{
				return this.mAngle;
			}
			set
			{
				this.mAngle = value;
			}
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x0008446C File Offset: 0x0008266C
		protected virtual bool ShouldSerializeAngle()
		{
			return this.Angle != 0f;
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x00084480 File Offset: 0x00082680
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x00084488 File Offset: 0x00082688
		public virtual float[] BlendFactors
		{
			get
			{
				return this.mBlendFactors;
			}
			set
			{
				this.mBlendFactors = value;
			}
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00084494 File Offset: 0x00082694
		protected virtual bool ShouldSerializeBlendFactors()
		{
			return this.BlendFactors != null;
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x000844A4 File Offset: 0x000826A4
		// (set) Token: 0x06002632 RID: 9778 RVA: 0x000844AC File Offset: 0x000826AC
		public virtual float[] BlendPositions
		{
			get
			{
				return this.mBlendPositions;
			}
			set
			{
				this.mBlendPositions = value;
			}
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x000844B8 File Offset: 0x000826B8
		protected virtual bool ShouldSerializeBlendPositions()
		{
			return this.BlendPositions != null;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x000844C8 File Offset: 0x000826C8
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (this.FirstColor != global::System.Drawing.Color.Empty || this.SecondColor != global::System.Drawing.Color.Empty)
			{
				if (this.FirstColor == this.SecondColor)
				{
					global::System.Drawing.SolidBrush brush = graphics.BrushsCache.GetBrush(this.FirstColor);
					graphics.Graphics.FillRectangle(brush, area);
					return;
				}
				using (global::System.Drawing.Drawing2D.LinearGradientBrush linearGradientBrush = new global::System.Drawing.Drawing2D.LinearGradientBrush(area, this.FirstColor, this.SecondColor, this.Angle))
				{
					if (this.BlendFactors != null && this.BlendPositions != null && this.BlendFactors.Length == this.BlendPositions.Length)
					{
						linearGradientBrush.Blend = new global::System.Drawing.Drawing2D.Blend
						{
							Factors = this.BlendFactors,
							Positions = this.BlendPositions
						};
					}
					graphics.Graphics.FillRectangle(linearGradientBrush, area);
				}
			}
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x000845D0 File Offset: 0x000827D0
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			return global::System.Drawing.SizeF.Empty;
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000845D8 File Offset: 0x000827D8
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.BackgroundLinearGradient(this);
		}

		// Token: 0x04000D6E RID: 3438
		private global::System.Drawing.Color mFirstColor = global::System.Drawing.Color.Empty;

		// Token: 0x04000D6F RID: 3439
		private global::System.Drawing.Color mSecondColor = global::System.Drawing.Color.Empty;

		// Token: 0x04000D70 RID: 3440
		private float mAngle;

		// Token: 0x04000D71 RID: 3441
		private float[] mBlendFactors;

		// Token: 0x04000D72 RID: 3442
		private float[] mBlendPositions;
	}
}
