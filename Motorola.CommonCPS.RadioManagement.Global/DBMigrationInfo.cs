using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.Global
{
	// Token: 0x02000006 RID: 6
	public class DBMigrationInfo
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000023B0 File Offset: 0x000005B0
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002460 File Offset: 0x00000660
		public string LegacyDBVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1900081611;
				short num2 = num;
				num = (short)584315339;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1805123584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1582104576;
				if (num != 0)
				{
				}
				num = (short)462356481;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)878380260;
				short num2 = num;
				num = (short)301794532;
				switch (num2 == num)
				{
				default:
				{
					num = (short)260046848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)982122497;
				if (num != 0)
				{
				}
				num = (short)306839552;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002510 File Offset: 0x00000710
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000025C4 File Offset: 0x000007C4
		public global::Motorola.CommonCPS.RadioManagement.Global.MigrationProgress CurrentProgress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2029980371;
				short num2 = num;
				num = (short)1537280723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)926613504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1698758657;
				if (num != 0)
				{
				}
				num = (short)1103036416;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2017263901;
				short num2 = num;
				num = (short)143261981;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1749352448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2049507329;
				if (num != 0)
				{
				}
				num = (short)488570880;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x04000011 RID: 17
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x04000012 RID: 18
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.Global.MigrationProgress b;
	}
}
