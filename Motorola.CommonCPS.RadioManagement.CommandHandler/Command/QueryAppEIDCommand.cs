using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000080 RID: 128
	internal class QueryAppEIDCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000340 RID: 832 RVA: 0x00032A4C File Offset: 0x00030C4C
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1542717442;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext registerApplicationLicenseContext;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A2;
				case 1:
					return false;
				case 2:
				{
					num = (short)541022338;
					short num3 = num;
					num = (short)1027627138;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)1598291968;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					}
					break;
				}
				case 3:
					if (registerApplicationLicenseContext == null)
					{
						num = (short)818348033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1291845636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!string.IsNullOrEmpty(registerApplicationLicenseContext.EIDString))
					{
						num = (short)750583813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					goto IL_106;
				}
				IL_86:
				if (paras.Length == 0)
				{
					num = (short)1982332928;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					registerApplicationLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext);
					num = (short)198836227;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_A2:
			num = (short)1738866689;
			if (num != 0)
			{
			}
			num = (short)2137325568;
			short num4 = num;
			return false;
			IL_106:
			return !string.IsNullOrEmpty(registerApplicationLicenseContext.EIDString.Trim());
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00032BE4 File Offset: 0x00030DE4
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 5;
			short num = (short)1795489792;
			switch (num)
			{
			default:
			{
				num = (short)2035810313;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext registerApplicationLicenseContext;
					string eidstring;
					string text;
					switch (num2)
					{
					case 0:
						goto IL_BA;
					case 1:
						if (registerApplicationLicenseContext.EIDHistory.Contains(registerApplicationLicenseContext.EIDString))
						{
							num = (short)1808990220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1720778763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("귵駷ퟹ蛻뿽ⷿ堁㐃⬅ㄇ圉看㘍洏㼑伓眕㔗怙崛㌝稟ሡणἥ甧儩ᠫ匭ᴯ椱唳ᬵ䈷笹ᄻ搽瀿潁絃ᭅ㍇繉ㅋ捍୏㍑祓ⱕᥗ睙ٛ湝䵟孡㥣ᵥ屧ᝩ䅫㕭ᅯ影๳㝵啷⁹䱻卽륿\udf81ﾃ랅몇", a_)).IsMatch(eidstring))
						{
							num = (short)744685571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BF;
					case 3:
						num = (short)931528711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_4B3;
					case 5:
						goto IL_1ED;
					case 6:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)898367505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CC;
					case 7:
					{
						if (eidstring.Length > 36)
						{
							num = (short)1203765266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.QueryAppEIDInfo(eidstring, out text).GetEnumerator();
						num = (short)1463156749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)1212022785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_9D;
						}
						continue;
					case 10:
						if (registerApplicationLicenseContext == null)
						{
							num = (short)303431685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1905983502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (!string.IsNullOrEmpty(registerApplicationLicenseContext.ExceptionMessage))
						{
							num = (short)90963987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_570;
					case 12:
						goto IL_4FF;
					case 13:
						try
						{
							num = (short)1976434694;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo eidinfo;
								switch (num2)
								{
								case 0:
									num = (short)426311682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2096758784;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									eidinfo = enumerator.Current;
									num = (short)1576337412;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_481;
								case 3:
									eidinfo.IsSingleRegister = true;
									num = (short)1116536840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (eidinfo.ProductName.IndexOf(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꋵ꫷룹돻뷽僿儁嬃吅娇娉", a_), global::System.StringComparison.Ordinal) <= 0)
									{
										num = (short)733151241;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsAppLicense_RadioManagement(eidinfo.ProductName))
									{
										num = (short)287309827;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3A9;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_348;
									}
									continue;
								case 8:
									goto IL_3A9;
								case 9:
									num = (short)644939781;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_348;
								IL_3A9:
								registerApplicationLicenseContext.EIDInfos.Add(eidinfo);
								num = (short)722993159;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_42D:
								num = (short)1779171329;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_348:
								goto IL_42D;
							}
							IL_481:
							goto IL_236;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_494;
						IL_236:
						registerApplicationLicenseContext.EIDHistory.Add(eidstring);
						num = (short)445513734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (!string.IsNullOrEmpty(registerApplicationLicenseContext.EIDString))
						{
							num = (short)1666383887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52D;
					case 15:
						registerApplicationLicenseContext.EIDString = registerApplicationLicenseContext.EIDString.Trim();
						num = (short)432865288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_570;
					case 17:
						goto IL_494;
					case 18:
						goto IL_231;
					case 19:
					{
						registerApplicationLicenseContext.ExceptionMessage = string.Empty;
						num = (short)839057408;
						short num3 = num;
						num = (short)1787494416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_9D:
					if (paras.Length == 0)
					{
						num = (short)528547840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1495937604;
					short num4 = num;
					num = (short)1817850436;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_538;
					default:
						num = (short)1276706816;
						if (num != 0)
						{
						}
						registerApplicationLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext);
						num = (short)982384650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_494:
					registerApplicationLicenseContext.ExceptionMessage = text;
					num = (short)523567108;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_570:
					eidstring = registerApplicationLicenseContext.EIDString;
					num = (short)592183298;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BA:
				return null;
				IL_BF:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Err_Invalid_EID);
				IL_1ED:
				num = (short)865992705;
				if (num != 0)
				{
				}
				return null;
				IL_231:
				goto IL_BF;
				IL_4B3:
				goto IL_5CC;
				IL_4FF:
				goto IL_538;
				IL_52D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Err_Invalid_EID);
				IL_538:
				return null;
				IL_5CC:
				return null;
			}
			}
		}
	}
}
