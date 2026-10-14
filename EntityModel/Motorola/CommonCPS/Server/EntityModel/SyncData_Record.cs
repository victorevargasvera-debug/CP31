using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000188 RID: 392
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class SyncData_Record
	{
		// Token: 0x06001519 RID: 5401 RVA: 0x000E04B0 File Offset: 0x000DE6B0
		public SyncData_Record()
		{
			this.IsFNERecSet = false;
			this.FieldsAndValue = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>();
			this._SyncDataReferChildUuids = new global::System.Collections.Generic.List<global::System.Guid>();
			this._SyncFieldsAndValue = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>>();
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x000E04EC File Offset: 0x000DE6EC
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x000E059C File Offset: 0x000DE79C
		[global::System.Runtime.Serialization.DataMember]
		public bool IsFNERecSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)260568036;
				short num2 = num;
				num = (short)801960932;
				switch (num2 == num)
				{
				}
				num = (short)317849600;
				if (num != 0)
				{
				}
				num = (short)496697345;
				if (num != 0)
				{
				}
				num = (short)1850146816;
				short num3 = num;
				return this.<IsFNERecSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1962737665;
				if (num != 0)
				{
				}
				num = (short)423690959;
				short num2 = num;
				num = (short)1051067087;
				switch (num2 == num)
				{
				}
				num = (short)935919616;
				if (num != 0)
				{
				}
				num = (short)1174601728;
				short num3 = num;
				this.<IsFNERecSet>k__BackingField = value;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x000E064C File Offset: 0x000DE84C
		// (set) Token: 0x0600151D RID: 5405 RVA: 0x000E0700 File Offset: 0x000DE900
		[global::System.Runtime.Serialization.DataMember]
		public string BLRecSetName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1722277477;
				short num2 = num;
				num = (short)371121765;
				switch (num2 == num)
				{
				}
				num = (short)1034420225;
				if (num != 0)
				{
				}
				num = (short)1893269504;
				if (num != 0)
				{
				}
				num = (short)413401088;
				short num3 = num;
				return this.<BLRecSetName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1071952654;
				short num2 = num;
				num = (short)1188410126;
				switch (num2 == num)
				{
				}
				num = (short)852623360;
				if (num != 0)
				{
				}
				num = (short)492503040;
				short num3 = num;
				num = (short)617218049;
				if (num != 0)
				{
				}
				this.<BLRecSetName>k__BackingField = value;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x000E07B0 File Offset: 0x000DE9B0
		// (set) Token: 0x0600151F RID: 5407 RVA: 0x000E085C File Offset: 0x000DEA5C
		[global::System.Runtime.Serialization.DataMember]
		public string BLRecordUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)127205377;
				if (num != 0)
				{
				}
				num = (short)877686069;
				short num2 = num;
				num = (short)1626434869;
				switch (num2 == num)
				{
				}
				num = (short)567672832;
				short num3 = num;
				num = (short)582483968;
				if (num != 0)
				{
				}
				return this.<BLRecordUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1481262486;
				short num2 = num;
				num = (short)1747994006;
				switch (num2 == num)
				{
				}
				num = (short)1233780737;
				if (num != 0)
				{
				}
				num = (short)628424704;
				short num3 = num;
				num = (short)1439301632;
				if (num != 0)
				{
				}
				this.<BLRecordUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x000E090C File Offset: 0x000DEB0C
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x000E09B8 File Offset: 0x000DEBB8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes TargetEntityType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1261289329;
				short num2 = num;
				num = (short)741588849;
				switch (num2 == num)
				{
				}
				num = (short)513605632;
				if (num != 0)
				{
				}
				num = (short)160301056;
				short num3 = num;
				num = (short)2019950593;
				if (num != 0)
				{
				}
				return this.<TargetEntityType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1893078768;
				short num2 = num;
				num = (short)2075006704;
				switch (num2 == num)
				{
				}
				num = (short)122814464;
				if (num != 0)
				{
				}
				num = (short)544735232;
				short num3 = num;
				num = (short)788594689;
				if (num != 0)
				{
				}
				this.<TargetEntityType>k__BackingField = value;
			}
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x000E0A6C File Offset: 0x000DEC6C
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>> Get_SyncFieldsAndValue()
		{
			short num = (short)1409417217;
			if (num != 0)
			{
			}
			num = (short)304356730;
			short num2 = num;
			num = (short)584588666;
			switch (num2 == num)
			{
			}
			num = (short)694616064;
			short num3 = num;
			num = (short)677314560;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>>(this._SyncFieldsAndValue);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x000E0B20 File Offset: 0x000DED20
		public void AddFieldItem(global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes syncDataType, global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					for (;;)
					{
						num2 = (short)1348476752;
						short num3 = num2;
						num2 = (short)1001398096;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_99;
						}
					}
					IL_99:
					num2 = (short)340328448;
					short num4 = num2;
					num2 = (short)1850474496;
					if (num2 != 0)
					{
					}
					this._SyncFieldsAndValue[syncDataType] = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>();
					num2 = (short)2025390081;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_FF;
				case 2:
					if (!this._SyncFieldsAndValue.ContainsKey(syncDataType))
					{
						num2 = (short)730857472;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_129;
				}
				goto IL_1C;
			}
			IL_FF:
			num2 = (short)1623392257;
			if (num2 != 0)
			{
			}
			IL_129:
			this._SyncFieldsAndValue[syncDataType].Add(syncData_FieldItem);
			this.a();
			return;
			IL_1C:
			this.FieldsAndValue.Add(syncData_FieldItem);
			num2 = (short)2092695554;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x000E0C70 File Offset: 0x000DEE70
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x000E0D24 File Offset: 0x000DEF24
		public bool IsEntryForSyncData
		{
			get
			{
				short num = (short)404094977;
				if (num != 0)
				{
				}
				num = (short)239252123;
				short num2 = num;
				num = (short)250262171;
				switch (num2 == num)
				{
				}
				num = (short)1314979840;
				short num3 = num;
				num = (short)745144320;
				if (num != 0)
				{
				}
				return this._IsEntryForSyncData;
			}
			set
			{
				short num = (short)1007621864;
				short num2 = num;
				num = (short)7739112;
				switch (num2 == num)
				{
				}
				num = (short)112066560;
				if (num != 0)
				{
				}
				num = (short)727580672;
				short num3 = num;
				num = (short)2053242881;
				if (num != 0)
				{
				}
				this._IsEntryForSyncData = value;
				this.a();
			}
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000E0DD8 File Offset: 0x000DEFD8
		public global::System.Collections.Generic.List<global::System.Guid> Get_SyncDataReferChildUuids()
		{
			short num = (short)1262591115;
			short num2 = num;
			num = (short)1606130827;
			switch (num2 == num)
			{
			}
			num = (short)474087424;
			if (num != 0)
			{
			}
			num = (short)441450496;
			short num3 = num;
			num = (short)825425921;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<global::System.Guid>(this._SyncDataReferChildUuids);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000E0E8C File Offset: 0x000DF08C
		public void Add_SyncDataReferChildUuids(global::System.Guid guidOfChild)
		{
			short num = (short)1991400907;
			short num2 = num;
			num = (short)1040145867;
			switch (num2 == num)
			{
			}
			num = (short)1875771393;
			if (num != 0)
			{
			}
			num = (short)971177984;
			short num3 = num;
			num = (short)221118464;
			if (num != 0)
			{
			}
			this._SyncDataReferChildUuids.Add(guidOfChild);
			this.a();
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x000E0F48 File Offset: 0x000DF148
		private void a()
		{
			int a_ = 7;
			short num = (short)1240006668;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)22347785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)549191683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this._SyncFieldsAndValue.Keys.Count > 1)
					{
						num = (short)1977483269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					if (this._SyncDataReferChildUuids.Count != 0)
					{
						num = (short)628621316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
				{
					num = (short)1946943488;
					short num3 = num;
					num = (short)1125122059;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_23A;
				case 6:
					goto IL_2CD;
				case 7:
					if (this._SyncDataReferChildUuids.Count == 0)
					{
						num = (short)1111949320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19F;
				case 8:
					num = (short)281280514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					if (this._SyncFieldsAndValue.Keys.Count <= 1)
					{
						return;
					}
					num = (short)645363672;
					short num4 = num;
					num = (short)352286680;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2CD;
					default:
						num = (short)552730624;
						if (num != 0)
						{
						}
						num = (short)950796294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					num = (short)636616711;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (this._SyncDataReferChildUuids.Count >= 1)
					{
						num = (short)533856256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C9;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 13:
					num = (short)437518337;
					if (num != 0)
					{
					}
					if (!this._IsEntryForSyncData)
					{
						num = (short)1128333322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19F;
				}
				IL_66:
				if (this._IsEntryForSyncData)
				{
					num = (short)334036993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C9:
				num = (short)164823053;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2CD:
				goto IL_C9;
			}
			IL_19F:
			throw new global::System.NotSupportedException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䨄椆攈爊ⴌ渎ㄐ瘒笔挖欘戚㴜䰞堠䴢䘤甦䰨䠪䈬崮唰ጲ嘴嘶圸ᬺ堼嘾㕀⭂⁄㕆摈⑊㽌潎㥐㉒⍔㹖㝘㱚絜㱞ॠ੢।ͦ䕨䭪ɬᵮ兰᭲ᑴŶၸᕺ᩼彾ﮊ놐삒練滛쾚쒠趢", a_));
			IL_23A:
			goto IL_19F;
		}

		// Token: 0x040009EC RID: 2540
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> FieldsAndValue;

		// Token: 0x040009ED RID: 2541
		private global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>> _SyncFieldsAndValue;

		// Token: 0x040009EE RID: 2542
		[global::System.Runtime.Serialization.DataMember]
		private bool _IsEntryForSyncData;

		// Token: 0x040009EF RID: 2543
		private global::System.Collections.Generic.List<global::System.Guid> _SyncDataReferChildUuids;
	}
}
