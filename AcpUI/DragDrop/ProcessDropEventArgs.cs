using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace AcpUI.DragDrop
{
	// Token: 0x0200006E RID: 110
	public class ProcessDropEventArgs<TItemType> : global::System.EventArgs where TItemType : class
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x00072B08 File Offset: 0x00070D08
		internal ProcessDropEventArgs(global::System.Collections.ObjectModel.ObservableCollection<TItemType> A_0, TItemType A_1, int A_2, int A_3, global::System.Windows.DragDropEffects A_4)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
			this.d = A_3;
			this.e = A_4;
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00072B40 File Offset: 0x00070D40
		internal global::System.Collections.ObjectModel.ObservableCollection<TItemType> ItemsSource
		{
			get
			{
				short num = (short)1850776947;
				short num2 = num;
				num = (short)2130091379;
				switch (num2 == num)
				{
				}
				num = (short)1719861248;
				short num3 = num;
				num = (short)27262977;
				if (num != 0)
				{
				}
				num = (short)879624192;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00072BF4 File Offset: 0x00070DF4
		internal TItemType DataItem
		{
			get
			{
				short num = (short)902781408;
				short num2 = num;
				num = (short)1160600032;
				switch (num2 == num)
				{
				}
				num = (short)445513728;
				short num3 = num;
				num = (short)1660878848;
				if (num != 0)
				{
				}
				num = (short)460062721;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00072CA4 File Offset: 0x00070EA4
		internal int OldIndex
		{
			get
			{
				short num = (short)1974664281;
				short num2 = num;
				num = (short)618658905;
				switch (num2 == num)
				{
				}
				num = (short)50659328;
				short num3 = num;
				num = (short)1859584001;
				if (num != 0)
				{
				}
				num = (short)880082944;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00072D54 File Offset: 0x00070F54
		internal int NewIndex
		{
			get
			{
				short num = (short)2048131073;
				if (num != 0)
				{
				}
				num = (short)1597821168;
				short num2 = num;
				num = (short)1466224880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)368902144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)54460416;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00072E04 File Offset: 0x00071004
		internal global::System.Windows.DragDropEffects AllowedEffects
		{
			get
			{
				short num = (short)1067515905;
				if (num != 0)
				{
				}
				num = (short)1416479095;
				short num2 = num;
				num = (short)860471671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)891355136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)309133312;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00072EB4 File Offset: 0x000710B4
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00072F64 File Offset: 0x00071164
		internal global::System.Windows.DragDropEffects Effects
		{
			get
			{
				short num = (short)188404423;
				short num2 = num;
				num = (short)1498796743;
				switch (num2 == num)
				{
				}
				num = (short)1159987200;
				short num3 = num;
				num = (short)1615003648;
				if (num != 0)
				{
				}
				num = (short)1998651393;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1263668895;
				short num2 = num;
				num = (short)1803554463;
				switch (num2 == num)
				{
				}
				num = (short)1997275136;
				short num3 = num;
				num = (short)263389185;
				if (num != 0)
				{
				}
				num = (short)2127495168;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x04000300 RID: 768
		private global::System.Collections.ObjectModel.ObservableCollection<TItemType> a;

		// Token: 0x04000301 RID: 769
		private TItemType b;

		// Token: 0x04000302 RID: 770
		private int c;

		// Token: 0x04000303 RID: 771
		private int d;

		// Token: 0x04000304 RID: 772
		private global::System.Windows.DragDropEffects e;

		// Token: 0x04000305 RID: 773
		private global::System.Windows.DragDropEffects f;
	}
}
