using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Comparers;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x02000014 RID: 20
	public class Logger
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00009328 File Offset: 0x00007528
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000093D8 File Offset: 0x000075D8
		public static string ExcepitonMsg
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1992884225;
				if (num != 0)
				{
				}
				num = (short)554041344;
				short num2 = num;
				num = (short)1850629132;
				short num3 = num;
				num = (short)1004690444;
				switch (num3 == num)
				{
				}
				num = (short)834863104;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1209008129;
				if (num != 0)
				{
				}
				num = (short)666042368;
				short num2 = num;
				num = (short)707118373;
				short num3 = num;
				num = (short)2021639461;
				switch (num3 == num)
				{
				}
				num = (short)523698176;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.b = value;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00009484 File Offset: 0x00007684
		public static void Log(string message, global::System.Exception exp = null, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel logLevel = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error)
		{
			short num;
			try
			{
				num = (short)1409810434;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(exp, message);
						num = (short)1809776643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_EA;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 3:
					{
						num = (short)480730459;
						short num3 = num;
						num = (short)1794268507;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3B;
						default:
							num = (short)217186304;
							if (num != 0)
							{
							}
							goto IL_EA;
						}
						break;
					}
					case 4:
						goto IL_101;
					}
					goto IL_38;
					IL_3B:
					num = (short)302383104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38:
					if (exp != null)
					{
						goto IL_3B;
					}
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Debug(message);
					num = (short)609943553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EA:
					num = (short)411762692;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_101:;
			}
			catch
			{
			}
			num = (short)1295450112;
			short num4 = num;
			num = (short)832045057;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00009618 File Offset: 0x00007818
		// Note: this type is marked as 'beforefieldinit'.
		static Logger()
		{
			int a_ = 3;
			short num = (short)405020271;
			short num2 = num;
			num = (short)121708143;
			switch (num2 == num)
			{
			default:
			{
				num = (short)825819136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)514981889;
			if (num != 0)
			{
			}
			num = (short)1073086464;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.a = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ୖ୘ᙚṜ煞ᕠ᭢ᅤ", a_);
		}

		// Token: 0x04000036 RID: 54
		private static string a;

		// Token: 0x04000037 RID: 55
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static string b;
	}
}
