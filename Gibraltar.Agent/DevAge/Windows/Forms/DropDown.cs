using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x0200032D RID: 813
	internal partial class DropDown : Form
	{
		// Token: 0x06002653 RID: 9811 RVA: 0x00084BB8 File Offset: 0x00082DB8
		public DropDown()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00084BDC File Offset: 0x00082DDC
		public DropDown(Control innerControl, Control parentControl, Form owner) : this()
		{
			base.Owner = owner;
			this.m_InnerControl = innerControl;
			this.m_ParentControl = parentControl;
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x00084D40 File Offset: 0x00082F40
		// (set) Token: 0x06002658 RID: 9816 RVA: 0x00084D48 File Offset: 0x00082F48
		public Control ParentControl
		{
			get
			{
				return this.m_ParentControl;
			}
			set
			{
				this.m_ParentControl = value;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x00084D54 File Offset: 0x00082F54
		// (set) Token: 0x0600265A RID: 9818 RVA: 0x00084D5C File Offset: 0x00082F5C
		public Control InnerControl
		{
			get
			{
				return this.m_InnerControl;
			}
			set
			{
				this.m_InnerControl = value;
			}
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00084D68 File Offset: 0x00082F68
		private void DropDown_Layout(object sender, LayoutEventArgs e)
		{
			base.SuspendLayout();
			this.CalcLocation();
			base.ResumeLayout(false);
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00084D80 File Offset: 0x00082F80
		private void CalcLocation()
		{
			if (this.m_InnerControl != null && this.m_ParentControl != null)
			{
				base.Size = this.m_InnerControl.Size;
			}
			Rectangle rectangle = this.m_ParentControl.RectangleToScreen(this.m_ParentControl.ClientRectangle);
			Screen screen = Screen.FromPoint(new Point(rectangle.X, rectangle.Bottom));
			int x = screen.Bounds.X;
			int num = screen.Bounds.X + screen.Bounds.Width;
			int num2 = screen.Bounds.Y + screen.Bounds.Height;
			int width = base.Width;
			int height = base.Height;
			if (rectangle.X + width <= num)
			{
				if (rectangle.X < x)
				{
					this.StartLocation.X = x;
				}
				else
				{
					this.StartLocation.X = rectangle.X;
				}
			}
			else if (Screen.FromPoint(new Point(rectangle.X + rectangle.Width, 0)) == screen)
			{
				this.StartLocation.X = rectangle.Right - width;
			}
			else
			{
				this.StartLocation.X = num - width;
			}
			if (rectangle.Bottom + height <= num2)
			{
				this.StartLocation.Y = rectangle.Bottom;
			}
			else
			{
				this.StartLocation.Y = rectangle.Y - height;
			}
			base.Location = this.StartLocation;
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x00084F24 File Offset: 0x00083124
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if ((this.m_Flags & DropDownFlags.CloseOnEscape) == DropDownFlags.CloseOnEscape && keyData == Keys.Escape)
			{
				base.DialogResult = DialogResult.Cancel;
				this.CloseDropDown();
			}
			if ((this.m_Flags & DropDownFlags.CloseOnEnter) == DropDownFlags.CloseOnEnter && keyData == Keys.Return)
			{
				base.DialogResult = DialogResult.OK;
				this.CloseDropDown();
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x00084F84 File Offset: 0x00083184
		// (set) Token: 0x0600265F RID: 9823 RVA: 0x00084F8C File Offset: 0x0008318C
		public DropDownFlags DropDownFlags
		{
			get
			{
				return this.m_Flags;
			}
			set
			{
				this.m_Flags = value;
			}
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x00084F98 File Offset: 0x00083198
		private void DropDown_Deactivate(object sender, EventArgs e)
		{
			this.CloseDropDown();
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x00084FA0 File Offset: 0x000831A0
		public void ShowDropDown()
		{
			if (this.m_bShowed)
			{
				return;
			}
			this.m_bShowed = true;
			if (this.InnerControl == null)
			{
				throw new ApplicationException("InnerControl is null");
			}
			if (this.ParentControl == null)
			{
				throw new ApplicationException("ParentControl is null");
			}
			if (base.Owner == null)
			{
				throw new ApplicationException("Owner is null");
			}
			this.OnDropDownOpen(EventArgs.Empty);
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x00085014 File Offset: 0x00083214
		public void CloseDropDown()
		{
			if (!this.m_bShowed)
			{
				return;
			}
			this.OnDropDownClosed(EventArgs.Empty);
			this.m_bShowed = false;
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x00085034 File Offset: 0x00083234
		protected virtual void OnDropDownOpen(EventArgs e)
		{
			if (this.DropDownOpen != null)
			{
				this.DropDownOpen(this, e);
			}
			this.panelContainer.Controls.Add(this.m_InnerControl);
			try
			{
				this.CalcLocation();
				base.Show();
				while (this.m_bShowed)
				{
					Application.DoEvents();
					Thread.Sleep(1);
				}
			}
			finally
			{
				this.panelContainer.Controls.Remove(this.m_InnerControl);
			}
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x000850C0 File Offset: 0x000832C0
		protected virtual void OnDropDownClosed(EventArgs e)
		{
			base.Owner.Activate();
			base.Hide();
			if (this.DropDownClosed != null)
			{
				this.DropDownClosed(this, e);
			}
		}

		// Token: 0x140000A2 RID: 162
		// (add) Token: 0x06002665 RID: 9829 RVA: 0x000850EC File Offset: 0x000832EC
		// (remove) Token: 0x06002666 RID: 9830 RVA: 0x00085108 File Offset: 0x00083308
		public event EventHandler DropDownOpen;

		// Token: 0x140000A3 RID: 163
		// (add) Token: 0x06002667 RID: 9831 RVA: 0x00085124 File Offset: 0x00083324
		// (remove) Token: 0x06002668 RID: 9832 RVA: 0x00085140 File Offset: 0x00083340
		public event EventHandler DropDownClosed;

		// Token: 0x04000D81 RID: 3457
		private Point StartLocation = new Point(0, 0);

		// Token: 0x04000D84 RID: 3460
		private Control m_ParentControl;

		// Token: 0x04000D85 RID: 3461
		private Control m_InnerControl;

		// Token: 0x04000D86 RID: 3462
		private DropDownFlags m_Flags = DropDownFlags.CloseOnEscape | DropDownFlags.CloseOnEnter;

		// Token: 0x04000D87 RID: 3463
		private bool m_bShowed;
	}
}
