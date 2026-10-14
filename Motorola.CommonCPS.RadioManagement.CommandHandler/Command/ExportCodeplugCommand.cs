using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000A1 RID: 161
	internal class ExportCodeplugCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003A9 RID: 937 RVA: 0x0003BF30 File Offset: 0x0003A130
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1135935488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						bool? isOutOfSync;
						bool flag;
						if (!(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null))
						{
							num = (short)565968901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 1:
					{
						num = (short)410648576;
						short num3 = num;
						if (list != null)
						{
							num = (short)39845891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 2:
						if (list.Count == 1)
						{
							num = (short)717488132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						goto IL_B7;
					case 4:
					{
						radioBase = list[0];
						bool? isOutOfSync = radioBase.IsOutOfSync;
						bool flag = true;
						num = (short)617676800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)1493434369;
						if (num != 0)
						{
						}
						num = (short)2098365785;
						short num4 = num;
						num = (short)2088994137;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B7;
						default:
							goto IL_119;
						}
						break;
					}
					}
					goto IL_48;
					IL_B7:
					num = (short)774111234;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_119:
				num = (short)1973944320;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.CanExportCodeplug(radioBase.RadioStatus, radioBase.HasPBA);
				IL_48:
				list = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
				num = (short)964493313;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0003C124 File Offset: 0x0003A324
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)997916672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device;
				string filePath;
				global::System.Action <>9__3;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
					switch (num2)
					{
					case 0:
						goto IL_29C;
					case 1:
					{
						if (list.Count == 0)
						{
							num = (short)313786375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						device = list[0];
						string text = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.GetFileNameForExportCodeplug(device.SerialNumber, device.TemplateName, device.ConfigurationName, device.HasPBA);
						text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ReplaceInvalidCharacters(text);
						text = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddFileSuffix(text);
						filePath = base.Interaction.ShowSaveFileDialogForExportRadio(text);
						num = (short)310378500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_272;
					case 3:
					{
						num = (short)1771268191;
						short num3 = num;
						num = (short)1713989727;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_29C;
						default:
							num = (short)308740096;
							if (num != 0)
							{
							}
							list = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d)
							{
								short num5 = (short)1313194206;
								short num6 = num5;
								num5 = (short)122405086;
								switch (num6 == num5)
								{
								}
								num5 = (short)1562968065;
								if (num5 != 0)
								{
								}
								num5 = (short)430374912;
								short num7 = num5;
								num5 = (short)707592192;
								if (num5 != 0)
								{
								}
								return d.Clone() as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
							}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
							num = (short)1393033216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						if (!string.IsNullOrEmpty(filePath))
						{
							num = (short)727777285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30F;
					case 5:
					{
						bool exportSuccess = false;
						global::System.ComponentModel.BackgroundWorker bw = new global::System.ComponentModel.BackgroundWorker();
						bw.DoWork += delegate(object sender, global::System.ComponentModel.DoWorkEventArgs e)
						{
							short num5;
							try
							{
								num5 = (short)118358016;
								int num6 = (int)num5;
								switch (num6)
								{
								default:
								{
									switch (0)
									{
									case 0:
										goto IL_46;
									}
									global::System.Collections.Generic.Dictionary<string, string> dictionary;
									global::Motorola.CommonCPS.Server.EntityModel.Radio radioBySerialNumber;
									for (;;)
									{
										IL_27:
										string fieldError;
										switch (num6)
										{
										case 0:
											if (dictionary.Count > 0)
											{
												num5 = (short)1538850821;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											goto IL_16F;
										case 1:
										{
											bool flag = this.UIValidateService.ValidateAllRadioFields(radioBySerialNumber, dictionary);
											fieldError = string.Empty;
											if (!flag)
											{
												num5 = (short)56295427;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											goto IL_16F;
										}
										case 2:
											goto IL_16F;
										case 3:
											num5 = (short)551288832;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										case 4:
											goto IL_1DC;
										case 5:
										{
											num5 = (short)2006968934;
											short num7 = num5;
											num5 = (short)864938598;
											switch ((num7 == num5) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_16F;
											default:
												num5 = (short)1554513920;
												if (num5 != 0)
												{
												}
												fieldError = dictionary.First<global::System.Collections.Generic.KeyValuePair<string, string>>().Value;
												num5 = (short)1991770114;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											break;
										}
										}
										goto IL_46;
										IL_16F:
										num5 = (short)1303379969;
										if (num5 != 0)
										{
										}
										global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.ExportCodeplug(device, filePath, radioBySerialNumber, fieldError);
										exportSuccess = true;
										num5 = (short)629276676;
										num6 = (int)((global::System.IntPtr)num5);
									}
									IL_1DC:
									break;
									IL_46:
									radioBySerialNumber = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.GetRadioBySerialNumber(device.SerialNumber, true);
									dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
									num5 = (short)1734868993;
									num6 = (int)((global::System.IntPtr)num5);
									goto IL_27;
								}
								}
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.Common.CustomException.CommonException ex4;
								global::Motorola.Common.CustomException.CommonException ex2 = ex4;
								global::Motorola.Common.CustomException.CommonException ex = ex2;
								this.Interaction.HideWaitingIndicator();
								if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND)
								{
									if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist)
									{
										if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.GenericError)
										{
											if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error)
											{
												goto IL_25A;
											}
										}
										if (!string.IsNullOrWhiteSpace(ex.Message))
										{
											global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
											{
												int a_ = 8;
												short num9 = (short)1734619801;
												short num10 = num9;
												num9 = (short)2034315929;
												switch (num10 == num9)
												{
												}
												num9 = (short)480247809;
												if (num9 != 0)
												{
												}
												num9 = (short)212860928;
												short num11 = num9;
												num9 = (short)1848770560;
												if (num9 != 0)
												{
												}
												this.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportCodeplug_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("\ud9f8", a_) + ex.Message, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
											}), global::System.Array.Empty<object>());
											goto IL_31D;
										}
										IL_25A:
										global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
										{
											int a_ = 12;
											short num9 = (short)627346358;
											short num10 = num9;
											num9 = (short)1044679606;
											switch (num10 == num9)
											{
											}
											num9 = (short)1526464512;
											if (num9 != 0)
											{
											}
											num9 = (short)189399040;
											short num11 = num9;
											num9 = (short)1868955649;
											if (num9 != 0)
											{
											}
											this.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportCodeplug_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("\uddfc", a_) + global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null), global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
										}), global::System.Array.Empty<object>());
										goto IL_31D;
									}
								}
								global::System.Windows.Threading.Dispatcher dispatcher = global::System.Windows.Application.Current.Dispatcher;
								global::System.Action method;
								if ((method = <>9__3) == null)
								{
									method = (<>9__3 = delegate()
									{
										short num9 = (short)1340137496;
										short num10 = num9;
										num9 = (short)763879448;
										switch (num10 == num9)
										{
										}
										num9 = (short)1376649217;
										if (num9 != 0)
										{
										}
										num9 = (short)1639120896;
										short num11 = num9;
										num9 = (short)128516096;
										if (num9 != 0)
										{
										}
										this.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Device_Deleted_By_Other_User_Refresh_Try_Again, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
									});
								}
								dispatcher.BeginInvoke(method, global::System.Array.Empty<object>());
								IL_31D:;
							}
							catch (global::System.Exception ex3)
							{
								global::System.Exception exception2 = ex3;
								global::System.Exception exception = exception2;
								global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
								{
									int a_ = 13;
									short num9 = (short)364000109;
									short num10 = num9;
									num9 = (short)2089300845;
									switch (num10 == num9)
									{
									}
									num9 = (short)1541079040;
									if (num9 != 0)
									{
									}
									num9 = (short)1439105024;
									short num11 = num9;
									num9 = (short)1372913665;
									if (num9 != 0)
									{
									}
									this.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportCodeplug_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("\udefd", a_) + exception.Message, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
								}), global::System.Array.Empty<object>());
							}
							num5 = (short)55181312;
							short num8 = num5;
						};
						bw.RunWorkerCompleted += delegate(object sender, global::System.ComponentModel.RunWorkerCompletedEventArgs e)
						{
							switch (0)
							{
							case 0:
								goto IL_1C;
							}
							int num5;
							short num6;
							for (;;)
							{
								IL_0A:
								switch (num5)
								{
								case 0:
								{
									if (!exportSuccess)
									{
										goto IL_13B;
									}
									num6 = (short)1589379072;
									short num7 = num6;
									num6 = (short)726859665;
									short num8 = num6;
									num6 = (short)862519185;
									switch ((num8 == num6) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num6 = (short)7667713;
										if (num6 != 0)
										{
										}
										num6 = (short)1567686656;
										if (num6 != 0)
										{
										}
										num6 = (short)1229127682;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									}
									break;
								}
								case 1:
									goto IL_139;
								case 2:
									this.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Message_Export_successful, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ExportRadio);
									num6 = (short)260636673;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								}
								goto IL_1C;
							}
							IL_139:
							IL_13B:
							bw.Dispose();
							return;
							IL_1C:
							this.Interaction.HideWaitingIndicator();
							num6 = (short)2099118080;
							num5 = (int)((global::System.IntPtr)num6);
							goto IL_0A;
						};
						bw.RunWorkerAsync();
						base.Interaction.ShowWaitingIndicator();
						num = (short)1744896002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)947060737;
						if (num != 0)
						{
						}
						num = (short)1691942913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1D5;
					}
					goto IL_4E;
					IL_29C:
					if (list == null)
					{
						break;
					}
					num = (short)1070137344;
					short num4 = num;
					num = (short)595591174;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D5:
				goto IL_30D;
				IL_272:
				goto IL_30F;
				IL_30D:
				return null;
				IL_30F:
				return false;
				IL_4E:
				num = (short)1936719875;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
