using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001B3 RID: 435
	[global::System.Runtime.Serialization.DataContract]
	public class PCRMVOEntry : global::Motorola.CommonCPS.Server.EntityModel.MVOEntry
	{
		// Token: 0x06001699 RID: 5785 RVA: 0x000F2CCC File Offset: 0x000F0ECC
		public PCRMVOEntry()
		{
			int a_ = 7;
			base..ctor();
			this.AppOptions = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.HOption>();
			this.FlashSize = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䌄欆栈砊攌導砐椒瀔䠖⨘⤚倜", a_);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000F2D08 File Offset: 0x000F0F08
		public override object Clone()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object obj;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)970568214;
					short num3 = num2;
					num2 = (short)821670422;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_EC;
					}
					break;
				}
				case 1:
					if ((obj as global::Motorola.CommonCPS.Server.EntityModel.PCRMVOEntry).AppOptions != null)
					{
						num2 = (short)1696858114;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return obj;
				case 2:
					(obj as global::Motorola.CommonCPS.Server.EntityModel.PCRMVOEntry).AppOptions = this.AppOptions.ToList<global::Motorola.CommonCPS.Server.EntityModel.HOption>();
					num2 = (short)65994752;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_EC:
			num2 = (short)1731330049;
			if (num2 != 0)
			{
			}
			num2 = (short)1730412544;
			if (num2 != 0)
			{
			}
			return obj;
			IL_1C:
			num2 = (short)1140588544;
			short num4 = num2;
			obj = base.Clone();
			num2 = (short)1563820033;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x000F2E44 File Offset: 0x000F1044
		public bool Is32MRepeater()
		{
			int a_ = 17;
			short num = (short)629365129;
			short num2 = num;
			num = (short)424630665;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			case 1:
				break;
			default:
			{
				num = (short)390529024;
				short num3 = num;
				break;
			}
			}
			num = (short)1896022016;
			if (num != 0)
			{
			}
			num = (short)865665025;
			if (num != 0)
			{
			}
			if (this.FlashSize.Equals(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䤎紐爒昔编䨘爚朜稞縠ဢᜤ樦", a_)))
			{
				return true;
			}
			return false;
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x000F2F14 File Offset: 0x000F1114
		public override string IDString
		{
			get
			{
				int a_ = 3;
				short num = (short)384636095;
				short num2 = num;
				num = (short)706155711;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D4;
				case 1:
					break;
				default:
				{
					num = (short)1013055488;
					short num3 = num;
					break;
				}
				}
				num = (short)1888354304;
				if (num != 0)
				{
				}
				num = (short)200867841;
				if (num != 0)
				{
				}
				if (!string.IsNullOrEmpty(this.TanapaNumber))
				{
					return base.ModelNumber + global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("帀", a_) + this.TanapaNumber;
				}
				IL_D4:
				return base.ModelNumber;
			}
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000F2FFC File Offset: 0x000F11FC
		public override void SetFlashSize(string flashSize)
		{
			short num = (short)692322304;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
					return;
				case 2:
					this.FlashSize = flashSize;
					num = (short)116785153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1113522177;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productfamily;
					if (productfamily.Equals(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MatrixRepeater))
					{
						num = (short)217448450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 4:
				{
					num = (short)2105414757;
					short num3 = num;
					num = (short)1437865061;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)206110720;
						if (num != 0)
						{
						}
						num = (short)1573978112;
						short num4 = num;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productfamily = base.Productfamily;
						break;
					}
					}
					num = (short)486473731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_39:
				if (string.IsNullOrEmpty(flashSize))
				{
					break;
				}
				num = (short)625999876;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x000F3174 File Offset: 0x000F1374
		// (set) Token: 0x0600169F RID: 5791 RVA: 0x000F3224 File Offset: 0x000F1424
		[global::System.Runtime.Serialization.DataMember]
		public string TanapaNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)876675072;
				short num2 = num;
				num = (short)355201560;
				short num3 = num;
				num = (short)1464791576;
				switch (num3 == num)
				{
				}
				num = (short)234553345;
				if (num != 0)
				{
				}
				num = (short)1259339776;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)442826752;
				short num2 = num;
				num = (short)1004242570;
				short num3 = num;
				num = (short)1003128458;
				switch (num3 == num)
				{
				}
				num = (short)1126039552;
				if (num != 0)
				{
				}
				num = (short)334692353;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x000F32D4 File Offset: 0x000F14D4
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x000F3384 File Offset: 0x000F1584
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.HOption> AppOptions
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1091895296;
				short num2 = num;
				num = (short)730133314;
				short num3 = num;
				num = (short)2014507842;
				switch (num3 == num)
				{
				}
				num = (short)148635649;
				if (num != 0)
				{
				}
				num = (short)1641807872;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1355350016;
				short num2 = num;
				num = (short)1146171271;
				short num3 = num;
				num = (short)948907911;
				switch (num3 == num)
				{
				}
				num = (short)553320448;
				if (num != 0)
				{
				}
				num = (short)752156673;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x000F3438 File Offset: 0x000F1638
		// (set) Token: 0x060016A3 RID: 5795 RVA: 0x000F34E8 File Offset: 0x000F16E8
		[global::System.Runtime.Serialization.DataMember]
		public string FlashSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1218052096;
				short num2 = num;
				num = (short)1716912562;
				short num3 = num;
				num = (short)1759510962;
				switch (num3 == num)
				{
				}
				num = (short)887554048;
				if (num != 0)
				{
				}
				num = (short)287899649;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)343146496;
				short num2 = num;
				num = (short)410648577;
				if (num != 0)
				{
				}
				num = (short)1504404739;
				short num3 = num;
				num = (short)1075995907;
				switch (num3 == num)
				{
				}
				num = (short)1090846720;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x000F359C File Offset: 0x000F179C
		public override string ToString()
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)25100289;
					if (num2 != 0)
					{
					}
					num2 = (short)1539768320;
					short num3 = num2;
					text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䨐栒└樖䐘怚Ⱌ戞縠堢ᜤ娦椨倪Ḭ刮ሰ䠲Ĵ䨶", a_), new object[]
					{
						base.Productfamily,
						base.ModelNumber,
						this.TanapaNumber,
						base.Version,
						base.Region
					});
					num2 = (short)267714567;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)1761673222;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!string.IsNullOrEmpty(this.TanapaNumber))
					{
						num2 = (short)2071134208;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䨐栒└樖䐘怚Ⱌ戞愠堢ᜤ娦ਨ倪Ḭ刮", a_), new object[]
					{
						base.Productfamily,
						base.ModelNumber,
						base.Version,
						base.Region
					});
					num2 = (short)1008664580;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.HOption>.Enumerator enumerator = base.Options.GetEnumerator();
					num2 = (short)479395848;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_33C;
				case 5:
					if (base.Options != null)
					{
						num2 = (short)2048065537;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 6:
					if (base.Options.Count > 0)
					{
						num2 = (short)1182859267;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 7:
					goto IL_33C;
				case 8:
					try
					{
						num2 = (short)1785200640;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.HOption>.Enumerator enumerator;
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_257;
								}
								continue;
							case 1:
								num2 = (short)1151533058;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
							{
								num2 = (short)1543196932;
								short num4 = num2;
								num2 = (short)1999589636;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_28E;
								default:
									goto IL_316;
								}
								break;
							}
							case 4:
								if (!enumerator.MoveNext())
								{
									num2 = (short)690159617;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_28E;
							}
							IL_259:
							num2 = (short)1876754436;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_257:
							goto IL_259;
							IL_28E:
							global::Motorola.CommonCPS.Server.EntityModel.HOption hoption = enumerator.Current;
							text = text + global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("㨐", a_) + hoption.OptionTag;
							num2 = (short)2093547523;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_316:
						num2 = (short)667746304;
						if (num2 != 0)
						{
						}
						return text;
					}
					finally
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.HOption>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_33C;
				}
				goto IL_3D;
				IL_33C:
				num2 = (short)1511522309;
				num = (int)((global::System.IntPtr)num2);
			}
			return text;
			IL_3D:
			text = string.Empty;
			num2 = (short)627441666;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x04000AA4 RID: 2724
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x04000AA5 RID: 2725
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.HOption> b;

		// Token: 0x04000AA6 RID: 2726
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;
	}
}
