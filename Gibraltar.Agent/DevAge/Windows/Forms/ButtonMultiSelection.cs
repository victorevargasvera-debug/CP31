using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x0200031F RID: 799
	[global::System.ComponentModel.DefaultEvent("Click")]
	internal class ButtonMultiSelection : global::System.Windows.Forms.UserControl, global::System.Windows.Forms.IButtonControl
	{
		// Token: 0x060025C6 RID: 9670 RVA: 0x0008379C File Offset: 0x0008199C
		public ButtonMultiSelection()
		{
			this.InitializeComponent();
			base.SetStyle(global::System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
			base.BackColor = global::System.Drawing.Color.Transparent;
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x000837E8 File Offset: 0x000819E8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00083810 File Offset: 0x00081A10
		private void InitializeComponent()
		{
			new global::System.Resources.ResourceManager(typeof(global::DevAge.Windows.Forms.ButtonMultiSelection));
			this.btMain = new global::System.Windows.Forms.Button();
			this.btArrow = new global::DevAge.Windows.Forms.DropDownButton();
			base.SuspendLayout();
			this.btMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btMain.Location = new global::System.Drawing.Point(0, 0);
			this.btMain.Name = "btMain";
			this.btMain.Size = new global::System.Drawing.Size(61, 23);
			this.btMain.TabIndex = 0;
			this.btMain.Text = "button1";
			this.btMain.Click += this.btMain_Click;
			this.btArrow.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btArrow.Location = new global::System.Drawing.Point(61, 0);
			this.btArrow.Name = "btArrow";
			this.btArrow.Size = new global::System.Drawing.Size(14, 23);
			this.btArrow.TabIndex = 1;
			this.btArrow.Click += this.btArrow_Click;
			base.Controls.Add(this.btMain);
			base.Controls.Add(this.btArrow);
			base.Name = "ButtonMultiSelection";
			base.Size = new global::System.Drawing.Size(75, 23);
			base.ResumeLayout(false);
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x060025C9 RID: 9673 RVA: 0x0008396C File Offset: 0x00081B6C
		// (set) Token: 0x060025CA RID: 9674 RVA: 0x0008397C File Offset: 0x00081B7C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
		[global::System.ComponentModel.Browsable(true)]
		public override string Text
		{
			get
			{
				return this.btMain.Text;
			}
			set
			{
				this.btMain.Text = value;
				base.Text = value;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x060025CB RID: 9675 RVA: 0x00083994 File Offset: 0x00081B94
		// (set) Token: 0x060025CC RID: 9676 RVA: 0x0008399C File Offset: 0x00081B9C
		[global::System.ComponentModel.Browsable(false)]
		public new global::System.Drawing.Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x060025CD RID: 9677 RVA: 0x000839A8 File Offset: 0x00081BA8
		// (set) Token: 0x060025CE RID: 9678 RVA: 0x000839B0 File Offset: 0x00081BB0
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
		public override global::System.Drawing.Color ForeColor
		{
			get
			{
				return base.ForeColor;
			}
			set
			{
				this.btMain.ForeColor = value;
				this.btArrow.ForeColor = value;
				base.ForeColor = value;
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060025CF RID: 9679 RVA: 0x000839D4 File Offset: 0x00081BD4
		// (set) Token: 0x060025D0 RID: 9680 RVA: 0x000839DC File Offset: 0x00081BDC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
		[global::System.ComponentModel.Browsable(true)]
		public override global::System.Drawing.Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				this.btMain.Font = value;
				this.btArrow.Font = value;
				base.Font = value;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060025D1 RID: 9681 RVA: 0x00083A00 File Offset: 0x00081C00
		// (set) Token: 0x060025D2 RID: 9682 RVA: 0x00083A10 File Offset: 0x00081C10
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
		public virtual global::System.Drawing.ContentAlignment TextAlign
		{
			get
			{
				return this.btMain.TextAlign;
			}
			set
			{
				this.btMain.TextAlign = value;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x00083A20 File Offset: 0x00081C20
		// (set) Token: 0x060025D4 RID: 9684 RVA: 0x00083A30 File Offset: 0x00081C30
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
		[global::System.ComponentModel.Browsable(true)]
		public virtual global::System.Drawing.Image Image
		{
			get
			{
				return this.btMain.Image;
			}
			set
			{
				this.btMain.Image = value;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x060025D5 RID: 9685 RVA: 0x00083A40 File Offset: 0x00081C40
		// (set) Token: 0x060025D6 RID: 9686 RVA: 0x00083A50 File Offset: 0x00081C50
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
		[global::System.ComponentModel.Browsable(true)]
		public virtual global::System.Drawing.ContentAlignment ImageAlign
		{
			get
			{
				return this.btMain.ImageAlign;
			}
			set
			{
				this.btMain.ImageAlign = value;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x00083A60 File Offset: 0x00081C60
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x00083A70 File Offset: 0x00081C70
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
		public virtual global::System.Windows.Forms.DialogResult DialogResult
		{
			get
			{
				return this.btMain.DialogResult;
			}
			set
			{
				this.btMain.DialogResult = value;
			}
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00083A80 File Offset: 0x00081C80
		public void PerformClick()
		{
			this.btMain.PerformClick();
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00083A90 File Offset: 0x00081C90
		public void NotifyDefault(bool value)
		{
			this.btMain.NotifyDefault(value);
		}

		// Token: 0x1400009E RID: 158
		// (add) Token: 0x060025DB RID: 9691 RVA: 0x00083AA0 File Offset: 0x00081CA0
		// (remove) Token: 0x060025DC RID: 9692 RVA: 0x00083ABC File Offset: 0x00081CBC
		private event global::DevAge.Windows.Forms.SubButtonItemEventHandler m_Click;

		// Token: 0x1400009F RID: 159
		// (add) Token: 0x060025DD RID: 9693 RVA: 0x00083AD8 File Offset: 0x00081CD8
		// (remove) Token: 0x060025DE RID: 9694 RVA: 0x00083AF4 File Offset: 0x00081CF4
		public new event global::DevAge.Windows.Forms.SubButtonItemEventHandler Click
		{
			add
			{
				this.m_Click = (global::DevAge.Windows.Forms.SubButtonItemEventHandler)global::System.Delegate.Combine(this.m_Click, value);
			}
			remove
			{
				this.m_Click = (global::DevAge.Windows.Forms.SubButtonItemEventHandler)global::System.Delegate.Remove(this.m_Click, value);
			}
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00083B10 File Offset: 0x00081D10
		protected virtual void OnClick(global::DevAge.Windows.Forms.SubButtonItemEventArgs e)
		{
			if (e.ButtonItem != null)
			{
				e.ButtonItem.InvokeItemClick(global::System.EventArgs.Empty);
			}
			if (this.m_Click != null)
			{
				this.m_Click(this, e);
			}
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00083B48 File Offset: 0x00081D48
		internal void InvokeSubItemClick(global::DevAge.Windows.Forms.SubButtonItemEventArgs e)
		{
			this.OnClick(e);
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x00083B54 File Offset: 0x00081D54
		private void btMain_Click(object sender, global::System.EventArgs e)
		{
			if (this.m_Mode != global::DevAge.Windows.Forms.ButtonMultiSelectionMode.InvokeFirstAction)
			{
				this.btArrow_Click(sender, e);
				return;
			}
			if (this.m_ButtonsItems != null && this.m_ButtonsItems.Count > 0)
			{
				this.OnClick(new global::DevAge.Windows.Forms.SubButtonItemEventArgs(this.m_ButtonsItems[0]));
				return;
			}
			this.OnClick(new global::DevAge.Windows.Forms.SubButtonItemEventArgs(null));
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x00083BBC File Offset: 0x00081DBC
		private void btArrow_Click(object sender, global::System.EventArgs e)
		{
			if (this.m_ButtonsItems != null && this.m_ButtonsItems.Count > 0)
			{
				this.l_ContextMenu.MenuItems.Clear();
				foreach (global::DevAge.Windows.Forms.SubButtonItem subButtonItem in this.m_ButtonsItems)
				{
					subButtonItem.Owner = this;
					this.l_ContextMenu.MenuItems.Add(subButtonItem.m_MenuItem);
				}
				this.l_ContextMenu.Show(this.btMain, new global::System.Drawing.Point(0, this.btMain.Height));
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x00083C80 File Offset: 0x00081E80
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x00083C88 File Offset: 0x00081E88
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::DevAge.Windows.Forms.SubButtonItemCollection ButtonsItems
		{
			get
			{
				return this.m_ButtonsItems;
			}
			set
			{
				this.m_ButtonsItems = value;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x00083C94 File Offset: 0x00081E94
		// (set) Token: 0x060025E6 RID: 9702 RVA: 0x00083C9C File Offset: 0x00081E9C
		[global::System.ComponentModel.DefaultValue(global::DevAge.Windows.Forms.ButtonMultiSelectionMode.InvokeFirstAction)]
		public global::DevAge.Windows.Forms.ButtonMultiSelectionMode Mode
		{
			get
			{
				return this.m_Mode;
			}
			set
			{
				this.m_Mode = value;
			}
		}

		// Token: 0x04000D5D RID: 3421
		private global::System.Windows.Forms.Button btMain;

		// Token: 0x04000D5E RID: 3422
		private global::DevAge.Windows.Forms.DropDownButton btArrow;

		// Token: 0x04000D5F RID: 3423
		private global::System.ComponentModel.Container components;

		// Token: 0x04000D61 RID: 3425
		private global::System.Windows.Forms.ContextMenu l_ContextMenu = new global::System.Windows.Forms.ContextMenu();

		// Token: 0x04000D62 RID: 3426
		private global::DevAge.Windows.Forms.SubButtonItemCollection m_ButtonsItems = new global::DevAge.Windows.Forms.SubButtonItemCollection();

		// Token: 0x04000D63 RID: 3427
		private global::DevAge.Windows.Forms.ButtonMultiSelectionMode m_Mode;
	}
}
