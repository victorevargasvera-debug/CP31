using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001B5 RID: 437
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRHOption))]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRHOption))]
	[global::System.Serializable]
	public class HOption
	{
		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x000F3AB4 File Offset: 0x000F1CB4
		// (set) Token: 0x060016A9 RID: 5801 RVA: 0x000F3B64 File Offset: 0x000F1D64
		[global::System.Xml.Serialization.XmlAttribute("tg")]
		[global::System.Runtime.Serialization.DataMember]
		public string OptionTag
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2012741632;
				short num2 = num;
				num = (short)867458945;
				short num3 = num;
				num = (short)985423745;
				switch (num3 == num)
				{
				}
				num = (short)1681522689;
				if (num != 0)
				{
				}
				num = (short)898826240;
				if (num != 0)
				{
				}
				return this.<OptionTag>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1102446592;
				short num2 = num;
				num = (short)917465250;
				short num3 = num;
				num = (short)1747806370;
				switch (num3 == num)
				{
				}
				num = (short)490930177;
				if (num != 0)
				{
				}
				num = (short)1023148032;
				if (num != 0)
				{
				}
				this.<OptionTag>k__BackingField = value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x000F3C14 File Offset: 0x000F1E14
		// (set) Token: 0x060016AB RID: 5803 RVA: 0x000F3CC0 File Offset: 0x000F1EC0
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("id")]
		public string OptionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1643511808;
				short num2 = num;
				num = (short)217869547;
				short num3 = num;
				num = (short)460614891;
				switch (num3 == num)
				{
				}
				num = (short)91750401;
				if (num != 0)
				{
				}
				num = (short)1482489856;
				if (num != 0)
				{
				}
				return this.<OptionID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1889665024;
				short num2 = num;
				num = (short)556749490;
				short num3 = num;
				num = (short)131027634;
				switch (num3 == num)
				{
				}
				num = (short)488898561;
				if (num != 0)
				{
				}
				num = (short)222887936;
				if (num != 0)
				{
				}
				this.<OptionID>k__BackingField = value;
			}
		}
	}
}
