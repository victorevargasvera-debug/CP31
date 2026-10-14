using System;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000AD RID: 173
	public class PrepareResetIdentifiersCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x0003F5CC File Offset: 0x0003D7CC
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1216020480;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_76;
				}
				bool result;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						num = (short)248323666;
						short num3 = num;
						num = (short)496508498;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_272;
						default:
							goto IL_2AF;
						}
						break;
					}
					case 1:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2;
						if (productFamily.GetValueOrDefault() == productFamily2 & productFamily != null)
						{
							num = (short)1559625738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						bool flag = base.UIValidateService.IsRadioSwitchoverRequired(radioBase.JobStatus, radioBase.CruncherStatus);
						bool? isOutOfSync = radioBase.IsOutOfSync;
						bool flag2 = true;
						num = (short)1799618569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						bool flag;
						if (!flag)
						{
							num = (short)1805123584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 3:
						num = (short)2001797134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1C2;
					case 5:
						goto IL_272;
					case 6:
					{
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
						if (observableCollection.Count > 1)
						{
							num = (short)1256980484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = observableCollection[0];
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily = radioBase.ProductFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2 = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller;
						num = (short)478478347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2;
						if (!(productFamily.GetValueOrDefault() == productFamily2 & productFamily != null))
						{
							num = (short)293601296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 8:
						num = (short)102891522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						bool? isOutOfSync;
						bool flag2;
						if (!(isOutOfSync.GetValueOrDefault() == flag2 & isOutOfSync != null))
						{
							num = (short)648019971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 10:
						goto IL_17F;
					case 11:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2;
						if (!(productFamily.GetValueOrDefault() == productFamily2 & productFamily != null))
						{
							num = (short)1939079185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 12:
					{
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
						if (observableCollection.Count != 0)
						{
							num = (short)1561460741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 13:
						return result;
					case 14:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.ValidationService.CanCreateJob(radioBase.JobStatus))
						{
							num = (short)413794312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 15:
					{
						if (paras.Length == 0)
						{
							num = (short)1793458189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)651689984;
						short num4 = num;
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection = paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>;
						num = (short)1426784268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						num = (short)125239297;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily = radioBase.ProductFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2 = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC;
						num = (short)1048444929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily = radioBase.ProductFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2 = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS;
						num = (short)390987783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_76;
					IL_272:
					num = (short)534315014;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_17F:
				return false;
				IL_1C2:
				return result;
				IL_2AF:
				num = (short)456785920;
				if (num != 0)
				{
				}
				return true;
				IL_76:
				result = false;
				num = (short)1548877839;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0003F9E0 File Offset: 0x0003DBE0
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1764753408;
			switch (num)
			{
			default:
			{
				num = (short)1340604417;
				if (num != 0)
				{
				}
				num = (short)553385987;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
				for (;;)
				{
					IL_65:
					switch (num2)
					{
					case 0:
						goto IL_A1;
					case 1:
						num = (short)226426882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)591790080;
						short num3 = num;
						if (observableCollection.Count > 1)
						{
							num = (short)1046675460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A4;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					case 4:
						goto IL_10A;
					case 5:
						if (observableCollection.Count != 0)
						{
							num = (short)1742929921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A2;
					}
					IL_84:
					while (paras.Length != 0)
					{
						observableCollection = (paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
						num = (short)1096731916;
						short num4 = num;
						num = (short)1372704012;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1789001728;
							if (num != 0)
							{
							}
							num = (short)1398079493;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_65;
						}
					}
					num = (short)1713897472;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A1:
				return null;
				IL_10A:
				IL_1A2:
				return null;
				IL_1A4:
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = observableCollection[0];
				global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext resetIdentifiersContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext(radioBase.ID.Value, radioBase.RadioTimestamp);
				resetIdentifiersContext.SerialNumber = radioBase.SerialNumber;
				resetIdentifiersContext.Password = string.Empty;
				resetIdentifiersContext.ProductFamilyInfo = new global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily?(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX);
				resetIdentifiersContext.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.ResetIdentifierValidationService();
				base.Interaction.ShowResetIdentifiersDialog(resetIdentifiersContext);
				return null;
			}
			}
		}
	}
}
