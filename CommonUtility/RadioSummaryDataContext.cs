using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.EntityModel;

namespace CommonUtility
{
	// Token: 0x0200004F RID: 79
	public class RadioSummaryDataContext
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0002DD1C File Offset: 0x0002BF1C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0002DDCC File Offset: 0x0002BFCC
		public global::Motorola.CommonCPS.Server.EntityModel.Radio Radio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1778057216;
				short num2 = num;
				num = (short)793149793;
				short num3 = num;
				num = (short)1110933857;
				switch (num3 == num)
				{
				}
				num = (short)1804664832;
				if (num != 0)
				{
				}
				num = (short)1055588353;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1876033536;
				short num2 = num;
				num = (short)402784257;
				if (num != 0)
				{
				}
				num = (short)7592860;
				short num3 = num;
				num = (short)645061532;
				switch (num3 == num)
				{
				}
				num = (short)1220083712;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0002DE7C File Offset: 0x0002C07C
		public RadioSummaryDataContext(global::Motorola.CommonCPS.Server.EntityModel.Radio changedRadio)
		{
			this.Radio = changedRadio;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0002DE98 File Offset: 0x0002C098
		public virtual global::Motorola.CommonCPS.Server.EntityModel.Group GetGroup()
		{
			short num = (short)924712960;
			short num2 = num;
			num = (short)377842829;
			short num3 = num;
			num = (short)2041801869;
			switch (num3 == num)
			{
			}
			num = (short)284491777;
			if (num != 0)
			{
			}
			num = (short)1331625984;
			if (num != 0)
			{
			}
			return this.Radio.Group;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0002DF4C File Offset: 0x0002C14C
		public virtual global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem GetIPProgramSystem()
		{
			short num = (short)1783889920;
			short num2 = num;
			num = (short)2057487875;
			short num3 = num;
			num = (short)1629144579;
			switch (num3 == num)
			{
			}
			num = (short)304676865;
			if (num != 0)
			{
			}
			num = (short)2107637760;
			if (num != 0)
			{
			}
			return this.Radio.IPProgramSystem;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0002DFFC File Offset: 0x0002C1FC
		public virtual global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob GetReadWriteJob()
		{
			short num = (short)17104896;
			short num2 = num;
			num = (short)1336803329;
			if (num != 0)
			{
			}
			num = (short)637917270;
			short num3 = num;
			num = (short)1377818710;
			switch (num3 == num)
			{
			}
			num = (short)1189478400;
			if (num != 0)
			{
			}
			return this.Radio.LastJob;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0002E0B0 File Offset: 0x0002C2B0
		public virtual global::Motorola.CommonCPS.Server.EntityModel.Codeplug GetWorkingCodeplug()
		{
			short num = (short)337313792;
			short num2 = num;
			num = (short)1678782387;
			short num3 = num;
			num = (short)550383539;
			switch (num3 == num)
			{
			}
			num = (short)560988161;
			if (num != 0)
			{
			}
			num = (short)174784512;
			if (num != 0)
			{
			}
			return this.Radio.WorkingCodeplug;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0002E160 File Offset: 0x0002C360
		public virtual global::Motorola.CommonCPS.Server.EntityModel.Template GetTemplate(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug)
		{
			short num = (short)358154240;
			short num2 = num;
			num = (short)587486193;
			short num3 = num;
			num = (short)1052398577;
			switch (num3 == num)
			{
			}
			num = (short)690421760;
			if (num != 0)
			{
			}
			num = (short)1151795201;
			if (num != 0)
			{
			}
			return codeplug.Template;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0002E20C File Offset: 0x0002C40C
		public virtual global::Motorola.CommonCPS.Server.EntityModel.Configuration GetConfiguration(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug)
		{
			short num = (short)267976704;
			short num2 = num;
			num = (short)1664950496;
			short num3 = num;
			num = (short)396763360;
			switch (num3 == num)
			{
			}
			num = (short)227934208;
			if (num != 0)
			{
			}
			num = (short)293797889;
			if (num != 0)
			{
			}
			return codeplug.Configuration;
		}

		// Token: 0x0400010D RID: 269
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.EntityModel.Radio a;
	}
}
