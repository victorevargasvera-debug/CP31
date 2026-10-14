using System;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000025 RID: 37
	public class ListHeaderType : global::Motorola.Acp.PackUnpack.Ish.IshType
	{
		// Token: 0x0600015D RID: 349 RVA: 0x000219F8 File Offset: 0x0001FBF8
		public ListHeaderType(string name, int value, bool singleInstance) : base(name, value, singleInstance)
		{
			this.a = null;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00021A18 File Offset: 0x0001FC18
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00021AC4 File Offset: 0x0001FCC4
		public global::Motorola.Acp.PackUnpack.Ish.ListListletType ListletType
		{
			get
			{
				short num = (short)1058013184;
				short num2 = num;
				num = (short)1900281857;
				if (num != 0)
				{
				}
				num = (short)1125852547;
				short num3 = num;
				num = (short)1451632003;
				switch (num3 == num)
				{
				}
				num = (short)1339621376;
				if (num != 0)
				{
				}
				return this.a;
			}
			internal set
			{
				short num = (short)1449525248;
				short num2 = num;
				num = (short)356712449;
				if (num != 0)
				{
				}
				num = (short)1994452852;
				short num3 = num;
				num = (short)2038230900;
				switch (num3 == num)
				{
				}
				num = (short)922025984;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x04000071 RID: 113
		private global::Motorola.Acp.PackUnpack.Ish.ListListletType a;
	}
}
