using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x020003A1 RID: 929
	[global::System.Serializable]
	public class O7MFKAssignmentControlInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060087C9 RID: 34761 RVA: 0x007E7048 File Offset: 0x007E5248
		public O7MFKAssignmentControlInnerRecset() : base(global::CommonResources.AcgResources.ID_MFKROTARYCONTROL, global::CommonResources.AcgResources.ID_MFKCONTROL)
		{
			this.SetValues();
		}

		// Token: 0x060087CA RID: 34762 RVA: 0x007E706C File Offset: 0x007E526C
		public O7MFKAssignmentControlInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700450F RID: 17679
		// (get) Token: 0x060087CB RID: 34763 RVA: 0x007E7098 File Offset: 0x007E5298
		public override int MaxPool
		{
			get
			{
				short num = (short)265277492;
				short num2 = num;
				num = (short)1875562548;
				switch (num2 == num)
				{
				}
				num = (short)1977352193;
				if (num != 0)
				{
				}
				num = (short)632946688;
				short num3 = num;
				num = (short)487981056;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004510 RID: 17680
		// (get) Token: 0x060087CC RID: 34764 RVA: 0x007E7148 File Offset: 0x007E5348
		// (set) Token: 0x060087CD RID: 34765 RVA: 0x007E7208 File Offset: 0x007E5408
		public override int Max
		{
			get
			{
				short num = (short)329252864;
				short num2 = num;
				if (this._DynMax == -1)
				{
					num = (short)281346049;
					if (num != 0)
					{
					}
					num = (short)1427088680;
					short num3 = num;
					num = (short)804955432;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)319750144;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset._Max;
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1065485264;
				short num2 = num;
				num = (short)386008016;
				switch (num2 == num)
				{
				}
				num = (short)1624375297;
				if (num != 0)
				{
				}
				num = (short)906821632;
				short num3 = num;
				num = (short)445775872;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004511 RID: 17681
		// (get) Token: 0x060087CE RID: 34766 RVA: 0x007E72B8 File Offset: 0x007E54B8
		public override int Min
		{
			get
			{
				short num = (short)1091263004;
				short num2 = num;
				num = (short)1206802972;
				switch (num2 == num)
				{
				}
				num = (short)894500865;
				if (num != 0)
				{
				}
				num = (short)1110900736;
				short num3 = num;
				num = (short)2023096320;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset._Min;
			}
		}

		// Token: 0x17004512 RID: 17682
		// (get) Token: 0x060087CF RID: 34767 RVA: 0x007E7368 File Offset: 0x007E5568
		// (set) Token: 0x060087D0 RID: 34768 RVA: 0x007E7418 File Offset: 0x007E5618
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1541420974;
				short num2 = num;
				num = (short)898447278;
				switch (num2 == num)
				{
				}
				num = (short)1175322624;
				if (num != 0)
				{
				}
				num = (short)2146369536;
				short num3 = num;
				num = (short)1435959297;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)306185577;
				short num2 = num;
				num = (short)855704937;
				switch (num2 == num)
				{
				}
				num = (short)384499712;
				short num3 = num;
				num = (short)688062465;
				if (num != 0)
				{
				}
				num = (short)287506432;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004513 RID: 17683
		// (get) Token: 0x060087D1 RID: 34769 RVA: 0x007E74C8 File Offset: 0x007E56C8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1750841780;
				short num2 = num;
				num = (short)1585559988;
				switch (num2 == num)
				{
				}
				num = (short)1915158528;
				short num3 = num;
				num = (short)1473773569;
				if (num != 0)
				{
				}
				num = (short)375914496;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060087D2 RID: 34770 RVA: 0x007E7578 File Offset: 0x007E5778
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1380919655;
			short num2 = num;
			num = (short)370092391;
			switch (num2 == num)
			{
			}
			num = (short)1551499264;
			short num3 = num;
			num = (short)915144704;
			if (num != 0)
			{
			}
			num = (short)1351090177;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner(this);
		}

		// Token: 0x060087D3 RID: 34771 RVA: 0x007E7628 File Offset: 0x007E5828
		internal void SetValues()
		{
			short num = (short)2086629388;
			short num2 = num;
			num = (short)409890828;
			switch (num2 == num)
			{
			}
			num = (short)1253441536;
			short num3 = num;
			num = (short)544014337;
			if (num != 0)
			{
			}
			num = (short)1319567360;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_MFKROTARYCONTROL;
			base.KeySeed = global::CommonResources.AcgResources.ID_MFKCONTROL;
			base.DataTransferOrder = 65;
		}

		// Token: 0x060087D4 RID: 34772 RVA: 0x007E7700 File Offset: 0x007E5900
		// Note: this type is marked as 'beforefieldinit'.
		static O7MFKAssignmentControlInnerRecset()
		{
			short num = (short)74902956;
			short num2 = num;
			num = (short)1756556716;
			switch (num2 == num)
			{
			}
			num = (short)1731330048;
			short num3 = num;
			num = (short)1715470337;
			if (num != 0)
			{
			}
			num = (short)1229324288;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset._Min = 1;
		}

		// Token: 0x04003FF7 RID: 16375
		public static int _MaxPool;

		// Token: 0x04003FF8 RID: 16376
		public static int _Max;

		// Token: 0x04003FF9 RID: 16377
		public int _DynMax;

		// Token: 0x04003FFA RID: 16378
		public static int _Min;

		// Token: 0x04003FFB RID: 16379
		public static int _DefaultRecordCount;
	}
}
