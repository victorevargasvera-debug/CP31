using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert
{
	// Token: 0x020001B9 RID: 441
	[global::System.Serializable]
	public class VirtualPartnerAlertRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060051B0 RID: 20912 RVA: 0x004A489C File Offset: 0x004A2A9C
		public VirtualPartnerAlertRecset() : base(global::CommonResources.AcgResources.ID_VIRTUALPARTNERALERT, global::CommonResources.AcgResources.ID_VPALERT)
		{
			this.SetValues();
		}

		// Token: 0x060051B1 RID: 20913 RVA: 0x004A48C0 File Offset: 0x004A2AC0
		public VirtualPartnerAlertRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x004A48EC File Offset: 0x004A2AEC
		public override int MaxPool
		{
			get
			{
				short num = (short)856916864;
				short num2 = num;
				num = (short)800293760;
				switch (num2 == num)
				{
				}
				num = (short)1499201536;
				short num3 = num;
				num = (short)1195966465;
				if (num != 0)
				{
				}
				num = (short)1217986560;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlertRecset._MaxPool;
			}
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x060051B3 RID: 20915 RVA: 0x004A4998 File Offset: 0x004A2B98
		// (set) Token: 0x060051B4 RID: 20916 RVA: 0x004A4A58 File Offset: 0x004A2C58
		public override int Max
		{
			get
			{
				short num;
				while (this._DynMax == -1)
				{
					num = (short)751181445;
					short num2 = num;
					num = (short)334634629;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)405405696;
						if (num != 0)
						{
						}
						num = (short)371130369;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlertRecset._Max;
					}
				}
				num = (short)1195835392;
				short num3 = num;
				return this._DynMax;
			}
			set
			{
				short num = (short)1173650262;
				short num2 = num;
				num = (short)1241021270;
				switch (num2 == num)
				{
				}
				num = (short)1434910720;
				short num3 = num;
				num = (short)1742209025;
				if (num != 0)
				{
				}
				num = (short)925499392;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x060051B5 RID: 20917 RVA: 0x004A4B08 File Offset: 0x004A2D08
		public bool HasDiffs
		{
			get
			{
				short num = (short)336044727;
				short num2 = num;
				num = (short)1535025847;
				switch (num2 == num)
				{
				}
				num = (short)181338112;
				short num3 = num;
				num = (short)2031812609;
				if (num != 0)
				{
				}
				num = (short)488243200;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x060051B6 RID: 20918 RVA: 0x004A4BB8 File Offset: 0x004A2DB8
		// (set) Token: 0x060051B7 RID: 20919 RVA: 0x004A4C64 File Offset: 0x004A2E64
		public override int Min
		{
			get
			{
				short num = (short)2036693207;
				short num2 = num;
				num = (short)548960471;
				switch (num2 == num)
				{
				}
				num = (short)937295872;
				short num3 = num;
				num = (short)1376190465;
				if (num != 0)
				{
				}
				num = (short)2000879616;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlertRecset._Min;
			}
			set
			{
				short num = (short)761017183;
				short num2 = num;
				num = (short)1085223775;
				switch (num2 == num)
				{
				}
				num = (short)273547264;
				short num3 = num;
				num = (short)1688010752;
				if (num != 0)
				{
				}
				num = (short)1047527425;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlertRecset._Min = value;
			}
		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x004A4D14 File Offset: 0x004A2F14
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1825922842;
			short num2 = num;
			num = (short)1877303066;
			switch (num2 == num)
			{
			}
			num = (short)2073755649;
			if (num != 0)
			{
			}
			num = (short)1003094016;
			if (num != 0)
			{
			}
			num = (short)1190789120;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlert(this);
		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x004A4DC8 File Offset: 0x004A2FC8
		internal void SetValues()
		{
			int a_ = 5;
			short num = (short)526974977;
			if (num != 0)
			{
			}
			num = (short)1310071400;
			short num2 = num;
			num = (short)845355624;
			switch (num2 == num)
			{
			}
			num = (short)2127233024;
			if (num != 0)
			{
			}
			num = (short)1074266112;
			short num3 = num;
			this._DynMax = -1;
			base.Id = 4231;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蟅꓇ꛉ請ꯍ뇏ꛑꇓꓕ뷗꧙鷝迟迡铣觥蛧迩苫髭곯ꃱ闳鋵釷闹\udcfb믽狿攁欃栅朇有攋洍挏㈑圓礕瘗簙甛礝唟倡䔣別䄧䔩䈫爭是嬱䘳䈵䴷嬹倻ḽဿ⍁㙃㉅♇⽉㹋湍ᅏ㹑ㅓ⑕ⱗٙਜ਼㝝቟ᙡᅣݥѧ㩩൫ᱭѯᱱᅳѵ㥷ᙹ᥻౽횁ꚇﲏ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_VIRTUALPARTNERALERT;
			base.KeySeed = global::CommonResources.AcgResources.ID_VPALERT;
			base.DataTransferOrder = 400;
		}

		// Token: 0x060051BA RID: 20922 RVA: 0x004A4ECC File Offset: 0x004A30CC
		// Note: this type is marked as 'beforefieldinit'.
		static VirtualPartnerAlertRecset()
		{
			short num = (short)439286370;
			short num2 = num;
			num = (short)2038233698;
			switch (num2 == num)
			{
			}
			num = (short)13107200;
			if (num != 0)
			{
			}
			num = (short)145293313;
			if (num != 0)
			{
			}
			num = (short)1643642880;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlertRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlertRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlertRecset._Min = 1;
		}

		// Token: 0x04001F16 RID: 7958
		public static int _MaxPool;

		// Token: 0x04001F17 RID: 7959
		public static int _Max;

		// Token: 0x04001F18 RID: 7960
		public int _DynMax;

		// Token: 0x04001F19 RID: 7961
		public static int _Min;
	}
}
