using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack
{
	// Token: 0x02000003 RID: 3
	public sealed class CrcPolynomial : global::Motorola.Acp.PackUnpack.ICrcPolynomial
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002330 File Offset: 0x00000530
		internal CrcPolynomial(int A_0, int A_1, string A_2)
		{
			int a_ = 15;
			this.a = 33;
			this.b = 17;
			this.c = global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udea5鮩骫躭鮯銱첳覷袹鲻閽뫁髃ￍ", a_);
			base..ctor();
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002388 File Offset: 0x00000588
		public int Value
		{
			get
			{
				short num = (short)182571998;
				short num2 = num;
				num = (short)2070533086;
				switch (num2 == num)
				{
				}
				num = (short)979238913;
				if (num != 0)
				{
				}
				num = (short)258867200;
				short num3 = num;
				num = (short)1475018752;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002434 File Offset: 0x00000634
		public int Length
		{
			get
			{
				short num = (short)322070254;
				short num2 = num;
				num = (short)788424430;
				switch (num2 == num)
				{
				}
				num = (short)59113472;
				if (num != 0)
				{
				}
				num = (short)1011810304;
				short num3 = num;
				num = (short)314048513;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000024E4 File Offset: 0x000006E4
		public string Description
		{
			get
			{
				short num = (short)2029595503;
				short num2 = num;
				num = (short)987835247;
				switch (num2 == num)
				{
				}
				num = (short)1272184832;
				if (num != 0)
				{
				}
				num = (short)164560896;
				short num3 = num;
				num = (short)1585381377;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x04000003 RID: 3
		private int a;

		// Token: 0x04000004 RID: 4
		private int b;

		// Token: 0x04000005 RID: 5
		private string c;
	}
}
