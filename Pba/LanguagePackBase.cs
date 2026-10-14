using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000005 RID: 5
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo))]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.AstroFilePackInfo))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.AstroFilePackInfo))]
	[global::System.Serializable]
	public class LanguagePackBase
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002D88 File Offset: 0x00000F88
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002E38 File Offset: 0x00001038
		[global::System.Runtime.Serialization.DataMember]
		public string sourceFilePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)334757888;
				short num2 = num;
				num = (short)631350186;
				short num3 = num;
				num = (short)1054057386;
				switch (num3 == num)
				{
				}
				num = (short)538705920;
				if (num != 0)
				{
				}
				num = (short)736559105;
				if (num != 0)
				{
				}
				return this.<sourceFilePath>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1114636288;
				short num2 = num;
				num = (short)697020403;
				short num3 = num;
				num = (short)1474539507;
				switch (num3 == num)
				{
				}
				num = (short)140705793;
				if (num != 0)
				{
				}
				num = (short)1667170304;
				if (num != 0)
				{
				}
				this.<sourceFilePath>k__BackingField = value;
			}
		}
	}
}
