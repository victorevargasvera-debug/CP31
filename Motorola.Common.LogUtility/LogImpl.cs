using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Motorola.Common.LogUtility.PerformanceMeasurement;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000014 RID: 20
	public class LogImpl : global::Motorola.Common.LogUtility.ILog
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x0000CD3C File Offset: 0x0000AF3C
		public void Debug(string message)
		{
			short num = (short)166920192;
			short num2 = num;
			num = (short)1902175091;
			short num3 = num;
			num = (short)1384309619;
			switch (num3 == num)
			{
			}
			num = (short)1688600576;
			if (num != 0)
			{
			}
			num = (short)1367080961;
			if (num != 0)
			{
			}
			this.DebugEx(string.Empty, message, null);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		public void Debug(string format, params object[] message)
		{
			short num = (short)1731395584;
			short num2 = num;
			num = (short)186898860;
			short num3 = num;
			num = (short)1131993516;
			switch (num3 == num)
			{
			}
			num = (short)1531445249;
			if (num != 0)
			{
			}
			num = (short)248840192;
			if (num != 0)
			{
			}
			this.DebugEx(string.Empty, format, message);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000CEB0 File Offset: 0x0000B0B0
		public void DebugEx(string logFileSuffix, string format, params object[] message)
		{
			short num = (short)167764173;
			short num2 = num;
			num = (short)2067194061;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_CE:
				if (this.c <= global::Motorola.Common.LogUtility.LoggingLevel.Debug)
				{
					goto IL_1DF;
				}
				num = (short)2104098817;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)462422016;
				short num4 = num;
				goto IL_5E;
			}
			}
			for (;;)
			{
				IL_BC:
				switch (num3)
				{
				case 0:
					num = (short)43122689;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_CE;
					}
					continue;
				case 1:
					return;
				case 2:
					goto IL_1F8;
				}
				goto IL_CE;
			}
			return;
			IL_1F8:
			try
			{
				switch (0)
				{
				case 0:
					goto IL_11C;
				}
				string message2;
				for (;;)
				{
					IL_FE:
					switch (num3)
					{
					case 0:
						if (message != null)
						{
							num = (short)1203437569;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A3;
					case 1:
						num = (short)2041774084;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1A3;
					case 3:
						message2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, message);
						num = (short)1833041922;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (message.Length != 0)
						{
							num = (short)785514499;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A3;
					case 5:
						goto IL_1D6;
					}
					goto IL_11C;
					IL_1A3:
					global::Motorola.Common.LogUtility.LoggingEventArgs a_ = new global::Motorola.Common.LogUtility.LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel.Debug, global::System.DateTime.Now, message2)
					{
						FileNameSuffix = logFileSuffix
					};
					this.a(a_);
					num = (short)401276933;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1D6:
				return;
				IL_11C:
				message2 = format;
				num = (short)1039335424;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_FE;
			}
			catch (global::System.Exception e)
			{
				global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e);
				return;
			}
			goto IL_1DF;
			IL_5E:
			num = (short)62128128;
			if (num != 0)
			{
			}
			num = (short)1173225472;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_BC;
			IL_1DF:
			num = (short)1678704642;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_BC;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000D0CC File Offset: 0x0000B2CC
		public void Error(string message)
		{
			short num = (short)2055536640;
			short num2 = num;
			num = (short)776859420;
			short num3 = num;
			num = (short)1327689500;
			switch (num3 == num)
			{
			}
			num = (short)41943041;
			if (num != 0)
			{
			}
			num = (short)270336000;
			if (num != 0)
			{
			}
			this.ErrorEx(string.Empty, message, null);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000D184 File Offset: 0x0000B384
		public void Error(string format, params object[] message)
		{
			short num = (short)233832448;
			short num2 = num;
			num = (short)1948982596;
			short num3 = num;
			num = (short)802299204;
			switch (num3 == num)
			{
			}
			num = (short)1440022528;
			if (num != 0)
			{
			}
			num = (short)1389494273;
			if (num != 0)
			{
			}
			this.ErrorEx(string.Empty, format, message);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000D23C File Offset: 0x0000B43C
		public void ErrorEx(string logFileSuffix, string format, params object[] message)
		{
			short num = (short)483023703;
			short num2 = num;
			num = (short)1011112791;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A5:
				num = (short)720961537;
				if (num != 0)
				{
				}
				if (this.c <= global::Motorola.Common.LogUtility.LoggingLevel.Error)
				{
					goto IL_1DC;
				}
				num = (short)1297743873;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)469368832;
				short num4 = num;
				goto IL_5F;
			}
			}
			for (;;)
			{
				IL_93:
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					continue;
				case 1:
					return;
				case 2:
					goto IL_1F6;
				}
				goto IL_A5;
			}
			return;
			IL_1F6:
			try
			{
				switch (0)
				{
				case 0:
					goto IL_119;
				}
				string message2;
				for (;;)
				{
					IL_FB:
					switch (num3)
					{
					case 0:
						if (message != null)
						{
							num = (short)1445527553;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19F;
					case 1:
						num = (short)1260126212;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_19F;
					case 3:
						message2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, message);
						num = (short)523698178;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (message.Length != 0)
						{
							num = (short)1194786819;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19F;
					case 5:
						goto IL_1D3;
					}
					goto IL_119;
					IL_19F:
					global::Motorola.Common.LogUtility.LoggingEventArgs a_ = new global::Motorola.Common.LogUtility.LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel.Error, global::System.DateTime.Now, message2)
					{
						FileNameSuffix = logFileSuffix
					};
					this.a(a_);
					num = (short)691929093;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1D3:
				return;
				IL_119:
				message2 = format;
				num = (short)683343872;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_FB;
			}
			catch (global::System.Exception e)
			{
				global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e);
				return;
			}
			goto IL_1DC;
			IL_5F:
			num = (short)574947328;
			if (num != 0)
			{
			}
			num = (short)1362231296;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_93;
			IL_1DC:
			num = (short)1571160066;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_93;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000D458 File Offset: 0x0000B658
		public void Error(global::System.Exception e, string message = null)
		{
			short num = (short)976814080;
			short num2 = num;
			num = (short)1829247149;
			short num3 = num;
			num = (short)546117805;
			switch (num3 == num)
			{
			}
			num = (short)1867841537;
			if (num != 0)
			{
			}
			num = (short)1591214080;
			if (num != 0)
			{
			}
			this.ErrorEx(e, string.Empty, message, null);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000D510 File Offset: 0x0000B710
		public void Error(global::System.Exception e, string format, params object[] message)
		{
			short num = (short)1998913536;
			short num2 = num;
			num = (short)342877100;
			short num3 = num;
			num = (short)811852716;
			switch (num3 == num)
			{
			}
			num = (short)170196993;
			if (num != 0)
			{
			}
			num = (short)1536819200;
			if (num != 0)
			{
			}
			this.ErrorEx(e, string.Empty, format, message);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000D5C8 File Offset: 0x0000B7C8
		public void ErrorEx(global::System.Exception e, string logFileSuffix, string format, params object[] message)
		{
			short num = (short)1212678144;
			short num2 = num;
			num = (short)1065156610;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
					num = (short)1077477377;
					if (num != 0)
					{
					}
					try
					{
						num = (short)1862502831;
						short num4 = num;
						num = (short)613386671;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_125:
							num = (short)1074266112;
							num3 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)1193082880;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_F4;
							}
							break;
						}
						string message2;
						for (;;)
						{
							IL_D6:
							switch (num3)
							{
							case 0:
								if (message.Length != 0)
								{
									num = (short)1583611905;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17D;
							case 1:
								message2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, message);
								num = (short)869007362;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_17D;
							case 3:
								if (message != null)
								{
									num = (short)1151533061;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17D;
							case 4:
								goto IL_1B3;
							case 5:
								goto IL_123;
							}
							goto IL_F4;
							IL_17D:
							global::Motorola.Common.LogUtility.LoggingEventArgs a_ = new global::Motorola.Common.LogUtility.LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel.Error, global::System.DateTime.Now, message2, e)
							{
								FileNameSuffix = logFileSuffix
							};
							this.a(a_);
							num = (short)582287364;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_123:
						goto IL_125;
						IL_1B3:
						return;
						IL_F4:
						message2 = format;
						num = (short)1072627715;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_D6;
					}
					catch (global::System.Exception e2)
					{
						global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e2);
						return;
					}
					goto IL_1BC;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				}
				IL_5C:
				if (this.c > global::Motorola.Common.LogUtility.LoggingLevel.Error)
				{
					num = (short)236322816;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1BC:
				num = (short)1604845569;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000D7F4 File Offset: 0x0000B9F4
		public void UserOperation(string message)
		{
			short num = (short)84762502;
			short num2 = num;
			num = (short)1948409734;
			switch (num2 == num)
			{
			}
			num = (short)754122753;
			if (num != 0)
			{
			}
			num = (short)1570308096;
			short num3 = num;
			num = (short)2130444288;
			if (num != 0)
			{
			}
			this.UserOperationEx(string.Empty, message, null);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000D8AC File Offset: 0x0000BAAC
		public void UserOperation(string format, params object[] message)
		{
			short num = (short)892373639;
			short num2 = num;
			num = (short)416516743;
			switch (num2 == num)
			{
			}
			num = (short)1956052993;
			if (num != 0)
			{
			}
			num = (short)691863552;
			short num3 = num;
			num = (short)1390804992;
			if (num != 0)
			{
			}
			this.UserOperationEx(string.Empty, format, message);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000D964 File Offset: 0x0000BB64
		public void UserOperationEx(string logFileSuffix, string format, params object[] message)
		{
			short num;
			try
			{
				num = (short)72679430;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string message2;
					switch (num2)
					{
					case 0:
						num = (short)996016136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (message != null)
						{
							num = (short)164757504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_192;
					case 2:
						message2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, message);
						num = (short)2113667077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)266095883;
						short num3 = num;
						num = (short)1289309451;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_190;
						default:
							num = (short)751435776;
							if (num != 0)
							{
							}
							num = (short)1420886020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_169;
					case 5:
						goto IL_190;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_4A;
						}
						continue;
					case 7:
						goto IL_1C4;
					case 8:
						num = (short)33095681;
						if (num != 0)
						{
						}
						if (message.Length != 0)
						{
							num = (short)1250099202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_192;
					}
					IL_4A:
					if (this.c > global::Motorola.Common.LogUtility.LoggingLevel.Debug)
					{
						num = (short)1197801475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					message2 = format;
					num = (short)1927544833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_192:
					global::Motorola.Common.LogUtility.LoggingEventArgs a_ = new global::Motorola.Common.LogUtility.LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel.UserOperation, global::System.DateTime.Now, message2)
					{
						FileNameSuffix = logFileSuffix
					};
					this.a(a_);
					num = (short)2034237447;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_190:
					goto IL_192;
				}
				IL_169:
				IL_1C4:;
			}
			catch (global::System.Exception e)
			{
				global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e);
			}
			num = (short)2000748544;
			short num4 = num;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000DB84 File Offset: 0x0000BD84
		public void SetTimeStampLabel(string labelName)
		{
			short num = (short)1245055958;
			short num2 = num;
			num = (short)1446906838;
			switch (num2 == num)
			{
			}
			num = (short)276692993;
			if (num != 0)
			{
			}
			num = (short)100270080;
			short num3 = num;
			num = (short)497876992;
			if (num != 0)
			{
			}
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel(labelName);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000DC34 File Offset: 0x0000BE34
		public bool CanLogPerformance()
		{
			short num = (short)1941612293;
			short num2 = num;
			num = (short)657762053;
			switch (num2 == num)
			{
			}
			num = (short)1373831168;
			if (num != 0)
			{
			}
			num = (short)984219648;
			short num3 = num;
			num = (short)131661825;
			if (num != 0)
			{
			}
			return global::Motorola.Common.LogUtility.AppConfigurator.Instance.PerformanceMeasurerEnabled;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000DCE4 File Offset: 0x0000BEE4
		public void Performance(string stampName, string message)
		{
			short num = (short)2016843396;
			short num2 = num;
			num = (short)555587204;
			switch (num2 == num)
			{
			}
			num = (short)167510017;
			if (num != 0)
			{
			}
			num = (short)1984626688;
			short num3 = num;
			num = (short)556859392;
			if (num != 0)
			{
			}
			this.PerformanceEx(string.Empty, stampName, message, null);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000DD9C File Offset: 0x0000BF9C
		[global::System.Obsolete("Please use PerformanceMeasure.StartNew()")]
		public void Performance(string stampName, string format, params object[] message)
		{
			short num = (short)448326126;
			short num2 = num;
			num = (short)418179566;
			switch (num2 == num)
			{
			}
			num = (short)1487011841;
			if (num != 0)
			{
			}
			num = (short)432930816;
			short num3 = num;
			num = (short)1275330560;
			if (num != 0)
			{
			}
			this.PerformanceEx(string.Empty, stampName, format, message);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000DE54 File Offset: 0x0000C054
		public void PerformanceEx(string logFileSuffix, string stampName, string format, params object[] message)
		{
			short num;
			try
			{
				num = (short)1881407494;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string message2;
					switch (num2)
					{
					case 0:
						num = (short)856227848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (message != null)
						{
							num = (short)1099366400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190;
					case 2:
						message2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, message);
						num = (short)726138885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)549845786;
						short num3 = num;
						num = (short)1899559706;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18E;
						default:
							num = (short)704446465;
							if (num != 0)
							{
							}
							num = (short)1533935616;
							if (num != 0)
							{
							}
							num = (short)1684340740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_167;
					case 5:
						goto IL_18E;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_4A;
						}
						continue;
					case 7:
						goto IL_1CC;
					case 8:
						if (message.Length != 0)
						{
							num = (short)1058340866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190;
					}
					IL_4A:
					if (!this.CanLogPerformance())
					{
						num = (short)1286930435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					message2 = format;
					num = (short)1862074369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_190:
					global::Motorola.Common.LogUtility.LoggingEventArgs a_ = new global::Motorola.Common.LogUtility.LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel.Performance, global::System.DateTime.Now, message2, new global::System.Diagnostics.StackFrame(1, true), stampName)
					{
						FileNameSuffix = logFileSuffix
					};
					this.a(a_);
					num = (short)2003435527;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18E:
					goto IL_190;
				}
				IL_167:
				IL_1CC:;
			}
			catch (global::System.Exception e)
			{
				global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e);
			}
			num = (short)1246232576;
			short num4 = num;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000E07C File Offset: 0x0000C27C
		public void EventLog(string message, global::Motorola.Common.LogUtility.LoggingLevel level)
		{
			short num;
			try
			{
				num = (short)216518559;
				short num2 = num;
				num = (short)408801183;
				switch (num2 == num)
				{
				}
				num = (short)762904576;
				if (num != 0)
				{
				}
				num = (short)1627717633;
				if (num != 0)
				{
				}
				global::Motorola.Common.LogUtility.LoggingEventArgs a_ = new global::Motorola.Common.LogUtility.LoggingEventArgs(level, global::System.DateTime.Now, message);
				this.a(a_);
			}
			catch (global::System.Exception e)
			{
				global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e);
			}
			num = (short)21364736;
			short num3 = num;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000E154 File Offset: 0x0000C354
		public void EventInfo(string message)
		{
			short num = (short)1405979039;
			short num2 = num;
			num = (short)489392543;
			switch (num2 == num)
			{
			}
			num = (short)1447690241;
			if (num != 0)
			{
			}
			num = (short)985530368;
			short num3 = num;
			num = (short)20250624;
			if (num != 0)
			{
			}
			this.EventLog(message, global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000E208 File Offset: 0x0000C408
		public void EventWarning(string message)
		{
			short num = (short)1914948508;
			short num2 = num;
			num = (short)2113457052;
			switch (num2 == num)
			{
			}
			num = (short)2096627713;
			if (num != 0)
			{
			}
			num = (short)1320681472;
			short num3 = num;
			num = (short)85065728;
			if (num != 0)
			{
			}
			this.EventLog(message, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000E2BC File Offset: 0x0000C4BC
		public void EventError(string message)
		{
			short num = (short)240202530;
			short num2 = num;
			num = (short)1517433634;
			switch (num2 == num)
			{
			}
			num = (short)1619591169;
			if (num != 0)
			{
			}
			num = (short)1330774016;
			short num3 = num;
			num = (short)784990208;
			if (num != 0)
			{
			}
			this.EventLog(message, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000E36C File Offset: 0x0000C56C
		public void WriteEventEntry(string content, global::Motorola.Common.LogUtility.LoggingLevel level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
		{
			int a_ = 3;
			short num = (short)805830656;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1D;
				case 1:
					if (level < global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
					{
						num = (short)569311236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27E;
				case 2:
				{
					num = (short)1749680128;
					short num3 = num;
					goto IL_27E;
				}
				case 3:
					goto IL_182;
				case 4:
					goto IL_EC;
				case 5:
					if (level >= global::Motorola.Common.LogUtility.LoggingLevel.EventError)
					{
						num = (short)55705607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
				{
					num = (short)754695452;
					short num4 = num;
					num = (short)82230556;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						goto IL_233;
					}
					break;
				}
				case 7:
					this.EventError(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("歖", a_) + level.ToString() + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("楖祘", a_) + content);
					num = (short)1574371331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (level == global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
					{
						num = (short)1942290433;
						if (num != 0)
						{
						}
						num = (short)99221510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1752694795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1921253377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_EA;
				case 11:
					if (level == global::Motorola.Common.LogUtility.LoggingLevel.EventWarning)
					{
						num = (short)2029256714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)482934789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5D;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_5D:
					if (level > global::Motorola.Common.LogUtility.LoggingLevel.EventError)
					{
						goto IL_EC;
					}
					num = (short)640090121;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_EC:
				level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo;
				num = (short)1319370754;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27E:
				num = (short)1493434376;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EA:
			this.EventWarning(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("歖", a_) + level.ToString() + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("楖祘", a_) + content);
			return;
			IL_182:
			return;
			IL_233:
			num = (short)1182203904;
			if (num != 0)
			{
			}
			this.EventInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("歖", a_) + level.ToString() + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("楖祘", a_) + content);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000E65C File Offset: 0x0000C85C
		public void WriteEventEntry(global::System.Exception e, global::Motorola.Common.LogUtility.LoggingLevel level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1593573382;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)393609216;
						short num3 = num;
						if (level < global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
						{
							num = (short)1089273860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_86;
					}
					case 1:
						num = (short)1086193672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.c <= level)
						{
							num = (short)2119041025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1262551045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1320353792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_140;
					case 5:
						goto IL_135;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 7:
					{
						num = (short)1408631910;
						short num4 = num;
						num = (short)526582886;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)544997376;
							if (num != 0)
							{
							}
							goto IL_86;
						}
						break;
					}
					case 8:
						goto IL_7B;
					}
					IL_49:
					if (level <= global::Motorola.Common.LogUtility.LoggingLevel.EventError)
					{
						num = (short)1197211651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_140;
					IL_86:
					num = (short)1277296642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_140:
					num = (short)1263796225;
					if (num != 0)
					{
					}
					level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo;
					num = (short)1870266375;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7B:
			string text = e.ToString();
			goto IL_1CF;
			IL_135:
			text = e.Message;
			IL_1CF:
			string content = text;
			this.WriteEventEntry(content, level);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000E844 File Offset: 0x0000CA44
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000E8F4 File Offset: 0x0000CAF4
		public string Name
		{
			get
			{
				short num = (short)1039035074;
				short num2 = num;
				num = (short)265579202;
				switch (num2 == num)
				{
				}
				num = (short)763035649;
				if (num != 0)
				{
				}
				num = (short)305004544;
				short num3 = num;
				num = (short)721092608;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1559232513;
				if (num != 0)
				{
				}
				num = (short)1262737018;
				short num2 = num;
				num = (short)815257210;
				switch (num2 == num)
				{
				}
				num = (short)714080256;
				short num3 = num;
				num = (short)560660480;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000E9A8 File Offset: 0x0000CBA8
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000EA58 File Offset: 0x0000CC58
		public global::Motorola.Common.LogUtility.LoggingLevel Level
		{
			get
			{
				short num = (short)1371275420;
				short num2 = num;
				num = (short)92143772;
				switch (num2 == num)
				{
				}
				num = (short)634388481;
				if (num != 0)
				{
				}
				num = (short)67829760;
				short num3 = num;
				num = (short)1723138048;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1560787182;
				short num2 = num;
				num = (short)990492910;
				switch (num2 == num)
				{
				}
				num = (short)427556864;
				if (num != 0)
				{
				}
				num = (short)726663168;
				short num3 = num;
				num = (short)1438973953;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000EB04 File Offset: 0x0000CD04
		public void AddAppender(global::Motorola.Common.LogUtility.IAppender appender)
		{
			short num = (short)1785551914;
			short num2 = num;
			num = (short)127687722;
			switch (num2 == num)
			{
			}
			num = (short)1252524033;
			if (num != 0)
			{
			}
			num = (short)1964703744;
			short num3 = num;
			num = (short)87228416;
			if (num != 0)
			{
			}
			this.a.Add(appender);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000EBBC File Offset: 0x0000CDBC
		private void a(global::Motorola.Common.LogUtility.LoggingEventArgs A_0)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.IAppender>.Enumerator enumerator = this.a.GetEnumerator();
			short num;
			try
			{
				num = (short)1222092399;
				short num2 = num;
				num = (short)1890035311;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_CE:
					if (!enumerator.MoveNext())
					{
						num = (short)981401600;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						enumerator.Current.DoAppend(this, A_0);
						num = (short)1609170948;
						num3 = (int)((global::System.IntPtr)num);
					}
					break;
				default:
					num = (short)284950528;
					if (num != 0)
					{
					}
					num = (short)1962016770;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)1625161731;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_CE;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					case 3:
						goto IL_106;
					}
					IL_B9:
					num = (short)1742143489;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_93:
					goto IL_B9;
				}
				IL_106:;
			}
			finally
			{
				num = (short)177078273;
				if (num != 0)
				{
				}
				((global::System.IDisposable)enumerator).Dispose();
			}
			num = (short)570884096;
			short num4 = num;
		}

		// Token: 0x0400005B RID: 91
		private global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.IAppender> a = new global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.IAppender>();

		// Token: 0x0400005C RID: 92
		private string b;

		// Token: 0x0400005D RID: 93
		private global::Motorola.Common.LogUtility.LoggingLevel c;
	}
}
