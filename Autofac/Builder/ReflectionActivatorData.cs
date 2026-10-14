using System;
using System.Collections.Generic;
using Autofac.Core;
using Autofac.Core.Activators.Reflection;

namespace Autofac.Builder
{
	// Token: 0x020000C1 RID: 193
	public class ReflectionActivatorData
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x0000C9F5 File Offset: 0x0000ABF5
		public ReflectionActivatorData(global::System.Type implementer)
		{
			this.ImplementationType = implementer;
			this._constructorFinder = global::Autofac.Builder.ReflectionActivatorData.DefaultConstructorFinder;
			this._constructorSelector = global::Autofac.Builder.ReflectionActivatorData.DefaultConstructorSelector;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0000CA30 File Offset: 0x0000AC30
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x0000CA38 File Offset: 0x0000AC38
		public global::System.Type ImplementationType
		{
			get
			{
				return this._implementer;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this._implementer = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0000CA55 File Offset: 0x0000AC55
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x0000CA5D File Offset: 0x0000AC5D
		public global::Autofac.Core.Activators.Reflection.IConstructorFinder ConstructorFinder
		{
			get
			{
				return this._constructorFinder;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this._constructorFinder = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0000CA74 File Offset: 0x0000AC74
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x0000CA7C File Offset: 0x0000AC7C
		public global::Autofac.Core.Activators.Reflection.IConstructorSelector ConstructorSelector
		{
			get
			{
				return this._constructorSelector;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this._constructorSelector = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0000CA93 File Offset: 0x0000AC93
		public global::System.Collections.Generic.IList<global::Autofac.Core.Parameter> ConfiguredParameters { get; } = new global::System.Collections.Generic.List<global::Autofac.Core.Parameter>();

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0000CA9B File Offset: 0x0000AC9B
		public global::System.Collections.Generic.IList<global::Autofac.Core.Parameter> ConfiguredProperties { get; } = new global::System.Collections.Generic.List<global::Autofac.Core.Parameter>();

		// Token: 0x0400012D RID: 301
		private global::System.Type _implementer;

		// Token: 0x0400012E RID: 302
		private global::Autofac.Core.Activators.Reflection.IConstructorFinder _constructorFinder;

		// Token: 0x0400012F RID: 303
		private global::Autofac.Core.Activators.Reflection.IConstructorSelector _constructorSelector;

		// Token: 0x04000130 RID: 304
		private static readonly global::Autofac.Core.Activators.Reflection.IConstructorFinder DefaultConstructorFinder = new global::Autofac.Core.Activators.Reflection.DefaultConstructorFinder();

		// Token: 0x04000131 RID: 305
		private static readonly global::Autofac.Core.Activators.Reflection.IConstructorSelector DefaultConstructorSelector = new global::Autofac.Core.Activators.Reflection.MostParametersConstructorSelector();
	}
}
