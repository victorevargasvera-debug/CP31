using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000022 RID: 34
	public class FillOperationWarningItem : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x0000D98C File Offset: 0x0000BB8C
		public FillOperationWarningItem(string guiPath, string message)
		{
			this.a = guiPath;
			this.b = message;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000DA5C File Offset: 0x0000BC5C
		public string GUIPath
		{
			get
			{
				short num = (short)119886980;
				short num2 = num;
				num = (short)1926976644;
				switch (num2 == num)
				{
				}
				num = (short)859832320;
				if (num != 0)
				{
				}
				num = (short)1846280192;
				short num3 = num;
				num = (short)330104833;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1036451841;
				if (num != 0)
				{
				}
				num = (short)357105664;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_56;
						}
						continue;
					case 1:
						return;
					case 2:
						this.a = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FillOperationWarningItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.FillOperationWarningItem.get_GUIPath())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1333067777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_56:
					if (!(value != this.a))
					{
						break;
					}
					num = (short)1026974834;
					short num3 = num;
					num = (short)1529111666;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1276116992;
						short num4 = num;
						num = (short)212860928;
						if (num != 0)
						{
						}
						num = (short)1584136194;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000DBB4 File Offset: 0x0000BDB4
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000DC64 File Offset: 0x0000BE64
		public string Message
		{
			get
			{
				short num = (short)1651271890;
				short num2 = num;
				num = (short)1399417042;
				switch (num2 == num)
				{
				}
				num = (short)124321793;
				if (num != 0)
				{
				}
				num = (short)215023616;
				short num3 = num;
				num = (short)743768064;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)806682624;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
						goto IL_123;
					case 2:
						this.b = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FillOperationWarningItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.FillOperationWarningItem.get_Message())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2076311553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_31:
					if (!(value != this.b))
					{
						return;
					}
					num = (short)1725742554;
					short num3 = num;
					num = (short)943570394;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1879441408;
						if (num != 0)
						{
						}
						num = (short)320077824;
						short num4 = num;
						num = (short)1236074498;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_123:
				num = (short)267059201;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x04000057 RID: 87
		private string a;

		// Token: 0x04000058 RID: 88
		private string b;
	}
}
