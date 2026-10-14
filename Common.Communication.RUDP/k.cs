using System;
using System.Collections.Generic;
using System.Threading;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000013 RID: 19
	internal static class k
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00012560 File Offset: 0x00010760
		public static global::Motorola.Common.Communication.RUDP.i b(global::Motorola.Common.Communication.RUDP.b A_0)
		{
			short num = (short)1878392832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::Motorola.Common.Communication.RUDP.i i;
				global::Motorola.Common.Communication.RUDP.RUDPConfigParams rudpconfigParams;
				for (;;)
				{
					IL_28:
					global::Motorola.Common.Communication.RUDP.i obj;
					bool flag;
					switch (num2)
					{
					case 0:
					{
						if (A_0.ah() == null)
						{
							num = (short)869531650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1849229312;
						short num3 = num;
						num = (short)1318259253;
						short num4 = num;
						num = (short)344001077;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)315883520;
							if (num != 0)
							{
							}
							i = A_0.ah();
							num = (short)1669857283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)1773076481;
						if (num != 0)
						{
						}
						try
						{
							global::System.Threading.Monitor.Enter(obj, ref flag);
							i.i.d(true);
							i.i.ao(false);
							i.i.ar(false);
							i.i.@as(false);
							i.i.at(false);
							i.i.au(false);
							i.i.ao(global::Motorola.Common.Communication.RUDP.c.s);
							i.i.d(A_0.ac());
							i.i.ao(global::Motorola.Common.Communication.RUDP.c.a);
							i.k.d(global::Motorola.Common.Communication.RUDP.g.a);
							i.k.ar().d((ushort)rudpconfigParams.SynNegociateParameters.maximal_number_of_outstanding_unacknowledged_fragment);
							i.k.ar().ao((ushort)rudpconfigParams.SynNegociateParameters.maximal_fragment_size);
							i.k.ar().d(rudpconfigParams.SynNegociateParameters.sequenced_delivery_mode == 1);
							i.i.ar((byte)(i.f / 2));
							return i;
						}
						finally
						{
							num = (short)1209401344;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1B6;
									}
									continue;
								case 1:
									global::System.Threading.Monitor.Exit(obj);
									num = (short)884670466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1EC;
								}
								IL_1B6:
								if (!flag)
								{
									break;
								}
								num = (short)1836777473;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1EC:;
						}
						goto IL_1EF;
					case 2:
						i = new global::Motorola.Common.Communication.RUDP.i(true);
						A_0.n(i);
						num = (short)266797060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1EF;
					case 4:
						goto IL_1EF;
					}
					goto IL_43;
					IL_1EF:
					i.m = true;
					obj = A_0.ah();
					flag = false;
					num = (short)81002497;
					num2 = (int)((global::System.IntPtr)num);
				}
				return i;
				IL_43:
				rudpconfigParams = A_0.an();
				i = null;
				num = (short)896466944;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00012880 File Offset: 0x00010A80
		public static global::Motorola.Common.Communication.RUDP.i a(global::Motorola.Common.Communication.RUDP.b A_0, global::Motorola.Common.Communication.RUDP.i A_1)
		{
			short num = (short)1214447616;
			short num2 = num;
			num = (short)1736229511;
			short num3 = num;
			num = (short)67093127;
			global::Motorola.Common.Communication.RUDP.i i;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1439105024;
				if (num != 0)
				{
				}
				i = null;
				i = global::Motorola.Common.Communication.RUDP.k.a(true);
				global::Motorola.Common.Communication.RUDP.i obj = A_0.ah();
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B6;
					}
					int num4;
					for (;;)
					{
						IL_94:
						switch (num4)
						{
						case 0:
							if (A_1 == null)
							{
								num = (short)1384906754;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							i.bb();
							i.i.d(A_0.ae());
							i.i.ao(A_1.i.az());
							A_1.h = true;
							num = (short)273154051;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1559035905;
							if (num != 0)
							{
							}
							i.k.@as().d((byte)A_0.an().MaxNumberofRetries);
							i.k.@as().@as((byte)(A_0.an().MaxTimeBetweenRetries / global::Motorola.Common.Communication.RUDP.c.w));
							i.k.@as().at((byte)(A_0.an().InactivityTimeout / global::Motorola.Common.Communication.RUDP.c.w));
							i.k.@as().ao((byte)(A_0.an().TimeBetweenRetries / global::Motorola.Common.Communication.RUDP.c.w));
							i.k.@as().ar((byte)A_0.an().RetryCurveShape);
							i.k.@as().au((byte)(A_0.an().CloseWaitTimeout / global::Motorola.Common.Communication.RUDP.c.w));
							num = (short)2107441158;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							i.i.d(A_0.ac() + 1);
							i.i.ao(A_0.af());
							i.m = true;
							i.k.d(global::Motorola.Common.Communication.RUDP.g.b);
							num = (short)802684932;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_324;
						case 4:
							if (i.k.@as() != null)
							{
								num = (short)574357505;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_319;
						case 5:
							goto IL_34F;
						case 6:
							goto IL_324;
						}
						goto IL_B6;
						IL_324:
						i.i.ar((byte)(i.f / 2));
						num = (short)1181483013;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_319:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_HandshakePacketInitFailed);
					IL_34F:
					break;
					IL_B6:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					i.i.d(false);
					i.i.ao(true);
					i.i.ar(false);
					i.i.@as(false);
					i.i.at(false);
					i.i.au(false);
					i.i.ao(global::Motorola.Common.Communication.RUDP.c.s);
					num = (short)2088239104;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_94;
				}
				finally
				{
					num = (short)839778304;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_381;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1343619074;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_3B6;
						}
						IL_381:
						if (!flag)
						{
							break;
						}
						num = (short)422576129;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_3B6:;
				}
				break;
			}
			}
			return i;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00012C64 File Offset: 0x00010E64
		public static global::Motorola.Common.Communication.RUDP.i a(global::Motorola.Common.Communication.RUDP.b A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.RUDP.i i;
			for (;;)
			{
				IL_0A:
				global::Motorola.Common.Communication.RUDP.i obj;
				bool flag;
				switch (num)
				{
				case 0:
					if (A_0.ah() == null)
					{
						num2 = (short)206569474;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					i = A_0.ah();
					num2 = (short)622592003;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					try
					{
						global::System.Threading.Monitor.Enter(obj, ref flag);
						i.i.d(false);
						i.i.ao(false);
						i.i.ar(false);
						i.i.@as(true);
						i.i.at(false);
						i.i.au(false);
						i.i.ao(global::Motorola.Common.Communication.RUDP.c.s);
						i.i.d(A_0.ae());
						i.i.ao(A_0.af());
						i.i.ar(global::Motorola.Common.Communication.RUDP.c.b / 2);
						i.bb();
						return i;
					}
					finally
					{
						num2 = (short)365035520;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_17F;
								}
								continue;
							case 1:
							{
								num2 = (short)1654998242;
								short num3 = num2;
								num2 = (short)2076853474;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num2 = (short)749010944;
									if (num2 != 0)
									{
									}
									global::System.Threading.Monitor.Exit(obj);
									break;
								}
								num2 = (short)582352898;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 2:
								goto IL_201;
							}
							IL_17F:
							if (!flag)
							{
								break;
							}
							num2 = (short)1853882369;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_201:;
					}
					goto IL_204;
				case 2:
					num2 = (short)1102774273;
					if (num2 != 0)
					{
					}
					i = global::Motorola.Common.Communication.RUDP.k.a(true);
					num2 = (short)418578436;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_204;
				case 4:
					goto IL_204;
				}
				goto IL_24;
				IL_204:
				obj = A_0.ah();
				flag = false;
				num2 = (short)909312001;
				num = (int)((global::System.IntPtr)num2);
			}
			return i;
			IL_24:
			i = null;
			num2 = (short)913375232;
			short num4 = num2;
			num2 = (short)1779630080;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00012EEC File Offset: 0x000110EC
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i> a(global::Motorola.Common.Communication.RUDP.b A_0, byte[] A_1, int A_2, int A_3)
		{
			short num = (short)1499660288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1171587072;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_74;
				}
				int num4;
				bool a_;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i> list;
				int num5;
				int num6;
				for (;;)
				{
					IL_51:
					switch (num2)
					{
					case 0:
						num4 = A_0.ar();
						a_ = true;
						num = (short)1441792002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1864892417;
						if (num != 0)
						{
						}
						goto IL_19E;
					case 2:
						goto IL_19E;
					case 3:
						return list;
					case 4:
						if (num5 >= A_3)
						{
							num = (short)323551235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_110;
					case 5:
					{
						if (num6 - num5 <= A_0.ar())
						{
							num4 = num6 - num5;
							a_ = false;
							num = (short)218693633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)617859341;
						short num7 = num;
						num = (short)763218189;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_19E;
						default:
							num = (short)422313984;
							if (num != 0)
							{
							}
							num = (short)1671102464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_110;
					}
					goto IL_74;
					IL_110:
					num = (short)927203333;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19E:
					global::Motorola.Common.Communication.RUDP.i item = global::Motorola.Common.Communication.RUDP.k.a(A_0, A_1, num5, num4, a_);
					list.Add(item);
					num5 += num4;
					num = (short)1436286980;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_74:
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>();
				num4 = 0;
				a_ = false;
				num5 = A_2;
				num6 = A_2 + A_3;
				num = (short)2023686150;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000130EC File Offset: 0x000112EC
		private static global::Motorola.Common.Communication.RUDP.i a(global::Motorola.Common.Communication.RUDP.b A_0, byte[] A_1, int A_2, int A_3, bool A_4)
		{
			short num = (short)98978630;
			short num2 = num;
			num = (short)528567110;
			switch (num2 == num)
			{
			}
			num = (short)948240384;
			if (num != 0)
			{
			}
			num = (short)1073545216;
			short num3 = num;
			num = (short)1362558977;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.RUDP.i i = global::Motorola.Common.Communication.RUDP.k.a(false);
			i.i.d(false);
			i.i.ao(true);
			i.i.ar(false);
			i.i.@as(false);
			i.i.at(false);
			i.i.au(A_4);
			i.i.ao(global::Motorola.Common.Communication.RUDP.c.s);
			i.i.d(A_0.ae());
			i.i.ao(A_0.af());
			i.i.ar(global::Motorola.Common.Communication.RUDP.c.b / 2);
			i.l.ao(new byte[A_3]);
			global::System.Array.Copy(A_1, A_2, i.l.ar(), 0, A_3);
			return i;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00013250 File Offset: 0x00011450
		private static global::Motorola.Common.Communication.RUDP.i a(bool A_0)
		{
			short num = (short)1591100734;
			short num2 = num;
			num = (short)595805502;
			switch (num2 == num)
			{
			}
			num = (short)1239678977;
			if (num != 0)
			{
			}
			num = (short)505020416;
			short num3 = num;
			num = (short)718077952;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.RUDP.i(A_0);
		}
	}
}
