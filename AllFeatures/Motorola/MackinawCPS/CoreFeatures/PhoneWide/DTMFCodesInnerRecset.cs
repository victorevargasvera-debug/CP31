using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x02000439 RID: 1081
	[global::System.Serializable]
	public class DTMFCodesInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600921C RID: 37404 RVA: 0x0089BE30 File Offset: 0x0089A030
		public DTMFCodesInnerRecset() : base(global::CommonResources.AcgResources.ID_DTMFCODES, global::CommonResources.AcgResources.ID_CODE)
		{
			this.SetValues();
		}

		// Token: 0x0600921D RID: 37405 RVA: 0x0089BE54 File Offset: 0x0089A054
		public DTMFCodesInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170049B5 RID: 18869
		// (get) Token: 0x0600921E RID: 37406 RVA: 0x0089BE80 File Offset: 0x0089A080
		public override int MaxPool
		{
			get
			{
				short num = (short)1141702656;
				short num2 = num;
				num = (short)1440480699;
				short num3 = num;
				num = (short)1841823163;
				switch (num3 == num)
				{
				}
				num = (short)1587216385;
				if (num != 0)
				{
				}
				num = (short)97845248;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerRecset._MaxPool;
			}
		}

		// Token: 0x170049B6 RID: 18870
		// (get) Token: 0x0600921F RID: 37407 RVA: 0x0089BF30 File Offset: 0x0089A130
		// (set) Token: 0x06009220 RID: 37408 RVA: 0x0089BFF0 File Offset: 0x0089A1F0
		public override int Max
		{
			get
			{
				short num = (short)1906660132;
				short num2 = num;
				num = (short)845239076;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AA;
				case 1:
					break;
				default:
				{
					num = (short)2055340032;
					short num3 = num;
					break;
				}
				}
				num = (short)2102853632;
				if (num != 0)
				{
				}
				if (this._DynMax == -1)
				{
					num = (short)1238761473;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerRecset._Max;
				}
				IL_AA:
				return this._DynMax;
			}
			set
			{
				short num = (short)1504641024;
				short num2 = num;
				num = (short)1754660865;
				if (num != 0)
				{
				}
				num = (short)70874350;
				short num3 = num;
				num = (short)252474606;
				switch (num3 == num)
				{
				}
				num = (short)1585184768;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170049B7 RID: 18871
		// (get) Token: 0x06009221 RID: 37409 RVA: 0x0089C0A0 File Offset: 0x0089A2A0
		public override int Min
		{
			get
			{
				short num = (short)44433408;
				short num2 = num;
				num = (short)341120689;
				short num3 = num;
				num = (short)90248881;
				switch (num3 == num)
				{
				}
				num = (short)704380929;
				if (num != 0)
				{
				}
				num = (short)10682368;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerRecset._Min;
			}
		}

		// Token: 0x170049B8 RID: 18872
		// (get) Token: 0x06009222 RID: 37410 RVA: 0x0089C150 File Offset: 0x0089A350
		// (set) Token: 0x06009223 RID: 37411 RVA: 0x0089C1FC File Offset: 0x0089A3FC
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1591017472;
				short num2 = num;
				num = (short)2132128018;
				short num3 = num;
				num = (short)1022603538;
				switch (num3 == num)
				{
				}
				num = (short)797048833;
				if (num != 0)
				{
				}
				num = (short)1514471424;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1934491648;
				short num2 = num;
				num = (short)1943309217;
				short num3 = num;
				num = (short)812813217;
				switch (num3 == num)
				{
				}
				num = (short)2011496449;
				if (num != 0)
				{
				}
				num = (short)1831796736;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170049B9 RID: 18873
		// (get) Token: 0x06009224 RID: 37412 RVA: 0x0089C2B0 File Offset: 0x0089A4B0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1830617088;
				short num2 = num;
				num = (short)957211797;
				short num3 = num;
				num = (short)561702037;
				switch (num3 == num)
				{
				}
				num = (short)1071775745;
				if (num != 0)
				{
				}
				num = (short)1657470976;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06009225 RID: 37413 RVA: 0x0089C360 File Offset: 0x0089A560
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)855048192;
			short num2 = num;
			num = (short)1831836440;
			short num3 = num;
			num = (short)1787534104;
			switch (num3 == num)
			{
			}
			num = (short)745865217;
			if (num != 0)
			{
			}
			num = (short)595066880;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInner(this);
		}

		// Token: 0x06009226 RID: 37414 RVA: 0x0089C410 File Offset: 0x0089A610
		internal void SetValues()
		{
			short num = (short)241369088;
			short num2 = num;
			num = (short)1539499909;
			short num3 = num;
			num = (short)337307525;
			switch (num3 == num)
			{
			}
			num = (short)773783553;
			if (num != 0)
			{
			}
			num = (short)95879168;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DTMFCODES;
			base.KeySeed = global::CommonResources.AcgResources.ID_CODE;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06009227 RID: 37415 RVA: 0x0089C4E4 File Offset: 0x0089A6E4
		// Note: this type is marked as 'beforefieldinit'.
		static DTMFCodesInnerRecset()
		{
			short num = (short)973799424;
			short num2 = num;
			num = (short)1512458507;
			short num3 = num;
			num = (short)1604339979;
			switch (num3 == num)
			{
			}
			num = (short)1437007873;
			if (num != 0)
			{
			}
			num = (short)12320768;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerRecset._Min = 1;
		}

		// Token: 0x0400489A RID: 18586
		public static int _MaxPool;

		// Token: 0x0400489B RID: 18587
		public static int _Max;

		// Token: 0x0400489C RID: 18588
		public int _DynMax;

		// Token: 0x0400489D RID: 18589
		public static int _Min;

		// Token: 0x0400489E RID: 18590
		public static int _DefaultRecordCount;
	}
}
