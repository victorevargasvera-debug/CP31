using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000AA RID: 170
	public class GeneralPackage : global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x0005B9F8 File Offset: 0x00059BF8
		public GeneralPackage() : base(new global::Motorola.CommonCPS.Server.EntityModel.PackageSummary())
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0005BA10 File Offset: 0x00059C10
		public GeneralPackage(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary) : base(summary)
		{
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0005BA24 File Offset: 0x00059C24
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x0005BAD0 File Offset: 0x00059CD0
		public bool Staged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1800332341;
				short num2 = num;
				num = (short)116581429;
				switch (num2 == num)
				{
				}
				num = (short)982515713;
				if (num != 0)
				{
				}
				num = (short)1525415936;
				if (num != 0)
				{
				}
				num = (short)1467940864;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1370882049;
				if (num != 0)
				{
				}
				num = (short)1679136633;
				short num2 = num;
				num = (short)684889977;
				switch (num2 == num)
				{
				}
				num = (short)778895360;
				if (num != 0)
				{
				}
				num = (short)1326907392;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0005BB80 File Offset: 0x00059D80
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x0005BC30 File Offset: 0x00059E30
		public bool Reboot
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1498060425;
				short num2 = num;
				num = (short)2008716937;
				switch (num2 == num)
				{
				}
				num = (short)1615331329;
				if (num != 0)
				{
				}
				num = (short)1228603392;
				if (num != 0)
				{
				}
				num = (short)593166336;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1314157093;
				short num2 = num;
				num = (short)655258149;
				switch (num2 == num)
				{
				}
				num = (short)1394933760;
				if (num != 0)
				{
				}
				num = (short)601423873;
				if (num != 0)
				{
				}
				num = (short)734265344;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0005BCE0 File Offset: 0x00059EE0
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x0005BE0C File Offset: 0x0005A00C
		public string Description
		{
			get
			{
				string result;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary generalPackageSummary;
					short num2;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							return result;
						case 1:
							if (generalPackageSummary != null)
							{
								num2 = (short)655949826;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						case 2:
						{
							num2 = (short)1488198225;
							short num3 = num2;
							num2 = (short)565189201;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)928776192;
								if (num2 != 0)
								{
								}
								num2 = (short)455606272;
								short num4 = num2;
								result = generalPackageSummary.PackageDescription;
								num2 = (short)1532690433;
								if (num2 != 0)
								{
								}
								num2 = (short)832372736;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
					}
					IL_1C:
					result = string.Empty;
					generalPackageSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary);
					num2 = (short)1756299265;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				return result;
			}
			set
			{
				short num = (short)115483339;
				short num2 = num;
				num = (short)1522082507;
				switch (num2 == num)
				{
				}
				num = (short)1607270401;
				if (num != 0)
				{
				}
				num = (short)1121124352;
				if (num != 0)
				{
				}
				num = (short)882704384;
				short num3 = num;
				value = (value ?? string.Empty);
				global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary generalPackageSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary;
				generalPackageSummary.PackageDescription = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0005BED8 File Offset: 0x0005A0D8
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x0005C010 File Offset: 0x0005A210
		public string ManifestRoot
		{
			get
			{
				string result;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					short num;
					int num2;
					global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary generalPackageSummary;
					for (;;)
					{
						IL_0A:
						num = (short)628424705;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							return result;
						case 1:
							if (!string.IsNullOrEmpty(generalPackageSummary.ManifestRoot))
							{
								num = (short)596246530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 2:
						{
							num = (short)2036366286;
							short num3 = num;
							num = (short)1569094606;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1044185088;
								short num4 = num;
								num = (short)811728896;
								if (num != 0)
								{
								}
								result = generalPackageSummary.ManifestRoot;
								num = (short)1652490240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						break;
					}
					IL_44:
					result = string.Empty;
					generalPackageSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary);
					num = (short)562888705;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				return result;
			}
			set
			{
				short num = (short)1787485511;
				short num2 = num;
				num = (short)132701511;
				switch (num2 == num)
				{
				}
				num = (short)1410859008;
				if (num != 0)
				{
				}
				num = (short)974716929;
				if (num != 0)
				{
				}
				num = (short)851181568;
				short num3 = num;
				value = (value ?? string.Empty);
				global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary generalPackageSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary;
				generalPackageSummary.ManifestRoot = value;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0005C0E0 File Offset: 0x0005A2E0
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x0005C21C File Offset: 0x0005A41C
		public string ManifestVersion
		{
			get
			{
				string result;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary generalPackageSummary;
					short num2;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							return result;
						case 1:
							if (!string.IsNullOrEmpty(generalPackageSummary.ManifestVersion))
							{
								num2 = (short)133300226;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						case 2:
						{
							num2 = (short)1224824615;
							short num3 = num2;
							num2 = (short)1108367143;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)698155008;
								short num4 = num2;
								num2 = (short)238354432;
								if (num2 != 0)
								{
								}
								result = generalPackageSummary.ManifestVersion;
								num2 = (short)1478098944;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
					}
					IL_1C:
					result = string.Empty;
					generalPackageSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary);
					num2 = (short)937558017;
					if (num2 != 0)
					{
					}
					num2 = (short)1411907585;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				return result;
			}
			set
			{
				short num = (short)1955685130;
				short num2 = num;
				num = (short)1267426058;
				switch (num2 == num)
				{
				}
				num = (short)1289158657;
				if (num != 0)
				{
				}
				num = (short)970981376;
				if (num != 0)
				{
				}
				num = (short)648216576;
				short num3 = num;
				value = (value ?? string.Empty);
				global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary generalPackageSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary;
				generalPackageSummary.ManifestVersion = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0005C2E8 File Offset: 0x0005A4E8
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x0005C414 File Offset: 0x0005A614
		public string Version
		{
			get
			{
				string result;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary generalPackageSummary;
					short num2;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							return result;
						case 1:
							if (generalPackageSummary != null)
							{
								num2 = (short)2068578305;
								if (num2 != 0)
								{
								}
								num2 = (short)1781530626;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						case 2:
						{
							num2 = (short)1043402892;
							short num3 = num2;
							num2 = (short)1242370188;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)638058496;
								short num4 = num2;
								num2 = (short)1865613312;
								if (num2 != 0)
								{
								}
								result = generalPackageSummary.PackageVersion;
								num2 = (short)1006436352;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
					}
					IL_1C:
					result = string.Empty;
					generalPackageSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary);
					num2 = (short)1826226177;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				return result;
			}
			set
			{
				short num = (short)45812679;
				short num2 = num;
				num = (short)913247175;
				switch (num2 == num)
				{
				}
				num = (short)1528299521;
				if (num != 0)
				{
				}
				num = (short)1676673024;
				if (num != 0)
				{
				}
				num = (short)133955584;
				short num3 = num;
				value = (value ?? string.Empty);
				global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary generalPackageSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary;
				generalPackageSummary.PackageVersion = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0005C4E0 File Offset: 0x0005A6E0
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x0005C5C8 File Offset: 0x0005A7C8
		public int Size
		{
			get
			{
				while (base.SummaryEntity.FileSize == null)
				{
					short num = (short)2127198041;
					short num2 = num;
					num = (short)300971865;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1509687296;
						short num3 = num;
						num = (short)391774209;
						if (num != 0)
						{
						}
						num = (short)1499856896;
						if (num != 0)
						{
						}
						return 0;
					}
					}
				}
				return (base.SummaryEntity.FileSize.Value + 1023) / 1024;
			}
			set
			{
				short num = (short)671174488;
				short num2 = num;
				num = (short)1079201624;
				switch (num2 == num)
				{
				}
				num = (short)413990913;
				if (num != 0)
				{
				}
				num = (short)398655488;
				if (num != 0)
				{
				}
				num = (short)2036924416;
				short num3 = num;
				base.SummaryEntity.FileSize = new int?(value * 1024 - 1023);
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0005C68C File Offset: 0x0005A88C
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x0005C740 File Offset: 0x0005A940
		public string VValue
		{
			get
			{
				short num = (short)141678837;
				short num2 = num;
				num = (short)1767758069;
				switch (num2 == num)
				{
				}
				num = (short)271450113;
				if (num != 0)
				{
				}
				num = (short)1676345344;
				if (num != 0)
				{
				}
				num = (short)1876033536;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)247973372;
				short num2 = num;
				num = (short)127583740;
				switch (num2 == num)
				{
				}
				num = (short)409337856;
				if (num != 0)
				{
				}
				num = (short)286785537;
				if (num != 0)
				{
				}
				num = (short)1392312320;
				short num3 = num;
				this.a = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage.get_VValue())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x040002C1 RID: 705
		private string a;

		// Token: 0x040002C2 RID: 706
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;

		// Token: 0x040002C3 RID: 707
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;
	}
}
