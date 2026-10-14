using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000174 RID: 372
	public class Logger
	{
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x00198244 File Offset: 0x00196444
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x001982F0 File Offset: 0x001964F0
		internal static string ExcepitonMsg
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1908998144;
				short num2 = num;
				num = (short)236912641;
				if (num != 0)
				{
				}
				num = (short)557917172;
				short num3 = num;
				num = (short)1338254324;
				switch (num3 == num)
				{
				}
				num = (short)1007616000;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Comms.Logger.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)134086656;
				short num2 = num;
				num = (short)1248152307;
				short num3 = num;
				num = (short)658197235;
				switch (num3 == num)
				{
				}
				num = (short)1202585601;
				if (num != 0)
				{
				}
				num = (short)1576927232;
				if (num != 0)
				{
				}
				global::SpecialFeatures.Comms.Logger.c = value;
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x001983A0 File Offset: 0x001965A0
		public static void Log(string message)
		{
			short num = (short)1102249984;
			short num2 = num;
			num = (short)2139291649;
			if (num != 0)
			{
			}
			num = (short)912030914;
			short num3 = num;
			num = (short)1469086914;
			switch (num3 == num)
			{
			}
			num = (short)333185024;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00198448 File Offset: 0x00196648
		public static void LogWithDateTime(string message)
		{
			short num = (short)1128202240;
			short num2 = num;
			num = (short)243105701;
			short num3 = num;
			num = (short)1807843237;
			switch (num3 == num)
			{
			}
			num = (short)591134720;
			if (num != 0)
			{
			}
			num = (short)760414209;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Comms.Logger.Log(string.Format(global::SpecialFeatures.Comms.Logger.b, global::System.DateTime.Now, message));
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00198508 File Offset: 0x00196708
		// Note: this type is marked as 'beforefieldinit'.
		static Logger()
		{
			int a_ = 10;
			short num = (short)1057947648;
			short num2 = num;
			num = (short)978501470;
			short num3 = num;
			num = (short)165920606;
			switch (num3 == num)
			{
			}
			num = (short)409272320;
			if (num != 0)
			{
			}
			num = (short)1840906241;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Comms.Logger.a = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톌캎킘쾚톜욠趢톤\udfa6\udda8", a_);
			global::SpecialFeatures.Comms.Logger.b = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("회ꆐ떔몖릘겜ﲠ", a_);
		}

		// Token: 0x04000A00 RID: 2560
		private static readonly string a;

		// Token: 0x04000A01 RID: 2561
		private static readonly string b;

		// Token: 0x04000A02 RID: 2562
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static string c;
	}
}
