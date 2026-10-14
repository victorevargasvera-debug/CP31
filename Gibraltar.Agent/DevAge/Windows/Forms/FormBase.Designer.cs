namespace DevAge.Windows.Forms
{
	// Token: 0x02000319 RID: 793
	internal partial class FormBase : global::System.Windows.Forms.Form
	{
		// Token: 0x0600257A RID: 9594 RVA: 0x00082C68 File Offset: 0x00080E68
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x00082C90 File Offset: 0x00080E90
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			base.Size = new global::System.Drawing.Size(300, 300);
			this.Text = "FormPosition";
		}

		// Token: 0x04000D3E RID: 3390
		private global::System.ComponentModel.Container components;
	}
}
