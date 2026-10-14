using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000035 RID: 53
	public class RcmpIshProgramMode : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000C324 File Offset: 0x0000A524
		private byte Action
		{
			get
			{
				short num = (short)57784808;
				short num2 = num;
				num = (short)1590082024;
				switch (num2 == num)
				{
				}
				num = (short)1167196160;
				if (num != 0)
				{
				}
				num = (short)445251585;
				if (num != 0)
				{
				}
				num = (short)596705280;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		public RcmpIshProgramMode(byte action)
		{
			base.Opcode = 262;
			this.a = action;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000C3FC File Offset: 0x0000A5FC
		public RcmpIshProgramMode(byte action, byte[] optionalData) : this(action)
		{
			this.b = optionalData;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000C418 File Offset: 0x0000A618
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num;
			for (;;)
			{
				num = (short)1443364865;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_112;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 2:
						if (this.b.Length != 0)
						{
							num = (short)1336147968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_117;
					case 3:
						num = (short)363986946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_34:
					num = (short)1777664001;
					if (num != 0)
					{
					}
					if (this.b == null)
					{
						break;
					}
					num = (short)788070403;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_117:
				num = (short)476024125;
				short num3 = num;
				num = (short)1638239549;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_14C;
				}
			}
			IL_112:
			num = (short)85524480;
			short num4 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b
			});
			IL_14C:
			num = (short)559611904;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)25493505;
			if (num != 0)
			{
			}
			num = (short)217418117;
			short num2 = num;
			num = (short)1293322629;
			switch (num2 == num)
			{
			}
			num = (short)141885440;
			if (num != 0)
			{
			}
			num = (short)38993920;
			short num3 = num;
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x040000F6 RID: 246
		private byte a;

		// Token: 0x040000F7 RID: 247
		private byte[] b;

		// Token: 0x02000036 RID: 54
		public enum Actions
		{
			// Token: 0x040000F9 RID: 249
			EnterProgramMode,
			// Token: 0x040000FA RID: 250
			ExitWithRadioReset,
			// Token: 0x040000FB RID: 251
			EnterCloneMode,
			// Token: 0x040000FC RID: 252
			ExitWithoutRadioReset,
			// Token: 0x040000FD RID: 253
			EnterOtapWriteMode,
			// Token: 0x040000FE RID: 254
			EnterOtapReadMode,
			// Token: 0x040000FF RID: 255
			ExitOtapModeWithChecksum,
			// Token: 0x04000100 RID: 256
			EnterRemoteProgrammingMode
		}
	}
}
