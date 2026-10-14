using System;
using System.Collections.Generic;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x02000022 RID: 34
	internal class OperationParameters
	{
		// Token: 0x1700003C RID: 60
		public string this[string category]
		{
			get
			{
				category = category.ToUpperInvariant();
				string result;
				if (this.ParaList.TryGetValue(category, out result))
				{
					short num = (short)1844451489;
					short num2 = num;
					num = (short)970528929;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1419509761;
						if (num != 0)
						{
						}
						num = (short)1120403456;
						short num3 = num;
						num = (short)1268842496;
						if (num != 0)
						{
						}
						return result;
					}
					}
				}
				return string.Empty;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00012554 File Offset: 0x00010754
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationParameters AddOrUpdateParameter(string category, string value)
		{
			short num = (short)687603713;
			if (num != 0)
			{
			}
			num = (short)1882070184;
			short num2 = num;
			num = (short)578034856;
			switch (num2 == num)
			{
			}
			num = (short)1522794496;
			if (num != 0)
			{
			}
			num = (short)1534001152;
			short num3 = num;
			category = category.Trim().ToUpperInvariant();
			this.ParaList[category] = value;
			return this;
		}

		// Token: 0x0400008B RID: 139
		internal global::System.Collections.Generic.Dictionary<string, string> ParaList = new global::System.Collections.Generic.Dictionary<string, string>();
	}
}
