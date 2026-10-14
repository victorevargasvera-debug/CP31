using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000103 RID: 259
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Field))]
	[global::System.Serializable]
	public class DBRefField : global::Motorola.CommonCPS.Server.EntityModel.Field
	{
		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x000A6718 File Offset: 0x000A4918
		// (set) Token: 0x06000F8A RID: 3978 RVA: 0x000A67CC File Offset: 0x000A49CC
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("ReferSetName")]
		public string ReferSetName
		{
			get
			{
				short num = (short)1935882991;
				short num2 = num;
				num = (short)125582063;
				switch (num2 == num)
				{
				}
				num = (short)849412097;
				if (num != 0)
				{
				}
				num = (short)483000320;
				if (num != 0)
				{
				}
				num = (short)1311375360;
				short num3 = num;
				return this._ReferSetName;
			}
			set
			{
				short num = (short)821035009;
				if (num != 0)
				{
				}
				num = (short)1560296374;
				short num2 = num;
				num = (short)587545526;
				switch (num2 == num)
				{
				}
				num = (short)1658388480;
				if (num != 0)
				{
				}
				num = (short)396623872;
				short num3 = num;
				this._ReferSetName = ((value == null) ? null : string.Intern(value));
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x000A688C File Offset: 0x000A4A8C
		// (set) Token: 0x06000F8C RID: 3980 RVA: 0x000A693C File Offset: 0x000A4B3C
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("IsGlobalRefer")]
		public bool IsGlobalRefer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1752897213;
				short num2 = num;
				num = (short)1476925117;
				switch (num2 == num)
				{
				}
				num = (short)2125856769;
				if (num != 0)
				{
				}
				num = (short)1261305856;
				if (num != 0)
				{
				}
				num = (short)913702912;
				short num3 = num;
				return this.<IsGlobalRefer>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1263534081;
				if (num != 0)
				{
				}
				num = (short)613687631;
				short num2 = num;
				num = (short)1805853007;
				switch (num2 == num)
				{
				}
				num = (short)397017088;
				if (num != 0)
				{
				}
				num = (short)1181745152;
				short num3 = num;
				this.<IsGlobalRefer>k__BackingField = value;
			}
		}

		// Token: 0x04000745 RID: 1861
		private string _ReferSetName;
	}
}
