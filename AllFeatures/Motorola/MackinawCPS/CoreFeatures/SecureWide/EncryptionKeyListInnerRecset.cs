using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000E3 RID: 227
	[global::System.Serializable]
	public class EncryptionKeyListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001EDE RID: 7902 RVA: 0x001EDFFC File Offset: 0x001EC1FC
		public EncryptionKeyListInnerRecset() : base(global::CommonResources.AcgResources.ID_ENCRYPTIONKEYLIST, global::CommonResources.AcgResources.ID_SECKEY)
		{
			this.SetValues();
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x001EE020 File Offset: 0x001EC220
		public EncryptionKeyListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x001EE04C File Offset: 0x001EC24C
		public override int MaxPool
		{
			get
			{
				short num = (short)1373801613;
				short num2 = num;
				num = (short)1832029325;
				switch (num2 == num)
				{
				}
				num = (short)1383792641;
				if (num != 0)
				{
				}
				num = (short)517079040;
				short num3 = num;
				num = (short)824573952;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x001EE0FC File Offset: 0x001EC2FC
		// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x001EE1BC File Offset: 0x001EC3BC
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax == -1)
				{
					num = (short)946761999;
					short num2 = num;
					num = (short)1890349327;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1063583744;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset._Max;
					}
				}
				num = (short)479723521;
				if (num != 0)
				{
				}
				num = (short)141754368;
				short num3 = num;
				return this._DynMax;
			}
			set
			{
				short num = (short)1160677320;
				short num2 = num;
				num = (short)493782984;
				switch (num2 == num)
				{
				}
				num = (short)1496317952;
				if (num != 0)
				{
				}
				num = (short)679870464;
				short num3 = num;
				num = (short)1199833089;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x001EE26C File Offset: 0x001EC46C
		public override int Min
		{
			get
			{
				short num = (short)1664943794;
				short num2 = num;
				num = (short)1236338354;
				switch (num2 == num)
				{
				}
				num = (short)1532362753;
				if (num != 0)
				{
				}
				num = (short)220594176;
				short num3 = num;
				num = (short)379125760;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset._Min;
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x001EE31C File Offset: 0x001EC51C
		// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x001EE3CC File Offset: 0x001EC5CC
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)891363744;
				short num2 = num;
				num = (short)1163796896;
				switch (num2 == num)
				{
				}
				num = (short)1632239617;
				if (num != 0)
				{
				}
				num = (short)1587609600;
				short num3 = num;
				num = (short)1376321536;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)69179491;
				short num2 = num;
				num = (short)1583061091;
				switch (num2 == num)
				{
				}
				num = (short)2006646785;
				if (num != 0)
				{
				}
				num = (short)458948608;
				short num3 = num;
				num = (short)462225408;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x001EE47C File Offset: 0x001EC67C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1546691210;
				short num2 = num;
				num = (short)744792714;
				switch (num2 == num)
				{
				}
				num = (short)2088304641;
				if (num != 0)
				{
				}
				num = (short)1127809024;
				short num3 = num;
				num = (short)1009844224;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x001EE52C File Offset: 0x001EC72C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1500964221;
			short num2 = num;
			num = (short)397206909;
			switch (num2 == num)
			{
			}
			num = (short)1763966976;
			if (num != 0)
			{
			}
			num = (short)1386283008;
			short num3 = num;
			num = (short)1855586305;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner(this);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x001EE5DC File Offset: 0x001EC7DC
		internal void SetValues()
		{
			short num = (short)1257936408;
			short num2 = num;
			num = (short)851482136;
			switch (num2 == num)
			{
			}
			num = (short)1405550593;
			if (num != 0)
			{
			}
			num = (short)1749614592;
			short num3 = num;
			num = (short)118685696;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_ENCRYPTIONKEYLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_SECKEY;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x001EE6B0 File Offset: 0x001EC8B0
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)922205491;
			short num2 = num;
			num = (short)1224916275;
			switch (num2 == num)
			{
			}
			num = (short)61210625;
			if (num != 0)
			{
			}
			num = (short)1410531328;
			short num3 = num;
			num = (short)742653952;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.c(record);
			this.b();
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x001EE76C File Offset: 0x001EC96C
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)906550468;
			short num2 = num;
			num = (short)156490948;
			switch (num2 == num)
			{
			}
			num = (short)2075394048;
			if (num != 0)
			{
			}
			num = (short)1681850368;
			short num3 = num;
			num = (short)1072693249;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.b(record);
			this.b();
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x001EE824 File Offset: 0x001ECA24
		protected override void OnFinishedMoveRecord(global::AcpCommonLib.IAcpFeatureNode record, global::AcpCommonLib.IAcpFeatureNode targetRecord)
		{
			short num = (short)263060130;
			short num2 = num;
			num = (short)622328482;
			switch (num2 == num)
			{
			}
			num = (short)2111373312;
			if (num != 0)
			{
			}
			num = (short)43384832;
			short num3 = num;
			num = (short)941162497;
			if (num != 0)
			{
			}
			base.OnFinishedMoveRecord();
			this.a(record, targetRecord);
			this.b();
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x001EE8E0 File Offset: 0x001ECAE0
		private void b()
		{
			short num = (short)1144520704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset secureWideRecset;
					switch (num2)
					{
					case 0:
					{
						num = (short)1204944896;
						short num3 = num;
						try
						{
							num = (short)558628867;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_326;
								case 1:
									goto IL_33F;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)10158080;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current)[10126].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset).GetEnumerator();
									num = (short)2012086276;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_175;
									}
									continue;
								case 4:
									try
									{
										num = (short)1547567107;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)1864302593;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_2B7;
											case 2:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1877540864;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												(((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInner)enumerator2.Current)[10127] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection).SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.CalculateValidity();
												num = (short)2010906628;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												switch (0)
												{
												case 0:
													goto IL_228;
												}
												continue;
											}
											IL_266:
											num = (short)511115266;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_228:
											goto IL_266;
										}
										IL_2B7:
										break;
									}
									finally
									{
										num = (short)1045299202;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)1709441025;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_323;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_2EE;
												}
												continue;
											}
											IL_2EE:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1508769792;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_323:;
									}
									goto IL_326;
								}
								IL_1B4:
								num = (short)2027552770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_175:
								goto IL_1B4;
								IL_326:
								num = (short)262537217;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_33F:
							goto IL_C7;
						}
						finally
						{
							num = (short)2003107842;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1489240065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3AC;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_377;
									}
									continue;
								}
								IL_377:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1259143168;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3AC:;
						}
						goto IL_3AF;
					}
					case 1:
						num = (short)203685889;
						if (num != 0)
						{
						}
						enumerator = (secureWideRecset[0][10040].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset).GetEnumerator();
						num = (short)255000579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (secureWideRecset != null)
						{
							num = (short)2005467137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_C2;
					case 4:
						if (secureKMFProfileRecset != null)
						{
							num = (short)543686661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7;
					case 5:
						goto IL_3AF;
					}
					goto IL_47;
					IL_C7:
					secureWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2021) as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset);
					num = (short)1008730114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AF:
					enumerator = secureKMFProfileRecset.GetEnumerator();
					num = (short)1861484544;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C2:
				try
				{
					num = (short)1474625539;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)177012737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_4C5;
						case 2:
							if (!enumerator.MoveNext())
							{
								num = (short)1444413440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							(((global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner)enumerator.Current)[10041] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListCKR_A7665.CalculateValidity();
							num = (short)1406468100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_438;
							}
							continue;
						}
						IL_475:
						num = (short)300810242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_438:
						goto IL_475;
					}
					IL_4C5:;
				}
				finally
				{
					num = (short)683474946;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1551695873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_580;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_4FC;
							}
							continue;
						}
						IL_4FC:
						num = (short)1677202774;
						short num4 = num;
						num = (short)187045206;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_580;
						default:
							num = (short)1702952960;
							if (num != 0)
							{
							}
							if (enumerator == null)
							{
								goto IL_582;
							}
							num = (short)176816128;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_580:
					IL_582:;
				}
				return;
				IL_47:
				secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
				num = (short)1554972676;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x001EEEBC File Offset: 0x001ED0BC
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1219382696;
			short num2 = num;
			num = (short)1228819880;
			switch (num2 == num)
			{
			}
			num = (short)1218117633;
			if (num != 0)
			{
			}
			num = (short)2040987648;
			short num3 = num;
			num = (short)1976762368;
			if (num != 0)
			{
			}
			this.a(A_0);
			this.a();
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x001EEF74 File Offset: 0x001ED174
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)455556395;
			short num2 = num;
			num = (short)180829483;
			switch (num2 == num)
			{
			}
			num = (short)244252672;
			if (num != 0)
			{
			}
			num = (short)184942592;
			short num3 = num;
			num = (short)1054867457;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x001EF024 File Offset: 0x001ED224
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0, global::AcpCommonLib.IAcpFeatureNode A_1)
		{
			short num = (short)1852904335;
			short num2 = num;
			num = (short)1410929551;
			switch (num2 == num)
			{
			}
			num = (short)1555234817;
			if (num != 0)
			{
			}
			num = (short)907542528;
			short num3 = num;
			num = (short)1077673984;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x001EF0D4 File Offset: 0x001ED2D4
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)620429312;
			switch (num)
			{
			default:
			{
				num = (short)2004156430;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				for (;;)
				{
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_15C;
					case 1:
						num3++;
						num4 = 0;
						num = (short)2076573705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_29C;
					case 3:
						num4 = 0;
						num = (short)2114584599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!global::AcpCommonLib.AppInfoManager.AddDefaultRecord)
						{
							num = (short)654114840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)622133259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						int num5;
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset;
						if (num5 >= encryptionKeyListInnerRecset.Count - 1)
						{
							num = (short)834928655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1973420040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1599930378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_689;
					case 8:
					{
						int num5;
						int value;
						int[] array;
						if (value == array[num5])
						{
							num = (short)438239235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5++;
						num = (short)164167682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_646;
					case 10:
						if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
						{
							num = (short)445055001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
					{
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)247463953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1649999872;
						short num6 = num;
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset secureWideRecset = global::AcpCommonLib.FeatureManager.GetFeature(2021) as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset;
						num = (short)1731330055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_29C;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset secureWideRecset;
						if (secureWideRecset != null)
						{
							num = (short)1465712656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 14:
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					case 15:
						goto IL_2DD;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset secureWideRecset;
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset = secureWideRecset[0][10040].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset;
						int[] array = new int[encryptionKeyListInnerRecset.Count - 1];
						num3 = 0;
						int value = (A_0[10041] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListCKR_A7665.Value;
						bool flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = encryptionKeyListInnerRecset.GetEnumerator();
						goto IL_335;
					}
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset secureWideRecset = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2021) as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset;
						num = (short)419142309;
						short num7 = num;
						num = (short)1627626149;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_335;
						default:
							num = (short)255197184;
							if (num != 0)
							{
							}
							num = (short)130351122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 18:
						goto IL_689;
					case 19:
					{
						try
						{
							num = (short)1013972993;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int value2;
								switch (num2)
								{
								case 0:
								{
									bool flag = true;
									num = (short)1625096197;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_49E;
									}
									continue;
								case 2:
								{
									int value;
									if (value == value2)
									{
										num = (short)1925120003;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4A3;
								}
								case 3:
									num = (short)2071789574;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									bool flag;
									if (!flag)
									{
										num = (short)169541632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4A3;
								}
								case 7:
									num = (short)291569672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_5D4;
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2098135047;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									value2 = (((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10041] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListCKR_A7665.Value;
									num = (short)1427963906;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_49E;
								IL_4A3:
								int[] array;
								array[num3] = value2;
								num3++;
								num = (short)956104708;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_55F:
								num = (short)1956315145;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_49E:
								goto IL_55F;
							}
							IL_5D4:
							goto IL_FA;
						}
						finally
						{
							num = (short)1832976384;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_60B;
									}
									continue;
								case 1:
									goto IL_643;
								case 2:
									enumerator.Dispose();
									num = (short)965935105;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_60B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)372047874;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_643:;
						}
						goto IL_646;
						IL_FA:
						int num5 = 0;
						num = (short)60948492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset;
						if (num4 >= encryptionKeyListInnerRecset.Count - 1)
						{
							num = (short)1763508246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1568538645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						int[] array;
						if (num3 == array[num4])
						{
							num = (short)197787649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_646;
					}
					case 22:
						goto IL_19A;
					case 23:
						goto IL_15C;
					case 24:
						goto IL_44B;
					case 25:
						num = (short)171114497;
						if (num != 0)
						{
						}
						num = (short)998244356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AC:
					if (!global::AcpCommonLib.AppInfoManager.DndOperation)
					{
						num = (short)1857945606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_15C:
					num = (short)488701972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29C:
					num = (short)138018821;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_335:
					num = (short)756875283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_646:
					num4++;
					num = (short)1447034880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_689:
					num = (short)754581517;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19A:
				(A_0[10041] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListCKR_A7665.Value = num3;
				return;
				IL_2DD:
				return;
				IL_44B:
				return;
			}
			}
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x001EF804 File Offset: 0x001EDA04
		private void a()
		{
			short num = (short)86245379;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					num = (short)2015100937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1273692174;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)131530753;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				case 4:
					goto IL_2AF;
				case 5:
					goto IL_184;
				case 6:
					num = (short)1194721292;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)839254022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					goto IL_1DD;
				case 9:
				{
					bool markForUndo = global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo;
					global::AcpCommonLib.UndoRedo.ContainerTask task = new global::AcpCommonLib.UndoRedo.ContainerTask("");
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conSetSecPIDIndexMapAndSlotAAndSlotBValues(((global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner)base[0])[10041], task);
					if (markForUndo)
					{
						num = (short)280231947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
					num = (short)1001455616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					if (base.Count > 0)
					{
						num = (short)707526657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
				{
					num = (short)14745600;
					short num3 = num;
					num = (short)688547942;
					short num4 = num;
					num = (short)1439787110;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DD;
					default:
						goto IL_168;
					}
					break;
				}
				case 12:
					if (global::AcpCommonLib.AppInfoManager.ComparatorDocument.IsOpen)
					{
						num = (short)1423179781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 13:
					num = (short)1889796104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (global::AcpCommonLib.FeatureManager.ActiveDocument.IsOpen)
					{
						num = (short)1988821005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AF;
				}
				IL_88:
				if (base.ParentSection != null)
				{
					num = (short)1701249026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_184:
				num = (short)1203372042;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DD:
				if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
				{
					num = (short)698417156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_184;
				IL_2AF:
				num = (short)1829306375;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_168:
			num = (short)1706295296;
			if (num != 0)
			{
			}
			global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x001EFAFC File Offset: 0x001EDCFC
		// Note: this type is marked as 'beforefieldinit'.
		static EncryptionKeyListInnerRecset()
		{
			short num = (short)943782633;
			short num2 = num;
			num = (short)1661532905;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1234632704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)617807873;
			if (num != 0)
			{
			}
			num = (short)627703808;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset._Min = 1;
		}

		// Token: 0x04000BAE RID: 2990
		public static int _MaxPool;

		// Token: 0x04000BAF RID: 2991
		public static int _Max;

		// Token: 0x04000BB0 RID: 2992
		public int _DynMax;

		// Token: 0x04000BB1 RID: 2993
		public static int _Min;

		// Token: 0x04000BB2 RID: 2994
		public static int _DefaultRecordCount;
	}
}
