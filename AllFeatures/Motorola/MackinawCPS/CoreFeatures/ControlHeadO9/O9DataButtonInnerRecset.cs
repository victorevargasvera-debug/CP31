using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000371 RID: 881
	[global::System.Serializable]
	public class O9DataButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600827A RID: 33402 RVA: 0x007988C8 File Offset: 0x00796AC8
		public O9DataButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_DATABUTTON_1)
		{
			this.SetValues();
		}

		// Token: 0x0600827B RID: 33403 RVA: 0x007988E8 File Offset: 0x00796AE8
		public O9DataButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004274 RID: 17012
		// (get) Token: 0x0600827C RID: 33404 RVA: 0x00798914 File Offset: 0x00796B14
		public override int MaxPool
		{
			get
			{
				short num = (short)445644800;
				short num2 = num;
				num = (short)1034509307;
				short num3 = num;
				num = (short)1703566331;
				switch (num3 == num)
				{
				}
				num = (short)560988160;
				if (num != 0)
				{
				}
				num = (short)1061093377;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004275 RID: 17013
		// (get) Token: 0x0600827D RID: 33405 RVA: 0x007989C0 File Offset: 0x00796BC0
		// (set) Token: 0x0600827E RID: 33406 RVA: 0x00798A80 File Offset: 0x00796C80
		public override int Max
		{
			get
			{
				short num = (short)2082235803;
				short num2 = num;
				num = (short)281240987;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AB;
				case 1:
					break;
				default:
				{
					num = (short)1830617088;
					short num3 = num;
					break;
				}
				}
				num = (short)399507457;
				if (num != 0)
				{
				}
				num = (short)1387659264;
				if (num != 0)
				{
				}
				if (this._DynMax == -1)
				{
					return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset._Max;
				}
				IL_AB:
				return this._DynMax;
			}
			set
			{
				short num = (short)938082304;
				short num2 = num;
				num = (short)156913607;
				short num3 = num;
				num = (short)1611091911;
				switch (num3 == num)
				{
				}
				num = (short)676134913;
				if (num != 0)
				{
				}
				num = (short)941162496;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004276 RID: 17014
		// (get) Token: 0x0600827F RID: 33407 RVA: 0x00798B34 File Offset: 0x00796D34
		public override int Min
		{
			get
			{
				short num = (short)267255808;
				short num2 = num;
				num = (short)2044993932;
				short num3 = num;
				num = (short)115745164;
				switch (num3 == num)
				{
				}
				num = (short)299761665;
				if (num != 0)
				{
				}
				num = (short)535822336;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset._Min;
			}
		}

		// Token: 0x17004277 RID: 17015
		// (get) Token: 0x06008280 RID: 33408 RVA: 0x00798BE4 File Offset: 0x00796DE4
		// (set) Token: 0x06008281 RID: 33409 RVA: 0x00798C94 File Offset: 0x00796E94
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1122172928;
				short num2 = num;
				num = (short)1153199193;
				short num3 = num;
				num = (short)199978073;
				switch (num3 == num)
				{
				}
				num = (short)582156288;
				if (num != 0)
				{
				}
				num = (short)961413121;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)51970048;
				short num2 = num;
				num = (short)924242155;
				short num3 = num;
				num = (short)1845088491;
				switch (num3 == num)
				{
				}
				num = (short)792461313;
				if (num != 0)
				{
				}
				num = (short)727908352;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004278 RID: 17016
		// (get) Token: 0x06008282 RID: 33410 RVA: 0x00798D40 File Offset: 0x00796F40
		public bool HasDiffs
		{
			get
			{
				short num = (short)1314146349;
				short num2 = num;
				num = (short)712263725;
				switch (num2 == num)
				{
				}
				num = (short)1134952449;
				if (num != 0)
				{
				}
				num = (short)390725632;
				if (num != 0)
				{
				}
				num = (short)2083258368;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06008283 RID: 33411 RVA: 0x00798DF0 File Offset: 0x00796FF0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)368218286;
			short num2 = num;
			num = (short)244224174;
			switch (num2 == num)
			{
			}
			num = (short)1837891585;
			if (num != 0)
			{
			}
			num = (short)451805184;
			if (num != 0)
			{
			}
			num = (short)2008154112;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInner(this);
		}

		// Token: 0x06008284 RID: 33412 RVA: 0x00798EA0 File Offset: 0x007970A0
		internal void SetValues()
		{
			short num = (short)1568916902;
			short num2 = num;
			num = (short)1460389286;
			switch (num2 == num)
			{
			}
			num = (short)637534209;
			if (num != 0)
			{
			}
			num = (short)402259968;
			if (num != 0)
			{
			}
			num = (short)1255800832;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DATABUTTON_1;
			base.DataTransferOrder = 50;
		}

		// Token: 0x06008285 RID: 33413 RVA: 0x00798F68 File Offset: 0x00797168
		// Note: this type is marked as 'beforefieldinit'.
		static O9DataButtonInnerRecset()
		{
			short num = (short)349374741;
			short num2 = num;
			num = (short)1502349589;
			switch (num2 == num)
			{
			}
			num = (short)1337982977;
			if (num != 0)
			{
			}
			num = (short)657391616;
			if (num != 0)
			{
			}
			num = (short)462815232;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset._Min = 1;
		}

		// Token: 0x04003E45 RID: 15941
		public static int _MaxPool;

		// Token: 0x04003E46 RID: 15942
		public static int _Max;

		// Token: 0x04003E47 RID: 15943
		public int _DynMax;

		// Token: 0x04003E48 RID: 15944
		public static int _Min;

		// Token: 0x04003E49 RID: 15945
		public static int _DefaultRecordCount;
	}
}
