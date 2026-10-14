using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using ASK.Interface;
using Motorola.CommonCPS.ResourceRepository;

namespace ASK.Core
{
	// Token: 0x0200000F RID: 15
	[global::System.Serializable]
	public class AccessRecord : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00007678 File Offset: 0x00005878
		internal AccessRecord(string A_0, int A_1, global::ASK.Interface.FeatureCategoryType A_2, byte[] A_3, global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> A_4, global::ASK.Interface.FeatureCategoryRadioType A_5, bool A_6)
		{
			this.accessNodes = new global::ASK.Core.AccessRecordSetX<global::ASK.Core.AccessNode>(global::Motorola.CommonCPS.ResourceRepository.Resources.Codeplug_Field);
			this.m_ranges = new global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>();
			this.primaryKey = A_1;
			this.m_name = A_0;
			this.m_recType = A_2;
			this.m_radioType = A_5;
			this.m_bOTAPState = A_6;
			this.m_bInUseFlag = false;
			this.m_FieldCodeArr = new byte[24];
			this.a();
			if (A_3 != null)
			{
				global::System.Array.Copy(A_3, 0, this.m_FieldCodeArr, 0, A_3.Length);
				this.m_bOTAPState = this.b(193);
			}
			if (A_4 != null)
			{
				for (;;)
				{
					using (global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator = A_4.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::System.Collections.Generic.KeyValuePair<ushort, global::ASK.Core.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
							this.m_ranges.Add(keyValuePair.Key, keyValuePair.Value);
						}
						break;
					}
				}
			}
			this.c();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007778 File Offset: 0x00005978
		public AccessRecord(string name, int pk, global::ASK.Interface.FeatureCategoryType recType) : this(name, pk, recType, null, null, global::ASK.Interface.FeatureCategoryRadioType.XTSXTLRadios, false)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007787 File Offset: 0x00005987
		public AccessRecord(string name, global::ASK.Interface.FeatureCategoryType recType) : this(name, 0, recType, null, null, global::ASK.Interface.FeatureCategoryRadioType.XTSXTLRadios, false)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007796 File Offset: 0x00005996
		public AccessRecord(int pk, global::ASK.Interface.FeatureCategoryType recType, byte[] fieldCode, global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> ranges, bool bOTAP) : this(null, pk, recType, fieldCode, ranges, global::ASK.Interface.FeatureCategoryRadioType.XTSXTLRadios, bOTAP)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000077A8 File Offset: 0x000059A8
		public AccessRecord(global::ASK.Core.AccessRecord copy)
		{
			this.accessNodes = new global::ASK.Core.AccessRecordSetX<global::ASK.Core.AccessNode>(global::Motorola.CommonCPS.ResourceRepository.Resources.Codeplug_Field);
			this.m_ranges = new global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>();
			this.primaryKey = copy.primaryKey;
			this.m_id = copy.m_id;
			this.m_name = copy.m_name;
			this.m_bOTAPState = copy.m_bOTAPState;
			this.m_bInUseFlag = copy.m_bInUseFlag;
			this.m_recType = copy.m_recType;
			this.m_FieldCodeArr = new byte[24];
			global::System.Array.Copy(copy.m_FieldCodeArr, 0, this.m_FieldCodeArr, 0, copy.m_FieldCodeArr.Length);
			using (global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator = copy.m_ranges.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Collections.Generic.KeyValuePair<ushort, global::ASK.Core.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
					global::ASK.Core.FieldValueRangeRecSet fieldValueRangeRecSet = new global::ASK.Core.FieldValueRangeRecSet(keyValuePair.Value.OwnerID);
					using (global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator2 = keyValuePair.Value.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::ASK.Core.AccessFieldValueRange accessFieldValueRange = enumerator2.Current;
							fieldValueRangeRecSet.Add(new global::ASK.Core.AccessFieldValueRange
							{
								FieldID = accessFieldValueRange.FieldID,
								Minimum = accessFieldValueRange.Minimum,
								Maximum = accessFieldValueRange.Maximum
							});
						}
						goto IL_12E;
					}
					break;
					IL_12E:
					this.m_ranges.Add(keyValuePair.Key, fieldValueRangeRecSet);
					continue;
					IL_1A2:
					goto IL_E3;
				}
				goto IL_1A2;
			}
			return;
			for (;;)
			{
				IL_E3:
				using (global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator3 = copy.AccessNodes.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						global::ASK.Core.AccessNode a_ = enumerator3.Current;
						global::ASK.Core.AccessNode item = this.c(a_);
						this.accessNodes.Add(item);
					}
					break;
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007994 File Offset: 0x00005B94
		private void c()
		{
			short num = (short)1819672576;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = global::ASK.Core.FeatureSchemaManager.FeatureCategories.GetEnumerator();
				try
				{
					num = (short)836829193;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)1067778049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::ASK.Core.FeatureCategory featureCategory;
							if (featureCategory.RadioType == this.m_radioType)
							{
								num = (short)1541799941;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator2;
							try
							{
								num = (short)103219204;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
										goto IL_394;
									case 2:
										num = (short)456261633;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)1316159490;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::ASK.Core.AccessNode a_ = enumerator2.Current;
										global::ASK.Core.AccessNode item = this.d(a_);
										this.accessNodes.Add(item);
										num = (short)348454912;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_30D;
										}
										continue;
									}
									IL_344:
									num = (short)1198784515;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_30D:
									goto IL_344;
								}
								IL_394:
								goto IL_2A9;
							}
							finally
							{
								num = (short)1898446850;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_452;
									case 1:
										enumerator2.Dispose();
										num = (short)1549598720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_3AF;
									}
									goto IL_3CC;
									IL_3AF:
									switch (0)
									{
									case 0:
									{
										IL_3CC:
										if (enumerator2 == null)
										{
											goto IL_454;
										}
										num = (short)1500936217;
										short num3 = num;
										num = (short)648509465;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_3AF;
										default:
											num = (short)1194262528;
											if (num != 0)
											{
											}
											num = (short)1432616961;
											num2 = (int)((global::System.IntPtr)num);
											break;
										}
										break;
									}
									}
								}
								IL_452:
								IL_454:;
							}
							goto IL_455;
							IL_2A9:
							global::ASK.Core.FeatureCategory featureCategory;
							enumerator2 = featureCategory.Functions.GetEnumerator();
							num = (short)2131361795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							try
							{
								num = (short)2054619140;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
										goto IL_1D4;
									case 2:
										num = (short)1296629761;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)574619650;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::ASK.Core.AccessNode a_2 = enumerator2.Current;
										global::ASK.Core.AccessNode item2 = this.d(a_2);
										this.accessNodes.Add(item2);
										num = (short)1269956608;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_14B;
										}
										continue;
									}
									IL_184:
									num = (short)758185987;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_14B:
									goto IL_184;
								}
								IL_1D4:;
							}
							finally
							{
								num = (short)1388183554;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator2;
									switch (num2)
									{
									case 0:
										goto IL_23E;
									case 1:
										enumerator2.Dispose();
										num = (short)1896546304;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_208;
										}
										continue;
									}
									IL_208:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)214237185;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_23E:;
							}
							break;
						case 4:
						{
							global::ASK.Core.FeatureCategory featureCategory;
							if (featureCategory.Type == this.m_recType)
							{
								num = (short)1045889024;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							global::ASK.Core.FeatureCategory featureCategory;
							global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator2 = featureCategory.Features.GetEnumerator();
							num = (short)1913913346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_46D;
						case 7:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1147863048;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASK.Core.FeatureCategory featureCategory = (global::ASK.Core.FeatureCategory)enumerator.Current;
							num = (short)786694148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_455;
						case 9:
							switch (0)
							{
							case 0:
								goto IL_79;
							}
							continue;
						}
						IL_241:
						num = (short)1459486727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_79:
						goto IL_241;
						IL_455:
						num = (short)349831174;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_46D:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_48F;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_47C:
						switch (num2)
						{
						case 0:
							goto IL_50F;
						case 1:
							disposable.Dispose();
							num = (short)439549952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)172425217;
							if (num != 0)
							{
							}
							if (disposable != null)
							{
								num = (short)934936577;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_511;
						}
						goto IL_48F;
					}
					IL_50F:
					IL_511:
					goto EndFinally_17;
					IL_48F:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)766443522;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_47C;
					EndFinally_17:;
				}
				num = (short)556466176;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00007F28 File Offset: 0x00006128
		private global::ASK.Core.AccessNode d(global::ASK.Core.AccessNode A_0)
		{
			short num = (short)1646657536;
			short num2 = num;
			num = (short)369819649;
			if (num != 0)
			{
			}
			num = (short)1371930624;
			switch (num)
			{
			default:
			{
				global::ASK.Core.AccessNode accessNode = new global::ASK.Core.AccessNode(A_0.Name, A_0.UIName, A_0.ID);
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator = A_0.Sections.GetEnumerator();
				try
				{
					num = (short)1703346176;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_D4;
							}
							continue;
						case 1:
							goto IL_6FB;
						case 3:
						{
							global::ASK.Core.AccessSection accessSection;
							try
							{
								num = (short)526516235;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										global::ASK.Core.AccessElement accessElement;
										if (accessElement is global::ASK.Core.AccessOperation)
										{
											num = (short)664862724;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_39E;
									}
									case 1:
										goto IL_39E;
									case 3:
									{
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1507655686;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::ASK.Core.AccessElement accessElement = enumerator2.Current;
										global::ASK.Core.AccessElement accessElement2 = null;
										num = (short)1642201103;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::ASK.Core.AccessElement accessElement;
										global::ASK.Core.AccessElement accessElement2 = new global::ASK.Core.AccessOperation(accessElement.Name, accessElement.UIName, accessElement.ID, accessElement.ElemID, false);
										((global::ASK.Core.AccessOperation)accessElement2).AccessLevel = this.b(accessElement2.ID);
										num = (short)465109002;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										num = (short)1408696343;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										num = (short)1894580245;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										global::ASK.Core.AccessElement accessElement;
										global::ASK.Core.AccessElement accessElement2 = new global::ASK.Core.AccessRangeField(accessElement.Name, accessElement.UIName, accessElement.ID, ((global::ASK.Core.AccessRangeField)accessElement).MapID, accessElement.ElemID, global::ASK.Interface.AccessLevelType.ReadOnly);
										num = (short)1561264150;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										if (this.m_FieldCodeArr != null)
										{
											num = (short)1582825488;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_39E;
									case 9:
									{
										global::ASK.Core.AccessElement accessElement2;
										accessSection.Items.Add(accessElement2);
										num = (short)479264770;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
										goto IL_39E;
									case 11:
										switch (0)
										{
										case 0:
											goto IL_165;
										}
										continue;
									case 12:
										goto IL_318;
									case 13:
										if (this.m_FieldCodeArr != null)
										{
											num = (short)2004877329;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_39E;
									case 14:
									{
										global::ASK.Core.AccessElement accessElement2;
										if (accessElement2 != null)
										{
											num = (short)874512393;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 15:
									{
										global::ASK.Core.AccessElement accessElement;
										if (accessElement is global::ASK.Core.AccessRangeField)
										{
											num = (short)776404999;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1771438100;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 16:
									{
										global::ASK.Core.AccessElement accessElement2;
										((global::ASK.Core.AccessRangeField)accessElement2).AccessLevel = this.a((ushort)accessElement2.ID);
										num = (short)1628700690;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 17:
									{
										global::ASK.Core.AccessElement accessElement2;
										((global::ASK.Core.AccessField)accessElement2).AccessLevel = this.a((ushort)accessElement2.ID);
										num = (short)1682636801;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 18:
										goto IL_39E;
									case 19:
									{
										global::ASK.Core.AccessElement accessElement;
										global::ASK.Core.AccessElement accessElement2 = new global::ASK.Core.AccessField(accessElement.Name, accessElement.UIName, accessElement.ID, ((global::ASK.Core.AccessField)accessElement).MapID, accessElement.ElemID, global::ASK.Interface.AccessLevelType.ReadOnly);
										num = (short)1126236173;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 20:
									{
										global::ASK.Core.AccessElement accessElement;
										if (accessElement is global::ASK.Core.AccessField)
										{
											num = (short)2040659987;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1169162240;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 21:
										goto IL_573;
									case 22:
										if (this.m_ranges != null)
										{
											num = (short)1961820165;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_318;
									case 23:
									{
										global::ASK.Core.AccessElement accessElement;
										if (this.m_ranges.ContainsKey((ushort)accessElement.ID))
										{
											num = (short)1508573208;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_318;
									}
									case 24:
									{
										global::ASK.Core.AccessElement accessElement;
										global::ASK.Core.AccessElement accessElement2;
										((global::ASK.Core.AccessRangeField)accessElement2).Ranges = this.m_ranges[(ushort)accessElement.ID];
										num = (short)1726283788;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_205:
									num = (short)944046083;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_165:
									goto IL_205;
									IL_318:
									num = (short)65077256;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_39E:
									num = (short)1300168718;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_573:
								goto IL_6B9;
							}
							finally
							{
								num = (short)585632139;
								short num4 = num;
								num = (short)266209675;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)230883328;
									if (num != 0)
									{
									}
									num = (short)1751777281;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2;
										switch (num3)
										{
										case 0:
											goto IL_62E;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_5F5;
											}
											continue;
										case 2:
											enumerator2.Dispose();
											num = (short)1281622016;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_5F5:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)1477902338;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_62E:
									break;
								}
							}
							break;
							IL_6B9:
							accessNode.Sections.Add(accessSection);
							num = (short)565706754;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1225457669;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASK.Core.AccessSection accessSection2 = enumerator.Current;
							global::ASK.Core.AccessSection accessSection = new global::ASK.Core.AccessSection(accessSection2.Name, accessSection2.UIName, accessSection2.ID);
							global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2 = accessSection2.Items.GetEnumerator();
							num = (short)718143491;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1852178433;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_631:
						num = (short)1751908356;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D4:
						goto IL_631;
					}
					IL_6FB:;
				}
				finally
				{
					num = (short)762511361;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_766;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_730;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)558039040;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_730:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1664024578;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_766:;
				}
				return accessNode;
			}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000086D4 File Offset: 0x000068D4
		private global::ASK.Core.AccessNode c(global::ASK.Core.AccessNode A_0)
		{
			short num = (short)2059010048;
			short num2 = num;
			num = (short)180617216;
			switch (num)
			{
			default:
			{
				global::ASK.Core.AccessNode accessNode = new global::ASK.Core.AccessNode(A_0.Name, A_0.UIName, A_0.ID);
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator = A_0.Sections.GetEnumerator();
				try
				{
					num = (short)171704324;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_64B;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)115867651;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASK.Core.AccessSection accessSection = enumerator.Current;
							global::ASK.Core.AccessSection accessSection2 = new global::ASK.Core.AccessSection(accessSection.Name, accessSection.UIName, accessSection.ID);
							global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2 = accessSection.Items.GetEnumerator();
							num = (short)1277100037;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)466616320;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_AD;
							}
							continue;
						case 5:
						{
							try
							{
								num = (short)1022099460;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::ASK.Core.AccessElement accessElement2;
									switch (num3)
									{
									case 0:
										goto IL_4BE;
									case 1:
									{
										global::ASK.Core.AccessElement accessElement;
										if (accessElement is global::ASK.Core.AccessOperation)
										{
											num = (short)1356660745;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2BF;
									}
									case 2:
										goto IL_2BF;
									case 3:
										num = (short)1558708224;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_110;
										}
										continue;
									case 5:
									{
										global::ASK.Core.AccessElement accessElement;
										global::ASK.Core.AccessField accessField = (global::ASK.Core.AccessField)accessElement;
										accessElement2 = new global::ASK.Core.AccessField(accessField.Name, accessField.UIName, accessField.ID, accessField.MapID, accessField.ElemID, accessField.AccessLevel);
										num = (short)1062666252;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										global::ASK.Core.AccessElement accessElement;
										if (accessElement is global::ASK.Core.AccessRangeField)
										{
											num = (short)410910731;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2087452679;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										global::ASK.Core.AccessElement accessElement;
										if (accessElement is global::ASK.Core.AccessField)
										{
											num = (short)2043346949;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1357381633;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1537277955;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::ASK.Core.AccessElement accessElement = enumerator2.Current;
										accessElement2 = null;
										num = (short)1043333126;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
									{
										global::ASK.Core.AccessElement accessElement;
										global::ASK.Core.AccessOperation accessOperation = (global::ASK.Core.AccessOperation)accessElement;
										accessElement2 = new global::ASK.Core.AccessOperation(accessOperation.Name, accessOperation.UIName, accessOperation.ID, accessOperation.ElemID, accessOperation.AccessLevel);
										num = (short)1457586178;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
									{
										global::ASK.Core.AccessElement accessElement;
										global::ASK.Core.AccessRangeField accessRangeField = (global::ASK.Core.AccessRangeField)accessElement;
										accessElement2 = new global::ASK.Core.AccessRangeField(accessRangeField.Name, accessRangeField.UIName, accessRangeField.ID, accessRangeField.MapID, accessRangeField.ElemID, accessRangeField.AccessLevel);
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator3 = accessRangeField.Ranges.GetEnumerator();
										num = (short)648216589;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										goto IL_2BF;
									case 13:
										try
										{
											num = (short)623312899;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													goto IL_24E;
												case 2:
												{
													global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator3;
													if (!enumerator3.MoveNext())
													{
														num = (short)400556036;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::ASK.Core.AccessFieldValueRange accessFieldValueRange = enumerator3.Current;
													global::ASK.Core.AccessFieldValueRange item = new global::ASK.Core.AccessFieldValueRange(accessFieldValueRange.FieldID, accessFieldValueRange.Minimum, accessFieldValueRange.Maximum);
													((global::ASK.Core.AccessRangeField)accessElement2).Ranges.Add(item);
													num = (short)961347585;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
													switch (0)
													{
													case 0:
														goto IL_1A7;
													}
													continue;
												case 4:
													num = (short)422248448;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_1A9:
												num = (short)1752301570;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_1A7:
												goto IL_1A9;
											}
											IL_24E:;
										}
										finally
										{
											num = (short)1265041409;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator3;
												switch (num3)
												{
												case 0:
													goto IL_2BC;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_285;
													}
													continue;
												case 2:
													enumerator3.Dispose();
													num = (short)2040791040;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_285:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)1771175938;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_2BC:;
										}
										goto IL_2BF;
									}
									goto IL_110;
									IL_2BF:
									global::ASK.Core.AccessSection accessSection2;
									accessSection2.Items.Add(accessElement2);
									num = (short)847511562;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_2E6:
									num = (short)996802568;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_110:
									goto IL_2E6;
								}
								IL_4BE:
								goto IL_5BE;
							}
							finally
							{
								num = (short)639434753;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2;
									switch (num3)
									{
									case 0:
										goto IL_530;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_4F6;
										}
										continue;
									case 2:
										enumerator2.Dispose();
										num = (short)58982400;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_4F6:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1892876290;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_530:;
							}
							break;
							IL_5BE:
							num = (short)309863159;
							short num4 = num;
							num = (short)693707511;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)661389312;
								if (num != 0)
								{
								}
								global::ASK.Core.AccessSection accessSection2;
								accessNode.Sections.Add(accessSection2);
								num = (short)507772930;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_533:
						num = (short)1564147713;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_AD:
						goto IL_533;
					}
					IL_64B:;
				}
				finally
				{
					num = (short)755302401;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_6DD;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_682;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)1281228801;
							if (num != 0)
							{
							}
							num = (short)207028224;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_682:
						if (enumerator == null)
						{
							break;
						}
						num = (short)622133250;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_6DD:;
				}
				return accessNode;
			}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00008E10 File Offset: 0x00007010
		public void UpdateFieldCode(global::ASK.Core.AccessNode nodeAccess)
		{
			short num = (short)1556709038;
			short num2 = num;
			num = (short)1984396974;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B8;
			case 1:
				break;
			default:
			{
				num = (short)2014380032;
				short num3 = num;
				break;
			}
			}
			num = (short)1982070785;
			if (num != 0)
			{
			}
			num = (short)106430464;
			if (num != 0)
			{
			}
			num = (short)1463222272;
			switch (num)
			{
			default:
			{
				IL_B8:
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator = nodeAccess.Sections.GetEnumerator();
				try
				{
					num = (short)288358400;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_101;
							}
							continue;
						case 1:
							try
							{
								num = (short)659881986;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										num = (short)1335558148;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1339031552;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::ASK.Core.AccessElement accessElement = enumerator2.Current;
										num = (short)509214732;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1C7;
										}
										continue;
									case 3:
									{
										global::ASK.Core.AccessOperation accessOperation;
										this.a(accessOperation.ID);
										num = (short)1352925194;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_386;
									case 5:
									{
										global::ASK.Core.AccessField accessField;
										this.a(accessField.ID);
										num = (short)1081475085;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										global::ASK.Core.AccessField accessField;
										if (accessField.AccessLevel == global::ASK.Interface.AccessLevelType.Editable)
										{
											num = (short)819331077;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
									{
										global::ASK.Core.AccessElement accessElement;
										global::ASK.Core.AccessOperation accessOperation = (global::ASK.Core.AccessOperation)accessElement;
										num = (short)1119027211;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										global::ASK.Core.AccessElement accessElement;
										if (accessElement is global::ASK.Core.AccessOperation)
										{
											num = (short)443940871;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
									{
										global::ASK.Core.AccessElement accessElement;
										global::ASK.Core.AccessField accessField = (global::ASK.Core.AccessField)accessElement;
										num = (short)1156710406;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
									{
										global::ASK.Core.AccessOperation accessOperation;
										if (accessOperation.AccessLevel)
										{
											num = (short)935133187;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 12:
									{
										global::ASK.Core.AccessElement accessElement;
										if (accessElement is global::ASK.Core.AccessField)
										{
											num = (short)173015049;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1622081544;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1C9:
									num = (short)124321793;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_1C7:
									goto IL_1C9;
								}
								IL_386:
								break;
							}
							finally
							{
								num = (short)1151729664;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2;
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_3BD;
										}
										continue;
									case 1:
										enumerator2.Dispose();
										num = (short)92471298;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_3F4;
									}
									IL_3BD:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)940507137;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_3F4:;
							}
							goto IL_3F7;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1277427715;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2 = enumerator.Current.Items.GetEnumerator();
							num = (short)1335820289;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_3F7;
						case 4:
							goto IL_40F;
						}
						IL_12D:
						num = (short)1542586370;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_101:
						goto IL_12D;
						IL_3F7:
						num = (short)2105868292;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_40F:;
				}
				finally
				{
					num = (short)2086535168;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_443;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1478426626;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_479;
						}
						IL_443:
						if (enumerator == null)
						{
							break;
						}
						num = (short)653393921;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_479:;
				}
				return;
			}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000092D0 File Offset: 0x000074D0
		public byte[] PackedData
		{
			get
			{
				short num = (short)1334902784;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					global::System.Collections.ArrayList arrayList;
					for (;;)
					{
						IL_28:
						int num3;
						global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator2;
						switch (num2)
						{
						case 0:
							if (this.primaryKey > 5)
							{
								num = (short)1800339457;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5CB;
						case 1:
							goto IL_23E;
						case 2:
						{
							arrayList.Add((byte)this.m_ranges.Count);
							byte b = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList.ToArray(typeof(byte)));
							arrayList.Add(b);
							num = (short)2133262345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (num3 >= this.m_FieldCodeArr.Length)
							{
								num = (short)785514498;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							arrayList.Add(this.m_FieldCodeArr[num3]);
							num3++;
							num = (short)2102919172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_D4;
						case 5:
						{
							global::System.Collections.ArrayList arrayList2;
							try
							{
								num = (short)1333395456;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_35B;
										}
										continue;
									case 1:
									{
										global::ASK.Core.FieldValueRangeRecSet value;
										if (value.Count > 0)
										{
											num = (short)316604421;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										num = (short)148111367;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										byte[] array;
										if (array != null)
										{
											num = (short)998309890;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)107937801;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<ushort, global::ASK.Core.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
										global::ASK.Core.FieldValueRangeRecSet value = keyValuePair.Value;
										num = (short)2077229057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::ASK.Core.FieldValueRangeRecSet value;
										byte[] array = value.PackedData;
										num = (short)667025411;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										goto IL_4AD;
									case 7:
									{
										byte[] array;
										if (array.Length != 0)
										{
											num = (short)225181704;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
									{
										byte[] array;
										arrayList.AddRange(array);
										arrayList2.AddRange(array);
										num = (short)444334090;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										num = (short)484507654;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_429:
									num = (short)2055340036;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_35B:
									goto IL_429;
								}
								IL_4AD:;
							}
							finally
							{
								global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							byte b2 = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList2.ToArray(typeof(byte)));
							arrayList.Add(b2);
							goto IL_4EB;
						}
						case 6:
							goto IL_D4;
						case 7:
						{
							num = (short)454514524;
							short num4 = num;
							num = (short)5527388;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_4EB;
							default:
							{
								num = (short)989659137;
								if (num != 0)
								{
								}
								num = (short)222691328;
								short num5 = num;
								num = (short)950730752;
								if (num != 0)
								{
								}
								try
								{
									num = (short)1763115008;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_154;
											}
											continue;
										case 2:
										{
											if (!enumerator2.MoveNext())
											{
												num = (short)1719336963;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::ASK.Core.AccessNode nodeAccess = enumerator2.Current;
											this.UpdateFieldCode(nodeAccess);
											num = (short)911409153;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											num = (short)278724612;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											goto IL_1CB;
										}
										IL_17D:
										num = (short)864813058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_154:
										goto IL_17D;
									}
									IL_1CB:
									goto IL_5CB;
								}
								finally
								{
									num = (short)1176043520;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_204;
											}
											continue;
										case 1:
											enumerator2.Dispose();
											num = (short)1108344834;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_23B;
										}
										IL_204:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)440991745;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_23B:;
								}
								goto IL_23E;
							}
							}
							break;
						}
						case 8:
							goto IL_503;
						case 9:
							if (this.m_ranges.Count > 0)
							{
								num = (short)1030946826;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_614;
						case 10:
						{
							global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
							global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator = this.m_ranges.GetEnumerator();
							num = (short)391708677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_5B;
						IL_D4:
						num = (short)230686723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_23E:
						this.a();
						enumerator2 = this.accessNodes.GetEnumerator();
						num = (short)972423175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4EB:
						num = (short)1294729224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5CB:
						arrayList.Add((byte)this.primaryKey);
						arrayList.Add((byte)this.m_FieldCodeArr.Length);
						num3 = 0;
						num = (short)1136656390;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_503:
					IL_614:
					return (byte[])arrayList.ToArray(typeof(byte));
					IL_5B:
					arrayList = new global::System.Collections.ArrayList();
					new global::System.Collections.ArrayList();
					num = (short)795344896;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000993C File Offset: 0x00007B3C
		public void SetAccessLevel(global::ASK.Interface.AccessLevelType fldAccLvl, bool opAccLvl)
		{
			global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator = this.accessNodes.GetEnumerator();
			short num;
			try
			{
				num = (short)1626555876;
				short num2 = num;
				num = (short)510477796;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AC:
					num = (short)528744449;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1395458048;
					if (num != 0)
					{
					}
					num = (short)1393164291;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (!enumerator.MoveNext())
						{
							num = (short)362807300;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_95;
					case 2:
						goto IL_10D;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					case 4:
						num = (short)2085945346;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C4:
					num = (short)17891328;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_93:
					goto IL_C4;
				}
				IL_95:
				global::ASK.Core.AccessNode accessNode = enumerator.Current;
				this.a(accessNode, fldAccLvl, opAccLvl);
				this.UpdateFieldCode(accessNode);
				goto IL_AC;
				IL_10D:;
			}
			finally
			{
				num = (short)621805569;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1309999106;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_13F;
						}
						continue;
					case 2:
						goto IL_175;
					}
					IL_13F:
					if (enumerator == null)
					{
						break;
					}
					num = (short)807927808;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_175:;
			}
			num = (short)1074790400;
			short num4 = num;
			num = (short)404619265;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00009B30 File Offset: 0x00007D30
		private void a(global::ASK.Core.AccessNode A_0, global::ASK.Interface.AccessLevelType A_1, bool A_2)
		{
			short num = (short)1914241025;
			if (num != 0)
			{
			}
			num = (short)628293632;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator = A_0.Sections.GetEnumerator();
			try
			{
				num = (short)324075523;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1056243716;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2 = enumerator.Current.Items.GetEnumerator();
						num = (short)243990529;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)592838658;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									global::ASK.Core.AccessElement accessElement;
									if (accessElement is global::ASK.Core.AccessField)
									{
										num = (short)1387331590;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)564789249;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::ASK.Core.AccessElement accessElement;
									if (accessElement is global::ASK.Core.AccessOperation)
									{
										num = (short)1055195141;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									num = (short)1288273659;
									short num4 = num;
									num = (short)780697339;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_206;
									default:
										num = (short)2010841088;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_190;
										}
										continue;
									}
									break;
								}
								case 3:
									goto IL_2A9;
								case 5:
								{
									global::ASK.Core.AccessElement accessElement;
									((global::ASK.Core.AccessOperation)accessElement).AccessLevel = A_2;
									num = (short)1083637769;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::ASK.Core.AccessElement accessElement;
									((global::ASK.Core.AccessField)accessElement).AccessLevel = A_1;
									num = (short)744423428;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1522073608;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ASK.Core.AccessElement accessElement = enumerator2.Current;
									goto IL_206;
								}
								case 8:
									num = (short)217055235;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_192:
								num = (short)1590099975;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_190:
								goto IL_192;
								IL_206:
								num = (short)32178176;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_2A9:
							break;
						}
						finally
						{
							num = (short)1790181377;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2;
								switch (num3)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)1545601026;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2DE;
									}
									continue;
								case 2:
									goto IL_312;
								}
								IL_2DE:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)369098752;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_312:;
						}
						goto IL_315;
					case 2:
						goto IL_32C;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_97;
						}
						continue;
					case 4:
						goto IL_315;
					}
					IL_C0:
					num = (short)975437824;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_97:
					goto IL_C0;
					IL_315:
					num = (short)941555714;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_32C:;
			}
			finally
			{
				num = (short)373161985;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)336789506;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_35F;
						}
						continue;
					case 2:
						goto IL_392;
					}
					IL_35F:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1896611840;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_392:;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00009F08 File Offset: 0x00008108
		public void UnPackFeatures()
		{
			short num = (short)455540737;
			if (num != 0)
			{
			}
			num = (short)442040320;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator = this.accessNodes.GetEnumerator();
			try
			{
				num = (short)1187493062;
				short num3 = num;
				num = (short)1943844038;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_F4:
					num = (short)1945763841;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)921436160;
					if (num != 0)
					{
					}
					num = (short)927662083;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						if (!enumerator.MoveNext())
						{
							num = (short)196542468;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E6;
					case 2:
						goto IL_155;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_E4;
						}
						continue;
					case 4:
						num = (short)705626114;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_10A:
					num = (short)1467088896;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E4:
					goto IL_10A;
				}
				IL_E6:
				global::ASK.Core.AccessNode a_ = enumerator.Current;
				this.b(a_);
				goto IL_F4;
				IL_155:;
			}
			finally
			{
				num = (short)1089142785;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						enumerator.Dispose();
						num = (short)200736770;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_187;
						}
						continue;
					case 2:
						goto IL_1BC;
					}
					IL_187:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1372848128;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1BC:;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000A0E4 File Offset: 0x000082E4
		private void b(global::ASK.Core.AccessNode A_0)
		{
			global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator = A_0.Sections.GetEnumerator();
			short num;
			try
			{
				num = (short)849870851;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)2091974660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2 = enumerator.Current.Items.GetEnumerator();
						num = (short)1843200001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)163774466;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::ASK.Core.AccessElement accessElement;
									if (accessElement is global::ASK.Core.AccessField)
									{
										num = (short)1334050822;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)888340481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::ASK.Core.AccessElement accessElement;
									if (accessElement is global::ASK.Core.AccessOperation)
									{
										num = (short)372244485;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									num = (short)501780196;
									short num3 = num;
									num = (short)1599377124;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1B5;
									default:
										num = (short)144834560;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_13F;
										}
										continue;
									}
									break;
								}
								case 3:
									goto IL_26B;
								case 5:
								{
									global::ASK.Core.AccessElement accessElement;
									((global::ASK.Core.AccessOperation)accessElement).AccessLevel = this.b(accessElement.ID);
									num = (short)866779145;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::ASK.Core.AccessElement accessElement;
									((global::ASK.Core.AccessField)accessElement).AccessLevel = this.a((ushort)accessElement.ID);
									num = (short)330498052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1174667272;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ASK.Core.AccessElement accessElement = enumerator2.Current;
									goto IL_1B5;
								}
								case 8:
									num = (short)1708195843;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_141:
								num = (short)37355527;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13F:
								goto IL_141;
								IL_1B5:
								num = (short)332660736;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_26B:
							break;
						}
						finally
						{
							num = (short)2070347777;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2;
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)47448066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2A1;
									}
									continue;
								case 2:
									goto IL_2D8;
								}
								IL_2A1:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)411107328;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2D8:;
						}
						goto IL_2DB;
					case 2:
						goto IL_2F2;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_47;
						}
						continue;
					case 4:
						goto IL_2DB;
					}
					IL_70:
					num = (short)1394212864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47:
					goto IL_70;
					IL_2DB:
					num = (short)1524367362;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2F2:;
			}
			finally
			{
				num = (short)235470849;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1752760322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_325;
						}
						continue;
					case 2:
						goto IL_35A;
					}
					IL_325:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1957888000;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_35A:;
			}
			num = (short)2011693056;
			short num4 = num;
			num = (short)1128923137;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000A4D4 File Offset: 0x000086D4
		private void a(global::ASK.Core.AccessNode A_0)
		{
			short num = (short)1341194241;
			if (num != 0)
			{
			}
			num = (short)1548812288;
			short num2 = num;
			num = (short)888733696;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator = A_0.Sections.GetEnumerator();
				try
				{
					num = (short)1318518787;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2143223812;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2 = enumerator.Current.Items.GetEnumerator();
							num = (short)243466241;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							try
							{
								num = (short)2141257732;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 1:
									{
										global::ASK.Core.AccessOperation accessOperation;
										if (accessOperation.AccessLevel)
										{
											num = (short)636682250;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_469;
									case 3:
									{
										global::ASK.Core.AccessField accessField;
										this.a(accessField.ID);
										num = (short)751239182;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_192;
										}
										continue;
									case 5:
									{
										global::ASK.Core.AccessElement accessElement;
										if (accessElement is global::ASK.Core.AccessRangeField)
										{
											num = (short)94830598;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										num = (short)2139029516;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_451;
									case 8:
									{
										global::ASK.Core.AccessElement accessElement;
										global::ASK.Core.AccessField accessField = (global::ASK.Core.AccessField)accessElement;
										num = (short)660799503;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
									{
										global::ASK.Core.AccessElement accessElement;
										if (accessElement is global::ASK.Core.AccessField)
										{
											num = (short)561709064;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)623116305;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
									{
										global::ASK.Core.AccessOperation accessOperation;
										this.a(accessOperation.ID);
										num = (short)1120600080;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
									{
										global::ASK.Core.AccessElement accessElement;
										this.m_ranges[(ushort)accessElement.ID] = ((global::ASK.Core.AccessRangeField)accessElement).Ranges;
										num = (short)1545863168;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
									{
										global::ASK.Core.AccessElement accessElement;
										if (((global::ASK.Core.AccessRangeField)accessElement).Ranges.Count > 0)
										{
											num = (short)1309802507;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 13:
									{
										global::ASK.Core.AccessElement accessElement;
										global::ASK.Core.AccessOperation accessOperation = (global::ASK.Core.AccessOperation)accessElement;
										num = (short)2117861377;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 14:
										goto IL_2C7;
									case 15:
									{
										global::ASK.Core.AccessField accessField;
										if (accessField.AccessLevel == global::ASK.Interface.AccessLevelType.Editable)
										{
											num = (short)1726087171;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2C7;
									}
									case 17:
									{
										global::ASK.Core.AccessElement accessElement;
										if (accessElement is global::ASK.Core.AccessOperation)
										{
											num = (short)49610765;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 18:
									{
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1090191367;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::ASK.Core.AccessElement accessElement = enumerator2.Current;
										num = (short)1570111497;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_197:
									num = (short)851968018;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_192:
									goto IL_197;
									IL_2C7:
									num = (short)1589579550;
									short num4 = num;
									num = (short)1037766430;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										IL_451:
										num = (short)167706626;
										num3 = (int)((global::System.IntPtr)num);
										break;
									default:
										num = (short)2128609280;
										if (num != 0)
										{
										}
										num = (short)814809093;
										num3 = (int)((global::System.IntPtr)num);
										break;
									}
								}
								IL_469:
								break;
							}
							finally
							{
								num = (short)1582563330;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator2;
									switch (num3)
									{
									case 0:
										goto IL_4D6;
									case 1:
										enumerator2.Dispose();
										num = (short)82771968;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_4A0;
										}
										continue;
									}
									IL_4A0:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)220069889;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_4D6:;
							}
							goto IL_4D9;
						case 2:
							goto IL_4F2;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_B7;
							}
							continue;
						case 4:
							goto IL_4D9;
						}
						IL_E5:
						num = (short)1711210496;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B7:
						goto IL_E5;
						IL_4D9:
						num = (short)309526530;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_4F2:;
				}
				finally
				{
					num = (short)1552613378;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_55D;
						case 1:
							enumerator.Dispose();
							num = (short)1580007424;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_526;
							}
							continue;
						}
						IL_526:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2012020737;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_55D:;
				}
				return;
			}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000AA78 File Offset: 0x00008C78
		private void b()
		{
			short num = (short)791478273;
			if (num != 0)
			{
			}
			this.a();
			global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator = this.accessNodes.GetEnumerator();
			try
			{
				num = (short)1390608388;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1123287043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ASK.Core.AccessNode a_ = enumerator.Current;
						this.a(a_);
						num = (short)777388034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_E8;
					case 3:
						num = (short)905773057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_75;
						}
						continue;
					}
					IL_9D:
					num = (short)193724416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_75:
					goto IL_9D;
				}
				IL_E8:;
			}
			finally
			{
				num = (short)1138501660;
				short num3 = num;
				num = (short)441591836;
				int num2;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_16A:
					num = (short)1930625025;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)2044788736;
					if (num != 0)
					{
					}
					num = (short)1616642050;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_19A;
					case 1:
						enumerator.Dispose();
						num = (short)275775488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_167;
						}
						continue;
					}
					break;
				}
				IL_167:
				if (enumerator != null)
				{
					goto IL_16A;
				}
				IL_19A:;
			}
			num = (short)1987510272;
			short num4 = num;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000AC5C File Offset: 0x00008E5C
		public override string ToString()
		{
			short num = (short)1870713016;
			short num2 = num;
			num = (short)2102579384;
			switch (num2 == num)
			{
			}
			num = (short)1296367616;
			short num3 = num;
			num = (short)935985153;
			if (num != 0)
			{
			}
			num = (short)120586240;
			if (num != 0)
			{
			}
			return this.m_name;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000AD08 File Offset: 0x00008F08
		private bool b(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = this.a(this.m_FieldCodeArr, A_0);
					num2 = (short)1371275265;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)1258881025;
					if (num2 != 0)
					{
					}
					if (A_0 != 193)
					{
						num2 = (short)183631872;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)529842644;
					short num3 = num2;
					num2 = (short)1399046612;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1379926016;
						if (num2 != 0)
						{
						}
						result = this.m_bOTAPState;
						num2 = (short)1501036546;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
			}
			return result;
			IL_20:
			num2 = (short)40108032;
			short num4 = num2;
			result = true;
			num2 = (short)425066499;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000AE54 File Offset: 0x00009054
		private bool a(byte[] A_0, int A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_EE;
				case 1:
					return result;
				case 2:
					result = true;
					num2 = (short)1998651393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					int num3 = A_1 - 1;
					int num4 = num3 / 8;
					int num5 = num3 % 8;
					num2 = (short)41156612;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					int num4;
					int num5;
					if (((int)A_0[num4] & 1 << num5) > 0)
					{
						num2 = (short)1262616578;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AF;
				}
				case 5:
					if (A_1 <= 192)
					{
						num2 = (short)848429059;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_28;
			}
			IL_EE:
			num2 = (short)66650112;
			short num6 = num2;
			return result;
			IL_28:
			result = true;
			num2 = (short)516181844;
			short num7 = num2;
			num2 = (short)396119892;
			switch ((num7 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_AF:
				result = false;
				num2 = (short)798818305;
				if (num2 != 0)
				{
				}
				num2 = (short)1981612032;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)364969984;
				if (num2 != 0)
				{
				}
				num2 = (short)1360330757;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000AFE4 File Offset: 0x000091E4
		private global::ASK.Interface.AccessLevelType a(ushort A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::ASK.Interface.AccessLevelType result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = global::ASK.Interface.AccessLevelType.Editable;
					num2 = (short)269352961;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
				{
					if (this.b((int)A_0))
					{
						num2 = (short)1226637312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)333854991;
					short num3 = num2;
					num2 = (short)2029664527;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1510408193;
						if (num2 != 0)
						{
						}
						num2 = (short)1727791104;
						if (num2 != 0)
						{
						}
						result = global::ASK.Interface.AccessLevelType.ReadOnly;
						num2 = (short)54591490;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
			}
			return result;
			IL_20:
			num2 = (short)2090205184;
			short num4 = num2;
			result = global::ASK.Interface.AccessLevelType.Editable;
			num2 = (short)598212611;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000B120 File Offset: 0x00009320
		public bool IsRangeValueValid(global::ASK.Interface.AccessElementIDType id, int value)
		{
			short num = (short)2114650112;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1206583297;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary;
				bool result;
				for (;;)
				{
					IL_51:
					switch (num2)
					{
					case 0:
						if (dictionary.ContainsKey((ushort)id))
						{
							num = (short)1765081089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F4;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator = dictionary[(ushort)id].GetEnumerator();
						num = (short)1372782594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)2140536833;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								long? num7;
								long? num9;
								switch (num2)
								{
								case 0:
								{
									long? num3 = null;
									num = (short)593494025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_110;
									}
									continue;
								case 2:
								{
									uint? num4;
									if (num4 == null)
									{
										num = (short)1031340032;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2090139660;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_2F7;
								case 4:
									num = (short)548798470;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									result = true;
									num = (short)1542651912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									long num5 = (long)value;
									global::ASK.Core.AccessFieldValueRange accessFieldValueRange;
									uint? num4 = accessFieldValueRange.Maximum;
									long? num6;
									if (num4 == null)
									{
										long? num3 = null;
										num6 = num3;
									}
									else
									{
										num6 = new long?((long)((ulong)num4.GetValueOrDefault()));
									}
									num7 = num6;
									if (num5 <= num7.GetValueOrDefault() & num7 != null)
									{
										num = (short)1025507333;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)45023243;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ASK.Core.AccessFieldValueRange accessFieldValueRange = enumerator.Current;
									long num8 = (long)value;
									uint? num4 = accessFieldValueRange.Minimum;
									num = (short)47120386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_25D;
								case 9:
								{
									long? num3;
									num9 = num3;
									goto IL_15F;
								}
								case 10:
								{
									long num8;
									if (num8 >= num7.GetValueOrDefault() & num7 != null)
									{
										num = (short)770506756;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
									num = (short)751239171;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									uint? num4;
									num9 = new long?((long)((ulong)num4.GetValueOrDefault()));
									goto IL_15F;
								}
								}
								goto IL_110;
								IL_15F:
								num7 = num9;
								num = (short)140705802;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_295:
								num = (short)343343111;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_110:
								goto IL_295;
							}
							IL_25D:
							IL_2F7:
							return result;
						}
						finally
						{
							num = (short)1554534447;
							short num10 = num;
							num = (short)2127384623;
							switch ((num10 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_37D:
								num = (short)1325727745;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)826998784;
								if (num != 0)
								{
								}
								num = (short)2060320770;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3B1;
								case 1:
									enumerator.Dispose();
									num = (short)1658585088;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_37A;
									}
									continue;
								}
								break;
							}
							IL_37A:
							if (enumerator != null)
							{
								goto IL_37D;
							}
							IL_3B1:;
						}
						goto IL_3B4;
					case 3:
						goto IL_3B4;
					case 4:
						return result;
					case 5:
						if (dictionary != null)
						{
							num = (short)241762307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F4;
					}
					goto IL_70;
					IL_3B4:
					num = (short)1455161344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F4:
					num = (short)1547829248;
					short num11 = num;
					result = true;
					num = (short)831782916;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_70:
				result = false;
				dictionary = global::ASK.Core.AccessDataConverter.a(this.m_ranges);
				num = (short)397934597;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000B5B0 File Offset: 0x000097B0
		public bool IsAccessElementEnabled(global::ASK.Interface.AccessElementIDType id)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			byte[] a_;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)160301057;
					if (num2 != 0)
					{
					}
					result = this.a(a_, (int)id);
					num2 = (short)1258422273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
				{
					if (id != global::ASK.Interface.AccessElementIDType.OTAP_ELEMENT)
					{
						num2 = (short)1834942464;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1913571676;
					short num3 = num2;
					num2 = (short)537643356;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1778778112;
						if (num2 != 0)
						{
						}
						result = this.m_bOTAPState;
						num2 = (short)972619778;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
			}
			return result;
			IL_20:
			num2 = (short)1696792576;
			short num4 = num2;
			result = false;
			a_ = global::ASK.Core.AccessDataConverter.a(this.m_FieldCodeArr);
			num2 = (short)1127153667;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000B6F8 File Offset: 0x000098F8
		public bool IsWriteProtected()
		{
			short num = (short)1969881088;
			short num2 = num;
			num = (short)467861505;
			if (num != 0)
			{
			}
			num = (short)551157430;
			short num3 = num;
			num = (short)1702952630;
			switch (num3 == num)
			{
			}
			num = (short)1756102656;
			if (num != 0)
			{
			}
			return this.b(84);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000B7AC File Offset: 0x000099AC
		internal bool d()
		{
			short num = (short)1314062336;
			short num2 = num;
			num = (short)1260178457;
			short num3 = num;
			num = (short)2007813145;
			switch (num3 == num)
			{
			}
			num = (short)771031041;
			if (num != 0)
			{
			}
			num = (short)1965359104;
			if (num != 0)
			{
			}
			return this.b(83);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000B860 File Offset: 0x00009A60
		public global::ASK.Interface.KeyAccessLevelType GetKeyAccessLevelType()
		{
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			global::ASK.Interface.KeyAccessLevelType keyAccessLevelType;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return keyAccessLevelType;
				case 1:
					goto IL_DE;
				case 2:
					if (!this.b(84))
					{
						num2 = (short)457637904;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return keyAccessLevelType;
				case 3:
					goto IL_2C4;
				case 4:
					keyAccessLevelType = global::ASK.Interface.KeyAccessLevelType.LIMITED_ACC;
					num2 = (short)466092044;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					int num3;
					if (!this.b(num3))
					{
						num2 = (short)1023672331;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_260;
				}
				case 6:
					goto IL_2C4;
				case 7:
					if (keyAccessLevelType != global::ASK.Interface.KeyAccessLevelType.LIMITED_ACC)
					{
						num2 = (short)408748041;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return keyAccessLevelType;
				case 8:
					if (this.RangeCount != 0)
					{
						num2 = (short)1487339524;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1412628482;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1432092680;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_DE;
				case 11:
					keyAccessLevelType = global::ASK.Interface.KeyAccessLevelType.LIMITED_ACC;
					num2 = (short)805699585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					return keyAccessLevelType;
				case 13:
				{
					int num3;
					if (num3 >= 192)
					{
						num2 = (short)135856138;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1585053697;
					if (num2 != 0)
					{
					}
					num2 = (short)20119566;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 14:
				{
					int num3;
					if (num3 != 84)
					{
						num2 = (short)1972502543;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_260;
				}
				case 15:
					num2 = (short)636354565;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					keyAccessLevelType = global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP;
					num2 = (short)2032402432;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_54;
				IL_DE:
				num2 = (short)1290469383;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2C4:
				num2 = (short)376176653;
				num = (int)((global::System.IntPtr)num2);
			}
			return keyAccessLevelType;
			IL_54:
			num2 = (short)948223140;
			short num4 = num2;
			num2 = (short)1978383524;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_260:
				int num3;
				num3++;
				num2 = (short)2129657856;
				short num5 = num2;
				num2 = (short)706281478;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1422393344;
				if (num2 != 0)
				{
				}
				keyAccessLevelType = global::ASK.Interface.KeyAccessLevelType.UNLM_ACC;
				int num3 = 1;
				num2 = (short)1495072771;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000BB74 File Offset: 0x00009D74
		private void a()
		{
			short num = (short)287724363;
			short num2 = num;
			num = (short)1916162891;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_115:
				num = (short)1614872578;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)227213312;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				break;
			}
			int num4;
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					num = (short)264896513;
					if (num != 0)
					{
					}
					goto IL_AC;
				case 1:
					goto IL_DC;
				case 2:
					goto IL_AC;
				case 3:
					if (num4 >= 24)
					{
						num = (short)153026561;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_108;
				}
				goto IL_6B;
				IL_AC:
				num = (short)1034354691;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_DC:
			num = (short)1627455488;
			short num5 = num;
			return;
			IL_108:
			this.m_FieldCodeArr[num4] = 0;
			num4++;
			goto IL_115;
			IL_6B:
			num4 = 0;
			num = (short)221446144;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		private void a(int A_0)
		{
			short num = (short)760020994;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)966918144;
					short num3 = num;
					int num4 = A_0 - 1;
					byte b = (byte)(num4 / 8);
					byte b2 = (byte)(num4 % 8);
					byte[] fieldCodeArr = this.m_FieldCodeArr;
					byte b3 = b;
					fieldCodeArr[(int)b3] = fieldCodeArr[(int)b3] + (byte)(1 << (int)b2);
					num = (short)1324930047;
					short num5 = num;
					num = (short)1908003839;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1447755776;
						if (num != 0)
						{
						}
						num = (short)1523646465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				num = (short)1452802049;
				if (num != 0)
				{
				}
				if (A_0 == 193)
				{
					break;
				}
				num = (short)579862528;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000BDE8 File Offset: 0x00009FE8
		public string ToXMLString()
		{
			int a_ = 17;
			short num = (short)1379729408;
			switch (num)
			{
			default:
			{
				num = (short)194510849;
				int num2 = (int)((global::System.IntPtr)num);
				string text;
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)993656834;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_283;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1F8;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)62390276;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<ushort, global::ASK.Core.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
									global::ASK.Core.FieldValueRangeRecSet value = keyValuePair.Value;
									text += value.a(2);
									num = (short)1203372032;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1260650497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_232:
								num = (short)333119491;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F8:
								goto IL_232;
							}
							IL_283:
							goto IL_4FA;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_296;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_87;
						}
						continue;
					case 2:
						num = (short)1267138561;
						if (num != 0)
						{
						}
						goto IL_AD;
					case 3:
					{
						if (num3 >= 24)
						{
							num = (short)966983692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string str = string.Format(global::ASK.Core.StatusMsg.b("㙌罎歐⭒杔⩖", a_), this.m_FieldCodeArr[23 - num3]);
						text += str;
						num3++;
						num = (short)1673003013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_4BA;
					case 5:
						goto IL_4BA;
					case 6:
						goto IL_138;
					case 7:
					{
						num = (short)1228144640;
						short num4 = num;
						if (this.m_bOTAPState)
						{
							num = (short)30343181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text += global::ASK.Core.StatusMsg.b("⭌⹎㵐⁒ご", a_);
						num = (short)100794370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_AD;
					case 9:
						goto IL_296;
					case 10:
						for (;;)
						{
							global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator = this.m_ranges.GetEnumerator();
							num = (short)606796771;
							short num5 = num;
							num = (short)415824867;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_2FB;
							}
						}
						IL_2FB:
						num = (short)481886208;
						if (num != 0)
						{
						}
						num = (short)1821310976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.RangeCount > 0)
						{
							num = (short)300154890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FA;
					case 12:
					{
						text += global::ASK.Core.StatusMsg.b("浌獎繐ᕒ㱔㉖㕘㽚Ṝぞՠ٢孤浦", a_);
						text += global::ASK.Core.StatusMsg.b("䑌䙎浐ὒ㱔㩖じ⽚㡜㭞╠ɢᅤ٦㭨๪๬nͰᝲ㭴ɶᑸ䕺嵼", a_);
						string str = string.Format(global::ASK.Core.StatusMsg.b("㙌罎ⱐ", a_), this.Ranges.Count);
						text += str;
						text += global::ASK.Core.StatusMsg.b("浌獎繐ὒ㱔㩖じ⽚㡜㭞╠ɢᅤ٦㭨๪๬nͰᝲ㭴ɶᑸ䕺睼", a_);
						text += global::ASK.Core.StatusMsg.b("䑌䙎浐᱒Ŕᙖक़࡚⥜㹞ᕠᙢᙤ奦䥨", a_);
						num = (short)1259995143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						text += global::ASK.Core.StatusMsg.b("㥌㵎⑐㙒", a_);
						num = (short)16842760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_87:
					if (this.GetKeyAccessLevelType() == global::ASK.Interface.KeyAccessLevelType.LIMITED_ACC)
					{
						num = (short)1925054473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_138;
					IL_AD:
					text += global::ASK.Core.StatusMsg.b("浌獎繐᱒Ŕᙖक़࡚⥜㹞ᕠᙢᙤ奦捨", a_);
					num = (short)1002110987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_138:
					text = "";
					text += global::ASK.Core.StatusMsg.b("䑌獎͐㙒㙔㡖⭘㽚捜啞", a_);
					text += global::ASK.Core.StatusMsg.b("䑌䙎浐ቒ㙔㑖㱘⡚⹜ᅞ`๢d奦䥨", a_);
					text += this.m_name;
					text += global::ASK.Core.StatusMsg.b("浌獎繐ቒ㙔㑖㱘⡚⹜ᅞ`๢d奦捨", a_);
					text += global::ASK.Core.StatusMsg.b("䑌䙎浐ᕒ㱔㉖㕘㽚Ṝぞՠ٢孤䝦", a_);
					num3 = 0;
					num = (short)2122186756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_296:
					this.b();
					num = (short)1629880326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BA:
					num = (short)2052849667;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4FA:
				text += global::ASK.Core.StatusMsg.b("䑌獎繐Œご㑖㙘⥚㥜慞歠", a_);
				return text;
			}
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000C318 File Offset: 0x0000A518
		public AccessRecord(global::System.Xml.XmlNode node, bool bLimitRecordNameLength = true)
		{
			int a_ = 16;
			base..ctor();
			this.accessNodes = new global::ASK.Core.AccessRecordSetX<global::ASK.Core.AccessNode>(global::Motorola.CommonCPS.ResourceRepository.Resources.Codeplug_Field);
			this.m_ranges = new global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>();
			this.m_FieldCodeArr = new byte[24];
			this.a();
			this.m_id = -1;
			this.m_recType = global::ASK.Interface.FeatureCategoryType.TRUNKING;
			this.m_bInUseFlag = false;
			for (global::System.Xml.XmlNode xmlNode = node.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				string name = xmlNode.Name;
				string text = xmlNode.InnerText.Trim();
				if (global::ASK.Core.StatusMsg.b("ോⵍ㍏㝑❓╕ᙗ㭙ㅛ㭝", a_) == name)
				{
					if (string.IsNullOrEmpty(text))
					{
						throw new global::System.Exception(global::ASK.Core.StatusMsg.b("ോⵍ㍏㝑❓╕硗ᑙ㵛㍝՟䉡ݣݥ٧ѩͫᩭ偯ၱᅳ噵ᵷ᝹౻੽勵", a_));
					}
					if (text == global::Motorola.CommonCPS.ResourceRepository.Resources.Enter_Access_Level)
					{
						throw new global::System.Exception(global::ASK.Core.StatusMsg.b("ࡋ⭍㙏㍑⅓㩕ⱗ穙ᵛ㵝͟ݡᝣᕥ䡧⑩൫ͭᕯ剱ᩳ᥵౷婹ᵻችꒉ", a_));
					}
					if (bLimitRecordNameLength && text.Length > global::ASK.Core.Constants.MAX_LENGTH)
					{
						throw new global::System.Exception(global::ASK.Core.StatusMsg.b("ോⵍ㍏㝑❓╕硗ᑙ㵛㍝՟䉡ၣ॥ݧ䩩kŭṯᕱ婳", a_));
					}
					this.m_name = text;
				}
				if (global::ASK.Core.StatusMsg.b("͋ᩍᅏɑݓ≕㥗⹙⥛ⵝ", a_) == name)
				{
					if (text == global::ASK.Core.StatusMsg.b("㡋㱍╏㝑", a_))
					{
						this.m_bOTAPState = true;
					}
					else
					{
						if (!(text == global::ASK.Core.StatusMsg.b("⩋⽍㱏⅑ㅓ", a_)))
						{
							throw new global::System.Exception(global::ASK.Core.StatusMsg.b("Ջ⁍♏㍑㡓㽕㱗穙፛੝⅟㉡㝣ብ१ṩᥫᵭ", a_));
						}
						this.m_bOTAPState = false;
					}
				}
				if (global::ASK.Core.StatusMsg.b("ੋ❍㕏㹑こᕕ㝗㹙㥛", a_) == name)
				{
					string text2 = text;
					for (int i = 0; i < text2.Length; i++)
					{
						if (!global::ASK.Core.Global.a(text2[i]))
						{
							throw new global::System.Exception(global::ASK.Core.StatusMsg.b("Ջ⁍♏㍑㡓㽕㱗穙ᩛ㝝՟๡c╥ݧ๩५乭嵯剱ͳѵ᝷ᑹ᭻幽", a_));
						}
					}
					if (text2.Length / 2 != 24 && text2.Length / 2 != 12)
					{
						throw new global::System.Exception(global::ASK.Core.StatusMsg.b("Ջ⁍♏㍑㡓㽕㱗穙ᩛ㝝՟๡c╥ݧ๩५乭嵯剱᭳͵౷婹፻᡽ꁿ", a_));
					}
					bool flag = true;
					byte[] array = new byte[text2.Length / 2];
					byte[] array2 = new byte[24];
					for (int j = 0; j < text2.Length / 2; j++)
					{
						int num = text2.Length / 2 - 1 - j;
						byte b = byte.Parse(text2.Substring(2 * num, 2), global::System.Globalization.NumberStyles.HexNumber);
						array[j] = b;
						if (array[j] != 0)
						{
							flag = false;
						}
					}
					array.CopyTo(array2, 0);
					if (flag)
					{
						throw new global::System.Exception(global::ASK.Core.StatusMsg.b("Ջ⁍♏㍑㡓㽕㱗穙ᩛ㝝՟๡c╥ݧ๩५乭嵯剱ɳ᝵ᑷཹ᥻幽ꚅﮇ", a_));
					}
					global::System.Array.Copy(array2, 0, this.m_FieldCodeArr, 0, 24);
				}
				if (global::ASK.Core.StatusMsg.b("K❍㵏㭑⁓㍕㱗ṙ㵛⩝şちţեݧᡩ࡫", a_) == name)
				{
					global::ASK.Core.FieldValueRangeRecSet fieldValueRangeRecSet = new global::ASK.Core.FieldValueRangeRecSet(xmlNode);
					this.m_ranges.Add(fieldValueRangeRecSet.OwnerID, fieldValueRangeRecSet);
				}
			}
			this.c();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000C670 File Offset: 0x0000A870
		public AccessRecord(string name, string strFieldCode, bool bOTAP, global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> Range)
		{
			int a_ = 14;
			base..ctor();
			this.accessNodes = new global::ASK.Core.AccessRecordSetX<global::ASK.Core.AccessNode>(global::Motorola.CommonCPS.ResourceRepository.Resources.Codeplug_Field);
			this.m_ranges = new global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>();
			this.m_FieldCodeArr = new byte[24];
			this.a();
			this.m_id = -1;
			this.m_recType = global::ASK.Interface.FeatureCategoryType.TRUNKING;
			this.m_bInUseFlag = false;
			this.m_name = name;
			this.m_bOTAPState = bOTAP;
			for (int i = 0; i < strFieldCode.Length; i++)
			{
				if (!global::ASK.Core.Global.a(strFieldCode[i]))
				{
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("͉≋㡍ㅏ㹑㵓㉕硗᱙㕛㭝౟١❣॥౧ཀྵ䱫䍭偯ձٳ᥵ᙷᵹ屻ࡽ", a_));
				}
			}
			if (strFieldCode.Length / 2 != 24)
			{
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("͉≋㡍ㅏ㹑㵓㉕硗᱙㕛㭝౟١❣॥౧ཀྵ䱫䍭偯ᵱųɵ塷ᕹ᩻幽", a_));
			}
			bool flag = true;
			byte[] array = new byte[24];
			for (int j = 0; j < 24; j++)
			{
				array[j] = 0;
			}
			int num = 0;
			for (;;)
			{
				if (num >= 24)
				{
					if (flag)
					{
						break;
					}
					global::System.Array.Copy(array, 0, this.m_FieldCodeArr, 0, 24);
					if (Range == null)
					{
						goto IL_1CC;
					}
					using (global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator = Range.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::System.Collections.Generic.KeyValuePair<ushort, global::ASK.Core.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
							this.m_ranges.Add(keyValuePair.Key, keyValuePair.Value);
						}
						goto IL_1CC;
					}
				}
				int num2 = 23 - num;
				byte b = byte.Parse(strFieldCode.Substring(2 * num2, 2), global::System.Globalization.NumberStyles.HexNumber);
				array[num] = b;
				if (array[num] != 0)
				{
					flag = false;
				}
				num++;
			}
			throw new global::System.Exception(global::ASK.Core.StatusMsg.b("͉≋㡍ㅏ㹑㵓㉕硗᱙㕛㭝౟١❣॥౧ཀྵ䱫䍭偯ѱᕳ᩵൷ό屻ၽꒃﺉ", a_));
			IL_1CC:
			this.c();
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000C860 File Offset: 0x0000AA60
		public global::ASK.Core.AccessRecordSetX<global::ASK.Core.AccessNode> AccessNodes
		{
			get
			{
				short num = (short)1150418945;
				if (num != 0)
				{
				}
				num = (short)1406468096;
				short num2 = num;
				num = (short)571187816;
				short num3 = num;
				num = (short)1181852264;
				switch (num3 == num)
				{
				}
				num = (short)903544832;
				if (num != 0)
				{
				}
				return this.accessNodes;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000C910 File Offset: 0x0000AB10
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		public int PrimaryKey
		{
			get
			{
				short num = (short)1405870469;
				short num2 = num;
				num = (short)510255493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1232535552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1283129344;
				if (num != 0)
				{
				}
				num = (short)1564409857;
				if (num != 0)
				{
				}
				return this.primaryKey;
			}
			set
			{
				short num = (short)1691587939;
				short num2 = num;
				num = (short)384406883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169293312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)254738433;
				if (num != 0)
				{
				}
				num = (short)2056454144;
				if (num != 0)
				{
				}
				this.primaryKey = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000CA70 File Offset: 0x0000AC70
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000CB20 File Offset: 0x0000AD20
		public int ID
		{
			get
			{
				short num = (short)1036058625;
				if (num != 0)
				{
				}
				num = (short)1091960832;
				short num2 = num;
				num = (short)2103204751;
				short num3 = num;
				num = (short)411261839;
				switch (num3 == num)
				{
				}
				num = (short)600834048;
				if (num != 0)
				{
				}
				return this.m_id;
			}
			set
			{
				short num = (short)1664014283;
				short num2 = num;
				num = (short)455595979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2055405568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2040135681;
				if (num != 0)
				{
				}
				num = (short)1782579200;
				if (num != 0)
				{
				}
				this.m_id = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000CBD4 File Offset: 0x0000ADD4
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000CC84 File Offset: 0x0000AE84
		public string Name
		{
			get
			{
				short num = (short)827180025;
				short num2 = num;
				num = (short)1301922809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)925761536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)533135360;
				if (num != 0)
				{
				}
				num = (short)1188495361;
				if (num != 0)
				{
				}
				return this.m_name;
			}
			set
			{
				int a_ = 12;
				short num = (short)1716466253;
				short num2 = num;
				num = (short)1481716301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)949420032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2082013185;
				if (num != 0)
				{
				}
				num = (short)1719468032;
				if (num != 0)
				{
				}
				this.m_name = value;
				this.a(global::ASK.Core.StatusMsg.b("ه⭉⅋⭍", a_));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000CD54 File Offset: 0x0000AF54
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000CE08 File Offset: 0x0000B008
		public global::ASK.Interface.FeatureCategoryType RecordType
		{
			get
			{
				short num = (short)652964500;
				short num2 = num;
				num = (short)1912828564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)487456768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1438056448;
				if (num != 0)
				{
				}
				num = (short)655491073;
				if (num != 0)
				{
				}
				return this.m_recType;
			}
			set
			{
				short num = (short)1391014022;
				short num2 = num;
				num = (short)79769734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)387186688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1703477249;
				if (num != 0)
				{
				}
				num = (short)320798720;
				if (num != 0)
				{
				}
				this.m_recType = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000CF68 File Offset: 0x0000B168
		public byte[] FieldCode
		{
			get
			{
				short num = (short)1274524538;
				short num2 = num;
				num = (short)780252026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)994181120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1747976192;
				if (num != 0)
				{
				}
				num = (short)1804271617;
				if (num != 0)
				{
				}
				return this.m_FieldCodeArr;
			}
			set
			{
				short num = (short)831258625;
				if (num != 0)
				{
				}
				num = (short)298450944;
				short num2 = num;
				num = (short)1123785027;
				short num3 = num;
				num = (short)1439209795;
				switch (num3 == num)
				{
				}
				num = (short)1275461632;
				if (num != 0)
				{
				}
				this.m_FieldCodeArr = value;
				this.UnPackFeatures();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000D020 File Offset: 0x0000B220
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000D0D0 File Offset: 0x0000B2D0
		public bool OPTAPState
		{
			get
			{
				short num = (short)654035928;
				short num2 = num;
				num = (short)841403352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1632043008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1570373633;
				if (num != 0)
				{
				}
				num = (short)243859456;
				if (num != 0)
				{
				}
				return this.m_bOTAPState;
			}
			set
			{
				short num = (short)465875620;
				short num2 = num;
				num = (short)1106555556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1091305472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1655439361;
				if (num != 0)
				{
				}
				num = (short)16449536;
				if (num != 0)
				{
				}
				this.m_bOTAPState = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000D17C File Offset: 0x0000B37C
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000D230 File Offset: 0x0000B430
		internal bool InUse
		{
			get
			{
				short num = (short)1398529202;
				short num2 = num;
				num = (short)996465842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)962396160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2107244545;
				if (num != 0)
				{
				}
				num = (short)1910374400;
				if (num != 0)
				{
				}
				return this.m_bInUseFlag;
			}
			set
			{
				short num = (short)1389232129;
				if (num != 0)
				{
				}
				num = (short)386859008;
				short num2 = num;
				num = (short)1988759204;
				short num3 = num;
				num = (short)1273040548;
				switch (num3 == num)
				{
				}
				num = (short)420478976;
				if (num != 0)
				{
				}
				this.m_bInUseFlag = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000D390 File Offset: 0x0000B590
		public global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> Ranges
		{
			get
			{
				short num = (short)1891419790;
				short num2 = num;
				num = (short)1506133646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)844562432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1763442689;
				if (num != 0)
				{
				}
				num = (short)544735232;
				if (num != 0)
				{
				}
				return this.m_ranges;
			}
			set
			{
				int a_ = 0;
				short num = (short)1076428801;
				if (num != 0)
				{
				}
				num = (short)1524432896;
				short num2 = num;
				num = (short)30424619;
				short num3 = num;
				num = (short)1424047659;
				switch (num3 == num)
				{
				}
				num = (short)839516160;
				if (num != 0)
				{
				}
				this.m_ranges = value;
				this.a(global::ASK.Core.StatusMsg.b("渻弽⸿╁⅃㕅", a_));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000D45C File Offset: 0x0000B65C
		public ushort RangeCount
		{
			get
			{
				short num = (short)164262630;
				short num2 = num;
				num = (short)1026650854;
				ushort num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1337786368;
					short num3 = num;
					num = (short)1874788352;
					if (num != 0)
					{
					}
					num = (short)721944577;
					if (num != 0)
					{
					}
					num = (short)940179456;
					switch (num)
					{
					default:
						num4 = 0;
						using (global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator = this.m_ranges.GetEnumerator())
						{
							num = (short)790822914;
							int num5 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num5)
								{
								case 1:
									goto IL_18A;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_103;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1600323588;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<ushort, global::ASK.Core.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
									global::ASK.Core.FieldValueRangeRecSet value = keyValuePair.Value;
									num4 += (ushort)value.Count;
									num = (short)584122368;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)582352897;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_137:
								num = (short)1732706307;
								num5 = (int)((global::System.IntPtr)num);
								continue;
								IL_103:
								goto IL_137;
							}
							IL_18A:;
						}
						break;
					}
					break;
				}
				}
				return num4;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000D614 File Offset: 0x0000B814
		internal global::ASK.Core.AccessNode c(int A_0)
		{
			short num = (short)381812737;
			if (num != 0)
			{
			}
			num = (short)1477181440;
			short num2 = num;
			num = (short)638102257;
			short num3 = num;
			num = (short)96971505;
			global::ASK.Core.AccessNode result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2005336064;
				if (num != 0)
				{
				}
				result = null;
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator = this.accessNodes.GetEnumerator();
				try
				{
					num = (short)1189347330;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::ASK.Core.AccessNode accessNode;
							result = accessNode;
							num = (short)285278211;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)834076678;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASK.Core.AccessNode accessNode = enumerator.Current;
							num = (short)1479933956;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_EC;
							}
							continue;
						case 3:
							goto IL_178;
						case 4:
						{
							global::ASK.Core.AccessNode accessNode;
							if (accessNode.ID == (global::ASK.Core.AccessNodeIDType)A_0)
							{
								num = (short)1480982528;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_195;
						case 6:
							num = (short)1671495685;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_129:
						num = (short)1410924545;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_EC:
						goto IL_129;
					}
					IL_178:
					IL_195:;
				}
				finally
				{
					num = (short)610729984;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1C7;
							}
							continue;
						case 1:
							goto IL_1FB;
						case 2:
							enumerator.Dispose();
							num = (short)1253703681;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1C7:
						if (enumerator == null)
						{
							break;
						}
						num = (short)228392962;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1FB:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000D830 File Offset: 0x0000BA30
		public bool IsEqual(global::ASK.Core.AccessRecord inRec)
		{
			short num = (short)380895232;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B3;
				}
				bool flag;
				int num3;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary;
						if (dictionary == null)
						{
							num = (short)458948617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4;
					}
					case 1:
						num = (short)596639775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						flag = false;
						num = (short)626589713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1373700114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)695992327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_41C;
					case 6:
						goto IL_5AD;
					case 7:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary;
						if (dictionary.Count == 0)
						{
							num = (short)83230725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_630;
					}
					case 8:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary2;
						if (dictionary2 != null)
						{
							num = (short)130678803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F2;
					}
					case 9:
						num = (short)1760428060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary2;
						if (dictionary2 == null)
						{
							num = (short)831651841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41C;
					}
					case 11:
						if (flag)
						{
							num = (short)1719468062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F2;
					case 12:
						flag = false;
						num = (short)74579988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1067384857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_559;
					case 15:
					{
						if (this.m_bOTAPState != inRec.m_bOTAPState)
						{
							num = (short)364511259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary2 = this.a(this);
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary = this.a(inRec);
						num = (short)1539637258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (num3 >= 24)
						{
							num = (short)1911554080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)124059671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_1A3;
					case 18:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary;
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary2;
						if (dictionary2.Count != dictionary.Count)
						{
							num = (short)762576898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator = dictionary2.GetEnumerator();
						num = (short)2061828120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						num = (short)864944157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_149;
					case 21:
						goto IL_630;
					case 22:
						goto IL_559;
					case 23:
						if (this.m_FieldCodeArr[num3] != inRec.m_FieldCodeArr[num3])
						{
							num = (short)837484556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)199819286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						try
						{
							num = (short)325582849;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag = false;
									num = (short)1108279301;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_27F;
									}
									continue;
								case 2:
									goto IL_409;
								case 3:
									goto IL_3EC;
								case 4:
									num = (short)307101698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_3CD;
								case 6:
								{
									global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary;
									global::System.Collections.Generic.KeyValuePair<ushort, global::ASK.Core.FieldValueRangeRecSet> keyValuePair;
									if (dictionary.ContainsKey(keyValuePair.Key))
									{
										num = (short)937951241;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = false;
									num = (short)849936387;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)946798596;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<ushort, global::ASK.Core.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
									global::ASK.Core.FieldValueRangeRecSet value = keyValuePair.Value;
									num = (short)2135949318;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::ASK.Core.FieldValueRangeRecSet value;
									global::ASK.Core.FieldValueRangeRecSet a_;
									if (!value.a(a_))
									{
										num = (short)613651976;
										short num4 = num;
										num = (short)702649864;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											continue;
										default:
											num = (short)282198016;
											if (num != 0)
											{
											}
											num = (short)140967936;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								case 9:
								{
									global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary;
									global::System.Collections.Generic.KeyValuePair<ushort, global::ASK.Core.FieldValueRangeRecSet> keyValuePair;
									global::ASK.Core.FieldValueRangeRecSet a_ = dictionary[keyValuePair.Key];
									num = (short)1232666632;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_374:
								num = (short)1606352903;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_27F:
								goto IL_374;
							}
							IL_3CD:
							IL_3EC:
							IL_409:
							goto IL_6F2;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_41C;
					case 25:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary2;
						if (dictionary2.Count != 0)
						{
							num = (short)642318357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4;
					}
					case 26:
						goto IL_D4;
					case 27:
						flag = false;
						num = (short)1108738054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary2;
						if (dictionary2 != null)
						{
							num = (short)774635533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4;
					}
					case 29:
					{
						num = (short)800849920;
						short num5 = num;
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary;
						if (dictionary != null)
						{
							num = (short)1508376579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F2;
					}
					case 30:
						num = (short)1356857359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary;
						if (dictionary != null)
						{
							num = (short)754253828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41C;
					}
					case 32:
						goto IL_149;
					}
					goto IL_B3;
					IL_D4:
					num = (short)389283848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_149:
					num = (short)1592983563;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41C:
					num = (short)444006400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_559:
					num = (short)1351745552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_630:
					flag = false;
					num = (short)976158746;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A3:
				IL_5AD:
				IL_6F2:
				num = (short)815661057;
				if (num != 0)
				{
				}
				return flag;
				IL_B3:
				flag = true;
				num3 = 0;
				num = (short)1107361806;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000DF74 File Offset: 0x0000C174
		private global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> a(global::ASK.Core.AccessRecord A_0)
		{
			short num = (short)1388511232;
			short num2 = num;
			num = (short)649789440;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary = new global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>();
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator = A_0.AccessNodes.GetEnumerator();
				try
				{
					num = (short)2096168963;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_89B;
						case 1:
							try
							{
								num = (short)1066598403;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator4;
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator5;
									switch (num3)
									{
									case 0:
										try
										{
											num = (short)1996619776;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::ASK.Core.AccessElement accessElement;
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_206;
													}
													continue;
												case 1:
													num = (short)1193607176;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													if (accessElement is global::ASK.Core.AccessRangeField)
													{
														num = (short)730988545;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 3:
													goto IL_721;
												case 5:
													goto IL_708;
												case 6:
													num = (short)80216073;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 7:
												{
													global::ASK.Core.FieldValueRangeRecSet fieldValueRangeRecSet;
													try
													{
														num = (short)933625860;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																goto IL_6F5;
															case 1:
															{
																global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>>.Enumerator enumerator2;
																if (!enumerator2.MoveNext())
																{
																	num = (short)1739653123;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::System.Collections.Generic.List<uint> list = enumerator2.Current;
																fieldValueRangeRecSet.Add(new global::ASK.Core.AccessFieldValueRange
																{
																	Minimum = new uint?(list[0]),
																	Maximum = new uint?(list[1]),
																	FieldID = (int)((global::ASK.Core.AccessRangeField)accessElement).Ranges.OwnerID
																});
																num = (short)720437250;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 3:
																num = (short)1449000960;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 4:
																switch (0)
																{
																case 0:
																	goto IL_626;
																}
																continue;
															}
															IL_69C:
															num = (short)1318846465;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_626:
															goto IL_69C;
														}
														IL_6F5:
														goto IL_51F;
													}
													finally
													{
														global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>>.Enumerator enumerator2;
														((global::System.IDisposable)enumerator2).Dispose();
													}
													goto IL_708;
													IL_51F:
													dictionary.Add(((global::ASK.Core.AccessRangeField)accessElement).Ranges.OwnerID, fieldValueRangeRecSet);
													num = (short)820641796;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 8:
													if (((global::ASK.Core.AccessRangeField)accessElement).AccessLevel == global::ASK.Interface.AccessLevelType.Editable)
													{
														num = (short)2059010054;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 9:
													if (((global::ASK.Core.AccessRangeField)accessElement).Ranges.Count > 0)
													{
														num = (short)366018572;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 10:
												{
													global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>> list3;
													try
													{
														num = (short)1187053575;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
															{
																uint? num4;
																if (num4 != null)
																{
																	num = (short)1752498179;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 1:
															{
																global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator3;
																if (!enumerator3.MoveNext())
																{
																	num = (short)1899036676;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::ASK.Core.AccessFieldValueRange accessFieldValueRange = enumerator3.Current;
																uint? num4 = accessFieldValueRange.Maximum;
																num = (short)1297350661;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 3:
															{
																global::System.Collections.Generic.List<uint> list2 = new global::System.Collections.Generic.List<uint>();
																global::ASK.Core.AccessFieldValueRange accessFieldValueRange;
																uint? num4 = accessFieldValueRange.Minimum;
																uint value = num4.Value;
																list2.Add(value);
																num4 = accessFieldValueRange.Maximum;
																value = num4.Value;
																list2.Add(value);
																list3.Add(list2);
																num = (short)1854210050;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 4:
																num = (short)2033844230;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 5:
															{
																uint? num4;
																if (num4 != null)
																{
																	num = (short)1355546632;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 6:
																goto IL_3E1;
															case 7:
																switch (0)
																{
																case 0:
																	goto IL_291;
																}
																continue;
															case 8:
															{
																global::ASK.Core.AccessFieldValueRange accessFieldValueRange;
																uint? num4 = accessFieldValueRange.Minimum;
																num = (short)949747712;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															}
															IL_32A:
															num = (short)1112932353;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_291:
															goto IL_32A;
														}
														IL_3E1:
														goto IL_555;
													}
													finally
													{
														num = (short)1801715713;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator3;
															switch (num3)
															{
															case 0:
																goto IL_450;
															case 1:
																switch (0)
																{
																case 0:
																	goto IL_418;
																}
																continue;
															case 2:
																enumerator3.Dispose();
																num = (short)1824587776;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_418:
															if (enumerator3 == null)
															{
																break;
															}
															num = (short)171835394;
															num3 = (int)((global::System.IntPtr)num);
														}
														IL_450:;
													}
													goto IL_453;
													IL_555:
													list3.Sort(new global::System.Comparison<global::System.Collections.Generic.List<uint>>(global::ASK.Core.AccessRecord.CompareListsByMin));
													global::ASK.Core.FieldValueRangeRecSet fieldValueRangeRecSet = new global::ASK.Core.FieldValueRangeRecSet(((global::ASK.Core.AccessRangeField)accessElement).Ranges.OwnerID);
													global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>>.Enumerator enumerator2 = list3.GetEnumerator();
													num = (short)2086928391;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 11:
													if (!enumerator4.MoveNext())
													{
														num = (short)322043909;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_453;
												case 12:
												{
													global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>> list3 = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>>();
													global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator3 = ((global::ASK.Core.AccessRangeField)accessElement).Ranges.GetEnumerator();
													num = (short)1221525514;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_20B:
												num = (short)1256718347;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_206:
												goto IL_20B;
												IL_453:
												accessElement = enumerator4.Current;
												num = (short)778043394;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_708:
												num = (short)1918697475;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_721:
											break;
										}
										finally
										{
											num = (short)769851394;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													goto IL_7E0;
												case 1:
												{
													enumerator4.Dispose();
													num = (short)691361928;
													short num5 = num;
													num = (short)2078955656;
													switch ((num5 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														continue;
													default:
														num = (short)1579417600;
														if (num != 0)
														{
														}
														num = (short)1927872512;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 2:
													switch (0)
													{
													case 0:
														goto IL_758;
													}
													continue;
												}
												IL_758:
												if (enumerator4 == null)
												{
													break;
												}
												num = (short)818610177;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_7E0:;
										}
										goto IL_7E3;
									case 1:
										if (!enumerator5.MoveNext())
										{
											num = (short)211025924;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_7E3;
									case 2:
										goto IL_82A;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_16B;
										}
										continue;
									case 4:
										num = (short)1112604674;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_170:
									num = (short)1281884161;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_16B:
									goto IL_170;
									IL_7E3:
									enumerator4 = enumerator5.Current.Items.GetEnumerator();
									num = (short)310378496;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_82A:
								goto IL_ED;
							}
							finally
							{
								num = (short)104726530;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator5;
									switch (num3)
									{
									case 0:
										goto IL_898;
									case 1:
										enumerator5.Dispose();
										num = (short)979435520;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_861;
										}
										continue;
									}
									IL_861:
									if (enumerator5 == null)
									{
										break;
									}
									num = (short)1288765441;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_898:;
							}
							goto IL_89B;
						case 2:
							goto IL_8B4;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_98;
							}
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1420951552;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator5 = enumerator.Current.Sections.GetEnumerator();
							num = (short)478674945;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_98;
						IL_ED:
						num = (short)1495465988;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_98:
						num = (short)116457473;
						if (num != 0)
						{
						}
						goto IL_ED;
						IL_89B:
						num = (short)1511522306;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_8B4:;
				}
				finally
				{
					num = (short)1539440642;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_91D;
						case 1:
							enumerator.Dispose();
							num = (short)535887872;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_8E8;
							}
							continue;
						}
						IL_8E8:
						if (enumerator == null)
						{
							break;
						}
						num = (short)59768833;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_91D:;
				}
				return dictionary;
			}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000E920 File Offset: 0x0000CB20
		public static global::ASK.Core.AccessRecord Union(global::ASK.Core.AccessRecord rec1, global::ASK.Core.AccessRecord rec2)
		{
			int a_ = 7;
			short num = (short)453771264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_FC;
				}
				global::ASK.Core.AccessRecord accessRecord;
				for (;;)
				{
					IL_31:
					int num3;
					int num6;
					switch (num2)
					{
					case 0:
						if (rec2.GetKeyAccessLevelType() == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
						{
							num = (short)560791587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F86;
					case 1:
						if (accessRecord.RangeCount == 0)
						{
							num = (short)1127940114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)542179357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (rec1.m_radioType == rec2.m_radioType)
						{
							num = (short)445841449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D10;
					case 3:
						num = (short)753598475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (rec1.GetKeyAccessLevelType() == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
						{
							num = (short)1967259692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1537867776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (num3 >= 8)
						{
							num = (short)1765736460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)700252181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (rec2.m_bOTAPState)
						{
							num = (short)1074724895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_119E;
					case 7:
						num3 = 0;
						num = (short)155254800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (accessRecord.Ranges == null)
						{
							num = (short)1076035584;
							short num4 = num;
							num = (short)1037172776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1156120577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (rec1.GetKeyAccessLevelType() == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
						{
							num = (short)359661571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D87;
					case 10:
						if (rec1.GetKeyAccessLevelType() == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
						{
							num = (short)1301872688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)623116333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (rec2.GetKeyAccessLevelType() != global::ASK.Interface.KeyAccessLevelType.LIMITED_ACC)
						{
							num = (short)918224910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F86;
					case 12:
						goto IL_C69;
					case 13:
						if (rec2.RangeCount > 0)
						{
							num = (short)711655441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return accessRecord;
					case 14:
						goto IL_D87;
					case 15:
						goto IL_119E;
					case 16:
						goto IL_10D2;
					case 17:
						num = (short)2026635272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator = rec2.Ranges.GetEnumerator();
						num = (short)2078670886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_10D2;
					case 20:
						goto IL_C8B;
					case 21:
					{
						int num5 = (((int)accessRecord.m_FieldCodeArr[num6] & 1 << num3) != 0) ? 1 : 0;
						bool flag = ((int)rec2.m_FieldCodeArr[num6] & 1 << num3) != 0;
						if (num5 == 0 && flag)
						{
							num = (short)1540161583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_113B;
					}
					case 22:
						if (rec2.GetKeyAccessLevelType() != global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
						{
							num = (short)1126301716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F86;
					case 23:
						goto IL_1199;
					case 24:
						num = (short)299171862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_188;
					case 26:
						num = (short)1097924614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)696188941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator = rec2.Ranges.GetEnumerator();
						num = (short)521338919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						if (accessRecord.RangeCount > 0)
						{
							num = (short)163577884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return accessRecord;
					case 30:
						goto IL_188;
					case 31:
						accessRecord.m_bOTAPState = rec2.m_bOTAPState;
						num = (short)1716584463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)504037377;
						if (num != 0)
						{
						}
						num = (short)349503525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (num6 >= 24)
						{
							num = (short)1964048416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1784873006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						return accessRecord;
					case 35:
						goto IL_E47;
					case 36:
						if (rec2.Ranges != null)
						{
							num = (short)89849883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return accessRecord;
					case 37:
						if (!accessRecord.m_bOTAPState)
						{
							num = (short)2060910618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_119E;
					case 38:
						try
						{
							num = (short)1505689600;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator;
								global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator2;
								global::ASK.Core.FieldValueRangeRecSet fieldValueRangeRecSet;
								global::System.Collections.Generic.KeyValuePair<ushort, global::ASK.Core.FieldValueRangeRecSet> keyValuePair;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_245;
									}
									continue;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)2060451843;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3F6;
								case 2:
									goto IL_4C6;
								case 3:
									num = (short)578813954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									try
									{
										num = (short)1689059329;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_381;
											case 1:
											{
												num = (short)2139307751;
												short num7 = num;
												num = (short)1677737703;
												switch ((num7 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													break;
												default:
													num = (short)1864433664;
													if (num != 0)
													{
													}
													switch (0)
													{
													case 0:
														goto IL_2CF;
													}
													continue;
												}
												break;
											}
											case 2:
												num = (short)1154351104;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)443219970;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::ASK.Core.AccessFieldValueRange accessFieldValueRange = enumerator2.Current;
												fieldValueRangeRecSet.Add(new global::ASK.Core.AccessFieldValueRange
												{
													FieldID = accessFieldValueRange.FieldID,
													Minimum = accessFieldValueRange.Minimum,
													Maximum = accessFieldValueRange.Maximum
												});
												num = (short)1949696004;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_2D1:
											num = (short)135593987;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_2CF:
											goto IL_2D1;
										}
										IL_381:
										goto IL_47C;
									}
									finally
									{
										num = (short)160759809;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)1824915458;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_3BA;
												}
												continue;
											case 2:
												goto IL_3F3;
											}
											IL_3BA:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1350565888;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3F3:;
									}
									goto IL_3F6;
									IL_47C:
									accessRecord.Ranges.Add(keyValuePair.Key, fieldValueRangeRecSet);
									num = (short)744161285;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_245;
								IL_3F6:
								keyValuePair = enumerator.Current;
								fieldValueRangeRecSet = new global::ASK.Core.FieldValueRangeRecSet(keyValuePair.Value.OwnerID);
								enumerator2 = keyValuePair.Value.GetEnumerator();
								num = (short)305594372;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_43D:
								num = (short)611254273;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_245:
								goto IL_43D;
							}
							IL_4C6:
							return accessRecord;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_4D9;
					case 39:
						try
						{
							num = (short)951648257;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator;
								global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator2;
								global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>>.Enumerator enumerator3;
								global::System.Collections.Generic.KeyValuePair<ushort, global::ASK.Core.FieldValueRangeRecSet> keyValuePair2;
								global::ASK.Core.FieldValueRangeRecSet fieldValueRangeRecSet2;
								global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>> list3;
								switch (num2)
								{
								case 0:
									goto IL_995;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5D2;
									}
									continue;
								case 2:
									try
									{
										num = (short)439222273;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_715;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_66A;
												}
												continue;
											case 2:
											{
												if (!enumerator3.MoveNext())
												{
													num = (short)1042415620;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.List<uint> list = enumerator3.Current;
												global::ASK.Core.AccessFieldValueRange item = new global::ASK.Core.AccessFieldValueRange((int)keyValuePair2.Key, new uint?(list[0]), new uint?(list[1]));
												fieldValueRangeRecSet2.Add(item);
												num = (short)1013514243;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												num = (short)435224576;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_6BE:
											num = (short)547553282;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_66A:
											goto IL_6BE;
										}
										IL_715:
										break;
									}
									finally
									{
										((global::System.IDisposable)enumerator3).Dispose();
									}
									goto IL_728;
								case 3:
									if (accessRecord.Ranges.ContainsKey(keyValuePair2.Key))
									{
										num = (short)480247812;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_728;
								case 5:
									num = (short)905445382;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_C56;
								case 7:
									try
									{
										num = (short)1226375169;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 1:
												switch (0)
												{
												case 0:
													goto IL_7D9;
												}
												continue;
											case 2:
											{
												uint? num8;
												if (num8 != null)
												{
													num = (short)2126184455;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)2078736388;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::ASK.Core.AccessFieldValueRange accessFieldValueRange2 = enumerator2.Current;
												uint? num8 = accessFieldValueRange2.Maximum;
												num = (short)348717064;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												num = (short)1315635206;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
											{
												global::ASK.Core.AccessFieldValueRange accessFieldValueRange2;
												uint? num8 = accessFieldValueRange2.Minimum;
												num = (short)2126970882;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												goto IL_923;
											case 7:
											{
												global::System.Collections.Generic.List<uint> list2 = new global::System.Collections.Generic.List<uint>();
												global::ASK.Core.AccessFieldValueRange accessFieldValueRange2;
												uint? num8 = accessFieldValueRange2.Minimum;
												uint value = num8.Value;
												list2.Add(value);
												num8 = accessFieldValueRange2.Maximum;
												value = num8.Value;
												list2.Add(value);
												list3.Add(list2);
												num = (short)475267072;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
											{
												uint? num8;
												if (num8 != null)
												{
													num = (short)1715863557;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_87D:
											num = (short)2004746243;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_7D9:
											goto IL_87D;
										}
										IL_923:
										goto IL_762;
									}
									finally
									{
										num = (short)1647116289;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)209059842;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_95A;
												}
												continue;
											case 2:
												goto IL_992;
											}
											IL_95A:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)527499264;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_992:;
									}
									goto Block_31;
									IL_762:
									enumerator2 = keyValuePair2.Value.GetEnumerator();
									num = (short)399966208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (!enumerator.MoveNext())
									{
										num = (short)1787953157;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BA1;
								}
								goto IL_5D2;
								Block_31:
								try
								{
									IL_995:
									num = (short)1068171265;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 1:
											switch (0)
											{
											case 0:
												goto IL_9E0;
											}
											continue;
										case 2:
										{
											uint? num8;
											if (num8 != null)
											{
												num = (short)1767309319;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 3:
										{
											if (!enumerator2.MoveNext())
											{
												num = (short)440795140;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::ASK.Core.AccessFieldValueRange accessFieldValueRange3 = enumerator2.Current;
											uint? num8 = accessFieldValueRange3.Maximum;
											num = (short)227672072;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
											num = (short)1972568070;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
										{
											global::ASK.Core.AccessFieldValueRange accessFieldValueRange3;
											uint? num8 = accessFieldValueRange3.Minimum;
											num = (short)1529544706;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 6:
											goto IL_B2D;
										case 7:
										{
											global::System.Collections.Generic.List<uint> list4 = new global::System.Collections.Generic.List<uint>();
											global::ASK.Core.AccessFieldValueRange accessFieldValueRange3;
											uint? num8 = accessFieldValueRange3.Minimum;
											uint value2 = num8.Value;
											list4.Add(value2);
											num8 = accessFieldValueRange3.Maximum;
											value2 = num8.Value;
											list4.Add(value2);
											list3.Add(list4);
											num = (short)1440284672;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 8:
										{
											uint? num8;
											if (num8 != null)
											{
												num = (short)1726218245;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										IL_A85:
										num = (short)1926758403;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_9E0:
										goto IL_A85;
									}
									IL_B2D:
									goto IL_5D7;
								}
								finally
								{
									num = (short)912719873;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											enumerator2.Dispose();
											num = (short)407109634;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_B64;
											}
											continue;
										case 2:
											goto IL_B9E;
										}
										IL_B64:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)942342144;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_B9E:;
								}
								goto IL_BA1;
								IL_5D7:
								list3.Sort(new global::System.Comparison<global::System.Collections.Generic.List<uint>>(global::ASK.Core.AccessRecord.CompareListsByMin));
								global::ASK.Core.AccessRecord.a(ref list3);
								fieldValueRangeRecSet2 = accessRecord.Ranges[keyValuePair2.Key];
								fieldValueRangeRecSet2.Clear();
								enumerator3 = list3.GetEnumerator();
								num = (short)738918402;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_728:
								list3 = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>>();
								enumerator2 = accessRecord.Ranges[keyValuePair2.Key].GetEnumerator();
								num = (short)78184455;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BA1:
								keyValuePair2 = enumerator.Current;
								global::ASK.Core.FieldValueRangeRecSet value3 = keyValuePair2.Value;
								num = (short)1188167683;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BFE:
								num = (short)1198260232;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5D2:
								goto IL_BFE;
							}
							IL_C56:
							return accessRecord;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_C69;
					case 40:
						accessRecord.Ranges = new global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>();
						num = (short)799146018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)1378811914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (rec1.GetKeyAccessLevelType() == global::ASK.Interface.KeyAccessLevelType.LIMITED_ACC)
						{
							num = (short)2066350104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C8B;
					case 43:
						goto IL_113B;
					case 44:
						goto IL_CC8;
					case 45:
						if (rec2.GetKeyAccessLevelType() == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
						{
							num = (short)506527767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D9;
					case 46:
						if (accessRecord.m_FieldCodeArr[num6] != rec2.m_FieldCodeArr[num6])
						{
							num = (short)396230663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C69;
					case 47:
					{
						byte[] fieldCodeArr = accessRecord.m_FieldCodeArr;
						int num9 = num6;
						fieldCodeArr[num9] |= (byte)(1 << num3);
						num = (short)741474347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						goto IL_D82;
					}
					goto IL_FC;
					IL_188:
					num = (short)356319265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D9:
					num = (short)1899888649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C69:
					num6++;
					num = (short)121765913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C8B:
					num = (short)985661444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D87:
					num = (short)1555955754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F86:
					accessRecord = new global::ASK.Core.AccessRecord(rec1);
					accessRecord.Name = rec1.Name + global::ASK.Core.StatusMsg.b("捂ᩄ杆", a_) + rec2.Name;
					num6 = 0;
					num = (short)1226899486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10D2:
					num = (short)1604321285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_113B:
					num3++;
					num = (short)423231507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_119E:
					num = (short)1200291876;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CC8:
				return new global::ASK.Core.AccessRecord(rec1);
				IL_D10:
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("ੂ⭄⑆♈♊㵌⹎═㩒㝔㭖㱘筚ᱜ㱞ɠ٢ᙤᑦ䥨㥪࡬౮ṰŲᅴѶ塸", a_));
				IL_D82:
				return new global::ASK.Core.AccessRecord(rec1);
				IL_E47:
				return new global::ASK.Core.AccessRecord(rec2);
				IL_1199:
				return new global::ASK.Core.AccessRecord(rec2);
				IL_FC:
				accessRecord = null;
				num = (short)1676541954;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000FBCC File Offset: 0x0000DDCC
		public static int CompareListsByMin(global::System.Collections.Generic.List<uint> x, global::System.Collections.Generic.List<uint> y)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			int result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = 0;
					num2 = (short)1238237190;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					if (y == null)
					{
						num2 = (short)1827209216;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = -1;
					num2 = (short)950468609;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)612106242;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					result = 1;
					num2 = (short)840761351;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)1316487169;
					if (num2 != 0)
					{
					}
					num2 = (short)1766152819;
					short num3 = num2;
					num2 = (short)1504270963;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1874788352;
						if (num2 != 0)
						{
						}
						if (y != null)
						{
							result = x[0].CompareTo(y[0]);
							num2 = (short)1598160904;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					num2 = (short)1789460484;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					return result;
				case 7:
					return result;
				case 8:
					return result;
				case 9:
				{
					if (x == null)
					{
						num2 = (short)1139671043;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1381761024;
					short num4 = num2;
					num2 = (short)1936785413;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_38;
			}
			return result;
			IL_38:
			result = 0;
			num2 = (short)907345929;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000FDDC File Offset: 0x0000DFDC
		private static void a(ref global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>> A_0)
		{
			short num = (short)1085865984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				int num3;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1238630403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (num3 >= A_0.Count)
						{
							num = (short)214958084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<uint> list = A_0[num3];
						num = (short)1843134474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_202;
					case 3:
					{
						num = (short)1839050608;
						short num4 = num;
						num = (short)1427484528;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_206;
						default:
						{
							num = (short)1996029952;
							if (num != 0)
							{
							}
							ulong num5;
							ulong num6;
							if (num5 >= num6 + 1UL)
							{
								num = (short)1382285318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_0.RemoveAt(num3);
							num3--;
							num = (short)819658754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						return;
					case 5:
					{
						num = (short)1228734464;
						short num7 = num;
						goto IL_17B;
					}
					case 6:
					{
						ulong num5;
						A_0[num3 - 1][1] = (uint)num5;
						A_0.RemoveAt(num3);
						num3--;
						num = (short)1862074377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						num = (short)1079377921;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<uint> list;
						ulong num8 = (ulong)list[0];
						ulong num5 = (ulong)list[1];
						uint num9 = A_0[num3 - 1][0];
						ulong num6 = (ulong)A_0[num3 - 1][1];
						num = (short)1146617864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						ulong num6;
						ulong num8;
						if (num8 <= num6 + 1UL)
						{
							num = (short)800522240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_202;
					}
					case 9:
						goto IL_202;
					case 10:
						if (num3 > 0)
						{
							num = (short)1084489735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_202;
					case 11:
						goto IL_17B;
					}
					goto IL_5E;
					IL_17B:
					num = (short)72024065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_206:
					num = (short)1092747269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_202:
					num3++;
					goto IL_206;
				}
				return;
				IL_5E:
				num3 = 0;
				num = (short)1231421451;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600008D RID: 141 RVA: 0x000100C4 File Offset: 0x0000E2C4
		// (remove) Token: 0x0600008E RID: 142 RVA: 0x000101FC File Offset: 0x0000E3FC
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_8D;
				}
				short num;
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)389325628;
					short num2 = num;
					num = (short)1995678524;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1804140544;
						if (num != 0)
						{
						}
						num = (short)1828716545;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							return;
						case 1:
							goto IL_AE;
						case 2:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1212481536;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AE;
						}
						goto IL_8D;
						IL_AE:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num = (short)81723392;
						short num4 = num;
						num = (short)425459714;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_8D:
				propertyChangedEventHandler = this.PropertyChanged;
				num = (short)266141697;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				short num;
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)1620101914;
					short num2 = num;
					num = (short)907791130;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FE;
					default:
					{
						num = (short)508362752;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							goto IL_FE;
						case 1:
							goto IL_85;
						case 2:
						{
							num = (short)48758784;
							short num4 = num;
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1093271552;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_85;
						}
						}
						goto IL_67;
						IL_85:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num = (short)1326645250;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_FE:
				num = (short)1694957569;
				if (num != 0)
				{
				}
				return;
				IL_67:
				propertyChangedEventHandler = this.PropertyChanged;
				num = (short)460849153;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00010330 File Offset: 0x0000E530
		private void a(string A_0)
		{
			short num = (short)1822883841;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_14;
				case 2:
				{
					this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
					num = (short)1541540748;
					short num3 = num;
					num = (short)632228748;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					case 1:
						break;
					default:
					{
						num = (short)1247281152;
						short num4 = num;
						break;
					}
					}
					num = (short)1529151488;
					if (num != 0)
					{
					}
					num = (short)1296039936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_30;
				IL_14:
				switch (0)
				{
				case 0:
					IL_30:
					num = (short)1892876289;
					if (num != 0)
					{
					}
					if (this.PropertyChanged == null)
					{
						return;
					}
					num = (short)869466114;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x04000024 RID: 36
		private global::ASK.Core.AccessRecordSetX<global::ASK.Core.AccessNode> accessNodes;

		// Token: 0x04000025 RID: 37
		private int m_id;

		// Token: 0x04000026 RID: 38
		private int primaryKey;

		// Token: 0x04000027 RID: 39
		private string m_name;

		// Token: 0x04000028 RID: 40
		private global::ASK.Interface.FeatureCategoryType m_recType;

		// Token: 0x04000029 RID: 41
		private byte[] m_FieldCodeArr;

		// Token: 0x0400002A RID: 42
		private bool m_bOTAPState;

		// Token: 0x0400002B RID: 43
		private bool m_bInUseFlag;

		// Token: 0x0400002C RID: 44
		private global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> m_ranges;

		// Token: 0x0400002D RID: 45
		private global::ASK.Interface.FeatureCategoryRadioType m_radioType;
	}
}
