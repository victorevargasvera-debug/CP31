using System;
using System.Globalization;
using System.Text;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Comparers;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x02000015 RID: 21
	public static class LogUtil
	{
		// Token: 0x0600006A RID: 106 RVA: 0x000096F4 File Offset: 0x000078F4
		public static string GenLogEveArgs(string message, global::System.Exception exp, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel logLevel = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			short num2;
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					if (exp != null)
					{
						num2 = (short)566362113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_176;
				case 1:
					stringBuilder.Append(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogUtil.a(exp));
					num2 = (short)107020290;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_174;
				}
				goto IL_25;
			}
			IL_174:
			IL_176:
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			return stringBuilder.ToString();
			IL_25:
			stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine();
			stringBuilder.Append(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ౖ", a_) + logLevel.ToString() + global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("੖", a_));
			stringBuilder.Append(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogUtil.a());
			stringBuilder.Append(message);
			num2 = (short)343391230;
			short num3 = num2;
			num2 = (short)813087742;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_13;
			default:
			{
				num2 = (short)486604800;
				short num4 = num2;
				num2 = (short)1390018560;
				if (num2 != 0)
				{
				}
				num2 = (short)1612316673;
				if (num2 != 0)
				{
				}
				num2 = (short)975175680;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000988C File Offset: 0x00007A8C
		private static string a()
		{
			int a_ = 3;
			short num = (short)2085224449;
			if (num != 0)
			{
			}
			num = (short)142475264;
			short num2 = num;
			num = (short)1775712282;
			short num3 = num;
			num = (short)1977038874;
			switch (num3 == num)
			{
			}
			num = (short)1306066944;
			if (num != 0)
			{
			}
			global::System.DateTime now = global::System.DateTime.Now;
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ⱖ楘♚灜⑞偠奢Ⅴ啦ᑨ䙪ᙬ嵮䭰㝲䝴੶奸z乼䕾얀놂붆뾊람쮎ꎐ꾔겘ꆚ\ud99c궞\udca0莢\udea4醦鎨麬튮醰鎲", a_), new object[]
			{
				now.Year,
				now.Month,
				now.Day,
				now.Hour,
				now.Minute,
				now.Second,
				now.Millisecond
			});
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000099D0 File Offset: 0x00007BD0
		private static string a(global::System.Exception A_0)
		{
			int a_ = 10;
			short num = (short)1319960578;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5B;
				case 1:
					goto IL_D4;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 3:
				{
					num = (short)1351942144;
					short num3 = num;
					if (A_0.InnerException != null)
					{
						num = (short)894566404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_211;
				}
				case 4:
				{
					num = (short)343229646;
					short num4 = num;
					num = (short)514933966;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2146041856;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)1299972097;
					if (num != 0)
					{
					}
					stringBuilder.AppendLine();
					stringBuilder.Append(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("᝝๟ౡţᑥⵧቩཫ୭oٱᵳ᥵ᙷ", a_));
					stringBuilder.AppendLine();
					stringBuilder.Append(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogUtil.a(A_0.InnerException));
					num = (short)1363345409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_41:
				if (A_0 == null)
				{
					num = (short)1177616384;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					stringBuilder = new global::System.Text.StringBuilder();
					stringBuilder.AppendLine();
					stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("᭝ᡟšţᙥᱧͩͫm䩯剱ཱི䙵շ灹", a_), A_0.GetType());
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogUtil.a(stringBuilder, A_0);
					stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("፝՟ᅡᝣݥཧཀྵ噫乭୯䉱ॳ籵", a_), A_0.Message);
					stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("൝ཟᝡᙣե൧偩䱫ᕭ䁯ཱ繳", a_), A_0.Source);
					stringBuilder.Append(A_0.StackTrace);
					num = (short)809631747;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5B:
			return string.Empty;
			IL_D4:
			IL_211:
			return stringBuilder.ToString();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00009BF4 File Offset: 0x00007DF4
		public static global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel ConvertLoggingLevelToLogLevel(global::Motorola.Common.LogUtility.LoggingLevel loggingLevel)
		{
			short num = (short)1767796078;
			short num2 = num;
			num = (short)1957719406;
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1835270144;
				short num3 = num;
				num = (short)871497729;
				if (num != 0)
				{
				}
				num = (short)1879965696;
				if (num != 0)
				{
				}
				result = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Info;
				try
				{
					num = (short)901578756;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_1B4;
						case 1:
							goto IL_1B4;
						case 2:
							goto IL_1B4;
						case 3:
							goto IL_1B4;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_E5;
							}
							continue;
						case 5:
							num = (short)461963266;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_1B4;
						case 7:
							goto IL_1CC;
						}
						IL_E5:
						switch (loggingLevel)
						{
						case global::Motorola.Common.LogUtility.LoggingLevel.Unknown:
						case global::Motorola.Common.LogUtility.LoggingLevel.UserOperation:
						case global::Motorola.Common.LogUtility.LoggingLevel.Performance:
						case global::Motorola.Common.LogUtility.LoggingLevel.EventInfo:
							result = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Info;
							num = (short)626065408;
							num4 = (int)((global::System.IntPtr)num);
							break;
						case global::Motorola.Common.LogUtility.LoggingLevel.EventDetail:
						case global::Motorola.Common.LogUtility.LoggingLevel.Info:
							IL_1B4:
							num = (short)1081802759;
							num4 = (int)((global::System.IntPtr)num);
							break;
						case global::Motorola.Common.LogUtility.LoggingLevel.EventWarning:
							result = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Warning;
							num = (short)885260291;
							num4 = (int)((global::System.IntPtr)num);
							break;
						case global::Motorola.Common.LogUtility.LoggingLevel.EventError:
						case global::Motorola.Common.LogUtility.LoggingLevel.Error:
							result = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error;
							num = (short)1670381574;
							num4 = (int)((global::System.IntPtr)num);
							break;
						case global::Motorola.Common.LogUtility.LoggingLevel.Debug:
							result = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Trace;
							num = (short)895483905;
							num4 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)1044447237;
							num4 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_1CC:;
				}
				catch
				{
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00009DF0 File Offset: 0x00007FF0
		private static void a(global::System.Text.StringBuilder A_0, global::System.Exception A_1)
		{
			int a_ = 5;
			global::Motorola.Common.CustomException.CommonException ex;
			short num;
			for (;;)
			{
				ex = (A_1 as global::Motorola.Common.CustomException.CommonException);
				if (ex == null)
				{
					num = (short)1382838818;
					short num2 = num;
					num = (short)1433498146;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_74;
					}
					break;
				}
				goto IL_B5;
			}
			num = (short)231211008;
			short num3 = num;
			IL_74:
			num = (short)1440808960;
			if (num != 0)
			{
			}
			num = (short)1682636801;
			if (num != 0)
			{
			}
			return;
			IL_B5:
			A_0.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("᱘⥚⽜ぞ፠⁢੤ͦ౨兪䵬ᑮ䅰๲罴", a_), ex.ErrorCode);
		}
	}
}
