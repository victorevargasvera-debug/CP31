using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000081 RID: 129
	public class RadioCache
	{
		// Token: 0x0600039F RID: 927 RVA: 0x00055190 File Offset: 0x00053390
		private RadioCache()
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000551B0 File Offset: 0x000533B0
		public static global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache Instance
		{
			get
			{
				short num = (short)1914686261;
				short num2 = num;
				num = (short)914082613;
				switch (num2 == num)
				{
				}
				num = (short)374603776;
				if (num != 0)
				{
				}
				num = (short)1857814528;
				short num3 = num;
				num = (short)2146566145;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.a;
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00055260 File Offset: 0x00053460
		public global::Motorola.CommonCPS.Server.EntityModel.Radio GetCachedRadio(global::System.Guid deviceId)
		{
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.Radio> obj = this.b;
			bool flag = false;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.Radio result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_2B;
				}
				int num;
				for (;;)
				{
					IL_15:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1919141049;
						short num3 = num2;
						num2 = (short)1617478841;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6E;
						default:
							num2 = (short)767754240;
							if (num2 != 0)
							{
							}
							result = null;
							num2 = (short)769720321;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						goto IL_FB;
					case 2:
						goto IL_125;
					case 3:
						goto IL_6E;
					}
					goto IL_2B;
					IL_6E:
					if (!this.b.ContainsKey(deviceId))
					{
						num2 = (short)598605824;
						num = (int)((global::System.IntPtr)num2);
					}
					else
					{
						result = this.b[deviceId];
						num2 = (short)1696268290;
						num = (int)((global::System.IntPtr)num2);
					}
				}
				IL_FB:
				IL_125:
				goto IL_190;
				IL_2B:
				num2 = (short)446431233;
				if (num2 != 0)
				{
				}
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num2 = (short)1749549059;
				num = (int)((global::System.IntPtr)num2);
				goto IL_15;
			}
			finally
			{
				num2 = (short)1282998274;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						global::System.Threading.Monitor.Exit(obj);
						num2 = (short)2091843585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_18D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_158;
						}
						continue;
					}
					IL_158:
					if (!flag)
					{
						break;
					}
					num2 = (short)275972096;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_18D:;
			}
			IL_190:
			num2 = (short)1254162432;
			short num4 = num2;
			return result;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00055444 File Offset: 0x00053644
		public void Add(global::System.Guid deviceId, global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.Radio> obj = this.b;
			bool flag = false;
			short num;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				int num2;
				for (;;)
				{
					IL_15:
					num = (short)1821638657;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)2030117784;
						short num3 = num;
						num = (short)559752088;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6F;
						default:
							num = (short)60227584;
							if (num != 0)
							{
							}
							this.b[deviceId] = radio;
							num = (short)1199702017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_10E;
					case 2:
						goto IL_139;
					case 3:
						goto IL_6F;
					}
					goto IL_52;
					IL_6F:
					if (this.b.ContainsKey(deviceId))
					{
						num = (short)1854865408;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.b.Add(deviceId, radio);
						num = (short)746455042;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_10E:
				IL_139:
				goto IL_1A5;
				IL_52:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num = (short)793772035;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_15;
			}
			finally
			{
				num = (short)534708226;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)849149953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1A2;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_16C;
						}
						continue;
					}
					IL_16C:
					if (!flag)
					{
						break;
					}
					num = (short)203554816;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A2:;
			}
			IL_1A5:
			num = (short)2094923776;
			short num4 = num;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0005563C File Offset: 0x0005383C
		public void Clear()
		{
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.Radio> obj = this.b;
			bool flag = false;
			short num;
			try
			{
				num = (short)802226177;
				if (num != 0)
				{
				}
				global::System.Threading.Monitor.Enter(obj, ref flag);
				this.b.Clear();
			}
			finally
			{
				num = (short)1054408706;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1612670129;
						short num3 = num;
						num = (short)771122353;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_100;
						default:
							num = (short)1682243584;
							if (num != 0)
							{
							}
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1541668865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_100;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					}
					IL_7C:
					if (!flag)
					{
						break;
					}
					num = (short)418643968;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_100:;
			}
			num = (short)516554752;
			short num4 = num;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00055788 File Offset: 0x00053988
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetRadioList()
		{
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.Radio> obj = this.b;
			bool flag = false;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio> result;
			short num;
			try
			{
				global::System.Threading.Monitor.Enter(obj, ref flag);
				result = this.b.Values.ToList<global::Motorola.CommonCPS.Server.EntityModel.Radio>();
			}
			finally
			{
				num = (short)899940354;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)148035139;
						short num3 = num;
						num = (short)1124456003;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_DE;
						default:
							num = (short)1054146560;
							if (num != 0)
							{
							}
							global::System.Threading.Monitor.Exit(obj);
							num = (short)2061041665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_DE;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					IL_5A:
					if (!flag)
					{
						break;
					}
					num = (short)1587806208;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DE:;
			}
			num = (short)188940288;
			short num4 = num;
			num = (short)1893859329;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000558D8 File Offset: 0x00053AD8
		// Note: this type is marked as 'beforefieldinit'.
		static RadioCache()
		{
			short num = (short)1690169089;
			short num2 = num;
			num = (short)534769409;
			switch (num2 == num)
			{
			}
			num = (short)305790977;
			if (num != 0)
			{
			}
			num = (short)1541865472;
			short num3 = num;
			num = (short)2015166464;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.a = new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache();
		}

		// Token: 0x040000B0 RID: 176
		private static readonly global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache a;

		// Token: 0x040000B1 RID: 177
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.Radio> b = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.Radio>();
	}
}
