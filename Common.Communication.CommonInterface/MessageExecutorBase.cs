using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001E RID: 30
	public abstract class MessageExecutorBase : global::Motorola.Common.Communication.IMessageExecutor
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00003420 File Offset: 0x00001620
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000034D0 File Offset: 0x000016D0
		protected byte[] sendBuffer
		{
			get
			{
				short num = (short)1276641281;
				if (num != 0)
				{
				}
				num = (short)7747575;
				short num2 = num;
				num = (short)683751415;
				switch (num2 == num)
				{
				}
				num = (short)620101632;
				short num3 = num;
				num = (short)1227816960;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)884059960;
				short num2 = num;
				num = (short)608284472;
				switch (num2 == num)
				{
				}
				num = (short)892862465;
				if (num != 0)
				{
				}
				num = (short)1648623616;
				short num3 = num;
				num = (short)2127822848;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00003580 File Offset: 0x00001780
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00003630 File Offset: 0x00001830
		protected byte[] receiveBuffer
		{
			get
			{
				short num = (short)273139730;
				short num2 = num;
				num = (short)220317714;
				switch (num2 == num)
				{
				}
				num = (short)438763521;
				if (num != 0)
				{
				}
				num = (short)762511360;
				short num3 = num;
				num = (short)223019008;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1862084614;
				short num2 = num;
				num = (short)128002054;
				switch (num2 == num)
				{
				}
				num = (short)451084289;
				if (num != 0)
				{
				}
				num = (short)125239296;
				short num3 = num;
				num = (short)664076288;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000036E0 File Offset: 0x000018E0
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00003790 File Offset: 0x00001990
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CommPipe
		{
			get
			{
				short num = (short)1770192965;
				short num2 = num;
				num = (short)798294085;
				switch (num2 == num)
				{
				}
				num = (short)262930433;
				if (num != 0)
				{
				}
				num = (short)329777152;
				short num3 = num;
				num = (short)581369856;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)218813054;
				short num2 = num;
				num = (short)144298622;
				switch (num2 == num)
				{
				}
				num = (short)310575104;
				if (num != 0)
				{
				}
				num = (short)1633615872;
				short num3 = num;
				num = (short)560791553;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003844 File Offset: 0x00001A44
		protected virtual void preSendMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			int a_ = 10;
			if (msg == null)
			{
				short num = (short)676265984;
				short num2 = num;
				num = (short)1600490661;
				short num3 = num;
				num = (short)1867746469;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)651952129;
					if (num != 0)
					{
					}
					num = (short)1260322816;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.IteratedProgressIndicator.b("㑃㑅ⵇ᥉⥋⁍㑏ὑㅓ╕⭗㭙㭛㭝", a_));
				}
			}
		}

		// Token: 0x060000E8 RID: 232
		protected abstract void validateSendBuffer(byte[] sendBuffer, int length);

		// Token: 0x060000E9 RID: 233 RVA: 0x00003914 File Offset: 0x00001B14
		public virtual void SendAndReceiveMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			short num = (short)1348707338;
			short num2 = num;
			num = (short)370713610;
			switch (num2 == num)
			{
			}
			num = (short)468779008;
			if (num != 0)
			{
			}
			num = (short)540016640;
			short num3 = num;
			num = (short)1898184705;
			if (num != 0)
			{
			}
			this.preSendMessage(msg);
			int num4 = msg.BuildCommandMessage(this.sendBuffer);
			this.validateSendBuffer(this.sendBuffer, num4);
			this.Execute(num4, msg);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000039E4 File Offset: 0x00001BE4
		public virtual void SendAndReceivePresenceInfo(global::Motorola.Common.Communication.IMessage msg)
		{
			short num = (short)812719137;
			short num2 = num;
			num = (short)1542790177;
			switch (num2 == num)
			{
			}
			num = (short)1433272320;
			if (num != 0)
			{
			}
			num = (short)579338240;
			short num3 = num;
			num = (short)993198081;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadTimeout);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003A98 File Offset: 0x00001C98
		protected virtual void Execute(int sendLength, global::Motorola.Common.Communication.IMessage msg)
		{
			int a_ = 15;
			short num = (short)937164803;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				object syncRoot;
				bool flag;
				switch (num2)
				{
				case 0:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_17D;
						}
						for (;;)
						{
							IL_16B:
							switch (num2)
							{
							case 0:
								goto IL_251;
							case 1:
								goto IL_223;
							case 2:
								if (this.receiveBuffer != null)
								{
									num = (short)661520385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_256;
							}
							goto IL_17D;
						}
						IL_223:
						msg.DecodeReplyMessage(this.receiveBuffer, 0, this.receiveBuffer.Length);
						goto IL_23A;
						IL_251:
						return;
						IL_256:
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IteratedProgressIndicator.b("ᭈ㍊睌潎ᵐ㙒㭔橖≘歚⁜罞๠ᅢ䕤ŦࡨɪŬ੮ᕰ", a_), new object[]
						{
							0
						});
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure);
						IL_17D:
						global::System.Threading.Monitor.Enter(syncRoot, ref flag);
						this.receiveBuffer = this.a.RequestData(this.sendBuffer, 0, sendLength, msg.ReadTimeout);
						num = (short)425022751;
						short num3 = num;
						num = (short)1618826527;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_23A:
							num = (short)1688010752;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_16B;
						default:
							num = (short)1079377920;
							if (num != 0)
							{
							}
							num = (short)380567554;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_16B;
						}
					}
					finally
					{
						num = (short)1823145986;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_2EC;
							case 1:
								global::System.Threading.Monitor.Exit(syncRoot);
								num = (short)1884618752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_2B9;
								}
								continue;
							}
							IL_2B9:
							if (!flag)
							{
								break;
							}
							num = (short)1678901249;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2EC:;
					}
					goto IL_2EF;
				case 1:
					try
					{
						global::System.Threading.Monitor.Enter(syncRoot, ref flag);
						this.a.SendData(this.sendBuffer, 0, sendLength);
						return;
					}
					finally
					{
						num = (short)1333657602;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_10D;
							case 1:
								num = (short)2076377089;
								if (num != 0)
								{
								}
								global::System.Threading.Monitor.Exit(syncRoot);
								num = (short)1534918656;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_B3;
								}
								continue;
							}
							IL_B3:
							if (!flag)
							{
								break;
							}
							num = (short)1589837825;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_10D:;
					}
					goto IL_110;
				case 2:
					goto IL_110;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				}
				IL_3E:
				if (msg.hasReply)
				{
					num = (short)936706050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2EF;
				IL_110:
				num = (short)305397760;
				short num4 = num;
				syncRoot = this.sendBuffer.SyncRoot;
				flag = false;
				num = (short)891224064;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2EF:
				syncRoot = this.sendBuffer.SyncRoot;
				flag = false;
				num = (short)1763311617;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003DF4 File Offset: 0x00001FF4
		public virtual void Setup()
		{
			short num = (short)584758264;
			short num2 = num;
			num = (short)792048632;
			switch (num2 == num)
			{
			}
			num = (short)1696333825;
			if (num != 0)
			{
			}
			num = (short)1130627072;
			short num3 = num;
			num = (short)44695552;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003EA0 File Offset: 0x000020A0
		public virtual void TearDown()
		{
			short num = (short)688586753;
			if (num != 0)
			{
			}
			num = (short)2073529102;
			short num2 = num;
			num = (short)1946520334;
			switch (num2 == num)
			{
			}
			num = (short)452788224;
			short num3 = num;
			num = (short)1420165120;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003F4C File Offset: 0x0000214C
		public void SetRxTimeoutTimer(int timeout)
		{
			short num = (short)1173986071;
			short num2 = num;
			num = (short)1909037847;
			switch (num2 == num)
			{
			}
			num = (short)273219585;
			if (num != 0)
			{
			}
			num = (short)890437632;
			short num3 = num;
			num = (short)1664352256;
			if (num != 0)
			{
			}
			this.a.ReceiveTimeout = timeout;
		}

		// Token: 0x04000015 RID: 21
		private global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe a;

		// Token: 0x04000016 RID: 22
		private byte[] b = new byte[65535];

		// Token: 0x04000017 RID: 23
		private byte[] c;
	}
}
