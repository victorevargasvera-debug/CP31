using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000008 RID: 8
	public class AstroManagedFileFlashSequenceManager : global::Motorola.Common.Communication.AstroFileFlashSequenceManager
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00008EC0 File Offset: 0x000070C0
		public AstroManagedFileFlashSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00008ED8 File Offset: 0x000070D8
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation)
		{
			short num = (short)2037140346;
			short num2 = num;
			num = (short)1287605114;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1759248384;
				if (num != 0)
				{
				}
				num = (short)400228354;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_E0;
					case 1:
						num = (short)1122631681;
						if (num != 0)
						{
						}
						base.ProgressIndicator.SetCurrentScope(0, 7);
						num = (short)1718616064;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					}
					IL_7A:
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)355401729;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_E0:
				break;
			}
			}
			num = (short)233046016;
			short num4 = num;
			base.UpdateOobeBeforeWrite(writePBA);
			base.UpdatePINPasswordBeforeWrite(writePBA);
			base.UpdateWiFiPasswordBeforeWrite(writePBA);
			base.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
			base.WriteDevice(writePBA, sessionID, null, hostedDepotOperation);
			return writePBA;
		}
	}
}
