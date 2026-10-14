using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels;

namespace Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels
{
	// Token: 0x020001BF RID: 447
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ConfigurationExtention
	{
		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x000F6BD0 File Offset: 0x000F4DD0
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x000F6C84 File Offset: 0x000F4E84
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid ConfigurationUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1134336323;
				short num2 = num;
				num = (short)813930819;
				switch (num2 == num)
				{
				default:
				{
					num = (short)997916672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)60424192;
				if (num != 0)
				{
				}
				num = (short)147652609;
				if (num != 0)
				{
				}
				return this.<ConfigurationUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)226844500;
				short num2 = num;
				num = (short)2072993620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)478412800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2118057984;
				if (num != 0)
				{
				}
				num = (short)142802945;
				if (num != 0)
				{
				}
				this.<ConfigurationUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x000F6D34 File Offset: 0x000F4F34
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x000F6DE4 File Offset: 0x000F4FE4
		[global::System.Runtime.Serialization.DataMember]
		public long VersionStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1992670374;
				short num2 = num;
				num = (short)1758379174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1901395968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)79822849;
				if (num != 0)
				{
				}
				num = (short)2004287488;
				if (num != 0)
				{
				}
				return this.<VersionStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)780376212;
				short num2 = num;
				num = (short)885758100;
				switch (num2 == num)
				{
				default:
				{
					num = (short)664797184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2053636097;
				if (num != 0)
				{
				}
				num = (short)523698176;
				if (num != 0)
				{
				}
				this.<VersionStamp>k__BackingField = value;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x000F6E94 File Offset: 0x000F5094
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x000F6F44 File Offset: 0x000F5144
		[global::System.Runtime.Serialization.IgnoreDataMember]
		public long CacheVersionStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)244115147;
				short num2 = num;
				num = (short)2037442251;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1282670592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1920532480;
				if (num != 0)
				{
				}
				num = (short)1179975681;
				if (num != 0)
				{
				}
				return this.<CacheVersionStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1242404274;
				short num2 = num;
				num = (short)1194890674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1298857984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2112487425;
				if (num != 0)
				{
				}
				num = (short)1631846400;
				if (num != 0)
				{
				}
				this.<CacheVersionStamp>k__BackingField = value;
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x000F6FF4 File Offset: 0x000F51F4
		// (set) Token: 0x060016E3 RID: 5859 RVA: 0x000F70A4 File Offset: 0x000F52A4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? ArchivedRMFileGuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1290278447;
				short num2 = num;
				num = (short)128128559;
				switch (num2 == num)
				{
				default:
				{
					num = (short)233635840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1897791489;
				if (num != 0)
				{
				}
				num = (short)893059072;
				if (num != 0)
				{
				}
				return this.<ArchivedRMFileGuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2005500116;
				short num2 = num;
				num = (short)564429012;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1642790912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)980549633;
				if (num != 0)
				{
				}
				num = (short)972554240;
				if (num != 0)
				{
				}
				this.<ArchivedRMFileGuid>k__BackingField = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x000F7158 File Offset: 0x000F5358
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x000F7208 File Offset: 0x000F5408
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? ModifiedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)314108967;
				short num2 = num;
				num = (short)1068035111;
				switch (num2 == num)
				{
				default:
				{
					num = (short)490274816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)666697729;
				if (num != 0)
				{
				}
				num = (short)1443364864;
				if (num != 0)
				{
				}
				return this.<ModifiedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1146568822;
				short num2 = num;
				num = (short)1824473206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2073690112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1967652865;
				if (num != 0)
				{
				}
				num = (short)2017263616;
				if (num != 0)
				{
				}
				this.<ModifiedDate>k__BackingField = value;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x000F72B8 File Offset: 0x000F54B8
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x000F737C File Offset: 0x000F557C
		[global::System.Runtime.Serialization.DataMember]
		public byte[] SyncDataSource
		{
			get
			{
				if (this.OSyncDataSource != null)
				{
					short num;
					for (;;)
					{
						num = (short)1959127292;
						short num2 = num;
						num = (short)1512827132;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_42;
						}
					}
					IL_42:
					num = (short)455933953;
					if (num != 0)
					{
					}
					num = (short)768147456;
					if (num != 0)
					{
					}
					num = (short)107085824;
					short num3 = num;
					return global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.SerializeAndZip(this.OSyncDataSource);
				}
				return null;
			}
			set
			{
				short num;
				if (value != null)
				{
					for (;;)
					{
						num = (short)657190183;
						short num2 = num;
						num = (short)475393319;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_3B;
						}
					}
					IL_3B:
					num = (short)623837184;
					if (num != 0)
					{
					}
					this.OSyncDataSource = global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.DeserializeAndUnzip<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfConfiguration>(value);
					return;
				}
				num = (short)1261699072;
				short num3 = num;
				num = (short)372834305;
				if (num != 0)
				{
				}
				this.OSyncDataSource = null;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x000F7440 File Offset: 0x000F5640
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x000F74F4 File Offset: 0x000F56F4
		[global::System.Runtime.Serialization.DataMember]
		public long SyncDataVersionStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)807534593;
				if (num != 0)
				{
				}
				num = (short)356712448;
				short num2 = num;
				num = (short)1758019530;
				short num3 = num;
				num = (short)1518223306;
				switch (num3 == num)
				{
				}
				num = (short)2088763392;
				if (num != 0)
				{
				}
				return this.<SyncDataVersionStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1283981313;
				if (num != 0)
				{
				}
				num = (short)1762131968;
				short num2 = num;
				num = (short)1364471380;
				short num3 = num;
				num = (short)1860185684;
				switch (num3 == num)
				{
				}
				num = (short)1682571264;
				if (num != 0)
				{
				}
				this.<SyncDataVersionStamp>k__BackingField = value;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x000F75A8 File Offset: 0x000F57A8
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x000F7658 File Offset: 0x000F5858
		[global::System.Runtime.Serialization.DataMember]
		public long HOptionVersionStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1456388660;
				short num2 = num;
				num = (short)1023851060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1655898112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1017053185;
				if (num != 0)
				{
				}
				num = (short)1597636608;
				if (num != 0)
				{
				}
				return this.<HOptionVersionStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1425324430;
				short num2 = num;
				num = (short)825866638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)663486464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)88604673;
				if (num != 0)
				{
				}
				num = (short)1628962816;
				if (num != 0)
				{
				}
				this.<HOptionVersionStamp>k__BackingField = value;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x000F7708 File Offset: 0x000F5908
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x000F77BC File Offset: 0x000F59BC
		[global::System.Runtime.Serialization.IgnoreDataMember]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfConfiguration OSyncDataSource
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1821724865;
				short num2 = num;
				num = (short)1248809153;
				switch (num2 == num)
				{
				default:
				{
					num = (short)838074368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1481703425;
				if (num != 0)
				{
				}
				num = (short)1916272640;
				if (num != 0)
				{
				}
				return this.<OSyncDataSource>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1581842433;
				if (num != 0)
				{
				}
				num = (short)1035075584;
				short num2 = num;
				num = (short)1075842575;
				short num3 = num;
				num = (short)1282346511;
				switch (num3 == num)
				{
				}
				num = (short)546570240;
				if (num != 0)
				{
				}
				this.<OSyncDataSource>k__BackingField = value;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x000F786C File Offset: 0x000F5A6C
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x000F791C File Offset: 0x000F5B1C
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord> SyncRecords
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)342556672;
				short num2 = num;
				num = (short)905865050;
				short num3 = num;
				num = (short)109864794;
				switch (num3 == num)
				{
				}
				num = (short)1647902720;
				if (num != 0)
				{
				}
				num = (short)2136145921;
				if (num != 0)
				{
				}
				return this.<SyncRecords>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1756102656;
				short num2 = num;
				num = (short)1376836956;
				short num3 = num;
				num = (short)1213652316;
				switch (num3 == num)
				{
				}
				num = (short)1231093760;
				if (num != 0)
				{
				}
				num = (short)778436609;
				if (num != 0)
				{
				}
				this.<SyncRecords>k__BackingField = value;
			}
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x000F79D0 File Offset: 0x000F5BD0
		public static global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter>> FindById(global::System.Guid Id)
		{
			int a_ = 12;
			short num;
			for (;;)
			{
				num = (short)363528193;
				if (num != 0)
				{
				}
				num = (short)1587871744;
				short num2 = num;
				if (Id.Equals(global::System.Guid.Empty))
				{
					goto IL_106;
				}
				num = (short)1783063958;
				short num3 = num;
				num = (short)687826326;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A2;
				}
			}
			IL_A2:
			num = (short)1632960512;
			if (num != 0)
			{
			}
			string key = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("܉؋⸍』㈑㐓㘕㠗㨙㰛㸝\u001fȡУإࠧ਩ఫอုሱ䜳匵吷弹弻䨽怿佁乃晅桇橉汋湍灏牑瑓癕硗穙籛繝䁟䉡䑣䙥䡧䩩䱫㕭㍯ᵱᩳၵᅷᵹॻ౽\udf89曆쾑뢓鮕銗몙벛뺝肟芡蒣蚥袧誩貫躭邯銱钳隵颷骹鲻麽駁鋃ꏅ뫇막ꗋꇍ뻏臑ꃓ럕뗗꫙臛쓣웥죧쫩쳫컭탯틱퓳훵\ud8f7\udaf9\udcfb\udefd⃿∁␃★⠇⨉國䌍缏瘑紓瀕焗缙砛娝䄟嘡䄣笥Ч✩☫อုሱᐳᘵᠷᨹ᰻ḽ怿扁摃晅桇橉汋湍灏牑瑓ൕୗ⍙㉛㵝⑟͡ၣݥ㭧թᥫᱭ፯᝱⥳婵畷灹屻幽ꁿꊁꒃꚅꢇꪉ겋꺍낏늑뒓뚕뢗몙벛뺝肟芡ﾣ톧쒩쾫톯욱햳\uddb7좹쾻ힽ꾿곁韃닅꧇Ꟊ볋鏍ﳏ\udfd1\uded3龎ﳛﻝ샟싡쓣웥죧쫩쳫컭탯틱퓳훵\ud8f7\udaf9\udcfbꗽ䣿䴁球爅愇攉戋堍甏怑朓缕眗琙伛樝䄟伡吣笥Ч✩☫อုሱᐳᘵᠷᨹ᰻ḽ怿扁摃晅桇橉汋湍灏牑瑓ൕ᭗㭙㽛㙝՟㑡ţᑥ᭧ͩͫm⍯ٱᕳ᭵ࡷ❹偻獽詿ꊁꒃꚅꢇꪉ겋꺍낏늑뒓뚕뢗몙벛뺝肟芡蒣蚥袧\udcad펯\udab1\uddb3삵\uddb7\udeb9蚿ꯁꣃꏅ过뿉ꗋ꫍跏\udfd1\uded3龎ﳛﻝ샟싡쓣웥죧쫩쳫컭탯틱퓳훵\ud8f7\udaf9뫻곽俿企␃ଅȇ⨉Ⰻ⸍』㈑㐓㘕㠗㨙㰛㸝\u001fȡУإࠧ਩ఫอု椱眳夵嘷尹唻夽㔿ぁ╃㉅ⅇ╉≋୍⡏♑ㅓ㡕ⱗ㍙㍛そ㵟䉡፣๥൧ᡩ५乭㍯ᵱᩳၵᅷᵹॻ౽\udf89曆꾑풓쎕", a_);
			global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> value = new global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter>
			{
				new global::System.Data.SqlClient.SqlParameter
				{
					SqlDbType = global::System.Data.SqlDbType.UniqueIdentifier,
					ParameterName = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("弉礋服琏", a_),
					SqlValue = Id
				}
			};
			return new global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter>>(key, value);
			IL_106:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("三洋稍焏㈑礓礕簗缙瀛㸝䤟䘡У䔥䤧䐩䈫䄭䐯ሱ嘳匵ᠷ吹䤻刽ⰿ", a_));
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x000F7AF8 File Offset: 0x000F5CF8
		public static int SaveNew(global::System.Data.SqlClient.SqlConnection sqlConnect, global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationExtention target)
		{
			int a_ = 7;
			short num = (short)2112749568;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1140129792;
				num2 = (int)((global::System.IntPtr)num);
				int result;
				for (;;)
				{
					global::System.Data.SqlClient.SqlCommand sqlCommand;
					switch (num2)
					{
					case 0:
						goto IL_3B;
					case 1:
						goto IL_3D1;
					case 2:
					{
						try
						{
							switch (0)
							{
							case 0:
								goto IL_BD;
							}
							for (;;)
							{
								IL_AA:
								switch (num2)
								{
								case 0:
									sqlCommand.Parameters[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄吆瀈攊渌䬎瀐朒琔䐖瘘渚漜簞䐠", a_)].Value = ((target.SyncDataSource == null) ? global::System.DBNull.Value : target.SyncDataSource);
									sqlCommand.Parameters[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄䨆昈漊搌椎砐瘒焔化砘漚砜", a_)].Value = global::System.DateTime.UtcNow;
									num = (short)465240065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									sqlCommand.Parameters[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄䘆笈栊攌明朐瘒焔䔖吘崚琜猞䐠搢値並䴨", a_)].Value = ((target.ArchivedRMFileGuid != null) ? target.ArchivedRMFileGuid.Value : global::System.DBNull.Value);
									result = sqlCommand.ExecuteNonQuery();
									num = (short)470286338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_361;
								}
								goto IL_BD;
							}
							IL_361:
							goto IL_419;
							IL_BD:
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄吆瀈攊渌䬎瀐朒琔䐖瘘渚漜簞䐠", a_), global::System.Data.SqlDbType.VarBinary);
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄分簈戊椌", a_), global::System.Data.SqlDbType.UniqueIdentifier);
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄儆氈礊縌明縐紒䘔挖砘瘚洜", a_), global::System.Data.SqlDbType.BigInt);
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄䐆栈栊攌樎䜐瘒朔搖瀘琚猜䰞唠䈢䠤圦", a_), global::System.Data.SqlDbType.BigInt);
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄䨆昈漊搌椎砐瘒焔化砘漚砜", a_), global::System.Data.SqlDbType.DateTime2);
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄伆䘈笊礌明縐紒䌔爖欘栚琜瀞传瀢儤䘦䐨嬪", a_), global::System.Data.SqlDbType.BigInt);
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄吆瀈攊渌䬎瀐朒琔䄖簘椚渜瘞丠䴢瘤匦䠨䘪崬", a_), global::System.Data.SqlDbType.BigInt);
							sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄䘆笈栊攌明朐瘒焔䔖吘崚琜猞䐠搢値並䴨", a_), global::System.Data.SqlDbType.UniqueIdentifier);
							sqlCommand.Parameters[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄分簈戊椌", a_)].Value = target.ConfigurationUuid;
							sqlCommand.Parameters[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄儆氈礊縌明縐紒䘔挖砘瘚洜", a_)].Value = target.VersionStamp;
							sqlCommand.Parameters[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄䐆栈栊攌樎䜐瘒朔搖瀘琚猜䰞唠䈢䠤圦", a_)].Value = target.CacheVersionStamp;
							sqlCommand.Parameters[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄伆䘈笊礌明縐紒䌔爖欘栚琜瀞传瀢儤䘦䐨嬪", a_)].Value = target.HOptionVersionStamp;
							sqlCommand.Parameters[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔄吆瀈攊渌䬎瀐朒琔䄖簘椚渜瘞丠䴢瘤匦䠨䘪崬", a_)].Value = target.SyncDataVersionStamp;
							num = (short)20054016;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_AA;
						}
						finally
						{
							num = (short)943063040;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_398;
									}
									continue;
								case 1:
									((global::System.IDisposable)sqlCommand).Dispose();
									num = (short)648937474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3CE;
								}
								IL_398:
								if (sqlCommand == null)
								{
									break;
								}
								num = (short)320274433;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3CE:;
						}
						goto IL_3D1;
						IL_419:
						num = (short)430555287;
						short num3 = num;
						num = (short)571326615;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3B;
						default:
							goto IL_44E;
						}
						break;
					}
					}
					goto IL_58;
					IL_3B:
					switch (0)
					{
					case 0:
						IL_58:
						num = (short)124780545;
						if (num != 0)
						{
						}
						if (target == null)
						{
							goto IL_405;
						}
						num = (short)941096961;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_3D1:
					sqlCommand = new global::System.Data.SqlClient.SqlCommand(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("ࠄആ⤈⬊ⴌ⼎ㄐ㌒㔔㜖㤘㬚㴜㼞Ġ̢Ԥܦनପബ༮堰崲䘴制䬸伺ᴼ嘾⽀㝂⩄杆ੈ⑊⍌⥎㡐㑒⁔╖㡘⽚㑜ぞའ♢ᵤ፦౨ժᥬٮṰᵲ硴絶奸孺嵼彾ꆀꎂꖄꞆꦈꮊ권꾎놐뎒떔랖릘뮚붜뾞膠莢薤螦覨讪薬\udeb0\uddb2펴\udeb6\udeb8캺쾼\udebe뗀ꫂ꫄꧆鳈뻊꓌ꯎ﷐藒냔ꗖ꫘닚닜뇞닠韢蓤諦駨쟪껬軮鋰鯲郴ꇶ鳸觺軼雾渀洂嘄猆栈昊紌⌎尐簒焔縖缘爚砜笞攠䈢儤䈦Ԩ砪听䄮到眲吴䌶堸栺刼䨾㍀⁂⁄歆ňъ㵌㭎㡐㱒㭔Ŗ㱘⥚⹜㙞๠ൢ㙤፦ࡨ٪ᵬ䍮≰ੲ᭴ᑶ㵸᩺ॼṾ힀\udc8e떘\uda9aﲞ즠쪢펤슦춨寧\ud8b0\udfb2킴첸튺\ud9bc难쳀짂律ﯚ﷜￞쇠쏢엤쟦짨쯪鯬軮鷰蛲郴蓶퇸믺꣼諾栀朂⤄䜆弈渊缌簎砐簒笔䐖洘稚瀜漞ഠ挢昤䘦䨨䌪䠬礮吰䄲䘴帶嘸唺渼䬾⁀⹂㕄歆ैي≌⭎㡐㕒㱔㉖㵘὚㱜⭞Ѡ佢╤㑦ၨժ๬⭮ၰݲᑴ⑶ᙸ๺ོ᱾꾂얄쾆욈ﮊ歷ﺐﶒ쎔쾠톤욦쒨\udbaa膬쪲\udbb4풶ﶸ\udaba즼\udebe韀ꛂ럄듆ꃈ꓊ꏌ鳎ꗐ닒룔Ꟗﯚ鷜點鏠胢跤軦鿨軪觬뷮볰뗲鳴鯶鳸볺裼雾攀⨂ࠄആ⤈⬊ⴌ⼎ㄐ㌒㔔㜖㤘㬚㴜㼞Ġ̢Ԥܦ", a_), sqlConnect);
					num = (short)1934360578;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_405:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("焄昆笈氊栌笎ㄐ縒稔猖簘眚㴜㼞䈠䈢䬤䤦䘨弪ബ䴮吰ጲ嬴䈶唸场ᴼ倾㍀捂ㅄ♆㭈ⱊ⡌㭎煐㩒♔睖㝘㑚⥜罞`䍢౤०ᩨὪ౬Ůተᙲ啴ᡶὸ孺㹼ၾﲈ力ﮎﲒﮔ튖햠쪢쪤즦", a_));
				IL_44E:
				num = (short)1342373888;
				if (num != 0)
				{
				}
				num = (short)688717824;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x000F7FB0 File Offset: 0x000F61B0
		public static int Update(global::System.Data.SqlClient.SqlConnection sqlConnect, global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationExtention target)
		{
			int a_ = 19;
			short num = (short)1887436800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)805765120;
				num2 = (int)((global::System.IntPtr)num);
				int result;
				for (;;)
				{
					global::System.Data.SqlClient.SqlCommand sqlCommand;
					switch (num2)
					{
					case 0:
						goto IL_3D;
					case 1:
						goto IL_2DE;
					case 2:
					{
						try
						{
							num = (short)740884480;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_AC;
									}
									continue;
								case 1:
									sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儐划朔琖焘爚欜稞䔠焢栤愦䀨䜪䠬栮䐰娲儴", a_), global::System.Data.SqlDbType.UniqueIdentifier).Value = ((target.ArchivedRMFileGuid != null) ? target.ArchivedRMFileGuid.Value : global::System.DBNull.Value);
									result = sqlCommand.ExecuteNonQuery();
									num = (short)413204482;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_26E;
								}
								IL_AC:
								sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儐䀒气礖稘弚簜欞䀠瀢䨤刦嬨䠪䠬", a_), global::System.Data.SqlDbType.VarBinary).Value = ((target.SyncDataSource == null) ? global::System.DBNull.Value : target.SyncDataSource);
								sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儐䘒怔縖紘", a_), global::System.Data.SqlDbType.UniqueIdentifier).Value = target.ConfigurationUuid;
								sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儐䔒瀔攖樘爚爜焞爠圢䐤䨦夨", a_), global::System.Data.SqlDbType.BigInt).Value = target.VersionStamp;
								sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儐倒琔琖焘縚䬜稞匠倢䰤䠦䜨砪夬丮尰䌲", a_), global::System.Data.SqlDbType.BigInt).Value = target.CacheVersionStamp;
								sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儐帒稔猖瀘級琜稞䔠朢䐤匦䰨", a_), global::System.Data.SqlDbType.DateTime2).Value = global::System.DateTime.UtcNow;
								sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儐嬒娔朖洘爚爜焞眠䘢圤否䀨䐪䌬簮䔰刲場䜶", a_), global::System.Data.SqlDbType.BigInt).Value = target.HOptionVersionStamp;
								sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儐䀒气礖稘弚簜欞䀠產䀤唦娨䈪䈬䄮戰䜲吴娶䤸", a_), global::System.Data.SqlDbType.BigInt).Value = target.SyncDataVersionStamp;
								num = (short)1742667777;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_26E:
							goto IL_34D;
						}
						finally
						{
							num = (short)2029518848;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2A6;
									}
									continue;
								case 1:
									((global::System.IDisposable)sqlCommand).Dispose();
									num = (short)1313669122;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2DB;
								}
								IL_2A6:
								if (sqlCommand == null)
								{
									break;
								}
								num = (short)385024001;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2DB:;
						}
						goto IL_2DE;
						IL_34D:
						num = (short)940818378;
						short num3 = num;
						num = (short)1154924490;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3D;
						default:
							goto IL_382;
						}
						break;
					}
					}
					goto IL_5A;
					IL_3D:
					switch (0)
					{
					case 0:
						IL_5A:
						if (target == null)
						{
							goto IL_312;
						}
						num = (short)937361409;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_2DE:
					sqlCommand = new global::System.Data.SqlClient.SqlCommand(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("ᰐᤒ㔔㜖㤘㬚㴜㼞Ġ̢Ԥܦनପബ༮ᄰጲᔴ᜶ᤸᬺ䠼伾╀≂ㅄ≆䑈䅊浌潎煐獒畔睖祘筚絜罞䅠䍢䕤䝦䥨䭪䵬佮兰卲啴坶奸孺㹼ၾﲈ力ﮎﲒﮔ튖햠쪢쪤즦꒨ꆪ趬辮醰鎲閴鞶馸鮺鶼龾ꛔ닖귘훚ퟜ￞쇠쏢엤쟦짨쯪췬쿮퇰폲헴ퟶ\ud9f8\udbfa\uddfc\udffe℀⌂┄✆⤈⬊ⴌ夎琐愒昔縖瘘甚东欞䀠丢唤ᨦ椨紪䠬崮䈰娲娴夶樸伺尼刾ㅀ潂䡄䵆楈歊浌潎煐獒畔睖祘筚絜罞䅠䍢䕤䝦䥨䭪䵬佮兰卲啴坶㑸ᑺ᥼ᙾ춈歷겐펒\ud894ﶘﮜ쒠잢욦\udda8캪膬ꊮ뮰鎲閴鞶馸鮺鶼龾律ﯚ﷜￞쇠냢鳤触諨꿪賬鯮郰ꃲ髴苶诸飺飼싾䄀倂簄椆樈伊氌笎瀐䀒稔或欘砚砜㌞Ⱐ⤢Ԥܦनପബ༮ᄰጲᔴ᜶ᤸᬺᴼἾ慀捂敄杆楈歊浌潎煐獒ᵔᡖ⥘⽚㑜ぞའ㕢dᕦᩨɪɬŮ≰ݲᑴ᩶ॸ䙺㵼㝾캀\udb8cﲔ좚ﺞ철펢覤ꪦꎨ讪趬辮醰鎲閴鞶馸鮺鶼龾律裚ꓜ뇞苠꟢蓤鏦裨뷪裬鷮苰髲髴駶꫸迺鳼鋾焀㸂䔄吆瀈攊渌䬎瀐朒琔䄖簘椚渜瘞丠䴢瘤匦䠨䘪崬̮㰰㤲ᔴ᜶ᤸᬺᴼἾ慀捂敄杆楈歊浌潎煐獒畔睖祘筚絜罞䅠䍢♤٦੨ͪ࡬㥮ᑰŲٴṶᙸᕺ⹼୾몆즈좊戀쎔쾠톤욦쒨\udbaa膬ꊮ뮰鎲閴鞶馸鮺鶼龾律ﯚ﷜￞쇠ꋢ韤蓦臨苪鯬諮闰ꇲ룴뇶郸韺飼룾琀樂愄㨆䤈䨊缌氎礐稒挔爖紘䤚倜夞䠠伢䀤怦尨䈪䤬∮㬰ጲᔴ᜶ᤸᬺᴼἾ慀捂敄杆楈歊浌潎煐獒畔睖祘ⱚ㕜㩞፠٢䕤⑦٨ժ୬ٮᙰٲݴᙶ൸ቺቼᅾ풀뒈쮊\ud88c搜颔鶖릘뮚붜뾞膠莢薤螦覨讪趬辮醰鎲閴鞶", a_), sqlConnect);
					num = (short)2118778882;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_312:
				num = (short)863830017;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("攐爒朔瀖簘漚㴜爞丠䜢䀤䬦नପ丬丮弰崲娴䌶ᤸ夺堼Ἶ⽀㙂⥄⭆楈⑊㽌潎═㉒❔ざ㱘⽚絜㙞በ䍢୤ࡦᵨ䭪౬佮ᡰᵲٴͶᡸᕺṼ᩾ꆀꞆ쪈쾠\udda4펦첨얪\ud9ac욮\udeb0\uddb2", a_));
				IL_382:
				num = (short)908460032;
				if (num != 0)
				{
				}
				num = (short)1706819584;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x000F839C File Offset: 0x000F659C
		public static int UpdateVersionStamps(global::System.Data.SqlClient.SqlConnection sqlConnect, global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationExtention target)
		{
			int a_ = 14;
			short num = (short)125829120;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Data.SqlClient.SqlCommand sqlCommand;
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
					goto IL_1CB;
				case 2:
					try
					{
						sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䰋嬍攏笑瀓", a_), global::System.Data.SqlDbType.UniqueIdentifier).Value = target.ConfigurationUuid;
						sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䰋堍甏怑朓缕眗琙伛樝䄟伡吣", a_), global::System.Data.SqlDbType.BigInt).Value = target.VersionStamp;
						sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䰋䴍焏焑簓猕丗缙減洝䤟䴡䨣甥尧䬩䄫席", a_), global::System.Data.SqlDbType.BigInt).Value = target.CacheVersionStamp;
						sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䰋䘍式我怓缕眗琙䨛笝刟儡䴣䤥䘧礩堫伭崯䈱", a_), global::System.Data.SqlDbType.BigInt).Value = target.HOptionVersionStamp;
						sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䰋崍椏簑眓刕礗渙紛䠝䔟倡圣伥䜧䐩缫娭儯弱䐳", a_), global::System.Data.SqlDbType.BigInt).Value = target.SyncDataVersionStamp;
						sqlCommand.Parameters.Add(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䰋䌍缏瘑紓瀕焗缙砛娝䄟嘡䄣", a_), global::System.Data.SqlDbType.DateTime2).Value = global::System.DateTime.UtcNow;
						return sqlCommand.ExecuteNonQuery();
					}
					finally
					{
						num = (short)1980825600;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_195;
								}
								continue;
							case 1:
								((global::System.IDisposable)sqlCommand).Dispose();
								num = (short)1285488642;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1C8;
							}
							IL_195:
							if (sqlCommand == null)
							{
								break;
							}
							num = (short)1168769025;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1C8:;
					}
					goto IL_1CB;
				}
				goto IL_3B;
				IL_41:
				num = (short)1133969409;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CB:
				sqlCommand = new global::System.Data.SqlClient.SqlCommand(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("ċЍ』㈑㐓㘕㠗㨙㰛㸝\u001fȡУإࠧ਩ఫอုሱᐳᘵ䴷䨹堻弽㐿❁䥃䱅桇橉汋湍灏牑瑓癕硗穙籛繝䁟䉡䑣䙥䡧䩩䱫乭偯剱味噵㭷ᕹቻ᡽ﺉﺏ힑ﶗ쾟첡ꦣ겥袧誩貫躭邯銱钳隵颷骹鲻麽ꏏ럑ꃓ\udbd5틗龎ﳛﻝ샟싡쓣웥죧쫩쳫컭탯틱퓳훵\ud8f7\udaf9\udcfb\udefd⃿∁␃★⠇尉椋簍挏笑笓砕䬗渙紛猝借ἡ搣瀥䴧堩弫䜭弯就朳䈵夷圹䰻ሽ䴿䡁摃晅桇橉汋湍灏牑瑓癕硗穙籛繝䁟䉡䑣䙥䡧䩩䱫乭偯剱㝳᝵᭷ቹ᥻⡽\udf8b揄ﾑꮕ\ud897\ud999ﶛﶝ좟잡쎥\udaa7\ud9a9얫솭\udeaf삳ힵ햷쪹邻뎽쪿龎ﳛﻝ샟싡쓣웥죧쫩쳫컭탯뫱믳蛵賷鏹鏻都囿朁瘃甅愇攉戋崍搏猑礓昕┗娙君儝借嘡䴣䤥䘧簩䤫尭䌯嬱嬳堵欷丹崻匽〿湁䥃䱅桇橉汋湍灏牑瑓癕硗穙籛繝䁟䉡䑣䙥䡧䩩䱫乭偯剱味噵⭷͹ቻᵽ쑿\ude87ﺋﶍ憐﶑望얕ﮙ鶟\udfa5욧즩쾭쒯펱펵쪷즹햻톽꺿釁냃Ʂꗇ뫉쏍\udacf龎ﳛﻝ샟싡쓣웥죧쫩쳫컭탯틱퓳훵\ud8f7\udaf9\udcfb\udefd⃿企欃戅愇氉攋欍琏嘑甓戕紗✙尛匝伟䘡䴣䀥䄧伩䠫樭儯䘱儳㬵㈷ᨹ᰻ḽ怿扁摃晅桇橉汋湍灏牑瑓癕硗穙籛繝䁟ᕡౣͥᩧཀྵ䱫⵭Ὧᱱታήίཹ๻ώ\udd87ﾉ궏튑솓ﺙ醛钝肟芡蒣蚥袧誩貫躭邯銱钳隵颷骹鲻麽", a_), sqlConnect);
				num = (short)1597510787;
				short num3 = num;
				num = (short)2092700803;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_41;
				default:
					num = (short)1612054529;
					if (num != 0)
					{
					}
					num = (short)1567162368;
					if (num != 0)
					{
					}
					num = (short)1538064386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3B:
				if (target != null)
				{
					goto IL_41;
				}
				break;
			}
			num = (short)702873600;
			short num4 = num;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("砋漍戏甑焓戕㠗眙猛稝䔟両Уإ䬧䬩䈫䀭弯䘱ᐳ吵崷ᨹ刻䬽ⰿ⹁摃⥅㩇橉㡋⽍≏㕑ㅓ≕硗㍙⽛繝๟ൡၣ䙥१䩩իmͯٱᕳᡵ᭷ό屻ᅽꊁ잃\udb9d\ud89f횡솣좥\udca7쎩쎫삭", a_));
		}
	}
}
