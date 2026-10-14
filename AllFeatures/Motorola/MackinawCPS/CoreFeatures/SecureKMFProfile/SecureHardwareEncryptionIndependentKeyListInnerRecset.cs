using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x020000FD RID: 253
	[global::System.Serializable]
	public class SecureHardwareEncryptionIndependentKeyListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600258B RID: 9611 RVA: 0x00249B4C File Offset: 0x00247D4C
		public SecureHardwareEncryptionIndependentKeyListInnerRecset() : base(global::CommonResources.AcgResources.ID_SECUREHARDWAREENCRYPTIONINDEPENDENTKEYLIST, true, false, global::CommonResources.AcgResources.ID_SECKEY)
		{
			this.SetValues();
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00249B74 File Offset: 0x00247D74
		public SecureHardwareEncryptionIndependentKeyListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x00249BA0 File Offset: 0x00247DA0
		public override int MaxPool
		{
			get
			{
				short num = (short)734162094;
				short num2 = num;
				num = (short)1181314222;
				switch (num2 == num)
				{
				}
				num = (short)173342721;
				if (num != 0)
				{
				}
				num = (short)321257472;
				if (num != 0)
				{
				}
				num = (short)1730609152;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset._MaxPool;
			}
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x00249C54 File Offset: 0x00247E54
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x00249D10 File Offset: 0x00247F10
		public override int Max
		{
			get
			{
				short num = (short)1934688256;
				short num2 = num;
				if (this._DynMax == -1)
				{
					num = (short)247085834;
					short num3 = num;
					num = (short)1102592778;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1843003392;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset._Max;
					}
				}
				num = (short)1890648065;
				if (num != 0)
				{
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)524599462;
				short num2 = num;
				num = (short)1777713318;
				switch (num2 == num)
				{
				}
				num = (short)152043521;
				if (num != 0)
				{
				}
				num = (short)1051394048;
				if (num != 0)
				{
				}
				num = (short)902037504;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x00249DC0 File Offset: 0x00247FC0
		public override int Min
		{
			get
			{
				short num = (short)1903798583;
				short num2 = num;
				num = (short)1691461943;
				switch (num2 == num)
				{
				}
				num = (short)306315265;
				if (num != 0)
				{
				}
				num = (short)863567872;
				if (num != 0)
				{
				}
				num = (short)1183252480;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset._Min;
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x00249E70 File Offset: 0x00248070
		// (set) Token: 0x06002592 RID: 9618 RVA: 0x00249F20 File Offset: 0x00248120
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1330210185;
				short num2 = num;
				num = (short)234186121;
				switch (num2 == num)
				{
				}
				num = (short)1482817536;
				if (num != 0)
				{
				}
				num = (short)451149825;
				if (num != 0)
				{
				}
				num = (short)721616896;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)439363657;
				short num2 = num;
				num = (short)65873993;
				switch (num2 == num)
				{
				}
				num = (short)1962803201;
				if (num != 0)
				{
				}
				num = (short)1964310528;
				if (num != 0)
				{
				}
				num = (short)926810112;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x00249FD0 File Offset: 0x002481D0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1774274383;
				short num2 = num;
				num = (short)1925138255;
				switch (num2 == num)
				{
				}
				num = (short)705167360;
				if (num != 0)
				{
				}
				num = (short)443744257;
				if (num != 0)
				{
				}
				num = (short)1284702208;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x0024A080 File Offset: 0x00248280
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1298664719;
			short num2 = num;
			num = (short)1547308303;
			switch (num2 == num)
			{
			}
			num = (short)856555521;
			if (num != 0)
			{
			}
			num = (short)1850343424;
			if (num != 0)
			{
			}
			num = (short)1416036352;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInner(this);
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x0024A130 File Offset: 0x00248330
		internal void SetValues()
		{
			short num = (short)1847331256;
			short num2 = num;
			num = (short)647825848;
			switch (num2 == num)
			{
			}
			num = (short)1396965376;
			if (num != 0)
			{
			}
			num = (short)476381185;
			if (num != 0)
			{
			}
			num = (short)758906880;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_SECUREHARDWAREENCRYPTIONINDEPENDENTKEYLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_SECKEY;
			base.DataTransferOrder = 27;
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x0024A208 File Offset: 0x00248408
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)948768978;
			short num2 = num;
			num = (short)663883986;
			switch (num2 == num)
			{
			}
			num = (short)924778496;
			if (num != 0)
			{
			}
			num = (short)208470017;
			if (num != 0)
			{
			}
			num = (short)1222967296;
			short num3 = num;
			base.OnFinishedAddRecord();
			this.b(record);
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x0024A2C0 File Offset: 0x002484C0
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)30421511;
			short num2 = num;
			num = (short)614478343;
			switch (num2 == num)
			{
			}
			num = (short)1498742785;
			if (num != 0)
			{
			}
			num = (short)757858304;
			if (num != 0)
			{
			}
			num = (short)650444800;
			short num3 = num;
			this.a(A_0);
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x0024A370 File Offset: 0x00248570
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)2080899072;
			switch (num)
			{
			default:
			{
				num = (short)1306656769;
				if (num != 0)
				{
				}
				num = (short)1496842254;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				global::AcpBusinessLayer.AcpSimpleRangeField secProfIndependMultikeyListCKR_;
				for (;;)
				{
					int num4;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
					switch (num2)
					{
					case 0:
						goto IL_4DD;
					case 1:
						num3++;
						num4 = 0;
						num = (short)1082785810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						goto IL_4DD;
					case 4:
					{
						int num5;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset secureHardwareEncryptionIndependentKeyListInnerRecset;
						if (num5 >= secureHardwareEncryptionIndependentKeyListInnerRecset.Count - 1)
						{
							num = (short)1145176084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1461649421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						int[] array;
						if (num3 == array[num4])
						{
							num = (short)654180353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64E;
					}
					case 6:
					{
						if (A_0.Parent.ParentSection == null)
						{
							num = (short)122159106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int index = (A_0.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile).Position - 1;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset secureHardwareEncryptionIndependentKeyListInnerRecset = secureKMFProfileRecset[index][10881].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset;
						secProfIndependMultikeyListCKR_ = (A_0[10882] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerSection).SecProfIndependMultikeyListCKR_43594;
						int[] array = new int[secureHardwareEncryptionIndependentKeyListInnerRecset.Count - 1];
						num3 = 0;
						int value = secProfIndependMultikeyListCKR_.Value;
						bool flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureHardwareEncryptionIndependentKeyListInnerRecset.GetEnumerator();
						num = (short)1135738891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1702101014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)558170124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_5D0;
					case 10:
						goto IL_5D0;
					case 11:
					{
						try
						{
							num = (short)459669504;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_279;
									}
									continue;
								case 1:
								{
									bool flag;
									if (!flag)
									{
										num = (short)173801483;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_367;
								}
								case 2:
								{
									int value;
									int secProfIndependMultikeyListCKR_43594Value;
									if (value == secProfIndependMultikeyListCKR_43594Value)
									{
										num = (short)703201285;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_367;
								}
								case 3:
								{
									int[] array;
									int secProfIndependMultikeyListCKR_43594Value;
									array[num3] = secProfIndependMultikeyListCKR_43594Value;
									num3++;
									num = (short)1497104394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									int[] array;
									if (num3 < array.Length)
									{
										num = (short)988020739;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)2087059457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1903230984;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_3E6;
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1831206918;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int secProfIndependMultikeyListCKR_43594Value = (((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10882] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerSection).SecProfIndependMultikeyListCKR_43594Value;
									num = (short)1970470914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									bool flag = true;
									num = (short)1704853511;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_2AF:
								num = (short)2060582921;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_279:
								goto IL_2AF;
								IL_367:
								num = (short)686292996;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3E6:
							goto IL_146;
						}
						finally
						{
							num = (short)726394112;
							short num6 = num;
							num = (short)2116740352;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_485:
								enumerator.Dispose();
								num = (short)1129775104;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)551485440;
								if (num != 0)
								{
								}
								num = (short)1352663042;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4A4;
								case 1:
									goto IL_485;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_46A;
									}
									continue;
								}
								IL_46A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)719650817;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4A4:;
						}
						goto IL_4A7;
						IL_146:
						int num5 = 0;
						num = (short)236781571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						if (!global::AcpCommonLib.AppInfoManager.AddDefaultRecord)
						{
							num = (short)999555096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)275644416;
						short num7 = num;
						num = (short)717029395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						int num5;
						int[] array;
						int value;
						if (value == array[num5])
						{
							num = (short)1566507034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5++;
						num = (short)201392128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						switch (0)
						{
						case 0:
							goto IL_DB;
						}
						continue;
					case 15:
						goto IL_19B;
					case 16:
						num = (short)2083586054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						secureKMFProfileRecset = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
						num = (short)146145289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_64E;
					case 19:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1095041041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A7;
					case 20:
						goto IL_51D;
					case 21:
						goto IL_19B;
					case 22:
						if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
						{
							num = (short)1019674632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 23:
						if (secureKMFProfileRecset != null)
						{
							num = (short)195952656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 24:
						goto IL_7A2;
					case 25:
						goto IL_1DB;
					case 26:
						num4 = 0;
						num = (short)622592015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset secureHardwareEncryptionIndependentKeyListInnerRecset;
						if (num4 >= secureHardwareEncryptionIndependentKeyListInnerRecset.Count - 1)
						{
							num = (short)726663193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)711065605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_DB:
					if (!global::AcpCommonLib.AppInfoManager.DndOperation)
					{
						num = (short)1531379719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_19B:
					num = (short)2019033115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A7:
					secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
					num = (short)1588854794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DD:
					num = (short)796655620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D0:
					num = (short)1746862103;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64E:
					num4++;
					num = (short)1966145557;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DB:
				secProfIndependMultikeyListCKR_.Value = num3;
				return;
				IL_51D:
				return;
				IL_7A2:
				return;
			}
			}
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x0024AB40 File Offset: 0x00248D40
		// Note: this type is marked as 'beforefieldinit'.
		static SecureHardwareEncryptionIndependentKeyListInnerRecset()
		{
			short num = (short)1575702524;
			short num2 = num;
			num = (short)45895676;
			switch (num2 == num)
			{
			}
			num = (short)284033024;
			if (num != 0)
			{
			}
			num = (short)1442447361;
			if (num != 0)
			{
			}
			num = (short)1359740928;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset._Min = 1;
		}

		// Token: 0x04000D66 RID: 3430
		public static int _MaxPool;

		// Token: 0x04000D67 RID: 3431
		public static int _Max;

		// Token: 0x04000D68 RID: 3432
		public int _DynMax;

		// Token: 0x04000D69 RID: 3433
		public static int _Min;

		// Token: 0x04000D6A RID: 3434
		public static int _DefaultRecordCount;
	}
}
