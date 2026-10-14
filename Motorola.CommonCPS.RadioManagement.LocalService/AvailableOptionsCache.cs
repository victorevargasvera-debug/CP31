using System;
using System.Collections.Generic;
using System.Threading;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200001F RID: 31
	public class AvailableOptionsCache
	{
		// Token: 0x0600016D RID: 365 RVA: 0x000186C8 File Offset: 0x000168C8
		private AvailableOptionsCache()
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000186E8 File Offset: 0x000168E8
		public static global::Motorola.CommonCPS.RadioManagement.LocalService.AvailableOptionsCache Instance
		{
			get
			{
				short num = (short)1420165120;
				short num2 = num;
				num = (short)1352956487;
				short num3 = num;
				num = (short)683702855;
				switch (num3 == num)
				{
				}
				num = (short)1104412673;
				if (num != 0)
				{
				}
				num = (short)1528365056;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.LocalService.AvailableOptionsCache.a;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00018798 File Offset: 0x00016998
		public global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection GetCachedOptions(string condition)
		{
			short num = (short)1093271552;
			short num2 = num;
			num = (short)810944494;
			short num3 = num;
			num = (short)2037909486;
			global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)244187136;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection> obj = this.b;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_9E;
					}
					int num4;
					for (;;)
					{
						IL_88:
						switch (num4)
						{
						case 0:
							if (!this.b.ContainsKey(condition))
							{
								num = (short)944963585;
								if (num != 0)
								{
								}
								num = (short)2067726337;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = this.b[condition];
							num = (short)1444610051;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							result = null;
							num = (short)812318722;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_120;
						case 3:
							goto IL_149;
						}
						goto IL_9E;
					}
					IL_120:
					IL_149:
					break;
					IL_9E:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)1297547264;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_88;
				}
				finally
				{
					num = (short)332136448;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_17B;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1650262018;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1AE;
						}
						IL_17B:
						if (!flag)
						{
							break;
						}
						num = (short)1924136961;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1AE:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00018968 File Offset: 0x00016B68
		public void Add(string condition, global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection options)
		{
			short num = (short)626262016;
			short num2 = num;
			num = (short)122766879;
			short num3 = num;
			num = (short)747849247;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1887174657;
				if (num != 0)
				{
				}
				num = (short)1708654592;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection> obj = this.b;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_C7;
					}
					int num4;
					for (;;)
					{
						IL_B1:
						switch (num4)
						{
						case 0:
							if (this.b.ContainsKey(condition))
							{
								num = (short)1063059457;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.b.Add(condition, options);
							num = (short)720830467;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							this.b[condition] = options;
							num = (short)2109276162;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_129;
						case 3:
							goto IL_153;
						}
						goto IL_C7;
					}
					IL_129:
					IL_153:
					break;
					IL_C7:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)1882849280;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_B1;
				}
				finally
				{
					num = (short)1327759360;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_185;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)976027650;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1B9;
						}
						IL_185:
						if (!flag)
						{
							break;
						}
						num = (short)833421313;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1B9:;
				}
				break;
			}
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00018B44 File Offset: 0x00016D44
		public void Clear()
		{
			short num = (short)667156480;
			short num2 = num;
			num = (short)1631268164;
			short num3 = num;
			num = (short)1379085636;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1172504577;
				if (num != 0)
				{
				}
				num = (short)263847936;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection> obj = this.b;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					this.b.Clear();
				}
				finally
				{
					num = (short)635633664;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_EC;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1237254146;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_11F;
						}
						IL_EC:
						if (!flag)
						{
							break;
						}
						num = (short)1136328705;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_11F:;
				}
				break;
			}
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00018C84 File Offset: 0x00016E84
		// Note: this type is marked as 'beforefieldinit'.
		static AvailableOptionsCache()
		{
			short num = (short)1101266944;
			short num2 = num;
			num = (short)1600202829;
			short num3 = num;
			num = (short)1986144333;
			switch (num3 == num)
			{
			}
			num = (short)814350337;
			if (num != 0)
			{
			}
			num = (short)1980760064;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.AvailableOptionsCache.a = new global::Motorola.CommonCPS.RadioManagement.LocalService.AvailableOptionsCache();
		}

		// Token: 0x04000034 RID: 52
		private static readonly global::Motorola.CommonCPS.RadioManagement.LocalService.AvailableOptionsCache a;

		// Token: 0x04000035 RID: 53
		private readonly global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection> b = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection>();
	}
}
