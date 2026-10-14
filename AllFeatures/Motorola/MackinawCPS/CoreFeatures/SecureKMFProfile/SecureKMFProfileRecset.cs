using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x02000104 RID: 260
	[global::System.Serializable]
	public class SecureKMFProfileRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600262B RID: 9771 RVA: 0x00254AEC File Offset: 0x00252CEC
		public SecureKMFProfileRecset() : base(global::CommonResources.AcgResources.ID_ASTROOTARPROFILE, global::CommonResources.AcgResources.ID_PROFILE)
		{
			this.SetValues();
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x00254B10 File Offset: 0x00252D10
		public SecureKMFProfileRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x00254B3C File Offset: 0x00252D3C
		public override int MaxPool
		{
			get
			{
				short num = (short)1072900921;
				short num2 = num;
				num = (short)2019830585;
				switch (num2 == num)
				{
				}
				num = (short)1166016513;
				if (num != 0)
				{
				}
				num = (short)1320943616;
				short num3 = num;
				num = (short)1369178112;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset._MaxPool;
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x00254BEC File Offset: 0x00252DEC
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x00254CB0 File Offset: 0x00252EB0
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)1061355521;
					if (num != 0)
					{
					}
					num = (short)1952666313;
					short num2 = num;
					num = (short)164516553;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B1;
					case 1:
						break;
					default:
					{
						num = (short)1175322624;
						short num3 = num;
						break;
					}
					}
					num = (short)946405376;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset._Max;
				}
				IL_B1:
				return this._DynMax;
			}
			set
			{
				short num = (short)1310184372;
				short num2 = num;
				num = (short)51368884;
				switch (num2 == num)
				{
				}
				num = (short)1964703744;
				if (num != 0)
				{
				}
				num = (short)2070413312;
				short num3 = num;
				num = (short)193658881;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x00254D60 File Offset: 0x00252F60
		public bool HasDiffs
		{
			get
			{
				short num = (short)1919228740;
				short num2 = num;
				num = (short)1165826884;
				switch (num2 == num)
				{
				}
				num = (short)1954676737;
				if (num != 0)
				{
				}
				num = (short)1099235328;
				short num3 = num;
				num = (short)1316552704;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x00254E10 File Offset: 0x00253010
		// (set) Token: 0x06002632 RID: 9778 RVA: 0x00254EBC File Offset: 0x002530BC
		public override int Min
		{
			get
			{
				short num = (short)265052799;
				short num2 = num;
				num = (short)1877435007;
				switch (num2 == num)
				{
				}
				num = (short)2008023041;
				if (num != 0)
				{
				}
				num = (short)1929314304;
				short num3 = num;
				num = (short)1503920128;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset._Min;
			}
			set
			{
				short num = (short)57063682;
				short num2 = num;
				num = (short)661371138;
				switch (num2 == num)
				{
				}
				num = (short)1806958593;
				if (num != 0)
				{
				}
				num = (short)1969291264;
				short num3 = num;
				num = (short)225574912;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset._Min = value;
			}
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00254F6C File Offset: 0x0025316C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)549223283;
			short num2 = num;
			num = (short)664894323;
			switch (num2 == num)
			{
			}
			num = (short)1541931009;
			if (num != 0)
			{
			}
			num = (short)778371072;
			short num3 = num;
			num = (short)754188288;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.FeatureNode result = new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile(this);
			this.b();
			return result;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00255024 File Offset: 0x00253224
		internal void SetValues()
		{
			int a_ = 9;
			short num = (short)1109344564;
			short num2 = num;
			num = (short)1425031476;
			switch (num2 == num)
			{
			}
			num = (short)262930433;
			if (num != 0)
			{
			}
			num = (short)1990656000;
			short num3 = num;
			num = (short)591724544;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2055;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("诉ꃋꋍ雏럑뗓ꋕ귗꣙맛귝\udbdfꇡ诣该飧藩苫语黯蛱ꣳꗵ鷷駹觻賽旿∁䜃椅昇氉攋植攏怑甓戕焗甙爛䈝猟䜡䜣匥娧伩ఫ攭累琱ᐳ昵䨷唹娻圽ⰿ❁ᡃᕅⵇ⥉㥋㱍㕏ᥑᥓၕࡗ⡙㍛㡝य़๡ţ㉥੧٩䉫᙭ᅯάᡳ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ASTROOTARPROFILE;
			base.KeySeed = global::CommonResources.AcgResources.ID_PROFILE;
			base.DataTransferOrder = 27;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x00255120 File Offset: 0x00253320
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)820523348;
			short num2 = num;
			num = (short)1420112212;
			switch (num2 == num)
			{
			}
			num = (short)634060800;
			if (num != 0)
			{
			}
			num = (short)1918304256;
			short num3 = num;
			num = (short)155385857;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord(record);
			this.c(record);
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x002551D8 File Offset: 0x002533D8
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1422001620;
			short num2 = num;
			num = (short)566625748;
			switch (num2 == num)
			{
			}
			num = (short)323878913;
			if (num != 0)
			{
			}
			num = (short)611975168;
			short num3 = num;
			num = (short)1690042368;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord(record);
			this.b(record);
			this.c();
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x00255298 File Offset: 0x00253498
		private void c()
		{
			short num = (short)491978753;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
			try
			{
				num = (short)896729091;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1869742082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_E3;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_67;
						}
						continue;
					case 4:
						if (!enumerator.MoveNext())
						{
							num = (short)176881664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current).General.SecKmfProfileSecureProfileGUID_43662.CalculateValidity();
						num = (short)1401815041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_99:
					num = (short)410714116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_67:
					goto IL_99;
				}
				IL_E3:;
			}
			finally
			{
				num = (short)770899969;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)215239834;
						short num3 = num;
						num = (short)1589922970;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_137;
						default:
							goto IL_189;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_119;
						}
						continue;
					case 2:
						goto IL_137;
					}
					IL_119:
					if (enumerator != null)
					{
						num = (short)793247746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A0;
					IL_137:
					enumerator.Dispose();
					num = (short)2051801088;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_189:
				num = (short)1630994432;
				if (num != 0)
				{
				}
				IL_1A0:;
			}
			num = (short)1280245760;
			short num4 = num;
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00255480 File Offset: 0x00253680
		private void b()
		{
			short num = (short)1716062111;
			short num2 = num;
			num = (short)1563559839;
			switch (num2 == num)
			{
			}
			num = (short)434569216;
			if (num != 0)
			{
			}
			num = (short)689700864;
			short num3 = num;
			num = (short)1024262145;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset.TriggerKMFProfileTableSizeCheck();
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x0025552C File Offset: 0x0025372C
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)412873972;
			short num2 = num;
			num = (short)1807676660;
			switch (num2 == num)
			{
			}
			num = (short)1237057536;
			if (num != 0)
			{
			}
			num = (short)1998520320;
			short num3 = num;
			num = (short)1258815489;
			if (num != 0)
			{
			}
			this.a(A_0);
			this.a();
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x002555E0 File Offset: 0x002537E0
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)714084507;
			short num2 = num;
			num = (short)557322395;
			switch (num2 == num)
			{
			}
			num = (short)1681850369;
			if (num != 0)
			{
			}
			num = (short)1771307008;
			short num3 = num;
			num = (short)1890189312;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00255690 File Offset: 0x00253890
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num;
			for (;;)
			{
				num = (short)549191681;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)638844934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_41;
						}
						continue;
					case 2:
						if (!(A_0 as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile).General.SecKmfProfGenIndependentKeyList_43597.Value)
						{
							num = (short)1417412608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A3;
					case 3:
						goto IL_B9;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation astrootarinformation;
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR astrootar;
						astrootarinformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.SetValue(astrootar.SecWideASTROOTARIndividualASTROOTARRadioID_A8284.Value);
						num = (short)501022723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)749600769;
						if (num != 0)
						{
						}
						num = (short)1149501440;
						short num3 = num;
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR astrootar = (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide).ASTROOTAR;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation astrootarinformation = A_0[10124] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation;
						num = (short)962854914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR astrootar;
						if (astrootar.SecWideASTROOTARIndividualASTROOTARRadioID_A8284.Visible)
						{
							num = (short)1044840452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A3;
					}
					}
					IL_41:
					if (!global::AcpCommonLib.FeatureManager.IsInitialized)
					{
						break;
					}
					num = (short)736362501;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A3:
				num = (short)1865553174;
				short num4 = num;
				num = (short)1484592406;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_1D7;
				}
				IL_B9:
				goto IL_1A3;
			}
			IL_1D7:
			num = (short)1230176256;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x0025588C File Offset: 0x00253A8C
		private void a()
		{
			short num = (short)145948672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset enhancedDataPortListRecset;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset dataWideRecset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)15138819;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset;
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_2C3;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									if (enhancedDataPortList.EnhancedDataPortList42005 != null)
									{
										num = (short)398786572;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									if (enhancedDataPortList != null)
									{
										num = (short)1856156951;
										short num3 = num;
										num = (short)456897815;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_2C3;
										default:
											num = (short)1474232320;
											if (num != 0)
											{
											}
											num = (short)252575754;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_286;
									}
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									enhancedDataPortTableInnerRecset = (enhancedDataPortList.EnhancedDataPortList42005.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset);
									num = (short)4325382;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									if (enhancedDataPortList.EnhancedDataPortList42005.EmbeddedRecset != null)
									{
										num = (short)2949124;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									if (enhancedDataPortTableInnerRecset != null)
									{
										num = (short)1628176384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1451753483;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList;
									num = (short)1058406402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									try
									{
										num = (short)2033123331;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)915537922;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_3E7;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_360;
												}
												continue;
											case 4:
												if (!enumerator2.MoveNext())
												{
													num = (short)1691811840;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												(enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner).EnhancedDataPortTableInnerSection.DataWideEnhDataPortListPortNum_A42008.CalculateValidity();
												num = (short)194314241;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_395:
											num = (short)1763704836;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_360:
											goto IL_395;
										}
										IL_3E7:
										break;
									}
									finally
									{
										num = (short)2013462529;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_457;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_41E;
												}
												continue;
											case 2:
												enumerator2.Dispose();
												num = (short)1595473920;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_41E:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)2092761090;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_457:;
									}
									goto IL_45A;
								case 9:
									goto IL_59E;
								case 10:
									num = (short)1788280833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									num = (short)266731529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_45A;
								}
								IL_288:
								num = (short)1145307143;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_286:
								goto IL_288;
								IL_2C3:
								enumerator2 = enhancedDataPortTableInnerRecset.GetEnumerator();
								num = (short)1027276808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_45A:
								num = (short)1947402245;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_59E:;
						}
						finally
						{
							num = (short)613154817;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_60A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5D4;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1140326400;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5D4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2118254594;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_60A:;
						}
						goto IL_60D;
					case 1:
						num = (short)660209668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (enhancedDataPortListRecset != null)
						{
							num = (short)978583553;
							if (num != 0)
							{
							}
							num = (short)1924333568;
							short num4 = num;
							num = (short)1294532614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_60D;
					case 3:
						if (dataWideRecset != null)
						{
							num = (short)1432354817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						if (dataWideRecset.Count > 0)
						{
							num = (short)1540292615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						return;
					case 6:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = enhancedDataPortListRecset.GetEnumerator();
						num = (short)858259456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideP25LocationReportingUDPPort_42413.CalculateValidity();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideWIFIOTAPTCPPort_42627.CalculateValidity();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022.CalculateApplicability();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022.CalculateValidity();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205.CalculateApplicability();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205.CalculateValidity();
						num = (short)1048772613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4E;
					IL_60D:
					dataWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2028) as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset);
					num = (short)941621251;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_4E:
				enhancedDataPortListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4148) as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset);
				num = (short)382074882;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00255F28 File Offset: 0x00254128
		public static void TriggerKMFProfileTableSizeCheck()
		{
			short num = (short)1814298624;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)499190048;
					short num3 = num;
					num = (short)1251608864;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B4;
					case 1:
						break;
					default:
					{
						num = (short)1430978560;
						short num4 = num;
						break;
					}
					}
					num = (short)209321984;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_A8;
					}
					continue;
				}
				case 1:
					num = (short)927793153;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConIsSecureOperationApp(((global::AcpCommonLib.FeatureManager.GetFeature(2021) as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide).General);
					num = (short)1564934146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				}
				goto IL_A8;
				IL_B4:
				num = (short)1895628801;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A8:
				if (global::AcpCommonLib.FeatureManager.GetFeature(2055) != null)
				{
					goto IL_B4;
				}
				break;
			}
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00256068 File Offset: 0x00254268
		// Note: this type is marked as 'beforefieldinit'.
		static SecureKMFProfileRecset()
		{
			short num = (short)1750401615;
			short num2 = num;
			num = (short)1110114895;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1344012288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1568931841;
			if (num != 0)
			{
			}
			num = (short)2069692416;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset._Min = 1;
		}

		// Token: 0x04000E4F RID: 3663
		public static int _MaxPool;

		// Token: 0x04000E50 RID: 3664
		public static int _Max;

		// Token: 0x04000E51 RID: 3665
		public int _DynMax;

		// Token: 0x04000E52 RID: 3666
		public static int _Min;
	}
}
