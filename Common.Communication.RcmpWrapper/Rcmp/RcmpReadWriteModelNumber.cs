using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000047 RID: 71
	public class RcmpReadWriteModelNumber : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000107C4 File Offset: 0x0000E9C4
		public string ModelNumber
		{
			get
			{
				short num = (short)1112008120;
				short num2 = num;
				num = (short)69330360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)951910400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)155844608;
				if (num != 0)
				{
				}
				num = (short)852623361;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00010874 File Offset: 0x0000EA74
		public RcmpReadWriteModelNumber(byte operation, string modelNumber)
		{
			int a_ = 5;
			base..ctor();
			if (modelNumber != null && modelNumber.Length > 17)
			{
				throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ﲐﲒ햚쎠욢힤螦삨\ud8aa趬쎮\udeb0\uddb2튴튶쮸鮺즼ힾꃀ귂", a_) + 17.ToString());
			}
			base.Opcode = 16;
			this.a = modelNumber;
			this.b = operation;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000108DC File Offset: 0x0000EADC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			int a_ = 14;
			short num = (short)2047672328;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a != null)
					{
						num = (short)1692925957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FC;
				case 1:
					if (this.a == null)
					{
						num = (short)1287651331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FC;
				case 2:
					if (this.b == 1)
					{
						num = (short)1576337412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FC;
				case 3:
					goto IL_FC;
				case 4:
					num = (short)348192769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1F7;
				case 6:
					num = (short)343408640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_234;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 9:
					if (this.a == null)
					{
						num = (short)995688455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_276;
				}
				IL_55:
				num = (short)195690497;
				if (num != 0)
				{
				}
				if (this.b == 0)
				{
					num = (short)1196752902;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)884146178;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1FC:
				num = (short)205193225;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FC:
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("힙瞧얟캡펥얧좩즫\udcad", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\udb99劣햟쾡솣좥\udca7誩쪫솭슯銱\ud9b3\ud9b5\udcb7\udfb9킻麽꺿럁꧃꓅귇룉ꟍꏏ뫓ꏕ듗뛙ﳛ룝迟郡쓣뇥髧菩飫语탯뷱蓳鏵諷鯹裻韽濿氁眃", a_));
			IL_169:
			num = (short)1358823424;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.b
			});
			IL_1F7:
			num = (short)27270378;
			short num4 = num;
			num = (short)298786026;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1155137536;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("힙瞧얟캡펥얧좩즫\udcad", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\udb99劣햟쾡솣좥\udca7誩쪫솭슯銱\ud9b3\ud9b5\udcb7\udfb9킻麽꺿럁꧃꓅귇룉ꟍꏏ뫓맕곗龎닛ꯝ賟軡쓣胥蟧飩쳫볭闯鏱郳훵럷諹駻賽懿瘁洃椅昇礉", a_));
			}
			IL_234:
			goto IL_169;
			IL_276:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.b,
				this.a
			});
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00010B94 File Offset: 0x0000ED94
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_12D;
				case 1:
					goto IL_98;
				case 2:
				{
					object[] array = new object[]
					{
						string.Empty
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.a = (string)array[0];
					num2 = (short)660865025;
					if (num2 != 0)
					{
					}
					num2 = (short)354615296;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_98:
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				goto IL_A3;
			}
			IL_12D:
			num2 = (short)708182016;
			short num3 = num2;
			return;
			IL_1C:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)1970913954;
			short num4 = num2;
			num2 = (short)861258402;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_A3:
				num2 = (short)823918594;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1162018816;
				if (num2 != 0)
				{
				}
				num2 = (short)328073217;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00010CFC File Offset: 0x0000EEFC
		public int MaxMessageSize
		{
			get
			{
				short num = (short)1660657554;
				short num2 = num;
				num = (short)1755094930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1046544384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)196018177;
				if (num != 0)
				{
				}
				num = (short)1227423744;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.r.b() + 17;
			}
		}

		// Token: 0x0400014F RID: 335
		private string a;

		// Token: 0x04000150 RID: 336
		private byte b;

		// Token: 0x04000151 RID: 337
		private const int c = 17;
	}
}
