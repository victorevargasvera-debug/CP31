using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence
{
	// Token: 0x0200026E RID: 622
	[global::System.Serializable]
	public class MissionCriticalGeofenceRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06006EEB RID: 28395 RVA: 0x0062DBC4 File Offset: 0x0062BDC4
		public MissionCriticalGeofenceRecset() : base(global::CommonResources.AcgResources.ID_MISSIONCRITICALGEOFENCE, global::CommonResources.AcgResources.ID_GFPROFILE)
		{
			this.SetValues();
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x0062DBE8 File Offset: 0x0062BDE8
		public MissionCriticalGeofenceRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x06006EED RID: 28397 RVA: 0x0062DC14 File Offset: 0x0062BE14
		public override int MaxPool
		{
			get
			{
				short num = (short)463685066;
				short num2 = num;
				num = (short)704398794;
				switch (num2 == num)
				{
				}
				num = (short)1115029504;
				short num3 = num;
				num = (short)661454849;
				if (num != 0)
				{
				}
				num = (short)1889533952;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset._MaxPool;
			}
		}

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x06006EEE RID: 28398 RVA: 0x0062DCC4 File Offset: 0x0062BEC4
		// (set) Token: 0x06006EEF RID: 28399 RVA: 0x0062DD8C File Offset: 0x0062BF8C
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)702823728;
					short num2 = num;
					num = (short)106052912;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1126629377;
						if (num != 0)
						{
						}
						num = (short)1825767424;
						short num3 = num;
						num = (short)2105737216;
						if (num != 0)
						{
						}
						break;
					}
					}
					return global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1224635026;
				short num2 = num;
				num = (short)1866822290;
				switch (num2 == num)
				{
				}
				num = (short)173211648;
				short num3 = num;
				num = (short)1740308480;
				if (num != 0)
				{
				}
				num = (short)627245057;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x06006EF0 RID: 28400 RVA: 0x0062DE3C File Offset: 0x0062C03C
		public bool HasDiffs
		{
			get
			{
				short num = (short)564417944;
				short num2 = num;
				num = (short)1973507480;
				switch (num2 == num)
				{
				}
				num = (short)1191510016;
				short num3 = num;
				num = (short)1456275457;
				if (num != 0)
				{
				}
				num = (short)865992704;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x06006EF1 RID: 28401 RVA: 0x0062DEEC File Offset: 0x0062C0EC
		// (set) Token: 0x06006EF2 RID: 28402 RVA: 0x0062DF9C File Offset: 0x0062C19C
		public override int Min
		{
			get
			{
				short num = (short)1337231181;
				short num2 = num;
				num = (short)1018136397;
				switch (num2 == num)
				{
				}
				num = (short)329383936;
				short num3 = num;
				num = (short)139460608;
				if (num != 0)
				{
				}
				num = (short)68026369;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset._Min;
			}
			set
			{
				short num = (short)195126441;
				short num2 = num;
				num = (short)1698915497;
				switch (num2 == num)
				{
				}
				num = (short)1681522688;
				short num3 = num;
				num = (short)145817601;
				if (num != 0)
				{
				}
				num = (short)898891776;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset._Min = value;
			}
		}

		// Token: 0x06006EF3 RID: 28403 RVA: 0x0062E04C File Offset: 0x0062C24C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)164423466;
			short num2 = num;
			num = (short)1286858538;
			switch (num2 == num)
			{
			}
			num = (short)1200357376;
			short num3 = num;
			num = (short)946012160;
			if (num != 0)
			{
			}
			num = (short)1986789377;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence(this);
		}

		// Token: 0x06006EF4 RID: 28404 RVA: 0x0062E0FC File Offset: 0x0062C2FC
		internal void SetValues()
		{
			int a_ = 19;
			short num = (short)1594621953;
			if (num != 0)
			{
			}
			num = (short)2110317512;
			short num2 = num;
			num = (short)1494868936;
			switch (num2 == num)
			{
			default:
			{
				num = (short)639696896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1613496320;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 4174;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("闓뫕듗鳙맛뿝铟韡難菥鯧퇩꿫臭鷯英鯳飵鷷铹裻ꋽ勿持怃漅朇⨉䤋簍眏紑稓礕甗猙缛洝\u001f愡䬣䠥丧䌩䬫嬭䈯匱䀳張圷吹总猽⤿ㅁ㝃⽅❇⑉汋്≏㭑⁓㽕㭗㭙せ繝❟ݡୣe൧ѩཫ୭Ɐ㽱ᵳյ୷፹፻ၽ썿힏ﮓﶗﾛﮝ삡좣袥킧쮩솫슭", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MISSIONCRITICALGEOFENCE;
			base.KeySeed = global::CommonResources.AcgResources.ID_GFPROFILE;
			base.DataTransferOrder = 325;
		}

		// Token: 0x06006EF5 RID: 28405 RVA: 0x0062E200 File Offset: 0x0062C400
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1811742721;
			if (num != 0)
			{
			}
			num = (short)408218974;
			short num2 = num;
			num = (short)190049630;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1260322816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1116536832;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord(record);
			this.c(record);
			this.d(record);
		}

		// Token: 0x06006EF6 RID: 28406 RVA: 0x0062E2BC File Offset: 0x0062C4BC
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)784826161;
			short num2 = num;
			num = (short)218660657;
			switch (num2 == num)
			{
			}
			num = (short)1608974336;
			short num3 = num;
			num = (short)938016769;
			if (num != 0)
			{
			}
			num = (short)1534066688;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord(record);
			this.b(record);
			this.d(record);
		}

		// Token: 0x06006EF7 RID: 28407 RVA: 0x0062E37C File Offset: 0x0062C57C
		private void d(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)530659703;
			short num2 = num;
			num = (short)1101150583;
			switch (num2 == num)
			{
			}
			num = (short)1174929408;
			short num3 = num;
			num = (short)577241089;
			if (num != 0)
			{
			}
			num = (short)1407582208;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006EF8 RID: 28408 RVA: 0x0062E428 File Offset: 0x0062C628
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)903799495;
			short num2 = num;
			num = (short)1726210759;
			switch (num2 == num)
			{
			}
			num = (short)341966848;
			short num3 = num;
			num = (short)873463809;
			if (num != 0)
			{
			}
			num = (short)1137377280;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x06006EF9 RID: 28409 RVA: 0x0062E4D8 File Offset: 0x0062C6D8
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)682164225;
			if (num != 0)
			{
			}
			num = (short)798421077;
			short num2 = num;
			num = (short)43380821;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1008533504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)6553600;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x0062E588 File Offset: 0x0062C788
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				for (;;)
				{
					IL_0A:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num)
					{
					case 0:
					{
						if (this == null)
						{
							goto IL_251;
						}
						num2 = (short)205368404;
						short num3 = num2;
						num2 = (short)1975364692;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)666238976;
							if (num2 != 0)
							{
							}
							num2 = (short)2071199746;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						try
						{
							num2 = (short)493355011;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_1C1;
								case 1:
									num2 = (short)1496973312;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
									if (missionCriticalGeofence != null)
									{
										num2 = (short)858062854;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_109;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num2 = (short)2127888385;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence = (global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence)enumerator.Current;
									num2 = (short)1693515778;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
									missionCriticalGeofence.General.McGeofencePriority_42879.CalculateValidity();
									num2 = (short)160432133;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								}
								IL_10B:
								num2 = (short)992673796;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_109:
								goto IL_10B;
							}
							IL_1C1:
							goto IL_251;
						}
						finally
						{
							num2 = (short)1022033920;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1F7;
									}
									continue;
								case 1:
									goto IL_22B;
								case 2:
									enumerator.Dispose();
									num2 = (short)1745747969;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								IL_1F7:
								if (enumerator == null)
								{
									break;
								}
								num2 = (short)335413250;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_22B:;
						}
						goto IL_22E;
					case 2:
						num2 = (short)777322497;
						if (num2 != 0)
						{
						}
						goto IL_22E;
					}
					break;
					IL_22E:
					enumerator = this.GetEnumerator();
					num2 = (short)854982657;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1C:
				num2 = (short)1189412864;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_251:
			num2 = (short)1275265024;
			short num4 = num2;
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x0062E820 File Offset: 0x0062CA20
		// Note: this type is marked as 'beforefieldinit'.
		static MissionCriticalGeofenceRecset()
		{
			short num = (short)1381817451;
			short num2 = num;
			num = (short)167107691;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1292500992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1898250240;
			if (num != 0)
			{
			}
			num = (short)1462173697;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset._Min = 1;
		}

		// Token: 0x04002B2E RID: 11054
		public static int _MaxPool;

		// Token: 0x04002B2F RID: 11055
		public static int _Max;

		// Token: 0x04002B30 RID: 11056
		public int _DynMax;

		// Token: 0x04002B31 RID: 11057
		public static int _Min;
	}
}
