using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using AcpCommonResources;

namespace AcpASKLib
{
	// Token: 0x02000012 RID: 18
	[global::System.Serializable]
	public class AccessRecord : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00007994 File Offset: 0x00005B94
		internal AccessRecord(string A_0, int A_1, global::AcpASKLib.FeatureCategoryType A_2, byte[] A_3, global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> A_4, global::AcpASKLib.FeatureCategoryRadioType A_5, bool A_6)
		{
			this.accessNodes = new global::AcpASKLib.AccessRecordSetX<global::AcpASKLib.AccessNode>(global::AcpCommonResources.AcpResources.Codeplug_Field);
			this.m_ranges = new global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>();
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
					using (global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator = A_4.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::System.Collections.Generic.KeyValuePair<ushort, global::AcpASKLib.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
							this.m_ranges.Add(keyValuePair.Key, keyValuePair.Value);
						}
						break;
					}
				}
			}
			this.c();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007A94 File Offset: 0x00005C94
		public AccessRecord(string name, int pk, global::AcpASKLib.FeatureCategoryType recType) : this(name, pk, recType, null, null, global::AcpASKLib.FeatureCategoryRadioType.XTSXTLRadios, false)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007AA3 File Offset: 0x00005CA3
		public AccessRecord(string name, global::AcpASKLib.FeatureCategoryType recType) : this(name, 0, recType, null, null, global::AcpASKLib.FeatureCategoryRadioType.XTSXTLRadios, false)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007AB2 File Offset: 0x00005CB2
		public AccessRecord(int pk, global::AcpASKLib.FeatureCategoryType recType, byte[] fieldCode, global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> ranges, bool bOTAP) : this(null, pk, recType, fieldCode, ranges, global::AcpASKLib.FeatureCategoryRadioType.XTSXTLRadios, bOTAP)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007AC4 File Offset: 0x00005CC4
		public AccessRecord(global::AcpASKLib.AccessRecord copy)
		{
			this.accessNodes = new global::AcpASKLib.AccessRecordSetX<global::AcpASKLib.AccessNode>(global::AcpCommonResources.AcpResources.Codeplug_Field);
			this.m_ranges = new global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>();
			this.primaryKey = copy.primaryKey;
			this.m_id = copy.m_id;
			this.m_name = copy.m_name;
			this.m_bOTAPState = copy.m_bOTAPState;
			this.m_bInUseFlag = copy.m_bInUseFlag;
			this.m_recType = copy.m_recType;
			this.m_FieldCodeArr = new byte[24];
			global::System.Array.Copy(copy.m_FieldCodeArr, 0, this.m_FieldCodeArr, 0, copy.m_FieldCodeArr.Length);
			using (global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator = copy.m_ranges.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Collections.Generic.KeyValuePair<ushort, global::AcpASKLib.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
					global::AcpASKLib.FieldValueRangeRecSet fieldValueRangeRecSet = new global::AcpASKLib.FieldValueRangeRecSet(keyValuePair.Value.OwnerID);
					using (global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator2 = keyValuePair.Value.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::AcpASKLib.AccessFieldValueRange accessFieldValueRange = enumerator2.Current;
							fieldValueRangeRecSet.Add(new global::AcpASKLib.AccessFieldValueRange
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
				using (global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator3 = copy.AccessNodes.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						global::AcpASKLib.AccessNode a_ = enumerator3.Current;
						global::AcpASKLib.AccessNode item = this.c(a_);
						this.accessNodes.Add(item);
					}
					break;
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007CB0 File Offset: 0x00005EB0
		private void c()
		{
			short num = (short)1464205312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1627258880;
				short num3 = num;
				global::System.Collections.IEnumerator enumerator = global::AcpASKLib.FeatureSchemaManager.FeatureCategories.GetEnumerator();
				try
				{
					num = (short)1896546308;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)428212231;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.FeatureCategory featureCategory = (global::AcpASKLib.FeatureCategory)enumerator.Current;
							num = (short)1667629062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::AcpASKLib.FeatureCategory featureCategory;
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator2 = featureCategory.Features.GetEnumerator();
							num = (short)304545800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::AcpASKLib.FeatureCategory featureCategory;
							if (featureCategory.RadioType == this.m_radioType)
							{
								num = (short)552140801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							num = (short)1941241858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_A5;
							}
							continue;
						case 5:
							try
							{
								num = (short)1255145472;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_178;
										}
										continue;
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)488505347;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.AccessNode a_ = enumerator2.Current;
										global::AcpASKLib.AccessNode item = this.d(a_);
										this.accessNodes.Add(item);
										num = (short)1227620353;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)1972830212;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_204;
									}
									IL_1B2:
									num = (short)840826882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_178:
									goto IL_1B2;
								}
								IL_204:;
							}
							finally
							{
								num = (short)429391872;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator2;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_23C;
										}
										continue;
									case 1:
									{
										num = (short)1740410868;
										short num4 = num;
										num = (short)1491570676;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											continue;
										default:
											num = (short)1166934016;
											if (num != 0)
											{
											}
											enumerator2.Dispose();
											num = (short)1011875842;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_2C3;
									}
									IL_23C:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1332150273;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2C3:;
							}
							break;
						case 6:
						{
							global::AcpASKLib.FeatureCategory featureCategory;
							if (featureCategory.Type == this.m_recType)
							{
								num = (short)1873215491;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							goto IL_48A;
						case 8:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator2;
							try
							{
								num = (short)1885929472;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_391;
										}
										continue;
									case 2:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)253231107;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.AccessNode a_2 = enumerator2.Current;
										global::AcpASKLib.AccessNode item2 = this.d(a_2);
										this.accessNodes.Add(item2);
										num = (short)1206910977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)1994653700;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_419;
									}
									IL_3C8:
									num = (short)1126563842;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_391:
									goto IL_3C8;
								}
								IL_419:
								goto IL_32E;
							}
							finally
							{
								num = (short)1308426240;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_452;
										}
										continue;
									case 1:
										enumerator2.Dispose();
										num = (short)2030370818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_487;
									}
									IL_452:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1372913665;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_487:;
							}
							goto IL_48A;
							IL_32E:
							global::AcpASKLib.FeatureCategory featureCategory;
							enumerator2 = featureCategory.Functions.GetEnumerator();
							num = (short)900333573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_4A2;
						}
						IL_2C6:
						num = (short)1355743232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A5:
						goto IL_2C6;
						IL_48A:
						num = (short)1535049737;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4A2:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_4C4;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_4B1:
						switch (num2)
						{
						case 0:
							num = (short)491847681;
							if (num != 0)
							{
							}
							if (disposable != null)
							{
								num = (short)1510342657;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_549;
						case 1:
							disposable.Dispose();
							num = (short)11272194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_547;
						}
						goto IL_4C4;
					}
					IL_547:
					IL_549:
					goto EndFinally_17;
					IL_4C4:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)227475456;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_4B1;
					EndFinally_17:;
				}
				return;
			}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00008254 File Offset: 0x00006454
		private global::AcpASKLib.AccessNode d(global::AcpASKLib.AccessNode A_0)
		{
			short num = (short)1233453057;
			if (num != 0)
			{
			}
			num = (short)1396637696;
			short num2 = num;
			num = (short)98566144;
			switch (num)
			{
			default:
			{
				global::AcpASKLib.AccessNode accessNode = new global::AcpASKLib.AccessNode(A_0.Name, A_0.UIName, A_0.ID);
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator = A_0.Sections.GetEnumerator();
				try
				{
					num = (short)1840054273;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::AcpASKLib.AccessSection accessSection;
							try
							{
								num = (short)2102394892;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 1:
										num = (short)1512177674;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_572;
									case 3:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessField)
										{
											num = (short)1077870608;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)110886917;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::AcpASKLib.AccessElement accessElement2;
										((global::AcpASKLib.AccessRangeField)accessElement2).AccessLevel = this.a((ushort)accessElement2.ID);
										num = (short)271515659;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessOperation)
										{
											num = (short)1313996815;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_39E;
									}
									case 6:
									{
										global::AcpASKLib.AccessElement accessElement;
										global::AcpASKLib.AccessElement accessElement2;
										((global::AcpASKLib.AccessRangeField)accessElement2).Ranges = this.m_ranges[(ushort)accessElement.ID];
										num = (short)1521483795;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										global::AcpASKLib.AccessElement accessElement2;
										((global::AcpASKLib.AccessField)accessElement2).AccessLevel = this.a((ushort)accessElement2.ID);
										num = (short)874250253;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)701300759;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.AccessElement accessElement = enumerator2.Current;
										global::AcpASKLib.AccessElement accessElement2 = null;
										num = (short)1707737108;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										if (this.m_FieldCodeArr != null)
										{
											num = (short)1183842308;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_39E;
									case 10:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (this.m_ranges.ContainsKey((ushort)accessElement.ID))
										{
											num = (short)1653866502;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_319;
									}
									case 11:
										goto IL_39E;
									case 12:
										switch (0)
										{
										case 0:
											goto IL_163;
										}
										continue;
									case 13:
										goto IL_39E;
									case 14:
										if (this.m_ranges != null)
										{
											num = (short)991887361;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_319;
									case 15:
									{
										global::AcpASKLib.AccessElement accessElement;
										global::AcpASKLib.AccessElement accessElement2 = new global::AcpASKLib.AccessOperation(accessElement.Name, accessElement.UIName, accessElement.ID, accessElement.ElemID, false);
										((global::AcpASKLib.AccessOperation)accessElement2).AccessLevel = this.b(accessElement2.ID);
										num = (short)821755921;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 16:
									{
										global::AcpASKLib.AccessElement accessElement;
										global::AcpASKLib.AccessElement accessElement2 = new global::AcpASKLib.AccessField(accessElement.Name, accessElement.UIName, accessElement.ID, ((global::AcpASKLib.AccessField)accessElement).MapID, accessElement.ElemID, global::AcpASKLib.AccessLevelType.ReadOnly);
										num = (short)209125400;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 17:
										goto IL_39E;
									case 18:
									{
										global::AcpASKLib.AccessElement accessElement2;
										accessSection.Items.Add(accessElement2);
										num = (short)672858112;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 19:
										goto IL_319;
									case 20:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessRangeField)
										{
											num = (short)570556438;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1233321987;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 21:
									{
										global::AcpASKLib.AccessElement accessElement2;
										if (accessElement2 != null)
										{
											num = (short)461701138;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 22:
									{
										global::AcpASKLib.AccessElement accessElement;
										global::AcpASKLib.AccessElement accessElement2 = new global::AcpASKLib.AccessRangeField(accessElement.Name, accessElement.UIName, accessElement.ID, ((global::AcpASKLib.AccessRangeField)accessElement).MapID, accessElement.ElemID, global::AcpASKLib.AccessLevelType.ReadOnly);
										num = (short)2147352590;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 23:
										num = (short)2080899074;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 24:
										if (this.m_FieldCodeArr != null)
										{
											num = (short)1839529991;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_39E;
									}
									IL_204:
									num = (short)616431624;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_163:
									goto IL_204;
									IL_319:
									num = (short)993525769;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_39E:
									num = (short)2117206037;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_572:
								goto IL_66C;
							}
							finally
							{
								num = (short)1774780417;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)1207631874;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_5AA;
										}
										continue;
									case 2:
										goto IL_5E3;
									}
									IL_5AA:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1193672704;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_5E3:;
							}
							break;
							IL_66C:
							accessNode.Sections.Add(accessSection);
							num = (short)1572869;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_D4;
							}
							continue;
						case 2:
							num = (short)190119939;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_6AD;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)190447618;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.AccessSection accessSection2 = enumerator.Current;
							global::AcpASKLib.AccessSection accessSection = new global::AcpASKLib.AccessSection(accessSection2.Name, accessSection2.UIName, accessSection2.ID);
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2 = accessSection2.Items.GetEnumerator();
							num = (short)37617664;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_5E6:
						num = (short)1175126020;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D4:
						goto IL_5E6;
					}
					IL_6AD:;
				}
				finally
				{
					num = (short)1162215425;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1145962498;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_6C7;
						case 2:
							goto IL_76B;
						}
						goto IL_6E4;
						IL_6C7:
						switch (0)
						{
						case 0:
						{
							IL_6E4:
							if (enumerator == null)
							{
								goto IL_76D;
							}
							num = (short)1817579237;
							short num4 = num;
							num = (short)1646923493;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_6C7;
							default:
								num = (short)412155904;
								if (num != 0)
								{
								}
								num = (short)966983680;
								num3 = (int)((global::System.IntPtr)num);
								break;
							}
							break;
						}
						}
					}
					IL_76B:
					IL_76D:;
				}
				return accessNode;
			}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00008A04 File Offset: 0x00006C04
		private global::AcpASKLib.AccessNode c(global::AcpASKLib.AccessNode A_0)
		{
			short num = (short)958529536;
			switch (num)
			{
			default:
			{
				global::AcpASKLib.AccessNode accessNode = new global::AcpASKLib.AccessNode(A_0.Name, A_0.UIName, A_0.ID);
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator = A_0.Sections.GetEnumerator();
				try
				{
					num = (short)1466761217;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::AcpASKLib.AccessSection accessSection;
							try
							{
								num = (short)549257218;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::AcpASKLib.AccessElement accessElement2;
									switch (num2)
									{
									case 0:
									{
										global::AcpASKLib.AccessElement accessElement;
										global::AcpASKLib.AccessField accessField = (global::AcpASKLib.AccessField)accessElement;
										accessElement2 = new global::AcpASKLib.AccessField(accessField.Name, accessField.UIName, accessField.ID, accessField.MapID, accessField.ElemID, accessField.AccessLevel);
										num = (short)2095579144;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_E6;
										}
										continue;
									case 3:
									{
										global::AcpASKLib.AccessElement accessElement;
										global::AcpASKLib.AccessOperation accessOperation = (global::AcpASKLib.AccessOperation)accessElement;
										accessElement2 = new global::AcpASKLib.AccessOperation(accessOperation.Name, accessOperation.UIName, accessOperation.ID, accessOperation.ElemID, accessOperation.AccessLevel);
										num = (short)1231421449;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessField)
										{
											num = (short)327680000;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)87818253;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessRangeField)
										{
											num = (short)31129607;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1009057796;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										goto IL_4E6;
									case 7:
									{
										global::AcpASKLib.AccessElement accessElement;
										global::AcpASKLib.AccessRangeField accessRangeField = (global::AcpASKLib.AccessRangeField)accessElement;
										accessElement2 = new global::AcpASKLib.AccessRangeField(accessRangeField.Name, accessRangeField.UIName, accessRangeField.ID, accessRangeField.MapID, accessRangeField.ElemID, accessRangeField.AccessLevel);
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator2 = accessRangeField.Ranges.GetEnumerator();
										num = (short)1705181194;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										goto IL_2E4;
									case 9:
										goto IL_2E4;
									case 10:
										try
										{
											num = (short)870973443;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_223;
												case 1:
													num = (short)1713635328;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
												{
													global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator2;
													if (!enumerator2.MoveNext())
													{
														num = (short)1615265793;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpASKLib.AccessFieldValueRange accessFieldValueRange = enumerator2.Current;
													global::AcpASKLib.AccessFieldValueRange item = new global::AcpASKLib.AccessFieldValueRange(accessFieldValueRange.FieldID, accessFieldValueRange.Minimum, accessFieldValueRange.Maximum);
													((global::AcpASKLib.AccessRangeField)accessElement2).Ranges.Add(item);
													num = (short)458883076;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
													switch (0)
													{
													case 0:
														goto IL_17E;
													}
													continue;
												}
												IL_180:
												num = (short)1322123266;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_17E:
												goto IL_180;
											}
											IL_223:;
										}
										finally
										{
											num = (short)773718017;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												num = (short)1188374189;
												short num3 = num;
												num = (short)1117726381;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_2E3;
												default:
												{
													num = (short)634191872;
													if (num != 0)
													{
													}
													global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator2;
													switch (num2)
													{
													case 0:
														enumerator2.Dispose();
														num = (short)182845442;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 1:
														switch (0)
														{
														case 0:
															goto IL_2A5;
														}
														continue;
													case 2:
														goto IL_2E1;
													}
													IL_2A5:
													if (enumerator2 == null)
													{
														goto IL_2E3;
													}
													num = (short)1372782592;
													num2 = (int)((global::System.IntPtr)num);
													break;
												}
												}
											}
											IL_2E1:
											IL_2E3:;
										}
										goto IL_2E4;
									case 11:
										num = (short)1379074054;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator3;
										if (!enumerator3.MoveNext())
										{
											num = (short)1689255947;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.AccessElement accessElement = enumerator3.Current;
										accessElement2 = null;
										num = (short)1908867077;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 13:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessOperation)
										{
											num = (short)2004549635;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2E4;
									}
									}
									goto IL_E6;
									IL_2E4:
									accessSection.Items.Add(accessElement2);
									num = (short)770244609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_30B:
									num = (short)138936332;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_E6:
									goto IL_30B;
								}
								IL_4E6:
								goto IL_5E1;
							}
							finally
							{
								num = (short)830537730;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator3;
									switch (num2)
									{
									case 0:
										goto IL_556;
									case 1:
										enumerator3.Dispose();
										num = (short)1731264512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_51D;
										}
										continue;
									}
									IL_51D:
									if (enumerator3 == null)
									{
										break;
									}
									num = (short)244711425;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_556:;
							}
							break;
							IL_5E1:
							accessNode.Sections.Add(accessSection);
							num = (short)1751646213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_83;
							}
							continue;
						case 2:
							num = (short)1190658051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_622;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1746731010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.AccessSection accessSection2 = enumerator.Current;
							global::AcpASKLib.AccessSection accessSection = new global::AcpASKLib.AccessSection(accessSection2.Name, accessSection2.UIName, accessSection2.ID);
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator3 = accessSection2.Items.GetEnumerator();
							num = (short)1902116864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_559:
						num = (short)984088580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_83:
						goto IL_559;
					}
					IL_622:;
				}
				finally
				{
					num = (short)2114453506;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_6B8;
						case 1:
							enumerator.Dispose();
							num = (short)124780545;
							if (num != 0)
							{
							}
							num = (short)2065629184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_65A;
							}
							continue;
						}
						IL_65A:
						if (enumerator == null)
						{
							break;
						}
						num = (short)509345793;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_6B8:;
				}
				num = (short)776667136;
				short num4 = num;
				return accessNode;
			}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00009144 File Offset: 0x00007344
		public void UpdateFieldCode(global::AcpASKLib.AccessNode nodeAccess)
		{
			short num = (short)842995619;
			short num2 = num;
			num = (short)1896421283;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)805306368;
				short num3 = num;
				break;
			}
			}
			num = (short)1403191297;
			if (num != 0)
			{
			}
			num = (short)434569216;
			if (num != 0)
			{
			}
			num = (short)1583022080;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator = nodeAccess.Sections.GetEnumerator();
				try
				{
					num = (short)512884736;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_FF;
							}
							continue;
						case 1:
							try
							{
								num = (short)184942600;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
									{
										global::AcpASKLib.AccessOperation accessOperation;
										this.a(accessOperation.ID);
										num = (short)1984233481;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)525467658;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessOperation)
										{
											num = (short)1502412805;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
									{
										global::AcpASKLib.AccessField accessField;
										if (accessField.AccessLevel == global::AcpASKLib.AccessLevelType.Editable)
										{
											num = (short)923598861;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessField)
										{
											num = (short)2077556742;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1309605890;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::AcpASKLib.AccessElement accessElement;
										global::AcpASKLib.AccessOperation accessOperation = (global::AcpASKLib.AccessOperation)accessElement;
										num = (short)1447886860;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										global::AcpASKLib.AccessElement accessElement;
										global::AcpASKLib.AccessField accessField = (global::AcpASKLib.AccessField)accessElement;
										num = (short)995753987;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)484311041;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.AccessElement accessElement = enumerator2.Current;
										num = (short)830210052;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										switch (0)
										{
										case 0:
											goto IL_1C3;
										}
										continue;
									case 10:
										goto IL_37D;
									case 12:
									{
										global::AcpASKLib.AccessOperation accessOperation;
										if (accessOperation.AccessLevel)
										{
											num = (short)535298048;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 13:
									{
										global::AcpASKLib.AccessField accessField;
										this.a(accessField.ID);
										num = (short)1291255819;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1C5:
									num = (short)395378695;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_1C3:
									goto IL_1C5;
								}
								IL_37D:
								break;
							}
							finally
							{
								num = (short)1643970560;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_3B4;
										}
										continue;
									case 1:
										goto IL_3E9;
									case 2:
										enumerator2.Dispose();
										num = (short)371130369;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_3B4:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)602800130;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_3E9:;
							}
							goto IL_3EC;
						case 2:
							goto IL_3EC;
						case 3:
							goto IL_404;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)274006018;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2 = enumerator.Current.Items.GetEnumerator();
							num = (short)1964310529;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_129:
						num = (short)514850820;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_FF:
						goto IL_129;
						IL_3EC:
						num = (short)1139802115;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_404:;
				}
				finally
				{
					num = (short)1761804288;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_438;
							}
							continue;
						case 1:
							goto IL_470;
						case 2:
							enumerator.Dispose();
							num = (short)1080557569;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_438:
						if (enumerator == null)
						{
							break;
						}
						num = (short)696451074;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_470:;
				}
				break;
			}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000095F8 File Offset: 0x000077F8
		internal byte[] PackedData
		{
			get
			{
				short num = (short)1922433024;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					global::System.Collections.ArrayList arrayList;
					for (;;)
					{
						IL_27:
						int num4;
						global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator2;
						switch (num2)
						{
						case 0:
						{
							num = (short)95944704;
							short num3 = num;
							goto IL_2AC;
						}
						case 1:
							if (num4 >= this.m_FieldCodeArr.Length)
							{
								num = (short)1947598855;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							arrayList.Add(this.m_FieldCodeArr[num4]);
							num4++;
							num = (short)1833304067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::System.Collections.ArrayList arrayList2;
							try
							{
								num = (short)677445637;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::AcpASKLib.FieldValueRangeRecSet value;
										if (value.Count > 0)
										{
											num = (short)445841410;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
									{
										byte[] array;
										if (array != null)
										{
											num = (short)2007302151;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
									{
										global::AcpASKLib.FieldValueRangeRecSet value;
										byte[] array = value.PackedData;
										num = (short)360054785;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1418067972;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<ushort, global::AcpASKLib.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
										global::AcpASKLib.FieldValueRangeRecSet value = keyValuePair.Value;
										num = (short)1970995200;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										num = (short)1332019206;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_356;
										}
										continue;
									case 6:
										goto IL_4A3;
									case 7:
										num = (short)199753738;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										byte[] array;
										arrayList.AddRange(array);
										arrayList2.AddRange(array);
										num = (short)539295752;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
									{
										byte[] array;
										if (array.Length != 0)
										{
											num = (short)1591345161;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_420:
									num = (short)1710948355;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_356:
									goto IL_420;
								}
								IL_4A3:;
							}
							finally
							{
								global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							byte b = global::AcpASKLib.Global.a((byte[])arrayList2.ToArray(typeof(byte)));
							arrayList.Add(b);
							num = (short)477757449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_147;
						case 4:
							if (this.m_ranges.Count > 0)
							{
								num = (short)1820655624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_609;
						case 5:
						{
							if (this.primaryKey <= 5)
							{
								goto IL_5C0;
							}
							num = (short)29735106;
							short num5 = num;
							num = (short)1058519234;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_12A;
							default:
								num = (short)1460142080;
								if (num != 0)
								{
								}
								num = (short)1162870784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_147;
						case 7:
						{
							arrayList.Add((byte)this.m_ranges.Count);
							byte b2 = global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte)));
							arrayList.Add(b2);
							num = (short)793772036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
							global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator = this.m_ranges.GetEnumerator();
							goto IL_12A;
						}
						case 9:
							goto IL_4F9;
						case 10:
							try
							{
								num = (short)373030912;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1C7;
										}
										continue;
									case 2:
										num = (short)274399235;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_23A;
									case 4:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)662962178;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.AccessNode nodeAccess = enumerator2.Current;
										this.UpdateFieldCode(nodeAccess);
										num = (short)274726913;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1EE:
									num = (short)659357700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1C7:
									goto IL_1EE;
								}
								IL_23A:
								goto IL_5C0;
							}
							finally
							{
								num = (short)1462960128;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_272;
										}
										continue;
									case 1:
										goto IL_2A9;
									case 2:
										enumerator2.Dispose();
										num = (short)173670401;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_272:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1601568770;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2A9:;
							}
							goto IL_2AC;
						}
						goto IL_5A;
						IL_12A:
						num = (short)245825538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_147:
						num = (short)365953025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2AC:
						this.a();
						enumerator2 = this.accessNodes.GetEnumerator();
						num = (short)2095710209;
						if (num != 0)
						{
						}
						num = (short)742719498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5C0:
						arrayList.Add((byte)this.primaryKey);
						arrayList.Add((byte)this.m_FieldCodeArr.Length);
						num4 = 0;
						num = (short)1350107142;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4F9:
					IL_609:
					return (byte[])arrayList.ToArray(typeof(byte));
					IL_5A:
					arrayList = new global::System.Collections.ArrayList();
					new global::System.Collections.ArrayList();
					num = (short)967311365;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00009C58 File Offset: 0x00007E58
		public void SetAccessLevel(global::AcpASKLib.AccessLevelType fldAccLvl, bool opAccLvl)
		{
			short num;
			for (;;)
			{
				num = (short)348782592;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator = this.accessNodes.GetEnumerator();
				try
				{
					num = (short)405929984;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_71;
							}
							continue;
						case 2:
							num = (short)1476722691;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_EB;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1381957634;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.AccessNode accessNode = enumerator.Current;
							this.a(accessNode, fldAccLvl, opAccLvl);
							this.UpdateFieldCode(accessNode);
							num = (short)864092161;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_A1:
						num = (short)108789764;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_71:
						goto IL_A1;
					}
					IL_EB:;
				}
				finally
				{
					num = (short)644022272;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_11D;
							}
							continue;
						case 1:
							goto IL_153;
						case 2:
							enumerator.Dispose();
							num = (short)1257308161;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_11D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1978990594;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_153:;
				}
				num = (short)2144895324;
				short num4 = num;
				num = (short)1125220700;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_18A;
				}
			}
			IL_18A:
			num = (short)1676541952;
			if (num != 0)
			{
			}
			num = (short)702152705;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00009E3C File Offset: 0x0000803C
		private void a(global::AcpASKLib.AccessNode A_0, global::AcpASKLib.AccessLevelType A_1, bool A_2)
		{
			short num;
			for (;;)
			{
				num = (short)1664811008;
				short num2 = num;
				num = (short)973602817;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator = A_0.Sections.GetEnumerator();
				try
				{
					num = (short)1984364544;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_98;
							}
							continue;
						case 1:
							try
							{
								num = (short)579731460;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num = (short)1606025221;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1560281088;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.AccessElement accessElement = enumerator2.Current;
										num = (short)1618673672;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::AcpASKLib.AccessElement accessElement;
										((global::AcpASKLib.AccessField)accessElement).AccessLevel = A_1;
										num = (short)1119617031;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_143;
										}
										continue;
									case 5:
										goto IL_258;
									case 6:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessOperation)
										{
											num = (short)284164105;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessField)
										{
											num = (short)1833107458;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)882638854;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
									{
										global::AcpASKLib.AccessElement accessElement;
										((global::AcpASKLib.AccessOperation)accessElement).AccessLevel = A_2;
										num = (short)144637955;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_145:
									num = (short)449249281;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_143:
									goto IL_145;
								}
								IL_258:
								break;
							}
							finally
							{
								num = (short)2046885888;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_28E;
										}
										continue;
									case 1:
										goto IL_2C1;
									case 2:
										enumerator2.Dispose();
										num = (short)1772683265;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_28E:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1658322946;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_2C1:;
							}
							goto IL_2C4;
						case 2:
							goto IL_2C4;
						case 3:
							goto IL_2DB;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)86966274;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2 = enumerator.Current.Items.GetEnumerator();
							num = (short)672989185;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_C1:
						num = (short)1955594244;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_98:
						goto IL_C1;
						IL_2C4:
						num = (short)1090256899;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2DB:;
				}
				finally
				{
					num = (short)1361903616;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_30D;
							}
							continue;
						case 1:
							goto IL_341;
						case 2:
							enumerator.Dispose();
							num = (short)120258561;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_30D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)386793474;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_341:;
				}
				num = (short)728962002;
				short num4 = num;
				num = (short)695014354;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_37A;
				}
			}
			IL_37A:
			num = (short)2424832;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000A210 File Offset: 0x00008410
		public void UnPackFeatures()
		{
			short num = (short)2006777857;
			if (num != 0)
			{
			}
			num = (short)1617297408;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator = this.accessNodes.GetEnumerator();
			try
			{
				num = (short)1857028099;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (enumerator.MoveNext())
						{
							num = (short)754141771;
							short num4 = num;
							num = (short)1087130187;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)183435264;
								if (num != 0)
								{
								}
								global::AcpASKLib.AccessNode a_ = enumerator.Current;
								this.b(a_);
								num = (short)424280068;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
						}
						num = (short)1772879874;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_15E;
					case 2:
						num = (short)1111883777;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_96;
						}
						continue;
					}
					IL_109:
					num = (short)1173487616;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_96:
					goto IL_109;
				}
				IL_15E:;
			}
			finally
			{
				num = (short)2115633154;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1994850305;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1C4;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_191;
						}
						continue;
					}
					IL_191:
					if (enumerator == null)
					{
						break;
					}
					num = (short)48693248;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1C4:;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000A400 File Offset: 0x00008600
		private void b(global::AcpASKLib.AccessNode A_0)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator = A_0.Sections.GetEnumerator();
			short num;
			try
			{
				num = (short)231997443;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1936785410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2 = enumerator.Current.Items.GetEnumerator();
						num = (short)375586820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_300;
					case 2:
						goto IL_2E9;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 4:
						try
						{
							num = (short)296747016;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpASKLib.AccessElement accessElement;
								switch (num2)
								{
								case 0:
									((global::AcpASKLib.AccessOperation)accessElement).AccessLevel = this.b(accessElement.ID);
									num = (short)1012137986;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1832583173;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									((global::AcpASKLib.AccessField)accessElement).AccessLevel = this.a((ushort)accessElement.ID);
									num = (short)867893252;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_27C;
								case 6:
									if (accessElement is global::AcpASKLib.AccessField)
									{
										num = (short)1288044547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)773652489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
									if (enumerator2.MoveNext())
									{
										accessElement = enumerator2.Current;
										num = (short)983302150;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1306175782;
									short num3 = num;
									num = (short)1788651814;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_195;
									default:
										num = (short)1745354752;
										if (num != 0)
										{
										}
										num = (short)2041970689;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_F5;
									}
									continue;
								case 9:
									goto IL_195;
								}
								IL_F7:
								num = (short)1140981767;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_195:
								if (accessElement is global::AcpASKLib.AccessOperation)
								{
									num = (short)1096286208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F5:
								goto IL_F7;
							}
							IL_27C:
							break;
						}
						finally
						{
							num = (short)261816322;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)870580225;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2E6;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2B3;
									}
									continue;
								}
								IL_2B3:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1842479104;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E6:;
						}
						goto IL_2E9;
					}
					IL_70:
					num = (short)1012662272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46:
					goto IL_70;
					IL_2E9:
					num = (short)1253703681;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_300:;
			}
			finally
			{
				num = (short)1427111938;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)373882881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_368;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_333;
						}
						continue;
					}
					IL_333:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1232535552;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_368:;
			}
			num = (short)1273298944;
			short num4 = num;
			num = (short)2109079553;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000A800 File Offset: 0x00008A00
		private void a(global::AcpASKLib.AccessNode A_0)
		{
			short num = (short)1699610625;
			if (num != 0)
			{
			}
			num = (short)1570832384;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator = A_0.Sections.GetEnumerator();
				try
				{
					num = (short)204931075;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2042298370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2 = enumerator.Current.Items.GetEnumerator();
							num = (short)1307574276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_4CF;
						case 2:
							goto IL_4B7;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_8D;
							}
							continue;
						case 4:
							try
							{
								num = (short)682885137;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1446117389;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.AccessElement accessElement = enumerator2.Current;
										num = (short)121307151;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)28770307;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::AcpASKLib.AccessField accessField;
										if (accessField.AccessLevel == global::AcpASKLib.AccessLevelType.Editable)
										{
											num = (short)384892946;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2F2;
									}
									case 3:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (((global::AcpASKLib.AccessRangeField)accessElement).Ranges.Count > 0)
										{
											num = (short)1151926284;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessOperation)
										{
											num = (short)2080178184;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_448;
									case 6:
										goto IL_2F2;
									case 7:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessRangeField)
										{
											num = (short)1931214849;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
									{
										global::AcpASKLib.AccessElement accessElement;
										global::AcpASKLib.AccessOperation accessOperation = (global::AcpASKLib.AccessOperation)accessElement;
										num = (short)653983754;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
									{
										global::AcpASKLib.AccessElement accessElement;
										global::AcpASKLib.AccessField accessField = (global::AcpASKLib.AccessField)accessElement;
										num = (short)1186791426;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
									{
										global::AcpASKLib.AccessOperation accessOperation;
										if (accessOperation.AccessLevel)
										{
											num = (short)1970208782;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 12:
									{
										global::AcpASKLib.AccessElement accessElement;
										this.m_ranges[(ushort)accessElement.ID] = ((global::AcpASKLib.AccessRangeField)accessElement).Ranges;
										num = (short)672858128;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 13:
										goto IL_1AE;
									case 14:
									{
										global::AcpASKLib.AccessOperation accessOperation;
										this.a(accessOperation.ID);
										num = (short)280952843;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 15:
									{
										global::AcpASKLib.AccessElement accessElement;
										if (accessElement is global::AcpASKLib.AccessField)
										{
											num = (short)1911619593;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1916993540;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 17:
										switch (0)
										{
										case 0:
											goto IL_170;
										}
										continue;
									case 18:
									{
										num = (short)1009516022;
										short num3 = num;
										num = (short)700841462;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1AE;
										default:
										{
											num = (short)1467940864;
											if (num != 0)
											{
											}
											global::AcpASKLib.AccessField accessField;
											this.a(accessField.ID);
											num = (short)1070268422;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										break;
									}
									}
									IL_175:
									num = (short)84934656;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_170:
									goto IL_175;
									IL_1AE:
									num = (short)361168901;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2F2:
									num = (short)1119879175;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_448:
								break;
							}
							finally
							{
								num = (short)1241317378;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)1962868737;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_4B4;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_47F;
										}
										continue;
									}
									IL_47F:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)534839296;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4B4:;
							}
							goto IL_4B7;
						}
						IL_BC:
						num = (short)631635968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8D:
						goto IL_BC;
						IL_4B7:
						num = (short)740163585;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4CF:;
				}
				finally
				{
					num = (short)1501102082;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)191889409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_53B;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_504;
							}
							continue;
						}
						IL_504:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1080492032;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_53B:;
				}
				num = (short)1056768000;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000ADAC File Offset: 0x00008FAC
		private void b()
		{
			short num = (short)657784833;
			if (num != 0)
			{
			}
			num = (short)1068498944;
			short num2 = num;
			this.a();
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator = this.accessNodes.GetEnumerator();
			try
			{
				num = (short)316669955;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (enumerator.MoveNext())
						{
							num = (short)811580632;
							short num4 = num;
							num = (short)354729176;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)1228865536;
								if (num != 0)
								{
								}
								global::AcpASKLib.AccessNode a_ = enumerator.Current;
								this.a(a_);
								num = (short)161808388;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
						}
						num = (short)347013122;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_164;
					case 2:
						num = (short)1601961985;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_9F;
						}
						continue;
					}
					IL_111:
					num = (short)1441792000;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F:
					goto IL_111;
				}
				IL_164:;
			}
			finally
			{
				num = (short)1467744258;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1946484737;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1CB;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_196;
						}
						continue;
					}
					IL_196:
					if (enumerator == null)
					{
						break;
					}
					num = (short)983760896;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1CB:;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000AFA4 File Offset: 0x000091A4
		public override string ToString()
		{
			short num = (short)52169337;
			short num2 = num;
			num = (short)1775962745;
			switch (num2 == num)
			{
			}
			num = (short)276103168;
			short num3 = num;
			num = (short)628555777;
			if (num != 0)
			{
			}
			num = (short)1403715584;
			if (num != 0)
			{
			}
			return this.m_name;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000B054 File Offset: 0x00009254
		private bool b(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num5;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_CE;
				case 1:
					goto IL_177;
				case 2:
				{
					int num2 = A_0 - 1;
					int num3 = num2 / 8;
					int num4 = num2 % 8;
					num5 = (short)123666435;
					num = (int)((global::System.IntPtr)num5);
					continue;
				}
				case 3:
				{
					int num3;
					int num4;
					if (((int)this.m_FieldCodeArr[num3] & 1 << num4) > 0)
					{
						num5 = (short)287899652;
						num = (int)((global::System.IntPtr)num5);
						continue;
					}
					result = false;
					num5 = (short)1560412161;
					if (num5 != 0)
					{
					}
					num5 = (short)1057554440;
					num = (int)((global::System.IntPtr)num5);
					continue;
				}
				case 4:
					result = true;
					num5 = (short)819200000;
					num = (int)((global::System.IntPtr)num5);
					continue;
				case 5:
					if (A_0 <= 192)
					{
						num5 = (short)1112539138;
						num = (int)((global::System.IntPtr)num5);
						continue;
					}
					goto IL_1CE;
				case 6:
				{
					num5 = (short)1977408574;
					short num6 = num5;
					num5 = (short)162716734;
					switch ((num6 == num5) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_177;
					default:
						num5 = (short)799014912;
						if (num5 != 0)
						{
						}
						num5 = (short)99549189;
						num = (int)((global::System.IntPtr)num5);
						continue;
					}
					break;
				}
				case 7:
					if (A_0 != 193)
					{
						num5 = (short)1843855366;
						num = (int)((global::System.IntPtr)num5);
						continue;
					}
					result = this.m_bOTAPState;
					num5 = (short)1186922497;
					num = (int)((global::System.IntPtr)num5);
					continue;
				case 8:
					goto IL_B0;
				}
				goto IL_34;
			}
			IL_B0:
			IL_CE:
			IL_177:
			IL_1CE:
			num5 = (short)1424687104;
			short num7 = num5;
			return result;
			IL_34:
			result = true;
			num5 = (short)2005598215;
			num = (int)((global::System.IntPtr)num5);
			goto IL_0A;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000B25C File Offset: 0x0000945C
		private global::AcpASKLib.AccessLevelType a(ushort A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			short num;
			int num3;
			global::AcpASKLib.AccessLevelType result;
			for (;;)
			{
				IL_0A:
				num = (short)1849098240;
				short num2 = num;
				switch (num3)
				{
				case 0:
					return result;
				case 1:
					goto IL_9B;
				case 2:
					if (this.b((int)A_0))
					{
						num = (short)1651834883;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::AcpASKLib.AccessLevelType.ReadOnly;
					num = (short)70844417;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)54801756;
					short num4 = num;
					num = (short)2033464668;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)1099104256;
						if (num != 0)
						{
						}
						result = global::AcpASKLib.AccessLevelType.Editable;
						num = (short)1822425088;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_4A;
			}
			IL_9B:
			num = (short)1802764289;
			if (num != 0)
			{
			}
			return result;
			IL_4A:
			result = global::AcpASKLib.AccessLevelType.Editable;
			num = (short)164954114;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000B398 File Offset: 0x00009598
		public bool IsRangeValueValid(global::AcpASKLib.AccessElementIDType id, int value)
		{
			short num = (short)1934426112;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_88;
				}
				bool result;
				for (;;)
				{
					IL_27:
					num = (short)1477848900;
					short num3 = num;
					num = (short)1168191300;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num = (short)1154940928;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator;
						switch (num2)
						{
						case 0:
							return result;
						case 1:
							try
							{
								num = (short)1287323659;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									long? num4;
									long? num7;
									switch (num2)
									{
									case 0:
									{
										uint? num5;
										num4 = new long?((long)((ulong)num5.GetValueOrDefault()));
										goto IL_218;
									}
									case 1:
										goto IL_2FF;
									case 2:
										num = (short)1378353157;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1875705858;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.AccessFieldValueRange accessFieldValueRange = enumerator.Current;
										long num6 = (long)value;
										uint? num5 = accessFieldValueRange.Minimum;
										num = (short)312541191;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										result = true;
										num = (short)1672478721;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_35C;
									case 6:
										num = (short)2077622281;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										uint? num5;
										if (num5 == null)
										{
											num = (short)1799028746;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)347930624;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										long num6;
										if (num6 >= num7.GetValueOrDefault() & num7 != null)
										{
											num = (short)1842151430;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
									{
										long num8 = (long)value;
										global::AcpASKLib.AccessFieldValueRange accessFieldValueRange;
										uint? num5 = accessFieldValueRange.Maximum;
										long? num10;
										if (num5 == null)
										{
											long? num9 = null;
											num10 = num9;
										}
										else
										{
											num10 = new long?((long)((ulong)num5.GetValueOrDefault()));
										}
										num7 = num10;
										if (num8 <= num7.GetValueOrDefault() & num7 != null)
										{
											num = (short)532873220;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
									{
										long? num9 = null;
										num = (short)1369440268;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
										switch (0)
										{
										case 0:
											goto IL_17A;
										}
										continue;
									case 12:
									{
										long? num9;
										num4 = num9;
										goto IL_218;
									}
									}
									goto IL_17A;
									IL_218:
									num7 = num4;
									num = (short)1403125768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_304:
									num = (short)2047606787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_17A:
									goto IL_304;
								}
								IL_2FF:
								IL_35C:
								return result;
							}
							finally
							{
								num = (short)1650130946;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1403650049;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_3C9;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_393;
										}
										continue;
									}
									IL_393:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1470169088;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3C9:;
							}
							goto IL_3CC;
						case 2:
						{
							num = (short)1101725697;
							if (num != 0)
							{
							}
							num = (short)1098383360;
							short num11 = num;
							if (this.m_ranges.ContainsKey((ushort)id))
							{
								num = (short)1541668867;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = true;
							num = (short)455278592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_3CC;
						}
						goto IL_88;
						IL_3CC:
						enumerator = this.m_ranges[(ushort)id].GetEnumerator();
						num = (short)1310785537;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return result;
				IL_88:
				result = false;
				num = (short)1060634626;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000B7DC File Offset: 0x000099DC
		public bool IsAccessElementEnabled(global::AcpASKLib.AccessElementIDType id)
		{
			short num = (short)1924202497;
			if (num != 0)
			{
			}
			num = (short)1393085887;
			short num2 = num;
			num = (short)527224255;
			switch (num2 == num)
			{
			}
			num = (short)1773469696;
			if (num != 0)
			{
			}
			num = (short)629342208;
			short num3 = num;
			return this.b((int)id);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000B88C File Offset: 0x00009A8C
		internal bool e()
		{
			short num = (short)400563183;
			short num2 = num;
			num = (short)1476074479;
			switch (num2 == num)
			{
			}
			num = (short)675151873;
			if (num != 0)
			{
			}
			num = (short)1208745984;
			if (num != 0)
			{
			}
			num = (short)1076887552;
			short num3 = num;
			return this.b(76);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000B93C File Offset: 0x00009B3C
		public bool IsCloningEnabled()
		{
			short num = (short)1325793281;
			if (num != 0)
			{
			}
			num = (short)1598532232;
			short num2 = num;
			num = (short)1526639240;
			switch (num2 == num)
			{
			}
			num = (short)45481984;
			if (num != 0)
			{
			}
			num = (short)786563072;
			short num3 = num;
			return this.b(75);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000B9EC File Offset: 0x00009BEC
		public global::AcpASKLib.KeyAccessLevelType GetKeyAccessLevelType()
		{
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			int num;
			short num2;
			global::AcpASKLib.KeyAccessLevelType keyAccessLevelType;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2015232012;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return keyAccessLevelType;
				case 2:
					if (num3 > 80)
					{
						num2 = (short)2069168143;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1177681924;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					keyAccessLevelType = global::AcpASKLib.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP;
					num2 = (short)273350657;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (num3 != 76)
					{
						num2 = (short)1642135560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_230;
				case 5:
					return keyAccessLevelType;
				case 6:
					if (!this.b(76))
					{
						num2 = (short)2057633795;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return keyAccessLevelType;
				case 7:
					goto IL_DD;
				case 8:
					num2 = (short)176160775;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_8C;
				case 10:
					goto IL_2B6;
				case 11:
					goto IL_2B6;
				case 12:
					if (this.RangeCount != 0)
					{
						num2 = (short)1529413648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)169279494;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (keyAccessLevelType != global::AcpASKLib.KeyAccessLevelType.LIMITED_ACC)
					{
						num2 = (short)141623296;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return keyAccessLevelType;
				case 14:
				{
					num2 = (short)1459445028;
					short num4 = num2;
					num2 = (short)46292260;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DD;
					default:
						num2 = (short)393740288;
						if (num2 != 0)
						{
						}
						keyAccessLevelType = global::AcpASKLib.KeyAccessLevelType.LIMITED_ACC;
						num2 = (short)68354057;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 15:
					goto IL_8C;
				case 16:
				{
					num2 = (short)1671561216;
					short num5 = num2;
					keyAccessLevelType = global::AcpASKLib.KeyAccessLevelType.LIMITED_ACC;
					num2 = (short)1012269061;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_54;
				IL_8C:
				num2 = (short)1143406605;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_DD:
				num2 = (short)771096577;
				if (num2 != 0)
				{
				}
				if (!this.b(num3))
				{
					num2 = (short)1981480974;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_230:
				num3++;
				num2 = (short)1925709835;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2B6:
				num2 = (short)736690178;
				num = (int)((global::System.IntPtr)num2);
			}
			return keyAccessLevelType;
			IL_54:
			keyAccessLevelType = global::AcpASKLib.KeyAccessLevelType.UNLM_ACC;
			num3 = 1;
			num2 = (short)1359282186;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000BCEC File Offset: 0x00009EEC
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_75;
				case 1:
					goto IL_61;
				case 2:
				{
					num2 = (short)1332740005;
					short num3 = num2;
					num2 = (short)893058981;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_75;
					default:
						num2 = (short)250740736;
						if (num2 != 0)
						{
						}
						goto IL_61;
					}
					break;
				}
				case 3:
					return;
				}
				goto IL_20;
				IL_61:
				num2 = (short)1625030656;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_75:
				if (num4 >= 24)
				{
					num2 = (short)186580995;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)309395457;
					if (num2 != 0)
					{
					}
					this.m_FieldCodeArr[num4] = 0;
					num4++;
					num2 = (short)483524610;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			return;
			IL_20:
			num4 = 0;
			num2 = (short)981204992;
			short num5 = num2;
			num2 = (short)1631059969;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000BE2C File Offset: 0x0000A02C
		private void a(int A_0)
		{
			short num = (short)1494876160;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)1572798465;
					if (num != 0)
					{
					}
					int num3 = A_0 - 1;
					byte b = (byte)(num3 / 8);
					byte b2 = (byte)(num3 % 8);
					byte[] fieldCodeArr = this.m_FieldCodeArr;
					byte b3 = b;
					fieldCodeArr[(int)b3] = fieldCodeArr[(int)b3] + (byte)(1 << (int)b2);
					num = (short)1710030848;
					short num4 = num;
					num = (short)100544246;
					short num5 = num;
					num = (short)1161309942;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1239678976;
						if (num != 0)
						{
						}
						num = (short)1257635841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_30:
				if (A_0 == 193)
				{
					break;
				}
				num = (short)315293698;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000BF64 File Offset: 0x0000A164
		internal string f()
		{
			int a_ = 9;
			short num = (short)1173356544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				string text;
				int num5;
				for (;;)
				{
					IL_31:
					string str;
					switch (num2)
					{
					case 0:
					{
						num = (short)1318118639;
						short num3 = num;
						num = (short)612361455;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12E;
						default:
							num = (short)1425080320;
							if (num != 0)
							{
							}
							text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("䙥呧䕩⩫ݭᕯṱၳ㕵᝷ṹ᥻䁽詿", a_);
							text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("潥慧噩⁫ݭᵯ᭱s፵ᱷ㹹ᵻ੽킁삍ﾑꪓ뚕", a_);
							str = string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᵥ塧ᝩ", a_), this.Ranges.Count);
							text += str;
							text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("䙥呧䕩⁫ݭᵯ᭱s፵ᱷ㹹ᵻ੽킁삍ﾑꪓ鲕", a_);
							text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("潥慧噩⍫㩭ㅯ≱❳ɵ᥷๹ॻൽ빿ꊁ", a_);
							num = (short)1917059077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						num = (short)1542062080;
						short num4 = num;
						goto IL_2DA;
					}
					case 2:
						if (this.RangeCount > 0)
						{
							num = (short)1265958922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_49A;
					case 3:
						num = (short)1153892353;
						if (num != 0)
						{
						}
						goto IL_2DA;
					case 4:
						goto IL_173;
					case 5:
						if (this.m_bOTAPState)
						{
							num = (short)460914697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("e१٩Ὣ୭", a_);
						goto IL_12E;
					case 6:
						goto IL_173;
					case 7:
						try
						{
							num = (short)800129025;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_27A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1ED;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1992884227;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<ushort, global::AcpASKLib.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
									global::AcpASKLib.FieldValueRangeRecSet value = keyValuePair.Value;
									text += value.a(2);
									num = (short)1128660996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1075970048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1EF:
								num = (short)1246429186;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1ED:
								goto IL_1EF;
							}
							IL_27A:
							goto IL_49A;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_28D;
					case 8:
						if (num5 >= 24)
						{
							num = (short)57081856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28D;
					case 9:
						text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("ብᩧὩ५", a_);
						num = (short)1378615297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator = this.m_ranges.GetEnumerator();
						num = (short)10551303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_64;
					IL_12E:
					num = (short)764411907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_173:
					num = (short)302186504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28D:
					str = string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᵥ塧偩ᑫ屭൯", a_), this.m_FieldCodeArr[23 - num5]);
					text += str;
					num5++;
					num = (short)2141782022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DA:
					text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("䙥呧䕩⍫㩭ㅯ≱❳ɵ᥷๹ॻൽ빿袁", a_);
					num = (short)1321861122;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_49A:
				text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("潥呧䕩㹫୭፯ᵱٳት䙷灹", a_);
				return text;
				IL_64:
				this.b();
				text = "";
				text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("潥呧㡩५൭Ὧqၳ䡵牷", a_);
				text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("潥慧噩⵫൭፯᝱ݳյ㙷᭹ᅻ᭽빿ꊁ", a_);
				text += this.m_name;
				text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("䙥呧䕩⵫൭፯᝱ݳյ㙷᭹ᅻ᭽빿袁", a_);
				text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("潥慧噩⩫ݭᕯṱၳ㕵᝷ṹ᥻䁽ꁿ", a_);
				num5 = 0;
				num = (short)630390788;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000C434 File Offset: 0x0000A634
		public AccessRecord(global::System.Xml.XmlNode node)
		{
			int a_ = 0;
			base..ctor();
			this.accessNodes = new global::AcpASKLib.AccessRecordSetX<global::AcpASKLib.AccessNode>(global::AcpCommonResources.AcpResources.Codeplug_Field);
			this.m_ranges = new global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>();
			this.m_FieldCodeArr = new byte[24];
			this.a();
			this.m_id = -1;
			this.m_recType = global::AcpASKLib.FeatureCategoryType.TRUNKING;
			this.m_bInUseFlag = false;
			for (global::System.Xml.XmlNode xmlNode = node.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				string name = xmlNode.Name;
				string text = xmlNode.InnerText.Trim();
				if (global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᱜ㱞ɠ٢ᙤᑦ❨੪l੮", a_) == name)
				{
					if (string.IsNullOrEmpty(text))
					{
						throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᱜ㱞ɠ٢ᙤᑦ䥨╪౬ɮᑰ卲ᙴᙶ᝸ᕺቼ୾ꆀꞆﶌﮎ", a_));
					}
					if (text == global::AcpCommonResources.AcpResources.Enter_Access_Level)
					{
						throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᥜ㩞ݠɢၤ୦ᵨ䭪ⱬ౮ተᙲٴѶ奸㕺ᱼቾꎂﶈꮊ﶐ﲒﶘ떚", a_));
					}
					if (text.Length > global::AcpASKLib.Constants.MAX_LENGTH)
					{
						throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᱜ㱞ɠ٢ᙤᑦ䥨╪౬ɮᑰ卲Ŵᡶᙸ孺ᅼၾꮄ", a_));
					}
					this.m_name = text;
				}
				if (global::AcpASKLib.SystemKeyLoadedEventArgs.b("ቜ୞⁠㍢㙤፦ࡨὪᡬᱮ", a_) == name)
				{
					if (text == global::AcpASKLib.SystemKeyLoadedEventArgs.b("⥜ⵞᑠ٢", a_))
					{
						this.m_bOTAPState = true;
					}
					else
					{
						if (!(text == global::AcpASKLib.SystemKeyLoadedEventArgs.b("㭜㹞ൠၢd", a_)))
						{
							throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᑜㅞᝠɢ।๦൨䭪≬㭮ば⍲♴Ͷᡸེࡼ౾", a_));
						}
						this.m_bOTAPState = false;
					}
				}
				if (global::AcpASKLib.SystemKeyLoadedEventArgs.b("᭜㙞ѠརŤ⑦٨ཪ࡬", a_) == name)
				{
					string text2 = text;
					for (int i = 0; i < text2.Length; i++)
					{
						if (!global::AcpASKLib.Global.a(text2[i]))
						{
							throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᑜㅞᝠɢ।๦൨䭪⭬ٮᑰὲᅴ㑶ᙸὺ᡼彾검ꎂ꾎璉ﲘ", a_));
						}
					}
					if (text2.Length / 2 != 24 && text2.Length / 2 != 12)
					{
						throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᑜㅞᝠɢ।๦൨䭪⭬ٮᑰὲᅴ㑶ᙸὺ᡼彾검ꎂﶈꮊ놐練ﺘﺚ", a_));
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
						throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᑜㅞᝠɢ।๦൨䭪⭬ٮᑰὲᅴ㑶ᙸὺ᡼彾검ꎂﺊ꾎ﾐﲒ랖ﺚ", a_));
					}
					global::System.Array.Copy(array2, 0, this.m_FieldCodeArr, 0, 24);
				}
				if (global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᅜ㙞ౠ੢ᅤɦ൨⽪౬᭮ၰⅲၴᑶᙸॺ᥼", a_) == name)
				{
					global::AcpASKLib.FieldValueRangeRecSet fieldValueRangeRecSet = new global::AcpASKLib.FieldValueRangeRecSet(xmlNode);
					this.m_ranges.Add(fieldValueRangeRecSet.OwnerID, fieldValueRangeRecSet);
				}
			}
			this.c();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000C788 File Offset: 0x0000A988
		public AccessRecord(string name, string strFieldCode, bool bOTAP, global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> Range)
		{
			int a_ = 13;
			base..ctor();
			this.accessNodes = new global::AcpASKLib.AccessRecordSetX<global::AcpASKLib.AccessNode>(global::AcpCommonResources.AcpResources.Codeplug_Field);
			this.m_ranges = new global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>();
			this.m_FieldCodeArr = new byte[24];
			this.a();
			this.m_id = -1;
			this.m_recType = global::AcpASKLib.FeatureCategoryType.TRUNKING;
			this.m_bInUseFlag = false;
			this.m_name = name;
			this.m_bOTAPState = bOTAP;
			for (int i = 0; i < strFieldCode.Length; i++)
			{
				if (!global::AcpASKLib.Global.a(strFieldCode[i]))
				{
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⍩ɫᡭᅯṱᵳት塷㱹ᕻ᭽잃겋ꎍ낏秊ﶙ벛솟캡톣쎥", a_));
				}
			}
			if (strFieldCode.Length / 2 != 24)
			{
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⍩ɫᡭᅯṱᵳት塷㱹ᕻ᭽잃겋ꎍ낏﶑뢗瀞뺝튟쎡쪣솥춧", a_));
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
					using (global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator = Range.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::System.Collections.Generic.KeyValuePair<ushort, global::AcpASKLib.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
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
			throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⍩ɫᡭᅯṱᵳት塷㱹ᕻ᭽잃겋ꎍ낏歹ﾙ벛쾟횡蒣향춧\udea9", a_));
			IL_1CC:
			this.c();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000C978 File Offset: 0x0000AB78
		public global::AcpASKLib.AccessRecordSetX<global::AcpASKLib.AccessNode> AccessNodes
		{
			get
			{
				short num = (short)1475205722;
				short num2 = num;
				num = (short)1785780826;
				switch (num2 == num)
				{
				}
				num = (short)451149824;
				if (num != 0)
				{
				}
				num = (short)1007550465;
				if (num != 0)
				{
				}
				num = (short)1340669952;
				short num3 = num;
				return this.accessNodes;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000CA24 File Offset: 0x0000AC24
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
		public int PrimaryKey
		{
			get
			{
				short num = (short)740687873;
				if (num != 0)
				{
				}
				num = (short)552178125;
				short num2 = num;
				num = (short)1588498893;
				switch (num2 == num)
				{
				}
				num = (short)1222443008;
				if (num != 0)
				{
				}
				num = (short)510394368;
				short num3 = num;
				return this.primaryKey;
			}
			set
			{
				short num = (short)476975189;
				short num2 = num;
				num = (short)256905301;
				switch (num2 == num)
				{
				}
				num = (short)819003392;
				if (num != 0)
				{
				}
				num = (short)2023227393;
				if (num != 0)
				{
				}
				num = (short)521535488;
				short num3 = num;
				this.primaryKey = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000CB88 File Offset: 0x0000AD88
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000CC38 File Offset: 0x0000AE38
		public int ID
		{
			get
			{
				short num = (short)273663048;
				short num2 = num;
				num = (short)392676424;
				switch (num2 == num)
				{
				}
				num = (short)306315265;
				if (num != 0)
				{
				}
				num = (short)1741094912;
				if (num != 0)
				{
				}
				num = (short)1516044288;
				short num3 = num;
				return this.m_id;
			}
			set
			{
				short num = (short)1369178113;
				if (num != 0)
				{
				}
				num = (short)1418834057;
				short num2 = num;
				num = (short)419475593;
				switch (num2 == num)
				{
				}
				num = (short)1274675200;
				if (num != 0)
				{
				}
				num = (short)1100414976;
				short num3 = num;
				this.m_id = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		public string Name
		{
			get
			{
				short num = (short)711904415;
				short num2 = num;
				num = (short)1248054431;
				switch (num2 == num)
				{
				}
				num = (short)1125122049;
				if (num != 0)
				{
				}
				num = (short)1476132864;
				if (num != 0)
				{
				}
				num = (short)2065104896;
				short num3 = num;
				return this.m_name;
			}
			set
			{
				int a_ = 3;
				short num = (short)1309399101;
				short num2 = num;
				num = (short)1479989309;
				switch (num2 == num)
				{
				}
				num = (short)1478426624;
				if (num != 0)
				{
				}
				num = (short)1008795649;
				if (num != 0)
				{
				}
				num = (short)740098048;
				short num3 = num;
				this.m_name = value;
				this.a(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⹟͡ॣͥ", a_));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000CE6C File Offset: 0x0000B06C
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000CF1C File Offset: 0x0000B11C
		internal global::AcpASKLib.FeatureCategoryType RecordType
		{
			get
			{
				short num = (short)1412910050;
				short num2 = num;
				num = (short)611929058;
				switch (num2 == num)
				{
				}
				num = (short)2029387777;
				if (num != 0)
				{
				}
				num = (short)303955968;
				if (num != 0)
				{
				}
				num = (short)675217408;
				short num3 = num;
				return this.m_recType;
			}
			set
			{
				short num = (short)1306650863;
				short num2 = num;
				num = (short)321120495;
				switch (num2 == num)
				{
				}
				num = (short)1113194496;
				if (num != 0)
				{
				}
				num = (short)1500643329;
				if (num != 0)
				{
				}
				num = (short)1517944832;
				short num3 = num;
				this.m_recType = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000CFCC File Offset: 0x0000B1CC
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0000D080 File Offset: 0x0000B280
		public byte[] FieldCode
		{
			get
			{
				short num = (short)284536796;
				short num2 = num;
				num = (short)652914652;
				switch (num2 == num)
				{
				}
				num = (short)477757441;
				if (num != 0)
				{
				}
				num = (short)1320943616;
				if (num != 0)
				{
				}
				num = (short)2143420416;
				short num3 = num;
				return this.m_FieldCodeArr;
			}
			set
			{
				short num = (short)1395779971;
				short num2 = num;
				num = (short)213838211;
				switch (num2 == num)
				{
				}
				num = (short)1550843904;
				if (num != 0)
				{
				}
				num = (short)800194561;
				if (num != 0)
				{
				}
				num = (short)848625664;
				short num3 = num;
				this.m_FieldCodeArr = value;
				this.UnPackFeatures();
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000D138 File Offset: 0x0000B338
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		public bool OPTAPState
		{
			get
			{
				short num = (short)2099904513;
				if (num != 0)
				{
				}
				num = (short)1451598169;
				short num2 = num;
				num = (short)1912643929;
				switch (num2 == num)
				{
				}
				num = (short)707985408;
				if (num != 0)
				{
				}
				num = (short)1084751872;
				short num3 = num;
				return this.m_bOTAPState;
			}
			set
			{
				short num = (short)731589920;
				short num2 = num;
				num = (short)138095904;
				switch (num2 == num)
				{
				}
				num = (short)1878130689;
				if (num != 0)
				{
				}
				num = (short)1178927104;
				if (num != 0)
				{
				}
				num = (short)10223616;
				short num3 = num;
				this.m_bOTAPState = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000D294 File Offset: 0x0000B494
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000D344 File Offset: 0x0000B544
		internal bool InUse
		{
			get
			{
				short num = (short)2076181342;
				short num2 = num;
				num = (short)1386808158;
				switch (num2 == num)
				{
				}
				num = (short)492961793;
				if (num != 0)
				{
				}
				num = (short)37224448;
				if (num != 0)
				{
				}
				num = (short)39059456;
				short num3 = num;
				return this.m_bInUseFlag;
			}
			set
			{
				short num = (short)2058930651;
				short num2 = num;
				num = (short)167299547;
				switch (num2 == num)
				{
				}
				num = (short)48168961;
				if (num != 0)
				{
				}
				num = (short)88539136;
				if (num != 0)
				{
				}
				num = (short)577503232;
				short num3 = num;
				this.m_bInUseFlag = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0000D4A8 File Offset: 0x0000B6A8
		public global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> Ranges
		{
			get
			{
				short num = (short)1565655041;
				if (num != 0)
				{
				}
				num = (short)1224343552;
				short num2 = num;
				num = (short)408498720;
				short num3 = num;
				num = (short)984691232;
				switch (num3 == num)
				{
				}
				num = (short)394199040;
				if (num != 0)
				{
				}
				return this.m_ranges;
			}
			set
			{
				int a_ = 4;
				short num = (short)1509058750;
				short num2 = num;
				num = (short)422275262;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1647771648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)886308865;
				if (num != 0)
				{
				}
				num = (short)417857536;
				if (num != 0)
				{
				}
				this.m_ranges = value;
				this.a(global::AcpASKLib.SystemKeyLoadedEventArgs.b("㍠ɢ୤f౨ᡪ", a_));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000D574 File Offset: 0x0000B774
		public ushort RangeCount
		{
			get
			{
				short num = (short)1503330305;
				if (num != 0)
				{
				}
				num = (short)785055744;
				switch (num)
				{
				default:
				{
					num = (short)1539178496;
					short num2 = num;
					ushort num3 = 0;
					using (global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator = this.m_ranges.GetEnumerator())
					{
						num = (short)193593347;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 1:
							{
								num = (short)1853188804;
								short num5 = num;
								num = (short)1841916612;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1232273408;
									if (num != 0)
									{
									}
									break;
								}
								num = (short)1349713922;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_18C;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_BA;
								}
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)766377985;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<ushort, global::AcpASKLib.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
								global::AcpASKLib.FieldValueRangeRecSet value = keyValuePair.Value;
								num3 += (ushort)value.Count;
								num = (short)909770752;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_EF:
							num = (short)474873860;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_BA:
							goto IL_EF;
						}
						IL_18C:;
					}
					return num3;
				}
				}
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000D73C File Offset: 0x0000B93C
		internal global::AcpASKLib.AccessNode c(int A_0)
		{
			global::AcpASKLib.AccessNode result = null;
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator = this.accessNodes.GetEnumerator();
			short num;
			try
			{
				num = (short)1212416005;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::AcpASKLib.AccessNode accessNode;
						result = accessNode;
						num = (short)1935343617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_DD;
					case 2:
						goto IL_F9;
					case 3:
					{
						global::AcpASKLib.AccessNode accessNode;
						if (accessNode.ID == (global::AcpASKLib.AccessNodeIDType)A_0)
						{
							num = (short)254738432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)895025154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_51;
						}
						continue;
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1676476420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpASKLib.AccessNode accessNode = enumerator.Current;
						num = (short)383188995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_8F:
					num = (short)181010438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51:
					goto IL_8F;
				}
				IL_DD:
				IL_F9:;
			}
			finally
			{
				num = (short)2087845889;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_18A;
					case 1:
						num = (short)2122776577;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_155;
						}
						continue;
					case 2:
						goto IL_16E;
					}
					IL_155:
					if (enumerator != null)
					{
						num = (short)720764930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18A;
					IL_16E:
					enumerator.Dispose();
					num = (short)50921472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18A:
					num = (short)79944497;
					short num3 = num;
					num = (short)576183089;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16E;
					default:
						goto IL_1BF;
					}
				}
				IL_1BF:
				num = (short)392364032;
				if (num != 0)
				{
				}
			}
			num = (short)956301312;
			short num4 = num;
			return result;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000D958 File Offset: 0x0000BB58
		public bool IsEqual(global::AcpASKLib.AccessRecord inRec)
		{
			short num = (short)1125122048;
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
						if (this.m_bOTAPState != inRec.m_bOTAPState)
						{
							num = (short)2107703316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary = this.a(this);
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary2 = this.a(inRec);
						num = (short)1136590880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						flag = false;
						num = (short)1676804101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (num3 >= 24)
						{
							num = (short)1009188890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1742536712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary2;
						if (dictionary2 == null)
						{
							num = (short)1265958936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					}
					case 4:
						num = (short)899285011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_14A;
					case 6:
						try
						{
							num = (short)1450180610;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3DB;
								case 1:
									num = (short)1126170624;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_252;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1163067393;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<ushort, global::AcpASKLib.FieldValueRangeRecSet> keyValuePair = enumerator.Current;
									global::AcpASKLib.FieldValueRangeRecSet value = keyValuePair.Value;
									num = (short)65342493;
									short num4 = num;
									num = (short)247663645;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_385;
									default:
										num = (short)1636368384;
										if (num != 0)
										{
										}
										num = (short)706543621;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_3BD;
								case 5:
								{
									global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary2;
									global::System.Collections.Generic.KeyValuePair<ushort, global::AcpASKLib.FieldValueRangeRecSet> keyValuePair;
									if (dictionary2.ContainsKey(keyValuePair.Key))
									{
										num = (short)1926496265;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = false;
									num = (short)1226047492;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									flag = false;
									goto IL_385;
								case 7:
									goto IL_39E;
								case 8:
								{
									global::AcpASKLib.FieldValueRangeRecSet value;
									global::AcpASKLib.FieldValueRangeRecSet a_;
									if (!value.a(a_))
									{
										num = (short)1518665734;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary2;
									global::System.Collections.Generic.KeyValuePair<ushort, global::AcpASKLib.FieldValueRangeRecSet> keyValuePair;
									global::AcpASKLib.FieldValueRangeRecSet a_ = dictionary2[keyValuePair.Key];
									num = (short)1464336392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_344:
								num = (short)612171779;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_252:
								goto IL_344;
								IL_385:
								num = (short)2037907463;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39E:
							IL_3BD:
							IL_3DB:
							goto IL_6E7;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_3EE;
					case 7:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary2;
						if (dictionary2.Count == 0)
						{
							num = (short)1012531215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_600;
					}
					case 8:
						if (this.m_FieldCodeArr[num3] != inRec.m_FieldCodeArr[num3])
						{
							num = (short)2052653057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)1919549467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary;
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary2;
						if (dictionary.Count != dictionary2.Count)
						{
							num = (short)781320214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>.Enumerator enumerator = dictionary.GetEnumerator();
						num = (short)1903886342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary;
						if (dictionary != null)
						{
							num = (short)102826007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E7;
					}
					case 11:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary;
						if (dictionary.Count != 0)
						{
							num = (short)1851457536;
							short num5 = num;
							num = (short)628949020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					}
					case 12:
						goto IL_1A0;
					case 13:
						num = (short)1185742855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_528;
					case 15:
						goto IL_3EE;
					case 16:
						if (flag)
						{
							num = (short)1479802897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E7;
					case 17:
						num = (short)574423040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary2;
						if (dictionary2 != null)
						{
							num = (short)1042874397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E7;
					}
					case 19:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary2;
						if (dictionary2 != null)
						{
							num = (short)63701005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EE;
					}
					case 20:
						flag = false;
						num = (short)651362325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_57C;
					case 22:
						flag = false;
						num = (short)1713897484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)1817116690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)1582891033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary;
						if (dictionary != null)
						{
							num = (short)546242591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					}
					case 26:
						goto IL_14A;
					case 27:
						goto IL_528;
					case 28:
						goto IL_600;
					case 29:
						num = (short)1657470985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_D6;
					case 31:
						num = (short)873660427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary;
						if (dictionary == null)
						{
							num = (short)363397124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EE;
					}
					}
					goto IL_B3;
					IL_D6:
					num = (short)1279524874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14A:
					num = (short)1420361744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EE:
					num = (short)612433923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_528:
					num = (short)1195573250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_600:
					flag = false;
					num = (short)779550750;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A0:
				IL_57C:
				IL_6E7:
				num = (short)869007361;
				if (num != 0)
				{
				}
				return flag;
				IL_B3:
				flag = true;
				num3 = 0;
				num = (short)380043278;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000E090 File Offset: 0x0000C290
		private global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> a(global::AcpASKLib.AccessRecord A_0)
		{
			short num = (short)508362752;
			short num2 = num;
			num = (short)1075314688;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary = new global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>();
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator = A_0.AccessNodes.GetEnumerator();
				try
				{
					num = (short)474415107;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							try
							{
								num = (short)74645507;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator2;
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator5;
									switch (num3)
									{
									case 0:
										if (!enumerator2.MoveNext())
										{
											num = (short)1441796;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_7DC;
									case 1:
										try
										{
											num = (short)1930297349;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::AcpASKLib.AccessElement accessElement;
												switch (num3)
												{
												case 0:
													if (((global::AcpASKLib.AccessRangeField)accessElement).AccessLevel == global::AcpASKLib.AccessLevelType.Editable)
													{
														num = (short)1309999105;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 1:
													num = (short)1255604232;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													num = (short)225509376;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													goto IL_76C;
												case 4:
												{
													global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>> list2;
													try
													{
														num = (short)862781446;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
															{
																global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator3;
																if (!enumerator3.MoveNext())
																{
																	num = (short)1496711175;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpASKLib.AccessFieldValueRange accessFieldValueRange = enumerator3.Current;
																uint? num4 = accessFieldValueRange.Maximum;
																num = (short)1372258308;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 1:
																goto IL_3DF;
															case 2:
															{
																global::System.Collections.Generic.List<uint> list = new global::System.Collections.Generic.List<uint>();
																global::AcpASKLib.AccessFieldValueRange accessFieldValueRange;
																uint? num4 = accessFieldValueRange.Minimum;
																uint value = num4.Value;
																list.Add(value);
																num4 = accessFieldValueRange.Maximum;
																value = num4.Value;
																list.Add(value);
																list2.Add(list);
																num = (short)371195912;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 3:
															{
																uint? num4;
																if (num4 != null)
																{
																	num = (short)1459552258;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 4:
															{
																uint? num4;
																if (num4 != null)
																{
																	num = (short)1284964357;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 5:
															{
																global::AcpASKLib.AccessFieldValueRange accessFieldValueRange;
																uint? num4 = accessFieldValueRange.Minimum;
																num = (short)243793923;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 6:
																switch (0)
																{
																case 0:
																	goto IL_28D;
																}
																continue;
															case 7:
																num = (short)1457782785;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_325:
															num = (short)1161035776;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_28D:
															goto IL_325;
														}
														IL_3DF:
														goto IL_558;
													}
													finally
													{
														num = (short)1578762240;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator3;
															switch (num3)
															{
															case 0:
																switch (0)
																{
																case 0:
																	goto IL_418;
																}
																continue;
															case 1:
																enumerator3.Dispose();
																num = (short)1390411778;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 2:
																goto IL_450;
															}
															IL_418:
															if (enumerator3 == null)
															{
																break;
															}
															num = (short)1886584833;
															num3 = (int)((global::System.IntPtr)num);
														}
														IL_450:;
													}
													goto IL_453;
													IL_558:
													list2.Sort(new global::System.Comparison<global::System.Collections.Generic.List<uint>>(global::AcpASKLib.AccessRecord.CompareListsByMin));
													global::AcpASKLib.FieldValueRangeRecSet fieldValueRangeRecSet = new global::AcpASKLib.FieldValueRangeRecSet(((global::AcpASKLib.AccessRangeField)accessElement).Ranges.OwnerID);
													global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>>.Enumerator enumerator4 = list2.GetEnumerator();
													num = (short)1784479754;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 5:
													switch (0)
													{
													case 0:
														goto IL_203;
													}
													continue;
												case 7:
													goto IL_754;
												case 8:
													if (((global::AcpASKLib.AccessRangeField)accessElement).Ranges.Count > 0)
													{
														num = (short)34406412;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 9:
													if (accessElement is global::AcpASKLib.AccessRangeField)
													{
														num = (short)588840962;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 10:
												{
													global::AcpASKLib.FieldValueRangeRecSet fieldValueRangeRecSet;
													try
													{
														num = (short)1296564226;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
															{
																global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>>.Enumerator enumerator4;
																if (!enumerator4.MoveNext())
																{
																	num = (short)2090139651;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::System.Collections.Generic.List<uint> list3 = enumerator4.Current;
																fieldValueRangeRecSet.Add(new global::AcpASKLib.AccessFieldValueRange
																{
																	Minimum = new uint?(list3[0]),
																	Maximum = new uint?(list3[1]),
																	FieldID = (int)((global::AcpASKLib.AccessRangeField)accessElement).Ranges.OwnerID
																});
																num = (short)1545142273;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 2:
															{
																num = (short)1141288045;
																short num5 = num;
																num = (short)1589161069;
																switch ((num5 == num) ? 1 : 0)
																{
																case 0:
																case 2:
																	break;
																default:
																	num = (short)942866432;
																	if (num != 0)
																	{
																	}
																	switch (0)
																	{
																	case 0:
																		goto IL_675;
																	}
																	continue;
																}
																break;
															}
															case 3:
																num = (short)1595932676;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 4:
																goto IL_741;
															}
															IL_6EA:
															num = (short)1899757568;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_675:
															goto IL_6EA;
														}
														IL_741:
														goto IL_521;
													}
													finally
													{
														global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>>.Enumerator enumerator4;
														((global::System.IDisposable)enumerator4).Dispose();
													}
													goto IL_754;
													IL_521:
													dictionary.Add(((global::AcpASKLib.AccessRangeField)accessElement).Ranges.OwnerID, fieldValueRangeRecSet);
													num = (short)2105540614;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 11:
													if (!enumerator5.MoveNext())
													{
														num = (short)781713415;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_453;
												case 12:
												{
													global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>> list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<uint>>();
													global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator3 = ((global::AcpASKLib.AccessRangeField)accessElement).Ranges.GetEnumerator();
													num = (short)1614348292;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_208:
												num = (short)244580363;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_203:
												goto IL_208;
												IL_453:
												accessElement = enumerator5.Current;
												num = (short)954335241;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_754:
												num = (short)99876867;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_76C:
											break;
										}
										finally
										{
											num = (short)825425920;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_7A3;
													}
													continue;
												case 1:
													enumerator5.Dispose();
													num = (short)1888616450;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													goto IL_7D9;
												}
												IL_7A3:
												if (enumerator5 == null)
												{
													break;
												}
												num = (short)5832705;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_7D9:;
										}
										goto IL_7DC;
									case 2:
										goto IL_822;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_168;
										}
										continue;
									case 4:
										num = (short)1297219586;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_16D:
									num = (short)172752896;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_168:
									goto IL_16D;
									IL_7DC:
									enumerator5 = enumerator2.Current.Items.GetEnumerator();
									num = (short)415563777;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_822:
								goto IL_EC;
							}
							finally
							{
								num = (short)1110638592;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator2;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_85A;
										}
										continue;
									case 1:
										enumerator2.Dispose();
										num = (short)571080706;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_890;
									}
									IL_85A:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)2110717953;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_890:;
							}
							goto IL_893;
						case 1:
							goto IL_893;
						case 2:
							goto IL_8AB;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_95;
							}
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)194183169;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator2 = enumerator.Current.Sections.GetEnumerator();
							num = (short)1066336256;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_95;
						IL_EC:
						num = (short)2033844228;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_95:
						num = (short)591134721;
						if (num != 0)
						{
						}
						goto IL_EC;
						IL_893:
						num = (short)1529479170;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_8AB:;
				}
				finally
				{
					num = (short)13565952;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_8E0;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1132724226;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_916;
						}
						IL_8E0:
						if (enumerator == null)
						{
							break;
						}
						num = (short)926023681;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_916:;
				}
				return dictionary;
			}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000EA34 File Offset: 0x0000CC34
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
					return result;
				case 1:
					return result;
				case 2:
					result = 1;
					num2 = (short)1038024705;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					num2 = (short)179240965;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (y == null)
					{
						num2 = (short)192151558;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = -1;
					goto IL_B8;
				case 6:
				{
					num2 = (short)1647373523;
					short num3 = num2;
					num2 = (short)2014768339;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B8;
					default:
						num2 = (short)496173056;
						if (num2 != 0)
						{
						}
						result = 0;
						num2 = (short)300417025;
						if (num2 != 0)
						{
						}
						num2 = (short)816054280;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					if (x == null)
					{
						num2 = (short)1932460032;
						short num4 = num2;
						num2 = (short)1721171972;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)189726729;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return result;
				case 9:
					if (y == null)
					{
						num2 = (short)1854865410;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = x[0].CompareTo(y[0]);
					num2 = (short)1040842752;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_B8:
				num2 = (short)613875715;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_38:
			result = 0;
			num2 = (short)1658978311;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600008A RID: 138 RVA: 0x0000EC44 File Offset: 0x0000CE44
		// (remove) Token: 0x0600008B RID: 139 RVA: 0x0000ED7C File Offset: 0x0000CF7C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_B1;
					case 1:
						num2 = (short)1976958977;
						if (num2 != 0)
						{
						}
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)911278082;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B1;
					case 2:
						return;
					}
					goto IL_1C;
					IL_B1:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)1765801985;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				num2 = (short)128210535;
				short num3 = num2;
				num2 = (short)1380275815;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)1179779072;
					short num4 = num2;
					num2 = (short)1097465856;
					if (num2 != 0)
					{
					}
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
					break;
				}
				}
				num2 = (short)292290560;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_D7;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)150274050;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D7;
					case 2:
						return;
					}
					goto IL_1C;
					IL_D7:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)1783169025;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				num2 = (short)1674063017;
				short num3 = num2;
				num2 = (short)1069100201;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)41746432;
					short num4 = num2;
					num2 = (short)1821573121;
					if (num2 != 0)
					{
					}
					num2 = (short)485425152;
					if (num2 != 0)
					{
					}
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
					break;
				}
				}
				num2 = (short)632684544;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
		private void a(string A_0)
		{
			short num = (short)1381040128;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
				{
					num = (short)912926984;
					short num3 = num;
					num = (short)1584277768;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)2013069312;
						if (num != 0)
						{
						}
						this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
						num = (short)1713176578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				IL_32:
				if (this.PropertyChanged == null)
				{
					break;
				}
				num = (short)789577728;
				short num4 = num;
				num = (short)399900673;
				if (num != 0)
				{
				}
				num = (short)887619585;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x040000E1 RID: 225
		private global::AcpASKLib.AccessRecordSetX<global::AcpASKLib.AccessNode> accessNodes;

		// Token: 0x040000E2 RID: 226
		private int m_id;

		// Token: 0x040000E3 RID: 227
		private int primaryKey;

		// Token: 0x040000E4 RID: 228
		private string m_name;

		// Token: 0x040000E5 RID: 229
		private global::AcpASKLib.FeatureCategoryType m_recType;

		// Token: 0x040000E6 RID: 230
		private byte[] m_FieldCodeArr;

		// Token: 0x040000E7 RID: 231
		private bool m_bOTAPState;

		// Token: 0x040000E8 RID: 232
		private bool m_bInUseFlag;

		// Token: 0x040000E9 RID: 233
		private global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> m_ranges;

		// Token: 0x040000EA RID: 234
		private global::AcpASKLib.FeatureCategoryRadioType m_radioType;
	}
}
