using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x02000309 RID: 777
	internal class ImageNavigator : global::System.Windows.Forms.UserControl
	{
		// Token: 0x0600250E RID: 9486 RVA: 0x000818F8 File Offset: 0x0007FAF8
		public ImageNavigator()
		{
			this.InitializeComponent();
			base.SetStyle(global::System.Windows.Forms.ControlStyles.Selectable, true);
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x00081924 File Offset: 0x0007FB24
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x0008194C File Offset: 0x0007FB4C
		private void InitializeComponent()
		{
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::DevAge.Windows.Forms.ImageNavigator));
			this.pictureBox = new global::System.Windows.Forms.PictureBox();
			this.btNext = new global::System.Windows.Forms.Button();
			this.btPrevious = new global::System.Windows.Forms.Button();
			this.lblStatus = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.pictureBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new global::System.Drawing.Size(344, 224);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.btNext.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btNext.DialogResult = global::System.Windows.Forms.DialogResult.None;
			this.btNext.Image = (global::System.Drawing.Image)resourceManager.GetObject("btNext.Image");
			this.btNext.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btNext.Location = new global::System.Drawing.Point(176, 228);
			this.btNext.Name = "btNext";
			this.btNext.Size = new global::System.Drawing.Size(24, 24);
			this.btNext.TabIndex = 1;
			this.btNext.TabStop = false;
			this.btNext.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btNext.Click += this.btNext_Click;
			this.btPrevious.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btPrevious.DialogResult = global::System.Windows.Forms.DialogResult.None;
			this.btPrevious.Image = (global::System.Drawing.Image)resourceManager.GetObject("btPrevious.Image");
			this.btPrevious.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btPrevious.Location = new global::System.Drawing.Point(144, 228);
			this.btPrevious.Name = "btPrevious";
			this.btPrevious.Size = new global::System.Drawing.Size(24, 24);
			this.btPrevious.TabIndex = 2;
			this.btPrevious.TabStop = false;
			this.btPrevious.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btPrevious.Click += this.btPrevious_Click;
			this.lblStatus.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.lblStatus.Location = new global::System.Drawing.Point(4, 228);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(132, 23);
			this.lblStatus.TabIndex = 3;
			this.lblStatus.Text = "status";
			this.lblStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			base.Controls.Add(this.btPrevious);
			base.Controls.Add(this.btNext);
			base.Controls.Add(this.lblStatus);
			base.Controls.Add(this.pictureBox);
			base.Name = "ImageNavigator";
			base.Size = new global::System.Drawing.Size(344, 256);
			base.ResumeLayout(false);
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x00081C60 File Offset: 0x0007FE60
		private void RefreshImageList()
		{
			if (this.Images != null)
			{
				if (this.Images.Length > 0)
				{
					this.CurrentImageIndex = 0;
				}
				else
				{
					this.CurrentImageIndex = -1;
				}
			}
			else
			{
				this.CurrentImageIndex = -1;
			}
			this.RefreshImage();
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x00081CB0 File Offset: 0x0007FEB0
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x00081CB8 File Offset: 0x0007FEB8
		public string StatusFormat
		{
			get
			{
				return this.m_StatusFormat;
			}
			set
			{
				this.m_StatusFormat = value;
			}
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x00081CC4 File Offset: 0x0007FEC4
		private void RefreshImage()
		{
			if (this.m_CurrentImageIndex < 0 || this.Images == null || this.m_CurrentImageIndex >= this.Images.Length)
			{
				this.pictureBox.Image = null;
				this.lblStatus.Text = "";
				this.btNext.Enabled = false;
				this.btPrevious.Enabled = false;
				return;
			}
			this.pictureBox.Image = this.Images[this.m_CurrentImageIndex];
			this.lblStatus.Text = string.Format(this.StatusFormat, this.m_CurrentImageIndex + 1, this.Images.Length);
			this.btNext.Enabled = true;
			this.btPrevious.Enabled = true;
			if (this.m_CurrentImageIndex == 0)
			{
				this.btPrevious.Enabled = false;
			}
			if (this.m_CurrentImageIndex >= this.Images.Length - 1)
			{
				this.btNext.Enabled = false;
			}
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x00081DD0 File Offset: 0x0007FFD0
		public void NextImage()
		{
			if (this.Images != null && this.m_CurrentImageIndex < this.Images.Length - 1)
			{
				this.CurrentImageIndex++;
			}
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x00081E00 File Offset: 0x00080000
		public void PreviousImage()
		{
			if (this.Images != null && this.m_CurrentImageIndex > 0)
			{
				this.CurrentImageIndex--;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x00081E28 File Offset: 0x00080028
		// (set) Token: 0x06002518 RID: 9496 RVA: 0x00081E30 File Offset: 0x00080030
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Drawing.Image[] Images
		{
			get
			{
				return this.m_Images;
			}
			set
			{
				this.m_Images = value;
				this.RefreshImageList();
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x00081E40 File Offset: 0x00080040
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x00081E48 File Offset: 0x00080048
		public int CurrentImageIndex
		{
			get
			{
				return this.m_CurrentImageIndex;
			}
			set
			{
				this.m_CurrentImageIndex = value;
				this.RefreshImage();
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x00081E58 File Offset: 0x00080058
		// (set) Token: 0x0600251C RID: 9500 RVA: 0x00081E68 File Offset: 0x00080068
		public global::System.Drawing.Size ImageAreaSize
		{
			get
			{
				return this.pictureBox.Size;
			}
			set
			{
				base.Width += value.Width - this.pictureBox.Width;
				base.Height += value.Height - this.pictureBox.Height;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x00081EBC File Offset: 0x000800BC
		// (set) Token: 0x0600251E RID: 9502 RVA: 0x00081ECC File Offset: 0x000800CC
		public global::System.Windows.Forms.BorderStyle ImageAreaBorderStyle
		{
			get
			{
				return this.pictureBox.BorderStyle;
			}
			set
			{
				this.pictureBox.BorderStyle = value;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x0600251F RID: 9503 RVA: 0x00081EDC File Offset: 0x000800DC
		// (set) Token: 0x06002520 RID: 9504 RVA: 0x00081EEC File Offset: 0x000800EC
		public global::System.Windows.Forms.PictureBoxSizeMode ImageAreaSizeMode
		{
			get
			{
				return this.pictureBox.SizeMode;
			}
			set
			{
				this.pictureBox.SizeMode = value;
			}
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x00081EFC File Offset: 0x000800FC
		protected override void OnLoad(global::System.EventArgs e)
		{
			base.OnLoad(e);
			this.RefreshImageList();
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x00081F0C File Offset: 0x0008010C
		private void btPrevious_Click(object sender, global::System.EventArgs e)
		{
			this.PreviousImage();
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x00081F14 File Offset: 0x00080114
		private void btNext_Click(object sender, global::System.EventArgs e)
		{
			this.NextImage();
		}

		// Token: 0x04000CEE RID: 3310
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000CEF RID: 3311
		private global::System.Windows.Forms.PictureBox pictureBox;

		// Token: 0x04000CF0 RID: 3312
		private global::System.Windows.Forms.Button btNext;

		// Token: 0x04000CF1 RID: 3313
		private global::System.Windows.Forms.Button btPrevious;

		// Token: 0x04000CF2 RID: 3314
		private global::System.ComponentModel.Container components;

		// Token: 0x04000CF3 RID: 3315
		private string m_StatusFormat = "{0} of {1}";

		// Token: 0x04000CF4 RID: 3316
		private global::System.Drawing.Image[] m_Images;

		// Token: 0x04000CF5 RID: 3317
		private int m_CurrentImageIndex = -1;
	}
}
