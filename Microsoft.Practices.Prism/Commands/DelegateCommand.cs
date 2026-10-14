using System;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Commands
{
	// Token: 0x02000009 RID: 9
	public class DelegateCommand<T> : global::Microsoft.Practices.Prism.Commands.DelegateCommandBase
	{
		// Token: 0x06000046 RID: 70 RVA: 0x000029EB File Offset: 0x00000BEB
		public DelegateCommand(global::System.Action<T> executeMethod) : this(executeMethod, (T o) => true)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002A40 File Offset: 0x00000C40
		public DelegateCommand(global::System.Action<T> executeMethod, global::System.Func<T, bool> canExecuteMethod) : base(delegate(object o)
		{
			executeMethod((T)((object)o));
		}, (object o) => canExecuteMethod((T)((object)o)))
		{
			if (executeMethod == null || canExecuteMethod == null)
			{
				throw new global::System.ArgumentNullException("executeMethod", global::Microsoft.Practices.Prism.Properties.Resources.DelegateCommandDelegatesCannotBeNull);
			}
			global::System.Type typeFromHandle = typeof(T);
			if (typeFromHandle.IsValueType && (!typeFromHandle.IsGenericType || !typeof(global::System.Nullable<>).IsAssignableFrom(typeFromHandle.GetGenericTypeDefinition())))
			{
				throw new global::System.InvalidCastException(global::Microsoft.Practices.Prism.Properties.Resources.DelegateCommandInvalidGenericPayloadType);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002AEA File Offset: 0x00000CEA
		public bool CanExecute(T parameter)
		{
			return base.CanExecute(parameter);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public void Execute(T parameter)
		{
			base.Execute(parameter);
		}
	}
}
