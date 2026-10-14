using System;
using System.Net;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000082 RID: 130
	public class XcmpSecureConnect : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0001BEA0 File Offset: 0x0001A0A0
		public global::System.Net.IPAddress RadioIP
		{
			get
			{
				short num = (short)1914568705;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)990707715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 2:
						num = (short)1062600709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.c.Length == 6)
						{
							num = (short)453509124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_196;
					case 4:
						goto IL_E1;
					case 5:
					{
						if (this.c == null)
						{
							goto IL_196;
						}
						num = (short)1791847231;
						short num3 = num;
						num = (short)2113825599;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)800980992;
							if (num != 0)
							{
							}
							num = (short)1988624385;
							if (num != 0)
							{
							}
							num = (short)1646985216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_3D:
					if (this.a != global::Motorola.Common.Communication.Rcmp.FuctionOperation.ReadIpandPort)
					{
						goto IL_196;
					}
					num = (short)2102460416;
					short num4 = num;
					num = (short)2060386306;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E1:
				byte[] array = new byte[4];
				global::System.Array.Copy(this.c, array, 4);
				return new global::System.Net.IPAddress(array);
				IL_196:
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0001C048 File Offset: 0x0001A248
		public ushort RadioPort
		{
			get
			{
				short num = (short)996999169;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1754333187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					case 2:
						num = (short)713752581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.c.Length == 6)
						{
							num = (short)726138884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_194;
					case 4:
						goto IL_E3;
					case 5:
					{
						num = (short)341049345;
						if (num != 0)
						{
						}
						if (this.c == null)
						{
							goto IL_194;
						}
						num = (short)1088530163;
						short num3 = num;
						num = (short)225814259;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1230438400;
							if (num != 0)
							{
							}
							num = (short)1323106304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_3E:
					if (this.a != global::Motorola.Common.Communication.Rcmp.FuctionOperation.ReadIpandPort)
					{
						goto IL_194;
					}
					num = (short)714801152;
					short num4 = num;
					num = (short)111017986;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E3:
				byte[] array = new byte[4];
				global::System.Array.Copy(this.c, 4, array, 0, 2);
				return global::Motorola.Common.Communication.r.a(array, 0);
				IL_194:
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0001C1F0 File Offset: 0x0001A3F0
		public byte SSLCertificateSupportedID
		{
			get
			{
				short num = (short)945225729;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)413663235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 2:
						num = (short)366084101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.c.Length == 1)
						{
							num = (short)1600126980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_181;
					case 4:
						goto IL_CF;
					case 5:
					{
						if (this.c == null)
						{
							goto IL_181;
						}
						num = (short)1378292247;
						short num3 = num;
						num = (short)2012549655;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1823866881;
							if (num != 0)
							{
							}
							num = (short)1037893632;
							if (num != 0)
							{
							}
							num = (short)2123366400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_3C:
					if (this.a != global::Motorola.Common.Communication.Rcmp.FuctionOperation.ReadCertID)
					{
						goto IL_181;
					}
					num = (short)1144127488;
					short num4 = num;
					num = (short)1428881410;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CF:
				return this.c[0];
				IL_181:
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0001C384 File Offset: 0x0001A584
		public XcmpSecureConnect(global::Motorola.Common.Communication.Rcmp.FuctionOperation operationType)
		{
			base.Opcode = 61;
			this.a = operationType;
			this.b = 0;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)122818378;
			short num2 = num;
			num = (short)1900023626;
			switch (num2 == num)
			{
			}
			num = (short)911671297;
			if (num != 0)
			{
			}
			num = (short)589299712;
			if (num != 0)
			{
			}
			num = (short)1767374848;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.a,
				0
			});
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001C48C File Offset: 0x0001A68C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1391062968;
			short num2 = num;
			num = (short)656863160;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_130:
				num = (short)497745920;
				short num3 = num;
				num = (short)1813839874;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)424083456;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				break;
			}
			for (;;)
			{
				IL_57:
				num = (short)278724609;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)2059993089;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_EB;
				case 2:
					return;
				}
				goto IL_8F;
			}
			IL_EB:
			this.a = (global::Motorola.Common.Communication.Rcmp.FuctionOperation)replyBuffer[offset];
			offset++;
			this.b = replyBuffer[offset];
			offset++;
			this.c = new byte[(int)this.b];
			global::System.Buffer.BlockCopy(replyBuffer, offset, this.c, 0, this.c.Length);
			goto IL_130;
			IL_8F:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | 32768);
			offset += global::Motorola.Common.Communication.r.b();
			num = (short)713621504;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_57;
		}

		// Token: 0x04000290 RID: 656
		private global::Motorola.Common.Communication.Rcmp.FuctionOperation a;

		// Token: 0x04000291 RID: 657
		private byte b;

		// Token: 0x04000292 RID: 658
		private byte[] c;
	}
}
