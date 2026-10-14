using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists
{
	// Token: 0x020005D6 RID: 1494
	[global::System.Serializable]
	public class MessageAliasTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600CE85 RID: 52869 RVA: 0x00C03014 File Offset: 0x00C01214
		public MessageAliasTableInnerRecset() : base(global::CommonResources.AcgResources.ID_MESSAGEALIASTABLE, global::CommonResources.AcgResources.ID_MESSAGE_1)
		{
			this.SetValues();
		}

		// Token: 0x0600CE86 RID: 52870 RVA: 0x00C03038 File Offset: 0x00C01238
		public MessageAliasTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170067DD RID: 26589
		// (get) Token: 0x0600CE87 RID: 52871 RVA: 0x00C03064 File Offset: 0x00C01264
		public override int MaxPool
		{
			get
			{
				short num = (short)1665262778;
				short num2 = num;
				num = (short)643032250;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1338572800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1345847296;
				if (num != 0)
				{
				}
				num = (short)1836253185;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x170067DE RID: 26590
		// (get) Token: 0x0600CE88 RID: 52872 RVA: 0x00C03110 File Offset: 0x00C01310
		// (set) Token: 0x0600CE89 RID: 52873 RVA: 0x00C031D4 File Offset: 0x00C013D4
		public override int Max
		{
			get
			{
				short num = (short)369788177;
				short num2 = num;
				num = (short)21005585;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A7;
				case 1:
					break;
				default:
				{
					num = (short)665190400;
					short num3 = num;
					break;
				}
				}
				num = (short)1579089921;
				if (num != 0)
				{
				}
				num = (short)409075712;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					return this._DynMax;
				}
				IL_A7:
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerRecset._Max;
			}
			set
			{
				short num = (short)257556481;
				if (num != 0)
				{
				}
				num = (short)1348468736;
				short num2 = num;
				num = (short)1433028876;
				short num3 = num;
				num = (short)1311918348;
				switch (num3 == num)
				{
				}
				num = (short)1624834048;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170067DF RID: 26591
		// (get) Token: 0x0600CE8A RID: 52874 RVA: 0x00C03284 File Offset: 0x00C01484
		public override int Min
		{
			get
			{
				short num = (short)1476305080;
				short num2 = num;
				num = (short)1922146488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1110441984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)243073024;
				if (num != 0)
				{
				}
				num = (short)630784001;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerRecset._Min;
			}
		}

		// Token: 0x170067E0 RID: 26592
		// (get) Token: 0x0600CE8B RID: 52875 RVA: 0x00C03334 File Offset: 0x00C01534
		// (set) Token: 0x0600CE8C RID: 52876 RVA: 0x00C033E4 File Offset: 0x00C015E4
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)667909842;
				short num2 = num;
				num = (short)1553366738;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1032781824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)712310785;
				if (num != 0)
				{
				}
				num = (short)1850015744;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)530810124;
				short num2 = num;
				num = (short)450725132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)541065216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)425721856;
				if (num != 0)
				{
				}
				num = (short)817430529;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170067E1 RID: 26593
		// (get) Token: 0x0600CE8D RID: 52877 RVA: 0x00C03490 File Offset: 0x00C01690
		public bool HasDiffs
		{
			get
			{
				short num = (short)599851009;
				if (num != 0)
				{
				}
				num = (short)1076428800;
				short num2 = num;
				num = (short)332319734;
				short num3 = num;
				num = (short)1096207350;
				switch (num3 == num)
				{
				}
				num = (short)1983512576;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600CE8E RID: 52878 RVA: 0x00C03540 File Offset: 0x00C01740
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1240600000;
			short num2 = num;
			num = (short)1665404352;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1367867392;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1857814529;
			if (num != 0)
			{
			}
			num = (short)241631232;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInner(this);
		}

		// Token: 0x0600CE8F RID: 52879 RVA: 0x00C035F0 File Offset: 0x00C017F0
		internal void SetValues()
		{
			short num = (short)482082817;
			if (num != 0)
			{
			}
			num = (short)2051997696;
			short num2 = num;
			num = (short)1260490506;
			short num3 = num;
			num = (short)560369418;
			switch (num3 == num)
			{
			}
			num = (short)1041104896;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_MESSAGEALIASTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_MESSAGE_1;
			base.DataTransferOrder = 32;
		}

		// Token: 0x0600CE90 RID: 52880 RVA: 0x00C036C8 File Offset: 0x00C018C8
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1409613825;
			if (num != 0)
			{
			}
			num = (short)527630336;
			short num2 = num;
			num = (short)889510271;
			short num3 = num;
			num = (short)664525183;
			switch (num3 == num)
			{
			}
			num = (short)1101201408;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.a();
		}

		// Token: 0x0600CE91 RID: 52881 RVA: 0x00C0377C File Offset: 0x00C0197C
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)786779369;
			short num2 = num;
			num = (short)1380338921;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2119172096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)372637696;
			if (num != 0)
			{
			}
			num = (short)1742405633;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.a();
		}

		// Token: 0x0600CE92 RID: 52882 RVA: 0x00C03830 File Offset: 0x00C01A30
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
				{
					num2 = (short)2085289984;
					short num3 = num2;
					if (conventionalPersonalityRecset != null)
					{
						num2 = (short)1897398274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 1:
					try
					{
						num2 = (short)11468801;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								num2 = (short)195083809;
								short num4 = num2;
								num2 = (short)722517537;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num2 = (short)836370432;
									if (num2 != 0)
									{
									}
									if (!enumerator.MoveNext())
									{
										num2 = (short)1393360898;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current)[10145].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset).GetEnumerator();
									num2 = (short)772014084;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_C1;
								}
								continue;
							case 2:
								goto IL_2BB;
							case 3:
								goto IL_2D3;
							case 4:
								try
								{
									num2 = (short)1837826049;
									num = (int)((global::System.IntPtr)num2);
									for (;;)
									{
										switch (num)
										{
										case 0:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num2 = (short)824901634;
												num = (int)((global::System.IntPtr)num2);
												continue;
											}
											(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner)enumerator2.Current)[10146] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerSection).CnvPerOneTouchIndex_A19663.CalculateValidity();
											num2 = (short)886308868;
											num = (int)((global::System.IntPtr)num2);
											continue;
										}
										case 1:
											switch (0)
											{
											case 0:
												goto IL_1C1;
											}
											continue;
										case 2:
											num2 = (short)31064067;
											num = (int)((global::System.IntPtr)num2);
											continue;
										case 3:
											goto IL_24D;
										}
										IL_1C3:
										num2 = (short)380043264;
										num = (int)((global::System.IntPtr)num2);
										continue;
										IL_1C1:
										goto IL_1C3;
									}
									IL_24D:
									break;
								}
								finally
								{
									num2 = (short)292945920;
									num = (int)((global::System.IntPtr)num2);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										switch (num)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_284;
											}
											continue;
										case 1:
											goto IL_2B8;
										case 2:
											enumerator2.Dispose();
											num2 = (short)1091174401;
											num = (int)((global::System.IntPtr)num2);
											continue;
										}
										IL_284:
										if (enumerator2 == null)
										{
											break;
										}
										num2 = (short)598736898;
										num = (int)((global::System.IntPtr)num2);
									}
									IL_2B8:;
								}
								goto IL_2BB;
							}
							IL_C3:
							num2 = (short)713359360;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_C1:
							goto IL_C3;
							IL_2BB:
							num2 = (short)1282146307;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_2D3:
						return;
					}
					finally
					{
						num2 = (short)184549376;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_309;
								}
								continue;
							case 1:
								goto IL_33D;
							case 2:
								enumerator.Dispose();
								num2 = (short)302514177;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_309:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1702690818;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_33D:;
					}
					goto IL_340;
				case 2:
					goto IL_340;
				}
				goto IL_1C;
				IL_340:
				num2 = (short)110821377;
				if (num2 != 0)
				{
				}
				enumerator = conventionalPersonalityRecset.GetEnumerator();
				num2 = (short)224788481;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
			num2 = (short)779681792;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600CE93 RID: 52883 RVA: 0x00C03C00 File Offset: 0x00C01E00
		// Note: this type is marked as 'beforefieldinit'.
		static MessageAliasTableInnerRecset()
		{
			short num = (short)641990657;
			if (num != 0)
			{
			}
			num = (short)841744384;
			short num2 = num;
			num = (short)286745779;
			short num3 = num;
			num = (short)1077634227;
			switch (num3 == num)
			{
			}
			num = (short)383975424;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerRecset._Min = 1;
		}

		// Token: 0x0400653B RID: 25915
		public static int _MaxPool;

		// Token: 0x0400653C RID: 25916
		public static int _Max;

		// Token: 0x0400653D RID: 25917
		public int _DynMax;

		// Token: 0x0400653E RID: 25918
		public static int _Min;

		// Token: 0x0400653F RID: 25919
		public static int _DefaultRecordCount;
	}
}
