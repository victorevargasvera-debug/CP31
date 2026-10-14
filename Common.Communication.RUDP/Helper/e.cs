using System;
using System.Globalization;
using System.IO;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP.Helper
{
	// Token: 0x02000033 RID: 51
	internal static class e
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x0001EA68 File Offset: 0x0001CC68
		public static void a(ref byte A_0, bool A_1, byte A_2)
		{
			short num;
			for (;;)
			{
				num = (short)1979056129;
				if (num != 0)
				{
				}
				if (A_1)
				{
					break;
				}
				num = (short)504457918;
				short num2 = num;
				num = (short)1645505214;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_94;
				}
			}
			num = (short)767229952;
			short num3 = num;
			A_0 |= A_2;
			return;
			IL_94:
			num = (short)541655040;
			if (num != 0)
			{
			}
			byte b = ~A_2;
			A_0 &= b;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0001EB2C File Offset: 0x0001CD2C
		private static byte a(global::System.IO.Stream A_0)
		{
			short num = (short)1784348673;
			if (num != 0)
			{
			}
			num = (short)1018138049;
			short num2 = num;
			num = (short)779521473;
			switch (num2 == num)
			{
			}
			num = (short)420020224;
			if (num != 0)
			{
			}
			num = (short)804847616;
			short num3 = num;
			int num4 = A_0.ReadByte();
			if (num4 < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UnexpectedEndOfMsg);
			}
			return (byte)num4;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
		public static int a(byte[] A_0, int A_1, int A_2, object[] A_3)
		{
			int a_ = 12;
			short num = (short)1133445120;
			switch (num)
			{
			default:
			{
				num = (short)399638531;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)378142720;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_88C;
					case 1:
						goto IL_A7;
					case 2:
						goto IL_8B0;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 4:
					{
						if (A_3 == null)
						{
							num = (short)2015625216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(A_0, A_1, A_2, false);
						num = (short)1674510338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_8C:
					if (A_0 == null)
					{
						num = (short)83492865;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)546308100;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_A7:
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("刯䜱刳倵崷䠹", a_));
				IL_830:
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("尯嬱䜳䈵", a_));
				IL_88C:
				goto IL_830;
				IL_8B0:
				num = (short)1067450369;
				if (num != 0)
				{
				}
				try
				{
					switch (0)
					{
					case 0:
						goto IL_155;
					}
					int num4;
					int result;
					for (;;)
					{
						IL_B6:
						global::System.IO.MemoryStream memoryStream;
						switch (num2)
						{
						case 0:
							goto IL_772;
						case 1:
							goto IL_254;
						case 2:
							goto IL_730;
						case 3:
							if (num4 >= A_3.Length)
							{
								num = (short)937689113;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1744764946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_4DD;
						case 5:
							goto IL_730;
						case 6:
							if (A_3[num4] is byte)
							{
								num = (short)174194712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1094385680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
							int num5 = memoryStream.ReadByte();
							num = (short)1370488859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_751;
						case 9:
							goto IL_730;
						case 10:
						{
							global::Motorola.Common.Communication.RUDP.Helper.b b;
							if (b != null)
							{
								num = (short)1609039907;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_730;
						}
						case 11:
							goto IL_730;
						case 12:
							if (A_3[num4] is string)
							{
								num = (short)146604039;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)995819535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							byte[] array;
							if (memoryStream.Read(array, 0, array.Length) == array.Length)
							{
								num = (short)500629534;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_730;
						}
						case 14:
						{
							byte[] array2 = A_3[num4] as byte[];
							num = (short)611057681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							if (A_3[num4] is byte[])
							{
								num = (short)1776549902;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1266286615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							if (A_3[num4] is ushort)
							{
								num = (short)288620570;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1854603295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
						{
							byte[] array2;
							if (array2.Length == 0)
							{
								num = (short)795475987;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4DD;
						}
						case 18:
							if (memoryStream.Position == memoryStream.Length)
							{
								num = (short)832962582;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)995557382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
						{
							byte[] array2 = A_3[num4] = new byte[memoryStream.Length - memoryStream.Position];
							num = (short)1344798724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
						{
							int num5;
							if (num5 <= 0)
							{
								num = (short)1131216929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Text.StringBuilder stringBuilder;
							stringBuilder.Append((char)num5);
							num5 = memoryStream.ReadByte();
							num = (short)1359413277;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							goto IL_730;
						case 22:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("琯圱圳夵尷弹᰻氽ᔿفᑃ晅ᡇ⭉⽋╍㕏♑湓癕੗㽙㵛㵝࡟䉡ၣ๥൧䩩५mᑯ剱᭳ၵ塷⩹ᵻᵽ벅ꢇ궏꒓", a_), new object[]
							{
								memoryStream.Length
							});
							num = (short)765394952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
							if (A_3[num4] is global::Motorola.Common.Communication.RUDP.Helper.b)
							{
								num = (short)730595365;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_175;
						case 24:
							A_3[num4] = global::Motorola.Common.Communication.RUDP.Helper.e.a(memoryStream);
							num = (short)1345519625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							goto IL_751;
						case 26:
						{
							ushort num6 = (ushort)((int)global::Motorola.Common.Communication.RUDP.Helper.e.a(memoryStream) * 256 + (int)global::Motorola.Common.Communication.RUDP.Helper.e.a(memoryStream));
							A_3[num4] = num6;
							num = (short)861667330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 27:
							goto IL_474;
						case 28:
						{
							byte[] array2;
							if (memoryStream.Read(array2, 0, array2.Length) != array2.Length)
							{
								num = (short)434634784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_730;
						}
						case 29:
							goto IL_474;
						case 30:
						{
							global::Motorola.Common.Communication.RUDP.Helper.b b;
							byte[] array;
							memoryStream.Position = (long)b.f(array, 0, array.Length);
							num = (short)540082197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 31:
							if (A_3[num4] is uint)
							{
								num = (short)1974599714;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1363083276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							goto IL_525;
						case 33:
						{
							global::System.Text.StringBuilder stringBuilder;
							A_3[num4] = stringBuilder.ToString();
							num = (short)1110507531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 34:
						{
							uint num7 = (uint)global::Motorola.Common.Communication.RUDP.Helper.e.a(memoryStream) * 16777216U + (uint)global::Motorola.Common.Communication.RUDP.Helper.e.a(memoryStream) * 65536U + (uint)global::Motorola.Common.Communication.RUDP.Helper.e.a(memoryStream) * 256U + (uint)global::Motorola.Common.Communication.RUDP.Helper.e.a(memoryStream);
							A_3[num4] = num7;
							num = (short)166920197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 35:
						{
							byte[] array = new byte[memoryStream.Length - memoryStream.Position];
							num = (short)274006029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 36:
							goto IL_254;
						case 37:
						{
							global::Motorola.Common.Communication.RUDP.Helper.b b = A_3[num4] as global::Motorola.Common.Communication.RUDP.Helper.b;
							num = (short)1487601674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_155;
						IL_254:
						num = (short)1016332291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_474:
						num = (short)18677780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4DD:
						num = (short)1422589980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_730:
						num4++;
						num = (short)520814593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_751:
						result = (int)memoryStream.Position;
						num = (short)775880704;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_175:
					throw new global::System.ArgumentException(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("支就䜳䌵䠷䨹医䰽㐿❁⁃晅㱇㍉㱋⭍橏牑", a_) + A_3[num4].GetType().FullName);
					IL_525:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidRcmpReplySize);
					IL_772:
					return result;
					IL_155:
					num4 = 0;
					num = (short)277413924;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_B6;
				}
				finally
				{
					num = (short)1560084481;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)42218519;
						short num8 = num;
						num = (short)1810904087;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_82D;
						default:
						{
							num = (short)1118633984;
							if (num != 0)
							{
							}
							global::System.IO.MemoryStream memoryStream;
							switch (num2)
							{
							case 0:
								goto IL_82D;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_7F5;
								}
								continue;
							case 2:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)1125122048;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_7F5:
							if (memoryStream == null)
							{
								goto IL_82F;
							}
							num = (short)754909186;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					IL_82D:
					IL_82F:;
				}
				goto IL_830;
			}
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0001F4F8 File Offset: 0x0001D6F8
		public static int a(byte[] A_0, int A_1, params object[] A_2)
		{
			int a_ = 18;
			short num = (short)1712521217;
			if (num != 0)
			{
			}
			num = (short)791281664;
			switch (num)
			{
			default:
			{
				num = (short)917635075;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_755;
					case 1:
						goto IL_C9;
					case 2:
						goto IL_77E;
					case 3:
					{
						num = (short)1985347584;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_AE;
						}
						continue;
					}
					case 4:
					{
						if (A_2 == null)
						{
							num = (short)1729757184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(A_0, A_1, A_0.Length - A_1, true);
						num = (short)1585774594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_AE:
					if (A_0 == null)
					{
						num = (short)372310017;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)2009399300;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_C9:
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("吵䴷尹娻嬽㈿", a_));
				IL_6FA:
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("娵儷䤹䠻", a_));
				IL_755:
				goto IL_6FA;
				IL_77E:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_157;
					}
					int num4;
					object obj;
					for (;;)
					{
						IL_D8:
						switch (num2)
						{
						case 0:
							goto IL_178;
						case 1:
						{
							global::System.IO.MemoryStream memoryStream;
							num4 = (int)memoryStream.Position;
							num = (short)2008940569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(obj.ToString());
							global::System.IO.MemoryStream memoryStream;
							memoryStream.Write(bytes, 0, bytes.Length);
							memoryStream.WriteByte(0);
							num = (short)1451819008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (obj is ushort)
							{
								num = (short)1958674461;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1126105105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::System.IO.MemoryStream memoryStream;
							byte[] array;
							memoryStream.Write(array, 0, array.Length);
							num = (short)1187708937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_178;
						case 6:
							goto IL_178;
						case 7:
							if (obj is byte)
							{
								num = (short)1215234070;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1092091907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							char[] chars;
							if ((chars = (obj as char[])) != null)
							{
								num = (short)2132869132;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)65549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_178;
						case 10:
							goto IL_178;
						case 11:
							goto IL_246;
						case 12:
						{
							char[] chars;
							byte[] bytes2 = global::System.Text.Encoding.ASCII.GetBytes(chars);
							global::System.IO.MemoryStream memoryStream;
							memoryStream.Write(bytes2, 0, bytes2.Length);
							num = (short)712179739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							byte[] array;
							if ((array = (obj as byte[])) != null)
							{
								num = (short)1924464644;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1772683279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
						{
							int num5;
							if (num5 > 0)
							{
								num = (short)94699543;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_178;
						}
						case 15:
						{
							global::Motorola.Common.Communication.RUDP.Helper.b b;
							if ((b = (obj as global::Motorola.Common.Communication.RUDP.Helper.b)) != null)
							{
								num = (short)1648820250;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3D4;
						}
						case 16:
						{
							byte[] array2 = new byte[10240];
							global::Motorola.Common.Communication.RUDP.Helper.b b;
							int num5 = b.q(array2, 0);
							num = (short)1879572494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							if (obj is uint)
							{
								num = (short)788529173;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2019033108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							if (num4 >= A_2.Length)
							{
								num = (short)1451425793;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							obj = A_2[num4];
							num = (short)258867207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							goto IL_178;
						case 20:
							if (obj is string)
							{
								num = (short)585826306;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1851785224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
						{
							uint num6 = (uint)obj;
							global::System.IO.MemoryStream memoryStream;
							memoryStream.WriteByte((byte)(num6 >> 24 & 255U));
							memoryStream.WriteByte((byte)(num6 >> 16 & 255U));
							memoryStream.WriteByte((byte)(num6 >> 8 & 255U));
							memoryStream.WriteByte((byte)(num6 & 255U));
							num = (short)449249290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
						{
							global::System.IO.MemoryStream memoryStream;
							memoryStream.WriteByte((byte)obj);
							num = (short)581369875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
						{
							global::System.IO.MemoryStream memoryStream;
							int num5;
							byte[] array2;
							memoryStream.Write(array2, 0, num5);
							num = (short)1868431365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
						{
							global::Motorola.Common.Communication.RUDP.Helper.b b;
							if (b != null)
							{
								num = (short)1133445136;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_178;
						}
						case 25:
							goto IL_630;
						case 26:
							num = (short)496566296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							goto IL_178;
						case 28:
							goto IL_246;
						case 29:
						{
							ushort num7 = (ushort)obj;
							global::System.IO.MemoryStream memoryStream;
							memoryStream.WriteByte((byte)(num7 >> 8 & 255));
							memoryStream.WriteByte((byte)(num7 & 255));
							num = (short)655818758;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_157;
						IL_178:
						num4++;
						num = (short)1393950731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_246:
						num = (short)1279066130;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3D4:
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.Common.Communication.RUDP.RUDPSocket.i("挵嘷䤹䤻丽〿ⵁ㙃㉅ⵇ⹉汋㩍⥏≑ㅓ汕硗⅙汛⍝", a_), obj.GetType().FullName));
					IL_630:
					return num4;
					IL_157:
					num4 = 0;
					num = (short)2136997916;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_D8;
				}
				catch (global::System.NotSupportedException systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InsufficientMessageBuffer, systemException);
				}
				finally
				{
					num = (short)49676289;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)408355277;
						short num8 = num;
						num = (short)1485832653;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6F7;
						default:
						{
							num = (short)673316864;
							if (num != 0)
							{
							}
							global::System.IO.MemoryStream memoryStream;
							switch (num2)
							{
							case 0:
								goto IL_6F7;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_6BE;
								}
								continue;
							case 2:
								memoryStream.Dispose();
								num = (short)1621884928;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_6BE:
							if (memoryStream == null)
							{
								goto IL_6F9;
							}
							num = (short)845742082;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					IL_6F7:
					IL_6F9:;
				}
				goto IL_6FA;
			}
			}
		}
	}
}
