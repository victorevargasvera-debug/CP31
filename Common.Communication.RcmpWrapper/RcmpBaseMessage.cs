using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000007 RID: 7
	public abstract class RcmpBaseMessage : global::Motorola.Common.Communication.BaseMessage
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002AB4 File Offset: 0x00000CB4
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002B68 File Offset: 0x00000D68
		protected ushort Opcode
		{
			get
			{
				short num = (short)1551645488;
				short num2 = num;
				num = (short)775568176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2047082496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)276365312;
				if (num != 0)
				{
				}
				num = (short)885522433;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1893531401;
				short num2 = num;
				num = (short)1507786505;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1398734848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)658505728;
				if (num != 0)
				{
				}
				num = (short)466092033;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002C18 File Offset: 0x00000E18
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002CCC File Offset: 0x00000ECC
		public global::Motorola.Common.Communication.RcmpReplyResult ReplyResult
		{
			get
			{
				short num = (short)263056183;
				short num2 = num;
				num = (short)355724087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)308084736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1100742657;
				if (num != 0)
				{
				}
				num = (short)1100480512;
				if (num != 0)
				{
				}
				return this.b;
			}
			protected set
			{
				short num = (short)725923807;
				short num2 = num;
				num = (short)428521439;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1858207744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)541851649;
				if (num != 0)
				{
				}
				num = (short)2042429440;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002D7C File Offset: 0x00000F7C
		public override int BuildCommandMessage(byte[] sendBuffer)
		{
			short num = (short)2058641212;
			short num2 = num;
			num = (short)1958108988;
			switch (num2 == num)
			{
			default:
			{
				num = (short)489029632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)537198593;
			if (num != 0)
			{
			}
			num = (short)1527709696;
			if (num != 0)
			{
			}
			return this.BuildCommandMessage(sendBuffer, 0);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002E2C File Offset: 0x0000102C
		public virtual int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1582039041;
			if (num != 0)
			{
			}
			num = (short)1395916800;
			short num2 = num;
			num = (short)511521557;
			short num3 = num;
			num = (short)2054828821;
			switch (num3 == num)
			{
			}
			num = (short)1283194880;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				this.Opcode
			});
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002EF0 File Offset: 0x000010F0
		public virtual ushort CalculateMessageCRC16(ref uint checksum, byte[] inputData, int start, int length)
		{
			short num = (short)1644953601;
			if (num != 0)
			{
			}
			num = (short)867696640;
			short num2 = num;
			num = (short)895770572;
			short num3 = num;
			num = (short)261513164;
			switch (num3 == num)
			{
			}
			num = (short)83427328;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.RcmpBaseMessage.CalculateCRC16(ref checksum, inputData, start, length);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002FA0 File Offset: 0x000011A0
		public static ushort CalculateCRC16(ref uint workspace, byte[] inputData, int start, int length)
		{
			int num;
			short num2;
			int num5;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_DE;
					case 1:
					{
						num2 = (short)1545626047;
						short num3 = num2;
						num2 = (short)1151361471;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22;
						case 1:
							break;
						default:
						{
							num2 = (short)1746862080;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)336265216;
						if (num2 != 0)
						{
						}
						if (num5 >= start + length)
						{
							num2 = (short)1999044608;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						workspace = ((uint)global::Motorola.Common.Communication.RcmpBaseMessage.c[(int)((workspace >> 8 ^ (uint)inputData[num5]) & 255U)] ^ workspace << 8);
						num5++;
						num2 = (short)1581318146;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						goto IL_38;
					case 3:
						goto IL_38;
					}
					goto IL_20;
					IL_38:
					num2 = (short)544276481;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_DE:
				num2 = (short)710606849;
				if (num2 != 0)
				{
				}
				return (ushort)workspace;
			}
			IL_20:
			num5 = start;
			IL_22:
			num2 = (short)1173946371;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003114 File Offset: 0x00001314
		// Note: this type is marked as 'beforefieldinit'.
		static RcmpBaseMessage()
		{
			short num = (short)499920213;
			short num2 = num;
			num = (short)1609182549;
			switch (num2 == num)
			{
			default:
			{
				num = (short)46006272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)689045505;
			if (num != 0)
			{
			}
			num = (short)382402560;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.RcmpBaseMessage.c = new ushort[]
			{
				0,
				4129,
				8258,
				12387,
				16516,
				20645,
				24774,
				28903,
				33032,
				37161,
				41290,
				45419,
				49548,
				53677,
				57806,
				61935,
				4657,
				528,
				12915,
				8786,
				21173,
				17044,
				29431,
				25302,
				37689,
				33560,
				45947,
				41818,
				54205,
				50076,
				62463,
				58334,
				9314,
				13379,
				1056,
				5121,
				25830,
				29895,
				17572,
				21637,
				42346,
				46411,
				34088,
				38153,
				58862,
				62927,
				50604,
				54669,
				13907,
				9842,
				5649,
				1584,
				30423,
				26358,
				22165,
				18100,
				46939,
				42874,
				38681,
				34616,
				63455,
				59390,
				55197,
				51132,
				18628,
				22757,
				26758,
				30887,
				2112,
				6241,
				10242,
				14371,
				51660,
				55789,
				59790,
				63919,
				35144,
				39273,
				43274,
				47403,
				23285,
				19156,
				31415,
				27286,
				6769,
				2640,
				14899,
				10770,
				56317,
				52188,
				64447,
				60318,
				39801,
				35672,
				47931,
				43802,
				27814,
				31879,
				19684,
				23749,
				11298,
				15363,
				3168,
				7233,
				60846,
				64911,
				52716,
				56781,
				44330,
				48395,
				36200,
				40265,
				32407,
				28342,
				24277,
				20212,
				15891,
				11826,
				7761,
				3696,
				65439,
				61374,
				57309,
				53244,
				48923,
				44858,
				40793,
				36728,
				37256,
				33193,
				45514,
				41451,
				53516,
				49453,
				61774,
				57711,
				4224,
				161,
				12482,
				8419,
				20484,
				16421,
				28742,
				24679,
				33721,
				37784,
				41979,
				46042,
				49981,
				54044,
				58239,
				62302,
				689,
				4752,
				8947,
				13010,
				16949,
				21012,
				25207,
				29270,
				46570,
				42443,
				38312,
				34185,
				62830,
				58703,
				54572,
				50445,
				13538,
				9411,
				5280,
				1153,
				29798,
				25671,
				21540,
				17413,
				42971,
				47098,
				34713,
				38840,
				59231,
				63358,
				50973,
				55100,
				9939,
				14066,
				1681,
				5808,
				26199,
				30326,
				17941,
				22068,
				55628,
				51565,
				63758,
				59695,
				39368,
				35305,
				47498,
				43435,
				22596,
				18533,
				30726,
				26663,
				6336,
				2273,
				14466,
				10403,
				52093,
				56156,
				60223,
				64286,
				35833,
				39896,
				43963,
				48026,
				19061,
				23124,
				27191,
				31254,
				2801,
				6864,
				10931,
				14994,
				64814,
				60687,
				56684,
				52557,
				48554,
				44427,
				40424,
				36297,
				31782,
				27655,
				23652,
				19525,
				15522,
				11395,
				7392,
				3265,
				61215,
				65342,
				53085,
				57212,
				44955,
				49082,
				36825,
				40952,
				28183,
				32310,
				20053,
				24180,
				11923,
				16050,
				3793,
				7920
			};
		}

		// Token: 0x04000006 RID: 6
		private ushort a;

		// Token: 0x04000007 RID: 7
		private global::Motorola.Common.Communication.RcmpReplyResult b = global::Motorola.Common.Communication.RcmpReplyResult.Undefined;

		// Token: 0x04000008 RID: 8
		private static readonly ushort[] c;
	}
}
