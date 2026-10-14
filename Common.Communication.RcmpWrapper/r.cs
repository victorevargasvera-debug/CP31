using System;
using System.Globalization;
using System.IO;
using System.Text;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000008 RID: 8
	internal static class r
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000031D8 File Offset: 0x000013D8
		public static int b()
		{
			short num = (short)1638248072;
			short num2 = num;
			num = (short)1341369992;
			switch (num2 == num)
			{
			}
			num = (short)260374528;
			short num3 = num;
			num = (short)1583153153;
			if (num != 0)
			{
			}
			num = (short)672268288;
			if (num != 0)
			{
			}
			return 3;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003280 File Offset: 0x00001480
		public static ushort a()
		{
			short num = (short)466700706;
			short num2 = num;
			num = (short)710035874;
			switch (num2 == num)
			{
			}
			num = (short)1813315584;
			short num3 = num;
			num = (short)2025390081;
			if (num != 0)
			{
			}
			num = (short)208142336;
			if (num != 0)
			{
			}
			return 32768;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000332C File Offset: 0x0000152C
		public static global::Motorola.Common.Communication.RcmpReplyResult a(byte[] A_0, int A_1, ushort A_2)
		{
			int a_ = 2;
			short num = (short)273030074;
			short num2 = num;
			num = (short)562437050;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1962344448;
				short num3 = num;
				num = (short)1535705088;
				if (num != 0)
				{
				}
				num = (short)1772158976;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_BA;
						}
						continue;
					case 1:
						if (A_0.Length - A_1 < global::Motorola.Common.Communication.r.b())
						{
							num = (short)678035461;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1075183620;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_13F;
					case 3:
						goto IL_D4;
					case 4:
						if ((ushort)((int)A_0[A_1] * 256 + (int)A_0[A_1 + 1]) != A_2)
						{
							num = (short)11665410;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5;
					case 5:
						goto IL_1A3;
					}
					IL_BA:
					if (A_0 == null)
					{
						num = (short)1219428355;
						num4 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1573191681;
						num4 = (int)((global::System.IntPtr)num);
					}
				}
				IL_D4:
				num = (short)11141121;
				if (num != 0)
				{
				}
				break;
				IL_13F:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidReplyOpcode);
				IL_1A3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidRcmpReplySize);
				IL_1A5:
				return (global::Motorola.Common.Communication.RcmpReplyResult)A_0[A_1 + 2];
			}
			}
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("", a_));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000034E4 File Offset: 0x000016E4
		public static void a(byte[] A_0, int A_1, int A_2, object[] A_3)
		{
			int a_ = 5;
			short num = (short)844496896;
			short num2 = num;
			num = (short)1376911360;
			switch (num)
			{
			default:
			{
				num = (short)738983937;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						if (A_3 == null)
						{
							num = (short)539951106;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(A_0, A_1, A_2, false);
						num = (short)1646526468;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_8E;
						}
						continue;
					case 2:
						goto IL_698;
					case 3:
						goto IL_AA;
					case 4:
						goto IL_6BC;
					}
					IL_8E:
					if (A_0 == null)
					{
						num = (short)1691222019;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)811270144;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_AA:
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ﲘ", a_));
				IL_63B:
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("﶐朗", a_));
				IL_698:
				goto IL_63B;
				IL_6BC:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_130;
					}
					int num4;
					for (;;)
					{
						IL_B9:
						switch (num3)
						{
						case 0:
							goto IL_5CC;
						case 1:
							if (A_3[num4] is uint)
							{
								num = (short)79757330;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)928251930;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)199426048;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_1DF;
						case 4:
						{
							byte[] array;
							if (array.Length == 0)
							{
								num = (short)38535179;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_524;
						}
						case 5:
						{
							global::System.Text.StringBuilder stringBuilder;
							A_3[num4] = stringBuilder.ToString();
							num = (short)1157365779;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::System.IO.MemoryStream memoryStream;
							byte[] array;
							if (memoryStream.Read(array, 0, array.Length) != array.Length)
							{
								num = (short)2053242887;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14F;
						}
						case 7:
							goto IL_56B;
						case 8:
							if (num4 >= A_3.Length)
							{
								num = (short)769196034;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1900412937;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (A_3[num4] is byte)
							{
								num = (short)233832461;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1840119833;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_1DF;
						case 11:
						{
							global::System.IO.MemoryStream memoryStream;
							byte[] array = A_3[num4] = new byte[memoryStream.Length - memoryStream.Position];
							num = (short)1762328588;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							goto IL_524;
						case 13:
						{
							global::System.IO.MemoryStream memoryStream;
							A_3[num4] = global::Motorola.Common.Communication.r.a(memoryStream);
							num = (short)78577678;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							goto IL_14F;
						case 15:
							goto IL_14F;
						case 16:
							goto IL_422;
						case 17:
							if (A_3[num4] is byte[])
							{
								num = (short)589103131;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_397;
						case 18:
						{
							global::System.IO.MemoryStream memoryStream;
							uint num5 = (uint)global::Motorola.Common.Communication.r.a(memoryStream) * 16777216U + (uint)global::Motorola.Common.Communication.r.a(memoryStream) * 65536U + (uint)global::Motorola.Common.Communication.r.a(memoryStream) * 256U + (uint)global::Motorola.Common.Communication.r.a(memoryStream);
							A_3[num4] = num5;
							num = (short)1901002772;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
							goto IL_14F;
						case 20:
							goto IL_14F;
						case 21:
							goto IL_422;
						case 22:
						{
							global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
							global::System.IO.MemoryStream memoryStream;
							int num6 = memoryStream.ReadByte();
							num = (short)1115619344;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
						{
							int num6;
							if (num6 <= 0)
							{
								num = (short)2038628357;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Text.StringBuilder stringBuilder;
							stringBuilder.Append((char)num6);
							global::System.IO.MemoryStream memoryStream;
							num6 = memoryStream.ReadByte();
							num = (short)1894383637;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
						{
							global::System.IO.MemoryStream memoryStream;
							ushort num7 = (ushort)((int)global::Motorola.Common.Communication.r.a(memoryStream) * 256 + (int)global::Motorola.Common.Communication.r.a(memoryStream));
							A_3[num4] = num7;
							num = (short)1234042895;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
						{
							num = (short)176493349;
							short num8 = num;
							num = (short)450171685;
							switch ((num8 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_524;
							default:
								num = (short)319684608;
								if (num != 0)
								{
								}
								if (A_3[num4] is ushort)
								{
									num = (short)672399384;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1251409921;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 26:
							if (A_3[num4] is string)
							{
								num = (short)1696923670;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1771241489;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
						{
							byte[] array = A_3[num4] as byte[];
							num = (short)1440612356;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_130;
						IL_14F:
						num4++;
						num = (short)123011075;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1DF:
						num = (short)640745480;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_422:
						num = (short)471007255;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_524:
						num = (short)1053753350;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_397:
					throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("쒐ﶒ햠욢솤螦\udda8튪\uddac쪮记鎲", a_) + A_3[num4].GetType().FullName);
					IL_56B:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidRcmpReplySize);
					IL_5CC:
					goto IL_6C1;
					IL_130:
					num4 = 0;
					num = (short)573440010;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_B9;
				}
				finally
				{
					num = (short)626130945;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.IO.MemoryStream memoryStream;
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)935526402;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_603;
							}
							continue;
						case 2:
							goto IL_638;
						}
						IL_603:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)1130037248;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_638:;
				}
				goto IL_63B;
				IL_6C1:
				num = (short)1674772481;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003BF8 File Offset: 0x00001DF8
		public static int a(byte[] A_0, int A_1, params object[] A_2)
		{
			int a_ = 4;
			short num = (short)978124800;
			switch (num)
			{
			default:
			{
				num = (short)1787297793;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (A_2 == null)
						{
							num = (short)801832962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(A_0, A_1, A_0.Length - A_1, true);
						num = (short)605880324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_63;
						}
						continue;
					case 2:
						goto IL_634;
					case 3:
						goto IL_AA;
					case 4:
						goto IL_65F;
					}
					IL_63:
					num = (short)1443102720;
					short num3 = num;
					if (A_0 == null)
					{
						num = (short)1649934339;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)874774528;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_AA:
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ﶗ", a_));
				IL_5B1:
				num = (short)1466761217;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ﲏﮑ", a_));
				IL_634:
				goto IL_5B1;
				IL_65F:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_11C;
					}
					object obj;
					int num4;
					for (;;)
					{
						IL_B9:
						switch (num2)
						{
						case 0:
							if (obj is string)
							{
								num = (short)507379716;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1943273475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::System.IO.MemoryStream memoryStream;
							byte[] array;
							memoryStream.Write(array, 0, array.Length);
							num = (short)1016332303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							byte[] array;
							if ((array = (obj as byte[])) != null)
							{
								num = (short)450494465;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E5;
						}
						case 3:
						{
							char[] chars;
							if ((chars = (obj as char[])) != null)
							{
								num = (short)589889549;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1502019586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(obj.ToString());
							global::System.IO.MemoryStream memoryStream;
							memoryStream.Write(bytes, 0, bytes.Length);
							memoryStream.WriteByte(0);
							num = (short)718209033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_20E;
						case 6:
							goto IL_13A;
						case 7:
							if (obj is byte)
							{
								num = (short)331087892;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2001600533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_533;
						case 9:
							goto IL_13A;
						case 10:
						{
							global::System.IO.MemoryStream memoryStream;
							num4 = (int)memoryStream.Position;
							num = (short)1494548488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							if (num4 >= A_2.Length)
							{
								num = (short)316997642;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							obj = A_2[num4];
							num = (short)1112997895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_13A;
						case 13:
						{
							char[] chars;
							byte[] bytes2 = global::System.Text.Encoding.ASCII.GetBytes(chars);
							global::System.IO.MemoryStream memoryStream;
							memoryStream.Write(bytes2, 0, bytes2.Length);
							num = (short)706281494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							goto IL_20E;
						case 15:
							goto IL_13A;
						case 16:
							if (obj is uint)
							{
								num = (short)258342930;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)751632384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
						{
							ushort num5 = (ushort)obj;
							global::System.IO.MemoryStream memoryStream;
							memoryStream.WriteByte((byte)(num5 >> 8 & 255));
							memoryStream.WriteByte((byte)(num5 & 255));
							num = (short)281608198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
						{
							uint num6 = (uint)obj;
							global::System.IO.MemoryStream memoryStream;
							memoryStream.WriteByte((byte)(num6 >> 24 & 255U));
							memoryStream.WriteByte((byte)(num6 >> 16 & 255U));
							memoryStream.WriteByte((byte)(num6 >> 8 & 255U));
							memoryStream.WriteByte((byte)(num6 & 255U));
							num = (short)142213132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
							goto IL_13A;
						case 20:
						{
							global::System.IO.MemoryStream memoryStream;
							memoryStream.WriteByte((byte)obj);
							num = (short)662175763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							if (!(obj is ushort))
							{
								num = (short)1047315466;
								short num7 = num;
								num = (short)738313226;
								switch ((num7 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)2002649088;
									if (num != 0)
									{
									}
									num = (short)1779826704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							num = (short)1049493521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							goto IL_13A;
						}
						goto IL_11C;
						IL_13A:
						num4++;
						num = (short)708837390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_20E:
						num = (short)1806696459;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1E5:
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("얏ﲑ풟잡삣蚥\udca7펩\udcab쮭誯銱쾳蚵얷", a_), obj.GetType().FullName));
					IL_533:
					return num4;
					IL_11C:
					num4 = 0;
					num = (short)145817605;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_B9;
				}
				catch (global::System.NotSupportedException systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InsufficientMessageBuffer, systemException);
				}
				finally
				{
					num = (short)1434189825;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.IO.MemoryStream memoryStream;
						switch (num2)
						{
						case 0:
							memoryStream.Dispose();
							num = (short)1739456514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_578;
							}
							continue;
						case 2:
							goto IL_5AE;
						}
						IL_578:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)662503424;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5AE:;
				}
				goto IL_5B1;
			}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000042A0 File Offset: 0x000024A0
		public static int a(string A_0, byte[] A_1, int A_2, bool A_3 = false)
		{
			short num;
			int result;
			try
			{
				num = (short)1660747776;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte[] bytes;
					byte[] array;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_41;
						}
						continue;
					case 1:
						bytes = global::System.Text.Encoding.Unicode.GetBytes(A_0);
						goto IL_D6;
					case 2:
						goto IL_15E;
					case 3:
						goto IL_10F;
					case 4:
						if (A_1.Length < A_2 + array.Length)
						{
							num = (short)2140012547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_136;
					case 5:
						num = (short)1787297798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						bytes = global::System.Text.Encoding.BigEndianUnicode.GetBytes(A_0);
						goto IL_D6;
					}
					IL_41:
					if (!A_3)
					{
						num = (short)462422017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2107641142;
					short num3 = num;
					num = (short)87493942;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_136;
					default:
						num = (short)1257242624;
						if (num != 0)
						{
						}
						num = (short)1065877509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D6:
					array = bytes;
					num = (short)224067588;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_136:
					global::System.Buffer.BlockCopy(array, 0, A_1, A_2, array.Length);
					result = array.Length;
					num = (short)803274754;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10F:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				IL_15E:;
			}
			catch (global::System.ArgumentNullException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull, systemException);
			}
			num = (short)544473089;
			if (num != 0)
			{
			}
			num = (short)1972699136;
			short num4 = num;
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004484 File Offset: 0x00002684
		public static int a(string A_0, ref byte[] A_1)
		{
			short num;
			int result;
			try
			{
				num = (short)844365824;
				switch (num)
				{
				default:
				{
					num = (short)1497628672;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						int num3;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_60;
							}
							continue;
						case 1:
							result = A_1.Length;
							num = (short)1293156354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_19E;
						case 3:
						{
							if (num3 >= A_1.Length)
							{
								num = (short)608632833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)551555053;
							short num4 = num;
							num = (short)702418925;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)1899102208;
								if (num != 0)
								{
								}
								string s = A_0.Substring(num3 * 2, 2);
								A_1[num3] = byte.Parse(s, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
								num3++;
								break;
							}
							}
							num = (short)1373896710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_143;
						case 5:
							goto IL_82;
						case 6:
							goto IL_143;
						}
						IL_60:
						if (A_0.Length % 2 != 0)
						{
							num = (short)543686661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_1 = new byte[A_0.Length / 2];
						num3 = 0;
						num = (short)791281668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_143:
						num = (short)2141388803;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_82:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
					IL_19E:
					num = (short)587464705;
					if (num != 0)
					{
					}
					break;
				}
				}
			}
			catch (global::System.ArgumentNullException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull, systemException);
			}
			num = (short)1432420352;
			short num5 = num;
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000046A8 File Offset: 0x000028A8
		public static string a(byte[] A_0, int A_1, int A_2)
		{
			short num;
			string result;
			try
			{
				num = (short)1694391127;
				short num2 = num;
				num = (short)243555159;
				switch (num2 == num)
				{
				}
				num = (short)578945024;
				if (num != 0)
				{
				}
				result = global::System.Text.Encoding.BigEndianUnicode.GetString(A_0, A_1, A_2).TrimEnd(new char[1]);
			}
			catch (global::System.ArgumentNullException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull, systemException);
			}
			catch (global::System.ArgumentOutOfRangeException systemException2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange, systemException2);
			}
			catch (global::System.ArithmeticException systemException3)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument, systemException3);
			}
			num = (short)2028929025;
			if (num != 0)
			{
			}
			num = (short)351272960;
			short num3 = num;
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000047AC File Offset: 0x000029AC
		public static uint b(byte[] A_0, int A_1)
		{
			short num = (short)537853953;
			int num2 = (int)((global::System.IntPtr)num);
			uint num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (A_0.Length < A_1 + 4)
					{
						num = (short)1448280066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = 0U;
					int num4 = A_1;
					num = (short)5832713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 2:
					goto IL_1E4;
				case 3:
					goto IL_113;
				case 4:
				{
					num = (short)828093614;
					short num5 = num;
					num = (short)288732334;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E9;
					default:
						num = (short)808124416;
						if (num != 0)
						{
						}
						if (A_1 < 0)
						{
							num = (short)88276999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1099497472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
				{
					int num4;
					if (num4 >= A_1 + 4)
					{
						num = (short)234618886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 <<= 8;
					num3 += (uint)A_0[num4];
					num4++;
					num = (short)325124099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_14B;
				case 7:
					goto IL_10E;
				case 8:
					goto IL_64;
				case 9:
					goto IL_113;
				}
				IL_4D:
				if (A_0 == null)
				{
					num = (short)1530200072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1530658820;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_113:
				num = (short)2052784133;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_64:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			IL_10E:
			goto IL_1E9;
			IL_14B:
			num = (short)198246400;
			short num6 = num;
			return num3;
			IL_1E4:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			IL_1E9:
			num = (short)591593473;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000049D0 File Offset: 0x00002BD0
		public static ushort a(byte[] A_0, int A_1)
		{
			short num = (short)1932066820;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1873674241;
					if (num != 0)
					{
					}
					if (A_1 < 0)
					{
						goto IL_164;
					}
					num = (short)1507655683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_17B;
				case 2:
					goto IL_108;
				case 3:
					if (A_0.Length < A_1 + 2)
					{
						num = (short)1538129922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17D;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					goto IL_CD;
				}
				IL_3C:
				num = (short)1246429184;
				short num3 = num;
				if (A_0 != null)
				{
					num = (short)1101987840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1590813698;
				short num4 = num;
				num = (short)1995498498;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)542834688;
					if (num != 0)
					{
					}
					num = (short)2140143621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_164:
				num = (short)127139841;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CD:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			IL_108:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			IL_17B:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			IL_17D:
			return (ushort)(((int)A_0[A_1] << 8) + (int)A_0[A_1 + 1]);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004B68 File Offset: 0x00002D68
		private static byte a(global::System.IO.Stream A_0)
		{
			short num = (short)1739033861;
			short num2 = num;
			num = (short)594251013;
			switch (num2 == num)
			{
			}
			num = (short)2054619136;
			if (num != 0)
			{
			}
			num = (short)1518665728;
			short num3 = num;
			num = (short)9437185;
			if (num != 0)
			{
			}
			int num4 = A_0.ReadByte();
			if (num4 < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UnexpectedEndOfMsg);
			}
			return (byte)num4;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004C2C File Offset: 0x00002E2C
		// Note: this type is marked as 'beforefieldinit'.
		static r()
		{
			short num = (short)1330063712;
			short num2 = num;
			num = (short)1378756960;
			switch (num2 == num)
			{
			}
			num = (short)1963655169;
			if (num != 0)
			{
			}
			num = (short)992477184;
			short num3 = num;
			num = (short)153354240;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.r.a = 0;
			global::Motorola.Common.Communication.r.b = 0;
			global::Motorola.Common.Communication.r.c = new byte[0];
			global::Motorola.Common.Communication.r.d = 0U;
		}

		// Token: 0x04000009 RID: 9
		public static readonly object a;

		// Token: 0x0400000A RID: 10
		public static readonly object b;

		// Token: 0x0400000B RID: 11
		public static readonly object c;

		// Token: 0x0400000C RID: 12
		public static readonly object d;
	}
}
