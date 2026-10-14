using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Util;

namespace Autofac.Features.Variance
{
	// Token: 0x02000027 RID: 39
	public class ContravariantRegistrationSource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00005284 File Offset: 0x00003484
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service, global::System.Func<global::Autofac.Core.Service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration>> registrationAccessor)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (registrationAccessor == null)
			{
				throw new global::System.ArgumentNullException("registrationAccessor");
			}
			global::Autofac.Core.IServiceWithType swt = service as global::Autofac.Core.IServiceWithType;
			int contravariantParameterIndex;
			if (swt == null || !global::Autofac.Features.Variance.ContravariantRegistrationSource.IsCompatibleInterfaceType(swt.ServiceType, out contravariantParameterIndex))
			{
				return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
			}
			global::System.Type[] args = swt.ServiceType.GetTypeInfo().GenericTypeArguments;
			global::System.Type definition = swt.ServiceType.GetGenericTypeDefinition();
			global::System.Type type = args[contravariantParameterIndex];
			if (type.GetTypeInfo().IsValueType)
			{
				return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
			}
			return from r in (from s in global::Autofac.Features.Variance.ContravariantRegistrationSource.GetTypesAssignableFrom(type)
			select global::Autofac.Features.Variance.ContravariantRegistrationSource.SubstituteArrayElementAt(args, s, contravariantParameterIndex) into a
			where definition.IsCompatibleWithGenericParameterConstraints(a)
			select definition.MakeGenericType(a)).SelectMany((global::System.Type v) => registrationAccessor(swt.ChangeType(v)))
			where !r.Metadata.ContainsKey("IsContravariantAdapter")
			select r into vr
			select global::Autofac.Builder.RegistrationBuilder.ForDelegate<object>((global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p) => c.ResolveComponent(vr, p)).Targeting(vr).As(new global::Autofac.Core.Service[]
			{
				service
			}).WithMetadata("IsContravariantAdapter", true).CreateRegistration<object, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000053D9 File Offset: 0x000035D9
		private static global::System.Type[] SubstituteArrayElementAt(global::System.Type[] array, global::System.Type newElement, int index)
		{
			global::System.Type[] array2 = array.ToArray<global::System.Type>();
			array2[index] = newElement;
			return array2;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000053E5 File Offset: 0x000035E5
		private static global::System.Collections.Generic.IEnumerable<global::System.Type> GetTypesAssignableFrom(global::System.Type type)
		{
			return global::Autofac.Features.Variance.ContravariantRegistrationSource.GetBagOfTypesAssignableFrom(type).Distinct<global::System.Type>();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000053F2 File Offset: 0x000035F2
		private static global::System.Collections.Generic.IEnumerable<global::System.Type> GetBagOfTypesAssignableFrom(global::System.Type type)
		{
			global::System.Collections.Generic.IEnumerator<global::System.Type> enumerator;
			if (type.GetTypeInfo().BaseType != null)
			{
				yield return type.GetTypeInfo().BaseType;
				foreach (global::System.Type type2 in global::Autofac.Features.Variance.ContravariantRegistrationSource.GetBagOfTypesAssignableFrom(type.GetTypeInfo().BaseType))
				{
					yield return type2;
				}
				enumerator = null;
			}
			else if (type != typeof(object))
			{
				yield return typeof(object);
			}
			foreach (global::System.Type ifce in type.GetTypeInfo().ImplementedInterfaces)
			{
				if (ifce != type)
				{
					yield return ifce;
					foreach (global::System.Type type3 in global::Autofac.Features.Variance.ContravariantRegistrationSource.GetBagOfTypesAssignableFrom(ifce))
					{
						yield return type3;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Type> enumerator2 = null;
				}
				ifce = null;
			}
			enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00005404 File Offset: 0x00003604
		private static bool IsCompatibleInterfaceType(global::System.Type type, out int contravariantParameterIndex)
		{
			if (type.GetTypeInfo().IsGenericType && type.GetTypeInfo().IsInterface)
			{
				var array = (from cwi in type.GetGenericTypeDefinition().GetTypeInfo().GenericTypeParameters.Select((global::System.Type c, int i) => new
				{
					IsContravariant = ((c.GetTypeInfo().GenericParameterAttributes & global::System.Reflection.GenericParameterAttributes.Contravariant) > global::System.Reflection.GenericParameterAttributes.None),
					Index = i
				})
				where cwi.IsContravariant
				select cwi).ToArray();
				if (array.Length == 1)
				{
					contravariantParameterIndex = array[0].Index;
					return true;
				}
			}
			contravariantParameterIndex = 0;
			return false;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000549F File Offset: 0x0000369F
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0400002C RID: 44
		private const string IsContravariantAdapter = "IsContravariantAdapter";
	}
}
