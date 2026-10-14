using System;
using System.Windows.Input;
using Infragistics.Controls;

namespace Infragistics
{
	// Token: 0x020000C7 RID: 199
	public class CommandBase : global::System.Windows.Input.ICommand
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x0001B222 File Offset: 0x00019422
		protected virtual void OnCanExecuteChanged()
		{
			if (this.CanExecuteChanged != null)
			{
				this.CanExecuteChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0001B23D File Offset: 0x0001943D
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x0001B245 File Offset: 0x00019445
		public global::Infragistics.Controls.CommandSource CommandSource { get; set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x0001B24E File Offset: 0x0001944E
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x0001B256 File Offset: 0x00019456
		public global::Infragistics.ICommandTarget CurrentTarget { get; internal set; }

		// Token: 0x06000777 RID: 1911 RVA: 0x0001B25F File Offset: 0x0001945F
		public virtual bool CanExecute(object parameter)
		{
			return false;
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000778 RID: 1912 RVA: 0x0001B264 File Offset: 0x00019464
		// (remove) Token: 0x06000779 RID: 1913 RVA: 0x0001B29C File Offset: 0x0001949C
		public event global::System.EventHandler CanExecuteChanged;

		// Token: 0x0600077A RID: 1914 RVA: 0x0001B2D1 File Offset: 0x000194D1
		public virtual void Execute(object parameter)
		{
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0001B2D3 File Offset: 0x000194D3
		public virtual void Execute(global::Infragistics.Controls.CommandSource source, global::Infragistics.ICommandTarget target)
		{
		}
	}
}
