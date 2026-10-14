using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	public class AstroWiFiManagedFileFlashSequenceManager : global::Motorola.Common.Communication.AstroManagedFileFlashSequenceManager
	{
		// Token: 0x06000048 RID: 72 RVA: 0x0000901C File Offset: 0x0000721C
		public AstroWiFiManagedFileFlashSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int inactivityTimer, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
			this.a = inactivityTimer;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00009040 File Offset: 0x00007240
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)1173071249;
			short num2 = num;
			num = (short)1911727505;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1668087809;
				if (num != 0)
				{
				}
				num = (short)1331757056;
				if (num != 0)
				{
				}
				num = (short)1848377346;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_E4;
					case 1:
						base.UnlockRadioPartition(0);
						this.b = sessionID;
						num = (short)1503199232;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					}
					IL_A5:
					if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
					{
						break;
					}
					num = (short)1251540993;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_E4:
				break;
			}
			}
			num = (short)1845035008;
			short num4 = num;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00009160 File Offset: 0x00007360
		public override void CloseSession(ushort sessionId, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			short num = (short)303955968;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
				{
					ushort num3;
					ushort num4;
					base.IOController.ComponentSession(1056, sessionId, out num3, out num4);
					base.ValidateUpdate();
					num = (short)39714819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return;
				case 3:
					num = (short)489029633;
					if (num != 0)
					{
					}
					goto IL_D3;
				case 4:
					if (!pendingDeploy)
					{
						num = (short)999096321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D3;
				case 5:
					num = (short)182910980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_3C;
				IL_14:
				switch (0)
				{
				case 0:
				{
					IL_3C:
					if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
					{
						return;
					}
					num = (short)1490957105;
					short num5 = num;
					num = (short)1292448561;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
					{
						num = (short)1525678080;
						short num6 = num;
						num = (short)568983552;
						if (num != 0)
						{
						}
						num = (short)1979121669;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
					break;
				}
				}
				continue;
				IL_D3:
				this.ExitWriteProgramMode();
				num = (short)574357506;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000092F8 File Offset: 0x000074F8
		protected override void EnterWriteProgramMode()
		{
			short num = (short)1913650332;
			short num2 = num;
			num = (short)734526620;
			switch (num2 == num)
			{
			}
			num = (short)1799553025;
			if (num != 0)
			{
			}
			num = (short)521535488;
			if (num != 0)
			{
			}
			num = (short)276496384;
			short num3 = num;
			byte[] data = new byte[]
			{
				(byte)(this.a / 256),
				(byte)(this.a & 255)
			};
			base.IOController.EnterProgramMode(4, data);
			((global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
			this.c = true;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000093EC File Offset: 0x000075EC
		protected override void ExitWriteProgramMode()
		{
			short num = (short)788856833;
			if (num != 0)
			{
			}
			num = (short)1207605433;
			short num2 = num;
			num = (short)209623225;
			switch (num2 == num)
			{
			}
			num = (short)1579876352;
			if (num != 0)
			{
			}
			num = (short)1315700736;
			short num3 = num;
			ushort checksum = ((global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor)base.RcmpWrapper).Checksum;
			byte[] data = new byte[]
			{
				(byte)(checksum / 256),
				(byte)(checksum & 255)
			};
			base.IOController.ExitProgramMode(6, data);
			this.c = false;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000094D8 File Offset: 0x000076D8
		public override void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionId, bool hostedDepotOperation, int? userDefersAllowed = null)
		{
			short num = (short)365101056;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 1:
					goto IL_1EB;
				case 2:
					if (!base.DifferentialWriteCapableRadio)
					{
						num = (short)189988868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1ED;
				case 3:
					goto IL_C2;
				case 4:
				{
					num = (short)48824320;
					short num3 = num;
					ushort num4;
					ushort num5;
					base.IOController.ComponentSession(7, this.b, out num4, out num5);
					goto IL_A9;
				}
				case 5:
				{
					num = (short)1589232421;
					short num6 = num;
					num = (short)1265419045;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A9;
					default:
						num = (short)926875648;
						if (num != 0)
						{
						}
						num = (short)2047082498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
				{
					num = (short)2123366401;
					if (num != 0)
					{
					}
					if (base.SessionParam.ArchiveSession)
					{
						num = (short)1955987461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					ushort num4;
					ushort num5;
					base.IOController.ComponentSession(3, this.b, out num4, out num5);
					num = (short)1657667585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					this.EnterWriteProgramMode();
					num = (short)627703814;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_45:
				if (!this.c)
				{
					num = (short)147783687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A9:
				num = (short)1467219971;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C2:
			IL_1EB:
			IL_1ED:
			base.UpdateDevice(pbaObject, sessionId, hostedDepotOperation, userDefersAllowed);
		}

		// Token: 0x04000024 RID: 36
		private int a = 60;

		// Token: 0x04000025 RID: 37
		private ushort b;

		// Token: 0x04000026 RID: 38
		private bool c;
	}
}
