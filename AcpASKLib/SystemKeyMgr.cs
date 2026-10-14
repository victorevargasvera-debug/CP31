using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using AcpCommonResources;
using AcpKeyValidatorLib;
using AcpUtility;
using IBtnWrapperLib;

namespace AcpASKLib
{
	// Token: 0x0200003B RID: 59
	public class SystemKeyMgr : global::AcpASKLib.ISystemKeyMgr
	{
		// Token: 0x0600018B RID: 395 RVA: 0x00029C0C File Offset: 0x00027E0C
		public SystemKeyMgr()
		{
			int a_ = 2;
			base..ctor();
			this.b = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData>();
			this.a = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SpecialKeyData>();
			this.c = new global::IBtnWrapperLib.MultiBtnWrapper();
			this.g = new global::AcpASKLib.LegacySoftwareKey();
			this.e = new global::AcpASKLib.AccessRecord(global::AcpCommonResources.AcpResources.Default_Unlimited, global::AcpASKLib.SystemKeyLoadedEventArgs.b("㥞ݠբͤŦཨ൪୬८ᝰᕲ፴ᅶὸᵺ᭼᥾ꊔﾘﶚﮜ咽잠얢쎤솦쾨춪쮬즮ힰ햲펴톶\udfb8\uddba\udbbc", a_), false, null);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00029C74 File Offset: 0x00027E74
		public int LoadHardwareKeys(global::AcpKeyValidatorLib.HardwareKeyType keyTypeToLoad, global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> status)
		{
			short num = (short)1469710336;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				int result = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B1;
					}
					global::AcpASKLib.KeyRecordSet keyRecordSet;
					global::AcpASKLib.AccessLevelDataRecordSet systemWideACLRecSet;
					bool flag2;
					bool flag3;
					bool flag4;
					for (;;)
					{
						IL_2C:
						num = (short)410370605;
						short num3 = num;
						num = (short)509526573;
						global::System.Collections.Generic.IEnumerator<global::AcpKeyValidatorLib.AcpiButton> enumerator;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1335099392;
							if (num != 0)
							{
							}
							bool flag;
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyRecord> enumerator2;
							switch (num2)
							{
							case 0:
								goto IL_537;
							case 1:
								goto IL_550;
							case 2:
								if (keyRecordSet.KeyList.Count <= 0)
								{
									num = (short)1593835527;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2BE;
							case 3:
								try
								{
									num = (short)1594097667;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											num = (short)516096004;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)673120256;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::AcpKeyValidatorLib.AcpiButton a_ = enumerator.Current;
											this.a(a_);
											num = (short)1710358529;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											switch (0)
											{
											case 0:
												goto IL_3F6;
											}
											continue;
										case 4:
											goto IL_46E;
										}
										IL_420:
										num = (short)1441792002;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_3F6:
										goto IL_420;
									}
									IL_46E:
									goto IL_2FB;
								}
								finally
								{
									num = (short)2084044801;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											enumerator.Dispose();
											num = (short)1429340162;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_4A5;
											}
											continue;
										case 2:
											goto IL_4DE;
										}
										IL_4A5:
										if (enumerator == null)
										{
											break;
										}
										num = (short)1766391808;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_4DE:;
								}
								goto IL_4E1;
								IL_2FB:
								num = (short)1830223874;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								flag = true;
								goto IL_39A;
							case 5:
								goto IL_4E1;
							case 6:
								try
								{
									num = (short)1224015874;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::AcpASKLib.HardwareKey hardwareKey;
											this.a(hardwareKey);
											num = (short)1047527430;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
											goto IL_24C;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_18A;
											}
											continue;
										case 3:
										{
											if (!enumerator2.MoveNext())
											{
												num = (short)714997764;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::AcpASKLib.HardwareKey hardwareKey = (global::AcpASKLib.HardwareKey)enumerator2.Current;
											num = (short)917045253;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
											num = (short)100532225;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
										{
											global::AcpASKLib.HardwareKey hardwareKey;
											if (hardwareKey.IsAdvancedSystemKey)
											{
												num = (short)2075918336;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										IL_1D2:
										num = (short)1677262851;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_18A:
										goto IL_1D2;
									}
									IL_24C:
									goto IL_33E;
								}
								finally
								{
									num = (short)278921217;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											enumerator2.Dispose();
											num = (short)1684537346;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_283;
											}
											continue;
										case 2:
											goto IL_2BB;
										}
										IL_283:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)342425600;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_2BB:;
								}
								goto IL_2BE;
							case 7:
								num = (short)12713996;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								if (keyRecordSet.a(this.c, keyTypeToLoad, false, true, systemWideACLRecSet, ref flag2, ref flag3, ref status))
								{
									num = (short)1252458501;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = 0;
								num = (short)2071789568;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								this.a();
								num = (short)385744907;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								goto IL_537;
							case 11:
								goto IL_365;
							case 12:
								flag = (keyRecordSet.SpecialKeyList.Count > 0);
								goto IL_39A;
							}
							goto IL_B1;
							IL_2BE:
							num = (short)255459332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_365:
							result = keyRecordSet.KeyList.Count + keyRecordSet.SpecialKeyList.Count;
							num = (short)627834890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_39A:
							if (flag || flag4)
							{
								num = (short)1067057161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_365;
							IL_4E1:
							enumerator2 = keyRecordSet.KeyList.GetEnumerator();
							num = (short)2060582918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_537:
							num = (short)994181121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_33E:
						enumerator = keyRecordSet.SpecialKeyList.GetEnumerator();
						num = (short)940376067;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_550:
					goto IL_553;
					IL_B1:
					flag4 = this.b();
					keyRecordSet = new global::AcpASKLib.KeyRecordSet();
					systemWideACLRecSet = global::AcpASKLib.Global.m_persistentData.SystemWideACLRecSet;
					flag2 = true;
					flag3 = true;
					num = (short)176881672;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_2C;
				}
				catch (global::System.AccessViolationException ex)
				{
					throw ex;
				}
				IL_553:
				num = (short)1750532096;
				short num4 = num;
				num = (short)2055929857;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0002A274 File Offset: 0x00028474
		public int LoadAllKeys(string swKeyDirectory, global::AcpKeyValidatorLib.HardwareKeyType keyTypeToLoad, bool bLoadSwKeys, global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> status)
		{
			short num = (short)971177985;
			if (num != 0)
			{
			}
			num = (short)300744705;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)479075647;
				short num3 = num;
				num = (short)1800805695;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_10A;
				default:
					num = (short)2035089408;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						this.a(swKeyDirectory, false, status);
						num = (short)1910964226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 2:
						goto IL_DE;
					}
					IL_A2:
					if (!bLoadSwKeys)
					{
						goto IL_10A;
					}
					num = (short)245104640;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_DE:
			num = (short)1114112;
			short num4 = num;
			IL_10A:
			this.LoadHardwareKeys(keyTypeToLoad, status);
			return this.b.Count;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0002A3A0 File Offset: 0x000285A0
		public bool IsSpecialKeyLoaded()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (this.a.Count > 0)
					{
						num2 = (short)642777089;
						if (num2 != 0)
						{
						}
						num2 = (short)1770127364;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					num2 = (short)845611008;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_C4;
				case 3:
					goto IL_87;
				case 4:
					result = true;
					num2 = (short)512950274;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_87:
			if (this.a != null)
			{
				goto IL_92;
			}
			return result;
			IL_C4:
			num2 = (short)713097216;
			short num3 = num2;
			return result;
			IL_24:
			result = false;
			num2 = (short)2037946045;
			short num4 = num2;
			num2 = (short)1103730365;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_92:
				num2 = (short)1971453953;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)577503232;
				if (num2 != 0)
				{
				}
				num2 = (short)1469644803;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0002A50C File Offset: 0x0002870C
		public bool CheckIfSpecialKeyIsAttached(global::AcpKeyValidatorLib.HardwareKeyType keyToCheck)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			bool result;
			global::AcpKeyValidatorLib.AcpKeyValidator acpKeyValidator;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1835466753;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					goto IL_C0;
				case 3:
				{
					num2 = (short)1862042555;
					short num3 = num2;
					num2 = (short)125141947;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A0;
					default:
						goto IL_119;
					}
					break;
				}
				case 4:
					switch (keyToCheck)
					{
					case global::AcpKeyValidatorLib.HardwareKeyType.DEPOT_KEY:
						goto IL_A0;
					case global::AcpKeyValidatorLib.HardwareKeyType.LABTOOL_KEY:
						result = acpKeyValidator.IsLabtoolKeyAttached(out flag);
						num2 = (short)243859461;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case (global::AcpKeyValidatorLib.HardwareKeyType)3:
						return result;
					case global::AcpKeyValidatorLib.HardwareKeyType.FTR_KEY:
						result = acpKeyValidator.IsFTRKeyAttached();
						num2 = (short)1436942339;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)1994784768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 5:
					return result;
				}
				goto IL_28;
				IL_A0:
				result = acpKeyValidator.IsDepotKeyAttached();
				num2 = (short)2141978626;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_C0:
			return result;
			IL_119:
			num2 = (short)1092943872;
			if (num2 != 0)
			{
			}
			num2 = (short)1749745664;
			short num4 = num2;
			return result;
			IL_28:
			result = false;
			flag = false;
			acpKeyValidator = new global::AcpKeyValidatorLib.AcpKeyValidator();
			num2 = (short)1997930497;
			if (num2 != 0)
			{
			}
			num2 = (short)1561198596;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0002A6B0 File Offset: 0x000288B0
		internal bool c()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			bool result;
			short num2;
			global::AcpKeyValidatorLib.AcpKeyValidator acpKeyValidator;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_94;
				case 1:
					result = true;
					num2 = (short)1472200704;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_11C;
				case 3:
					return result;
				case 4:
					goto IL_B2;
				case 5:
					if (acpKeyValidator.IsFTRKeyAttached())
					{
						num2 = (short)2147287048;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1519321095;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					result = true;
					num2 = (short)711327748;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (acpKeyValidator.IsDepotKeyAttached())
					{
						num2 = (short)970784774;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)858128393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					num2 = (short)1684746339;
					short num3 = num2;
					num2 = (short)2079207523;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)742391808;
						if (num2 != 0)
						{
						}
						result = true;
						num2 = (short)1344929794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					if (acpKeyValidator.IsLabtoolKeyAttached(out flag))
					{
						num2 = (short)1120665600;
						short num4 = num2;
						num2 = (short)815005697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = false;
					num2 = (short)108396547;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
			}
			IL_94:
			IL_B2:
			return result;
			IL_11C:
			num2 = (short)584056833;
			if (num2 != 0)
			{
			}
			return result;
			IL_38:
			result = false;
			flag = false;
			acpKeyValidator = new global::AcpKeyValidatorLib.AcpKeyValidator();
			num2 = (short)1501757445;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0002A8C8 File Offset: 0x00028AC8
		public bool IsFieldEditable(global::AcpASKLib.AccessElementIDType id, global::AcpASKLib.KeyType type, int sysId, bool bAskOnly)
		{
			short num = (short)1754706633;
			short num2 = num;
			num = (short)1951904457;
			switch (num2 == num)
			{
			}
			num = (short)1610088449;
			if (num != 0)
			{
			}
			num = (short)495255552;
			if (num != 0)
			{
			}
			num = (short)889061376;
			short num3 = num;
			return this.a(id, type, sysId, bAskOnly);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0002A97C File Offset: 0x00028B7C
		internal bool b(global::AcpASKLib.AccessElementIDType A_0, global::AcpASKLib.KeyType A_1, int A_2, bool A_3)
		{
			short num = (short)355500271;
			short num2 = num;
			num = (short)495419631;
			switch (num2 == num)
			{
			}
			num = (short)990642176;
			if (num != 0)
			{
			}
			num = (short)466747393;
			if (num != 0)
			{
			}
			num = (short)1662320640;
			short num3 = num;
			return this.a(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0002AA30 File Offset: 0x00028C30
		private bool a(global::AcpASKLib.AccessElementIDType A_0, global::AcpASKLib.KeyType A_1, int A_2, bool A_3)
		{
			short num = (short)724107264;
			switch (num)
			{
			default:
			{
				bool result = false;
				bool flag = false;
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = this.b.GetEnumerator();
				try
				{
					num = (short)1391132685;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							global::AcpASKLib.AccessRecord accessLevel = systemKeyData.AccessLevel;
							num = (short)1109917712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.SystemID == A_2)
							{
								num = (short)1715339282;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17C;
						}
						case 2:
							num = (short)564920337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_17C;
						case 4:
							if (A_3)
							{
								num = (short)1289093141;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2078277652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_296;
						case 6:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Type == A_1)
							{
								num = (short)340000778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17C;
						}
						case 7:
							flag = true;
							num = (short)881786883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_35E;
						case 9:
							num = (short)429129734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							flag = true;
							num = (short)1175977996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Type == A_1)
							{
								num = (short)1182728194;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17C;
						}
						case 12:
							goto IL_17C;
						case 13:
							switch (0)
							{
							case 0:
								goto IL_B4;
							}
							continue;
						case 14:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1273036808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
							num = (short)275120132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							goto IL_377;
						case 16:
						{
							global::AcpASKLib.AccessRecord accessLevel;
							if (accessLevel != null)
							{
								num = (short)117178390;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_35E;
						}
						case 17:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Source == global::AcpASKLib.KeySource.HARDWARE)
							{
								num = (short)195756039;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17C;
						}
						case 18:
							num = (short)1249968139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							if (flag)
							{
								num = (short)11599872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 20:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.SystemID == A_2)
							{
								num = (short)1483407369;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17C;
						}
						case 21:
							num = (short)343736321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
						{
							global::AcpASKLib.AccessRecord accessLevel;
							result = accessLevel.IsAccessElementEnabled(A_0);
							num = (short)1302593541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_B4;
						IL_17C:
						num = (short)345309203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B4:
						num = (short)168230926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B4:
						goto IL_1B4;
						IL_35E:
						num = (short)1442971663;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_296:
					IL_377:;
				}
				finally
				{
					num = (short)989069314;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_437;
						case 1:
							for (;;)
							{
								num = (short)1674684569;
								short num3 = num;
								num = (short)1306896537;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_403;
								}
							}
							IL_403:
							num = (short)1440874496;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)1779826688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3B0;
							}
							continue;
						}
						IL_3B0:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1355415553;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_437:;
				}
				num = (short)1304494081;
				if (num != 0)
				{
				}
				num = (short)1519058944;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0002AEE8 File Offset: 0x000290E8
		public bool IsRangeValueValid(global::AcpASKLib.AccessElementIDType id, global::AcpASKLib.KeyType type, int sysId, int value, bool bAskOnly)
		{
			short num = (short)952565760;
			switch (num)
			{
			default:
			{
				num = (short)2049507329;
				if (num != 0)
				{
				}
				bool result = false;
				bool flag = false;
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = this.b.GetEnumerator();
				try
				{
					num = (short)1401749517;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							global::AcpASKLib.AccessRecord accessLevel = systemKeyData.AccessLevel;
							num = (short)98435088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.SystemID == sysId)
							{
								num = (short)1589641234;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A3;
						}
						case 2:
							num = (short)346357777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_1A3;
						case 4:
							if (bAskOnly)
							{
								num = (short)2071134229;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1985347604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_2C2;
						case 6:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Type == type)
							{
								num = (short)1674641418;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A3;
						}
						case 7:
							flag = true;
							num = (short)336527363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_38A;
						case 9:
							num = (short)1003290630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							flag = true;
							num = (short)571998220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Type == type)
							{
								num = (short)203816962;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A3;
						}
						case 12:
							goto IL_1A3;
						case 13:
							switch (0)
							{
							case 0:
								goto IL_DA;
							}
							continue;
						case 14:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)940245000;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
							num = (short)217513988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							goto IL_3A2;
						case 16:
						{
							global::AcpASKLib.AccessRecord accessLevel;
							if (accessLevel != null)
							{
								num = (short)2013397014;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_38A;
						}
						case 17:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Source == global::AcpASKLib.KeySource.HARDWARE)
							{
								num = (short)1206714375;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A3;
						}
						case 18:
							num = (short)399441931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							if (flag)
							{
								num = (short)960823296;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 20:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.SystemID == sysId)
							{
								num = (short)1824260105;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A3;
						}
						case 21:
							num = (short)664141825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
						{
							global::AcpASKLib.AccessRecord accessLevel;
							result = accessLevel.IsRangeValueValid(id, value);
							num = (short)755236869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_DA;
						IL_1A3:
						num = (short)1484193811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1DD:
						num = (short)2058682382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_DA:
						goto IL_1DD;
						IL_38A:
						num = (short)1046216719;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2C2:
					IL_3A2:;
				}
				finally
				{
					num = (short)489422850;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_461;
						case 1:
							for (;;)
							{
								num = (short)294869764;
								short num3 = num;
								num = (short)1086151428;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_42C;
								}
							}
							IL_42C:
							num = (short)719454208;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)547946496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3DA;
							}
							continue;
						}
						IL_3DA:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1470889985;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_461:;
				}
				num = (short)1734868992;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0002B3A0 File Offset: 0x000295A0
		public bool IsRangeField(global::AcpASKLib.AccessElementIDType id)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
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
					return result;
				case 1:
				{
					num2 = (short)1715077121;
					if (num2 != 0)
					{
					}
					num2 = (short)2087377143;
					short num3 = num2;
					num2 = (short)1526847735;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_42;
					default:
					{
						num2 = (short)1493237760;
						if (num2 != 0)
						{
						}
						num2 = (short)1813381120;
						short num4 = num2;
						result = true;
						num2 = (short)1037893632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (global::AcpASKLib.FeatureSchemaManager.a(id) is global::AcpASKLib.AccessRangeField)
					{
						goto IL_42;
					}
					return result;
				}
				goto IL_1C;
				IL_42:
				num2 = (short)901906433;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_1C:
			result = false;
			num2 = (short)364249090;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0002B4BC File Offset: 0x000296BC
		internal bool d()
		{
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = this.b.GetEnumerator();
			short num;
			try
			{
				num = (short)1599537154;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						result = true;
						num = (short)523239429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!enumerator.MoveNext())
						{
							num = (short)1024917508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)872218630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_51;
						}
						continue;
					case 3:
						goto IL_F7;
					case 4:
						num = (short)1823539203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_DB;
					case 6:
						if (enumerator.Current.WriteProtectEnabled)
						{
							num = (short)1228668928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_8C:
					num = (short)125960193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51:
					goto IL_8C;
				}
				IL_DB:
				IL_F7:;
			}
			finally
			{
				num = (short)1638006786;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1243676673;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_1DB;
					case 1:
						for (;;)
						{
							num = (short)1644468239;
							short num3 = num;
							num = (short)301373455;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_1A7;
							}
						}
						IL_1A7:
						num = (short)137953280;
						if (num != 0)
						{
						}
						enumerator.Dispose();
						num = (short)996409344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_154;
						}
						continue;
					}
					IL_154:
					if (enumerator == null)
					{
						break;
					}
					num = (short)2034368513;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DB:;
			}
			num = (short)1840578560;
			short num4 = num;
			return result;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0002B6E4 File Offset: 0x000298E4
		internal bool e()
		{
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = this.b.GetEnumerator();
			short num;
			try
			{
				num = (short)92930050;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)71827460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1207894016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpASKLib.AccessRecord accessLevel = enumerator.Current.AccessLevel;
						num = (short)433258504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 3:
					{
						global::AcpASKLib.AccessRecord accessLevel;
						if (accessLevel.IsCloningEnabled())
						{
							num = (short)1777336326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_139;
					case 5:
						num = (short)1224736771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						result = true;
						num = (short)1354432519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_11D;
					case 8:
					{
						global::AcpASKLib.AccessRecord accessLevel;
						if (accessLevel != null)
						{
							num = (short)1050017797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_93:
					num = (short)856817665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58:
					goto IL_93;
				}
				IL_11D:
				IL_139:;
			}
			finally
			{
				num = (short)112656386;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1F3;
					case 1:
						for (;;)
						{
							num = (short)612430904;
							short num3 = num;
							num = (short)443675704;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_1C0;
							}
						}
						IL_1C0:
						num = (short)1487208448;
						if (num != 0)
						{
						}
						enumerator.Dispose();
						num = (short)1953628160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_16E;
						}
						continue;
					}
					IL_16E:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1987182593;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F3:;
			}
			num = (short)1553268737;
			if (num != 0)
			{
			}
			num = (short)99811328;
			short num4 = num;
			return result;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0002B954 File Offset: 0x00029B54
		public global::AcpASKLib.AccessRecord GetSystemAccessLevel(int sysId, global::AcpASKLib.KeyType uKeyTpe)
		{
			global::AcpASKLib.AccessRecord result = null;
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = this.b.GetEnumerator();
			short num;
			try
			{
				num = (short)1604976642;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1449656324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)603324416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
						num = (short)222035976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 3:
					{
						global::AcpASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.Type == uKeyTpe)
						{
							num = (short)412680198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_140;
					case 5:
						num = (short)1810759683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::AcpASKLib.SystemKeyData systemKeyData;
						result = systemKeyData.AccessLevel;
						num = (short)1218379783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_122;
					case 8:
					{
						global::AcpASKLib.SystemKeyData systemKeyData;
						if (systemKeyData.SystemID == sysId)
						{
							num = (short)1669005317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_95:
					num = (short)1074593793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58:
					goto IL_95;
				}
				IL_122:
				IL_140:;
			}
			finally
			{
				num = (short)949747714;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_223;
					case 1:
						for (;;)
						{
							num = (short)1376248826;
							short num3 = num;
							num = (short)1051255802;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_1F0;
							}
						}
						IL_1F0:
						num = (short)1426980864;
						if (num != 0)
						{
						}
						enumerator.Dispose();
						num = (short)852164608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)968294401;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_19E;
						}
						continue;
					}
					IL_19E:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1852899329;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_223:;
			}
			num = (short)1457913856;
			short num4 = num;
			return result;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0002BBD0 File Offset: 0x00029DD0
		public bool IsSystemKeyLoaded(int sysId, byte uKeyTpe, bool bAskOnly)
		{
			short num = (short)561381376;
			short num2 = num;
			num = (short)1802252019;
			short num3 = num;
			num = (short)1511993075;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)207552513;
				if (num != 0)
				{
				}
				num = (short)1538719744;
				if (num != 0)
				{
				}
				result = false;
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = this.b.GetEnumerator();
				try
				{
					num = (short)286654466;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)749797380;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							result = true;
							num = (short)2030829573;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_117;
							}
							continue;
						case 3:
							if (bAskOnly)
							{
								num = (short)495452169;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)459866122;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_32E;
						case 5:
							goto IL_173;
						case 6:
							num = (short)1857945615;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)762576910;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Type == (global::AcpASKLib.KeyType)uKeyTpe)
							{
								num = (short)1215758343;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							num = (short)625737740;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.SystemID == sysId)
							{
								num = (short)1890844678;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
							result = true;
							num = (short)1669201933;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.SystemID == sysId)
							{
								num = (short)1134952464;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 13:
							goto IL_251;
						case 14:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Source == global::AcpASKLib.KeySource.HARDWARE)
							{
								num = (short)1223098379;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 15:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Type == (global::AcpASKLib.KeyType)uKeyTpe)
							{
								num = (short)2093350913;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 16:
							num = (short)1473708040;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1847394304;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
							num = (short)1754464259;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_1F5:
						num = (short)884408337;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_117:
						goto IL_1F5;
					}
					IL_173:
					IL_251:
					IL_32E:;
				}
				finally
				{
					num = (short)1081606144;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_361;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)116457474;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_395;
						}
						IL_361:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1386283009;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_395:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0002BF94 File Offset: 0x0002A194
		public bool IsUnLimitedASKLoaded(int sysId, byte uKeyTpe, bool bSearchWriteProtectOnly)
		{
			short num = (short)2125594624;
			short num2 = num;
			num = (short)1549945217;
			short num3 = num;
			num = (short)315574657;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)739311616;
				if (num != 0)
				{
				}
				num = (short)1563230209;
				if (num != 0)
				{
				}
				result = false;
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = this.b.GetEnumerator();
				try
				{
					num = (short)1165426698;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)80740363;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.AccessLevelType != global::AcpASKLib.KeyAccessLevelType.UNLM_ACC)
							{
								num = (short)1357185028;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F7;
						}
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1654128657;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
							num = (short)1673003029;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Source == global::AcpASKLib.KeySource.HARDWARE)
							{
								num = (short)1334640653;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							num = (short)1506672646;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)236912643;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.AccessLevelType == global::AcpASKLib.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
							{
								num = (short)1916665865;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							num = (short)2135752722;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.SystemID == sysId)
							{
								num = (short)195035155;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							goto IL_2F7;
						case 10:
							switch (0)
							{
							case 0:
								goto IL_13C;
							}
							continue;
						case 11:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Type == (global::AcpASKLib.KeyType)uKeyTpe)
							{
								num = (short)369360901;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.SystemID == sysId)
							{
								num = (short)2003566592;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 13:
							num = (short)1374158849;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_3ED;
						case 15:
							goto IL_311;
						case 16:
							num = (short)2107572247;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							num = (short)1595867160;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.AccessLevelType == global::AcpASKLib.KeyAccessLevelType.UNLM_ACC)
							{
								num = (short)127795222;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 19:
							num = (short)731906068;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Type == (global::AcpASKLib.KeyType)uKeyTpe)
							{
								num = (short)1432092688;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 21:
							if (bSearchWriteProtectOnly)
							{
								num = (short)1545469977;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1784348684;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							result = true;
							num = (short)1244594190;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Source == global::AcpASKLib.KeySource.HARDWARE)
							{
								num = (short)780140551;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 24:
							goto IL_448;
						case 25:
							num = (short)2141716488;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_23D:
						num = (short)756154370;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_13C:
						goto IL_23D;
						IL_2F7:
						result = true;
						num = (short)1621819407;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_311:
					IL_3ED:
					IL_448:;
				}
				finally
				{
					num = (short)848232448;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_47A;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)276955138;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_4AD;
						}
						IL_47A:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1125711873;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_4AD:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0002C470 File Offset: 0x0002A670
		public bool IsASKAttachedForGivenSysIdAndType(int dwSystemId, byte uKeyType)
		{
			short num = (short)1200750592;
			short num2 = num;
			num = (short)1610555706;
			short num3 = num;
			num = (short)332865850;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2065694720;
				if (num != 0)
				{
				}
				num = (short)2121400320;
				switch (num)
				{
				}
				break;
			}
			bool flag = false;
			global::AcpASKLib.KeyRecordSet keyRecordSet = new global::AcpASKLib.KeyRecordSet();
			global::IBtnWrapperLib.MultiBtnWrapper a_ = new global::IBtnWrapperLib.MultiBtnWrapper();
			global::AcpASKLib.AccessLevelDataRecordSet systemWideACLRecSet = global::AcpASKLib.Global.m_persistentData.SystemWideACLRecSet;
			bool flag2 = true;
			bool flag3 = true;
			global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> collection = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg>();
			keyRecordSet.a(a_, (global::AcpKeyValidatorLib.HardwareKeyType)12, false, true, systemWideACLRecSet, ref flag2, ref flag3, ref collection);
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyRecord> enumerator = keyRecordSet.KeyList.GetEnumerator();
			try
			{
				num = (short)187170818;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)485031937;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator2 = ((global::AcpASKLib.HardwareKey)enumerator.Current).KeyDataList.GetEnumerator();
						num = (short)1696595973;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)758251521;
						if (num != 0)
						{
						}
						num = (short)1075183622;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_11C;
						}
						continue;
					case 3:
						if (flag)
						{
							num = (short)2089091079;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 4:
						goto IL_360;
					case 5:
						try
						{
							num = (short)1237254147;
							num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									goto IL_260;
								case 1:
									num = (short)1975582727;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpASKLib.IKeyDataRecord keyDataRecord;
									if (keyDataRecord.SystemID == dwSystemId)
									{
										num = (short)330432513;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_16B;
									}
									continue;
								case 4:
									num = (short)1993211904;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_203;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1341063172;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpASKLib.IKeyDataRecord keyDataRecord = enumerator2.Current;
									num = (short)187301890;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::AcpASKLib.IKeyDataRecord keyDataRecord;
									if (keyDataRecord.KeyType == uKeyType)
									{
										num = (short)1321336840;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									flag = true;
									num = (short)1972764677;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1AD:
								num = (short)545325062;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_16B:
								goto IL_1AD;
							}
							IL_203:
							IL_260:
							goto IL_365;
						}
						finally
						{
							num = (short)1773666304;
							num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator2;
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_297;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)2071986178;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2CE;
								}
								IL_297:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)846004225;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_2CE:;
						}
						break;
						IL_365:
						num = (short)1711603715;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_3E0;
					case 7:
						num = (short)1096286212;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2D1:
					num = (short)704839680;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_11C:
					goto IL_2D1;
				}
				IL_360:
				IL_3E0:;
			}
			finally
			{
				num = (short)1741750272;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_415;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)1522925570;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_44D;
					}
					IL_415:
					if (enumerator == null)
					{
						break;
					}
					num = (short)591331329;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_44D:;
			}
			return flag;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0002C904 File Offset: 0x0002AB04
		public global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> GetSysKeysFromAttachedASKs(bool bValidatePassword)
		{
			short num = (short)956184182;
			short num2 = num;
			num = (short)297416310;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_92;
			case 1:
				break;
			default:
			{
				num = (short)135397376;
				short num3 = num;
				break;
			}
			}
			num = (short)934674432;
			if (num != 0)
			{
			}
			num = (short)1978466304;
			switch (num)
			{
			default:
			{
				IL_92:
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> collection = null;
				global::AcpASKLib.KeyRecordSet keyRecordSet = new global::AcpASKLib.KeyRecordSet();
				global::IBtnWrapperLib.MultiBtnWrapper a_ = new global::IBtnWrapperLib.MultiBtnWrapper();
				global::AcpASKLib.AccessLevelDataRecordSet systemWideACLRecSet = global::AcpASKLib.Global.m_persistentData.SystemWideACLRecSet;
				bool flag = true;
				bool flag2 = true;
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> collection2 = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg>();
				keyRecordSet.a(a_, (global::AcpKeyValidatorLib.HardwareKeyType)12, false, bValidatePassword, systemWideACLRecSet, ref flag, ref flag2, ref collection2);
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyRecord> enumerator = keyRecordSet.KeyList.GetEnumerator();
				try
				{
					num = (short)430243840;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_112;
							}
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1824522243;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.HardwareKey hardwareKey = (global::AcpASKLib.HardwareKey)enumerator.Current;
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator2 = hardwareKey.KeyDataList.GetEnumerator();
							num = (short)1664286722;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							try
							{
								num = (short)1676804099;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::AcpASKLib.KeyDataRecord keyDataRecord;
									bool bWriteProtected;
									bool otapEnabled;
									switch (num4)
									{
									case 0:
										goto IL_32B;
									case 1:
										if (keyDataRecord.AccessLevel != null)
										{
											num = (short)774045702;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2C5;
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator2;
										global::AcpASKLib.IKeyDataRecord keyDataRecord2 = enumerator2.Current;
										if (collection == null)
										{
											collection = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData>();
										}
										keyDataRecord = (global::AcpASKLib.KeyDataRecord)keyDataRecord2;
										bWriteProtected = false;
										otapEnabled = false;
										num = (short)1967456257;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_1D5;
										}
										continue;
									case 4:
										goto IL_2C5;
									case 5:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1335296007;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1680015362;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										bWriteProtected = keyDataRecord.AccessLevel.e();
										otapEnabled = keyDataRecord.AccessLevel.OPTAPState;
										num = (short)455409668;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										num = (short)644153344;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_284:
									num = (short)915603461;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_1D5:
									goto IL_284;
									IL_2C5:
									global::AcpASKLib.HardwareKey hardwareKey;
									global::AcpASKLib.SystemKeyData item = new global::AcpASKLib.SystemKeyData(global::AcpASKLib.KeySource.HARDWARE, hardwareKey.SerialNumber, keyDataRecord.SystemID, (global::AcpASKLib.KeyType)keyDataRecord.KeyType, otapEnabled, bWriteProtected, keyDataRecord.AccessLevel);
									collection.Add(item);
									num = (short)1344012296;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_32B:
								break;
							}
							finally
							{
								num = (short)2077032448;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator2;
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_362;
										}
										continue;
									case 1:
										enumerator2.Dispose();
										num = (short)51445762;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_399;
									}
									IL_362:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1442054145;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_399:;
							}
							goto IL_39C;
						case 3:
							goto IL_39C;
						case 4:
							goto IL_3B6;
						}
						IL_14B:
						num = (short)1593901057;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_112:
						goto IL_14B;
						IL_39C:
						num = (short)578945028;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_3B6:;
				}
				finally
				{
					num = (short)795607040;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_3EA;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)565182466;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_422;
						}
						IL_3EA:
						if (enumerator == null)
						{
							break;
						}
						num = (short)78839809;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_422:;
				}
				num = (short)1627717633;
				if (num != 0)
				{
				}
				return collection;
			}
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0002CD94 File Offset: 0x0002AF94
		private bool b()
		{
			short num = (short)831782912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
				bool flag;
				bool result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						num = (short)148045824;
						short num3 = num;
						try
						{
							num = (short)1440153603;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_24D;
								case 1:
									num = (short)1070268423;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpASKLib.SystemKeyData systemKeyData;
									if (systemKeyData.SystemID == 1)
									{
										num = (short)246546433;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_163;
									}
									continue;
								case 4:
									num = (short)640942080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_1F3;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1233387524;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
									num = (short)829489154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::AcpASKLib.SystemKeyData systemKeyData;
									if (systemKeyData.Type == global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY)
									{
										num = (short)1054801928;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									flag = true;
									num = (short)2024407045;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1A1:
								num = (short)1663631366;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_163:
								goto IL_1A1;
							}
							IL_1F3:
							IL_24D:
							goto IL_DD;
						}
						finally
						{
							num = (short)772341760;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_284;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1003421698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2BC;
								}
								IL_284:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1323237377;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2BC:;
						}
						goto IL_2BF;
						IL_DD:
						num = (short)154140673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_F5;
					case 2:
						goto IL_2BF;
					case 3:
						goto IL_325;
					}
					goto IL_3F;
					IL_2BF:
					num = (short)1396637697;
					if (num != 0)
					{
					}
					global::AcpASKLib.SystemKeyData item = new global::AcpASKLib.SystemKeyData(global::AcpASKLib.KeySource.HARDWARE, global::AcpCommonResources.AcpResources.None_Id, 1, global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY, false, false, this.e);
					this.b.Add(item);
					result = true;
					num = (short)1454833667;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_325:
				return result;
				IL_3F:
				result = false;
				flag = false;
				enumerator = this.b.GetEnumerator();
				num = (short)679024510;
				short num4 = num;
				num = (short)1128208254;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_F5:
					if (!flag)
					{
						num = (short)1673330690;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_28;
					}
					break;
				default:
					num = (short)1027735552;
					if (num != 0)
					{
					}
					num = (short)268042240;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				return result;
			}
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0002D0E8 File Offset: 0x0002B2E8
		private void a(global::AcpASKLib.HardwareKey A_0)
		{
			short num = (short)1653080064;
			switch (num)
			{
			default:
			{
				num = (short)405602304;
				short num2 = num;
				num = (short)1894973441;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator = A_0.KeyDataList.GetEnumerator();
				try
				{
					num = (short)1990656007;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator2;
						global::AcpASKLib.SystemKeyData systemKeyData;
						global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData> collection;
						global::AcpASKLib.KeyDataRecord keyDataRecord;
						bool bWriteProtected;
						bool otapEnabled;
						switch (num3)
						{
						case 0:
							try
							{
								num = (short)1912799234;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_237;
									case 1:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)212271108;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.SystemKeyData item = enumerator2.Current;
										this.b.Remove(item);
										num = (short)1637416963;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1B9;
										}
										continue;
									case 4:
										num = (short)1293156352;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1E9:
									num = (short)1090125825;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1B9:
									goto IL_1E9;
								}
								IL_237:
								goto IL_11F;
							}
							finally
							{
								num = (short)394199041;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)39911426;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_270;
										}
										continue;
									case 2:
										goto IL_2A9;
									}
									IL_270:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)846790656;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_2A9:;
							}
							break;
							IL_11F:
							this.b.Add(systemKeyData);
							num = (short)1676279816;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_CF;
						case 2:
							try
							{
								num = (short)1542324230;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										global::AcpASKLib.SystemKeyData systemKeyData2;
										if (systemKeyData2.SystemID == systemKeyData.SystemID)
										{
											num = (short)1704394759;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
									{
										global::AcpASKLib.SystemKeyData systemKeyData2;
										collection.Add(systemKeyData2);
										num = (short)325255169;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)358613000;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.SystemKeyData systemKeyData2 = enumerator2.Current;
										num = (short)1030291456;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::AcpASKLib.SystemKeyData systemKeyData2;
										if (systemKeyData2.Type == systemKeyData.Type)
										{
											num = (short)1721630722;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_4B9;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_3AD;
										}
										continue;
									case 7:
										num = (short)1622016004;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										num = (short)176029701;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_43B:
									num = (short)1283653635;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_3AD:
									goto IL_43B;
								}
								IL_4B9:
								goto IL_33C;
							}
							finally
							{
								num = (short)1662910465;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)987627522;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_4F0;
										}
										continue;
									case 2:
									{
										num = (short)1995768347;
										short num4 = num;
										num = (short)39256603;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_55E;
										}
										break;
									}
									}
									IL_4F0:
									if (enumerator2 == null)
									{
										goto IL_577;
									}
									num = (short)1668546560;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_55E:
								num = (short)1457520640;
								if (num != 0)
								{
								}
								IL_577:;
							}
							goto IL_578;
							IL_33C:
							enumerator2 = collection.GetEnumerator();
							num = (short)1268318208;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_578;
						case 4:
							goto IL_590;
						case 5:
							if (!enumerator.MoveNext())
							{
								num = (short)540540931;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							keyDataRecord = (global::AcpASKLib.KeyDataRecord)enumerator.Current;
							bWriteProtected = false;
							otapEnabled = false;
							num = (short)626982921;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							bWriteProtected = keyDataRecord.AccessLevel.e();
							otapEnabled = keyDataRecord.AccessLevel.OPTAPState;
							num = (short)2069889025;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_CA;
							}
							continue;
						case 9:
							if (keyDataRecord.AccessLevel != null)
							{
								num = (short)551878662;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CF;
						}
						goto IL_CA;
						IL_CF:
						systemKeyData = new global::AcpASKLib.SystemKeyData(global::AcpASKLib.KeySource.HARDWARE, A_0.SerialNumber, keyDataRecord.SystemID, (global::AcpASKLib.KeyType)keyDataRecord.KeyType, otapEnabled, bWriteProtected, keyDataRecord.AccessLevel);
						collection = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData>();
						enumerator2 = this.b.GetEnumerator();
						num = (short)808255490;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2AC:
						num = (short)1162018821;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_CA:
						goto IL_2AC;
						IL_578:
						num = (short)1965293572;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_590:;
				}
				finally
				{
					num = (short)1784872961;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)2062024706;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_5C4;
							}
							continue;
						case 2:
							goto IL_5FA;
						}
						IL_5C4:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1795424256;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_5FA:;
				}
				return;
			}
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0002D740 File Offset: 0x0002B940
		private void a(global::AcpKeyValidatorLib.AcpiButton A_0)
		{
			short num = (short)746979328;
			switch (num)
			{
			default:
			{
				num = (short)442105856;
				short num2 = num;
				global::AcpASKLib.SpecialKeyData item = new global::AcpASKLib.SpecialKeyData(A_0.SerialNumber, A_0.KeyType);
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SpecialKeyData> collection = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SpecialKeyData>();
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SpecialKeyData> enumerator = this.a.GetEnumerator();
				try
				{
					num = (short)924123140;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)857604099;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::AcpASKLib.SpecialKeyData specialKeyData;
							collection.Add(specialKeyData);
							num = (short)242548741;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::AcpASKLib.SpecialKeyData specialKeyData;
							if (specialKeyData.iBtnSerialNum == A_0.SerialNumber)
							{
								num = (short)943063041;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_27E;
						}
						case 3:
							goto IL_2D2;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_1EB;
							}
							continue;
						case 5:
							goto IL_27E;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)3145728;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.SpecialKeyData specialKeyData = enumerator.Current;
							num = (short)1960902658;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_1EB;
						IL_27E:
						num = (short)596312070;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1EB:
						num = (short)832634881;
						if (num != 0)
						{
						}
						goto IL_27E;
					}
					IL_2D2:
					goto IL_19D;
				}
				finally
				{
					num = (short)603586561;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1613496322;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_30B;
							}
							continue;
						case 2:
						{
							num = (short)325256290;
							short num4 = num;
							num = (short)1466958946;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_374;
							}
							break;
						}
						}
						IL_30B:
						if (enumerator == null)
						{
							goto IL_38B;
						}
						num = (short)162791424;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_374:
					num = (short)995033088;
					if (num != 0)
					{
					}
					IL_38B:;
				}
				goto IL_38C;
				for (;;)
				{
					IL_19D:
					enumerator = collection.GetEnumerator();
					try
					{
						num = (short)1771896834;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_12C;
							case 1:
								num = (short)256966656;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_AD;
								}
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)595197953;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpASKLib.SpecialKeyData item2 = enumerator.Current;
								this.a.Remove(item2);
								num = (short)1050869764;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_AF:
							num = (short)405864451;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_AD:
							goto IL_AF;
						}
						IL_12C:
						break;
					}
					finally
					{
						num = (short)572194817;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)680132610;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_163;
								}
								continue;
							case 2:
								goto IL_19A;
							}
							IL_163:
							if (enumerator == null)
							{
								break;
							}
							num = (short)187957248;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_19A:;
					}
				}
				IL_38C:
				this.a.Add(item);
				return;
			}
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0002DB1C File Offset: 0x0002BD1C
		internal int a(string A_0, bool A_1, global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> A_2)
		{
			int a_ = 7;
			short num = (short)591265792;
			switch (num)
			{
			default:
			{
				num = (short)1061748736;
				short num2 = num;
				int num3 = 0;
				try
				{
					num = (short)323092491;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						int num5;
						switch (num4)
						{
						case 0:
							goto IL_1BC;
						case 1:
							goto IL_313;
						case 2:
							goto IL_313;
						case 3:
							goto IL_32D;
						case 4:
						{
							global::System.IO.FileInfo[] files;
							if (num5 >= files.Length)
							{
								num = (short)559808521;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.IO.FileInfo fileInfo = files[num5];
							num = (short)888143877;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.IO.FileInfo fileInfo;
							string strB;
							if (string.Compare(fileInfo.Extension, strB, true) == 0)
							{
								goto IL_132;
							}
							goto IL_2F2;
						}
						case 6:
							goto IL_1BC;
						case 7:
						{
							global::System.IO.FileInfo fileInfo;
							if (!this.a(fileInfo.FullName, A_2))
							{
								goto IL_2F2;
							}
							num = (short)1277344730;
							short num6 = num;
							num = (short)2076425178;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_132;
							default:
								num = (short)1626406912;
								if (num != 0)
								{
								}
								num = (short)1620246538;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							string strB = global::AcpASKLib.SystemKeyLoadedEventArgs.b("乣䡥ͧཀྵᕫ", a_).Substring(1).Trim();
							global::System.IO.FileInfo[] files = new global::System.IO.DirectoryInfo(A_0).GetFiles(global::AcpASKLib.SystemKeyLoadedEventArgs.b("乣䡥ͧཀྵᕫ", a_));
							num5 = 0;
							num = (short)1448411136;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							num = (short)1718157314;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num3++;
							num = (short)1558118413;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							switch (0)
							{
							case 0:
								goto IL_B5;
							}
							continue;
						case 12:
							num = (short)1596194823;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_2F2;
						}
						IL_B5:
						num = (short)1330905089;
						if (num != 0)
						{
						}
						if (global::System.IO.Directory.Exists(A_0))
						{
							num = (short)78118920;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_2.Add(new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Warning, global::AcpCommonResources.AcpResources.System_Key_Files_Not_Loaded.AcpStringFormat(new object[]
						{
							A_0
						}), 3758129160U));
						num = (short)1757413377;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_132:
						num = (short)1835991052;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BC:
						num = (short)974520324;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_2F2:
						num5++;
						num = (short)1212284934;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_313:
						num = (short)1844183043;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_32D:;
				}
				catch (global::System.Exception ex)
				{
					A_2.Add(new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, global::AcpCommonResources.AcpResources.Error_Loading_Software + ex.Message, 3758129160U));
				}
				finally
				{
					num = (short)255197186;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							this.a();
							num = (short)514785281;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3CB;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_395;
							}
							continue;
						case 3:
							num = (short)1189281796;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (num3 > 0)
							{
								num = (short)1557725184;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_401;
						}
						IL_395:
						if (!A_1)
						{
							break;
						}
						num = (short)220659715;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_3CB:
					IL_401:;
				}
				return num3;
			}
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0002DF60 File Offset: 0x0002C160
		public int LoadSelectedSwKeyFiles(string[] selectedFileNames, global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> status)
		{
			short num = (short)126156800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_58;
				}
				int num3;
				int num5;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						if (num3 >= selectedFileNames.Length)
						{
							num = (short)1244790785;
							if (num != 0)
							{
							}
							num = (short)1140916228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string a_ = selectedFileNames[num3];
						num = (short)1186791429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_17F;
					case 2:
					{
						num = (short)2048851968;
						short num4 = num;
						if (num5 > 0)
						{
							num = (short)1572143112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
					}
					case 3:
						num5++;
						num = (short)2053505030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1632763906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						string a_;
						if (this.a(a_, status))
						{
							num = (short)1305739267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9;
					}
					case 6:
						IL_17A:
						goto IL_D9;
					case 7:
						goto IL_17F;
					case 8:
						this.a();
						num = (short)793051145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1E5;
					}
					goto IL_58;
					IL_D9:
					num3++;
					num = (short)891682817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E5:
					num = (short)1543648473;
					short num6 = num;
					num = (short)1243559129;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17A;
					default:
						goto IL_21C;
					}
					IL_17F:
					num = (short)1909456896;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_21C:
				num = (short)556335104;
				if (num != 0)
				{
				}
				return num5;
				IL_58:
				num5 = 0;
				num3 = 0;
				num = (short)771424263;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0002E1A4 File Offset: 0x0002C3A4
		private bool a(string A_0, global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> A_1)
		{
			short num = (short)984350720;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				bool result;
				for (;;)
				{
					IL_28:
					int num3;
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						if (num3 > 0)
						{
							num = (short)700579847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
					{
						global::AcpASKLib.SystemKeyData systemKeyData;
						this.b.Remove(systemKeyData);
						num = (short)147587075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_123;
					case 4:
						try
						{
							num = (short)401473544;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1783758851;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpASKLib.SystemKeyData systemKeyData2;
									if (systemKeyData2.Type == global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY)
									{
										num = (short)2107244551;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)94175233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_348;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1102053376;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpASKLib.SystemKeyData systemKeyData2 = enumerator.Current;
									num = (short)672399365;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpASKLib.SystemKeyData systemKeyData2;
									if (systemKeyData2.SystemID == num3)
									{
										num = (short)1803354114;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_268;
								case 7:
								{
									global::AcpASKLib.SystemKeyData systemKeyData2;
									global::AcpASKLib.SystemKeyData systemKeyData = systemKeyData2;
									num = (short)1911750662;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_24E;
									}
									continue;
								}
								IL_2B3:
								num = (short)461897732;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_24E:
								goto IL_2B3;
							}
							IL_268:
							IL_348:
							goto IL_BD;
						}
						finally
						{
							num = (short)685768706;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1039980991;
								short num4 = num;
								num = (short)525588927;
								global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1762263040;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_40A;
									case 1:
										goto IL_3EA;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_3CE;
										}
										continue;
									}
									IL_3CE:
									if (enumerator != null)
									{
										num = (short)997523457;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_40C;
								}
								IL_3EA:
								enumerator.Dispose();
								num = (short)1110769664;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_40A:
							IL_40C:;
						}
						return result;
						IL_BD:
						num = (short)763232261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::AcpASKLib.SystemKeyData systemKeyData;
						if (systemKeyData != null)
						{
							num = (short)507772930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123;
					}
					case 6:
					{
						num = (short)900399104;
						short num5 = num;
						num3 = this.g.a(A_0, A_1);
						num = (short)856752129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::AcpASKLib.SystemKeyData systemKeyData = null;
						global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = this.b.GetEnumerator();
						num = (short)1388118020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (global::System.IO.File.Exists(A_0))
						{
							num = (short)95682566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_53;
					IL_123:
					global::AcpASKLib.SystemKeyData item = new global::AcpASKLib.SystemKeyData(global::AcpASKLib.KeySource.LEGACY_KEY_FILE, global::AcpCommonResources.AcpResources.None_Id, num3, global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY, false, false, this.e);
					this.b.Add(item);
					result = true;
					num = (short)1972109312;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_53:
				result = false;
				num = (short)1433600001;
				if (num != 0)
				{
				}
				num = (short)1325137928;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0002E5DC File Offset: 0x0002C7DC
		private void a()
		{
			short num = (short)1853489160;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_93;
				case 1:
					if (this.b.Count <= 0)
					{
						num = (short)1102839815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_93;
				case 2:
					this.h(this, new global::AcpASKLib.SystemKeyLoadedEventArgs(this.b, this.a));
					num = (short)400752643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					if (this.a.Count > 0)
					{
						num = (short)1722744832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					if (this.h != null)
					{
						num = (short)2013003778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					num = (short)276955137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_D0;
				case 8:
				{
					num = (short)1794703360;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				}
				}
				IL_71:
				if (this.b != null)
				{
					num = (short)1545404422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_D0;
				IL_93:
				num = (short)212008965;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D0:
				num = (short)1588648604;
				short num4 = num;
				num = (short)211475100;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1003683840;
					if (num != 0)
					{
					}
					num = (short)911736833;
					if (num != 0)
					{
					}
					num = (short)322633732;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0002E7F0 File Offset: 0x0002C9F0
		public global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> LoadedUserSystemKeys
		{
			get
			{
				short num = (short)1456006224;
				short num2 = num;
				num = (short)2078008400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)62455808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1594359808;
				if (num != 0)
				{
				}
				num = (short)2056781825;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0002E89C File Offset: 0x0002CA9C
		public global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> LoadedASKs
		{
			get
			{
				global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData>();
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator = this.b.GetEnumerator();
				short num;
				try
				{
					num = (short)343670790;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)174981123;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
							num = (short)1791492100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_100;
						case 2:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							observableCollection.Add(systemKeyData);
							num = (short)199294981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)1819475969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::AcpASKLib.SystemKeyData systemKeyData;
							if (systemKeyData.Source == global::AcpASKLib.KeySource.HARDWARE)
							{
								num = (short)626851842;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_54;
							}
							continue;
						}
						IL_90:
						num = (short)1323565056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_54:
						goto IL_90;
					}
					IL_100:;
				}
				finally
				{
					num = (short)110166018;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1354465812;
						short num3 = num;
						num = (short)1659404820;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)412155904;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								goto IL_1B7;
							case 1:
								goto IL_19A;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_180;
								}
								continue;
							}
							IL_180:
							if (enumerator != null)
							{
								num = (short)1767571457;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B9;
						}
						IL_19A:
						enumerator.Dispose();
						num = (short)396689408;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1B7:
					IL_1B9:;
				}
				num = (short)1746010113;
				if (num != 0)
				{
				}
				num = (short)919142400;
				short num4 = num;
				return observableCollection;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0002EAC4 File Offset: 0x0002CCC4
		public global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SpecialKeyData> LoadedSpecialKeys
		{
			get
			{
				short num = (short)483585398;
				short num2 = num;
				num = (short)1452338550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1762525184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1767964672;
				if (num != 0)
				{
				}
				num = (short)1193607169;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060001A7 RID: 423 RVA: 0x0002EB74 File Offset: 0x0002CD74
		// (remove) Token: 0x060001A8 RID: 424 RVA: 0x0002ECA8 File Offset: 0x0002CEA8
		public event global::AcpASKLib.SystemKeyLoadedEventHandler SystemKeyLoadedEvent
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
				global::AcpASKLib.SystemKeyLoadedEventHandler systemKeyLoadedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_FB;
					case 1:
					{
						IL_DD:
						global::AcpASKLib.SystemKeyLoadedEventHandler systemKeyLoadedEventHandler2;
						if (systemKeyLoadedEventHandler == systemKeyLoadedEventHandler2)
						{
							num2 = (short)1859059712;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)1261520171;
					short num3 = num2;
					num2 = (short)1937786155;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DD;
					default:
					{
						num2 = (short)1700593665;
						if (num2 != 0)
						{
						}
						num2 = (short)187498496;
						if (num2 != 0)
						{
						}
						global::AcpASKLib.SystemKeyLoadedEventHandler systemKeyLoadedEventHandler2 = systemKeyLoadedEventHandler;
						global::AcpASKLib.SystemKeyLoadedEventHandler value2 = (global::AcpASKLib.SystemKeyLoadedEventHandler)global::System.Delegate.Combine(systemKeyLoadedEventHandler2, value);
						systemKeyLoadedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpASKLib.SystemKeyLoadedEventHandler>(ref this.h, value2, systemKeyLoadedEventHandler2);
						num2 = (short)2100232193;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				IL_FB:
				num2 = (short)320536576;
				short num4 = num2;
				return;
				IL_1C:
				systemKeyLoadedEventHandler = this.h;
				num2 = (short)303890434;
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
				global::AcpASKLib.SystemKeyLoadedEventHandler systemKeyLoadedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_D7;
					case 1:
					{
						IL_B9:
						global::AcpASKLib.SystemKeyLoadedEventHandler systemKeyLoadedEventHandler2;
						if (systemKeyLoadedEventHandler == systemKeyLoadedEventHandler2)
						{
							num2 = (short)1006239744;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)1588399879;
					short num3 = num2;
					num2 = (short)2119700231;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B9;
					default:
					{
						num2 = (short)1163198464;
						if (num2 != 0)
						{
						}
						global::AcpASKLib.SystemKeyLoadedEventHandler systemKeyLoadedEventHandler2 = systemKeyLoadedEventHandler;
						global::AcpASKLib.SystemKeyLoadedEventHandler value2 = (global::AcpASKLib.SystemKeyLoadedEventHandler)global::System.Delegate.Remove(systemKeyLoadedEventHandler2, value);
						systemKeyLoadedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpASKLib.SystemKeyLoadedEventHandler>(ref this.h, value2, systemKeyLoadedEventHandler2);
						num2 = (short)1235877889;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				IL_D7:
				num2 = (short)16252929;
				if (num2 != 0)
				{
				}
				num2 = (short)2061959168;
				short num4 = num2;
				return;
				IL_1C:
				systemKeyLoadedEventHandler = this.h;
				num2 = (short)84606978;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x040001CB RID: 459
		private global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SpecialKeyData> a;

		// Token: 0x040001CC RID: 460
		private global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> b;

		// Token: 0x040001CD RID: 461
		private global::IBtnWrapperLib.MultiBtnWrapper c;

		// Token: 0x040001CE RID: 462
		private const int d = 1;

		// Token: 0x040001CF RID: 463
		private global::AcpASKLib.AccessRecord e;

		// Token: 0x040001D0 RID: 464
		private global::AcpASKLib.AccessRecord f;

		// Token: 0x040001D1 RID: 465
		private global::AcpASKLib.LegacySoftwareKey g;

		// Token: 0x040001D2 RID: 466
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpASKLib.SystemKeyLoadedEventHandler h;
	}
}
