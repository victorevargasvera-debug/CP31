using System;
using System.Runtime.InteropServices;
using System.Security;
using System.ServiceModel;
using System.Windows;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.RMDiscoveryServiceInterface;
using Motorola.Security.SamlTokenComponent;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000097 RID: 151
	internal class ChangeRMUserPasswordCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000386 RID: 902 RVA: 0x00038230 File Offset: 0x00036430
		public static global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement GetChannel(string currentUserType, string authType, string discoveryHost, int discoveryPort)
		{
			int a_ = 10;
			short num = (short)1910636544;
			short num2 = num;
			num = (short)965049814;
			short num3 = num;
			num = (short)1149664726;
			switch (num3 == num)
			{
			}
			num = (short)2052456449;
			if (num != 0)
			{
			}
			num = (short)462290944;
			if (num != 0)
			{
			}
			string svcType = global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꧺ냼믾栀瀂昄栆缈渊缌瘎䈐瘒朔愖簘椚", a_);
			global::Motorola.CommonCPS.RadioManagement.Command.ChangeRMUserPasswordCommand.channel = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.CreateClientChannelEx2<global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement>(currentUserType, authType, discoveryHost, discoveryPort, svcType, "", null, null, false, 5, 2000, "", "");
			return global::Motorola.CommonCPS.RadioManagement.Command.ChangeRMUserPasswordCommand.channel.CreateChannel();
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00038320 File Offset: 0x00036520
		public override bool CanExecute(params object[] paras)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_5A;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword rmuserPassword;
			for (;;)
			{
				IL_13:
				num = (short)541392896;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (rmuserPassword.SecureOldPassword.Length != 0)
					{
						num = (short)1876885506;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17A;
				case 1:
					goto IL_191;
				case 2:
					num = (short)1818820611;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (rmuserPassword.SecureNewPassword.Length != 0)
					{
						num = (short)1796341765;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17A;
				case 4:
					goto IL_16A;
				case 5:
				{
					num = (short)1810309846;
					short num4 = num;
					num = (short)601301718;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)971964416;
						if (num != 0)
						{
						}
						num = (short)857669633;
						if (num != 0)
						{
						}
						num = (short)1596456964;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_5A;
				IL_17A:
				num = (short)1040842753;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_16A:
			bool flag = rmuserPassword.SecureConfirmedPassword.Length != 0;
			goto IL_194;
			IL_191:
			flag = false;
			IL_194:
			bool flag2 = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingAuthenticationMethodType.Equals(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꧻ跽旿瀁䨃朅攇漉", a_)) && global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected;
			return flag && flag2;
			IL_5A:
			rmuserPassword = this.a(paras);
			num = (short)1189543936;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x000384F4 File Offset: 0x000366F4
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 14;
			bool flag;
			for (;;)
			{
				IL_09:
				short num = (short)1628504064;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)2100101120;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword rmuserPassword;
					for (;;)
					{
						IL_59:
						switch (num2)
						{
						case 0:
						{
							if (this.a(rmuserPassword.SecureNewPassword, rmuserPassword.SecureConfirmedPassword))
							{
								global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement irmserviceManagement = null;
								string userName = rmuserPassword.UserName;
								num = (short)2134179842;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2059796481;
							if (num != 0)
							{
							}
							num = (short)35592976;
							short num4 = num;
							num = (short)871766800;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)1350828032;
								if (num != 0)
								{
								}
								num = (short)395182081;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_132;
						case 2:
							try
							{
								string userName;
								global::Motorola.CommonCPS.RadioManagement.Command.ChangeRMUserPasswordCommand.channel = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.CreateClientChannelEx2<global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement>(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("蓾㤀㜂㄄㔆䠈上䠌㘎㰐倒⌔☖⤘㘚⤜夞搠愢ࠤἦᰨᰪᨬȮ̰ਲȴ6稸ȺԼ簾着݂D畆㑈", a_), global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingAuthenticationMethodType, global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("귾䰀䜂氄理樈搊笌樎挐樒䘔爖欘洚砜洞", a_), global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("뻾刀圂圄䠆", a_), userName, rmuserPassword.SecureOldPassword, false, 5, 2000, "", "");
								global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement irmserviceManagement = global::Motorola.CommonCPS.RadioManagement.Command.ChangeRMUserPasswordCommand.channel.CreateChannel();
								goto IL_22A;
							}
							catch
							{
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ChangeRMUserPassword_ConnectionToDiscoveryFailed);
							}
							goto IL_2F8;
						case 3:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_158;
								}
								string oldPassword;
								string newPassword;
								for (;;)
								{
									IL_141:
									switch (num2)
									{
									case 0:
									{
										global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement irmserviceManagement;
										if (irmserviceManagement.ChangePassword(oldPassword, newPassword) == 0)
										{
											num = (short)1576009729;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1F3;
									}
									case 1:
										global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword = rmuserPassword.SecureNewPassword.Copy();
										global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingSecurePassword = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword.Copy();
										global::System.Windows.MessageBox.Show(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Password_Changed_Succeed);
										flag = true;
										num = (short)2106523651;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_216;
									case 3:
										num = (short)374669314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_158;
								}
								IL_1F3:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ChangeRMUserPassword_ChangePasswordFailed);
								IL_216:
								goto IL_2F8;
								IL_158:
								oldPassword = this.a(rmuserPassword.SecureOldPassword);
								newPassword = this.a(rmuserPassword.SecureNewPassword);
								num = (short)1289879552;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_141;
							}
							catch (global::Motorola.Common.CustomException.CommonException)
							{
								throw;
							}
							catch (global::System.Exception)
							{
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ChangeRMUserPassword_ChangePasswordFailed);
							}
							goto IL_22A;
						}
						break;
						IL_22A:
						num = (short)95617027;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_70:
					flag = false;
					rmuserPassword = this.a(paras);
					num = (short)2082734080;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_59;
				}
				}
			}
			IL_132:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ChangeRMUserPassword_PasswordNotSame);
			IL_2F8:
			return flag;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00038828 File Offset: 0x00036A28
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword a(object[] A_0)
		{
			int a_ = 0;
			short num = (short)1743912960;
			short num2 = num;
			num = (short)1115226077;
			short num3 = num;
			num = (short)1630207965;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)678756353;
				if (num != 0)
				{
				}
				num = (short)2118451200;
				if (num != 0)
				{
				}
				result = null;
				try
				{
					num = (short)852623360;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_E6;
							}
							continue;
						case 1:
							goto IL_174;
						case 2:
							num = (short)854982659;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (A_0[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)
							{
								num = (short)759037957;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15D;
						case 4:
							goto IL_15D;
						case 5:
							result = (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).RMUserPassword;
							num = (short)564068356;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E6:
						if (A_0.Length == 1)
						{
							num = (short)1273495554;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_15D:
						num = (short)1300234241;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_174:;
				}
				catch (global::System.Exception)
				{
					throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("룰鿲駴鋶黸髺釼\udffe怀焂戄爆搈渊挌笎ㄐ朒气朖簘㔚㴜娞夠匢䀤䐦崨ᄪബ種砰縲娴匶尸场丼ᄾɀⱂ⭄⥆ⱈ⡊㥌♎㹐㵒答", a_));
				}
				break;
			}
			return result;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000389D4 File Offset: 0x00036BD4
		private bool a(global::System.Security.SecureString A_0, global::System.Security.SecureString A_1)
		{
			int a_ = 1;
			short num = (short)1567096832;
			switch (num)
			{
			default:
			{
				num = (short)1881997313;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)538454689;
					short num3 = num;
					num = (short)949430945;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_158;
					default:
					{
						num = (short)1551499264;
						short num4 = num;
						num = (short)1666121728;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_F8;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_DD;
							}
							continue;
						case 2:
							goto IL_158;
						case 3:
							try
							{
								num = (short)1493762049;
								if (num != 0)
								{
								}
								global::System.IntPtr intPtr = global::System.Runtime.InteropServices.Marshal.SecureStringToBSTR(A_0);
								global::System.IntPtr intPtr2 = global::System.Runtime.InteropServices.Marshal.SecureStringToBSTR(A_1);
								string text = global::System.Runtime.InteropServices.Marshal.PtrToStringBSTR(intPtr);
								string value = global::System.Runtime.InteropServices.Marshal.PtrToStringBSTR(intPtr2);
								return text.Equals(value);
							}
							finally
							{
								num = (short)984023040;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IntPtr intPtr;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1FE;
										}
										continue;
									case 1:
									{
										global::System.IntPtr intPtr2;
										global::System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(intPtr2);
										num = (short)2031681541;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										global::System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(intPtr);
										num = (short)1881669635;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_25E;
									case 4:
									{
										global::System.IntPtr intPtr2;
										if (intPtr2 != global::System.IntPtr.Zero)
										{
											num = (short)2061434881;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_29F;
									}
									case 5:
										goto IL_25C;
									}
									IL_1FE:
									if (intPtr != global::System.IntPtr.Zero)
									{
										num = (short)186122242;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_25E:
									num = (short)812253188;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_25C:
								IL_29F:;
							}
							goto IL_2A0;
						case 4:
							return false;
						case 5:
						{
							if (A_0.Length != A_1.Length)
							{
								num = (short)1388969988;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.IntPtr intPtr = global::System.IntPtr.Zero;
							global::System.IntPtr intPtr2 = global::System.IntPtr.Zero;
							num = (short)1909981187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							if (A_1 == null)
							{
								num = (short)173473794;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A0;
						}
						IL_DD:
						if (A_0 == null)
						{
							num = (short)574685184;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						num = (short)951189510;
						num2 = (int)((global::System.IntPtr)num);
						break;
						IL_2A0:
						num = (short)1867317253;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_F8:
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("臱엳", a_));
				IL_158:
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("臱웳", a_));
			}
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00038CF0 File Offset: 0x00036EF0
		private string a(global::System.Security.SecureString A_0)
		{
			short num = (short)786825216;
			short num2 = num;
			num = (short)2081583074;
			short num3 = num;
			num = (short)1333817314;
			string result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)652541953;
				if (num != 0)
				{
				}
				num = (short)1863122944;
				if (num != 0)
				{
				}
				global::System.IntPtr intPtr = global::System.IntPtr.Zero;
				try
				{
					intPtr = global::System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(A_0);
					result = global::System.Runtime.InteropServices.Marshal.PtrToStringUni(intPtr);
				}
				finally
				{
					global::System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x040000A3 RID: 163
		public static global::System.ServiceModel.ChannelFactory<global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement> channel;
	}
}
