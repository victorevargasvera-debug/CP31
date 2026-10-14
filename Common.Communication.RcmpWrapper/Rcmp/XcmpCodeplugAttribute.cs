using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000061 RID: 97
	public class XcmpCodeplugAttribute : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00015044 File Offset: 0x00013244
		public uint TotalAllowableMemory
		{
			get
			{
				short num = (short)1120796677;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)362956313;
						short num3 = num;
						num = (short)1757038105;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							num = (short)1424424960;
							if (num != 0)
							{
							}
							num = (short)676003844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (this.c.Length == 4)
						{
							num = (short)741670915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_182;
					case 2:
						num = (short)1923612673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_FA;
					case 4:
						if (this.c != null)
						{
							num = (short)1982791682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_182;
					case 5:
						goto IL_14;
					}
					goto IL_66;
					IL_14:
					num = (short)127795200;
					short num4 = num;
					switch (0)
					{
					case 0:
						IL_66:
						if (this.b != global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.TotalAllowableMemory)
						{
							goto IL_182;
						}
						num = (short)514195456;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_FA:
				num = (short)1895235585;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.r.b(this.c, 0);
				IL_182:
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000151D8 File Offset: 0x000133D8
		private uint CurrentMemoryUsed
		{
			get
			{
				short num = (short)154402821;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1652137478;
						short num3 = num;
						num = (short)627809798;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							num = (short)531431424;
							if (num != 0)
							{
							}
							num = (short)92864516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)800653313;
						if (num != 0)
						{
						}
						if (this.c.Length == 4)
						{
							num = (short)1659568131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17F;
					case 2:
						num = (short)1115357185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_F8;
					case 4:
						if (this.c != null)
						{
							num = (short)287768578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17F;
					case 5:
						goto IL_14;
					}
					goto IL_66;
					IL_14:
					num = (short)1233780736;
					short num4 = num;
					switch (0)
					{
					case 0:
						IL_66:
						if (this.b != global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.CurrentMemoryUsed)
						{
							goto IL_17F;
						}
						num = (short)1406795776;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_F8:
				return global::Motorola.Common.Communication.r.b(this.c, 0);
				IL_17F:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0001536C File Offset: 0x0001356C
		private ushort OEMManufacturerID
		{
			get
			{
				short num = (short)1304297477;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1075726724;
						short num3 = num;
						num = (short)1908623748;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
							num = (short)1808596993;
							if (num != 0)
							{
							}
							num = (short)1113915392;
							if (num != 0)
							{
							}
							num = (short)1209401348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (this.c.Length == 2)
						{
							num = (short)1937244163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_181;
					case 2:
						num = (short)140443649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_D2;
					case 4:
						if (this.c != null)
						{
							num = (short)424345602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_181;
					case 5:
						goto IL_15;
					}
					goto IL_68;
					IL_15:
					num = (short)608567296;
					short num4 = num;
					switch (0)
					{
					case 0:
						IL_68:
						if (this.b != global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.OEMManufacturerID)
						{
							goto IL_181;
						}
						num = (short)2027225088;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_D2:
				return global::Motorola.Common.Communication.r.a(this.c, 0);
				IL_181:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00015500 File Offset: 0x00013700
		public byte RegionalInformation
		{
			get
			{
				short num = (short)1479671813;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)385227450;
						short num3 = num;
						num = (short)202054330;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
							num = (short)950796288;
							if (num != 0)
							{
							}
							num = (short)1143930884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (this.c.Length == 1)
						{
							num = (short)660537347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17E;
					case 2:
						num = (short)444989441;
						if (num != 0)
						{
						}
						num = (short)1009123329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_CD;
					case 4:
						if (this.c != null)
						{
							num = (short)1520500738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17E;
					case 5:
						goto IL_15;
					}
					goto IL_67;
					IL_15:
					num = (short)1119944704;
					short num4 = num;
					switch (0)
					{
					case 0:
						IL_67:
						if (this.b != global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.RegionalInformation)
						{
							goto IL_17E;
						}
						num = (short)1681653760;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_CD:
				return this.c[0];
				IL_17E:
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00015690 File Offset: 0x00013890
		public byte SecurityCapability
		{
			get
			{
				short num = (short)1449000965;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)394002433;
						if (num != 0)
						{
						}
						num = (short)1242256891;
						short num3 = num;
						num = (short)1206081019;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16;
						default:
							num = (short)1883373568;
							if (num != 0)
							{
							}
							num = (short)1974861828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (this.c.Length == 1)
						{
							num = (short)1033502723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17F;
					case 2:
						num = (short)2145976321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_F7;
					case 4:
						if (this.c != null)
						{
							num = (short)1184497666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17F;
					case 5:
						goto IL_16;
					}
					goto IL_67;
					IL_16:
					num = (short)890109952;
					short num4 = num;
					switch (0)
					{
					case 0:
						IL_67:
						if (this.b != global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.CertificateSupportedID)
						{
							goto IL_17F;
						}
						num = (short)1973223424;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_F7:
				return this.c[0];
				IL_17F:
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00015824 File Offset: 0x00013A24
		public byte[] AttributeData
		{
			get
			{
				short num = (short)751875442;
				short num2 = num;
				num = (short)567588210;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1947533312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1642594304;
				if (num != 0)
				{
				}
				num = (short)377094145;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000158D4 File Offset: 0x00013AD4
		public XcmpCodeplugAttribute(global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation operationType, global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType attrType, byte[] attrData = null)
		{
			base.Opcode = 55;
			this.a = operationType;
			this.b = attrType;
			this.c = attrData;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00015904 File Offset: 0x00013B04
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num;
			if (this.c != null)
			{
				num = (short)834862112;
				short num2 = num;
				num = (short)1562377248;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1106640896;
					if (num != 0)
					{
					}
					return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
					{
						base.Opcode,
						(byte)this.a,
						(byte)this.b,
						(byte)this.c.Length,
						this.c
					});
				}
			}
			num = (short)1307377665;
			if (num != 0)
			{
			}
			num = (short)1386938368;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.a,
				(byte)this.b,
				0
			});
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00015A50 File Offset: 0x00013C50
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)391044705;
			short num2 = num;
			num = (short)480435809;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1021116416;
				short num3 = num;
				break;
			}
			}
			num = (short)1002831873;
			if (num != 0)
			{
			}
			num = (short)195756032;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_B7;
			}
			int num4;
			for (;;)
			{
				IL_A5:
				switch (num4)
				{
				case 0:
					return;
				case 1:
				{
					this.a = (global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation)replyBuffer[offset];
					offset++;
					this.b = (global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType)replyBuffer[offset];
					offset++;
					byte b = replyBuffer[offset];
					offset++;
					this.c = new byte[(int)b];
					global::System.Buffer.BlockCopy(replyBuffer, offset, this.c, 0, this.c.Length);
					num = (short)1691549696;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)213975041;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				break;
			}
			IL_B7:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | 32768);
			offset += global::Motorola.Common.Communication.r.b();
			num = (short)1315504130;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A5;
		}

		// Token: 0x040001BF RID: 447
		private global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation a;

		// Token: 0x040001C0 RID: 448
		private global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType b;

		// Token: 0x040001C1 RID: 449
		private byte[] c;
	}
}
