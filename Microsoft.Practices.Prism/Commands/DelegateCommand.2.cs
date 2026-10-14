using System;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Commands
{
	// Token: 0x0200000A RID: 10
	public class DelegateCommand : global::Microsoft.Practices.Prism.Commands.DelegateCommandBase
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00002B09 File Offset: 0x00000D09
		public DelegateCommand(global::System.Action executeMethod) : this(executeMethod, () => true)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002B54 File Offset: 0x00000D54
		public DelegateCommand(global::System.Action executeMethod, global::System.Func<bool> canExecuteMethod) : base(delegate(object o)
		{
			executeMethod();
		}, (object o) => canExecuteMethod())
		{
			if (executeMethod == null || canExecuteMethod == null)
			{
				throw new global::System.ArgumentNullException("executeMethod", global::Microsoft.Practices.Prism.Properties.Resources.DelegateCommandDelegatesCannotBeNull);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002BC1 File Offset: 0x00000DC1
		public void Execute()
		{
			base.Execute(null);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002BCA File Offset: 0x00000DCA
		public bool CanExecute()
		{
			return base.CanExecute(null);
		}
	}
}
