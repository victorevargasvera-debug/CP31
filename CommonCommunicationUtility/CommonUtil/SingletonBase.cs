using System;
using System.Threading;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000047 RID: 71
	public class SingletonBase<T> where T : class, new()
	{
		// Token: 0x060000DE RID: 222 RVA: 0x0000B02C File Offset: 0x0000922C
		public static T Instance()
		{
			short num = (short)1708457984;
			short num2 = num;
			object obj = global::Motorola.Common.Communication.CommonUtil.SingletonBase<T>.a;
			bool flag = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				int num3;
				for (;;)
				{
					IL_3C:
					switch (num3)
					{
					case 0:
						if (global::Motorola.Common.Communication.CommonUtil.SingletonBase<T>.b == null)
						{
							num = (short)1966866434;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126;
					case 1:
					{
						num = (short)1910402889;
						short num4 = num;
						num = (short)1613197129;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9E;
						default:
							num = (short)1289289729;
							if (num != 0)
							{
							}
							num = (short)339869696;
							if (num != 0)
							{
							}
							goto IL_126;
						}
						break;
					}
					case 2:
						global::Motorola.Common.Communication.CommonUtil.SingletonBase<T>.b = global::System.Activator.CreateInstance<T>();
						goto IL_9E;
					case 3:
						goto IL_13D;
					}
					goto IL_52;
					IL_9E:
					num = (short)698286081;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_126:
					num = (short)1520369667;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_13D:
				goto IL_1A7;
				IL_52:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num = (short)877985792;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_3C;
			}
			finally
			{
				num = (short)52166657;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)681771010;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_170;
						}
						continue;
					case 2:
						goto IL_1A4;
					}
					IL_170:
					if (!flag)
					{
						break;
					}
					num = (short)1716649984;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1A4:;
			}
			IL_1A7:
			return global::Motorola.Common.Communication.CommonUtil.SingletonBase<T>.b;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000B218 File Offset: 0x00009418
		// Note: this type is marked as 'beforefieldinit'.
		static SingletonBase()
		{
			short num = (short)968294400;
			short num2 = num;
			num = (short)141426689;
			if (num != 0)
			{
			}
			num = (short)2075095718;
			short num3 = num;
			num = (short)385118886;
			switch (num3 == num)
			{
			}
			num = (short)1187774464;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.SingletonBase<T>.a = new object();
		}

		// Token: 0x04000222 RID: 546
		private static object a;

		// Token: 0x04000223 RID: 547
		private static T b;
	}
}
