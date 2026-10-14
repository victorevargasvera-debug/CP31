using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000024 RID: 36
	public class SimpleTouchTreeNode : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x0000DF54 File Offset: 0x0000C154
		public SimpleTouchTreeNode()
		{
			this.a = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.SimpleTouchTreeNode>();
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000DF74 File Offset: 0x0000C174
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000E020 File Offset: 0x0000C220
		public string PackageName
		{
			get
			{
				short num = (short)517039048;
				short num2 = num;
				num = (short)415654856;
				switch (num2 == num)
				{
				}
				num = (short)857014272;
				if (num != 0)
				{
				}
				num = (short)738197504;
				short num3 = num;
				num = (short)1191378945;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1826422784;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						return;
					case 2:
						this.b = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SimpleTouchTreeNode)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SimpleTouchTreeNode.get_PackageName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1407188993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30:
					if (!(this.b != value))
					{
						break;
					}
					num = (short)1613348297;
					short num3 = num;
					num = (short)1605221833;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)2141782016;
						if (num != 0)
						{
						}
						num = (short)1217134592;
						short num4 = num;
						num = (short)1126957057;
						if (num != 0)
						{
						}
						num = (short)878968834;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000E178 File Offset: 0x0000C378
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000E228 File Offset: 0x0000C428
		public string ClassName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1598436439;
				short num2 = num;
				num = (short)630666327;
				switch (num2 == num)
				{
				}
				num = (short)1911357440;
				if (num != 0)
				{
				}
				num = (short)1104674816;
				short num3 = num;
				num = (short)1407516673;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)770710570;
				short num2 = num;
				num = (short)1226251306;
				switch (num2 == num)
				{
				}
				num = (short)867368961;
				if (num != 0)
				{
				}
				num = (short)1679687680;
				short num3 = num;
				num = (short)619315200;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000E2DC File Offset: 0x0000C4DC
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.SimpleTouchTreeNode> TreeViewNodes
		{
			get
			{
				short num = (short)1778806967;
				short num2 = num;
				num = (short)459829431;
				switch (num2 == num)
				{
				}
				num = (short)1949433857;
				if (num != 0)
				{
				}
				num = (short)228196352;
				short num3 = num;
				num = (short)164495360;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000E38C File Offset: 0x0000C58C
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000E43C File Offset: 0x0000C63C
		public bool IsRoot
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1873553021;
				short num2 = num;
				num = (short)1194010237;
				switch (num2 == num)
				{
				}
				num = (short)1490944000;
				if (num != 0)
				{
				}
				num = (short)698482688;
				short num3 = num;
				num = (short)1074528257;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2010447873;
				if (num != 0)
				{
				}
				num = (short)1962614177;
				short num2 = num;
				num = (short)441720225;
				switch (num2 == num)
				{
				}
				num = (short)1777860608;
				short num3 = num;
				num = (short)181927936;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x0400005C RID: 92
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.SimpleTouchTreeNode> a;

		// Token: 0x0400005D RID: 93
		private string b;

		// Token: 0x0400005E RID: 94
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x0400005F RID: 95
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d;
	}
}
