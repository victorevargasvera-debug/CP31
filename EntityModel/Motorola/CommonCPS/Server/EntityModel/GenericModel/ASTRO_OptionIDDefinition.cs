using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel
{
	// Token: 0x020001C4 RID: 452
	[global::System.Xml.Serialization.XmlType("AO")]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ASTRO_OptionIDDefinition : global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition
	{
		// Token: 0x06001731 RID: 5937 RVA: 0x000FB09C File Offset: 0x000F929C
		public ASTRO_OptionIDDefinition()
		{
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x000FB0B0 File Offset: 0x000F92B0
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x000FB160 File Offset: 0x000F9360
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("v")]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ASTRO_OptionIDs OptionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1916198033;
				short num2 = num;
				num = (short)1434180753;
				switch (num2 == num)
				{
				}
				num = (short)829227008;
				short num3 = num;
				num = (short)890765312;
				if (num != 0)
				{
				}
				num = (short)1123811329;
				if (num != 0)
				{
				}
				return this.<OptionID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1665548363;
				short num2 = num;
				num = (short)645939275;
				switch (num2 == num)
				{
				}
				num = (short)36962304;
				short num3 = num;
				num = (short)1646985217;
				if (num != 0)
				{
				}
				num = (short)1464008704;
				if (num != 0)
				{
				}
				this.<OptionID>k__BackingField = value;
			}
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x000FB210 File Offset: 0x000F9410
		public ASTRO_OptionIDDefinition(global::Motorola.CommonCPS.Server.CommonDBConstants.ASTRO_OptionIDs OptionID)
		{
			this.OptionID = OptionID;
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x000FB22C File Offset: 0x000F942C
		public ASTRO_OptionIDDefinition(string String_OptionID)
		{
			int a_ = 18;
			base..ctor();
			global::Motorola.CommonCPS.Server.CommonDBConstants.ASTRO_OptionIDs optionID;
			if (!global::System.Enum.TryParse<global::Motorola.CommonCPS.Server.CommonDBConstants.ASTRO_OptionIDs>(String_OptionID, out optionID))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("匏猑稓砕眗渙㰛渝䄟倡圣䌥ࠧ漩䈫嬭崯ሱ伳ص䔷ᨹ娻䰽⼿⽁摃ᕅ㱇㡉╋⁍㝏൑᭓♕ⱗ㍙㍛そ⥟♡䑣ᵥ奧ᝩ", a_), global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儏䄑䀓䐕圗䔙匛渝吟䬡䬣䠥愧温弫", a_), String_OptionID));
			}
			this.OptionID = optionID;
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x000FB288 File Offset: 0x000F9488
		public override string ResourceID
		{
			get
			{
				short num = (short)1914486387;
				short num2 = num;
				num = (short)442416755;
				switch (num2 == num)
				{
				}
				num = (short)1503657984;
				short num3 = num;
				num = (short)2076311553;
				if (num != 0)
				{
				}
				num = (short)1265565696;
				if (num != 0)
				{
				}
				return this.OptionID.ToString();
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x000FB348 File Offset: 0x000F9548
		public override int OptionInt
		{
			get
			{
				short num = (short)1916126831;
				short num2 = num;
				num = (short)208586351;
				switch (num2 == num)
				{
				}
				num = (short)521797632;
				short num3 = num;
				num = (short)1641086977;
				if (num != 0)
				{
				}
				num = (short)1976762368;
				if (num != 0)
				{
				}
				return (int)this.OptionID;
			}
		}
	}
}
