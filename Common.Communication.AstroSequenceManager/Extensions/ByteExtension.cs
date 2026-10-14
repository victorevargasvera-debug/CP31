using System;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.Extensions
{
	// Token: 0x02000033 RID: 51
	public static class ByteExtension
	{
		// Token: 0x0600018F RID: 399 RVA: 0x00027E80 File Offset: 0x00026080
		public static global::Motorola.Common.Communication.Pba.PbaObject ToPbaObject(this byte[] cmp, string codeplugVersion)
		{
			short num = (short)728825856;
			short num2 = num;
			num = (short)350099065;
			short num3 = num;
			num = (short)1883707001;
			switch (num3 == num)
			{
			}
			num = (short)575471617;
			if (num != 0)
			{
			}
			num = (short)1154547712;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true).Deserialize(cmp);
			pbaObject.CodeplugData.CPVersion = codeplugVersion;
			return pbaObject;
		}
	}
}
