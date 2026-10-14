using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SourceGrid
{
	// Token: 0x02000337 RID: 823
	[global::System.ComponentModel.ToolboxItem(false)]
	internal abstract class CustomScrollControl : global::System.Windows.Forms.Panel
	{
		// Token: 0x060026D3 RID: 9939 RVA: 0x00086848 File Offset: 0x00084A48
		public CustomScrollControl()
		{
			this.SuspendLayout();
			base.Name = "CustomScrollControl";
			base.AutoScroll = false;
			base.SetStyle(global::System.Windows.Forms.ControlStyles.UserPaint, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
			this.CreateDockControls();
			this.ResumeLayout(false);
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x000868C4 File Offset: 0x00084AC4
		protected virtual void CreateDockControls()
		{
			this.panelDockBottom.SuspendLayout();
			this.panelDockBottom.Controls.Add(this.mHScrollBar);
			this.panelDockBottom.Controls.Add(this.mBottomRightPanel);
			this.panelDockBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.mBottomRightPanel.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.mHScrollBar.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.mVScrollBar.Dock = global::System.Windows.Forms.DockStyle.Right;
			base.Controls.Add(this.mVScrollBar);
			base.Controls.Add(this.panelDockBottom);
			this.mHScrollBar.ValueChanged += this.HScroll_Change;
			this.mVScrollBar.ValueChanged += this.VScroll_Change;
			this.mHScrollBar.UserInteraction += this.ScrollBar_UserInteraction;
			this.mVScrollBar.UserInteraction += this.ScrollBar_UserInteraction;
			this.mVScrollBar.TabStop = false;
			this.mHScrollBar.TabStop = false;
			this.mBottomRightPanel.TabStop = false;
			this.panelDockBottom.TabStop = false;
			this.panelDockBottom.TabIndex = 1;
			this.mBottomRightPanel.TabIndex = 2;
			this.mVScrollBar.TabIndex = 3;
			this.mHScrollBar.TabIndex = 4;
			this.mBottomRightPanel.BackColor = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Control);
			this.PrepareScrollBars(false, false);
			this.panelDockBottom.ResumeLayout(false);
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x00086A40 File Offset: 0x00084C40
		protected virtual void OnUserInteraction()
		{
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00086A44 File Offset: 0x00084C44
		private void ScrollBar_UserInteraction(object sender, global::System.EventArgs e)
		{
			this.OnUserInteraction();
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x00086A4C File Offset: 0x00084C4C
		protected override void OnMouseDown(global::System.Windows.Forms.MouseEventArgs e)
		{
			this.OnUserInteraction();
			base.OnMouseDown(e);
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x00086A5C File Offset: 0x00084C5C
		// (set) Token: 0x060026D9 RID: 9945 RVA: 0x00086A60 File Offset: 0x00084C60
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue(false)]
		public override bool AutoScroll
		{
			get
			{
				return false;
			}
			set
			{
				if (value)
				{
					throw new global::SourceGrid.SourceGridException("Auto Scroll not supported in this control");
				}
				base.AutoScroll = false;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x00086A7C File Offset: 0x00084C7C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Forms.VScrollBar VScrollBar
		{
			get
			{
				return this.mVScrollBar;
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x00086A84 File Offset: 0x00084C84
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Forms.HScrollBar HScrollBar
		{
			get
			{
				return this.mHScrollBar;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x060026DC RID: 9948 RVA: 0x00086A8C File Offset: 0x00084C8C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Forms.Panel BottomRightPanel
		{
			get
			{
				return this.mBottomRightPanel;
			}
		}

		// Token: 0x060026DD RID: 9949
		protected abstract void InvalidateScrollableArea();

		// Token: 0x060026DE RID: 9950 RVA: 0x00086A94 File Offset: 0x00084C94
		protected virtual void PrepareScrollBars(bool showHScroll, bool showVScroll)
		{
			if (showHScroll != this.HScrollBarVisible)
			{
				if (showHScroll)
				{
					this.panelDockBottom.Height = global::System.Windows.Forms.SystemInformation.HorizontalScrollBarHeight;
					this.SetHScrollBarVisible(true);
				}
				else
				{
					this.panelDockBottom.Height = 0;
					this.SetHScrollBarVisible(false);
				}
			}
			if (showVScroll != this.VScrollBarVisible)
			{
				if (showVScroll)
				{
					this.SetVScrollBarVisible(true);
					this.mBottomRightPanel.Width = this.mVScrollBar.Width;
					return;
				}
				this.SetVScrollBarVisible(false);
				this.mBottomRightPanel.Width = 0;
			}
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x00086B2C File Offset: 0x00084D2C
		protected void SetHScrollBarVisible(bool value)
		{
			if (value)
			{
				this.mHScrollBar.Height = global::System.Windows.Forms.SystemInformation.HorizontalScrollBarHeight;
				return;
			}
			this.mHScrollBar.Height = 0;
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x00086B54 File Offset: 0x00084D54
		[global::System.ComponentModel.Browsable(false)]
		public bool HScrollBarVisible
		{
			get
			{
				return this.mHScrollBar.Height != 0;
			}
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00086B68 File Offset: 0x00084D68
		protected void SetVScrollBarVisible(bool value)
		{
			if (value)
			{
				this.mVScrollBar.Width = global::System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
				return;
			}
			this.mVScrollBar.Width = 0;
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x00086B90 File Offset: 0x00084D90
		[global::System.ComponentModel.Browsable(false)]
		public bool VScrollBarVisible
		{
			get
			{
				return this.mVScrollBar.Width != 0;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x00086BA4 File Offset: 0x00084DA4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		protected int HorizontalPage
		{
			get
			{
				return this.mHorizontalPage;
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x060026E4 RID: 9956 RVA: 0x00086BAC File Offset: 0x00084DAC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		protected int VerticalPage
		{
			get
			{
				return this.mVerticalPage;
			}
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x00086BB4 File Offset: 0x00084DB4
		protected void LoadScrollArea(int verticalPage, int horizontalPage)
		{
			this.mVerticalPage = verticalPage;
			this.mHorizontalPage = horizontalPage;
			this.RecalcCustomScrollBars();
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060026E6 RID: 9958 RVA: 0x00086BCC File Offset: 0x00084DCC
		// (set) Token: 0x060026E7 RID: 9959 RVA: 0x00086C18 File Offset: 0x00084E18
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual global::System.Drawing.Point CustomScrollPosition
		{
			get
			{
				int x = 0;
				if (this.HScrollBarVisible)
				{
					x = this.mHScrollBar.Value;
				}
				int y = 0;
				if (this.VScrollBarVisible)
				{
					y = this.mVScrollBar.Value;
				}
				return new global::System.Drawing.Point(x, y);
			}
			set
			{
				if (this.HScrollBarVisible)
				{
					if (value.X > this.mHScrollBar.Maximum)
					{
						this.mHScrollBar.Value = this.mHScrollBar.Maximum;
					}
					else if (value.X > 0)
					{
						this.mHScrollBar.Value = value.X;
					}
					else
					{
						this.mHScrollBar.Value = 0;
					}
				}
				if (this.VScrollBarVisible)
				{
					if (value.Y > this.mVScrollBar.Maximum)
					{
						this.mVScrollBar.Value = this.mVScrollBar.Maximum;
						return;
					}
					if (value.Y > 0)
					{
						this.mVScrollBar.Value = value.Y;
						return;
					}
					this.mVScrollBar.Value = 0;
				}
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x00086CFC File Offset: 0x00084EFC
		public new global::System.Drawing.Rectangle DisplayRectangle
		{
			get
			{
				int num = 0;
				if (this.HScrollBarVisible)
				{
					num = this.mHScrollBar.Height;
				}
				int num2 = 0;
				if (this.VScrollBarVisible)
				{
					num2 = this.mVScrollBar.Width;
				}
				global::System.Drawing.Rectangle displayRectangle = base.DisplayRectangle;
				return new global::System.Drawing.Rectangle(displayRectangle.X, displayRectangle.Y, displayRectangle.Width - num2, displayRectangle.Height - num);
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x00086D6C File Offset: 0x00084F6C
		private void RecalcHScrollBar(int cols)
		{
			if (this.HScrollBarVisible)
			{
				this.mHScrollBar.Minimum = 0;
				this.mHScrollBar.Maximum = cols + this.HorizontalPage - 1;
				this.mHScrollBar.LargeChange = this.HorizontalPage;
				this.mHScrollBar.SmallChange = 1;
				if (this.mHScrollBar.Value > this.MaximumHScroll)
				{
					this.mHScrollBar.Value = this.MaximumHScroll;
				}
			}
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00086DF0 File Offset: 0x00084FF0
		private void RecalcVScrollBar(int rows)
		{
			if (this.VScrollBarVisible)
			{
				this.mVScrollBar.Minimum = 0;
				this.mVScrollBar.Maximum = rows + this.VerticalPage - 1;
				this.mVScrollBar.LargeChange = this.VerticalPage;
				this.mVScrollBar.SmallChange = 1;
				if (this.mVScrollBar.Value > this.MaximumVScroll)
				{
					this.mVScrollBar.Value = this.MaximumVScroll;
				}
			}
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x00086E74 File Offset: 0x00085074
		protected void RecalcCustomScrollBars()
		{
			this.SuspendLayout();
			int scrollRows = this.GetScrollRows(base.DisplayRectangle.Height);
			int scrollColumns = this.GetScrollColumns(base.DisplayRectangle.Width);
			this.PrepareScrollBars(scrollColumns > 0, scrollRows > 0);
			scrollRows = this.GetScrollRows(this.DisplayRectangle.Height);
			scrollColumns = this.GetScrollColumns(this.DisplayRectangle.Width);
			this.PrepareScrollBars(scrollColumns > 0, scrollRows > 0);
			if (scrollRows > 0)
			{
				scrollRows = this.GetScrollRows(this.DisplayRectangle.Height);
			}
			if (scrollColumns > 0)
			{
				scrollColumns = this.GetScrollColumns(this.DisplayRectangle.Width);
			}
			this.RecalcVScrollBar(scrollRows);
			this.RecalcHScrollBar(scrollColumns);
			this.InvalidateScrollableArea();
			this.ResumeLayout(true);
		}

		// Token: 0x060026EC RID: 9964
		protected abstract int GetScrollRows(int displayHeight);

		// Token: 0x060026ED RID: 9965
		protected abstract int GetScrollColumns(int displayWidth);

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x060026EE RID: 9966 RVA: 0x00086F54 File Offset: 0x00085154
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		protected int MaximumVScroll
		{
			get
			{
				if (this.VScrollBarVisible)
				{
					return this.mVScrollBar.Maximum - (this.mVScrollBar.LargeChange - 1);
				}
				return 0;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x00086F7C File Offset: 0x0008517C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		protected int MinimumVScroll
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x00086F80 File Offset: 0x00085180
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		protected int MinimumHScroll
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x00086F84 File Offset: 0x00085184
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		protected int MaximumHScroll
		{
			get
			{
				if (this.HScrollBarVisible)
				{
					return this.mHScrollBar.Maximum - (this.mHScrollBar.LargeChange - 1);
				}
				return 0;
			}
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x00086FAC File Offset: 0x000851AC
		protected override void OnLayout(global::System.Windows.Forms.LayoutEventArgs levent)
		{
			if (levent.AffectedControl != this)
			{
				base.OnLayout(levent);
				return;
			}
			this.RecalcCustomScrollBars();
			base.OnLayout(levent);
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00086FD0 File Offset: 0x000851D0
		public new void SuspendLayout()
		{
			base.SuspendLayout();
			this.mSuspendedCount++;
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x00086FE8 File Offset: 0x000851E8
		public new void ResumeLayout()
		{
			base.ResumeLayout();
			if (this.mSuspendedCount > 0)
			{
				this.mSuspendedCount--;
			}
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x0008700C File Offset: 0x0008520C
		public new void ResumeLayout(bool performLayout)
		{
			base.ResumeLayout(performLayout);
			if (this.mSuspendedCount > 0)
			{
				this.mSuspendedCount--;
			}
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00087030 File Offset: 0x00085230
		public new void PerformLayout()
		{
			this.PerformLayout(this, null);
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x0008703C File Offset: 0x0008523C
		public new void PerformLayout(global::System.Windows.Forms.Control affectedControl, string affectedProperty)
		{
			base.PerformLayout(affectedControl, affectedProperty);
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x00087048 File Offset: 0x00085248
		public bool IsSuspended()
		{
			return this.mSuspendedCount > 0;
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x00087054 File Offset: 0x00085254
		private void VScroll_Change(object sender, global::System.EventArgs e)
		{
			this.OnVScrollPositionChanged(new global::SourceGrid.ScrollPositionChangedEventArgs(-this.mVScrollBar.Value, -this.m_OldVScrollValue));
			this.InvalidateScrollableArea();
			this.m_OldVScrollValue = this.mVScrollBar.Value;
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x0008709C File Offset: 0x0008529C
		private void HScroll_Change(object sender, global::System.EventArgs e)
		{
			this.OnHScrollPositionChanged(new global::SourceGrid.ScrollPositionChangedEventArgs(-this.mHScrollBar.Value, -this.m_OldHScrollValue));
			this.InvalidateScrollableArea();
			this.m_OldHScrollValue = this.mHScrollBar.Value;
		}

		// Token: 0x140000AB RID: 171
		// (add) Token: 0x060026FB RID: 9979 RVA: 0x000870E4 File Offset: 0x000852E4
		// (remove) Token: 0x060026FC RID: 9980 RVA: 0x00087100 File Offset: 0x00085300
		public event global::SourceGrid.ScrollPositionChangedEventHandler VScrollPositionChanged;

		// Token: 0x060026FD RID: 9981 RVA: 0x0008711C File Offset: 0x0008531C
		protected virtual void OnVScrollPositionChanged(global::SourceGrid.ScrollPositionChangedEventArgs e)
		{
			if (this.VScrollPositionChanged != null)
			{
				this.VScrollPositionChanged(this, e);
			}
		}

		// Token: 0x140000AC RID: 172
		// (add) Token: 0x060026FE RID: 9982 RVA: 0x00087138 File Offset: 0x00085338
		// (remove) Token: 0x060026FF RID: 9983 RVA: 0x00087154 File Offset: 0x00085354
		public event global::SourceGrid.ScrollPositionChangedEventHandler HScrollPositionChanged;

		// Token: 0x06002700 RID: 9984 RVA: 0x00087170 File Offset: 0x00085370
		protected virtual void OnHScrollPositionChanged(global::SourceGrid.ScrollPositionChangedEventArgs e)
		{
			if (this.HScrollPositionChanged != null)
			{
				this.HScrollPositionChanged(this, e);
			}
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x0008718C File Offset: 0x0008538C
		public virtual void CustomScrollPageDown()
		{
			if (this.VScrollBarVisible)
			{
				this.mVScrollBar.Value = global::System.Math.Min(this.mVScrollBar.Value + this.mVScrollBar.LargeChange, this.mVScrollBar.Maximum - this.mVScrollBar.LargeChange);
			}
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x000871E8 File Offset: 0x000853E8
		public virtual void CustomScrollPageUp()
		{
			if (this.VScrollBarVisible)
			{
				this.mVScrollBar.Value = global::System.Math.Max(this.mVScrollBar.Value - this.mVScrollBar.LargeChange, this.mVScrollBar.Minimum);
			}
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x00087238 File Offset: 0x00085438
		public virtual void CustomScrollPageRight()
		{
			if (this.HScrollBarVisible)
			{
				this.mHScrollBar.Value = global::System.Math.Min(this.mHScrollBar.Value + this.mHScrollBar.LargeChange, this.mHScrollBar.Maximum - this.mHScrollBar.LargeChange);
			}
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x00087294 File Offset: 0x00085494
		public virtual void CustomScrollPageLeft()
		{
			if (this.HScrollBarVisible)
			{
				this.mHScrollBar.Value = global::System.Math.Max(this.mHScrollBar.Value - this.mHScrollBar.LargeChange, this.mHScrollBar.Minimum);
			}
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x000872E4 File Offset: 0x000854E4
		public virtual void CustomScrollWheel(int rotationDelta)
		{
			if ((rotationDelta >= 120 || rotationDelta <= -120) && this.VScrollBarVisible)
			{
				global::System.Drawing.Point customScrollPosition = this.CustomScrollPosition;
				int num = customScrollPosition.Y + global::System.Windows.Forms.SystemInformation.MouseWheelScrollLines * this.VScrollBar.SmallChange * -global::System.Math.Sign(rotationDelta);
				if (num < 0)
				{
					num = 0;
				}
				if (num > this.MaximumVScroll)
				{
					num = this.MaximumVScroll;
				}
				else
				{
					this.OnUserInteraction();
				}
				this.CustomScrollPosition = new global::System.Drawing.Point(customScrollPosition.X, num);
			}
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x00087374 File Offset: 0x00085574
		public virtual void CustomScrollLineDown()
		{
			if (this.VScrollBarVisible)
			{
				this.mVScrollBar.Value = global::System.Math.Min(this.mVScrollBar.Value + this.mVScrollBar.SmallChange, this.mVScrollBar.Maximum);
			}
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000873C4 File Offset: 0x000855C4
		public virtual void CustomScrollLineUp()
		{
			if (this.VScrollBarVisible)
			{
				this.mVScrollBar.Value = global::System.Math.Max(this.mVScrollBar.Value - this.mVScrollBar.SmallChange, this.mVScrollBar.Minimum);
			}
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00087414 File Offset: 0x00085614
		public virtual void CustomScrollLineRight()
		{
			if (this.HScrollBarVisible)
			{
				this.mHScrollBar.Value = global::System.Math.Min(this.mHScrollBar.Value + this.mHScrollBar.SmallChange, this.mHScrollBar.Maximum);
			}
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x00087464 File Offset: 0x00085664
		public virtual void CustomScrollLineLeft()
		{
			if (this.HScrollBarVisible)
			{
				this.mHScrollBar.Value = global::System.Math.Max(this.mHScrollBar.Value - this.mHScrollBar.SmallChange, this.mHScrollBar.Minimum);
			}
		}

		// Token: 0x04000DAB RID: 3499
		private global::SourceGrid.CustomScrollControl.HScrollBarEx mHScrollBar = new global::SourceGrid.CustomScrollControl.HScrollBarEx();

		// Token: 0x04000DAC RID: 3500
		private global::SourceGrid.CustomScrollControl.VScrollBarEx mVScrollBar = new global::SourceGrid.CustomScrollControl.VScrollBarEx();

		// Token: 0x04000DAD RID: 3501
		private global::System.Windows.Forms.Panel mBottomRightPanel = new global::System.Windows.Forms.Panel();

		// Token: 0x04000DAE RID: 3502
		private global::System.Windows.Forms.Panel panelDockBottom = new global::System.Windows.Forms.Panel();

		// Token: 0x04000DAF RID: 3503
		private int mHorizontalPage;

		// Token: 0x04000DB0 RID: 3504
		private int mVerticalPage;

		// Token: 0x04000DB1 RID: 3505
		private int mSuspendedCount;

		// Token: 0x04000DB2 RID: 3506
		private int m_OldVScrollValue;

		// Token: 0x04000DB3 RID: 3507
		private int m_OldHScrollValue;

		// Token: 0x020004C6 RID: 1222
		private class VScrollBarEx : global::System.Windows.Forms.VScrollBar
		{
			// Token: 0x140000E5 RID: 229
			// (add) Token: 0x0600340F RID: 13327 RVA: 0x000BB8CC File Offset: 0x000B9ACC
			// (remove) Token: 0x06003410 RID: 13328 RVA: 0x000BB8E8 File Offset: 0x000B9AE8
			public event global::System.EventHandler UserInteraction;

			// Token: 0x06003411 RID: 13329 RVA: 0x000BB904 File Offset: 0x000B9B04
			protected override void WndProc(ref global::System.Windows.Forms.Message m)
			{
				if (m.Msg == 513 && this.UserInteraction != null)
				{
					this.UserInteraction(this, global::System.EventArgs.Empty);
				}
				base.WndProc(ref m);
			}
		}

		// Token: 0x020004C7 RID: 1223
		private class HScrollBarEx : global::System.Windows.Forms.HScrollBar
		{
			// Token: 0x140000E6 RID: 230
			// (add) Token: 0x06003413 RID: 13331 RVA: 0x000BB944 File Offset: 0x000B9B44
			// (remove) Token: 0x06003414 RID: 13332 RVA: 0x000BB960 File Offset: 0x000B9B60
			public event global::System.EventHandler UserInteraction;

			// Token: 0x06003415 RID: 13333 RVA: 0x000BB97C File Offset: 0x000B9B7C
			protected override void WndProc(ref global::System.Windows.Forms.Message m)
			{
				if (m.Msg == 513 && this.UserInteraction != null)
				{
					this.UserInteraction(this, global::System.EventArgs.Empty);
				}
				base.WndProc(ref m);
			}
		}
	}
}
