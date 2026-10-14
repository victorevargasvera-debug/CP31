using System;
using System.Collections;

namespace NPOI.Util
{
	// Token: 0x02000261 RID: 609
	public class BitFieldFactory
	{
		// Token: 0x06000FD2 RID: 4050 RVA: 0x00030D48 File Offset: 0x0002EF48
		public static global::NPOI.Util.BitField GetInstance(int mask)
		{
			global::NPOI.Util.BitField bitField = (global::NPOI.Util.BitField)global::NPOI.Util.BitFieldFactory.instances[mask];
			if (bitField == null)
			{
				bitField = new global::NPOI.Util.BitField(mask);
				global::NPOI.Util.BitFieldFactory.instances[mask] = bitField;
			}
			return bitField;
		}

		// Token: 0x040006E4 RID: 1764
		private static global::System.Collections.Hashtable instances = new global::System.Collections.Hashtable();
	}
}
