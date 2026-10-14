using System;
using System.Runtime.CompilerServices;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.FCCExceptionHandler
{
	// Token: 0x02000119 RID: 281
	internal class BaseSection
	{
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x0015129C File Offset: 0x0014F49C
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x0015134C File Offset: 0x0014F54C
		public string BandType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1380758829;
				short num2 = num;
				num = (short)69383469;
				switch (num2 == num)
				{
				}
				num = (short)363921409;
				if (num != 0)
				{
				}
				num = (short)2089025536;
				if (num != 0)
				{
				}
				num = (short)612237312;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)304283649;
				if (num != 0)
				{
				}
				num = (short)723099307;
				short num2 = num;
				num = (short)2089197227;
				switch (num2 == num)
				{
				}
				num = (short)675348480;
				if (num != 0)
				{
				}
				num = (short)839319552;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00151400 File Offset: 0x0014F600
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x001514B0 File Offset: 0x0014F6B0
		public global::SpecialFeatures.FCCExceptionHandler.SectionType FreqType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1578250953;
				short num2 = num;
				num = (short)892482249;
				switch (num2 == num)
				{
				}
				num = (short)1612775424;
				if (num != 0)
				{
				}
				num = (short)1996357633;
				if (num != 0)
				{
				}
				num = (short)562429952;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1697054721;
				if (num != 0)
				{
				}
				num = (short)1744998841;
				short num2 = num;
				num = (short)313430457;
				switch (num2 == num)
				{
				}
				num = (short)287047680;
				if (num != 0)
				{
				}
				num = (short)1082851328;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00151560 File Offset: 0x0014F760
		public override string ToString()
		{
			int a_ = 9;
			short num = (short)734683495;
			short num2 = num;
			num = (short)1126130023;
			switch (num2 == num)
			{
			}
			num = (short)1041760256;
			if (num != 0)
			{
			}
			num = (short)314245121;
			if (num != 0)
			{
			}
			num = (short)1720385536;
			short num3 = num;
			return this.BandType + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겋ꎍ낏", a_) + this.FreqType.ToString();
		}

		// Token: 0x040007FB RID: 2043
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x040007FC RID: 2044
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SpecialFeatures.FCCExceptionHandler.SectionType b;
	}
}
