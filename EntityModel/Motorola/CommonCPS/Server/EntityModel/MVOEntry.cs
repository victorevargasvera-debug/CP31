using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001B2 RID: 434
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROMVOEntry))]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRMVOEntry))]
	public class MVOEntry : global::System.ICloneable
	{
		// Token: 0x06001688 RID: 5768 RVA: 0x000F1AC0 File Offset: 0x000EFCC0
		public MVOEntry()
		{
			this.ModelNumber = string.Empty;
			this.Productfamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None;
			this.Options = null;
			this.Version = null;
			this.Region = global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NULL;
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x000F1AFC File Offset: 0x000EFCFC
		public virtual void SetFlashSize(string flashSize)
		{
			short num = (short)1455290648;
			short num2 = num;
			num = (short)1246427416;
			switch (num2 == num)
			{
			}
			num = (short)402325504;
			if (num != 0)
			{
			}
			num = (short)370606080;
			short num3 = num;
			num = (short)932773889;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x000F1BA8 File Offset: 0x000EFDA8
		public virtual string IDString
		{
			get
			{
				short num = (short)151433856;
				short num2 = num;
				num = (short)1768272512;
				switch (num2 == num)
				{
				}
				num = (short)1080426497;
				if (num != 0)
				{
				}
				num = (short)15007744;
				short num3 = num;
				num = (short)1872035840;
				if (num != 0)
				{
				}
				return this.ModelNumber;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x000F1C58 File Offset: 0x000EFE58
		// (set) Token: 0x0600168C RID: 5772 RVA: 0x000F1D08 File Offset: 0x000EFF08
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily Productfamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1014148390;
				short num2 = num;
				num = (short)136097062;
				switch (num2 == num)
				{
				}
				num = (short)637599745;
				if (num != 0)
				{
				}
				num = (short)334102528;
				short num3 = num;
				num = (short)1903755264;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1501392865;
				short num2 = num;
				num = (short)335900641;
				switch (num2 == num)
				{
				}
				num = (short)2137260033;
				if (num != 0)
				{
				}
				num = (short)372310016;
				short num3 = num;
				num = (short)1910505472;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x0600168D RID: 5773 RVA: 0x000F1DBC File Offset: 0x000EFFBC
		// (set) Token: 0x0600168E RID: 5774 RVA: 0x000F1E68 File Offset: 0x000F0068
		[global::System.Runtime.Serialization.DataMember]
		public string ProductIdentifier
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1642319051;
				short num2 = num;
				num = (short)1147325643;
				switch (num2 == num)
				{
				}
				num = (short)2075197441;
				if (num != 0)
				{
				}
				num = (short)1008599040;
				short num3 = num;
				num = (short)693043200;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)287181800;
				short num2 = num;
				num = (short)987368424;
				switch (num2 == num)
				{
				}
				num = (short)340983808;
				if (num != 0)
				{
				}
				num = (short)1930690560;
				short num3 = num;
				num = (short)1483472897;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x000F1F18 File Offset: 0x000F0118
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x000F1FC8 File Offset: 0x000F01C8
		[global::System.Runtime.Serialization.DataMember]
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)508318969;
				short num2 = num;
				num = (short)1279350009;
				switch (num2 == num)
				{
				}
				num = (short)1437401089;
				if (num != 0)
				{
				}
				num = (short)104660992;
				short num3 = num;
				num = (short)2098593792;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1728884862;
				short num2 = num;
				num = (short)938717310;
				switch (num2 == num)
				{
				}
				num = (short)1045299201;
				if (num != 0)
				{
				}
				num = (short)1869348864;
				short num3 = num;
				num = (short)357629952;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x000F2078 File Offset: 0x000F0278
		// (set) Token: 0x06001692 RID: 5778 RVA: 0x000F2128 File Offset: 0x000F0328
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.HOption> Options
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1151926273;
				if (num != 0)
				{
				}
				num = (short)858107114;
				short num2 = num;
				num = (short)156347626;
				switch (num2 == num)
				{
				}
				num = (short)1979973632;
				short num3 = num;
				num = (short)1313406976;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)534884233;
				short num2 = num;
				num = (short)225554313;
				switch (num2 == num)
				{
				}
				num = (short)1568669697;
				if (num != 0)
				{
				}
				num = (short)1077870592;
				short num3 = num;
				num = (short)1067319296;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x000F21D8 File Offset: 0x000F03D8
		// (set) Token: 0x06001694 RID: 5780 RVA: 0x000F228C File Offset: 0x000F048C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.BLVersion Version
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)98168263;
				short num2 = num;
				num = (short)1444343239;
				switch (num2 == num)
				{
				}
				num = (short)1848442881;
				if (num != 0)
				{
				}
				num = (short)840957952;
				short num3 = num;
				num = (short)1090584576;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1580446237;
				short num2 = num;
				num = (short)624669213;
				switch (num2 == num)
				{
				}
				num = (short)719585281;
				if (num != 0)
				{
				}
				num = (short)408551424;
				short num3 = num;
				num = (short)1689911296;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x000F233C File Offset: 0x000F053C
		// (set) Token: 0x06001696 RID: 5782 RVA: 0x000F23EC File Offset: 0x000F05EC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName Region
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)892497393;
				short num2 = num;
				num = (short)45313521;
				switch (num2 == num)
				{
				}
				num = (short)1578237952;
				if (num != 0)
				{
				}
				num = (short)1065091072;
				short num3 = num;
				num = (short)1549860865;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)941948929;
				if (num != 0)
				{
				}
				num = (short)735546182;
				short num2 = num;
				num = (short)1107987270;
				switch (num2 == num)
				{
				}
				num = (short)15007744;
				short num3 = num;
				num = (short)1387986944;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000F249C File Offset: 0x000F069C
		public virtual object Clone()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object obj;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)887131180;
					short num3 = num2;
					num2 = (short)826903596;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_E5;
					}
					break;
				}
				case 1:
					if (this.Options != null)
					{
						num2 = (short)1930821634;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return obj;
				case 2:
					(obj as global::Motorola.CommonCPS.Server.EntityModel.MVOEntry).Options = this.Options.ToList<global::Motorola.CommonCPS.Server.EntityModel.HOption>();
					num2 = (short)244383744;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_E5:
			num2 = (short)2125529088;
			if (num2 != 0)
			{
			}
			num2 = (short)68943873;
			if (num2 != 0)
			{
			}
			return obj;
			IL_1C:
			num2 = (short)1991704576;
			short num4 = num2;
			obj = base.MemberwiseClone();
			num2 = (short)229965825;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x000F25CC File Offset: 0x000F07CC
		public static bool IsEqual(global::Motorola.CommonCPS.Server.EntityModel.MVOEntry source, global::Motorola.CommonCPS.Server.EntityModel.MVOEntry target)
		{
			short num = (short)1947664384;
			switch (num)
			{
			default:
			{
				num = (short)282001443;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.Server.EntityModel.PCRMVOEntry pcrmvoentry;
				global::Motorola.CommonCPS.Server.EntityModel.ASTROMVOEntry astromvoentry;
				global::Motorola.CommonCPS.Server.EntityModel.PCRMVOEntry pcrmvoentry2;
				global::Motorola.CommonCPS.Server.EntityModel.ASTROMVOEntry astromvoentry2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (pcrmvoentry.AppOptions != null)
						{
							num = (short)717225988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						goto IL_3E4;
					case 2:
					{
						num = (short)238288896;
						short num3 = num;
						num = (short)1334364396;
						short num4 = num;
						num = (short)1632028908;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_442;
						default:
							num = (short)1009844224;
							if (num != 0)
							{
							}
							num = (short)1846870044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_367;
					case 4:
						goto IL_3A9;
					case 5:
						num = (short)538312727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1278214144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (astromvoentry.Options == null)
						{
							num = (short)1924857858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_367;
					case 8:
						if (pcrmvoentry2.FlashSize == pcrmvoentry.FlashSize)
						{
							num = (short)671875094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						if (pcrmvoentry2.ModelNumber == pcrmvoentry.ModelNumber)
						{
							num = (short)1124925472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 10:
						goto IL_667;
					case 11:
						if (astromvoentry.ProductIdentifier == astromvoentry2.ProductIdentifier)
						{
							num = (short)897450000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 12:
						if (astromvoentry.FlashCode == astromvoentry2.FlashCode)
						{
							num = (short)2359313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 13:
						if (pcrmvoentry2.ProductIdentifier == pcrmvoentry.ProductIdentifier)
						{
							num = (short)455540760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 14:
						if (pcrmvoentry2.AppOptions != null)
						{
							num = (short)96862209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						num = (short)531496986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1739390983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_442;
					case 18:
						num = (short)199753739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1277493278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (astromvoentry.Options != null)
						{
							num = (short)537395237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 21:
						if (astromvoentry.ModelNumber == astromvoentry2.ModelNumber)
						{
							num = (short)57147407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 22:
						num = (short)1568604193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (pcrmvoentry.Options != null)
						{
							num = (short)1300168729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_667;
					case 24:
						num = (short)1556545544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_105;
					case 26:
						if (astromvoentry.Version == astromvoentry2.Version)
						{
							num = (short)564461586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 27:
						astromvoentry = (source as global::Motorola.CommonCPS.Server.EntityModel.ASTROMVOEntry);
						astromvoentry2 = (target as global::Motorola.CommonCPS.Server.EntityModel.ASTROMVOEntry);
						num = (short)170065932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (astromvoentry2.Options != null)
						{
							num = (short)872218627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 29:
						if (pcrmvoentry2.Options != null)
						{
							num = (short)609878035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 30:
						if (pcrmvoentry2.Options.Count<global::Motorola.CommonCPS.Server.EntityModel.HOption>() == pcrmvoentry.Options.Count<global::Motorola.CommonCPS.Server.EntityModel.HOption>())
						{
							num = (short)1800929281;
							if (num != 0)
							{
							}
							num = (short)887160842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 31:
						if (pcrmvoentry2.AppOptions == null)
						{
							num = (short)110952454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A9;
					case 32:
						num = (short)946208802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (pcrmvoentry2.Options == null)
						{
							num = (short)1923350533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_105;
					case 34:
						if (pcrmvoentry2.Version == pcrmvoentry.Version)
						{
							num = (short)566427684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 35:
						switch (0)
						{
						case 0:
							goto IL_DD;
						}
						continue;
					case 36:
						num = (short)2122842125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_3A4;
					}
					IL_DD:
					if (source is global::Motorola.CommonCPS.Server.EntityModel.ASTROMVOEntry)
					{
						num = (short)686882843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					pcrmvoentry2 = (source as global::Motorola.CommonCPS.Server.EntityModel.PCRMVOEntry);
					pcrmvoentry = (target as global::Motorola.CommonCPS.Server.EntityModel.PCRMVOEntry);
					num = (short)1948712969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_105:
					num = (short)703725597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_367:
					num = (short)366084116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A9:
					num = (short)1959591950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_442:
					num = (short)1593311253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_667:
					num = (short)1724842015;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_3A4:
				return astromvoentry.Options.Count<global::Motorola.CommonCPS.Server.EntityModel.HOption>() == astromvoentry2.Options.Count<global::Motorola.CommonCPS.Server.EntityModel.HOption>();
				IL_3E4:
				return pcrmvoentry2.AppOptions.Count<global::Motorola.CommonCPS.Server.EntityModel.HOption>() == pcrmvoentry.AppOptions.Count<global::Motorola.CommonCPS.Server.EntityModel.HOption>();
			}
			}
		}

		// Token: 0x04000A9C RID: 2716
		public const string FlashSize_32M = "FlashSize_32M";

		// Token: 0x04000A9D RID: 2717
		public const string FlashSize_8M = "FlashSize_8M";

		// Token: 0x04000A9E RID: 2718
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily a;

		// Token: 0x04000A9F RID: 2719
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x04000AA0 RID: 2720
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x04000AA1 RID: 2721
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.HOption> d;

		// Token: 0x04000AA2 RID: 2722
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.EntityModel.BLVersion e;

		// Token: 0x04000AA3 RID: 2723
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName f;
	}
}
