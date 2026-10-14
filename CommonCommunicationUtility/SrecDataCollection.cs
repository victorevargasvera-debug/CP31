using System;
using System.Collections;
using System.Collections.Generic;

namespace Motorola.Common.Communication
{
	// Token: 0x02000008 RID: 8
	public class SrecDataCollection : global::System.Collections.Generic.ICollection<global::Motorola.Common.Communication.SrecData>, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.SrecData>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000024E4 File Offset: 0x000006E4
		internal SrecDataCollection()
		{
			this.a = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SrecData>();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002504 File Offset: 0x00000704
		public void Add(global::Motorola.Common.Communication.SrecData item)
		{
			if (item == null)
			{
				short num = (short)494534657;
				if (num != 0)
				{
				}
				num = (short)16699070;
				short num2 = num;
				num = (short)1580846782;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1605697536;
					if (num != 0)
					{
					}
					num = (short)1487405056;
					short num3 = num;
					throw new global::System.ArgumentNullException("item");
				}
				}
			}
			this.a.Add(item);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000025CC File Offset: 0x000007CC
		public void Clear()
		{
			short num = (short)217211902;
			short num2 = num;
			num = (short)683959294;
			switch (num2 == num)
			{
			}
			num = (short)348192768;
			if (num != 0)
			{
			}
			num = (short)1004535809;
			if (num != 0)
			{
			}
			num = (short)1683554304;
			short num3 = num;
			this.a.Clear();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000267C File Offset: 0x0000087C
		public bool Contains(global::Motorola.Common.Communication.SrecData item)
		{
			short num = (short)1364000769;
			if (num != 0)
			{
			}
			if (item == null)
			{
				num = (short)457785794;
				short num2 = num;
				num = (short)88031682;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1859256320;
					if (num != 0)
					{
					}
					num = (short)1116995584;
					short num3 = num;
					throw new global::System.ArgumentNullException("item");
				}
				}
			}
			return this.a.Contains(item);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002744 File Offset: 0x00000944
		public void CopyTo(global::Motorola.Common.Communication.SrecData[] array, int arrayIndex)
		{
			short num = (short)669766535;
			short num2 = num;
			num = (short)296080263;
			switch (num2 == num)
			{
			}
			num = (short)828047361;
			if (num != 0)
			{
			}
			num = (short)1932001280;
			if (num != 0)
			{
			}
			num = (short)1438515200;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000027F4 File Offset: 0x000009F4
		public int Count
		{
			get
			{
				short num = (short)1364134042;
				short num2 = num;
				num = (short)1557989530;
				switch (num2 == num)
				{
				}
				num = (short)821559296;
				if (num != 0)
				{
				}
				num = (short)320667649;
				if (num != 0)
				{
				}
				num = (short)231735296;
				short num3 = num;
				return this.a.Count;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000028A8 File Offset: 0x00000AA8
		public bool IsReadOnly
		{
			get
			{
				short num = (short)810830706;
				short num2 = num;
				num = (short)129256306;
				switch (num2 == num)
				{
				}
				num = (short)604635137;
				if (num != 0)
				{
				}
				num = (short)954793984;
				if (num != 0)
				{
				}
				num = (short)711917568;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002950 File Offset: 0x00000B50
		public bool Remove(global::Motorola.Common.Communication.SrecData item)
		{
			short num = (short)647888897;
			if (num != 0)
			{
			}
			if (item == null)
			{
				num = (short)624733215;
				short num2 = num;
				num = (short)1499835423;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)171507712;
					if (num != 0)
					{
					}
					num = (short)942342144;
					short num3 = num;
					throw new global::System.ArgumentNullException("item");
				}
				}
			}
			return this.a.Remove(item);
		}

		// Token: 0x17000008 RID: 8
		public global::Motorola.Common.Communication.SrecData this[int index]
		{
			get
			{
				short num = (short)998834177;
				if (num != 0)
				{
				}
				num = (short)1684654921;
				short num2 = num;
				num = (short)782551881;
				switch (num2 == num)
				{
				}
				num = (short)491126784;
				if (num != 0)
				{
				}
				num = (short)1926561792;
				short num3 = num;
				return this.a[index];
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002ACC File Offset: 0x00000CCC
		internal void a(int A_0, global::Motorola.Common.Communication.SrecData A_1)
		{
			short num = (short)77987841;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)631504897;
					if (num != 0)
					{
					}
					if (A_0 > this.a.Count)
					{
						goto IL_AA;
					}
					goto IL_18B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 2:
					num = (short)1373962240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (A_0 >= 0)
					{
						num = (short)2053308418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_180;
				case 4:
				{
					num = (short)852230996;
					short num3 = num;
					num = (short)227803988;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AA;
					default:
						goto IL_15E;
					}
					break;
				}
				case 5:
					goto IL_C1;
				}
				IL_3E:
				if (A_1 == null)
				{
					num = (short)1633157124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)424345600;
				short num4 = num;
				num = (short)1807024131;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AA:
				num = (short)924188677;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C1:
			goto IL_180;
			IL_15E:
			num = (short)1586561024;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException("item");
			IL_180:
			throw new global::System.ArgumentOutOfRangeException("index");
			IL_18B:
			this.a.Insert(A_0, A_1);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002C74 File Offset: 0x00000E74
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.SrecData> GetEnumerator()
		{
			short num = (short)1786955738;
			short num2 = num;
			num = (short)391038938;
			switch (num2 == num)
			{
			}
			num = (short)1948123137;
			if (num != 0)
			{
			}
			num = (short)1759313920;
			if (num != 0)
			{
			}
			num = (short)1839398912;
			short num3 = num;
			return this.a.GetEnumerator();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002D2C File Offset: 0x00000F2C
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)179830785;
			if (num != 0)
			{
			}
			num = (short)1786610370;
			short num2 = num;
			num = (short)1362264770;
			switch (num2 == num)
			{
			}
			num = (short)1109655552;
			if (num != 0)
			{
			}
			num = (short)931463168;
			short num3 = num;
			return this.GetEnumerator();
		}

		// Token: 0x04000018 RID: 24
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.SrecData> a;
	}
}
