using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000059 RID: 89
	public class DBMigrationTemplateBasicInfo : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x0600028A RID: 650 RVA: 0x00027334 File Offset: 0x00025534
		public DBMigrationTemplateBasicInfo()
		{
			this.ReferencedRadioList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationRadioBasicInfo>();
			this.IsTemplateExist = false;
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00027360 File Offset: 0x00025560
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00027410 File Offset: 0x00025610
		public global::System.Guid TemplateUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1076425205;
				short num2 = num;
				num = (short)655880693;
				switch (num2 == num)
				{
				}
				num = (short)67960832;
				if (num != 0)
				{
				}
				num = (short)1147863041;
				if (num != 0)
				{
				}
				num = (short)1651376128;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)744865019;
				short num2 = num;
				num = (short)226934011;
				switch (num2 == num)
				{
				}
				num = (short)1941307393;
				if (num != 0)
				{
				}
				num = (short)114950144;
				if (num != 0)
				{
				}
				num = (short)55312384;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600028D RID: 653 RVA: 0x000274C0 File Offset: 0x000256C0
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00027570 File Offset: 0x00025770
		public string TemplateName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)140275723;
				short num2 = num;
				num = (short)566784011;
				switch (num2 == num)
				{
				}
				num = (short)1384382465;
				if (num != 0)
				{
				}
				num = (short)1857093632;
				if (num != 0)
				{
				}
				num = (short)832241664;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1158610945;
				if (num != 0)
				{
				}
				num = (short)1437028532;
				short num2 = num;
				num = (short)1981698228;
				switch (num2 == num)
				{
				}
				num = (short)2013003776;
				if (num != 0)
				{
				}
				num = (short)1530789888;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0002761C File Offset: 0x0002581C
		// (set) Token: 0x06000290 RID: 656 RVA: 0x000276CC File Offset: 0x000258CC
		public global::System.Guid ArchiveFileUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)831697196;
				short num2 = num;
				num = (short)412725548;
				switch (num2 == num)
				{
				}
				num = (short)1320353793;
				if (num != 0)
				{
				}
				num = (short)62193664;
				if (num != 0)
				{
				}
				num = (short)1894514688;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)64950905;
				short num2 = num;
				num = (short)324801145;
				switch (num2 == num)
				{
				}
				num = (short)632487936;
				if (num != 0)
				{
				}
				num = (short)391053312;
				short num3 = num;
				num = (short)354549761;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0002777C File Offset: 0x0002597C
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0002782C File Offset: 0x00025A2C
		public bool IsChecked
		{
			get
			{
				short num = (short)1638264692;
				short num2 = num;
				num = (short)2132275060;
				switch (num2 == num)
				{
				}
				num = (short)1108279296;
				if (num != 0)
				{
				}
				num = (short)255721472;
				short num3 = num;
				num = (short)1734082561;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)629932033;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1790438041;
						short num3 = num;
						num = (short)768600729;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_12C;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
					{
						this.a = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo.get_IsChecked())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1434320896;
						short num4 = num;
						num = (short)1360330752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_31:
					num = (short)1337655297;
					if (num != 0)
					{
					}
					if (value == this.a)
					{
						return;
					}
					num = (short)369033218;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12C:
				num = (short)318832640;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0002797C File Offset: 0x00025B7C
		// (set) Token: 0x06000294 RID: 660 RVA: 0x00027A2C File Offset: 0x00025C2C
		public bool IsTemplateExist
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1408201351;
				short num2 = num;
				num = (short)374305415;
				switch (num2 == num)
				{
				}
				num = (short)1617690625;
				if (num != 0)
				{
				}
				num = (short)1628766208;
				short num3 = num;
				num = (short)1532297216;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)912141766;
				short num2 = num;
				num = (short)591932870;
				switch (num2 == num)
				{
				}
				num = (short)1084686337;
				if (num != 0)
				{
				}
				num = (short)258342912;
				short num3 = num;
				num = (short)1138688000;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00027ADC File Offset: 0x00025CDC
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00027B8C File Offset: 0x00025D8C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationRadioBasicInfo> ReferencedRadioList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)117299349;
				short num2 = num;
				num = (short)1091491989;
				switch (num2 == num)
				{
				}
				num = (short)700973056;
				if (num != 0)
				{
				}
				num = (short)572981248;
				short num3 = num;
				num = (short)2045378561;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2056155736;
				short num2 = num;
				num = (short)1324446296;
				switch (num2 == num)
				{
				}
				num = (short)1464139777;
				if (num != 0)
				{
				}
				num = (short)1327038464;
				short num3 = num;
				num = (short)798687232;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x04000112 RID: 274
		private bool a = true;

		// Token: 0x04000113 RID: 275
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid b;

		// Token: 0x04000114 RID: 276
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x04000115 RID: 277
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid d;

		// Token: 0x04000116 RID: 278
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool e;

		// Token: 0x04000117 RID: 279
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationRadioBasicInfo> f;
	}
}
