using System;
using System.Text;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200005B RID: 91
	public class RcmpVersionInformation : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000146 RID: 326 RVA: 0x000137E8 File Offset: 0x000119E8
		public RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType type) : this((byte)type)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000137FC File Offset: 0x000119FC
		private RcmpVersionInformation(byte A_0)
		{
			base.Opcode = 15;
			this.a = A_0;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00013820 File Offset: 0x00011A20
		public string VersionInformation
		{
			get
			{
				short num = (short)1466579106;
				short num2 = num;
				num = (short)1536506018;
				switch (num2 == num)
				{
				}
				num = (short)433717249;
				if (num != 0)
				{
				}
				num = (short)536150016;
				short num3 = num;
				num = (short)1426784256;
				if (num != 0)
				{
				}
				return this.m_VersionInformation;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000138D0 File Offset: 0x00011AD0
		private byte Type
		{
			get
			{
				short num = (short)1618596390;
				short num2 = num;
				num = (short)127062566;
				switch (num2 == num)
				{
				}
				num = (short)1108410368;
				if (num != 0)
				{
				}
				num = (short)566034432;
				short num3 = num;
				num = (short)57081857;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0001397C File Offset: 0x00011B7C
		public global::Motorola.Common.Communication.Rcmp.FlashSizeType FlashSizeType
		{
			get
			{
				short num;
				if (this.a == 109)
				{
					for (;;)
					{
						num = (short)357236737;
						if (num != 0)
						{
						}
						num = (short)922090017;
						short num2 = num;
						num = (short)2126707233;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_68;
						}
					}
					IL_68:
					num = (short)506331136;
					if (num != 0)
					{
					}
					return (global::Motorola.Common.Communication.Rcmp.FlashSizeType)this.m_rawReply[0];
				}
				num = (short)1623326720;
				short num3 = num;
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00013A40 File Offset: 0x00011C40
		public string FPGAVersionInformation
		{
			get
			{
				short num = (short)158007298;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.a <= 181)
						{
							num = (short)399179779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					case 1:
						num = (short)1092616192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 3:
					{
						num = (short)2085965488;
						short num3 = num;
						num = (short)1685474992;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_E2;
						}
						goto Block_2;
					}
					}
					IL_34:
					num = (short)1154744321;
					if (num != 0)
					{
					}
					if (this.a < 176)
					{
						goto IL_15E;
					}
					num = (short)332267521;
					num2 = (int)((global::System.IntPtr)num);
				}
				Block_2:
				num = (short)1164574720;
				short num4 = num;
				IL_E2:
				num = (short)1520697344;
				if (num != 0)
				{
				}
				return string.Join(string.Empty, global::System.BitConverter.ToString(this.m_rawReply, 8).Split(new char[]
				{
					'-'
				}));
				IL_15E:
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00013BB0 File Offset: 0x00011DB0
		public bool IsDspCapabilityEnabled
		{
			get
			{
				short num;
				if (this.a == 17)
				{
					for (;;)
					{
						num = (short)2076762859;
						short num2 = num;
						num = (short)2080498411;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_43;
						}
					}
					IL_43:
					num = (short)1011351553;
					if (num != 0)
					{
					}
					num = (short)854327296;
					if (num != 0)
					{
					}
					return (this.m_rawReply[0] & 1) == 1;
				}
				num = (short)1423507456;
				short num3 = num;
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00013C7C File Offset: 0x00011E7C
		public bool IsDtpCapabilityEnabled()
		{
			short num;
			if (this.a == 19)
			{
				for (;;)
				{
					num = (short)579403777;
					if (num != 0)
					{
					}
					num = (short)850444839;
					short num2 = num;
					num = (short)886030887;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6A;
					}
				}
				IL_6A:
				num = (short)1893662720;
				if (num != 0)
				{
				}
				return (this.m_rawReply[0] & 1) == 1;
			}
			num = (short)842661888;
			short num3 = num;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00013D48 File Offset: 0x00011F48
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)768639452;
			short num2 = num;
			num = (short)1816625628;
			switch (num2 == num)
			{
			}
			num = (short)1038483457;
			if (num != 0)
			{
			}
			num = (short)1495859200;
			short num3 = num;
			num = (short)1580335104;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00013E18 File Offset: 0x00012018
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
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
					num2 = (short)1849622528;
					short num3 = num2;
					this.m_rawReply = new byte[length - global::Motorola.Common.Communication.r.b()];
					global::System.Buffer.BlockCopy(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), this.m_rawReply, 0, this.m_rawReply.Length);
					this.m_VersionInformation = global::System.Text.Encoding.ASCII.GetString(this.m_rawReply);
					num2 = (short)426377218;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1910833152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_120;
				case 2:
					goto IL_11E;
				}
				goto IL_1C;
			}
			IL_11E:
			IL_120:
			num2 = (short)706586317;
			short num4 = num2;
			num2 = (short)817866445;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_11E;
			default:
				num2 = (short)345309184;
				if (num2 != 0)
				{
				}
				return;
			}
			IL_1C:
			num2 = (short)810287105;
			if (num2 != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)1271726081;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040001A6 RID: 422
		protected string m_VersionInformation;

		// Token: 0x040001A7 RID: 423
		protected byte[] m_rawReply;

		// Token: 0x040001A8 RID: 424
		private byte a;
	}
}
