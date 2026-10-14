using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic
{
	// Token: 0x020002DC RID: 732
	[global::System.Serializable]
	public class RSMButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600780C RID: 30732 RVA: 0x006D0778 File Offset: 0x006CE978
		public RSMButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_ACCESSORYBUTTONSTABLE, global::CommonResources.AcgResources.ID_ACCESSORY)
		{
			this.SetValues();
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x006D079C File Offset: 0x006CE99C
		public RSMButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x0600780E RID: 30734 RVA: 0x006D07C8 File Offset: 0x006CE9C8
		public override int MaxPool
		{
			get
			{
				short num = (short)1776401397;
				short num2 = num;
				num = (short)807058421;
				switch (num2 == num)
				{
				}
				num = (short)1230241792;
				if (num != 0)
				{
				}
				num = (short)606076928;
				short num3 = num;
				num = (short)954466305;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x0600780F RID: 30735 RVA: 0x006D0874 File Offset: 0x006CEA74
		// (set) Token: 0x06007810 RID: 30736 RVA: 0x006D0934 File Offset: 0x006CEB34
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)254935040;
					short num2 = num;
				}
				else
				{
					short num = (short)181731329;
					if (num != 0)
					{
					}
					num = (short)255645729;
					short num3 = num;
					num = (short)1080875041;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)633143296;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset._Max;
			}
			set
			{
				short num = (short)2002770075;
				short num2 = num;
				num = (short)560257179;
				switch (num2 == num)
				{
				}
				num = (short)241631233;
				if (num != 0)
				{
				}
				num = (short)159449088;
				short num3 = num;
				num = (short)30932992;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x06007811 RID: 30737 RVA: 0x006D09E4 File Offset: 0x006CEBE4
		public override int Min
		{
			get
			{
				short num = (short)1384841217;
				if (num != 0)
				{
				}
				num = (short)1748988116;
				short num2 = num;
				num = (short)149516500;
				switch (num2 == num)
				{
				}
				num = (short)535429120;
				short num3 = num;
				num = (short)909049856;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset._Min;
			}
		}

		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x06007812 RID: 30738 RVA: 0x006D0A98 File Offset: 0x006CEC98
		// (set) Token: 0x06007813 RID: 30739 RVA: 0x006D0B44 File Offset: 0x006CED44
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)485900084;
				short num2 = num;
				num = (short)1156464436;
				switch (num2 == num)
				{
				}
				num = (short)1780350976;
				if (num != 0)
				{
				}
				num = (short)685506560;
				short num3 = num;
				num = (short)485752833;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1850919134;
				short num2 = num;
				num = (short)215533790;
				switch (num2 == num)
				{
				}
				num = (short)2025848833;
				if (num != 0)
				{
				}
				num = (short)749469696;
				short num3 = num;
				num = (short)803995648;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x06007814 RID: 30740 RVA: 0x006D0BF8 File Offset: 0x006CEDF8
		public bool HasDiffs
		{
			get
			{
				short num = (short)485961010;
				short num2 = num;
				num = (short)370158898;
				switch (num2 == num)
				{
				}
				num = (short)844693505;
				if (num != 0)
				{
				}
				num = (short)570884096;
				short num3 = num;
				num = (short)1217134592;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x006D0CA8 File Offset: 0x006CEEA8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1667288333;
			short num2 = num;
			num = (short)916507917;
			switch (num2 == num)
			{
			}
			num = (short)1247019009;
			if (num != 0)
			{
			}
			num = (short)1764425728;
			short num3 = num;
			num = (short)823787520;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner(this);
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x006D0D5C File Offset: 0x006CEF5C
		internal void SetValues()
		{
			short num = (short)923640558;
			short num2 = num;
			num = (short)622502638;
			switch (num2 == num)
			{
			}
			num = (short)470614016;
			if (num != 0)
			{
			}
			num = (short)2077229056;
			short num3 = num;
			num = (short)348192769;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_ACCESSORYBUTTONSTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_ACCESSORY;
			base.DataTransferOrder = 21;
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x006D0E30 File Offset: 0x006CF030
		// Note: this type is marked as 'beforefieldinit'.
		static RSMButtonInnerRecset()
		{
			short num = (short)2005370366;
			short num2 = num;
			num = (short)316114430;
			switch (num2 == num)
			{
			}
			num = (short)506724352;
			if (num != 0)
			{
			}
			num = (short)643891200;
			short num3 = num;
			num = (short)564068353;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset._Min = 1;
		}

		// Token: 0x040032F6 RID: 13046
		public static int _MaxPool;

		// Token: 0x040032F7 RID: 13047
		public static int _Max;

		// Token: 0x040032F8 RID: 13048
		public int _DynMax;

		// Token: 0x040032F9 RID: 13049
		public static int _Min;

		// Token: 0x040032FA RID: 13050
		public static int _DefaultRecordCount;
	}
}
