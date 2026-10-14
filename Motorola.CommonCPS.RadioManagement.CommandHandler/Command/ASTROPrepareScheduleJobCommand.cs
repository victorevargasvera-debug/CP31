using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000048 RID: 72
	public class ASTROPrepareScheduleJobCommand : global::Motorola.CommonCPS.RadioManagement.Command.PrepareScheduleJobCommand
	{
		// Token: 0x06000281 RID: 641 RVA: 0x00022B00 File Offset: 0x00020D00
		protected override void InitializeContext(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios)
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
					return;
				case 1:
					for (;;)
					{
						this.a(radios);
						num2 = (short)25624576;
						short num3 = num2;
						num2 = (short)642219450;
						short num4 = num2;
						num2 = (short)914652602;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_13C;
						}
					}
					IL_13C:
					num2 = (short)689242112;
					if (num2 != 0)
					{
					}
					num2 = (short)859045888;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)68354049;
					if (num2 != 0)
					{
					}
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
					{
						num2 = (short)393412609;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			base.InitializeContext(radios);
			global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService iastrolocalService = base.LocalService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService;
			base.Context.IsConnectionMethodOTAEditable = iastrolocalService.CheckAstroPop25Enabled();
			base.Context.IsConnectionMethodAnyEditable = base.Context.IsConnectionMethodOTAEditable;
			base.Context.IsConnectionMethodWiredEditable = true;
			base.Context.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROScheduleJobContextValidator();
			num2 = (short)18219010;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00022C78 File Offset: 0x00020E78
		protected override void InitContextBasedOnDefaultJobType(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType defaultType)
		{
			base.InitContextBasedOnDefaultJobType(defaultType);
			if (base.Context.Type != global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Read)
			{
				short num = (short)267281062;
				short num2 = num;
				num = (short)1966564006;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)93061120;
					short num3 = num;
					num = (short)207486977;
					if (num != 0)
					{
					}
					num = (short)570359808;
					if (num != 0)
					{
					}
					base.Context.IsWriteProtected = false;
					base.Context.IsWriteProtectedEnable = true;
					base.Context.IsTypeFactoryResetEditable = true;
					return;
				}
				}
			}
			base.Context.IsWriteProtected = false;
			base.Context.IsWriteProtectedEnable = false;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00022D74 File Offset: 0x00020F74
		private void a(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> A_0)
		{
			short num = (short)2065039361;
			if (num != 0)
			{
			}
			base.Context.IsContainingUnprovisionedDevices = false;
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = A_0.GetEnumerator();
			try
			{
				num = (short)2121138181;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1851785223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = enumerator.Current as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
						num = (short)644677640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!astroradio.Provisioned)
						{
							num = (short)426311683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)1864237057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						base.Context.IsContainingUnprovisionedDevices = true;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContextHandler.UpdateExceptionMessage(base.Context);
						num = (short)2003304454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_17B;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					case 6:
						goto IL_15F;
					case 7:
						num = (short)624820228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (astroradio != null)
						{
							num = (short)615120898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_C0:
					num = (short)713490432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_85:
					goto IL_C0;
				}
				IL_15F:
				IL_17B:;
			}
			finally
			{
				num = (short)8716290;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_236;
					case 1:
					{
						enumerator.Dispose();
						num = (short)1029545020;
						short num3 = num;
						num = (short)1813158972;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_236;
						default:
							num = (short)903020544;
							if (num != 0)
							{
							}
							num = (short)2127495168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1B0;
						}
						continue;
					}
					IL_1B0:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1434058753;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_236:;
			}
			num = (short)1584922624;
			short num4 = num;
		}
	}
}
