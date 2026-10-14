using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000B2 RID: 178
	public class ReflectionActivator : global::Autofac.Core.Activators.InstanceActivator, global::Autofac.Core.IInstanceActivator, global::System.IDisposable
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x0000C29C File Offset: 0x0000A49C
		public ReflectionActivator(global::System.Type implementationType, global::Autofac.Core.Activators.Reflection.IConstructorFinder constructorFinder, global::Autofac.Core.Activators.Reflection.IConstructorSelector constructorSelector, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> configuredParameters, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> configuredProperties) : base(implementationType)
		{
			if (constructorFinder == null)
			{
				throw new global::System.ArgumentNullException("constructorFinder");
			}
			if (constructorSelector == null)
			{
				throw new global::System.ArgumentNullException("constructorSelector");
			}
			if (configuredParameters == null)
			{
				throw new global::System.ArgumentNullException("configuredParameters");
			}
			if (configuredProperties == null)
			{
				throw new global::System.ArgumentNullException("configuredProperties");
			}
			this._implementationType = implementationType;
			this.ConstructorFinder = constructorFinder;
			this.ConstructorSelector = constructorSelector;
			this._configuredProperties = configuredProperties.ToArray<global::Autofac.Core.Parameter>();
			this._defaultParameters = configuredParameters.Concat(new global::Autofac.Core.Parameter[]
			{
				new global::Autofac.Core.Activators.Reflection.AutowiringParameter(),
				new global::Autofac.Core.Activators.Reflection.DefaultValueParameter()
			}).ToArray<global::Autofac.Core.Parameter>();
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0000C33F File Offset: 0x0000A53F
		public global::Autofac.Core.Activators.Reflection.IConstructorFinder ConstructorFinder { get; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000C347 File Offset: 0x0000A547
		public global::Autofac.Core.Activators.Reflection.IConstructorSelector ConstructorSelector { get; }

		// Token: 0x06000414 RID: 1044 RVA: 0x0000C350 File Offset: 0x0000A550
		public object ActivateInstance(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			if (this._availableConstructors == null)
			{
				object availableConstructorsLock = this._availableConstructorsLock;
				lock (availableConstructorsLock)
				{
					if (this._availableConstructors == null)
					{
						this._availableConstructors = this.ConstructorFinder.FindConstructors(this._implementationType);
					}
				}
			}
			if (this._availableConstructors.Length == 0)
			{
				throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.Reflection.ReflectionActivatorResources.NoConstructorsAvailable, new object[]
				{
					this._implementationType,
					this.ConstructorFinder
				}));
			}
			global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding[] validConstructorBindings = this.GetValidConstructorBindings(context, parameters);
			object obj = this.ConstructorSelector.SelectConstructorBinding(validConstructorBindings, parameters).Instantiate();
			this.InjectProperties(obj, context);
			return obj;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000C428 File Offset: 0x0000A628
		private global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding[] GetValidConstructorBindings(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> enumerable;
			if (!parameters.Any<global::Autofac.Core.Parameter>())
			{
				global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> defaultParameters = this._defaultParameters;
				enumerable = defaultParameters;
			}
			else
			{
				enumerable = ((this._defaultParameters.Length == 0) ? parameters : parameters.Concat(this._defaultParameters));
			}
			global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> availableParameters = enumerable;
			global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding[] array = new global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding[this._availableConstructors.Length];
			for (int i = 0; i < this._availableConstructors.Length; i++)
			{
				array[i] = new global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding(this._availableConstructors[i], availableParameters, context);
			}
			global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding[] array2 = array;
			for (int j = 0; j < array.Length; j++)
			{
				if (!array[j].CanInstantiate)
				{
					array2 = (from cb in array
					where cb.CanInstantiate
					select cb).ToArray<global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding>();
					break;
				}
			}
			if (array2.Length == 0)
			{
				throw new global::Autofac.Core.DependencyResolutionException(this.GetBindingFailureMessage(array));
			}
			return array2;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		private string GetBindingFailureMessage(global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding> constructorBindings)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding constructorParameterBinding in from cb in constructorBindings
			where !cb.CanInstantiate
			select cb)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append(constructorParameterBinding.Description);
			}
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.Reflection.ReflectionActivatorResources.NoConstructorsBindable, new object[]
			{
				this.ConstructorFinder,
				this._implementationType,
				stringBuilder
			});
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000C5A4 File Offset: 0x0000A7A4
		private void InjectProperties(object instance, global::Autofac.IComponentContext context)
		{
			if (this._configuredProperties.Length == 0)
			{
				return;
			}
			global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> list = (from pi in instance.GetType().GetRuntimeProperties()
			where pi.CanWrite
			select pi).ToList<global::System.Reflection.PropertyInfo>();
			foreach (global::Autofac.Core.Parameter parameter in this._configuredProperties)
			{
				foreach (global::System.Reflection.PropertyInfo propertyInfo in list)
				{
					global::System.Reflection.MethodInfo setMethod = propertyInfo.SetMethod;
					global::System.Func<object> func;
					if (setMethod != null && parameter.CanSupplyValue(setMethod.GetParameters().First<global::System.Reflection.ParameterInfo>(), context, out func))
					{
						list.Remove(propertyInfo);
						propertyInfo.SetValue(instance, func(), null);
						break;
					}
				}
			}
		}

		// Token: 0x04000111 RID: 273
		private readonly global::System.Type _implementationType;

		// Token: 0x04000112 RID: 274
		private readonly global::Autofac.Core.Parameter[] _configuredProperties;

		// Token: 0x04000113 RID: 275
		private readonly global::Autofac.Core.Parameter[] _defaultParameters;

		// Token: 0x04000114 RID: 276
		private global::System.Reflection.ConstructorInfo[] _availableConstructors;

		// Token: 0x04000115 RID: 277
		private readonly object _availableConstructorsLock = new object();
	}
}
