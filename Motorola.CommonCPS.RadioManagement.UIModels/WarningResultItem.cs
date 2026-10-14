using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000026 RID: 38
	public class WarningResultItem : global::Motorola.CommonCPS.RadioManagement.UIModels.RfGuiPath
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x0000E508 File Offset: 0x0000C708
		public WarningResultItem(global::Motorola.CommonCPS.RadioManagement.UIModels.RfGuiPath guiPath, global::Motorola.CommonCPS.RadioManagement.UIModels.MessageType msgType, string errorCode, string description)
		{
			if (guiPath != null)
			{
				base.ArrayFieldPath = guiPath.ArrayFieldPath;
				base.OriginalBLFullPath = guiPath.OriginalBLFullPath;
				base.Type = guiPath.Type;
				base.Path = guiPath.Path;
			}
			this.a = msgType;
			this.b = errorCode;
			this.c = description;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000E580 File Offset: 0x0000C780
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000E630 File Offset: 0x0000C830
		public global::Motorola.CommonCPS.RadioManagement.UIModels.MessageType MessageType
		{
			get
			{
				short num = (short)1924136960;
				short num2 = num;
				num = (short)1515498075;
				short num3 = num;
				num = (short)965454427;
				switch (num3 == num)
				{
				}
				num = (short)1508311040;
				if (num != 0)
				{
				}
				num = (short)409796609;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1699256774;
				short num2 = num;
				num = (short)569612742;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)765591553;
					if (num != 0)
					{
					}
					num = (short)1754595328;
					if (num != 0)
					{
					}
					num = (short)1777139713;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					case 2:
					{
						num = (short)1953234944;
						short num4 = num;
						this.a = value;
						num = (short)373489664;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A5:
					if (value == this.a)
					{
						break;
					}
					num = (short)1109065730;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000E748 File Offset: 0x0000C948
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
		public string Description
		{
			get
			{
				short num = (short)515702784;
				short num2 = num;
				num = (short)733981651;
				short num3 = num;
				num = (short)426159059;
				switch (num3 == num)
				{
				}
				num = (short)730202113;
				if (num != 0)
				{
				}
				num = (short)869335040;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)123731968;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 1:
						return;
					case 2:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.WarningResultItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.WarningResultItem.get_Description())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1967587329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)549912576;
						short num3 = num;
						this.c = value;
						num = (short)1001783300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)1869918261;
						short num4 = num;
						num = (short)481407029;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1744502785;
							if (num != 0)
							{
							}
							num = (short)387055616;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)970719234;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					}
					IL_38:
					if (!(value != this.c))
					{
						break;
					}
					num = (short)784924675;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000E994 File Offset: 0x0000CB94
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x0000EA44 File Offset: 0x0000CC44
		public string ErrorCode
		{
			get
			{
				short num = (short)1036320768;
				short num2 = num;
				num = (short)1393455245;
				short num3 = num;
				num = (short)1793552525;
				switch (num3 == num)
				{
				}
				num = (short)1095303168;
				if (num != 0)
				{
				}
				num = (short)1484587009;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)664400779;
				short num2 = num;
				num = (short)1710683019;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1999503360;
					if (num != 0)
					{
					}
					num = (short)819789825;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 2:
					{
						num = (short)155713537;
						if (num != 0)
						{
						}
						num = (short)1869938688;
						short num4 = num;
						this.b = value;
						num = (short)1465843712;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_7C:
					if (!(value != this.b))
					{
						break;
					}
					num = (short)1382809602;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x04000060 RID: 96
		private global::Motorola.CommonCPS.RadioManagement.UIModels.MessageType a;

		// Token: 0x04000061 RID: 97
		private string b = string.Empty;

		// Token: 0x04000062 RID: 98
		private string c = string.Empty;
	}
}
