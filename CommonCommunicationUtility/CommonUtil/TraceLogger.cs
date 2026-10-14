using System;
using System.Diagnostics;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000049 RID: 73
	public abstract class TraceLogger
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000C0A0 File Offset: 0x0000A2A0
		public static global::Motorola.Common.Communication.CommonUtil.TraceLogger Instance
		{
			get
			{
				short num = (short)1812922369;
				if (num != 0)
				{
				}
				num = (short)907699816;
				short num2 = num;
				num = (short)1445160552;
				switch (num2 == num)
				{
				}
				num = (short)1060044800;
				short num3 = num;
				num = (short)1214906368;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommonUtil.TraceLogger.a;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000ED RID: 237
		public abstract global::System.Diagnostics.TraceLevel Level { get; }

		// Token: 0x060000EE RID: 238 RVA: 0x0000C14C File Offset: 0x0000A34C
		static TraceLogger()
		{
			short num = (short)1331822593;
			if (num != 0)
			{
			}
			num = (short)805603178;
			short num2 = num;
			num = (short)1936557930;
			switch (num2 == num)
			{
			}
			num = (short)2106720256;
			short num3 = num;
			num = (short)1066860544;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.a = new global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC();
		}

		// Token: 0x060000EF RID: 239
		public abstract void WriteError(string format, params object[] args);

		// Token: 0x060000F0 RID: 240
		public abstract void WriteWarning(string format, params object[] args);

		// Token: 0x060000F1 RID: 241
		[global::System.Diagnostics.Conditional("TRACE")]
		public abstract void WriteInfo(string format, params object[] args);

		// Token: 0x060000F2 RID: 242
		[global::System.Diagnostics.Conditional("TRACE")]
		public abstract void WriteVerbose(global::Motorola.Common.Communication.CommonUtil.TraceLogger.TraceLoggerStringBuilder errorBuilder);

		// Token: 0x060000F3 RID: 243
		[global::System.Diagnostics.Conditional("TRACE")]
		public abstract void WriteVerbose(string format, params object[] args);

		// Token: 0x060000F4 RID: 244
		[global::System.Diagnostics.Conditional("DEBUG")]
		public abstract void WriteSensitive(string format, params object[] args);

		// Token: 0x060000F5 RID: 245
		[global::System.Diagnostics.Conditional("TRACE")]
		public abstract void WriteVoid(string format, params object[] args);

		// Token: 0x0400022A RID: 554
		private static global::Motorola.Common.Communication.CommonUtil.TraceLogger a;

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060000F8 RID: 248
		public delegate string TraceLoggerStringBuilder();
	}
}
