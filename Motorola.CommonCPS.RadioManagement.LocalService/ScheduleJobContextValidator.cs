using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200003C RID: 60
	public class ScheduleJobContextValidator : global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate
	{
		// Token: 0x0600021C RID: 540 RVA: 0x00025B58 File Offset: 0x00023D58
		public virtual void Validate(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 7;
			short num = (short)143065088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9B;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext scheduleJobContext;
				string text;
				for (;;)
				{
					IL_30:
					bool flag;
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						goto IL_333;
					case 1:
						if (e == null)
						{
							num = (short)1083834374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)336265235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)418775063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("爠圢䐤唦崨横䬬嬮吰䄲焴嘶䴸帺", a_)))
						{
							num = (short)898236440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B7;
					case 4:
						if (!flag && flag2 && flag3)
						{
							num = (short)1185021952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2065170449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1522663437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					case 7:
					{
						global::System.Collections.Generic.Dictionary<string, string> dictionary;
						scheduleJobContext.EndBeforeDateError = (dictionary.ContainsKey(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搠䴢䄤攦䰨䴪䈬崮吰眲吴䌶尸縺似䴾⹀ㅂ", a_)) ? dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搠䴢䄤攦䰨䴪䈬崮吰眲吴䌶尸縺似䴾⹀ㅂ", a_)] : null);
						num = (short)108265473;
						if (num != 0)
						{
						}
						num = (short)303431694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搠䴢䄤攦䰨䴪䈬崮吰朲尴娶尸", a_)))
						{
							num = (short)1425539092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B7;
					case 9:
						goto IL_37F;
					case 10:
					{
						global::System.Collections.Generic.Dictionary<string, string> dictionary;
						scheduleJobContext.StartAfterTimeError = (dictionary.ContainsKey(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("爠圢䐤唦崨横䬬嬮吰䄲愴帶吸帺砼䴾㍀ⱂ㝄", a_)) ? dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("爠圢䐤唦崨横䬬嬮吰䄲愴帶吸帺砼䴾㍀ⱂ㝄", a_)] : null);
						num = (short)422117397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_2B7;
					case 12:
						num = (short)198115336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("爠䘢䤤䈦䨨弪䠬䬮攰娲場制挸吺匼娾ࡀⵂ⍄⡆", a_))
						{
							num = (short)336658443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
					{
						global::System.Collections.Generic.Dictionary<string, string> dictionary;
						scheduleJobContext.EndBeforeTimeError = (dictionary.ContainsKey(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搠䴢䄤攦䰨䴪䈬崮吰朲尴娶尸縺似䴾⹀ㅂ", a_)) ? dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搠䴢䄤攦䰨䴪䈬崮吰朲尴娶尸縺似䴾⹀ㅂ", a_)] : null);
						num = (short)69730326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (!this.a(scheduleJobContext.UtcStartDate, scheduleJobContext.UtcEndDate, out text))
						{
							num = (short)1182007305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						num = (short)119275527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (flag && flag2 && flag3)
						{
							num = (short)955711490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("爠圢䐤唦崨横䬬嬮吰䄲愴帶吸帺", a_)))
						{
							num = (short)1252458501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B7;
					case 19:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搠䴢䄤攦䰨䴪䈬崮吰眲吴䌶尸", a_)))
						{
							num = (short)428408844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B7;
					case 20:
						num = (short)1463156739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						return;
					case 22:
					{
						global::System.Collections.Generic.Dictionary<string, string> dictionary;
						scheduleJobContext.StartAfterDateError = (dictionary.ContainsKey(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("爠圢䐤唦崨横䬬嬮吰䄲焴嘶䴸帺砼䴾㍀ⱂ㝄", a_)) ? dictionary[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("爠圢䐤唦崨横䬬嬮吰䄲焴嘶䴸帺砼䴾㍀ⱂ㝄", a_)] : null);
						num = (short)2062942208;
						short num3 = num;
						num = (short)1520173066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						global::System.Collections.Generic.Dictionary<string, string> dictionary;
						if (!this.a(scheduleJobContext.UtcStartDate, scheduleJobContext.UtcEndDate, out dictionary))
						{
							num = (short)1084030992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 24:
					{
						num = (short)179798732;
						short num4 = num;
						num = (short)1301185228;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_333;
						default:
							num = (short)1948385280;
							if (num != 0)
							{
							}
							num = (short)606470162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_9B;
					IL_2B7:
					scheduleJobContext.CleanErrors();
					scheduleJobContext.UtcEndDate = null;
					scheduleJobContext.UtcStartDate = null;
					flag3 = false;
					flag2 = false;
					flag = this.a(scheduleJobContext);
					flag2 = this.b(scheduleJobContext);
					flag3 = this.c(scheduleJobContext);
					num = (short)990183428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_333:
					num = (short)1439563791;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_37F:
				scheduleJobContext.EndBeforeDateError = text;
				scheduleJobContext.StartAfterDateError = text;
				return;
				IL_9B:
				scheduleJobContext = (global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)uiModel;
				num = (short)775684097;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00026134 File Offset: 0x00024334
		private bool c(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext A_0)
		{
			int a_ = 17;
			short num = (short)1840316416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1040973825;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_AD;
				}
				bool result;
				for (;;)
				{
					IL_56:
					switch (num2)
					{
					case 0:
					{
						bool flag;
						if (flag)
						{
							num = (short)333905932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2122186767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (!string.IsNullOrEmpty(A_0.EndBeforeDate))
						{
							num = (short)347340814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						return result;
					case 3:
						goto IL_26F;
					case 4:
						num = (short)1409089544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (string.IsNullOrEmpty(A_0.EndBeforeTime))
						{
							num = (short)882835465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					case 6:
						return result;
					case 7:
					{
						global::System.DateTime? dateTime;
						string text;
						if (!this.a(dateTime, A_0.SelectedTimeZoneInfo, out text))
						{
							num = (short)573243396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 8:
					{
						if (string.IsNullOrEmpty(A_0.EndBeforeTime))
						{
							num = (short)1030684690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text;
						A_0.EndBeforeDateError = text;
						A_0.EndBeforeTimeError = text;
						num = (short)693174275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						A_0.EndBeforeDateError = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("漪䰬嬮吰ጲ匴堶䬸嘺尼䬾慀♂㝄㕆♈㥊", a_);
						num = (short)1192165387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_41B;
					case 11:
						goto IL_41B;
					case 12:
						num = (short)1040318469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						return result;
					case 14:
					{
						num = (short)1522710551;
						short num3 = num;
						num = (short)1498462231;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_28F;
						default:
						{
							num = (short)13697024;
							if (num != 0)
							{
							}
							global::System.DateTime? dateTime = null;
							bool flag = false;
							num = (short)1727660049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 15:
					{
						global::System.DateTime? dateTime;
						if (dateTime == null)
						{
							num = (short)57081872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1096351751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						num = (short)1395654656;
						short num4 = num;
						goto IL_23A;
					}
					case 17:
						try
						{
							global::System.DateTime? dateTime = this.a(A_0.EndBeforeDate, A_0.EndBeforeTime, A_0.SelectedTimeZoneInfo);
							A_0.UtcEndDate = dateTime;
							goto IL_2D6;
						}
						catch (global::System.FormatException)
						{
							bool flag = true;
							goto IL_2D6;
						}
						goto IL_23A;
						IL_2D6:
						num = (short)2011299840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						string text;
						A_0.EndBeforeDateError = text;
						num = (short)63504403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_26F;
					}
					goto IL_AD;
					IL_23A:
					A_0.EndBeforeDateError = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_InvalidTimeInTimeZone;
					A_0.EndBeforeTimeError = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_InvalidTimeInTimeZone;
					result = false;
					num = (short)568655874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26F:
					result = false;
					num = (short)357629958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28F:
					A_0.EndBeforeDateError = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("漪䰬嬮吰ጲ匴堶䬸嘺尼䬾慀♂㝄㕆♈㥊", a_);
					A_0.EndBeforeTimeError = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("缪䐬䈮吰ጲ匴堶䬸嘺尼䬾慀♂㝄㕆♈㥊", a_);
					num = (short)884342794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41B:
					result = false;
					num = (short)1813446669;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_AD:
				result = true;
				num = (short)1903689729;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0002658C File Offset: 0x0002478C
		private bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext A_0)
		{
			int a_ = 12;
			short num = (short)1191444480;
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
					switch (num2)
					{
					case 0:
					{
						bool flag;
						if (flag)
						{
							num = (short)130613260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1323499535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (!string.IsNullOrEmpty(A_0.StartAfterDate))
						{
							num = (short)498860046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						return result;
					case 3:
						goto IL_273;
					case 4:
						num = (short)406192136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (string.IsNullOrEmpty(A_0.StartAfterTime))
						{
							num = (short)1106903049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_292;
					case 6:
						return result;
					case 7:
					{
						global::System.DateTime? dateTime;
						string text;
						if (!this.b(dateTime, A_0.SelectedTimeZoneInfo, out text))
						{
							num = (short)2052325380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 8:
					{
						if (string.IsNullOrEmpty(A_0.StartAfterTime))
						{
							num = (short)1855324178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text;
						A_0.StartAfterDateError = text;
						A_0.StartAfterTimeError = text;
						num = (short)1347354627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						A_0.StartAfterDateError = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("戥䤧帩䤫อ嘯崱䘳嬵夷丹᰻嬽㈿ぁ⭃㑅", a_);
						num = (short)1248854027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_419;
					case 11:
						goto IL_419;
					case 12:
						num = (short)1676345349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						return result;
					case 14:
					{
						num = (short)1955397633;
						if (num != 0)
						{
						}
						num = (short)324661209;
						short num3 = num;
						num = (short)1707077593;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_292;
						default:
						{
							num = (short)1763770368;
							if (num != 0)
							{
							}
							global::System.DateTime? dateTime = null;
							bool flag = false;
							num = (short)1031667729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 15:
					{
						global::System.DateTime? dateTime;
						if (dateTime == null)
						{
							num = (short)635174928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2018312199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						num = (short)649986048;
						short num4 = num;
						goto IL_23D;
					}
					case 17:
						try
						{
							global::System.DateTime? dateTime = this.a(A_0.StartAfterDate, A_0.StartAfterTime, A_0.SelectedTimeZoneInfo);
							A_0.UtcStartDate = dateTime;
							goto IL_2D8;
						}
						catch (global::System.FormatException)
						{
							bool flag = true;
							goto IL_2D8;
						}
						goto IL_23D;
						IL_2D8:
						num = (short)1594490880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						string text;
						A_0.StartAfterDateError = text;
						num = (short)1321336851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_273;
					}
					goto IL_87;
					IL_23D:
					A_0.StartAfterDateError = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_InvalidTimeInTimeZone;
					A_0.StartAfterTimeError = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_InvalidTimeInTimeZone;
					result = false;
					num = (short)659161090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_273:
					result = false;
					num = (short)1641086982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_292:
					A_0.StartAfterDateError = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("戥䤧帩䤫อ嘯崱䘳嬵夷丹᰻嬽㈿ぁ⭃㑅", a_);
					A_0.StartAfterTimeError = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("爥䄧䜩䤫อ嘯崱䘳嬵夷丹᰻嬽㈿ぁ⭃㑅", a_);
					num = (short)1281490954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_419:
					result = false;
					num = (short)1455161357;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_87:
				result = true;
				num = (short)266797057;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000269E0 File Offset: 0x00024BE0
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext A_0)
		{
			short num;
			bool result;
			for (;;)
			{
				num = (short)1083375617;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_86;
				}
				int num2;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						num = (short)863436802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (string.IsNullOrEmpty(A_0.EndBeforeTime))
						{
							num = (short)388431887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_376;
					case 2:
						if (!string.IsNullOrEmpty(A_0.EndBeforeTime))
						{
							num = (short)783089672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_213;
					case 3:
						if (string.IsNullOrEmpty(A_0.StartAfterDate))
						{
							num = (short)122683406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AB;
					case 4:
						if (string.IsNullOrEmpty(A_0.StartAfterTime))
						{
							num = (short)1447362570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F4;
					case 5:
						goto IL_F4;
					case 6:
						num = (short)733478916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!string.IsNullOrEmpty(A_0.EndBeforeDate))
						{
							num = (short)1932656652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_376;
					case 8:
						A_0.EndBeforeDateError = global::Motorola.CommonCPS.ResourceRepository.Resources.EndBeforeDateError;
						result = false;
						num = (short)1469251601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (string.IsNullOrEmpty(A_0.EndBeforeDate))
						{
							num = (short)1983905792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_213;
					case 10:
						A_0.StartAfterTimeError = global::Motorola.CommonCPS.ResourceRepository.Resources.StartAfterTimeError;
						result = false;
						num = (short)1411186707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (!string.IsNullOrEmpty(A_0.StartAfterDate))
						{
							num = (short)2110324742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F4;
					case 12:
						num = (short)1167392769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (!string.IsNullOrEmpty(A_0.StartAfterTime))
						{
							num = (short)1436483602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AB;
					case 14:
						num = (short)1976696845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						A_0.EndBeforeTimeError = global::Motorola.CommonCPS.ResourceRepository.Resources.EndBeforeTimeError;
						result = false;
						num = (short)121307152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_27C;
					case 17:
						goto IL_EF;
					case 18:
					{
						A_0.StartAfterDateError = global::Motorola.CommonCPS.ResourceRepository.Resources.StartAfterDateError;
						result = false;
						num = (short)930217984;
						short num3 = num;
						num = (short)700907525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_F4;
					}
					goto IL_86;
					IL_F4:
					num = (short)852557833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_213:
					num = (short)1417674759;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AB:
					num = (short)977076235;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_376:
				num = (short)1620518388;
				short num4 = num;
				num = (short)116073972;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_3AB;
				}
				IL_EF:
				IL_27C:
				goto IL_376;
				IL_86:
				result = true;
				num = (short)559546371;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			IL_3AB:
			num = (short)932184064;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00026DB0 File Offset: 0x00024FB0
		private global::System.DateTime? a(string A_0, string A_1, global::System.TimeZoneInfo A_2)
		{
			int a_ = 1;
			global::System.DateTime? result;
			for (;;)
			{
				IL_09:
				short num = (short)1588658176;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					string text;
					string text2;
					for (;;)
					{
						IL_31:
						global::System.Globalization.CultureInfo currentCulture;
						switch (num2)
						{
						case 0:
						{
							global::System.DateTime dateTime;
							if (!A_2.IsInvalidTime(dateTime))
							{
								num = (short)1848573952;
								short num3 = num;
								num = (short)2028208134;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						case 1:
							goto IL_146;
						case 2:
							num = (short)811728899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (!string.IsNullOrEmpty(text))
							{
								num = (short)272760836;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 4:
						{
							global::System.DateTime dateTime = global::System.DateTime.Parse(A_0 + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("㬚", a_) + text, currentCulture, global::System.Globalization.DateTimeStyles.NoCurrentDateDefault);
							num = (short)1026555904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							if (string.IsNullOrEmpty(A_1))
							{
								num = (short)1659240456;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = A_1;
							num = (short)1203237669;
							short num4 = num;
							num = (short)724955941;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)1511260160;
								if (num != 0)
								{
								}
								num = (short)42860545;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
						{
							global::System.DateTime dateTime;
							result = new global::System.DateTime?(global::System.TimeZoneInfo.ConvertTimeToUtc(dateTime, A_2));
							num = (short)1440677898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_146;
						case 8:
							num = (short)1241972737;
							if (num != 0)
							{
							}
							text = text2;
							num = (short)1129054215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (!string.IsNullOrEmpty(A_0))
							{
								num = (short)1461780482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 10:
							return result;
						}
						break;
						IL_146:
						currentCulture = global::System.Threading.Thread.CurrentThread.CurrentCulture;
						num = (short)1572536329;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_64:
					result = null;
					text2 = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("⤚⸜┞ᐠᨢ", a_);
					text = null;
					num = (short)612892677;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			return result;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00027070 File Offset: 0x00025270
		private bool a(global::System.DateTime? A_0, global::System.DateTime? A_1, out string A_2)
		{
			bool result;
			for (;;)
			{
				IL_00:
				short num = (short)457375744;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					for (;;)
					{
						IL_27:
						bool flag;
						switch (num2)
						{
						case 0:
						{
							num = (short)1828355027;
							short num3 = num;
							num = (short)574258131;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1281359872;
								if (num != 0)
								{
								}
								A_2 = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_EndDateFollowStartDate;
								result = false;
								num = (short)459603976;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							global::System.DateTime? dateTime;
							global::System.DateTime? dateTime2;
							if (!(dateTime != null & dateTime2 != null))
							{
								num = (short)1190330373;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1606549506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::System.DateTime? dateTime;
							global::System.DateTime? dateTime2;
							flag = (dateTime.GetValueOrDefault() < dateTime2.GetValueOrDefault());
							goto IL_205;
						}
						case 3:
						{
							global::System.DateTime dateTime3 = A_0.Value;
							dateTime3 = dateTime3.Date;
							num = (short)913375236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.DateTime dateTime3;
							if (!dateTime3.Equals(A_1.Value.Date))
							{
								num = (short)454492170;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						case 5:
							num = (short)612499463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (A_0 != null)
							{
								num = (short)1547567113;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 7:
						{
							num = (short)687865856;
							short num4 = num;
							flag = false;
							goto IL_205;
						}
						case 8:
							return result;
						case 9:
							num = (short)765591563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							num = (short)1351024641;
							if (num != 0)
							{
							}
							global::System.DateTime? dateTime = A_1;
							global::System.DateTime? dateTime2 = A_0;
							num = (short)1224736769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							if (A_1 != null)
							{
								num = (short)1079836675;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						break;
						IL_205:
						if (!flag)
						{
							return result;
						}
						num = (short)817496064;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5E:
					result = true;
					A_2 = null;
					num = (short)661323782;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
			}
			return result;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00027340 File Offset: 0x00025540
		private bool b(global::System.DateTime? A_0, global::System.TimeZoneInfo A_1, out string A_2)
		{
			short num = (short)157614080;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1243283456;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				bool result;
				global::System.DateTime dateTime2;
				for (;;)
				{
					IL_50:
					bool flag;
					switch (num2)
					{
					case 0:
						return result;
					case 1:
					{
						global::System.DateTime? dateTime;
						if (dateTime == null)
						{
							num = (short)1821573127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1966997508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						A_2 = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_StartDateTimePassed;
						result = false;
						num = (short)1424097280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.DateTime? dateTime = A_0;
						global::System.DateTime t = dateTime2;
						num = (short)639893505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.DateTime? dateTime;
						global::System.DateTime t;
						flag = (dateTime.GetValueOrDefault() < t);
						goto IL_1E9;
					}
					case 5:
					{
						if (A_0 == null)
						{
							return result;
						}
						num = (short)505748170;
						short num4 = num;
						num = (short)1778260682;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_153;
						default:
							num = (short)63438848;
							if (num != 0)
							{
							}
							num = (short)262668291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_153;
					case 7:
						num = (short)980353030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_77;
					IL_1E9:
					if (flag)
					{
						num = (short)776667138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_153:
					num = (short)173277185;
					if (num != 0)
					{
					}
					flag = false;
					goto IL_1E9;
				}
				return result;
				IL_77:
				result = true;
				A_2 = null;
				dateTime2 = global::System.TimeZoneInfo.ConvertTimeToUtc(global::System.TimeZoneInfo.ConvertTime(global::System.DateTime.Now, A_1), A_1);
				num = (short)1552351237;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00027558 File Offset: 0x00025758
		private bool a(global::System.DateTime? A_0, global::System.TimeZoneInfo A_1, out string A_2)
		{
			short num = (short)1473052672;
			short num2 = num;
			num = (short)1374027776;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				bool result;
				global::System.DateTime dateTime2;
				for (;;)
				{
					IL_50:
					global::System.TimeSpan value;
					global::System.TimeSpan? timeSpan;
					global::System.TimeSpan? timeSpan2;
					switch (num3)
					{
					case 0:
						if (value.TotalHours < 1.0)
						{
							num = (short)1207042049;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						A_2 = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_LastingIntervalRule;
						result = false;
						num = (short)778174468;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1066467329;
						if (num != 0)
						{
						}
						global::System.DateTime? dateTime;
						global::System.DateTime d;
						timeSpan = new global::System.TimeSpan?(dateTime.GetValueOrDefault() - d);
						goto IL_1FD;
					}
					case 3:
						if (A_0 != null)
						{
							goto IL_B4;
						}
						return result;
					case 4:
						return result;
					case 5:
					{
						num = (short)176954846;
						short num4 = num;
						num = (short)254352862;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B4;
						default:
						{
							num = (short)1073807360;
							if (num != 0)
							{
							}
							global::System.DateTime? dateTime;
							if (dateTime == null)
							{
								num = (short)861929480;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1844117506;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 6:
					{
						global::System.DateTime? dateTime = A_0;
						global::System.DateTime d = dateTime2;
						num = (short)1320353797;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						timeSpan = timeSpan2;
						goto IL_1FD;
					case 8:
						timeSpan2 = null;
						num = (short)1239482375;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
					IL_B4:
					num = (short)2027880454;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FD:
					timeSpan2 = timeSpan;
					value = timeSpan2.Value;
					num = (short)1820459008;
					num3 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_7B:
				result = true;
				A_2 = null;
				dateTime2 = global::System.TimeZoneInfo.ConvertTimeToUtc(global::System.TimeZoneInfo.ConvertTime(global::System.DateTime.Now, A_1), A_1);
				num = (short)1150287875;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000277B8 File Offset: 0x000259B8
		private bool a(global::System.DateTime? A_0, global::System.DateTime? A_1, out global::System.Collections.Generic.Dictionary<string, string> A_2)
		{
			int a_ = 10;
			short num = (short)582483968;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B8;
				}
				bool result;
				for (;;)
				{
					IL_31:
					global::System.DateTime? dateTime;
					global::System.DateTime? dateTime2;
					bool flag;
					bool flag2;
					global::System.TimeSpan? timeSpan;
					global::System.TimeSpan value;
					global::System.TimeSpan? timeSpan2;
					switch (num2)
					{
					case 0:
						dateTime = A_1;
						dateTime2 = A_0;
						num = (short)340459524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return result;
					case 2:
					{
						num = (short)2090860544;
						short num3 = num;
						num = (short)796393480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (A_1 == null)
						{
							num = (short)1471545369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_259;
					case 4:
						if (!(dateTime != null & dateTime2 != null))
						{
							num = (short)1794965515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)955514897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						flag = (dateTime2.GetValueOrDefault() > dateTime.GetValueOrDefault());
						goto IL_6EA;
					case 6:
						A_2.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("愣䠥䰧栩䤫䠭弯䀱儳爵夷丹夻笽㈿ぁ⭃㑅", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ScheduleIntervalRule);
						A_2.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("愣䠥䰧栩䤫䠭弯䀱儳戵儷圹夻笽㈿ぁ⭃㑅", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ScheduleIntervalRule);
						A_2.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("眣別䤧堩堫漭嘯䘱儳䐵氷匹儻嬽Կぁ㙃⥅㩇", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ScheduleIntervalRule);
						A_2.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("眣別䤧堩堫漭嘯䘱儳䐵簷嬹䠻嬽Կぁ㙃⥅㩇", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ScheduleIntervalRule);
						result = false;
						num = (short)639959066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1149829147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)1174467969;
						short num4 = num;
						num = (short)2138568065;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							num = (short)828309504;
							if (num != 0)
							{
							}
							flag2 = false;
							goto IL_451;
						}
						break;
					}
					case 9:
						num = (short)1611071498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)77266945;
						if (num != 0)
						{
						}
						if (A_1 != null)
						{
							num = (short)1070792733;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 11:
						timeSpan = null;
						num = (short)1962737695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						flag = false;
						goto IL_6EA;
					case 13:
						if (value.TotalHours < 1.0)
						{
							num = (short)218562566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 14:
						A_2.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("愣䠥䰧栩䤫䠭弯䀱儳爵夷丹夻笽㈿ぁ⭃㑅", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_EndDateTimeFollowStartDateTime);
						A_2.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("愣䠥䰧栩䤫䠭弯䀱儳戵儷圹夻笽㈿ぁ⭃㑅", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_EndDateTimeFollowStartDateTime);
						A_2.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("眣別䤧堩堫漭嘯䘱儳䐵氷匹儻嬽Կぁ㙃⥅㩇", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_EndDateTimeFollowStartDateTime);
						A_2.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("眣別䤧堩堫漭嘯䘱儳䐵簷嬹䠻嬽Կぁ㙃⥅㩇", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_EndDateTimeFollowStartDateTime);
						result = false;
						num = (short)1181483028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1347026947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						flag2 = (dateTime.GetValueOrDefault() <= dateTime2.GetValueOrDefault());
						goto IL_451;
					case 17:
						timeSpan2 = new global::System.TimeSpan?(dateTime.GetValueOrDefault() - dateTime2.GetValueOrDefault());
						goto IL_473;
					case 18:
						A_2.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("眣別䤧堩堫漭嘯䘱儳䐵氷匹儻嬽Կぁ㙃⥅㩇", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Must_Provide_StartDateTime);
						A_2.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("眣別䤧堩堫漭嘯䘱儳䐵簷嬹䠻嬽Կぁ㙃⥅㩇", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Must_Provide_StartDateTime);
						result = false;
						num = (short)231276567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (A_0 != null)
						{
							num = (short)1428815881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 20:
						return result;
					case 21:
						num = (short)515440652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (!(dateTime != null & dateTime2 != null))
						{
							num = (short)1114243074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1258356752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_4C9;
					case 24:
						if (A_0 == null)
						{
							num = (short)1263075335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C9;
					case 25:
						A_2.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("愣䠥䰧栩䤫䠭弯䀱儳爵夷丹夻笽㈿ぁ⭃㑅", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Must_Provide_EndDateTime);
						A_2.Add(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("愣䠥䰧栩䤫䠭弯䀱儳戵儷圹夻笽㈿ぁ⭃㑅", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Must_Provide_EndDateTime);
						result = false;
						num = (short)6225921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						return result;
					case 27:
						if (A_1 != null)
						{
							num = (short)1625554962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C9;
					case 28:
						if (A_0 != null)
						{
							num = (short)307953679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_259;
					case 29:
						dateTime = A_1;
						dateTime2 = A_0;
						num = (short)1385627670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (!(dateTime2 != null & dateTime != null))
						{
							num = (short)1803747349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)794165253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						timeSpan2 = timeSpan;
						goto IL_473;
					}
					goto IL_B8;
					IL_259:
					num = (short)689373203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_451:
					if (flag2)
					{
						num = (short)2062417934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					dateTime2 = A_1;
					dateTime = A_0;
					num = (short)35192862;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_473:
					timeSpan = timeSpan2;
					value = timeSpan.Value;
					num = (short)2054553613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C9:
					num = (short)967114780;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6EA:
					if (!flag)
					{
						break;
					}
					num = (short)1173815296;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_B8:
				result = true;
				A_2 = new global::System.Collections.Generic.Dictionary<string, string>();
				num = (short)1076625432;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}
	}
}
