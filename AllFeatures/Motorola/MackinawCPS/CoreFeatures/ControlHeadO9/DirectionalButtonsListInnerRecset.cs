using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200036B RID: 875
	[global::System.Serializable]
	public class DirectionalButtonsListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060081BF RID: 33215 RVA: 0x0078FD50 File Offset: 0x0078DF50
		public DirectionalButtonsListInnerRecset() : base(global::CommonResources.AcgResources.ID_DIRECTIONALBUTTONS)
		{
			this.SetValues();
		}

		// Token: 0x060081C0 RID: 33216 RVA: 0x0078FD70 File Offset: 0x0078DF70
		public DirectionalButtonsListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004216 RID: 16918
		// (get) Token: 0x060081C1 RID: 33217 RVA: 0x0078FD9C File Offset: 0x0078DF9C
		public override int MaxPool
		{
			get
			{
				short num = (short)2110676447;
				short num2 = num;
				num = (short)427253215;
				switch (num2 == num)
				{
				}
				num = (short)163512321;
				if (num != 0)
				{
				}
				num = (short)1760821248;
				short num3 = num;
				num = (short)1943076864;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004217 RID: 16919
		// (get) Token: 0x060081C2 RID: 33218 RVA: 0x0078FE4C File Offset: 0x0078E04C
		// (set) Token: 0x060081C3 RID: 33219 RVA: 0x0078FF10 File Offset: 0x0078E110
		public override int Max
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)1632043008;
					short num2 = num;
					if (this._DynMax != -1)
					{
						goto IL_B1;
					}
					num = (short)523716112;
					short num3 = num;
					num = (short)1402947088;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6B;
					}
				}
				IL_6B:
				num = (short)1645674497;
				if (num != 0)
				{
				}
				num = (short)1664614400;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset._Max;
				IL_B1:
				return this._DynMax;
			}
			set
			{
				short num = (short)1081743403;
				short num2 = num;
				num = (short)196548651;
				switch (num2 == num)
				{
				}
				num = (short)167903233;
				if (num != 0)
				{
				}
				num = (short)1891434496;
				short num3 = num;
				num = (short)1450508288;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004218 RID: 16920
		// (get) Token: 0x060081C4 RID: 33220 RVA: 0x0078FFC0 File Offset: 0x0078E1C0
		public override int Min
		{
			get
			{
				short num = (short)1959705989;
				short num2 = num;
				num = (short)753319301;
				switch (num2 == num)
				{
				}
				num = (short)1137901569;
				if (num != 0)
				{
				}
				num = (short)1885077504;
				short num3 = num;
				num = (short)892928000;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset._Min;
			}
		}

		// Token: 0x17004219 RID: 16921
		// (get) Token: 0x060081C5 RID: 33221 RVA: 0x00790074 File Offset: 0x0078E274
		// (set) Token: 0x060081C6 RID: 33222 RVA: 0x00790120 File Offset: 0x0078E320
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2140783974;
				short num2 = num;
				num = (short)696108390;
				switch (num2 == num)
				{
				}
				num = (short)834076673;
				if (num != 0)
				{
				}
				num = (short)1648361472;
				short num3 = num;
				num = (short)1279066112;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)2131034069;
				short num2 = num;
				num = (short)449445845;
				switch (num2 == num)
				{
				}
				num = (short)1477705729;
				if (num != 0)
				{
				}
				num = (short)1180041216;
				short num3 = num;
				num = (short)2130247680;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700421A RID: 16922
		// (get) Token: 0x060081C7 RID: 33223 RVA: 0x007901D0 File Offset: 0x0078E3D0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1168179200;
				short num2 = num;
				num = (short)959141173;
				short num3 = num;
				num = (short)1210406197;
				switch (num3 == num)
				{
				}
				num = (short)809238529;
				if (num != 0)
				{
				}
				num = (short)1216872448;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060081C8 RID: 33224 RVA: 0x00790280 File Offset: 0x0078E480
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1977942016;
			short num2 = num;
			num = (short)1562613611;
			short num3 = num;
			num = (short)266180459;
			switch (num3 == num)
			{
			}
			num = (short)1473970176;
			if (num != 0)
			{
			}
			num = (short)378732545;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner(this);
		}

		// Token: 0x060081C9 RID: 33225 RVA: 0x00790330 File Offset: 0x0078E530
		internal void SetValues()
		{
			short num = (short)1320419328;
			short num2 = num;
			num = (short)165347329;
			if (num != 0)
			{
			}
			num = (short)121922672;
			short num3 = num;
			num = (short)531981424;
			switch (num3 == num)
			{
			}
			num = (short)519700480;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTIONALBUTTONS;
			base.DataTransferOrder = 50;
		}

		// Token: 0x060081CA RID: 33226 RVA: 0x007903FC File Offset: 0x0078E5FC
		// Note: this type is marked as 'beforefieldinit'.
		static DirectionalButtonsListInnerRecset()
		{
			short num = (short)1246822400;
			short num2 = num;
			num = (short)332243125;
			short num3 = num;
			num = (short)1068212405;
			switch (num3 == num)
			{
			}
			num = (short)363266048;
			if (num != 0)
			{
			}
			num = (short)1387069441;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset._Min = 1;
		}

		// Token: 0x04003E38 RID: 15928
		public static int _MaxPool;

		// Token: 0x04003E39 RID: 15929
		public static int _Max;

		// Token: 0x04003E3A RID: 15930
		public int _DynMax;

		// Token: 0x04003E3B RID: 15931
		public static int _Min;

		// Token: 0x04003E3C RID: 15932
		public static int _DefaultRecordCount;
	}
}
