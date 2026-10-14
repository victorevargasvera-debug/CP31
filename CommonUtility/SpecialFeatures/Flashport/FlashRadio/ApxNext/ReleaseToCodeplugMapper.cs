using System;
using System.Collections.Generic;
using CommonUtility;

namespace SpecialFeatures.Flashport.FlashRadio.ApxNext
{
	// Token: 0x02000009 RID: 9
	public class ReleaseToCodeplugMapper
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000047AC File Offset: 0x000029AC
		public static string GetMaxSupportedCodeplug(string targetRelease)
		{
			int a_ = 19;
			int num;
			short num2;
			string result;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						num2 = (short)966656003;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_C7;
					case 2:
						if (targetRelease != null)
						{
							num2 = (short)2009268224;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
						if (!global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ReleaseToCodeplugMapper.a.TryGetValue(targetRelease, out result))
						{
							num2 = (short)1870921729;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					goto IL_29;
				}
				IL_C7:
				num2 = (short)509637414;
				short num3 = num2;
				num2 = (short)763982630;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2B;
				default:
				{
					num2 = (short)321781760;
					if (num2 != 0)
					{
					}
					num2 = (short)156762113;
					if (num2 != 0)
					{
					}
					num2 = (short)1959919616;
					short num4 = num2;
					throw new global::System.Exception(global::CommonUtility.VersionUtility.b("捃", a_) + targetRelease + global::CommonUtility.VersionUtility.b("捃晅ⅇ㥉汋⁍㽏♑瑓㥕㙗穙⡛㙝՟䉡ࡣཥ᭧ṩ䱫ŭᙯ剱ݳ͵ࡷ੹፻౽ꚅ慎", a_));
				}
				}
				return result;
			}
			}
			IL_29:
			result = null;
			IL_2B:
			num2 = (short)700710914;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004938 File Offset: 0x00002B38
		// Note: this type is marked as 'beforefieldinit'.
		static ReleaseToCodeplugMapper()
		{
			int a_ = 17;
			short num = (short)745087857;
			short num2 = num;
			num = (short)1036460913;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1027538944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1338572801;
			if (num != 0)
			{
			}
			num = (short)920846336;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ReleaseToCodeplugMapper.a = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					global::CommonUtility.VersionUtility.b("灁瑃瑅硇摉祋", a_),
					global::CommonUtility.VersionUtility.b("၁癃瑅晇獉畋恍楏歑浓", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("灁瑃瑅祇摉絋", a_),
					global::CommonUtility.VersionUtility.b("၁癃畅晇獉畋恍楏歑浓", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("灁瑃瑅祇摉繋", a_),
					global::CommonUtility.VersionUtility.b("၁癃牅晇獉畋恍楏歑浓", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("灁瑃瑅祇摉罋", a_),
					global::CommonUtility.VersionUtility.b("၁癃獅晇獉畋恍楏歑浓", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("灁瑃瑅祇摉硋", a_),
					global::CommonUtility.VersionUtility.b("၁癃灅晇獉畋恍楏歑浓", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("灁瑃瑅穇摉絋", a_),
					global::CommonUtility.VersionUtility.b("၁癃煅晇獉畋恍楏歑浓", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("灁瑃瑅穇摉繋", a_),
					global::CommonUtility.VersionUtility.b("၁癃繅晇獉畋恍楏歑浓", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("灁瑃瑅穇摉罋", a_),
					global::CommonUtility.VersionUtility.b("၁癃罅晇獉畋恍楏歑浓", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("灁瑃瑅筇摉絋", a_),
					global::CommonUtility.VersionUtility.b("၁睃癅晇獉畋恍楏歑浓", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("灁瑃瑅筇摉繋", a_),
					global::CommonUtility.VersionUtility.b("၁睃睅晇獉畋恍楏歑浓", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("灁瑃瑅筇摉罋", a_),
					global::CommonUtility.VersionUtility.b("၁睃瑅晇獉畋恍楏歑浓", a_)
				}
			};
		}

		// Token: 0x04000015 RID: 21
		private static global::System.Collections.Generic.Dictionary<string, string> a;
	}
}
