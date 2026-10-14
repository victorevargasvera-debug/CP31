using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;
using Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels
{
	// Token: 0x020001EE RID: 494
	public class SyncDataSourceOfRecordDao
	{
		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x001078F4 File Offset: 0x00105AF4
		// (set) Token: 0x06001862 RID: 6242 RVA: 0x001079A4 File Offset: 0x00105BA4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid Uuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)469434368;
				short num2 = num;
				num = (short)582011217;
				short num3 = num;
				num = (short)1795017041;
				switch (num3 == num)
				{
				}
				num = (short)281608192;
				if (num != 0)
				{
				}
				num = (short)2293761;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)767426560;
				short num2 = num;
				num = (short)1265509920;
				short num3 = num;
				num = (short)741025312;
				switch (num3 == num)
				{
				}
				num = (short)2020474881;
				if (num != 0)
				{
				}
				num = (short)207618048;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x00107A54 File Offset: 0x00105C54
		// (set) Token: 0x06001864 RID: 6244 RVA: 0x00107B04 File Offset: 0x00105D04
		public byte[] SyncDataSource
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)866975744;
				short num2 = num;
				num = (short)366851792;
				short num3 = num;
				num = (short)737064656;
				switch (num3 == num)
				{
				}
				num = (short)392691713;
				if (num != 0)
				{
				}
				num = (short)1086324736;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)713555968;
				short num2 = num;
				num = (short)1079322880;
				short num3 = num;
				num = (short)2018650368;
				switch (num3 == num)
				{
				}
				num = (short)1942159360;
				if (num != 0)
				{
				}
				num = (short)974716929;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x00107BB4 File Offset: 0x00105DB4
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord InternalInstance
		{
			get
			{
				short num = (short)891363919;
				short num2 = num;
				num = (short)1254236751;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A5;
				case 1:
					break;
				default:
				{
					num = (short)610336768;
					short num3 = num;
					break;
				}
				}
				num = (short)358023169;
				if (num != 0)
				{
				}
				num = (short)1626734592;
				if (num != 0)
				{
				}
				if (this.SyncDataSource == null)
				{
					return null;
				}
				IL_A5:
				return global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.DeserializeAndUnzip<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord>(this.SyncDataSource);
			}
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00107C78 File Offset: 0x00105E78
		public static global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecordDao WrapperInstance(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord internalInstance)
		{
			short num = (short)1070444605;
			short num2 = num;
			num = (short)1090433085;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_79;
			case 1:
				break;
			default:
			{
				num = (short)1636630528;
				short num3 = num;
				break;
			}
			}
			num = (short)256376832;
			if (num != 0)
			{
			}
			if (internalInstance == null)
			{
				num = (short)2114191361;
				if (num != 0)
				{
				}
				return null;
			}
			IL_79:
			return new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecordDao
			{
				Uuid = internalInstance.Uuid,
				SyncDataSource = global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.SerializeAndZip(internalInstance)
			};
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x00107D48 File Offset: 0x00105F48
		public static global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter>> FindById(global::System.Guid Id)
		{
			int a_ = 13;
			short num = (short)1061987201;
			short num2 = num;
			num = (short)273720193;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B0;
			case 1:
				break;
			default:
			{
				num = (short)536018944;
				short num3 = num;
				break;
			}
			}
			num = (short)1492451329;
			if (num != 0)
			{
			}
			num = (short)200409088;
			if (num != 0)
			{
			}
			if (Id.Equals(global::System.Guid.Empty))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("伊氌笎瀐㌒研砖紘縚焜㼞䠠䜢Ԥ䐦䠨䔪䌬䀮䔰ጲ圴制ᤸ唺䠼匾ⵀ", a_));
			}
			IL_B0:
			string key = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("؊܌⼎ㄐ㌒㔔㜖㤘㬚㴜㼞Ġ̢Ԥܦनପബ༮ᄰጲ䘴制唸帺帼䬾慀乂佄杆楈歊浌潎煐獒畔睖祘筚絜罞䅠䍢䕤䝦䥨䭪䵬㑮⑰ٲᱴ፶⑸坺灼畾ꆀꎂꖄꞆꦈꮊ권꾎놐뎒떔랖릘뮚붜뾞膠莢薤螦풬솮튰풴쎶\ud8b8튼쪾돀ꃂꃄ髆쓈쇊律ﯚ﷜￞쇠쏢엤쟦짨쯪췬쿮퇰뗲ꟴ룶듸\udbfa℀⌂┄✆⤈⬊ⴌ⼎ㄐ㌒㔔㜖㤘㬚㴜㼞Ġ̢Ԥܦ爨砪听䄮到眲吴䌶堸栺刼䨾㍀⁂⁄ࡆ⽈᥊⡌ⱎ㹐⅒ㅔ੖祘ⱚ㕜㩞፠٢䕤㱦㱨ṪѬ୮Ɒ乲㕴≶౸ቺ᥼", a_);
			global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> value = new global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter>
			{
				new global::System.Data.SqlClient.SqlParameter
				{
					SqlDbType = global::System.Data.SqlDbType.UniqueIdentifier,
					ParameterName = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("帊砌明甐", a_),
					SqlValue = Id
				}
			};
			return new global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter>>(key, value);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00107E68 File Offset: 0x00106068
		public static int SaveNew(global::System.Data.SqlClient.SqlConnection sqlConnect, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord target)
		{
			int a_ = 16;
			for (;;)
			{
				IL_09:
				short num = (short)1842282496;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Data.SqlClient.SqlCommand sqlCommand;
					global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecordDao syncDataSourceOfRecordDao;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3B;
						}
						continue;
					case 1:
						num = (short)668336129;
						if (num != 0)
						{
						}
						try
						{
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("不䌏欑稓甕尗笙栛缝猟䴡儣吥䬧伩", a_), global::System.Data.SqlDbType.VarBinary);
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("不䔏朑紓爕", a_), global::System.Data.SqlDbType.UniqueIdentifier);
							sqlCommand.Parameters[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("不䔏朑紓爕", a_)].Value = syncDataSourceOfRecordDao.Uuid;
							sqlCommand.Parameters[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("不䌏欑稓甕尗笙栛缝猟䴡儣吥䬧伩", a_)].Value = ((syncDataSourceOfRecordDao.SyncDataSource == null) ? global::System.DBNull.Value : syncDataSourceOfRecordDao.SyncDataSource);
							return sqlCommand.ExecuteNonQuery();
						}
						finally
						{
							num = (short)1115357184;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1A7;
									}
									continue;
								case 1:
									goto IL_1DB;
								case 2:
									((global::System.IDisposable)sqlCommand).Dispose();
									num = (short)590151681;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1A7:
								if (sqlCommand == null)
								{
									break;
								}
								num = (short)210370562;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1DB:;
						}
						goto IL_1DE;
					case 2:
						goto IL_1DE;
					}
					IL_3B:
					num = (short)1048313856;
					short num3 = num;
					num = (short)247132209;
					short num4 = num;
					num = (short)255651889;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_09;
					default:
						num = (short)2081816576;
						if (num != 0)
						{
						}
						if (target != null)
						{
							num = (short)85852162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23C;
					}
					IL_1DE:
					string cmdText = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("̍ᨏ㈑㐓㘕㠗㨙㰛㸝\u001fȡУإࠧ਩ఫอုሱᐳᘵᠷ匹刻䴽┿ぁぃ晅ⅇ⑉㡋⅍灏彑幓癕硗穙籛繝䁟䉡䑣䙥䡧䩩䱫乭偯剱味噵塷婹屻幽ꁿꊁꒃ햅쪍얕ﶝ얟슣춧즩쎫\udcad풯骱쎵톷\udeb9邻릿곁ꟃ苅꧇뻉귋鷍뿏ꟑꛓ뗕뷗퇛퓝샟싡쓣웥죧쫩쳫컭탯틱퓳훵\ud8f7\udaf9\udcfb\udefd⃿∁␃★縇欉怋笍甏愑㰓嘕䴗漙甛稝ట戡眣弥䘧䤩栫伭䐯匱朳夵䴷䠹弻嬽椿佁乃晅桇橉汋湍灏牑瑓癕硗穙籛繝䁟䉡䑣", a_);
					syncDataSourceOfRecordDao = global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecordDao.WrapperInstance(target);
					sqlCommand = new global::System.Data.SqlClient.SqlCommand(cmdText, sqlConnect);
					num = (short)965410817;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_23C:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("稍焏怑猓猕気㨙焛焝䐟䜡䠣إࠧ䤩䴫䀭帯崱䀳ᘵ娷弹᰻倽㔿⹁⡃晅", a_));
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x001080D8 File Offset: 0x001062D8
		public static int Update(global::System.Data.SqlClient.SqlConnection sqlConnect, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord target)
		{
			int a_ = 12;
			for (;;)
			{
				IL_09:
				short num = (short)218562560;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Data.SqlClient.SqlCommand sqlCommand;
					global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecordDao syncDataSourceOfRecordDao;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3B;
						}
						continue;
					case 1:
						try
						{
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䨉弋眍縏焑倓眕気笙伛焝唟倡䜣䌥", a_), global::System.Data.SqlDbType.VarBinary);
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䨉夋笍礏瘑", a_), global::System.Data.SqlDbType.UniqueIdentifier);
							sqlCommand.Parameters[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䨉夋笍礏瘑", a_)].Value = syncDataSourceOfRecordDao.Uuid;
							sqlCommand.Parameters[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䨉弋眍縏焑倓眕気笙伛焝唟倡䜣䌥", a_)].Value = ((syncDataSourceOfRecordDao.SyncDataSource == null) ? global::System.DBNull.Value : syncDataSourceOfRecordDao.SyncDataSource);
							return sqlCommand.ExecuteNonQuery();
						}
						finally
						{
							num = (short)2012348416;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1CC;
									}
									continue;
								case 1:
									goto IL_202;
								case 2:
									((global::System.IDisposable)sqlCommand).Dispose();
									num = (short)146079745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1CC:
								if (sqlCommand == null)
								{
									break;
								}
								num = (short)553254914;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_202:;
						}
						goto IL_205;
					case 2:
						goto IL_205;
					}
					IL_3B:
					num = (short)1137704960;
					short num3 = num;
					num = (short)1770959028;
					short num4 = num;
					num = (short)2057416884;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_09;
					default:
						num = (short)1263534081;
						if (num != 0)
						{
						}
						num = (short)532938752;
						if (num != 0)
						{
						}
						if (target != null)
						{
							num = (short)827523074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23E;
					}
					IL_205:
					string cmdText = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("܉؋⸍』㈑㐓㘕㠗㨙㰛㸝\u001fȡУإࠧ਩ఫอုሱᐳ缵縷ᨹ礻昽िᅁ၃ᕅ桇扉Ὃ୍ᱏᝑᝓɕ硗ཙ⥛㝝џ䉡≣㑥❧❩䱫㕭⍯ୱᩳᕵ㱷᭹ࡻώ퍿쎋슏秊ﺙ솛뺝誩嶺\udbad\ud9af횱観쾹햻\udabd쿁컃龎ﳛﻝ샟싡쓣웥죧쫩쳫컭탯틱퓳ꏵ裷黹鷻諽旿∁弃唅焇搉漋䨍焏昑甓䔕眗漙減紝䔟洡䈣琥䴧䤩䌫尭启漱㤳㰵ᠷᨹ᰻ḽ怿扁摃晅桇橉汋湍灏牑瑓癕硗穙籛繝䁟䉡䑣䙥㭧ཀྵᡫ乭⍯ୱᩳᕵ㱷᭹ࡻώ퍿놋캍쎏望\udc97ﮙﾝ춡톣풥쮧쾩ꆫ꒭邯銱钳隵颷骹鲻麽龎ﳛﻝ럟諡臣铥跧쫩맫鯭駯雱짳뛵귷迹闻髽෿ࠁ␃★⠇⨉Ⰻ⸍』㈑㐓㘕㠗㨙㰛㸝\u001fȡУإࠧ਩椫戭振眱㤳㰵ᠷᨹ᰻ḽ怿扁摃晅桇橉汋湍灏牑瑓癕硗穙籛繝䁟䉡䑣䙥ŧѩὫ୭ɯٱ味ήᙷ๹፻幽\udb7f톁ﶃ캉揄솑ﮓ蓮鍊톝욟솣얥잧\ud8a9좫颯솳\udfb5\udcb7隹잽꺿ꇁ胃Ʂ볇ꯉ鿋ꇍꗏꃑ럓돕ퟙ훛ﻝ샟싡쓣웥죧쫩쳫컭탯틱퓳훵\ud8f7\udaf9\udcfb\udefd⃿∁␃★⠇⨉Ⰻ砍焏縑愓猕欗㈙尛䬝唟䬡䀣ਥ栧礩唫䀭匯瘱唳䈵夷椹医䬽㈿⅁⅃潅䕇䁉汋湍灏牑瑓癕硗穙籛繝䁟䉡䑣䙥䡧䩩", a_);
					syncDataSourceOfRecordDao = global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecordDao.WrapperInstance(target);
					sqlCommand = new global::System.Data.SqlClient.SqlCommand(cmdText, sqlConnect);
					num = (short)1923416065;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_23E:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("縉洋簍眏眑怓㘕甗甙砛笝䰟ȡУ䔥䤧䐩䈫䄭䐯ሱ嘳匵ᠷ吹䤻刽ⰿ扁", a_));
		}

		// Token: 0x04000B53 RID: 2899
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid a;

		// Token: 0x04000B54 RID: 2900
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte[] b;
	}
}
