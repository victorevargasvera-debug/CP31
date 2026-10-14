using System;
using System.Text;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000073 RID: 115
	public class XcmpFileAccess : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00018F18 File Offset: 0x00017118
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00018FCC File Offset: 0x000171CC
		private string PathName
		{
			get
			{
				short num = (short)473759744;
				short num2 = num;
				num = (short)1887402768;
				short num3 = num;
				num = (short)1627749136;
				switch (num3 == num)
				{
				}
				num = (short)240779265;
				if (num != 0)
				{
				}
				num = (short)21495808;
				if (num != 0)
				{
				}
				return this.f.ToString();
			}
			set
			{
				short num = (short)1809121280;
				short num2 = num;
				num = (short)538458959;
				short num3 = num;
				num = (short)1101019983;
				switch (num3 == num)
				{
				}
				num = (short)1127677953;
				if (num != 0)
				{
				}
				num = (short)564985856;
				if (num != 0)
				{
				}
				this.f = new global::System.Text.StringBuilder(value);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00019080 File Offset: 0x00017280
		public uint FileSize
		{
			get
			{
				short num = (short)1583349760;
				short num2 = num;
				num = (short)863556249;
				short num3 = num;
				num = (short)1723978393;
				switch (num3 == num)
				{
				}
				num = (short)1982988289;
				if (num != 0)
				{
				}
				num = (short)1313538048;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00019130 File Offset: 0x00017330
		private uint PathLength
		{
			get
			{
				short num = (short)17956864;
				short num2 = num;
				num = (short)1867658903;
				short num3 = num;
				num = (short)1896035991;
				switch (num3 == num)
				{
				}
				num = (short)1568014337;
				if (num != 0)
				{
				}
				num = (short)1667104768;
				if (num != 0)
				{
				}
				return (uint)this.d;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000191E0 File Offset: 0x000173E0
		public XcmpFileAccess(ushort PartitionID, byte TransferType, uint OptionFlag, uint FileOffset, uint FileSize, ushort PathLength, string Path)
		{
			base.Opcode = 1093;
			this.g = TransferType;
			this.e = PartitionID;
			this.c = OptionFlag;
			this.a = FileSize;
			this.b = FileOffset;
			this.d = PathLength;
			this.f = new global::System.Text.StringBuilder(Path);
			this.f.Append('\0');
			this.d += 1;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00019254 File Offset: 0x00017454
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)346750976;
			short num2 = num;
			num = (short)1115055641;
			short num3 = num;
			num = (short)1786537497;
			switch (num3 == num)
			{
			}
			num = (short)727842816;
			if (num != 0)
			{
			}
			num = (short)174325761;
			if (num != 0)
			{
			}
			byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(this.f.ToString());
			this.d = (ushort)bytes.Length;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.g,
				this.e,
				this.c,
				this.a,
				this.b,
				this.d,
				bytes
			});
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00019390 File Offset: 0x00017590
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1759313920;
					short num3 = num2;
					num2 = (short)356644468;
					short num4 = num2;
					num2 = (short)1028585076;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D2;
					default:
						num2 = (short)1585053696;
						if (num2 != 0)
						{
						}
						if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)423034884;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					return;
				case 2:
					this.g = replyBuffer[offset + 3];
					this.e = (ushort)((int)replyBuffer[offset + 5] | (int)replyBuffer[offset + 4] << 8);
					this.c = (uint)((int)replyBuffer[offset + 9] | (int)replyBuffer[offset + 8] << 8 | (int)replyBuffer[offset + 7] << 16 | (int)replyBuffer[offset + 6] << 24);
					this.a = (uint)((int)replyBuffer[offset + 13] | (int)replyBuffer[offset + 12] << 8 | (int)replyBuffer[offset + 11] << 16 | (int)replyBuffer[offset + 10] << 24);
					this.b = (uint)((int)replyBuffer[offset + 17] | (int)replyBuffer[offset + 16] << 8 | (int)replyBuffer[offset + 15] << 16 | (int)replyBuffer[offset + 14] << 24);
					this.d = (ushort)((int)replyBuffer[offset + 19] | (int)replyBuffer[offset + 18] << 8);
					this.f = new global::System.Text.StringBuilder(global::System.Text.Encoding.UTF8.GetString(replyBuffer, offset + 20, (int)this.d));
					num2 = (short)1289093121;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (length >= global::Motorola.Common.Communication.r.b() + 17)
					{
						num2 = (short)1006567426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					goto IL_1D2;
				}
				goto IL_24;
				IL_1D2:
				num2 = (short)1010761729;
				if (num2 != 0)
				{
				}
				num2 = (short)2091450371;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)192151552;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000233 RID: 563
		private uint a;

		// Token: 0x04000234 RID: 564
		private uint b;

		// Token: 0x04000235 RID: 565
		private uint c;

		// Token: 0x04000236 RID: 566
		private ushort d;

		// Token: 0x04000237 RID: 567
		private ushort e;

		// Token: 0x04000238 RID: 568
		private global::System.Text.StringBuilder f;

		// Token: 0x04000239 RID: 569
		private byte g;

		// Token: 0x02000074 RID: 116
		public enum TransferType : byte
		{
			// Token: 0x0400023B RID: 571
			Read,
			// Token: 0x0400023C RID: 572
			Write,
			// Token: 0x0400023D RID: 573
			Erase,
			// Token: 0x0400023E RID: 574
			ReadFileList,
			// Token: 0x0400023F RID: 575
			ReadFileLength,
			// Token: 0x04000240 RID: 576
			CreateFile,
			// Token: 0x04000241 RID: 577
			GetFileCRC,
			// Token: 0x04000242 RID: 578
			GetFreeSpace
		}
	}
}
