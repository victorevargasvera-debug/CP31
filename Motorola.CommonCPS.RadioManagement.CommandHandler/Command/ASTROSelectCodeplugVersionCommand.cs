using System;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200005F RID: 95
	internal class ASTROSelectCodeplugVersionCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002E8 RID: 744 RVA: 0x0002B8E0 File Offset: 0x00029AE0
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)61014017;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (paras.Count<object>() <= 0)
					{
						num = (short)1619984387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
				{
					num = (short)2118033782;
					short num3 = num;
					num = (short)1423352182;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1325203456;
						if (num != 0)
						{
						}
						num = (short)2077163520;
						short num4 = num;
						num = (short)1529675776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					goto IL_127;
				}
				IL_34:
				num = (short)1676083201;
				if (num != 0)
				{
				}
				if (paras == null)
				{
					break;
				}
				num = (short)756416514;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E9:
			throw new global::System.ArgumentNullException();
			IL_127:
			goto IL_E9;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0002BA18 File Offset: 0x00029C18
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 11;
			short num = (short)1560412165;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.SelectCodeplugVersionContext selectCodeplugVersionContext;
			string codeplugVersion;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					codeplugVersion = selectCodeplugVersionContext.MaxCodeplugVersion;
					num = (short)1552744452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_E4;
				case 2:
					goto IL_167;
				case 3:
					if (paras.Count<object>() <= 0)
					{
						num = (short)1139539970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					selectCodeplugVersionContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectCodeplugVersionContext);
					codeplugVersion = null;
					num = (short)2128216070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_87;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 6:
				{
					if (selectCodeplugVersionContext.SelectedCodeplug == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("뷻鋽矿持紃甅⠇昉洋稍甏愑怓㘕渗缙減洝䤟䴡䨣", a_))
					{
						num = (short)1913126912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					codeplugVersion = selectCodeplugVersionContext.SelectedCodeplug;
					num = (short)1134821376;
					short num3 = num;
					num = (short)1517420551;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_165;
				}
				IL_4E:
				if (paras != null)
				{
					num = (short)851312641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_167;
				IL_E4:
				num = (short)1696595971;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_167:
				num = (short)1856262398;
				short num4 = num;
				num = (short)735662334;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E4;
				default:
					goto IL_19B;
				}
			}
			IL_87:
			IL_165:
			goto IL_1DF;
			IL_19B:
			num = (short)930152448;
			if (num != 0)
			{
			}
			num = (short)1886715905;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException();
			IL_1DF:
			global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROSelectCodeplugVersionBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROSelectCodeplugVersionBatchOp(selectCodeplugVersionContext.Radios, codeplugVersion);
			base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
			return null;
		}
	}
}
