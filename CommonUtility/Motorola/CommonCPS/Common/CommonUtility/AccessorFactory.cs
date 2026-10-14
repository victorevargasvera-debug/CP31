using System;
using System.Collections.Concurrent;

namespace Motorola.CommonCPS.Common.CommonUtility
{
	// Token: 0x02000014 RID: 20
	public sealed class AccessorFactory
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00008EA8 File Offset: 0x000070A8
		public static global::Motorola.CommonCPS.Common.CommonUtility.IAccessor BuildAccessor<T>()
		{
			short num = (short)1064820131;
			short num2 = num;
			num = (short)1620499875;
			switch (num2 == num)
			{
			}
			num = (short)1192755200;
			if (num != 0)
			{
			}
			num = (short)373882880;
			short num3 = num;
			num = (short)1837563905;
			if (num != 0)
			{
			}
			global::System.Type typeFromHandle = typeof(T);
			return global::Motorola.CommonCPS.Common.CommonUtility.AccessorFactory.a.GetOrAdd(typeFromHandle, global::System.Activator.CreateInstance(typeof(global::Motorola.CommonCPS.Common.CommonUtility.b<>).MakeGenericType(new global::System.Type[]
			{
				typeFromHandle
			})) as global::Motorola.CommonCPS.Common.CommonUtility.IAccessor);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00008F8C File Offset: 0x0000718C
		public static global::Motorola.CommonCPS.Common.CommonUtility.IAccessor BuildAccessor(global::System.Type type)
		{
			short num = (short)1170866177;
			if (num != 0)
			{
			}
			num = (short)1624118991;
			short num2 = num;
			num = (short)2038240975;
			switch (num2 == num)
			{
			}
			num = (short)157417472;
			short num3 = num;
			num = (short)1566048256;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Common.CommonUtility.AccessorFactory.a.GetOrAdd(type, global::System.Activator.CreateInstance(typeof(global::Motorola.CommonCPS.Common.CommonUtility.b<>).MakeGenericType(new global::System.Type[]
			{
				type
			})) as global::Motorola.CommonCPS.Common.CommonUtility.IAccessor);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00009078 File Offset: 0x00007278
		// Note: this type is marked as 'beforefieldinit'.
		static AccessorFactory()
		{
			short num = (short)409562669;
			short num2 = num;
			num = (short)1733127725;
			switch (num2 == num)
			{
			}
			num = (short)1098711041;
			if (num != 0)
			{
			}
			num = (short)1383333888;
			short num3 = num;
			num = (short)361758720;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Common.CommonUtility.AccessorFactory.a = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::Motorola.CommonCPS.Common.CommonUtility.IAccessor>();
		}

		// Token: 0x0400001E RID: 30
		private static global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::Motorola.CommonCPS.Common.CommonUtility.IAccessor> a;
	}
}
