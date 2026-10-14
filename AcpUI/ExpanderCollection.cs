using System;
using System.Collections.ObjectModel;

namespace AcpUI
{
	// Token: 0x02000021 RID: 33
	public class ExpanderCollection : global::System.Collections.ObjectModel.KeyedCollection<string, global::AcpUI.AcpExpander>
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x00021528 File Offset: 0x0001F728
		protected override string GetKeyForItem(global::AcpUI.AcpExpander item)
		{
			short num = (short)830999207;
			short num2 = num;
			num = (short)291048103;
			switch (num2 == num)
			{
			}
			num = (short)1435500544;
			short num3 = num;
			num = (short)1108279297;
			if (num != 0)
			{
			}
			num = (short)2109603840;
			if (num != 0)
			{
			}
			return item.Name;
		}
	}
}
