using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000A7 RID: 167
	[global::System.Serializable]
	public class StatusAliasInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060014C3 RID: 5315 RVA: 0x00135DB8 File Offset: 0x00133FB8
		public StatusAliasInnerRecset() : base(global::CommonResources.AcgResources.ID_STATUSALIAS)
		{
			this.SetValues();
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00135DD8 File Offset: 0x00133FD8
		public StatusAliasInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x00135E04 File Offset: 0x00134004
		public override int MaxPool
		{
			get
			{
				short num = (short)1539620996;
				short num2 = num;
				num = (short)2104934532;
				switch (num2 == num)
				{
				}
				num = (short)709885952;
				short num3 = num;
				num = (short)232521729;
				if (num != 0)
				{
				}
				num = (short)1707409408;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerRecset._MaxPool;
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x00135EB0 File Offset: 0x001340B0
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x00135F70 File Offset: 0x00134170
		public override int Max
		{
			get
			{
				short num = (short)1637575889;
				short num2 = num;
				num = (short)2047372497;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)689373184;
					if (num != 0)
					{
					}
					num = (short)1418723329;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						num = (short)1214119936;
						short num3 = num;
						return this._DynMax;
					}
					break;
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerRecset._Max;
			}
			set
			{
				short num = (short)785744444;
				short num2 = num;
				num = (short)592478780;
				switch (num2 == num)
				{
				}
				num = (short)1727725568;
				short num3 = num;
				num = (short)1285750785;
				if (num != 0)
				{
				}
				num = (short)529661952;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x00136020 File Offset: 0x00134220
		public override int Min
		{
			get
			{
				short num = (short)120704149;
				short num2 = num;
				num = (short)1880542357;
				switch (num2 == num)
				{
				}
				num = (short)229310464;
				short num3 = num;
				num = (short)1415774209;
				if (num != 0)
				{
				}
				num = (short)1574895616;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerRecset._Min;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x001360D0 File Offset: 0x001342D0
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x00136180 File Offset: 0x00134380
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2018290756;
				short num2 = num;
				num = (short)751479876;
				switch (num2 == num)
				{
				}
				num = (short)1680277504;
				short num3 = num;
				num = (short)1345454081;
				if (num != 0)
				{
				}
				num = (short)233111552;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1181279596;
				short num2 = num;
				num = (short)43509100;
				switch (num2 == num)
				{
				}
				num = (short)723386368;
				short num3 = num;
				num = (short)690487297;
				if (num != 0)
				{
				}
				num = (short)672464896;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x00136230 File Offset: 0x00134430
		public bool HasDiffs
		{
			get
			{
				short num = (short)233762050;
				short num2 = num;
				num = (short)2040196354;
				switch (num2 == num)
				{
				}
				num = (short)996474880;
				short num3 = num;
				num = (short)1017970689;
				if (num != 0)
				{
				}
				num = (short)1951465472;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x001362E0 File Offset: 0x001344E0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1603077476;
			short num2 = num;
			num = (short)556139876;
			switch (num2 == num)
			{
			}
			num = (short)1720975360;
			short num3 = num;
			num = (short)150667264;
			if (num != 0)
			{
			}
			num = (short)1284833281;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInner(this);
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00136390 File Offset: 0x00134590
		internal void SetValues()
		{
			short num = (short)265405164;
			short num2 = num;
			num = (short)452051692;
			switch (num2 == num)
			{
			}
			num = (short)1236140032;
			short num3 = num;
			num = (short)1330905088;
			if (num != 0)
			{
			}
			num = (short)1661403137;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_STATUSALIAS;
			base.DataTransferOrder = 43;
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0013645C File Offset: 0x0013465C
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1133032329;
			short num2 = num;
			num = (short)1307489161;
			switch (num2 == num)
			{
			}
			num = (short)835780608;
			short num3 = num;
			num = (short)1022164993;
			if (num != 0)
			{
			}
			num = (short)1207566336;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.a();
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00136514 File Offset: 0x00134714
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)720767789;
			short num2 = num;
			num = (short)727452461;
			switch (num2 == num)
			{
			}
			num = (short)1604780032;
			short num3 = num;
			num = (short)1715666944;
			if (num != 0)
			{
			}
			num = (short)1574436865;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.a();
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x001365C8 File Offset: 0x001347C8
		private void a()
		{
			short num = (short)1460338689;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_1D7;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
					try
					{
						num = (short)1368272140;
						short num3 = num;
						num = (short)341912844;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_114:
							(((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInner)enumerator.Current)[10166] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection).TrkSysOneTouchIndex_A8618.CalculateValidity();
							num = (short)138805250;
							num2 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)1463615488;
							if (num != 0)
							{
							}
							num = (short)90898433;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)364838916;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_DE;
								}
								continue;
							case 3:
								if (!enumerator.MoveNext())
								{
									num = (short)2079653888;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_114;
							case 4:
								goto IL_16A;
							}
							IL_E0:
							num = (short)1789526019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_DE:
							goto IL_E0;
						}
						IL_16A:
						return;
					}
					finally
					{
						num = (short)1654915073;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)329973762;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_19F;
								}
								continue;
							case 2:
								goto IL_1D4;
							}
							IL_19F:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2050031616;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1D4:;
					}
					goto IL_1D7;
				}
				IL_32:
				if (base.ParentSection != null)
				{
					num = (short)1545928704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1D7:
				num = (short)18284544;
				short num4 = num;
				num = (short)539230209;
				if (num != 0)
				{
				}
				enumerator = (base.ParentSection.Parent[10165].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset).GetEnumerator();
				num = (short)1151401986;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0013685C File Offset: 0x00134A5C
		// Note: this type is marked as 'beforefieldinit'.
		static StatusAliasInnerRecset()
		{
			short num = (short)1732498249;
			short num2 = num;
			num = (short)1180947273;
			switch (num2 == num)
			{
			}
			num = (short)641204224;
			short num3 = num;
			num = (short)264568833;
			if (num != 0)
			{
			}
			num = (short)2010710016;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerRecset._Min = 1;
		}

		// Token: 0x04000476 RID: 1142
		public static int _MaxPool;

		// Token: 0x04000477 RID: 1143
		public static int _Max;

		// Token: 0x04000478 RID: 1144
		public int _DynMax;

		// Token: 0x04000479 RID: 1145
		public static int _Min;

		// Token: 0x0400047A RID: 1146
		public static int _DefaultRecordCount;
	}
}
