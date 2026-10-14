using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels
{
	// Token: 0x020001EB RID: 491
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.List<string>>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBShortcutDesc>>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelectionList>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificate>>))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.LinkType))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.Dictionary<global::System.Guid, string>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ApkApplicationDesc>>))]
	[global::System.Serializable]
	public class SyncDataSourceOfConfiguration
	{
		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x0010643C File Offset: 0x0010463C
		// (set) Token: 0x06001842 RID: 6210 RVA: 0x001064EC File Offset: 0x001046EC
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes, object> BLLSyncData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)601443436;
				short num2 = num;
				num = (short)1836993644;
				switch (num2 == num)
				{
				}
				num = (short)1293549568;
				short num3 = num;
				num = (short)593428481;
				if (num != 0)
				{
				}
				num = (short)1167327232;
				if (num != 0)
				{
				}
				return this.<BLLSyncData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)633728627;
				short num2 = num;
				num = (short)2040131187;
				switch (num2 == num)
				{
				}
				num = (short)301596672;
				short num3 = num;
				num = (short)310771712;
				if (num != 0)
				{
				}
				num = (short)1901199361;
				if (num != 0)
				{
				}
				this.<BLLSyncData>k__BackingField = value;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x0010659C File Offset: 0x0010479C
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x0010664C File Offset: 0x0010484C
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<int, int> OptionList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)720044033;
				if (num != 0)
				{
				}
				num = (short)1624272817;
				short num2 = num;
				num = (short)1222406065;
				switch (num2 == num)
				{
				default:
				{
					num = (short)308215808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)237502464;
				if (num != 0)
				{
				}
				return this.<OptionList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1449504896;
				short num2 = num;
				num = (short)1397338240;
				switch (num2 == num)
				{
				}
				num = (short)2098462720;
				short num3 = num;
				num = (short)1547632640;
				if (num != 0)
				{
				}
				num = (short)1746075649;
				if (num != 0)
				{
				}
				this.<OptionList>k__BackingField = value;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x001066FC File Offset: 0x001048FC
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x001067A8 File Offset: 0x001049A8
		[global::System.Runtime.Serialization.DataMember]
		public long SyncDataVersionStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1965421991;
				short num2 = num;
				num = (short)814478759;
				switch (num2 == num)
				{
				}
				num = (short)133890048;
				short num3 = num;
				num = (short)1690238977;
				if (num != 0)
				{
				}
				num = (short)812449792;
				if (num != 0)
				{
				}
				return this.<SyncDataVersionStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)583695030;
				short num2 = num;
				num = (short)1606384310;
				switch (num2 == num)
				{
				}
				num = (short)2056192000;
				short num3 = num;
				num = (short)889520128;
				if (num != 0)
				{
				}
				num = (short)161415169;
				if (num != 0)
				{
				}
				this.<SyncDataVersionStamp>k__BackingField = value;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x0010685C File Offset: 0x00104A5C
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x0010690C File Offset: 0x00104B0C
		[global::System.Runtime.Serialization.DataMember]
		public long HOptionVersionStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1565822011;
				short num2 = num;
				num = (short)1712688187;
				switch (num2 == num)
				{
				}
				num = (short)459210752;
				short num3 = num;
				num = (short)1116995585;
				if (num != 0)
				{
				}
				num = (short)1136263168;
				if (num != 0)
				{
				}
				return this.<HOptionVersionStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)666368129;
				short num2 = num;
				num = (short)698808449;
				switch (num2 == num)
				{
				}
				num = (short)1523056640;
				short num3 = num;
				num = (short)1750204416;
				if (num != 0)
				{
				}
				num = (short)781647873;
				if (num != 0)
				{
				}
				this.<HOptionVersionStamp>k__BackingField = value;
			}
		}
	}
}
