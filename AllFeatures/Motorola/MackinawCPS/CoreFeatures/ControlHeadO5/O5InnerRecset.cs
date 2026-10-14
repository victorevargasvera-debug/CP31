using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO5
{
	// Token: 0x020003B2 RID: 946
	[global::System.Serializable]
	public class O5InnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600889B RID: 34971 RVA: 0x007F4AEC File Offset: 0x007F2CEC
		public O5InnerRecset() : base(global::CommonResources.AcgResources.ID_O5, global::CommonResources.AcgResources.ID_BUTTON)
		{
			this.SetValues();
		}

		// Token: 0x0600889C RID: 34972 RVA: 0x007F4B10 File Offset: 0x007F2D10
		public O5InnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700455B RID: 17755
		// (get) Token: 0x0600889D RID: 34973 RVA: 0x007F4B3C File Offset: 0x007F2D3C
		public override int MaxPool
		{
			get
			{
				short num = (short)1667432448;
				short num2 = num;
				num = (short)764600891;
				short num3 = num;
				num = (short)716497467;
				switch (num3 == num)
				{
				}
				num = (short)2067267585;
				if (num != 0)
				{
				}
				num = (short)398786560;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset._MaxPool;
			}
		}

		// Token: 0x1700455C RID: 17756
		// (get) Token: 0x0600889E RID: 34974 RVA: 0x007F4BE8 File Offset: 0x007F2DE8
		// (set) Token: 0x0600889F RID: 34975 RVA: 0x007F4CA8 File Offset: 0x007F2EA8
		public override int Max
		{
			get
			{
				short num = (short)1167653008;
				short num2 = num;
				num = (short)1184102544;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1816264705;
					if (num != 0)
					{
					}
					num = (short)1413873664;
					short num3 = num;
					num = (short)1401618432;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					break;
				}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset._Max;
			}
			set
			{
				short num = (short)93388800;
				short num2 = num;
				num = (short)1258772264;
				short num3 = num;
				num = (short)1371166504;
				switch (num3 == num)
				{
				}
				num = (short)2011889664;
				if (num != 0)
				{
				}
				num = (short)1033306113;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700455D RID: 17757
		// (get) Token: 0x060088A0 RID: 34976 RVA: 0x007F4D54 File Offset: 0x007F2F54
		public override int Min
		{
			get
			{
				short num = (short)1758789632;
				short num2 = num;
				num = (short)1172320231;
				short num3 = num;
				num = (short)1994731495;
				switch (num3 == num)
				{
				}
				num = (short)109117440;
				if (num != 0)
				{
				}
				num = (short)1676476417;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset._Min;
			}
		}

		// Token: 0x1700455E RID: 17758
		// (get) Token: 0x060088A1 RID: 34977 RVA: 0x007F4E04 File Offset: 0x007F3004
		// (set) Token: 0x060088A2 RID: 34978 RVA: 0x007F4EB4 File Offset: 0x007F30B4
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2146304000;
				short num2 = num;
				num = (short)1490704402;
				short num3 = num;
				num = (short)1487296530;
				switch (num3 == num)
				{
				}
				num = (short)731185152;
				if (num != 0)
				{
				}
				num = (short)1341587457;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1298989056;
				short num2 = num;
				num = (short)1705574401;
				if (num != 0)
				{
				}
				num = (short)488469901;
				short num3 = num;
				num = (short)350713229;
				switch (num3 == num)
				{
				}
				num = (short)1576140800;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700455F RID: 17759
		// (get) Token: 0x060088A3 RID: 34979 RVA: 0x007F4F64 File Offset: 0x007F3164
		public bool HasDiffs
		{
			get
			{
				short num = (short)783745024;
				short num2 = num;
				num = (short)530984746;
				short num3 = num;
				num = (short)1703292714;
				switch (num3 == num)
				{
				}
				num = (short)753532928;
				if (num != 0)
				{
				}
				num = (short)1884487681;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060088A4 RID: 34980 RVA: 0x007F5014 File Offset: 0x007F3214
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)447479808;
			short num2 = num;
			num = (short)1845231617;
			if (num != 0)
			{
			}
			num = (short)943413871;
			short num3 = num;
			num = (short)866277999;
			switch (num3 == num)
			{
			}
			num = (short)1766391808;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner(this);
		}

		// Token: 0x060088A5 RID: 34981 RVA: 0x007F50C4 File Offset: 0x007F32C4
		internal void SetValues()
		{
			short num = (short)1068040192;
			short num2 = num;
			num = (short)262041574;
			short num3 = num;
			num = (short)1448439782;
			switch (num3 == num)
			{
			}
			num = (short)546242561;
			if (num != 0)
			{
			}
			num = (short)1452081152;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_O5;
			base.KeySeed = global::CommonResources.AcgResources.ID_BUTTON;
			base.DataTransferOrder = 16;
		}

		// Token: 0x060088A6 RID: 34982 RVA: 0x007F5198 File Offset: 0x007F3398
		// Note: this type is marked as 'beforefieldinit'.
		static O5InnerRecset()
		{
			short num = (short)1200685056;
			short num2 = num;
			num = (short)1062141953;
			if (num != 0)
			{
			}
			num = (short)1336543087;
			short num3 = num;
			num = (short)1893468015;
			switch (num3 == num)
			{
			}
			num = (short)387776512;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset._Min = 1;
		}

		// Token: 0x040040DC RID: 16604
		public static int _MaxPool;

		// Token: 0x040040DD RID: 16605
		public static int _Max;

		// Token: 0x040040DE RID: 16606
		public int _DynMax;

		// Token: 0x040040DF RID: 16607
		public static int _Min;

		// Token: 0x040040E0 RID: 16608
		public static int _DefaultRecordCount;
	}
}
