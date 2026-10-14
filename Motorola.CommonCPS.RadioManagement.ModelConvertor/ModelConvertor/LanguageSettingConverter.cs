using System;
using System.Collections.Generic;
using System.Text;
using CommonUtility;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.ModelConvertor
{
	// Token: 0x02000003 RID: 3
	public class LanguageSettingConverter
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public static string Convert2UIDispaly(string radioSummaryLanguageSetting, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary rawData)
		{
			short num = (short)627441664;
			switch (num)
			{
			default:
			{
				num = (short)1753952825;
				short num2 = num;
				num = (short)1091908153;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)39387136;
					if (num != 0)
					{
					}
					num = (short)870252544;
					short num3 = num;
					num = (short)1636827137;
					int num4 = (int)((global::System.IntPtr)num);
					global::System.Text.StringBuilder stringBuilder;
					for (;;)
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc> list;
						switch (num4)
						{
						case 0:
						{
							if (list.Count == 0)
							{
								num = (short)1122566150;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							stringBuilder = new global::System.Text.StringBuilder();
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>.Enumerator enumerator = list.GetEnumerator();
							num = (short)720109571;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_D7;
							}
							continue;
						case 2:
							goto IL_3AC;
						case 3:
							try
							{
								num = (short)212271107;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									string value;
									string text;
									switch (num4)
									{
									case 0:
										goto IL_39C;
									case 1:
										num = (short)824705030;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_352;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_1E8;
										}
										continue;
									case 4:
										num = (short)1868169216;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										if (rawData is global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary)
										{
											num = (short)835649545;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc languageSettingDesc;
										value = global::Motorola.CommonCPS.RadioManagement.CommonBase.PacResourceFactory.Instance().GetStringByResourceID(languageSettingDesc.LanguageID, null);
										num = (short)1134166018;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc languageSettingDesc;
										text = languageSettingDesc.LanguageName;
										goto IL_2EC;
									}
									case 7:
									{
										global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc languageSettingDesc;
										if (!string.IsNullOrEmpty(languageSettingDesc.LanguageName))
										{
											num = (short)291831809;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1691680778;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										goto IL_352;
									case 9:
										num = (short)593821703;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
									{
										global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc languageSettingDesc;
										text = global::Motorola.CommonCPS.RadioManagement.CommonBase.PacResourceFactory.Instance().GetStringByResourceID(global::CommonUtility.PCRLanguageUtility.ToResourceID(languageSettingDesc.LanguageID), null);
										goto IL_2EC;
									}
									case 11:
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)199557124;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc languageSettingDesc = enumerator.Current;
										num = (short)1991639045;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_22A:
									num = (short)992477195;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_1E8:
									goto IL_22A;
									IL_2EC:
									value = text;
									num = (short)741539848;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_352:
									stringBuilder.Append(value);
									stringBuilder.Append(',');
									num = (short)1648361484;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_39C:
								goto IL_3ED;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_3AC;
						case 4:
							if (list != null)
							{
								num = (short)1675558914;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_143;
						case 5:
							goto IL_F4;
						case 6:
							goto IL_3E8;
						}
						IL_D7:
						if (string.IsNullOrEmpty(radioSummaryLanguageSetting))
						{
							num = (short)788856837;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						list = global::Motorola.CommonCPS.Common.CommonUtility.ObjectSeralizeUtility.JsonToObject<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>>(radioSummaryLanguageSetting);
						num = (short)144179204;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_3AC:
						num = (short)69599232;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_F4:
					num = (short)450691073;
					if (num != 0)
					{
					}
					return string.Empty;
					IL_3ED:
					return stringBuilder.ToString().TrimEnd(new char[]
					{
						','
					});
				}
				}
				IL_143:
				return string.Empty;
				IL_3E8:
				goto IL_143;
			}
			}
		}

		// Token: 0x04000003 RID: 3
		private const char a = ',';
	}
}
