using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x02000323 RID: 803
	internal class SubButtonItem
	{
		// Token: 0x060025EE RID: 9710 RVA: 0x00083CCC File Offset: 0x00081ECC
		public SubButtonItem() : this("NewItem")
		{
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00083CDC File Offset: 0x00081EDC
		public SubButtonItem(string p_Text) : this(p_Text, null)
		{
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00083CE8 File Offset: 0x00081EE8
		public SubButtonItem(string p_Text, global::System.EventHandler p_Event) : this(p_Text, p_Event, null)
		{
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x00083CF4 File Offset: 0x00081EF4
		public SubButtonItem(string p_Text, global::System.EventHandler p_Event, global::System.Drawing.Image p_Image)
		{
			if (p_Image == null)
			{
				this.m_MenuItem = new global::System.Windows.Forms.MenuItem();
			}
			else
			{
				this.m_MenuItem = new global::System.Windows.Forms.MenuItem();
			}
			this.DefConstructor(p_Text, p_Event);
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x00083D28 File Offset: 0x00081F28
		public SubButtonItem(string p_Text, global::System.EventHandler p_Event, global::System.Windows.Forms.ImageList p_ImageList, int p_ImageIndex)
		{
			if (p_ImageList == null)
			{
				this.m_MenuItem = new global::System.Windows.Forms.MenuItem();
			}
			else
			{
				this.m_MenuItem = new global::System.Windows.Forms.MenuItem();
			}
			this.DefConstructor(p_Text, p_Event);
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x00083D5C File Offset: 0x00081F5C
		private void DefConstructor(string p_Text, global::System.EventHandler p_Event)
		{
			this.m_MenuItem.Click += this.Menu_Click;
			this.Text = p_Text;
			if (p_Event != null)
			{
				this.Click += p_Event;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x00083D8C File Offset: 0x00081F8C
		// (set) Token: 0x060025F5 RID: 9717 RVA: 0x00083D94 File Offset: 0x00081F94
		public object Tag
		{
			get
			{
				return this.m_Tag;
			}
			set
			{
				this.m_Tag = value;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x00083DA0 File Offset: 0x00081FA0
		// (set) Token: 0x060025F7 RID: 9719 RVA: 0x00083DB0 File Offset: 0x00081FB0
		public string Text
		{
			get
			{
				return this.m_MenuItem.Text;
			}
			set
			{
				this.m_MenuItem.Text = value;
			}
		}

		// Token: 0x140000A0 RID: 160
		// (add) Token: 0x060025F8 RID: 9720 RVA: 0x00083DC0 File Offset: 0x00081FC0
		// (remove) Token: 0x060025F9 RID: 9721 RVA: 0x00083DDC File Offset: 0x00081FDC
		private event global::System.EventHandler m_Click;

		// Token: 0x060025FA RID: 9722 RVA: 0x00083DF8 File Offset: 0x00081FF8
		public void InvokeItemClick(global::System.EventArgs e)
		{
			if (this.m_Click != null)
			{
				this.m_Click(this, e);
			}
		}

		// Token: 0x140000A1 RID: 161
		// (add) Token: 0x060025FB RID: 9723 RVA: 0x00083E14 File Offset: 0x00082014
		// (remove) Token: 0x060025FC RID: 9724 RVA: 0x00083E30 File Offset: 0x00082030
		public event global::System.EventHandler Click
		{
			add
			{
				this.m_Click = (global::System.EventHandler)global::System.Delegate.Combine(this.m_Click, value);
			}
			remove
			{
				this.m_Click = (global::System.EventHandler)global::System.Delegate.Remove(this.m_Click, value);
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x00083E4C File Offset: 0x0008204C
		// (set) Token: 0x060025FE RID: 9726 RVA: 0x00083E54 File Offset: 0x00082054
		public global::DevAge.Windows.Forms.ButtonMultiSelection Owner
		{
			get
			{
				return this.m_ParentButton;
			}
			set
			{
				this.m_ParentButton = value;
			}
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x00083E60 File Offset: 0x00082060
		private void Menu_Click(object sender, global::System.EventArgs e)
		{
			if (this.m_ParentButton != null)
			{
				this.m_ParentButton.InvokeSubItemClick(new global::DevAge.Windows.Forms.SubButtonItemEventArgs(this));
			}
		}

		// Token: 0x04000D68 RID: 3432
		internal global::System.Windows.Forms.MenuItem m_MenuItem;

		// Token: 0x04000D69 RID: 3433
		private object m_Tag;

		// Token: 0x04000D6B RID: 3435
		private global::DevAge.Windows.Forms.ButtonMultiSelection m_ParentButton;
	}
}
