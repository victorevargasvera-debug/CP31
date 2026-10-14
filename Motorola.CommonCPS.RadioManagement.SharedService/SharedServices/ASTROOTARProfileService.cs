using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000020 RID: 32
	internal class ASTROOTARProfileService : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROOTARProfileService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x0600048F RID: 1167 RVA: 0x000296B8 File Offset: 0x000278B8
		public ASTROOTARProfileService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase validationServiceBase) : base(serverAccessor, validationServiceBase)
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000296D0 File Offset: 0x000278D0
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> EditOTARProfilesFields(global::Motorola.CommonCPS.Server.EntityModel.Radio apxRadio, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> otarProfiles, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.OtarFieldType, object> fieldValues)
		{
			short num = (short)1832189957;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (otarProfiles == null)
					{
						num = (short)143130630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO>();
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> enumerator = otarProfiles.GetEnumerator();
					num = (short)558563331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)1293418496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)3670016;
					short num3 = num;
					num = (short)494338052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_2CC;
				case 4:
					if (fieldValues != null)
					{
						num = (short)1995767809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20F;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 6:
					goto IL_27C;
				}
				IL_40:
				if (apxRadio == null)
				{
					break;
				}
				num = (short)698875906;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_20F:
			throw new global::System.ArgumentNullException();
			IL_27C:
			num = (short)1194524673;
			if (num != 0)
			{
			}
			goto IL_20F;
			IL_2CC:
			try
			{
				num = (short)885456899;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> list;
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1906180097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1A1;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)1450049536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_C1;
						}
						continue;
					case 4:
					{
						num = (short)515785484;
						short num4 = num;
						num = (short)1200571148;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F8;
						default:
							num = (short)321781760;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					}
					IL_C3:
					num = (short)1127219202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C1:
					goto IL_C3;
					IL_F8:
					global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxotarProfile = enumerator.Current;
					list.Add(base.ServerAccessor.EditASTROOTARProfile(apxRadio.Uuid, apxotarProfile.Uuid, fieldValues, null));
					num = (short)989659140;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A1:
				return list;
			}
			finally
			{
				num = (short)257884161;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> enumerator;
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1743323138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1D8;
						}
						continue;
					case 2:
						goto IL_20C;
					}
					IL_1D8:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1249574912;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_20C:;
			}
			goto IL_20F;
		}
	}
}
