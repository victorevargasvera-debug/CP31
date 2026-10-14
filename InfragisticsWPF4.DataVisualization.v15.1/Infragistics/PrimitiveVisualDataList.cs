using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Infragistics
{
	// Token: 0x020000C8 RID: 200
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class PrimitiveVisualDataList : global::System.Collections.Generic.List<global::Infragistics.PrimitiveVisualData>, global::Infragistics.IVisualData
	{
		// Token: 0x06000852 RID: 2130 RVA: 0x000273A0 File Offset: 0x000255A0
		public global::Infragistics.PrimitiveVisualDataList ContainingTag(string tag)
		{
			global::Infragistics.PrimitiveVisualDataList primitiveVisualDataList = new global::Infragistics.PrimitiveVisualDataList();
			for (int i = 0; i < base.Count; i++)
			{
				global::Infragistics.PrimitiveVisualData primitiveVisualData = base[i];
				for (int j = 0; j < primitiveVisualData.Tags.Count; j++)
				{
					if (primitiveVisualData.Tags[j] == tag)
					{
						primitiveVisualDataList.Add(primitiveVisualData);
						break;
					}
				}
			}
			return primitiveVisualDataList;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00027400 File Offset: 0x00025600
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
