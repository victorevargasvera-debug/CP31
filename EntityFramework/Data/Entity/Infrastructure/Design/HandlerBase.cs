using System;

namespace System.Data.Entity.Infrastructure.Design
{
	// Token: 0x0200029E RID: 670
	public abstract class HandlerBase : global::System.MarshalByRefObject
	{
		// Token: 0x0600216A RID: 8554 RVA: 0x0005CD98 File Offset: 0x0005AF98
		public virtual bool ImplementsContract(string interfaceName)
		{
			global::System.Type type;
			try
			{
				type = global::System.Type.GetType(interfaceName, true);
			}
			catch
			{
				return false;
			}
			return type.IsAssignableFrom(base.GetType());
		}
	}
}
