using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000028 RID: 40
	public class ListListletType : global::Motorola.Acp.PackUnpack.Ish.IshType
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00022D9C File Offset: 0x00020F9C
		public ListListletType(string name, int value) : base(name, value, false)
		{
			this.a = null;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00022DBC File Offset: 0x00020FBC
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00022E68 File Offset: 0x00021068
		public global::Motorola.Acp.PackUnpack.Ish.ListHeaderType HeaderType
		{
			get
			{
				short num = (short)358744065;
				if (num != 0)
				{
				}
				num = (short)1900321936;
				short num2 = num;
				num = (short)577739920;
				switch (num2 == num)
				{
				}
				num = (short)1281556480;
				short num3 = num;
				num = (short)141950976;
				if (num != 0)
				{
				}
				return this.a;
			}
			internal set
			{
				int a_ = 17;
				short num = (short)1737752578;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value.Value == base.Value)
						{
							num = (short)1204486147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_164;
					case 1:
						goto IL_AA;
					case 2:
						goto IL_1D;
					case 3:
					{
						num = (short)312767386;
						short num3 = num;
						num = (short)707031962;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
							goto IL_E5;
						}
						break;
					}
					}
					goto IL_91;
					IL_1D:
					num = (short)1052311553;
					if (num != 0)
					{
					}
					num = (short)1895628800;
					short num4 = num;
					switch (0)
					{
					case 0:
						IL_91:
						if (value == null)
						{
							num = (short)1136328705;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)1188757504;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
				}
				IL_AA:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udea7쮩삫\udbad햯", a_));
				IL_E5:
				num = (short)1098776576;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udea7쮩삫\udbad햯", a_));
				IL_164:
				this.a = value;
			}
		}

		// Token: 0x0400007E RID: 126
		private global::Motorola.Acp.PackUnpack.Ish.ListHeaderType a;
	}
}
