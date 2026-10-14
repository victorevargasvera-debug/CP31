using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x02000319 RID: 793
	internal partial class FormBase : Form
	{
		// Token: 0x06002579 RID: 9593 RVA: 0x00082BE0 File Offset: 0x00080DE0
		public FormBase()
		{
			this.InitializeComponent();
			string text = AppDomain.CurrentDomain.FriendlyName + "." + base.GetType().ToString() + ".frp";
			char[] invalidPathChars = Path.GetInvalidPathChars();
			for (int i = 0; i < invalidPathChars.Length; i++)
			{
				text = text.Replace(new string(invalidPathChars[i], 1), "");
			}
			this.StorageFileName = text;
			this.RestoreFlags = RestoreFlags.None;
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x00082CC0 File Offset: 0x00080EC0
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x00082CD0 File Offset: 0x00080ED0
		[Description("Isolated Storage FileName where the form save the position information")]
		public virtual string StorageFileName
		{
			get
			{
				return this.m_Setting.StorageFileName;
			}
			set
			{
				this.m_Setting.StorageFileName = value;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x00082CE0 File Offset: 0x00080EE0
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x00082CF0 File Offset: 0x00080EF0
		[Description("Restore flags")]
		public virtual RestoreFlags RestoreFlags
		{
			get
			{
				return this.m_Setting.RestoreFlags;
			}
			set
			{
				this.m_Setting.RestoreFlags = value;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x00082D00 File Offset: 0x00080F00
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x00082D10 File Offset: 0x00080F10
		[Description("Save flags")]
		public virtual SaveFlags SaveFlags
		{
			get
			{
				return this.m_Setting.SaveFlags;
			}
			set
			{
				this.m_Setting.SaveFlags = value;
			}
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00082D20 File Offset: 0x00080F20
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			try
			{
				if (!base.DesignMode && (Control.ModifierKeys & Keys.Control) != Keys.Control)
				{
					this.m_Setting.Load(this);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00082D7C File Offset: 0x00080F7C
		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			try
			{
				if (!base.DesignMode && (Control.ModifierKeys & Keys.Control) != Keys.Control)
				{
					this.m_Setting.Save(this);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000D3F RID: 3391
		private PositionRecorderIsolatedStorage m_Setting = new PositionRecorderIsolatedStorage();
	}
}
