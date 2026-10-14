using System;
using System.Threading;

namespace NLog.Internal
{
	// Token: 0x0200012D RID: 301
	internal static class ThreadLocalStorageHelper
	{
		// Token: 0x06000DD7 RID: 3543 RVA: 0x00023053 File Offset: 0x00021253
		public static object AllocateDataSlot()
		{
			return global::System.Threading.Thread.AllocateDataSlot();
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0002305C File Offset: 0x0002125C
		public static T GetDataForSlot<T>(object slot, bool create = true) where T : class, new()
		{
			global::System.LocalDataStoreSlot slot2 = (global::System.LocalDataStoreSlot)slot;
			object obj = global::System.Threading.Thread.GetData(slot2);
			if (obj == null)
			{
				if (!create)
				{
					return default(T);
				}
				obj = global::System.Activator.CreateInstance<T>();
				global::System.Threading.Thread.SetData(slot2, obj);
			}
			return (T)((object)obj);
		}
	}
}
