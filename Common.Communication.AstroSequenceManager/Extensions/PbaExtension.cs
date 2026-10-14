using System;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.Extensions
{
	// Token: 0x02000034 RID: 52
	public static class PbaExtension
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00027F44 File Offset: 0x00026144
		public static byte[] ToCmpBytes(this global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)452395008;
			short num2 = num;
			num = (short)798433618;
			short num3 = num;
			num = (short)1708925266;
			switch (num3 == num)
			{
			}
			num = (short)1292369921;
			if (num != 0)
			{
			}
			num = (short)2119696384;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader fileHeader = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader
			{
				HeaderVer = 16,
				FullDelta = global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Full,
				Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData
			};
			return new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true).Serialize(fileHeader, pba);
		}
	}
}
