using System;
using System.IO.Compression;

namespace SpecialFeatures.Comms.Util
{
	// Token: 0x0200017C RID: 380
	public class IOCompressionHelper : global::SpecialFeatures.Comms.Util.IIOCompressionHelper
	{
		// Token: 0x060012C7 RID: 4807 RVA: 0x001A466C File Offset: 0x001A286C
		public global::System.IO.Compression.ZipArchive OpenRead(string path)
		{
			short num = (short)1923095751;
			short num2 = num;
			num = (short)1593515207;
			switch (num2 == num)
			{
			}
			num = (short)330170369;
			if (num != 0)
			{
			}
			num = (short)1059061760;
			if (num != 0)
			{
			}
			num = (short)1152909312;
			short num3 = num;
			return global::System.IO.Compression.ZipFile.OpenRead(path);
		}
	}
}
