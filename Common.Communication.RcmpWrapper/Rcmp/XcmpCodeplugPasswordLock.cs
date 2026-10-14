using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000063 RID: 99
	public class XcmpCodeplugPasswordLock : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00015BCC File Offset: 0x00013DCC
		public byte Policy()
		{
			short num = (short)836119878;
			short num2 = num;
			num = (short)248720710;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_10A:
				if (this.a != global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.VerifyPair)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
				}
				num = (short)1755906048;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)712114176;
				if (num != 0)
				{
				}
				num = (short)1228537857;
				if (num != 0)
				{
				}
				num = (short)1203896323;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_12A;
				case 1:
				{
					num = (short)2044657664;
					short num4 = num;
					num = (short)1104084994;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_10A;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_A8;
					}
					continue;
				}
				IL_A8:
				if (this.a == global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus)
				{
					break;
				}
				num = (short)367788033;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_C6:
			return this.c;
			IL_12A:
			goto IL_C6;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00015D0C File Offset: 0x00013F0C
		public uint AlgorithmID()
		{
			if (this.a != global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus)
			{
				short num = (short)1869611008;
				short num2 = num;
				num = (short)1512916597;
				short num3 = num;
				num = (short)238110325;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)308740096;
					if (num != 0)
					{
					}
					num = (short)662700033;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
				}
			}
			return this.d;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00015DCC File Offset: 0x00013FCC
		public byte[] Salt()
		{
			short num;
			if (this.a != global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus)
			{
				num = (short)1945737527;
				short num2 = num;
				num = (short)2055248183;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)330170368;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
				}
			}
			num = (short)32833537;
			if (num != 0)
			{
			}
			num = (short)1905655808;
			short num3 = num;
			return this.e;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00015E90 File Offset: 0x00014090
		public byte ConfigurationLocked()
		{
			short num;
			if (this.a != global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus)
			{
				num = (short)104749049;
				short num2 = num;
				num = (short)374822905;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1089011712;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
				}
			}
			num = (short)2014380033;
			if (num != 0)
			{
			}
			num = (short)90701824;
			short num3 = num;
			return this.f;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00015F50 File Offset: 0x00014150
		public byte RemainingAttempts()
		{
			short num = (short)222602967;
			short num2 = num;
			num = (short)2080155351;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BA:
				num = (short)1866530816;
				short num3 = num;
				if (this.a != global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.VerifyPassword)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
				}
				num = (short)1284636672;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)2090401792;
				if (num != 0)
				{
				}
				num = (short)1500119043;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_102;
				case 1:
					num = (short)1379401730;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_BA;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_7F;
					}
					continue;
				}
				IL_7F:
				if (this.a == global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus)
				{
					break;
				}
				num = (short)1035403265;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_9E:
			return this.g;
			IL_102:
			num = (short)595918849;
			if (num != 0)
			{
			}
			goto IL_9E;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00016094 File Offset: 0x00014294
		public byte[] OUID()
		{
			if (this.a != global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.PairDevice)
			{
				short num = (short)133169152;
				short num2 = num;
				num = (short)627035594;
				short num3 = num;
				num = (short)788712906;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1797783552;
					if (num != 0)
					{
					}
					num = (short)772734977;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
				}
			}
			return this.h;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00016158 File Offset: 0x00014358
		public XcmpCodeplugPasswordLock(global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction function, string functionData = null)
		{
			base.Opcode = 1127;
			this.a = function;
			this.b = functionData;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00016190 File Offset: 0x00014390
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (!string.IsNullOrEmpty(this.b))
			{
				short num = (short)337313792;
				short num2 = num;
				num = (short)223162240;
				short num3 = num;
				num = (short)1607937920;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)283049985;
					if (num != 0)
					{
					}
					num = (short)392429568;
					if (num != 0)
					{
					}
					byte[] array = null;
					global::Motorola.Common.Communication.r.a(this.b, ref array);
					return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
					{
						base.Opcode,
						(byte)this.a,
						(byte)array.Length,
						array
					});
				}
				}
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.a
			});
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000162C0 File Offset: 0x000144C0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			int a_ = 13;
			short num = (short)1465319424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction codeplugPasswordLockFunction;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					byte b;
					byte[] array2;
					for (;;)
					{
						IL_32:
						switch (num2)
						{
						case 0:
							goto IL_22F;
						case 1:
							return;
						case 2:
							return;
						case 3:
							switch (codeplugPasswordLockFunction)
							{
							case global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus:
							{
								object[] array = new object[]
								{
									global::Motorola.Common.Communication.r.b,
									global::Motorola.Common.Communication.r.d,
									global::Motorola.Common.Communication.r.b,
									global::Motorola.Common.Communication.r.c
								};
								global::Motorola.Common.Communication.r.a(replyBuffer, offset, length - (global::Motorola.Common.Communication.r.b() + 1), array);
								this.c = (byte)array[0];
								this.d = (uint)array[1];
								b = (byte)array[2];
								array2 = (byte[])array[3];
								this.e = new byte[(int)b];
								num = (short)1433600010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.VerifyPassword:
								this.g = byte.MaxValue;
								num = (short)146014224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.PairDevice:
							{
								object[] array3 = new object[]
								{
									global::Motorola.Common.Communication.r.b,
									global::Motorola.Common.Communication.r.c
								};
								global::Motorola.Common.Communication.r.a(replyBuffer, offset, length - (global::Motorola.Common.Communication.r.b() + 1), array3);
								byte b2 = (byte)array3[0];
								this.h = (byte[])array3[1];
								num = (short)1243807752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.UnpairDevice:
								return;
							case global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.VerifyPair:
							{
								object[] array4 = new object[]
								{
									global::Motorola.Common.Communication.r.b
								};
								global::Motorola.Common.Communication.r.a(replyBuffer, offset, length - (global::Motorola.Common.Communication.r.b() + 1), array4);
								this.c = (byte)array4[0];
								num = (short)524288002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							default:
								num = (short)1187512321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 4:
						{
							num = (short)1492647936;
							short num3 = num;
							if (array2.Length < (int)b)
							{
								num = (short)1248395264;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Buffer.BlockCopy(array2, 0, this.e, 0, (int)b);
							num = (short)1310261253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_493;
						case 6:
							goto IL_17A;
						case 7:
						{
							if ((int)(b + 1) > array2.Length)
							{
								goto IL_17F;
							}
							num = (short)1721198845;
							short num4 = num;
							num = (short)987916541;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_B5;
							default:
								num = (short)473432064;
								if (num != 0)
								{
								}
								num = (short)100728844;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							byte b2;
							if (this.h.Length != (int)b2)
							{
								num = (short)1867710473;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						case 9:
							goto IL_2BA;
						case 10:
							if (b > 0)
							{
								num = (short)480116750;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_493;
						case 11:
							goto IL_1C6;
						case 12:
							this.f = array2[(int)b];
							num = (short)696057871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if ((int)(b + 2) <= array2.Length)
							{
								num = (short)1301348363;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 14:
							num = (short)781451268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_17F;
						case 16:
							num = (short)1808924673;
							if (num != 0)
							{
							}
							if (length - (global::Motorola.Common.Communication.r.b() + 1) > 0)
							{
								num = (short)1473904646;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						goto IL_7D;
						IL_17F:
						this.g = byte.MaxValue;
						num = (short)802226189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_493:
						this.f = 0;
						num = (short)215023623;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
					IL_17A:
					object[] array5 = new object[]
					{
						global::Motorola.Common.Communication.r.b
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset, length - (global::Motorola.Common.Communication.r.b() + 1), array5);
					this.g = (byte)array5[0];
					return;
					IL_1C6:
					this.g = array2[(int)(b + 1)];
					return;
					IL_22F:
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("漢욢쮤삦\udda8쎪", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("漢膠킢첤\udda6첨讪쒬\udcae醰\uddb2\udab4쎶馸\udeba첼쪾ꃀ꿂돆ꛈ뻌껎뷐꟒駔닖럘볚꧜럞", a_));
					IL_2BA:
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ﮞ욢쮤삦\udda8쎪", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ﮞ膠킢첤\udda6첨讪쒬\udcae醰\uddb2\udab4쎶馸\udeba첼쪾ꃀ꿂돆ꛈꋌ뫎룐럒駔닖럘볚꧜럞", a_));
				}
				}
				IL_7D:
				base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | 32768);
				offset += global::Motorola.Common.Communication.r.b();
				this.a = (global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction)replyBuffer[offset];
				offset++;
				codeplugPasswordLockFunction = this.a;
				IL_B5:
				num = (short)2094989315;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x040001C8 RID: 456
		private global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction a;

		// Token: 0x040001C9 RID: 457
		private string b;

		// Token: 0x040001CA RID: 458
		private byte c;

		// Token: 0x040001CB RID: 459
		private uint d;

		// Token: 0x040001CC RID: 460
		private byte[] e;

		// Token: 0x040001CD RID: 461
		private byte f;

		// Token: 0x040001CE RID: 462
		private byte g = byte.MaxValue;

		// Token: 0x040001CF RID: 463
		private byte[] h;
	}
}
