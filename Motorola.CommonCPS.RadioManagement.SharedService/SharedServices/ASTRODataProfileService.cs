using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200005C RID: 92
	internal class ASTRODataProfileService : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRODataProfileService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060006C6 RID: 1734 RVA: 0x00046010 File Offset: 0x00044210
		public ASTRODataProfileService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService astroValidationService) : base(serverAccessor, astroValidationService)
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00046028 File Offset: 0x00044228
		public global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary EditDataProfileFields(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Guid? DataProfileID, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> fieldValues)
		{
			short num = (short)668729344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				for (;;)
				{
					IL_28:
					global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
					global::System.Guid? guid;
					global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile entity;
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object> dictionary;
						try
						{
							num = (short)387317761;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3D4;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_34D;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)321060867;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object> keyValuePair = enumerator.Current;
									dictionary.Add(keyValuePair.Key, keyValuePair.Value);
									num = (short)1295515652;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1295122432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_384:
								num = (short)619184130;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_34D:
								goto IL_384;
							}
							IL_3D4:
							goto IL_1EF;
						}
						finally
						{
							num = (short)924450818;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> enumerator;
								switch (num2)
								{
								case 0:
								{
									num = (short)189535028;
									short num3 = num;
									num = (short)325784372;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_412;
									default:
										goto IL_47C;
									}
									break;
								}
								case 1:
									enumerator.Dispose();
									num = (short)2135883776;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_40B;
									}
									continue;
								}
								goto IL_40B;
								IL_412:
								num = (short)1598488577;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_40B:
								if (enumerator != null)
								{
									goto IL_412;
								}
								goto IL_493;
							}
							IL_47C:
							num = (short)1557856256;
							if (num != 0)
							{
							}
							IL_493:;
						}
						goto IL_494;
						IL_1EF:
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary result = base.ServerAccessor.EditAPXRadioProfile(radio.Uuid, DataProfileID.Value, dictionary, validateEntitySet);
						num = (short)2082013187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_112;
					case 2:
						goto IL_494;
					case 3:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary result;
						return result;
					}
					case 4:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.LastJob);
						num = (short)1264451585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (fieldValues != null)
						{
							num = (short)466223110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary result;
						return result;
					}
					case 6:
					{
						global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object> dictionary = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>();
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> enumerator = fieldValues.GetEnumerator();
						num = (short)1156448256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio);
						guid = radio.LastJobUuid;
						num = (short)727449612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (radio != null)
						{
							num = (short)2000289802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A;
					case 9:
						if (radio != null)
						{
							num = (short)80805888;
							short num4 = num;
							num = (short)396820487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5;
					case 10:
						num = (short)1435303937;
						if (num != 0)
						{
						}
						num = (short)1938292752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (guid != null)
						{
							num = (short)1064960002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5;
					case 12:
						if (guid != null)
						{
							num = (short)1172242436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112;
					case 13:
						num = (short)1306591249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_1A3;
					case 15:
						goto IL_1A5;
					case 16:
						if (fieldValues != null)
						{
							num = (short)1686437901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A;
					case 17:
					{
						if (DataProfileID == null)
						{
							num = (short)728629262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						entity = (radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).APXDataProfiles.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile p)
						{
							short num5 = (short)236249596;
							short num6 = num5;
							num5 = (short)1957290492;
							switch (num6 == num5)
							{
							}
							num5 = (short)386727937;
							if (num5 != 0)
							{
							}
							num5 = (short)1498546176;
							if (num5 != 0)
							{
							}
							num5 = (short)1274806272;
							short num7 = num5;
							return p.Uuid.Equals(DataProfileID);
						}).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>();
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary result = null;
						validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
						validateEntitySet.RelatedObject = new global::System.Guid?(radio.Uuid);
						validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
						validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
						num = (short)434110473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_77;
					IL_112:
					guid = radio.WorkingCodeplugUuid;
					num = (short)1954217995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A5:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, entity);
					num = (short)1101594629;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_494:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.WorkingCodeplug);
					num = (short)576847887;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_15A:
				throw new global::System.ArgumentNullException();
				IL_1A3:
				goto IL_15A;
				IL_77:
				num = (short)1519321096;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
		}
	}
}
