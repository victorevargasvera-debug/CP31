using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Infragistics
{
	// Token: 0x020000CB RID: 203
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class LabelAppearanceDataList : global::System.Collections.Generic.List<global::Infragistics.LabelAppearanceData>, global::Infragistics.IVisualData
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x000278FC File Offset: 0x00025AFC
		public string Serialize()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("{ items: [");
			for (int i = 0; i < base.Count; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(base[i].Serialize());
			}
			return stringBuilder.ToString();
		}
	}
}
