using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000388 RID: 904
	[global::System.Serializable]
	public class TopFunctionProgrammableButtonListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060084F3 RID: 34035 RVA: 0x007B5AFC File Offset: 0x007B3CFC
		public TopFunctionProgrammableButtonListInnerRecset() : base(global::CommonResources.AcgResources.ID_TOPFUNCTIONPROGRAMMABLEBUTTON)
		{
			this.SetValues();
		}

		// Token: 0x060084F4 RID: 34036 RVA: 0x007B5B1C File Offset: 0x007B3D1C
		public TopFunctionProgrammableButtonListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170043A0 RID: 17312
		// (get) Token: 0x060084F5 RID: 34037 RVA: 0x007B5B48 File Offset: 0x007B3D48
		public override int MaxPool
		{
			get
			{
				short num = (short)753019711;
				short num2 = num;
				num = (short)605039423;
				switch (num2 == num)
				{
				}
				num = (short)1808728064;
				short num3 = num;
				num = (short)1246625793;
				if (num != 0)
				{
				}
				num = (short)635371520;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset._MaxPool;
			}
		}

		// Token: 0x170043A1 RID: 17313
		// (get) Token: 0x060084F6 RID: 34038 RVA: 0x007B5BF8 File Offset: 0x007B3DF8
		// (set) Token: 0x060084F7 RID: 34039 RVA: 0x007B5CB8 File Offset: 0x007B3EB8
		public override int Max
		{
			get
			{
				short num = (short)657719297;
				if (num != 0)
				{
				}
				num = (short)630790445;
				short num2 = num;
				num = (short)871438637;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1675886592;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					num = (short)515440640;
					short num3 = num;
					break;
				}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset._Max;
			}
			set
			{
				short num = (short)958398465;
				if (num != 0)
				{
				}
				num = (short)137098420;
				short num2 = num;
				num = (short)825881780;
				switch (num2 == num)
				{
				}
				num = (short)1113325568;
				short num3 = num;
				num = (short)2043805696;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170043A2 RID: 17314
		// (get) Token: 0x060084F8 RID: 34040 RVA: 0x007B5D68 File Offset: 0x007B3F68
		public override int Min
		{
			get
			{
				short num = (short)177313139;
				short num2 = num;
				num = (short)2026476915;
				switch (num2 == num)
				{
				}
				num = (short)363462657;
				if (num != 0)
				{
				}
				num = (short)2067726336;
				short num3 = num;
				num = (short)328990720;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset._Min;
			}
		}

		// Token: 0x170043A3 RID: 17315
		// (get) Token: 0x060084F9 RID: 34041 RVA: 0x007B5E14 File Offset: 0x007B4014
		// (set) Token: 0x060084FA RID: 34042 RVA: 0x007B5EC0 File Offset: 0x007B40C0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2081363109;
				short num2 = num;
				num = (short)11015333;
				switch (num2 == num)
				{
				}
				num = (short)470679552;
				if (num != 0)
				{
				}
				num = (short)1858600960;
				short num3 = num;
				num = (short)77791233;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)158193729;
				short num2 = num;
				num = (short)1893587009;
				switch (num2 == num)
				{
				}
				num = (short)1721106433;
				if (num != 0)
				{
				}
				num = (short)1113260032;
				short num3 = num;
				num = (short)988807168;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170043A4 RID: 17316
		// (get) Token: 0x060084FB RID: 34043 RVA: 0x007B5F70 File Offset: 0x007B4170
		public bool HasDiffs
		{
			get
			{
				short num = (short)1143334964;
				short num2 = num;
				num = (short)181397556;
				switch (num2 == num)
				{
				}
				num = (short)1014366209;
				if (num != 0)
				{
				}
				num = (short)1986723840;
				short num3 = num;
				num = (short)2092171264;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060084FC RID: 34044 RVA: 0x007B6020 File Offset: 0x007B4220
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)782041089;
			if (num != 0)
			{
			}
			num = (short)874486013;
			short num2 = num;
			num = (short)1048942845;
			switch (num2 == num)
			{
			}
			num = (short)1526464512;
			short num3 = num;
			num = (short)1157824512;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner(this);
		}

		// Token: 0x060084FD RID: 34045 RVA: 0x007B60D0 File Offset: 0x007B42D0
		internal void SetValues()
		{
			short num = (short)1720567408;
			short num2 = num;
			num = (short)658818672;
			switch (num2 == num)
			{
			}
			num = (short)1076297729;
			if (num != 0)
			{
			}
			num = (short)136052736;
			short num3 = num;
			num = (short)1445789696;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TOPFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 50;
		}

		// Token: 0x060084FE RID: 34046 RVA: 0x007B6198 File Offset: 0x007B4398
		// Note: this type is marked as 'beforefieldinit'.
		static TopFunctionProgrammableButtonListInnerRecset()
		{
			short num = (short)386838010;
			short num2 = num;
			num = (short)2124000762;
			switch (num2 == num)
			{
			}
			num = (short)214237184;
			if (num != 0)
			{
			}
			num = (short)563019776;
			short num3 = num;
			num = (short)738787329;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset._Min = 1;
		}

		// Token: 0x04003E7E RID: 15998
		public static int _MaxPool;

		// Token: 0x04003E7F RID: 15999
		public static int _Max;

		// Token: 0x04003E80 RID: 16000
		public int _DynMax;

		// Token: 0x04003E81 RID: 16001
		public static int _Min;

		// Token: 0x04003E82 RID: 16002
		public static int _DefaultRecordCount;
	}
}
