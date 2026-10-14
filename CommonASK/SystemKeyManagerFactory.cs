using System;
using System.Threading;
using ASK.Interface;
using ASKLib;

namespace CommonASK
{
	// Token: 0x0200000D RID: 13
	public class SystemKeyManagerFactory
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00008430 File Offset: 0x00006630
		private SystemKeyManagerFactory()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008444 File Offset: 0x00006644
		public global::ASK.Interface.ISystemKeyManager GetSystemKeyManager()
		{
			short num = (short)979387262;
			short num2 = num;
			num = (short)731923326;
			global::ASK.Interface.ISystemKeyManager result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)823263232;
				short num3 = num;
				break;
			}
			}
			num = (short)1898840065;
			if (num != 0)
			{
			}
			num = (short)1431044096;
			if (num != 0)
			{
			}
			object obj = global::CommonASK.SystemKeyManagerFactory.d;
			bool flag = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_DD;
				}
				int num4;
				for (;;)
				{
					IL_AF:
					switch (num4)
					{
					case 0:
						this.b = new global::CommonASK.MockSystemKeyManager();
						num = (short)1984888838;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.c)
						{
							num = (short)659161090;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1116209161;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1059258375;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_207;
					case 4:
						goto IL_202;
					case 5:
						goto IL_225;
					case 6:
						goto IL_1E4;
					case 7:
						if (this.b == null)
						{
							num = (short)367394816;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E4;
					case 8:
						this.a = global::ASKLib.SystemKeyManager.GetInstance();
						num = (short)102170627;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.a == null)
						{
							num = (short)952696840;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_207;
					}
					goto IL_DD;
					IL_1E4:
					result = this.b;
					num = (short)1494417412;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_207:
					result = this.a;
					num = (short)51970053;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_202:
				IL_225:
				return result;
				IL_DD:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num = (short)1988493313;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_AF;
			}
			finally
			{
				num = (short)1783693312;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_257;
						}
						continue;
					case 1:
						goto IL_28C;
					case 2:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)1786314753;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_257:
					if (!flag)
					{
						break;
					}
					num = (short)1735065602;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_28C:;
			}
			return result;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00008700 File Offset: 0x00006900
		public void SetTestMode(bool istestmode)
		{
			short num = (short)815209231;
			short num2 = num;
			num = (short)541530895;
			switch (num2 == num)
			{
			}
			num = (short)1253048320;
			short num3 = num;
			num = (short)1142423552;
			if (num != 0)
			{
			}
			num = (short)1246035969;
			if (num != 0)
			{
			}
			this.c = istestmode;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000087B0 File Offset: 0x000069B0
		public bool GetTestMode()
		{
			short num = (short)106262437;
			short num2 = num;
			num = (short)1084387237;
			switch (num2 == num)
			{
			}
			num = (short)2058616832;
			short num3 = num;
			num = (short)2041577473;
			if (num != 0)
			{
			}
			num = (short)2058027008;
			if (num != 0)
			{
			}
			return this.c;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00008860 File Offset: 0x00006A60
		// Note: this type is marked as 'beforefieldinit'.
		static SystemKeyManagerFactory()
		{
			short num = (short)287719733;
			short num2 = num;
			num = (short)1353269557;
			switch (num2 == num)
			{
			}
			num = (short)1611595776;
			short num3 = num;
			num = (short)1989738496;
			if (num != 0)
			{
			}
			num = (short)1609039873;
			if (num != 0)
			{
			}
			global::CommonASK.SystemKeyManagerFactory.Instance = new global::CommonASK.SystemKeyManagerFactory();
			global::CommonASK.SystemKeyManagerFactory.d = new object();
		}

		// Token: 0x04000027 RID: 39
		public static readonly global::CommonASK.SystemKeyManagerFactory Instance;

		// Token: 0x04000028 RID: 40
		private global::ASK.Interface.ISystemKeyManager a;

		// Token: 0x04000029 RID: 41
		private global::ASK.Interface.ISystemKeyManager b;

		// Token: 0x0400002A RID: 42
		private bool c;

		// Token: 0x0400002B RID: 43
		private static object d;
	}
}
