using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003FB RID: 1019
	[global::System.Serializable]
	public class E5NavigationControlsTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008D82 RID: 36226 RVA: 0x0084A710 File Offset: 0x00848910
		public E5NavigationControlsTableInnerRecset() : base(global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS, global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS)
		{
			this.SetValues();
		}

		// Token: 0x06008D83 RID: 36227 RVA: 0x0084A734 File Offset: 0x00848934
		public E5NavigationControlsTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004787 RID: 18311
		// (get) Token: 0x06008D84 RID: 36228 RVA: 0x0084A760 File Offset: 0x00848960
		public override int MaxPool
		{
			get
			{
				short num = (short)462021607;
				short num2 = num;
				num = (short)1064100839;
				switch (num2 == num)
				{
				}
				num = (short)785973248;
				short num3 = num;
				num = (short)497942529;
				if (num != 0)
				{
				}
				num = (short)826671104;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004788 RID: 18312
		// (get) Token: 0x06008D85 RID: 36229 RVA: 0x0084A810 File Offset: 0x00848A10
		// (set) Token: 0x06008D86 RID: 36230 RVA: 0x0084A8D4 File Offset: 0x00848AD4
		public override int Max
		{
			get
			{
				while (this._DynMax == -1)
				{
					short num = (short)293770929;
					short num2 = num;
					num = (short)9148081;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)4063232;
						short num3 = num;
						num = (short)183435265;
						if (num != 0)
						{
						}
						num = (short)1770717184;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1746326976;
				short num2 = num;
				num = (short)1427166656;
				switch (num2 == num)
				{
				}
				num = (short)1625423872;
				short num3 = num;
				num = (short)1575747584;
				if (num != 0)
				{
				}
				num = (short)889257985;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004789 RID: 18313
		// (get) Token: 0x06008D87 RID: 36231 RVA: 0x0084A984 File Offset: 0x00848B84
		public override int Min
		{
			get
			{
				short num = (short)1742405633;
				if (num != 0)
				{
				}
				num = (short)1298080930;
				short num2 = num;
				num = (short)2030183586;
				switch (num2 == num)
				{
				default:
				{
					num = (short)81920000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)359530496;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset._Min;
			}
		}

		// Token: 0x1700478A RID: 18314
		// (get) Token: 0x06008D88 RID: 36232 RVA: 0x0084AA34 File Offset: 0x00848C34
		// (set) Token: 0x06008D89 RID: 36233 RVA: 0x0084AAE0 File Offset: 0x00848CE0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2081197815;
				short num2 = num;
				num = (short)1025412855;
				switch (num2 == num)
				{
				}
				num = (short)1316618240;
				short num3 = num;
				num = (short)1596850177;
				if (num != 0)
				{
				}
				num = (short)423428096;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)231366350;
				short num2 = num;
				num = (short)1983209166;
				switch (num2 == num)
				{
				}
				num = (short)2099707904;
				short num3 = num;
				num = (short)300613633;
				if (num != 0)
				{
				}
				num = (short)2088697856;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700478B RID: 18315
		// (get) Token: 0x06008D8A RID: 36234 RVA: 0x0084AB90 File Offset: 0x00848D90
		public bool HasDiffs
		{
			get
			{
				short num = (short)902603836;
				short num2 = num;
				num = (short)1199744060;
				switch (num2 == num)
				{
				}
				num = (short)1506213888;
				if (num != 0)
				{
				}
				num = (short)616431617;
				if (num != 0)
				{
				}
				num = (short)1530003456;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06008D8B RID: 36235 RVA: 0x0084AC40 File Offset: 0x00848E40
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)550494860;
			short num2 = num;
			num = (short)1460527756;
			switch (num2 == num)
			{
			}
			num = (short)1813315584;
			if (num != 0)
			{
			}
			num = (short)53608449;
			if (num != 0)
			{
			}
			num = (short)59768832;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInner(this);
		}

		// Token: 0x06008D8C RID: 36236 RVA: 0x0084ACEC File Offset: 0x00848EEC
		internal void SetValues()
		{
			short num = (short)2011259135;
			short num2 = num;
			num = (short)1374839039;
			switch (num2 == num)
			{
			}
			num = (short)1196490753;
			if (num != 0)
			{
			}
			num = (short)1276444672;
			if (num != 0)
			{
			}
			num = (short)1147731968;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.KeySeed = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 77;
		}

		// Token: 0x06008D8D RID: 36237 RVA: 0x0084ADC4 File Offset: 0x00848FC4
		// Note: this type is marked as 'beforefieldinit'.
		static E5NavigationControlsTableInnerRecset()
		{
			short num = (short)357406505;
			short num2 = num;
			num = (short)1006671657;
			switch (num2 == num)
			{
			}
			num = (short)1787953153;
			if (num != 0)
			{
			}
			num = (short)1839595520;
			if (num != 0)
			{
			}
			num = (short)2055012352;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset._Min = 1;
		}

		// Token: 0x04004588 RID: 17800
		public static int _MaxPool;

		// Token: 0x04004589 RID: 17801
		public static int _Max;

		// Token: 0x0400458A RID: 17802
		public int _DynMax;

		// Token: 0x0400458B RID: 17803
		public static int _Min;

		// Token: 0x0400458C RID: 17804
		public static int _DefaultRecordCount;
	}
}
