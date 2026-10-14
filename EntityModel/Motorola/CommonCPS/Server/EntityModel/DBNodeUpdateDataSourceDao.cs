using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000046 RID: 70
	public class DBNodeUpdateDataSourceDao
	{
		// Token: 0x060005F4 RID: 1524 RVA: 0x00042F1C File Offset: 0x0004111C
		public static int SaveNew(global::System.Data.SqlClient.SqlConnection con, global::Motorola.CommonCPS.Server.EntityModel.DBNodeUpdateDataSource target)
		{
			int a_ = 2;
			short num = (short)1561591810;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Data.SqlClient.SqlCommand sqlCommand;
				switch (num2)
				{
				case 0:
				{
					num = (short)554958848;
					short num3 = num;
					goto IL_1C1;
				}
				case 1:
					try
					{
						num = (short)867434497;
						if (num != 0)
						{
						}
						sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䃿圁焃漅氇", a_), global::System.Data.SqlDbType.UniqueIdentifier).Value = target.Uuid;
						sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䃿䄁氃朅昇洉椋樍吏猑怓眕娗挙栛笝匟", a_), global::System.Data.SqlDbType.Binary).Value = target.ChangedDataBytes;
						return sqlCommand.ExecuteNonQuery();
					}
					finally
					{
						num = (short)2144731138;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								((global::System.IDisposable)sqlCommand).Dispose();
								num = (short)2004821769;
								short num4 = num;
								num = (short)1955997449;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_140;
								default:
									num = (short)799211520;
									if (num != 0)
									{
									}
									num = (short)229376001;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_1BE;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_13A;
								}
								continue;
							}
							goto IL_13A;
							IL_140:
							num = (short)753926144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_13A:
							if (sqlCommand != null)
							{
								goto IL_140;
							}
							break;
						}
						IL_1BE:;
					}
					goto IL_1C1;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				IL_3A:
				if (target != null)
				{
					num = (short)1014497280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1C1:
				sqlCommand = new global::System.Data.SqlClient.SqlCommand(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䧿䰁圃䌅娇帉Ⰻ䜍帏䘑嬓㘕尗堙创焝䐟䜡焣嘥䰧䬩堫䬭琯匱䀳圵欷唹䤻䰽⌿❁汃ፅ㵇⍉⡋才灏ᅑ㱓㝕㙗㵙㥛㩝⑟͡ၣݥ⩧፩ᡫ୭ͯ孱味⁵㥷㙹⥻㭽퍿ꪁ쒃펅ﶇꊍ낏튑힓ﺕ聯ﮛﮝ쒟얣튥즧햫\udaad햯솱鶳", a_), con);
				num = (short)1624768513;
				num2 = (int)((global::System.IntPtr)num);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("瓿持瘃愅洇縉Ⰻ挍缏瘑焓稕㠗㨙缛缝丟䰡䬣別ࠧ䠩䤫อ帯䜱堳娵ᠷ唹主ḽ㐿⍁㙃ⅅⵇ㹉汋❍⍏牑㩓㥕ⱗ穙㵛繝य़ౡᝣብ१ѩཫ୭偯ᵱታ噵㭷ᕹቻ᡽ﺉﺏ힑ﶗ쾟첡", a_));
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00043140 File Offset: 0x00041340
		public static global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter>> FindByUuid(global::System.Guid Uuid)
		{
			int a_ = 11;
			short num = (short)1468923905;
			if (num != 0)
			{
			}
			if (Uuid.Equals(global::System.Guid.Empty))
			{
				num = (short)1663605656;
				short num2 = num;
				num = (short)1154522008;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_41;
				case 1:
					break;
				default:
				{
					num = (short)25624576;
					short num3 = num;
					break;
				}
				}
				num = (short)1174798336;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("專縊搌欎ㄐ瀒琔礖㤘甚爜欞Ġ䄢䀤ܦ䰨䘪崬嬮䠰", a_));
			}
			IL_41:
			global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> value = new global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter>
			{
				new global::System.Data.SqlClient.SqlParameter
				{
					SqlDbType = global::System.Data.SqlDbType.UniqueIdentifier,
					ParameterName = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("專縊搌欎", a_),
					SqlValue = Uuid
				}
			};
			return new global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter>>(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("娈上䄌䨎刐䜒㔔䰖䰘渚琜笞簠༢縤搦䄨䨪䌬䠮吰圲焴嘶䴸娺缼䘾㕀♂㙄ᩆ楈ൊὌN᱐獒๔㍖㭘㑚\\煞㩠❢❤⥦٨ཪ࡬㩮ŰᝲᑴͶᱸ㽺ᱼ୾킂ﮈ튎놐쒒\udd94튖쮘\ude9a붜쒞얠솢쪤益螨ﾰ\udcb2톴튶쮺\ud9bc\udebe뗀ꛂ臄ꛆ뷈꫊黌ꃎꓐꇒ뛔닖蓘蛜諞铠諢臤뫦짨훪췬꿮ꓰ蛲鳴鏶", a_), value);
		}

		// Token: 0x040002F4 RID: 756
		protected const string SaveNewDBNodeUpdateDataSource = "INSERT INTO DBNodeUpdateDataSource(Uuid, ChangedDataBytes) VALUES(@Uuid, @ChangedDataBytes)";

		// Token: 0x040002F5 RID: 757
		protected const string GetDBNodeUpdateDataSourceByUuid = "SELECT [Uuid],[ChangedDataBytes] FROM [dbo].[DBNodeUpdateDataSource] WHERE [dbo].[DBNodeUpdateDataSource].[Uuid] = @Uuid";
	}
}
