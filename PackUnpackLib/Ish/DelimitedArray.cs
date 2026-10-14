using System;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200001B RID: 27
	public class DelimitedArray<T>
	{
		// Token: 0x06000128 RID: 296 RVA: 0x0001EF6C File Offset: 0x0001D16C
		internal DelimitedArray(T[] A_0, int A_1, int A_2)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0001EF94 File Offset: 0x0001D194
		internal int Count
		{
			get
			{
				short num = (short)732135085;
				short num2 = num;
				num = (short)1178238637;
				switch (num2 == num)
				{
				}
				num = (short)1017053184;
				if (num != 0)
				{
				}
				num = (short)1229127680;
				short num3 = num;
				num = (short)1490092033;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000033 RID: 51
		internal T this[int A_0]
		{
			get
			{
				int a_ = 10;
				switch (0)
				{
				case 0:
					goto IL_29;
				}
				int num;
				int num2;
				short num3;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						if (num2 < 0)
						{
							num3 = (short)430899202;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_16D;
					case 1:
						if (num2 <= this.Count - 1)
						{
							num3 = (short)897122307;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_6D;
					case 2:
						goto IL_168;
					case 3:
						num3 = (short)188153856;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_29;
				}
				IL_6D:
				num3 = (short)1059323905;
				if (num3 != 0)
				{
				}
				num3 = (short)1965091340;
				short num4 = num3;
				num3 = (short)133097996;
				switch ((num4 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_16D:
					return this.a[num2];
				default:
				{
					num3 = (short)798752768;
					if (num3 != 0)
					{
					}
					num3 = (short)1769930752;
					short num5 = num3;
					throw new global::System.IndexOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춢솤슦톨讪説", a_) + num2.ToString() + global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("蚠莢튤욦\udaa8讪슬\udaae얰삲\udcb4펶\udcb8鮺즼ힾ꓀Ꞔ꣆볈ꗊ꧌볎볒돔귘돚룜￞胠釢韤蛦部엪", a_));
				}
				}
				IL_168:
				goto IL_6D;
				IL_29:
				num2 = this.b + A_0 - 1;
				num3 = (short)2046689281;
				num = (int)((global::System.IntPtr)num3);
				goto IL_13;
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0001F1D0 File Offset: 0x0001D3D0
		internal global::System.Collections.Generic.IEnumerator<T> b()
		{
			short num = (short)109471633;
			short num2 = num;
			num = (short)204957585;
			switch (num2 == num)
			{
			}
			num = (short)644677632;
			if (num != 0)
			{
			}
			num = (short)407896064;
			short num3 = num;
			num = (short)1683292161;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.DelimitedArray<T>.a a = new global::Motorola.Acp.PackUnpack.Ish.DelimitedArray<T>.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0001F284 File Offset: 0x0001D484
		public override int GetHashCode()
		{
			short num = (short)659696559;
			short num2 = num;
			num = (short)514599855;
			switch (num2 == num)
			{
			}
			num = (short)55246848;
			if (num != 0)
			{
			}
			num = (short)1741750272;
			short num3 = num;
			num = (short)1979121665;
			if (num != 0)
			{
			}
			return this.a.GetHashCode() ^ this.b ^ this.c;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0001F344 File Offset: 0x0001D544
		public override bool Equals(object obj)
		{
			short num;
			while (obj is global::System.ArraySegment<T>)
			{
				num = (short)1346584270;
				short num2 = num;
				num = (short)217267918;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)329121792;
					short num3 = num;
					num = (short)184942592;
					if (num != 0)
					{
					}
					return this.Equals((global::System.ArraySegment<T>)obj);
				}
				}
			}
			num = (short)1316225025;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0001F410 File Offset: 0x0001D610
		public bool Equals(global::Motorola.Acp.PackUnpack.Ish.DelimitedArray<T> obj)
		{
			short num = (short)112852993;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (obj.b == this.b)
					{
						num = (short)1703477250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
				{
					num = (short)541218347;
					short num3 = num;
					num = (short)668816939;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_BA;
					}
					break;
				}
				case 3:
					num = (short)1077280768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				num = (short)1201340417;
				if (num != 0)
				{
				}
				if (obj.a != this.a)
				{
					return false;
				}
				num = (short)2019753987;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BA:
			num = (short)11403264;
			if (num != 0)
			{
			}
			num = (short)614400000;
			short num4 = num;
			return obj.c == this.c;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0001F56C File Offset: 0x0001D76C
		public static bool operator ==(global::Motorola.Acp.PackUnpack.Ish.DelimitedArray<T> a, global::Motorola.Acp.PackUnpack.Ish.DelimitedArray<T> b)
		{
			short num = (short)376492082;
			short num2 = num;
			num = (short)354734130;
			switch (num2 == num)
			{
			}
			num = (short)1720844289;
			if (num != 0)
			{
			}
			num = (short)217055232;
			short num3 = num;
			num = (short)2115174400;
			if (num != 0)
			{
			}
			return a.Equals(b);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0001F618 File Offset: 0x0001D818
		public static bool operator !=(global::Motorola.Acp.PackUnpack.Ish.DelimitedArray<T> a, global::Motorola.Acp.PackUnpack.Ish.DelimitedArray<T> b)
		{
			short num = (short)819724289;
			if (num != 0)
			{
			}
			num = (short)420733454;
			short num2 = num;
			num = (short)194634254;
			switch (num2 == num)
			{
			}
			num = (short)1251344384;
			short num3 = num;
			num = (short)1029242880;
			if (num != 0)
			{
			}
			return a != b;
		}

		// Token: 0x04000059 RID: 89
		private T[] a;

		// Token: 0x0400005A RID: 90
		private int b;

		// Token: 0x0400005B RID: 91
		private int c;
	}
}
