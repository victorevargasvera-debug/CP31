using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000348 RID: 840
	[global::System.Serializable]
	public class BottomFunctionProgrammableButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060080A2 RID: 32930 RVA: 0x00762758 File Offset: 0x00760958
		public BottomFunctionProgrammableButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON)
		{
			this.SetValues();
		}

		// Token: 0x060080A3 RID: 32931 RVA: 0x00762778 File Offset: 0x00760978
		public BottomFunctionProgrammableButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170041BF RID: 16831
		// (get) Token: 0x060080A4 RID: 32932 RVA: 0x007627A4 File Offset: 0x007609A4
		public override int MaxPool
		{
			get
			{
				short num = (short)368836608;
				short num2 = num;
				num = (short)1817072072;
				short num3 = num;
				num = (short)1401901512;
				switch (num3 == num)
				{
				}
				num = (short)1085276161;
				if (num != 0)
				{
				}
				num = (short)2097872896;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x170041C0 RID: 16832
		// (get) Token: 0x060080A5 RID: 32933 RVA: 0x00762850 File Offset: 0x00760A50
		// (set) Token: 0x060080A6 RID: 32934 RVA: 0x00762910 File Offset: 0x00760B10
		public override int Max
		{
			get
			{
				short num = (short)1336965181;
				short num2 = num;
				num = (short)1593997373;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A5;
				case 1:
					break;
				default:
				{
					num = (short)1589706752;
					short num3 = num;
					break;
				}
				}
				num = (short)1414529025;
				if (num != 0)
				{
				}
				num = (short)272957440;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					return this._DynMax;
				}
				IL_A5:
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset._Max;
			}
			set
			{
				short num = (short)21037056;
				short num2 = num;
				num = (short)1001129969;
				short num3 = num;
				num = (short)1541998577;
				switch (num3 == num)
				{
				}
				num = (short)1408958465;
				if (num != 0)
				{
				}
				num = (short)1432748032;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170041C1 RID: 16833
		// (get) Token: 0x060080A7 RID: 32935 RVA: 0x007629C0 File Offset: 0x00760BC0
		public override int Min
		{
			get
			{
				short num = (short)172490752;
				short num2 = num;
				num = (short)1947603721;
				short num3 = num;
				num = (short)1361842953;
				switch (num3 == num)
				{
				}
				num = (short)91357185;
				if (num != 0)
				{
				}
				num = (short)374276096;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset._Min;
			}
		}

		// Token: 0x170041C2 RID: 16834
		// (get) Token: 0x060080A8 RID: 32936 RVA: 0x00762A74 File Offset: 0x00760C74
		// (set) Token: 0x060080A9 RID: 32937 RVA: 0x00762B24 File Offset: 0x00760D24
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)51380224;
				short num2 = num;
				num = (short)1185828696;
				short num3 = num;
				num = (short)1151749976;
				switch (num3 == num)
				{
				}
				num = (short)1256194048;
				if (num != 0)
				{
				}
				num = (short)731447297;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1569718272;
				short num2 = num;
				num = (short)1259464200;
				short num3 = num;
				num = (short)1727456776;
				switch (num3 == num)
				{
				}
				num = (short)1814560768;
				if (num != 0)
				{
				}
				num = (short)953942017;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170041C3 RID: 16835
		// (get) Token: 0x060080AA RID: 32938 RVA: 0x00762BD4 File Offset: 0x00760DD4
		public bool HasDiffs
		{
			get
			{
				short num = (short)198574080;
				short num2 = num;
				num = (short)863240193;
				if (num != 0)
				{
				}
				num = (short)1716092587;
				short num3 = num;
				num = (short)1073249963;
				switch (num3 == num)
				{
				}
				num = (short)662372352;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x00762C84 File Offset: 0x00760E84
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2036662272;
			short num2 = num;
			num = (short)1463615681;
			short num3 = num;
			num = (short)961151169;
			switch (num3 == num)
			{
			}
			num = (short)1472266240;
			if (num != 0)
			{
			}
			num = (short)608239617;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner(this);
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x00762D34 File Offset: 0x00760F34
		internal void SetValues()
		{
			short num = (short)897515520;
			short num2 = num;
			num = (short)1547354536;
			short num3 = num;
			num = (short)1578942888;
			switch (num3 == num)
			{
			}
			num = (short)483196929;
			if (num != 0)
			{
			}
			num = (short)833355776;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 50;
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x00762DFC File Offset: 0x00760FFC
		// Note: this type is marked as 'beforefieldinit'.
		static BottomFunctionProgrammableButtonInnerRecset()
		{
			short num = (short)1464074240;
			short num2 = num;
			num = (short)1003711262;
			short num3 = num;
			num = (short)741567262;
			switch (num3 == num)
			{
			}
			num = (short)1987051521;
			if (num != 0)
			{
			}
			num = (short)768081920;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset._Min = 1;
		}

		// Token: 0x040039C5 RID: 14789
		public static int _MaxPool;

		// Token: 0x040039C6 RID: 14790
		public static int _Max;

		// Token: 0x040039C7 RID: 14791
		public int _DynMax;

		// Token: 0x040039C8 RID: 14792
		public static int _Min;

		// Token: 0x040039C9 RID: 14793
		public static int _DefaultRecordCount;
	}
}
