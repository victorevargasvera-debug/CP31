using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001E6 RID: 486
	[global::System.Serializable]
	public class SignalIndependentProductIndependentProgrammableButtonListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060054B9 RID: 21689 RVA: 0x004CF248 File Offset: 0x004CD448
		public SignalIndependentProductIndependentProgrammableButtonListInnerRecset() : base(global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTPROGRAMMABLEBUTTONLIST, global::CommonResources.AcgResources.ID_SIGNPRG)
		{
			this.SetValues();
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x004CF26C File Offset: 0x004CD46C
		public SignalIndependentProductIndependentProgrammableButtonListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x060054BB RID: 21691 RVA: 0x004CF298 File Offset: 0x004CD498
		public override int MaxPool
		{
			get
			{
				short num = (short)1837629441;
				if (num != 0)
				{
				}
				num = (short)913986771;
				short num2 = num;
				num = (short)97473747;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1821179904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1979252736;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x060054BC RID: 21692 RVA: 0x004CF348 File Offset: 0x004CD548
		// (set) Token: 0x060054BD RID: 21693 RVA: 0x004CF40C File Offset: 0x004CD60C
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)2046365037;
					short num2 = num;
					num = (short)61869421;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1129447424;
						short num3 = num;
						num = (short)675545089;
						if (num != 0)
						{
						}
						num = (short)639303680;
						if (num != 0)
						{
						}
						break;
					}
					}
					return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1283838499;
				short num2 = num;
				num = (short)876270115;
				switch (num2 == num)
				{
				}
				num = (short)2080833536;
				short num3 = num;
				num = (short)578224128;
				if (num != 0)
				{
				}
				num = (short)333381633;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x060054BE RID: 21694 RVA: 0x004CF4BC File Offset: 0x004CD6BC
		public override int Min
		{
			get
			{
				short num = (short)1551003356;
				short num2 = num;
				num = (short)1397452508;
				switch (num2 == num)
				{
				}
				num = (short)409600000;
				short num3 = num;
				num = (short)880803840;
				if (num != 0)
				{
				}
				num = (short)642580481;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset._Min;
			}
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x060054BF RID: 21695 RVA: 0x004CF56C File Offset: 0x004CD76C
		// (set) Token: 0x060054C0 RID: 21696 RVA: 0x004CF618 File Offset: 0x004CD818
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)70176966;
				short num2 = num;
				num = (short)215273670;
				switch (num2 == num)
				{
				}
				num = (short)498073600;
				short num3 = num;
				num = (short)688914433;
				if (num != 0)
				{
				}
				num = (short)1533804544;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1081670981;
				short num2 = num;
				num = (short)1082260805;
				switch (num2 == num)
				{
				}
				num = (short)494403584;
				short num3 = num;
				num = (short)2065367040;
				if (num != 0)
				{
				}
				num = (short)1496252417;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x060054C1 RID: 21697 RVA: 0x004CF6CC File Offset: 0x004CD8CC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1509092496;
				short num2 = num;
				num = (short)38857872;
				switch (num2 == num)
				{
				}
				num = (short)1968308224;
				short num3 = num;
				num = (short)1940324353;
				if (num != 0)
				{
				}
				num = (short)779550720;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060054C2 RID: 21698 RVA: 0x004CF780 File Offset: 0x004CD980
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)158141101;
			short num2 = num;
			num = (short)2086734509;
			switch (num2 == num)
			{
			}
			num = (short)2119106560;
			short num3 = num;
			num = (short)987365376;
			if (num != 0)
			{
			}
			num = (short)179372033;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner(this);
		}

		// Token: 0x060054C3 RID: 21699 RVA: 0x004CF830 File Offset: 0x004CDA30
		internal void SetValues()
		{
			short num = (short)792544521;
			short num2 = num;
			num = (short)1978483977;
			switch (num2 == num)
			{
			}
			num = (short)1805516800;
			short num3 = num;
			num = (short)550830081;
			if (num != 0)
			{
			}
			num = (short)888733696;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTPROGRAMMABLEBUTTONLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_SIGNPRG;
			base.DataTransferOrder = 22;
		}

		// Token: 0x060054C4 RID: 21700 RVA: 0x004CF904 File Offset: 0x004CDB04
		// Note: this type is marked as 'beforefieldinit'.
		static SignalIndependentProductIndependentProgrammableButtonListInnerRecset()
		{
			short num = (short)2129299747;
			short num2 = num;
			num = (short)519670051;
			switch (num2 == num)
			{
			}
			num = (short)1231093760;
			short num3 = num;
			num = (short)579796993;
			if (num != 0)
			{
			}
			num = (short)914620416;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset._Min = 1;
		}

		// Token: 0x04002169 RID: 8553
		public static int _MaxPool;

		// Token: 0x0400216A RID: 8554
		public static int _Max;

		// Token: 0x0400216B RID: 8555
		public int _DynMax;

		// Token: 0x0400216C RID: 8556
		public static int _Min;

		// Token: 0x0400216D RID: 8557
		public static int _DefaultRecordCount;
	}
}
