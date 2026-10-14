using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000099 RID: 153
	[global::System.Serializable]
	public class MessageAliasInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001184 RID: 4484 RVA: 0x0010D8E0 File Offset: 0x0010BAE0
		public MessageAliasInnerRecset() : base(global::CommonResources.AcgResources.ID_MESSAGEALIAS, global::CommonResources.AcgResources.ID_MESSAGE_1)
		{
			this.SetValues();
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0010D904 File Offset: 0x0010BB04
		public MessageAliasInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x0010D930 File Offset: 0x0010BB30
		public override int MaxPool
		{
			get
			{
				short num = (short)1013839202;
				short num2 = num;
				num = (short)1990063458;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1634336768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)320471040;
				if (num != 0)
				{
				}
				num = (short)1522925569;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerRecset._MaxPool;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x0010D9E0 File Offset: 0x0010BBE0
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x0010DAA0 File Offset: 0x0010BCA0
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax == -1)
				{
					num = (short)941639413;
					short num2 = num;
					num = (short)1405503221;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1146945536;
						short num3 = num;
						num = (short)1657012224;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerRecset._Max;
					}
					}
				}
				num = (short)1019281409;
				if (num != 0)
				{
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)617972092;
				short num2 = num;
				num = (short)1018790268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1228210176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)33423360;
				if (num != 0)
				{
				}
				num = (short)302514177;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x0010DB50 File Offset: 0x0010BD50
		public override int Min
		{
			get
			{
				short num = (short)1126820903;
				short num2 = num;
				num = (short)1878649895;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1768095744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)128319489;
				if (num != 0)
				{
				}
				num = (short)125501440;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerRecset._Min;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x0010DBFC File Offset: 0x0010BDFC
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x0010DCAC File Offset: 0x0010BEAC
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)49448112;
				short num2 = num;
				num = (short)405701808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)439287808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1858600961;
				if (num != 0)
				{
				}
				num = (short)1318453248;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1430072744;
				short num2 = num;
				num = (short)1757949352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1385365504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2133917697;
				if (num != 0)
				{
				}
				num = (short)1470365696;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x0010DD5C File Offset: 0x0010BF5C
		public bool HasDiffs
		{
			get
			{
				short num = (short)311854340;
				short num2 = num;
				num = (short)228099332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)679936000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)853934081;
				if (num != 0)
				{
				}
				num = (short)914292736;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0010DE10 File Offset: 0x0010C010
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1563592982;
			short num2 = num;
			num = (short)864717078;
			switch (num2 == num)
			{
			default:
			{
				num = (short)829227008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)380305409;
			if (num != 0)
			{
			}
			num = (short)1532755968;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInner(this);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0010DEC0 File Offset: 0x0010C0C0
		internal void SetValues()
		{
			short num = (short)499845392;
			short num2 = num;
			num = (short)519047440;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1427243008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)214761473;
			if (num != 0)
			{
			}
			num = (short)945487872;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_MESSAGEALIAS;
			base.KeySeed = global::CommonResources.AcgResources.ID_MESSAGE_1;
			base.DataTransferOrder = 43;
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0010DF98 File Offset: 0x0010C198
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1816387113;
			short num2 = num;
			num = (short)1497030185;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1875050496;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1297088513;
			if (num != 0)
			{
			}
			num = (short)1045037056;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.a();
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0010E04C File Offset: 0x0010C24C
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1042777261;
			short num2 = num;
			num = (short)1389462701;
			switch (num2 == num)
			{
			default:
			{
				num = (short)171376640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1384710144;
			if (num != 0)
			{
			}
			num = (short)717881345;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.a();
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0010E100 File Offset: 0x0010C300
		private void a()
		{
			short num = (short)3211265;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_222;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					try
					{
						num = (short)514195459;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							num = (short)260608679;
							short num3 = num;
							num = (short)1743426215;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)304087040;
								if (num != 0)
								{
								}
								switch (num2)
								{
								case 0:
									goto IL_141;
								case 1:
									num = (short)284426242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1B6;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_12B;
									}
									continue;
								}
								IL_12D:
								num = (short)1299709952;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12B:
								goto IL_12D;
							}
							IL_141:
							if (!enumerator.MoveNext())
							{
								num = (short)1877278721;
								num2 = (int)((global::System.IntPtr)num);
							}
							else
							{
								(((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInner)enumerator.Current)[10166] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection).TrkSysOneTouchIndex_A8618.CalculateValidity();
								num = (short)1382744068;
								num2 = (int)((global::System.IntPtr)num);
							}
						}
						IL_1B6:
						return;
					}
					finally
					{
						num = (short)1769406465;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1692925954;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1EC;
								}
								continue;
							case 2:
								goto IL_21F;
							}
							IL_1EC:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1140195328;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_21F:;
					}
					goto IL_222;
				}
				IL_30:
				if (base.ParentSection != null)
				{
					num = (short)627572736;
					short num4 = num;
					num = (short)158597121;
					if (num != 0)
					{
					}
					num = (short)1753939968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_222:
				enumerator = (base.ParentSection.Parent[10165].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset).GetEnumerator();
				num = (short)1216217090;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0010E38C File Offset: 0x0010C58C
		// Note: this type is marked as 'beforefieldinit'.
		static MessageAliasInnerRecset()
		{
			short num = (short)1616843894;
			short num2 = num;
			num = (short)1837634678;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1322713088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1310523392;
			if (num != 0)
			{
			}
			num = (short)1071382529;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerRecset._Min = 1;
		}

		// Token: 0x04000441 RID: 1089
		public static int _MaxPool;

		// Token: 0x04000442 RID: 1090
		public static int _Max;

		// Token: 0x04000443 RID: 1091
		public int _DynMax;

		// Token: 0x04000444 RID: 1092
		public static int _Min;

		// Token: 0x04000445 RID: 1093
		public static int _DefaultRecordCount;
	}
}
