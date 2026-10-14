using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using AcpASKLib;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCryptoLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Security
{
	// Token: 0x02000046 RID: 70
	public static class FieldMapManager
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x00077190 File Offset: 0x00075390
		static FieldMapManager()
		{
			short num = (short)1046607052;
			short num2 = num;
			num = (short)880538828;
			switch (num2 == num)
			{
			}
			num = (short)478609409;
			if (num != 0)
			{
			}
			num = (short)1079771136;
			short num3 = num;
			num = (short)482738176;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Security.FieldMapManager.a = null;
			global::SpecialFeatures.Security.FieldMapManager.b = null;
			global::SpecialFeatures.Security.FieldMapManager.c = new global::System.Type[6];
			global::SpecialFeatures.Security.FieldMapManager.c[0] = typeof(global::SpecialFeatures.Security.KeyFeature);
			global::SpecialFeatures.Security.FieldMapManager.c[1] = typeof(global::SpecialFeatures.Security.Feature);
			global::SpecialFeatures.Security.FieldMapManager.c[2] = typeof(global::SpecialFeatures.Security.FieldMapInfo);
			global::SpecialFeatures.Security.FieldMapManager.c[3] = typeof(global::SpecialFeatures.Security.KeyFieldMapInfo);
			global::SpecialFeatures.Security.FieldMapManager.c[4] = typeof(global::SpecialFeatures.Security.RefKeyFieldMapInfo);
			global::SpecialFeatures.Security.FieldMapManager.c[5] = typeof(global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.FieldMapInfo>);
			global::SpecialFeatures.Security.FieldMapManager.b = new global::System.Collections.Generic.Dictionary<string, global::SpecialFeatures.Security.FieldMapInfo>();
			global::SpecialFeatures.Security.FieldMapManager.b();
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000772C8 File Offset: 0x000754C8
		private static void b()
		{
			short num = (short)976224258;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					global::SpecialFeatures.Security.FieldMapManager.a();
					num = (short)290455553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)746129128;
					short num3 = num;
					num = (short)1163724520;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_63;
					default:
						goto IL_C8;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				goto IL_31;
				IL_63:
				num = (short)1637679104;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_31:
				num = (short)428212225;
				if (num != 0)
				{
				}
				if (global::SpecialFeatures.Security.FieldMapManager.a == null)
				{
					goto IL_63;
				}
				return;
			}
			IL_C8:
			num = (short)858062848;
			if (num != 0)
			{
			}
			num = (short)1280245760;
			short num4 = num;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000773DC File Offset: 0x000755DC
		private static void a()
		{
			int a_ = 3;
			short num = (short)961150976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Xml.XmlNodeReader xmlNodeReader = null;
				try
				{
					global::System.IO.Stream manifestResourceStream = global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햅ﺑ튓聯얟톡誣춧즩\ud9ab\udcad\ud9af욱춳颵\ud9b7쪹쒻\ud8bd趿ꏁ듃", a_));
					xmlNodeReader = new global::System.Xml.XmlNodeReader(new global::AcpCryptoLib.AcpXMLEncryptDecrypt().DecryptXMLFile(manifestResourceStream).DocumentElement);
					global::SpecialFeatures.Security.FieldMapManager.a = (global::System.Collections.ArrayList)new global::System.Xml.Serialization.XmlSerializer(typeof(global::System.Collections.ArrayList), global::SpecialFeatures.Security.FieldMapManager.c).Deserialize(xmlNodeReader);
					global::System.Collections.IEnumerator enumerator = global::SpecialFeatures.Security.FieldMapManager.a.GetEnumerator();
					try
					{
						num = (short)1601830915;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_26F;
							case 1:
								goto IL_287;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1420034048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::SpecialFeatures.Security.Feature feature = (global::SpecialFeatures.Security.Feature)enumerator.Current;
								global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.FieldMapInfo> enumerator2 = feature.FieldMap.GetEnumerator();
								num = (short)1964769284;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_C5;
								}
								continue;
							case 4:
								try
								{
									num = (short)1366294531;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											num = (short)1328021505;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_1FD;
										case 2:
										{
											global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.FieldMapInfo> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)2125791232;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo = enumerator2.Current;
											global::SpecialFeatures.Security.Feature feature;
											fieldMapInfo.ParentFeature = feature;
											global::SpecialFeatures.Security.FieldMapManager.b.Add(fieldMapInfo.CPSFieldName, fieldMapInfo);
											num = (short)239337476;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											switch (0)
											{
											case 0:
												goto IL_16D;
											}
											continue;
										}
										IL_1AC:
										num = (short)111214594;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_16D:
										goto IL_1AC;
									}
									IL_1FD:
									break;
								}
								finally
								{
									num = (short)2132738050;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.FieldMapInfo> enumerator2;
										switch (num2)
										{
										case 0:
											enumerator2.Dispose();
											num = (short)786432001;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_26C;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_234;
											}
											continue;
										}
										IL_234:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)286720000;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_26C:;
								}
								goto IL_26F;
							}
							IL_F8:
							num = (short)100532226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C5:
							goto IL_F8;
							IL_26F:
							num = (short)1748107265;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_287:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_2A9;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_296:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)622657537;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_350;
							case 2:
							{
								if (disposable == null)
								{
									goto IL_352;
								}
								num = (short)877175747;
								short num3 = num;
								num = (short)374907843;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_350;
								default:
									num = (short)50331648;
									if (num != 0)
									{
									}
									num = (short)995753984;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							goto IL_2A9;
						}
						IL_350:
						IL_352:
						goto EndFinally_15;
						IL_2A9:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)632487938;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_296;
						EndFinally_15:;
					}
				}
				catch (global::System.Exception)
				{
					global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Internal_Error_Critical_File_Mis_Crpt_0xC01);
					global::System.Environment.Exit(3074);
				}
				finally
				{
					num = (short)73990146;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							xmlNodeReader.Close();
							num = (short)1489174529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3DB;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3A4;
							}
							continue;
						}
						IL_3A4:
						if (xmlNodeReader == null)
						{
							break;
						}
						num = (short)443744256;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3DB:;
				}
				num = (short)284622848;
				short num4 = num;
				num = (short)580780033;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x0007787C File Offset: 0x00075A7C
		public static global::System.Collections.ArrayList Features
		{
			get
			{
				short num = (short)205685275;
				short num2 = num;
				num = (short)1378255387;
				switch (num2 == num)
				{
				}
				num = (short)884473857;
				if (num != 0)
				{
				}
				num = (short)1733033984;
				short num3 = num;
				num = (short)567672832;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Security.FieldMapManager.a;
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00077930 File Offset: 0x00075B30
		internal static global::SpecialFeatures.Security.Feature GetFeature(string name)
		{
			short num = (short)1182728193;
			if (num != 0)
			{
			}
			num = (short)34013184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1836711936;
				short num3 = num;
				global::SpecialFeatures.Security.Feature result = null;
				global::System.Collections.IEnumerator enumerator = global::SpecialFeatures.Security.FieldMapManager.Features.GetEnumerator();
				try
				{
					num = (short)915537923;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::SpecialFeatures.Security.Feature feature;
						switch (num2)
						{
						case 0:
							goto IL_1A9;
						case 1:
							num = (short)1576992772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_120;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_BF;
							}
							continue;
						case 4:
							goto IL_1C6;
						case 5:
						{
							num = (short)502940458;
							short num4 = num;
							num = (short)293618474;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_120;
							default:
								num = (short)750911488;
								if (num != 0)
								{
								}
								result = feature;
								num = (short)566427648;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							if (feature.Name == name)
							{
								num = (short)1037762565;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						goto IL_BF;
						IL_120:
						if (!enumerator.MoveNext())
						{
							num = (short)544538625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						feature = (global::SpecialFeatures.Security.Feature)enumerator.Current;
						num = (short)1046937606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_107:
						num = (short)831455234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_BF:
						goto IL_107;
					}
					IL_1A9:
					IL_1C6:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_1E5;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_1D2:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)1881473025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_239;
						case 2:
							if (disposable != null)
							{
								num = (short)810221568;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_23B;
						}
						goto IL_1E5;
					}
					IL_239:
					IL_23B:
					goto EndFinally_6;
					IL_1E5:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1355350018;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_1D2;
					EndFinally_6:;
				}
				return result;
			}
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00077B98 File Offset: 0x00075D98
		internal static global::SpecialFeatures.Security.Feature GetFeature(global::SpecialFeatures.Security.CpsFeatureID id)
		{
			short num = (short)747569152;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)329449473;
				if (num != 0)
				{
				}
				num = (short)1639579648;
				short num3 = num;
				global::SpecialFeatures.Security.Feature result = null;
				global::System.Collections.IEnumerator enumerator = global::SpecialFeatures.Security.FieldMapManager.Features.GetEnumerator();
				try
				{
					num = (short)354353155;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::SpecialFeatures.Security.Feature feature;
						switch (num2)
						{
						case 0:
							goto IL_1A2;
						case 1:
							num = (short)264437764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_11B;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_C0;
							}
							continue;
						case 4:
							goto IL_1BF;
						case 5:
						{
							num = (short)562852394;
							short num4 = num;
							num = (short)1785688618;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_11B;
							default:
								num = (short)954662912;
								if (num != 0)
								{
								}
								result = feature;
								num = (short)2099445760;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							if (feature.FeatureID == id)
							{
								num = (short)113836037;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						goto IL_C0;
						IL_11B:
						if (!enumerator.MoveNext())
						{
							num = (short)1781006337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						feature = (global::SpecialFeatures.Security.Feature)enumerator.Current;
						num = (short)695402502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_105:
						num = (short)1938030594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C0:
						goto IL_105;
					}
					IL_1A2:
					IL_1BF:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_1DE;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_1CB:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)1691680769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_230;
						case 2:
							if (disposable != null)
							{
								num = (short)1400111104;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_232;
						}
						goto IL_1DE;
					}
					IL_230:
					IL_232:
					goto EndFinally_6;
					IL_1DE:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1762525186;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_1CB;
					EndFinally_6:;
				}
				return result;
			}
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00077DF8 File Offset: 0x00075FF8
		internal static global::SpecialFeatures.Security.FieldMapInfo GetFieldMapInfo(string cpsFieldName)
		{
			int num;
			global::SpecialFeatures.Security.FieldMapInfo result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						result = global::SpecialFeatures.Security.FieldMapManager.b[cpsFieldName];
						num2 = (short)1226113025;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_7A;
					case 2:
						if (global::SpecialFeatures.Security.FieldMapManager.b.ContainsKey(cpsFieldName))
						{
							num2 = (short)1097138176;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					goto IL_1C;
				}
				IL_7A:
				num2 = (short)197680169;
				short num3 = num2;
				num2 = (short)276192297;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1E;
				default:
				{
					num2 = (short)43646976;
					short num4 = num2;
					num2 = (short)1400766465;
					if (num2 != 0)
					{
					}
					num2 = (short)1601372160;
					if (num2 != 0)
					{
					}
					break;
				}
				}
				return result;
			}
			}
			IL_1C:
			result = null;
			IL_1E:
			num2 = (short)1589903362;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00077F20 File Offset: 0x00076120
		private static global::SpecialFeatures.Security.FieldMapInfo a(string A_0, global::AcpASKLib.KeyType A_1)
		{
			short num = (short)913440768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::SpecialFeatures.Security.FieldMapInfo result;
				global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo2;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.FieldMapInfo> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_321;
					case 1:
						try
						{
							num = (short)1999831048;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
									result = (global::SpecialFeatures.Security.KeyFieldMapInfo)fieldMapInfo;
									num = (short)291700741;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
									result = (global::SpecialFeatures.Security.RefKeyFieldMapInfo)fieldMapInfo;
									num = (short)681115659;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1512833031;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_296;
								case 4:
									goto IL_2AF;
								case 5:
									goto IL_1FE;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1490092035;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo = enumerator.Current;
									num = (short)217776137;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									num = (short)638102609;
									short num3 = num;
									num = (short)1867295825;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_296;
									default:
									{
										num = (short)1785528320;
										if (num != 0)
										{
										}
										global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
										if (((global::SpecialFeatures.Security.KeyFieldMapInfo)fieldMapInfo).Type == A_1)
										{
											num = (short)123469824;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_F8;
									}
									continue;
								case 9:
								{
									global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
									if (fieldMapInfo is global::SpecialFeatures.Security.KeyFieldMapInfo)
									{
										num = (short)18677762;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)375521290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
									if (fieldMapInfo is global::SpecialFeatures.Security.RefKeyFieldMapInfo)
									{
										num = (short)1096548353;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
									goto IL_11A;
								}
								IL_19E:
								num = (short)562692102;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F8:
								goto IL_19E;
								IL_296:
								num = (short)689569796;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_11A:
							IL_1FE:
							IL_2AF:
							goto IL_350;
						}
						finally
						{
							num = (short)1816199170;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1972895745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_31E;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2E6;
									}
									continue;
								}
								IL_2E6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1807089664;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_31E:;
						}
						goto IL_321;
					case 2:
						if (fieldMapInfo2 != null)
						{
							num = (short)552796160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_350;
					}
					goto IL_3A;
					IL_321:
					enumerator = fieldMapInfo2.ParentFeature.FieldMap.GetEnumerator();
					num = (short)1093271553;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_350:
				num = (short)630784000;
				short num4 = num;
				return result;
				IL_3A:
				result = null;
				fieldMapInfo2 = global::SpecialFeatures.Security.FieldMapManager.GetFieldMapInfo(A_0);
				num = (short)91619329;
				if (num != 0)
				{
				}
				num = (short)1905131522;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000782C4 File Offset: 0x000764C4
		private static global::SpecialFeatures.Security.FieldMapInfo a(global::SpecialFeatures.Security.Feature A_0, global::AcpASKLib.KeyType A_1)
		{
			global::SpecialFeatures.Security.FieldMapInfo result = null;
			global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.FieldMapInfo> enumerator = A_0.FieldMap.GetEnumerator();
			short num;
			try
			{
				num = (short)1117388808;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1E1;
					case 1:
					{
						global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
						if (fieldMapInfo is global::SpecialFeatures.Security.KeyFieldMapInfo)
						{
							num = (short)1579155462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)678625285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1069940746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo = enumerator.Current;
						num = (short)22806529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_13D;
					case 4:
						goto IL_1FE;
					case 5:
					{
						global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
						if (fieldMapInfo is global::SpecialFeatures.Security.RefKeyFieldMapInfo)
						{
							num = (short)658964487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						num = (short)2132934667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
						result = fieldMapInfo;
						num = (short)2129002499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_66;
						}
						continue;
					case 9:
					{
						num = (short)769630944;
						short num3 = num;
						num = (short)481600224;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E6;
						default:
						{
							num = (short)761856000;
							if (num != 0)
							{
							}
							global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
							result = fieldMapInfo;
							num = (short)1278345216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 10:
						goto IL_1E6;
					case 11:
					{
						global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
						if (((global::SpecialFeatures.Security.KeyFieldMapInfo)fieldMapInfo).Type == A_1)
						{
							num = (short)103219209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_A3:
					num = (short)1292107778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_66:
					goto IL_A3;
					IL_1E6:
					num = (short)747241476;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13D:
				IL_1E1:
				IL_1FE:;
			}
			finally
			{
				num = (short)1442775042;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1456275457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_266;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_230;
						}
						continue;
					}
					IL_230:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1859059712;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_266:;
			}
			num = (short)1151598592;
			short num4 = num;
			num = (short)1152843777;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000785A8 File Offset: 0x000767A8
		internal static global::AcpASKLib.AccessElementIDType GetElementID(global::AcpCommonLib.IAcpField self)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpASKLib.AccessElementIDType result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1519730151;
					short num3 = num2;
					num2 = (short)935804391;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)2080112640;
						if (num2 != 0)
						{
						}
						global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
						if (fieldMapInfo != null)
						{
							num2 = (short)369229826;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 1:
					return result;
				case 2:
				{
					global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
					result = fieldMapInfo.ID;
					num2 = (short)125173761;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					num2 = (short)739704833;
					if (num2 != 0)
					{
					}
					global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo = global::SpecialFeatures.Security.FieldMapManager.GetFieldMapInfo(self.Name);
					num2 = (short)2490368;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (self != null)
					{
						num2 = (short)1033109507;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)1584201728;
			short num4 = num2;
			result = global::AcpASKLib.AccessElementIDType.UNDEFINED;
			num2 = (short)975634436;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00078710 File Offset: 0x00076910
		internal static global::AcpASKLib.KeyType GetTrunkingKeyType(global::AcpCommonLib.IAcpFeatureNode cpsTrkSysNode)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::AcpASKLib.KeyType result;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1976893446;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1298661377;
					if (num2 != 0)
					{
					}
					result = global::AcpASKLib.KeyType.ADVANCED_WACN_KEY;
					num2 = (short)1735065602;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
					if (trunkingSystem.General.TrkSysGeneralCoverageType_A7782.Valid)
					{
						num2 = (short)1835008;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_191;
				case 4:
					if (trunkingSystem != null)
					{
						num2 = (short)1877540871;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 5:
					return result;
				case 6:
					if (trunkingSystem.General.TrkSysGeneralCoverageType_A7782.Value == 5)
					{
						num2 = (short)1249705985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_191;
				case 7:
				{
					num2 = (short)1450034408;
					short num3 = num2;
					num2 = (short)2040710376;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1454440448;
						if (num2 != 0)
						{
						}
						num2 = (short)796000259;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_30;
				IL_191:
				result = global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
				num2 = (short)18153472;
				short num4 = num2;
				num2 = (short)912850949;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_30:
			result = global::AcpASKLib.KeyType.UNDEFINED_KEY;
			trunkingSystem = (cpsTrkSysNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			num2 = (short)1244921860;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000788F8 File Offset: 0x00076AF8
		internal static global::AcpCommonLib.IAcpField GetTrunkingSysIDField(global::AcpCommonLib.IAcpFeatureNode cpsTrkSysNode)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			global::AcpCommonLib.IAcpField result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = trunkingSystem.General.TrkSysGeneralHomeWACNID_A8205;
					num2 = (short)848429057;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_15C;
				case 2:
				{
					global::AcpASKLib.KeyType trunkingKeyType;
					if (trunkingKeyType == global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY)
					{
						num2 = (short)598999046;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15C;
				}
				case 3:
				{
					global::AcpASKLib.KeyType trunkingKeyType;
					if (trunkingKeyType == global::AcpASKLib.KeyType.ADVANCED_WACN_KEY)
					{
						num2 = (short)1223098368;
						short num3 = num2;
						num2 = (short)954728448;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)549519362;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (trunkingSystem != null)
					{
						num2 = (short)691339271;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15C;
				case 5:
					goto IL_15C;
				case 6:
					IL_9D:
					result = trunkingSystem.General.TrkSysGeneralSystemID_A9239;
					num2 = (short)543817733;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					global::AcpASKLib.KeyType trunkingKeyType = global::SpecialFeatures.Security.FieldMapManager.GetTrunkingKeyType(trunkingSystem);
					num2 = (short)1528627203;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_30;
				IL_15C:
				num2 = (short)514328839;
				short num4 = num2;
				num2 = (short)1209927943;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_9D;
				default:
					goto IL_192;
				}
			}
			IL_192:
			num2 = (short)160104449;
			if (num2 != 0)
			{
			}
			num2 = (short)2113404928;
			if (num2 != 0)
			{
			}
			return result;
			IL_30:
			result = null;
			trunkingSystem = (cpsTrkSysNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			num2 = (short)520749060;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00078AD8 File Offset: 0x00076CD8
		internal static bool GetTrkSysGeneralAskRequired(global::AcpCommonLib.IAcpFeatureNode cpsTrkSysNode)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1208421693;
					short num3 = num2;
					num2 = (short)68685117;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)69206016;
						if (num2 != 0)
						{
						}
						if (trunkingSystem.General == null)
						{
							return result;
						}
						break;
					}
					num2 = (short)1463549954;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_AA;
				case 2:
					result = trunkingSystem.General.TrkSysGeneralAskRequired_A44909Value;
					num2 = (short)1540554753;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1903886336;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (trunkingSystem != null)
					{
						num2 = (short)400687104;
						short num4 = num2;
						num2 = (short)485359619;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			IL_AA:
			num2 = (short)216793089;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = false;
			trunkingSystem = (cpsTrkSysNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			num2 = (short)1925775364;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00078C44 File Offset: 0x00076E44
		internal static void GetKeyFieldInfo(global::AcpCommonLib.IAcpField self, out global::AcpASKLib.KeyType type, out global::AcpCommonLib.IAcpField sysIDField, out bool trkSysGeneralAskRequired)
		{
			short num = (short)1743978496;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1078132739;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1540358148;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)101912763;
									short num3 = num;
									num = (short)116265147;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1B6;
									default:
									{
										num = (short)144572416;
										if (num != 0)
										{
										}
										global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.FieldMapInfo> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)861995008;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo = enumerator.Current;
										num = (short)1926758405;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 2:
								{
									global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
									string cpsfieldName = ((global::SpecialFeatures.Security.RefKeyFieldMapInfo)fieldMapInfo).CPSFieldName;
									acpFeatureNode = global::SpecialFeatures.Security.FieldMapManager.b(acpFeatureNode2, cpsfieldName);
									global::SpecialFeatures.Security.KeyFeature keyFeature = (global::SpecialFeatures.Security.KeyFeature)global::SpecialFeatures.Security.FieldMapManager.GetFeature(((global::SpecialFeatures.Security.RefKeyFieldMapInfo)fieldMapInfo).ReferencedFeatureName);
									num = (short)531824646;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_13E;
									}
									continue;
								case 4:
									goto IL_275;
								case 5:
								{
									global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
									if (fieldMapInfo is global::SpecialFeatures.Security.RefKeyFieldMapInfo)
									{
										goto IL_1B6;
									}
									break;
								}
								case 6:
									goto IL_188;
								}
								goto IL_13E;
								IL_1B6:
								num = (short)1999962114;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D4:
								num = (short)1916928001;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13E:
								goto IL_1D4;
							}
							IL_188:
							IL_275:
							goto IL_C1;
						}
						finally
						{
							num = (short)817364994;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.FieldMapInfo> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1191182337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2E3;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2AC;
									}
									continue;
								}
								IL_2AC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1507000320;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E3:;
						}
						goto IL_2E6;
					case 1:
					{
						num = (short)1105526785;
						if (num != 0)
						{
						}
						global::SpecialFeatures.Security.Feature feature;
						if (feature is global::SpecialFeatures.Security.KeyFeature)
						{
							num = (short)741736453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.FieldMapInfo> enumerator = feature.FieldMap.GetEnumerator();
						num = (short)315490304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						type = global::AcpASKLib.KeyType.ADVANCED_CONV_SYSTEM_KEY;
						num = (short)1077805063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::SpecialFeatures.Security.Feature feature;
						if (feature.Type == global::AcpASKLib.FeatureCategoryType.TRUNKING)
						{
							num = (short)937492486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2048262157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_2E6;
					case 5:
					{
						acpFeatureNode = acpFeatureNode2;
						global::SpecialFeatures.Security.Feature feature;
						global::SpecialFeatures.Security.KeyFeature keyFeature2 = (global::SpecialFeatures.Security.KeyFeature)feature;
						num = (short)1506344972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						acpFeatureNode = null;
						num = (short)1508835329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return;
					case 8:
						if (acpFeatureNode2 != null)
						{
							num = (short)1333395467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
					{
						global::SpecialFeatures.Security.Feature feature;
						if (feature != null)
						{
							num = (short)2118713348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 10:
						goto IL_F7;
					case 11:
					{
						global::SpecialFeatures.Security.Feature feature = global::SpecialFeatures.Security.FieldMapManager.GetFeature((global::SpecialFeatures.Security.CpsFeatureID)acpFeatureNode2.Parent.RecsetId);
						num = (short)222625801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						num = (short)1432616960;
						short num4 = num;
						goto IL_C1;
					}
					case 13:
					{
						global::SpecialFeatures.Security.Feature feature;
						if (feature.Type == global::AcpASKLib.FeatureCategoryType.CONVENTIONAL)
						{
							num = (short)1279066114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 14:
						if (acpFeatureNode != null)
						{
							num = (short)1623982090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_6A;
					IL_C1:
					num = (short)1702428686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E6:
					num = (short)627441667;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F7:
				type = global::SpecialFeatures.Security.FieldMapManager.GetTrunkingKeyType(acpFeatureNode);
				sysIDField = global::SpecialFeatures.Security.FieldMapManager.GetTrunkingSysIDField(acpFeatureNode);
				trkSysGeneralAskRequired = global::SpecialFeatures.Security.FieldMapManager.GetTrkSysGeneralAskRequired(acpFeatureNode);
				return;
				IL_6A:
				type = global::AcpASKLib.KeyType.UNDEFINED_KEY;
				sysIDField = null;
				trkSysGeneralAskRequired = false;
				acpFeatureNode2 = global::SpecialFeatures.Security.FieldMapManager.b(self.Parent.Parent);
				num = (short)2129657864;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00079138 File Offset: 0x00077338
		private static global::AcpCommonLib.IAcpFeatureNode b(global::AcpCommonLib.IAcpFeatureNode A_0, string A_1)
		{
			short num = (short)1104281600;
			short num2 = num;
			num = (short)1862533120;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				global::AcpCommonLib.IAcpFeatureNode result;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				for (;;)
				{
					IL_51:
					bool flag;
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
					switch (num3)
					{
					case 0:
						try
						{
							num = (short)548012033;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									if (flag)
									{
										num = (short)1868562439;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_EC;
									}
									continue;
								case 2:
									goto IL_3E1;
								case 3:
									goto IL_3C9;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2070020099;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2 = ((global::AcpBusinessLayer.FeatureSection)enumerator.Current).FieldsCollection.GetEnumerator();
									num = (short)302514181;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									try
									{
										num = (short)1136197634;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
											{
												global::AcpCommonLib.IAcpField acpField;
												result = ((global::AcpBusinessLayer.AcpRecRefField)acpField).ReferencedNode;
												flag = true;
												num = (short)321060869;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												goto IL_30E;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_1FD;
												}
												continue;
											case 3:
												num = (short)1622147076;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												global::AcpCommonLib.IAcpField acpField;
												if (acpField.Name == A_1)
												{
													num = (short)220004352;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
												goto IL_260;
											case 6:
												num = (short)1676083201;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1050542086;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpField acpField = enumerator2.Current;
												num = (short)2049114120;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
											{
												global::AcpCommonLib.IAcpField acpField;
												if (acpField is global::AcpBusinessLayer.AcpRecRefField)
												{
													num = (short)705363971;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_1FF:
											num = (short)1628307463;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_1FD:
											goto IL_1FF;
										}
										IL_260:
										IL_30E:
										goto IL_13B;
									}
									finally
									{
										num = (short)1107244324;
										short num4 = num;
										num = (short)727397668;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)1730281472;
											if (num != 0)
											{
											}
											num = (short)1699610625;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
												switch (num3)
												{
												case 0:
													goto IL_3C6;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_38E;
													}
													continue;
												case 2:
													enumerator2.Dispose();
													num = (short)1102184448;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_38E:
												if (enumerator2 == null)
												{
													break;
												}
												num = (short)538116098;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_3C6:
											break;
										}
									}
									goto IL_3C9;
									IL_13B:
									num = (short)1053884416;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_106;
								case 7:
									num = (short)978845702;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_171:
								num = (short)395182084;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_EC:
								goto IL_171;
								IL_3C9:
								num = (short)236847106;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_106:
							IL_3E1:
							return result;
						}
						finally
						{
							num = (short)898367489;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_44E;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_418;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)729546752;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_418:
								if (enumerator == null)
								{
									break;
								}
								num = (short)829030402;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_44E:;
						}
						goto IL_451;
					case 1:
						if (acpFeatureNode != null)
						{
							num = (short)1883373570;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						goto IL_451;
					}
					goto IL_64;
					IL_451:
					num = (short)683999233;
					if (num != 0)
					{
					}
					flag = false;
					enumerator = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
					num = (short)1632960512;
					num3 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_64:
				result = null;
				acpFeatureNode = global::SpecialFeatures.Security.FieldMapManager.b(A_0);
				num = (short)208732161;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00079620 File Offset: 0x00077820
		private static global::AcpCommonLib.IAcpField a(global::AcpCommonLib.IAcpFeatureNode A_0, string A_1)
		{
			short num = (short)1237712896;
			switch (num)
			{
			default:
			{
				num = (short)2122711040;
				short num2 = num;
				num = (short)1837105153;
				if (num != 0)
				{
				}
				global::AcpCommonLib.IAcpField acpField = null;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = A_0.FeatureSectionsCollection.GetEnumerator();
				try
				{
					num = (short)1513029633;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							try
							{
								num = (short)1095630853;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_1A2;
									case 1:
										goto IL_1BF;
									case 2:
									{
										global::AcpCommonLib.IAcpField acpField2;
										if (acpField2.Name == A_1)
										{
											num = (short)1569849348;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										num = (short)1697120257;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::AcpCommonLib.IAcpField acpField2;
										acpField = acpField2;
										num = (short)1444478976;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										switch (0)
										{
										case 0:
											goto IL_10B;
										}
										continue;
									case 6:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)657784835;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpField acpField2 = enumerator2.Current;
										num = (short)642908162;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_14F:
									num = (short)1525153798;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_10B:
									goto IL_14F;
								}
								IL_1A2:
								IL_1BF:
								goto IL_309;
							}
							finally
							{
								num = (short)1098838761;
								short num4 = num;
								num = (short)1642525417;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1991704576;
									if (num != 0)
									{
									}
									num = (short)1357774849;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
										switch (num3)
										{
										case 0:
											goto IL_277;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_241;
											}
											continue;
										case 2:
											enumerator2.Dispose();
											num = (short)1731788800;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_241:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)1455030274;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_277:
									break;
								}
							}
							break;
							IL_309:
							num = (short)1529282564;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_C4;
							}
							continue;
						case 2:
							goto IL_35A;
						case 3:
							num = (short)1994391559;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (acpField != null)
							{
								num = (short)1177550851;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 5:
							num = (short)1680080898;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)771096581;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2 = ((global::AcpBusinessLayer.FeatureSection)enumerator.Current).FieldsCollection.GetEnumerator();
							num = (short)723189760;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_304;
						}
						IL_27A:
						num = (short)422445062;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C4:
						goto IL_27A;
					}
					IL_304:
					IL_35A:;
				}
				finally
				{
					num = (short)1179582465;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_3C5;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_38F;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)2120482816;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_38F:
						if (enumerator == null)
						{
							break;
						}
						num = (short)466944002;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3C5:;
				}
				return acpField;
			}
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00079A2C File Offset: 0x00077C2C
		private static global::AcpCommonLib.IAcpFeatureNode b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_74;
				case 1:
					if (A_0.Parent.IsEmbeddedRecset)
					{
						num2 = (short)1097138178;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = A_0;
					num2 = (short)1577713664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1163631715;
					short num3 = num2;
					num2 = (short)1555668067;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_45;
					default:
						num2 = (short)467468288;
						if (num2 != 0)
						{
						}
						result = global::SpecialFeatures.Security.FieldMapManager.a(A_0);
						num2 = (short)642187269;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					num2 = (short)1723924481;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (A_0 != null)
					{
						goto IL_45;
					}
					goto IL_150;
				case 5:
					goto IL_E2;
				}
				goto IL_28;
				IL_45:
				num2 = (short)277282819;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_74:
			goto IL_150;
			IL_E2:
			num2 = (short)1718550529;
			if (num2 != 0)
			{
			}
			IL_150:
			num2 = (short)6815744;
			short num4 = num2;
			return result;
			IL_28:
			result = null;
			num2 = (short)652869636;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00079BB8 File Offset: 0x00077DB8
		private static global::AcpCommonLib.IAcpFeatureNode a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_AA;
			}
			short num;
			int num4;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				num = (short)28364759;
				short num2 = num;
				num = (short)265998295;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1AD;
				case 1:
					break;
				default:
				{
					num = (short)1265303552;
					short num3 = num;
					break;
				}
				}
				num = (short)1076625408;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					num = (short)2019622920;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return result;
				case 2:
					if (A_0 != null)
					{
						num = (short)1609760775;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
				{
					global::AcpCommonLib.IAcpFeatureSection parentSection = A_0.Parent.ParentSection;
					num = (short)1939210246;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					IL_1AD:
					if (A_0.Parent != null)
					{
						num = (short)91881472;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 5:
				{
					global::AcpCommonLib.IAcpFeatureSection parentSection;
					result = parentSection.Parent;
					num = (short)97517569;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
				{
					global::AcpCommonLib.IAcpFeatureSection parentSection;
					if (parentSection != null)
					{
						num = (short)1583677445;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				case 7:
					num = (short)1990459396;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)1679884289;
					if (num != 0)
					{
					}
					if (A_0.Parent.IsEmbeddedRecset)
					{
						num = (short)1992425475;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_AA;
			}
			return result;
			IL_AA:
			result = null;
			num = (short)762773506;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040002F4 RID: 756
		private static global::System.Collections.ArrayList a;

		// Token: 0x040002F5 RID: 757
		private static global::System.Collections.Generic.Dictionary<string, global::SpecialFeatures.Security.FieldMapInfo> b;

		// Token: 0x040002F6 RID: 758
		private static global::System.Type[] c;
	}
}
