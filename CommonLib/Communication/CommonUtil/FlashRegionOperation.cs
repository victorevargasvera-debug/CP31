using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200009A RID: 154
	[global::System.Serializable]
	public class FlashRegionOperation : global::System.ICloneable
	{
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00040C98 File Offset: 0x0003EE98
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00040D48 File Offset: 0x0003EF48
		public global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType RegionType
		{
			get
			{
				short num = (short)1146444898;
				short num2 = num;
				num = (short)1127767138;
				switch (num2 == num)
				{
				}
				num = (short)15597569;
				if (num != 0)
				{
				}
				num = (short)1956052992;
				if (num != 0)
				{
				}
				num = (short)470548480;
				short num3 = num;
				return this._regionType;
			}
			set
			{
				short num = (short)776565865;
				short num2 = num;
				num = (short)83391593;
				switch (num2 == num)
				{
				}
				num = (short)2025652224;
				if (num != 0)
				{
				}
				num = (short)750059521;
				if (num != 0)
				{
				}
				num = (short)1313275904;
				short num3 = num;
				this._regionType = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00040DFC File Offset: 0x0003EFFC
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00040EAC File Offset: 0x0003F0AC
		public global::Motorola.Common.Communication.CommonUtil.FlashOperationType OperationType
		{
			get
			{
				short num = (short)613630953;
				short num2 = num;
				num = (short)239420393;
				switch (num2 == num)
				{
				}
				num = (short)1129709569;
				if (num != 0)
				{
				}
				num = (short)1423572992;
				if (num != 0)
				{
				}
				num = (short)289734656;
				short num3 = num;
				return this._opType;
			}
			set
			{
				short num = (short)280339300;
				short num2 = num;
				num = (short)284074852;
				switch (num2 == num)
				{
				}
				num = (short)1487208448;
				if (num != 0)
				{
				}
				num = (short)1824260097;
				if (num != 0)
				{
				}
				num = (short)877133824;
				short num3 = num;
				this._opType = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00040F5C File Offset: 0x0003F15C
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x0004100C File Offset: 0x0003F20C
		public bool OperationResult
		{
			get
			{
				short num = (short)936826954;
				short num2 = num;
				num = (short)1375656010;
				switch (num2 == num)
				{
				}
				num = (short)197263360;
				if (num != 0)
				{
				}
				num = (short)823918593;
				if (num != 0)
				{
				}
				num = (short)2097020928;
				short num3 = num;
				return this._bOK;
			}
			set
			{
				short num = (short)1114481104;
				short num2 = num;
				num = (short)648847824;
				switch (num2 == num)
				{
				}
				num = (short)1080688641;
				if (num != 0)
				{
				}
				num = (short)1645543424;
				if (num != 0)
				{
				}
				num = (short)869203968;
				short num3 = num;
				this._bOK = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x000410BC File Offset: 0x0003F2BC
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00041168 File Offset: 0x0003F368
		public string FilePathForOperation
		{
			get
			{
				short num = (short)1883689304;
				short num2 = num;
				num = (short)1040240984;
				switch (num2 == num)
				{
				}
				num = (short)478609409;
				if (num != 0)
				{
				}
				num = (short)670564352;
				if (num != 0)
				{
				}
				num = (short)1362493440;
				short num3 = num;
				return this._filePath;
			}
			set
			{
				short num = (short)1053964388;
				short num2 = num;
				num = (short)2102474852;
				switch (num2 == num)
				{
				}
				num = (short)1953038337;
				if (num != 0)
				{
				}
				num = (short)928645120;
				if (num != 0)
				{
				}
				num = (short)8519680;
				short num3 = num;
				this._filePath = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00041218 File Offset: 0x0003F418
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x000412CC File Offset: 0x0003F4CC
		public global::Motorola.Common.Communication.CommonUtil.CommRC ErrorReason
		{
			get
			{
				short num = (short)919856995;
				short num2 = num;
				num = (short)1215162211;
				switch (num2 == num)
				{
				}
				num = (short)1548484609;
				if (num != 0)
				{
				}
				num = (short)940638208;
				if (num != 0)
				{
				}
				num = (short)300482560;
				short num3 = num;
				return this._rcCode;
			}
			set
			{
				short num = (short)875248385;
				short num2 = num;
				num = (short)419379969;
				switch (num2 == num)
				{
				}
				num = (short)869990401;
				if (num != 0)
				{
				}
				num = (short)1443233792;
				if (num != 0)
				{
				}
				num = (short)652148736;
				short num3 = num;
				this._rcCode = value;
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0004137C File Offset: 0x0003F57C
		public object Clone()
		{
			short num = (short)775272752;
			short num2 = num;
			num = (short)1023719728;
			switch (num2 == num)
			{
			}
			num = (short)1765408768;
			if (num != 0)
			{
			}
			num = (short)1728053249;
			if (num != 0)
			{
			}
			num = (short)2052653056;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.FlashRegionOperation flashRegionOperation = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.FlashRegionOperation;
			flashRegionOperation.OperationType = this.OperationType;
			flashRegionOperation.OperationResult = this.OperationResult;
			flashRegionOperation.FilePathForOperation = this.FilePathForOperation;
			flashRegionOperation.RegionType = this.RegionType;
			flashRegionOperation.ErrorReason = this.ErrorReason;
			return flashRegionOperation;
		}

		// Token: 0x040004AE RID: 1198
		private global::Motorola.Common.Communication.CommonUtil.FlashOperationType _opType = global::Motorola.Common.Communication.CommonUtil.FlashOperationType.NONE;

		// Token: 0x040004AF RID: 1199
		private string _filePath = string.Empty;

		// Token: 0x040004B0 RID: 1200
		private bool _bOK = true;

		// Token: 0x040004B1 RID: 1201
		private global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType _regionType = global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.UNKNOWN;

		// Token: 0x040004B2 RID: 1202
		private global::Motorola.Common.Communication.CommonUtil.CommRC _rcCode;
	}
}
