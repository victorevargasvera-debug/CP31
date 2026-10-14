using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005C7 RID: 1479
	[global::System.Serializable]
	public class OneTouchInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600C893 RID: 51347 RVA: 0x00BB73E0 File Offset: 0x00BB55E0
		public OneTouchInnerRecset() : base(global::CommonResources.AcgResources.ID_CONVENTIONALONETOUCH, global::CommonResources.AcgResources.ID_BUTTON)
		{
			this.SetValues();
		}

		// Token: 0x0600C894 RID: 51348 RVA: 0x00BB7404 File Offset: 0x00BB5604
		public OneTouchInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700649B RID: 25755
		// (get) Token: 0x0600C895 RID: 51349 RVA: 0x00BB7430 File Offset: 0x00BB5630
		public override int MaxPool
		{
			get
			{
				short num = (short)1759500897;
				short num2 = num;
				num = (short)408803937;
				switch (num2 == num)
				{
				}
				num = (short)1908998145;
				if (num != 0)
				{
				}
				num = (short)905248768;
				short num3 = num;
				num = (short)1705967616;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700649C RID: 25756
		// (get) Token: 0x0600C896 RID: 51350 RVA: 0x00BB74E0 File Offset: 0x00BB56E0
		// (set) Token: 0x0600C897 RID: 51351 RVA: 0x00BB75A0 File Offset: 0x00BB57A0
		public override int Max
		{
			get
			{
				short num = (short)274167553;
				short num2 = num;
				num = (short)937195265;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1864564737;
					if (num != 0)
					{
					}
					num = (short)543752192;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					num = (short)552927232;
					short num3 = num;
					break;
				}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset._Max;
			}
			set
			{
				short num = (short)259926076;
				short num2 = num;
				num = (short)1463756860;
				switch (num2 == num)
				{
				}
				num = (short)1875443713;
				if (num != 0)
				{
				}
				num = (short)1861222400;
				short num3 = num;
				num = (short)1189281792;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700649D RID: 25757
		// (get) Token: 0x0600C898 RID: 51352 RVA: 0x00BB7650 File Offset: 0x00BB5850
		public override int Min
		{
			get
			{
				short num = (short)136048117;
				short num2 = num;
				num = (short)1400892917;
				switch (num2 == num)
				{
				}
				num = (short)925827072;
				if (num != 0)
				{
				}
				num = (short)754974720;
				short num3 = num;
				num = (short)893452289;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset._Min;
			}
		}

		// Token: 0x1700649E RID: 25758
		// (get) Token: 0x0600C899 RID: 51353 RVA: 0x00BB7700 File Offset: 0x00BB5900
		// (set) Token: 0x0600C89A RID: 51354 RVA: 0x00BB77B0 File Offset: 0x00BB59B0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1223666566;
				short num2 = num;
				num = (short)1501604742;
				switch (num2 == num)
				{
				}
				num = (short)843579393;
				if (num != 0)
				{
				}
				num = (short)1983840256;
				short num3 = num;
				num = (short)1902313472;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)520530188;
				short num2 = num;
				num = (short)410364172;
				switch (num2 == num)
				{
				}
				num = (short)155451393;
				if (num != 0)
				{
				}
				num = (short)257949696;
				short num3 = num;
				num = (short)759103488;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700649F RID: 25759
		// (get) Token: 0x0600C89B RID: 51355 RVA: 0x00BB7860 File Offset: 0x00BB5A60
		public bool HasDiffs
		{
			get
			{
				short num = (short)70838072;
				short num2 = num;
				num = (short)1139992376;
				switch (num2 == num)
				{
				}
				num = (short)1140654081;
				if (num != 0)
				{
				}
				num = (short)790626304;
				short num3 = num;
				num = (short)480509952;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600C89C RID: 51356 RVA: 0x00BB7910 File Offset: 0x00BB5B10
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)790036481;
			if (num != 0)
			{
			}
			num = (short)1352043590;
			short num2 = num;
			num = (short)1786088518;
			switch (num2 == num)
			{
			}
			num = (short)367788032;
			short num3 = num;
			num = (short)77594624;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner(this);
		}

		// Token: 0x0600C89D RID: 51357 RVA: 0x00BB79C4 File Offset: 0x00BB5BC4
		internal void SetValues()
		{
			short num = (short)544374173;
			short num2 = num;
			num = (short)1169063325;
			switch (num2 == num)
			{
			}
			num = (short)1225457665;
			if (num != 0)
			{
			}
			num = (short)1148715008;
			short num3 = num;
			num = (short)222429184;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALONETOUCH;
			base.KeySeed = global::CommonResources.AcgResources.ID_BUTTON;
			base.DataTransferOrder = 44;
		}

		// Token: 0x0600C89E RID: 51358 RVA: 0x00BB7A98 File Offset: 0x00BB5C98
		// Note: this type is marked as 'beforefieldinit'.
		static OneTouchInnerRecset()
		{
			short num = (short)2034487951;
			short num2 = num;
			num = (short)322228879;
			switch (num2 == num)
			{
			}
			num = (short)827523073;
			if (num != 0)
			{
			}
			num = (short)685834240;
			short num3 = num;
			num = (short)890503168;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset._Min = 1;
		}

		// Token: 0x040064BE RID: 25790
		public static int _MaxPool;

		// Token: 0x040064BF RID: 25791
		public static int _Max;

		// Token: 0x040064C0 RID: 25792
		public int _DynMax;

		// Token: 0x040064C1 RID: 25793
		public static int _Min;

		// Token: 0x040064C2 RID: 25794
		public static int _DefaultRecordCount;
	}
}
