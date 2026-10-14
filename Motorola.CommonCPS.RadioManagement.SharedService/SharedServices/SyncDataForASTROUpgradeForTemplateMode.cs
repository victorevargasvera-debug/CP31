using System;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000BB RID: 187
	public class SyncDataForASTROUpgradeForTemplateMode : global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00082E70 File Offset: 0x00081070
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00082F20 File Offset: 0x00081120
		public byte[] CpFileContent
		{
			get
			{
				short num = (short)1317076992;
				short num2 = num;
				num = (short)991952897;
				if (num != 0)
				{
				}
				num = (short)1630100837;
				short num3 = num;
				num = (short)791305573;
				switch (num3 == num)
				{
				}
				num = (short)309329920;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1316290560;
				short num2 = num;
				num = (short)655343660;
				short num3 = num;
				num = (short)673759276;
				switch (num3 == num)
				{
				}
				num = (short)2043019264;
				if (num != 0)
				{
				}
				num = (short)2099511297;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00082FD0 File Offset: 0x000811D0
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x0008307C File Offset: 0x0008127C
		public global::Motorola.CommonCPS.Server.EntityModel.APXTemplate SourceTemplate
		{
			get
			{
				short num = (short)924188672;
				short num2 = num;
				num = (short)2057163066;
				short num3 = num;
				num = (short)1617023290;
				switch (num3 == num)
				{
				}
				num = (short)1598947329;
				if (num != 0)
				{
				}
				num = (short)461045760;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1927282688;
				short num2 = num;
				num = (short)1963735704;
				short num3 = num;
				num = (short)710359704;
				switch (num3 == num)
				{
				}
				num = (short)1559298049;
				if (num != 0)
				{
				}
				num = (short)1757741056;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0008312C File Offset: 0x0008132C
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x000831DC File Offset: 0x000813DC
		public global::Motorola.CommonCPS.Server.EntityModel.APXTemplate TargetTemplate
		{
			get
			{
				short num = (short)1037828096;
				short num2 = num;
				num = (short)985530468;
				short num3 = num;
				num = (short)964821092;
				switch (num3 == num)
				{
				}
				num = (short)232390657;
				if (num != 0)
				{
				}
				num = (short)1358168064;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)838139904;
				short num2 = num;
				num = (short)652648075;
				short num3 = num;
				num = (short)1708039819;
				switch (num3 == num)
				{
				}
				num = (short)1120075777;
				if (num != 0)
				{
				}
				num = (short)1213267968;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0008328C File Offset: 0x0008148C
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x0008333C File Offset: 0x0008153C
		public global::Motorola.CommonCPS.Server.EntityModel.APXTemplate TargetTemplateCross712Upgrade
		{
			get
			{
				short num = (short)81002496;
				short num2 = num;
				num = (short)757477590;
				short num3 = num;
				num = (short)475148502;
				switch (num3 == num)
				{
				}
				num = (short)936378368;
				if (num != 0)
				{
				}
				num = (short)1178402817;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1671168000;
				short num2 = num;
				num = (short)396712346;
				short num3 = num;
				num = (short)1744001434;
				switch (num3 == num)
				{
				}
				num = (short)1788674049;
				if (num != 0)
				{
				}
				num = (short)514195456;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00083400 File Offset: 0x00081600
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1691389166 + A_1) + (global::System.IntPtr)38 + (global::System.IntPtr)33 + (global::System.IntPtr)97);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x040001A6 RID: 422
		private byte[] a;

		// Token: 0x040001A7 RID: 423
		private global::Motorola.CommonCPS.Server.EntityModel.APXTemplate b;

		// Token: 0x040001A8 RID: 424
		private global::Motorola.CommonCPS.Server.EntityModel.APXTemplate c;

		// Token: 0x040001A9 RID: 425
		private global::Motorola.CommonCPS.Server.EntityModel.APXTemplate d;
	}
}
