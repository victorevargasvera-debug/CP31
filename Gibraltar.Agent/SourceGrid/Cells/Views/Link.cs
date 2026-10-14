using System;
using System.Drawing;
using System.Windows.Forms;

namespace SourceGrid.Cells.Views
{
	// Token: 0x0200034E RID: 846
	[global::System.Serializable]
	internal class Link : global::SourceGrid.Cells.Views.Cell
	{
		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x0008E12C File Offset: 0x0008C32C
		public new static global::SourceGrid.Cells.Views.Link Default
		{
			get
			{
				if (global::SourceGrid.Cells.Views.Link.t_Default == null)
				{
					global::SourceGrid.Cells.Views.Link.t_Default = new global::SourceGrid.Cells.Views.Link();
				}
				return global::SourceGrid.Cells.Views.Link.t_Default;
			}
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x0008E148 File Offset: 0x0008C348
		public Link()
		{
			base.Font = new global::System.Drawing.Font(global::System.Windows.Forms.Control.DefaultFont, global::System.Drawing.FontStyle.Underline);
			base.ForeColor = global::System.Drawing.Color.Blue;
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x0008E16C File Offset: 0x0008C36C
		public Link(global::SourceGrid.Cells.Views.Link p_Source) : base(p_Source)
		{
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x0008E178 File Offset: 0x0008C378
		public override object Clone()
		{
			return new global::SourceGrid.Cells.Views.Link(this);
		}

		// Token: 0x04000E2F RID: 3631
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Views.Link t_Default;
	}
}
