using System;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200009F RID: 159
	internal class EditCodeplugCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003A4 RID: 932 RVA: 0x0003B7E8 File Offset: 0x000399E8
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)10289152;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				bool result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
						if (observableCollection.Count != 0)
						{
							num = (short)1847197708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 1:
					{
						num = (short)1397696096;
						short num3 = num;
						num = (short)58074720;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							num = (short)670433280;
							if (num != 0)
							{
							}
							result = true;
							num = (short)1033699330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_270;
					case 3:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						bool flag;
						if (radioBase.RadioStatus > global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.New && flag)
						{
							num = (short)834666505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 4:
						return result;
					case 5:
						goto IL_2DA;
					case 6:
					{
						num = (short)1592524800;
						short num4 = num;
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
						if (observableCollection.Count > 1)
						{
							num = (short)90439685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = observableCollection[0];
						global::System.Guid? workingTemplateUuid = radioBase.WorkingTemplateUuid;
						num = (short)1817444362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						return false;
					case 8:
					{
						if (paras.Length == 0)
						{
							num = (short)375390212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection = paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>;
						num = (short)852164608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1439236107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)2070413313;
						if (num != 0)
						{
						}
						global::System.Guid? workingTemplateUuid;
						if (workingTemplateUuid == null)
						{
							num = (short)283049991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						bool flag = base.UIValidateService.CanCreateJob(radioBase.JobStatus);
						bool flag2 = base.UIValidateService.IsRadioSwitchoverRequired(radioBase.JobStatus, radioBase.CruncherStatus);
						num = (short)1258094595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						bool flag2;
						if (!flag2)
						{
							num = (short)1676148737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 12:
						num = (short)1442447366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63;
				}
				return result;
				IL_270:
				return result;
				IL_2DA:
				return result;
				IL_63:
				result = false;
				num = (short)1791492104;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0003BAD4 File Offset: 0x00039CD4
		protected override object ExecuteCmd(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (string.IsNullOrEmpty(text))
					{
						goto IL_160;
					}
					num2 = (short)145031168;
					short num3 = num2;
					num2 = (short)397545429;
					short num4 = num2;
					num2 = (short)470159317;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1067384833;
						if (num2 != 0)
						{
						}
						num2 = (short)288489472;
						if (num2 != 0)
						{
						}
						num2 = (short)1731198978;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_15E;
				case 2:
					base.Interaction.ShowNotificationDialog(text, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
					num2 = (short)1186725889;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_15E:
			IL_160:
			return null;
			IL_1C:
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device = (paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>)[0];
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
			global::Motorola.CommonCPS.RadioManagement.Command.SaveTemplateCommandFromCPS @object = new global::Motorola.CommonCPS.RadioManagement.Command.SaveTemplateCommandFromCPS();
			((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).SaveCodeplugDelegate = new global::Motorola.CommonCPS.RadioManagement.SharedServices.SaveCodeplugToRMCDelegate(@object.Execute);
			radioService.EditCodeplug(device, out text);
			num2 = (short)1679032320;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
