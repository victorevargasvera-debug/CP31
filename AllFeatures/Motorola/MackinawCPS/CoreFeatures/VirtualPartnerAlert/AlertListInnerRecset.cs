using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert
{
	// Token: 0x020001B2 RID: 434
	[global::System.Serializable]
	public class AlertListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06005133 RID: 20787 RVA: 0x0049DCC0 File Offset: 0x0049BEC0
		public AlertListInnerRecset() : base(global::CommonResources.AcgResources.ID_ALERTLIST, global::CommonResources.AcgResources.ID_ALERT)
		{
			this.SetValues();
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x0049DCE4 File Offset: 0x0049BEE4
		public AlertListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x06005135 RID: 20789 RVA: 0x0049DD10 File Offset: 0x0049BF10
		public override int MaxPool
		{
			get
			{
				short num = (short)1410334720;
				short num2 = num;
				num = (short)274100851;
				short num3 = num;
				num = (short)175665779;
				switch (num3 == num)
				{
				}
				num = (short)1740636161;
				if (num != 0)
				{
				}
				num = (short)1885274112;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x06005136 RID: 20790 RVA: 0x0049DDBC File Offset: 0x0049BFBC
		// (set) Token: 0x06005137 RID: 20791 RVA: 0x0049DE7C File Offset: 0x0049C07C
		public override int Max
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)176488449;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						goto IL_AD;
					}
					num = (short)1239318033;
					short num2 = num;
					num = (short)734756369;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_66;
					}
				}
				IL_66:
				num = (short)1387200512;
				if (num != 0)
				{
				}
				num = (short)614662144;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerRecset._Max;
				IL_AD:
				return this._DynMax;
			}
			set
			{
				short num = (short)339345408;
				short num2 = num;
				num = (short)1957375878;
				short num3 = num;
				num = (short)1310535558;
				switch (num3 == num)
				{
				}
				num = (short)2021916673;
				if (num != 0)
				{
				}
				num = (short)1383661568;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x06005138 RID: 20792 RVA: 0x0049DF34 File Offset: 0x0049C134
		public override int Min
		{
			get
			{
				short num = (short)1576992768;
				short num2 = num;
				num = (short)570228737;
				if (num != 0)
				{
				}
				num = (short)540201147;
				short num3 = num;
				num = (short)1400164539;
				switch (num3 == num)
				{
				}
				num = (short)57933824;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerRecset._Min;
			}
		}

		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x06005139 RID: 20793 RVA: 0x0049DFE4 File Offset: 0x0049C1E4
		// (set) Token: 0x0600513A RID: 20794 RVA: 0x0049E090 File Offset: 0x0049C290
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2124021760;
				short num2 = num;
				num = (short)46071809;
				if (num != 0)
				{
				}
				num = (short)178395737;
				short num3 = num;
				num = (short)1249516121;
				switch (num3 == num)
				{
				}
				num = (short)1480130560;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)251002880;
				short num2 = num;
				num = (short)596157480;
				short num3 = num;
				num = (short)754689064;
				switch (num3 == num)
				{
				}
				num = (short)1253048321;
				if (num != 0)
				{
				}
				num = (short)234225664;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x0600513B RID: 20795 RVA: 0x0049E144 File Offset: 0x0049C344
		public bool HasDiffs
		{
			get
			{
				short num = (short)1377959936;
				short num2 = num;
				num = (short)1624948431;
				short num3 = num;
				num = (short)1268498127;
				switch (num3 == num)
				{
				}
				num = (short)1182990337;
				if (num != 0)
				{
				}
				num = (short)168230912;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x0049E1F8 File Offset: 0x0049C3F8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)683474944;
			short num2 = num;
			num = (short)1198476434;
			short num3 = num;
			num = (short)554847378;
			switch (num3 == num)
			{
			}
			num = (short)696123393;
			if (num != 0)
			{
			}
			num = (short)1316225024;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInner(this);
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x0049E2A4 File Offset: 0x0049C4A4
		internal void SetValues()
		{
			short num = (short)1552613377;
			if (num != 0)
			{
			}
			num = (short)1919284997;
			short num2 = num;
			num = (short)938669829;
			switch (num2 == num)
			{
			}
			num = (short)969998336;
			short num3 = num;
			num = (short)366346240;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_ALERTLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_ALERT;
			base.DataTransferOrder = 400;
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x0049E37C File Offset: 0x0049C57C
		// Note: this type is marked as 'beforefieldinit'.
		static AlertListInnerRecset()
		{
			short num = (short)1409744897;
			if (num != 0)
			{
			}
			num = (short)1215346528;
			short num2 = num;
			num = (short)837072736;
			switch (num2 == num)
			{
			}
			num = (short)192086016;
			short num3 = num;
			num = (short)35782656;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerRecset._Min = 1;
		}

		// Token: 0x04001EE3 RID: 7907
		public static int _MaxPool;

		// Token: 0x04001EE4 RID: 7908
		public static int _Max;

		// Token: 0x04001EE5 RID: 7909
		public int _DynMax;

		// Token: 0x04001EE6 RID: 7910
		public static int _Min;

		// Token: 0x04001EE7 RID: 7911
		public static int _DefaultRecordCount;
	}
}
