using System;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000023 RID: 35
	public class RefRelationSet
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x0000DDC0 File Offset: 0x0000BFC0
		public RefRelationSet(global::Motorola.CommonCPS.RadioManagement.UIModels.Set selectedSet, string referFieldUIPath)
		{
			this.a = selectedSet.Name;
			this.b = selectedSet.Alias;
			this.c = referFieldUIPath;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000DDF4 File Offset: 0x0000BFF4
		public string SelectedSetAliasName
		{
			get
			{
				short num = (short)1911226369;
				if (num != 0)
				{
				}
				num = (short)1513634710;
				short num2 = num;
				num = (short)2081569686;
				switch (num2 == num)
				{
				}
				num = (short)75890688;
				short num3 = num;
				num = (short)1288830976;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
		public string ReferFieldUIPath
		{
			get
			{
				short num = (short)1786583960;
				short num2 = num;
				num = (short)1717574552;
				switch (num2 == num)
				{
				}
				num = (short)361037825;
				if (num != 0)
				{
				}
				num = (short)763494400;
				short num3 = num;
				num = (short)1397882880;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x04000059 RID: 89
		private string a;

		// Token: 0x0400005A RID: 90
		private string b;

		// Token: 0x0400005B RID: 91
		private string c;
	}
}
