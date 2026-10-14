using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000032 RID: 50
	public class ImportCSVCache : global::System.IDisposable
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x000394B8 File Offset: 0x000376B8
		public ImportCSVCache()
		{
			this.TemplateCahce = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.Template>();
			this.ConfigurationCahce = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary>();
			this.CopiedRadioCache = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.Radio>();
			this.RadioFromBLLCache = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug>>();
			this.IPProgramSystemCache = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem>();
			this.RadioAndConfigCompatibleResultCahce = new global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.KeyValuePair<string, string>, global::System.Collections.Generic.KeyValuePair<bool, global::Motorola.Common.CustomException.CommonErrorCode>>();
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00039510 File Offset: 0x00037710
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1138022956;
				short num2 = num;
				num = (short)1944050220;
				switch (num2 == num)
				{
				}
				num = (short)1766064128;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)1960050688;
			short num3 = num;
			num = (short)162725889;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x000395DC File Offset: 0x000377DC
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x0003968C File Offset: 0x0003788C
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.Template> TemplateCahce
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)825931887;
				short num2 = num;
				num = (short)441694319;
				switch (num2 == num)
				{
				}
				num = (short)1154613249;
				if (num != 0)
				{
				}
				num = (short)48365568;
				if (num != 0)
				{
				}
				num = (short)1499004928;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1448654155;
				short num2 = num;
				num = (short)1571730763;
				switch (num2 == num)
				{
				}
				num = (short)1103298561;
				if (num != 0)
				{
				}
				num = (short)1533607936;
				if (num != 0)
				{
				}
				num = (short)1443561472;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0003973C File Offset: 0x0003793C
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x000397EC File Offset: 0x000379EC
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> ConfigurationCahce
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1401535987;
				short num2 = num;
				num = (short)397458931;
				switch (num2 == num)
				{
				}
				num = (short)1421017088;
				if (num != 0)
				{
				}
				num = (short)56754177;
				if (num != 0)
				{
				}
				num = (short)2015952896;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)811401217;
				if (num != 0)
				{
				}
				num = (short)1176043982;
				short num2 = num;
				num = (short)247398862;
				switch (num2 == num)
				{
				}
				num = (short)212205568;
				if (num != 0)
				{
				}
				num = (short)739377152;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0003989C File Offset: 0x00037A9C
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0003994C File Offset: 0x00037B4C
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.Radio> CopiedRadioCache
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1990717113;
				short num2 = num;
				num = (short)1810165433;
				switch (num2 == num)
				{
				}
				num = (short)600244225;
				if (num != 0)
				{
				}
				num = (short)2026831872;
				short num3 = num;
				num = (short)559808512;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1392168708;
				short num2 = num;
				num = (short)79417092;
				switch (num2 == num)
				{
				}
				num = (short)1652555777;
				if (num != 0)
				{
				}
				num = (short)2052980736;
				short num3 = num;
				num = (short)1595015168;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00039A04 File Offset: 0x00037C04
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00039AB4 File Offset: 0x00037CB4
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug>> RadioFromBLLCache
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)390840153;
				short num2 = num;
				num = (short)1111801689;
				switch (num2 == num)
				{
				}
				num = (short)1604845569;
				if (num != 0)
				{
				}
				num = (short)419037184;
				short num3 = num;
				num = (short)2074476544;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)315921409;
				short num2 = num;
				num = (short)146510849;
				switch (num2 == num)
				{
				}
				num = (short)1581514753;
				if (num != 0)
				{
				}
				num = (short)253755392;
				short num3 = num;
				num = (short)422248448;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00039B64 File Offset: 0x00037D64
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00039C14 File Offset: 0x00037E14
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> IPProgramSystemCache
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)207597658;
				short num2 = num;
				num = (short)1974972506;
				switch (num2 == num)
				{
				}
				num = (short)1700986881;
				if (num != 0)
				{
				}
				num = (short)427163648;
				short num3 = num;
				num = (short)1312096256;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)509911056;
				short num2 = num;
				num = (short)1125883920;
				switch (num2 == num)
				{
				}
				num = (short)1110507521;
				if (num != 0)
				{
				}
				num = (short)946601984;
				short num3 = num;
				num = (short)542703616;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00039CC8 File Offset: 0x00037EC8
		public void Dispose()
		{
			short num = (short)88077731;
			short num2 = num;
			num = (short)117765539;
			switch (num2 == num)
			{
			}
			num = (short)1589706753;
			if (num != 0)
			{
			}
			num = (short)1237843968;
			short num3 = num;
			num = (short)741277696;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00039D80 File Offset: 0x00037F80
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)363528214;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)98566144;
					short num3 = num;
					global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ipprogramSystemCache = this.IPProgramSystemCache;
					if (ipprogramSystemCache == null)
					{
						num = (short)969474064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					ipprogramSystemCache.Clear();
					num = (short)1985609731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_3BF;
				case 2:
					goto IL_1FE;
				case 3:
					num = (short)1674379265;
					if (num != 0)
					{
					}
					goto IL_35E;
				case 4:
				{
					global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.Radio> copiedRadioCache = this.CopiedRadioCache;
					if (copiedRadioCache == null)
					{
						num = (short)1307901966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					copiedRadioCache.Clear();
					num = (short)2055733250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_137;
				case 6:
					goto IL_137;
				case 7:
					if (disposing)
					{
						num = (short)547815432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DF;
				case 8:
					num = (short)1115029514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1359544327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.Template> templateCahce = this.TemplateCahce;
					if (templateCahce == null)
					{
						num = (short)435814405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					templateCahce.Clear();
					num = (short)550043654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					goto IL_19A;
				case 12:
					goto IL_3BF;
				case 13:
				{
					global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.KeyValuePair<string, string>, global::System.Collections.Generic.KeyValuePair<bool, global::Motorola.Common.CustomException.CommonErrorCode>> radioAndConfigCompatibleResultCahce = this.RadioAndConfigCompatibleResultCahce;
					if (radioAndConfigCompatibleResultCahce == null)
					{
						num = (short)1206583297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					radioAndConfigCompatibleResultCahce.Clear();
					num = (short)384958476;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					goto IL_1FE;
				case 15:
					goto IL_2AE;
				case 16:
					goto IL_35E;
				case 17:
					goto IL_19A;
				case 18:
				{
					global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug>> radioFromBLLCache = this.RadioFromBLLCache;
					if (radioFromBLLCache == null)
					{
						num = (short)234029071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					radioFromBLLCache.Clear();
					num = (short)1486290963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					goto IL_2AE;
				case 20:
				{
					IL_155:
					global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> configurationCahce = this.ConfigurationCahce;
					if (configurationCahce == null)
					{
						num = (short)1198784523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					configurationCahce.Clear();
					num = (short)1004601361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 21:
					goto IL_3DD;
				case 22:
					switch (0)
					{
					case 0:
						goto IL_80;
					}
					continue;
				}
				IL_80:
				if (!this.a)
				{
					num = (short)325713929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_137:
				this.TemplateCahce = null;
				num = (short)1029701652;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1FE:
				this.CopiedRadioCache = null;
				num = (short)1385534585;
				short num4 = num;
				num = (short)641569913;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_155;
				default:
					num = (short)947716096;
					if (num != 0)
					{
					}
					num = (short)2082996242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_19A:
				this.ConfigurationCahce = null;
				num = (short)387776516;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AE:
				this.RadioFromBLLCache = null;
				num = (short)1638662144;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35E:
				this.IPProgramSystemCache = null;
				num = (short)1232338957;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3BF:
				this.RadioAndConfigCompatibleResultCahce = null;
				num = (short)1200160789;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3DD:
			IL_3DF:
			this.a = true;
		}

		// Token: 0x0400004C RID: 76
		private bool a;

		// Token: 0x0400004D RID: 77
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.Template> b;

		// Token: 0x0400004E RID: 78
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> c;

		// Token: 0x0400004F RID: 79
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.Radio> d;

		// Token: 0x04000050 RID: 80
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug>> e;

		// Token: 0x04000051 RID: 81
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> f;

		// Token: 0x04000052 RID: 82
		public global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.KeyValuePair<string, string>, global::System.Collections.Generic.KeyValuePair<bool, global::Motorola.Common.CustomException.CommonErrorCode>> RadioAndConfigCompatibleResultCahce;
	}
}
