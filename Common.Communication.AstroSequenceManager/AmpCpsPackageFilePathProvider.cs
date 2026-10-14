using System;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000D RID: 13
	public class AmpCpsPackageFilePathProvider : global::Motorola.Common.Communication.IAmpPackageFilePathProvider
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00008C70 File Offset: 0x00006E70
		public string GetPackageFilePath(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)2048131073;
			if (num != 0)
			{
			}
			num = (short)1731645011;
			short num2 = num;
			num = (short)1134612051;
			switch (num2 == num)
			{
			}
			num = (short)78970880;
			short num3 = num;
			num = (short)1969422336;
			if (num != 0)
			{
			}
			return pba.FWpath;
		}
	}
}
