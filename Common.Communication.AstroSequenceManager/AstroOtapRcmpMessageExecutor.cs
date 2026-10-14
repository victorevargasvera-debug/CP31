using System;
using System.Threading;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.IshHandler;

namespace Motorola.Common.Communication
{
	// Token: 0x02000018 RID: 24
	public class AstroOtapRcmpMessageExecutor : global::Motorola.Common.Communication.IshHandler.RcmpMessageExecutor
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00017C08 File Offset: 0x00015E08
		public ushort Checksum
		{
			get
			{
				short num = (short)432899833;
				short num2 = num;
				num = (short)71337721;
				switch (num2 == num)
				{
				}
				num = (short)1010761729;
				if (num != 0)
				{
				}
				num = (short)1388576768;
				if (num != 0)
				{
				}
				num = (short)395116544;
				short num3 = num;
				return (ushort)this.b;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00017CB4 File Offset: 0x00015EB4
		public void ResetChecksum()
		{
			short num = (short)590562373;
			short num2 = num;
			num = (short)457327685;
			switch (num2 == num)
			{
			}
			num = (short)93454337;
			if (num != 0)
			{
			}
			num = (short)598278144;
			if (num != 0)
			{
			}
			num = (short)1568014336;
			short num3 = num;
			this.b = 0U;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00017D68 File Offset: 0x00015F68
		public AstroOtapRcmpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, int inactivityTimeout) : base(commPipe)
		{
			this.c = inactivityTimeout * 1000;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00017DA4 File Offset: 0x00015FA4
		protected override void Execute(int sendLength, global::Motorola.Common.Communication.IMessage rcmpMessage)
		{
			int a_ = 18;
			short num = (short)1561216515;
			short num2 = num;
			num = (short)2038187523;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)366608384;
				if (num != 0)
				{
				}
				object syncRoot = base.sendBuffer.SyncRoot;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(syncRoot, ref flag);
					base.CommPipe.SendData(base.sendBuffer, 0, sendLength);
					(rcmpMessage as global::Motorola.Common.Communication.RcmpBaseMessage).CalculateMessageCRC16(ref this.b, base.sendBuffer, 0, sendLength);
					goto IL_129;
				}
				finally
				{
					num = (short)129761280;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1CC;
							}
							continue;
						case 1:
							goto IL_1FF;
						case 2:
							global::System.Threading.Monitor.Exit(syncRoot);
							num = (short)1324613633;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1CC:
						if (!flag)
						{
							break;
						}
						num = (short)1308557314;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1FF:;
				}
				break;
				for (;;)
				{
					IL_129:
					num = (short)13041664;
					short num4 = num;
					syncRoot = this.d.SyncRoot;
					flag = false;
					try
					{
						global::System.Threading.Monitor.Enter(syncRoot, ref flag);
						int length = base.CommPipe.ReceiveData(this.d, 0, this.c);
						rcmpMessage.DecodeReplyMessage(this.d, 0, length);
						break;
					}
					finally
					{
						num = (short)763559936;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								num = (short)1513160705;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_F1;
								}
								continue;
							case 1:
								goto IL_126;
							case 2:
								global::System.Threading.Monitor.Exit(syncRoot);
								num = (short)1478164481;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_F1:
							if (!flag)
							{
								break;
							}
							num = (short)1147207682;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_126:;
					}
				}
				break;
			}
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("倁簃㰅⠇焉㰋猍", a_), new object[]
			{
				rcmpMessage.ToString()
			});
		}

		// Token: 0x0400003C RID: 60
		private const uint a = 0U;

		// Token: 0x0400003D RID: 61
		private uint b;

		// Token: 0x0400003E RID: 62
		private int c = 180000;

		// Token: 0x0400003F RID: 63
		private byte[] d = new byte[65535];
	}
}
