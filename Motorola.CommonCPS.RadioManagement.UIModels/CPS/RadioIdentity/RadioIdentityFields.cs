using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity
{
	// Token: 0x020000FF RID: 255
	public class RadioIdentityFields : global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.IRadioIdentityFields
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x000BCFA4 File Offset: 0x000BB1A4
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> Fields
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1574371328;
				short num2 = num;
				num = (short)1945924957;
				short num3 = num;
				num = (short)374437213;
				switch (num3 == num)
				{
				}
				num = (short)687210497;
				if (num != 0)
				{
				}
				num = (short)1274675200;
				if (num != 0)
				{
				}
				return this.k;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x000BD054 File Offset: 0x000BB254
		public global::System.Collections.Generic.List<string> PbaFields
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1887240192;
				short num2 = num;
				num = (short)2131449125;
				short num3 = num;
				num = (short)128144677;
				switch (num3 == num)
				{
				}
				num = (short)587988993;
				if (num != 0)
				{
				}
				num = (short)941228032;
				if (num != 0)
				{
				}
				return this.l;
			}
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x000BD104 File Offset: 0x000BB304
		public global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase GetFieldBase(string pbaFieldId)
		{
			int a_ = 5;
			short num = (short)1611202560;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase result;
			for (;;)
			{
				num = (short)1149829120;
				short num3 = num;
				num = (short)1611000099;
				short num4 = num;
				num = (short)1795942691;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1890123776;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_1E;
					case 1:
						num = (short)1308033026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						string key;
						if (this.Fields.TryGetValue(key, out result))
						{
							num = (short)1002242051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_151;
					}
					case 3:
						goto IL_125;
					}
					goto IL_B4;
				}
				IL_1E:
				switch (0)
				{
				case 0:
				{
					IL_B4:
					string key;
					if (!this.i.TryGetValue(pbaFieldId, out key))
					{
						goto IL_151;
					}
					num = (short)1472987137;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_125:
			num = (short)519503873;
			if (num != 0)
			{
			}
			return result;
			IL_151:
			throw new global::Motorola.Common.CustomException.Cps2Exception(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᔿⱁ╃⑅⑇⽉汋㩍㽏牑㉓㽕㙗㹙籛ᵝたㅡ䑣eŧཀྵk੭偯ᵱታ噵", a_) + pbaFieldId, null);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x000BD280 File Offset: 0x000BB480
		public bool GetVisibilityByFeature(global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType feature)
		{
			short num = (short)1000603648;
			short num2 = num;
			num = (short)1754923009;
			if (num != 0)
			{
			}
			num = (short)453760058;
			short num3 = num;
			num = (short)541840442;
			switch (num3 == num)
			{
			}
			num = (short)1688928256;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFields.a(feature).Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>(this.a)).All(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase field)
			{
				short num4 = (short)663948069;
				short num5 = num4;
				num4 = (short)706546469;
				switch ((num5 == num4) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num4 = (short)969539584;
					short num6 = num4;
					num4 = (short)1102315520;
					if (num4 != 0)
					{
					}
					num4 = (short)1978269697;
					if (num4 != 0)
					{
					}
					if (field == null)
					{
						return false;
					}
					break;
				}
				}
				return field.IsVisible;
			});
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000BD368 File Offset: 0x000BB568
		public void CombineRadioIpField(global::System.Collections.Generic.IDictionary<string, string> fieldValues)
		{
			int a_ = 6;
			short num = (short)853147654;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1408696325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_2FF;
				case 2:
					if (fieldValues.ContainsKey(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ汞", a_)))
					{
						num = (short)2089156612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FF;
				case 3:
					num = (short)37289986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					string value = string.Join(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("潀", a_), new string[]
					{
						fieldValues[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ潞", a_)],
						fieldValues[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ湞", a_)],
						fieldValues[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ浞", a_)],
						fieldValues[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ汞", a_)]
					});
					fieldValues.Remove(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ潞", a_));
					fieldValues.Remove(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ湞", a_));
					fieldValues.Remove(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ浞", a_));
					fieldValues.Remove(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ汞", a_));
					fieldValues.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ", a_), value);
					num = (short)1653211137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					if (fieldValues.ContainsKey(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ潞", a_)))
					{
						num = (short)684064775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FF;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 7:
					num = (short)1554513930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (fieldValues.ContainsKey(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ浞", a_)))
					{
						num = (short)631439363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FF;
				case 9:
					num = (short)604176392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (fieldValues.ContainsKey(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ湞", a_)))
					{
						num = (short)1354563593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FF;
				}
				goto IL_59;
				IL_88:
				num = (short)639959041;
				if (num != 0)
				{
				}
				num = (short)157679616;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2FF:
				num = (short)648520877;
				short num3 = num;
				num = (short)651994285;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_88;
				default:
					goto IL_335;
				}
				IL_59:
				num = (short)1692139520;
				short num4 = num;
				if (fieldValues != null)
				{
					goto IL_88;
				}
				goto IL_2FF;
			}
			IL_335:
			num = (short)826867712;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
		private global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase a(string setName, string fieldName)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
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
					IL_41:
					num2 = (short)1124794368;
					short num3 = num2;
					if (this.h != null)
					{
						num2 = (short)134283265;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12B;
				}
				case 1:
					num2 = (short)1476395009;
					if (num2 != 0)
					{
					}
					num2 = (short)1768554498;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.h.Any(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory s)
					{
						short num5 = (short)2010775552;
						short num6 = num5;
						num5 = (short)491099023;
						short num7 = num5;
						num5 = (short)522621839;
						switch (num7 == num5)
						{
						}
						num5 = (short)1919221760;
						if (num5 != 0)
						{
						}
						num5 = (short)1162477569;
						if (num5 != 0)
						{
						}
						return s.Name == setName;
					}))
					{
						num2 = (short)1827602435;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12B;
				case 3:
					goto IL_129;
				}
				goto IL_20;
				IL_12B:
				num2 = (short)1183604462;
				short num4 = num2;
				num2 = (short)243621614;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_41;
				default:
					goto IL_161;
				}
			}
			IL_129:
			return this.h.First(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory s)
			{
				short num5 = (short)195756032;
				short num6 = num5;
				num5 = (short)978239170;
				short num7 = num5;
				num5 = (short)2143338178;
				switch (num7 == num5)
				{
				}
				num5 = (short)1918238721;
				if (num5 != 0)
				{
				}
				num5 = (short)1426653184;
				if (num5 != 0)
				{
				}
				return s.Name == setName;
			}).Sets[0].Fields[fieldName];
			IL_161:
			num2 = (short)446955520;
			if (num2 != 0)
			{
			}
			return null;
			IL_20:
			num2 = (short)587726848;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x000BD84C File Offset: 0x000BBA4C
		private static global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity> a(global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType A_0)
		{
			short num = (short)1521590177;
			short num2 = num;
			num = (short)2010226593;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1168048128;
				short num3 = num;
				num = (short)517406721;
				if (num != 0)
				{
				}
				num = (short)2116157440;
				if (num != 0)
				{
				}
				if (!global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFields.j.Any(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity item)
				{
					short num4 = (short)1509425152;
					short num5 = num4;
					num4 = (short)1676973812;
					short num6 = num4;
					num4 = (short)768382708;
					switch (num6 == num4)
					{
					}
					num4 = (short)393609216;
					if (num4 != 0)
					{
					}
					num4 = (short)298647553;
					if (num4 != 0)
					{
					}
					return item.Feature == A_0;
				}))
				{
					return null;
				}
				break;
			}
			}
			return global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFields.j.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity item)
			{
				short num4 = (short)1108213760;
				short num5 = num4;
				num4 = (short)2026583279;
				short num6 = num4;
				num4 = (short)380318959;
				switch (num6 == num4)
				{
				}
				num4 = (short)71892993;
				if (num4 != 0)
				{
				}
				num4 = (short)814678016;
				if (num4 != 0)
				{
				}
				return item.Feature == CS$<>8__locals1.feature;
			}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity>();
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x000BD94C File Offset: 0x000BBB4C
		// Note: this type is marked as 'beforefieldinit'.
		static RadioIdentityFields()
		{
			int a_ = 6;
			short num = (short)731971584;
			short num2 = num;
			num = (short)1487726778;
			short num3 = num;
			num = (short)51243194;
			switch (num3 == num)
			{
			}
			num = (short)742326272;
			if (num != 0)
			{
			}
			num = (short)1887895553;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFields.j = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity>
			{
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ـ♂⭄≆㭈⩊⅌ᱎ㑐❒⅔㹖㝘㱚⹜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᕆࡈཊьNၐὒ᱔ᙖ੘њṜཞ㉠", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᕆࡈཊьNၐὒ᱔ᙖ੘", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.None),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ـ♂⭄≆㭈⩊⅌ᱎ㑐❒⅔㹖㝘㱚⹜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆ᱈ॊṌ౎͐ᩒ᝔ቖ୘ቚᥜ^≠㍢㙤", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆ᱈ॊṌ౎͐ᩒ᝔ቖ୘ቚᥜ", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.None),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀ♂ㅄう♈㥊♌", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ^≠㍢㙤", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌᵎᕐᩒՔᙖᵘ὚ཛྷ", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.None),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀ♂ㅄう♈㥊♌", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌ౎ၐᩒ᭔ቖ൘ቚᥜ^≠㍢㙤", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀقᅄᑆైὊቌ౎ၐᩒ᭔ቖ൘ቚᥜ", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.None),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ـ♂⭄≆㭈⩊⅌ᱎ㑐❒⅔㹖㝘㱚⹜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚浜^≠㍢㙤", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚浜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.FiveTone),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ـ♂⭄≆㭈⩊⅌ᱎ㑐❒⅔㹖㝘㱚⹜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚汜^≠㍢㙤", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚汜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.FiveTone),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ـ♂⭄≆㭈⩊⅌ᱎ㑐❒⅔㹖㝘㱚⹜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚潜^≠㍢㙤", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚潜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.FiveTone),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ـ♂⭄≆㭈⩊⅌ᱎ㑐❒⅔㹖㝘㱚⹜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚湜^≠㍢㙤", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚湜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.FiveTone),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ـ♂⭄≆㭈⩊⅌ᱎ㑐❒⅔㹖㝘㱚⹜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚楜^≠㍢㙤", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚楜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.FiveTone),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ـ♂⭄≆㭈⩊⅌ᱎ㑐❒⅔㹖㝘㱚⹜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚桜^≠㍢㙤", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚桜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.FiveTone),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ـ♂⭄≆㭈⩊⅌ᱎ㑐❒⅔㹖㝘㱚⹜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚歜^≠㍢㙤", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚歜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.FiveTone),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ـ♂⭄≆㭈⩊⅌ᱎ㑐❒⅔㹖㝘㱚⹜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚橜^≠㍢㙤", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፀBᩄᑆై݊硌ᵎၐᝒ᱔ᡖၘ὚橜", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.FiveTone),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀ♂ㅄう♈㥊♌", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᙀɂፄɆੈൊੌൎᵐᡒ੔Vᡘ൚ᡜਫ਼㉠♢㝤⹦⵨㑪⹬㽮≰", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᙀɂፄɆੈൊੌൎᵐᡒ੔Vᡘ൚ᡜਫ਼㉠♢㝤⹦⵨", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.Wave),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀ♂ㅄう♈㥊♌", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᙀɂፄɆੈൊੌൎᵐᡒ੔Vᡘ൚ᡜਫ਼㉠♢㝤㝦⡨㡪㹬㡮㹰ⅲㅴ⡶㩸⭺⹼", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᙀɂፄɆੈൊੌൎᵐᡒ੔Vᡘ൚ᡜਫ਼㉠♢㝤㝦⡨㡪㹬㡮㹰ⅲㅴ", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.Wave),
				new global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཀ♂ㅄう♈㥊♌", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᙀూلц཈ొཌ͎ᩐ౒ᑔᑖ൘ቚଡ଼Ṟ㕠⩢⩤⥦⩨⑪⥬⩮⹰ひ╴⑶", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᙀూلц཈ొཌ͎ᩐ౒ᑔᑖ൘ቚଡ଼Ṟ㕠⩢⩤⥦⩨⑪⥬⩮", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.WaveOnCloud)
			};
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x000BDD30 File Offset: 0x000BBF30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase a(global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity A_0)
		{
			short num = (short)619773952;
			short num2 = num;
			num = (short)873658366;
			short num3 = num;
			num = (short)369489918;
			switch (num3 == num)
			{
			}
			num = (short)1543766017;
			if (num != 0)
			{
			}
			num = (short)654704640;
			if (num != 0)
			{
			}
			return this.a(A_0.Set, A_0.FieldId);
		}

		// Token: 0x0400046C RID: 1132
		private const string a = "GeneralSettings";

		// Token: 0x0400046D RID: 1133
		private const string b = "Network";

		// Token: 0x0400046E RID: 1134
		private const string c = "NETSET_RDIPADDR";

		// Token: 0x0400046F RID: 1135
		private const string d = "NETSET_RDIPADDR0";

		// Token: 0x04000470 RID: 1136
		private const string e = "NETSET_RDIPADDR1";

		// Token: 0x04000471 RID: 1137
		private const string f = "NETSET_RDIPADDR2";

		// Token: 0x04000472 RID: 1138
		private const string g = "NETSET_RDIPADDR3";

		// Token: 0x04000473 RID: 1139
		private readonly global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> h;

		// Token: 0x04000474 RID: 1140
		private readonly global::System.Collections.Generic.Dictionary<string, string> i;

		// Token: 0x04000475 RID: 1141
		private static readonly global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentity> j;

		// Token: 0x04000476 RID: 1142
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> k;

		// Token: 0x04000477 RID: 1143
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Collections.Generic.List<string> l;
	}
}
