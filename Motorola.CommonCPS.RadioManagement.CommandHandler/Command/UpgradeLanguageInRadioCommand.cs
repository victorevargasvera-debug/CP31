using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000032 RID: 50
	internal class UpgradeLanguageInRadioCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600022A RID: 554 RVA: 0x0001CB1C File Offset: 0x0001AD1C
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1766260737;
			if (num != 0)
			{
			}
			num = (short)929497094;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerable;
				switch (num2)
				{
				case 0:
					if (enumerable != null)
					{
						num = (short)551223298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
				{
					if (enumerable.Any(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(this.a)))
					{
						num = (short)179240965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1907585088;
					short num3 = num;
					num = (short)13987904;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10E;
					case 1:
						goto IL_1AB;
					}
					goto Block_5;
				}
				case 2:
					num = (short)1446838275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!enumerable.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>())
					{
						num = (short)596967428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1404829697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					continue;
				case 7:
					return false;
				}
				IL_6A:
				if (paras == null)
				{
					num = (short)1723465735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_10E:
				enumerable = (paras[0] as global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
				num = (short)1935933440;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			Block_5:
			num = (short)33030144;
			short num4 = num;
			IL_1AB:
			num = (short)872939520;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0001CCEC File Offset: 0x0001AEEC
		private bool a(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? A_0)
		{
			if (A_0 != null)
			{
				short num;
				for (;;)
				{
					num = (short)1225936800;
					short num2 = num;
					num = (short)2066960288;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_46;
					}
				}
				IL_46:
				num = (short)2042363905;
				if (num != 0)
				{
				}
				num = (short)432668672;
				if (num != 0)
				{
				}
				num = (short)309985280;
				short num3 = num;
				return A_0.Value.HasFlag(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP);
			}
			return false;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0001CDC4 File Offset: 0x0001AFC4
		protected override object ExecuteCmd(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num3;
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerable;
			for (;;)
			{
				IL_0A:
				num = (short)693436416;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (enumerable.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>())
					{
						num = (short)1071316994;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_167;
				case 1:
					goto IL_B2;
				case 2:
				{
					num = (short)1345746243;
					short num4 = num;
					num = (short)2058974531;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1842937857;
						if (num != 0)
						{
						}
						num = (short)1462173696;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.BatchOp.UpgradeLanguageInRadiosBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.UpgradeLanguageInRadiosBatchOp(enumerable.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>());
						base.ExecuteBatchOp<object>(op);
						num = (short)137494529;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					if (enumerable != null)
					{
						num = (short)1477378052;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_167;
				case 4:
					num = (short)1171128320;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
			}
			IL_B2:
			IL_167:
			return null;
			IL_4D:
			enumerable = (paras[0] as global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
			num = (short)184483843;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0001CF50 File Offset: 0x0001B150
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			short num = (short)956532471;
			short num2 = num;
			num = (short)1523484407;
			switch (num2 == num)
			{
			}
			num = (short)1295843329;
			if (num != 0)
			{
			}
			num = (short)1834942464;
			short num3 = num;
			num = (short)1919352832;
			if (num != 0)
			{
			}
			return this.a(A_0.ProductFamily);
		}
	}
}
