using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200007A RID: 122
	internal class FilterAvailableDevicesCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000332 RID: 818 RVA: 0x00031614 File Offset: 0x0002F814
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 3;
			short num = (short)1483931648;
			switch (num)
			{
			default:
			{
				num = (short)2140667909;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> enumerator2;
					int featureType;
					bool flag;
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> list;
						if (list.Count == 0)
						{
							num = (short)1837301768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo = new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.Command, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("닳鿵铷軹駻賽⃿䄁䈃唅", a_));
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>.Enumerator enumerator = list.GetEnumerator();
						num = (short)1320615955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)1657208840;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4CA;
								case 1:
									goto IL_547;
								case 2:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail;
									astroeiddetail.IsSelected = false;
									num = (short)2030829568;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)290717697;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail2;
									if (astroeiddetail2.IsSelected)
									{
										num = (short)1307181058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4CA;
								}
								case 5:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail;
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail2;
									if (astroeiddetail.EntitlementID == astroeiddetail2.EntitlementID)
									{
										num = (short)187891719;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1222836228;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_61E;
								case 7:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail;
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail2;
									astroeiddetail.IsSelected = astroeiddetail2.IsSelected;
									num = (short)1118306313;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_455;
									}
									continue;
								case 9:
									goto IL_4CA;
								case 10:
									num = (short)1555496966;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail;
									if (astroeiddetail == null)
									{
										num = (short)1719271427;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1201733637;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1856045066;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail = enumerator2.Current as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail;
									num = (short)1495269387;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_455;
								IL_4CA:
								num = (short)994574348;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_455:
								num = (short)812449793;
								if (num != 0)
								{
								}
								goto IL_4CA;
							}
							IL_547:
							IL_61E:
							goto IL_3B0;
						}
						finally
						{
							num = (short)581959682;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_68D;
								case 1:
									enumerator2.Dispose();
									num = (short)438566912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_655;
									}
									continue;
								}
								IL_655:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)99745793;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_68D:;
						}
						goto IL_690;
					case 2:
					{
						try
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> list;
							base.LocalService.GetAvailableDevices(registerRadioLicenseContext.AvailableDevices, registerRadioLicenseContext.SelectedGroup.ID, list, featureType);
							goto IL_F4;
						}
						finally
						{
							num = (short)1675886594;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
								switch (num2)
								{
								case 0:
									goto IL_73B;
								case 1:
									automaticPerformanceMeasurer.Dispose();
									num = (short)1224343552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_704;
									}
									continue;
								}
								IL_704:
								if (automaticPerformanceMeasurer == null)
								{
									break;
								}
								num = (short)1765933057;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_73B:;
						}
						goto IL_73E;
						IL_F4:
						num = (short)403963904;
						short num3 = num;
						num = (short)1412169731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_137;
					case 4:
					{
						bool confirmed = false;
						global::System.Windows.Application.Current.Dispatcher.Invoke(delegate()
						{
							short num5 = (short)524934901;
							short num6 = num5;
							num5 = (short)2058936053;
							switch (num6 == num5)
							{
							}
							num5 = (short)2016083968;
							short num7 = num5;
							num5 = (short)1518796801;
							if (num5 != 0)
							{
							}
							num5 = (short)874840064;
							if (num5 != 0)
							{
							}
							confirmed = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Warning_Radio_Feature_Mismatch, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation);
						});
						num = (short)364642315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						continue;
					case 6:
						if (registerRadioLicenseContext.EIDDetails.Count > 1)
						{
							num = (short)960430087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B0;
					case 7:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail2 = registerRadioLicenseContext.SelectChangeSource as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail;
						num = (short)1197604877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_7DE;
					case 9:
						goto IL_A37;
					case 10:
						flag = (null != null);
						goto IL_A19;
					case 11:
						if (!CS$<>8__locals1.confirmed)
						{
							num = (short)970260494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A3C;
					case 12:
						goto IL_842;
					case 13:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail2;
						if (astroeiddetail2 != null)
						{
							num = (short)1751973908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B0;
					}
					case 14:
						enumerator2 = registerRadioLicenseContext.EIDDetails.GetEnumerator();
						num = (short)1082195980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						flag = (registerRadioLicenseContext.SelectChangeSource != null);
						goto IL_A19;
					case 16:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> list = registerRadioLicenseContext.EIDDetails.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail eidDetail)
						{
							short num5 = (short)571900821;
							short num6 = num5;
							num5 = (short)1274971029;
							switch (num6 == num5)
							{
							}
							num5 = (short)1313079296;
							short num7 = num5;
							num5 = (short)1200750593;
							if (num5 != 0)
							{
							}
							num5 = (short)416088064;
							if (num5 != 0)
							{
							}
							return eidDetail.IsSelected;
						}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>();
						registerRadioLicenseContext.SelectedListBoxSelctedItems.Clear();
						registerRadioLicenseContext.AvailableListBoxSelectedItems.Clear();
						registerRadioLicenseContext.AvailableDevices.Clear();
						registerRadioLicenseContext.SelectedDevices.Clear();
						num = (short)364707840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (registerRadioLicenseContext == null)
						{
							num = (short)115736598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)709361679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_CB;
					case 19:
					{
						global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo;
						try
						{
							num = (short)2106327040;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_881;
									}
									continue;
								case 2:
									goto IL_95A;
								case 3:
									num = (short)436862978;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									num = (short)344388228;
									short num4 = num;
									num = (short)42332804;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)1521614848;
										if (num != 0)
										{
										}
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>.Enumerator enumerator;
										if (enumerator.MoveNext())
										{
											global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail eiddetail = enumerator.Current;
											operationInfo.AddOrUpdateParameter(eiddetail.ActivationID, "");
											num = (short)373358593;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									num = (short)1070923779;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_883:
								num = (short)1226506244;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_881:
								goto IL_883;
							}
							IL_95A:
							goto IL_14A;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_96D;
						IL_14A:
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.StartNewAutomatic(operationInfo, null);
						num = (short)1946812418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_73E;
					case 21:
						if (registerRadioLicenseContext.SelectedDevices.Count > 0)
						{
							num = (short)1207566340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A3C;
					case 22:
						goto IL_690;
					}
					IL_A8:
					if (paras.Length < 2)
					{
						num = (short)1080098834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					registerRadioLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext);
					featureType = (int)paras[1];
					num = (short)308412433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B0:
					num = (short)1151664144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_690:
					num = (short)1879048202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_73E:
					enumerator2 = registerRadioLicenseContext.EIDDetails.GetEnumerator();
					num = (short)944439297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_96D:
					num = (short)709427221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A19:
					if (!flag)
					{
						num = (short)1411317769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_96D;
					IL_A3C:
					num = (short)807862278;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CB:
				return null;
				IL_137:
				global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext2 = registerRadioLicenseContext;
				string noDeviceWarning;
				if (registerRadioLicenseContext.AvailableDevices.Count == 0)
				{
					noDeviceWarning = global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_No_Available_Radio;
					goto IL_A82;
				}
				IL_302:
				noDeviceWarning = string.Empty;
				goto IL_A82;
				IL_7DE:
				registerRadioLicenseContext.NoDeviceWarning = string.Empty;
				return null;
				IL_842:
				try
				{
					num = (short)661520386;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_28D;
						case 1:
							num = (short)148242432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1BE;
							}
							continue;
						case 3:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail eiddetail2;
							eiddetail2.IsSelected = !eiddetail2.IsSelected;
							num = (short)1059586054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> enumerator2;
							if (!enumerator2.MoveNext())
							{
								num = (short)1771700225;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail eiddetail2 = enumerator2.Current;
							num = (short)699990021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail eiddetail2;
							if (eiddetail2.Equals(registerRadioLicenseContext.SelectChangeSource))
							{
								num = (short)1538981891;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_1E6;
						}
						IL_1EB:
						num = (short)339804164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BE:
						goto IL_1EB;
					}
					IL_1E6:
					IL_28D:
					goto IL_81B;
				}
				finally
				{
					num = (short)684982274;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> enumerator2;
						switch (num2)
						{
						case 0:
							goto IL_2FF;
						case 1:
							enumerator2.Dispose();
							num = (short)554172416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2C5;
							}
							continue;
						}
						IL_2C5:
						if (enumerator2 == null)
						{
							break;
						}
						num = (short)427032577;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2FF:;
				}
				goto IL_302;
				IL_81B:
				return null;
				IL_A37:
				return null;
				IL_A82:
				registerRadioLicenseContext2.NoDeviceWarning = noDeviceWarning;
				return null;
			}
			}
		}
	}
}
