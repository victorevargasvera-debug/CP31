using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200006A RID: 106
	public class XcmpComponentSession : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000186 RID: 390 RVA: 0x0001789C File Offset: 0x00015A9C
		public XcmpComponentSession(ushort action, ushort sessionID, uint data)
		{
			base.Opcode = 271;
			this.c = action;
			this.d = sessionID;
			this.e = data;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000178D0 File Offset: 0x00015AD0
		public XcmpComponentSession(ushort action, ushort sessionID)
		{
			base.Opcode = 271;
			this.c = action;
			this.d = sessionID;
			this.e = 0U;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00017904 File Offset: 0x00015B04
		public ushort Action
		{
			get
			{
				short num = (short)1804730368;
				short num2 = num;
				num = (short)1112530315;
				short num3 = num;
				num = (short)1863310731;
				switch (num3 == num)
				{
				}
				num = (short)282591233;
				if (num != 0)
				{
				}
				num = (short)1440940032;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000179B4 File Offset: 0x00015BB4
		public ushort SessionID
		{
			get
			{
				short num = (short)1176043520;
				short num2 = num;
				num = (short)1947236401;
				short num3 = num;
				num = (short)843544625;
				switch (num3 == num)
				{
				}
				num = (short)305201153;
				if (num != 0)
				{
				}
				num = (short)2137128960;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00017A64 File Offset: 0x00015C64
		public ushort ReplySessionId
		{
			get
			{
				short num = (short)694419456;
				short num2 = num;
				num = (short)47252926;
				short num3 = num;
				num = (short)1094452670;
				switch (num3 == num)
				{
				}
				num = (short)1274347520;
				if (num != 0)
				{
				}
				num = (short)1462173697;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00017B10 File Offset: 0x00015D10
		public ushort CompletedActions
		{
			get
			{
				short num = (short)1857224704;
				short num2 = num;
				num = (short)32086158;
				short num3 = num;
				num = (short)158570638;
				switch (num3 == num)
				{
				}
				num = (short)1718026240;
				if (num != 0)
				{
				}
				num = (short)2099052545;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00017BC0 File Offset: 0x00015DC0
		public static global::Motorola.Common.Communication.Rcmp.XcmpComponentSession DecodeCommandMessage(byte[] buffer, int start, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			short num;
			int num4;
			int num5;
			object[] array;
			for (;;)
			{
				IL_0A:
				num = (short)1341076883;
				short num2 = num;
				num = (short)1801663891;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)483459072;
					short num3 = num;
					num = (short)1601961984;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_D4;
					case 1:
						goto IL_142;
					case 2:
						goto IL_F0;
					}
					goto IL_90;
				}
				}
				IL_D4:
				if (num5 < length)
				{
					num = (short)148832258;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::Motorola.Common.Communication.r.a(buffer, start, num5, array);
					num = (short)1479016449;
					if (num != 0)
					{
					}
					num = (short)828243969;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
			IL_F0:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UnexpectedEndOfMsg);
			IL_142:
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession((ushort)array[1], (ushort)array[2]);
			if (xcmpComponentSession.Opcode != (ushort)array[0])
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UnexpectedRequestOpcode);
			}
			return xcmpComponentSession;
			IL_90:
			array = new object[3];
			num5 = 0;
			array[0] = global::Motorola.Common.Communication.r.a;
			num5 += 2;
			array[1] = global::Motorola.Common.Communication.r.a;
			num5 += 2;
			array[2] = global::Motorola.Common.Communication.r.a;
			num5 += 2;
			num = (short)1347026944;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00017D40 File Offset: 0x00015F40
		private byte[] a()
		{
			short num = (short)55443456;
			short num2 = num;
			num = (short)476774401;
			if (num != 0)
			{
			}
			num = (short)1948294354;
			short num3 = num;
			num = (short)1945672914;
			switch (num3 == num)
			{
			}
			num = (short)1333264384;
			if (num != 0)
			{
			}
			byte[] array = new byte[7];
			ushort num4 = 33039;
			global::Motorola.Common.Communication.r.a(array, 0, new object[]
			{
				num4,
				0,
				this.c,
				this.d
			});
			return array;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00017E34 File Offset: 0x00016034
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)945422337;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)124658720;
					short num3 = num;
					num = (short)561259552;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1017839616;
						if (num != 0)
						{
						}
						if ((this.c & 32) == 32)
						{
							num = (short)890306567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					num = (short)855703558;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 2:
					goto IL_2DE;
				case 3:
					goto IL_70;
				case 4:
					if (this.e == 0U)
					{
						num = (short)970326018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_75;
				case 5:
					goto IL_276;
				case 6:
					num = (short)963117060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if ((this.c & 64) == 64)
					{
						num = (short)670826497;
						if (num != 0)
						{
						}
						num = (short)1225195525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E3;
				}
				IL_45:
				if ((this.c & 2048) == 2048)
				{
					num = (short)1276706819;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)374276096;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_70:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.c,
				this.d,
				(ushort)this.e
			});
			IL_75:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.c,
				this.d,
				(ushort)this.e
			});
			IL_276:
			num = (short)428867584;
			short num4 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.c,
				this.d,
				this.e
			});
			IL_2DE:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.c,
				this.d
			});
			IL_2E3:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.c,
				this.d,
				(ushort)this.e
			});
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001816C File Offset: 0x0001636C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_91;
			}
			short num;
			int num4;
			for (;;)
			{
				IL_0A:
				num = (short)919418968;
				short num2 = num;
				num = (short)688273496;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)183042048;
					short num3 = num;
					num = (short)351928320;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_C4;
					case 1:
						goto IL_127;
					case 2:
						this.a = (ushort)((int)replyBuffer[offset + 4] | (int)replyBuffer[offset + 3] << 8);
						this.b = (ushort)((int)replyBuffer[offset + 6] | (int)replyBuffer[offset + 5] << 8);
						num = (short)804454401;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_91;
				}
				}
				IL_C4:
				if (offset + 6 >= replyBuffer.Length)
				{
					return;
				}
				num = (short)660406274;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_127:
			num = (short)1453391873;
			if (num != 0)
			{
			}
			return;
			IL_91:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num = (short)954466304;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04000201 RID: 513
		private ushort a;

		// Token: 0x04000202 RID: 514
		private ushort b;

		// Token: 0x04000203 RID: 515
		private ushort c;

		// Token: 0x04000204 RID: 516
		private ushort d;

		// Token: 0x04000205 RID: 517
		private uint e;

		// Token: 0x04000206 RID: 518
		public const ushort CommandOpcode = 271;

		// Token: 0x04000207 RID: 519
		public const ushort ReplyOpcode = 33039;

		// Token: 0x0200006B RID: 107
		[global::System.Flags]
		public enum Actions : ushort
		{
			// Token: 0x04000209 RID: 521
			None = 0,
			// Token: 0x0400020A RID: 522
			Reset = 1,
			// Token: 0x0400020B RID: 523
			StartSession = 2,
			// Token: 0x0400020C RID: 524
			Snapshot = 4,
			// Token: 0x0400020D RID: 525
			ValidateCRC = 8,
			// Token: 0x0400020E RID: 526
			UnpackFiles = 16,
			// Token: 0x0400020F RID: 527
			Deploy = 32,
			// Token: 0x04000210 RID: 528
			DelayTOD = 64,
			// Token: 0x04000211 RID: 529
			SuppressPN = 128,
			// Token: 0x04000212 RID: 530
			Status = 256,
			// Token: 0x04000213 RID: 531
			ReadWrite = 512,
			// Token: 0x04000214 RID: 532
			CreateArchive = 1024,
			// Token: 0x04000215 RID: 533
			ProgrammingIndicator = 2048
		}

		// Token: 0x0200006C RID: 108
		[global::System.Flags]
		public enum SessionReplyResult : ushort
		{
			// Token: 0x04000217 RID: 535
			Success = 0,
			// Token: 0x04000218 RID: 536
			Failure = 1,
			// Token: 0x04000219 RID: 537
			InvalidParameter = 4,
			// Token: 0x0400021A RID: 538
			InvalidSessionID = 16,
			// Token: 0x0400021B RID: 539
			InvalidArchive = 17,
			// Token: 0x0400021C RID: 540
			Busy = 18
		}
	}
}
