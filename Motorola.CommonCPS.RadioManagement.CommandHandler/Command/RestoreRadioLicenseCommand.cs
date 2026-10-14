using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ASK.Interface;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000089 RID: 137
	internal class RestoreRadioLicenseCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600035B RID: 859 RVA: 0x0003500C File Offset: 0x0003320C
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1536163842;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> enumerator;
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> observableCollection;
				switch (num2)
				{
				case 0:
					num = (short)1491075078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_2FE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 3:
					try
					{
						num = (short)2041249794;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)925958145;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1C6;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_118;
								}
								continue;
							case 3:
								result = false;
								num = (short)478478342;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								if (enumerator.Current.RawData.FeatureStatus != 16)
								{
									num = (short)205914115;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 5:
								if (!enumerator.MoveNext())
								{
									num = (short)1693908992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1552809988;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_1AA;
							}
							IL_159:
							num = (short)572653573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_118:
							goto IL_159;
						}
						IL_1AA:
						return result;
						IL_1C6:
						return true;
					}
					finally
					{
						num = (short)41943040;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1FB;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)204668930;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_22F;
							}
							IL_1FB:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1647247361;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_22F:;
					}
					goto IL_232;
				case 4:
					return false;
				case 5:
					if (observableCollection != null)
					{
						goto IL_27B;
					}
					return false;
				case 6:
					if (observableCollection.Count == 0)
					{
						num = (short)1292042241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_232;
				}
				IL_40:
				num = (short)1214318468;
				short num3 = num;
				num = (short)1334970244;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_27B:
					num = (short)496041984;
					short num4 = num;
					num = (short)1489502208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				default:
					num = (short)211222528;
					if (num != 0)
					{
					}
					num = (short)1409089537;
					if (num != 0)
					{
					}
					if (paras.Length == 0)
					{
						num = (short)1131872260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					observableCollection = (paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>);
					num = (short)638713861;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_232:
				enumerator = observableCollection.GetEnumerator();
				num = (short)1478623235;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_2FE:
			return false;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0003532C File Offset: 0x0003352C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)355794944;
			switch (num)
			{
			default:
			{
				num = (short)173080577;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> observableCollection;
				global::System.Collections.Generic.Dictionary<string, global::ASK.Interface.ISystemKeyData> dictionary;
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
					global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService iastrolocalService;
					switch (num2)
					{
					case 0:
						goto IL_98;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					case 2:
						if (observableCollection.Count == 0)
						{
							num = (short)2090401795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A2;
					case 3:
						goto IL_64D;
					case 4:
						num = (short)704053250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext selectASKForCFSContext;
						if (base.Interaction.ShowSelectASKDialogForCFS(selectASKForCFSContext))
						{
							num = (short)1620181000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AD;
					}
					case 6:
						if (observableCollection != null)
						{
							num = (short)1275723780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AB;
					case 7:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext selectASKForCFSContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext();
						selectASKForCFSContext.Radios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(list);
						selectASKForCFSContext.LoadedASKs = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.GetLoadedASKWithoutDefault(false);
						selectASKForCFSContext.RadioASKMapping = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData>();
						num = (short)1911357445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						dictionary = new global::System.Collections.Generic.Dictionary<string, global::ASK.Interface.ISystemKeyData>();
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext selectASKForCFSContext;
						global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData>.Enumerator enumerator = selectASKForCFSContext.RadioASKMapping.GetEnumerator();
						num = (short)757071881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						num = (short)469303296;
						short num3 = num;
						try
						{
							num = (short)1796014082;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1921646595;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData> keyValuePair = enumerator.Current;
									dictionary.Add(keyValuePair.Key.SerialNumber, keyValuePair.Value);
									num = (short)1984888832;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_232;
									}
									continue;
								case 3:
									num = (short)1352007684;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_2BE;
								}
								IL_234:
								num = (short)558104577;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_232:
								goto IL_234;
							}
							IL_2BE:;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2CE;
					}
					case 10:
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator2 = observableCollection.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase license)
						{
							short num5 = (short)844300289;
							if (num5 != 0)
							{
							}
							num5 = (short)1774820019;
							short num6 = num5;
							num5 = (short)682400435;
							switch (num6 == num5)
							{
							}
							num5 = (short)1811808256;
							short num7 = num5;
							num5 = (short)1772158976;
							if (num5 != 0)
							{
							}
							return license.SerialNumber;
						}).Distinct<string>().ToList<string>().GetEnumerator();
						num = (short)226557965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)1436549121;
						if (num != 0)
						{
						}
						if (list.Count > 0)
						{
							num = (short)2085814279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CE;
					case 12:
						goto IL_2E7;
					case 13:
						for (;;)
						{
							try
							{
								num = (short)803078144;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_353;
										}
										continue;
									case 1:
									{
										global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid;
										if (radioByDeviceUuid == null)
										{
											num = (short)1884160008;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplug = (radioByDeviceUuid as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).WorkingCodeplug;
										string astroPurchasedFlashCode = (radioByDeviceUuid.ToUiModel(true) as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).AstroPurchasedFlashCode;
										num = (short)1915289610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::System.Collections.Generic.List<string>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)120520716;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string rdSN = enumerator2.Current;
										global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense astroLicense = observableCollection.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase lic)
										{
											short num5 = (short)1018100110;
											short num6 = num5;
											num5 = (short)956365198;
											switch (num6 == num5)
											{
											}
											num5 = (short)1727528961;
											if (num5 != 0)
											{
											}
											num5 = (short)1580924928;
											short num7 = num5;
											num5 = (short)308084736;
											if (num5 != 0)
											{
											}
											return lic.SerialNumber == rdSN;
										}) as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense;
										num = (short)1318256649;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										if (list.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase rd)
										{
											short num5 = (short)234348687;
											short num6 = num5;
											num5 = (short)938270863;
											switch (num6 == num5)
											{
											}
											num5 = (short)582287360;
											if (num5 != 0)
											{
											}
											num5 = (short)1536294912;
											short num7 = num5;
											num5 = (short)296091649;
											if (num5 != 0)
											{
											}
											return rd.DeviceUuid == CS$<>8__locals2.astroLicense.DeviceUuid.Value;
										}) == null)
										{
											num = (short)1550516235;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 4:
										goto IL_58F;
									case 6:
									{
										global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid;
										list.Add(radioByDeviceUuid.ToUiModel(true));
										num = (short)946077701;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										num = (short)1687093251;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										goto IL_3AD;
									case 9:
										if (iastrolocalService.AstroCheckAskEnable(CS$<>8__locals2.astroLicense.FlashCode, CS$<>8__locals2.astroLicense.ModelNumber))
										{
											num = (short)832765959;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 10:
									{
										global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid;
										string astroPurchasedFlashCode;
										if (!iastrolocalService.AstroCheckAskEnable(astroPurchasedFlashCode, radioByDeviceUuid.ModelNumber))
										{
											num = (short)646643718;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 11:
									{
										global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioByDeviceUuid(CS$<>8__locals2.astroLicense.DeviceUuid.Value, true);
										num = (short)943259649;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										num = (short)1080950788;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_4FE:
									num = (short)592183298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_353:
									goto IL_4FE;
								}
								IL_3AD:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DeviceNoExistForEditTemplate, null);
								IL_58F:
								goto IL_F6;
							}
							finally
							{
								global::System.Collections.Generic.List<string>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_5A2;
							IL_F6:
							num = (short)1689122847;
							short num4 = num;
							num = (short)1915549727;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_12C;
							}
						}
						IL_12C:
						num = (short)1678573568;
						if (num != 0)
						{
						}
						num = (short)174325771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7B:
					if (paras.Length == 0)
					{
						num = (short)562888704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					observableCollection = (paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>);
					num = (short)229441542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CE:
					num = (short)1243611148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A2:
					dictionary = null;
					iastrolocalService = (base.LocalService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService);
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
					num = (short)126484490;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_98:
				return null;
				IL_1AB:
				return null;
				IL_1AD:
				return false;
				IL_2E7:
				global::Motorola.CommonCPS.RadioManagement.BatchOp.RestoreRadioLicenseBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.RestoreRadioLicenseBatchOp(observableCollection.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase license)
				{
					short num5 = (short)1207241544;
					short num6 = num5;
					num5 = (short)768740168;
					switch (num6 == num5)
					{
					}
					num5 = (short)187498497;
					if (num5 != 0)
					{
					}
					num5 = (short)1072627712;
					short num7 = num5;
					num5 = (short)974127104;
					if (num5 != 0)
					{
					}
					return license;
				}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>(), dictionary);
				base.ExecuteBatchOp<string>(op);
				return true;
				IL_64D:
				goto IL_1AB;
			}
			}
		}
	}
}
