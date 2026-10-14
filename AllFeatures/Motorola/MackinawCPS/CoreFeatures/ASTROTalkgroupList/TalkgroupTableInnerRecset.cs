using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList
{
	// Token: 0x020005E6 RID: 1510
	[global::System.Serializable]
	public class TalkgroupTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600CFBD RID: 53181 RVA: 0x00C14D94 File Offset: 0x00C12F94
		public TalkgroupTableInnerRecset() : base(global::CommonResources.AcgResources.ID_TALKGROUPTABLE, global::CommonResources.AcgResources.ID_TALKGROUP)
		{
			this.SetValues();
		}

		// Token: 0x0600CFBE RID: 53182 RVA: 0x00C14DB8 File Offset: 0x00C12FB8
		public TalkgroupTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17006857 RID: 26711
		// (get) Token: 0x0600CFBF RID: 53183 RVA: 0x00C14DE4 File Offset: 0x00C12FE4
		public override int MaxPool
		{
			get
			{
				short num = (short)448867479;
				short num2 = num;
				num = (short)1477848215;
				switch (num2 == num)
				{
				}
				num = (short)1722089472;
				short num3 = num;
				num = (short)1955135488;
				if (num != 0)
				{
				}
				num = (short)342294529;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17006858 RID: 26712
		// (get) Token: 0x0600CFC0 RID: 53184 RVA: 0x00C14E94 File Offset: 0x00C13094
		// (set) Token: 0x0600CFC1 RID: 53185 RVA: 0x00C14F54 File Offset: 0x00C13154
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax == -1)
				{
					num = (short)1161035777;
					if (num != 0)
					{
					}
					num = (short)1074211261;
					short num2 = num;
					num = (short)335292861;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1400635392;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset._Max;
					}
				}
				num = (short)1615527936;
				short num3 = num;
				return this._DynMax;
			}
			set
			{
				short num = (short)1319107816;
				short num2 = num;
				num = (short)914619624;
				switch (num2 == num)
				{
				}
				num = (short)1834090496;
				short num3 = num;
				num = (short)2136801281;
				if (num != 0)
				{
				}
				num = (short)1420689408;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17006859 RID: 26713
		// (get) Token: 0x0600CFC2 RID: 53186 RVA: 0x00C15004 File Offset: 0x00C13204
		public override int Min
		{
			get
			{
				short num = (short)52203230;
				short num2 = num;
				num = (short)1313902302;
				switch (num2 == num)
				{
				}
				num = (short)941883392;
				short num3 = num;
				num = (short)2015821825;
				if (num != 0)
				{
				}
				num = (short)180224000;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset._Min;
			}
		}

		// Token: 0x1700685A RID: 26714
		// (get) Token: 0x0600CFC3 RID: 53187 RVA: 0x00C150B4 File Offset: 0x00C132B4
		// (set) Token: 0x0600CFC4 RID: 53188 RVA: 0x00C15164 File Offset: 0x00C13364
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1983995798;
				short num2 = num;
				num = (short)1047551894;
				switch (num2 == num)
				{
				}
				num = (short)1950285824;
				short num3 = num;
				num = (short)137953280;
				if (num != 0)
				{
				}
				num = (short)1822097409;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)435921377;
				short num2 = num;
				num = (short)154313185;
				switch (num2 == num)
				{
				}
				num = (short)2061762560;
				short num3 = num;
				num = (short)964034560;
				if (num != 0)
				{
				}
				num = (short)1329725441;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700685B RID: 26715
		// (get) Token: 0x0600CFC5 RID: 53189 RVA: 0x00C15214 File Offset: 0x00C13414
		public bool HasDiffs
		{
			get
			{
				short num = (short)1800488348;
				short num2 = num;
				num = (short)1572226460;
				switch (num2 == num)
				{
				}
				num = (short)1588723712;
				short num3 = num;
				num = (short)1177026561;
				if (num != 0)
				{
				}
				num = (short)1392050176;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600CFC6 RID: 53190 RVA: 0x00C152C4 File Offset: 0x00C134C4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)984154113;
			if (num != 0)
			{
			}
			num = (short)1086814310;
			short num2 = num;
			num = (short)1675524198;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1069023232;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)261292032;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner(this);
		}

		// Token: 0x0600CFC7 RID: 53191 RVA: 0x00C15374 File Offset: 0x00C13574
		internal void SetValues()
		{
			short num = (short)1330472946;
			short num2 = num;
			num = (short)2102880242;
			switch (num2 == num)
			{
			}
			num = (short)2051932160;
			short num3 = num;
			num = (short)185270273;
			if (num != 0)
			{
			}
			num = (short)1489043456;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TALKGROUPTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_TALKGROUP;
			base.DataTransferOrder = 31;
		}

		// Token: 0x0600CFC8 RID: 53192 RVA: 0x00C15448 File Offset: 0x00C13648
		// Note: this type is marked as 'beforefieldinit'.
		static TalkgroupTableInnerRecset()
		{
			short num = (short)711649512;
			short num2 = num;
			num = (short)1145694440;
			switch (num2 == num)
			{
			}
			num = (short)210436096;
			short num3 = num;
			num = (short)1689583617;
			if (num != 0)
			{
			}
			num = (short)473497600;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset._Min = 1;
		}

		// Token: 0x040065AD RID: 26029
		public static int _MaxPool;

		// Token: 0x040065AE RID: 26030
		public static int _Max;

		// Token: 0x040065AF RID: 26031
		public int _DynMax;

		// Token: 0x040065B0 RID: 26032
		public static int _Min;

		// Token: 0x040065B1 RID: 26033
		public static int _DefaultRecordCount;
	}
}
