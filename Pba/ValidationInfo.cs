using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000037 RID: 55
	[global::System.Serializable]
	public class ValidationInfo
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0001C4FC File Offset: 0x0001A6FC
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0001C5AC File Offset: 0x0001A7AC
		[global::System.Xml.Serialization.XmlAttribute("ID")]
		public string ID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)501731960;
				short num2 = num;
				num = (short)504746616;
				switch (num2 == num)
				{
				}
				num = (short)1475215361;
				if (num != 0)
				{
				}
				num = (short)1405485056;
				if (num != 0)
				{
				}
				num = (short)918159360;
				short num3 = num;
				return this.<ID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1370148206;
				short num2 = num;
				num = (short)1512164718;
				switch (num2 == num)
				{
				}
				num = (short)1736900609;
				if (num != 0)
				{
				}
				num = (short)745472000;
				if (num != 0)
				{
				}
				num = (short)1257504768;
				short num3 = num;
				this.<ID>k__BackingField = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0001C65C File Offset: 0x0001A85C
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0001C70C File Offset: 0x0001A90C
		[global::System.Xml.Serialization.XmlAttribute("Value")]
		public string Value
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2060533352;
				short num2 = num;
				num = (short)1136803432;
				switch (num2 == num)
				{
				}
				num = (short)1418264577;
				if (num != 0)
				{
				}
				num = (short)948240384;
				if (num != 0)
				{
				}
				num = (short)1772552192;
				short num3 = num;
				return this.<Value>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1590808284;
				short num2 = num;
				num = (short)663277276;
				switch (num2 == num)
				{
				}
				num = (short)1009975297;
				if (num != 0)
				{
				}
				num = (short)2027487232;
				if (num != 0)
				{
				}
				num = (short)2054881280;
				short num3 = num;
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0001C7BC File Offset: 0x0001A9BC
		public ValidationInfo()
		{
			this.ID = string.Empty;
			this.Value = string.Empty;
			this.ValidationMethod = global::Motorola.Common.Communication.Pba.ValidationMethod.Equal;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001C7EC File Offset: 0x0001A9EC
		public ValidationInfo(string id, string value)
		{
			this.ID = id;
			this.Value = value;
			this.ValidationMethod = global::Motorola.Common.Communication.Pba.ValidationMethod.Equal;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001C814 File Offset: 0x0001AA14
		public ValidationInfo(string id, string value, global::Motorola.Common.Communication.Pba.ValidationMethod validationMethod)
		{
			this.ID = id;
			this.Value = value;
			this.ValidationMethod = validationMethod;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0001C83C File Offset: 0x0001AA3C
		public ValidationInfo(string id, string value, global::Motorola.Common.Communication.Pba.ValidationMethod validationMethod, global::Motorola.Common.CustomException.CommonErrorCode errorToThrow)
		{
			this.ID = id;
			this.Value = value;
			this.ValidationMethod = validationMethod;
			this.ErrorToThrow = errorToThrow;
		}

		// Token: 0x04000144 RID: 324
		[global::System.Xml.Serialization.XmlAttribute("ValidationMethod")]
		[global::System.Runtime.Serialization.OptionalField]
		public global::Motorola.Common.Communication.Pba.ValidationMethod ValidationMethod;

		// Token: 0x04000145 RID: 325
		[global::System.Xml.Serialization.XmlAttribute("ErrorToThrow")]
		[global::System.Runtime.Serialization.OptionalField]
		public global::Motorola.Common.CustomException.CommonErrorCode ErrorToThrow;
	}
}
