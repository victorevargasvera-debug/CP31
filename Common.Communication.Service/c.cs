using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000005 RID: 5
	internal class c : global::Motorola.Common.Communication.Service.b, global::System.IAsyncResult, global::System.IDisposable
	{
		// Token: 0x0600001B RID: 27 RVA: 0x0000211C File Offset: 0x0000031C
		public c(string A_0, global::System.AsyncCallback A_1, object A_2)
		{
			if (string.IsNullOrEmpty(A_0))
			{
				this.o(global::System.Guid.NewGuid().ToString());
			}
			else
			{
				this.o(A_0);
			}
			this.v(null);
			this.a = A_1;
			this.o(A_2);
			this.b = new global::System.Threading.ManualResetEvent(false);
			global::System.Reflection.MethodBase method = new global::System.Diagnostics.StackTrace().GetFrame(1).GetMethod();
			if (method != null)
			{
				this.h = method.Name;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000021B4 File Offset: 0x000003B4
		public string r()
		{
			short num = (short)457454276;
			short num2 = num;
			num = (short)676147908;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1299775488;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1820983297;
			if (num != 0)
			{
			}
			num = (short)1116667904;
			if (num != 0)
			{
			}
			return this.h;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002264 File Offset: 0x00000464
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public object s()
		{
			short num = (short)925179246;
			short num2 = num;
			num = (short)296492398;
			switch (num2 == num)
			{
			default:
			{
				num = (short)446496768;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1561722881;
			if (num != 0)
			{
			}
			num = (short)1102774272;
			if (num != 0)
			{
			}
			return this.j;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002314 File Offset: 0x00000514
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void t(object A_0)
		{
			short num = (short)859422876;
			short num2 = num;
			num = (short)1829159068;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1992032256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)944373761;
			if (num != 0)
			{
			}
			num = (short)1307705344;
			if (num != 0)
			{
			}
			this.j = A_0;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000023C4 File Offset: 0x000005C4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public global::System.Exception u()
		{
			short num = (short)759086376;
			short num2 = num;
			num = (short)1301134632;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1479671808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)59637760;
			if (num != 0)
			{
			}
			num = (short)857473025;
			if (num != 0)
			{
			}
			return this.k;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002474 File Offset: 0x00000674
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void v(global::System.Exception A_0)
		{
			short num = (short)1159795120;
			short num2 = num;
			num = (short)264835504;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1291059200;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2111897601;
			if (num != 0)
			{
			}
			num = (short)812777472;
			if (num != 0)
			{
			}
			this.k = A_0;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002524 File Offset: 0x00000724
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public string w()
		{
			short num = (short)447741953;
			if (num != 0)
			{
			}
			num = (short)1577910272;
			short num2 = num;
			num = (short)391127953;
			short num3 = num;
			num = (short)1349133201;
			switch (num3 == num)
			{
			}
			num = (short)1700462592;
			if (num != 0)
			{
			}
			return this.l;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000025D4 File Offset: 0x000007D4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void o(string value)
		{
			short num = (short)980202890;
			short num2 = num;
			num = (short)1704572298;
			switch (num2 == num)
			{
			default:
			{
				num = (short)27066368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1360920577;
			if (num != 0)
			{
			}
			num = (short)1833369600;
			if (num != 0)
			{
			}
			this.l = value;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002688 File Offset: 0x00000888
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public global::Motorola.Common.Communication.Service.a x()
		{
			short num = (short)1555333042;
			short num2 = num;
			num = (short)1147961266;
			switch (num2 == num)
			{
			default:
			{
				num = (short)874971136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)328335360;
			if (num != 0)
			{
			}
			num = (short)1291780097;
			if (num != 0)
			{
			}
			return this.m;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002738 File Offset: 0x00000938
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void o(global::Motorola.Common.Communication.Service.a A_0)
		{
			short num = (short)1130891096;
			short num2 = num;
			num = (short)679479128;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1977876480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2021261313;
			if (num != 0)
			{
			}
			num = (short)1062141952;
			if (num != 0)
			{
			}
			this.m = A_0;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000027E8 File Offset: 0x000009E8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public object get_AsyncState()
		{
			short num = (short)749868114;
			short num2 = num;
			num = (short)1045763154;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1201012736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)591921152;
			if (num != 0)
			{
			}
			num = (short)2130116609;
			if (num != 0)
			{
			}
			return this.n;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002898 File Offset: 0x00000A98
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void o(object A_0)
		{
			short num = (short)1893386792;
			short num2 = num;
			num = (short)2014169640;
			switch (num2 == num)
			{
			default:
			{
				num = (short)650510336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1144717312;
			if (num != 0)
			{
			}
			num = (short)76480513;
			if (num != 0)
			{
			}
			this.n = A_0;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002948 File Offset: 0x00000B48
		public global::System.Threading.WaitHandle get_AsyncWaitHandle()
		{
			short num = (short)1540248829;
			short num2 = num;
			num = (short)1101878525;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1664548864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)928645120;
			if (num != 0)
			{
			}
			num = (short)1606746113;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000029F8 File Offset: 0x00000BF8
		public bool get_CompletedSynchronously()
		{
			short num = (short)1610484876;
			short num2 = num;
			num = (short)622922892;
			switch (num2 == num)
			{
			default:
			{
				num = (short)59834368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1026752513;
			if (num != 0)
			{
			}
			num = (short)777715712;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002AA0 File Offset: 0x00000CA0
		public bool get_IsCompleted()
		{
			short num = (short)1021659719;
			short num2 = num;
			num = (short)948456007;
			switch (num2 == num)
			{
			default:
			{
				num = (short)587530240;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1304363008;
			if (num != 0)
			{
			}
			num = (short)1713700865;
			if (num != 0)
			{
			}
			return this.b.WaitOne(0, false);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002B58 File Offset: 0x00000D58
		public void y(global::System.EventHandler A_0)
		{
			short num = (short)229055685;
			short num2 = num;
			num = (short)588455109;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1880293376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1797062657;
			if (num != 0)
			{
			}
			num = (short)524222464;
			if (num != 0)
			{
			}
			this.c = (global::System.EventHandler)global::System.Delegate.Combine(this.c, A_0);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002C18 File Offset: 0x00000E18
		public void z(global::System.EventHandler A_0)
		{
			short num = (short)1890655210;
			short num2 = num;
			num = (short)773790698;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1939931136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1867841536;
			if (num != 0)
			{
			}
			num = (short)974651393;
			if (num != 0)
			{
			}
			this.c = (global::System.EventHandler)global::System.Delegate.Remove(this.c, A_0);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002CD8 File Offset: 0x00000ED8
		public void aa(global::System.EventHandler A_0)
		{
			short num = (short)401846672;
			short num2 = num;
			num = (short)371306896;
			switch (num2 == num)
			{
			default:
			{
				num = (short)188022784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1476853760;
			if (num != 0)
			{
			}
			num = (short)1425211393;
			if (num != 0)
			{
			}
			this.g = (global::System.EventHandler)global::System.Delegate.Combine(this.g, A_0);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002D98 File Offset: 0x00000F98
		public void ab(global::System.EventHandler A_0)
		{
			short num = (short)1872027437;
			short num2 = num;
			num = (short)906551085;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1672740864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)338231297;
			if (num != 0)
			{
			}
			num = (short)224722944;
			if (num != 0)
			{
			}
			this.g = (global::System.EventHandler)global::System.Delegate.Remove(this.g, A_0);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002E58 File Offset: 0x00001058
		public void ac(global::System.EventHandler A_0)
		{
			short num = (short)998175177;
			short num2 = num;
			num = (short)1043984841;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2100690944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)596246528;
			if (num != 0)
			{
			}
			num = (short)93782017;
			if (num != 0)
			{
			}
			this.e = (global::System.EventHandler)global::System.Delegate.Combine(this.e, A_0);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002F18 File Offset: 0x00001118
		public void ad(global::System.EventHandler A_0)
		{
			short num = (short)702599338;
			short num2 = num;
			num = (short)200528042;
			switch (num2 == num)
			{
			default:
			{
				num = (short)359268352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)260571137;
			if (num != 0)
			{
			}
			num = (short)2126708736;
			if (num != 0)
			{
			}
			this.e = (global::System.EventHandler)global::System.Delegate.Remove(this.e, A_0);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002FD8 File Offset: 0x000011D8
		public void ae(global::System.EventHandler A_0)
		{
			short num = (short)1584269030;
			short num2 = num;
			num = (short)920717030;
			switch (num2 == num)
			{
			default:
			{
				num = (short)963510272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1440612353;
			if (num != 0)
			{
			}
			num = (short)302317568;
			if (num != 0)
			{
			}
			this.d = (global::System.EventHandler)global::System.Delegate.Combine(this.d, A_0);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003098 File Offset: 0x00001298
		public void af(global::System.EventHandler A_0)
		{
			short num = (short)501598050;
			short num2 = num;
			num = (short)1284294498;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1747714048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)235995137;
			if (num != 0)
			{
			}
			num = (short)857210880;
			if (num != 0)
			{
			}
			this.d = (global::System.EventHandler)global::System.Delegate.Remove(this.d, A_0);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003158 File Offset: 0x00001358
		public void ag(global::System.EventHandler A_0)
		{
			short num = (short)170587334;
			short num2 = num;
			num = (short)1649538246;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1806106624;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)698482688;
			if (num != 0)
			{
			}
			num = (short)621346817;
			if (num != 0)
			{
			}
			this.f = (global::System.EventHandler)global::System.Delegate.Combine(this.f, A_0);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003214 File Offset: 0x00001414
		public void ah(global::System.EventHandler A_0)
		{
			short num = (short)1880430603;
			short num2 = num;
			num = (short)1657673739;
			switch (num2 == num)
			{
			default:
			{
				num = (short)484638720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)779223040;
			if (num != 0)
			{
			}
			num = (short)1304231937;
			if (num != 0)
			{
			}
			this.f = (global::System.EventHandler)global::System.Delegate.Remove(this.f, A_0);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000032D8 File Offset: 0x000014D8
		public virtual void ai()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			object obj;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)715259904;
					short num3 = num2;
					num2 = (short)2131951617;
					if (num2 != 0)
					{
					}
					try
					{
						switch (0)
						{
						case 0:
							goto IL_146;
						}
						for (;;)
						{
							IL_128:
							switch (num)
							{
							case 0:
								if (this.x() != global::Motorola.Common.Communication.Service.a.e)
								{
									num2 = (short)1132658692;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_1DA;
							case 1:
								num2 = (short)341180416;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (this.x() != global::Motorola.Common.Communication.Service.a.d)
								{
									num2 = (short)891224065;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_1DA;
							case 3:
								goto IL_1F3;
							case 4:
								this.o(global::Motorola.Common.Communication.Service.a.b);
								num2 = (short)974258181;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								goto IL_1DA;
							}
							goto IL_146;
							IL_1DA:
							num2 = (short)1781399555;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1F3:
						goto IL_92;
						IL_146:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num2 = (short)1033043970;
						num = (int)((global::System.IntPtr)num2);
						goto IL_128;
					}
					finally
					{
						num2 = (short)1685061632;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_229;
								}
								continue;
							case 1:
								global::System.Threading.Monitor.Exit(obj);
								num2 = (short)1763704834;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_25C;
							}
							IL_229:
							if (!flag)
							{
								break;
							}
							num2 = (short)1223622657;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_25C:;
					}
					goto IL_25F;
					IL_92:
					num2 = (short)2129657857;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)789043651;
					short num4 = num2;
					num2 = (short)370989507;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)165675008;
						if (num2 != 0)
						{
						}
						if (this.d != null)
						{
							num2 = (short)1710227458;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 2:
					goto IL_25F;
				case 3:
					return;
				}
				goto IL_20;
				IL_25F:
				this.d(this, global::System.EventArgs.Empty);
				num2 = (short)1073283075;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			obj = this.i;
			flag = false;
			num2 = (short)1886519296;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003580 File Offset: 0x00001780
		public virtual void aj()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			object obj;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1593311232;
					short num3 = num2;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_11C;
						}
						for (;;)
						{
							IL_FE:
							switch (num)
							{
							case 0:
								if (this.x() != global::Motorola.Common.Communication.Service.a.e)
								{
									num2 = (short)928120836;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_1B1;
							case 1:
								num2 = (short)846528512;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (this.x() != global::Motorola.Common.Communication.Service.a.d)
								{
									num2 = (short)1499070465;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_1B1;
							case 3:
								goto IL_1C8;
							case 4:
								this.o(global::Motorola.Common.Communication.Service.a.c);
								num2 = (short)1971126277;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								goto IL_1B1;
							}
							goto IL_11C;
							IL_1B1:
							num2 = (short)863764483;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1C8:
						goto IL_6B;
						IL_11C:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num2 = (short)478347266;
						num = (int)((global::System.IntPtr)num2);
						goto IL_FE;
					}
					finally
					{
						num2 = (short)1526005760;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1FF;
								}
								continue;
							case 1:
								global::System.Threading.Monitor.Exit(obj);
								num2 = (short)1455816706;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_233;
							}
							IL_1FF:
							if (!flag)
							{
								break;
							}
							num2 = (short)1960509441;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_233:;
					}
					goto IL_236;
					IL_6B:
					num2 = (short)832110593;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)106713507;
					short num4 = num2;
					num2 = (short)591942051;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25E;
					default:
						num2 = (short)1320812544;
						if (num2 != 0)
						{
						}
						if (this.e != null)
						{
							num2 = (short)380764162;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_260;
					}
					break;
				}
				case 2:
					goto IL_236;
				case 3:
					goto IL_25E;
				}
				goto IL_20;
				IL_236:
				this.e(this, global::System.EventArgs.Empty);
				num2 = (short)1549402115;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_25E:
			IL_260:
			num2 = (short)1621164033;
			if (num2 != 0)
			{
			}
			return;
			IL_20:
			obj = this.i;
			flag = false;
			num2 = (short)88080384;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003824 File Offset: 0x00001A24
		public virtual void ak()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			object obj;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1729363968;
					short num3 = num2;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_11B;
						}
						for (;;)
						{
							IL_105:
							switch (num)
							{
							case 0:
								if (this.x() != global::Motorola.Common.Communication.Service.a.d)
								{
									num2 = (short)499318785;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_1A1;
							case 1:
								num2 = (short)1743716353;
								if (num2 != 0)
								{
								}
								this.o(global::Motorola.Common.Communication.Service.a.e);
								num2 = (short)1359085570;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_1A1;
							case 3:
								goto IL_1B9;
							}
							goto IL_11B;
							IL_1A1:
							num2 = (short)1321730051;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1B9:
						goto IL_6A;
						IL_11B:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num2 = (short)427819008;
						num = (int)((global::System.IntPtr)num2);
						goto IL_105;
					}
					finally
					{
						num2 = (short)522911744;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1EF;
								}
								continue;
							case 1:
								global::System.Threading.Monitor.Exit(obj);
								num2 = (short)1671430146;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_226;
							}
							IL_1EF:
							if (!flag)
							{
								break;
							}
							num2 = (short)1247215617;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_226:;
					}
					goto IL_229;
					IL_6A:
					num2 = (short)551065722;
					short num4 = num2;
					num2 = (short)1809881210;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)793837568;
						if (num2 != 0)
						{
						}
						this.o();
						num2 = (short)812056577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (this.c != null)
					{
						num2 = (short)1530003458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					goto IL_229;
				case 3:
					return;
				}
				goto IL_20;
				IL_229:
				this.c(this, global::System.EventArgs.Empty);
				num2 = (short)2144993283;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			obj = this.i;
			flag = false;
			num2 = (short)301137920;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003A94 File Offset: 0x00001C94
		public virtual void al()
		{
			short num = (short)327745536;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1470911394;
				short num3 = num;
				num = (short)2085835682;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)526516225;
					if (num != 0)
					{
					}
					num = (short)1452539904;
					short num4 = num;
					num = (short)571998208;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_CD;
						}
						continue;
					case 1:
						goto IL_EC;
					case 2:
						return;
					}
					IL_CD:
					if (this.g != null)
					{
						num = (short)2146762753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_EC:
				this.g(this, global::System.EventArgs.Empty);
				num = (short)1316683778;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003BBC File Offset: 0x00001DBC
		public virtual void am()
		{
			short num = (short)1412431873;
			if (num != 0)
			{
			}
			num = (short)1915682816;
			short num2 = num;
			object obj = this.i;
			bool flag = false;
			try
			{
				global::System.Threading.Monitor.Enter(obj, ref flag);
				this.o(global::Motorola.Common.Communication.Service.a.d);
			}
			finally
			{
				num = (short)2059206658;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)926353543;
					short num4 = num;
					num = (short)1610877063;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1248854016;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_103;
						case 1:
							goto IL_122;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_EB;
							}
							continue;
						}
						IL_EB:
						if (flag)
						{
							num = (short)1918238720;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_124;
					}
					IL_103:
					global::System.Threading.Monitor.Exit(obj);
					num = (short)95617025;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_122:
				IL_124:;
			}
			this.o();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003D04 File Offset: 0x00001F04
		public virtual void an()
		{
			int a_ = 10;
			short num = (short)1719992322;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)359654555;
				short num3 = num;
				num = (short)3007643;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)428605440;
					short num4 = num;
					num = (short)1742340096;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_CE;
					case 1:
						goto IL_171;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					}
					IL_AC:
					if (this.f != null)
					{
						num = (short)90701824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_173;
				}
				}
				IL_CE:
				global::System.Console.ForegroundColor = global::System.ConsoleColor.Green;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udf8b揄ﲗ몙ﾛﾝ첟캡蒣튥삧쾩貫잭\udeaf욱톳쒵\udeb7\udbb9\udfbb\udbbdﻁ뿃뗇뗍꿑", a_), new object[]
				{
					this.h,
					this.w()
				});
				global::System.Console.ResetColor();
				this.f(this, global::System.EventArgs.Empty);
				global::System.Console.ForegroundColor = global::System.ConsoleColor.Green;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("즋뚕ﮗﮙ肟횡첣쎥袧쎩슫\udaad햯삱튳ힵ\udbb7\udfb9鲻芽뮿맃뇉﷋돍", a_), new object[]
				{
					this.h,
					this.w()
				});
				global::System.Console.ResetColor();
				num = (short)233635841;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_171:
			IL_173:
			num = (short)1112997889;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003EB0 File Offset: 0x000020B0
		private void o()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)728357848;
					short num3 = num2;
					num2 = (short)77323224;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CC;
					default:
						num2 = (short)627441664;
						if (num2 != 0)
						{
						}
						this.a(this);
						num2 = (short)1214906369;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_CC;
				case 2:
					if (this.a != null)
					{
						num2 = (short)1565655040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_CC:
			num2 = (short)649592833;
			if (num2 != 0)
			{
			}
			num2 = (short)661782528;
			short num4 = num2;
			return;
			IL_1C:
			this.b.Set();
			num2 = (short)849936386;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003FDC File Offset: 0x000021DC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void q(global::System.EventHandler A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			short num;
			int num2;
			global::System.EventHandler eventHandler;
			for (;;)
			{
				IL_0A:
				num = (short)961806337;
				if (num != 0)
				{
				}
				global::System.EventHandler eventHandler2;
				switch (num2)
				{
				case 0:
				{
					num = (short)524873791;
					short num3 = num;
					num = (short)1530785855;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_101;
					default:
						num = (short)1255669760;
						if (num != 0)
						{
						}
						if (eventHandler == eventHandler2)
						{
							num = (short)964952065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_60;
					}
					break;
				}
				case 1:
					goto IL_101;
				case 2:
					goto IL_60;
				}
				goto IL_43;
				IL_60:
				eventHandler2 = eventHandler;
				global::System.EventHandler value = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, A_0);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.p, value, eventHandler2);
				num = (short)436731904;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_101:
			num = (short)702808064;
			short num4 = num;
			return;
			IL_43:
			eventHandler = this.p;
			num = (short)1424752642;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004114 File Offset: 0x00002314
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void o(global::System.EventHandler A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.EventHandler eventHandler;
			for (;;)
			{
				IL_0A:
				global::System.EventHandler eventHandler2;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1817026801;
					short num3 = num2;
					num2 = (short)840605937;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FD;
					default:
						num2 = (short)1387397121;
						if (num2 != 0)
						{
						}
						num2 = (short)1758593024;
						if (num2 != 0)
						{
						}
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1197277185;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					break;
				}
				case 1:
					goto IL_FD;
				case 2:
					goto IL_39;
				}
				goto IL_1C;
				IL_39:
				eventHandler2 = eventHandler;
				global::System.EventHandler value = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, A_0);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.p, value, eventHandler2);
				num2 = (short)836829184;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FD:
			num2 = (short)1754202112;
			short num4 = num2;
			return;
			IL_1C:
			eventHandler = this.p;
			num2 = (short)1227161602;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000424C File Offset: 0x0000244C
		public void r(global::System.EventHandler A_0)
		{
			short num = (short)496661308;
			short num2 = num;
			num = (short)1091007292;
			switch (num2 == num)
			{
			}
			num = (short)830734336;
			short num3 = num;
			num = (short)510787585;
			if (num != 0)
			{
			}
			num = (short)1583939584;
			if (num != 0)
			{
			}
			this.q(A_0);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000042FC File Offset: 0x000024FC
		public void s(global::System.EventHandler A_0)
		{
			short num = (short)292106821;
			short num2 = num;
			num = (short)1991193157;
			switch (num2 == num)
			{
			}
			num = (short)2004287488;
			short num3 = num;
			num = (short)1776615425;
			if (num != 0)
			{
			}
			num = (short)524091392;
			if (num != 0)
			{
			}
			this.o(A_0);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000043AC File Offset: 0x000025AC
		public void Dispose()
		{
			short num = (short)1794730575;
			short num2 = num;
			num = (short)250964559;
			switch (num2 == num)
			{
			}
			num = (short)2121138176;
			short num3 = num;
			num = (short)475791361;
			if (num != 0)
			{
			}
			num = (short)570294272;
			if (num != 0)
			{
			}
			this.o(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004460 File Offset: 0x00002660
		protected virtual void o(bool A_0)
		{
			short num;
			try
			{
				num = (short)1539506180;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1B5;
					case 1:
						this.b.Close();
						this.b = null;
						this.o(null);
						goto IL_103;
					case 2:
						if (A_0)
						{
							num = (short)1268383745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B5;
					case 3:
						goto IL_177;
					case 4:
					{
						num = (short)2033517407;
						short num3 = num;
						num = (short)603521887;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_103;
						default:
							num = (short)1743585280;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_95;
							}
							continue;
						}
						break;
					}
					case 5:
						this.p(this, global::System.EventArgs.Empty);
						this.p = null;
						num = (short)1874657283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1CC;
					case 7:
						if (this.p != null)
						{
							num = (short)1983381509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_177;
					case 8:
						num = (short)2113404930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_95:
					if (!this.o)
					{
						num = (short)740753416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B5;
					IL_103:
					num = (short)265289735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_177:
					this.e = null;
					this.d = null;
					this.c = null;
					this.f = null;
					this.g = null;
					num = (short)1264844800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B5:
					num = (short)2091843590;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1CC:;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
			}
			finally
			{
				num = (short)467140609;
				if (num != 0)
				{
				}
				this.o = true;
			}
			num = (short)1320484864;
			short num4 = num;
		}

		// Token: 0x04000009 RID: 9
		private global::System.AsyncCallback a;

		// Token: 0x0400000A RID: 10
		private global::System.Threading.ManualResetEvent b;

		// Token: 0x0400000B RID: 11
		private global::System.EventHandler c;

		// Token: 0x0400000C RID: 12
		private global::System.EventHandler d;

		// Token: 0x0400000D RID: 13
		private global::System.EventHandler e;

		// Token: 0x0400000E RID: 14
		private global::System.EventHandler f;

		// Token: 0x0400000F RID: 15
		private global::System.EventHandler g;

		// Token: 0x04000010 RID: 16
		private string h;

		// Token: 0x04000011 RID: 17
		private object i = new object();

		// Token: 0x04000012 RID: 18
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private object j;

		// Token: 0x04000013 RID: 19
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Exception k;

		// Token: 0x04000014 RID: 20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string l;

		// Token: 0x04000015 RID: 21
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.Service.a m;

		// Token: 0x04000016 RID: 22
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private object n;

		// Token: 0x04000017 RID: 23
		private bool o;

		// Token: 0x04000018 RID: 24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler p;
	}
}
