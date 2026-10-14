using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000AC RID: 172
	public class MatchingSignatureConstructorSelector : global::Autofac.Core.Activators.Reflection.IConstructorSelector
	{
		// Token: 0x060003F4 RID: 1012 RVA: 0x0000BE54 File Offset: 0x0000A054
		public MatchingSignatureConstructorSelector(params global::System.Type[] signature)
		{
			if (signature == null)
			{
				throw new global::System.ArgumentNullException("signature");
			}
			this._signature = signature;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000BE74 File Offset: 0x0000A074
		public global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding SelectConstructorBinding(global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding[] constructorBindings, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			if (constructorBindings == null)
			{
				throw new global::System.ArgumentNullException("constructorBindings");
			}
			global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding[] array = (from b in constructorBindings
			where (from p in b.TargetConstructor.GetParameters()
			select p.ParameterType).SequenceEqual(this._signature)
			select b).ToArray<global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding>();
			if (array.Length == 1)
			{
				return array[0];
			}
			if (!constructorBindings.Any<global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding>())
			{
				throw new global::System.ArgumentException(global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.AtLeastOneBindingRequired);
			}
			string name = constructorBindings.First<global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding>().TargetConstructor.DeclaringType.Name;
			string text = string.Join(", ", (from t in this._signature
			select t.Name).ToArray<string>());
			if (array.Length == 0)
			{
				throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.RequiredConstructorNotAvailable, new object[]
				{
					name,
					text
				}));
			}
			throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.TooManyConstructorsMatch, new object[]
			{
				text
			}));
		}

		// Token: 0x04000109 RID: 265
		private readonly global::System.Type[] _signature;
	}
}
