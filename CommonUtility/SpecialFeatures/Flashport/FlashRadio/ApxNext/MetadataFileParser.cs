using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using CommonUtility;
using RFResourceRepository;

namespace SpecialFeatures.Flashport.FlashRadio.ApxNext
{
	// Token: 0x02000007 RID: 7
	public class MetadataFileParser
	{
		// Token: 0x06000024 RID: 36 RVA: 0x000040FC File Offset: 0x000022FC
		public static string ExtractMetadata(string zipPath)
		{
			short num = (short)1848643602;
			short num2 = num;
			num = (short)912003090;
			string result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1082130432;
				if (num != 0)
				{
				}
				num = (short)1427308545;
				if (num != 0)
				{
				}
				global::System.IO.Compression.ZipArchive zipArchive = global::System.IO.Compression.ZipFile.OpenRead(zipPath);
				try
				{
					global::System.Collections.Generic.IEnumerable<global::System.IO.Compression.ZipArchiveEntry> source = zipArchive.Entries.Where(new global::System.Func<global::System.IO.Compression.ZipArchiveEntry, bool>(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.MetadataFileParser.<>c.<>9.a));
					if (!source.Any<global::System.IO.Compression.ZipArchiveEntry>())
					{
						throw new global::System.Exception(global::RFResourceRepository.RFResources.Invalid_upgrade_file);
					}
					result = new global::System.IO.StreamReader(source.FirstOrDefault<global::System.IO.Compression.ZipArchiveEntry>().Open()).ReadToEnd();
				}
				finally
				{
					num = (short)777781248;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_106;
							}
							continue;
						case 1:
							((global::System.IDisposable)zipArchive).Dispose();
							num = (short)1544028162;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_13B;
						}
						IL_106:
						if (zipArchive == null)
						{
							break;
						}
						num = (short)1821245441;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_13B:;
				}
				break;
			}
			}
			num = (short)647233536;
			short num4 = num;
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004280 File Offset: 0x00002480
		public static global::SpecialFeatures.Flashport.FlashRadio.MetadataFile ParseMetadata(string metadata)
		{
			int a_ = 15;
			short num = (short)927727617;
			if (num != 0)
			{
			}
			num = (short)458620928;
			short num2 = num;
			num = (short)1455017679;
			short num3 = num;
			num = (short)734777039;
			switch (num3 == num)
			{
			}
			num = (short)1509031936;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Flashport.FlashRadio.MetadataFile(metadata.Split(new string[]
			{
				global::System.Environment.NewLine,
				global::CommonUtility.VersionUtility.b("䨿", a_)
			}, global::System.StringSplitOptions.RemoveEmptyEntries).ToDictionary(new global::System.Func<string, string>(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.MetadataFileParser.<>c.<>9.a), new global::System.Func<string, string>(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.MetadataFileParser.<>c.<>9.b)));
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000043AC File Offset: 0x000025AC
		public static global::SpecialFeatures.Flashport.FlashRadio.MetadataFile ParseZip(string zipPath)
		{
			short num = (short)1103034067;
			short num2 = num;
			num = (short)1327494867;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2033254400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)461570048;
			if (num != 0)
			{
			}
			num = (short)987889665;
			if (num != 0)
			{
			}
			return global::SpecialFeatures.Flashport.FlashRadio.ApxNext.MetadataFileParser.ParseMetadata(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.MetadataFileParser.ExtractMetadata(zipPath));
		}
	}
}
