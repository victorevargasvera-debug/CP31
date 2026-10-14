using System;
using System.Globalization;

namespace Infragistics
{
	// Token: 0x0200002C RID: 44
	public static class CultureInfoHelper
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000CA88 File Offset: 0x0000AC88
		public static global::System.Globalization.CultureInfo CultureToUse
		{
			get
			{
				global::System.Globalization.CultureInfo result;
				if (global::System.Globalization.CultureInfo.CurrentCulture == null || global::System.Globalization.CultureInfo.CurrentCulture.IsNeutralCulture)
				{
					result = global::System.Globalization.CultureInfo.InvariantCulture;
				}
				else
				{
					result = global::System.Globalization.CultureInfo.CurrentCulture;
				}
				return result;
			}
		}
	}
}
