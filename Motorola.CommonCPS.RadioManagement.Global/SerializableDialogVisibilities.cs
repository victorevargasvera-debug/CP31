using System;
using System.Collections.Generic;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.Global
{
	// Token: 0x02000008 RID: 8
	[global::System.Configuration.SettingsSerializeAs(global::System.Configuration.SettingsSerializeAs.Xml)]
	public class SerializableDialogVisibilities
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002808 File Offset: 0x00000A08
		public SerializableDialogVisibilities()
		{
			this.Dialogs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.SerializableDialogVisibilities.SerializableDialog>();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002828 File Offset: 0x00000A28
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000028D8 File Offset: 0x00000AD8
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.SerializableDialogVisibilities.SerializableDialog> Dialogs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1308537342;
				short num2 = num;
				num = (short)1986048510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)89456640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1670447105;
				if (num != 0)
				{
				}
				num = (short)240123904;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1247614592;
				short num2 = num;
				num = (short)2038437504;
				switch (num2 == num)
				{
				default:
				{
					num = (short)88801280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)723386369;
				if (num != 0)
				{
				}
				num = (short)951451648;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x04000014 RID: 20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.SerializableDialogVisibilities.SerializableDialog> a;

		// Token: 0x02000009 RID: 9
		public class SerializableDialog
		{
			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000013 RID: 19 RVA: 0x00002988 File Offset: 0x00000B88
			// (set) Token: 0x06000014 RID: 20 RVA: 0x00002A34 File Offset: 0x00000C34
			public string Operation
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)1624477769;
					short num2 = num;
					num = (short)920358985;
					switch (num2 == num)
					{
					default:
					{
						num = (short)630980608;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)2006712321;
					if (num != 0)
					{
					}
					num = (short)1444282368;
					if (num != 0)
					{
					}
					return this.a;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)750923670;
					short num2 = num;
					num = (short)238890902;
					switch (num2 == num)
					{
					default:
					{
						num = (short)1690959872;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)836829185;
					if (num != 0)
					{
					}
					num = (short)1955004416;
					if (num != 0)
					{
					}
					this.a = value;
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000015 RID: 21 RVA: 0x00002AE4 File Offset: 0x00000CE4
			// (set) Token: 0x06000016 RID: 22 RVA: 0x00002B90 File Offset: 0x00000D90
			public bool Show
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)1071097120;
					short num2 = num;
					num = (short)937927968;
					switch (num2 == num)
					{
					default:
					{
						num = (short)1814560768;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)1905328128;
					if (num != 0)
					{
					}
					num = (short)643629057;
					if (num != 0)
					{
					}
					return this.b;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)48219646;
					short num2 = num;
					num = (short)1974388222;
					switch (num2 == num)
					{
					default:
					{
						num = (short)1291255808;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)138870784;
					if (num != 0)
					{
					}
					num = (short)925827073;
					if (num != 0)
					{
					}
					this.b = value;
				}
			}

			// Token: 0x04000015 RID: 21
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private string a;

			// Token: 0x04000016 RID: 22
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private bool b;
		}
	}
}
