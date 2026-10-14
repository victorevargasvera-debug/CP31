using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ScanList
{
	// Token: 0x0200011D RID: 285
	[global::System.Serializable]
	public class ScanListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06002A01 RID: 10753 RVA: 0x0028F914 File Offset: 0x0028DB14
		public ScanListInnerRecset() : base(global::CommonResources.AcgResources.ID_SCANMEMBERLIST, global::CommonResources.AcgResources.ID_MEMBER)
		{
			this.SetValues();
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x0028F938 File Offset: 0x0028DB38
		public ScanListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x0028F964 File Offset: 0x0028DB64
		public override int MaxPool
		{
			get
			{
				short num = (short)1518783040;
				short num2 = num;
				num = (short)1826736704;
				switch (num2 == num)
				{
				}
				num = (short)1506738176;
				short num3 = num;
				num = (short)377290753;
				if (num != 0)
				{
				}
				num = (short)1822294016;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x0028FA14 File Offset: 0x0028DC14
		// (set) Token: 0x06002A05 RID: 10757 RVA: 0x0028FAD4 File Offset: 0x0028DCD4
		public override int Max
		{
			get
			{
				short num = (short)121635302;
				short num2 = num;
				num = (short)601293286;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)947060737;
					if (num != 0)
					{
					}
					num = (short)51249152;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					break;
				}
				num = (short)196083712;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset._Max;
			}
			set
			{
				short num = (short)1108912485;
				short num2 = num;
				num = (short)95725925;
				switch (num2 == num)
				{
				}
				num = (short)1443233792;
				short num3 = num;
				num = (short)938737665;
				if (num != 0)
				{
				}
				num = (short)1485832192;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06002A06 RID: 10758 RVA: 0x0028FB84 File Offset: 0x0028DD84
		public override int Min
		{
			get
			{
				short num = (short)198146175;
				short num2 = num;
				num = (short)616855679;
				switch (num2 == num)
				{
				}
				num = (short)633995264;
				short num3 = num;
				num = (short)171507712;
				if (num != 0)
				{
				}
				num = (short)37486593;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset._Min;
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x0028FC34 File Offset: 0x0028DE34
		// (set) Token: 0x06002A08 RID: 10760 RVA: 0x0028FCE0 File Offset: 0x0028DEE0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1315971999;
				short num2 = num;
				num = (short)1431970719;
				switch (num2 == num)
				{
				}
				num = (short)325648384;
				short num3 = num;
				num = (short)264896513;
				if (num != 0)
				{
				}
				num = (short)1092419584;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)462640043;
				short num2 = num;
				num = (short)1950634923;
				switch (num2 == num)
				{
				}
				num = (short)2132672512;
				short num3 = num;
				num = (short)168034305;
				if (num != 0)
				{
				}
				num = (short)1840578560;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x0028FD90 File Offset: 0x0028DF90
		public bool HasDiffs
		{
			get
			{
				short num = (short)39964912;
				short num2 = num;
				num = (short)290705648;
				switch (num2 == num)
				{
				}
				num = (short)448790528;
				short num3 = num;
				num = (short)1637548033;
				if (num != 0)
				{
				}
				num = (short)1149108224;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x0028FE40 File Offset: 0x0028E040
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2122617706;
			short num2 = num;
			num = (short)1731236714;
			switch (num2 == num)
			{
			}
			num = (short)2050490368;
			short num3 = num;
			num = (short)1405681665;
			if (num != 0)
			{
			}
			num = (short)776732672;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner(this);
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x0028FEF4 File Offset: 0x0028E0F4
		internal void SetValues()
		{
			short num = (short)875243564;
			short num2 = num;
			num = (short)178923564;
			switch (num2 == num)
			{
			}
			num = (short)954073088;
			short num3 = num;
			num = (short)1850408961;
			if (num != 0)
			{
			}
			num = (short)2137915392;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_SCANMEMBERLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_MEMBER;
			base.DataTransferOrder = 47;
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x0028FFCC File Offset: 0x0028E1CC
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1244659713;
			if (num != 0)
			{
			}
			num = (short)1170285105;
			short num2 = num;
			num = (short)1125327409;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1217921024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)146538496;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.d(record);
			this.a();
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x00290088 File Offset: 0x0028E288
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)2012716715;
			short num2 = num;
			num = (short)155098795;
			switch (num2 == num)
			{
			}
			num = (short)922419200;
			short num3 = num;
			num = (short)77987841;
			if (num != 0)
			{
			}
			num = (short)1363935232;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.c(record);
			this.a();
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x00290144 File Offset: 0x0028E344
		private void a()
		{
			for (;;)
			{
				IL_00:
				short num = (short)1883832320;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)1480523776;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					case 1:
						goto IL_1B0;
					case 2:
					{
						num = (short)1583066429;
						short num4 = num;
						num = (short)1399303485;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1464729600;
							if (num != 0)
							{
							}
							try
							{
								num = (short)856489985;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1527382020;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_B8;
										}
										continue;
									case 2:
										if (!enumerator.MoveNext())
										{
											num = (short)2031288320;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										(((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)enumerator.Current)[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListChannel_A7620.CalculateValidity();
										num = (short)1853882371;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_142;
									}
									IL_BA:
									num = (short)2141192194;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_B8:
									goto IL_BA;
								}
								IL_142:
								return;
							}
							finally
							{
								num = (short)548208640;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_179;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)14483458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_1AD;
									}
									IL_179:
									if (enumerator == null)
									{
										break;
									}
									num = (short)812253185;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1AD:;
							}
							goto IL_1B0;
						}
						break;
					}
					}
					IL_5A:
					if (base.ParentSection != null)
					{
						num = (short)1114113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_1B0:
					enumerator = (base.ParentSection.Parent[10132].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset).GetEnumerator();
					num = (short)2012545025;
					if (num != 0)
					{
					}
					num = (short)1292566530;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x002903C8 File Offset: 0x0028E5C8
		private void d(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1354993906;
			short num2 = num;
			num = (short)765628658;
			switch (num2 == num)
			{
			}
			num = (short)1852375040;
			short num3 = num;
			num = (short)654639104;
			if (num != 0)
			{
			}
			num = (short)1356791809;
			if (num != 0)
			{
			}
			this.b(A_0);
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x00290478 File Offset: 0x0028E678
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)839717042;
			short num2 = num;
			num = (short)53874866;
			switch (num2 == num)
			{
			}
			num = (short)154009600;
			short num3 = num;
			num = (short)2019164160;
			if (num != 0)
			{
			}
			num = (short)2017918977;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x00290528 File Offset: 0x0028E728
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1345388547;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1E3;
				case 1:
				{
					num = (short)1274019840;
					short num3 = num;
					if (!global::AcpCommonLib.ConstraintManager.Suspended)
					{
						num = (short)657457158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E3;
				}
				case 2:
					num = (short)314703873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1472921601;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6B;
					}
					continue;
				case 4:
					if (base.ParentSection != null)
					{
						num = (short)1123745797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
				{
					num = (short)938625375;
					short num4 = num;
					num = (short)1205225823;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E3;
					default:
					{
						num = (short)254541824;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = (base.ParentSection.Parent[10131] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).FieldsCollection.GetEnumerator();
						num = (short)100335623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 6:
					A_0.CalculateValidity();
					num = (short)1463418880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					try
					{
						num = (short)1283063810;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
							{
								global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
								acpRecRefField.RefreshRecRefItems();
								num = (short)1315176448;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_CC;
								}
								continue;
							case 3:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)928055300;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.AcpRecRefField acpRecRefField = enumerator.Current as global::AcpBusinessLayer.AcpRecRefField;
								num = (short)2088173573;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)888406022;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
								if (acpRecRefField != null)
								{
									num = (short)1224933377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								goto IL_176;
							}
							IL_CE:
							num = (short)1922170883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_CC:
							goto IL_CE;
						}
						IL_176:
						return;
					}
					finally
					{
						num = (short)693633024;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1AB;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)570753026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1E0;
							}
							IL_1AB:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1153105921;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1E0:;
					}
					goto IL_1E3;
				}
				IL_6B:
				if (A_0 != null)
				{
					num = (short)1050804226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1E3:
				num = (short)1283325956;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x00290878 File Offset: 0x0028EA78
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)531103744;
			switch (num)
			{
			default:
			{
				num = (short)55574529;
				if (num != 0)
				{
				}
				num = (short)669450243;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!global::AcpCommonLib.ConstraintManager.Suspended)
						{
							num = (short)1228406791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_120;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = (base.ParentSection.Parent[10131] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).FieldsCollection.GetEnumerator();
						num = (short)479395844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1043660800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 4:
					{
						num = (short)1166802944;
						short num3 = num;
						try
						{
							num = (short)198443010;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)553582597;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField = enumerator.Current as global::AcpBusinessLayer.AcpRecRefField;
									num = (short)1265238019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_229;
									}
									continue;
								case 3:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (acpRecRefField != null)
									{
										num = (short)2064777220;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									acpRecRefField.RefreshRecRefItems();
									num = (short)1747124225;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)16121862;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_2D7;
								}
								IL_266:
								num = (short)1903296512;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_229:
								goto IL_266;
							}
							IL_2D7:
							return;
						}
						finally
						{
							for (;;)
							{
								num = (short)1837891584;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_30F;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1055129602;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_348;
									}
									IL_30F:
									if (enumerator == null)
									{
										goto IL_394;
									}
									num = (short)1454964737;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_348:
								num = (short)274380071;
								short num4 = num;
								num = (short)571716903;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_37D;
								}
							}
							IL_37D:
							num = (short)86114304;
							if (num != 0)
							{
							}
							IL_394:;
						}
						goto Block_5;
					}
					case 5:
						if (base.ParentSection != null)
						{
							num = (short)213385217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_395;
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (base.ParentSection.Parent[10132].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset).GetEnumerator();
						num = (short)87883782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_8C:
					if (base.ParentSection != null)
					{
						num = (short)2037907458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_120:
					num = (short)1322778629;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_5:
					try
					{
						IL_395:
						num = (short)1562902530;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpBusinessLayer.AcpRecRefField scanLstScanListChannel_A;
								scanLstScanListChannel_A.CalculateValidity();
								num = (short)939982851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								num = (short)2053898246;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_3D7;
								}
								continue;
							case 4:
							{
								global::AcpBusinessLayer.AcpRecRefField scanLstScanListChannel_A;
								if (!scanLstScanListChannel_A.Valid)
								{
									num = (short)1602551808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								if (!enumerator2.MoveNext())
								{
									num = (short)1036124161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.AcpRecRefField scanLstScanListChannel_A = (((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)enumerator2.Current)[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListChannel_A7620;
								num = (short)1163329540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_4A1;
							}
							IL_44E:
							num = (short)709361669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3D7:
							goto IL_44E;
						}
						IL_4A1:
						goto IL_120;
					}
					finally
					{
						num = (short)1118961664;
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
									goto IL_4DA;
								}
								continue;
							case 1:
								enumerator2.Dispose();
								num = (short)1890648066;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_512;
							}
							IL_4DA:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)19398657;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_512:;
					}
					break;
				}
				return;
			}
			}
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00290DD0 File Offset: 0x0028EFD0
		// Note: this type is marked as 'beforefieldinit'.
		static ScanListInnerRecset()
		{
			short num = (short)811973914;
			short num2 = num;
			num = (short)1703132442;
			switch (num2 == num)
			{
			}
			num = (short)911147008;
			short num3 = num;
			num = (short)1698299905;
			if (num != 0)
			{
			}
			num = (short)1006370816;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset._Min = 1;
		}

		// Token: 0x04000FBD RID: 4029
		public static int _MaxPool;

		// Token: 0x04000FBE RID: 4030
		public static int _Max;

		// Token: 0x04000FBF RID: 4031
		public int _DynMax;

		// Token: 0x04000FC0 RID: 4032
		public static int _Min;

		// Token: 0x04000FC1 RID: 4033
		public static int _DefaultRecordCount;
	}
}
