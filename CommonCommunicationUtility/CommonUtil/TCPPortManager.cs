using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000048 RID: 72
	public class TCPPortManager
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000B2CC File Offset: 0x000094CC
		public static global::Motorola.Common.Communication.CommonUtil.TCPPortManager Instance
		{
			get
			{
				short num = (short)322306048;
				short num2 = num;
				num = (short)1215736230;
				short num3 = num;
				num = (short)702851494;
				switch (num3 == num)
				{
				}
				num = (short)96272385;
				if (num != 0)
				{
				}
				num = (short)773455872;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommonUtil.TCPPortManager.a;
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000B378 File Offset: 0x00009578
		private TCPPortManager()
		{
			this.MinPortNumber = 0;
			this.MaxPortNumber = 0;
			this.d = new global::System.Collections.Generic.List<int>();
			this.e = new global::System.Collections.Generic.List<int>();
			this.f = new object();
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000B3BC File Offset: 0x000095BC
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000B468 File Offset: 0x00009668
		public int MinPortNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)32964608;
				short num2 = num;
				num = (short)1659472622;
				short num3 = num;
				num = (short)1600359150;
				switch (num3 == num)
				{
				}
				num = (short)884998145;
				if (num != 0)
				{
				}
				num = (short)710737920;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)317611846;
				short num2 = num;
				num = (short)1592680262;
				switch (num2 == num)
				{
				}
				num = (short)1740701697;
				if (num != 0)
				{
				}
				num = (short)1064173568;
				short num3 = num;
				num = (short)199819264;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000B51C File Offset: 0x0000971C
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000B5CC File Offset: 0x000097CC
		public int MaxPortNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1265172481;
				if (num != 0)
				{
				}
				num = (short)363876267;
				short num2 = num;
				num = (short)2140229547;
				switch (num2 == num)
				{
				}
				num = (short)1284571136;
				short num3 = num;
				num = (short)71106560;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1156465196;
				short num2 = num;
				num = (short)1738293804;
				switch (num2 == num)
				{
				}
				num = (short)269090816;
				if (num != 0)
				{
				}
				num = (short)278855680;
				short num3 = num;
				num = (short)172359681;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000B680 File Offset: 0x00009880
		public void Reserve(int port)
		{
			object obj = this.f;
			bool flag = false;
			short num;
			try
			{
				num = (short)1153607927;
				short num2 = num;
				num = (short)88451319;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_75;
				default:
					num = (short)866648064;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_75;
					}
					break;
				}
				int num3;
				for (;;)
				{
					IL_5F:
					switch (num3)
					{
					case 0:
						num = (short)783745025;
						if (num != 0)
						{
						}
						goto IL_101;
					case 1:
						goto IL_118;
					case 2:
						if (!this.d.Contains(port))
						{
							num = (short)1966931971;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101;
					case 3:
						this.d.Add(port);
						num = (short)1813839872;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_75;
					IL_101:
					num = (short)1239613441;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_118:
				goto IL_183;
				IL_75:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num = (short)740950018;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5F;
			}
			finally
			{
				num = (short)1606418434;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)230227969;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_180;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_14B;
						}
						continue;
					}
					IL_14B:
					if (!flag)
					{
						break;
					}
					num = (short)2043084800;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_180:;
			}
			IL_183:
			num = (short)112132096;
			short num4 = num;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000B858 File Offset: 0x00009A58
		public int GetAvailable()
		{
			short num = (short)1872887808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::System.Net.IPEndPoint[] activeTcpListeners;
				global::System.Collections.Generic.List<int> list;
				for (;;)
				{
					IL_28:
					object obj;
					bool flag;
					switch (num2)
					{
					case 0:
						if (activeTcpListeners != null)
						{
							num = (short)739966981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EE;
					case 1:
						goto IL_3EE;
					case 2:
					{
						int num3;
						global::System.Net.IPEndPoint[] array;
						if (num3 >= array.Length)
						{
							num = (short)259850241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Net.IPEndPoint ipendPoint = array[num3];
						list.Add(ipendPoint.Port);
						num3++;
						num = (short)1148911619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_490;
					case 4:
					{
						num = (short)1090977792;
						short num4 = num;
						goto IL_490;
					}
					case 5:
					{
						global::System.Net.IPEndPoint[] array = activeTcpListeners;
						int num3 = 0;
						num = (short)757006340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_E5;
							}
							int num3;
							for (;;)
							{
								IL_9E:
								int num5;
								int num6;
								int num7;
								switch (num2)
								{
								case 0:
									goto IL_356;
								case 1:
									if (!this.d.Contains(num5))
									{
										num = (short)205193221;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_297;
								case 2:
									if (!list.Contains(num5))
									{
										num = (short)558956551;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_297;
								case 3:
									num = (short)751435790;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (this.MinPortNumber >= 0)
									{
										num = (short)338624515;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)423297032;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									IL_268:
									this.e.Add(num5);
									num3 = num5;
									num = (short)891682826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_301;
								case 7:
									num = (short)1854603265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num6 = 0;
									goto IL_164;
								case 9:
									num = (short)539492352;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_292;
								case 11:
									num = (short)2072641538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (num5 > num7)
									{
										num = (short)425984009;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)125632527;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_301;
								case 14:
									num6 = this.MinPortNumber;
									goto IL_164;
								case 15:
									if (!this.e.Contains(num5))
									{
										num = (short)1130037259;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_297;
								}
								goto IL_E5;
								IL_164:
								num7 = ((this.MaxPortNumber > 65535) ? 65535 : this.MaxPortNumber);
								num5 = num6;
								num = (short)760152070;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_297:
								num = (short)1113786902;
								short num8 = num;
								num = (short)1896090134;
								switch ((num8 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_268;
								default:
									num = (short)1442447360;
									if (num != 0)
									{
									}
									num5++;
									num = (short)1863843853;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_301:
								num = (short)1608974348;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_292:
							return num3;
							IL_356:
							return -1;
							IL_E5:
							global::System.Threading.Monitor.Enter(obj, ref flag);
							num = (short)2061303812;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_9E;
						}
						finally
						{
							num = (short)1286799362;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									global::System.Threading.Monitor.Exit(obj);
									num = (short)1065156609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3EB;
								case 2:
									num = (short)1647902721;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_3B3;
									}
									continue;
								}
								IL_3B3:
								if (!flag)
								{
									break;
								}
								num = (short)1928593408;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3EB:;
						}
						goto IL_3EE;
					}
					goto IL_4B;
					IL_3EE:
					obj = this.f;
					flag = false;
					num = (short)1409286150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_490:
					num = (short)1177550850;
					num2 = (int)((global::System.IntPtr)num);
				}
				return -1;
				IL_4B:
				activeTcpListeners = global::System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners();
				list = new global::System.Collections.Generic.List<int>();
				num = (short)1057882112;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000BD50 File Offset: 0x00009F50
		public void Unreserve(int port)
		{
			object obj = this.f;
			bool flag = false;
			short num;
			try
			{
				global::System.Threading.Monitor.Enter(obj, ref flag);
				this.d.Remove(port);
			}
			finally
			{
				num = (short)225247234;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_E4;
					case 1:
						goto IL_105;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_55;
						}
						continue;
					}
					IL_55:
					if (!flag)
					{
						break;
					}
					num = (short)1711594685;
					short num3 = num;
					num = (short)1529076925;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1846149121;
						if (num != 0)
						{
						}
						num = (short)1629093888;
						if (num != 0)
						{
						}
						num = (short)1256259584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E4:
					global::System.Threading.Monitor.Exit(obj);
					num = (short)1142423553;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_105:;
			}
			num = (short)255918080;
			short num4 = num;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000BEA0 File Offset: 0x0000A0A0
		public void Release(int port)
		{
			object obj = this.f;
			bool flag = false;
			short num;
			try
			{
				global::System.Threading.Monitor.Enter(obj, ref flag);
				this.e.Remove(port);
			}
			finally
			{
				num = (short)1555300354;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_BD;
					case 1:
						goto IL_DD;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					}
					IL_57:
					if (!flag)
					{
						break;
					}
					num = (short)191465011;
					short num3 = num;
					num = (short)261064243;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)979632128;
						if (num != 0)
						{
						}
						num = (short)732299264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_BD:
					global::System.Threading.Monitor.Exit(obj);
					num = (short)1925513217;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DD:;
			}
			num = (short)1873215488;
			short num4 = num;
			num = (short)386596865;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000BFEC File Offset: 0x0000A1EC
		// Note: this type is marked as 'beforefieldinit'.
		static TCPPortManager()
		{
			short num = (short)2082799617;
			if (num != 0)
			{
			}
			num = (short)1446194124;
			short num2 = num;
			num = (short)1223568332;
			switch (num2 == num)
			{
			}
			num = (short)1560477696;
			short num3 = num;
			num = (short)231735296;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TCPPortManager.a = new global::Motorola.Common.Communication.CommonUtil.TCPPortManager();
		}

		// Token: 0x04000224 RID: 548
		private static global::Motorola.Common.Communication.CommonUtil.TCPPortManager a;

		// Token: 0x04000225 RID: 549
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int b;

		// Token: 0x04000226 RID: 550
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int c;

		// Token: 0x04000227 RID: 551
		private global::System.Collections.Generic.List<int> d;

		// Token: 0x04000228 RID: 552
		private global::System.Collections.Generic.List<int> e;

		// Token: 0x04000229 RID: 553
		private object f;
	}
}
