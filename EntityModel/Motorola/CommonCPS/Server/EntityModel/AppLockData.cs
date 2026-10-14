using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000023 RID: 35
	public class AppLockData
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000ED74 File Offset: 0x0000CF74
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000EE28 File Offset: 0x0000D028
		public global::System.Guid Uuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1194562755;
				short num2 = num;
				num = (short)110269635;
				switch (num2 == num)
				{
				default:
				{
					num = (short)150077440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)250216448;
				if (num != 0)
				{
				}
				num = (short)1808793601;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)625694182;
				short num2 = num;
				num = (short)545740262;
				switch (num2 == num)
				{
				}
				num = (short)146604032;
				short num3 = num;
				num = (short)2109734913;
				if (num != 0)
				{
				}
				num = (short)1652424704;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000EED8 File Offset: 0x0000D0D8
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0000EF8C File Offset: 0x0000D18C
		public global::System.Guid JobID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)128054273;
				short num2 = num;
				num = (short)2004939777;
				switch (num2 == num)
				{
				}
				num = (short)381485056;
				short num3 = num;
				num = (short)478085120;
				if (num != 0)
				{
				}
				num = (short)1620312065;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1916959293;
				short num2 = num;
				num = (short)2039970365;
				switch (num2 == num)
				{
				}
				num = (short)1434451968;
				short num3 = num;
				num = (short)345702401;
				if (num != 0)
				{
				}
				num = (short)280887296;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000F03C File Offset: 0x0000D23C
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
		public global::System.Guid EntityID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)915617284;
				short num2 = num;
				num = (short)15283716;
				switch (num2 == num)
				{
				}
				num = (short)1154940928;
				short num3 = num;
				num = (short)387514369;
				if (num != 0)
				{
				}
				num = (short)1470758912;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1531565332;
				short num2 = num;
				num = (short)1292817684;
				switch (num2 == num)
				{
				}
				num = (short)633602048;
				short num3 = num;
				num = (short)602669057;
				if (num != 0)
				{
				}
				num = (short)1401618432;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000F1A0 File Offset: 0x0000D3A0
		// (set) Token: 0x06000125 RID: 293 RVA: 0x0000F250 File Offset: 0x0000D450
		public global::Motorola.CommonCPS.Server.CommonDBConstants.AppLockType LockType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)893295231;
				short num2 = num;
				num = (short)679582335;
				switch (num2 == num)
				{
				}
				num = (short)737607680;
				short num3 = num;
				num = (short)1606418432;
				if (num != 0)
				{
				}
				num = (short)692977665;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1453085661;
				short num2 = num;
				num = (short)1813664733;
				switch (num2 == num)
				{
				}
				num = (short)1961492480;
				short num3 = num;
				num = (short)951451649;
				if (num != 0)
				{
				}
				num = (short)162136064;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000F300 File Offset: 0x0000D500
		public static int CleanData(global::System.Data.SqlClient.SqlConnection sqlConnect, global::Motorola.CommonCPS.Server.EntityModel.AppLockData target)
		{
			int a_ = 2;
			global::System.Data.SqlClient.SqlCommand sqlCommand = new global::System.Data.SqlClient.SqlCommand(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("哿倁儃䠅䬇䬉堋䬍』䘑唓吕吗弙㰛稝䈟䴡ਣ朥堧娩怫䄭匯失瀳圵䰷嬹", a_), sqlConnect);
			short num;
			int result;
			try
			{
				num = (short)2003042305;
				if (num != 0)
				{
				}
				result = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				num = (short)1012858882;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1118513643;
						short num3 = num;
						num = (short)1080699371;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1899626496;
							if (num != 0)
							{
							}
							((global::System.IDisposable)sqlCommand).Dispose();
							num = (short)2013200385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_10A;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					}
					IL_84:
					if (sqlCommand == null)
					{
						break;
					}
					num = (short)1532952576;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10A:;
			}
			num = (short)988872704;
			short num4 = num;
			return result;
		}

		// Token: 0x0400009D RID: 157
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid a;

		// Token: 0x0400009E RID: 158
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid b;

		// Token: 0x0400009F RID: 159
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid c;

		// Token: 0x040000A0 RID: 160
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.AppLockType d;
	}
}
