using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x02000559 RID: 1369
	[global::System.Serializable]
	public class ConventionalSystemRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600B74A RID: 46922 RVA: 0x00AA51A4 File Offset: 0x00AA33A4
		public ConventionalSystemRecset() : base(global::CommonResources.AcgResources.ID_CONVENTIONALSYSTEM, global::CommonResources.AcgResources.ID_CNVSYS)
		{
			this.SetValues();
		}

		// Token: 0x0600B74B RID: 46923 RVA: 0x00AA51C8 File Offset: 0x00AA33C8
		public ConventionalSystemRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17005BB0 RID: 23472
		// (get) Token: 0x0600B74C RID: 46924 RVA: 0x00AA51F4 File Offset: 0x00AA33F4
		public override int MaxPool
		{
			get
			{
				short num = (short)1730947529;
				short num2 = num;
				num = (short)341125577;
				switch (num2 == num)
				{
				}
				num = (short)2090532864;
				short num3 = num;
				num = (short)1330249729;
				if (num != 0)
				{
				}
				num = (short)1863122944;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset._MaxPool;
			}
		}

		// Token: 0x17005BB1 RID: 23473
		// (get) Token: 0x0600B74D RID: 46925 RVA: 0x00AA52A0 File Offset: 0x00AA34A0
		// (set) Token: 0x0600B74E RID: 46926 RVA: 0x00AA5360 File Offset: 0x00AA3560
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax == -1)
				{
					num = (short)163100495;
					short num2 = num;
					num = (short)553760591;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2106720256;
						if (num != 0)
						{
						}
						num = (short)462225408;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset._Max;
					}
					}
				}
				num = (short)427098113;
				if (num != 0)
				{
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1916677155;
				short num2 = num;
				num = (short)1605315619;
				switch (num2 == num)
				{
				}
				num = (short)1378746368;
				short num3 = num;
				num = (short)494010369;
				if (num != 0)
				{
				}
				num = (short)1596719104;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17005BB2 RID: 23474
		// (get) Token: 0x0600B74F RID: 46927 RVA: 0x00AA5410 File Offset: 0x00AA3610
		public bool HasDiffs
		{
			get
			{
				short num = (short)178323457;
				if (num != 0)
				{
				}
				num = (short)958742350;
				short num2 = num;
				num = (short)925384526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1679163392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1751318528;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005BB3 RID: 23475
		// (get) Token: 0x0600B750 RID: 46928 RVA: 0x00AA54C0 File Offset: 0x00AA36C0
		// (set) Token: 0x0600B751 RID: 46929 RVA: 0x00AA556C File Offset: 0x00AA376C
		public override int Min
		{
			get
			{
				short num = (short)443478058;
				short num2 = num;
				num = (short)1621028906;
				switch (num2 == num)
				{
				}
				num = (short)372113408;
				short num3 = num;
				num = (short)2024865792;
				if (num != 0)
				{
				}
				num = (short)310575105;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset._Min;
			}
			set
			{
				short num = (short)459840921;
				short num2 = num;
				num = (short)1208130969;
				switch (num2 == num)
				{
				}
				num = (short)355860480;
				short num3 = num;
				num = (short)1672937472;
				if (num != 0)
				{
				}
				num = (short)1815740417;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset._Min = value;
			}
		}

		// Token: 0x0600B752 RID: 46930 RVA: 0x00AA561C File Offset: 0x00AA381C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1963781848;
			short num2 = num;
			num = (short)407498456;
			switch (num2 == num)
			{
			}
			num = (short)2043346944;
			short num3 = num;
			num = (short)896270337;
			if (num != 0)
			{
			}
			num = (short)808779776;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem(this);
		}

		// Token: 0x0600B753 RID: 46931 RVA: 0x00AA56CC File Offset: 0x00AA38CC
		internal void SetValues()
		{
			int a_ = 14;
			short num = (short)617791387;
			short num2 = num;
			num = (short)1041743771;
			switch (num2 == num)
			{
			}
			num = (short)589758464;
			short num3 = num;
			num = (short)143523840;
			if (num != 0)
			{
			}
			num = (short)1774256129;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2053;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4ꓦ蛨蛪鷬胮鿰雲鯴菶ꗸ룺鋼釾眀昂欄猆怈搊挌渎紐㌒嘔砖眘級琜砞吠儢䐤匦䀨䐪䌬献爰尲嬴䄶尸唺䤼嘾⹀ⵂ⑄⭆楈ᡊ㑌㱎═㙒㡔ୖᩘ㑚㍜⥞Ѡൢᅤ๦٨ժ౬ͮ≰ੲٴͶᱸᙺ⥼ᵾ궂ﶄ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSYSTEM;
			base.KeySeed = global::CommonResources.AcgResources.ID_CNVSYS;
			base.DataTransferOrder = 42;
		}

		// Token: 0x0600B754 RID: 46932 RVA: 0x00AA57CC File Offset: 0x00AA39CC
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1144994236;
			short num2 = num;
			num = (short)1899116988;
			switch (num2 == num)
			{
			}
			num = (short)1721040896;
			short num3 = num;
			num = (short)309395456;
			if (num != 0)
			{
			}
			num = (short)543686657;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord(record);
			this.d(record);
			this.e(record);
		}

		// Token: 0x0600B755 RID: 46933 RVA: 0x00AA588C File Offset: 0x00AA3A8C
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)918442313;
			short num2 = num;
			num = (short)1880248649;
			switch (num2 == num)
			{
			}
			num = (short)1007681536;
			short num3 = num;
			num = (short)2067136513;
			if (num != 0)
			{
			}
			num = (short)2013724672;
			if (num != 0)
			{
			}
			this.c(record);
			base.OnFinishedRemoveRecord(record);
			this.e(record);
		}

		// Token: 0x0600B756 RID: 46934 RVA: 0x00AA594C File Offset: 0x00AA3B4C
		private void e(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1612382209;
			if (num != 0)
			{
			}
			num = (short)1469633416;
			short num2 = num;
			num = (short)1889915784;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1722220544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1467482112;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B757 RID: 46935 RVA: 0x00AA59F4 File Offset: 0x00AA3BF4
		private void d(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1559394128;
			short num2 = num;
			num = (short)1683322704;
			switch (num2 == num)
			{
			}
			num = (short)1110048768;
			short num3 = num;
			num = (short)1735786497;
			if (num != 0)
			{
			}
			num = (short)1093926912;
			if (num != 0)
			{
			}
			this.b(A_0);
		}

		// Token: 0x0600B758 RID: 46936 RVA: 0x00AA5AA8 File Offset: 0x00AA3CA8
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)580441584;
			short num2 = num;
			num = (short)893834736;
			switch (num2 == num)
			{
			}
			num = (short)1370357760;
			short num3 = num;
			num = (short)679411712;
			if (num != 0)
			{
			}
			num = (short)456589313;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600B759 RID: 46937 RVA: 0x00AA5B58 File Offset: 0x00AA3D58
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1942683648;
			switch (num)
			{
			default:
			{
				num = (short)1166213120;
				short num2 = num;
				num = (short)187564037;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset individualIDTonesInnerRecset;
					switch (num3)
					{
					case 0:
						num = (short)209453062;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)761790465;
							if (num != 0)
							{
							}
							num = (short)1852440580;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						int num4 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = individualIDTonesInnerRecset.GetEnumerator();
						num = (short)127795207;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)1153695745;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_372;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_91;
						}
						continue;
					case 6:
						if (global::AcpCommonLib.AppInfoManager.AddDefaultRecord)
						{
							num = (short)2123366403;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						try
						{
							num = (short)872284166;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									num = (short)1711538181;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2017853449;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection individualIDTonesInnerSection = ((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner)enumerator.Current).IndividualIDTonesInnerSection;
									int num4;
									num4++;
									num = (short)1785069575;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_103;
									}
									continue;
								case 7:
								{
									int num4;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection individualIDTonesInnerSection;
									switch (num4)
									{
									case 2:
										individualIDTonesInnerSection.CnvSysGeneralQc2Name_A42231.Value = global::CommonResources.AppResources.QC2_Tone_B;
										individualIDTonesInnerSection.CnvSysGeneralQc2Freq_A42232.Value = 9032;
										individualIDTonesInnerSection.CnvSysGeneralQc2Code_A42234.Value = 94;
										num = (short)1005453314;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										num = (short)1083152759;
										short num5 = num;
										num = (short)385718647;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)57147392;
											if (num != 0)
											{
											}
											individualIDTonesInnerSection.CnvSysGeneralQc2Name_A42231.Value = global::CommonResources.AppResources.QC2_Tone_C;
											individualIDTonesInnerSection.CnvSysGeneralQc2Freq_A42232.Value = 2885;
											individualIDTonesInnerSection.CnvSysGeneralQc2Code_A42234.Value = 1;
											num = (short)1076887555;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
										break;
									default:
										num = (short)2117926912;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									individualIDTonesInnerSection.CnvSysGeneralQc2Name_A42231.Value = global::CommonResources.AppResources.QC2_Tone_D;
									individualIDTonesInnerSection.CnvSysGeneralQc2Freq_A42232.Value = 2885;
									individualIDTonesInnerSection.CnvSysGeneralQc2Code_A42234.Value = 1;
									num = (short)1388380164;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_303;
								case 9:
									num = (short)722272264;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_108:
								num = (short)885653505;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_103:
								goto IL_108;
							}
							IL_303:
							return;
						}
						finally
						{
							num = (short)1326645250;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num3)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1534263297;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_36F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_33A;
									}
									continue;
								}
								IL_33A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1513095168;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_36F:;
						}
						goto IL_372;
					case 8:
						if (individualIDTonesInnerRecset != null)
						{
							num = (short)1414856706;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_91:
					if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
					{
						num = (short)262995968;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_372:
					global::AcpCommonLib.IAcpRecordset parent = A_0.Parent;
					individualIDTonesInnerRecset = ((A_0 as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).QuikCallII.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset);
					num = (short)1996292104;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600B75A RID: 46938 RVA: 0x00AA6018 File Offset: 0x00AA4218
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)988217344;
			switch (num)
			{
			default:
			{
				num = (short)90112007;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1622671361;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
					global::AcpCommonLib.IAcpRecordset feature;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						try
						{
							num = (short)597360645;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (conventionalSystem.ReferenceKey != conventionalSystem2.ReferenceKey)
									{
										num = (short)233570312;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1850998788;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
									num = (short)1794637824;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (!global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, conventionalSystem.Permissions))
									{
										num = (short)17301510;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_21D;
								case 4:
									num = (short)1458765831;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_16C;
									}
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem3 = conventionalSystem;
									num = (short)1618411523;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_2C6;
								case 8:
									num = (short)1150222338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_222:
								num = (short)1447019402;
								short num3 = num;
								num = (short)1769063306;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_16C:
									goto IL_222;
								default:
									num = (short)2120941568;
									if (num != 0)
									{
									}
									num = (short)468779009;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_21D:
							IL_2C6:
							goto IL_3CD;
						}
						finally
						{
							num = (short)1511456770;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)534577153;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_336;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2FD;
									}
									continue;
								}
								IL_2FD:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1541079040;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_336:;
						}
						goto IL_339;
						IL_3CD:
						num = (short)1452670987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_339;
					case 3:
						if (base.ContainerDoc.DocType != global::AcpCommonLib.DocumentType.Comparator)
						{
							num = (short)917372930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						try
						{
							num = (short)182517770;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_68C;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)302972935;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									num = (short)800522251;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (!global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, conventionalPersonality.Permissions))
									{
										num = (short)7077892;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1725169672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem3;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									conventionalPersonality.Signaling.CnvPerSignalingSystemNumber_A9243.UIValue = conventionalSystem3.ReferenceKey;
									num = (short)1250623500;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (!conventionalPersonality.Signaling.CnvPerSignalingSystemNumber_A9243.Applicable)
									{
										num = (short)1608515590;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)1166934018;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)736952320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (global::CommonResources.AppResources.Zone_Reserved == conventionalPersonality.Signaling.CnvPerSignalingSystemNumber_A9243.UIValue)
									{
										num = (short)1646460937;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									num = (short)179044357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_4DC;
									}
									continue;
								case 11:
									if (conventionalSystem2 != null)
									{
										num = (short)1831337987;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_636:
								num = (short)447873025;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4DC:
								goto IL_636;
							}
							IL_68C:
							return;
						}
						finally
						{
							num = (short)1308098562;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_6FC;
								case 1:
									enumerator.Dispose();
									num = (short)1982136320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_6C3;
									}
									continue;
								}
								IL_6C3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)90046465;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6FC:;
						}
						goto IL_6FF;
					case 5:
						if (base.ContainerDoc.IsOpen)
						{
							num = (short)1684209673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)feature).GetEnumerator();
						num = (short)1032454144;
						short num4 = num;
						num = (short)1533149188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 8:
					{
						if (feature.Count == 0)
						{
							num = (short)811925504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem3 = null;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (conventionalSystem2.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset).Items.GetEnumerator();
						num = (short)423690241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)763428867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_6FF;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem3;
						if (conventionalSystem3 != null)
						{
							num = (short)2026635270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 12:
						if (feature != null)
						{
							num = (short)2135883789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						num = (short)1092616200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A2:
					if (base.ContainerDoc != null)
					{
						num = (short)564002826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_339:
					conventionalSystem2 = (A_0 as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2059);
					num = (short)1110704140;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6FF:
					num = (short)1437663237;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600B75B RID: 46939 RVA: 0x00AA67A0 File Offset: 0x00AA49A0
		// Note: this type is marked as 'beforefieldinit'.
		static ConventionalSystemRecset()
		{
			short num = (short)923828214;
			short num2 = num;
			num = (short)718503926;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1937768448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)440664065;
			if (num != 0)
			{
			}
			num = (short)231997440;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset._Min = 1;
		}

		// Token: 0x04005B09 RID: 23305
		public static int _MaxPool;

		// Token: 0x04005B0A RID: 23306
		public static int _Max;

		// Token: 0x04005B0B RID: 23307
		public int _DynMax;

		// Token: 0x04005B0C RID: 23308
		public static int _Min;
	}
}
