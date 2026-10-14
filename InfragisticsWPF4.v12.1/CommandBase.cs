using System;
using System.Windows.Input;
using Infragistics.Controls;

namespace Infragistics
{
	// Token: 0x020000AD RID: 173
	public class CommandBase : global::System.Windows.Input.ICommand
	{
		// Token: 0x0600068E RID: 1678 RVA: 0x00017AE3 File Offset: 0x00015CE3
		protected virtual void OnCanExecuteChanged()
		{
			if (this.CanExecuteChanged != null)
			{
				this.CanExecuteChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00017AFE File Offset: 0x00015CFE
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00017B06 File Offset: 0x00015D06
		public global::Infragistics.Controls.CommandSource CommandSource { get; set; }

		// Token: 0x06000691 RID: 1681 RVA: 0x00017B0F File Offset: 0x00015D0F
		public virtual bool CanExecute(object parameter)
		{
			return false;
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000692 RID: 1682 RVA: 0x00017B14 File Offset: 0x00015D14
		// (remove) Token: 0x06000693 RID: 1683 RVA: 0x00017B4C File Offset: 0x00015D4C
		public event global::System.EventHandler CanExecuteChanged;

		// Token: 0x06000694 RID: 1684 RVA: 0x00017B81 File Offset: 0x00015D81
		public virtual void Execute(object parameter)
		{
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00017B83 File Offset: 0x00015D83
		public virtual void Execute(global::Infragistics.Controls.CommandSource source, global::Infragistics.ICommandTarget target)
		{
		}
	}
}
