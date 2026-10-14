using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000AA RID: 170
	[global::System.Serializable]
	public class TrunkingSystemRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600152C RID: 5420 RVA: 0x00143278 File Offset: 0x00141478
		public TrunkingSystemRecset() : base(global::CommonResources.AcgResources.ID_TRUNKINGSYSTEM, global::CommonResources.AcgResources.ID_TRKSYS)
		{
			this.SetValues();
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0014329C File Offset: 0x0014149C
		public TrunkingSystemRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x001432C8 File Offset: 0x001414C8
		public override int MaxPool
		{
			get
			{
				short num = (short)990117888;
				short num2 = num;
				num = (short)725483521;
				if (num != 0)
				{
				}
				num = (short)1910537416;
				short num3 = num;
				num = (short)1745976520;
				switch (num3 == num)
				{
				}
				num = (short)1525022720;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset._MaxPool;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x00143374 File Offset: 0x00141574
		// (set) Token: 0x06001530 RID: 5424 RVA: 0x00143434 File Offset: 0x00141634
		public override int Max
		{
			get
			{
				short num = (short)1357898469;
				short num2 = num;
				num = (short)511435493;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1024458753;
					if (num != 0)
					{
					}
					num = (short)714080256;
					if (num != 0)
					{
					}
					if (this._DynMax == -1)
					{
						return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset._Max;
					}
					break;
				}
				num = (short)304218112;
				short num3 = num;
				return this._DynMax;
			}
			set
			{
				short num = (short)1846804480;
				short num2 = num;
				num = (short)519908251;
				short num3 = num;
				num = (short)160770971;
				switch (num3 == num)
				{
				}
				num = (short)1047658497;
				if (num != 0)
				{
				}
				num = (short)1459945472;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x001434E4 File Offset: 0x001416E4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1367146496;
				short num2 = num;
				num = (short)453091423;
				short num3 = num;
				num = (short)1003331679;
				switch (num3 == num)
				{
				}
				num = (short)1670053889;
				if (num != 0)
				{
				}
				num = (short)1666121728;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x00143590 File Offset: 0x00141790
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x00143640 File Offset: 0x00141840
		public override int Min
		{
			get
			{
				short num = (short)618332160;
				short num2 = num;
				num = (short)216334337;
				if (num != 0)
				{
				}
				num = (short)17583355;
				short num3 = num;
				num = (short)707415291;
				switch (num3 == num)
				{
				}
				num = (short)1968898048;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset._Min;
			}
			set
			{
				short num = (short)1948844032;
				short num2 = num;
				num = (short)1728684808;
				short num3 = num;
				num = (short)1227399944;
				switch (num3 == num)
				{
				}
				num = (short)1362493441;
				if (num != 0)
				{
				}
				num = (short)1529348096;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset._Min = value;
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x001436EC File Offset: 0x001418EC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1867382784;
			short num2 = num;
			num = (short)1959050684;
			short num3 = num;
			num = (short)1283505596;
			switch (num3 == num)
			{
			}
			num = (short)1456734209;
			if (num != 0)
			{
			}
			num = (short)1605435392;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem(this);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0014379C File Offset: 0x0014199C
		internal void SetValues()
		{
			int a_ = 16;
			short num = (short)1425561649;
			short num2 = num;
			num = (short)1368479793;
			switch (num2 == num)
			{
			default:
			{
				num = (short)959840256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)402980864;
			if (num != 0)
			{
			}
			num = (short)1000275969;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2064;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6ꫨ蓪胬鿮黰鷲郴駶跸ꟺꧼ跾琀洂渄渆月氊ⴌ䰎縐紒猔縖縘渚漜縞唠䨢䨤䤦用缪弬娮弰堲尴夶常ᬺ渼䘾㉀㝂⁄⩆ᕈὊ㽌㩎㽐㡒㱔㥖㹘࡚⑜ⱞᕠ٢ࡤ㍦୨ݪ䍬ᝮၰṲᥴ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSYSTEM;
			base.KeySeed = global::CommonResources.AcgResources.ID_TRKSYS;
			base.DataTransferOrder = 43;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0014389C File Offset: 0x00141A9C
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1574102367;
			short num2 = num;
			num = (short)2084496735;
			switch (num2 == num)
			{
			default:
			{
				num = (short)723189760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)539230209;
			if (num != 0)
			{
			}
			num = (short)1087111168;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord(record);
			this.c(record);
			this.d(record);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0014395C File Offset: 0x00141B5C
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)495988989;
			short num2 = num;
			num = (short)597504253;
			switch (num2 == num)
			{
			default:
			{
				num = (short)702480384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1713111040;
			if (num != 0)
			{
			}
			num = (short)758513665;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord(record);
			this.b(record);
			this.d(record);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00143A18 File Offset: 0x00141C18
		protected override void OnFinishedMoveRecord(global::AcpCommonLib.IAcpFeatureNode record, global::AcpCommonLib.IAcpFeatureNode targetRecord)
		{
			short num = (short)2036974964;
			short num2 = num;
			num = (short)763020660;
			switch (num2 == num)
			{
			default:
			{
				num = (short)85917696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)908853249;
			if (num != 0)
			{
			}
			num = (short)989855744;
			if (num != 0)
			{
			}
			base.OnFinishedMoveRecord();
			this.a(record, targetRecord);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00143AD0 File Offset: 0x00141CD0
		private void d(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)260702209;
			if (num != 0)
			{
			}
			num = (short)558432256;
			short num2 = num;
			num = (short)1753019407;
			short num3 = num;
			num = (short)737670159;
			switch (num3 == num)
			{
			}
			num = (short)820314112;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00143B78 File Offset: 0x00141D78
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)649099032;
			short num2 = num;
			num = (short)1977513752;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1509294080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)642908161;
			if (num != 0)
			{
			}
			num = (short)1589379072;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00143C28 File Offset: 0x00141E28
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)2125605554;
			short num2 = num;
			num = (short)1920150194;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2136801280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1246560256;
			if (num != 0)
			{
			}
			num = (short)500105217;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00143CDC File Offset: 0x00141EDC
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0, global::AcpCommonLib.IAcpFeatureNode A_1)
		{
			short num = (short)1256078154;
			short num2 = num;
			num = (short)591870794;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1331363840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)651821057;
			if (num != 0)
			{
			}
			num = (short)1572536320;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00143D94 File Offset: 0x00141F94
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)149422081;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)993132544;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				}
				case 2:
					goto IL_1B4;
				case 3:
					try
					{
						num = (short)304021505;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)473563139;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								(((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current)[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralSystemType_A9252.CalculateValidity();
								num = (short)1601306628;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_BD;
								}
								continue;
							case 2:
								goto IL_146;
							case 3:
								num = (short)1606746114;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_BF:
							num = (short)459800576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BD:
							goto IL_BF;
						}
						IL_146:
						return;
					}
					finally
					{
						num = (short)1339883520;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_17D;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)678887426;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1B1;
							}
							IL_17D:
							if (enumerator == null)
							{
								break;
							}
							num = (short)908263425;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1B1:;
					}
					goto IL_1B4;
				case 4:
					IL_26F:
					if (trunkingSystemRecset != null)
					{
						num = (short)57802754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_61:
				if (global::AcpCommonLib.ConstraintManager.Suspended)
				{
					num = (short)174391296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				trunkingSystemRecset = (A_0.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
				num = (short)1265041412;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B4:
				num = (short)78009874;
				short num4 = num;
				num = (short)479155730;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_26F;
				default:
				{
					num = (short)1159528448;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingSystemRecset.GetEnumerator();
					num = (short)1310654465;
					if (num != 0)
					{
					}
					num = (short)1816592387;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00144040 File Offset: 0x00142240
		// Note: this type is marked as 'beforefieldinit'.
		static TrunkingSystemRecset()
		{
			short num = (short)807418013;
			short num2 = num;
			num = (short)1778006173;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2091843584;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1925775361;
			if (num != 0)
			{
			}
			num = (short)750059520;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset._Min = 1;
		}

		// Token: 0x0400084F RID: 2127
		public static int _MaxPool;

		// Token: 0x04000850 RID: 2128
		public static int _Max;

		// Token: 0x04000851 RID: 2129
		public int _DynMax;

		// Token: 0x04000852 RID: 2130
		public static int _Min;
	}
}
