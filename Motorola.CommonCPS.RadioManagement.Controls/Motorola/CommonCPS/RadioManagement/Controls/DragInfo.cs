using System;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000047 RID: 71
	public class DragInfo
	{
		// Token: 0x060000FF RID: 255 RVA: 0x000104D4 File Offset: 0x0000E6D4
		private DragInfo()
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000104E8 File Offset: 0x0000E6E8
		public static global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo Instance
		{
			get
			{
				short num = (short)1315046553;
				short num2 = num;
				num = (short)677119129;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2080768000;
					if (num != 0)
					{
					}
					num = (short)969474049;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					num = (short)2024407041;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						num = (short)2134966272;
						short num4 = num;
						global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo.a = new global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo();
						num = (short)1541210114;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 2:
						goto IL_10A;
					}
					IL_A2:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo.a != null)
					{
						break;
					}
					num = (short)2051276800;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_10A:
				return global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo.a;
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00010608 File Offset: 0x0000E808
		public void Clear()
		{
			short num = (short)192387959;
			short num2 = num;
			num = (short)1095080823;
			switch (num2 == num)
			{
			}
			num = (short)317587457;
			if (num != 0)
			{
			}
			num = (short)977272832;
			short num3 = num;
			num = (short)594083840;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo.a = new global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000106B8 File Offset: 0x0000E8B8
		public string Format
		{
			get
			{
				short num = (short)689714984;
				short num2 = num;
				num = (short)1701001000;
				switch (num2 == num)
				{
				}
				num = (short)472121344;
				if (num != 0)
				{
				}
				num = (short)1033043968;
				short num3 = num;
				num = (short)445710337;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.b;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00010764 File Offset: 0x0000E964
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00010810 File Offset: 0x0000EA10
		public global::System.Windows.Point DragStartPoint
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1892890097;
				short num2 = num;
				num = (short)157758961;
				switch (num2 == num)
				{
				}
				num = (short)39780353;
				if (num != 0)
				{
				}
				num = (short)123469824;
				short num3 = num;
				num = (short)494141440;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)695536002;
				short num2 = num;
				num = (short)26216834;
				switch (num2 == num)
				{
				}
				num = (short)1426915329;
				if (num != 0)
				{
				}
				num = (short)303693824;
				short num3 = num;
				num = (short)1073676288;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000108C0 File Offset: 0x0000EAC0
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0001096C File Offset: 0x0000EB6C
		public global::System.Windows.DragDropEffects Effects
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)875172995;
				short num2 = num;
				num = (short)192615555;
				switch (num2 == num)
				{
				}
				num = (short)1707016192;
				if (num != 0)
				{
				}
				num = (short)92798976;
				short num3 = num;
				num = (short)694026241;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)491348930;
				short num2 = num;
				num = (short)1574593474;
				switch (num2 == num)
				{
				}
				num = (short)1838809089;
				if (num != 0)
				{
				}
				num = (short)863371264;
				short num3 = num;
				num = (short)727056384;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00010A20 File Offset: 0x0000EC20
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		public global::System.Windows.UIElement VisualSource
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)753853067;
				short num2 = num;
				num = (short)1158996619;
				switch (num2 == num)
				{
				}
				num = (short)1785790465;
				if (num != 0)
				{
				}
				num = (short)501743616;
				short num3 = num;
				num = (short)346619904;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)1812201473;
				if (num != 0)
				{
				}
				num = (short)961482015;
				short num2 = num;
				num = (short)728567071;
				switch (num2 == num)
				{
				}
				num = (short)2117009408;
				short num3 = num;
				num = (short)1539178496;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00010B84 File Offset: 0x0000ED84
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00010C34 File Offset: 0x0000EE34
		public global::System.Windows.UIElement DragItem
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)789245867;
				short num2 = num;
				num = (short)420933547;
				switch (num2 == num)
				{
				}
				num = (short)1459159041;
				if (num != 0)
				{
				}
				num = (short)1955135488;
				short num3 = num;
				num = (short)512360448;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)450756609;
				if (num != 0)
				{
				}
				num = (short)1430393154;
				short num2 = num;
				num = (short)2090930498;
				switch (num2 == num)
				{
				}
				num = (short)188481536;
				short num3 = num;
				num = (short)2132082688;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00010CE8 File Offset: 0x0000EEE8
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00010D98 File Offset: 0x0000EF98
		public object Data
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)521548745;
				short num2 = num;
				num = (short)870134729;
				switch (num2 == num)
				{
				}
				num = (short)431554560;
				if (num != 0)
				{
				}
				num = (short)1936457728;
				short num3 = num;
				num = (short)924778497;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1687748609;
				if (num != 0)
				{
				}
				num = (short)460513719;
				short num2 = num;
				num = (short)630776247;
				switch (num2 == num)
				{
				}
				num = (short)46661632;
				short num3 = num;
				num = (short)1062666240;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x04000022 RID: 34
		private static global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo a;

		// Token: 0x04000023 RID: 35
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Point b;

		// Token: 0x04000024 RID: 36
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.DragDropEffects c;

		// Token: 0x04000025 RID: 37
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.UIElement d;

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.UIElement e;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private object f;
	}
}
