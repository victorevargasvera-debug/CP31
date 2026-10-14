using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000027 RID: 39
	internal class CommonDeviceService : global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceServiceBase
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x00031688 File Offset: 0x0002F888
		public CommonDeviceService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor) : base(serverAccessor, null, null)
		{
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000316A0 File Offset: 0x0002F8A0
		public override string AddFileSuffix(string filePath)
		{
			short num = (short)1424452482;
			short num2 = num;
			num = (short)1810197378;
			switch (num2 == num)
			{
			}
			num = (short)2058878976;
			if (num != 0)
			{
			}
			num = (short)1797652481;
			if (num != 0)
			{
			}
			num = (short)645660672;
			short num3 = num;
			return string.Empty;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00031750 File Offset: 0x0002F950
		public override global::Motorola.CommonCPS.Server.EntityModel.RadioSummary EditRadioFields(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> fieldValues)
		{
			short num = (short)825556996;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
			for (;;)
			{
				global::System.Guid? guid;
				switch (num2)
				{
				case 0:
					if (fieldValues == null)
					{
						num = (short)1009975304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
					validateEntitySet.RelatedObject = new global::System.Guid?(radio.Uuid);
					validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
					validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio);
					guid = radio.LastJobUuid;
					num = (short)968949763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.WorkingCodeplug);
					num = (short)967376898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1FF;
				case 3:
					if (guid != null)
					{
						num = (short)1830289413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 5:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.LastJob);
					num = (short)2045575175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)2000933273;
					short num3 = num;
					num = (short)1855443353;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D4;
					default:
						num = (short)444858369;
						if (num != 0)
						{
						}
						num = (short)1563885568;
						if (num != 0)
						{
						}
						num = (short)130809856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_6C;
				case 8:
					goto IL_1D4;
				case 9:
					if (guid != null)
					{
						num = (short)467271681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_234;
				}
				IL_4C:
				if (radio != null)
				{
					num = (short)119996422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_6C:
				guid = radio.WorkingCodeplugUuid;
				num = (short)333316105;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1D4:
			goto IL_201;
			IL_1FF:
			goto IL_234;
			IL_201:
			throw new global::System.ArgumentNullException();
			IL_234:
			num = (short)639762432;
			short num4 = num;
			return base.ServerAccessor.EditRadio(radio.Uuid, fieldValues, validateEntitySet);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000319D0 File Offset: 0x0002FBD0
		public override global::Motorola.CommonCPS.Server.EntityModel.RadioSummary SubmitTransferRadioIdentity(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> transferRadioIdentityRecords)
		{
			short num = (short)154253045;
			short num2 = num;
			num = (short)2017572597;
			switch (num2 == num)
			{
			}
			num = (short)125698049;
			if (num != 0)
			{
			}
			num = (short)821166080;
			if (num != 0)
			{
			}
			num = (short)2027290624;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
