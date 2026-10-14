using System;
using System.Data;
using System.Data.SqlClient;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200005D RID: 93
	public class MapOfConfigDBNodeUpdateDao
	{
		// Token: 0x0600071D RID: 1821 RVA: 0x0004F330 File Offset: 0x0004D530
		public static int SaveNew(global::System.Data.SqlClient.SqlConnection con, global::Motorola.CommonCPS.Server.EntityModel.MapOfConfigDBNodeUpdate target)
		{
			int a_ = 10;
			for (;;)
			{
				IL_09:
				short num = (short)784596993;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Data.SqlClient.SqlCommand sqlCommand;
					switch (num2)
					{
					case 0:
						try
						{
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䠇䤉挋怍瘏笑猓挕樗笙栛眝伟䰡焣匥䄧丩", a_), global::System.Data.SqlDbType.UniqueIdentifier).Value = target.ConfigurationUuid;
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䠇三下䀍缏瘑焓䌕栗縙紛樝䔟昡䔣別䤧礩䌫嬭䈯儱儳挵䴷匹堻", a_), global::System.Data.SqlDbType.UniqueIdentifier).Value = target.DBNodeUpdateDataSourceUuid;
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䠇䤉挋怍瘏笑猓挕樗笙栛眝伟䰡爣䌥娧天䔫䄭帯愱䀳圵唷䨹", a_), global::System.Data.SqlDbType.BigInt).Value = target.ConfigurationVersionStamp;
							return sqlCommand.ExecuteNonQuery();
						}
						finally
						{
							num = (short)1896349697;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1C0;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_18C;
									}
									continue;
								case 2:
									((global::System.IDisposable)sqlCommand).Dispose();
									num = (short)797310976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_18C:
								if (sqlCommand == null)
								{
									break;
								}
								num = (short)625344514;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1C0:;
						}
						goto IL_1C3;
					case 1:
					{
						num = (short)2027591477;
						short num3 = num;
						num = (short)1362597685;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)1356857345;
							if (num != 0)
							{
							}
							num = (short)1283981312;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_B0;
							}
							continue;
						}
						break;
					}
					case 2:
						goto IL_1C3;
					}
					IL_B0:
					if (target != null)
					{
						num = (short)467599362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21F;
					IL_1C3:
					num = (short)151912448;
					short num4 = num;
					sqlCommand = new global::System.Data.SqlClient.SqlCommand(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䄇䐉弋䬍䈏䘑㐓引嘗丙匛㸝洟䌡吣椥丧椩䌫䀭嘯嬱匳爵稷琹医娽┿ᝁ㑃≅⥇㹉⥋晍ፏ㵑㩓さㅗ㵙⥛ⱝşᙡൣ॥٧㽩ᥫݭᑯ幱味㉵㩷㑹፻᩽힁ﺉ쪍얕ﶝ얟톣쾥첧蚩貫\udfaf\udcb1튳\udfb5\udfb7쾹캻\udfbd뒿ꯁꯃꣅ黇꿉뻋뷍맏뷑뫓藕곗믙뇛껝짟싡닣꟥ꓧ뿩ꧫ뷭\ud8ef닱럳駵雷鳹闻駽痿瀁攃爅愇攉戋嬍攏笑瀓㨕㠗娙堛尝渟䴡䀣䌥紧娩䠫伭䐯圱瀳圵䰷嬹漻儽㔿ぁ❃⍅ᵇ㽉╋⩍籏牑ᑓᕕ㝗㑙㩛㝝ݟᝡᙣݥᱧͩͫm♯᝱ٳյᅷᕹቻ⵽ꆇ", a_), con);
					num = (short)1825439744;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_21F:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("簇欉縋植甏昑㐓笕眗縙礛爝\u001fȡ䜣䜥䘧䐩䌫娭ု倱儳ᘵ嘷伹倻刽怿ⵁ㙃晅㱇⭉㹋⥍㕏♑瑓㽕⭗穙㉛ㅝᑟ䉡գ䙥ŧѩὫᩭᅯᱱᝳ፵塷ᕹ᩻幽썿曆ﲍﶓ秊\udf99얟첡킣쾥잧쒩", a_));
		}

		// Token: 0x0400037F RID: 895
		protected const string SaveNewMapOfConfigDBNodeUpdate = "INSERT INTO MapOfConfigDBNodeUpdate(ConfigurationUuid, DBNodeUpdateDataSourceUuid, ConfigurationVersionStamp) VALUES(@ConfigurationUuid, @DBNodeUpdateDataSourceUuid, @ConfigurationVersionStamp)";

		// Token: 0x04000380 RID: 896
		protected const string GetConfigurationVersionOfDBNodeUpdate = "SELECT [ConfigurationVersionStamp] FROM [dbo].[MapOfConfigDBNodeUpdate] WHERE [ConfigurationUuid] = @ConfigurationUuid and [DBNodeUpdateDataSourceUuid] = @DSUuid";
	}
}
