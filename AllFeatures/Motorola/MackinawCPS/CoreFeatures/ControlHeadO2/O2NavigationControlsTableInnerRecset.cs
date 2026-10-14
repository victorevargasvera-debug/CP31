using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003E6 RID: 998
	[global::System.Serializable]
	public class O2NavigationControlsTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008C4B RID: 35915 RVA: 0x00833C88 File Offset: 0x00831E88
		public O2NavigationControlsTableInnerRecset() : base(global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS, global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS)
		{
			this.SetValues();
		}

		// Token: 0x06008C4C RID: 35916 RVA: 0x00833CAC File Offset: 0x00831EAC
		public O2NavigationControlsTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004707 RID: 18183
		// (get) Token: 0x06008C4D RID: 35917 RVA: 0x00833CD8 File Offset: 0x00831ED8
		public override int MaxPool
		{
			get
			{
				short num = (short)1633023941;
				short num2 = num;
				num = (short)1885599685;
				switch (num2 == num)
				{
				}
				num = (short)1164509185;
				if (num != 0)
				{
				}
				num = (short)119078912;
				short num3 = num;
				num = (short)17367040;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004708 RID: 18184
		// (get) Token: 0x06008C4E RID: 35918 RVA: 0x00833D88 File Offset: 0x00831F88
		// (set) Token: 0x06008C4F RID: 35919 RVA: 0x00833E4C File Offset: 0x0083204C
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax == -1)
				{
					num = (short)788922369;
					if (num != 0)
					{
					}
					num = (short)404388191;
					short num2 = num;
					num = (short)2062687;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)941359104;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset._Max;
					}
				}
				num = (short)1455489024;
				short num3 = num;
				return this._DynMax;
			}
			set
			{
				short num = (short)1793971656;
				short num2 = num;
				num = (short)474994120;
				switch (num2 == num)
				{
				}
				num = (short)953024513;
				if (num != 0)
				{
				}
				num = (short)1449394176;
				short num3 = num;
				num = (short)292225024;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004709 RID: 18185
		// (get) Token: 0x06008C50 RID: 35920 RVA: 0x00833EFC File Offset: 0x008320FC
		public override int Min
		{
			get
			{
				short num = (short)832512687;
				short num2 = num;
				num = (short)338961071;
				switch (num2 == num)
				{
				}
				num = (short)999751680;
				if (num != 0)
				{
				}
				num = (short)1251934208;
				short num3 = num;
				num = (short)499187713;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset._Min;
			}
		}

		// Token: 0x1700470A RID: 18186
		// (get) Token: 0x06008C51 RID: 35921 RVA: 0x00833FAC File Offset: 0x008321AC
		// (set) Token: 0x06008C52 RID: 35922 RVA: 0x0083405C File Offset: 0x0083225C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)833175976;
				short num2 = num;
				num = (short)691552680;
				switch (num2 == num)
				{
				}
				num = (short)926154752;
				if (num != 0)
				{
				}
				num = (short)862388224;
				short num3 = num;
				num = (short)169803777;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1751198379;
				short num2 = num;
				num = (short)853682859;
				switch (num2 == num)
				{
				}
				num = (short)879296512;
				if (num != 0)
				{
				}
				num = (short)1009582080;
				short num3 = num;
				num = (short)1791361025;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700470B RID: 18187
		// (get) Token: 0x06008C53 RID: 35923 RVA: 0x0083410C File Offset: 0x0083230C
		public bool HasDiffs
		{
			get
			{
				short num = (short)824358915;
				short num2 = num;
				num = (short)1820768259;
				switch (num2 == num)
				{
				}
				num = (short)632684545;
				if (num != 0)
				{
				}
				num = (short)760479744;
				short num3 = num;
				num = (short)1255145472;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008C54 RID: 35924 RVA: 0x008341BC File Offset: 0x008323BC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1935057372;
			short num2 = num;
			num = (short)1132503516;
			switch (num2 == num)
			{
			}
			num = (short)1403060225;
			if (num != 0)
			{
			}
			num = (short)1590624256;
			short num3 = num;
			num = (short)727187456;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInner(this);
		}

		// Token: 0x06008C55 RID: 35925 RVA: 0x0083426C File Offset: 0x0083246C
		internal void SetValues()
		{
			short num = (short)110099978;
			short num2 = num;
			num = (short)750321162;
			switch (num2 == num)
			{
			}
			num = (short)1621098497;
			if (num != 0)
			{
			}
			num = (short)373030912;
			short num3 = num;
			num = (short)1328676864;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.KeySeed = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 60;
		}

		// Token: 0x06008C56 RID: 35926 RVA: 0x00834340 File Offset: 0x00832540
		// Note: this type is marked as 'beforefieldinit'.
		static O2NavigationControlsTableInnerRecset()
		{
			short num = (short)1682440193;
			if (num != 0)
			{
			}
			num = (short)201576348;
			short num2 = num;
			num = (short)939577244;
			switch (num2 == num)
			{
			}
			num = (short)1521287168;
			if (num != 0)
			{
			}
			num = (short)1760952320;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset._Min = 1;
		}

		// Token: 0x040043EE RID: 17390
		public static int _MaxPool;

		// Token: 0x040043EF RID: 17391
		public static int _Max;

		// Token: 0x040043F0 RID: 17392
		public int _DynMax;

		// Token: 0x040043F1 RID: 17393
		public static int _Min;

		// Token: 0x040043F2 RID: 17394
		public static int _DefaultRecordCount;
	}
}
