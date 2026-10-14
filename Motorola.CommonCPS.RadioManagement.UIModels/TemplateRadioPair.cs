using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000F1 RID: 241
	public class TemplateRadioPair : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::Motorola.CommonCPS.RadioManagement.UIModels.ICopyable
	{
		// Token: 0x06000BBB RID: 3003 RVA: 0x000B0A4C File Offset: 0x000AEC4C
		public TemplateRadioPair(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase template, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio, string errorString = "")
		{
			this.a = template;
			this.b = radio;
			this.ErrorString = errorString;
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x000B0A84 File Offset: 0x000AEC84
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x000B0B34 File Offset: 0x000AED34
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1634279414;
				short num2 = num;
				num = (short)1766858742;
				switch (num2 == num)
				{
				}
				num = (short)1051656193;
				if (num != 0)
				{
				}
				num = (short)1029832704;
				if (num != 0)
				{
				}
				num = (short)1541734400;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1957804173;
				short num2 = num;
				num = (short)120764557;
				switch (num2 == num)
				{
				}
				num = (short)540409857;
				if (num != 0)
				{
				}
				num = (short)1676673024;
				if (num != 0)
				{
				}
				num = (short)143523840;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x000B0BE4 File Offset: 0x000AEDE4
		public global::System.Guid TemplateUuid
		{
			get
			{
				short num = (short)1884356608;
				short num2 = num;
				if (this.a != null)
				{
					num = (short)473366529;
					if (num != 0)
					{
					}
					num = (short)1472439125;
					short num3 = num;
					num = (short)849847125;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1863188480;
						if (num != 0)
						{
						}
						return this.a.TemplateID;
					}
				}
				return global::System.Guid.Empty;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x000B0CAC File Offset: 0x000AEEAC
		public string TemplateName
		{
			get
			{
				short num = (short)58654720;
				short num2 = num;
				if (this.a != null)
				{
					num = (short)1547807336;
					short num3 = num;
					num = (short)1422568040;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)541982721;
						if (num != 0)
						{
						}
						num = (short)1092222976;
						if (num != 0)
						{
						}
						return this.a.Name;
					}
				}
				return null;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x000B0D6C File Offset: 0x000AEF6C
		public string SerialNumber
		{
			get
			{
				short num = (short)1979514880;
				short num2 = num;
				num = (short)344326145;
				if (num != 0)
				{
				}
				if (this.b != null)
				{
					num = (short)2044944256;
					short num3 = num;
					num = (short)1796300672;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1851916288;
						if (num != 0)
						{
						}
						return this.b.SerialNumber;
					}
				}
				return null;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x000B0E30 File Offset: 0x000AF030
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x000B0EE0 File Offset: 0x000AF0E0
		public string ErrorString
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1196928963;
				short num2 = num;
				num = (short)541962179;
				switch (num2 == num)
				{
				}
				num = (short)913047553;
				if (num != 0)
				{
				}
				num = (short)565116928;
				if (num != 0)
				{
				}
				num = (short)602996736;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1291149748;
				short num2 = num;
				num = (short)645554612;
				switch (num2 == num)
				{
				}
				num = (short)803012609;
				if (num != 0)
				{
				}
				num = (short)479264768;
				if (num != 0)
				{
				}
				num = (short)978976768;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x000B0F90 File Offset: 0x000AF190
		public global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase Template
		{
			get
			{
				short num = (short)1501153187;
				short num2 = num;
				num = (short)1385416611;
				switch (num2 == num)
				{
				}
				num = (short)1098776577;
				if (num != 0)
				{
				}
				num = (short)1562640384;
				if (num != 0)
				{
				}
				num = (short)96206848;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x000B1040 File Offset: 0x000AF240
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase Radio
		{
			get
			{
				short num = (short)1010182752;
				short num2 = num;
				num = (short)788933216;
				switch (num2 == num)
				{
				}
				num = (short)319946752;
				if (num != 0)
				{
				}
				num = (short)1382154241;
				if (num != 0)
				{
				}
				num = (short)877723648;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x000B10F0 File Offset: 0x000AF2F0
		public void CopyFrom(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase source)
		{
			short num = (short)827509127;
			short num2 = num;
			num = (short)463128967;
			switch (num2 == num)
			{
			}
			num = (short)796983297;
			if (num != 0)
			{
			}
			num = (short)1410990080;
			if (num != 0)
			{
			}
			num = (short)1333526528;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair templateRadioPair = (global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair)source;
			this.b = templateRadioPair.b;
			this.a = templateRadioPair.a;
		}

		// Token: 0x0400042F RID: 1071
		private global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase a;

		// Token: 0x04000430 RID: 1072
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase b;

		// Token: 0x04000431 RID: 1073
		private global::System.Guid? c = new global::System.Guid?(global::System.Guid.NewGuid());

		// Token: 0x04000432 RID: 1074
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;
	}
}
