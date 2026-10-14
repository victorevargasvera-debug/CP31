using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000B0 RID: 176
	internal static class ValidateEntityBuilder
	{
		// Token: 0x06000A63 RID: 2659 RVA: 0x0007DDF0 File Offset: 0x0007BFF0
		public static global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet CreateValidateEntityForDeleteDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio device)
		{
			short num = (short)427829290;
			short num2 = num;
			num = (short)1673865258;
			switch (num2 == num)
			{
			}
			num = (short)1562247168;
			short num3 = num;
			num = (short)1990393857;
			if (num != 0)
			{
			}
			num = (short)1855389696;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = global::Motorola.CommonCPS.RadioManagement.SharedServices.ValidateEntityBuilder.a(device);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ValidateEntityBuilder.a(device, validateEntitySet);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ValidateEntityBuilder.b(device, validateEntitySet);
			return validateEntitySet;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0007DEB0 File Offset: 0x0007C0B0
		public static global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet CreateValidateEntityForDeleteConfiguration(global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary configuration)
		{
			short num = (short)1125066020;
			short num2 = num;
			num = (short)331359524;
			switch (num2 == num)
			{
			}
			num = (short)1266941952;
			short num3 = num;
			num = (short)703922177;
			if (num != 0)
			{
			}
			num = (short)847511552;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ValidateEntityBuilder.a(configuration);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0007DF60 File Offset: 0x0007C160
		public static global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet CreateValidateEntityForSaveAndApplyTempConfiguration(global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			short num = (short)38110525;
			short num2 = num;
			num = (short)1311409469;
			switch (num2 == num)
			{
			}
			num = (short)1613430784;
			short num3 = num;
			num = (short)512294912;
			if (num != 0)
			{
			}
			num = (short)1396703233;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ValidateEntityBuilder.a(radio);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0007E010 File Offset: 0x0007C210
		public static global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet CreateValidateEntityForApplyConfiguration(global::Motorola.CommonCPS.Server.EntityModel.Radio device, global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary configuration)
		{
			short num = (short)707919873;
			if (num != 0)
			{
			}
			num = (short)478198766;
			short num2 = num;
			num = (short)1580907502;
			switch (num2 == num)
			{
			default:
			{
				num = (short)508755968;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)412418048;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ValidateEntityBuilder.a(configuration);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0007E0C0 File Offset: 0x0007C2C0
		public static global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet CreateValidateEntityForDeleteTelePortSet(global::Motorola.CommonCPS.Server.EntityModel.RecordSummary emItem)
		{
			short num = (short)2007255025;
			short num2 = num;
			num = (short)1642350577;
			switch (num2 == num)
			{
			}
			num = (short)1751908352;
			short num3 = num;
			num = (short)1718222849;
			if (num != 0)
			{
			}
			num = (short)1283784704;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ValidateEntityBuilder.a(emItem);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0007E170 File Offset: 0x0007C370
		public static global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet CreateValidateEntityForApplyIPProgramSystem(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem sys)
		{
			short num = (short)1418985473;
			if (num != 0)
			{
			}
			num = (short)1818017840;
			short num2 = num;
			num = (short)704364592;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1126957056;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1261436928;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ValidateEntityBuilder.a(sys);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0007E21C File Offset: 0x0007C41C
		private static void b(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Guid? workingCodeplugUuid;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_81;
				case 1:
				{
					num2 = (short)1325662208;
					short num3 = num2;
					if (workingCodeplugUuid != null)
					{
						num2 = (short)1614217216;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
				{
					num2 = (short)1833428366;
					short num4 = num2;
					num2 = (short)995681678;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_81;
					default:
						goto IL_110;
					}
					break;
				}
				}
				goto IL_1C;
				IL_81:
				global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
				global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField2 = validatedField;
				workingCodeplugUuid = A_0.WorkingCodeplugUuid;
				validatedField2.Uuid = workingCodeplugUuid.Value;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Codeplug;
				validatedField.Timestamp = A_0.WorkingCodeplug.Timestamp;
				A_1.ValidateEntityList.Add(validatedField);
				num2 = (short)367919106;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_110:
			num2 = (short)1219756032;
			if (num2 != 0)
			{
			}
			num2 = (short)1434976257;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			workingCodeplugUuid = A_0.WorkingCodeplugUuid;
			num2 = (short)1121517569;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0007E378 File Offset: 0x0007C578
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Guid? lastJobUuid;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_80;
				case 1:
				{
					num2 = (short)930938880;
					short num3 = num2;
					if (lastJobUuid != null)
					{
						num2 = (short)1094451200;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
				{
					num2 = (short)1116888492;
					short num4 = num2;
					num2 = (short)80502188;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					default:
						goto IL_10E;
					}
					break;
				}
				}
				goto IL_1C;
				IL_80:
				global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
				global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField2 = validatedField;
				lastJobUuid = A_0.LastJobUuid;
				validatedField2.Uuid = lastJobUuid.Value;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Job;
				validatedField.Timestamp = A_0.LastJob.Timestamp;
				A_1.ValidateEntityList.Add(validatedField);
				num2 = (short)358219778;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_10E:
			num2 = (short)1300430848;
			if (num2 != 0)
			{
			}
			num2 = (short)1507262465;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			lastJobUuid = A_0.LastJobUuid;
			num2 = (short)2093940737;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0007E4D4 File Offset: 0x0007C6D4
		private static global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet a(global::Motorola.CommonCPS.Server.EntityModel.Radio device)
		{
			short num = (short)839482300;
			short num2 = num;
			num = (short)792886204;
			switch (num2 == num)
			{
			}
			num = (short)1254555648;
			short num3 = num;
			num = (short)1728380929;
			if (num != 0)
			{
			}
			num = (short)416481280;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.RelatedObject = new global::System.Guid?(device.Uuid);
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
			validatedField.Uuid = device.Uuid;
			validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
			validatedField.Timestamp = device.Timestamp;
			validateEntitySet.ValidateEntityList.Add(validatedField);
			return validateEntitySet;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0007E5D4 File Offset: 0x0007C7D4
		private static global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet a(global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary A_0)
		{
			short num = (short)2118159944;
			short num2 = num;
			num = (short)2082115144;
			switch (num2 == num)
			{
			}
			num = (short)1355087872;
			short num3 = num;
			num = (short)1284767744;
			if (num != 0)
			{
			}
			num = (short)1541275649;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.RelatedObject = new global::System.Guid?(A_0.Uuid);
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Configuration;
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
			validatedField.Uuid = A_0.Uuid;
			validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Configuration;
			validatedField.Timestamp = A_0.Timestamp;
			validateEntitySet.ValidateEntityList.Add(validatedField);
			return validateEntitySet;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0007E6D8 File Offset: 0x0007C8D8
		private static global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet a(global::Motorola.CommonCPS.Server.EntityModel.RecordSummary emItem)
		{
			short num = (short)239758308;
			short num2 = num;
			num = (short)1397386212;
			switch (num2 == num)
			{
			}
			num = (short)694943744;
			short num3 = num;
			num = (short)362020865;
			if (num != 0)
			{
			}
			num = (short)1891696640;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.RelatedObject = new global::System.Guid?(new global::System.Guid(emItem.UUID));
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.ConfigurationSet;
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
			validatedField.Uuid = new global::System.Guid(emItem.UUID);
			validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.ConfigurationSet;
			validatedField.Timestamp = emItem.Timestamp;
			validateEntitySet.ValidateEntityList.Add(validatedField);
			return validateEntitySet;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0007E7E8 File Offset: 0x0007C9E8
		private static global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet a(global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem sys)
		{
			short num = (short)981397873;
			short num2 = num;
			num = (short)2094723441;
			switch (num2 == num)
			{
			}
			num = (short)1784086528;
			short num3 = num;
			num = (short)1891631104;
			if (num != 0)
			{
			}
			num = (short)881721345;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.RelatedObject = new global::System.Guid?(sys.Uuid);
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.IPProgramSystem;
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
			validatedField.Uuid = sys.Uuid;
			validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.IPProgramSystem;
			validatedField.Timestamp = sys.Timestamp;
			validateEntitySet.ValidateEntityList.Add(validatedField);
			return validateEntitySet;
		}
	}
}
