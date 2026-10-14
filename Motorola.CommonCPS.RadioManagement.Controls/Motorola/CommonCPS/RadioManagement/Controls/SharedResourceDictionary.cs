using System;
using System.Collections.Generic;
using System.Windows;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000D5 RID: 213
	public class SharedResourceDictionary : global::System.Windows.ResourceDictionary
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00060F90 File Offset: 0x0005F190
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00061044 File Offset: 0x0005F244
		public new global::System.Uri Source
		{
			get
			{
				short num = (short)1545083462;
				short num2 = num;
				num = (short)646978118;
				switch (num2 == num)
				{
				}
				num = (short)621608960;
				short num3 = num;
				num = (short)614203393;
				if (num != 0)
				{
				}
				num = (short)175308800;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)379781121;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				int num2;
				global::System.WeakReference weakReference;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						num = (short)1352614945;
						short num3 = num;
						num = (short)187974689;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_133;
						default:
							goto IL_10A;
						}
						break;
					}
					case 1:
						if (weakReference != null)
						{
							num = (short)886112258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B2;
					case 2:
						num = (short)29491205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!global::Motorola.CommonCPS.RadioManagement.Controls.SharedResourceDictionary.a.ContainsKey(this.b))
						{
							num = (short)1507065860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						weakReference = global::Motorola.CommonCPS.RadioManagement.Controls.SharedResourceDictionary.a[this.b];
						goto IL_133;
					case 4:
						goto IL_96;
					case 5:
						if (weakReference.IsAlive)
						{
							num = (short)1930952704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B2;
					}
					goto IL_4F;
					IL_133:
					num = (short)641531905;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_96:
				this.a();
				return;
				IL_10A:
				num = (short)1195180032;
				if (num != 0)
				{
				}
				num = (short)2024603648;
				short num4 = num;
				base.MergedDictionaries.Add((global::System.Windows.ResourceDictionary)weakReference.Target);
				return;
				IL_1B2:
				this.a();
				return;
				IL_4F:
				this.b = value;
				num = (short)1464401923;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0006120C File Offset: 0x0005F40C
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E4;
				case 1:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.SharedResourceDictionary.a.ContainsKey(this.b))
					{
						num2 = (short)903479298;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_132;
				case 2:
					global::Motorola.CommonCPS.RadioManagement.Controls.SharedResourceDictionary.a.Remove(this.b);
					num2 = (short)794951681;
					if (num2 != 0)
					{
					}
					num2 = (short)1270808576;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_E4:
			num2 = (short)966345496;
			short num3 = num2;
			num2 = (short)1268925208;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)142409728;
				if (num2 != 0)
				{
				}
				break;
			}
			IL_132:
			global::Motorola.CommonCPS.RadioManagement.Controls.SharedResourceDictionary.a.Add(this.b, new global::System.WeakReference(this, false));
			return;
			IL_1C:
			num2 = (short)1230831616;
			short num4 = num2;
			base.Source = this.b;
			num2 = (short)428277761;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00061378 File Offset: 0x0005F578
		// Note: this type is marked as 'beforefieldinit'.
		static SharedResourceDictionary()
		{
			short num = (short)1849629383;
			short num2 = num;
			num = (short)1903499975;
			switch (num2 == num)
			{
			}
			num = (short)393609216;
			short num3 = num;
			num = (short)241041408;
			if (num != 0)
			{
			}
			num = (short)33030145;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.SharedResourceDictionary.a = (global::Motorola.CommonCPS.RadioManagement.Controls.SharedResourceDictionary.a = new global::System.Collections.Generic.Dictionary<global::System.Uri, global::System.WeakReference>());
		}

		// Token: 0x0400029A RID: 666
		private static global::System.Collections.Generic.Dictionary<global::System.Uri, global::System.WeakReference> a;

		// Token: 0x0400029B RID: 667
		private global::System.Uri b;
	}
}
