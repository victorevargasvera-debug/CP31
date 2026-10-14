using System;
using System.Collections.Generic;

namespace Motorola.CommonCPS.Common.CommonUtility.CSV
{
	// Token: 0x0200001D RID: 29
	[global::System.Serializable]
	public sealed class CsvRecord
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00010370 File Offset: 0x0000E570
		public int FieldCount
		{
			get
			{
				short num = (short)819789824;
				short num2 = num;
				num = (short)547487745;
				if (num != 0)
				{
				}
				num = (short)1092468055;
				short num3 = num;
				num = (short)1265155415;
				switch (num3 == num)
				{
				}
				num = (short)785776640;
				if (num != 0)
				{
				}
				return this.Fields.Count;
			}
		}

		// Token: 0x04000032 RID: 50
		public readonly global::System.Collections.Generic.List<string> Fields = new global::System.Collections.Generic.List<string>();
	}
}
