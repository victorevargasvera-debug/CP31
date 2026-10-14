using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000E RID: 14
	public class AstroOtapIshSequenceManager : global::Motorola.Common.Communication.AstroIshSequenceManager, global::Motorola.Common.Communication.IFwdl
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00012504 File Offset: 0x00010704
		public AstroOtapIshSequenceManager(global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor rcmpWrapper, int inactivityTimer, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParam) : base(rcmpWrapper, sessionParam)
		{
			this.a = inactivityTimer;
			this.m_MaxTransportPacketSize = 968;
			base.IshHandler = new global::Motorola.Common.Communication.IshHandler.CommonIshHandler(rcmpWrapper, this.m_MaxTransportPacketSize);
			base.IOController = new global::Motorola.Common.Communication.IshHandler.IOController(rcmpWrapper, this.m_MaxTransportPacketSize, false);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0001255C File Offset: 0x0001075C
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			short num = (short)1115947011;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2060582913;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)1167785988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					goto IL_B0;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 4:
					if (!pendingDeploy)
					{
						num = (short)524288006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
				{
					num = (short)2103304193;
					short num3 = num;
					num = (short)1672536065;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_172;
					default:
						num = (short)835780608;
						if (num != 0)
						{
						}
						if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
						{
							num = (short)1609105408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 6:
					this.ExitWriteProgramMode();
					num = (short)1542782977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_66:
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
				{
					num = (short)620363776;
					short num4 = num;
					num = (short)1067909122;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)58851333;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_B0:
			IL_172:
			this.ExitReadProgramMode();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00012704 File Offset: 0x00010904
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)1334771717;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_16D;
				case 2:
					goto IL_EC;
				case 3:
					base.UnlockRadioPartition(0);
					num = (short)1616838657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
					{
						num = (short)79167494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
				{
					num = (short)739226794;
					short num3 = num;
					num = (short)501462186;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16D;
					default:
						num = (short)674758656;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					}
					break;
				}
				case 6:
					this.EnterWriteProgramMode();
					num = (short)1480196096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_121;
				case 8:
					if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
					{
						num = (short)559677447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)395771908;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_93:
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)
				{
					num = (short)1784086531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.UnlockRadioPartition(212);
				num = (short)82378752;
				short num4 = num;
				num = (short)1515323394;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC:
				num = (short)417202184;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16D:
				goto IL_EC;
			}
			IL_121:
			num = (short)686030849;
			if (num != 0)
			{
			}
			this.EnterReadProgramMode();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000128FC File Offset: 0x00010AFC
		protected override void EnterReadProgramMode()
		{
			short num = (short)506507713;
			short num2 = num;
			num = (short)1959440833;
			switch (num2 == num)
			{
			}
			num = (short)362086401;
			if (num != 0)
			{
			}
			num = (short)18546688;
			short num3 = num;
			num = (short)1878982656;
			if (num != 0)
			{
			}
			byte[] data = new byte[]
			{
				(byte)(this.a / 256),
				(byte)(this.a & 255)
			};
			base.IOController.EnterProgramMode(5, data);
			((global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000129EC File Offset: 0x00010BEC
		protected override void ExitReadProgramMode()
		{
			short num = (short)803007187;
			short num2 = num;
			num = (short)1230760659;
			switch (num2 == num)
			{
			}
			num = (short)1503592449;
			if (num != 0)
			{
			}
			num = (short)476971008;
			short num3 = num;
			num = (short)2044526592;
			if (num != 0)
			{
			}
			base.IOController.ExitProgramMode(6, new byte[2]);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00012AAC File Offset: 0x00010CAC
		protected override void EnterWriteProgramMode()
		{
			short num = (short)2142446337;
			short num2 = num;
			num = (short)92939009;
			switch (num2 == num)
			{
			}
			num = (short)964100097;
			if (num != 0)
			{
			}
			num = (short)126091264;
			short num3 = num;
			num = (short)339935232;
			if (num != 0)
			{
			}
			byte[] data = new byte[]
			{
				(byte)(this.a / 256),
				(byte)(this.a & 255)
			};
			base.IOController.EnterProgramMode(4, data);
			((global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00012B98 File Offset: 0x00010D98
		protected override void ExitWriteProgramMode()
		{
			short num = (short)98613249;
			short num2 = num;
			num = (short)232765441;
			switch (num2 == num)
			{
			}
			num = (short)29622273;
			if (num != 0)
			{
			}
			num = (short)1097138176;
			short num3 = num;
			num = (short)941948928;
			if (num != 0)
			{
			}
			ushort checksum = ((global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor)base.RcmpWrapper).Checksum;
			byte[] data = new byte[]
			{
				(byte)(checksum / 256),
				(byte)(checksum & 255)
			};
			base.IOController.ExitProgramMode(6, data);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00012C7C File Offset: 0x00010E7C
		public bool SetFWDLConfig(ushort tg, string version)
		{
			int a_ = 0;
			short num = (short)1138929785;
			short num2 = num;
			num = (short)725397625;
			switch (num2 == num)
			{
			}
			num = (short)1952317441;
			if (num != 0)
			{
			}
			num = (short)10027008;
			short num3 = num;
			num = (short)467992576;
			if (num != 0)
			{
			}
			bool flag = base.IOController.SetDownLoadTGVersion(tg, version);
			if (!flag)
			{
				string format = string.Format(global::Motorola.Common.Communication.Crc32.c("\udd9a쪜\udb9e莢좦잨춪쒬좮醰\udab4\udab6풸\udaba펼\udbbeꗂ꓄껆ꗈ껊꧌럐볒꟔跘鳚￞髠폢飤쟦裨藪觬쿮런髲蟴髶軸髺迼髾℀唂怄甆稈戊戌愎⬐㌒渔☖搘", a_), tg, version);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(format, global::System.Array.Empty<object>());
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_FWDL_Xcmp_SetupCommand_Failed);
			}
			return flag;
		}

		// Token: 0x04000062 RID: 98
		private int a = 180;
	}
}
