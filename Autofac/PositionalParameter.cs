using System;
using System.Reflection;
using Autofac.Core;

namespace Autofac
{
	// Token: 0x02000010 RID: 16
	public class PositionalParameter : global::Autofac.Core.ConstantParameter
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002CA3 File Offset: 0x00000EA3
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002CAB File Offset: 0x00000EAB
		public int Position { get; private set; }

		// Token: 0x06000056 RID: 86 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public PositionalParameter(int position, object value) : base(value, (global::System.Reflection.ParameterInfo pi) => pi.Position == position && pi.Member is global::System.Reflection.ConstructorInfo)
		{
			if (position < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("position");
			}
			this.Position = position;
		}
	}
}
