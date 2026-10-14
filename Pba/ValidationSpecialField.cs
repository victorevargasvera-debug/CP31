using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200003A RID: 58
	[global::System.Serializable]
	public class ValidationSpecialField
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0001C880 File Offset: 0x0001AA80
		// (set) Token: 0x060001CD RID: 461 RVA: 0x0001C930 File Offset: 0x0001AB30
		[global::System.Xml.Serialization.XmlAttribute("Value")]
		public string Value
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1743240708;
				short num2 = num;
				num = (short)507624964;
				switch (num2 == num)
				{
				}
				num = (short)1962344449;
				if (num != 0)
				{
				}
				num = (short)1225850880;
				if (num != 0)
				{
				}
				num = (short)895877120;
				short num3 = num;
				return this.<Value>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)104412136;
				short num2 = num;
				num = (short)90846184;
				switch (num2 == num)
				{
				}
				num = (short)1132986368;
				if (num != 0)
				{
				}
				num = (short)80412673;
				if (num != 0)
				{
				}
				num = (short)102105088;
				short num3 = num;
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0001CA8C File Offset: 0x0001AC8C
		[global::System.Xml.Serialization.XmlAttribute("ValidationMethod")]
		public global::Motorola.Common.Communication.Pba.SpecialValidationMethod SpecialValidationMethod
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)569436037;
				short num2 = num;
				num = (short)1613621125;
				switch (num2 == num)
				{
				}
				num = (short)1008402433;
				if (num != 0)
				{
				}
				num = (short)1772814336;
				if (num != 0)
				{
				}
				num = (short)491847680;
				short num3 = num;
				return this.<SpecialValidationMethod>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)612641025;
				short num2 = num;
				num = (short)945367297;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2013003776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1519517696;
				if (num != 0)
				{
				}
				num = (short)1879965697;
				if (num != 0)
				{
				}
				this.<SpecialValidationMethod>k__BackingField = value;
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001CB38 File Offset: 0x0001AD38
		public ValidationSpecialField()
		{
			this.Value = null;
			this.SpecialValidationMethod = global::Motorola.Common.Communication.Pba.SpecialValidationMethod.PCRCodeplugPassword;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0001CB5C File Offset: 0x0001AD5C
		public ValidationSpecialField(string value, global::Motorola.Common.Communication.Pba.SpecialValidationMethod specialValidationMethod)
		{
			this.Value = value;
			this.SpecialValidationMethod = specialValidationMethod;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0001CB80 File Offset: 0x0001AD80
		public static global::Motorola.Common.Communication.Pba.ValidationField RetrieveValidationInfoFrinString(string value)
		{
			short num = (short)1978466304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::System.Xml.Serialization.XmlSerializer xmlSerializer;
				global::Motorola.Common.Communication.Pba.ValidationField validationField;
				global::Motorola.Common.Communication.Pba.ValidationField result;
				for (;;)
				{
					IL_28:
					num = (short)1257570304;
					short num3 = num;
					global::System.IO.TextReader textReader;
					switch (num2)
					{
					case 0:
						if (string.IsNullOrEmpty(value))
						{
							num = (short)2013986817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_182;
					case 1:
						goto IL_FC;
					case 2:
						try
						{
							validationField = (xmlSerializer.Deserialize(textReader) as global::Motorola.Common.Communication.Pba.ValidationField);
							result = validationField;
							goto IL_1A9;
						}
						finally
						{
							num = (short)1514799104;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_148;
									}
									continue;
								case 1:
									((global::System.IDisposable)textReader).Dispose();
									num = (short)311820290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_17F;
								}
								IL_148:
								if (textReader == null)
								{
									break;
								}
								num = (short)6029313;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_17F:;
						}
						goto IL_182;
					}
					goto IL_63;
					IL_182:
					textReader = new global::System.IO.StringReader(value);
					num = (short)163643394;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FC:
				return validationField;
				IL_1A9:
				num = (short)1584857089;
				if (num != 0)
				{
				}
				return result;
				IL_63:
				validationField = null;
				xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.ValidationField));
				num = (short)2039430107;
				short num4 = num;
				num = (short)1706638299;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return validationField;
				default:
					num = (short)874840064;
					if (num != 0)
					{
					}
					num = (short)985006080;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				break;
			}
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0001CD70 File Offset: 0x0001AF70
		public static string SerializeValidationInfoToString(global::Motorola.Common.Communication.Pba.ValidationField info)
		{
			short num = (short)1528242008;
			short num2 = num;
			num = (short)618667864;
			global::System.Text.StringBuilder stringBuilder;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1798701056;
				short num3 = num;
				num = (short)561905664;
				if (num != 0)
				{
				}
				num = (short)1083965441;
				if (num != 0)
				{
				}
				global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.ValidationField));
				stringBuilder = new global::System.Text.StringBuilder();
				global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(stringBuilder);
				try
				{
					xmlSerializer.Serialize(xmlWriter, info);
				}
				finally
				{
					num = (short)1466892288;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_F4;
							}
							continue;
						case 1:
							((global::System.IDisposable)xmlWriter).Dispose();
							num = (short)705626114;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_12A;
						}
						IL_F4:
						if (xmlWriter == null)
						{
							break;
						}
						num = (short)67371009;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_12A:;
				}
				break;
			}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000151 RID: 337
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Xml.Serialization.XmlAttribute("ErrorToThrow")]
		public global::Motorola.Common.CustomException.CommonErrorCode ErrorToThrow;
	}
}
