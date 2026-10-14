using System;
using System.Collections.Generic;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication.Utils
{
	// Token: 0x02000031 RID: 49
	public static class JobDescriptorFactory
	{
		// Token: 0x06000189 RID: 393 RVA: 0x00027874 File Offset: 0x00025A74
		public static global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor BuildJobDescriptorForWriteFirmware(int? userDefersAllowed = null)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor httpJobDescriptor;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (userDefersAllowed != null)
					{
						num2 = (short)329449473;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return httpJobDescriptor;
				case 1:
				{
					httpJobDescriptor.JobContent.UserDefersAllowed = userDefersAllowed.Value;
					num2 = (short)1138720133;
					short num3 = num2;
					num2 = (short)1897692549;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1572864001;
						if (num2 != 0)
						{
						}
						num2 = (short)1912143872;
						if (num2 != 0)
						{
						}
						num2 = (short)1464664066;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return httpJobDescriptor;
				}
				goto IL_25;
			}
			return httpJobDescriptor;
			IL_25:
			httpJobDescriptor = new global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor
			{
				JobType = global::Motorola.Common.Communication.AmpRequest.Models.JobType.Set,
				JobUuid = global::System.Guid.NewGuid().ToString(),
				JobContent = new global::Motorola.Common.Communication.AmpRequest.Models.JobContent
				{
					Files = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.FileDescription>
					{
						new global::Motorola.Common.Communication.AmpRequest.Models.FileDescription
						{
							FileName = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("駾栀焂栄瀆栈礊栌弎瀐瀒縔瘖縘縚㌜攞䠠匢", a_),
							FileType = global::Motorola.Common.Communication.AmpRequest.Models.FileType.FwPackage
						},
						new global::Motorola.Common.Communication.AmpRequest.Models.FileDescription
						{
							FileName = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鳾渀洂挄渆済嬊氌氎稐爒爔爖㜘愚琜漞", a_),
							FileType = global::Motorola.Common.Communication.AmpRequest.Models.FileType.ConfigPackage
						}
					},
					UserDefersAllowed = 1
				},
				Action = global::Motorola.Common.Communication.AmpRequest.Models.JobAction.None
			};
			num2 = (short)126222336;
			short num4 = num2;
			num2 = (short)1111228416;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00027A40 File Offset: 0x00025C40
		public static global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor BuildJobDescriptorForRead()
		{
			int a_ = 18;
			short num = (short)1969881088;
			short num2 = num;
			num = (short)1876042495;
			short num3 = num;
			num = (short)1542857471;
			switch (num3 == num)
			{
			}
			num = (short)517341185;
			if (num != 0)
			{
			}
			num = (short)460587008;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor
			{
				JobType = global::Motorola.Common.Communication.AmpRequest.Models.JobType.Get,
				JobUuid = global::System.Guid.NewGuid().ToString(),
				JobContent = new global::Motorola.Common.Communication.AmpRequest.Models.JobContent
				{
					Files = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.FileDescription>
					{
						new global::Motorola.Common.Communication.AmpRequest.Models.FileDescription
						{
							FileName = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("愁欃栅渇按欋帍焏焑缓眕缗缙㈛搝䤟刡", a_),
							FileType = global::Motorola.Common.Communication.AmpRequest.Models.FileType.ConfigPackage
						}
					}
				},
				Action = global::Motorola.Common.Communication.AmpRequest.Models.JobAction.None
			};
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00027B60 File Offset: 0x00025D60
		public static global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor BuildJobDescriptorForWriteCodeplug(int? userDefersAllowed = null)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor httpJobDescriptor;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (userDefersAllowed != null)
					{
						num2 = (short)277217281;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return httpJobDescriptor;
				case 1:
				{
					httpJobDescriptor.JobContent.UserDefersAllowed = userDefersAllowed.Value;
					num2 = (short)1280755206;
					short num3 = num2;
					num2 = (short)321897990;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)139526144;
						if (num2 != 0)
						{
						}
						num2 = (short)1008795650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_167;
				}
				goto IL_25;
			}
			IL_167:
			num2 = (short)1446051841;
			if (num2 != 0)
			{
			}
			return httpJobDescriptor;
			IL_25:
			httpJobDescriptor = new global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor
			{
				JobType = global::Motorola.Common.Communication.AmpRequest.Models.JobType.Set,
				JobUuid = global::System.Guid.NewGuid().ToString(),
				JobContent = new global::Motorola.Common.Communication.AmpRequest.Models.JobContent
				{
					Files = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.FileDescription>
					{
						new global::Motorola.Common.Communication.AmpRequest.Models.FileDescription
						{
							FileName = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("音駵雷鳹闻駽僿持會洅椇洉椋‍樏笑搓", a_),
							FileType = global::Motorola.Common.Communication.AmpRequest.Models.FileType.ConfigPackage
						}
					}
				},
				Action = global::Motorola.Common.Communication.AmpRequest.Models.JobAction.None
			};
			num2 = (short)1130299392;
			short num4 = num2;
			num2 = (short)13369344;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x040000CF RID: 207
		public const string ConfigPackageFileName = "configPackage.zip";

		// Token: 0x040000D0 RID: 208
		public const string FirmwarePackageFileName = "firmwarePackage.zip";
	}
}
