using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using CommonUtility;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using RFResourceRepository;
using SharedUtility;
using SharedUtility.Arguments;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000048 RID: 72
	public class ASTROUIValidationService : global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationUIServiceBase, global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService, global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0002E950 File Offset: 0x0002CB50
		protected ASTROUIValidationService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer serviceContainer) : base(serviceContainer)
		{
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.f = this;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0002E978 File Offset: 0x0002CB78
		public static global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService GetInstance(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer serviceContainer)
		{
			short num = (short)156845657;
			short num2 = num;
			num = (short)601114201;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1898250241;
				if (num != 0)
				{
				}
				num = (short)2054553600;
				if (num != 0)
				{
				}
				if (global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.f != null)
				{
					return global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.f;
				}
				break;
			}
			num = (short)1097924608;
			short num3 = num;
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService(serviceContainer);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0002EA34 File Offset: 0x0002CC34
		public override bool ValidateSerialNumber(string serialNumber, out string error)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_48:
					if (string.IsNullOrEmpty(serialNumber))
					{
						num2 = (short)2134900741;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)362414083;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_13F;
				case 2:
					goto IL_13F;
				case 3:
					if (!this.a(serialNumber))
					{
						num2 = (short)855179268;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13F;
				case 4:
				{
					num2 = (short)1219493888;
					short num3 = num2;
					num2 = (short)669188097;
					if (num2 != 0)
					{
					}
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_SerialNumberLength;
					result = false;
					num2 = (short)1948516354;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_SerialNumber_Missing;
					result = false;
					num2 = (short)289144833;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
				IL_13F:
				num2 = (short)1486014890;
				short num4 = num2;
				num2 = (short)234998186;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_48;
				default:
					goto IL_174;
				}
			}
			IL_174:
			num2 = (short)1512308736;
			if (num2 != 0)
			{
			}
			return result;
			IL_28:
			result = true;
			error = string.Empty;
			num2 = (short)2089418752;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0002EBCC File Offset: 0x0002CDCC
		public bool ValidatePassWord(string Password, out string err)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1358495745;
					if (num2 != 0)
					{
					}
					goto IL_CD;
				case 1:
					err = global::Motorola.CommonCPS.ResourceRepository.Resources.Error_InvalidPassword;
					result = false;
					num2 = (short)1941045248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					IL_62:
					if (!this.IsPasswordValid(Password))
					{
						num2 = (short)289669121;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CD;
				}
				goto IL_1C;
				IL_CD:
				num2 = (short)2016990929;
				short num3 = num2;
				num2 = (short)1295374033;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_62;
				default:
					goto IL_102;
				}
			}
			IL_102:
			num2 = (short)369033216;
			if (num2 != 0)
			{
			}
			return result;
			IL_1C:
			num2 = (short)1872429056;
			short num4 = num2;
			err = string.Empty;
			result = true;
			num2 = (short)2084765698;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0002ECF4 File Offset: 0x0002CEF4
		public override bool ValidateRadioAlias(string alias, out string error)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					alias = alias.Trim();
					num2 = (short)1511391238;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (alias != null)
					{
						num2 = (short)658964481;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_146;
				case 3:
					error = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Error_InvalidRadioAlias, 14);
					result = false;
					num2 = (short)1265565696;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)2117337089;
					if (num2 != 0)
					{
					}
					num2 = (short)2015731135;
					short num3 = num2;
					num2 = (short)1239326143;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_146;
					default:
						num2 = (short)1830354944;
						if (num2 != 0)
						{
						}
						num2 = (short)1740767239;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if (!string.IsNullOrEmpty(alias))
					{
						num2 = (short)1653145604;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					goto IL_146;
				case 7:
				{
					num2 = (short)6815744;
					short num4 = num2;
					if (alias.Length > 14)
					{
						num2 = (short)179699715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				}
				goto IL_30;
				IL_146:
				num2 = (short)223215621;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_30:
			error = string.Empty;
			result = true;
			num2 = (short)841547778;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0002EEDC File Offset: 0x0002D0DC
		public bool ValidateOTARID(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroRadio, out string error)
		{
			short num = (short)425918464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				bool? otarEnable;
				bool? flag;
				bool flag2;
				bool result;
				int? otarID;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						flag = otarEnable;
						flag2 = true;
						num = (short)392101900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int? num3;
						int num4;
						if (!(num3.GetValueOrDefault() <= num4 & num3 != null))
						{
							num = (short)793247757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18D;
					}
					case 2:
					{
						if (otarEnable != null)
						{
							return result;
						}
						num = (short)2060189697;
						if (num != 0)
						{
						}
						num = (short)833163895;
						short num5 = num;
						num = (short)83694199;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C7;
						default:
						{
							num = (short)906428416;
							if (num != 0)
							{
							}
							num = (short)1697185792;
							short num6 = num;
							num = (short)1820327947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
					{
						if (otarID == null)
						{
							num = (short)1975582720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int? num3 = otarID;
						int num4 = 0;
						num = (short)1998979073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return result;
					case 5:
						result = false;
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.Error_InvalidOTARId;
						num = (short)1021313031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_C7;
					case 7:
						return result;
					case 8:
						if (!(flag.GetValueOrDefault() == flag2 & flag != null))
						{
							num = (short)1050279942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14B;
					case 9:
					{
						int? num3;
						int num4;
						if (num3.GetValueOrDefault() >= num4 & num3 != null)
						{
							num = (short)1168048138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 10:
						goto IL_18D;
					case 11:
						goto IL_14B;
					case 12:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)548536325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 13:
					{
						int? num3 = otarID;
						int num4 = 9999999;
						num = (short)1582825481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_66;
					IL_C7:
					num = (short)164429826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14B:
					num = (short)1034354691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18D:
					result = false;
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.Error_InvalidOTARId;
					num = (short)1225457668;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_66:
				error = string.Empty;
				result = true;
				otarID = astroRadio.OtarID;
				otarEnable = astroRadio.OtarEnable;
				flag = otarEnable;
				flag2 = true;
				num = (short)209059848;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0002F224 File Offset: 0x0002D424
		public bool ValidateDeviceVRID(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroRadio, out string error, bool decimalDisplayOnly = false)
		{
			short num = (short)2008350720;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				bool result;
				bool? flag;
				bool flag2;
				bool? dvrshardwareEnable;
				int? vrid;
				for (;;)
				{
					IL_29:
					int? num3;
					int num4;
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1277362188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						flag = dvrshardwareEnable;
						flag2 = true;
						num = (short)714670081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (num3.GetValueOrDefault() > num4 & num3 != null)
						{
							num = (short)1921712139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						return result;
					case 5:
						goto IL_16F;
					case 6:
					{
						num = (short)560258315;
						short num5 = num;
						num = (short)1211096331;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16F;
						default:
							num = (short)166854656;
							if (num != 0)
							{
							}
							goto IL_1A2;
						}
						break;
					}
					case 7:
					{
						if (vrid == null)
						{
							num = (short)1335558146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1208483840;
						short num6 = num;
						num3 = vrid;
						num4 = 0;
						num = (short)1223163914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (!(flag.GetValueOrDefault() == flag2 & flag != null))
						{
							num = (short)1808859145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A2;
					case 9:
						num = (short)315686925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1037369345;
						if (num != 0)
						{
						}
						if (!(num3.GetValueOrDefault() < num4 & num3 != null))
						{
							num = (short)1649606661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E4;
					case 11:
						goto IL_1E4;
					case 12:
						result = false;
						this.a(0, 16777215, out error, decimalDisplayOnly);
						num = (short)1201078276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (dvrshardwareEnable == null)
						{
							num = (short)1561853958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_68;
					IL_16F:
					num3 = vrid;
					num4 = 16777215;
					num = (short)248643587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A2:
					num = (short)699924487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E4:
					result = false;
					this.a(0, 16777215, out error, decimalDisplayOnly);
					num = (short)416481280;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_68:
				error = string.Empty;
				result = true;
				vrid = astroRadio.VRID;
				dvrshardwareEnable = astroRadio.DVRSHardwareEnable;
				flag = dvrshardwareEnable;
				flag2 = true;
				num = (short)747700232;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0002F578 File Offset: 0x0002D778
		private void a(int A_0, int A_1, out string A_2, bool A_3 = false)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (A_3)
					{
						num2 = (short)1637285889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1603731459;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_79;
				case 2:
					goto IL_1E2;
				case 3:
					if (global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROVRIDEntryFormat.ToUpperInvariant() == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("愨", a_))
					{
						num2 = (short)2141650946;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_206;
				}
				goto IL_29;
			}
			IL_79:
			goto IL_1E7;
			IL_1E2:
			num2 = (short)1491678492;
			short num3 = num2;
			num2 = (short)1826764060;
			string @string;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1E7:
				A_2 = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, @string, A_0, A_1, string.Empty);
				return;
			default:
			{
				num2 = (short)432930817;
				if (num2 != 0)
				{
				}
				num2 = (short)751632384;
				short num4 = num2;
				num2 = (short)1738866688;
				if (num2 != 0)
				{
				}
				A_2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, @string, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᤨ匪嘬Ἦ䰰", a_), A_0.ToString(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("焨", a_), global::System.Globalization.CultureInfo.InvariantCulture)), string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᤨ匪嘬Ἦ䰰", a_), A_1.ToString(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("焨", a_), global::System.Globalization.CultureInfo.InvariantCulture)), string.Empty);
				return;
			}
			}
			IL_206:
			A_2 = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, @string, A_0, A_1, string.Empty);
			return;
			IL_29:
			A_2 = string.Empty;
			@string = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("氨太弬䀮䌰氲挴收瀸缺戼瀾㑀㝂੄ⅆᭈ⩊⍌⡎㑐", a_));
			num2 = (short)800522240;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0002F7AC File Offset: 0x0002D9AC
		public bool ValidateUserName(string userName, int? userNameDisplayTextSize, out string error)
		{
			short num = (short)298948979;
			short num2 = num;
			num = (short)1165203827;
			switch (num2 == num)
			{
			default:
			{
				num = (short)7143424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)408879105;
			if (num != 0)
			{
			}
			num = (short)1178075136;
			if (num != 0)
			{
			}
			global::Motorola.Common.CustomException.CommonErrorCode commonConstrainErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
			error = string.Empty;
			bool flag = global::SharedUtility.SharedConstrains.ValidateUserName(userName, userNameDisplayTextSize, out commonConstrainErrorCode);
			if (!flag)
			{
				error = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.CommonConstrainErrorCodeToResource(commonConstrainErrorCode);
			}
			return flag;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0002F87C File Offset: 0x0002DA7C
		public bool ValidateUserPIN(string userPIN, out string error)
		{
			short num = (short)76975916;
			short num2 = num;
			num = (short)1488817964;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1931149312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1690107905;
			if (num != 0)
			{
			}
			num = (short)2090074112;
			if (num != 0)
			{
			}
			global::Motorola.Common.CustomException.CommonErrorCode commonConstrainErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
			error = string.Empty;
			bool flag = global::SharedUtility.SharedConstrains.ValidateUserPIN(userPIN, out commonConstrainErrorCode);
			if (!flag)
			{
				error = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.CommonConstrainErrorCodeToResource(commonConstrainErrorCode);
			}
			return flag;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0002F944 File Offset: 0x0002DB44
		public bool ValidateUserLoginUnitID(string userLoginUnitID, int? userLoginUnitIDTextSize, out string error)
		{
			short num = (short)849346561;
			if (num != 0)
			{
			}
			num = (short)760414208;
			short num2 = num;
			num = (short)834885769;
			short num3 = num;
			num = (short)1813665929;
			switch (num3 == num)
			{
			}
			num = (short)1911226368;
			if (num != 0)
			{
			}
			global::Motorola.Common.CustomException.CommonErrorCode commonConstrainErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
			error = string.Empty;
			bool flag = global::SharedUtility.SharedConstrains.ValidateUserLoginUnitID(userLoginUnitID, userLoginUnitIDTextSize, out commonConstrainErrorCode);
			if (!flag)
			{
				error = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.CommonConstrainErrorCodeToResource(commonConstrainErrorCode);
			}
			return flag;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0002FA10 File Offset: 0x0002DC10
		public bool ValidateForeignIP(string ip, out string error)
		{
			int a_ = 16;
			short num = (short)1856482599;
			short num2 = num;
			num = (short)277130535;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)1164378112;
				short num3 = num;
				break;
			}
			}
			num = (short)2013528065;
			if (num != 0)
			{
			}
			num = (short)875692032;
			if (num != 0)
			{
			}
			error = string.Empty;
			global::System.Text.RegularExpressions.Regex regex = global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.a;
			try
			{
				num = (short)1164771337;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						string[] array;
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᨩᰫ", a_)))
						{
							num = (short)1299578895;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23D;
					}
					case 1:
						num = (short)1748828160;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						result = false;
						num = (short)1746075656;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_2EB;
					case 4:
						if (regex.IsMatch(ip))
						{
							num = (short)1413611526;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CB;
					case 5:
						goto IL_23D;
					case 6:
						num = (short)134414343;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!ip.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᨩȫḭḯȱᨳص", a_)))
						{
							num = (short)1980629002;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CB;
					case 8:
						goto IL_27D;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_12F;
						}
						continue;
					case 10:
						num = (short)109117454;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)1912864789;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_422;
					case 12:
					{
						string[] array;
						if (array[0].Equals(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᨩᰫḭ", a_)))
						{
							num = (short)1523056645;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)143196171;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_25F;
					case 14:
					{
						if (ip.Trim().Equals(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᠩᤫᬭḯ1ĳ̵ᘷ࠹ऻଽ渿灁煃獅", a_)))
						{
							num = (short)1578762257;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array = ip.Split(new char[]
						{
							'.'
						});
						num = (short)1724317715;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)1053884428;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)29818884;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_2CB;
					case 18:
						if (!string.IsNullOrEmpty(error))
						{
							num = (short)1476984834;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_422;
					case 19:
					{
						string[] array;
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᨩ", a_)))
						{
							num = (short)184680449;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23D;
					}
					case 20:
						goto IL_43B;
					case 21:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IPValidateHelper(ip, out error);
						num = (short)330956818;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_12F:
					if (!string.IsNullOrEmpty(ip))
					{
						num = (short)1306132496;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_422;
					IL_23D:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NoStartZero;
					result = false;
					num = (short)1511981069;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CB:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.ForeignIP_NotProperFormat;
					result = false;
					num = (short)1460338691;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_422:
					result = true;
					num = (short)89653268;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_25F:
				IL_27D:
				IL_2EB:
				IL_43B:;
			}
			catch
			{
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.ForeignIP_NotProperFormat;
				result = false;
			}
			return result;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0002FE84 File Offset: 0x0002E084
		public bool ValidateDeviceBluetoothFriendlyName(string bluetoothFriendlyName, out string error)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!string.IsNullOrEmpty(bluetoothFriendlyName))
					{
						num2 = (short)1795096577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_116;
				case 1:
					goto IL_5B;
				case 2:
				{
					num2 = (short)1115041764;
					short num3 = num2;
					num2 = (short)524627940;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B;
					default:
						goto IL_93;
					}
					break;
				}
				case 3:
					if (bluetoothFriendlyName.Length > 14)
					{
						num2 = (short)449183745;
						if (num2 != 0)
						{
						}
						num2 = (short)164823042;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_116;
				}
				goto IL_20;
				IL_5B:
				num2 = (short)1344733187;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_93:
			num2 = (short)748093440;
			if (num2 != 0)
			{
			}
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_BluetoothName_Over14Chars;
			return false;
			IL_116:
			num2 = (short)1360330752;
			short num4 = num2;
			return true;
			IL_20:
			error = string.Empty;
			num2 = (short)743440384;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0002FFD0 File Offset: 0x0002E1D0
		public bool ValidateDeviceIPGroup(string peerIP, string subscriberIP, string bluetoothDUNPeerIP, string bluetoothDUNSubscriberIP, out string error)
		{
			switch (0)
			{
			case 0:
				goto IL_E0;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1230700594;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_41E;
				case 2:
					if (bluetoothDUNSubscriberIP != null)
					{
						num2 = (short)960626714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_195;
				case 3:
					num2 = (short)1312882692;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!string.IsNullOrEmpty(bluetoothDUNPeerIP))
					{
						num2 = (short)2128871459;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4E1;
				case 5:
					goto IL_838;
				case 6:
					if (!string.IsNullOrEmpty(subscriberIP))
					{
						num2 = (short)1289158663;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_314;
				case 7:
					num2 = (short)1940652080;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (!string.IsNullOrEmpty(peerIP))
					{
						num2 = (short)764215327;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_768;
				case 9:
					goto IL_60A;
				case 10:
					bluetoothDUNPeerIP = bluetoothDUNPeerIP.Trim();
					num2 = (short)1166606366;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (subscriberIP != null)
					{
						num2 = (short)1541210130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_56D;
				case 12:
					num2 = (short)657326122;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_195;
				case 14:
					goto IL_6A3;
				case 15:
					if (!string.IsNullOrEmpty(bluetoothDUNPeerIP))
					{
						num2 = (short)1110900761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 16:
					if (!string.IsNullOrEmpty(bluetoothDUNSubscriberIP))
					{
						num2 = (short)1243349032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6E9;
				case 17:
					if (peerIP.Equals(bluetoothDUNSubscriberIP, global::System.StringComparison.Ordinal))
					{
						num2 = (short)1584988207;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_768;
				case 18:
					IL_6DA:
					subscriberIP = subscriberIP.Trim();
					num2 = (short)491061293;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_190;
				case 20:
					if (!string.IsNullOrEmpty(bluetoothDUNSubscriberIP))
					{
						num2 = (short)281083925;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 21:
					num2 = (short)401801252;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (!string.IsNullOrEmpty(bluetoothDUNPeerIP))
					{
						num2 = (short)1175912448;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_72A;
				case 23:
					if (!string.IsNullOrEmpty(bluetoothDUNSubscriberIP))
					{
						num2 = (short)1929117723;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_768;
				case 24:
				{
					string value;
					if (!peerIP.Equals(value, global::System.StringComparison.Ordinal))
					{
						num2 = (short)208863269;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_314;
				}
				case 25:
					num2 = (short)420544532;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					bluetoothDUNSubscriberIP = bluetoothDUNSubscriberIP.Trim();
					num2 = (short)133693453;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					num2 = (short)194904081;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					num2 = (short)101449750;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					if (!string.IsNullOrEmpty(subscriberIP))
					{
						num2 = (short)344719392;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6E9;
				case 30:
					goto IL_39D;
				case 31:
					num2 = (short)1220673559;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					num2 = (short)690225168;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					goto IL_654;
				case 34:
					if (subscriberIP.Equals(bluetoothDUNSubscriberIP, global::System.StringComparison.Ordinal))
					{
						num2 = (short)773390379;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6E9;
				case 35:
					num2 = (short)2058879022;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
				{
					if (bluetoothDUNPeerIP.Equals(bluetoothDUNSubscriberIP, global::System.StringComparison.Ordinal))
					{
						num2 = (short)2043871233;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string value2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(bluetoothDUNSubscriberIP, bluetoothDUNPeerIP, out error);
					num2 = (short)97648689;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 37:
					goto IL_568;
				case 38:
				{
					num2 = (short)1867972608;
					short num3 = num2;
					if (peerIP != null)
					{
						num2 = (short)1418395687;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6A3;
				}
				case 39:
					peerIP = peerIP.Trim();
					num2 = (short)419823630;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					num2 = (short)684130338;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					if (!string.IsNullOrEmpty(subscriberIP))
					{
						num2 = (short)755302403;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4E1;
				case 42:
				{
					if (subscriberIP.Equals(peerIP, global::System.StringComparison.Ordinal))
					{
						num2 = (short)352387105;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string value = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(subscriberIP, peerIP, out error);
					num2 = (short)1585315864;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 43:
					goto IL_4DC;
				case 44:
					if (!string.IsNullOrEmpty(peerIP))
					{
						num2 = (short)882835484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_72A;
				case 45:
					goto IL_56D;
				case 46:
					if (subscriberIP.Equals(bluetoothDUNPeerIP, global::System.StringComparison.Ordinal))
					{
						num2 = (short)1727660051;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4E1;
				case 47:
					goto IL_240;
				case 48:
					if (!string.IsNullOrEmpty(peerIP))
					{
						num2 = (short)70713356;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_314;
				case 49:
				{
					string value2;
					if (!bluetoothDUNPeerIP.Equals(value2, global::System.StringComparison.Ordinal))
					{
						num2 = (short)933625861;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 50:
					if (peerIP.Equals(bluetoothDUNPeerIP, global::System.StringComparison.Ordinal))
					{
						num2 = (short)1450246153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_72A;
				case 51:
					num2 = (short)1673003009;
					if (num2 != 0)
					{
					}
					if (bluetoothDUNPeerIP != null)
					{
						num2 = (short)251068426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_39D;
				}
				goto IL_E0;
				IL_195:
				num2 = (short)107282438;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_314:
				num2 = (short)1484587037;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_39D:
				num2 = (short)262602754;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4E1:
				num2 = (short)1134428168;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_56D:
				num2 = (short)1443692595;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_6A3:
				num2 = (short)1563492363;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_768:
				num2 = (short)492012768;
				short num4 = num2;
				num2 = (short)1043891424;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_6DA;
				default:
					num2 = (short)1634861056;
					if (num2 != 0)
					{
					}
					num2 = (short)1960116268;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_6E9:
				num2 = (short)1551958057;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_72A:
				num2 = (short)581566479;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_190:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNPeerIP_NoSame_SubIP;
			return false;
			IL_240:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNSubIP_NoSame_PeerIP;
			return false;
			IL_41E:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNSubIP_NoSame_BDUNPeerIP;
			return false;
			IL_4DC:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNSubIP_NoSame_SubIP;
			return false;
			IL_568:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_SubPeerNotSameSubset;
			return false;
			IL_60A:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNPeerIP_NoSame_PeerIP;
			return false;
			IL_654:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.SubIP_NoSame_PeerIP;
			return false;
			IL_838:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_BluetoothSubPeerNotSameSubset;
			return false;
			IL_E0:
			error = string.Empty;
			num2 = (short)623312934;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00030840 File Offset: 0x0002EA40
		public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> GetRadioIPErrors(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroRadio)
		{
			int a_ = 10;
			short num = (short)813367296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_19C;
				}
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> dictionary;
				for (;;)
				{
					IL_31:
					string text;
					string text2;
					string text3;
					bool flag;
					string text4;
					string text5;
					string text6;
					string text7;
					string text8;
					bool flag2;
					string text9;
					bool flag3;
					bool flag4;
					bool flag5;
					switch (num2)
					{
					case 0:
						if (text.Equals(text2))
						{
							num = (short)1681653780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_506;
					case 1:
						text3 = global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNSubIP_NoSame_PeerIP;
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("琣䌥䴧堩攫縭甯䀱䘳夵䨷", a_)].Add(text3);
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("昣䨥崧伩堫䄭弯䘱尳爵洷琹漻䬽∿ㅁ❃㑅ⅇ⡉⥋㱍᥏ɑᅓ⑕⩗㕙⹛", a_)].Add(text3);
						num = (short)228851779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						text3 = global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNPeerIP_NoSame_SubIP;
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("眣匥䨧天伫尭夯倱儳䐵焷樹礻䰽㈿ⵁ㙃", a_)].Add(text3);
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("昣䨥崧伩堫䄭弯䘱尳爵洷琹氻嬽┿ぁൃᙅേ㡉㹋⅍≏", a_)].Add(text3);
						num = (short)343408695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1704788042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_D15;
					case 5:
						if (flag)
						{
							num = (short)1610678350;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_506;
					case 6:
						num = (short)1473839129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_D15;
					case 8:
						goto IL_5A9;
					case 9:
						goto IL_7FF;
					case 10:
						text3 = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_BluetoothSubPeerNotSameSubset;
						num = (short)1936916566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						text4 = null;
						goto IL_986;
					case 12:
						if (!string.IsNullOrEmpty(text5))
						{
							num = (short)1140916311;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5B;
					case 13:
						text3 = global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNSubIP_NoSame_BDUNPeerIP;
						num = (short)1548353621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (!string.IsNullOrEmpty(text3))
						{
							num = (short)481624108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CA;
					case 15:
						text6 = null;
						goto IL_B02;
					case 16:
						text7 = astroRadio.SubscriberIP.Trim();
						goto IL_B7F;
					case 17:
						goto IL_633;
					case 18:
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)841154628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5B;
					case 19:
						text8 = astroRadio.PeerIP.Trim();
						goto IL_F5F;
					case 20:
						text3 = global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNPeerIP_NoSame_PeerIP;
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("琣䌥䴧堩攫縭甯䀱䘳夵䨷", a_)].Add(text3);
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("昣䨥崧伩堫䄭弯䘱尳爵洷琹氻嬽┿ぁൃᙅേ㡉㹋⅍≏", a_)].Add(text3);
						num = (short)884998183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (!string.IsNullOrEmpty(text) && flag2)
						{
							num = (short)1504313424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CA;
					case 22:
						flag = false;
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("昣䨥崧伩堫䄭弯䘱尳爵洷琹氻嬽┿ぁൃᙅേ㡉㹋⅍≏", a_)].Add(text3);
						num = (short)1005322299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)7602260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						text7 = null;
						goto IL_B7F;
					case 25:
						if (text5.Equals(text9))
						{
							num = (short)1925644346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A9;
					case 26:
						num = (short)2087452741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (!string.IsNullOrEmpty(text3))
						{
							num = (short)1400504396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					case 28:
						num = (short)1216282671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)1829437474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)1417412669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_506;
					case 31:
						text3 = global::Motorola.CommonCPS.ResourceRepository.Resources.SubIP_NoSame_PeerIP;
						num = (short)1042415623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						num = (short)2094202880;
						short num3 = num;
						num = (short)530448403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						if (!this.ValidateDeviceIP(text9, out text3))
						{
							num = (short)1481375798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA1;
					case 34:
						flag3 = !string.IsNullOrEmpty(text9);
						goto IL_542;
					case 35:
						if (flag)
						{
							num = (short)1133445162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5B;
					case 36:
					{
						string value;
						if (!text.Equals(value))
						{
							num = (short)583860299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D15;
					}
					case 37:
						num = (short)2021326849;
						if (num != 0)
						{
						}
						num = (short)501153862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (!string.IsNullOrEmpty(text) && flag2)
						{
							num = (short)1237385261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_506;
					case 39:
						goto IL_506;
					case 40:
						num = (short)1677721612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (text5.Equals(text2))
						{
							num = (short)1949630466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5B;
					case 42:
						num = (short)656408594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						flag4 = false;
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("眣匥䨧天伫尭夯倱儳䐵焷樹礻䰽㈿ⵁ㙃", a_)].Add(text3);
						num = (short)802226193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("眣匥䨧天伫尭夯倱儳䐵焷樹礻䰽㈿ⵁ㙃", a_)].Add(text3);
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("琣䌥䴧堩攫縭甯䀱䘳夵䨷", a_)].Add(text3);
						num = (short)465698873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						num = (short)2081292376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						num = (short)682426421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (!string.IsNullOrEmpty(text9))
						{
							num = (short)1724383238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A9;
					case 48:
						if (text.Equals(text9))
						{
							num = (short)1620705281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B42;
					case 49:
						flag2 = false;
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("琣䌥䴧堩攫縭甯䀱䘳夵䨷", a_)].Add(text3);
						num = (short)957939721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (!this.ValidateDeviceIP(text2, out text3))
						{
							num = (short)1550647318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E52;
					case 51:
						if (astroRadio.BluetoothDUNSubscriberIP != null)
						{
							num = (short)1248133146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1678376971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (!this.ValidateDeviceIP(text, out text3))
						{
							num = (short)285737009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7FF;
					case 53:
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)1643970583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					case 54:
						flag5 = false;
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("昣䨥崧伩堫䄭弯䘱尳爵洷琹漻䬽∿ㅁ❃㑅ⅇ⡉⥋㱍᥏ɑᅓ⑕⩗㕙⹛", a_)].Add(text3);
						num = (short)831062087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						goto IL_A5B;
					case 56:
						if (astroRadio.SubscriberIP != null)
						{
							num = (short)210042962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)824639512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_2CA;
					case 58:
						text3 = global::Motorola.CommonCPS.ResourceRepository.Resources.BluetoothDUNSubIP_NoSame_SubIP;
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("眣匥䨧天伫尭夯倱儳䐵焷樹礻䰽㈿ⵁ㙃", a_)].Add(text3);
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("昣䨥崧伩堫䄭弯䘱尳爵洷琹漻䬽∿ㅁ❃㑅ⅇ⡉⥋㱍᥏ɑᅓ⑕⩗㕙⹛", a_)].Add(text3);
						num = (short)1270153224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						goto IL_E52;
					case 60:
						return dictionary;
					case 61:
						num = (short)928579584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						if (astroRadio.PeerIP != null)
						{
							num = (short)1641480224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)613810255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
					{
						string value2;
						if (!text2.Equals(value2))
						{
							num = (short)12845066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_677;
					}
					case 64:
						if (flag4)
						{
							num = (short)2139815976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5B;
					case 65:
						flag3 = false;
						goto IL_542;
					case 66:
						if (flag5)
						{
							num = (short)1177616412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A9;
					case 67:
						goto IL_B42;
					case 68:
						num = (short)1408827433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						text4 = astroRadio.BluetoothDUNSubscriberIP.Trim();
						goto IL_986;
					case 70:
						text6 = astroRadio.BluetoothDUNPeerIP.Trim();
						goto IL_B02;
					case 71:
						goto IL_AA1;
					case 72:
						if (!this.ValidateDeviceIP(text5, out text3))
						{
							num = (short)1101070379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_633;
					case 73:
					{
						if (text5.Equals(text))
						{
							num = (short)1307639839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string value = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(text5, text, out text3);
						num = (short)935067684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 74:
						if (!string.IsNullOrEmpty(text9))
						{
							num = (short)706609229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B42;
					case 75:
						text3 = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_SubPeerNotSameSubset;
						num = (short)345964548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("昣䨥崧伩堫䄭弯䘱尳爵洷琹漻䬽∿ㅁ❃㑅ⅇ⡉⥋㱍᥏ɑᅓ⑕⩗㕙⹛", a_)].Add(text3);
						dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("昣䨥崧伩堫䄭弯䘱尳爵洷琹氻嬽┿ぁൃᙅേ㡉㹋⅍≏", a_)].Add(text3);
						num = (short)1872494652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						num = (short)1652293680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						num = (short)1750925342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						text8 = null;
						goto IL_F5F;
					case 80:
						num = (short)1483472969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						if (astroRadio.BluetoothDUNPeerIP != null)
						{
							num = (short)886636581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)946929679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						num = (short)1225654288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						if (flag5)
						{
							num = (short)104529949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1591410753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
					{
						if (text2.Equals(text9))
						{
							num = (short)1310392333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string value2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(text9, text2, out text3);
						num = (short)1907687487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
						goto IL_677;
					case 86:
						goto IL_677;
					case 87:
					{
						num = (short)2008656080;
						short num4 = num;
						num = (short)357804240;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_99B;
						default:
							num = (short)348127232;
							if (num != 0)
							{
							}
							num = (short)493027349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 88:
						if (flag5)
						{
							num = (short)1840578563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B42;
					}
					goto IL_19C;
					IL_2CA:
					num = (short)46792770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_506:
					num = (short)415105107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_542:
					if (flag3 && flag)
					{
						num = (short)1858142254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_5A9:
					num = (short)80805923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_633:
					num = (short)1994391604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_677:
					num = (short)1817247771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7FF:
					num = (short)1288568865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_99B:
					num = (short)2102329416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_986:
					text9 = text4;
					text3 = "";
					flag4 = true;
					flag2 = true;
					flag5 = true;
					flag = true;
					goto IL_99B;
					IL_A5B:
					num = (short)2088566822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA1:
					num = (short)387776562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B02:
					text2 = text6;
					num = (short)741933107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B42:
					num = (short)2069626885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B7F:
					text5 = text7;
					num = (short)1824456785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D15:
					num = (short)1186463758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E52:
					num = (short)1223753792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F5F:
					text = text8;
					num = (short)1555693624;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dictionary;
				IL_19C:
				dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>();
				dictionary.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("眣匥䨧天伫尭夯倱儳䐵焷樹礻䰽㈿ⵁ㙃", a_), new global::System.Collections.Generic.List<string>());
				dictionary.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("琣䌥䴧堩攫縭甯䀱䘳夵䨷", a_), new global::System.Collections.Generic.List<string>());
				dictionary.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("昣䨥崧伩堫䄭弯䘱尳爵洷琹漻䬽∿ㅁ❃㑅ⅇ⡉⥋㱍᥏ɑᅓ⑕⩗㕙⹛", a_), new global::System.Collections.Generic.List<string>());
				dictionary.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("昣䨥崧伩堫䄭弯䘱尳爵洷琹氻嬽┿ぁൃᙅേ㡉㹋⅍≏", a_), new global::System.Collections.Generic.List<string>());
				num = (short)1641807934;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0003186C File Offset: 0x0002FA6C
		public bool IsPasswordValid(string pw)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				int num4;
				switch (num)
				{
				case 0:
					num2 = (short)1720909828;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)526373893;
					short num3 = num2;
					num2 = (short)1219482629;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_220;
					default:
						num2 = (short)100401152;
						if (num2 != 0)
						{
						}
						goto IL_29C;
					}
					break;
				}
				case 2:
					if (!string.IsNullOrEmpty(pw))
					{
						num2 = (short)1203896330;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_260;
				case 3:
					goto IL_220;
				case 4:
					if (pw.Length < 6)
					{
						num2 = (short)1253900289;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_260;
				case 5:
					if (pw.Length <= 16)
					{
						num2 = (short)23461889;
						if (num2 != 0)
						{
						}
						num2 = (short)859439104;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29C;
				case 6:
					goto IL_25B;
				case 7:
					goto IL_225;
				case 8:
					goto IL_2B5;
				case 9:
					goto IL_225;
				case 10:
					num2 = (short)1137246213;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_15C;
				case 12:
				{
					char[] array = pw.ToCharArray();
					num4 = 0;
					num2 = (short)848953351;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
				{
					char[] array;
					if (array[num4] >= '\u0080')
					{
						num2 = (short)1420427267;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15C;
				}
				case 14:
				{
					char[] array;
					if (num4 >= array.Length)
					{
						num2 = (short)375652358;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)461111309;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 15:
					if (!string.IsNullOrEmpty(pw))
					{
						num2 = (short)2102001676;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_50;
				IL_15C:
				num4++;
				num2 = (short)409010185;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_220:
				result = false;
				num2 = (short)2020933643;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_225:
				num2 = (short)1138819086;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_260:
				num2 = (short)1687420943;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_29C:
				result = false;
				num2 = (short)1811677192;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_25B:
			return result;
			IL_2B5:
			num2 = (short)289538048;
			short num5 = num2;
			return result;
			IL_50:
			result = true;
			num2 = (short)269287426;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00031B5C File Offset: 0x0002FD5C
		public bool ValidateDeviceIP(string deviceIP, out string error)
		{
			int a_ = 17;
			short num = (short)1135852476;
			short num2 = num;
			num = (short)1494399932;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)1028653056;
				short num3 = num;
				break;
			}
			}
			num = (short)1966081;
			if (num != 0)
			{
			}
			num = (short)1352531968;
			if (num != 0)
			{
			}
			error = string.Empty;
			bool flag = true;
			try
			{
				num = (short)576978947;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						string[] array;
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᬪ", a_)))
						{
							num = (short)143589393;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21F;
					}
					case 1:
						if (!string.IsNullOrEmpty(error))
						{
							num = (short)733741066;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FA;
					case 2:
						goto IL_414;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_124;
						}
						continue;
					case 4:
						num = (short)1267269647;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_196;
					case 6:
					{
						string[] array;
						if (array[0].Equals(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᬪᴬἮ", a_)))
						{
							num = (short)1919156243;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IPValidateHelper(deviceIP, out error);
						num = (short)931594245;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						deviceIP = deviceIP.Trim();
						num = (short)1142816779;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)947126278;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_23F;
					case 10:
						flag = false;
						num = (short)601358350;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("甪Ԭܮ樰̲ᠴึ搸䜺昼฾汀穂ᡄ᱆祈晊瑌቎ⵐ扒๔杖瑘扚\\⑞占Ṣᥤ啦㉨孪䁬孮Ɒ⡲䕴婶䁸♺ż䵾뒀\ud882떄ꪆ번횊ꒌ펎뾐몒꒖뎚욜꾞負骢\udba6骪肬隮薴骶肸솼躾髀ﻆ铈냊ￌ닎귐軔胜蓞퇠컢\udce4뫦门\ud9ea\ud8ec듮쇰\udef2샴꫶탸\udffa", a_)).IsMatch(deviceIP, 0))
						{
							num = (short)1044906004;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AA;
					case 12:
						if (!deviceIP.Equals(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᬪ̬Ἦἰ᬴̲ܶ", a_)))
						{
							num = (short)603652100;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AA;
					case 13:
					{
						string[] array;
						if (!array[0].Equals(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᬪᴬ", a_)))
						{
							num = (short)1055784968;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21F;
					}
					case 14:
						goto IL_3FA;
					case 15:
					{
						if (deviceIP.Equals(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᤪᠬᨮἰĲ4ȶ᜸ऺ࠼ਾ潀煂灄牆", a_)))
						{
							num = (short)2026766352;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array = deviceIP.Split(new char[]
						{
							'.'
						});
						num = (short)375324672;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_2AA;
					case 17:
						num = (short)97845261;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_2CA;
					case 19:
						goto IL_21F;
					case 20:
						num = (short)2013593612;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_124:
					if (!string.IsNullOrEmpty(deviceIP))
					{
						num = (short)1719336967;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_196:
					num = (short)852361217;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_21F:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NoStartZero;
					result = false;
					num = (short)1366622217;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AA:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NotProperFormat;
					result = false;
					num = (short)1016528914;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FA:
					result = flag;
					num = (short)465502210;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_23F:
				IL_2CA:
				IL_414:;
			}
			catch
			{
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NotProperFormat;
				result = false;
			}
			return result;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00031FA8 File Offset: 0x000301A8
		public bool ValidateDeviceSubscriberIP(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroRadio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> relatedDataProfile, out string error, bool isIntegratedValidate = true)
		{
			short num = (short)1176305664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BB;
				}
				global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode;
				bool flag;
				for (;;)
				{
					IL_28:
					string subscriberIP;
					global::System.Collections.Generic.List<string> list;
					global::System.Collections.Generic.List<string> list2;
					global::System.Collections.Generic.List<string> list3;
					bool flag2;
					global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint;
					bool flag5;
					switch (num2)
					{
					case 0:
						if (relatedDataProfile != null)
						{
							num = (short)760217605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A4;
					case 1:
						goto IL_267;
					case 2:
						goto IL_F3;
					case 3:
						if (commonErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch)
						{
							goto IL_676;
						}
						error = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.CommonConstrainErrorCodeToResource(commonErrorCode);
						num = (short)1710948382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						string peerIP;
						string bluetoothDUNPeerIP;
						string bluetoothDUNSubscriberIP;
						bool? bluetoothEnable;
						flag = global::SharedUtility.SharedConstrains.ValidateDataWideSubscriberIP(subscriberIP, peerIP, bluetoothDUNPeerIP, bluetoothDUNSubscriberIP, bluetoothEnable, list, list2, list3, out commonErrorCode);
						num = (short)2107572247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator = relatedDataProfile.GetEnumerator();
						num = (short)537985038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						flag2 = false;
						goto IL_694;
					case 7:
						goto IL_F8;
					case 8:
					{
						bool? flag3;
						bool? directLocationRegistration = flag3;
						bool flag4 = true;
						num = (short)602865689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (!flag)
						{
							num = (short)1268776984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 10:
					{
						num = (short)1656356865;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceOperation deviceOperation = this._serviceContainer.DeviceOperation;
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint arge = apx_ArgumentOfSharedConstraint;
						bool? locationEnable2;
						bool? locationEnable = locationEnable2;
						bool? p25LocationReporting2;
						bool? p25LocationReporting = p25LocationReporting2;
						int? arsMode = null;
						bool? directLocationRegistration = null;
						flag = deviceOperation.ValidateIPConflictWithLocalServerIPAddress(arge, locationEnable, p25LocationReporting, arsMode, directLocationRegistration, null, out commonErrorCode);
						num = (short)1442840583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (flag)
						{
							num = (short)1452146709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_780;
					case 12:
						if (flag)
						{
							num = (short)181600266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
					case 13:
					{
						byte[] flashBytes = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroEncodeFlashCode(astroRadio.AstroPurchasedFlashCode);
						bool? flag3 = new bool?(this.ValidateDVRSMSUACTEnable(flashBytes));
						num = (short)335872019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						try
						{
							num = (short)870383616;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_38D;
									}
									continue;
								case 1:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1054081026;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile = enumerator.Current;
									list.Add(apxdataProfile.PeerIP);
									list2.Add(apxdataProfile.AirInterfaceAddress);
									list3.Add(apxdataProfile.AutomaticRegistrationServerAddress);
									num = (short)760676355;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1190723588;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_42E;
								}
								IL_38F:
								num = (short)2143748097;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_38D:
								goto IL_38F;
							}
							IL_42E:
							goto IL_2A4;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_441;
					case 15:
					{
						num = (short)802488566;
						short num3 = num;
						num = (short)1466106102;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_676;
						default:
							num = (short)1512505344;
							if (num != 0)
							{
							}
							num = (short)1696137247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
					{
						string peerIP;
						flag2 = !string.IsNullOrEmpty(peerIP);
						goto IL_694;
					}
					case 17:
					{
						if (astroRadio == null)
						{
							num = (short)1658847234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						error = string.Empty;
						flag = true;
						string bluetoothDUNPeerIP = astroRadio.BluetoothDUNPeerIP;
						string bluetoothDUNSubscriberIP = astroRadio.BluetoothDUNSubscriberIP;
						subscriberIP = astroRadio.SubscriberIP;
						string peerIP = astroRadio.PeerIP;
						bool? bluetoothEnable = astroRadio.BluetoothEnable;
						bool? locationEnable2 = astroRadio.LocationEnable;
						bool? p25LocationReporting2 = astroRadio.P25LocationReporting;
						string bluetoothPANNetworkBaseAddress = astroRadio.BluetoothPANNetworkBaseAddress;
						bool? flag3 = null;
						num = (short)38535200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						flag5 = true;
						goto IL_2E3;
					case 19:
						goto IL_441;
					case 20:
						if (string.IsNullOrEmpty(subscriberIP))
						{
							num = (short)101449754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1501036550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						string bluetoothPANNetworkBaseAddress;
						flag = this._serviceContainer.DeviceOperation.ValidataIPConflictWithBluetoothPANNetworkBaseAddress(apx_ArgumentOfSharedConstraint, bluetoothPANNetworkBaseAddress, out commonErrorCode);
						num = (short)515702811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						flag = true;
						error = string.Empty;
						num = (short)1173815325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_492;
					case 24:
						num = (short)1831010307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						bool? directLocationRegistration;
						bool flag4;
						if (!(directLocationRegistration.GetValueOrDefault() == flag4 & directLocationRegistration != null))
						{
							num = (short)1484324879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)310444050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						num = (short)1349648400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_780;
					case 28:
						if (flag)
						{
							num = (short)1444806664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_267;
					case 29:
						goto IL_17F;
					case 30:
						goto IL_1A5;
					case 31:
						flag5 = false;
						goto IL_2E3;
					case 32:
						if (!string.IsNullOrEmpty(astroRadio.AstroPurchasedFlashCode))
						{
							num = (short)1409482765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_441;
					case 33:
						goto IL_6B1;
					case 34:
						if (flag)
						{
							num = (short)945750020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_492;
					}
					goto IL_BB;
					IL_F8:
					num = (short)664272896;
					short num4 = num;
					num = (short)598212619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_267:
					num = (short)1154744332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A4:
					num = (short)1974861844;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E3:
					bool isDVRSMSUOperation = flag5;
					flag = this._serviceContainer.DeviceOperation.ValidataIPConflictLink2IPs(apx_ArgumentOfSharedConstraint, isDVRSMSUOperation, astroRadio.PeerIP_Link2, astroRadio.SubscriberIP_Link2, out commonErrorCode);
					num = (short)986447873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_441:
					list = new global::System.Collections.Generic.List<string>();
					list2 = new global::System.Collections.Generic.List<string>();
					list3 = new global::System.Collections.Generic.List<string>();
					num = (short)632619008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_492:
					num = (short)669646876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_676:
					num = (short)1483276310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_694:
					if (flag2 && isIntegratedValidate)
					{
						num = (short)703070241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					apx_ArgumentOfSharedConstraint = new global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint();
					apx_ArgumentOfSharedConstraint.APXDataProfile = relatedDataProfile;
					apx_ArgumentOfSharedConstraint.DeviceSubscriberIP = subscriberIP;
					num = (short)1674772514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_780:
					num = (short)1387855881;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F3:
				throw new global::System.ArgumentNullException();
				IL_17F:
				IL_1A5:
				return flag;
				IL_6B1:
				flag = false;
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
				return flag;
				IL_BB:
				commonErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
				num = (short)1559298065;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000327A0 File Offset: 0x000309A0
		public bool ValidateDevicePeerIP(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroRadio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> relatedDataProfile, out string error, bool isIntegratedValidate = true)
		{
			short num = (short)2049572864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AE;
				}
				bool flag4;
				global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode;
				for (;;)
				{
					IL_27:
					bool? flag;
					bool? flag2;
					bool flag3;
					global::System.Collections.Generic.List<string> list;
					global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint;
					bool flag5;
					string peerIP;
					bool flag6;
					switch (num2)
					{
					case 0:
						goto IL_2BC;
					case 1:
						goto IL_69A;
					case 2:
					{
						byte[] flashBytes = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroEncodeFlashCode(astroRadio.AstroPurchasedFlashCode);
						flag = new bool?(this.ValidateDVRSMSUACTEnable(flashBytes));
						num = (short)192675840;
						short num3 = num;
						num = (short)1750728735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
						{
							num = (short)420151325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1286930443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_E8;
					case 5:
						if (!string.IsNullOrEmpty(astroRadio.AstroPurchasedFlashCode))
						{
							num = (short)1404567554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38F;
					case 6:
						try
						{
							num = (short)1679294468;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)529530881;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_5A3;
								case 2:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1844510720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile = enumerator.Current;
									list.Add(apxdataProfile.AirInterfaceAddress);
									num = (short)1002569731;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_4D1;
									}
									continue;
								}
								IL_502:
								num = (short)256336005;
								short num4 = num;
								num = (short)164847749;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1608122368;
									if (num != 0)
									{
									}
									num = (short)289079298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4D1:
								goto IL_502;
							}
							IL_5A3:
							goto IL_244;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_5B6;
					case 7:
						if (!flag4)
						{
							num = (short)1121976337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag4;
					case 8:
					{
						string bluetoothPANNetworkBaseAddress;
						flag4 = this._serviceContainer.DeviceOperation.ValidataIPConflictWithBluetoothPANNetworkBaseAddress(apx_ArgumentOfSharedConstraint, bluetoothPANNetworkBaseAddress, out commonErrorCode);
						num = (short)1518469120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (flag4)
						{
							num = (short)1686503445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69A;
					case 10:
						goto IL_23F;
					case 11:
						flag5 = true;
						goto IL_454;
					case 12:
						num = (short)72744982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						flag4 = true;
						error = string.Empty;
						num = (short)528678922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (string.IsNullOrEmpty(peerIP))
						{
							num = (short)755957772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)474284048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						if (astroRadio == null)
						{
							num = (short)1341980676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						error = string.Empty;
						flag4 = true;
						peerIP = astroRadio.PeerIP;
						string subscriberIP = astroRadio.SubscriberIP;
						string bluetoothDUNPeerIP = astroRadio.BluetoothDUNPeerIP;
						string bluetoothDUNSubscriberIP = astroRadio.BluetoothDUNSubscriberIP;
						bool? bluetoothEnable = astroRadio.BluetoothEnable;
						string bluetoothPANNetworkBaseAddress = astroRadio.BluetoothPANNetworkBaseAddress;
						flag = null;
						num = (short)1568276485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						flag6 = false;
						goto IL_297;
					case 17:
						num = (short)770834451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (flag4)
						{
							num = (short)949157911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D7;
					case 19:
						if (commonErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch)
						{
							num = (short)1886519309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						error = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.CommonConstrainErrorCodeToResource(commonErrorCode);
						num = (short)507052062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (flag4)
						{
							num = (short)427163656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC;
					case 21:
						goto IL_5B6;
					case 22:
					{
						string subscriberIP;
						flag6 = !string.IsNullOrEmpty(subscriberIP);
						goto IL_297;
					}
					case 23:
					{
						string subscriberIP;
						string bluetoothDUNPeerIP;
						string bluetoothDUNSubscriberIP;
						bool? bluetoothEnable;
						flag4 = global::SharedUtility.SharedConstrains.ValidateDataWidePeerIP(peerIP, subscriberIP, bluetoothDUNPeerIP, bluetoothDUNSubscriberIP, bluetoothEnable, list, out commonErrorCode);
						num = (short)1191772186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (relatedDataProfile != null)
						{
							num = (short)52428825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_244;
					case 25:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator = relatedDataProfile.GetEnumerator();
						num = (short)2067595270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_6D7;
					case 27:
						goto IL_2B7;
					case 28:
						flag5 = false;
						goto IL_454;
					case 29:
						num = (short)1966108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_318;
					case 31:
						goto IL_38F;
					}
					goto IL_AE;
					IL_244:
					apx_ArgumentOfSharedConstraint = new global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint();
					apx_ArgumentOfSharedConstraint.APXDataProfile = relatedDataProfile;
					apx_ArgumentOfSharedConstraint.DevicePeerIP = peerIP;
					num = (short)1940848658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_297:
					if (flag6 && isIntegratedValidate)
					{
						num = (short)1761738779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					list = new global::System.Collections.Generic.List<string>();
					num = (short)1677066264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BC:
					num = (short)1505689607;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38F:
					num = (short)1369047054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_454:
					bool isDVRSMSUOperation = flag5;
					flag4 = this._serviceContainer.DeviceOperation.ValidataIPConflictLink2IPs(apx_ArgumentOfSharedConstraint, isDVRSMSUOperation, astroRadio.PeerIP_Link2, astroRadio.SubscriberIP_Link2, out commonErrorCode);
					num = (short)891420673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B6:
					flag2 = flag;
					flag3 = true;
					num = (short)149553155;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69A:
					num = (short)2027028500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D7:
					num = (short)390070281;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E8:
				throw new global::System.ArgumentNullException();
				IL_23F:
				return flag4;
				IL_2B7:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
				flag4 = false;
				return flag4;
				IL_318:
				num = (short)1544945665;
				if (num != 0)
				{
				}
				return flag4;
				IL_AE:
				commonErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
				num = (short)831455247;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00032EDC File Offset: 0x000310DC
		public bool ValidateDeviceBluetoothDUNSubscriberIP(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroRadio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> relatedDataProfile, out string error, bool isIntegratedValidate = true)
		{
			short num = (short)1706164224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_83;
				}
				bool flag;
				string bluetoothPANNetworkBaseAddress;
				global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode;
				bool? locationEnable;
				bool? p25LocationReporting;
				string bluetoothDUNSubscriberIP;
				string bluetoothDUNPeerIP2;
				string subscriberIP2;
				string peerIP2;
				int? assignmentType;
				for (;;)
				{
					IL_28:
					global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint;
					bool flag2;
					switch (num2)
					{
					case 0:
						flag = true;
						error = string.Empty;
						num = (short)1555890186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1271201805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						flag = this._serviceContainer.DeviceOperation.ValidataIPConflictWithBluetoothPANNetworkBaseAddress(apx_ArgumentOfSharedConstraint, bluetoothPANNetworkBaseAddress, out commonErrorCode);
						num = (short)1629880331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1132134400;
						short num3 = num;
						flag = this._serviceContainer.DeviceOperation.ValidateIPConflictWithLocalServerIPAddress(apx_ArgumentOfSharedConstraint, locationEnable, p25LocationReporting, null, null, null, out commonErrorCode);
						goto IL_2FB;
					}
					case 4:
						if (string.IsNullOrEmpty(bluetoothDUNSubscriberIP))
						{
							num = (short)1307508737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)633864207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (flag)
						{
							num = (short)485228552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4;
					case 6:
						goto IL_3AF;
					case 7:
						if (!flag)
						{
							num = (short)923926547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 8:
						num = (short)1213857812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (commonErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch)
						{
							num = (short)64749568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						error = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.CommonConstrainErrorCodeToResource(commonErrorCode);
						num = (short)1220411404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_14A;
					case 11:
						goto IL_243;
					case 12:
						goto IL_1AF;
					case 13:
						flag2 = !string.IsNullOrEmpty(astroRadio.BluetoothDUNPeerIP);
						goto IL_2A8;
					case 14:
						goto IL_2C8;
					case 15:
						flag2 = false;
						goto IL_2A8;
					case 16:
						if (flag)
						{
							num = (short)2058289155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AF;
					case 17:
						goto IL_1B4;
					case 18:
					{
						num = (short)1497367695;
						short num4 = num;
						num = (short)529597583;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2FB;
						default:
							num = (short)2026176512;
							if (num != 0)
							{
							}
							if (flag)
							{
								num = (short)1598226434;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_243;
						}
						break;
					}
					case 19:
						num = (short)1415315465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						string bluetoothDUNSubscriberIP2 = bluetoothDUNSubscriberIP;
						string bluetoothDUNPeerIP = bluetoothDUNPeerIP2;
						string subscriberIP = subscriberIP2;
						string peerIP = peerIP2;
						int? num5 = assignmentType;
						flag = global::SharedUtility.SharedConstrains.ValidateDataWideBluetoothDUNSubscriberIP(bluetoothDUNSubscriberIP2, bluetoothDUNPeerIP, subscriberIP, peerIP, (num5 != null) ? new global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType?((global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType)num5.GetValueOrDefault()) : null, out commonErrorCode);
						num = (short)1160904721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_83;
					IL_1B4:
					num = (short)1113522177;
					if (num != 0)
					{
					}
					num = (short)481493008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_243:
					num = (short)815267847;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A8:
					if (flag2 && isIntegratedValidate)
					{
						num = (short)1374879758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					apx_ArgumentOfSharedConstraint = new global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint();
					apx_ArgumentOfSharedConstraint.APXDataProfile = relatedDataProfile;
					apx_ArgumentOfSharedConstraint.DeviceBluetoothDUNSubscriberIP = bluetoothDUNSubscriberIP;
					num = (short)915800069;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FB:
					num = (short)2081423366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AF:
					num = (short)2017263634;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_14A:
				IL_1AF:
				return flag;
				IL_2C8:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
				flag = false;
				return flag;
				IL_83:
				commonErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
				error = string.Empty;
				flag = true;
				bluetoothDUNSubscriberIP = astroRadio.BluetoothDUNSubscriberIP;
				bluetoothDUNPeerIP2 = astroRadio.BluetoothDUNPeerIP;
				subscriberIP2 = astroRadio.SubscriberIP;
				peerIP2 = astroRadio.PeerIP;
				assignmentType = astroRadio.AssignmentType;
				locationEnable = astroRadio.LocationEnable;
				p25LocationReporting = astroRadio.P25LocationReporting;
				bluetoothPANNetworkBaseAddress = astroRadio.BluetoothPANNetworkBaseAddress;
				num = (short)1072300036;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00033398 File Offset: 0x00031598
		public bool ValidateDeviceBluetoothDUNPeerIP(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroRadio, out string error, bool isIntegratedValidate = true)
		{
			int a_ = 4;
			short num = (short)1136197632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_80;
				}
				global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode;
				bool flag;
				string bluetoothPANNetworkBaseAddress;
				string bluetoothDUNPeerIP;
				string bluetoothDUNSubscriberIP;
				string subscriberIP;
				string peerIP;
				for (;;)
				{
					IL_31:
					global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint;
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily valueOrDefault;
					string codeplugVersion;
					global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint2;
					bool flag2;
					switch (num2)
					{
					case 0:
						goto IL_352;
					case 1:
						num = (short)1431240706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (commonErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch)
						{
							num = (short)739573765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						error = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.CommonConstrainErrorCodeToResource(commonErrorCode);
						num = (short)1080426510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
						flag = false;
						num = (short)1324482572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1702952973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1475149825;
						if (num != 0)
						{
						}
						flag = true;
						error = string.Empty;
						num = (short)2008481798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return flag;
					case 7:
						if (!flag)
						{
							num = (short)217579521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 8:
						flag = this._serviceContainer.DeviceOperation.ValidataIPConflictWithBluetoothPANNetworkBaseAddress(apx_ArgumentOfSharedConstraint, bluetoothPANNetworkBaseAddress, out commonErrorCode);
						num = (short)578224128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_2FC;
					case 10:
						goto IL_2E2;
					case 11:
					{
						num = (short)1157021476;
						short num3 = num;
						num = (short)1423097636;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2FC;
						default:
							num = (short)717029376;
							if (num != 0)
							{
							}
							flag = global::SharedUtility.SharedConstrainsAdapter.CallConstraint(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䠝䄟両䴣䈥䤧帩䤫樭儯䘱唳愵儷帹夻簽ⰿ㝁⅃㉅❇╉㡋♍ᑏݑᩓٕ㵗㽙⹛᝝た", a_), valueOrDefault, codeplugVersion, apx_ArgumentOfSharedConstraint2, out commonErrorCode);
							num = (short)708116490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						return flag;
					case 13:
						flag2 = !string.IsNullOrEmpty(astroRadio.BluetoothDUNSubscriberIP);
						goto IL_165;
					case 14:
						return flag;
					case 15:
						if (flag)
						{
							num = (short)1637941259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E2;
					case 16:
						flag2 = false;
						goto IL_165;
					case 17:
						if (string.IsNullOrEmpty(bluetoothDUNPeerIP))
						{
							num = (short)397606916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)270467088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_80;
					IL_165:
					if (flag2 && isIntegratedValidate)
					{
						num = (short)1341128707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					apx_ArgumentOfSharedConstraint2 = new global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint();
					apx_ArgumentOfSharedConstraint2.BluetoothDUNPeerIP = bluetoothDUNPeerIP;
					apx_ArgumentOfSharedConstraint2.BluetoothDUNSubscriberIP = bluetoothDUNSubscriberIP;
					apx_ArgumentOfSharedConstraint2.SerialLinkSubscriberIP = subscriberIP;
					apx_ArgumentOfSharedConstraint2.SerialLinkPeerIP = peerIP;
					valueOrDefault = astroRadio.ProductFamily.GetValueOrDefault();
					codeplugVersion = astroRadio.CodeplugVersion;
					apx_ArgumentOfSharedConstraint = new global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint();
					apx_ArgumentOfSharedConstraint.DeviceBluetoothDUNPeerIP = bluetoothDUNPeerIP;
					num = (short)2049638415;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E2:
					num = (short)244056073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FC:
					if (flag)
					{
						num = (short)1195835400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_352:
					num = (short)1182269447;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_80:
				num = (short)1891172352;
				short num4 = num;
				commonErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
				error = string.Empty;
				flag = true;
				bluetoothDUNPeerIP = astroRadio.BluetoothDUNPeerIP;
				bluetoothDUNSubscriberIP = astroRadio.BluetoothDUNSubscriberIP;
				subscriberIP = astroRadio.SubscriberIP;
				peerIP = astroRadio.PeerIP;
				bluetoothPANNetworkBaseAddress = astroRadio.BluetoothPANNetworkBaseAddress;
				num = (short)1833959441;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000337AC File Offset: 0x000319AC
		public bool IsSameSubNet(string sourceIP, string targetIP, out string error)
		{
			string value = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(sourceIP, targetIP, out error);
			if (!targetIP.Equals(value))
			{
				short num = (short)1593053659;
				short num2 = num;
				num = (short)665653723;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)986316801;
					if (num != 0)
					{
					}
					num = (short)171376640;
					short num3 = num;
					num = (short)1814429696;
					if (num != 0)
					{
					}
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_SubPeerNotSameSubset;
					return false;
				}
				}
			}
			return true;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00033878 File Offset: 0x00031A78
		public bool ValidateDataProfilePeerIP(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile, string deviceSubscriberIP, out string error)
		{
			short num = (short)238485504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				string peerIP;
				string dataWidePeerIP;
				string dataProfileType;
				string subscriberIP;
				string airInterfaceIP;
				string bluetoothDUNSubscriberIP;
				string bluetoothDUNPeerIP;
				bool? bluetoothEnable;
				global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
				global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode;
				bool flag;
				string bluetoothPANNetworkBaseAddress;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						flag = global::SharedUtility.SharedConstrains.ValidateDataProfilePeerIP(peerIP, dataWidePeerIP, dataProfileType, subscriberIP, deviceSubscriberIP, airInterfaceIP, bluetoothDUNSubscriberIP, bluetoothDUNPeerIP, bluetoothEnable, bluetoothDunPeerIpAssignmentType, out commonErrorCode);
						goto IL_366;
					case 1:
						return flag;
					case 2:
						goto IL_312;
					case 3:
						return flag;
					case 4:
					{
						num = (short)1309209594;
						short num3 = num;
						num = (short)600568826;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_366;
						default:
							num = (short)594214912;
							if (num != 0)
							{
							}
							flag = true;
							error = string.Empty;
							num = (short)1649803265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						num = (short)1347616776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!flag)
						{
							num = (short)826736645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 7:
					{
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint;
						flag = this._serviceContainer.DeviceOperation.ValidataIPConflictWithBluetoothPANNetworkBaseAddress(apx_ArgumentOfSharedConstraint, bluetoothPANNetworkBaseAddress, out commonErrorCode);
						num = (short)1840971776;
						short num4 = num;
						num = (short)4325387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (commonErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch)
						{
							num = (short)117243908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						error = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.CommonConstrainErrorCodeToResource(commonErrorCode);
						num = (short)125894659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_11F;
					case 10:
						if (flag)
						{
							num = (short)822870017;
							if (num != 0)
							{
							}
							num = (short)506396672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_312;
					case 11:
						goto IL_2B3;
					case 12:
						if (flag)
						{
							num = (short)1805320199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B3;
					case 13:
					{
						if (string.IsNullOrEmpty(peerIP))
						{
							num = (short)1476067337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint = new global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint();
						apx_ArgumentOfSharedConstraint.DataProfilePeerIP = peerIP;
						num = (short)1521090570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_67;
					IL_2B3:
					num = (short)264830982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_312:
					num = (short)1938685964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_366:
					num = (short)1088749570;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11F:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
				flag = false;
				return flag;
				IL_67:
				commonErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
				flag = true;
				error = string.Empty;
				peerIP = astroDataProfile.PeerIP;
				bool? autoGenerateIPs = astroDataProfile.AutoGenerateIPs;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = astroDataProfile.SystemType;
				bool? natEnable = astroDataProfile.NatEnable;
				global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode = astroDataProfile.PacketDataMode;
				subscriberIP = astroDataProfile.SubscriberIP;
				airInterfaceIP = astroDataProfile.AirInterfaceIP;
				bluetoothDUNSubscriberIP = astroDataProfile.BluetoothDUNSubscriberIP;
				bluetoothDUNPeerIP = astroDataProfile.BluetoothDUNPeerIP;
				bluetoothEnable = astroDataProfile.BluetoothEnable;
				bluetoothDunPeerIpAssignmentType = astroDataProfile.BluetoothDunPeerIpAssignmentType;
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary summaryEntityPublic = astroDataProfile.SummaryEntityPublic;
				dataWidePeerIP = summaryEntityPublic.DataWidePeerIP;
				dataProfileType = summaryEntityPublic.DataProfileType;
				bluetoothPANNetworkBaseAddress = astroDataProfile.BluetoothPANNetworkBaseAddress;
				num = (short)1176764429;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00033C08 File Offset: 0x00031E08
		public bool ValidateDataProfileSubscriberIP(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile, out string error)
		{
			short num = (short)718340096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				bool flag;
				string subscriberIP;
				string dataWideSubscriberIP;
				string dataProfileType;
				string peerIP;
				bool? bluetoothEnable;
				string bluetoothDUNSubscriberIP;
				string bluetoothDUNPeerIP;
				string airInterfaceIP;
				string automaticRegistrationServerAddress;
				global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
				global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode;
				bool? locationEnable;
				bool? p25LocationReporting;
				int? arsMode;
				bool? directLocationRegistration;
				string locationServerIPAddress;
				string bluetoothPANNetworkBaseAddress;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (flag)
						{
							num = (short)964689934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F;
					case 1:
						goto IL_3AA;
					case 2:
						flag = global::SharedUtility.SharedConstrains.ValidateDataProfileSubscriberIP(subscriberIP, dataWideSubscriberIP, dataProfileType, peerIP, bluetoothEnable, bluetoothDUNSubscriberIP, bluetoothDUNPeerIP, airInterfaceIP, automaticRegistrationServerAddress, bluetoothDunPeerIpAssignmentType, out commonErrorCode);
						num = (short)21626881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_15A;
					case 4:
					{
						num = (short)2108096512;
						short num3 = num;
						goto IL_27F;
					}
					case 5:
					{
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint;
						flag = this._serviceContainer.DeviceOperation.ValidateIPConflictWithLocalServerIPAddress(apx_ArgumentOfSharedConstraint, locationEnable, p25LocationReporting, arsMode, directLocationRegistration, locationServerIPAddress, out commonErrorCode);
						num = (short)1977942027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return flag;
					case 7:
						flag = true;
						error = string.Empty;
						num = (short)228917254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (commonErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch)
						{
							num = (short)1167785991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						error = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.CommonConstrainErrorCodeToResource(commonErrorCode);
						num = (short)806682633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return flag;
					case 10:
						if (flag)
						{
							num = (short)1069481989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C3;
					case 11:
						goto IL_1C3;
					case 12:
						if (!flag)
						{
							num = (short)1989410820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 13:
						if (flag)
						{
							num = (short)1232535554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AA;
					case 14:
					{
						num = (short)293339137;
						if (num != 0)
						{
						}
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint;
						flag = this._serviceContainer.DeviceOperation.ValidataIPConflictWithBluetoothPANNetworkBaseAddress(apx_ArgumentOfSharedConstraint, bluetoothPANNetworkBaseAddress, out commonErrorCode);
						num = (short)1278869519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_15F;
					case 16:
					{
						if (string.IsNullOrEmpty(subscriberIP))
						{
							num = (short)1077018627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint = new global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint();
						apx_ArgumentOfSharedConstraint.DataProfileSubscriberIP = subscriberIP;
						num = (short)1013121037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_72;
					IL_15F:
					num = (short)362807308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C3:
					num = (short)1181089792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27F:
					num = (short)2047737864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AA:
					num = (short)445555254;
					short num4 = num;
					num = (short)657170998;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_27F;
					default:
						num = (short)1170276352;
						if (num != 0)
						{
						}
						num = (short)1654587402;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_15A:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
				flag = false;
				return flag;
				IL_72:
				flag = true;
				error = string.Empty;
				commonErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
				subscriberIP = astroDataProfile.SubscriberIP;
				peerIP = astroDataProfile.PeerIP;
				bool? autoGenerateIPs = astroDataProfile.AutoGenerateIPs;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = astroDataProfile.SystemType;
				bool? natEnable = astroDataProfile.NatEnable;
				global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode = astroDataProfile.PacketDataMode;
				airInterfaceIP = astroDataProfile.AirInterfaceIP;
				automaticRegistrationServerAddress = astroDataProfile.AutomaticRegistrationServerAddress;
				bluetoothDUNSubscriberIP = astroDataProfile.BluetoothDUNSubscriberIP;
				bluetoothDUNPeerIP = astroDataProfile.BluetoothDUNPeerIP;
				bluetoothEnable = astroDataProfile.BluetoothEnable;
				bluetoothDunPeerIpAssignmentType = astroDataProfile.BluetoothDunPeerIpAssignmentType;
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary summaryEntityPublic = astroDataProfile.SummaryEntityPublic;
				dataWideSubscriberIP = summaryEntityPublic.DataWideSubscriberIP;
				dataProfileType = summaryEntityPublic.DataProfileType;
				locationEnable = astroDataProfile.LocationEnable;
				p25LocationReporting = astroDataProfile.P25LocationReporting;
				arsMode = astroDataProfile.ArsMode;
				directLocationRegistration = astroDataProfile.DirectLocationRegistration;
				locationServerIPAddress = astroDataProfile.LocationServerIPAddress;
				bluetoothPANNetworkBaseAddress = astroDataProfile.BluetoothPANNetworkBaseAddress;
				num = (short)1627455504;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00034048 File Offset: 0x00032248
		public bool ValidateDataProfileBluetoothDUNPeerIP(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile, out string error)
		{
			short num = (short)1176567808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				string bluetoothDUNPeerIP;
				string dataWideBTDUNPeerIP;
				string dataProfileType;
				string subscriberIP;
				string peerIP;
				string bluetoothDUNSubscriberIP;
				string airInterfaceIP;
				global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode;
				bool flag;
				string bluetoothPANNetworkBaseAddress;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						flag = global::SharedUtility.SharedConstrains.ValidateDataProfileBluetoothDUNPeerIP(bluetoothDUNPeerIP, dataWideBTDUNPeerIP, dataProfileType, subscriberIP, peerIP, bluetoothDUNSubscriberIP, airInterfaceIP, out commonErrorCode);
						goto IL_35E;
					case 1:
						return flag;
					case 2:
						goto IL_311;
					case 3:
						return flag;
					case 4:
					{
						num = (short)1778196343;
						short num3 = num;
						num = (short)118038391;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_35E;
						default:
							num = (short)1501102081;
							if (num != 0)
							{
							}
							num = (short)1655177216;
							if (num != 0)
							{
							}
							flag = true;
							error = string.Empty;
							num = (short)1655308289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						num = (short)217579528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!flag)
						{
							num = (short)47251461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 7:
					{
						num = (short)988741632;
						short num4 = num;
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint;
						flag = this._serviceContainer.DeviceOperation.ValidataIPConflictWithBluetoothPANNetworkBaseAddress(apx_ArgumentOfSharedConstraint, bluetoothPANNetworkBaseAddress, out commonErrorCode);
						num = (short)1925513227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (commonErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch)
						{
							num = (short)175505412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						error = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.CommonConstrainErrorCodeToResource(commonErrorCode);
						num = (short)2068185091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_123;
					case 10:
						if (flag)
						{
							num = (short)497680384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311;
					case 11:
						goto IL_2B1;
					case 12:
						if (flag)
						{
							num = (short)1828913159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B1;
					case 13:
					{
						if (string.IsNullOrEmpty(bluetoothDUNPeerIP))
						{
							num = (short)733478921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint = new global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint();
						apx_ArgumentOfSharedConstraint.BluetoothDUNPeerIP = bluetoothDUNPeerIP;
						num = (short)1036582922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_66;
					IL_2B1:
					num = (short)74579974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_311:
					num = (short)1294139404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35E:
					num = (short)105906178;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_123:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
				flag = false;
				return flag;
				IL_66:
				flag = true;
				error = string.Empty;
				commonErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
				bluetoothDUNPeerIP = astroDataProfile.BluetoothDUNPeerIP;
				bluetoothDUNSubscriberIP = astroDataProfile.BluetoothDUNSubscriberIP;
				subscriberIP = astroDataProfile.SubscriberIP;
				peerIP = astroDataProfile.PeerIP;
				bool? autoGenerateIPs = astroDataProfile.AutoGenerateIPs;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = astroDataProfile.SystemType;
				bool? natEnable = astroDataProfile.NatEnable;
				global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode = astroDataProfile.PacketDataMode;
				airInterfaceIP = astroDataProfile.AirInterfaceIP;
				string automaticRegistrationServerAddress = astroDataProfile.AutomaticRegistrationServerAddress;
				bool? bluetoothEnable = astroDataProfile.BluetoothEnable;
				global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = astroDataProfile.BluetoothDunPeerIpAssignmentType;
				bluetoothPANNetworkBaseAddress = astroDataProfile.BluetoothPANNetworkBaseAddress;
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary summaryEntityPublic = astroDataProfile.SummaryEntityPublic;
				dataWideBTDUNPeerIP = summaryEntityPublic.DataWideBTDUNPeerIP;
				dataProfileType = summaryEntityPublic.DataProfileType;
				num = (short)936050701;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000343D0 File Offset: 0x000325D0
		public bool ValidateDataProfileBluetoothDUNSubscriberIP(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile, out string error)
		{
			short num = (short)907739137;
			if (num != 0)
			{
			}
			num = (short)1071775744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_99;
				}
				bool flag;
				string bluetoothDUNSubscriberIP;
				string dataWideBTDUNSubscriberIP;
				string dataProfileType;
				string subscriberIP;
				string peerIP;
				string bluetoothDUNPeerIP;
				string airInterfaceIP;
				string automaticRegistrationServerAddress;
				global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
				global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode;
				bool? locationEnable;
				bool? p25LocationReporting;
				int? arsMode;
				bool? directLocationRegistration;
				string locationServerIPAddress;
				string bluetoothPANNetworkBaseAddress;
				for (;;)
				{
					IL_4E:
					switch (num2)
					{
					case 0:
						if (flag)
						{
							num = (short)347471886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_185;
					case 1:
						goto IL_3A7;
					case 2:
						flag = global::SharedUtility.SharedConstrains.ValidateDataProfileBluetoothDUNSubscriberIP(bluetoothDUNSubscriberIP, dataWideBTDUNSubscriberIP, dataProfileType, subscriberIP, peerIP, bluetoothDUNPeerIP, airInterfaceIP, automaticRegistrationServerAddress, bluetoothDunPeerIpAssignmentType, out commonErrorCode);
						num = (short)1189740545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_180;
					case 4:
						goto IL_29E;
					case 5:
					{
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint;
						flag = this._serviceContainer.DeviceOperation.ValidateIPConflictWithLocalServerIPAddress(apx_ArgumentOfSharedConstraint, locationEnable, p25LocationReporting, arsMode, directLocationRegistration, locationServerIPAddress, out commonErrorCode);
						num = (short)1657929739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return flag;
					case 7:
						flag = true;
						error = string.Empty;
						num = (short)76480518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (commonErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch)
						{
							num = (short)1476460551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						error = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.CommonConstrainErrorCodeToResource(commonErrorCode);
						num = (short)991166473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return flag;
					case 10:
						if (flag)
						{
							num = (short)911933445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EA;
					case 11:
						goto IL_1EA;
					case 12:
						if (!flag)
						{
							num = (short)1287192576;
							short num3 = num;
							num = (short)750780420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 13:
						if (flag)
						{
							num = (short)1074266114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A7;
					case 14:
					{
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint;
						flag = this._serviceContainer.DeviceOperation.ValidataIPConflictWithBluetoothPANNetworkBaseAddress(apx_ArgumentOfSharedConstraint, bluetoothPANNetworkBaseAddress, out commonErrorCode);
						num = (short)661061647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_185;
					case 16:
					{
						if (string.IsNullOrEmpty(bluetoothDUNSubscriberIP))
						{
							num = (short)1985216515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint = new global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint();
						apx_ArgumentOfSharedConstraint.BluetoothDUNSubscriberIP = bluetoothDUNSubscriberIP;
						num = (short)426049549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_99;
					IL_185:
					num = (short)1367474188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EA:
					num = (short)2145189888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29E:
					num = (short)131006472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A7:
					num = (short)1109898468;
					short num4 = num;
					num = (short)2108339428;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_29E;
					default:
						num = (short)1669857280;
						if (num != 0)
						{
						}
						num = (short)1683095562;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_180:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
				flag = false;
				return flag;
				IL_99:
				flag = true;
				error = string.Empty;
				commonErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
				bluetoothDUNSubscriberIP = astroDataProfile.BluetoothDUNSubscriberIP;
				bluetoothDUNPeerIP = astroDataProfile.BluetoothDUNPeerIP;
				subscriberIP = astroDataProfile.SubscriberIP;
				peerIP = astroDataProfile.PeerIP;
				bool? autoGenerateIPs = astroDataProfile.AutoGenerateIPs;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = astroDataProfile.SystemType;
				bool? natEnable = astroDataProfile.NatEnable;
				global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode = astroDataProfile.PacketDataMode;
				airInterfaceIP = astroDataProfile.AirInterfaceIP;
				automaticRegistrationServerAddress = astroDataProfile.AutomaticRegistrationServerAddress;
				bool? bluetoothEnable = astroDataProfile.BluetoothEnable;
				bluetoothDunPeerIpAssignmentType = astroDataProfile.BluetoothDunPeerIpAssignmentType;
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary summaryEntityPublic = astroDataProfile.SummaryEntityPublic;
				dataWideBTDUNSubscriberIP = summaryEntityPublic.DataWideBTDUNSubscriberIP;
				dataProfileType = summaryEntityPublic.DataProfileType;
				locationEnable = astroDataProfile.LocationEnable;
				p25LocationReporting = astroDataProfile.P25LocationReporting;
				arsMode = astroDataProfile.ArsMode;
				directLocationRegistration = astroDataProfile.DirectLocationRegistration;
				locationServerIPAddress = astroDataProfile.LocationServerIPAddress;
				bluetoothPANNetworkBaseAddress = astroDataProfile.BluetoothPANNetworkBaseAddress;
				num = (short)1278738448;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4E;
			}
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0003480C File Offset: 0x00032A0C
		public bool ValidateAirInterfaceIP(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile, string devicePeerIP, string deviceSubscriberIP, out string error)
		{
			short num = (short)1321009152;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				string bluetoothPANNetworkBaseAddress;
				global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode;
				bool flag;
				string airInterfaceIP2;
				string bluetoothDUNPeerIP2;
				string bluetoothDUNSubscriberIP;
				string subscriberIP2;
				string peerIP2;
				string automaticRegistrationServerAddress;
				int? arsMode;
				bool? bluetoothEnable;
				global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
				bool? locationEnable;
				bool? p25LocationReporting;
				bool? directLocationRegistration;
				string locationServerIPAddress;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint;
						flag = this._serviceContainer.DeviceOperation.ValidataIPConflictWithBluetoothPANNetworkBaseAddress(apx_ArgumentOfSharedConstraint, bluetoothPANNetworkBaseAddress, out commonErrorCode);
						num = (short)1109655565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return flag;
					case 2:
						num = (short)1809055747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						string airInterfaceIP = airInterfaceIP2;
						string bluetoothDUNPeerIP = bluetoothDUNPeerIP2;
						string bluetoothDunSubscriberIP = bluetoothDUNSubscriberIP;
						string subscriberIP = subscriberIP2;
						string peerIP = peerIP2;
						string autoRegServerIP = automaticRegistrationServerAddress;
						int? num3 = arsMode;
						flag = global::SharedUtility.SharedConstrains.ValidateDataProfileAirInterfaceIP(airInterfaceIP, bluetoothDUNPeerIP, bluetoothDunSubscriberIP, subscriberIP, peerIP, autoRegServerIP, devicePeerIP, deviceSubscriberIP, (num3 != null) ? new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemARSMode?((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemARSMode)num3.GetValueOrDefault()) : null, bluetoothEnable, bluetoothDunPeerIpAssignmentType, out commonErrorCode);
						num = (short)1341194246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_172;
					case 5:
						if (!flag)
						{
							num = (short)320077833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 6:
						goto IL_35C;
					case 7:
					{
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint;
						flag = this._serviceContainer.DeviceOperation.ValidateIPConflictWithLocalServerIPAddress(apx_ArgumentOfSharedConstraint, locationEnable, p25LocationReporting, arsMode, directLocationRegistration, locationServerIPAddress, out commonErrorCode);
						num = (short)1065680908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						return flag;
					case 9:
						goto IL_331;
					case 10:
						if (flag)
						{
							num = (short)850460679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F5;
					case 11:
					{
						num = (short)1014688901;
						short num4 = num;
						num = (short)1437002885;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_331;
						default:
							num = (short)683474944;
							if (num != 0)
							{
							}
							num = (short)313065473;
							if (num != 0)
							{
							}
							flag = true;
							error = string.Empty;
							num = (short)369623041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						goto IL_3F5;
					case 13:
						goto IL_2F8;
					case 14:
						if (flag)
						{
							num = (short)648216578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35C;
					case 15:
						if (commonErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch)
						{
							num = (short)924712971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						error = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.CommonConstrainErrorCodeToResource(commonErrorCode);
						num = (short)1930821640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (flag)
						{
							num = (short)931790848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F8;
					case 17:
					{
						if (string.IsNullOrEmpty(airInterfaceIP2))
						{
							num = (short)702611460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint apx_ArgumentOfSharedConstraint = new global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint();
						apx_ArgumentOfSharedConstraint.DataProfileAirInterfaceIP = airInterfaceIP2;
						num = (short)1574764558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_77;
					IL_2F8:
					num = (short)2023489541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_331:
					num = (short)483459087;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35C:
					num = (short)1475608586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F5:
					num = (short)1962606608;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_172:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
				flag = false;
				return flag;
				IL_77:
				num = (short)700645376;
				short num5 = num;
				commonErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
				flag = true;
				error = string.Empty;
				airInterfaceIP2 = astroDataProfile.AirInterfaceIP;
				bluetoothDUNSubscriberIP = astroDataProfile.BluetoothDUNSubscriberIP;
				bluetoothDUNPeerIP2 = astroDataProfile.BluetoothDUNPeerIP;
				subscriberIP2 = astroDataProfile.SubscriberIP;
				peerIP2 = astroDataProfile.PeerIP;
				bool? autoGenerateIPs = astroDataProfile.AutoGenerateIPs;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = astroDataProfile.SystemType;
				bool? natEnable = astroDataProfile.NatEnable;
				global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode = astroDataProfile.PacketDataMode;
				automaticRegistrationServerAddress = astroDataProfile.AutomaticRegistrationServerAddress;
				bluetoothEnable = astroDataProfile.BluetoothEnable;
				bluetoothDunPeerIpAssignmentType = astroDataProfile.BluetoothDunPeerIpAssignmentType;
				arsMode = astroDataProfile.ArsMode;
				locationEnable = astroDataProfile.LocationEnable;
				p25LocationReporting = astroDataProfile.P25LocationReporting;
				directLocationRegistration = astroDataProfile.DirectLocationRegistration;
				locationServerIPAddress = astroDataProfile.LocationServerIPAddress;
				bluetoothPANNetworkBaseAddress = astroDataProfile.BluetoothPANNetworkBaseAddress;
				num = (short)12517393;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00034C90 File Offset: 0x00032E90
		public bool ValidateRadioIDValue(int? systemRadioId, global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType systemType, global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType systemSubType, bool expandedMDCIDRange, string codpelugVersion, out string error)
		{
			short num = (short)1837891584;
			short num2 = num;
			num = (short)572525048;
			short num3 = num;
			num = (short)2128677368;
			switch (num3 == num)
			{
			}
			num = (short)618856448;
			if (num != 0)
			{
			}
			num = (short)1305411585;
			if (num != 0)
			{
			}
			return (this._serviceContainer.ValidationService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService).ValidateRadioIdRange(systemRadioId, systemType, systemSubType, expandedMDCIDRange, codpelugVersion, out error);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00034D58 File Offset: 0x00032F58
		public override bool ValidateAllRadioFields(global::Motorola.CommonCPS.Server.EntityModel.Radio radioBase, global::System.Collections.Generic.Dictionary<string, string> tempErrorList)
		{
			int a_ = 1;
			short num = (short)1464139776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_144;
				}
				bool result;
				for (;;)
				{
					IL_31:
					global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("业渜稞匠洢䐤䨦䰨", a_), astroradio.UserNameError);
						num = (short)1790640152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.PassWordError))
						{
							num = (short)2144010250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26D;
					}
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("业渜稞匠猢氤椦", a_), astroradio.UserPINError);
						num = (short)1390608417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						apxradio = (radioBase as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = apxradio.ToUiModel(true) as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
						global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsIntegrated(astroradio);
						this.ValidateDeviceModel(astroradio);
						num = (short)291766316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (tempErrorList.Count > 0)
						{
							num = (short)985071646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䴚伜嘞攠", a_), astroradio.VRIDError);
						num = (short)1209860127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("吚䤜帞Ġ攢䰤弦䰨伪ബ昮愰", a_), astroradio.ForeignIPError);
						num = (short)1513816107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.OtarIDError))
						{
							num = (short)1466105906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1115;
					}
					case 8:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxotarProfile = apxcodeplug.APXOtarProfiles.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.<>c.<>9.a));
						num = (short)754516000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䬚砜稞匠樢甤", a_), astroradio.PeerIPError);
						num = (short)504037423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䬚簜氞删琢䨤唦䴨", a_), astroradio.PassWordError);
						num = (short)1936982057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (radioBase != null)
						{
							num = (short)2025193475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123B;
					case 12:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.UserPINError))
						{
							num = (short)182779906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					}
					case 13:
						if (apxcodeplug.APXRadioSystems != null)
						{
							num = (short)728301616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E90;
					case 14:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.ForeignIPError))
						{
							num = (short)947126278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D8;
					}
					case 15:
					{
						num = (short)1216872448;
						short num3 = num;
						num = (short)210370568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.BluetoothFriendlyNameError))
						{
							num = (short)1523843097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EA;
					}
					case 17:
						if (apxcodeplug.APXDataProfiles != null)
						{
							num = (short)190906433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_926;
					case 18:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.BluetoothDUNSubscriberIPError))
						{
							num = (short)484114468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_131F;
					}
					case 19:
						goto IL_FE4;
					case 20:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile otarProfile;
						string empty;
						if (!this.ValidateWhenEditOTARProfilesCross(otarProfile, radioBase, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("吚検縞匠樢愤", a_), true, out empty))
						{
							num = (short)847118399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123B;
					}
					case 21:
						goto IL_123B;
					case 22:
						goto IL_131F;
					case 23:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.SubscriberIPError))
						{
							num = (short)1354629169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1057;
					}
					case 24:
						goto IL_330;
					case 25:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("多焜樞䐠圢䨤䠦崨䌪欬崮堰嘲嬴匶唸䈺猼帾ⱀ♂", a_), astroradio.BluetoothFriendlyNameError);
						num = (short)1731592247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxotarProfile;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile otarProfile = apxotarProfile.ToUiModel(apxradio);
						num = (short)1705115668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						try
						{
							num = (short)1463484419;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string value;
								switch (num2)
								{
								case 0:
									num = (short)36700164;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
									if (!this.ValidateRadioIDValue(apxradioSystem.RadioId, apxradioSystem.SystemType.Value, apxradioSystem.SystemSubType.Value, apxradioSystem.ExpandedMDCIDRange, apxcodeplug.CodeplugVersion, out value))
									{
										num = (short)690683904;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_609;
								case 3:
								{
									num = (short)11869111;
									short num4 = num;
									num = (short)730405815;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_609;
									default:
										num = (short)1043726336;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_5C3;
										}
										continue;
									}
									break;
								}
								case 4:
									if (!tempErrorList.ContainsKey(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䤚簜笞䠠䰢氤挦", a_)))
									{
										num = (short)201523202;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6FC;
								case 5:
									goto IL_676;
								case 6:
									goto IL_715;
								case 7:
									goto IL_6FC;
								case 8:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)697106439;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem = enumerator.Current;
									num = (short)1634861057;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_5C3;
								IL_609:
								tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䤚簜笞䠠䰢氤挦", a_), value);
								num = (short)1428357125;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_60B:
								num = (short)1319108616;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5C3:
								goto IL_60B;
								IL_6FC:
								num = (short)736952326;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_676:
							IL_715:
							goto IL_E90;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_728;
					case 28:
						try
						{
							num = (short)1745616913;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!tempErrorList.ContainsKey(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弚簜欞䀠猢圤䠦伨䈪䄬䨮愰嘲倴䔶瀸欺", a_)))
									{
										num = (short)1507917852;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BB6;
								case 1:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
									tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弚簜欞䀠猢圤䠦伨䈪䄬䨮瀰娲䜴縶圸伺堼䴾❀≂♄≆Hᭊ", a_), astroDataProfile.AirInterfaceIPError);
									num = (short)964821017;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)332529690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (!tempErrorList.ContainsKey(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弚簜欞䀠猢圤䠦伨䈪䄬䨮猰弲䀴制䴸吺刼䬾⥀݂၄ॆ᥈⹊⡌㵎ᡐ͒", a_)))
									{
										num = (short)683737103;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A88;
								case 4:
									num = (short)1936850950;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (!tempErrorList.ContainsKey(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弚簜欞䀠猢圤䠦伨䈪䄬䨮猰弲䀴制䴸吺刼䬾⥀݂၄ॆᩈ㹊⽌㱎㉐⅒㱔㕖㱘⥚ᑜཞ", a_)))
									{
										num = (short)755499015;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D65;
								case 6:
									goto IL_E7D;
								case 7:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
									tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弚簜欞䀠猢圤䠦伨䈪䄬䨮猰弲䀴制䴸吺刼䬾⥀݂၄ॆᩈ㹊⽌㱎㉐⅒㱔㕖㱘⥚ᑜཞ", a_), astroDataProfile.BluetoothDUNSubscriberIPError);
									num = (short)2060058634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_A88;
								case 9:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
									if (!string.IsNullOrEmpty(astroDataProfile.BluetoothDUNPeerIPError))
									{
										num = (short)412418069;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A88;
								}
								case 10:
									goto IL_D65;
								case 11:
									goto IL_BB6;
								case 12:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
									if (!string.IsNullOrEmpty(astroDataProfile.AirInterfaceIPError))
									{
										num = (short)526909460;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
									if (!string.IsNullOrEmpty(astroDataProfile.BluetoothDUNSubscriberIPError))
									{
										num = (short)585891863;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D65;
								}
								case 14:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
									if (!string.IsNullOrEmpty(astroDataProfile.PeerIPError))
									{
										num = (short)746323987;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BB6;
								}
								case 15:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
									tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弚簜欞䀠猢圤䠦伨䈪䄬䨮猰弲䀴制䴸吺刼䬾⥀݂၄ॆ᥈⹊⡌㵎ᡐ͒", a_), astroDataProfile.BluetoothDUNPeerIPError);
									num = (short)772931592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
									if (!string.IsNullOrEmpty(astroDataProfile.SubscriberIPError))
									{
										num = (short)1200750594;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_DAC;
								}
								case 17:
									switch (0)
									{
									case 0:
										goto IL_A00;
									}
									continue;
								case 18:
									goto IL_DAC;
								case 19:
									num = (short)483196928;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									num = (short)1884225563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									num = (short)1509687299;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
									tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弚簜欞䀠猢圤䠦伨䈪䄬䨮戰䘲圴䐶娸䤺吼崾⑀ㅂౄᝆ", a_), astroDataProfile.SubscriberIPError);
									num = (short)1273561106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 23:
									num = (short)716636165;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1177550852;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile = enumerator2.Current.ToUiModel(radioBase as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
									this.ValidateDataProfileModel(astroDataProfile);
									num = (short)1815543822;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 26:
									if (!tempErrorList.ContainsKey(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弚簜欞䀠猢圤䠦伨䈪䄬䨮戰䘲圴䐶娸䤺吼崾⑀ㅂౄᝆ", a_)))
									{
										num = (short)456785942;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_DAC;
								case 27:
									if (!tempErrorList.ContainsKey(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弚簜欞䀠猢圤䠦伨䈪䄬䨮瀰娲䜴縶圸伺堼䴾❀≂♄≆Hᭊ", a_)))
									{
										num = (short)188547073;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 28:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
									tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("弚簜欞䀠猢圤䠦伨䈪䄬䨮愰嘲倴䔶瀸欺", a_), astroDataProfile.PeerIPError);
									num = (short)1930756107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_A00;
								IL_A88:
								num = (short)162791437;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BB6:
								num = (short)896466960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C4D:
								num = (short)2119106584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A00:
								goto IL_C4D;
								IL_D65:
								num = (short)1494089740;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DAC:
								num = (short)457048073;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E7D:
							goto IL_926;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_E90;
					case 29:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.UserLoginUnitIDError))
						{
							num = (short)133431331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_434;
					}
					case 30:
						result = false;
						num = (short)1334837285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_10D0;
					case 32:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxotarProfile;
						if (apxotarProfile != null)
						{
							num = (short)671219738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123B;
					}
					case 33:
						goto IL_21E;
					case 34:
						goto IL_12BE;
					case 35:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("业渜稞匠漢䨤䀦䀨䔪砬䄮堰䜲簴猶", a_), astroradio.UserLoginUnitIDError);
						num = (short)1412104232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("多焜樞䐠圢䨤䠦崨䌪椬種缰怲䀴唶䨸堺似嘾⍀♂㝄ๆ᥈", a_), astroradio.BluetoothDUNSubscriberIPError);
						num = (short)1183973398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						return result;
					case 38:
						if (apxcodeplug.APXOtarProfiles != null)
						{
							num = (short)873398318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123B;
					case 39:
						goto IL_1057;
					case 40:
						goto IL_434;
					case 41:
						num = (short)1268776961;
						if (num != 0)
						{
						}
						goto IL_26D;
					case 42:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.VRIDError))
						{
							num = (short)349765637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10D0;
					}
					case 43:
						goto IL_1D8;
					case 44:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.BluetoothDUNPeerIPError))
						{
							num = (short)1792016437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE4;
					}
					case 45:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.RadioAliasError))
						{
							num = (short)1519910970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_375;
					}
					case 46:
						goto IL_728;
					case 47:
						goto IL_3B8;
					case 48:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator = apxcodeplug.APXRadioSystems.GetEnumerator();
						num = (short)1482162203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䠚栜紞删䀢圤並䬨个弬昮愰", a_), astroradio.SubscriberIPError);
						num = (short)372178983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("吚検縞匠樢愤", a_), astroradio.OtarIDError);
						num = (short)1513488448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䠚砜洞䠠䈢䤤椦尨䘪伬䨮䌰", a_), astroradio.SerialNumberError);
						num = (short)1911095330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						goto IL_375;
					case 53:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("多焜樞䐠圢䨤䠦崨䌪椬種缰挲倴制䬸爺洼", a_), astroradio.BluetoothDUNPeerIPError);
						num = (short)665387027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template)
						{
							num = (short)710475833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123B;
					case 55:
						goto IL_2EA;
					case 56:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.PeerIPError))
						{
							num = (short)1915420681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B8;
					}
					case 57:
						num = (short)2141650982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䤚簜笞䠠䰢搤䬦䀨䨪帬", a_), astroradio.RadioAliasError);
						num = (short)130416692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.UserNameError))
						{
							num = (short)1096482816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_330;
					}
					case 60:
					{
						string empty;
						if (this.ValidateOtarIdStatesInAPXOtarProfiles(apxcodeplug.APXOtarProfiles, tempErrorList, empty))
						{
							num = (short)1713111055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123B;
					}
					case 61:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!string.IsNullOrEmpty(astroradio.SerialNumberError))
						{
							num = (short)526516275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12BE;
					}
					case 62:
						if (apxcodeplug.APXOtarProfiles.Count > 0)
						{
							num = (short)2010054722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123B;
					case 63:
					{
						string empty;
						tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("吚検縞匠樢愤", a_), empty);
						num = (short)986578965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						goto IL_1115;
					case 65:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2 = apxcodeplug.APXDataProfiles.GetEnumerator();
						num = (short)106233884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 66:
					{
						string empty = string.Empty;
						num = (short)1985806396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_144;
					IL_1D8:
					num = (short)1259667463;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21E:
					apxcodeplug = (apxradio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					num = (short)1216151565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26D:
					num = (short)1999700024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EA:
					num = (short)1341718542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_330:
					num = (short)1841102860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_375:
					num = (short)395313213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B8:
					num = (short)82509869;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_434:
					num = (short)667942971;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_728:
					num = (short)781058110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_926:
					num = (short)1595408438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E90:
					num = (short)2043346961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FE4:
					num = (short)301727762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1057:
					num = (short)1623654429;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10D0:
					num = (short)670236673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1115:
					num = (short)485687338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_123B:
					num = (short)1062862852;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12BE:
					num = (short)497483799;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_131F:
					num = (short)861863952;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_144:
				result = true;
				num = (short)1848180747;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00036100 File Offset: 0x00034300
		public bool ValidateOtarIdStatesInAPXOtarProfiles(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> apxOtarProfiles, global::System.Collections.Generic.IDictionary<string, string> tempErrorList, string errorOTARProfiles)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			bool result;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_B3;
				case 1:
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("挫娭儯䀱紳爵", a_), errorOTARProfiles);
					result = false;
					num2 = (short)438763522;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_EC;
				}
				goto IL_25;
			}
			IL_EC:
			goto IL_128;
			IL_25:
			num2 = (short)1362244937;
			short num3 = num2;
			num2 = (short)1397175625;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B3:
				if (apxOtarProfiles.Any(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.<>c.<>9.b)))
				{
					num2 = (short)1954480129;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				break;
			default:
			{
				num2 = (short)846921729;
				if (num2 != 0)
				{
				}
				num2 = (short)698613760;
				if (num2 != 0)
				{
				}
				result = true;
				num2 = (short)309657600;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
			IL_128:
			num2 = (short)326696960;
			short num4 = num2;
			return result;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00036260 File Offset: 0x00034460
		public override bool ValidateRadioWithMVOForImportCSV(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest CSVRequest, global::Motorola.CommonCPS.Server.EntityModel.Radio radioBase, global::System.Collections.Generic.Dictionary<string, string> tempErrorList)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_11D;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!string.IsNullOrEmpty(astroradio.BluetoothDUNPeerIPError))
					{
						num2 = (short)927727674;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AB6;
				}
				case 1:
					goto IL_671;
				case 2:
					num2 = (short)1166606356;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1534984232;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_UserName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)1116930108;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D53;
				case 5:
					num2 = (short)1386807325;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)869072944;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("儝琟挡У急䄧利䤫䨭ု笱搳", a_), astroradio.ForeignIPError);
					num2 = (short)384565284;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䬝匟䜡嘣樥䜧䴩䔫䀭支就崳䈵焷縹", a_), astroradio.UserLoginUnitIDError);
					num2 = (short)471597100;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest a = CSVRequest as global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest;
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = (radioBase as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).ToUiModel(false) as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
					global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsIntegrated(astroradio);
					this.ValidateDeviceModel(astroradio);
					num2 = (short)508362791;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("尝䰟圡䄣別䜧䔩堫䘭琯朱稳攵䴷堹伻崽㈿⭁♃⍅㩇͉᱋", a_), astroradio.BluetoothDUNSubscriberIPError);
					num2 = (short)312410113;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 11:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest.get_RadioAlias())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)1844445190;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BC8;
				case 12:
					goto IL_957;
				case 13:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("丝䔟䜡嘣漥砧", a_), astroradio.PeerIPError);
					num2 = (short)31260693;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 14:
					if (radioBase != null)
					{
						num2 = (short)649068553;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 15:
					num2 = (short)673316914;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!string.IsNullOrEmpty(astroradio.SubscriberIPError))
					{
						num2 = (short)772538390;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_957;
				}
				case 17:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_VRID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)68485122;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C53;
				case 18:
					goto IL_D53;
				case 19:
					num2 = (short)1393950721;
					if (num2 != 0)
					{
					}
					num2 = (short)1632239647;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!string.IsNullOrEmpty(astroradio.VRIDError))
					{
						num2 = (short)212074549;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C53;
				}
				case 21:
					goto IL_190;
				case 22:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䴝唟䀡圣䔥娧䌩丫䬭䈯笱搳", a_), astroradio.SubscriberIPError);
					num2 = (short)1413611532;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 23:
					goto IL_AB6;
				case 24:
					num2 = (short)1207042073;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!string.IsNullOrEmpty(astroradio.ForeignIPError))
					{
						num2 = (short)612040711;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_896;
				}
				case 26:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest.get_SerialNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)451215375;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E36;
				case 27:
				{
					num2 = (short)1357381632;
					short num3 = num2;
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!string.IsNullOrEmpty(astroradio.BluetoothFriendlyNameError))
					{
						num2 = (short)969015350;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3F4;
				}
				case 28:
					goto IL_C53;
				case 29:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!string.IsNullOrEmpty(astroradio.PeerIPError))
					{
						num2 = (short)43712525;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_190;
				}
				case 30:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䰝䄟䘡䴣䤥椧䘩䔫伭䌯", a_), astroradio.RadioAliasError);
					num2 = (short)851312686;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 31:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!string.IsNullOrEmpty(astroradio.UserLoginUnitIDError))
					{
						num2 = (short)994377736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_480;
				}
				case 32:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothDUNSubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)1100742697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_671;
				case 33:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䴝䔟倡䴣䜥䐧搩夫䌭刯圱䘳", a_), astroradio.SerialNumberError);
					num2 = (short)622002231;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 34:
					if (tempErrorList.Count > 0)
					{
						num2 = (short)1426456640;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 35:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_PeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)483328005;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_190;
				case 36:
					goto IL_896;
				case 37:
					num2 = (short)1014890512;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 38:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("儝吟䌡嘣漥氧", a_), astroradio.OtarIDError);
					num2 = (short)2067726379;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 39:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothDUNPeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)866910269;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AB6;
				case 40:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (string.IsNullOrEmpty(astroradio.OtarIDError))
					{
						goto IL_52B;
					}
					num2 = (short)542758355;
					short num4 = num2;
					num2 = (short)1239340499;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1677656064;
						if (num2 != 0)
						{
						}
						num2 = (short)1098055718;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 41:
					num2 = (short)1219625017;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 42:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothFriendlyName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)1799553073;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3F4;
				case 43:
					goto IL_52B;
				case 44:
					goto IL_480;
				case 45:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䬝匟䜡嘣栥䤧䜩䤫", a_), astroradio.UserNameError);
					num2 = (short)392626194;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 46:
					goto IL_BC8;
				case 47:
					return result;
				case 48:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!string.IsNullOrEmpty(astroradio.RadioAliasError))
					{
						num2 = (short)550764574;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BC8;
				}
				case 49:
					num2 = (short)1387266075;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 50:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!string.IsNullOrEmpty(astroradio.SerialNumberError))
					{
						num2 = (short)995754017;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E36;
				}
				case 51:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_UserLoginUnitID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)976289811;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_480;
				case 52:
					goto IL_3F4;
				case 53:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䠝爟次怣", a_), astroradio.VRIDError);
					num2 = (short)237502492;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 54:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("尝䰟圡䄣別䜧䔩堫䘭瘯䀱崳匵嘷帹倻䜽฿⍁⥃⍅", a_), astroradio.BluetoothFriendlyNameError);
					num2 = (short)750256180;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 55:
					goto IL_E36;
				case 56:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_SubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)1689780261;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_957;
				case 57:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!string.IsNullOrEmpty(astroradio.BluetoothDUNSubscriberIPError))
					{
						num2 = (short)1689452554;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_671;
				}
				case 58:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					tempErrorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("尝䰟圡䄣別䜧䔩堫䘭琯朱稳昵崷弹主眽ဿ", a_), astroradio.BluetoothDUNPeerIPError);
					num2 = (short)1793720343;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 59:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_ForeignIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)1188691992;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_896;
				case 60:
					num2 = (short)1048051774;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 61:
					num2 = (short)215023616;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 62:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!string.IsNullOrEmpty(astroradio.UserNameError))
					{
						num2 = (short)2125332525;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D53;
				}
				case 63:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_OtarID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)857735171;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_52B;
				case 64:
					result = false;
					num2 = (short)65470511;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_11D;
				IL_190:
				num2 = (short)357761035;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3F4:
				num2 = (short)1632829499;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_480:
				num2 = (short)849805316;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_52B:
				num2 = (short)1285619729;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_671:
				num2 = (short)287768618;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_896:
				num2 = (short)55967807;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_957:
				num2 = (short)1587806259;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_AB6:
				num2 = (short)514261024;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_BC8:
				num2 = (short)894238746;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_C53:
				num2 = (short)1050148899;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_D53:
				num2 = (short)1915682850;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E36:
				num2 = (short)185008184;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_11D:
			result = true;
			num2 = (short)250478606;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00037130 File Offset: 0x00035330
		public bool ValidateAskRequiredWhenEdit(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radioFromServer, out string error)
		{
			short num = (short)2040575916;
			short num2 = num;
			num = (short)2084616108;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1904738304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1783103488;
			if (num != 0)
			{
			}
			num = (short)2035023873;
			if (num != 0)
			{
			}
			return this._serviceContainer.DeviceOperation.ValidateAstroASKRequirement(radioFromServer, out error);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000371EC File Offset: 0x000353EC
		public bool ValidatePeerIPAndRelatedIPsWhenEdit(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile, string deviceSubscriberIP, global::System.Collections.Generic.Dictionary<string, string> errorList)
		{
			int a_ = 4;
			short num = (short)368574464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1841439511;
				short num3 = num;
				num = (short)396305175;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_3D0:
					num = (short)592510981;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 1:
					goto IL_84;
				default:
				{
					num = (short)1262288896;
					short num4 = num;
					goto IL_84;
				}
				}
				bool result;
				for (;;)
				{
					IL_A3:
					string value;
					string text;
					global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_119;
					case 1:
						if (!string.IsNullOrEmpty(value))
						{
							goto IL_3D0;
						}
						goto IL_119;
					case 2:
						if (!text.Equals(astroDataProfile.SubscriberIP))
						{
							num = (short)231735306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_119;
					case 3:
					{
						string value2;
						if (!this.ValidateDataProfilePeerIP(astroDataProfile, deviceSubscriberIP, out value2))
						{
							num = (short)1080688648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("丝䔟䜡嘣漥砧", a_), "");
						text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(astroDataProfile.PeerIP, astroDataProfile.SubscriberIP, out value2);
						num = (short)654704644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)334888961;
						if (num != 0)
						{
						}
						if (text != null)
						{
							num = (short)1887698953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_119;
					case 5:
					{
						string airInterfaceIP = astroDataProfile.AirInterfaceIP;
						string automaticRegistrationServerAddress = astroDataProfile.AutomaticRegistrationServerAddress;
						string peerIP = astroDataProfile.PeerIP;
						string bluetoothDUNPeerIP = astroDataProfile.BluetoothDUNPeerIP;
						string bluetoothDUNSubscriberIP = astroDataProfile.BluetoothDUNSubscriberIP;
						text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDifferentIPValue(text, new global::System.Collections.Generic.List<string>
						{
							peerIP,
							airInterfaceIP,
							automaticRegistrationServerAddress,
							bluetoothDUNPeerIP,
							bluetoothDUNSubscriberIP
						});
						astroDataProfile.SubscriberIP = text;
						num = (short)213909511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						try
						{
							num = (short)1944715266;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_36C;
								case 1:
									result = false;
									num = (short)1158086656;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2D1;
									}
									continue;
								case 3:
									num = (short)688717830;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
									if (!string.IsNullOrEmpty(keyValuePair.Value))
									{
										num = (short)243073025;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1209139203;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
									num = (short)1636368388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_389;
								}
								IL_318:
								num = (short)93454341;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D1:
								goto IL_318;
							}
							IL_36C:
							IL_389:
							return result;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_39C;
					case 7:
						goto IL_119;
					case 8:
					{
						string value2;
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("丝䔟䜡嘣漥砧", a_), value2);
						num = (short)1478230016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1622540290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_39C;
					}
					goto IL_D6;
					IL_119:
					enumerator = errorList.GetEnumerator();
					num = (short)994836486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39C:
					astroDataProfile.SubscriberIP = text;
					this.ValidateDataProfileSubscriberIP(astroDataProfile, out value);
					num = (short)728498177;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_84:
				num = (short)784400384;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_D6;
				}
				goto IL_A3;
				IL_D6:
				result = true;
				num = (short)345702403;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_A3;
			}
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00037650 File Offset: 0x00035850
		public bool ValidateSubscriberIPAndRelatedIPsWhenEdit(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile, string deviceSubscriberIP, global::System.Collections.Generic.Dictionary<string, string> errorList)
		{
			int a_ = 11;
			short num = (short)552534016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)587616108;
				short num3 = num;
				num = (short)1079529324;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_3C9:
					num = (short)1186201605;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 1:
					goto IL_86;
				default:
				{
					num = (short)547487744;
					short num4 = num;
					goto IL_86;
				}
				}
				bool result;
				for (;;)
				{
					IL_A6:
					string empty;
					string text;
					global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_142;
					case 1:
						if (!string.IsNullOrEmpty(empty))
						{
							goto IL_3C9;
						}
						goto IL_142;
					case 2:
						if (!text.Equals(astroDataProfile.PeerIP))
						{
							num = (short)1559101450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_142;
					case 3:
					{
						num = (short)84148225;
						if (num != 0)
						{
						}
						string value;
						if (!this.ValidateDataProfileSubscriberIP(astroDataProfile, out value))
						{
							num = (short)1799618568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("瘤刦䬨堪丬崮堰儲倴䔶瀸欺", a_), "");
						text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(astroDataProfile.SubscriberIP, astroDataProfile.PeerIP, out value);
						num = (short)927137796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (text != null)
						{
							num = (short)464781321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_142;
					case 5:
					{
						string airInterfaceIP = astroDataProfile.AirInterfaceIP;
						string subscriberIP = astroDataProfile.SubscriberIP;
						string bluetoothDUNPeerIP = astroDataProfile.BluetoothDUNPeerIP;
						string bluetoothDUNSubscriberIP = astroDataProfile.BluetoothDUNSubscriberIP;
						text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDifferentIPValue(text, new global::System.Collections.Generic.List<string>
						{
							airInterfaceIP,
							subscriberIP,
							deviceSubscriberIP,
							bluetoothDUNPeerIP,
							bluetoothDUNSubscriberIP
						});
						astroDataProfile.PeerIP = text;
						num = (short)1288306695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						try
						{
							num = (short)897646594;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_35E;
								case 1:
									result = false;
									num = (short)547028992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2C5;
									}
									continue;
								case 3:
									num = (short)1310654470;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
									if (!string.IsNullOrEmpty(keyValuePair.Value))
									{
										num = (short)1914175489;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2104492035;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
									num = (short)137494532;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_37B;
								}
								IL_30C:
								num = (short)851312645;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2C5:
								goto IL_30C;
							}
							IL_35E:
							IL_37B:
							return result;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_38E;
					case 7:
						goto IL_142;
					case 8:
					{
						string value;
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("瘤刦䬨堪丬崮堰儲倴䔶瀸欺", a_), value);
						num = (short)1188167680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1994522626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_38E;
					}
					goto IL_D9;
					IL_142:
					enumerator = errorList.GetEnumerator();
					num = (short)929169414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38E:
					empty = string.Empty;
					astroDataProfile.PeerIP = text;
					this.ValidateDataProfilePeerIP(astroDataProfile, deviceSubscriberIP, out empty);
					num = (short)782827521;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_86:
				num = (short)929366016;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_D9;
				}
				goto IL_A6;
				IL_D9:
				result = true;
				num = (short)1489698819;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_A6;
			}
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00037A9C File Offset: 0x00035C9C
		public bool ValidateBluetoothDUNPeerIPAndRelatedIPsWhenEdit(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile, global::System.Collections.Generic.Dictionary<string, string> errorList)
		{
			int a_ = 9;
			short num = (short)1882521600;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				bool result;
				global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
				global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2;
				for (;;)
				{
					IL_32:
					global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_2AB;
					case 1:
					{
						string empty = string.Empty;
						string text;
						astroDataProfile.BluetoothDUNSubscriberIP = text;
						this.ValidateDataProfileBluetoothDUNSubscriberIP(astroDataProfile, out empty);
						num = (short)1100873735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_EC;
					case 3:
						goto IL_3DF;
					case 4:
						try
						{
							num = (short)1658847234;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1818034179;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
									num = (short)607780865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
									if (!string.IsNullOrEmpty(keyValuePair.Value))
									{
										num = (short)2090663942;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1DF;
									}
									continue;
								case 3:
									num = (short)172949509;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_22E;
								case 5:
									goto IL_298;
								case 6:
									result = false;
									num = (short)440532996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1E1:
								num = (short)1844510720;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DF:
								goto IL_1E1;
							}
							IL_22E:
							IL_298:
							return result;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2AB;
					case 5:
					{
						string value;
						if (!this.ValidateDataProfileBluetoothDUNPeerIP(astroDataProfile, out value))
						{
							num = (short)1084096522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("愢䤤刦䰨弪䈬䀮䔰嬲焴戶眸欺堼娾㍀ੂᕄ", a_), "");
						string text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(astroDataProfile.BluetoothDUNPeerIP, astroDataProfile.BluetoothDUNSubscriberIP, out value);
						num = (short)766050315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						string subscriberIP = astroDataProfile.SubscriberIP;
						string peerIP = astroDataProfile.PeerIP;
						string bluetoothDUNPeerIP = astroDataProfile.BluetoothDUNPeerIP;
						string airInterfaceIP = astroDataProfile.AirInterfaceIP;
						string text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDifferentIPValue(text, new global::System.Collections.Generic.List<string>
						{
							subscriberIP,
							peerIP,
							bluetoothDUNPeerIP,
							airInterfaceIP
						});
						astroDataProfile.BluetoothDUNSubscriberIP = text;
						num = (short)637404412;
						short num3 = num;
						num = (short)1765672188;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3DF;
						default:
							num = (short)1640955904;
							if (num != 0)
							{
							}
							num = (short)1128005634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
					{
						string empty;
						if (!string.IsNullOrEmpty(empty))
						{
							num = (short)1412759558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC;
					}
					case 8:
						num = (short)158924801;
						if (num != 0)
						{
						}
						if (bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType2 & bluetoothDunPeerIpAssignmentType != null)
						{
							num = (short)1351090176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC;
					case 9:
						goto IL_EC;
					case 10:
					{
						num = (short)648478720;
						short num4 = num;
						string value;
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("愢䤤刦䰨弪䈬䀮䔰嬲焴戶眸欺堼娾㍀ੂᕄ", a_), value);
						num = (short)562561033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						string text;
						if (text != null)
						{
							num = (short)1451098115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC;
					}
					case 12:
					{
						string text;
						if (!text.Equals(astroDataProfile.BluetoothDUNSubscriberIP))
						{
							num = (short)1499725825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC;
					}
					}
					goto IL_6D;
					IL_EC:
					enumerator = errorList.GetEnumerator();
					num = (short)603652100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AB:
					num = (short)547880965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DF:
					num = (short)1283522572;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_6D:
				result = true;
				bluetoothDunPeerIpAssignmentType = astroDataProfile.BluetoothDunPeerIpAssignmentType;
				bluetoothDunPeerIpAssignmentType2 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
				num = (short)1962868744;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00037F5C File Offset: 0x0003615C
		public bool ValidateBluetoothDUNSubscriberIPAndRelatedIPsWhenEdit(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile, global::System.Collections.Generic.Dictionary<string, string> errorList)
		{
			int a_ = 9;
			short num = (short)480116736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				bool result;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator;
					string value;
					switch (num2)
					{
					case 0:
						goto IL_300;
					case 1:
					{
						string empty = string.Empty;
						string text;
						astroDataProfile.BluetoothDUNPeerIP = text;
						this.ValidateDataProfileBluetoothDUNPeerIP(astroDataProfile, out empty);
						num = (short)1880162311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_D7;
					case 3:
						goto IL_3F9;
					case 4:
					{
						num = (short)630390784;
						short num3 = num;
						try
						{
							num = (short)59703298;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1088552963;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
									num = (short)230555649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
									if (!string.IsNullOrEmpty(keyValuePair.Value))
									{
										num = (short)77660166;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_234;
									}
									continue;
								case 3:
									num = (short)936312837;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_283;
								case 5:
									goto IL_2ED;
								case 6:
									result = false;
									num = (short)1138819076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_236:
								num = (short)1086980096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_234:
								goto IL_236;
							}
							IL_283:
							IL_2ED:
							return result;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_300;
					}
					case 5:
					{
						string text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(astroDataProfile.BluetoothDUNSubscriberIP, astroDataProfile.BluetoothDUNPeerIP, out value);
						num = (short)885456907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						string subscriberIP = astroDataProfile.SubscriberIP;
						string peerIP = astroDataProfile.PeerIP;
						string bluetoothDUNSubscriberIP = astroDataProfile.BluetoothDUNSubscriberIP;
						string airInterfaceIP = astroDataProfile.AirInterfaceIP;
						string text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDifferentIPValue(text, new global::System.Collections.Generic.List<string>
						{
							subscriberIP,
							peerIP,
							bluetoothDUNSubscriberIP,
							airInterfaceIP
						});
						astroDataProfile.BluetoothDUNPeerIP = text;
						num = (short)2124728557;
						short num4 = num;
						num = (short)1246152941;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3F9;
						default:
							num = (short)1150287872;
							if (num != 0)
							{
							}
							num = (short)69533698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
					{
						string empty;
						if (!string.IsNullOrEmpty(empty))
						{
							num = (short)850001926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7;
					}
					case 8:
					{
						if (!this.ValidateDataProfileBluetoothDUNSubscriberIP(astroDataProfile, out value))
						{
							num = (short)1651965952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("愢䤤刦䰨弪䈬䀮䔰嬲焴戶眸栺䠼崾㉀⁂㝄⹆⭈⹊㽌َŐ", a_), "");
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = astroDataProfile.BluetoothDunPeerIpAssignmentType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
						num = (short)262078473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2;
						if (bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType2 & bluetoothDunPeerIpAssignmentType != null)
						{
							num = (short)135593989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7;
					}
					case 10:
						goto IL_D7;
					case 11:
					{
						string text;
						if (text != null)
						{
							num = (short)669777923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7;
					}
					case 12:
					{
						string text;
						if (!text.Equals(astroDataProfile.BluetoothDUNPeerIP))
						{
							num = (short)475398145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7;
					}
					}
					goto IL_6C;
					IL_D7:
					enumerator = errorList.GetEnumerator();
					num = (short)746258436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_300:
					errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("愢䤤刦䰨弪䈬䀮䔰嬲焴戶眸栺䠼崾㉀⁂㝄⹆⭈⹊㽌َŐ", a_), value);
					num = (short)918618122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F9:
					num = (short)1572876;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_6C:
				result = true;
				num = (short)1579876353;
				if (num != 0)
				{
				}
				num = (short)1084555272;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00038418 File Offset: 0x00036618
		public bool ValidateRadioIDWhenEdit(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxRadioSystem, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cp, string modelNumber, out string error)
		{
			short num = (short)178585600;
			short num2 = num;
			num = (short)690618369;
			if (num != 0)
			{
			}
			num = (short)416961065;
			short num3 = num;
			num = (short)1235309097;
			switch (num3 == num)
			{
			}
			num = (short)698220544;
			if (num != 0)
			{
			}
			error = string.Empty;
			return this._serviceContainer.AstroSystemService.ValidateASTROIndividualId(apxRadioSystem, cp, modelNumber, out error);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000384DC File Offset: 0x000366DC
		public bool ValidateDevicePeerIPAndRelatedIPsWhenEdit(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroDevice, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> relatedDataProfile, global::System.Collections.Generic.Dictionary<string, string> errorList, bool isIntegratedValidate = true)
		{
			int a_ = 15;
			short num = (short)1903558656;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				bool result;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator;
					global::System.Collections.Generic.IList<string> list;
					string text;
					string empty;
					switch (num2)
					{
					case 0:
						goto IL_1B4;
					case 1:
						try
						{
							num = (short)1777074178;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1089929219;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
									num = (short)1378091009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
									if (!string.IsNullOrEmpty(keyValuePair.Value))
									{
										num = (short)2125201414;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3AA;
									}
									continue;
								case 3:
									num = (short)999292933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_3FA;
								case 5:
									goto IL_465;
								case 6:
									result = false;
									num = (short)910098436;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3AC:
								num = (short)756219904;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3AA:
								goto IL_3AC;
							}
							IL_3FA:
							IL_465:
							return result;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_478;
					case 2:
						goto IL_478;
					case 3:
					{
						num = (short)890671974;
						short num3 = num;
						num = (short)25531238;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_157;
						default:
							num = (short)1024524288;
							if (num != 0)
							{
							}
							num = (short)788725777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						list.Add(astroDevice.BluetoothPANNetworkBaseAddress.Trim());
						num = (short)1620180994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_6B3;
					case 6:
						if (relatedDataProfile != null)
						{
							num = (short)2087714834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FD;
					case 7:
					{
						string value;
						if (!this.ValidateDevicePeerIP(astroDevice, relatedDataProfile, out value, isIntegratedValidate))
						{
							num = (short)1346633743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("礨个䠬崮砰挲", a_), "");
						text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(astroDevice.PeerIP, astroDevice.SubscriberIP, out value);
						num = (short)1781661709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (astroDevice.LocServerIPAddress != null)
						{
							num = (short)309919749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23F;
					case 9:
						goto IL_23F;
					case 10:
						list = new global::System.Collections.Generic.List<string>();
						num = (short)1344995334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_1B4;
					case 12:
						num = (short)545456129;
						if (num != 0)
						{
						}
						goto IL_157;
					case 13:
						if (text != null)
						{
							num = (short)1843593219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4;
					case 14:
						if (!string.IsNullOrEmpty(empty))
						{
							num = (short)1220476938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4;
					case 15:
					{
						string value;
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("礨个䠬崮砰挲", a_), value);
						num = (short)766050304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (!string.IsNullOrEmpty(astroDevice.BluetoothPANNetworkBaseAddress))
						{
							num = (short)961019908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_478;
					case 17:
						if (!text.Equals(astroDevice.SubscriberIP))
						{
							num = (short)797573132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4;
					case 18:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2 = relatedDataProfile.GetEnumerator();
						num = (short)1810825235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						try
						{
							num = (short)1638465538;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
									if (apxdataProfile.LocationServerIPAddress != null)
									{
										num = (short)606666758;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_59C;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1405222916;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile = enumerator2.Current;
									list.Add(apxdataProfile.PeerIP.Trim());
									list.Add(apxdataProfile.AirInterfaceAddress.Trim());
									list.Add(apxdataProfile.AutomaticRegistrationServerAddress.Trim());
									num = (short)1245511681;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)147718149;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_6A0;
								case 6:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
									list.Add(apxdataProfile.LocationServerIPAddress.Trim());
									num = (short)1325924352;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_5C9:
								num = (short)997457923;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_59C:
								goto IL_5C9;
							}
							IL_6A0:
							goto IL_FD;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_6B3;
					}
					goto IL_87;
					IL_FD:
					string bluetoothDUNSubscriberIP = astroDevice.BluetoothDUNSubscriberIP;
					string bluetoothDUNPeerIP = astroDevice.BluetoothDUNPeerIP;
					string peerIP = astroDevice.PeerIP;
					num = (short)1766522888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_157:
					empty = string.Empty;
					astroDevice.SubscriberIP = text;
					this.ValidateDeviceSubscriberIP(astroDevice, relatedDataProfile, out empty, isIntegratedValidate);
					num = (short)941883406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B4:
					enumerator = errorList.GetEnumerator();
					num = (short)482607105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23F:
					num = (short)1449721856;
					short num4 = num;
					num = (short)1285685264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_478:
					list.Add(peerIP);
					list.Add(bluetoothDUNSubscriberIP);
					list.Add(bluetoothDUNPeerIP);
					text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDifferentIPValue(text, list);
					astroDevice.SubscriberIP = text;
					num = (short)885194763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B3:
					list.Add(astroDevice.LocServerIPAddress.Trim());
					num = (short)739246089;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_87:
				result = true;
				num = (short)1255473159;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00038C04 File Offset: 0x00036E04
		public bool ValidateDeviceSubscriberIPAndRelatedIPsWhenEdit(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroDevice, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> relatedDataProfile, global::System.Collections.Generic.Dictionary<string, string> errorList, bool isIntegratedValidate = true)
		{
			int a_ = 9;
			short num = (short)226951168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				bool result;
				for (;;)
				{
					IL_30:
					string subscriberIP;
					string bluetoothDUNSubscriberIP;
					string bluetoothDUNPeerIP;
					global::System.Collections.Generic.IList<string> list;
					string value;
					string text;
					global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
					{
						num = (short)375455744;
						short num3 = num;
						num = (short)1643905025;
						if (num != 0)
						{
						}
						subscriberIP = astroDevice.SubscriberIP;
						bluetoothDUNSubscriberIP = astroDevice.BluetoothDUNSubscriberIP;
						bluetoothDUNPeerIP = astroDevice.BluetoothDUNPeerIP;
						list = new global::System.Collections.Generic.List<string>();
						num = (short)1242628102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)265617412;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_1BC;
								case 2:
									num = (short)696778753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1019346946;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile = enumerator.Current;
									list.Add(apxdataProfile.AirInterfaceAddress.Trim());
									num = (short)460259328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_135;
									}
									continue;
								}
								IL_16A:
								num = (short)683016195;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_135:
								goto IL_16A;
							}
							IL_1BC:
							goto IL_B1;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1CF;
					case 2:
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("瀢値䔦娨䠪弬䘮匰嘲䜴縶椸", a_), value);
						num = (short)689373187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_4BE;
					case 4:
						if (text != null)
						{
							num = (short)1711341578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BE;
					case 5:
						goto IL_4BE;
					case 6:
						if (relatedDataProfile != null)
						{
							num = (short)1312227339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1;
					case 7:
					{
						string empty = string.Empty;
						astroDevice.PeerIP = text;
						this.ValidateDevicePeerIP(astroDevice, relatedDataProfile, out empty, isIntegratedValidate);
						num = (short)1710161932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (!text.Equals(astroDevice.PeerIP))
						{
							num = (short)1646919687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BE;
					case 9:
						if (!this.ValidateDeviceSubscriberIP(astroDevice, relatedDataProfile, out value, isIntegratedValidate))
						{
							num = (short)239796226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_379;
					case 10:
						goto IL_1CF;
					case 11:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator = relatedDataProfile.GetEnumerator();
						num = (short)1786970113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						string empty;
						if (!string.IsNullOrEmpty(empty))
						{
							num = (short)393150464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BE;
					}
					case 13:
						try
						{
							num = (short)1171128326;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1047024751;
									short num4 = num;
									num = (short)626021487;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_22C;
									default:
									{
										num = (short)118489088;
										if (num != 0)
										{
										}
										global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
										if (!string.IsNullOrEmpty(keyValuePair.Value))
										{
											num = (short)1477574657;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								case 1:
									result = false;
									num = (short)2045247490;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_308;
								case 3:
									goto IL_366;
								case 4:
									num = (short)102432771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)41353220;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator2.Current;
									num = (short)796131328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_22C;
								}
								goto IL_259;
								IL_22C:
								switch (0)
								{
								case 0:
									IL_259:
									goto IL_30D;
								}
								continue;
								IL_30D:
								num = (short)41484293;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_308:
							IL_366:
							return result;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_379;
					}
					goto IL_6F;
					IL_B1:
					list.Add(subscriberIP);
					list.Add(bluetoothDUNSubscriberIP);
					list.Add(bluetoothDUNPeerIP);
					text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDifferentIPValue(text, list);
					astroDevice.PeerIP = text;
					num = (short)1597636613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CF:
					num = (short)1153171464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_379:
					errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("瀢値䔦娨䠪弬䘮匰嘲䜴縶椸", a_), "");
					text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(astroDevice.SubscriberIP, astroDevice.PeerIP, out value);
					num = (short)389349380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BE:
					enumerator2 = errorList.GetEnumerator();
					num = (short)1825243149;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_6F:
				result = true;
				num = (short)469893129;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000391A8 File Offset: 0x000373A8
		public bool ValidateDeviceBluetoothDUNPeerIPAndRelatedIPsWhenEdit(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroDevice, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> relatedDataProfile, global::System.Collections.Generic.Dictionary<string, string> errorList, bool isIntegratedValidate = true)
		{
			int a_ = 2;
			short num = (short)901120000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				bool result;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.IList<string> list;
					string value;
					string text;
					global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator2;
					string subscriberIP;
					string peerIP;
					string bluetoothDUNPeerIP;
					switch (num2)
					{
					case 0:
					{
						int? num3;
						int num4;
						if (num3.GetValueOrDefault() == num4 & num3 != null)
						{
							num = (short)264568845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19E;
					}
					case 1:
						list.Add(astroDevice.LocServerIPAddress.Trim());
						num = (short)1469841418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						string empty;
						if (!string.IsNullOrEmpty(empty))
						{
							num = (short)498073621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19E;
					}
					case 3:
					{
						num = (short)136577024;
						short num5 = num;
						goto IL_4D1;
					}
					case 4:
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ⴛ✝ሟడᔣဥဧЩᴫᴭ/ᰱس", a_), value);
						num = (short)313458710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						list.Add(astroDevice.BluetoothPANNetworkBaseAddress.Trim());
						num = (short)375783442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (text != null)
						{
							num = (short)322699267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19E;
					case 7:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator = relatedDataProfile.GetEnumerator();
						num = (short)355270667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						int? assignmentType;
						int? num3 = assignmentType;
						int num4 = 0;
						num = (short)1730019328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1434910721;
						if (num != 0)
						{
						}
						if (!text.Equals(astroDevice.BluetoothDUNSubscriberIP))
						{
							num = (short)877854732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19E;
					case 10:
						goto IL_DD;
					case 11:
						goto IL_365;
					case 12:
					{
						string empty = string.Empty;
						astroDevice.BluetoothDUNSubscriberIP = text;
						this.ValidateDeviceBluetoothDUNSubscriberIP(astroDevice, relatedDataProfile, out empty, isIntegratedValidate);
						num = (short)869793794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_123;
					case 14:
						if (astroDevice.LocServerIPAddress != null)
						{
							num = (short)1164574721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD;
					case 15:
					{
						int? assignmentType;
						if (assignmentType != null)
						{
							num = (short)4390920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123;
					}
					case 16:
						goto IL_19E;
					case 17:
						if (relatedDataProfile != null)
						{
							num = (short)1880555527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71B;
					case 18:
						goto IL_53E;
					case 19:
						try
						{
							num = (short)1145831430;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2B0;
								case 1:
								{
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
									if (!string.IsNullOrEmpty(keyValuePair.Value))
									{
										num = (short)729284610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									result = false;
									num = (short)1851850752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_352;
								case 4:
									num = (short)598147075;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)823525380;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator2.Current;
									num = (short)1208942593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_297;
									}
									continue;
								}
								IL_2FC:
								num = (short)749797381;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_297:
								goto IL_2FC;
							}
							IL_2B0:
							IL_352:
							return result;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto Block_6;
					case 20:
					{
						if (!this.ValidateDeviceBluetoothDUNPeerIP(astroDevice, out value, isIntegratedValidate))
						{
							num = (short)1593704452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ⴛ✝ሟడᔣဥဧЩᴫᴭ/ᰱس", a_), "");
						int? assignmentType = astroDevice.AssignmentType;
						num = (short)1278279695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						subscriberIP = astroDevice.SubscriberIP;
						peerIP = astroDevice.PeerIP;
						bluetoothDUNPeerIP = astroDevice.BluetoothDUNPeerIP;
						list = new global::System.Collections.Generic.List<string>();
						num = (short)535101457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_19E;
					case 23:
						if (!string.IsNullOrEmpty(astroDevice.BluetoothPANNetworkBaseAddress))
						{
							num = (short)122224645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53E;
					}
					goto IL_97;
					IL_DD:
					num = (short)2118909975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_123:
					text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(astroDevice.BluetoothDUNPeerIP, astroDevice.BluetoothDUNSubscriberIP, out value);
					num = (short)755957766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19E:
					enumerator2 = errorList.GetEnumerator();
					num = (short)2124480531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D1:
					num = (short)835977225;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					try
					{
						IL_365:
						num = (short)1590558726;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)1626802390;
								short num6 = num;
								num = (short)50399446;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_37C;
								default:
								{
									num = (short)664403968;
									if (num != 0)
									{
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
									if (apxdataProfile.LocationServerIPAddress != null)
									{
										num = (short)183631873;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								break;
							}
							case 1:
							{
								global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
								list.Add(apxdataProfile.LocationServerIPAddress.Trim());
								num = (short)198967298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_4BE;
							case 4:
								num = (short)1991049219;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)692846596;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile = enumerator.Current;
								num = (short)1598619648;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_37C;
							}
							goto IL_3A9;
							IL_37C:
							switch (0)
							{
							case 0:
								IL_3A9:
								goto IL_467;
							}
							continue;
							IL_467:
							num = (short)1450835973;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_4BE:
						goto IL_71B;
					}
					finally
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_4D1;
					IL_53E:
					list.Add(peerIP);
					list.Add(subscriberIP);
					list.Add(bluetoothDUNPeerIP);
					text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDifferentIPValue(text, list);
					astroDevice.BluetoothDUNSubscriberIP = text;
					num = (short)1062273040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_71B:
					num = (short)1661992974;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_97:
				result = true;
				num = (short)1702428692;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00039948 File Offset: 0x00037B48
		public bool ValidateDeviceBluetoothDUNSubscriberIPAndRelatedIPsWhenEdit(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroDevice, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> relatedDataProfile, global::System.Collections.Generic.Dictionary<string, string> errorList, bool isIntegratedValidate = true)
		{
			int a_ = 7;
			short num = (short)1789329408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_74;
				}
				bool result;
				for (;;)
				{
					IL_31:
					string text;
					global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator;
					string value;
					switch (num2)
					{
					case 0:
						goto IL_BA;
					case 1:
					{
						string empty = string.Empty;
						astroDevice.BluetoothDUNPeerIP = text;
						this.ValidateDeviceBluetoothDUNPeerIP(astroDevice, out empty, isIntegratedValidate);
						num = (short)1589706762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_3F1;
					case 3:
						goto IL_BA;
					case 4:
					{
						string subscriberIP = astroDevice.SubscriberIP;
						string peerIP = astroDevice.PeerIP;
						string bluetoothDUNSubscriberIP = astroDevice.BluetoothDUNSubscriberIP;
						text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDifferentIPValue(text, new global::System.Collections.Generic.List<string>
						{
							peerIP,
							subscriberIP,
							bluetoothDUNSubscriberIP
						});
						astroDevice.BluetoothDUNPeerIP = text;
						num = (short)804126723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						try
						{
							num = (short)1370882054;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (enumerator.MoveNext())
									{
										global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
										num = (short)1573322754;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1767258415;
									short num3 = num;
									num = (short)534395183;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_208;
									default:
										num = (short)1696989184;
										if (num != 0)
										{
										}
										num = (short)560398337;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)208994307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
									if (!string.IsNullOrEmpty(keyValuePair.Value))
									{
										num = (short)1491337221;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_340;
								case 4:
									goto IL_323;
								case 5:
									result = false;
									num = (short)1455554564;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_208;
								}
								goto IL_235;
								IL_208:
								switch (0)
								{
								case 0:
									IL_235:
									goto IL_237;
								}
								continue;
								IL_237:
								num = (short)1264779264;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_323:
							IL_340:
							return result;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_353;
					case 6:
						if (!text.Equals(astroDevice.BluetoothDUNPeerIP))
						{
							num = (short)832765953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BA;
					case 7:
					{
						int? assignmentType;
						if (assignmentType != null)
						{
							num = (short)350945288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F1;
					}
					case 8:
					{
						num = (short)211746816;
						short num4 = num;
						int? assignmentType;
						int? num5 = assignmentType;
						int num6 = 0;
						num = (short)693108748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1870725126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						string empty;
						if (!string.IsNullOrEmpty(empty))
						{
							num = (short)1395851268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BA;
					}
					case 11:
					{
						if (!this.ValidateDeviceBluetoothDUNSubscriberIP(astroDevice, relatedDataProfile, out value, isIntegratedValidate))
						{
							num = (short)2012217358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ဠᨢᜤदᠨᴪᔬĮ02Դᤶ࠸", a_), "");
						int? assignmentType = astroDevice.AssignmentType;
						num = (short)40763399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						int? num5;
						int num6;
						if (num5.GetValueOrDefault() == num6 & num5 != null)
						{
							num = (short)1218117634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BA;
					}
					case 13:
						if (text != null)
						{
							num = (short)978255881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BA;
					case 14:
						goto IL_353;
					}
					goto IL_74;
					IL_BA:
					num = (short)81985537;
					if (num != 0)
					{
					}
					enumerator = errorList.GetEnumerator();
					num = (short)2125266949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_353:
					errorList.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ဠᨢᜤदᠨᴪᔬĮ02Դᤶ࠸", a_), value);
					num = (short)208404480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F1:
					text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(astroDevice.BluetoothDUNSubscriberIP, astroDevice.BluetoothDUNPeerIP, out value);
					num = (short)1221132301;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_74:
				result = true;
				num = (short)1154088971;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00039E50 File Offset: 0x00038050
		public override void ValidateDeviceModel(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device)
		{
			short num = (short)653852672;
			short num2 = num;
			num = (short)402849793;
			if (num != 0)
			{
			}
			num = (short)1861287936;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				object obj = this.g;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_258;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					string empty;
					bool flag2;
					for (;;)
					{
						IL_85:
						switch (num3)
						{
						case 0:
							if (astroradio.IsBluetoothDUNSubscriberIPEditable)
							{
								num = (short)1359282218;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_841;
						case 1:
							num = (short)1025310742;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							astroradio.OtarIDError = empty;
							num = (short)807206931;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							astroradio.PeerIPError = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
							num = (short)1545601121;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!this.ValidateDeviceBluetoothFriendlyName(astroradio.BluetoothFriendlyName, out empty))
							{
								num = (short)1660878934;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_11E4;
						case 5:
							goto IL_8FA;
						case 6:
							astroradio.VRIDError = empty;
							num = (short)528613421;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (!this.ValidateDeviceVRID(astroradio, out empty, false))
							{
								num = (short)1457520646;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_99C;
						case 8:
							if (string.IsNullOrEmpty(astroradio.PeerIP))
							{
								num = (short)542900260;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F75;
						case 9:
							if (astroradio.IsSubscriberIPEditable)
							{
								num = (short)860684331;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_DCB;
						case 10:
							num = (short)1432551481;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							if (string.IsNullOrEmpty(astroradio.PeerIPError))
							{
								num = (short)83886185;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A05;
						case 12:
							if (astroradio.IsUserLoginUnitIDEditable)
							{
								num = (short)372113454;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_351;
						case 13:
							if (astroradio.IsPeerIPEditable)
							{
								num = (short)1822752857;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F33;
						case 14:
							num = (short)7602204;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (string.IsNullOrEmpty(astroradio.SubscriberIPError))
							{
								num = (short)622985270;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A05;
						case 16:
						{
							string value = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(astroradio.BluetoothDUNSubscriberIP, astroradio.BluetoothDUNPeerIP, out empty);
							num = (short)800522271;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							if (flag2)
							{
								num = (short)838402100;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3FE;
						case 18:
							astroradio.PeerIPError = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_SubPeerNotSameSubset;
							astroradio.SubscriberIPError = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_SubPeerNotSameSubset;
							num = (short)1130692678;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							goto IL_10E2;
						case 20:
							astroradio.BluetoothDUNPeerIPError = empty;
							num = (short)2112749629;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							astroradio.RadioAliasError = empty;
							num = (short)414056489;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							if (flag2)
							{
								num = (short)1255276576;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_109D;
						case 23:
							num = (short)2123956268;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							num = (short)1416364140;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							goto IL_122A;
						case 26:
							if (astroradio.IsForeignIPEditable)
							{
								num = (short)1715666958;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C00;
						case 27:
							num = (short)1939144781;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							if (!this.ValidateForeignIP(astroradio.ForeignIP, out empty))
							{
								num = (short)1684602938;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C00;
						case 29:
							if (!this.ValidateRadioAlias(astroradio.RadioAlias, out empty))
							{
								num = (short)799342613;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B94;
						case 30:
							goto IL_1249;
						case 31:
						{
							string value;
							if (!string.IsNullOrEmpty(value))
							{
								num = (short)61931547;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_122A;
						}
						case 32:
							num = (short)1504247863;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							if (astroradio.IsBluetoothFriendlyNameEditable)
							{
								num = (short)905904242;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_11E4;
						case 34:
							goto IL_D8B;
						case 35:
							num = (short)1340276846;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							num = (short)1783300149;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
							astroradio.BluetoothDUNPeerIPError = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_BluetoothSubPeerNotSameSubset;
							astroradio.BluetoothDUNSubscriberIPError = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_BluetoothSubPeerNotSameSubset;
							num = (short)345833497;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 38:
							if (astroradio.IsVRIDEditable)
							{
								num = (short)250478679;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_99C;
						case 39:
							if (string.IsNullOrEmpty(astroradio.BluetoothDUNSubscriberIP))
							{
								num = (short)902889574;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_444;
						case 40:
							num = (short)1517879304;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 41:
							goto IL_B94;
						case 42:
							num = (short)313196635;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 43:
							num = (short)1965686801;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
							if (!string.IsNullOrEmpty(astroradio.PeerIP))
							{
								num = (short)1440874576;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A05;
						case 45:
							goto IL_99C;
						case 46:
							num = (short)1436745776;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 47:
							if (flag2)
							{
								num = (short)1267728424;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F75;
						case 48:
							if (!this.ValidateUserLoginUnitID(astroradio.UserLoginUnitID, astroradio.UserLoginUnitIDTextSize, out empty))
							{
								num = (short)598081635;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_351;
						case 49:
							if (astroradio.IsUserNameEditable)
							{
								num = (short)501874784;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8FA;
						case 50:
							if (!this.ValidateDeviceBluetoothDUNPeerIP(astroradio, out empty, flag2))
							{
								num = (short)567607316;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C41;
						case 51:
							astroradio.UserPINError = empty;
							num = (short)494862370;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 52:
							num = (short)686686271;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 53:
							if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsConfigurationMode())
							{
								num = (short)2108882947;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F75;
						case 54:
						{
							string value2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.EnsureSubIPandPeerIPareSameSubNet(astroradio.SubscriberIP, astroradio.PeerIP, out empty);
							num = (short)1895825487;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 55:
							if (string.IsNullOrEmpty(astroradio.BluetoothDUNPeerIP))
							{
								num = (short)666959939;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_109D;
						case 56:
							astroradio.PeerIPError = empty;
							num = (short)684785740;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 57:
							if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsConfigurationMode())
							{
								num = (short)259326063;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3FE;
						case 58:
							astroradio.ForeignIPError = empty;
							num = (short)594739264;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 59:
							if (!this.ValidateDeviceSubscriberIP(astroradio, null, out empty, flag2))
							{
								num = (short)970063972;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_DCB;
						case 60:
							num = (short)153944103;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 61:
							goto IL_C41;
						case 62:
							goto IL_351;
						case 63:
							if (string.IsNullOrEmpty(astroradio.SubscriberIP))
							{
								num = (short)1973616650;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3FE;
						case 64:
							goto IL_C00;
						case 65:
							if (!this.ValidateDeviceBluetoothDUNSubscriberIP(astroradio, null, out empty, flag2))
							{
								num = (short)230621272;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_841;
						case 66:
							if (!this.ValidateUserName(astroradio.UserName, astroradio.UserNameDisplayTextSize, out empty))
							{
								num = (short)2004222053;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8FA;
						case 67:
							num = (short)67436625;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 68:
							if (astroradio.IsUserPINEditable)
							{
								num = (short)167575664;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D8B;
						case 69:
							if (!string.IsNullOrEmpty(astroradio.SubscriberIP))
							{
								num = (short)1358626839;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A05;
						case 70:
							goto IL_A05;
						case 71:
							goto IL_3FE;
						case 72:
						{
							string value2;
							if (!astroradio.PeerIP.Equals(value2, global::System.StringComparison.Ordinal))
							{
								num = (short)912785426;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A05;
						}
						case 73:
							if (!this.ValidateUserPIN(astroradio.UserPIN, out empty))
							{
								num = (short)907542579;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D8B;
						case 74:
							num = (short)759431243;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 75:
							if (!string.IsNullOrEmpty(astroradio.BluetoothDUNPeerIP))
							{
								num = (short)532742179;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_122A;
						case 76:
							goto IL_F33;
						case 77:
						{
							string value;
							if (!astroradio.BluetoothDUNPeerIP.Equals(value, global::System.StringComparison.Ordinal))
							{
								num = (short)167575589;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_122A;
						}
						case 78:
							num = (short)558432363;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 79:
						{
							string value2;
							if (!string.IsNullOrEmpty(value2))
							{
								num = (short)434372712;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A05;
						}
						case 80:
							num = (short)1300168715;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 81:
							if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsConfigurationMode())
							{
								num = (short)363921511;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_109D;
						case 82:
							goto IL_11E4;
						case 83:
							goto IL_109D;
						case 84:
							if (!string.IsNullOrEmpty(astroradio.BluetoothDUNSubscriberIP))
							{
								num = (short)388890698;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_122A;
						case 85:
							goto IL_444;
						case 86:
							astroradio.OtarIDError = empty;
							num = (short)1052639314;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 87:
							num = (short)1818296327;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 88:
							astroradio.BluetoothDUNSubscriberIPError = empty;
							num = (short)1038221405;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 89:
							num = (short)1587740719;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 90:
							if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsConfigurationMode())
							{
								num = (short)1869676653;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_444;
						case 91:
							if (flag2)
							{
								num = (short)1715404860;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_444;
						case 92:
							if (!this.ValidateDevicePeerIP(astroradio, null, out empty, flag2))
							{
								num = (short)1194852408;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F33;
						case 93:
							goto IL_841;
						case 94:
							goto IL_DCB;
						case 95:
							num = (short)1327431709;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 96:
							num = (short)859635778;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 97:
							goto IL_F75;
						case 98:
							if (astroradio.IsOtarIDEditable)
							{
								num = (short)1445855256;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10E2;
						case 99:
							astroradio.UserLoginUnitIDError = empty;
							num = (short)1136984126;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 100:
							astroradio.SubscriberIPError = empty;
							num = (short)2020671582;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 101:
							astroradio.UserNameError = empty;
							num = (short)1915486213;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 102:
							num = (short)1802109018;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 103:
							astroradio.BluetoothDUNPeerIPError = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
							num = (short)766443603;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 104:
							num = (short)1761673288;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 105:
							num = (short)86441999;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 106:
							if (astroradio.IsRadioAliasEditable)
							{
								num = (short)1895956575;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B94;
						case 107:
							if (string.IsNullOrEmpty(astroradio.BluetoothDUNSubscriberIPError))
							{
								num = (short)1404305424;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_122A;
						case 108:
							if (!this.ValidateOTARID(astroradio, out empty))
							{
								num = (short)1305673730;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10E2;
						case 109:
							astroradio.BluetoothDUNSubscriberIPError = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
							num = (short)33226837;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 110:
							if (string.IsNullOrEmpty(astroradio.BluetoothDUNPeerIPError))
							{
								num = (short)170262606;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_122A;
						case 111:
							astroradio.SubscriberIPError = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_Missing;
							num = (short)351469639;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 112:
							num = (short)330694729;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 113:
							if (astroradio.IsBluetoothDUNPeerIPEditable)
							{
								num = (short)2035351553;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C41;
						case 114:
							num = (short)850984964;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_258;
						IL_351:
						num = (short)1607467076;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_3FE:
						num = (short)2084110395;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_444:
						num = (short)884211777;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_841:
						num = (short)1625423985;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_8FA:
						num = (short)416022634;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_99C:
						num = (short)1356988449;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A05:
						num = (short)770572372;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B94:
						num = (short)53936140;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C00:
						num = (short)147652706;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C41:
						num = (short)1013514253;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D8B:
						num = (short)1303642112;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_DCB:
						num = (short)432734234;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F33:
						num = (short)1530003465;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F75:
						num = (short)1664483420;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_109D:
						num = (short)438632498;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_10E2:
						num = (short)1040777254;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_11E4:
						num = (short)1726677061;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_122A:
						this.n(astroradio);
						num = (short)1932722206;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1249:
					return;
					IL_258:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					flag2 = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsIntegrated(device);
					base.ValidateDeviceModel(device);
					astroradio = (device as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
					empty = string.Empty;
					astroradio.CleanErrors();
					num = (short)1051656241;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_85;
				}
				finally
				{
					num = (short)2040856578;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_1306;
						case 1:
						{
							num = (short)1448946076;
							short num4 = num;
							num = (short)1163602332;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1308;
							default:
								num = (short)1344995328;
								if (num != 0)
								{
								}
								global::System.Threading.Monitor.Exit(obj);
								num = (short)802160640;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1280;
							}
							continue;
						}
						IL_1280:
						if (!flag)
						{
							break;
						}
						num = (short)787546113;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1306:
					IL_1308:;
				}
				return;
			}
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0003B184 File Offset: 0x00039384
		public override void CheckDeviceModelEditable(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device)
		{
			short num = (short)1388249088;
			short num2 = num;
			num = (short)1660242483;
			short num3 = num;
			num = (short)3754547;
			switch (num3 == num)
			{
			}
			num = (short)1117454337;
			if (num != 0)
			{
			}
			num = (short)760348672;
			if (num != 0)
			{
			}
			base.CheckDeviceModelEditable(device);
			global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = device as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
			astroradio.IsRadioAliasEditable = this.q(astroradio);
			astroradio.IsUserLoginUnitIDEditable = this.p(astroradio);
			astroradio.IsOtarIDEditable = this.o(astroradio);
			astroradio.IsBluetoothDUNPeerIPEditable = this.k(astroradio);
			astroradio.IsBluetoothDUNSubscriberIPEditable = this.j(astroradio);
			astroradio.IsBluetoothFriendlyNameEditable = this.i(astroradio);
			astroradio.IsUserNameEditable = this.h(astroradio);
			astroradio.IsUserPINEditable = this.g(astroradio);
			astroradio.IsSubscriberIPEditable = this.a(astroradio);
			astroradio.IsPeerIPEditable = this.f(astroradio);
			astroradio.IsForeignIPEditable = this.e(astroradio);
			astroradio.IsAskRequiredEditable = this.d(astroradio);
			astroradio.IsVRIDEditable = this.l(astroradio);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0003B2E4 File Offset: 0x000394E4
		public bool ValidateUserPINApplicability(string modelNumber, byte[] flashBytes, global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus radioStatus, out string error)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				int num;
				bool flag;
				switch (num)
				{
				case 0:
					num2 = (short)298844161;
					if (num2 != 0)
					{
					}
					flag = ((flashBytes[0] & 1) == 1);
					goto IL_26E;
				case 1:
					if (flashBytes.Length > 11)
					{
						num2 = (short)625147913;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					if (flashBytes != null)
					{
						num2 = (short)36569094;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1403650055;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_212;
				case 4:
					if (flashBytes != null)
					{
						num2 = (short)329383939;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 5:
					flag = false;
					goto IL_26E;
				case 6:
					num2 = (short)1441267716;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (radioStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.New)
					{
						num2 = (short)1266679819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 8:
					return result;
				case 9:
					num2 = (short)2026831884;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)1407123456;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					result = false;
					num2 = (short)1314127885;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if ((flashBytes[8] & 1) == 1)
					{
						num2 = (short)1594884106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1557725189;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					return result;
				}
				goto IL_48;
				IL_26E:
				bool flag2 = (flashBytes[0] & 1) > 0;
				bool flag3 = (flashBytes[7] & 16) > 0 && flag2;
				result = (flag || flag3);
				num2 = (short)1004470280;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_48:
			num2 = (short)1930952704;
			short num3 = num2;
			num2 = (short)589612736;
			short num4 = num2;
			num2 = (short)1228064448;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_212:
				num2 = (short)122028033;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1788018688;
				if (num2 != 0)
				{
				}
				result = true;
				error = string.Empty;
				num2 = (short)766836738;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0003B594 File Offset: 0x00039794
		public bool ValidateUserNameApplicability(string modelNumber, byte[] flashBytes, global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus radioStatus, out string error)
		{
			int a_ = 18;
			short num = (short)1054343168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C7;
				}
				bool result;
				for (;;)
				{
					IL_31:
					num = (short)1644669748;
					short num3 = num;
					num = (short)836479796;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1982529536;
						if (num != 0)
						{
						}
						bool flag;
						bool flag2;
						bool flag3;
						bool flag4;
						switch (num2)
						{
						case 0:
							if (radioStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.New)
							{
								num = (short)1418330124;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 1:
							return result;
						case 2:
							num = (short)1699020816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							flag = true;
							goto IL_607;
						case 4:
							num = (short)764805129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1137770502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (flashBytes.Length > 11)
							{
								num = (short)1664614411;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 7:
							if ((flashBytes[8] & 1) == 1)
							{
								num = (short)1382940687;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1505624072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							flag2 = false;
							goto IL_227;
						case 9:
							if (flashBytes != null)
							{
								num = (short)424869893;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 10:
							flag2 = ((flashBytes[0] & 1) > 0);
							goto IL_227;
						case 11:
							num = (short)330170375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_659;
						case 13:
							if (flashBytes != null)
							{
								num = (short)642449412;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1313996800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							return result;
						case 15:
						{
							num = (short)802488320;
							short num4 = num;
							num = (short)287113226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							flag = (flag3 && flag4);
							goto IL_607;
						}
						goto IL_C7;
						IL_227:
						flag4 = ((flashBytes[0] & 1) > 0);
						bool flag5 = (flashBytes[7] & 16) > 0 && flag4;
						flag3 = ((modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭܯ昱猳爵ķ樹欻༽Ŀు", a_) && (flashBytes[11] & 2) > 0) || (modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᨭय昱猳爵ķ樹欻༽Ŀు", a_) && (flashBytes[11] & 2) > 0) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭ࠯朱眳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭ࠯挱瀳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭ࠯愱瀳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭ࠯礱猳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭ࠯朱眳縵ķ樹欻ऽȿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭ࠯挱瀳縵ķ樹欻ऽȿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭ࠯愱瀳縵ķ樹欻ऽȿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭ࠯礱猳縵ķ樹欻ऽȿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭय挱瀳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭय礱猳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭय朱眳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭय挱瀳縵ķ樹欻ऽȿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭय礱猳縵ķ樹欻ऽȿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭय朱眳縵ķ樹欻ऽȿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᬭȯ朱眳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᬭȯ挱瀳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᬭȯ愱瀳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᬭȯ礱瀳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᬭį朱眳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᬭį挱瀳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᬭį愱瀳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᬭį礱瀳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᬭį攱眳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᘭЯ礱瀳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᘭЯ挱瀳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᘭЯ愱瀳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᘭЯ朱眳縵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᜭį昱猳爵ķ樹欻ऽĿు", a_) || modelNumber == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搫ᬭį搱眳縵ķ樹欻ऽĿు", a_));
						if (!flag2 && !flag5)
						{
							num = (short)1297743873;
							if (num != 0)
							{
							}
							num = (short)1314783234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)863043587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_607:
						result = flag;
						num = (short)1239613441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_659:
					result = false;
					num = (short)1975123982;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_C7:
				result = true;
				error = string.Empty;
				num = (short)120520717;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0003BC1C File Offset: 0x00039E1C
		public bool ValidateDVRSMSUACTEnable(byte[] flashBytes)
		{
			short num = (short)890044417;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			int num2;
			bool result;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
				{
					if (flashBytes == null)
					{
						return result;
					}
					num = (short)1164573946;
					short num3 = num;
					num = (short)1542913274;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1341456384;
						if (num != 0)
						{
						}
						num = (short)97386497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					num = (short)1597767684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1165950976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (flashBytes != null)
					{
						num = (short)2126970882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					if (flashBytes.Length > 11)
					{
						num = (short)1022033926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 5:
					return result;
				case 6:
				{
					result = ((flashBytes[8] & 8) > 0);
					num = (short)282460160;
					short num4 = num;
					num = (short)442040325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_54;
			}
			return result;
			IL_54:
			result = false;
			num = (short)1143144451;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0003BDC4 File Offset: 0x00039FC4
		public void ValidateDataProfileModel(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile dataProfile)
		{
			int a_ = 2;
			short num = (short)2139488256;
			short num2 = num;
			object obj = this.g;
			bool flag = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_114;
				}
				int num3;
				string text;
				for (;;)
				{
					IL_46:
					switch (num3)
					{
					case 0:
						goto IL_61E;
					case 1:
						if (dataProfile.BluetoothDUNSubscriberIP != null)
						{
							num = (short)156565521;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82F;
					case 2:
						goto IL_478;
					case 3:
						if (dataProfile.AirInterfaceIP != null)
						{
							num = (short)1686437893;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61E;
					case 4:
						num = (short)1414725667;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						this.ValidateAirInterfaceIP(dataProfile, null, null, out text);
						num = (short)327221248;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)964296705;
						if (num != 0)
						{
						}
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1803878438;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5;
					case 7:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)2094333992;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 8:
						dataProfile.BluetoothDUNPeerIPError = text;
						num = (short)1930690574;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_478;
					case 10:
						goto IL_6E0;
					case 11:
						if (dataProfile.PeerIP != null)
						{
							num = (short)1019412499;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_478;
					case 12:
						goto IL_86B;
					case 13:
						goto IL_29D;
					case 14:
						goto IL_520;
					case 15:
						this.ValidateDataProfileBluetoothDUNPeerIP(dataProfile, out text);
						num = (short)1770324000;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1620312089;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						this.ValidateDataProfileBluetoothDUNSubscriberIP(dataProfile, out text);
						num = (short)1297350690;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						dataProfile.BluetoothDUNSubscriberIPError = text;
						num = (short)690487308;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						this.ValidateDataProfilePeerIP(dataProfile, null, out text);
						num = (short)293854970;
						short num4 = num;
						num = (short)1659559674;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_29D;
						default:
							num = (short)976355328;
							if (num != 0)
							{
							}
							num = (short)1427439625;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 20:
						text = global::Motorola.CommonCPS.ResourceRepository.Resources.SubAirInterface_IP_NotProperFormat;
						num = (short)38273061;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)750190615;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (dataProfile.PeerIP == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("Ⱋ〝ဟడᐣࠥᠧ", a_))
						{
							num = (short)1005977624;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1716453387;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (dataProfile.BluetoothDUNPeerIP != null)
						{
							num = (short)1052114959;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A1;
					case 24:
						text = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfilePeerIP_NotProperFormat;
						num = (short)978780162;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (dataProfile.SubscriberIP == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("Ⱋ〝ဟడᐣࠥᠧ", a_))
						{
							num = (short)1865744426;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)196083760;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (dataProfile.IsSubscriberIPEditable)
						{
							num = (short)1529937936;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58B;
					case 27:
						dataProfile.SubscriberIPError = text;
						num = (short)501022750;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_882;
					case 29:
						if (dataProfile.IsPeerIPEditable)
						{
							num = (short)1165230126;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5;
					case 30:
						goto IL_58B;
					case 31:
						if (dataProfile.IsAirInterfaceIPEditable)
						{
							num = (short)881721348;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 32:
						goto IL_6A1;
					case 33:
						num = (short)1197277185;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_82F;
					case 35:
						if (dataProfile.AirInterfaceIP == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("Ⱋ〝ဟడᐣࠥᠧ", a_))
						{
							num = (short)1478361108;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1574436867;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)2116091931;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58B;
					case 37:
						goto IL_61E;
					case 38:
						dataProfile.PeerIPError = text;
						num = (short)532545580;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						this.ValidateDataProfileSubscriberIP(dataProfile, out text);
						num = (short)1445789745;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						dataProfile.AirInterfaceIPError = text;
						num = (short)218628137;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_280;
					case 42:
						text = global::Motorola.CommonCPS.ResourceRepository.Resources.ProfileSubIP_NotProperFormat;
						num = (short)1692139530;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1452670994;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_86B;
					case 44:
						goto IL_1A5;
					case 45:
						if (dataProfile.IsBluetoothDUNSubscriberIPEditable)
						{
							num = (short)1029439521;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_86B;
					case 46:
						num = (short)2014642198;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1861353480;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_520;
					case 48:
						if (dataProfile.SubscriberIP != null)
						{
							num = (short)1700134951;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E0;
					case 49:
						goto IL_6E0;
					}
					goto IL_114;
					IL_1A5:
					text = string.Empty;
					num = (short)23658522;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_280:
					text = string.Empty;
					num = (short)1720057869;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_29D:
					if (dataProfile.IsBluetoothDUNPeerIPEditable)
					{
						num = (short)1028194325;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_520;
					IL_478:
					num = (short)976420870;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_520:
					text = string.Empty;
					num = (short)1201405997;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_58B:
					text = string.Empty;
					num = (short)1862074399;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_61E:
					num = (short)508100615;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_6A1:
					num = (short)2027683887;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E0:
					num = (short)1733492772;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_82F:
					num = (short)861667371;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_86B:
					num = (short)1367539740;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_882:
				return;
				IL_114:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				dataProfile.IsPeerIPEditable = this.d(dataProfile);
				dataProfile.IsSubscriberIPEditable = this.d(dataProfile);
				dataProfile.IsAirInterfaceIPEditable = this.b(dataProfile);
				dataProfile.IsBluetoothDUNPeerIPEditable = this.a(dataProfile);
				dataProfile.IsBluetoothDUNSubscriberIPEditable = this.e(dataProfile);
				text = string.Empty;
				dataProfile.CleanErrors();
				num = (short)1943732253;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_46;
			}
			finally
			{
				num = (short)1266941953;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)1862860802;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_8B4;
						}
						continue;
					case 2:
						goto IL_8E9;
					}
					IL_8B4:
					if (!flag)
					{
						break;
					}
					num = (short)589955072;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_8E9:;
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0003C6DC File Offset: 0x0003A8DC
		public void ValidateOtarProfileModel(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile otarProfile)
		{
			int a_ = 15;
			short num = (short)1527786180;
			short num2 = num;
			num = (short)907946692;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1402601472;
				short num3 = num;
				num = (short)1506213889;
				if (num != 0)
				{
				}
				num = (short)1827471360;
				if (num != 0)
				{
				}
				num = (short)1961033728;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					object obj = this.g;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_101;
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						for (;;)
						{
							IL_D6:
							string empty;
							switch (num4)
							{
							case 0:
								if (apxradio == null)
								{
									num = (short)833617926;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F4;
							case 1:
								if (apxradio == null)
								{
									num = (short)170197000;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Add(otarProfile.RadioID.Value, apxradio);
								num = (short)1036713989;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_2B3;
							case 3:
								goto IL_29B;
							case 4:
								if (!this.ValidateWhenEditOTARProfilesCross(otarProfile, apxradio, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("昨弪䰬崮砰眲", a_), otarProfile.IsOtarIDEditable, out empty))
								{
									num = (short)1982267399;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_29B;
							case 5:
								goto IL_1F4;
							case 6:
								apxradio = this._serviceContainer.AstroSystemService.GetASTRORadioRawData(otarProfile.RadioID.Value, false);
								num = (short)2033582081;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								otarProfile.OTARIDError = empty;
								num = (short)225705987;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_1EF;
							}
							goto IL_101;
							IL_1F4:
							otarProfile.IsOtarIDEditable = this.a(apxradio);
							empty = string.Empty;
							otarProfile.CleanErrors();
							num = (short)1658847236;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_29B:
							num = (short)1448673282;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_1EF:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DeviceNoExistForEditTemplate, null);
						IL_2B3:
						break;
						IL_101:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						apxradio = (global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.GetCachedRadio(otarProfile.RadioID.Value) as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
						num = (short)1509621760;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_D6;
					}
					finally
					{
						num = (short)123797504;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2E7;
								}
								continue;
							case 1:
								goto IL_31D;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1159200769;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2E7:
							if (!flag)
							{
								break;
							}
							num = (short)1299316738;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_31D:;
					}
					break;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0003CA28 File Offset: 0x0003AC28
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.APXRadio A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)239206404;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.CanCreateJob(new global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?(A_0.LastJob.JobStatus)))
					{
						goto IL_10D;
					}
					return false;
				case 2:
					goto IL_19D;
				case 3:
				{
					num2 = (short)34184863;
					short num3 = num2;
					num2 = (short)874225311;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10D;
					default:
						num2 = (short)920059905;
						if (num2 != 0)
						{
						}
						num2 = (short)959119360;
						if (num2 != 0)
						{
						}
						if (A_0.LastJob == null)
						{
							num2 = (short)923795456;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)802750465;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_167;
				case 5:
					num2 = (short)1479933954;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
				IL_10D:
				num2 = (short)446758912;
				short num4 = num2;
				num2 = (short)233308165;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_167:
			global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
			bool? otarEnable = apxcodeplug.OtarEnable;
			bool? astroOtarEnable = apxcodeplug.AstroOtarEnable;
			int? secureOperation = apxcodeplug.SecureOperation;
			return global::SharedUtility.SharedConstrains.OtarIDEditable(otarEnable, astroOtarEnable, (secureOperation != null) ? new global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation?((global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation)secureOperation.GetValueOrDefault()) : null);
			IL_19D:
			bool? otarEnable2 = apxcodeplug.OtarEnable;
			bool? astroOtarEnable2 = apxcodeplug.AstroOtarEnable;
			secureOperation = apxcodeplug.SecureOperation;
			return global::SharedUtility.SharedConstrains.OtarIDEditable(otarEnable2, astroOtarEnable2, (secureOperation != null) ? new global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation?((global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation)secureOperation.GetValueOrDefault()) : null);
			IL_28:
			apxcodeplug = (A_0.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
			num2 = (short)2067791875;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0003CC30 File Offset: 0x0003AE30
		public void ValidateRadioSystemModel(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem sys)
		{
			short num = (short)1136787456;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? subSystemType;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
				for (;;)
				{
					IL_27:
					string empty;
					switch (num2)
					{
					case 0:
						if (!(subSystemType.GetValueOrDefault() == astroSystemSubType & subSystemType != null))
						{
							goto IL_B4;
						}
						sys.RadioID = null;
						sys.IsRadioIDEditable = false;
						num = (short)177733634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						sys.RadioIDError = empty;
						num = (short)1455816709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_142;
					case 3:
					{
						int? radioID = sys.RadioID;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType value = sys.SystemType.Value;
						subSystemType = sys.SubSystemType;
						if (!this.ValidateRadioIDValue(radioID, value, subSystemType.Value, sys.ExpandedMDCIDRange, sys.CodpelugVerison, out empty))
						{
							num = (short)638582785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						num = (short)1978793987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return;
					case 6:
					{
						num = (short)801172907;
						short num3 = num;
						num = (short)1354296747;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B4;
						default:
							num = (short)713687040;
							if (num != 0)
							{
							}
							num = (short)804126721;
							if (num != 0)
							{
							}
							sys.IsRadioIDEditable = this.a(sys);
							num = (short)15204359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_142;
					case 8:
						if (sys.IsRadioIDEditable)
						{
							num = (short)1795555332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_52;
					IL_B4:
					num = (short)1552613382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_142:
					empty = string.Empty;
					sys.RadioIDError = string.Empty;
					num = (short)1956642824;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_52:
				subSystemType = sys.SubSystemType;
				astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.QCII;
				num = (short)1056440320;
				short num4 = num;
				num = (short)1459159040;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0003CEC4 File Offset: 0x0003B0C4
		public override void ValidateTemplateModel(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase)
		{
			int a_ = 5;
			short num = (short)656343040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1829502977;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_A2;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate astrotemplate;
				string text2;
				for (;;)
				{
					IL_57:
					string text;
					bool flag;
					switch (num2)
					{
					case 0:
					{
						global::System.Guid? lauguagePackUuid;
						if (lauguagePackUuid != null)
						{
							num = (short)462749712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_143;
					}
					case 1:
						goto IL_2FD;
					case 2:
						return;
					case 3:
						if (global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().CheckIsSupportedLanguagePack(astrotemplate.FirmwareVersion, astrotemplate.CPLanguageIndex))
						{
							num = (short)127401992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
					{
						global::System.Guid? lauguagePackUuid;
						if (lauguagePackUuid == null)
						{
							num = (short)1870200841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)166068236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (!text.Equals(global::CommonUtility.ASTROLanguageSelection.ID_ENGLISH.ToString()))
						{
							num = (short)223412225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						flag = true;
						goto IL_35D;
					case 7:
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)787480590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
					{
						global::System.Guid? lauguagePackUuid = astrotemplate.LauguagePackUuid;
						num = (short)903872512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)2110980102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Guid? lauguagePackUuid;
						if (lauguagePackUuid == null)
						{
							num = (short)1734803467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)341180420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)55181327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::System.Guid? lauguagePackUuid;
						global::System.Guid empty;
						flag = (lauguagePackUuid.GetValueOrDefault() == empty);
						goto IL_35D;
					}
					case 13:
						goto IL_143;
					case 14:
						goto IL_19D;
					case 15:
						flag = false;
						goto IL_35D;
					case 16:
					{
						num = (short)848691200;
						short num3 = num;
						global::System.Guid? lauguagePackUuid = astrotemplate.LauguagePackUuid;
						global::System.Guid empty = global::System.Guid.Empty;
						num = (short)1647771658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_A2;
					IL_143:
					text2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroDecodeLanguageIndexToLPID(astrotemplate.CPLanguageIndex);
					text = global::CommonUtility.ASTROLanguageUtility.Instance.ConvertLPID2LanguageID(text2);
					num = (short)494927879;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35D:
					if (flag)
					{
						num = (short)1656029197;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						astrotemplate.LPError = null;
						num = (short)2108096514;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_19D:
				goto IL_2AF;
				IL_2FD:
				astrotemplate.LPError = text2 + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("㼞", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.Package_missing;
				return;
				IL_A2:
				num = (short)1696354390;
				short num4 = num;
				num = (short)1257066582;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_2AF:
					num = (short)155582469;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_57;
				default:
					num = (short)570490880;
					if (num != 0)
					{
					}
					astrotemplate = (templateBase as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate);
					num = (short)1638137859;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_57;
				}
				break;
			}
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0003D290 File Offset: 0x0003B490
		public override void ValidateDVRSHashDVRSFile(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate astrotemplate;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					bool? dvrshardwareEnable;
					if (dvrshardwareEnable.Value)
					{
						num2 = (short)105840650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1783103491;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)280100865;
					if (num2 != 0)
					{
					}
					bool? dvrshardwareEnable = astrotemplate.DVRSHardwareEnable;
					num2 = (short)1601110016;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (astrotemplate != null)
					{
						num2 = (short)1105002503;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (astrotemplate.DVRSFile.Uuid != global::System.Guid.Empty)
					{
						num2 = (short)239534088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					astrotemplate.DVRSFileError = global::Motorola.CommonCPS.ResourceRepository.Resources.DVRS_Hash_Not_Equal;
					num2 = (short)1203306508;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_256;
				case 6:
					if (astrotemplate.DVRSFile.Uuid != global::System.Guid.Empty)
					{
						num2 = (short)639434765;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					num2 = (short)645726223;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					astrotemplate.DVRSFileError = global::Motorola.CommonCPS.ResourceRepository.Resources.DVRS_Hardware_Disable_DVRSFile_None;
					num2 = (short)1732313102;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (!this.a(astrotemplate.DVRSFile))
					{
						num2 = (short)1618673669;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
				{
					num2 = (short)411484250;
					short num3 = num2;
					num2 = (short)721207386;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1EC;
					default:
						num2 = (short)1900544;
						if (num2 != 0)
						{
						}
						num2 = (short)424673291;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					if (this.FoundInvalidDVRS(astrotemplate.DVRSFile, astrotemplate.DVRSHashCodeLong))
					{
						num2 = (short)947847172;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CD;
				case 12:
					goto IL_CD;
				case 13:
					num2 = (short)1791623177;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					return;
				case 15:
					goto IL_1EC;
				}
				goto IL_50;
				IL_CD:
				num2 = (short)1291517958;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1EC:
				if (astrotemplate.ModelNumber == null)
				{
					return;
				}
				num2 = (short)1198063617;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_256:
			astrotemplate.DVRSFileError = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DVRS_File_Version_Not_Allowed;
			return;
			IL_50:
			astrotemplate = (templateBase as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate);
			astrotemplate.DVRSFileError = null;
			num2 = (short)73662464;
			short num4 = num2;
			num2 = (short)442499074;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0003D5DC File Offset: 0x0003B7DC
		public override bool FoundInvalidDVRS(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto DVRSFile, long DVRSHashCode)
		{
			short num = (short)1179648001;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					for (;;)
					{
						long? dvrsfileHash = DVRSFile.DVRSFileHash;
						num = (short)569349840;
						short num3 = num;
						num = (short)72324816;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_F1;
						}
					}
					IL_F1:
					num = (short)401866752;
					if (num != 0)
					{
					}
					num = (short)1362624515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					goto IL_140;
				case 3:
				{
					long? dvrsfileHash;
					if (dvrsfileHash.Value != DVRSHashCode)
					{
						num = (short)1874853890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				}
				IL_35:
				if (!(DVRSFile.Uuid != global::System.Guid.Empty))
				{
					return false;
				}
				num = (short)1932132352;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_140:
			num = (short)1767374849;
			if (num != 0)
			{
			}
			num = (short)1040384000;
			short num4 = num;
			return true;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0003D730 File Offset: 0x0003B930
		private bool b(string A_0)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			short num;
			int num2;
			string[] array;
			for (;;)
			{
				IL_13:
				num = (short)809107457;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)862126080;
					short num3 = num;
					num = (short)189199478;
					short num4 = num;
					num = (short)1855845494;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						num = (short)429195264;
						if (num != 0)
						{
						}
						num = (short)1977679875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (array[0] == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᘦἨሪ", a_))
					{
						goto IL_91;
					}
					return true;
				case 2:
					return false;
				case 3:
					if (array[1] == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᔦᰨἪ", a_))
					{
						num = (short)118947842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				goto IL_50;
				IL_91:
				num = (short)884408320;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_50:
			array = A_0.Split(new char[]
			{
				'.'
			});
			num = (short)2008678401;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0003D8AC File Offset: 0x0003BAAC
		public override bool ValidateWhenEditRadioColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase oldDevice, object newValue, string editedFieldName, out global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> fieldValues, out global::Motorola.CommonCPS.Server.EntityModel.Radio validateRadio, out string error)
		{
			int a_ = 19;
			short num = (short)424017920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B7;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
				uint num3;
				global::System.Collections.Generic.Dictionary<string, string> dictionary;
				bool flag;
				bool result;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> relatedDataProfile;
					int? num4;
					int? vrid;
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					string value;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> relatedDataProfile2;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> relatedDataProfile3;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> relatedDataProfile4;
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug2;
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug3;
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug4;
					switch (num2)
					{
					case 0:
						goto IL_EC1;
					case 1:
						return true;
					case 2:
						if (string.Equals(oldDevice.Comments, astroradio.Comments, global::System.StringComparison.Ordinal))
						{
							num = (short)386072796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.Comments, astroradio.Comments)
						};
						num = (short)1403650170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_74C;
					case 4:
						goto IL_74C;
					case 5:
						if (string.Equals((oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).UserLoginUnitID, astroradio.UserLoginUnitID, global::System.StringComparison.Ordinal))
						{
							num = (short)1510408299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.UserLoginUnitID, astroradio.UserLoginUnitID)
						};
						num = (short)358285381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1329987782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1291583755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1117454376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_74C;
					case 10:
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validateRadio.WorkingCodeplug.Timestamp, astroradio.CodeplugTimestamp))
						{
							num = (short)591331584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1771;
					case 11:
						if (num3 != 1464523644U)
						{
							num = (short)1915224279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)457113843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (!this.r(astroradio))
						{
							num = (short)1112604706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1184628782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validateRadio.WorkingCodeplug.Timestamp, astroradio.CodeplugTimestamp))
						{
							num = (short)2113143028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2327;
					case 14:
						if (num3 != 505833392U)
						{
							num = (short)428736553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2130706511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)122814570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (num3 != 2565758308U)
						{
							num = (short)283508759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)387449002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						return true;
					case 18:
						goto IL_221F;
					case 19:
						goto IL_74C;
					case 20:
						goto IL_74C;
					case 21:
						goto IL_1FB4;
					case 22:
						num = (short)675938472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)215220280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("漬䌮䐰嘲䄴堶嘸伺唼笾ᑀൂᙄ㉆⭈㡊⹌㵎㡐ㅒご╖ၘ୚", a_)))
						{
							num = (short)528351509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20E1;
					case 25:
						num = (short)1390018781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_74C;
					case 27:
						if (this.ValidateSerialNumber(astroradio.SerialNumber, out error))
						{
							num = (short)1134624992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 28:
						goto IL_74C;
					case 29:
						if (this.ValidateDeviceBluetoothDUNSubscriberIPAndRelatedIPsWhenEdit(astroradio, relatedDataProfile, dictionary, flag))
						{
							num = (short)961347632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 30:
						if (validateRadio == null)
						{
							num = (short)1933443150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)137035953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("戬嬮倰䄲簴猶", a_)))
						{
							num = (short)763756566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						astroradio.OtarID = (int?)newValue;
						num4 = (oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).OtarID;
						vrid = astroradio.OtarID;
						num = (short)705101907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_74C;
					case 33:
						num = (short)365297839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_1306;
					case 35:
						num = (short)585433319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (validateRadio.WorkingCodeplug != null)
						{
							num = (short)923271450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14BD;
					case 37:
						if (vrid.GetValueOrDefault() == num4.GetValueOrDefault() & vrid != null == (num4 != null))
						{
							num = (short)332398845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)251461644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_10D1;
					case 39:
						goto IL_74C;
					case 40:
						goto IL_74C;
					case 41:
						num = (short)1292894227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
					{
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("測䀮尰帲倴夶䴸䠺", a_)))
						{
							num = (short)1641283729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string uiValue = newValue as string;
						astroradio.Comments = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(uiValue);
						num = (short)1852702722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.AskRequired, astroradio.AskRequired)
						};
						num = (short)1761214541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validateRadio.WorkingCodeplug.Timestamp, astroradio.CodeplugTimestamp))
						{
							num = (short)1134034962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1195;
					case 45:
						goto IL_74C;
					case 46:
						if (this.ValidateDeviceVRID(astroradio, out error, false))
						{
							num = (short)73072745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 47:
						goto IL_74C;
					case 48:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.BluetoothDUNSubscriberIP, astroradio.BluetoothDUNSubscriberIP),
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.BluetoothDUNPeerIP, astroradio.BluetoothDUNPeerIP)
						};
						num = (short)1959788785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (num4.GetValueOrDefault() == vrid.GetValueOrDefault() & num4 != null == (vrid != null))
						{
							num = (short)1490419777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						validateRadio = (this._serviceContainer.RadioService.GetRadioRawData(astroradio.DeviceUuid, true) as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
						num = (short)435355801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("紬䨮吰䄲簴朶缸吺似砾ᑀੂ", a_)))
						{
							num = (short)987168893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17BF;
					case 51:
						goto IL_74C;
					case 52:
						goto IL_74C;
					case 53:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("樬崮帰䘲䔴猶堸伺尼甾⹀⅂ౄ⍆", a_)))
						{
							num = (short)2110128340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						astroradio.GroupDataJobId = new int?((int)newValue);
						num4 = (oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).GroupDataJobId;
						vrid = astroradio.GroupDataJobId;
						num = (short)1471348785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						if (apxcodeplug != null)
						{
							num = (short)995360867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A2;
					case 55:
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validateRadio.WorkingCodeplug.Timestamp, astroradio.CodeplugTimestamp))
						{
							num = (short)1289748728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62A;
					case 56:
						if (num3 != 2620727545U)
						{
							num = (short)999424163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)525533400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (num3 <= 1634292012U)
						{
							num = (short)1678442625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1318781038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
					{
						string text;
						astroradio.UserLoginUnitID = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(text);
						num = (short)1752760325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						if (!this.b(astroradio.SubscriberIP))
						{
							num = (short)1626931419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						validateRadio = (this._serviceContainer.RadioService.GetRadioRawData(astroradio.DeviceUuid, true) as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
						num = (short)116064447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						if (string.Equals(oldDevice.SerialNumber, astroradio.SerialNumber, global::System.StringComparison.OrdinalIgnoreCase))
						{
							num = (short)872939682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1142030363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						return true;
					case 62:
						goto IL_74C;
					case 63:
						value = string.Empty;
						num = (short)536084629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						num = (short)1715470356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						return true;
					case 66:
					{
						num = (short)1124532224;
						short num5 = num;
						num = (short)1023541339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 67:
						if (this.ValidateUserPIN(astroradio.UserPIN, out error))
						{
							num = (short)470024255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 68:
						if (!string.IsNullOrEmpty(error))
						{
							num = (short)696844569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 69:
						goto IL_74C;
					case 70:
						num = (short)1926955021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						num = (short)1616576522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						num = (short)392757517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						num = (short)897974275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						num = (short)1840840713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						num = (short)1299775635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (num3 != 3526026794U)
						{
							num = (short)547094706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)774701106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						goto IL_74C;
					case 78:
						goto IL_129B;
					case 79:
					{
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("缬丮唰娲娴瘶唸刺尼䰾", a_)))
						{
							num = (short)1806172354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string uiValue2 = newValue as string;
						astroradio.RadioAlias = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(uiValue2);
						num = (short)1223360704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 80:
						if (num3 != 1834575210U)
						{
							num = (short)461439226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2138964098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						return true;
					case 82:
						if (num3 <= 1157191835U)
						{
							num = (short)1464729788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1502019784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						if (num4.GetValueOrDefault() == vrid.GetValueOrDefault() & num4 != null == (vrid != null))
						{
							num = (short)1039597728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)903217249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						value = null;
						num = (short)1701642348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						goto IL_2280;
					case 86:
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validateRadio.Timestamp, astroradio.RadioTimestamp))
						{
							num = (short)1222574335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 87:
						num = (short)110100669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						num = (short)494272692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						num = (short)1249050638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (this.ValidateUserName(astroradio.UserName, astroradio.UserNameDisplayTextSize, out error))
						{
							num = (short)536412420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 91:
						goto IL_74C;
					case 92:
						goto IL_123E;
					case 93:
						if (this.ValidateDeviceBluetoothDUNPeerIPAndRelatedIPsWhenEdit(astroradio, relatedDataProfile2, dictionary, flag))
						{
							num = (short)1499201775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 94:
						num = (short)932643023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						goto IL_74C;
					case 96:
						num = (short)1069023327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						if (this.ValidateOTARID(astroradio, out error))
						{
							num = (short)558039272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 98:
						if (!this.b(astroradio.PeerIP))
						{
							num = (short)117440705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						validateRadio = (this._serviceContainer.RadioService.GetRadioRawData(astroradio.DeviceUuid, true) as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
						num = (short)61276440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						relatedDataProfile3 = apxcodeplug.APXDataProfiles;
						num = (short)520880390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						num = (short)522911770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						num = (short)562823312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						if (this.ValidateRadioAlias(astroradio.RadioAlias, out error))
						{
							num = (short)1058734254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 103:
						num = (short)658964481;
						if (num != 0)
						{
						}
						goto IL_74C;
					case 104:
						goto IL_74C;
					case 105:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.VRID, astroradio.VRID)
						};
						num = (short)1985740957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						goto IL_74C;
					case 107:
						return true;
					case 108:
						goto IL_EC1;
					case 109:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.CloneEnabledIPReserved;
						num = (short)1042743347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						if (num3 <= 2620727545U)
						{
							num = (short)1361576100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1610547332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						goto IL_2C22;
					case 112:
						num = (short)370737204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 113:
					{
						global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator = dictionary.GetEnumerator();
						num = (short)1742668059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 114:
						if (string.Equals((oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).BluetoothDUNPeerIP, astroradio.BluetoothDUNPeerIP, global::System.StringComparison.Ordinal))
						{
							num = (short)1787035649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2867;
					case 115:
						return true;
					case 116:
						if (!this.b(astroradio.BluetoothDUNSubscriberIP))
						{
							num = (short)212926573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						validateRadio = (this._serviceContainer.RadioService.GetRadioRawData(astroradio.DeviceUuid, true) as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
						num = (short)577372407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 117:
						num = (short)949420136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
					{
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("漬䌮䐰嘲䄴堶嘸伺唼社㍀⩂⁄⥆ⵈ❊㑌Ŏぐ㹒ご", a_)))
						{
							num = (short)331677760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string uiValue3 = newValue as string;
						astroradio.BluetoothFriendlyName = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(uiValue3);
						num = (short)1915814072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 119:
						num = (short)830931216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						if (!this.b(astroradio.ForeignIP))
						{
							num = (short)1411842172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)403898605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						if (this.ValidateDevicePeerIPAndRelatedIPsWhenEdit(astroradio, relatedDataProfile4, dictionary, flag))
						{
							num = (short)1058275562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 122:
						goto IL_74C;
					case 123:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("漬䌮䐰嘲䄴堶嘸伺唼笾ᑀൂᕄ≆ⱈ㥊ь὎", a_)))
						{
							num = (short)466354191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EFD;
					case 124:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.CloneEnabledIPReserved;
						num = (short)879493159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
						num = (short)1257242899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						if (astroradio.CodeplugTimestamp != null)
						{
							num = (short)901775367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1142;
					case 127:
						goto IL_2E74;
					case 128:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("欬䀮䌰嘲尴倶圸爺洼社⹀ㅂɄቆH", a_)))
						{
							num = (short)1836974153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F46;
					case 129:
						num = (short)570294354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 130:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("縬娮匰䀲嘴䔶倸夺堼䴾ࡀፂ", a_)))
						{
							num = (short)1583087716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1073;
					case 131:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("第紮砰眲", a_)))
						{
							num = (short)519831748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1626603790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 132:
						if (num3 <= 3134841045U)
						{
							num = (short)2081030398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1811349683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 133:
						if (num3 != 2231345737U)
						{
							num = (short)1308492050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1673199820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						num = (short)217120977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						goto IL_74C;
					case 136:
						return true;
					case 137:
						goto IL_2E93;
					case 138:
						goto IL_74C;
					case 139:
						if (apxcodeplug2 != null)
						{
							num = (short)424935627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FB4;
					case 140:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.CloneEnabledIPReserved;
						num = (short)240255122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
						if (string.Equals((oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).UserName, astroradio.UserName, global::System.StringComparison.Ordinal))
						{
							num = (short)419299443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)459407450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 142:
						if (num3 <= 505833392U)
						{
							num = (short)40042726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1604321531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 143:
						num = (short)1597046820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 144:
						if (num3 != 1216208513U)
						{
							num = (short)1218052129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)598016123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 145:
						num = (short)697762056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 146:
						goto IL_74C;
					case 147:
						goto IL_74C;
					case 148:
						if (num3 <= 2231345737U)
						{
							num = (short)1301086359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1837105417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 149:
						if (string.IsNullOrEmpty(astroradio.UserPIN))
						{
							num = (short)460521606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A8E;
					case 150:
						goto IL_74C;
					case 151:
						num = (short)1259536464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 152:
						goto IL_74C;
					case 153:
						if (validateRadio == null)
						{
							num = (short)282067109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)907739222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 154:
					{
						num = (short)341363747;
						short num6 = num;
						num = (short)1425591331;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2513;
						default:
							num = (short)843382784;
							if (num != 0)
							{
							}
							num = (short)1389232144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 155:
						goto IL_74C;
					case 156:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("紬䨮吰䄲簴朶", a_)))
						{
							num = (short)1638596680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17BF;
					case 157:
						goto IL_74C;
					case 158:
						num = (short)1077870636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 159:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("欬䀮䌰嘲尴倶圸爺洼", a_)))
						{
							num = (short)438370379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F46;
					case 160:
						return true;
					case 161:
						goto IL_74C;
					case 162:
						return true;
					case 163:
						num = (short)1379532955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 164:
						num = (short)1392509076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 165:
						goto IL_1CC3;
					case 166:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_2785;
							}
							string text2;
							for (;;)
							{
								IL_276A:
								switch (num2)
								{
								case 0:
									astroradio.VRID = new int?(global::System.Convert.ToInt32(text2, 16));
									num = (short)433782788;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_283B;
								case 2:
									goto IL_2854;
								case 3:
									if (text2.ToUpperInvariant().StartsWith(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᴬ眮", a_), global::System.StringComparison.Ordinal))
									{
										num = (short)2018312192;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									astroradio.VRID = new int?(global::System.Convert.ToInt32(text2, global::System.Globalization.CultureInfo.InvariantCulture));
									num = (short)167903233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_283B;
								}
								goto IL_2785;
								IL_283B:
								num = (short)723386370;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2854:
							goto IL_10D1;
							IL_2785:
							text2 = newValue.ToString();
							num = (short)323551235;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_276A;
						}
						catch
						{
							error = global::Motorola.CommonCPS.ResourceRepository.Resources.Error_VRID_Format;
							goto IL_10D1;
						}
						goto IL_2867;
					case 167:
					{
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("砬尮吰䄲礴堶常刺匼樾⽀⩂ㅄๆൈ", a_)))
						{
							num = (short)1946812490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = newValue as string;
						astroradio.UserLoginUnitID = text;
						num = (short)738984199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 168:
						goto IL_74C;
					case 169:
						goto IL_74C;
					case 170:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("縬䨮䌰娲吴嬶眸为值崾⑀ㅂ", a_)))
						{
							num = (short)56492149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						astroradio.SerialNumber = (newValue as string);
						num = (short)748945468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 171:
						if (num3 != 2672840055U)
						{
							num = (short)460914782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1844576438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 172:
						if (this.ValidateDeviceBluetoothFriendlyName(astroradio.BluetoothFriendlyName, out error))
						{
							num = (short)147456214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 173:
						if (string.Equals((oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).SubscriberIP, astroradio.SubscriberIP, global::System.StringComparison.Ordinal))
						{
							num = (short)496238673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1099104315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 174:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.RadioAlias, astroradio.RadioAlias)
						};
						num = (short)893321354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 175:
						if (num3 != 1381509879U)
						{
							num = (short)730726519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1224933418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 176:
						goto IL_28F3;
					case 177:
						if (astroradio.CodeplugTimestamp != null)
						{
							num = (short)1520893977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2327;
					case 178:
						num = (short)1141637404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 179:
						if (num3 != 3180538576U)
						{
							num = (short)565772545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)348979367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 180:
						goto IL_74C;
					case 181:
						if (num3 != 1560111736U)
						{
							num = (short)1999044869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1513553951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 182:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("漬䌮䐰嘲䄴堶嘸伺唼笾ᑀൂᕄ≆ⱈ㥊ь὎ᝐ㱒❔ၖౘቚ", a_)))
						{
							num = (short)1012269168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EFD;
					case 183:
						if (num3 != 1634292012U)
						{
							num = (short)118423560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)901709952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 184:
						if (string.Equals((oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).BluetoothFriendlyName, astroradio.BluetoothFriendlyName, global::System.StringComparison.Ordinal))
						{
							num = (short)1666383933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1385431212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 185:
						goto IL_74C;
					case 186:
						return true;
					case 187:
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validateRadio.Timestamp, astroradio.RadioTimestamp))
						{
							num = (short)509346000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1443234034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 188:
						num = (short)2073428110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 189:
						if (num3 != 1130138234U)
						{
							num = (short)294125574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1713635381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 190:
						if (string.Equals((oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).ForeignIP, astroradio.ForeignIP, global::System.StringComparison.Ordinal))
						{
							num = (short)1672216762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1391263864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 191:
						if (validateRadio == null)
						{
							num = (short)647168085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2513;
					case 192:
						if (string.Equals((oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).RadioAlias, astroradio.RadioAlias, global::System.StringComparison.Ordinal))
						{
							num = (short)126156817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)859701350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 193:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.CloneEnabledIPReserved;
						num = (short)682950759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 194:
						num = (short)18415839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 195:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("氬尮娰愲倴䘶䰸刺似娾╀", a_)))
						{
							num = (short)2113798240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						astroradio.AskRequired = (bool)newValue;
						num = (short)388497643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 196:
						num = (short)1747517472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 197:
						goto IL_1E76;
					case 198:
						if (num3 != 1157191835U)
						{
							num = (short)1486618751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1660354584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 199:
						num = (short)1263599868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 200:
						if (num3 <= 1381509879U)
						{
							num = (short)973013093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1603928075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 201:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_SerialNumber_AlreadyExists;
						num = (short)1960771801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 202:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio2 = astroradio;
						vrid = null;
						astroradio2.VRID = vrid;
						num = (short)1508180006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 203:
						relatedDataProfile4 = apxcodeplug2.APXDataProfiles;
						num = (short)780795925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 204:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("砬尮吰䄲攴縶眸", a_)))
						{
							num = (short)2049507394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						astroradio.UserPIN = (newValue as string);
						num = (short)970719299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 205:
						relatedDataProfile2 = apxcodeplug3.APXDataProfiles;
						num = (short)147259568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 206:
						if (validateRadio == null)
						{
							num = (short)1077084252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1040449723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 207:
						if (num3 != 2733624436U)
						{
							num = (short)409010462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1402798211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 208:
						goto IL_CDE;
					case 209:
						if (!flag)
						{
							num = (short)1213005908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A8E;
					case 210:
						return true;
					case 211:
						return true;
					case 212:
						num = (short)1525678127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 213:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)681640049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B5A;
					case 214:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.BluetoothFriendlyName, astroradio.BluetoothFriendlyName)
						};
						num = (short)255918326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 215:
						num = (short)981205173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 216:
					{
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("砬尮吰䄲笴嘶吸帺", a_)))
						{
							num = (short)486867223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string uiValue4 = newValue as string;
						astroradio.UserName = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(uiValue4);
						num = (short)1928593549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 217:
						goto IL_74C;
					case 218:
						relatedDataProfile = apxcodeplug4.APXDataProfiles;
						num = (short)925040777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 219:
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.CloneEnabledIPReserved;
						num = (short)768475305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 220:
						return true;
					case 221:
						if (validateRadio.WorkingCodeplug != null)
						{
							num = (short)2140995654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_209B;
					case 222:
						if (astroradio.CodeplugTimestamp != null)
						{
							num = (short)2119631047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1771;
					case 223:
						goto IL_74C;
					case 224:
						num = (short)2031550693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 225:
						goto IL_74C;
					case 226:
						if (!this.b(astroradio.BluetoothDUNPeerIP))
						{
							num = (short)70123660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						validateRadio = (this._serviceContainer.RadioService.GetRadioRawData(astroradio.DeviceUuid, true) as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
						num = (short)724238366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 227:
						goto IL_74C;
					case 228:
						if (string.Equals((oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).BluetoothDUNSubscriberIP, astroradio.BluetoothDUNSubscriberIP, global::System.StringComparison.Ordinal))
						{
							num = (short)1526989010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)195952756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 229:
						if (this._serviceContainer.RadioService.GetRadioBySerialNumber(astroradio.SerialNumber, false) != null)
						{
							num = (short)446955721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.SerialNumber, astroradio.SerialNumber),
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.DeviceID, astroradio.SerialNumber)
						};
						num = (short)45220025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 230:
						num = (short)131203338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 231:
						goto IL_74C;
					case 232:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.OtarID, astroradio.OtarID)
						};
						num = (short)1728053310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 233:
						if (this.ValidateDeviceSubscriberIPAndRelatedIPsWhenEdit(astroradio, relatedDataProfile3, dictionary, flag))
						{
							num = (short)1015152876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 234:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.PeerIP, astroradio.PeerIP),
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.SubscriberIP, astroradio.SubscriberIP)
						};
						num = (short)1304363012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 235:
						if ((oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).AskRequired == astroradio.AskRequired)
						{
							num = (short)1207894152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						validateRadio = (this._serviceContainer.RadioService.GetRadioRawData(astroradio.DeviceUuid, true) as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
						num = (short)733544654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 236:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.PeerIP, astroradio.PeerIP),
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.SubscriberIP, astroradio.SubscriberIP)
						};
						num = (short)849477857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 237:
						if (this.ValidateForeignIP(astroradio.ForeignIP, out error))
						{
							num = (short)582287631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 238:
						if (string.Equals((oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).PeerIP, astroradio.PeerIP, global::System.StringComparison.Ordinal))
						{
							num = (short)596181203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1123680354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 239:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.BluetoothDUNSubscriberIP, astroradio.BluetoothDUNSubscriberIP),
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.BluetoothDUNPeerIP, astroradio.BluetoothDUNPeerIP)
						};
						num = (short)425066774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 240:
						num = (short)1332674710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 241:
						goto IL_74C;
					case 242:
						if (this.ValidateAskRequiredWhenEdit(validateRadio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio, out error))
						{
							num = (short)932839467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 243:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("縬娮匰䀲嘴䔶倸夺堼䴾ࡀፂ̈́⡆㭈ొᡌَ", a_)))
						{
							num = (short)376897624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1073;
					case 244:
						goto IL_2639;
					case 245:
						goto IL_74C;
					case 246:
						goto IL_74C;
					case 247:
						if (validateRadio == null)
						{
							num = (short)119013634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1828257918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 248:
						goto IL_1517;
					case 249:
						num = (short)231669912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 250:
						num = (short)2011955333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 251:
						if (num3 != 633542544U)
						{
							num = (short)144834647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)729677980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 252:
						if (validateRadio.WorkingCodeplug != null)
						{
							num = (short)22347847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29F3;
					case 253:
						return true;
					case 254:
						num = (short)1999569067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 255:
						goto IL_21B0;
					case 256:
						goto IL_3109;
					case 257:
						num = (short)1578827852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 258:
						goto IL_1E56;
					case 259:
						if (apxcodeplug4 != null)
						{
							num = (short)1188757722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E93;
					case 260:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.UserName, astroradio.UserName)
						};
						num = (short)1710031075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 261:
						num = (short)138739895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 262:
						goto IL_5A2;
					case 263:
						if (this.ValidateUserLoginUnitID(astroradio.UserLoginUnitID, astroradio.UserLoginUnitIDTextSize, out error))
						{
							num = (short)1334837306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74C;
					case 264:
						goto IL_74C;
					case 265:
						if (num3 != 2557910859U)
						{
							num = (short)1472200858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)630325443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 266:
						if (num3 != 80834809U)
						{
							num = (short)1420230745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)91488532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 267:
						if (validateRadio.WorkingCodeplug != null)
						{
							num = (short)1808269470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1195;
					case 268:
						if (apxcodeplug3 != null)
						{
							num = (short)1335951565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F3;
					case 269:
						goto IL_74C;
					case 270:
						if (newValue == null)
						{
							num = (short)1506476234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1412497574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 271:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.ForeignIP, astroradio.ForeignIP)
						};
						num = (short)108069025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 272:
						goto IL_74C;
					case 273:
						if (num3 != 3134841045U)
						{
							num = (short)1245184240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1069154422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 274:
						num = (short)2008350965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 275:
						goto IL_74C;
					case 276:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("漬䌮䐰嘲䄴堶嘸伺唼笾ᑀൂᙄ㉆⭈㡊⹌㵎㡐ㅒご╖ၘ୚᭜ぞ፠③つ⹦", a_)))
						{
							num = (short)1200357625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20E1;
					case 277:
						num = (short)590741639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 278:
						goto IL_74C;
					case 279:
						num = (short)2032730140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 280:
						if (validateRadio == null)
						{
							num = (short)1917059183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)889979165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 281:
						result = false;
						num = (short)1630273733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 282:
						num = (short)409665591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 283:
						try
						{
							num = (short)1216806917;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2E61;
								case 1:
									num = (short)239861760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
									error = keyValuePair.Value;
									num = (short)1313931270;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
									if (!string.IsNullOrEmpty(keyValuePair.Value))
									{
										num = (short)582090754;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1543176193;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
									num = (short)266928131;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_2D9F;
									}
									continue;
								}
								IL_2E09:
								num = (short)1420165124;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D9F:
								goto IL_2E09;
							}
							IL_2E61:
							goto IL_2B5A;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2E74;
					case 284:
						if (num3 != 3942800474U)
						{
							num = (short)1054605347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1717043359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 285:
						if (astroradio.CodeplugTimestamp != null)
						{
							num = (short)2073690255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62A;
					case 286:
						num = (short)1404109073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 287:
						goto IL_74C;
					}
					goto IL_4B7;
					IL_5A2:
					num = (short)1547043049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62A:
					relatedDataProfile4 = null;
					apxcodeplug2 = (validateRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					num = (short)1215299723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74C:
					num = (short)488505557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EC1:
					fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>>
					{
						new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType.UserPIN, value)
					};
					num = (short)1356136735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F46:
					astroradio.ForeignIP = (newValue as string);
					num = (short)2082472126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1073:
					astroradio.SubscriberIP = (newValue as string);
					num = (short)1907818669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10D1:
					vrid = (oldDevice as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).VRID;
					num4 = astroradio.VRID;
					num = (short)248840229;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1195:
					relatedDataProfile = null;
					apxcodeplug4 = (validateRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					num = (short)1489109251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1771:
					relatedDataProfile3 = null;
					apxcodeplug = (validateRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					num = (short)1550319670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17BF:
					astroradio.PeerIP = (newValue as string);
					num = (short)1661731054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A8E:
					value = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroPINPasswordConvert(astroradio.UserPIN, true);
					num = (short)1198325760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FB4:
					num = (short)1214578809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20E1:
					astroradio.BluetoothDUNSubscriberIP = (newValue as string);
					num = (short)695402724;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2327:
					relatedDataProfile2 = null;
					apxcodeplug3 = (validateRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					num = (short)406716684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2513:
					num = (short)1309540574;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2867:
					num = (short)1470103778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28F3:
					num = (short)842793053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B5A:
					num = (short)204472388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E74:
					num = (short)1401618477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E93:
					num = (short)1744371741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EFD:
					astroradio.BluetoothDUNPeerIP = (newValue as string);
					num = (short)354222194;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_CDE:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_1142:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_123E:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
				IL_129B:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
				IL_1306:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.Error_VRID_NO_DVRS_FILE_ASSIGNED;
				return false;
				IL_14BD:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_1517:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_1CC3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
				IL_1E56:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
				IL_1E76:
				return result;
				IL_209B:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_21B0:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_221F:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_2280:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
				IL_2639:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_29F3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_2C22:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
				IL_3109:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_4B7:
				result = true;
				dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
				error = string.Empty;
				fieldValues = null;
				astroradio = (global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)oldDevice.Clone();
				astroradio.Validator = null;
				validateRadio = astroradio.ToServerModel();
				flag = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsIntegrated(oldDevice);
				num3 = global::c.a(editedFieldName);
				num = (short)680984633;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00040D44 File Offset: 0x0003EF44
		private bool r(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)1311113216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				global::System.Guid? workingTemplateUuid;
				bool result;
				for (;;)
				{
					IL_28:
					int? num5;
					bool flag;
					switch (num2)
					{
					case 0:
					{
						num = (short)1133569812;
						short num3 = num;
						num = (short)881846036;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_199;
						default:
							num = (short)2130575360;
							if (num != 0)
							{
							}
							if (workingTemplateUuid != null)
							{
								num = (short)420282374;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						break;
					}
					case 1:
					{
						global::System.Guid value;
						global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate = this._serviceContainer.TemplateService.GetTemplateRawData(value, true) as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate;
						if (apxtemplate == null)
						{
							num = (short)938803204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles> astrodvrsfiles = apxtemplate.ASTRODVRSFiles;
						if (astrodvrsfiles == null)
						{
							int? num4 = null;
							num = (short)267780099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = new int?(astrodvrsfiles.Count);
						goto IL_17B;
					}
					case 2:
						goto IL_199;
					case 3:
					{
						int? num4;
						num5 = num4;
						goto IL_17B;
					}
					case 4:
						flag = false;
						goto IL_1D4;
					case 5:
						result = true;
						num = (short)325451783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						workingTemplateUuid = A_0.WorkingTemplateUuid;
						global::System.Guid value = workingTemplateUuid.Value;
						num = (short)369688577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						return result;
					}
					goto IL_4F;
					IL_17B:
					int? num6 = num5;
					int num7 = 0;
					num = (short)671481858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D4:
					if (flag)
					{
						num = (short)1198850048;
						short num8 = num;
						num = (short)200015877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_199:
					num = (short)695664641;
					if (num != 0)
					{
					}
					flag = (num6.GetValueOrDefault() > num7 & num6 != null);
					goto IL_1D4;
				}
				return result;
				IL_4F:
				result = false;
				workingTemplateUuid = A_0.WorkingTemplateUuid;
				num = (short)641925120;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00040F8C File Offset: 0x0003F18C
		public bool ValidateWhenEditRadioSystemColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem oldSystem, string editedFieldName, object newValue, bool needCache, out global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>> fieldValues, out global::Motorola.CommonCPS.Server.EntityModel.Radio validateRadio, out string error)
		{
			int a_ = 8;
			short num = (short)1119813632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_B0;
				}
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("瀡䔣䈥䄧䔩攫樭", a_))
						{
							num = (short)355794964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					case 1:
						c.a.RadioID = null;
						num = (short)105578509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1DA;
					case 3:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)334430231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					case 4:
						if (global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.GetCachedRadio(c.a.DeviceID.Value) == null)
						{
							num = (short)354353177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6AA;
					case 5:
						if (validateRadio == null)
						{
							num = (short)1168310296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)371785757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType.RadioId, c.a.RadioID)
						};
						num = (short)75825167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(apxradioSystem.Timestamp, c.a.RadioSystemTimestamp))
						{
							num = (short)141623298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						apxradioSystem.RadioId = c.a.RadioID;
						num = (short)364642322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						return false;
					case 9:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = validateRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> list = apxcodeplug.APXRadioSystems.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem, bool>(c.b)).ToList<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>();
						num = (short)1757675530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> list;
						if (list != null)
						{
							num = (short)2135162902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					}
					case 11:
						num = (short)708182017;
						if (num != 0)
						{
						}
						if (newValue == null)
						{
							num = (short)1915158529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1346764827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_6AA;
					case 13:
						goto IL_30E;
					case 14:
						if (needCache)
						{
							num = (short)432144410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						validateRadio = this._serviceContainer.AstroSystemService.GetASTRORadioRawData(c.a.DeviceID.Value, false);
						num = (short)593952789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_28F;
					case 16:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> list;
						if (list.Count > 0)
						{
							num = (short)1728512019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					}
					case 17:
						goto IL_2D1;
					case 18:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
						if (this.ValidateRadioIDWhenEdit(apxradioSystem, apxcodeplug, validateRadio.ModelNumber, out error))
						{
							num = (short)1659633670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					}
					case 19:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> list;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem = list[0];
						num = (short)1885405184;
						short num3 = num;
						num = (short)1478295559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						num = (short)216224351;
						short num4 = num;
						num = (short)2045727327;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6AA;
						default:
						{
							num = (short)937099264;
							if (num != 0)
							{
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem a = new global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem();
							a.CopyFrom(oldSystem);
							num = (short)522584075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 21:
						goto IL_2D1;
					case 22:
						num = (short)1754071056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_54B;
					case 24:
						goto IL_309;
					case 25:
						global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Add(c.a.DeviceID.Value, this._serviceContainer.AstroSystemService.GetASTRORadioRawData(c.a.DeviceID.Value, false));
						num = (short)1836318732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)808648708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_466;
							}
							string text;
							for (;;)
							{
								IL_44B:
								switch (num2)
								{
								case 0:
									goto IL_520;
								case 1:
									goto IL_520;
								case 2:
									if (text.ToUpperInvariant().StartsWith(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ሡ簣", a_), global::System.StringComparison.Ordinal))
									{
										num = (short)423493635;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									c.a.RadioID = new int?(global::System.Convert.ToInt32(text, global::System.Globalization.CultureInfo.InvariantCulture));
									num = (short)1596784640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									c.a.RadioID = new int?(global::System.Convert.ToInt32(text, 16));
									num = (short)179306497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_538;
								}
								goto IL_466;
								IL_520:
								num = (short)128516100;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_538:
							goto IL_30E;
							IL_466:
							text = newValue.ToString();
							num = (short)1826291714;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_44B;
						}
						catch
						{
							error = global::Motorola.CommonCPS.ResourceRepository.Resources.Error_RadioID_Format;
							goto IL_30E;
						}
						goto IL_54B;
					case 28:
						if (!string.IsNullOrEmpty(error))
						{
							num = (short)1042022408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 29:
						if (validateRadio.WorkingCodeplug != null)
						{
							num = (short)347471881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					}
					goto IL_B0;
					IL_28F:
					num = (short)633929756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D1:
					num = (short)1644560389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30E:
					num = (short)639827971;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54B:
					num = (short)1331625998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6AA:
					validateRadio = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.GetCachedRadio(c.a.DeviceID.Value);
					num = (short)1217527825;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DA:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_309:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DeviceNoExistForEditTemplate, null);
				IL_354:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_B0:
				error = string.Empty;
				fieldValues = null;
				validateRadio = null;
				num = (short)287244288;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00041758 File Offset: 0x0003F958
		public bool ValidateWhenEditRadioDataProfileColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile oldDataProfile, string editedFieldName, object newValue, bool needCache, out global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> fieldValues, out global::Motorola.CommonCPS.Server.EntityModel.Radio validateRadio, out string error)
		{
			int a_ = 5;
			short num = (short)829095936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1A7;
				}
				global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.d d;
				global::System.Collections.Generic.Dictionary<string, string> dictionary;
				bool result;
				for (;;)
				{
					IL_30:
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug2;
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug3;
					switch (num2)
					{
					case 0:
						goto IL_323;
					case 1:
						goto IL_323;
					case 2:
					{
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp((validateRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).APXDataProfiles.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile, bool>(d.b)).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>().Timestamp, d.a.DataProfileTimestamp))
						{
							num = (short)653721673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num3 = global::c.a(editedFieldName);
						num = (short)1579155464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("伞䐠䘢圤渦礨", a_)))
						{
							num = (short)1888616454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_686;
					case 4:
						goto IL_B65;
					case 5:
						if (this.ValidateSubscriberIPAndRelatedIPsWhenEdit(d.a, apxcodeplug.SubscriberIP, dictionary))
						{
							num = (short)1478492224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_323;
					case 6:
						num = (short)2006908972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("崞䴠嘢䀤匦䘨䐪夬䜮田昲笴搶䰸夺丼尾㍀⩂❄≆㭈Ɋᵌॎ㹐⅒ቔɖၘ", a_)))
						{
							num = (short)1701576775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E79;
					case 8:
					{
						uint num3;
						if (num3 <= 1216208513U)
						{
							num = (short)430374951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)739770384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (this.ValidatePeerIPAndRelatedIPsWhenEdit(d.a, apxcodeplug2.SubscriberIP, dictionary))
						{
							num = (short)2128281660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_323;
					case 10:
						num = (short)1673658418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_323;
					case 12:
						num = (short)1756626974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1481965652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						uint num3;
						if (num3 != 633542544U)
						{
							num = (short)1116733499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)791609347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("崞䴠嘢䀤匦䘨䐪夬䜮田昲笴搶䰸夺丼尾㍀⩂❄≆㭈Ɋᵌ", a_)))
						{
							num = (short)876544048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E79;
					case 16:
					{
						uint num3;
						if (num3 <= 1834575210U)
						{
							num = (short)1161232404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)50397269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_D71;
					case 18:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType.AstroBluetoothDunPeerIp, d.a.BluetoothDUNPeerIP),
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType.AstroBluetoothDunSubscriberIp, d.a.BluetoothDUNSubscriberIP)
						};
						num = (short)417071166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1328414731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)578813985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (this.ValidateAirInterfaceIP(d.a, apxcodeplug3.PeerIP, apxcodeplug3.SubscriberIP, out error))
						{
							num = (short)1621033025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_323;
					case 22:
						num = (short)1984561152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_323;
					case 24:
						num = (short)1598750774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						uint num3;
						if (num3 != 2672840055U)
						{
							num = (short)1095565324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)166592587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (this.ValidateBluetoothDUNSubscriberIPAndRelatedIPsWhenEdit(d.a, dictionary))
						{
							num = (short)1130430501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_323;
					case 27:
						goto IL_DAB;
					case 28:
						global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Add(d.a.DeviceID.Value, this._serviceContainer.RadioService.GetRadioRawData(d.a.DeviceID.Value, true) as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
						num = (short)161153028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)685834283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						uint num3;
						if (num3 != 3526026794U)
						{
							num = (short)814284819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2123694146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						if (validateRadio == null)
						{
							num = (short)254803995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1923022850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						return result;
					case 33:
					{
						uint num3;
						if (num3 != 1464523644U)
						{
							num = (short)1596588085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)685047846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						goto IL_323;
					case 35:
					{
						uint num3;
						if (num3 != 1834575210U)
						{
							num = (short)216596569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2011365444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						result = false;
						num = (short)745144352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType.AstroBluetoothDunPeerIp, d.a.BluetoothDUNPeerIP),
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType.AstroBluetoothDunSubscriberIp, d.a.BluetoothDUNSubscriberIP)
						};
						num = (short)2136080433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䰞吠䄢嘤䐦嬨䈪伬䨮䌰稲攴然嘸䤺稼樾ࡀ", a_)))
						{
							num = (short)843448392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1022;
					case 39:
						num = (short)1302724650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.GetCachedRadio(d.a.DeviceID.Value) == null)
						{
							num = (short)33357852;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B65;
					case 41:
						goto IL_323;
					case 42:
					{
						uint num3;
						if (num3 <= 633542544U)
						{
							num = (short)1078919192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)949616726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						goto IL_323;
					case 44:
						goto IL_323;
					case 45:
						num = (short)1262354433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (!string.IsNullOrEmpty(error))
						{
							num = (short)1525153828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 47:
					{
						num = (short)1265706868;
						short num4 = num;
						num = (short)1895442292;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1199;
						default:
							num = (short)2025127936;
							if (num != 0)
							{
							}
							num = (short)125042713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 48:
						num = (short)1453981763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						goto IL_323;
					case 50:
						goto IL_323;
					case 51:
						goto IL_323;
					case 52:
						num = (short)869728314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						num = (short)813170723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
					{
						uint num3;
						if (num3 != 80834809U)
						{
							num = (short)1019084856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)191758343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						num = (short)2111963137;
						if (num != 0)
						{
						}
						goto IL_323;
					case 56:
						num = (short)457113614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_323;
					case 58:
						goto IL_323;
					case 59:
						num = (short)2034434082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType.SubscriberIP, d.a.SubscriberIP),
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType.PeerIP, d.a.PeerIP)
						};
						num = (short)381222935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)1441202267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						goto IL_323;
					case 63:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帞䠠儢氤䤦崨个弬䤮倰倲倴縶椸", a_)))
						{
							num = (short)1980760116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F8;
					case 64:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType.SubscriberIP, d.a.SubscriberIP),
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType.PeerIP, d.a.PeerIP)
						};
						num = (short)234750009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>>
						{
							new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType.AirInterfaceAddress, d.a.AirInterfaceIP)
						};
						num = (short)1413021751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("伞䐠䘢圤渦礨洪䈬崮瘰昲簴", a_)))
						{
							num = (short)454688778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_686;
					case 67:
						goto IL_323;
					case 68:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䰞吠䄢嘤䐦嬨䈪伬䨮䌰稲攴", a_)))
						{
							num = (short)1384251437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1022;
					case 69:
						try
						{
							num = (short)459210755;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
									if (!string.IsNullOrEmpty(keyValuePair.Value))
									{
										num = (short)2130116613;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_CA4;
								case 2:
									num = (short)513081345;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_BE5;
									}
									continue;
								case 5:
								{
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
									error = keyValuePair.Value;
									num = (short)537526276;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1813839874;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
									num = (short)812187648;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_C08:
								num = (short)983236614;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BE5:
								goto IL_C08;
							}
							IL_CA4:
							goto IL_46F;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_CB7;
					case 70:
						goto IL_323;
					case 71:
						num = (short)1479344179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						num = (short)1012531241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						goto IL_B60;
					case 74:
						if (needCache)
						{
							num = (short)2086469719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						validateRadio = (this._serviceContainer.RadioService.GetRadioRawData(d.a.DeviceID.Value, true) as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
						num = (short)508231697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("崞䴠嘢䀤匦䘨䐪夬䜮田昲笴朶尸帺似瘾ᅀՂ⩄㕆่Ṋь", a_)))
						{
							num = (short)753795094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F3;
					case 76:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帞䠠儢氤䤦崨个弬䤮倰倲倴縶椸紺刼䴾ـᙂౄ", a_)))
						{
							num = (short)1148715098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F8;
					case 77:
						if (this.ValidateBluetoothDUNPeerIPAndRelatedIPsWhenEdit(d.a, dictionary))
						{
							num = (short)1420230674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_323;
					case 78:
						goto IL_D71;
					case 79:
						if (string.IsNullOrEmpty(error))
						{
							num = (short)902496344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46F;
					case 80:
						num = (short)648478801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
					{
						uint num3;
						if (num3 != 1157191835U)
						{
							num = (short)1920401421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)160497679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 82:
						if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("崞䴠嘢䀤匦䘨䐪夬䜮田昲笴朶尸帺似瘾ᅀ", a_)))
						{
							num = (short)1606615069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F3;
					case 83:
						goto IL_323;
					case 84:
					{
						uint num3;
						if (num3 != 1216208513U)
						{
							num = (short)852557885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)910884946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
					{
						uint num3;
						if (num3 != 2255350071U)
						{
							num = (short)1693646895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1955201087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 86:
					{
						uint num3;
						if (num3 != 736304373U)
						{
							num = (short)2022637648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1199;
					}
					case 87:
						num = (short)1010434088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
					{
						global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator = dictionary.GetEnumerator();
						num = (short)1290141765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 89:
						goto IL_CB7;
					case 90:
						num = (short)1812136019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
					{
						num = (short)537395200;
						short num5 = num;
						goto IL_323;
					}
					}
					goto IL_1A7;
					IL_323:
					num = (short)2080243791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F8:
					d.a.AirInterfaceIP = (newValue as string);
					apxcodeplug3 = (validateRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					num = (short)831979541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46F:
					num = (short)427360302;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_686:
					d.a.PeerIP = (newValue as string);
					apxcodeplug2 = (validateRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					num = (short)2128609289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F3:
					d.a.BluetoothDUNPeerIP = (newValue as string);
					num = (short)274333773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B65:
					validateRadio = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.GetCachedRadio(d.a.DeviceID.Value);
					num = (short)1310457934;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CB7:
					num = (short)132907078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D71:
					num = (short)602538015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E79:
					d.a.BluetoothDUNSubscriberIP = (newValue as string);
					num = (short)627441690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1022:
					d.a.SubscriberIP = (newValue as string);
					apxcodeplug = (validateRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					num = (short)1405026309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1199:
					num = (short)2015690828;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B60:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_DAB:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
				IL_1A7:
				d = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.d();
				result = true;
				error = string.Empty;
				fieldValues = null;
				dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
				d.a = (global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)oldDataProfile.Clone();
				d.a.Validator = null;
				num = (short)1827799114;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000429D4 File Offset: 0x00040BD4
		public bool ValidateWhenEditOTARProfilesCross(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile otarProfile, global::Motorola.CommonCPS.Server.EntityModel.Radio validateRadio, string editedFieldName, bool isEditable, out string error)
		{
			int a_ = 14;
			short num = (short)116523008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_89;
				}
				global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.e e;
				for (;;)
				{
					IL_32:
					int? otarID;
					bool flag;
					bool flag3;
					switch (num2)
					{
					case 0:
						otarID = e.a.OtarID;
						num = (short)1567424520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if ((validateRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).APXOtarProfiles.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile, bool>(e.b)).Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile, int?>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.<>c.<>9.c)).Distinct<int?>().Concat(new int?[]
						{
							e.a.OtarID
						}).Distinct<int?>().Count<int?>() > 1)
						{
							num = (short)674889746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C0;
					case 2:
						goto IL_111;
					case 3:
					{
						num = (short)408616960;
						short num3 = num;
						flag = false;
						goto IL_416;
					}
					case 4:
						num = (short)715259905;
						if (num != 0)
						{
						}
						num = (short)1424883713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						bool? independentList = e.a.IndependentList;
						bool flag2 = true;
						num = (short)914554886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						bool? independentList;
						bool flag2;
						if (!(independentList.GetValueOrDefault() == flag2 & independentList != null))
						{
							num = (short)1558511620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C0;
					}
					case 7:
						if (editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("朧帩䴫尭礯瘱", a_))
						{
							num = (short)1112866816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1701904387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						flag = (otarID != null);
						goto IL_416;
					case 9:
						if (otarID != null)
						{
							num = (short)1114832909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED;
					case 10:
						otarID = e.a.OtarID;
						num = (short)965738512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_ED;
					case 12:
						return false;
					case 13:
						otarID = e.a.OtarID;
						goto IL_2AC;
					case 14:
						if (!string.IsNullOrEmpty(error))
						{
							num = (short)377094156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 15:
						if (isEditable && flag3)
						{
							num = (short)369623045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C0;
					case 16:
						if (otarID.Value >= 9999999)
						{
							num = (short)620298251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111;
					case 17:
						if (otarID.Value > 0)
						{
							num = (short)689831946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED;
					case 18:
						flag3 = false;
						error = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("洧堩師䄭䈯洱笳戵礷根画稽Ἷቁ㙃⥅⹇⍉⁋⭍⍏൑ᵓ㡕㭗㕙㉛ⵝय़ᅡၣͥ٧ṩ", a_));
						num = (short)1472200723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_1C0;
					}
					goto IL_89;
					IL_ED:
					flag3 = false;
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.Error_InvalidOTARId;
					num = (short)441450498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_111:
					num = (short)722599951;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C0:
					num = (short)855488345;
					short num4 = num;
					num = (short)55359321;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_2AC:
						num = (short)904527889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)644939776;
						if (num != 0)
						{
						}
						num = (short)391577614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_416:
					flag3 = flag;
					otarID = e.a.OtarID;
					num = (short)2098855945;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_89:
				e = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.e();
				e.a = otarProfile;
				error = string.Empty;
				num = (short)259653639;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00042EA0 File Offset: 0x000410A0
		public bool ValidateWhenEditOTARProfile(global::Motorola.CommonCPS.Server.EntityModel.APXRadio validateRadio, string editedFieldName, object newValue, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile otarProfileUI, bool fillUpDownActive, out string error)
		{
			int a_ = 5;
			short num = (short)157876224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.f f;
				for (;;)
				{
					IL_30:
					int? num5;
					switch (num2)
					{
					case 0:
						if (validateRadio.LastJob != null)
						{
							num = (short)205258765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_228;
					case 1:
					{
						int num3 = global::System.Convert.ToInt32(newValue);
						num = (short)2101346321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (fillUpDownActive)
						{
							num = (short)756744193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_288;
					case 3:
						if (newValue == null)
						{
							num = (short)1313144832;
							short num4 = num;
							num = (short)10158084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2036531202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_41F;
					case 5:
						goto IL_37D;
					case 6:
						goto IL_396;
					case 7:
						num = (short)1395720204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("倞唠䈢圤渦洨", a_))
						{
							num = (short)1637875721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 9:
						num = (short)658964483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_2A1;
					case 11:
						goto IL_228;
					case 12:
					{
						int num3;
						if (num3 >= 9999999)
						{
							num = (short)1028587541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_288;
					}
					case 13:
						num = (short)1305935891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (num5 != null)
						{
							num = (short)1507655698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37D;
					case 15:
						if (!fillUpDownActive)
						{
							num = (short)683671572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 16:
					{
						int? num6;
						int? otarID;
						if (!(num6.GetValueOrDefault() == otarID.GetValueOrDefault() & num6 != null == (otarID != null)))
						{
							num = (short)332529669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 17:
					{
						int num3;
						if (num3 > 0)
						{
							num = (short)2009202695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26B;
					}
					case 18:
						num = (short)375980047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (base.CanCreateJob(new global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?(validateRadio.LastJob.JobStatus)))
						{
							num = (short)816840715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37D;
					case 20:
					{
						int? num6 = num5;
						int? otarID = f.a.OtarID;
						num = (short)761784539;
						short num7 = num;
						num = (short)1905715419;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2A1;
						default:
							num = (short)170655744;
							if (num != 0)
							{
							}
							num = (short)837287952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 21:
						goto IL_35B;
					}
					goto IL_8F;
					IL_228:
					num = (short)1434779662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_288:
					num = (short)1682636810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37D:
					num = (short)148635654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A1:
					num5 = (validateRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).APXOtarProfiles.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile, bool>(f.b)).Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile, int?>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.<>c.<>9.d)).FirstOrDefault<int?>();
					num = (short)198705152;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_26B:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("尞丠䴢嘤匦嬨䨪䐬䄮渰稲嬴䄶堸场吼嬾เᝂфᕆH⽊", a_));
				return false;
				IL_35B:
				goto IL_26B;
				IL_396:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_41F:
				num = (short)996933633;
				if (num != 0)
				{
				}
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("娞匠儢䨤唦瘨搪礬渮挰稲焴栶簸嘺䴼䬾㡀", a_));
				return false;
				IL_8F:
				f = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.f();
				f.a = otarProfileUI;
				error = string.Empty;
				num = (short)1101266952;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00043380 File Offset: 0x00041580
		public override bool ValidateNewRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio, out string error)
		{
			int a_ = 1;
			short num = (short)136979954;
			short num2 = num;
			num = (short)1505895922;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_428:
				num = (short)796852257;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1955987456;
				if (num != 0)
				{
				}
				num = (short)863764491;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateDeviceVRID(astroradio, out error, false))
					{
						num = (short)301531146;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1904017438;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!string.IsNullOrEmpty(astroradio.UserPIN))
					{
						num = (short)1076887555;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
				}
				case 2:
					return false;
				case 3:
					num = (short)1902247962;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return false;
				case 5:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateRadioAlias(astroradio.RadioAlias, out error))
					{
						goto IL_428;
					}
					num = (short)527892495;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateDeviceIP(astroradio.PeerIP, out error))
					{
						num = (short)1627389983;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2058158107;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateDeviceBluetoothFriendlyName(astroradio.BluetoothFriendlyName, out error))
					{
						num = (short)2019098633;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 8:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidatePassWord(astroradio.PassWord, out error))
					{
						num = (short)302383108;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1996554268;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_107;
					}
					continue;
				case 12:
					if (radio is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)
					{
						num = (short)2009399317;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6B9;
				case 13:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateDeviceIPGroup(astroradio.PeerIP, astroradio.SubscriberIP, astroradio.BluetoothDUNPeerIP, astroradio.BluetoothDUNSubscriberIP, out error))
					{
						num = (short)1021378574;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)398589952;
					short num4 = num;
					num = (short)518520839;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					return false;
				case 15:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateOTARID(astroradio, out error))
					{
						num = (short)266928144;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1175584768;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 16:
					return false;
				case 17:
					return false;
				case 18:
					return false;
				case 19:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateSerialNumber(astroradio.SerialNumber, out error))
					{
						num = (short)1277231122;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)963379208;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 20:
					goto IL_513;
				case 21:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = radio as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
					num = (short)914817043;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 22:
					num = (short)1515323404;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateUserLoginUnitID(astroradio.UserLoginUnitID, astroradio.UserLoginUnitIDTextSize, out error))
					{
						num = (short)1142358033;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)167772185;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 24:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateDeviceIP(astroradio.BluetoothDUNPeerIP, out error))
					{
						num = (short)1970274333;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)981794817;
					if (num != 0)
					{
					}
					num = (short)1874591757;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 25:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateDeviceIP(astroradio.SubscriberIP, out error))
					{
						num = (short)516947988;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1879310342;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 26:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateUserPIN(astroradio.UserPIN, out error))
					{
						num = (short)1188429858;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
				}
				case 27:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateDeviceIP(astroradio.BluetoothDUNSubscriberIP, out error))
					{
						num = (short)1706819619;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1173487640;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 28:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateForeignIP(astroradio.ForeignIP, out error))
					{
						num = (short)834797600;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)43974661;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 29:
					goto IL_55D;
				case 30:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					if (!this.ValidateUserName(astroradio.UserName, astroradio.UserNameDisplayTextSize, out error))
					{
						num = (short)2102001666;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1572274177;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 31:
					goto IL_23D;
				case 32:
					return false;
				case 33:
					return false;
				case 34:
					return false;
				case 35:
					goto IL_4C7;
				}
				IL_107:
				if (radio != null)
				{
					num = (short)1949237270;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6B9;
				IL_148:
				num = (short)942735383;
				num3 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_23D:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PeerIP + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("㬚", a_) + error;
			return false;
			IL_4C7:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_BluetoothDUNSubscriberIP + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("㬚", a_) + error;
			return false;
			IL_513:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_SubscriberIP + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("㬚", a_) + error;
			return false;
			IL_55D:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_BluetoothDUNPeerIP + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("㬚", a_) + error;
			return false;
			IL_6B9:
			error = "";
			return false;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00043A50 File Offset: 0x00041C50
		public bool CanUpgradeCodeplugVersion(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems)
		{
			short num = (short)1712652288;
			switch (num)
			{
			default:
			{
				num = (short)100073475;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_FB;
					case 1:
						num = (short)31326210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (selectedItems.Count == 0)
						{
							num = (short)1218772992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = selectedItems.GetEnumerator();
						num = (short)783679492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 4:
						goto IL_C1;
					}
					IL_58:
					if (selectedItems == null)
					{
						goto IL_FF;
					}
					num = (short)174260224;
					short num3 = num;
					num = (short)1267007489;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C1:
				bool flag;
				try
				{
					num = (short)56033289;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1706622978;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = enumerator.Current as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
							num = (short)1380384778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_24F;
						case 2:
							num = (short)1565982727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)846462982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_269;
						case 5:
						{
							bool? isOutOfSync;
							if (isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null)
							{
								num = (short)1991245825;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							if (!string.IsNullOrEmpty(astroradio.CodeplugVersion))
							{
								num = (short)1666056200;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24F;
						}
						case 7:
							goto IL_2CC;
						case 8:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							bool? isOutOfSync = astroradio.IsOutOfSync;
							flag = true;
							num = (short)1621557253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							switch (0)
							{
							case 0:
								goto IL_17A;
							}
							continue;
						case 10:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							if (base.CanCreateJob(astroradio.JobStatus))
							{
								num = (short)119996419;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24F;
						}
						}
						IL_17C:
						num = (short)1228734464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_17A:
						goto IL_17C;
						IL_24F:
						flag = false;
						num = (short)949944324;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_269:
					return flag;
					IL_2CC:
					return true;
				}
				finally
				{
					num = (short)180027393;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_388;
						case 1:
							goto IL_2E7;
						case 2:
							enumerator.Dispose();
							num = (short)1455685632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_304;
						IL_2E7:
						switch (0)
						{
						case 0:
						{
							IL_304:
							num = (short)1697698578;
							short num4 = num;
							num = (short)138466066;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2E7;
							default:
								num = (short)1840054272;
								if (num != 0)
								{
								}
								if (enumerator == null)
								{
									goto IL_38A;
								}
								num = (short)1683881986;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							break;
						}
						}
					}
					IL_388:
					IL_38A:;
				}
				return flag;
				IL_FB:
				IL_FF:
				num = (short)690094081;
				if (num != 0)
				{
				}
				return false;
			}
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00043E08 File Offset: 0x00042008
		public bool CanFlashPort(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems)
		{
			short num = (short)398000129;
			if (num != 0)
			{
			}
			num = (short)1898774531;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					num = (short)1770323970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (selectedItems.Count == 0)
					{
						num = (short)1027473408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A7;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 4:
					try
					{
						num = (short)1449000963;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							bool flag;
							switch (num2)
							{
							case 0:
								goto IL_1A0;
							case 1:
								num = (short)1868824578;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								flag = this.e(selectedItems);
								goto IL_188;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_E0;
								}
								continue;
							case 4:
								flag = false;
								goto IL_188;
							}
							IL_E0:
							if (!this.a(selectedItems, false))
							{
								num = (short)1839726596;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)542316901;
							short num3 = num;
							num = (short)1270159717;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1A0;
							default:
								num = (short)1961623552;
								if (num != 0)
								{
								}
								num = (short)1390018561;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_188:
							result = flag;
							num = (short)1155661824;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1A0:
						return result;
					}
					catch
					{
						return false;
					}
					goto IL_1A7;
				}
				IL_60:
				num = (short)641597440;
				short num4 = num;
				if (selectedItems != null)
				{
					num = (short)68812801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1A7:
				num = (short)472711172;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00044028 File Offset: 0x00042228
		public bool CanUpgradeFirmware(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems)
		{
			short num;
			bool result;
			try
			{
				num = (short)452198401;
				if (num != 0)
				{
				}
				num = (short)788227114;
				short num2 = num;
				num = (short)583164970;
				switch (num2 == num)
				{
				}
				num = (short)971636736;
				if (num != 0)
				{
				}
				result = this.a(selectedItems, true);
			}
			catch
			{
				result = false;
			}
			num = (short)908787712;
			short num3 = num;
			return result;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000440F0 File Offset: 0x000422F0
		public new bool CanSelectMVO(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems)
		{
			short num = (short)1750007808;
			switch (num)
			{
			default:
			{
				num = (short)1639579651;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						num = (short)1773993985;
						if (num != 0)
						{
						}
						num = (short)1588658178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (selectedItems.Count == 0)
						{
							num = (short)1165099008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = selectedItems.GetEnumerator();
						num = (short)1064763396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 4:
						goto IL_BA;
					}
					IL_58:
					if (selectedItems == null)
					{
						return false;
					}
					num = (short)1916469248;
					short num3 = num;
					num = (short)1005977601;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BA:
				bool result;
				try
				{
					num = (short)122683408;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							if (!string.IsNullOrEmpty(astroradio.ModelNumber))
							{
								num = (short)771424265;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_255;
						case 2:
							goto IL_3FF;
						case 3:
							num = (short)1501102093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_39C;
						case 5:
							goto IL_381;
						case 6:
							num = (short)2071920642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_235;
						case 8:
							result = false;
							num = (short)477757447;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							num = (short)1684930574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							if (base.CanCreateJob(astroradio.JobStatus))
							{
								num = (short)102563851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_381;
						}
						case 11:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							bool? isOutOfSync = astroradio.IsOutOfSync;
							bool flag = true;
							num = (short)1842544658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							result = false;
							num = (short)1730674689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							if (!string.IsNullOrEmpty(astroradio.AstroPurchasedFlashCode))
							{
								num = (short)1799618572;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 14:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							if (!string.IsNullOrEmpty(astroradio.CodeplugVersion))
							{
								num = (short)2042494979;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 15:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							if (astroradio == null)
							{
								num = (short)1827602440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)819920906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							switch (0)
							{
							case 0:
								goto IL_196;
							}
							continue;
						case 17:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2106916870;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = enumerator.Current as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
							num = (short)543948815;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
						{
							bool? isOutOfSync;
							bool flag;
							if (isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null)
							{
								num = (short)1456406533;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)854261760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_198:
						num = (short)1408892945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_196:
						goto IL_198;
						IL_381:
						result = false;
						num = (short)1112735748;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_235:
					IL_255:
					IL_39C:
					return result;
					IL_3FF:
					return true;
				}
				finally
				{
					num = (short)754581505;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_4BB;
						case 1:
							goto IL_41A;
						case 2:
							enumerator.Dispose();
							num = (short)960036864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_437;
						IL_41A:
						switch (0)
						{
						case 0:
						{
							IL_437:
							num = (short)833468761;
							short num4 = num;
							num = (short)859814233;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_41A;
							default:
								num = (short)1044643840;
								if (num != 0)
								{
								}
								if (enumerator == null)
								{
									goto IL_4BD;
								}
								num = (short)252706818;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							break;
						}
						}
					}
					IL_4BB:
					IL_4BD:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000445D8 File Offset: 0x000427D8
		public bool CanQueryUpdateRadio(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems)
		{
			short num = (short)128778240;
			switch (num)
			{
			default:
			{
				num = (short)1515323392;
				short num2 = num;
				global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list = selectedItems.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
				bool result;
				try
				{
					num = (short)1011941405;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_2AE;
						case 1:
							goto IL_50E;
						case 2:
							goto IL_548;
						case 3:
							goto IL_1DD;
						case 4:
							if (list.Count == 0)
							{
								num = (short)1268187142;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_399;
						case 5:
						{
							int num4;
							if (num4 >= selectedItems.Count)
							{
								num = (short)713752585;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = list[num4] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
							num = (short)1353187344;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_178;
						case 7:
							result = false;
							num = (short)1109131266;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::System.Guid? workingCodeplugUUID;
							if (workingCodeplugUUID == null)
							{
								num = (short)256376839;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1874919447;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							num = (short)1587871755;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							if (base.CanCreateJob(astroradio.JobStatus))
							{
								num = (short)1653145628;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_50E;
						}
						case 11:
							goto IL_605;
						case 12:
							goto IL_1FD;
						case 13:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							if (!(this._serviceContainer.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).AstroCheckAskEnable(astroradio.AstroPurchasedFlashCode, astroradio.ModelNumber))
							{
								num = (short)537198618;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1314783264;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							result = false;
							num = (short)1065222156;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							result = false;
							num = (short)1866661909;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.HasMVO(astroradio))
							{
								num = (short)620822546;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_50E;
						}
						case 17:
							goto IL_2AE;
						case 18:
							num = (short)733544458;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							result = false;
							num = (short)2042298392;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
						{
							bool? isOutOfSync;
							bool flag;
							if (isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null)
							{
								num = (short)423755777;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							global::System.Guid? workingCodeplugUUID = astroradio.WorkingCodeplugUUID;
							num = (short)1656291336;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							goto IL_289;
						case 22:
							num = (short)1796210689;
							if (num != 0)
							{
							}
							if (list != null)
							{
								num = (short)1140195361;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_399;
						case 23:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							if (global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroCheckIsConvOnly(astroradio.AstroPurchasedFlashCode, astroradio.ModelNumber))
							{
								num = (short)707330062;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1653538829;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
							goto IL_2A9;
						case 25:
							goto IL_529;
						case 26:
							result = false;
							num = (short)1697382430;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
						{
							if (!this.d(list))
							{
								num = (short)1016987663;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num4 = 0;
							num = (short)1255538705;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 28:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							bool? isOutOfSync = astroradio.IsOutOfSync;
							bool flag = true;
							num = (short)871301140;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 29:
							switch (0)
							{
							case 0:
								goto IL_106;
							}
							continue;
						case 30:
							goto IL_461;
						case 31:
							num = (short)472907798;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
						{
							if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.ASKUtility.CheckForUnlimitedKeyLoaded(this._serviceContainer.DeviceOperation.GetLoadedASKWithoutDefault(false)))
							{
								num = (short)873463827;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num4;
							num4++;
							num = (short)981139456;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 33:
							num = (short)1149042692;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_106:
						if (list != null)
						{
							num = (short)1657864223;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_178:
						num = (short)414097629;
						short num5 = num;
						num = (short)1110352093;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_399:
							num = (short)1694695451;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)710344704;
							if (num != 0)
							{
							}
							result = false;
							num = (short)1136918531;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2AE:
						num = (short)1682571269;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_50E:
						result = false;
						num = (short)73924633;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1DD:
					IL_1FD:
					IL_289:
					IL_2A9:
					IL_461:
					IL_529:
					IL_548:
					return result;
					IL_605:
					return true;
				}
				catch
				{
					result = false;
				}
				return result;
			}
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00044C14 File Offset: 0x00042E14
		public bool CheckDevicesReadPerformedAndTheSameTemplate(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radioList, bool isRefresh)
		{
			short num = (short)1202454528;
			switch (num)
			{
			default:
			{
				num = (short)1163067403;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						return false;
					case 2:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> source;
						global::System.Collections.Generic.List<string> list = source.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.<>c.<>9.b)).ToList<string>();
						num = (short)410320913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)168165401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)479985704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						string value;
						if (string.IsNullOrEmpty(value))
						{
							num = (short)1098645533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)3014670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						int num3 = 1;
						num = (short)152961031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_14C;
					case 8:
						goto IL_63B;
					case 9:
						num = (short)233766928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Collections.Generic.List<string> list2;
						if (list2.Count > 1)
						{
							num = (short)1722744877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 11:
						switch (0)
						{
						case 0:
							goto IL_101;
						}
						continue;
					case 12:
						if (!isRefresh)
						{
							num = (short)2132410388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 13:
					{
						global::System.Collections.Generic.List<string> list;
						int num3;
						if (num3 >= list.Count)
						{
							num = (short)1913782311;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1773273106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::System.Collections.Generic.List<string> list;
						if (list.Count > 1)
						{
							num = (short)1328414726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_121;
					}
					case 15:
						goto IL_5FD;
					case 16:
						return false;
					case 17:
						goto IL_482;
					case 18:
					{
						global::System.Collections.Generic.List<string> list;
						int num3;
						if (string.IsNullOrEmpty(list[num3]))
						{
							num = (short)1002831881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2033385502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						global::System.Collections.Generic.List<bool?> list3;
						if (list3.Count == 0)
						{
							num = (short)1270022144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<bool?>.Enumerator enumerator = list3.GetEnumerator();
						num = (short)1257635874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						global::System.Collections.Generic.List<string> list2;
						string value2 = list2[0];
						num = (short)1075380259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::System.Collections.Generic.List<string> list2;
						string value2;
						int num4;
						if (!string.Equals(list2[num4], value2, global::System.StringComparison.Ordinal))
						{
							num = (short)1177419777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)1510539279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> source;
						global::System.Collections.Generic.List<bool?> list3 = source.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, bool?>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.<>c.<>9.d)).ToList<bool?>();
						num = (short)1848836115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_14C;
					case 24:
						goto IL_5FD;
					case 25:
					{
						global::System.Collections.Generic.List<string> list;
						if (list.Count == 0)
						{
							num = (short)1907884076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string value = list[0];
						num = (short)1434583045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_347;
					case 27:
						if (!string.IsNullOrEmpty(radioList[0].TemplateName))
						{
							num = (short)1224540206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1285554178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)1337917473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						return false;
					case 30:
					{
						global::System.Collections.Generic.List<string> list;
						string value;
						int num3;
						if (!string.Equals(list[num3], value, global::System.StringComparison.Ordinal))
						{
							num = (short)1354301476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)1979514903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> source;
						global::System.Collections.Generic.List<string> list2 = source.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.<>c.<>9.c)).ToList<string>();
						num = (short)519897129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						goto IL_482;
					case 33:
					{
						if (radioList.Count <= 0)
						{
							num = (short)418643994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> source = radioList.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>();
						global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
						global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
						global::System.Collections.Generic.List<bool?> list3 = new global::System.Collections.Generic.List<bool?>();
						num = (short)18612251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						try
						{
							num = (short)137494533;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<bool?>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)992739331;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									bool? flag = enumerator.Current;
									num = (short)543490055;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_264;
								case 2:
									goto IL_249;
								case 3:
									num = (short)6225924;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_2CA;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1D6;
									}
									continue;
								case 6:
								{
									bool? flag;
									if (!flag.Value)
									{
										num = (short)1455357954;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									bool? flag;
									if (flag != null)
									{
										num = (short)1390215176;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_249;
								}
								case 8:
									num = (short)1942683654;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_20F:
								num = (short)330170368;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D6:
								goto IL_20F;
								IL_249:
								result = false;
								num = (short)1104019457;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_264:
							return result;
							IL_2CA:
							goto IL_6F2;
						}
						finally
						{
							global::System.Collections.Generic.List<bool?>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2DD;
						IL_6F2:
						num = (short)2129920012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						string value2;
						if (!string.IsNullOrEmpty(value2))
						{
							num = (short)1069416458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2082179600;
						short num5 = num;
						num = (short)7965200;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3E2;
						default:
							num = (short)1154154496;
							if (num != 0)
							{
							}
							num = (short)1186857002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 36:
						return false;
					case 37:
					{
						global::System.Collections.Generic.List<string> list2;
						int num4;
						if (string.IsNullOrEmpty(list2[num4]))
						{
							goto IL_3E2;
						}
						num = (short)1156513813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
					{
						global::System.Collections.Generic.List<string> list2;
						int num4;
						if (num4 >= list2.Count)
						{
							num = (short)1289945096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1979514917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						goto IL_121;
					case 40:
						return false;
					case 41:
					{
						global::System.Collections.Generic.List<string> list;
						if (list != null)
						{
							num = (short)1765277699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 42:
						goto IL_95C;
					case 43:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> source;
						global::System.Collections.Generic.List<string> list = source.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.<>c.<>9.a)).ToList<string>();
						num = (short)427622432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						goto IL_3B1;
					case 45:
					{
						int num4 = 1;
						num = (short)231604248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						goto IL_2DD;
					}
					IL_101:
					if (radioList != null)
					{
						num = (short)1717501980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_121:
					num = (short)1715077142;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14C:
					num = (short)1360461837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DD:
					num = (short)919797803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E2:
					num = (short)424411140;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_482:
					num = (short)1385234463;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FD:
					num = (short)1114964006;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_347:
				return false;
				IL_3B1:
				return false;
				IL_63B:
				num = (short)1928986625;
				if (num != 0)
				{
				}
				return true;
				IL_95C:
				num = (short)418447360;
				short num6 = num;
				return false;
			}
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00045614 File Offset: 0x00043814
		private bool e(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> A_0)
		{
			short num = (short)552075268;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string modelNumber;
				int num3;
				switch (num2)
				{
				case 0:
					if (!string.Equals(modelNumber, A_0[num3].ModelNumber, global::System.StringComparison.CurrentCultureIgnoreCase))
					{
						num = (short)1531314179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3++;
					num = (short)1792344065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_128;
				case 2:
					goto IL_128;
				case 3:
					return false;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 5:
					goto IL_70;
				case 6:
					if (num3 >= A_0.Count)
					{
						num = (short)1481768967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1349320704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return true;
				}
				IL_46:
				if (string.IsNullOrEmpty(A_0[0].ModelNumber))
				{
					num = (short)293076997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				modelNumber = A_0[0].ModelNumber;
				num3 = 1;
				num = (short)1954742274;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_128:
				num = (short)953213048;
				short num4 = num;
				num = (short)788586616;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
					num = (short)1073283072;
					if (num != 0)
					{
					}
					num = (short)1158479878;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_70:
			num = (short)415367169;
			if (num != 0)
			{
			}
			num = (short)2082471936;
			short num5 = num;
			return false;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00045800 File Offset: 0x00043A00
		private bool a(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_52;
				case 1:
				{
					if (A_0 == null)
					{
						num2 = (short)1684537344;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_0 = A_0.ToUpper(global::System.Globalization.CultureInfo.CurrentCulture);
					num2 = (short)445186048;
					short num3 = num2;
					num2 = (short)190775298;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					num2 = (short)10223617;
					if (num2 != 0)
					{
					}
					if (A_0.Length == 10)
					{
						num2 = (short)1895956483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					goto IL_FF;
				}
				goto IL_20;
			}
			for (;;)
			{
				IL_52:
				num2 = (short)703365091;
				short num4 = num2;
				num2 = (short)899842019;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_138;
				}
			}
			IL_138:
			num2 = (short)1604517888;
			if (num2 != 0)
			{
			}
			return false;
			IL_FF:
			return this._serviceContainer.DeviceOperation.IsSerialNumberValid(A_0);
			IL_20:
			string empty = string.Empty;
			num2 = (short)738459649;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00045960 File Offset: 0x00043B60
		private bool a(byte[] A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			bool flag;
			bool flag2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_CC;
				case 1:
					if (A_0 != null)
					{
						num2 = (short)1613103111;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_97;
				case 2:
					if (flag)
					{
						num2 = (short)1423441920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					goto IL_97;
				case 4:
				{
					num2 = (short)459735040;
					short num3 = num2;
					byte b = A_0[4];
					flag = ((b & 8) > 0);
					flag2 = ((b & 4) > 0);
					num2 = (short)937230339;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (A_0 != null)
					{
						num2 = (short)261292038;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_97;
				case 6:
					num2 = (short)152502273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1273823240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					if (A_0.Length <= 4)
					{
						goto IL_97;
					}
					num2 = (short)86106083;
					short num4 = num2;
					num2 = (short)72146915;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num2 = (short)765526016;
						if (num2 != 0)
						{
						}
						num2 = (short)805240836;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_34;
				IL_97:
				num2 = (short)139722754;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_CC:
			return !flag2;
			IL_34:
			num2 = (short)1610350593;
			if (num2 != 0)
			{
			}
			flag = false;
			flag2 = false;
			num2 = (short)2017656837;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00045B58 File Offset: 0x00043D58
		private bool q(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			bool? isOutOfSync;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1922564096;
					short num3 = num2;
					num2 = (short)760971739;
					short num4 = num2;
					num2 = (short)724992475;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12E;
					default:
						num2 = (short)456130560;
						if (num2 != 0)
						{
						}
						num2 = (short)1656356866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (!(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null))
					{
						num2 = (short)1751515136;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12E;
				case 2:
					if (base.CanCreateJob(A_0.JobStatus))
					{
						num2 = (short)1548025859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12E;
				case 3:
					goto IL_129;
				}
				goto IL_20;
			}
			IL_129:
			return global::SharedUtility.SharedConstrains.RadioAliasEditable(A_0.RadioAliasEnable);
			IL_12E:
			num2 = (short)1435893761;
			if (num2 != 0)
			{
			}
			return false;
			IL_20:
			isOutOfSync = A_0.IsOutOfSync;
			flag = true;
			num2 = (short)563478529;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00045CBC File Offset: 0x00043EBC
		private bool p(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			bool? isOutOfSync;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (base.CanCreateJob(A_0.JobStatus))
					{
						num2 = (short)2055471105;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					goto IL_150;
				case 2:
				{
					num2 = (short)486877270;
					short num3 = num2;
					num2 = (short)1349462102;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num2 = (short)502202368;
						if (num2 != 0)
						{
						}
						num2 = (short)1031536640;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (!(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null))
					{
						num2 = (short)152109058;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_20;
			}
			IL_150:
			num2 = (short)927727616;
			short num4 = num2;
			return global::SharedUtility.SharedConstrains.UserLoginUnitIDEnable(A_0.UserLoginUnitIDEnable);
			IL_20:
			num2 = (short)49283073;
			if (num2 != 0)
			{
			}
			isOutOfSync = A_0.IsOutOfSync;
			flag = true;
			num2 = (short)479199235;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00045E20 File Offset: 0x00044020
		private bool o(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)727690374;
			short num2 = num;
			num = (short)1592044678;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)743440384;
				if (num != 0)
				{
				}
				num = (short)1536425984;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)140115968;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_B6;
					}
					bool? isOutOfSync;
					bool flag;
					for (;;)
					{
						IL_9B:
						switch (num3)
						{
						case 0:
							if (!(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null))
							{
								num = (short)1791950852;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 1:
							goto IL_145;
						case 2:
							if (base.CanCreateJob(A_0.JobStatus))
							{
								num = (short)624820227;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 3:
							num = (short)513671169;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)791281665;
							if (num != 0)
							{
							}
							num = (short)1952382978;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B6;
					}
					IL_145:
					int num5 = this.a(A_0, global::RFResourceRepository.RFResources.Multi_System_OTAR) ? 1 : 0;
					bool? otarEnable = A_0.OtarEnable;
					bool? astrootarEnable = A_0.ASTROOtarEnable;
					int? secureOperation = A_0.SecureOperation;
					bool flag2 = global::SharedUtility.SharedConstrains.OtarIDEditable_7175(otarEnable, astrootarEnable, (secureOperation != null) ? new global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation?((global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation)secureOperation.GetValueOrDefault()) : null, A_0.AESEnable);
					return num5 == 0 && flag2;
					IL_B6:
					isOutOfSync = A_0.IsOutOfSync;
					flag = true;
					num = (short)874512384;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_9B;
				}
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0004600C File Offset: 0x0004420C
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0, string A_1)
		{
			short num = (short)1855717376;
			short num2 = num;
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.g g = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.g();
			g.a = A_1;
			if (A_0.LicensedFeatureList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense, bool>(g.b)) == null)
			{
				num = (short)1356595201;
				if (num != 0)
				{
				}
				num = (short)2000902062;
				short num3 = num;
				num = (short)1484937134;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1189150720;
					if (num != 0)
					{
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000460E0 File Offset: 0x000442E0
		private void n(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)1557004288;
			short num2 = num;
			num = (short)755551072;
			short num3 = num;
			num = (short)1097845600;
			switch (num3 == num)
			{
			}
			num = (short)445906944;
			if (num != 0)
			{
			}
			num = (short)1905197057;
			if (num != 0)
			{
			}
			A_0.IsMSOTAREnabled = this.m(A_0);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00046198 File Offset: 0x00044398
		private bool m(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1588199426;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1850185095;
						short num3 = num;
						num = (short)212899207;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1956380672;
							short num4 = num;
							num = (short)1749221376;
							if (num != 0)
							{
							}
							num = (short)1033568257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_108;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (!this.a(A_0, global::RFResourceRepository.RFResources.Multi_System_OTAR))
					{
						return false;
					}
					num = (short)1975058433;
					if (num != 0)
					{
					}
					num = (short)900268032;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_108:
			bool? otarEnable = A_0.OtarEnable;
			bool? astrootarEnable = A_0.ASTROOtarEnable;
			int? secureOperation = A_0.SecureOperation;
			return global::SharedUtility.SharedConstrains.OtarIDEditable(otarEnable, astrootarEnable, (secureOperation != null) ? new global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation?((global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation)secureOperation.GetValueOrDefault()) : null);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000462EC File Offset: 0x000444EC
		private bool l(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			bool? isOutOfSync;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (base.CanCreateJob(A_0.JobStatus))
					{
						num2 = (short)1908932609;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					goto IL_153;
				case 2:
				{
					num2 = (short)1298253736;
					short num3 = num2;
					num2 = (short)1594673064;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num2 = (short)24379392;
						if (num2 != 0)
						{
						}
						num2 = (short)1739784192;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (!(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null))
					{
						num2 = (short)2117599233;
						if (num2 != 0)
						{
						}
						num2 = (short)1606942722;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_20;
			}
			IL_153:
			num2 = (short)1552351232;
			short num4 = num2;
			return global::SharedUtility.SharedConstrains.DVRSHardwareEnable(A_0.DVRSHardwareEnable);
			IL_20:
			isOutOfSync = A_0.IsOutOfSync;
			flag = true;
			num2 = (short)1645608963;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00046454 File Offset: 0x00044654
		private bool k(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)47918393;
			short num2 = num;
			num = (short)466365753;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)259457024;
				if (num != 0)
				{
				}
				num = (short)748355584;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_8E;
					}
					break;
				}
				break;
			}
			bool? isOutOfSync;
			bool flag;
			for (;;)
			{
				IL_73:
				switch (num3)
				{
				case 0:
					if (!(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null))
					{
						num = (short)45875204;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					if (base.CanCreateJob(A_0.JobStatus))
					{
						num = (short)1450901506;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					num = (short)2071855107;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_185;
				case 4:
				{
					num = (short)1094189057;
					if (num != 0)
					{
					}
					num = (short)495910912;
					short num4 = num;
					num = (short)2097414145;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_8E;
			}
			IL_185:
			bool? bluetoothEnable = A_0.BluetoothEnable;
			int? assignmentType = A_0.AssignmentType;
			return global::SharedUtility.SharedConstrains.BluetoothDUNPeerIPEditable(bluetoothEnable, (assignmentType != null) ? new global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType?((global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType)assignmentType.GetValueOrDefault()) : null);
			IL_8E:
			isOutOfSync = A_0.IsOutOfSync;
			flag = true;
			num = (short)1014562816;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_73;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00046620 File Offset: 0x00044820
		private bool j(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)631504896;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			int num3;
			bool? isOutOfSync;
			bool flag;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
					while (base.CanCreateJob(A_0.JobStatus))
					{
						num = (short)1793783553;
						short num4 = num;
						num = (short)32765697;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)215154688;
							if (num != 0)
							{
							}
							num = (short)1300561921;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_34;
						}
					}
					return false;
				case 1:
					goto IL_152;
				case 2:
					num = (short)1925251073;
					if (num != 0)
					{
					}
					num = (short)1543962624;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null))
					{
						num = (short)678494210;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				goto IL_4A;
			}
			return false;
			IL_152:
			return global::SharedUtility.SharedConstrains.BluetoothDUNSubscriberIPEditable(A_0.BluetoothEnable);
			IL_4A:
			isOutOfSync = A_0.IsOutOfSync;
			flag = true;
			num = (short)58720259;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00046788 File Offset: 0x00044988
		private bool i(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)1813839872;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num3;
			bool? isOutOfSync;
			bool flag;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					while (base.CanCreateJob(A_0.JobStatus))
					{
						num = (short)1414406781;
						short num4 = num;
						num = (short)514859645;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1585643521;
							if (num != 0)
							{
							}
							num = (short)791412736;
							if (num != 0)
							{
							}
							num = (short)369623041;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_32;
						}
					}
					return false;
				case 1:
					goto IL_153;
				case 2:
					num = (short)337903616;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null))
					{
						num = (short)1204944898;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				goto IL_48;
			}
			return false;
			IL_153:
			return global::SharedUtility.SharedConstrains.BluetoothFriendlyNameEditable(A_0.BluetoothEnable);
			IL_48:
			isOutOfSync = A_0.IsOutOfSync;
			flag = true;
			num = (short)1507131395;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000468F0 File Offset: 0x00044AF0
		private bool h(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)1237450752;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				bool result;
				for (;;)
				{
					IL_28:
					bool flag;
					switch (num2)
					{
					case 0:
						if (!global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.HasMVO(A_0))
						{
							num = (short)1406468104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AC;
					case 1:
					{
						bool? isOutOfSync;
						bool flag2;
						flag = !(isOutOfSync.GetValueOrDefault() == flag2 & isOutOfSync != null);
						goto IL_267;
					}
					case 2:
						num = (short)1669005319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1485045775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1232273408;
						short num3 = num;
						goto IL_306;
					}
					case 5:
						goto IL_306;
					case 6:
						if (base.CanCreateJob(A_0.JobStatus))
						{
							num = (short)1624637449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AC;
					case 7:
						if (base.CanCreateJob(A_0.JobStatus))
						{
							num = (short)1482555402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B9;
					case 8:
						goto IL_1D7;
					case 9:
					{
						bool? isOutOfSync = A_0.IsOutOfSync;
						bool flag2 = true;
						num = (short)1185349645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						bool? isOutOfSync = A_0.IsOutOfSync;
						bool flag2 = true;
						num = (short)803995649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.HasMVO(A_0))
						{
							num = (short)428539907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_306;
					case 12:
						flag = false;
						goto IL_267;
					case 13:
					{
						bool? isOutOfSync;
						bool flag2;
						if (!(isOutOfSync.GetValueOrDefault() == flag2 & isOutOfSync != null))
						{
							num = (short)125698049;
							if (num != 0)
							{
							}
							num = (short)269418510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AC;
					}
					case 14:
						result = true;
						num = (short)859176965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						string text;
						if (this.ValidateUserNameApplicability(A_0.ModelNumber, A_0.ServerSideASTROPurchasedFlashCode, A_0.RadioStatus, out text))
						{
							num = (short)1681391618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B9;
					}
					}
					goto IL_6F;
					IL_1B9:
					num = (short)1876361228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D7:
					num = (short)880607238;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_306:
					num = (short)612816361;
					short num4 = num;
					num = (short)1037801;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D7;
					default:
						goto IL_33B;
					}
					IL_267:
					result = flag;
					num = (short)1360658436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AC:
					num = (short)216924171;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_33B:
				num = (short)711196672;
				if (num != 0)
				{
				}
				return result;
				IL_6F:
				result = false;
				num = (short)1382023168;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00046C50 File Offset: 0x00044E50
		private bool g(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)817102848;
			short num2 = num;
			num = (short)488096192;
			short num3 = num;
			num = (short)1004650944;
			switch (num3 == num)
			{
			}
			num = (short)1492058113;
			if (num != 0)
			{
			}
			num = (short)311361536;
			if (num != 0)
			{
			}
			return this.b(A_0);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00046D00 File Offset: 0x00044F00
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			short num = (short)547946496;
			short num2 = num;
			num = (short)585039873;
			if (num != 0)
			{
			}
			bool? isOutOfSync = A_0.IsOutOfSync;
			bool flag = true;
			if (!(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null))
			{
				num = (short)2076535641;
				short num3 = num;
				num = (short)204696409;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1883570176;
					if (num != 0)
					{
					}
					return base.CanCreateJob(A_0.JobStatus);
				}
			}
			return false;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00046DD8 File Offset: 0x00044FD8
		private bool f(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)508297216;
			short num2 = num;
			bool? isOutOfSync = A_0.IsOutOfSync;
			bool flag = true;
			if (!(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null))
			{
				num = (short)1156132363;
				short num3 = num;
				num = (short)2078092811;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1050279937;
					if (num != 0)
					{
					}
					num = (short)213778432;
					if (num != 0)
					{
					}
					return base.CanCreateJob(A_0.JobStatus);
				}
			}
			return false;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00046EB0 File Offset: 0x000450B0
		private bool e(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)497418240;
			short num2 = num;
			bool? isOutOfSync = A_0.IsOutOfSync;
			bool flag = true;
			if (!(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null))
			{
				num = (short)2087256065;
				if (num != 0)
				{
				}
				num = (short)1280173298;
				short num3 = num;
				num = (short)931259634;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1088290816;
					if (num != 0)
					{
					}
					return base.CanCreateJob(A_0.JobStatus);
				}
			}
			return false;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00046F88 File Offset: 0x00045188
		private bool d(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)1757937664;
			short num2 = num;
			num = (short)235345272;
			short num3 = num;
			num = (short)1626150264;
			switch (num3 == num)
			{
			}
			num = (short)539361281;
			if (num != 0)
			{
			}
			num = (short)632225792;
			if (num != 0)
			{
			}
			return this.a(A_0);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00047038 File Offset: 0x00045238
		private bool c(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)1399062528;
			short num2 = num;
			if (base.CanCreateJob(A_0.JobStatus))
			{
				num = (short)244514817;
				if (num != 0)
				{
				}
				num = (short)382148827;
				short num3 = num;
				num = (short)1681531099;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)681312256;
					if (num != 0)
					{
					}
					bool? bluetoothEnable = A_0.BluetoothEnable;
					bool flag = false;
					return !(bluetoothEnable.GetValueOrDefault() == flag & bluetoothEnable != null);
				}
				}
			}
			return false;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00047114 File Offset: 0x00045314
		private bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)625147904;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				bool result;
				for (;;)
				{
					IL_29:
					bool flag;
					switch (num2)
					{
					case 0:
						if (!global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.HasMVO(A_0))
						{
							num = (short)1588330504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AC;
					case 1:
					{
						bool? isOutOfSync;
						bool flag2;
						flag = !(isOutOfSync.GetValueOrDefault() == flag2 & isOutOfSync != null);
						goto IL_268;
					}
					case 2:
						num = (short)209453063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1776746511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1784807424;
						short num3 = num;
						goto IL_305;
					}
					case 5:
						goto IL_305;
					case 6:
						if (base.CanCreateJob(A_0.JobStatus))
						{
							num = (short)721027081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AC;
					case 7:
						if (base.CanCreateJob(A_0.JobStatus))
						{
							num = (short)2036269066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BC;
					case 8:
						goto IL_1DA;
					case 9:
					{
						bool? isOutOfSync = A_0.IsOutOfSync;
						bool flag2 = true;
						num = (short)2114125837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						bool? isOutOfSync = A_0.IsOutOfSync;
						bool flag2 = true;
						num = (short)467992577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.HasMVO(A_0))
						{
							num = (short)584515587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_305;
					case 12:
						flag = false;
						goto IL_268;
					case 13:
					{
						bool? isOutOfSync;
						bool flag2;
						if (!(isOutOfSync.GetValueOrDefault() == flag2 & isOutOfSync != null))
						{
							num = (short)140574734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AC;
					}
					case 14:
						result = true;
						num = (short)1405419525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						string text;
						if (this.ValidateUserPINApplicability(A_0.ModelNumber, A_0.ServerSideASTROPurchasedFlashCode, A_0.RadioStatus, out text))
						{
							num = (short)479133697;
							if (num != 0)
							{
							}
							num = (short)776470530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BC;
					}
					}
					goto IL_70;
					IL_1BC:
					num = (short)765591564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DA:
					num = (short)1974534150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_305:
					num = (short)1735405216;
					short num4 = num;
					num = (short)1625829024;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DA;
					default:
						goto IL_33A;
					}
					IL_268:
					result = flag;
					num = (short)1683161092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AC:
					num = (short)910557195;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_33A:
				num = (short)1608187904;
				if (num != 0)
				{
				}
				return result;
				IL_70:
				result = false;
				num = (short)1170800640;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00047474 File Offset: 0x00045674
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)455081990;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.HasMVO(A_0))
					{
						num2 = (short)1354825736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					bool? isOutOfSync;
					bool flag;
					if (isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null)
					{
						return result;
					}
					num2 = (short)992411649;
					if (num2 != 0)
					{
					}
					num2 = (short)453215049;
					short num3 = num2;
					num2 = (short)1115390793;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
					{
						num2 = (short)446103552;
						short num4 = num2;
						num2 = (short)265945088;
						if (num2 != 0)
						{
						}
						num2 = (short)82706432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					return result;
				case 4:
					if (base.CanCreateJob(A_0.JobStatus))
					{
						num2 = (short)1682505733;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 5:
				{
					bool? isOutOfSync = A_0.IsOutOfSync;
					bool flag = true;
					num2 = (short)2012479490;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (this.a(A_0.ServerSideASTROPurchasedFlashCode))
					{
						num2 = (short)1130692615;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 7:
					result = true;
					num2 = (short)2005139459;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_6A;
				}
				goto IL_34;
				IL_6A:
				num2 = (short)1628045316;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_34:
			result = false;
			num2 = (short)2096365569;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00047680 File Offset: 0x00045880
		private bool e(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0)
		{
			short num2;
			bool result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.c(A_0))
						{
							num2 = (short)1011875841;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_124;
					case 1:
					{
						num2 = (short)1587806209;
						if (num2 != 0)
						{
						}
						num2 = (short)75104256;
						short num3 = num2;
						num2 = (short)950665219;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						result = true;
						num2 = (short)454754308;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (global::SharedUtility.SharedConstrains.DataProfileBluetoothDUNSubIPApplicable(A_0.AutoGenerateIPs, A_0.BluetoothEnable, A_0.SystemType, A_0.NatEnable, A_0.PacketDataMode))
						{
							num2 = (short)627310594;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_124;
					case 4:
						goto IL_9D;
					}
					goto IL_24;
				}
				IL_124:
				num2 = (short)626728423;
				short num4 = num2;
				num2 = (short)533011943;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_159;
				}
				IL_9D:
				goto IL_124;
				IL_24:
				result = false;
				num2 = (short)1802174464;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_159:
			num2 = (short)1206452224;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00047800 File Offset: 0x00045A00
		private bool d(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0)
		{
			short num2;
			bool result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.c(A_0))
						{
							num2 = (short)963313665;
							if (num2 != 0)
							{
							}
							num2 = (short)493355009;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_11A;
					case 1:
					{
						num2 = (short)1540947968;
						short num3 = num2;
						num2 = (short)188678147;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						result = true;
						num2 = (short)617873412;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (global::SharedUtility.SharedConstrains.DataProfileSubIPandPeerIPEditable(A_0.AutoGenerateIPs, A_0.SystemType, A_0.NatEnable, A_0.PacketDataMode))
						{
							num2 = (short)2036924418;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_11A;
					case 4:
						goto IL_9D;
					}
					goto IL_24;
				}
				IL_11A:
				num2 = (short)628848270;
				short num4 = num2;
				num2 = (short)780039822;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_14E;
				}
				IL_9D:
				goto IL_11A;
				IL_24:
				result = false;
				num2 = (short)1750466560;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_14E:
			num2 = (short)144244736;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00047974 File Offset: 0x00045B74
		private bool c(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0)
		{
			short num = (short)1604124672;
			short num2 = num;
			num = (short)461449909;
			short num3 = num;
			num = (short)1645947573;
			switch (num3 == num)
			{
			}
			num = (short)884539393;
			if (num != 0)
			{
			}
			num = (short)1083047936;
			if (num != 0)
			{
			}
			return base.CanCreateJob(A_0.JobStatus);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00047A2C File Offset: 0x00045C2C
		private bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0)
		{
			short num2;
			bool result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.c(A_0))
						{
							num2 = (short)1882456065;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E6;
					case 1:
						num2 = (short)989462531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						result = true;
						num2 = (short)1390149636;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						num2 = (short)1577123840;
						short num3 = num2;
						if (global::SharedUtility.SharedConstrains.AirInterfaceIPEditable(A_0.AutoGenerateIPs, A_0.SystemType))
						{
							num2 = (short)59113474;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E6;
					}
					case 4:
						goto IL_75;
					}
					goto IL_24;
				}
				IL_E6:
				num2 = (short)996924428;
				short num4 = num2;
				num2 = (short)49077260;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_11B;
				}
				IL_75:
				goto IL_E6;
				IL_24:
				result = false;
				num2 = (short)898760704;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_11B:
			num2 = (short)697368577;
			if (num2 != 0)
			{
			}
			num2 = (short)986644480;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00047B94 File Offset: 0x00045D94
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0)
		{
			short num2;
			bool result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)1587806209;
						if (num2 != 0)
						{
						}
						if (this.c(A_0))
						{
							num2 = (short)995098625;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_12C;
					case 1:
					{
						num2 = (short)755564544;
						short num3 = num2;
						num2 = (short)905052163;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						result = true;
						num2 = (short)1621688324;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (global::SharedUtility.SharedConstrains.DataProfileBluetoothDUNPeerIPEditable(A_0.AutoGenerateIPs, A_0.BluetoothEnable, A_0.BluetoothDunPeerIpAssignmentType, A_0.SystemType, A_0.NatEnable, A_0.PacketDataMode))
						{
							num2 = (short)175636482;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_12C;
					case 4:
						goto IL_9D;
					}
					goto IL_24;
				}
				IL_12C:
				num2 = (short)1801481108;
				short num4 = num2;
				num2 = (short)570780564;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_160;
				}
				IL_9D:
				goto IL_12C;
				IL_24:
				result = false;
				num2 = (short)515309568;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_160:
			num2 = (short)208142336;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00047D18 File Offset: 0x00045F18
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem A_0)
		{
			short num = (short)1497104384;
			short num2 = num;
			num = (short)1728970753;
			if (num != 0)
			{
			}
			num = (short)2115232483;
			short num3 = num;
			num = (short)325903075;
			switch (num3 == num)
			{
			}
			num = (short)406323200;
			if (num != 0)
			{
			}
			return base.CanCreateJob(A_0.JobStatus);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00047DCC File Offset: 0x00045FCC
		private bool d(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> A_0)
		{
			short num = (short)1274281984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				int? num3;
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (num3 != null)
						{
							num = (short)1591803910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
					{
						int value;
						int num4 = value;
						num3 = astroradio.OwnerAdvKeyType;
						if (num4 == num3.Value)
						{
							num = (short)814088201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 2:
					{
						int num5;
						if (num3.GetValueOrDefault() == num5 & num3 != null)
						{
							num = (short)2032205834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = astroradio.OwnerAdvKeyType;
						int value = num3.Value;
						num3 = astroradio.OwnerSystemId;
						int value2 = num3.Value;
						int num6 = 1;
						num = (short)1455292424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return true;
					case 4:
					{
						num3 = astroradio.OwnerSystemId;
						int num5 = 0;
						num = (short)2141585410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_2BC;
					case 6:
					{
						num = (short)429221404;
						short num7 = num;
						num = (short)1526425116;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_29E;
						default:
							num = (short)1216282624;
							if (num != 0)
							{
							}
							num3 = astroradio.OwnerSystemId;
							num = (short)262602765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_2B7;
					case 8:
						goto IL_2BC;
					case 9:
						num = (short)537919499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_165;
					case 11:
					{
						int value2;
						int num8 = value2;
						num3 = astroradio.OwnerSystemId;
						if (num8 != num3.Value)
						{
							goto IL_29E;
						}
						num = (short)276234240;
						short num9 = num;
						int num6;
						num6++;
						num = (short)659947525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						int num6;
						if (num6 >= A_0.Count)
						{
							num = (short)1148256259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						astroradio = (A_0[num6] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
						num = (short)444399617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (num3 != null)
						{
							num = (short)1507262468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_68;
					IL_29E:
					num = (short)645660679;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BC:
					num = (short)626458636;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_165:
				num = (short)1943928833;
				if (num != 0)
				{
				}
				return false;
				IL_2B7:
				return false;
				IL_68:
				astroradio = (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
				num3 = astroradio.OwnerAdvKeyType;
				num = (short)1495990272;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00048118 File Offset: 0x00046318
		private bool a(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> A_0, bool A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (observableCollection != null)
					{
						num2 = (short)1265172486;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
				{
					if (!this.CheckDevicesReadPerformedAndTheSameTemplate(observableCollection, A_1))
					{
						return false;
					}
					num2 = (short)620695607;
					short num3 = num2;
					num2 = (short)29823031;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DF;
					default:
						num2 = (short)1391525888;
						if (num2 != 0)
						{
						}
						num2 = (short)1621229569;
						if (num2 != 0)
						{
						}
						num2 = (short)1815805961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (base.CheckDevicesIsTheSameModel(observableCollection))
					{
						num2 = (short)205979658;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					if (this.a(observableCollection))
					{
						num2 = (short)1836449800;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					if (observableCollection != null)
					{
						goto IL_1DF;
					}
					goto IL_260;
				case 5:
					if (observableCollection.Count == 0)
					{
						num2 = (short)1179451405;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_260;
				case 6:
					num2 = (short)460718084;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (this.c(observableCollection))
					{
						num2 = (short)949092364;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 8:
					num2 = (short)1239678978;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1972109319;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)916848641;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)1232535557;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_25B;
				case 13:
					goto IL_1B1;
				}
				goto IL_48;
				IL_1DF:
				num2 = (short)589692928;
				short num4 = num2;
				num2 = (short)1858142219;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_260:
				num2 = (short)699596803;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1B1:
			return false;
			IL_25B:
			return !this.b(observableCollection);
			IL_48:
			observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(A_0);
			num2 = (short)1910964224;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000483C8 File Offset: 0x000465C8
		private bool c(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> A_0)
		{
			short num = (short)1687224320;
			switch (num)
			{
			default:
			{
				num = (short)494272513;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<bool> list;
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<string> enumerator;
					global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, string> selector;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)845479936;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_248;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)378208261;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string modelNumber = enumerator.Current;
									bool item = (this._serviceContainer.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).IsFreon(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX, modelNumber);
									list.Add(item);
									num = (short)425263107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_266;
								case 3:
									if (list.Distinct<bool>().Count<bool>() != 1)
									{
										num = (short)697171974;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_32F;
								case 5:
									num = (short)1769476;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									result = false;
									num = (short)316407810;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2D7:
								num = (short)652607489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_248:
								goto IL_2D7;
							}
							IL_266:
							return result;
							IL_32F:
							goto IL_87;
						}
						finally
						{
							num = (short)467075072;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_368;
									}
									continue;
								case 1:
									goto IL_39D;
								case 2:
									enumerator.Dispose();
									num = (short)1443037185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_368:
								if (enumerator == null)
								{
									break;
								}
								num = (short)696713218;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39D:;
						}
						goto IL_3A0;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_6A;
						}
						continue;
					case 2:
						if ((selector = global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.<>c.<>9__104_0) == null)
						{
							selector = (global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.<>c.<>9__104_0 = new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.<>c.<>9.a));
							goto IL_3A0;
						}
						goto IL_3A0;
					case 3:
						return false;
					case 4:
						goto IL_85;
					case 5:
						num = (short)92143617;
						if (num != 0)
						{
						}
						if (A_0 != null)
						{
							num = (short)694026248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_96;
					case 6:
						if (A_0.Count == 0)
						{
							num = (short)1793785863;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_96;
					case 7:
						goto IL_1CE;
					case 8:
					{
						num = (short)1889134088;
						short num3 = num;
						num = (short)92464648;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_85;
						default:
						{
							num = (short)795475968;
							short num4 = num;
							num = (short)555876352;
							if (num != 0)
							{
							}
							num = (short)1405681670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_6A:
					if (A_0 != null)
					{
						num = (short)2014052356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CE;
					IL_85:
					num = (short)1966604293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_96:
					list = new global::System.Collections.Generic.List<bool>();
					num = (short)1001062402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CE:
					num = (short)1520697347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A0:
					enumerator = A_0.Select(selector).Distinct<string>().GetEnumerator();
					num = (short)2027552768;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_87:
				return list.Distinct<bool>().Count<bool>() == 1;
			}
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000487C0 File Offset: 0x000469C0
		private bool b(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> A_0)
		{
			short num = (short)1823801344;
			short num2 = num;
			num = (short)1604390247;
			short num3 = num;
			num = (short)1944849767;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)979828736;
				if (num != 0)
				{
				}
				result = false;
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>.Enumerator enumerator = A_0.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>().GetEnumerator())
				{
					num = (short)1611923456;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_CE;
							}
							continue;
						case 1:
							if (enumerator.Current.MaceSecureHardwareType == global::Motorola.CommonCPS.ResourceRepository.Resources.secureMace)
							{
								num = (short)206831619;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = false;
							num = (short)339673090;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							result = true;
							num = (short)263127045;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)936312839;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_168;
						case 6:
							if (!enumerator.MoveNext())
							{
								num = (short)250216452;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1706426369;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_19F;
						}
						IL_114:
						num = (short)103743494;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_CE:
						goto IL_114;
					}
					IL_168:
					IL_19F:;
				}
				break;
			}
			num = (short)1069481985;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000489C0 File Offset: 0x00046BC0
		private bool a(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> A_0)
		{
			short num = (short)906166272;
			short num2 = num;
			num = (short)1409747542;
			short num3 = num;
			num = (short)906889814;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)835190784;
				if (num != 0)
				{
				}
				num = (short)1693057024;
				switch (num)
				{
				}
				break;
			}
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = A_0.GetEnumerator();
			try
			{
				num = (short)983042;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						bool? isOutOfSync = radioBase.IsOutOfSync;
						bool flag = true;
						num = (short)1409482761;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1999306759;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
						num = (short)772931594;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_F5;
						}
						continue;
					case 3:
						goto IL_1D7;
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						if (base.CanCreateJob(radioBase.JobStatus))
						{
							num = (short)1716977664;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BB;
					}
					case 5:
						goto IL_266;
					case 6:
						num = (short)740163588;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)325451781;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						bool? isOutOfSync;
						bool flag;
						if (!(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null))
						{
							num = (short)1720254475;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BB;
					}
					case 10:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						if (radioBase.RadioStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.New)
						{
							num = (short)1189281798;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BB;
					}
					case 11:
						result = true;
						num = (short)1766391816;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_13A:
					num = (short)1828192257;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_F5:
					goto IL_13A;
					IL_1BB:
					result = false;
					num = (short)1572470787;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1D7:
				IL_266:;
			}
			finally
			{
				num = (short)20840448;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_29A;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)298188802;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2D0;
					}
					IL_29A:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1619984385;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_2D0:;
			}
			num = (short)285278209;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00048CE4 File Offset: 0x00046EE4
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto A_0)
		{
			short num = (short)1700921344;
			short num2 = num;
			num = (short)1422226153;
			short num3 = num;
			num = (short)1077179113;
			switch (num3 == num)
			{
			}
			num = (short)831651841;
			if (num != 0)
			{
			}
			num = (short)705953792;
			if (num != 0)
			{
			}
			return int.Parse(A_0.PackageVersion) >= 2;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00048DA0 File Offset: 0x00046FA0
		// Note: this type is marked as 'beforefieldinit'.
		static ASTROUIValidationService()
		{
			int a_ = 7;
			short num = (short)236060672;
			short num2 = num;
			num = (short)128777858;
			short num3 = num;
			num = (short)931462786;
			switch (num3 == num)
			{
			}
			num = (short)2083913729;
			if (num != 0)
			{
			}
			num = (short)218300416;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.a = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("缠ଢത簦ᤨتᐬ爮䴰栲дᨶ8昺昼༾汀穂ᡄ㭆硈၊経扎桐๒⹔敖⑘❚潜ў兠乢兤㩦㉨孪䁬噮Ɒི䝴䉶≸䭺偼䩾\udc80ꪂ\ud984ꦆꂈ뺌릐좒ꖔ몖ꂘ욚쒞邠躢鲤益鮪肬隮쾲蒴覸隺蒼뫀룄믆﯈郊﷌軒軔胜ꏞ폠훢뻤ퟦ쓨\udeea냬웮헰", a_));
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.b = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("缠砢ᔤਦဨ横,甮倰Ḳ伴欶䨸ᄺሼ᰾湀杂橄慆晈湊扌敎繐獒穔ୖ瑘瑚癜灞习䱢㡤ᱦ奨䝪彬彮౰坲", a_));
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.c = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("缠砢ᔤਦဨ横,甮倰Ḳ伴欶䨸ᄺሼ᰾湀杂橄慆晈湊扌敎繐獒穔ୖ瑘瑚癜灞习䱢㡤ᱦ奨䝪彬彮౰坲", a_));
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.d = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("缠砢ᔤਦဨ横,甮倰Ḳ伴欶䨸ᄺሼ᰾湀杂橄慆晈湊扌敎繐獒穔ୖ瑘瑚癜灞习䱢㡤ᱦ奨䝪彬彮౰坲", a_));
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.e = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("稠ጢࠤḦ栨ت眬爮䨰ȲԴ䨶", a_));
		}

		// Token: 0x0400006F RID: 111
		private static readonly global::System.Text.RegularExpressions.Regex a;

		// Token: 0x04000070 RID: 112
		private static readonly global::System.Text.RegularExpressions.Regex b;

		// Token: 0x04000071 RID: 113
		private static readonly global::System.Text.RegularExpressions.Regex c;

		// Token: 0x04000072 RID: 114
		private static readonly global::System.Text.RegularExpressions.Regex d;

		// Token: 0x04000073 RID: 115
		private static readonly global::System.Text.RegularExpressions.Regex e;

		// Token: 0x04000074 RID: 116
		private static global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService f;

		// Token: 0x04000075 RID: 117
		private object g = new object();

		// Token: 0x0200004C RID: 76
		private class a : global::System.Collections.Generic.IEqualityComparer<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
		{
			// Token: 0x060002EA RID: 746 RVA: 0x0004A52C File Offset: 0x0004872C
			public bool Equals(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio1, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio2)
			{
				short num = (short)1052966912;
				short num2 = num;
				num = (short)1340058336;
				short num3 = num;
				num = (short)644328160;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)306249729;
					if (num != 0)
					{
					}
					num = (short)287178752;
					if (num != 0)
					{
					}
					if (radio1 != null)
					{
						return radio1.ModelNumber == radio2.ModelNumber;
					}
					break;
				}
				return radio2 == null;
			}

			// Token: 0x060002EB RID: 747 RVA: 0x0004A5F4 File Offset: 0x000487F4
			public int GetHashCode(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio)
			{
				short num = (short)397606912;
				short num2 = num;
				num = (short)810663612;
				short num3 = num;
				num = (short)536854204;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)392953856;
					if (num != 0)
					{
					}
					if (radio != null)
					{
						num = (short)1282408449;
						if (num != 0)
						{
						}
						return radio.ModelNumber.GetHashCode();
					}
					break;
				}
				return 0;
			}
		}

		// Token: 0x0200004E RID: 78
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x04000081 RID: 129
			public global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest a;
		}

		// Token: 0x0200004F RID: 79
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x060002FA RID: 762 RVA: 0x0004AED8 File Offset: 0x000490D8
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem A_0)
			{
				short num = (short)1747648512;
				short num2 = num;
				num = (short)1925386993;
				short num3 = num;
				num = (short)1991906033;
				switch (num3 == num)
				{
				}
				num = (short)1672478721;
				if (num != 0)
				{
				}
				num = (short)1732116480;
				if (num != 0)
				{
				}
				return A_0.Uuid.Equals(this.a.ID);
			}

			// Token: 0x04000082 RID: 130
			public global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem a;
		}

		// Token: 0x02000050 RID: 80
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class d
		{
			// Token: 0x060002FC RID: 764 RVA: 0x0004AFBC File Offset: 0x000491BC
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile A_0)
			{
				short num = (short)278986752;
				short num2 = num;
				num = (short)1768121393;
				short num3 = num;
				num = (short)284058673;
				switch (num3 == num)
				{
				}
				num = (short)233897985;
				if (num != 0)
				{
				}
				num = (short)1919614976;
				if (num != 0)
				{
				}
				return A_0.Uuid.Equals(this.a.AstroDataProfileID);
			}

			// Token: 0x04000083 RID: 131
			public global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile a;
		}

		// Token: 0x02000051 RID: 81
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class e
		{
			// Token: 0x060002FE RID: 766 RVA: 0x0004B090 File Offset: 0x00049290
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile A_0)
			{
				bool? independentList = A_0.IndependentList;
				bool flag = true;
				if (!(independentList.GetValueOrDefault() == flag & independentList != null))
				{
					short num = (short)1151533057;
					if (num != 0)
					{
					}
					num = (short)715220921;
					short num2 = num;
					num = (short)952788921;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2055995392;
						short num3 = num;
						num = (short)1293352960;
						if (num != 0)
						{
						}
						break;
					}
					}
					return !A_0.Profile.Equals(this.a.OtarProfileName);
				}
				return false;
			}

			// Token: 0x04000084 RID: 132
			public global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile a;
		}

		// Token: 0x02000052 RID: 82
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class f
		{
			// Token: 0x06000300 RID: 768 RVA: 0x0004B18C File Offset: 0x0004938C
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile A_0)
			{
				short num = (short)1387457369;
				short num2 = num;
				num = (short)940043097;
				switch (num2 == num)
				{
				}
				num = (short)1145372673;
				if (num != 0)
				{
				}
				num = (short)1804271616;
				if (num != 0)
				{
				}
				num = (short)140640256;
				short num3 = num;
				return A_0.Profile.Equals(this.a.OtarProfileName);
			}

			// Token: 0x04000085 RID: 133
			public global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile a;
		}

		// Token: 0x02000053 RID: 83
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class g
		{
			// Token: 0x06000302 RID: 770 RVA: 0x0004B260 File Offset: 0x00049460
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense A_0)
			{
				short num = (short)966229815;
				short num2 = num;
				num = (short)1268612919;
				switch (num2 == num)
				{
				}
				num = (short)931921921;
				if (num != 0)
				{
				}
				num = (short)1208942592;
				if (num != 0)
				{
				}
				num = (short)873398272;
				short num3 = num;
				return A_0.FeatureName == this.a;
			}

			// Token: 0x04000086 RID: 134
			public string a;
		}
	}
}
