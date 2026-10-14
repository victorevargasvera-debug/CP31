using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000554 RID: 1364
	[global::System.Serializable]
	public class OTACInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600B699 RID: 46745 RVA: 0x00A90084 File Offset: 0x00A8E284
		public OTACInnerRecset() : base(global::CommonResources.AcgResources.ID_OTAC, global::CommonResources.AcgResources.ID_POSITION)
		{
			this.SetValues();
		}

		// Token: 0x0600B69A RID: 46746 RVA: 0x00A900A8 File Offset: 0x00A8E2A8
		public OTACInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17005B86 RID: 23430
		// (get) Token: 0x0600B69B RID: 46747 RVA: 0x00A900D4 File Offset: 0x00A8E2D4
		public override int MaxPool
		{
			get
			{
				short num = (short)1066796612;
				short num2 = num;
				num = (short)1184892484;
				switch (num2 == num)
				{
				}
				num = (short)875757568;
				short num3 = num;
				num = (short)1071448064;
				if (num != 0)
				{
				}
				num = (short)367788033;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerRecset._MaxPool;
			}
		}

		// Token: 0x17005B87 RID: 23431
		// (get) Token: 0x0600B69C RID: 46748 RVA: 0x00A90180 File Offset: 0x00A8E380
		// (set) Token: 0x0600B69D RID: 46749 RVA: 0x00A90244 File Offset: 0x00A8E444
		public override int Max
		{
			get
			{
				while (this._DynMax != -1)
				{
					short num = (short)1839530371;
					short num2 = num;
					num = (short)1391788419;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1211564033;
						if (num != 0)
						{
						}
						num = (short)763625472;
						if (num != 0)
						{
						}
						num = (short)1773010944;
						short num3 = num;
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerRecset._Max;
			}
			set
			{
				short num = (short)2130037423;
				short num2 = num;
				num = (short)648399535;
				switch (num2 == num)
				{
				}
				num = (short)6553600;
				short num3 = num;
				num = (short)2095972353;
				if (num != 0)
				{
				}
				num = (short)436666368;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17005B88 RID: 23432
		// (get) Token: 0x0600B69E RID: 46750 RVA: 0x00A902F4 File Offset: 0x00A8E4F4
		public override int Min
		{
			get
			{
				short num = (short)2098238547;
				short num2 = num;
				num = (short)1985320019;
				switch (num2 == num)
				{
				}
				num = (short)831062016;
				short num3 = num;
				num = (short)853278721;
				if (num != 0)
				{
				}
				num = (short)1848705024;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerRecset._Min;
			}
		}

		// Token: 0x17005B89 RID: 23433
		// (get) Token: 0x0600B69F RID: 46751 RVA: 0x00A903A0 File Offset: 0x00A8E5A0
		// (set) Token: 0x0600B6A0 RID: 46752 RVA: 0x00A9044C File Offset: 0x00A8E64C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1946547145;
				short num2 = num;
				num = (short)1943598025;
				switch (num2 == num)
				{
				}
				num = (short)1791164416;
				short num3 = num;
				num = (short)1485701121;
				if (num != 0)
				{
				}
				num = (short)1461911552;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1965372323;
				short num2 = num;
				num = (short)835924899;
				switch (num2 == num)
				{
				}
				num = (short)1104347136;
				short num3 = num;
				num = (short)796917761;
				if (num != 0)
				{
				}
				num = (short)1080688640;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17005B8A RID: 23434
		// (get) Token: 0x0600B6A1 RID: 46753 RVA: 0x00A904FC File Offset: 0x00A8E6FC
		public bool HasDiffs
		{
			get
			{
				short num = (short)869181386;
				short num2 = num;
				num = (short)2055907274;
				switch (num2 == num)
				{
				}
				num = (short)1256128512;
				short num3 = num;
				num = (short)899350529;
				if (num != 0)
				{
				}
				num = (short)1218052096;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B6A2 RID: 46754 RVA: 0x00A905AC File Offset: 0x00A8E7AC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1519197461;
			short num2 = num;
			num = (short)1951079701;
			switch (num2 == num)
			{
			}
			num = (short)780599296;
			short num3 = num;
			num = (short)29949953;
			if (num != 0)
			{
			}
			num = (short)1364852736;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInner(this);
		}

		// Token: 0x0600B6A3 RID: 46755 RVA: 0x00A9065C File Offset: 0x00A8E85C
		internal void SetValues()
		{
			short num = (short)710206834;
			short num2 = num;
			num = (short)837608818;
			switch (num2 == num)
			{
			}
			num = (short)1230241792;
			short num3 = num;
			num = (short)2022178817;
			if (num != 0)
			{
			}
			num = (short)223936512;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_OTAC;
			base.KeySeed = global::CommonResources.AcgResources.ID_POSITION;
			base.DataTransferOrder = 9;
		}

		// Token: 0x0600B6A4 RID: 46756 RVA: 0x00A90730 File Offset: 0x00A8E930
		// Note: this type is marked as 'beforefieldinit'.
		static OTACInnerRecset()
		{
			short num = (short)1014007284;
			short num2 = num;
			num = (short)1038321140;
			switch (num2 == num)
			{
			}
			num = (short)1128595456;
			short num3 = num;
			num = (short)1292828673;
			if (num != 0)
			{
			}
			num = (short)905773056;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerRecset._Min = 1;
		}

		// Token: 0x040058BE RID: 22718
		public static int _MaxPool;

		// Token: 0x040058BF RID: 22719
		public static int _Max;

		// Token: 0x040058C0 RID: 22720
		public int _DynMax;

		// Token: 0x040058C1 RID: 22721
		public static int _Min;

		// Token: 0x040058C2 RID: 22722
		public static int _DefaultRecordCount;
	}
}
