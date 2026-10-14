using System;
using System.Collections.Generic;
using System.Diagnostics;
using AcpCommonLib;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.AcpXMLCoreEngineLib
{
	// Token: 0x02000227 RID: 551
	public class AcpReports : global::SpecialFeatures.AcpXMLCoreEngineLib.IAcpReports
	{
		// Token: 0x06001C23 RID: 7203 RVA: 0x0024891C File Offset: 0x00246B1C
		public void GetFeatureSectionName(ref string sectionName, int FeatureID, int SectionID, int index)
		{
			int a_ = 10;
			short num = (short)1140195328;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_5E;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset acpRecordset;
			for (;;)
			{
				IL_3C:
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				switch (num3)
				{
				case 0:
				{
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
					if (acpFeatureSection != null)
					{
						num = (short)890896385;
						if (num != 0)
						{
						}
						num = (short)263979009;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 1:
				{
					sectionName = "";
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
					sectionName = acpFeatureSection.UIName;
					num = (short)1794244613;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (acpFeatureNode != null)
					{
						num = (short)796196867;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = acpFeatureNode[SectionID];
					num = (short)272826368;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)987279982;
					short num4 = num;
					num = (short)962441838;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18E;
					default:
						num = (short)397279232;
						if (num != 0)
						{
						}
						if (acpRecordset != null)
						{
							num = (short)821231622;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 5:
					return;
				case 6:
					goto IL_18E;
				}
				goto IL_5E;
				IL_18E:
				acpFeatureNode = acpRecordset[index];
				num = (short)72417282;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_5E:
			acpRecordset = null;
			sectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8cﲔ뮚펜ﺞ철욢", a_);
			acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(FeatureID);
			num = (short)671416324;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_3C;
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00248AF8 File Offset: 0x00246CF8
		public void GetfieldsCollection(ref global::AcpCommonLib.IAcpFeatureSection featureSection, int FeatureID, int SectionID, int index)
		{
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				global::AcpCommonLib.IAcpRecordset acpRecordset;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						if (acpFeatureNode != null)
						{
							num2 = (short)2020474883;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 1:
						goto IL_F3;
					case 2:
						if (acpRecordset != null)
						{
							num2 = (short)1031143428;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 3:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						featureSection = acpFeatureNode[SectionID];
						num2 = (short)828584133;
						short num3 = num2;
						num2 = (short)266219717;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)2104295424;
							if (num2 != 0)
							{
							}
							num2 = (short)555679745;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 4:
					{
						num2 = (short)434831361;
						if (num2 != 0)
						{
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = acpRecordset[index];
						num2 = (short)1231421440;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				IL_24:
				acpRecordset = null;
				acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(FeatureID);
				num2 = (short)1583153154;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_F3:
			num2 = (short)865796096;
			short num4 = num2;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00248C68 File Offset: 0x00246E68
		public void GetfieldFromPath(ref global::AcpCommonLib.IAcpField field, int FeatureID, string fieldPath)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset acpRecordset;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					for (;;)
					{
						num2 = (short)1476381583;
						short num3 = num2;
						num2 = (short)1840696207;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_94;
						}
					}
					IL_94:
					num2 = (short)1478426624;
					short num4 = num2;
					num2 = (short)867893249;
					if (num2 != 0)
					{
					}
					num2 = (short)561840128;
					if (num2 != 0)
					{
					}
					field = acpRecordset.FieldFromPath(fieldPath, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("㞋", a_));
					num2 = (short)40960001;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
					if (acpRecordset != null)
					{
						num2 = (short)620953600;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_25;
			}
			return;
			IL_25:
			acpRecordset = null;
			acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(FeatureID);
			num2 = (short)502464514;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x00248DA0 File Offset: 0x00246FA0
		public void GetfieldsCollectionFromName(ref global::AcpCommonLib.IAcpField field, int FeatureID, int SectionID, int index, string fieldName)
		{
			int a_ = 6;
			short num = (short)1517355008;
			short num2 = num;
			num = (short)821690368;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7D;
				}
				global::AcpCommonLib.IAcpRecordset acpRecordset;
				for (;;)
				{
					IL_5A:
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
					switch (num3)
					{
					case 0:
					{
						num = (short)1643839489;
						if (num != 0)
						{
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						if (acpFeatureNode != null)
						{
							num = (short)981139457;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						acpFeatureSection = acpFeatureNode[SectionID];
						num = (short)836370434;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (acpFeatureSection != null)
						{
							num = (short)663093251;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_300;
					case 4:
						if (acpRecordset != null)
						{
							num = (short)509083654;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						try
						{
							num = (short)1829240838;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_120;
								case 1:
								{
									global::AcpCommonLib.IAcpField acpField;
									field = acpField;
									num = (short)1416364032;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpField acpField;
									if (fieldName == acpField.Name)
									{
										num = (short)653393921;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpField acpField;
									if (acpField != null)
									{
										num = (short)1275592708;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_1AD;
								case 5:
									goto IL_28E;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_105;
									}
									continue;
								case 7:
								{
									num = (short)90378414;
									short num4 = num;
									num = (short)379195566;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1AD;
									default:
										num = (short)1281359872;
										if (num != 0)
										{
										}
										num = (short)473890821;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)597884935;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpField acpField = enumerator.Current;
									global::System.Diagnostics.Trace.WriteLine(string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("있놊뾎뾒떔솖爵\udaa0銢\ud8a4讦覨ﮪ첬\udbae\ud9b0좲螴쪶馸", a_), acpField.Name, acpField.ToString(), acpField.Path(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("했", a_))));
									num = (short)1984364547;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_125:
								num = (short)1669595144;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_105:
								goto IL_125;
								IL_1AD:
								num = (short)1758199810;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_120:
							IL_28E:
							return;
						}
						finally
						{
							num = (short)76939266;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1456078849;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2FD;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2C5;
									}
									continue;
								}
								IL_2C5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1812332544;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_2FD:;
						}
						goto IL_300;
					case 6:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = acpRecordset[index];
						num = (short)1175977984;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7D;
					IL_300:
					enumerator = acpFeatureSection.FieldsCollection.GetEnumerator();
					num = (short)632619013;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7D:
				acpRecordset = null;
				acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(FeatureID);
				num = (short)1038286852;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}
	}
}
