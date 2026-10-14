using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000AE RID: 174
	public class MostParametersConstructorSelector : global::Autofac.Core.Activators.Reflection.IConstructorSelector
	{
		// Token: 0x060003FE RID: 1022 RVA: 0x0000C020 File Offset: 0x0000A220
		public global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding SelectConstructorBinding(global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding[] constructorBindings, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			if (constructorBindings == null)
			{
				throw new global::System.ArgumentNullException("constructorBindings");
			}
			if (constructorBindings.Length == 0)
			{
				throw new global::System.ArgumentOutOfRangeException("constructorBindings");
			}
			if (constructorBindings.Length == 1)
			{
				return constructorBindings[0];
			}
			var source = from binding in constructorBindings
			select new
			{
				Binding = binding,
				ConstructorParameterLength = binding.TargetConstructor.GetParameters().Length
			};
			int maxLength = source.Max(binding => binding.ConstructorParameterLength);
			global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding[] array = (from binding in source
			where binding.ConstructorParameterLength == maxLength
			select binding into ctor
			select ctor.Binding).ToArray<global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding>();
			if (array.Length == 1)
			{
				return array[0];
			}
			throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.Reflection.MostParametersConstructorSelectorResources.UnableToChooseFromMultipleConstructors, new object[]
			{
				maxLength,
				array[0].TargetConstructor.DeclaringType
			}));
		}
	}
}
