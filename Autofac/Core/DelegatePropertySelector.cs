using System;
using System.Reflection;

namespace Autofac.Core
{
	// Token: 0x0200005A RID: 90
	public sealed class DelegatePropertySelector : global::Autofac.Core.IPropertySelector
	{
		// Token: 0x06000231 RID: 561 RVA: 0x00008438 File Offset: 0x00006638
		public DelegatePropertySelector(global::System.Func<global::System.Reflection.PropertyInfo, object, bool> finder)
		{
			if (finder == null)
			{
				throw new global::System.ArgumentNullException("finder");
			}
			this._finder = finder;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00008455 File Offset: 0x00006655
		public bool InjectProperty(global::System.Reflection.PropertyInfo property, object instance)
		{
			return this._finder(property, instance);
		}

		// Token: 0x0400007C RID: 124
		private readonly global::System.Func<global::System.Reflection.PropertyInfo, object, bool> _finder;
	}
}
