using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000013 RID: 19
	public class RcmpMessageExecutor : global::Motorola.Common.Communication.MessageExecutorBase, global::System.IDisposable
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00017D34 File Offset: 0x00015F34
		public RcmpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe)
		{
			base.CommPipe = commPipe;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00017D50 File Offset: 0x00015F50
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)672583239;
				short num2 = num;
				num = (short)1314704967;
				switch (num2 == num)
				{
				}
				num = (short)1080885249;
				if (num != 0)
				{
				}
				num = (short)1500774400;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)10092544;
			short num3 = num;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00017E18 File Offset: 0x00016018
		public void Dispose()
		{
			short num = (short)1260576653;
			short num2 = num;
			num = (short)979033997;
			switch (num2 == num)
			{
			}
			num = (short)1319698433;
			if (num != 0)
			{
			}
			num = (short)1964244992;
			short num3 = num;
			num = (short)1595277312;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00017ECC File Offset: 0x000160CC
		protected virtual void Dispose(bool isDisposing)
		{
			short num = (short)240910336;
			short num2 = num;
			num = (short)1738696629;
			short num3 = num;
			num = (short)964257717;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_ED:
				this.b = true;
				num = (short)1762328578;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1091043329;
				if (num != 0)
				{
				}
				num = (short)1960771584;
				if (num != 0)
				{
				}
				num = (short)226885633;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_EB;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_CF;
					}
					continue;
				case 2:
					return;
				}
				IL_CF:
				if (this.b)
				{
					return;
				}
				num = (short)26738688;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_EB:
			goto IL_ED;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00017FE8 File Offset: 0x000161E8
		protected override void validateSendBuffer(byte[] sendBuffer, int length)
		{
			short num = (short)1318518784;
			short num2 = num;
			if (length <= 0)
			{
				num = (short)2082537473;
				if (num != 0)
				{
				}
				num = (short)1638916871;
				short num3 = num;
				num = (short)1128063751;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1960771584;
					if (num != 0)
					{
					}
					break;
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.BuildRcmpFail);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000180A4 File Offset: 0x000162A4
		protected override void preSendMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			int a_ = 1;
			short num = (short)2084306947;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1107034112;
					short num3 = num;
					if (msg.ReadTimeout == 0)
					{
						num = (short)812384260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 1:
					return;
				case 2:
					goto IL_A3;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 4:
					num = (short)805765121;
					if (num != 0)
					{
					}
					msg.ReadTimeout = 90000;
					num = (short)1760559105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_41:
				num = (short)1556453168;
				short num4 = num;
				num = (short)170497840;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)733020160;
					if (num != 0)
					{
					}
					if (msg == null)
					{
						num = (short)1584726018;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1525022720;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_A3:
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.IshHandler.Validator.b("\udaa9\udeab쮭ힱ\udab3튵醴辿郁ꟃꯅ룇蟉꧋뷍ꏏ돑돓돕", a_));
		}

		// Token: 0x04000021 RID: 33
		private const int a = 90000;

		// Token: 0x04000022 RID: 34
		private bool b;
	}
}
