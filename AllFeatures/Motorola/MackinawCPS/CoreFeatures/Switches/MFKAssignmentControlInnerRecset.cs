using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002B7 RID: 695
	[global::System.Serializable]
	public class MFKAssignmentControlInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060074F6 RID: 29942 RVA: 0x00698A64 File Offset: 0x00696C64
		public MFKAssignmentControlInnerRecset() : base(global::CommonResources.AcgResources.ID_MFKROTARYCONTROL, global::CommonResources.AcgResources.ID_MFKCONTROL)
		{
			this.SetValues();
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x00698A88 File Offset: 0x00696C88
		public MFKAssignmentControlInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003C47 RID: 15431
		// (get) Token: 0x060074F8 RID: 29944 RVA: 0x00698AB4 File Offset: 0x00696CB4
		public override int MaxPool
		{
			get
			{
				short num = (short)1972273719;
				short num2 = num;
				num = (short)1496416823;
				switch (num2 == num)
				{
				}
				num = (short)108658689;
				if (num != 0)
				{
				}
				num = (short)800325632;
				if (num != 0)
				{
				}
				num = (short)1965752320;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x060074F9 RID: 29945 RVA: 0x00698B64 File Offset: 0x00696D64
		// (set) Token: 0x060074FA RID: 29946 RVA: 0x00698C28 File Offset: 0x00696E28
		public override int Max
		{
			get
			{
				if (this._DynMax != -1)
				{
					short num = (short)1967303261;
					short num2 = num;
					num = (short)1080666717;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1669791745;
						if (num != 0)
						{
						}
						num = (short)1726611456;
						if (num != 0)
						{
						}
						num = (short)668729344;
						short num3 = num;
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset._Max;
			}
			set
			{
				short num = (short)809406247;
				short num2 = num;
				num = (short)1638108967;
				switch (num2 == num)
				{
				}
				num = (short)1866924032;
				if (num != 0)
				{
				}
				num = (short)1085865985;
				if (num != 0)
				{
				}
				num = (short)1616314368;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x060074FB RID: 29947 RVA: 0x00698CD8 File Offset: 0x00696ED8
		public override int Min
		{
			get
			{
				short num = (short)1882687248;
				short num2 = num;
				num = (short)1731888912;
				switch (num2 == num)
				{
				}
				num = (short)207814657;
				if (num != 0)
				{
				}
				num = (short)1962409984;
				if (num != 0)
				{
				}
				num = (short)1373306880;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset._Min;
			}
		}

		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x060074FC RID: 29948 RVA: 0x00698D8C File Offset: 0x00696F8C
		// (set) Token: 0x060074FD RID: 29949 RVA: 0x00698E3C File Offset: 0x0069703C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)574029825;
				if (num != 0)
				{
				}
				num = (short)89359300;
				short num2 = num;
				num = (short)1316062148;
				switch (num2 == num)
				{
				}
				num = (short)856358912;
				if (num != 0)
				{
				}
				num = (short)645595136;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1400385438;
				short num2 = num;
				num = (short)2025074590;
				switch (num2 == num)
				{
				}
				num = (short)848887809;
				if (num != 0)
				{
				}
				num = (short)1316093952;
				if (num != 0)
				{
				}
				num = (short)368181248;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003C4B RID: 15435
		// (get) Token: 0x060074FE RID: 29950 RVA: 0x00698EEC File Offset: 0x006970EC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1498446784;
				short num2 = num;
				num = (short)411401152;
				switch (num2 == num)
				{
				}
				num = (short)299892736;
				if (num != 0)
				{
				}
				num = (short)1286995969;
				if (num != 0)
				{
				}
				num = (short)307691520;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x060074FF RID: 29951 RVA: 0x00698F9C File Offset: 0x0069719C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)773806960;
			short num2 = num;
			num = (short)1860787056;
			switch (num2 == num)
			{
			}
			num = (short)930086913;
			if (num != 0)
			{
			}
			num = (short)1261633536;
			if (num != 0)
			{
			}
			num = (short)723976192;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner(this);
		}

		// Token: 0x06007500 RID: 29952 RVA: 0x0069904C File Offset: 0x0069724C
		internal void SetValues()
		{
			short num = (short)1552937418;
			short num2 = num;
			num = (short)1642262986;
			switch (num2 == num)
			{
			}
			num = (short)151715840;
			if (num != 0)
			{
			}
			num = (short)1358036993;
			if (num != 0)
			{
			}
			num = (short)1648427008;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_MFKROTARYCONTROL;
			base.KeySeed = global::CommonResources.AcgResources.ID_MFKCONTROL;
			base.DataTransferOrder = 24;
		}

		// Token: 0x06007501 RID: 29953 RVA: 0x00699120 File Offset: 0x00697320
		// Note: this type is marked as 'beforefieldinit'.
		static MFKAssignmentControlInnerRecset()
		{
			short num = (short)892550462;
			short num2 = num;
			num = (short)1023229246;
			switch (num2 == num)
			{
			}
			num = (short)652804097;
			if (num != 0)
			{
			}
			num = (short)741408768;
			if (num != 0)
			{
			}
			num = (short)686751744;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset._Min = 1;
		}

		// Token: 0x04002F78 RID: 12152
		public static int _MaxPool;

		// Token: 0x04002F79 RID: 12153
		public static int _Max;

		// Token: 0x04002F7A RID: 12154
		public int _DynMax;

		// Token: 0x04002F7B RID: 12155
		public static int _Min;

		// Token: 0x04002F7C RID: 12156
		public static int _DefaultRecordCount;
	}
}
