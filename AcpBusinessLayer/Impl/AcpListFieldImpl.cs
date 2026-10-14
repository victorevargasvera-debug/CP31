using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AcpCommonLib;

namespace AcpBusinessLayer.Impl
{
	// Token: 0x02000062 RID: 98
	internal class AcpListFieldImpl : global::AcpBusinessLayer.Impl.AcpFieldImpl<int>
	{
		// Token: 0x06000564 RID: 1380 RVA: 0x00071214 File Offset: 0x0006F414
		internal AcpListFieldImpl(string uiName) : base(uiName)
		{
			this.f = new global::System.Collections.BitArray(32, true);
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00071238 File Offset: 0x0006F438
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x000712E8 File Offset: 0x0006F4E8
		internal global::AcpCommonLib.ListItemStateConstraint IsIndexValid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1795555328;
				short num2 = num;
				num = (short)21533796;
				short num3 = num;
				num = (short)1899009124;
				switch (num3 == num)
				{
				}
				num = (short)215482369;
				if (num != 0)
				{
				}
				num = (short)897974272;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)949354496;
				short num2 = num;
				num = (short)825204707;
				short num3 = num;
				num = (short)1625595875;
				switch (num3 == num)
				{
				}
				num = (short)612958209;
				if (num != 0)
				{
				}
				num = (short)443678720;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x0007139C File Offset: 0x0006F59C
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00071448 File Offset: 0x0006F648
		internal global::AcpCommonLib.ListItemImageConstraint IndexImage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)690421760;
				short num2 = num;
				num = (short)1075803434;
				short num3 = num;
				num = (short)350909738;
				switch (num3 == num)
				{
				}
				num = (short)2025783297;
				if (num != 0)
				{
				}
				num = (short)19595264;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)910032896;
				short num2 = num;
				num = (short)460330297;
				short num3 = num;
				num = (short)40506681;
				switch (num3 == num)
				{
				}
				num = (short)1047330817;
				if (num != 0)
				{
				}
				num = (short)889454592;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x000714F4 File Offset: 0x0006F6F4
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x000715A4 File Offset: 0x0006F7A4
		internal bool SerializeItems
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1153236992;
				short num2 = num;
				num = (short)1819557220;
				short num3 = num;
				num = (short)2041527652;
				switch (num3 == num)
				{
				}
				num = (short)142016512;
				if (num != 0)
				{
				}
				num = (short)1548222465;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)223805440;
				short num2 = num;
				num = (short)2001420187;
				short num3 = num;
				num = (short)1269776283;
				switch (num3 == num)
				{
				}
				num = (short)661585921;
				if (num != 0)
				{
				}
				num = (short)1359937536;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00071654 File Offset: 0x0006F854
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x00071704 File Offset: 0x0006F904
		internal bool UndoIgnoresSelection
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1610612736;
				short num2 = num;
				num = (short)128712705;
				if (num != 0)
				{
				}
				num = (short)1258213743;
				short num3 = num;
				num = (short)215863663;
				switch (num3 == num)
				{
				}
				num = (short)958267392;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1827536896;
				short num2 = num;
				num = (short)5852430;
				short num3 = num;
				num = (short)1126124814;
				switch (num3 == num)
				{
				}
				num = (short)365297665;
				if (num != 0)
				{
				}
				num = (short)2063859712;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x000717B4 File Offset: 0x0006F9B4
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00071864 File Offset: 0x0006FA64
		internal global::AcpBusinessLayer.AcpListField BuddyList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)396886016;
				short num2 = num;
				num = (short)372137793;
				short num3 = num;
				num = (short)274620225;
				switch (num3 == num)
				{
				}
				num = (short)112525313;
				if (num != 0)
				{
				}
				num = (short)1601110016;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)489553920;
				short num2 = num;
				num = (short)1493824385;
				short num3 = num;
				num = (short)2138108801;
				switch (num3 == num)
				{
				}
				num = (short)940834817;
				if (num != 0)
				{
				}
				num = (short)562167808;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00071914 File Offset: 0x0006FB14
		internal int ItemCount
		{
			get
			{
				short num = (short)1654259712;
				short num2 = num;
				num = (short)1024636741;
				short num3 = num;
				num = (short)341882693;
				switch (num3 == num)
				{
				}
				num = (short)2087518208;
				if (num != 0)
				{
				}
				num = (short)690946049;
				if (num != 0)
				{
				}
				return this.f.Count;
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x000719CC File Offset: 0x0006FBCC
		internal void SetItemVisibility(int index, bool visibility)
		{
			short num = (short)849018882;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_CE;
				case 1:
					goto IL_F0;
				case 2:
				{
					num = (short)1952514048;
					short num3 = num;
					num = (short)2050608050;
					short num4 = num;
					num = (short)2141637554;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CE;
					default:
						num = (short)60948480;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A9;
						}
						continue;
					}
					break;
				}
				}
				IL_A9:
				if (index < this.f.Count)
				{
					num = (short)1550581760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_CE:
				this.f[index] = visibility;
				num = (short)229900289;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F0:
			num = (short)497876993;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00071AF4 File Offset: 0x0006FCF4
		internal bool GetItemVisibility(int index)
		{
			short num = (short)1219279638;
			short num2 = num;
			num = (short)112835350;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1124204544;
				if (num != 0)
				{
				}
				num = (short)814284801;
				if (num != 0)
				{
				}
				if (index >= this.f.Count)
				{
					return true;
				}
				num = (short)611516416;
				short num3 = num;
				break;
			}
			}
			return this.f[index];
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00071BBC File Offset: 0x0006FDBC
		internal void DoubleItems()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			int num2;
			short num3;
			global::System.Collections.BitArray bitArray;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_158;
				case 1:
					if (num2 >= this.f.Count)
					{
						num3 = (short)1625423873;
						if (num3 != 0)
						{
						}
						num3 = (short)1791623171;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					bitArray.Set(num2, this.f[num2]);
					num2++;
					num3 = (short)1392181248;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					goto IL_C3;
				case 3:
					goto IL_128;
				}
				goto IL_20;
			}
			IL_C3:
			goto IL_C5;
			IL_128:
			this.f = bitArray;
			return;
			IL_20:
			bitArray = new global::System.Collections.BitArray(this.f.Count * 2, true);
			num2 = 0;
			num3 = (short)773398104;
			short num4 = num3;
			num3 = (short)984817240;
			switch ((num4 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_158:
				break;
			default:
			{
				num3 = (short)220856320;
				if (num3 != 0)
				{
				}
				num3 = (short)224722944;
				short num5 = num3;
				num3 = (short)576913410;
				num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			}
			IL_C5:
			num3 = (short)1618542593;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x0400018E RID: 398
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.ListItemStateConstraint a;

		// Token: 0x0400018F RID: 399
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.ListItemImageConstraint b;

		// Token: 0x04000190 RID: 400
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;

		// Token: 0x04000191 RID: 401
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d;

		// Token: 0x04000192 RID: 402
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpBusinessLayer.AcpListField e;

		// Token: 0x04000193 RID: 403
		private global::System.Collections.BitArray f;
	}
}
