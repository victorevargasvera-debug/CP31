using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000019 RID: 25
	public class AstroWifiFileSeqManager : global::Motorola.Common.Communication.AstroFileSeqManager
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x00017FF8 File Offset: 0x000161F8
		public AstroWifiFileSeqManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int inactivityTimer, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
			this.a = inactivityTimer;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0001801C File Offset: 0x0001621C
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)961176750;
			short num2 = num;
			num = (short)2006934702;
			switch (num2 == num)
			{
			}
			num = (short)738131968;
			if (num != 0)
			{
			}
			num = (short)1163395073;
			if (num != 0)
			{
			}
			num = (short)702414848;
			short num3 = num;
			base.UnlockRadioPartition(212);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000180D4 File Offset: 0x000162D4
		private void a(ushort A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation A_1)
		{
			short num = (short)527564801;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1680605184;
					short num3 = num;
					goto IL_82;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 2:
				{
					ushort num4;
					ushort num5;
					base.IOController.ComponentSession(7, A_0, out num4, out num5);
					num = (short)1412104198;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_82;
				case 4:
					if (base.SessionParam.ArchiveSession)
					{
						num = (short)1252524041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
				{
					num = (short)2050595210;
					short num6 = num;
					num = (short)1517132170;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_82;
					default:
						num = (short)991428608;
						if (num != 0)
						{
						}
						if (A_1 == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
						{
							num = (short)155910152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82;
					}
					break;
				}
				case 6:
					return;
				case 7:
					num = (short)1620115467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.EnterWriteProgramMode();
					num = (short)1613824003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)745275393;
					if (num != 0)
					{
					}
					num = (short)1511718926;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)591331341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (A_1 == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
					{
						num = (short)1303052300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)595591173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.EnterReadProgramMode();
					num = (short)1706819584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (!this.b)
					{
						num = (short)1572012039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 14:
					if (!base.DifferentialWriteCapableRadio)
					{
						num = (short)158597122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_60:
				if (A_1 != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)
				{
					num = (short)1662386186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_82:
				num = (short)1039007748;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000183B4 File Offset: 0x000165B4
		protected override void EnterReadProgramMode()
		{
			short num = (short)1584005121;
			if (num != 0)
			{
			}
			num = (short)1093330030;
			short num2 = num;
			num = (short)988996718;
			switch (num2 == num)
			{
			}
			num = (short)1632305152;
			if (num != 0)
			{
			}
			num = (short)1771438080;
			short num3 = num;
			byte[] data = new byte[]
			{
				(byte)(this.a / 256),
				(byte)(this.a & 255)
			};
			base.IOController.EnterProgramMode(5, data);
			((global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
			this.b = true;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000184A8 File Offset: 0x000166A8
		protected override void ExitReadProgramMode()
		{
			short num = (short)627988265;
			short num2 = num;
			num = (short)1179539241;
			switch (num2 == num)
			{
			}
			num = (short)373293056;
			if (num != 0)
			{
			}
			num = (short)1674182657;
			if (num != 0)
			{
			}
			num = (short)1064108032;
			short num3 = num;
			base.IOController.ExitProgramMode(6, new byte[2]);
			this.b = false;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00018568 File Offset: 0x00016768
		protected override void EnterWriteProgramMode()
		{
			short num = (short)1741995066;
			short num2 = num;
			num = (short)2050079802;
			switch (num2 == num)
			{
			}
			num = (short)755040257;
			if (num != 0)
			{
			}
			num = (short)1817378816;
			if (num != 0)
			{
			}
			num = (short)1549205504;
			short num3 = num;
			byte[] data = new byte[]
			{
				(byte)(this.a / 256),
				(byte)(this.a & 255)
			};
			base.IOController.EnterProgramMode(4, data);
			((global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
			this.b = true;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001865C File Offset: 0x0001685C
		protected override void ExitWriteProgramMode()
		{
			short num = (short)429311245;
			short num2 = num;
			num = (short)1686160653;
			switch (num2 == num)
			{
			}
			num = (short)664600577;
			if (num != 0)
			{
			}
			num = (short)116129792;
			if (num != 0)
			{
			}
			num = (short)939130880;
			short num3 = num;
			ushort checksum = ((global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor)base.RcmpWrapper).Checksum;
			byte[] data = new byte[]
			{
				(byte)(checksum / 256),
				(byte)(checksum & 255)
			};
			base.IOController.ExitProgramMode(6, data);
			this.b = false;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00018748 File Offset: 0x00016948
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			short num = (short)1269381685;
			short num2 = num;
			num = (short)1531132469;
			switch (num2 == num)
			{
			}
			num = (short)1547632640;
			if (num != 0)
			{
			}
			num = (short)259129345;
			if (num != 0)
			{
			}
			num = (short)279511040;
			short num3 = num;
			this.a(sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			return base.ManagedReadDevice(referencePba, sessionID);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00018804 File Offset: 0x00016A04
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation)
		{
			short num = (short)768405957;
			short num2 = num;
			num = (short)1645998533;
			switch (num2 == num)
			{
			}
			num = (short)1860173825;
			if (num != 0)
			{
			}
			num = (short)744882176;
			if (num != 0)
			{
			}
			num = (short)233373696;
			short num3 = num;
			this.a(sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			return base.WriteDevice(writePBA, sessionID, null, hostedDepotOperation);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000188C0 File Offset: 0x00016AC0
		public override void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			short num = (short)766814143;
			short num2 = num;
			num = (short)1629398975;
			switch (num2 == num)
			{
			}
			num = (short)448200705;
			if (num != 0)
			{
			}
			num = (short)1401028608;
			if (num != 0)
			{
			}
			num = (short)1029767168;
			short num3 = num;
			this.a(sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			base.ForceWriteDevice(writePBA, sessionID);
		}

		// Token: 0x04000040 RID: 64
		private int a = 60;

		// Token: 0x04000041 RID: 65
		private bool b;
	}
}
