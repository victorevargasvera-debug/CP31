using System;
using System.Globalization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000041 RID: 65
	public class RcmpReadIshIDSet : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000D964 File Offset: 0x0000BB64
		public byte LogicalPartition
		{
			get
			{
				short num = (short)1089185888;
				short num2 = num;
				num = (short)564570208;
				switch (num2 == num)
				{
				}
				num = (short)1724055552;
				if (num != 0)
				{
				}
				num = (short)247267329;
				if (num != 0)
				{
				}
				num = (short)648806400;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000DA14 File Offset: 0x0000BC14
		public ushort IshType
		{
			get
			{
				short num = (short)1482684294;
				short num2 = num;
				num = (short)1656158086;
				switch (num2 == num)
				{
				}
				num = (short)522649600;
				if (num != 0)
				{
				}
				num = (short)19267585;
				if (num != 0)
				{
				}
				num = (short)1721892864;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000DAC4 File Offset: 0x0000BCC4
		public ushort TotalIdCount
		{
			get
			{
				short num = (short)613285889;
				if (num != 0)
				{
				}
				num = (short)381300482;
				short num2 = num;
				num = (short)2083335938;
				switch (num2 == num)
				{
				}
				num = (short)1069809664;
				if (num != 0)
				{
				}
				num = (short)1533149184;
				short num3 = num;
				return this.e;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000DB74 File Offset: 0x0000BD74
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000DC24 File Offset: 0x0000BE24
		private ushort NumberOfIDs
		{
			get
			{
				short num = (short)15194447;
				short num2 = num;
				num = (short)103143759;
				switch (num2 == num)
				{
				}
				num = (short)1210908673;
				if (num != 0)
				{
				}
				num = (short)2117664768;
				if (num != 0)
				{
				}
				num = (short)119603200;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)227067593;
				short num2 = num;
				num = (short)483509961;
				switch (num2 == num)
				{
				}
				num = (short)703594496;
				if (num != 0)
				{
				}
				num = (short)1095892993;
				if (num != 0)
				{
				}
				num = (short)1342963712;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000DCD0 File Offset: 0x0000BED0
		private ushort Offset
		{
			get
			{
				short num = (short)922004534;
				short num2 = num;
				num = (short)244493366;
				switch (num2 == num)
				{
				}
				num = (short)124125184;
				if (num != 0)
				{
				}
				num = (short)1574567937;
				if (num != 0)
				{
				}
				num = (short)1980039168;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000DD80 File Offset: 0x0000BF80
		public ushort[] IDs
		{
			get
			{
				short num = (short)1098352352;
				short num2 = num;
				num = (short)1081312992;
				switch (num2 == num)
				{
				}
				num = (short)1822425088;
				if (num != 0)
				{
				}
				num = (short)580517889;
				if (num != 0)
				{
				}
				num = (short)984875008;
				short num3 = num;
				return this.f;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000DE30 File Offset: 0x0000C030
		public RcmpReadIshIDSet(byte logicalPartition, ushort type, ushort numberOfIDs, ushort offset)
		{
			base.Opcode = 260;
			this.a = logicalPartition;
			this.b = type;
			this.c = numberOfIDs;
			this.d = offset;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000DE6C File Offset: 0x0000C06C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)2037513618;
			short num2 = num;
			num = (short)992345490;
			switch (num2 == num)
			{
			}
			num = (short)1352073217;
			if (num != 0)
			{
			}
			num = (short)1919811584;
			if (num != 0)
			{
			}
			num = (short)519700480;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b,
				this.c,
				this.d
			});
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000DF68 File Offset: 0x0000C168
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			int a_ = 1;
			short num = (short)1106247680;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_5D;
				}
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
					{
						object[] array = new object[]
						{
							global::Motorola.Common.Communication.r.b,
							global::Motorola.Common.Communication.r.a,
							global::Motorola.Common.Communication.r.a,
							global::Motorola.Common.Communication.r.a,
							global::Motorola.Common.Communication.r.a,
							global::Motorola.Common.Communication.r.c
						};
						global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
						this.a = (byte)array[0];
						this.b = (ushort)array[1];
						this.c = (ushort)array[2];
						this.d = (ushort)array[3];
						this.e = (ushort)array[4];
						byte[] array2 = (byte[])array[5];
						this.f = new ushort[array2.Length / 2];
						int num3 = 0;
						num = (short)1239588554;
						short num4 = num;
						num = (short)1936236234;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2E4;
						default:
							num = (short)2133131264;
							if (num != 0)
							{
							}
							num = (short)740818945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_27C;
					case 2:
						if (length > global::Motorola.Common.Communication.r.b())
						{
							num = (short)2048851968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_2E4;
					case 4:
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\udf8c떔\ude96쪘펚붜횞莢욦삨잪\ud8ac\uddae풰覲閴", a_) + base.ReplyResult.ToString(), global::System.Array.Empty<object>());
						num = (short)547291139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (base.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)874774532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E4;
					case 6:
						goto IL_27C;
					case 7:
					{
						num = (short)1247150080;
						short num5 = num;
						int num3;
						if (num3 >= this.f.Length)
						{
							num = (short)985595912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2;
						this.f[num3] = (ushort)((int)array2[num3 * 2] * 256 + (int)array2[num3 * 2 + 1]);
						num3++;
						num = (short)455868417;
						if (num != 0)
						{
						}
						num = (short)63635462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						return;
					}
					goto IL_5D;
					IL_27C:
					num = (short)1156055047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E4:
					num = (short)436273154;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_5D:
				base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
				num = (short)490733573;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000E29C File Offset: 0x0000C49C
		public int MaxMessageSize
		{
			get
			{
				short num = (short)1534757548;
				short num2 = num;
				num = (short)879856300;
				switch (num2 == num)
				{
				}
				num = (short)17104896;
				if (num != 0)
				{
				}
				num = (short)1915682817;
				if (num != 0)
				{
				}
				num = (short)726925312;
				short num3 = num;
				return global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet.HeaderSize + (int)(2 * this.c);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000E354 File Offset: 0x0000C554
		public static int HeaderSize
		{
			get
			{
				short num = (short)543801927;
				short num2 = num;
				num = (short)810336839;
				switch (num2 == num)
				{
				}
				num = (short)813826049;
				if (num != 0)
				{
				}
				num = (short)423559168;
				if (num != 0)
				{
				}
				num = (short)981073920;
				short num3 = num;
				return 12;
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000E400 File Offset: 0x0000C600
		public override string ToString()
		{
			int a_ = 7;
			short num = (short)1607071663;
			short num2 = num;
			num = (short)1758787503;
			switch (num2 == num)
			{
			}
			num = (short)1390084097;
			if (num != 0)
			{
			}
			num = (short)1536098304;
			if (num != 0)
			{
			}
			num = (short)1895366656;
			short num3 = num;
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ꖔ놘쮚ﲜ햠쪢톤캦욨얪邬풮肰캲馴삸쮺\ud8bc芾뫀룄蟈뻊ꃌ귎듐ꇒ體뇖郘鿚껜髠탢飤쯦ꛨ跪诬鳮铰蟲죴賶췸蛺퇼꯾渀眂搄欆䀈漊丌怎搐紒愔⨖战⸚怜㌞猠䘢唤䬦倨礪䠬尮䐰弲䄴ਸ਼䈸ഺ䀼ᘾ", a_), new object[]
			{
				base.GetType().Name,
				this.LogicalPartition,
				this.IshType,
				this.NumberOfIDs,
				this.Offset,
				this.TotalIdCount,
				base.ReplyResult
			});
		}

		// Token: 0x04000138 RID: 312
		private byte a;

		// Token: 0x04000139 RID: 313
		private ushort b;

		// Token: 0x0400013A RID: 314
		private ushort c;

		// Token: 0x0400013B RID: 315
		private ushort d;

		// Token: 0x0400013C RID: 316
		private ushort e;

		// Token: 0x0400013D RID: 317
		private ushort[] f;
	}
}
