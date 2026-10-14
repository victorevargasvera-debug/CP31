using System;
using System.Runtime.CompilerServices;
using Infragistics.Windows.DataPresenter;

namespace Motorola.CommonCPS.UI.CellRangeFill.Constraints
{
	// Token: 0x02000031 RID: 49
	public class CellValueStringLengthConstraint : global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint
	{
		// Token: 0x06000113 RID: 275 RVA: 0x0000F884 File Offset: 0x0000DA84
		public CellValueStringLengthConstraint() : this(0, int.MaxValue)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		public CellValueStringLengthConstraint(int minLength, int maxLength)
		{
			int a_ = 6;
			base..ctor();
			if (minLength < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("ꃌꛎ뿐鿒냔맖뻘꿚뗜", a_));
			}
			if (maxLength < minLength)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("ꃌ껎꧐鿒냔맖뻘꿚뗜", a_));
			}
			this.a = minLength;
			this.b = maxLength;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000F900 File Offset: 0x0000DB00
		public int MinLength
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)171587744;
				short num2 = num;
				num = (short)2134784160;
				switch (num2 == num)
				{
				}
				num = (short)311361536;
				short num3 = num;
				num = (short)855441409;
				if (num != 0)
				{
				}
				num = (short)32702464;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000F9B0 File Offset: 0x0000DBB0
		public int MaxLength
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)715671247;
				short num2 = num;
				num = (short)104810191;
				switch (num2 == num)
				{
				}
				num = (short)572325888;
				short num3 = num;
				num = (short)1163264001;
				if (num != 0)
				{
				}
				num = (short)1830289408;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000FA60 File Offset: 0x0000DC60
		public bool IsValid(global::Infragistics.Windows.DataPresenter.Cell cell, out string message)
		{
			int a_ = 4;
			short num;
			if (cell == null)
			{
				num = (short)957945066;
				short num2 = num;
				num = (short)2096305386;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)983891969;
					if (num != 0)
					{
					}
					num = (short)557580288;
					if (num != 0)
					{
					}
					message = string.Empty;
					throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("꣊꣌ꏎ뷐", a_));
				}
			}
			num = (short)1053360128;
			short num3 = num;
			return this.IsValid(cell.Value, out message);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000FB40 File Offset: 0x0000DD40
		public bool IsValid(object value, out string message)
		{
			int a_ = 9;
			short num = (short)33030150;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1600258050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_68;
				case 2:
				{
					int num3;
					if (num3 > this.MaxLength)
					{
						num = (short)2029780995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F8;
				}
				case 3:
					goto IL_9E;
				case 4:
				{
					int num3;
					if (!int.TryParse(value.ToString(), out num3))
					{
						num = (short)1252392967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)233504773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					int num3;
					if (num3 >= this.MinLength)
					{
						num = (short)1234632704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_ED;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 7:
					goto IL_1B2;
				}
				IL_4D:
				if (value == null)
				{
					num = (short)249757697;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)231276545;
					if (num != 0)
					{
					}
					num = (short)584450052;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_68:
			num = (short)341311488;
			short num4 = num;
			message = global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("蛏돑룓ꏕ뷗龎뗛귝샟賡诣鋥죧诩쳫飭釯黱鷳鋵\ud8f7铹觻鏽拿朁瘃", a_);
			return false;
			IL_9E:
			IL_ED:
			num = (short)1924600615;
			short num5 = num;
			num = (short)2097943335;
			switch ((num5 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_68;
			default:
				num = (short)1999962112;
				if (num != 0)
				{
				}
				message = global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("鳏럑뫓뇕곗닙ﳛ럝鏟싡诣鏥鳧쫩菫裭탯胱闳飵鿷鿹", a_);
				return false;
			}
			IL_1B2:
			message = global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("蛏돑룓ꏕ뷗龎뗛귝샟賡诣鋥죧诩쳫飭釯黱鷳鋵\ud8f7铹觻鏽拿朁瘃", a_);
			return false;
			IL_1F8:
			message = string.Empty;
			return true;
		}

		// Token: 0x0400005C RID: 92
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly int a;

		// Token: 0x0400005D RID: 93
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly int b;
	}
}
