using System;

namespace NLog.Internal
{
	// Token: 0x02000100 RID: 256
	internal class FactoryHelper
	{
		// Token: 0x06000CC9 RID: 3273 RVA: 0x0001F593 File Offset: 0x0001D793
		private FactoryHelper()
		{
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0001F59C File Offset: 0x0001D79C
		internal static object CreateInstance(global::System.Type t)
		{
			object result;
			try
			{
				result = global::System.Activator.CreateInstance(t);
			}
			catch (global::System.MissingMethodException innerException)
			{
				throw new global::NLog.NLogConfigurationException(string.Format("Cannot access the constructor of type: {0}. Is the required permission granted?", t.FullName), innerException);
			}
			return result;
		}
	}
}
