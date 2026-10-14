using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000043 RID: 67
	internal class AstroUpgradeCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000270 RID: 624 RVA: 0x000211B8 File Offset: 0x0001F3B8
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)626327557;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1510434252;
				short num3 = num;
				num = (short)1461872076;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1796734976;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_16A;
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext;
						if (selectFirmwareContext.IsASKDialogVisible)
						{
							num = (short)1793130496;
							short num4 = num;
							num = (short)197132296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 2:
					{
						if (paras.Count<object>() <= 0)
						{
							num = (short)1162412041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext;
						num = (short)1692467203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)2009202689;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext;
						if (selectFirmwareContext.SelectedFirmware != null)
						{
							num = (short)1248264198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext;
						if (selectFirmwareContext.SelectedSystemID == null)
						{
							num = (short)869597191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_97;
						}
						continue;
					case 6:
						num = (short)332595201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_F8;
					case 8:
						num = (short)1325793284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1A6;
					}
					IL_97:
					if (paras != null)
					{
						num = (short)1168900096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AA;
				}
				IL_16A:
				num = (short)803405826;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F8:
			return false;
			IL_1A6:
			IL_1AA:
			throw new global::System.ArgumentNullException();
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000213DC File Offset: 0x0001F5DC
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 12;
			short num = (short)1038548992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				string msg;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator2;
					global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> source;
					global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::System.Guid> selector;
					global::System.Collections.Generic.List<global::System.Guid> cross712Radios;
					switch (num2)
					{
					case 0:
					{
						num = (short)861143040;
						short num3 = num;
						goto IL_343;
					}
					case 1:
					{
						string text;
						try
						{
							num = (short)1066795008;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3DE;
								case 1:
								{
									num = (short)29588596;
									short num4 = num;
									num = (short)412974196;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3DE;
									default:
										num = (short)1375928320;
										if (num != 0)
										{
										}
										num = (short)395444227;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)593887233;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string str = enumerator.Current;
									text = text + str + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("\uddfc", a_);
									num = (short)1611988996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_4DB;
								}
								goto IL_403;
								IL_3DE:
								switch (0)
								{
								case 0:
									IL_403:
									goto IL_405;
								}
								continue;
								IL_405:
								num = (short)1370488834;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4DB:
							goto IL_274;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_4EE;
						IL_274:
						msg = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.AstroLanguageSettingResetToEnglish, text);
						num = (short)1247019019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)915996674;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)748421124;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator2.Current;
									num = (short)883621893;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_550;
									}
									continue;
								case 3:
									goto IL_61A;
								case 4:
									num = (short)1389232131;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService iastrolocalService;
									if (!iastrolocalService.IsRadioSupportWriteLPWhenUpgrade(radioBase.DeviceUuid, selectFirmwareContext.SelectedFirmware.Version))
									{
										num = (short)1383071750;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									list.Add(radioBase);
									num = (short)1111752705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_552:
								num = (short)1052049408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_550:
								goto IL_552;
							}
							IL_61A:
							goto IL_186;
						}
						finally
						{
							num = (short)810090496;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_652;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)2015166466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_68B;
								}
								IL_652:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)279773185;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_68B:;
						}
						goto IL_68E;
						IL_186:
						num = (short)1659305988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_6E0;
					case 4:
						if (list.Count > 0)
						{
							num = (short)899940362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C6;
					case 5:
					{
						if (paras.Count<object>() <= 0)
						{
							num = (short)429195282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						selectFirmwareContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext);
						global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService iastrolocalService = base.LocalService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService;
						string codeplugVersion = null;
						num = (short)1105985549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::System.Collections.Generic.List<string> list2 = list.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item)
						{
							short num5 = (short)691994624;
							short num6 = num5;
							num5 = (short)2106851329;
							if (num5 != 0)
							{
							}
							num5 = (short)38054218;
							short num7 = num5;
							num5 = (short)656910666;
							switch (num7 == num5)
							{
							}
							num5 = (short)1656029184;
							if (num5 != 0)
							{
							}
							return item.SerialNumber;
						}).ToList<string>();
						string text = string.Empty;
						global::System.Collections.Generic.List<string>.Enumerator enumerator = list2.GetEnumerator();
						num = (short)1635188737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						num = (short)1735720961;
						if (num != 0)
						{
						}
						string codeplugVersion = selectFirmwareContext.MaxCodeplugVersion;
						num = (short)1749876736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_1C6;
					case 9:
						goto IL_24B;
					case 10:
						num = (short)420216838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (global::System.Windows.Application.Current != null)
						{
							num = (short)1811480591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C6;
					case 12:
						goto IL_508;
					case 13:
					{
						if (selectFirmwareContext.SelectedCodeplug == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("볼鏾瘀戂簄理⤈朊氌笎琐怒愔㜖漘縚漜氞䠠䰢䬤", a_))
						{
							num = (short)122814471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string codeplugVersion = selectFirmwareContext.SelectedCodeplug;
						num = (short)52101139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)1717436421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						global::System.Windows.Application.Current.Dispatcher.Invoke(delegate()
						{
							short num5 = (short)1062469632;
							short num6 = num5;
							num5 = (short)477069897;
							short num7 = num5;
							num5 = (short)205161033;
							switch (num7 == num5)
							{
							}
							num5 = (short)2141454336;
							if (num5 != 0)
							{
							}
							num5 = (short)2102329345;
							if (num5 != 0)
							{
							}
							this.Interaction.ShowNotificationDialog(msg, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Warning);
						});
						num = (short)2008350728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						source = list;
						if ((selector = global::Motorola.CommonCPS.RadioManagement.Command.AstroUpgradeCommand.<>c.<>9__1_0) == null)
						{
							goto IL_68E;
						}
						goto IL_37B;
					case 17:
						if (paras != null)
						{
							num = (short)1565589518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4EE;
					case 18:
						goto IL_4EE;
					case 19:
						goto IL_343;
					case 20:
					{
						string codeplugVersion;
						global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROUpgradeFirmwareBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROUpgradeFirmwareBatchOp(selectFirmwareContext.Radios, cross712Radios, selectFirmwareContext.SelectedFirmware, codeplugVersion);
						base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
						num = (short)1694498819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						if (selectFirmwareContext.IsRefresh)
						{
							num = (short)69468180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string codeplugVersion;
						global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROFlashportBatchOp op2 = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROFlashportBatchOp(selectFirmwareContext.Radios, cross712Radios, selectFirmwareContext.SelectedFirmware, selectFirmwareContext.SelectedSystemID, codeplugVersion);
						base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op2);
						num = (short)342229001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_90;
					IL_1C6:
					num = (short)1879506960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_343:
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
					cross712Radios = new global::System.Collections.Generic.List<global::System.Guid>();
					enumerator2 = selectFirmwareContext.Radios.GetEnumerator();
					num = (short)2043609090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37B:
					cross712Radios = source.Select(selector).ToList<global::System.Guid>();
					num = (short)1126170645;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_68E:
					selector = (global::Motorola.CommonCPS.RadioManagement.Command.AstroUpgradeCommand.<>c.<>9__1_0 = delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item)
					{
						short num5 = (short)1064042496;
						short num6 = num5;
						num5 = (short)1678434988;
						short num7 = num5;
						num5 = (short)1721229996;
						switch (num7 == num5)
						{
						}
						num5 = (short)2046164993;
						if (num5 != 0)
						{
						}
						num5 = (short)1033568256;
						if (num5 != 0)
						{
						}
						return item.DeviceUuid;
					});
					goto IL_37B;
					IL_4EE:
					num = (short)371654668;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_24B:
				goto IL_777;
				IL_508:
				throw new global::System.ArgumentNullException();
				IL_6E0:
				IL_777:
				return null;
				IL_90:
				num = (short)1763246097;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}
	}
}
