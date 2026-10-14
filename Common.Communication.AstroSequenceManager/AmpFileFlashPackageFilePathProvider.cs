using System;
using System.Linq;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000E RID: 14
	public class AmpFileFlashPackageFilePathProvider : global::Motorola.Common.Communication.IAmpPackageFilePathProvider
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00008D34 File Offset: 0x00006F34
		public string GetPackageFilePath(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)1414397954;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_140;
				case 1:
					num = (short)379387904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 3:
					goto IL_114;
				}
				IL_35:
				num = (short)407963754;
				short num3 = num;
				num = (short)181274730;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_140;
				default:
				{
					num = (short)1497497600;
					short num4 = num;
					num = (short)1652555776;
					if (num != 0)
					{
					}
					if (pba.UpdateData.MemoryImages.Count == 0)
					{
						num = (short)863240193;
						if (num != 0)
						{
						}
						num = (short)573571073;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)154271747;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_114:
			global::Motorola.Common.Communication.Pba.RadioImage radioImage = pba.UpdateData.MemoryImages.SingleOrDefault(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AmpFileFlashPackageFilePathProvider.<>c.<>9.a));
			if (radioImage == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
			}
			return radioImage.FilePath;
			IL_140:
			return null;
		}
	}
}
