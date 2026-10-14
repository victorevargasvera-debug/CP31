using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000384 RID: 900
	[global::System.Serializable]
	public class ResponseSelectorListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600846D RID: 33901 RVA: 0x007AF784 File Offset: 0x007AD984
		public ResponseSelectorListInnerRecset() : base(global::CommonResources.AcgResources.ID_RESPONSESELECTOR)
		{
			this.SetValues();
		}

		// Token: 0x0600846E RID: 33902 RVA: 0x007AF7A4 File Offset: 0x007AD9A4
		public ResponseSelectorListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700435F RID: 17247
		// (get) Token: 0x0600846F RID: 33903 RVA: 0x007AF7D0 File Offset: 0x007AD9D0
		public override int MaxPool
		{
			get
			{
				short num = (short)813391568;
				short num2 = num;
				num = (short)631463632;
				switch (num2 == num)
				{
				}
				num = (short)1676148736;
				if (num != 0)
				{
				}
				num = (short)103153665;
				if (num != 0)
				{
				}
				num = (short)806092800;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004360 RID: 17248
		// (get) Token: 0x06008470 RID: 33904 RVA: 0x007AF880 File Offset: 0x007ADA80
		// (set) Token: 0x06008471 RID: 33905 RVA: 0x007AF940 File Offset: 0x007ADB40
		public override int Max
		{
			get
			{
				short num = (short)847049948;
				short num2 = num;
				num = (short)484766940;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AA;
				case 1:
					break;
				default:
				{
					num = (short)1639383040;
					short num3 = num;
					break;
				}
				}
				num = (short)1661992960;
				if (num != 0)
				{
				}
				num = (short)1857552385;
				if (num != 0)
				{
				}
				if (this._DynMax == -1)
				{
					return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset._Max;
				}
				IL_AA:
				return this._DynMax;
			}
			set
			{
				short num = (short)1791928610;
				short num2 = num;
				num = (short)991340834;
				switch (num2 == num)
				{
				}
				num = (short)2075918337;
				if (num != 0)
				{
				}
				num = (short)819134464;
				if (num != 0)
				{
				}
				num = (short)748224512;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17004361 RID: 17249
		// (get) Token: 0x06008472 RID: 33906 RVA: 0x007AF9F0 File Offset: 0x007ADBF0
		public override int Min
		{
			get
			{
				short num = (short)892017926;
				short num2 = num;
				num = (short)1960189190;
				switch (num2 == num)
				{
				}
				num = (short)1982136321;
				if (num != 0)
				{
				}
				num = (short)1846673408;
				if (num != 0)
				{
				}
				num = (short)883163136;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset._Min;
			}
		}

		// Token: 0x17004362 RID: 17250
		// (get) Token: 0x06008473 RID: 33907 RVA: 0x007AFA9C File Offset: 0x007ADC9C
		// (set) Token: 0x06008474 RID: 33908 RVA: 0x007AFB48 File Offset: 0x007ADD48
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)722665473;
				if (num != 0)
				{
				}
				num = (short)1269014658;
				short num2 = num;
				num = (short)213360770;
				switch (num2 == num)
				{
				}
				num = (short)1207762944;
				if (num != 0)
				{
				}
				num = (short)177537024;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1250816853;
				short num2 = num;
				num = (short)361886549;
				switch (num2 == num)
				{
				}
				num = (short)1279262721;
				if (num != 0)
				{
				}
				num = (short)104595456;
				if (num != 0)
				{
				}
				num = (short)1749942272;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004363 RID: 17251
		// (get) Token: 0x06008475 RID: 33909 RVA: 0x007AFBF4 File Offset: 0x007ADDF4
		public bool HasDiffs
		{
			get
			{
				short num = (short)479216884;
				short num2 = num;
				num = (short)1069040884;
				switch (num2 == num)
				{
				}
				num = (short)1018691585;
				if (num != 0)
				{
				}
				num = (short)1327038464;
				if (num != 0)
				{
				}
				num = (short)636813312;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06008476 RID: 33910 RVA: 0x007AFCA4 File Offset: 0x007ADEA4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1314789242;
			short num2 = num;
			num = (short)2002261882;
			switch (num2 == num)
			{
			}
			num = (short)1124532225;
			if (num != 0)
			{
			}
			num = (short)469762048;
			if (num != 0)
			{
			}
			num = (short)1124728832;
			short num3 = num;
			global::AcpBusinessLayer.FeatureNode featureNode = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInner(this);
			this.b(featureNode);
			return featureNode;
		}

		// Token: 0x06008477 RID: 33911 RVA: 0x007AFD5C File Offset: 0x007ADF5C
		internal void SetValues()
		{
			short num = (short)690138310;
			short num2 = num;
			num = (short)1775152326;
			switch (num2 == num)
			{
			}
			num = (short)222232576;
			if (num != 0)
			{
			}
			num = (short)1717239809;
			if (num != 0)
			{
			}
			num = (short)210632704;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_RESPONSESELECTOR;
			base.DataTransferOrder = 50;
		}

		// Token: 0x06008478 RID: 33912 RVA: 0x007AFE28 File Offset: 0x007AE028
		private void b(global::AcpBusinessLayer.FeatureNode A_0)
		{
			short num = (short)1726567529;
			short num2 = num;
			num = (short)1663128681;
			switch (num2 == num)
			{
			}
			num = (short)1091698689;
			if (num != 0)
			{
			}
			num = (short)1554776064;
			if (num != 0)
			{
			}
			num = (short)716374016;
			short num3 = num;
			this.a(A_0);
		}

		// Token: 0x06008479 RID: 33913 RVA: 0x007AFEDC File Offset: 0x007AE0DC
		private void a(global::AcpBusinessLayer.FeatureNode A_0)
		{
			short num = (short)1764343927;
			short num2 = num;
			num = (short)1680851063;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BC;
			case 1:
				break;
			default:
			{
				num = (short)1409351680;
				short num3 = num;
				break;
			}
			}
			num = (short)975896577;
			if (num != 0)
			{
			}
			num = (short)1598488576;
			if (num != 0)
			{
			}
			if (base.Count <= 0)
			{
				(A_0 as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInner).ResponseSelectorListInnerSection.CHO9PursuitKnobIndex_A36685.ReferencedIndex = 1;
				return;
			}
			IL_BC:
			(A_0 as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInner).ResponseSelectorListInnerSection.CHO9PursuitKnobIndex_A36685.ReferencedIndex = 0;
		}

		// Token: 0x0600847A RID: 33914 RVA: 0x007AFFBC File Offset: 0x007AE1BC
		// Note: this type is marked as 'beforefieldinit'.
		static ResponseSelectorListInnerRecset()
		{
			short num = (short)984180215;
			short num2 = num;
			num = (short)1701668343;
			switch (num2 == num)
			{
			}
			num = (short)2081423361;
			if (num != 0)
			{
			}
			num = (short)1403453440;
			if (num != 0)
			{
			}
			num = (short)304283648;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset._Min = 1;
		}

		// Token: 0x04003E73 RID: 15987
		public static int _MaxPool;

		// Token: 0x04003E74 RID: 15988
		public static int _Max;

		// Token: 0x04003E75 RID: 15989
		public int _DynMax;

		// Token: 0x04003E76 RID: 15990
		public static int _Min;

		// Token: 0x04003E77 RID: 15991
		public static int _DefaultRecordCount;
	}
}
