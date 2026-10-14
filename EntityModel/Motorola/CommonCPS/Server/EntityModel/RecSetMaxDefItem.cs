using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000193 RID: 403
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class RecSetMaxDefItem
	{
		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x000E3FDC File Offset: 0x000E21DC
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x000E408C File Offset: 0x000E228C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.HashSet<string> MultipleRecSetNames
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1674383353;
				short num2 = num;
				num = (short)525340665;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2008154112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1075249153;
				if (num != 0)
				{
				}
				num = (short)1237450752;
				if (num != 0)
				{
				}
				return this.<MultipleRecSetNames>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)98062514;
				short num2 = num;
				num = (short)570249394;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2077556736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)323551233;
				if (num != 0)
				{
				}
				num = (short)1445462016;
				if (num != 0)
				{
				}
				this.<MultipleRecSetNames>k__BackingField = value;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x000E413C File Offset: 0x000E233C
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x000E41EC File Offset: 0x000E23EC
		[global::System.Runtime.Serialization.DataMember]
		public int MaxNum
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1421886363;
				short num2 = num;
				num = (short)12862363;
				switch (num2 == num)
				{
				default:
				{
					num = (short)479264768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)343474177;
				if (num != 0)
				{
				}
				num = (short)1313603584;
				if (num != 0)
				{
				}
				return this.<MaxNum>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)888877296;
				short num2 = num;
				num = (short)248787184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)266862592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)378929153;
				if (num != 0)
				{
				}
				num = (short)304021504;
				if (num != 0)
				{
				}
				this.<MaxNum>k__BackingField = value;
			}
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x000E429C File Offset: 0x000E249C
		public override string ToString()
		{
			int a_ = 19;
			short num;
			string text;
			for (;;)
			{
				num = (short)1061355520;
				switch (num)
				{
				default:
				{
					text = string.Empty;
					string str = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("洐", a_);
					using (global::System.Collections.Generic.HashSet<string>.Enumerator enumerator = this.MultipleRecSetNames.GetEnumerator())
					{
						num = (short)544276483;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_FE;
							case 2:
								num = (short)1670053889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_84;
								}
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)246153218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string str2 = enumerator.Current;
								text = text + str + str2;
								num = (short)114491392;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_AE:
							num = (short)1438187524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_84:
							goto IL_AE;
						}
						IL_FE:;
					}
					num = (short)427190969;
					short num3 = num;
					num = (short)2003331769;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_143;
					}
					break;
				}
				}
			}
			IL_143:
			num = (short)1175126016;
			short num4 = num;
			num = (short)55181313;
			if (num != 0)
			{
			}
			num = (short)1804664832;
			if (num != 0)
			{
			}
			return text;
		}
	}
}
