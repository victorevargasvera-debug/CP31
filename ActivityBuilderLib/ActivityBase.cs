using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.ActivityBuilderLib
{
	// Token: 0x0200000D RID: 13
	public class ActivityBase : global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ItemBase
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00005FA0 File Offset: 0x000041A0
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00006054 File Offset: 0x00004254
		[global::System.ComponentModel.Browsable(false)]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)59572225;
				if (num != 0)
				{
				}
				num = (short)527118714;
				short num2 = num;
				num = (short)896020858;
				switch (num2 == num)
				{
				}
				num = (short)307363840;
				short num3 = num;
				num = (short)1056243712;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2143603354;
				short num2 = num;
				num = (short)1993001626;
				switch (num2 == num)
				{
				}
				num = (short)1157496832;
				if (num != 0)
				{
				}
				num = (short)1975386112;
				short num3 = num;
				num = (short)272564225;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00006104 File Offset: 0x00004304
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000061B8 File Offset: 0x000043B8
		[global::System.ComponentModel.Browsable(false)]
		public string Description
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1047592961;
				if (num != 0)
				{
				}
				num = (short)719696768;
				short num2 = num;
				num = (short)742896512;
				switch (num2 == num)
				{
				}
				num = (short)1159725056;
				short num3 = num;
				num = (short)1681260544;
				if (num != 0)
				{
				}
				return this.<Description>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1287979009;
				if (num != 0)
				{
				}
				num = (short)1563388777;
				short num2 = num;
				num = (short)1504078697;
				switch (num2 == num)
				{
				}
				num = (short)878116864;
				short num3 = num;
				num = (short)1486422016;
				if (num != 0)
				{
				}
				this.<Description>k__BackingField = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000626C File Offset: 0x0000446C
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000631C File Offset: 0x0000451C
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase> Widgets
		{
			get
			{
				short num = (short)101728309;
				short num2 = num;
				num = (short)483541045;
				switch (num2 == num)
				{
				}
				num = (short)1217789953;
				if (num != 0)
				{
				}
				num = (short)561971200;
				short num3 = num;
				num = (short)181927936;
				if (num != 0)
				{
				}
				return this.widgets;
			}
			set
			{
				int a_ = 4;
				short num = (short)1434139046;
				short num2 = num;
				num = (short)1197685158;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1298399232;
					if (num != 0)
					{
					}
					num = (short)1547632641;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_10E;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_85;
							}
							continue;
						case 2:
						{
							this.widgets = value;
							this.NotifyChanged(new string[]
							{
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("쒒ﲔﺘﺚ", a_)
							});
							num = (short)522321920;
							short num4 = num;
							num = (short)233242624;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_85:
						if (this.widgets == value)
						{
							return;
						}
						num = (short)1756823554;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_10E:
					num = (short)1921712129;
					if (num != 0)
					{
					}
					break;
				}
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00006460 File Offset: 0x00004660
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00006510 File Offset: 0x00004710
		[global::System.ComponentModel.Browsable(false)]
		public double Height
		{
			get
			{
				short num = (short)75593191;
				short num2 = num;
				num = (short)1382381031;
				switch (num2 == num)
				{
				}
				num = (short)411959297;
				if (num != 0)
				{
				}
				num = (short)1757151232;
				short num3 = num;
				num = (short)790429696;
				if (num != 0)
				{
				}
				return this.height;
			}
			set
			{
				int a_ = 6;
				short num = (short)147759431;
				short num2 = num;
				num = (short)1443144007;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)893452289;
					if (num != 0)
					{
					}
					num = (short)207749120;
					if (num != 0)
					{
					}
					num = (short)1749417985;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_152;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_AF;
							}
							continue;
						case 2:
						{
							num = (short)767492096;
							short num4 = num;
							this.height = value;
							this.NotifyChanged(new string[]
							{
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("\udd94ﲚ", a_)
							});
							this.NotifyChanged(new string[]
							{
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("솔ﺚ햜爵좠쒢춤펦", a_)
							});
							num = (short)1740177408;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_AF:
						if (this.height == value)
						{
							break;
						}
						num = (short)216793090;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_152:
					break;
				}
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00006674 File Offset: 0x00004874
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000672C File Offset: 0x0000492C
		[global::System.ComponentModel.Browsable(false)]
		public double TrueHeight
		{
			get
			{
				short num = (short)91815937;
				if (num != 0)
				{
				}
				num = (short)1680964641;
				short num2 = num;
				num = (short)761691169;
				switch (num2 == num)
				{
				}
				num = (short)480903168;
				short num3 = num;
				num = (short)1900544;
				if (num != 0)
				{
				}
				return this.Height + 5.0;
			}
			set
			{
				int a_ = 5;
				short num = (short)160695483;
				short num2 = num;
				num = (short)452199611;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1317666816;
					if (num != 0)
					{
					}
					num = (short)446038017;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_133;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_84;
							}
							continue;
						case 2:
						{
							num = (short)1932460032;
							short num4 = num;
							this.trueHeight = value;
							this.NotifyChanged(new string[]
							{
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("삓ﾙ풛ﮝ즟얡첣튥", a_)
							});
							num = (short)2086535168;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_84:
						if (this.trueHeight == value)
						{
							break;
						}
						num = (short)528941057;
						if (num != 0)
						{
						}
						num = (short)1572405250;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_133:
					break;
				}
				}
			}
		}

		// Token: 0x04000026 RID: 38
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase> widgets;

		// Token: 0x04000027 RID: 39
		private double height = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultcanvasHeight;

		// Token: 0x04000028 RID: 40
		private double trueHeight;
	}
}
