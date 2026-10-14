using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ToneSignalingList
{
	// Token: 0x020001C6 RID: 454
	[global::System.Serializable]
	public class ToneSignalingListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060052F3 RID: 21235 RVA: 0x004B563C File Offset: 0x004B383C
		public ToneSignalingListRecset() : base(global::CommonResources.AcgResources.ID_TONESIGNALINGLIST, global::CommonResources.AcgResources.ID_TONELIST)
		{
			this.SetValues();
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x004B5660 File Offset: 0x004B3860
		public ToneSignalingListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x060052F5 RID: 21237 RVA: 0x004B568C File Offset: 0x004B388C
		public override int MaxPool
		{
			get
			{
				short num = (short)1049173749;
				short num2 = num;
				num = (short)1686052597;
				switch (num2 == num)
				{
				}
				num = (short)1391525888;
				if (num != 0)
				{
				}
				num = (short)422182913;
				if (num != 0)
				{
				}
				num = (short)2102591488;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset._MaxPool;
			}
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x060052F6 RID: 21238 RVA: 0x004B5738 File Offset: 0x004B3938
		// (set) Token: 0x060052F7 RID: 21239 RVA: 0x004B57F8 File Offset: 0x004B39F8
		public override int Max
		{
			get
			{
				short num = (short)1602093057;
				if (num != 0)
				{
				}
				num = (short)1726021632;
				short num2 = num;
				if (this._DynMax == -1)
				{
					num = (short)1446566231;
					short num3 = num;
					num = (short)1535957335;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)782761984;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset._Max;
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1785724929;
				if (num != 0)
				{
				}
				num = (short)1493668569;
				short num2 = num;
				num = (short)1467847385;
				switch (num2 == num)
				{
				}
				num = (short)1609695232;
				if (num != 0)
				{
				}
				num = (short)1923547136;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x060052F8 RID: 21240 RVA: 0x004B58AC File Offset: 0x004B3AAC
		public bool HasDiffs
		{
			get
			{
				short num = (short)106824009;
				short num2 = num;
				num = (short)1819214153;
				switch (num2 == num)
				{
				}
				num = (short)842792961;
				if (num != 0)
				{
				}
				num = (short)512163840;
				if (num != 0)
				{
				}
				num = (short)1430716416;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x060052F9 RID: 21241 RVA: 0x004B5958 File Offset: 0x004B3B58
		// (set) Token: 0x060052FA RID: 21242 RVA: 0x004B5A08 File Offset: 0x004B3C08
		public override int Min
		{
			get
			{
				short num = (short)2018397840;
				short num2 = num;
				num = (short)1859735184;
				switch (num2 == num)
				{
				}
				num = (short)123338752;
				if (num != 0)
				{
				}
				num = (short)106233857;
				if (num != 0)
				{
				}
				num = (short)956432384;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset._Min;
			}
			set
			{
				short num = (short)1870625097;
				short num2 = num;
				num = (short)2122545481;
				switch (num2 == num)
				{
				}
				num = (short)1678180353;
				if (num != 0)
				{
				}
				num = (short)1337458688;
				if (num != 0)
				{
				}
				num = (short)1296826368;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset._Min = value;
			}
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x004B5AB8 File Offset: 0x004B3CB8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1176822994;
			short num2 = num;
			num = (short)94299346;
			switch (num2 == num)
			{
			}
			num = (short)176816128;
			if (num != 0)
			{
			}
			num = (short)451543041;
			if (num != 0)
			{
			}
			num = (short)104464384;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList(this);
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x004B5B64 File Offset: 0x004B3D64
		internal void SetValues()
		{
			int a_ = 10;
			short num = (short)2107310081;
			if (num != 0)
			{
			}
			num = (short)594539415;
			short num2 = num;
			num = (short)740815767;
			switch (num2 == num)
			{
			}
			num = (short)2026045440;
			if (num != 0)
			{
			}
			num = (short)2088173568;
			short num3 = num;
			this._DynMax = -1;
			base.Id = 4156;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴ꗶ飸鿺铼郾℀䘂眄怆昈攊戌戎砐瀒昔㜖娘琚猜礞䠠䐢値唦䠨弪䐬䀮弰漲愴堶圸帺ᴼ氾⡀⑂⭄♆╈≊⍌⡎煐ၒ㩔㥖㽘㉚㩜⩞፠ɢᅤ๦٨ժㅬ㭮Ṱᵲၴ坶⩸ቺ᩼ᅾꮊ소즔쎖첞좠쒢쮤욦얨슪쎬좮ﶰ\udab2운쎶\ud9ba톼醾맀ꋂ꣄ꯆ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TONESIGNALINGLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_TONELIST;
			base.DataTransferOrder = 1000;
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x004B5C64 File Offset: 0x004B3E64
		// Note: this type is marked as 'beforefieldinit'.
		static ToneSignalingListRecset()
		{
			short num = (short)424584774;
			short num2 = num;
			num = (short)1975166534;
			switch (num2 == num)
			{
			}
			num = (short)1338245120;
			if (num != 0)
			{
			}
			num = (short)895156225;
			if (num != 0)
			{
			}
			num = (short)920518656;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset._Min = 1;
		}

		// Token: 0x04001F9E RID: 8094
		public static int _MaxPool;

		// Token: 0x04001F9F RID: 8095
		public static int _Max;

		// Token: 0x04001FA0 RID: 8096
		public int _DynMax;

		// Token: 0x04001FA1 RID: 8097
		public static int _Min;
	}
}
