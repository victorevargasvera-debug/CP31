using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using ASK.Interface;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000090 RID: 144
	internal class SubmitLicenseAssignmentCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000373 RID: 883 RVA: 0x00036D34 File Offset: 0x00034F34
		public override bool CanExecute(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (registerRadioLicenseContext.EIDDetails.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>().Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail ed)
					{
						short num5 = (short)1759526677;
						short num6 = num5;
						num5 = (short)26492693;
						switch (num6 == num5)
						{
						}
						num5 = (short)1275920384;
						short num7 = num5;
						num5 = (short)712638465;
						if (num5 != 0)
						{
						}
						num5 = (short)1712259072;
						if (num5 != 0)
						{
						}
						return ed.IsSelected;
					}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>().Count == 0)
					{
						num2 = (short)1240858625;
						if (num2 != 0)
						{
						}
						num2 = (short)1472331781;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					goto IL_D0;
				case 2:
					return false;
				case 3:
					if (registerRadioLicenseContext == null)
					{
						num2 = (short)1080426502;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1885011972;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (registerRadioLicenseContext.SelectedDevices.Count == 0)
					{
						num2 = (short)1227489281;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1807876096;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return false;
				case 6:
				{
					num2 = (short)2041919522;
					short num3 = num2;
					num2 = (short)440154146;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num2 = (short)1472266240;
						if (num2 != 0)
						{
						}
						num2 = (short)1745420290;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_2C;
			}
			IL_D0:
			num2 = (short)1137246208;
			short num4 = num2;
			return false;
			IL_2C:
			registerRadioLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext);
			num2 = (short)1963851779;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00036F18 File Offset: 0x00035118
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)675020800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1924071424;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				global::System.Collections.Generic.Dictionary<string, global::ASK.Interface.ISystemKeyData> dictionary;
				int featureType;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> list;
				global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext lisenceContext;
				bool isUserSelectASK;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext askSelectionContext;
				for (;;)
				{
					IL_54:
					switch (num2)
					{
					case 0:
					{
						num = (short)773718017;
						if (num != 0)
						{
						}
						bool flag;
						if (flag)
						{
							num = (short)806289414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4EE;
					}
					case 1:
					{
						dictionary = new global::System.Collections.Generic.Dictionary<string, global::ASK.Interface.ISystemKeyData>();
						global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData>.Enumerator enumerator = askSelectionContext.RadioASKMapping.GetEnumerator();
						num = (short)1731657737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (paras.Length < 2)
						{
							num = (short)560726026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						lisenceContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext);
						featureType = (int)paras[1];
						num = (short)769654788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						askSelectionContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext();
						askSelectionContext.Radios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(lisenceContext.SelectedDevices);
						askSelectionContext.LoadedASKs = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.GetLoadedASKWithoutDefault(false);
						askSelectionContext.RadioASKMapping = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData>();
						isUserSelectASK = false;
						global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
						{
							short num5 = (short)1259313756;
							short num6 = num5;
							num5 = (short)348691036;
							switch (num6 == num5)
							{
							}
							num5 = (short)2073493504;
							short num7 = num5;
							num5 = (short)1313800193;
							if (num5 != 0)
							{
							}
							num5 = (short)612696064;
							if (num5 != 0)
							{
							}
							isUserSelectASK = this.Interaction.ShowSelectASKDialogForCFS(askSelectionContext);
							lisenceContext.IsExecuted = isUserSelectASK;
						}), global::System.Array.Empty<object>()).Wait();
						num = (short)406257671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (lisenceContext == null)
						{
							num = (short)1956773893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)209715213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_2C1;
					case 6:
						num = (short)91881480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (isUserSelectASK)
						{
							num = (short)1740898305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C6;
					case 8:
					{
						bool flag2;
						if (!flag2)
						{
							num = (short)740360195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4EE;
					}
					case 9:
						goto IL_157;
					case 10:
						goto IL_D8;
					case 11:
					{
						list = lisenceContext.EIDDetails.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>().Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail ed)
						{
							short num5 = (short)2030756344;
							short num6 = num5;
							num5 = (short)1284366840;
							switch (num6 == num5)
							{
							}
							num5 = (short)124911616;
							short num7 = num5;
							num5 = (short)255524865;
							if (num5 != 0)
							{
							}
							num5 = (short)89325568;
							if (num5 != 0)
							{
							}
							return ed.IsSelected;
						}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>();
						dictionary = null;
						global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService iastrolocalService = base.LocalService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService;
						new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadio>();
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail = list[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail;
						bool flag = iastrolocalService.AstroCheckAskEnable(astroeiddetail.TargetFlashcode, astroeiddetail.SourceModelNumber);
						bool flag2 = iastrolocalService.AstroCheckAskEnable(astroeiddetail.SourceFlashcode, astroeiddetail.SourceModelNumber);
						num = (short)765394944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_122;
					case 13:
						if (lisenceContext.SelectedDevices.Count == 0)
						{
							num = (short)1128923148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)549650443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_93;
				}
				IL_D8:
				return null;
				IL_122:
				return null;
				IL_157:
				goto IL_3C5;
				try
				{
					for (;;)
					{
						IL_3C5:
						num = (short)1602813956;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1950941185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData> keyValuePair = enumerator.Current;
								dictionary.Add(keyValuePair.Key.SerialNumber, keyValuePair.Value);
								num = (short)1104609282;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								num = (short)2084503555;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_4DE;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_3FF;
								}
								continue;
							}
							IL_43A:
							num = (short)520035189;
							short num4 = num;
							num = (short)1397889909;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3C5;
							default:
								num = (short)1749483520;
								if (num != 0)
								{
								}
								num = (short)735444992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_3FF:
							goto IL_43A;
						}
					}
					IL_4DE:;
				}
				finally
				{
					global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData>.Enumerator enumerator;
					((global::System.IDisposable)enumerator).Dispose();
				}
				goto IL_4EE;
				IL_2C1:
				return null;
				IL_2C6:
				return false;
				IL_4EE:
				global::Motorola.CommonCPS.RadioManagement.BatchOp.SubmitLicenseAssignmentBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.SubmitLicenseAssignmentBatchOp(lisenceContext.SelectedDevices.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(), list, dictionary, featureType);
				base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
				return true;
				IL_93:
				num = (short)110493698;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			}
		}
	}
}
