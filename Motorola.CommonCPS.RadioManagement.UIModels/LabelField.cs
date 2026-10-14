using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000AE RID: 174
	public class LabelField : global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase, global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit
	{
		// Token: 0x0600068C RID: 1676 RVA: 0x0005F0D4 File Offset: 0x0005D2D4
		public LabelField(string name, bool isVisible)
		{
			base.Name = name;
			this.a = isVisible;
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x0005F0F8 File Offset: 0x0005D2F8
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x0005F1A4 File Offset: 0x0005D3A4
		public string Text
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)652071486;
				short num2 = num;
				num = (short)625726014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1448148992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)792854529;
				if (num != 0)
				{
				}
				num = (short)537722880;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1323819625;
				short num2 = num;
				num = (short)1426776681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1034813440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1817182209;
				if (num != 0)
				{
				}
				num = (short)342032384;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x0005F258 File Offset: 0x0005D458
		public int MaxLength
		{
			get
			{
				short num = (short)1019429951;
				short num2 = num;
				num = (short)1569408063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)220004352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1149763585;
				if (num != 0)
				{
				}
				num = (short)1655177216;
				if (num != 0)
				{
				}
				return 1024;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0005F304 File Offset: 0x0005D504
		public override bool IsEditable
		{
			get
			{
				short num = (short)131149998;
				short num2 = num;
				num = (short)833695918;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1687355392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1168441345;
				if (num != 0)
				{
				}
				num = (short)814481408;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x0005F3AC File Offset: 0x0005D5AC
		public override bool IsVisible
		{
			get
			{
				short num = (short)270534034;
				short num2 = num;
				num = (short)481428882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)727580672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)935133185;
				if (num != 0)
				{
				}
				num = (short)1219231744;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0005F460 File Offset: 0x0005D660
		public override bool IsPasteable
		{
			get
			{
				short num = (short)1066466068;
				short num2 = num;
				num = (short)1530657556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)326238208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)899284992;
				if (num != 0)
				{
				}
				num = (short)244383745;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x0005F50C File Offset: 0x0005D70C
		public override string ValueForCompare
		{
			get
			{
				short num = (short)932359815;
				short num2 = num;
				num = (short)822587015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1250099200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)25034752;
				if (num != 0)
				{
				}
				num = (short)261685249;
				if (num != 0)
				{
				}
				return this.Text;
			}
		}

		// Token: 0x040002C5 RID: 709
		private bool a;

		// Token: 0x040002C6 RID: 710
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;
	}
}
