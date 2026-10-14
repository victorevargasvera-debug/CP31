using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevAge.Drawing;
using DevAge.Drawing.VisualElements;

namespace DevAge.Windows.Forms
{
	// Token: 0x0200031E RID: 798
	[global::System.ComponentModel.DefaultEvent("Click")]
	internal class LinkLabel : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060025A2 RID: 9634 RVA: 0x00083230 File Offset: 0x00081430
		public LinkLabel()
		{
			this.InitializeComponent();
			base.SetStyle(global::System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.StandardClick, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.StandardDoubleClick, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.ResizeRedraw, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.UserPaint, true);
			base.BackColor = global::System.Drawing.Color.Transparent;
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x000832D0 File Offset: 0x000814D0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x000832F8 File Offset: 0x000814F8
		private void InitializeComponent()
		{
			this.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ForeColor = global::System.Drawing.Color.Blue;
			base.Name = "LinkLabel";
			base.Size = new global::System.Drawing.Size(148, 20);
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x00083354 File Offset: 0x00081554
		// (set) Token: 0x060025A6 RID: 9638 RVA: 0x0008335C File Offset: 0x0008155C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Drawing.Image Image
		{
			get
			{
				return this.mImage;
			}
			set
			{
				this.mImage = value;
				base.Invalidate(true);
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x0008336C File Offset: 0x0008156C
		// (set) Token: 0x060025A8 RID: 9640 RVA: 0x00083374 File Offset: 0x00081574
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Drawing.Image MouseOverImage
		{
			get
			{
				return this.mMouseOverImage;
			}
			set
			{
				this.mMouseOverImage = value;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x00083380 File Offset: 0x00081580
		// (set) Token: 0x060025AA RID: 9642 RVA: 0x00083388 File Offset: 0x00081588
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Drawing.Image DisabledImage
		{
			get
			{
				return this.mDisabledImage;
			}
			set
			{
				this.mDisabledImage = value;
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x00083394 File Offset: 0x00081594
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x0008339C File Offset: 0x0008159C
		[global::System.ComponentModel.DefaultValue(global::DevAge.Drawing.ContentAlignment.MiddleLeft)]
		public global::DevAge.Drawing.ContentAlignment ImageAlignment
		{
			get
			{
				return this.mImageAlignment;
			}
			set
			{
				this.mImageAlignment = value;
				base.Invalidate(true);
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x000833AC File Offset: 0x000815AC
		// (set) Token: 0x060025AE RID: 9646 RVA: 0x000833BC File Offset: 0x000815BC
		public global::DevAge.Drawing.ContentAlignment TextAlignment
		{
			get
			{
				return global::DevAge.Drawing.Utilities.StringFormatToContentAlignment(this.mStringFormat);
			}
			set
			{
				global::DevAge.Drawing.Utilities.ApplyContentAlignmentToStringFormat(value, this.mStringFormat);
				base.Invalidate(true);
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x000833D4 File Offset: 0x000815D4
		// (set) Token: 0x060025B0 RID: 9648 RVA: 0x000833DC File Offset: 0x000815DC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Drawing.StringFormat StringFormat
		{
			get
			{
				return this.mStringFormat;
			}
			set
			{
				this.mStringFormat = value;
				base.Invalidate(true);
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x000833EC File Offset: 0x000815EC
		// (set) Token: 0x060025B2 RID: 9650 RVA: 0x000833F4 File Offset: 0x000815F4
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AlignTextToImage
		{
			get
			{
				return this.mAlignTextToImage;
			}
			set
			{
				this.mAlignTextToImage = value;
				base.Invalidate(true);
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x00083404 File Offset: 0x00081604
		// (set) Token: 0x060025B4 RID: 9652 RVA: 0x0008340C File Offset: 0x0008160C
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ImageStretch
		{
			get
			{
				return this.mImageStretch;
			}
			set
			{
				this.mImageStretch = value;
				base.Invalidate(true);
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x0008341C File Offset: 0x0008161C
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x00083424 File Offset: 0x00081624
		[global::System.ComponentModel.DefaultValue(false)]
		public bool EnableMouseEffect
		{
			get
			{
				return this.mEnableMouseEffect;
			}
			set
			{
				this.mEnableMouseEffect = value;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x00083430 File Offset: 0x00081630
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x00083438 File Offset: 0x00081638
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x00083444 File Offset: 0x00081644
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x0008344C File Offset: 0x0008164C
		[global::System.ComponentModel.DefaultValue(0)]
		public int BorderWidth
		{
			get
			{
				return this.mBorderWidth;
			}
			set
			{
				this.mBorderWidth = value;
				base.Invalidate(true);
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x0008345C File Offset: 0x0008165C
		// (set) Token: 0x060025BC RID: 9660 RVA: 0x00083464 File Offset: 0x00081664
		[global::System.ComponentModel.DefaultValue(0)]
		public double BorderRound
		{
			get
			{
				return this.mBorderRound;
			}
			set
			{
				this.mBorderRound = value;
				base.Invalidate(true);
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x00083474 File Offset: 0x00081674
		// (set) Token: 0x060025BE RID: 9662 RVA: 0x0008347C File Offset: 0x0008167C
		public global::System.Drawing.Color BorderColor
		{
			get
			{
				return this.mBorderColor;
			}
			set
			{
				this.mBorderColor = value;
				base.Invalidate(true);
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x0008348C File Offset: 0x0008168C
		// (set) Token: 0x060025C0 RID: 9664 RVA: 0x00083494 File Offset: 0x00081694
		public new global::System.Drawing.Color BackColor
		{
			get
			{
				return this.mBackColor;
			}
			set
			{
				this.mBackColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x000834A4 File Offset: 0x000816A4
		protected override void OnMouseEnter(global::System.EventArgs e)
		{
			base.OnMouseEnter(e);
			this.mIsMouseOver = true;
			base.Invalidate();
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x000834BC File Offset: 0x000816BC
		protected override void OnMouseLeave(global::System.EventArgs e)
		{
			base.OnMouseLeave(e);
			this.mIsMouseOver = false;
			base.Invalidate();
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x000834D4 File Offset: 0x000816D4
		protected virtual void DrawBorderAndFill(global::System.Drawing.Graphics graphics)
		{
			int num = this.BorderWidth;
			double borderRound = this.BorderRound;
			global::System.Drawing.Color color = this.BorderColor;
			global::System.Drawing.Color color2 = this.BackColor;
			if (this.mEnableMouseEffect && this.mIsMouseOver && base.Enabled)
			{
				global::System.Drawing.Color color3 = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Highlight);
				color2 = global::System.Drawing.Color.FromArgb(75, color3);
				if (num == 0)
				{
					num = 1;
				}
				color = color3;
			}
			global::DevAge.Drawing.RoundedRectangle roundRect = new global::DevAge.Drawing.RoundedRectangle(base.ClientRectangle, borderRound);
			using (global::System.Drawing.SolidBrush solidBrush = new global::System.Drawing.SolidBrush(color2))
			{
				global::DevAge.Drawing.Utilities.FillRoundedRectangle(graphics, roundRect, solidBrush);
			}
			if (num > 0)
			{
				using (global::System.Drawing.Pen pen = new global::System.Drawing.Pen(color, (float)num))
				{
					global::DevAge.Drawing.Utilities.DrawRoundedRectangle(graphics, roundRect, pen);
				}
			}
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x000835BC File Offset: 0x000817BC
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaint(e);
			if (this.BorderRound > 0.0)
			{
				e.Graphics.SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			}
			this.DrawBorderAndFill(e.Graphics);
			bool flag = false;
			global::System.Drawing.Image value = this.mImage;
			if (!base.Enabled)
			{
				if (this.mDisabledImage != null)
				{
					value = this.mDisabledImage;
				}
				else
				{
					flag = true;
				}
			}
			else if (this.mIsMouseOver && this.mMouseOverImage != null)
			{
				value = this.mMouseOverImage;
			}
			global::System.Drawing.Rectangle clientRectangle = base.ClientRectangle;
			if (this.BorderWidth > 0)
			{
				clientRectangle = new global::System.Drawing.Rectangle(clientRectangle.X + this.BorderWidth, clientRectangle.Y + this.BorderWidth, clientRectangle.Width - this.BorderWidth * 2, clientRectangle.Height - this.BorderWidth * 2);
			}
			global::DevAge.Drawing.VisualElements.Container container = new global::DevAge.Drawing.VisualElements.Container();
			global::DevAge.Drawing.VisualElements.TextGDI textGDI = new global::DevAge.Drawing.VisualElements.TextGDI(this.Text);
			global::DevAge.Drawing.VisualElements.Image image = new global::DevAge.Drawing.VisualElements.Image(value);
			image.AnchorArea = new global::DevAge.Drawing.AnchorArea(this.mImageAlignment, this.mImageStretch);
			image.Enabled = !flag;
			textGDI.AnchorArea = new global::DevAge.Drawing.AnchorArea(global::DevAge.Drawing.Utilities.StringFormatToContentAlignment(this.mStringFormat), false);
			textGDI.StringFormat = this.mStringFormat;
			textGDI.Font = this.Font;
			textGDI.ForeColor = this.ForeColor;
			textGDI.Enabled = base.Enabled;
			container.Elements.Add(image);
			container.Elements.Add(textGDI);
			using (global::DevAge.Drawing.GraphicsCache graphicsCache = new global::DevAge.Drawing.GraphicsCache(e.Graphics, e.ClipRectangle))
			{
				container.Draw(graphicsCache, clientRectangle);
			}
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x0008378C File Offset: 0x0008198C
		protected override void OnTextChanged(global::System.EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate(true);
		}

		// Token: 0x04000D4F RID: 3407
		private global::System.ComponentModel.Container components;

		// Token: 0x04000D50 RID: 3408
		private global::System.Drawing.Image mImage;

		// Token: 0x04000D51 RID: 3409
		private global::System.Drawing.Image mMouseOverImage;

		// Token: 0x04000D52 RID: 3410
		private global::System.Drawing.Image mDisabledImage;

		// Token: 0x04000D53 RID: 3411
		private global::DevAge.Drawing.ContentAlignment mImageAlignment = global::DevAge.Drawing.ContentAlignment.MiddleLeft;

		// Token: 0x04000D54 RID: 3412
		private global::System.Drawing.StringFormat mStringFormat = new global::System.Drawing.StringFormat(global::System.Drawing.StringFormat.GenericDefault);

		// Token: 0x04000D55 RID: 3413
		private bool mAlignTextToImage = true;

		// Token: 0x04000D56 RID: 3414
		private bool mImageStretch;

		// Token: 0x04000D57 RID: 3415
		private bool mEnableMouseEffect;

		// Token: 0x04000D58 RID: 3416
		private int mBorderWidth;

		// Token: 0x04000D59 RID: 3417
		private double mBorderRound;

		// Token: 0x04000D5A RID: 3418
		private global::System.Drawing.Color mBorderColor = global::System.Drawing.Color.Black;

		// Token: 0x04000D5B RID: 3419
		private global::System.Drawing.Color mBackColor = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Control);

		// Token: 0x04000D5C RID: 3420
		private bool mIsMouseOver;
	}
}
