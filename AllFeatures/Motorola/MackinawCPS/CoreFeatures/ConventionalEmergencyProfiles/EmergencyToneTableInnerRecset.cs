using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x020004A3 RID: 1187
	[global::System.Serializable]
	public class EmergencyToneTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06009B08 RID: 39688 RVA: 0x00914264 File Offset: 0x00912464
		public EmergencyToneTableInnerRecset() : base(global::CommonResources.AcgResources.ID_EMERGENCYTONETABLE, global::CommonResources.AcgResources.ID_TONE)
		{
			this.SetValues();
		}

		// Token: 0x06009B09 RID: 39689 RVA: 0x00914288 File Offset: 0x00912488
		public EmergencyToneTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004DC6 RID: 19910
		// (get) Token: 0x06009B0A RID: 39690 RVA: 0x009142B4 File Offset: 0x009124B4
		public override int MaxPool
		{
			get
			{
				short num = (short)1783988351;
				short num2 = num;
				num = (short)1955364991;
				switch (num2 == num)
				{
				}
				num = (short)2139815937;
				if (num != 0)
				{
				}
				num = (short)476643328;
				if (num != 0)
				{
				}
				num = (short)1746534400;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004DC7 RID: 19911
		// (get) Token: 0x06009B0B RID: 39691 RVA: 0x00914364 File Offset: 0x00912564
		// (set) Token: 0x06009B0C RID: 39692 RVA: 0x00914420 File Offset: 0x00912620
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax != -1)
				{
					num = (short)799505451;
					short num2 = num;
					num = (short)919632939;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)871497729;
						if (num != 0)
						{
						}
						num = (short)317128704;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				num = (short)1443758080;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerRecset._Max;
			}
			set
			{
				short num = (short)660923089;
				short num2 = num;
				num = (short)1774117585;
				switch (num2 == num)
				{
				}
				num = (short)611516416;
				short num3 = num;
				num = (short)545587201;
				if (num != 0)
				{
				}
				num = (short)303497216;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004DC8 RID: 19912
		// (get) Token: 0x06009B0D RID: 39693 RVA: 0x009144D0 File Offset: 0x009126D0
		public override int Min
		{
			get
			{
				short num = (short)2131198813;
				short num2 = num;
				num = (short)551060317;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1259732992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)911867905;
				if (num != 0)
				{
				}
				num = (short)1326448640;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerRecset._Min;
			}
		}

		// Token: 0x17004DC9 RID: 19913
		// (get) Token: 0x06009B0E RID: 39694 RVA: 0x00914580 File Offset: 0x00912780
		// (set) Token: 0x06009B0F RID: 39695 RVA: 0x0091462C File Offset: 0x0091282C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)766705665;
				if (num != 0)
				{
				}
				num = (short)1606025216;
				short num2 = num;
				num = (short)619420153;
				short num3 = num;
				num = (short)630692345;
				switch (num3 == num)
				{
				}
				num = (short)95551488;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)970623200;
				short num2 = num;
				num = (short)2102036704;
				switch (num2 == num)
				{
				default:
				{
					num = (short)566755328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)109838337;
				if (num != 0)
				{
				}
				num = (short)148963328;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004DCA RID: 19914
		// (get) Token: 0x06009B10 RID: 39696 RVA: 0x009146DC File Offset: 0x009128DC
		public bool HasDiffs
		{
			get
			{
				short num = (short)2137980929;
				if (num != 0)
				{
				}
				num = (short)1119551488;
				short num2 = num;
				num = (short)1582411357;
				short num3 = num;
				num = (short)1874177629;
				switch (num3 == num)
				{
				}
				num = (short)209780736;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06009B11 RID: 39697 RVA: 0x0091478C File Offset: 0x0091298C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1792105714;
			short num2 = num;
			num = (short)892755186;
			switch (num2 == num)
			{
			default:
			{
				num = (short)65929216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2052849664;
			if (num != 0)
			{
			}
			num = (short)784728065;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInner(this);
		}

		// Token: 0x06009B12 RID: 39698 RVA: 0x00914838 File Offset: 0x00912A38
		internal void SetValues()
		{
			short num = (short)1883037816;
			short num2 = num;
			num = (short)1004724344;
			switch (num2 == num)
			{
			default:
			{
				num = (short)741474304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2015035393;
			if (num != 0)
			{
			}
			num = (short)156958720;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYTONETABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_TONE;
			base.DataTransferOrder = 29;
		}

		// Token: 0x06009B13 RID: 39699 RVA: 0x00914910 File Offset: 0x00912B10
		// Note: this type is marked as 'beforefieldinit'.
		static EmergencyToneTableInnerRecset()
		{
			short num = (short)1210418332;
			short num2 = num;
			num = (short)659653788;
			switch (num2 == num)
			{
			default:
			{
				num = (short)608829440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)994902017;
			if (num != 0)
			{
			}
			num = (short)1968308224;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerRecset._Min = 1;
		}

		// Token: 0x04004CF3 RID: 19699
		public static int _MaxPool;

		// Token: 0x04004CF4 RID: 19700
		public static int _Max;

		// Token: 0x04004CF5 RID: 19701
		public int _DynMax;

		// Token: 0x04004CF6 RID: 19702
		public static int _Min;

		// Token: 0x04004CF7 RID: 19703
		public static int _DefaultRecordCount;
	}
}
