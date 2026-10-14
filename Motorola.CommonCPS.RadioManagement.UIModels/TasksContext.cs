using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000091 RID: 145
	public class TasksContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0004D988 File Offset: 0x0004BB88
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x0004DA34 File Offset: 0x0004BC34
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> JobContainers
		{
			get
			{
				short num = (short)1007937115;
				short num2 = num;
				num = (short)1750263387;
				switch (num2 == num)
				{
				}
				num = (short)1135542273;
				if (num != 0)
				{
				}
				num = (short)1771110400;
				if (num != 0)
				{
				}
				num = (short)117047296;
				short num3 = num;
				return this.a;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1447952386;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)829882369;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TasksContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TasksContext.get_JobContainers())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)8388609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							return;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_61;
							}
							continue;
						case 3:
							this.a = value;
							num = (short)1064960004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)825502663;
							short num3 = num;
							num = (short)1071262663;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)670760960;
								short num4 = num;
								break;
							}
							}
							num = (short)2086993920;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)329646080;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						}
						IL_61:
						if (value == this.a)
						{
							return;
						}
						num = (short)2000879619;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x04000270 RID: 624
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> a;
	}
}
