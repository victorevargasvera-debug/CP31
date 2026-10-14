using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000053 RID: 83
	internal class ASTROPrepareSelectCodeplugVersionCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002C6 RID: 710 RVA: 0x00028CB4 File Offset: 0x00026EB4
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)280625152;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.ICollection source;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_74;
						}
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems;
						bool result;
						for (;;)
						{
							IL_62:
							bool flag;
							switch (num2)
							{
							case 0:
								flag = false;
								goto IL_C4;
							case 1:
							{
								global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService iastrouivalidationService = base.UIValidateService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService;
								if (iastrouivalidationService == null)
								{
									num = (short)2073296896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								flag = iastrouivalidationService.CanUpgradeCodeplugVersion(selectedItems);
								goto IL_C4;
							}
							case 2:
								goto IL_DA;
							}
							goto IL_74;
							IL_C4:
							result = flag;
							num = (short)719323138;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_DA:
						return result;
						IL_74:
						selectedItems = source.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
						num = (short)916717569;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_62;
					}
					catch
					{
						return false;
					}
					goto IL_E7;
				case 2:
				{
					num = (short)1665872232;
					short num3 = num;
					num = (short)885338472;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F0;
					case 1:
						goto IL_1CA;
					}
					goto Block_4;
				}
				case 3:
					num = (short)528875521;
					if (num != 0)
					{
					}
					num = (short)757989380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!paras.Any<object>())
					{
						num = (short)608829442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E7;
				}
				IL_39:
				if (paras != null)
				{
					num = (short)1183055875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1E2;
				IL_F0:
				num = (short)1086062593;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E7:
				source = (paras[0] as global::System.Collections.ICollection);
				goto IL_F0;
			}
			Block_4:
			num = (short)144637952;
			short num4 = num;
			IL_1CA:
			num = (short)1195573248;
			if (num != 0)
			{
			}
			IL_1E2:
			throw new global::System.ArgumentNullException();
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00028EBC File Offset: 0x000270BC
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 19;
			short num = (short)197001216;
			switch (num)
			{
			default:
			{
				num = (short)1297350662;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.List<string> supportedCodelugVersion_forUpgradeCPVersion;
						if (supportedCodelugVersion_forUpgradeCPVersion != null)
						{
							num = (short)1014562820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B;
					}
					case 1:
					{
						global::System.Collections.Generic.List<string> supportedCodelugVersion_forUpgradeCPVersion;
						string maxCodeplugVersion = supportedCodelugVersion_forUpgradeCPVersion[0];
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectCodeplugVersionContext selectCodeplugVersionContext;
						selectCodeplugVersionContext.MaxCodeplugVersion = maxCodeplugVersion;
						supportedCodelugVersion_forUpgradeCPVersion.Insert(0, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䔃樅缇欉甋納』縑甓戕紗椙栛㸝嘟䜡嘣唥䄧䔩䈫", a_));
						selectCodeplugVersionContext.Codeplugs = new global::System.Collections.ObjectModel.ObservableCollection<string>(supportedCodelugVersion_forUpgradeCPVersion);
						selectCodeplugVersionContext.SelectedCodeplug = supportedCodelugVersion_forUpgradeCPVersion.First<string>();
						base.Interaction.ShowSelectCodeplugversionDialog(selectCodeplugVersionContext);
						num = (short)930152453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1209532423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_C6;
					case 4:
					{
						num = (short)1226516111;
						short num3 = num;
						num = (short)165881487;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D3;
						default:
						{
							num = (short)1024786432;
							if (num != 0)
							{
							}
							num = (short)762576896;
							short num4 = num;
							num = (short)1545928713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 5:
						goto IL_31E;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 7:
					{
						if (!paras.Any<object>())
						{
							num = (short)1865154570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
						string maximumCpWorkingVer = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.GetMaximumCpWorkingVer(list);
						num = (short)528547848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService iastrolocalService = base.LocalService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService;
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectCodeplugVersionContext selectCodeplugVersionContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.SelectCodeplugVersionContext();
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
						selectCodeplugVersionContext.Radios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(list);
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = list[0].ProductFamily ?? global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX;
						string maximumCpWorkingVer;
						global::System.Collections.Generic.List<string> supportedCodelugVersion_forUpgradeCPVersion = iastrolocalService.GetSupportedCodelugVersion_forUpgradeCPVersion(productFamily, maximumCpWorkingVer);
						goto IL_1D3;
					}
					case 9:
					{
						global::System.Collections.Generic.List<string> supportedCodelugVersion_forUpgradeCPVersion;
						if (supportedCodelugVersion_forUpgradeCPVersion.Count > 0)
						{
							num = (short)269418497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B;
					}
					case 10:
						goto IL_1BE;
					}
					IL_7C:
					if (paras != null)
					{
						num = (short)598016002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CB;
					IL_9B:
					base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_UpgradeCodeplugVersion_NoVersionToUpgrade, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
					num = (short)873594883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D3:
					num = (short)616562689;
					if (num != 0)
					{
					}
					num = (short)1065811968;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C6:
				goto IL_320;
				IL_CB:
				throw new global::System.ArgumentNullException();
				IL_1BE:
				goto IL_CB;
				IL_31E:
				IL_320:
				return null;
			}
			}
		}
	}
}
