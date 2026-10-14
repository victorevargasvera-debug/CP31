using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ActionConsolidation
{
	// Token: 0x0200041E RID: 1054
	[global::System.Serializable]
	public class ConsolidatedActionsInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06009008 RID: 36872 RVA: 0x0087D474 File Offset: 0x0087B674
		public ConsolidatedActionsInnerRecset() : base(global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONS, true, false, global::CommonResources.AcgResources.ID_ALERT)
		{
			this.SetValues();
		}

		// Token: 0x06009009 RID: 36873 RVA: 0x0087D49C File Offset: 0x0087B69C
		public ConsolidatedActionsInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170048AE RID: 18606
		// (get) Token: 0x0600900A RID: 36874 RVA: 0x0087D4C8 File Offset: 0x0087B6C8
		public override int MaxPool
		{
			get
			{
				short num = (short)1085913658;
				short num2 = num;
				num = (short)2008529466;
				switch (num2 == num)
				{
				}
				num = (short)1235681280;
				short num3 = num;
				num = (short)694878208;
				if (num != 0)
				{
				}
				num = (short)1483472897;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset._MaxPool;
			}
		}

		// Token: 0x170048AF RID: 18607
		// (get) Token: 0x0600900B RID: 36875 RVA: 0x0087D574 File Offset: 0x0087B774
		// (set) Token: 0x0600900C RID: 36876 RVA: 0x0087D638 File Offset: 0x0087B838
		public override int Max
		{
			get
			{
				while (this._DynMax == -1)
				{
					short num = (short)775562474;
					short num2 = num;
					num = (short)294528234;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)337248257;
						if (num != 0)
						{
						}
						num = (short)234553344;
						short num3 = num;
						num = (short)707002368;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)758496025;
				short num2 = num;
				num = (short)524925721;
				switch (num2 == num)
				{
				}
				num = (short)34078720;
				short num3 = num;
				num = (short)1435631616;
				if (num != 0)
				{
				}
				num = (short)1680867329;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170048B0 RID: 18608
		// (get) Token: 0x0600900D RID: 36877 RVA: 0x0087D6E8 File Offset: 0x0087B8E8
		public override int Min
		{
			get
			{
				short num = (short)2096687848;
				short num2 = num;
				num = (short)1104145128;
				switch (num2 == num)
				{
				}
				num = (short)1625161728;
				short num3 = num;
				num = (short)1640366081;
				if (num != 0)
				{
				}
				num = (short)204275712;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset._Min;
			}
		}

		// Token: 0x170048B1 RID: 18609
		// (get) Token: 0x0600900E RID: 36878 RVA: 0x0087D798 File Offset: 0x0087B998
		// (set) Token: 0x0600900F RID: 36879 RVA: 0x0087D848 File Offset: 0x0087BA48
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1225811894;
				short num2 = num;
				num = (short)1494443958;
				switch (num2 == num)
				{
				}
				num = (short)126812160;
				short num3 = num;
				num = (short)1390280705;
				if (num != 0)
				{
				}
				num = (short)1851719680;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)2127535120;
				short num2 = num;
				num = (short)1500879888;
				switch (num2 == num)
				{
				}
				num = (short)482541568;
				short num3 = num;
				num = (short)1324613633;
				if (num != 0)
				{
				}
				num = (short)1243742208;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170048B2 RID: 18610
		// (get) Token: 0x06009010 RID: 36880 RVA: 0x0087D8F8 File Offset: 0x0087BAF8
		public bool HasDiffs
		{
			get
			{
				short num = (short)187208343;
				short num2 = num;
				num = (short)359699095;
				switch (num2 == num)
				{
				}
				num = (short)606666752;
				short num3 = num;
				num = (short)1634533377;
				if (num != 0)
				{
				}
				num = (short)379256832;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x0087D9A4 File Offset: 0x0087BBA4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)707638277;
			short num2 = num;
			num = (short)485405701;
			switch (num2 == num)
			{
			}
			num = (short)2123300864;
			short num3 = num;
			num = (short)744947712;
			if (num != 0)
			{
			}
			num = (short)794820609;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner(this);
		}

		// Token: 0x06009012 RID: 36882 RVA: 0x0087DA54 File Offset: 0x0087BC54
		internal void SetValues()
		{
			short num = (short)1522794497;
			if (num != 0)
			{
			}
			num = (short)908608412;
			short num2 = num;
			num = (short)653411228;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1683750912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)686358528;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONS;
			base.KeySeed = global::CommonResources.AcgResources.ID_ALERT;
			base.DataTransferOrder = 55;
		}

		// Token: 0x06009013 RID: 36883 RVA: 0x0087DB28 File Offset: 0x0087BD28
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1332116360;
			short num2 = num;
			num = (short)569473928;
			switch (num2 == num)
			{
			}
			num = (short)367132672;
			short num3 = num;
			num = (short)624689152;
			if (num != 0)
			{
			}
			num = (short)240451585;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.c(record);
			this.b();
		}

		// Token: 0x06009014 RID: 36884 RVA: 0x0087DBE4 File Offset: 0x0087BDE4
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1794266886;
			short num2 = num;
			num = (short)1052333830;
			switch (num2 == num)
			{
			}
			num = (short)740294656;
			short num3 = num;
			num = (short)618987521;
			if (num != 0)
			{
			}
			num = (short)746389504;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.b(record);
			this.b();
		}

		// Token: 0x06009015 RID: 36885 RVA: 0x0087DCA0 File Offset: 0x0087BEA0
		private void b()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)108525842;
					short num3 = num2;
					num2 = (short)1530788114;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_220;
					default:
						num2 = (short)274071553;
						if (num2 != 0)
						{
						}
						num2 = (short)894697472;
						if (num2 != 0)
						{
						}
						if (actionConsolidationRecset != null)
						{
							num2 = (short)1934426114;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					goto IL_220;
				case 2:
					goto IL_200;
				}
				goto IL_1C;
				IL_200:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = actionConsolidationRecset.GetEnumerator();
				num2 = (short)337248257;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_220:
				num2 = (short)352387072;
				short num4 = num2;
				try
				{
					num2 = (short)1775960065;
					num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							num2 = (short)648544259;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_10B;
							}
							continue;
						case 2:
							if (!enumerator.MoveNext())
							{
								num2 = (short)591593472;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							(((global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation)enumerator.Current)[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACGpsReport_A36587.CalculateValidity();
							num2 = (short)1132199940;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							goto IL_193;
						}
						IL_10D:
						num2 = (short)1381433346;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_10B:
						goto IL_10D;
					}
					IL_193:
					break;
				}
				finally
				{
					num2 = (short)1409810432;
					num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1C9;
							}
							continue;
						case 1:
							goto IL_1FD;
						case 2:
							enumerator.Dispose();
							num2 = (short)1535377409;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						IL_1C9:
						if (enumerator == null)
						{
							break;
						}
						num2 = (short)1930231810;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1FD:;
				}
				goto IL_200;
			}
			return;
			IL_1C:
			actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
			num2 = (short)266338304;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009016 RID: 36886 RVA: 0x0087DF0C File Offset: 0x0087C10C
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)902037505;
			if (num != 0)
			{
			}
			num = (short)1448496232;
			short num2 = num;
			num = (short)1910590568;
			switch (num2 == num)
			{
			default:
			{
				num = (short)859701248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1810300928;
			if (num != 0)
			{
			}
			this.a();
			this.a(A_0);
		}

		// Token: 0x06009017 RID: 36887 RVA: 0x0087DFC8 File Offset: 0x0087C1C8
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)378408200;
			short num2 = num;
			num = (short)358026504;
			switch (num2 == num)
			{
			}
			num = (short)1683619840;
			short num3 = num;
			num = (short)800915456;
			if (num != 0)
			{
			}
			num = (short)328990721;
			if (num != 0)
			{
			}
			this.a();
			this.a(A_0);
		}

		// Token: 0x06009018 RID: 36888 RVA: 0x0087E07C File Offset: 0x0087C27C
		private void a()
		{
			short num = (short)1376256000;
			switch (num)
			{
			default:
			{
				num = (short)131727360;
				int num2 = (int)((global::System.IntPtr)num);
				global::AcpBusinessLayer.AcpFieldX<bool, string> radioErgoConfigACGeneralActionAllowed_A;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					case 1:
						if (base.ParentSection != null)
						{
							num = (short)1605959686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						try
						{
							num = (short)1616838656;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_280;
									}
									continue;
								case 2:
								{
									int num3;
									num3++;
									num = (short)1718681601;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									radioErgoConfigACGeneralActionAllowed_A.Value = false;
									bool flag = true;
									num = (short)992608261;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)911474694;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_2DB;
								case 6:
									goto IL_3C8;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10614] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection).RadioErgoConfigACActionID_A36590.Value == 75)
									{
										num = (short)714997762;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)186646532;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)685572105;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10614] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection).RadioErgoConfigACActionID_A36590.Value == 74)
									{
										num = (short)1051197443;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1675362311;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_282:
								num = (short)1102249992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_280:
								goto IL_282;
							}
							IL_2DB:
							IL_3C8:
							goto IL_130;
						}
						finally
						{
							num = (short)2050257765;
							short num4 = num;
							num = (short)313684837;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1615462400;
								if (num != 0)
								{
								}
								num = (short)337903617;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_481;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_44A;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)823721984;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_44A:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1688535042;
									num2 = (int)((global::System.IntPtr)num);
								}
								break;
							}
							IL_481:;
						}
						return;
						IL_130:
						num = (short)688324617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_16F;
					case 4:
						if (base.Count != 0)
						{
							num = (short)1055195141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(base.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation).General.RadioErgoConfigACGeneralActionAllowed_A36579.Value = true;
						num = (short)924123143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)60555265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						radioErgoConfigACGeneralActionAllowed_A = (base.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation).General.RadioErgoConfigACGeneralActionAllowed_A36579;
						bool flag = false;
						int num3 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
						num = (short)922288130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						return;
					case 8:
						return;
					case 9:
					{
						int num3;
						bool flag;
						if (!flag & num3 <= 1)
						{
							num = (short)251920387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF;
					}
					}
					IL_6C:
					if (global::AcpCommonLib.AppInfoManager.UnpackOperation)
					{
						num = (short)1473445888;
						short num5 = num;
						num = (short)1200422920;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1507590148;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_FF:
				num = (short)829816833;
				if (num != 0)
				{
				}
				radioErgoConfigACGeneralActionAllowed_A.Value = false;
				return;
				IL_16F:
				radioErgoConfigACGeneralActionAllowed_A.Value = true;
				return;
			}
			}
		}

		// Token: 0x06009019 RID: 36889 RVA: 0x0087E52C File Offset: 0x0087C72C
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)547553280;
			switch (num)
			{
			default:
			{
				num = (short)153681921;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset consolidatedActionsInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
					switch (num2)
					{
					case 0:
						if (consolidatedActionsInnerRecset != null)
						{
							num = (short)130023431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_70;
						}
						continue;
					case 2:
						num = (short)403898378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (consolidatedActionsInnerRecset.Count > 0)
						{
							num = (short)1427374086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						return;
					case 5:
						try
						{
							num = (short)1202651139;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner;
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1859059720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									consolidatedActionsInner = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner);
									num = (short)175374341;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_29B;
								case 2:
									goto IL_3EF;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_227;
									}
									continue;
								case 4:
									num = (short)1606418445;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (consolidatedActionsInner != null)
									{
										num = (short)576978950;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									num = (short)1452998668;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									consolidatedActionsInner.ConsolidatedActionsInnerSection.RadioErgoConfigACAlertInterval_A42877.Value = 255;
									num = (short)656211969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)437911554;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									num = (short)591659019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									if (consolidatedActionsInner.ConsolidatedActionsInnerSection.RadioErgoConfigACActionID_A36590.Value == 260)
									{
										num = (short)1910112263;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29B;
								case 12:
									if (actionConsolidation != null)
									{
										num = (short)1348403204;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29B;
								case 13:
									if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value == 2)
									{
										num = (short)47054858;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29B;
								}
								IL_25A:
								num = (short)1355677696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_227:
								goto IL_25A;
								IL_29B:
								consolidatedActionsInner.ConsolidatedActionsInnerSection.RadioErgoConfigACAlertInterval_A42877.CalculateValidity();
								num = (short)2110324745;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3EF:
							return;
						}
						finally
						{
							num = (short)1140869990;
							short num3 = num;
							num = (short)397167462;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)140443648;
								if (num != 0)
								{
								}
								num = (short)2016149505;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_4AB;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_475;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)1485504512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_475:
									if (enumerator == null)
									{
										break;
									}
									num = (short)844890114;
									num2 = (int)((global::System.IntPtr)num);
								}
								break;
							}
							IL_4AB:;
						}
						goto IL_4AE;
					case 6:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = consolidatedActionsInnerRecset.GetEnumerator();
						num = (short)816447493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1566179331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!global::AcpCommonLib.ConstraintManager.Suspended)
						{
							num = (short)1358233602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						num = (short)2130509832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)1235091460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AE;
					}
					IL_70:
					num = (short)813826049;
					if (num != 0)
					{
					}
					num = (short)1638662144;
					short num4 = num;
					if (!global::AcpCommonLib.AppInfoManager.UnpackOperation)
					{
						num = (short)1910833161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_4AE:
					consolidatedActionsInnerRecset = (A_0.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset);
					actionConsolidation = (A_0.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
					num = (short)548929536;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600901A RID: 36890 RVA: 0x0087EA64 File Offset: 0x0087CC64
		// Note: this type is marked as 'beforefieldinit'.
		static ConsolidatedActionsInnerRecset()
		{
			short num = (short)879053299;
			short num2 = num;
			num = (short)943344115;
			switch (num2 == num)
			{
			}
			num = (short)55050240;
			if (num != 0)
			{
			}
			num = (short)528089088;
			short num3 = num;
			num = (short)1536884737;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset._Min = 1;
		}

		// Token: 0x04004835 RID: 18485
		public static int _MaxPool;

		// Token: 0x04004836 RID: 18486
		public static int _Max;

		// Token: 0x04004837 RID: 18487
		public int _DynMax;

		// Token: 0x04004838 RID: 18488
		public static int _Min;

		// Token: 0x04004839 RID: 18489
		public static int _DefaultRecordCount;
	}
}
