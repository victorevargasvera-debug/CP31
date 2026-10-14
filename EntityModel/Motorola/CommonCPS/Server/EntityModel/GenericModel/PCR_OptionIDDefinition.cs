using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel
{
	// Token: 0x020001C5 RID: 453
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Xml.Serialization.XmlType("PO")]
	[global::System.Serializable]
	public class PCR_OptionIDDefinition : global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition
	{
		// Token: 0x06001738 RID: 5944 RVA: 0x000FB3F8 File Offset: 0x000F95F8
		public PCR_OptionIDDefinition()
		{
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x000FB40C File Offset: 0x000F960C
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x000FB4B8 File Offset: 0x000F96B8
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("v")]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode OptionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2026432227;
				short num2 = num;
				num = (short)276883171;
				switch (num2 == num)
				{
				}
				num = (short)1500184576;
				short num3 = num;
				num = (short)1027407872;
				if (num != 0)
				{
				}
				num = (short)401866753;
				if (num != 0)
				{
				}
				return this.<OptionID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1653306392;
				short num2 = num;
				num = (short)865498136;
				switch (num2 == num)
				{
				}
				num = (short)1510473728;
				short num3 = num;
				num = (short)2078081025;
				if (num != 0)
				{
				}
				num = (short)587726848;
				if (num != 0)
				{
				}
				this.<OptionID>k__BackingField = value;
			}
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x000FB56C File Offset: 0x000F976C
		public PCR_OptionIDDefinition(global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode OptionID, string OptionNotice = null)
		{
			this.OptionID = OptionID;
			this.OptionNotice = OptionNotice;
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x000FB590 File Offset: 0x000F9790
		public PCR_OptionIDDefinition(string String_OptionID, string OptionNotice = null)
		{
			int a_ = 3;
			base..ctor();
			global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode optionID;
			if (!global::System.Enum.TryParse<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>(String_OptionID, out optionID))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䈀戂欄椆昈缊ⴌ缎瀐愒昔爖㤘帚猜樞䰠̢帤ᜦ吨ପ䬬崮帰帲ᔴ搶䴸䤺吼儾♀᱂੄㝆㵈≊≌ⅎᡐᝒ畔ⱖ桘♚", a_), global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儀䀂圄堆䨈䴊希䤎琐爒愔或欘縚帜瀞䔠䘢", a_), String_OptionID));
			}
			this.OptionID = optionID;
			this.OptionNotice = OptionNotice;
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x000FB5F4 File Offset: 0x000F97F4
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x000FB6A4 File Offset: 0x000F98A4
		[global::System.Xml.Serialization.XmlAttribute("c")]
		[global::System.Runtime.Serialization.DataMember]
		public int OptionRegisterCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1544889776;
				short num2 = num;
				num = (short)187835824;
				switch (num2 == num)
				{
				}
				num = (short)2091319296;
				short num3 = num;
				num = (short)1730609153;
				if (num != 0)
				{
				}
				num = (short)1671954432;
				if (num != 0)
				{
				}
				return this.<OptionRegisterCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1017819023;
				short num2 = num;
				num = (short)1758506895;
				switch (num2 == num)
				{
				}
				num = (short)389545984;
				short num3 = num;
				num = (short)439746561;
				if (num != 0)
				{
				}
				num = (short)166920192;
				if (num != 0)
				{
				}
				this.<OptionRegisterCount>k__BackingField = value;
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x000FB758 File Offset: 0x000F9958
		public bool ShouldSerializeOptionRegisterCount()
		{
			short num = (short)420627976;
			short num2 = num;
			num = (short)606750216;
			switch (num2 == num)
			{
			}
			num = (short)1809317888;
			short num3 = num;
			num = (short)495845377;
			if (num != 0)
			{
			}
			num = (short)1669267456;
			if (num != 0)
			{
			}
			return this.OptionRegisterCount != 0;
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x000FB80C File Offset: 0x000F9A0C
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x000FB8C0 File Offset: 0x000F9AC0
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("n")]
		public string OptionNotice
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1430487712;
				short num2 = num;
				num = (short)1421509280;
				switch (num2 == num)
				{
				}
				num = (short)2109145088;
				short num3 = num;
				num = (short)466157569;
				if (num != 0)
				{
				}
				num = (short)25100288;
				if (num != 0)
				{
				}
				return this.<OptionNotice>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)194838529;
				if (num != 0)
				{
				}
				num = (short)1581282841;
				short num2 = num;
				num = (short)1035695641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1974927360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1610022912;
				if (num != 0)
				{
				}
				this.<OptionNotice>k__BackingField = value;
			}
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x000FB970 File Offset: 0x000F9B70
		public bool ShouldSerializeOptionNotice()
		{
			short num = (short)1310575782;
			short num2 = num;
			num = (short)1656671398;
			switch (num2 == num)
			{
			}
			num = (short)938606592;
			short num3 = num;
			num = (short)1012400129;
			if (num != 0)
			{
			}
			num = (short)630325248;
			if (num != 0)
			{
			}
			return !string.IsNullOrWhiteSpace(this.OptionNotice);
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x000FBA2C File Offset: 0x000F9C2C
		public override string ResourceID
		{
			get
			{
				short num = (short)243374496;
				short num2 = num;
				num = (short)955619744;
				switch (num2 == num)
				{
				}
				num = (short)564723712;
				short num3 = num;
				num = (short)641662977;
				if (num != 0)
				{
				}
				num = (short)1441136640;
				if (num != 0)
				{
				}
				return this.OptionID.ToString();
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x000FBAEC File Offset: 0x000F9CEC
		public override int OptionInt
		{
			get
			{
				short num = (short)650427080;
				short num2 = num;
				num = (short)239581896;
				switch (num2 == num)
				{
				}
				num = (short)2108030976;
				short num3 = num;
				num = (short)251527169;
				if (num != 0)
				{
				}
				num = (short)957546496;
				if (num != 0)
				{
				}
				return (int)this.OptionID;
			}
		}
	}
}
