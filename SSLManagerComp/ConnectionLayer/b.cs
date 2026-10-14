using System;
using System.Reflection;
using System.Threading;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000035 RID: 53
	[global::System.Reflection.DefaultMember("Item")]
	internal class b
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00011EA4 File Offset: 0x000100A4
		private byte c(int A_0)
		{
			int a_ = 13;
			short num = (short)582226026;
			short num2 = num;
			num = (short)62853226;
			byte result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)106496000;
				if (num != 0)
				{
				}
				num = (short)1981808641;
				if (num != 0)
				{
				}
				byte[] obj = this.d;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_AE;
					}
					int num3;
					for (;;)
					{
						IL_90:
						switch (num3)
						{
						case 0:
							goto IL_198;
						case 1:
							if (A_0 >= this.a())
							{
								num = (short)722075650;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)626655236;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_E7;
						case 3:
							goto IL_125;
						case 4:
							if (A_0 + this.b < this.a)
							{
								num = (short)571015173;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = this.d[A_0 + this.b - this.a];
							num = (short)2068381696;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							result = this.d[A_0 + this.b];
							num = (short)1544159235;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE;
					}
					IL_E7:
					throw new global::System.ApplicationException(global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("績㕀㝂⁄⩆㥈㽊浌㭎㹐獒❔㉖㡘㡚㕜罞๠ᙢᅤ䝦٨Ṫᥬᱮᡰᝲၴ坶ᙸᵺ嵼୾ꖄﲈ", a_));
					IL_125:
					IL_198:
					break;
					IL_AE:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)1530134529;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_90;
				}
				finally
				{
					num = (short)490012672;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1CA;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)638844930;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1FE;
						}
						IL_1CA:
						if (!flag)
						{
							break;
						}
						num = (short)893386753;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1FE:;
				}
				break;
			}
			}
			num = (short)561971200;
			short num4 = num;
			return result;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000120F8 File Offset: 0x000102F8
		public b(int A_0)
		{
			this.a = A_0;
			this.d = new byte[A_0];
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00012120 File Offset: 0x00010320
		public void a(byte[] A_0, int A_1)
		{
			int a_ = 8;
			short num = (short)570490882;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2B5;
				case 1:
					goto IL_34A;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 3:
					goto IL_397;
				case 4:
					if (A_0.Length >= A_1)
					{
						num = (short)560791552;
						short num3 = num;
						num = (short)1540882437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					num = (short)1755643910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					if (A_1 < 1)
					{
						num = (short)2140864513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)307822593;
					if (num != 0)
					{
					}
					byte[] obj = this.d;
					bool flag = false;
					num = (short)591134723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4A:
				if (A_0 == null)
				{
					break;
				}
				num = (short)837527830;
				short num4 = num;
				num = (short)1054779670;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)643825664;
					if (num != 0)
					{
					}
					num = (short)1939406848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_2B5:
				num = (short)1712455684;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_34A:
			return;
			IL_397:
			try
			{
				switch (0)
				{
				case 0:
					goto IL_E6;
				}
				for (;;)
				{
					IL_C4:
					switch (num2)
					{
					case 0:
						goto IL_12D;
					case 1:
						global::System.Array.Copy(A_0, this.a - this.c, this.d, 0, A_1 - (this.a - this.c));
						num = (short)1680211973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.a + this.b - this.c < A_1)
						{
							num = (short)846856192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)580845572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_246;
					case 4:
						global::System.Array.Copy(A_0, 0, this.d, this.c, (this.a - this.c > A_1) ? A_1 : (this.a - this.c));
						num = (short)2023358470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_21A;
					case 6:
						if (this.a - this.c < A_1)
						{
							num = (short)754515969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21A;
					}
					goto IL_E6;
					IL_21A:
					this.c = (this.c + A_1) % this.a;
					num = (short)1894187011;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12D:
				throw new global::System.ApplicationException(global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("眹夻䴽㌿⍁⍃⍅桇㵉⍋⁍睏♑瑓さㅗ⹙籛㝝๟䉡٣፥๧౩५ᱭ幯", a_));
				IL_246:
				return;
				IL_E6:
				byte[] obj;
				bool flag;
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num = (short)955842562;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_C4;
			}
			finally
			{
				num = (short)490864640;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_27B;
						}
						continue;
					case 1:
					{
						byte[] obj;
						global::System.Threading.Monitor.Exit(obj);
						num = (short)1913061378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_2B1;
					}
					IL_27B:
					bool flag;
					if (!flag)
					{
						break;
					}
					num = (short)954073089;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2B1:;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000124E8 File Offset: 0x000106E8
		public void a(byte[] A_0)
		{
			short num = (short)1267859456;
			short num2 = num;
			num = (short)264626996;
			short num3 = num;
			num = (short)865461044;
			switch (num3 == num)
			{
			}
			num = (short)27328512;
			if (num != 0)
			{
			}
			num = (short)475529217;
			if (num != 0)
			{
			}
			this.a(A_0, A_0.Length);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0001259C File Offset: 0x0001079C
		private int a()
		{
			short num = (short)637179013;
			short num2 = num;
			num = (short)1209177221;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)683212801;
				if (num != 0)
				{
				}
				num = (short)488505344;
				if (num != 0)
				{
				}
				byte[] obj = this.d;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					int num3;
					for (;;)
					{
						IL_87:
						switch (num3)
						{
						case 0:
							if (this.c < this.b)
							{
								num = (short)780599298;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = this.c - this.b;
							num = (short)1066532865;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_132;
						case 2:
							result = this.c + (this.a - this.b);
							num = (short)276496387;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_106;
						}
						goto IL_9D;
					}
					IL_106:
					IL_132:
					break;
					IL_9D:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)714407936;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_87;
				}
				finally
				{
					num = (short)1916403712;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_165;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)477429762;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_198;
						}
						IL_165:
						if (!flag)
						{
							break;
						}
						num = (short)459079681;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_198:;
				}
				break;
			}
			}
			num = (short)904658944;
			short num4 = num;
			return result;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00012780 File Offset: 0x00010980
		private byte[] b(int A_0)
		{
			short num = (short)1107048419;
			short num2 = num;
			num = (short)2042574819;
			byte[] result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)336592896;
				if (num != 0)
				{
				}
				num = (short)1720254465;
				if (num != 0)
				{
				}
				num = (short)731054080;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					byte[] obj = this.d;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_CC;
						}
						byte[] array;
						for (;;)
						{
							IL_A5:
							switch (num3)
							{
							case 0:
								goto IL_22A;
							case 1:
							{
								int length = A_0 - (this.a - this.b);
								global::System.Array.Copy(this.d, 0, array, this.a - this.b, length);
								num = (short)2085814277;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								result = null;
								num = (short)28377094;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (A_0 > this.a())
								{
									num = (short)975175682;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								array = new byte[A_0];
								num = (short)1737818116;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								global::System.Array.Copy(this.d, this.b, array, 0, (this.b + A_0 > this.a) ? (this.a - this.b) : A_0);
								num = (short)831979527;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_211;
							case 6:
								goto IL_1B1;
							case 7:
								if (this.b + A_0 > this.a)
								{
									num = (short)1592262657;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_211;
							}
							goto IL_CC;
							IL_211:
							num = (short)994705408;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1B1:
						break;
						IL_22A:
						return array;
						IL_CC:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num = (short)1241513987;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_A5;
					}
					finally
					{
						num = (short)561971200;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_261;
								}
								continue;
							case 1:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1742077954;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_298;
							}
							IL_261:
							if (!flag)
							{
								break;
							}
							num = (short)1284505601;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_298:;
					}
					break;
				}
				}
				break;
			}
			}
			num = (short)279969792;
			short num4 = num;
			return result;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00012A70 File Offset: 0x00010C70
		private byte[] a(int A_0)
		{
			int a_ = 4;
			short num = (short)2117298336;
			short num2 = num;
			num = (short)524314784;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9C;
			case 1:
				break;
			default:
			{
				num = (short)1167654912;
				short num3 = num;
				break;
			}
			}
			num = (short)1886912512;
			if (num != 0)
			{
			}
			num = (short)1020198912;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				IL_9C:
				num = (short)1579024385;
				if (num != 0)
				{
				}
				byte[] obj = this.d;
				bool flag = false;
				byte[] result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_100;
					}
					for (;;)
					{
						IL_D9:
						byte[] array;
						switch (num4)
						{
						case 0:
							goto IL_29C;
						case 1:
							goto IL_27F;
						case 2:
							goto IL_13E;
						case 3:
							if (A_0 > this.a())
							{
								num = (short)65863682;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							array = new byte[A_0];
							num = (short)1410596869;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_27F;
						case 5:
							global::System.Array.Copy(this.d, this.b, array, 0, (this.b + A_0 > this.a) ? (this.a - this.b) : A_0);
							num = (short)512819206;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (this.b + A_0 > this.a)
							{
								num = (short)633667591;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.b += A_0;
							this.b %= this.a;
							num = (short)930283521;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							int length = A_0 - (this.a - this.b);
							global::System.Array.Copy(this.d, 0, array, this.a - this.b, length);
							this.b = length;
							num = (short)1832386564;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_100;
						IL_27F:
						result = array;
						num = (short)409927680;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_13E:
					throw new global::System.ApplicationException(global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("堵圷丹᰻嬽⸿ⵁㅃⅅ⁇橉⡋⽍⑏㍑瑓㽕㙗穙⡛㙝՟䉡٣፥๧౩५ᱭ", a_));
					IL_29C:
					return result;
					IL_100:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)66125827;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_D9;
				}
				finally
				{
					num = (short)1848246272;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_2D1;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1967849474;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_309;
						}
						IL_2D1:
						if (!flag)
						{
							break;
						}
						num = (short)1545404417;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_309:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00012DA8 File Offset: 0x00010FA8
		public byte[] b()
		{
			short num = (short)956905110;
			short num2 = num;
			num = (short)1141192342;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B7;
			case 1:
				break;
			default:
			{
				num = (short)1773928448;
				short num3 = num;
				break;
			}
			}
			num = (short)2022309889;
			if (num != 0)
			{
			}
			num = (short)2056257536;
			if (num != 0)
			{
			}
			num = (short)107020288;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				IL_B7:
				byte[] obj = this.d;
				bool flag = false;
				byte[] result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_EF;
					}
					for (;;)
					{
						IL_CC:
						switch (num4)
						{
						case 0:
							result = null;
							num = (short)1416429572;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							result = null;
							num = (short)1730347013;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (this.a() < 6)
							{
								num = (short)168755200;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							ushort num5 = global::System.BitConverter.ToUInt16(this.b(2), 0);
							num = (short)2130182150;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_1D8;
						case 4:
							goto IL_145;
						case 5:
							goto IL_165;
						case 6:
						{
							ushort num5;
							if (this.a() < (int)(num5 + 2))
							{
								num = (short)1279393793;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = this.a((int)(num5 + 2));
							num = (short)802553859;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_EF;
					}
					IL_145:
					IL_165:
					IL_1D8:
					return result;
					IL_EF:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)100270082;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_CC;
				}
				finally
				{
					num = (short)1285554176;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_20C;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1845755906;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_241;
						}
						IL_20C:
						if (!flag)
						{
							break;
						}
						num = (short)614137857;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_241:;
				}
				return result;
			}
			}
		}

		// Token: 0x040000B4 RID: 180
		private readonly int a;

		// Token: 0x040000B5 RID: 181
		private int b;

		// Token: 0x040000B6 RID: 182
		private int c;

		// Token: 0x040000B7 RID: 183
		protected byte[] d;
	}
}
