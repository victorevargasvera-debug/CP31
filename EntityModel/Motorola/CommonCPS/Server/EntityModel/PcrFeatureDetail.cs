using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200007C RID: 124
	public class PcrFeatureDetail
	{
		// Token: 0x06000974 RID: 2420 RVA: 0x00065FEC File Offset: 0x000641EC
		public PcrFeatureDetail(string name, global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region, global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode featureCode, global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixCfsModelType supportedModelType)
		{
			this.Name = name;
			this.Region = region;
			this.FeatureCode = featureCode;
			this.SupportedModelType = supportedModelType;
			this.PreconditionFeatures = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>();
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00066028 File Offset: 0x00064228
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x000660D4 File Offset: 0x000642D4
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1747124225;
				if (num != 0)
				{
				}
				num = (short)675333377;
				short num2 = num;
				num = (short)1428866305;
				switch (num2 == num)
				{
				}
				num = (short)1684144128;
				short num3 = num;
				num = (short)990969856;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)783286273;
				if (num != 0)
				{
				}
				num = (short)664149707;
				short num2 = num;
				num = (short)358686411;
				switch (num2 == num)
				{
				}
				num = (short)1825046528;
				short num3 = num;
				num = (short)1520435200;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00066188 File Offset: 0x00064388
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x0006623C File Offset: 0x0006443C
		public string Notice
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)630431953;
				short num2 = num;
				num = (short)974233809;
				switch (num2 == num)
				{
				}
				num = (short)1772552193;
				if (num != 0)
				{
				}
				num = (short)1146814464;
				short num3 = num;
				num = (short)809172992;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1497751860;
				short num2 = num;
				num = (short)1465508148;
				switch (num2 == num)
				{
				}
				num = (short)1187315713;
				if (num != 0)
				{
				}
				num = (short)1535311872;
				short num3 = num;
				num = (short)1454637056;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x000662EC File Offset: 0x000644EC
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x0006639C File Offset: 0x0006459C
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? Region
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1347408907;
				short num2 = num;
				num = (short)900387851;
				switch (num2 == num)
				{
				}
				num = (short)778371073;
				if (num != 0)
				{
				}
				num = (short)1718747136;
				short num3 = num;
				num = (short)2140340224;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)477822977;
				if (num != 0)
				{
				}
				num = (short)289657860;
				short num2 = num;
				num = (short)1729876996;
				switch (num2 == num)
				{
				}
				num = (short)480313344;
				short num3 = num;
				num = (short)811204608;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x00066450 File Offset: 0x00064650
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x000664FC File Offset: 0x000646FC
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode FeatureCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1199766064;
				short num2 = num;
				num = (short)1231419952;
				switch (num2 == num)
				{
				}
				num = (short)27131905;
				if (num != 0)
				{
				}
				num = (short)434044928;
				short num3 = num;
				num = (short)554237952;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1420364492;
				short num2 = num;
				num = (short)1398475468;
				switch (num2 == num)
				{
				}
				num = (short)29097984;
				if (num != 0)
				{
				}
				num = (short)744095744;
				short num3 = num;
				num = (short)895877121;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x000665AC File Offset: 0x000647AC
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x0006665C File Offset: 0x0006485C
		public global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixCfsModelType SupportedModelType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)553438689;
				short num2 = num;
				num = (short)122670561;
				switch (num2 == num)
				{
				}
				num = (short)1605107713;
				if (num != 0)
				{
				}
				num = (short)121438208;
				short num3 = num;
				num = (short)2100494336;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1926631672;
				short num2 = num;
				num = (short)490606840;
				switch (num2 == num)
				{
				}
				num = (short)1542586369;
				if (num != 0)
				{
				}
				num = (short)1376714752;
				short num3 = num;
				num = (short)1566113792;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x00066710 File Offset: 0x00064910
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x000667C4 File Offset: 0x000649C4
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode> PreconditionFeatures
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)55898262;
				short num2 = num;
				num = (short)1097461910;
				switch (num2 == num)
				{
				}
				num = (short)614727681;
				if (num != 0)
				{
				}
				num = (short)1089994752;
				short num3 = num;
				num = (short)158007296;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2143682561;
				if (num != 0)
				{
				}
				num = (short)1557717295;
				short num2 = num;
				num = (short)919003439;
				switch (num2 == num)
				{
				}
				num = (short)748748800;
				short num3 = num;
				num = (short)772210688;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00066878 File Offset: 0x00064A78
		public bool Equals(global::Motorola.CommonCPS.Server.EntityModel.PcrFeatureDetail that)
		{
			short num = (short)1336737794;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1855716588;
					short num3 = num;
					num = (short)367262956;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
					{
						num = (short)493420544;
						if (num != 0)
						{
						}
						num = (short)1815478273;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region;
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region2;
						if (!(region.GetValueOrDefault() == region2.GetValueOrDefault() & region != null == (region2 != null)))
						{
							num = (short)475922433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1666121739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_1B9;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 3:
				{
					if (this.FeatureCode != that.FeatureCode)
					{
						num = (short)1048117258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region = this.Region;
					global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region2 = that.Region;
					num = (short)1170341888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (this.Name != that.Name)
					{
						num = (short)1300234247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)787349507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!this.PreconditionFeatures.SequenceEqual(that.PreconditionFeatures))
					{
						num = (short)561971209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					if (this.SupportedModelType != that.SupportedModelType)
					{
						num = (short)554041352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.PreconditionFeatures.Sort();
					that.PreconditionFeatures.Sort();
					num = (short)949092357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_54:
				if (that == null)
				{
					num = (short)303235072;
					short num4 = num;
					num = (short)743964678;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)892338180;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_1B9:
			return false;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00066B38 File Offset: 0x00064D38
		public override string ToString()
		{
			int a_ = 16;
			short num = (short)1545535488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region;
				string text;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						region = this.Region;
						text = region.Value.ToString();
						num = (short)1288896513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_15A;
					case 2:
						goto IL_B0;
					}
					goto IL_43;
				}
				IL_15A:
				goto IL_15C;
				IL_43:
				text = string.Empty;
				region = this.Region;
				num = (short)1673987104;
				short num3 = num;
				num = (short)182125600;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_B0:
					num = (short)956104704;
					short num4 = num;
					num = (short)1881210881;
					if (num != 0)
					{
					}
					if (region != null)
					{
						num = (short)1363410944;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_30;
					}
					break;
				}
				default:
					num = (short)2044461056;
					if (num != 0)
					{
					}
					num = (short)873529346;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				IL_15C:
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("甍‏漑㐓洕⤗朙㰛攝ሟ弡У崥ᬧ圩ఫ甭䬯ر䤳欵", a_), new object[]
				{
					this.Name,
					text,
					this.FeatureCode.ToString(),
					this.SupportedModelType.ToString(),
					string.Join<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("⸍㘏㈑", a_), this.PreconditionFeatures)
				});
			}
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00066D18 File Offset: 0x00064F18
		public global::Motorola.CommonCPS.Server.EntityModel.PcrFeatureDetail Clone()
		{
			short num = (short)814543341;
			short num2 = num;
			num = (short)1548612077;
			switch (num2 == num)
			{
			}
			num = (short)787677184;
			if (num != 0)
			{
			}
			num = (short)422051840;
			short num3 = num;
			num = (short)1376845825;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.PcrFeatureDetail.a a = new global::Motorola.CommonCPS.Server.EntityModel.PcrFeatureDetail.a();
			a.a = new global::Motorola.CommonCPS.Server.EntityModel.PcrFeatureDetail(this.Name, this.Region, this.FeatureCode, this.SupportedModelType);
			this.PreconditionFeatures.ForEach(new global::System.Action<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>(a.b));
			return a.a;
		}

		// Token: 0x04000485 RID: 1157
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x04000486 RID: 1158
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x04000487 RID: 1159
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? c;

		// Token: 0x04000488 RID: 1160
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode d;

		// Token: 0x04000489 RID: 1161
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixCfsModelType e;

		// Token: 0x0400048A RID: 1162
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode> f;

		// Token: 0x0200007D RID: 125
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000985 RID: 2437 RVA: 0x00066E1C File Offset: 0x0006501C
			internal void b(global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode A_0)
			{
				short num = (short)411435009;
				if (num != 0)
				{
				}
				num = (short)1429317603;
				short num2 = num;
				num = (short)1504946147;
				switch (num2 == num)
				{
				}
				num = (short)305004544;
				short num3 = num;
				num = (short)2089418752;
				if (num != 0)
				{
				}
				this.a.PreconditionFeatures.Add(A_0);
			}

			// Token: 0x0400048B RID: 1163
			public global::Motorola.CommonCPS.Server.EntityModel.PcrFeatureDetail a;
		}
	}
}
