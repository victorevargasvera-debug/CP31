using System;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000C2 RID: 194
	internal class EditPackageColumnCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x00045010 File Offset: 0x00043210
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)400883713;
			if (num != 0)
			{
			}
			num = (short)1695096321;
			short num2 = num;
			num = (short)1276714497;
			switch (num2 == num)
			{
			}
			num = (short)1491992576;
			short num3 = num;
			num = (short)1844576256;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000450B8 File Offset: 0x000432B8
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 14;
			short num = (short)1612840960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1315045377;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase packageBase;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_5B:
						switch (num2)
						{
						case 0:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase packageBase2;
							if (packageBase.Comments != packageBase2.Comments)
							{
								num = (short)977076225;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return packageBase;
						}
						case 1:
						{
							num = (short)1869071713;
							short num3 = num;
							num = (short)1286784353;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_87;
							default:
							{
								num = (short)650641408;
								if (num != 0)
								{
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase packageBase2;
								global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.EditPackageColumn(packageBase2.ToEntity());
								num = (short)1949499397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 2:
							goto IL_D5;
						case 3:
						{
							string a = paras[1] as string;
							object obj = paras[2];
							if (a != global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("볾渀渂栄戆月缊縌", a_))
							{
								num = (short)206831618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase packageBase2 = packageBase.Clone() as global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase;
							packageBase2.Comments = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(obj.ToString());
							num = (short)346619904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
							packageBase.CopyFrom(packageSummary.ToUiModel());
							num = (short)20316166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
							if (packageSummary != null)
							{
								num = (short)1545797636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return packageBase;
						}
						case 6:
							return packageBase;
						}
						goto IL_7E;
					}
					IL_D5:
					num = (short)740491264;
					short num4 = num;
					return packageBase;
				}
				}
				IL_7E:
				packageBase = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase);
				IL_87:
				num = (short)1751711747;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5B;
			}
			}
		}
	}
}
