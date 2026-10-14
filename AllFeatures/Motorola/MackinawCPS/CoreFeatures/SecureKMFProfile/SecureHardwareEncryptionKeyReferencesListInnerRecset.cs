using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x02000101 RID: 257
	[global::System.Serializable]
	public class SecureHardwareEncryptionKeyReferencesListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060025DD RID: 9693 RVA: 0x0024DDB0 File Offset: 0x0024BFB0
		public SecureHardwareEncryptionKeyReferencesListInnerRecset() : base(global::CommonResources.AcgResources.ID_SECUREHARDWAREENCRYPTIONKEYREFERENCESLIST, global::CommonResources.AcgResources.ID_SECKEYREF)
		{
			this.SetValues();
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x0024DDD4 File Offset: 0x0024BFD4
		public SecureHardwareEncryptionKeyReferencesListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x0024DE00 File Offset: 0x0024C000
		public override int MaxPool
		{
			get
			{
				short num = (short)1191520413;
				short num2 = num;
				num = (short)338503837;
				switch (num2 == num)
				{
				}
				num = (short)219938817;
				if (num != 0)
				{
				}
				num = (short)897712128;
				short num3 = num;
				num = (short)921894912;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x0024DEAC File Offset: 0x0024C0AC
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x0024DF70 File Offset: 0x0024C170
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)1641611578;
					short num2 = num;
					num = (short)229245242;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)308674561;
						if (num != 0)
						{
						}
						num = (short)811991040;
						if (num != 0)
						{
						}
						num = (short)2013528064;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)36559478;
				short num2 = num;
				num = (short)1406261878;
				switch (num2 == num)
				{
				}
				num = (short)1944190977;
				if (num != 0)
				{
				}
				num = (short)102170624;
				short num3 = num;
				num = (short)1601503232;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x0024E020 File Offset: 0x0024C220
		public override int Min
		{
			get
			{
				short num = (short)563324705;
				short num2 = num;
				num = (short)868132641;
				switch (num2 == num)
				{
				}
				num = (short)180355073;
				if (num != 0)
				{
				}
				num = (short)596901888;
				short num3 = num;
				num = (short)1636499456;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset._Min;
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x0024E0D0 File Offset: 0x0024C2D0
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x0024E180 File Offset: 0x0024C380
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)69186923;
				short num2 = num;
				num = (short)1017296235;
				switch (num2 == num)
				{
				}
				num = (short)2043412481;
				if (num != 0)
				{
				}
				num = (short)1078722560;
				short num3 = num;
				num = (short)1770389504;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)115393578;
				short num2 = num;
				num = (short)661308458;
				switch (num2 == num)
				{
				}
				num = (short)1977745408;
				if (num != 0)
				{
				}
				num = (short)774963200;
				short num3 = num;
				num = (short)720568321;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x0024E230 File Offset: 0x0024C430
		public bool HasDiffs
		{
			get
			{
				short num = (short)385636156;
				short num2 = num;
				num = (short)435050300;
				switch (num2 == num)
				{
				}
				num = (short)1270218753;
				if (num != 0)
				{
				}
				num = (short)1634271232;
				short num3 = num;
				num = (short)664141824;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x0024E2DC File Offset: 0x0024C4DC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2004897957;
			short num2 = num;
			num = (short)833376421;
			switch (num2 == num)
			{
			}
			num = (short)1623523329;
			if (num != 0)
			{
			}
			num = (short)201719808;
			short num3 = num;
			num = (short)355729408;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInner(this);
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x0024E388 File Offset: 0x0024C588
		internal void SetValues()
		{
			short num = (short)1023714839;
			short num2 = num;
			num = (short)1549510167;
			switch (num2 == num)
			{
			}
			num = (short)1709572097;
			if (num != 0)
			{
			}
			num = (short)1477574656;
			short num3 = num;
			num = (short)264175616;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_SECUREHARDWAREENCRYPTIONKEYREFERENCESLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_SECKEYREF;
			base.DataTransferOrder = 27;
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x0024E45C File Offset: 0x0024C65C
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1054899668;
			short num2 = num;
			num = (short)885882324;
			switch (num2 == num)
			{
			}
			num = (short)1759182848;
			if (num != 0)
			{
			}
			num = (short)1568538624;
			short num3 = num;
			num = (short)1684209665;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.a();
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x0024E514 File Offset: 0x0024C714
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)96127578;
			short num2 = num;
			num = (short)1795869274;
			switch (num2 == num)
			{
			}
			num = (short)1129054208;
			if (num != 0)
			{
			}
			num = (short)1003683840;
			short num3 = num;
			num = (short)183697409;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.a();
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x0024E5C8 File Offset: 0x0024C7C8
		private void a()
		{
			short num = (short)265093120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_82;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset3;
					switch (num2)
					{
					case 0:
						if (trunkingPersonalityRecset != null)
						{
							num = (short)461897733;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_441;
					case 1:
						enumerator = (base.ParentSection.Parent[10126].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset).GetEnumerator();
						num = (short)217645071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)771817473;
						if (num != 0)
						{
						}
						goto IL_A2C;
					case 3:
						if (astrotalkgroupListRecset != null)
						{
							num = (short)1338507283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22C;
					case 4:
						if (base.ParentSection != null)
						{
							num = (short)1546977281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F9;
					case 5:
						goto IL_834;
					case 6:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1299972113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DE4;
					case 7:
						if (conventionalPersonalityRecset2 != null)
						{
							num = (short)1262354448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_85A;
					case 8:
						if (trunkingPersonalityRecset2 != null)
						{
							num = (short)257097748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						goto IL_B69;
					case 10:
						try
						{
							num = (short)791543811;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)474611714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3D1;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_344;
									}
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1184563200;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current)[10142] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure).CnvPerSecureKeySelection1_A8368.CalculateValidity();
									num = (short)1965948929;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_381:
								num = (short)1581449220;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_344:
								goto IL_381;
							}
							IL_3D1:
							goto IL_DE4;
						}
						finally
						{
							num = (short)1636433921;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_43E;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_408;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)914554880;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_408:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2034434050;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_43E:;
						}
						goto IL_441;
					case 11:
						try
						{
							num = (short)2124087299;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)2093613059;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)261095426;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_66F;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_5DF;
												}
												continue;
											case 4:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)720502784;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												(((global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner)enumerator2.Current)[10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection).TrkPerTalkgroupKeySelect_A8365.CalculateValidity();
												num = (short)1197670401;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_61C:
											num = (short)1287913476;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_5DF:
											goto IL_61C;
										}
										IL_66F:;
									}
									finally
									{
										num = (short)132055041;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												goto IL_6DA;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_6A4;
												}
												continue;
											case 2:
												enumerator2.Dispose();
												num = (short)817561600;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_6A4:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)626393090;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_6DA:;
									}
									break;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)83361796;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current)[10179].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerRecset).GetEnumerator();
									num = (short)2044985344;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_775;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_5A0;
									}
									continue;
								case 4:
									num = (short)1893203970;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6DD:
								num = (short)1503068161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5A0:
								goto IL_6DD;
							}
							IL_775:
							goto IL_441;
						}
						finally
						{
							num = (short)1989476353;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_7E7;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_7AE;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)938082304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_7AE:
								if (enumerator == null)
								{
									goto IL_833;
								}
								num = (short)802816002;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7E7:
							num = (short)1885415111;
							short num3 = num;
							num = (short)1632773831;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)724566016;
								if (num != 0)
								{
								}
								break;
							}
							IL_833:;
						}
						goto IL_834;
					case 12:
						enumerator = trunkingPersonalityRecset3.GetEnumerator();
						num = (short)1750663186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (trunkingPersonalityRecset3 != null)
						{
							num = (short)97583116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26E;
					case 14:
						try
						{
							num = (short)356581378;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_9B9;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_92B;
									}
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)365297668;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current)[10142] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure).CnvPerSecureKeySelection2_A8369.CalculateValidity();
									num = (short)2050883584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)2128674817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_968:
								num = (short)106037251;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_92B:
								goto IL_968;
							}
							IL_9B9:
							goto IL_85A;
						}
						finally
						{
							num = (short)572653568;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_9F1;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)414187522;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_A29;
								}
								IL_9F1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)375914497;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A29:;
						}
						goto Block_11;
					case 15:
						try
						{
							num = (short)411303939;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)230817796;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInner)enumerator.Current)[10127] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection).SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.CalculateValidity();
									num = (short)1248854016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1BA;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_12E;
									}
									continue;
								case 4:
									num = (short)1159790594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_130:
								num = (short)2051342337;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12E:
								goto IL_130;
							}
							IL_1BA:
							goto IL_4F9;
						}
						finally
						{
							num = (short)139788289;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_229;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1F2;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)797704192;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1F2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)156434434;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_229:;
						}
						goto IL_22C;
					case 16:
						enumerator = conventionalPersonalityRecset2.GetEnumerator();
						num = (short)522846222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)1481048074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						try
						{
							num = (short)920518658;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)836239363;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current)[10178] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General).TrkEmerProfGeneralKeySelect_A8970.CalculateValidity();
									num = (short)720371716;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_EF8;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E6B;
									}
									continue;
								case 3:
									num = (short)1431306241;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E6D:
								num = (short)682164224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E6B:
								goto IL_E6D;
							}
							IL_EF8:
							goto IL_26E;
						}
						finally
						{
							num = (short)416481280;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_F30;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1424883714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_F65;
								}
								IL_F30:
								if (enumerator == null)
								{
									break;
								}
								num = (short)992739329;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F65:;
						}
						return;
					case 19:
					{
						num = (short)1458700288;
						short num4 = num;
						enumerator = astrotalkgroupListRecset.GetEnumerator();
						num = (short)223346697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						enumerator = trunkingPersonalityRecset2.GetEnumerator();
						num = (short)124911618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_82;
					IL_22C:
					num = (short)1657536516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_12:
					try
					{
						IL_B69:
						num = (short)1223753730;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								try
								{
									num = (short)1373372418;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)1348599811;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											(((global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner)enumerator2.Current)[10153] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerSection).AstTlkgrpLstTalkgroupListKeySelectReference_A8366.CalculateValidity();
											num = (short)2051932164;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
											goto IL_CAF;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_C1F;
											}
											continue;
										case 3:
											num = (short)188481537;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_C21:
										num = (short)374996992;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_C1F:
										goto IL_C21;
									}
									IL_CAF:;
								}
								finally
								{
									num = (short)1542324224;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_CE4;
											}
											continue;
										case 1:
											enumerator2.Dispose();
											num = (short)876281858;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_D1A;
										}
										IL_CE4:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)1820524545;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_D1A:;
								}
								break;
							case 1:
								goto IL_D73;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_BA4;
								}
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)479330308;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (((global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList)enumerator.Current)[10152].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset).GetEnumerator();
								num = (short)608567296;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)774176769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_D1D:
							num = (short)961871875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BA4:
							goto IL_D1D;
						}
						IL_D73:
						goto IL_22C;
					}
					finally
					{
						num = (short)804782080;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_DAA;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1000538114;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_DE1;
							}
							IL_DAA:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1731723265;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_DE1:;
					}
					goto IL_DE4;
					IL_26E:
					trunkingPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset);
					num = (short)1805975552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_441:
					trunkingPersonalityRecset2 = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset);
					num = (short)1129119752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F9:
					conventionalPersonalityRecset2 = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					num = (short)2093940743;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_834:
					enumerator = trunkingPersonalityRecset.GetEnumerator();
					num = (short)1549139979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_85A:
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					num = (short)1484980230;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DE4:
					trunkingPersonalityRecset3 = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset);
					num = (short)633667597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_11:
					try
					{
						IL_A2C:
						num = (short)1961033730;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num = (short)1414266883;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								(((global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current)[10176] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup).TrkPerAnnouncementGroupAGKeySelect_A7414.CalculateValidity();
								num = (short)826998788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_AF5;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_A68;
								}
								continue;
							case 3:
								num = (short)786563073;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_A6A:
							num = (short)943980544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A68:
							goto IL_A6A;
						}
						IL_AF5:
						break;
					}
					finally
					{
						num = (short)588644352;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_B2E;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)531955714;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_B66;
							}
							IL_B2E:
							if (enumerator == null)
							{
								break;
							}
							num = (short)641204225;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_B66:;
					}
					goto Block_12;
				}
				return;
				IL_82:
				astrotalkgroupListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2062) as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset);
				num = (short)433127427;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x0024F61C File Offset: 0x0024D81C
		// Note: this type is marked as 'beforefieldinit'.
		static SecureHardwareEncryptionKeyReferencesListInnerRecset()
		{
			short num = (short)1486998847;
			short num2 = num;
			num = (short)1442630975;
			switch (num2 == num)
			{
			}
			num = (short)1712783361;
			if (num != 0)
			{
			}
			num = (short)1968570368;
			if (num != 0)
			{
			}
			num = (short)556269568;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset._Min = 1;
		}

		// Token: 0x04000D6E RID: 3438
		public static int _MaxPool;

		// Token: 0x04000D6F RID: 3439
		public static int _Max;

		// Token: 0x04000D70 RID: 3440
		public int _DynMax;

		// Token: 0x04000D71 RID: 3441
		public static int _Min;

		// Token: 0x04000D72 RID: 3442
		public static int _DefaultRecordCount;
	}
}
