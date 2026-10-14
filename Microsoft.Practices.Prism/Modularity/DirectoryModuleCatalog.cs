using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Policy;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000093 RID: 147
	public class DirectoryModuleCatalog : global::Microsoft.Practices.Prism.Modularity.ModuleCatalog
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0000ADFC File Offset: 0x00008FFC
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000AE04 File Offset: 0x00009004
		public string ModulePath { get; set; }

		// Token: 0x060003DF RID: 991 RVA: 0x0000AE48 File Offset: 0x00009048
		protected override void InnerLoad()
		{
			if (string.IsNullOrEmpty(this.ModulePath))
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.ModulePathCannotBeNullOrEmpty);
			}
			if (!global::System.IO.Directory.Exists(this.ModulePath))
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.DirectoryNotFound, new object[]
				{
					this.ModulePath
				}));
			}
			global::System.AppDomain appDomain = this.BuildChildDomain(global::System.AppDomain.CurrentDomain);
			try
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				global::System.Collections.Generic.IEnumerable<string> collection = from global::System.Reflection.Assembly assembly in global::System.AppDomain.CurrentDomain.GetAssemblies()
				where !(assembly is global::System.Reflection.Emit.AssemblyBuilder) && assembly.GetType().FullName != "System.Reflection.Emit.InternalAssemblyBuilder" && !string.IsNullOrEmpty(assembly.Location)
				select assembly.Location;
				list.AddRange(collection);
				global::System.Type typeFromHandle = typeof(global::Microsoft.Practices.Prism.Modularity.DirectoryModuleCatalog.InnerModuleInfoLoader);
				if (typeFromHandle.Assembly != null)
				{
					global::Microsoft.Practices.Prism.Modularity.DirectoryModuleCatalog.InnerModuleInfoLoader innerModuleInfoLoader = (global::Microsoft.Practices.Prism.Modularity.DirectoryModuleCatalog.InnerModuleInfoLoader)appDomain.CreateInstanceFrom(typeFromHandle.Assembly.Location, typeFromHandle.FullName).Unwrap();
					innerModuleInfoLoader.LoadAssemblies(list);
					base.Items.AddRange(innerModuleInfoLoader.GetModuleInfos(this.ModulePath));
				}
			}
			finally
			{
				global::System.AppDomain.Unload(appDomain);
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000AF88 File Offset: 0x00009188
		protected virtual global::System.AppDomain BuildChildDomain(global::System.AppDomain parentDomain)
		{
			if (parentDomain == null)
			{
				throw new global::System.ArgumentNullException("parentDomain");
			}
			global::System.Security.Policy.Evidence securityInfo = new global::System.Security.Policy.Evidence(parentDomain.Evidence);
			global::System.AppDomainSetup setupInformation = parentDomain.SetupInformation;
			return global::System.AppDomain.CreateDomain("DiscoveryRegion", securityInfo, setupInformation);
		}

		// Token: 0x02000094 RID: 148
		private class InnerModuleInfoLoader : global::System.MarshalByRefObject
		{
			// Token: 0x060003E4 RID: 996 RVA: 0x0000B004 File Offset: 0x00009204
			internal global::Microsoft.Practices.Prism.Modularity.ModuleInfo[] GetModuleInfos(string path)
			{
				global::System.IO.DirectoryInfo directory = new global::System.IO.DirectoryInfo(path);
				global::System.ResolveEventHandler value = (object sender, global::System.ResolveEventArgs args) => global::Microsoft.Practices.Prism.Modularity.DirectoryModuleCatalog.InnerModuleInfoLoader.OnReflectionOnlyResolve(args, directory);
				global::System.AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += value;
				global::System.Reflection.Assembly assembly = global::System.AppDomain.CurrentDomain.ReflectionOnlyGetAssemblies().First((global::System.Reflection.Assembly asm) => asm.FullName == typeof(global::Microsoft.Practices.Prism.Modularity.IModule).Assembly.FullName);
				global::System.Type type = assembly.GetType(typeof(global::Microsoft.Practices.Prism.Modularity.IModule).FullName);
				global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> notAllreadyLoadedModuleInfos = global::Microsoft.Practices.Prism.Modularity.DirectoryModuleCatalog.InnerModuleInfoLoader.GetNotAllreadyLoadedModuleInfos(directory, type);
				global::Microsoft.Practices.Prism.Modularity.ModuleInfo[] result = notAllreadyLoadedModuleInfos.ToArray<global::Microsoft.Practices.Prism.Modularity.ModuleInfo>();
				global::System.AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve -= value;
				return result;
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x0000B1C4 File Offset: 0x000093C4
			private static global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> GetNotAllreadyLoadedModuleInfos(global::System.IO.DirectoryInfo directory, global::System.Type IModuleType)
			{
				global::System.Collections.Generic.List<global::System.IO.FileInfo> list = new global::System.Collections.Generic.List<global::System.IO.FileInfo>();
				global::System.Reflection.Assembly[] alreadyLoadedAssemblies = global::System.AppDomain.CurrentDomain.ReflectionOnlyGetAssemblies();
				global::System.Collections.Generic.IEnumerable<global::System.IO.FileInfo> enumerable = from file in directory.GetFiles("*.dll")
				where alreadyLoadedAssemblies.FirstOrDefault((global::System.Reflection.Assembly assembly) => string.Compare(global::System.IO.Path.GetFileName(assembly.Location), file.Name, global::System.StringComparison.OrdinalIgnoreCase) == 0) == null
				select file;
				foreach (global::System.IO.FileInfo fileInfo in enumerable)
				{
					try
					{
						global::System.Reflection.Assembly.ReflectionOnlyLoadFrom(fileInfo.FullName);
						list.Add(fileInfo);
					}
					catch (global::System.BadImageFormatException)
					{
					}
				}
				return list.SelectMany((global::System.IO.FileInfo file) => from t in global::System.Reflection.Assembly.ReflectionOnlyLoadFrom(file.FullName).GetExportedTypes().Where(new global::System.Func<global::System.Type, bool>(IModuleType.IsAssignableFrom))
				where t != IModuleType
				where !t.IsAbstract
				select t into type
				select global::Microsoft.Practices.Prism.Modularity.DirectoryModuleCatalog.InnerModuleInfoLoader.CreateModuleInfo(type));
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x0000B2A4 File Offset: 0x000094A4
			private static global::System.Reflection.Assembly OnReflectionOnlyResolve(global::System.ResolveEventArgs args, global::System.IO.DirectoryInfo directory)
			{
				global::System.Reflection.Assembly assembly = global::System.AppDomain.CurrentDomain.ReflectionOnlyGetAssemblies().FirstOrDefault((global::System.Reflection.Assembly asm) => string.Equals(asm.FullName, args.Name, global::System.StringComparison.OrdinalIgnoreCase));
				if (assembly != null)
				{
					return assembly;
				}
				global::System.Reflection.AssemblyName assemblyName = new global::System.Reflection.AssemblyName(args.Name);
				string text = global::System.IO.Path.Combine(directory.FullName, assemblyName.Name + ".dll");
				if (global::System.IO.File.Exists(text))
				{
					return global::System.Reflection.Assembly.ReflectionOnlyLoadFrom(text);
				}
				return global::System.Reflection.Assembly.ReflectionOnlyLoad(args.Name);
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x0000B334 File Offset: 0x00009534
			internal void LoadAssemblies(global::System.Collections.Generic.IEnumerable<string> assemblies)
			{
				foreach (string assemblyFile in assemblies)
				{
					try
					{
						global::System.Reflection.Assembly.ReflectionOnlyLoadFrom(assemblyFile);
					}
					catch (global::System.IO.FileNotFoundException)
					{
					}
				}
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x0000B3DC File Offset: 0x000095DC
			private static global::Microsoft.Practices.Prism.Modularity.ModuleInfo CreateModuleInfo(global::System.Type type)
			{
				string name = type.Name;
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				bool flag = false;
				global::System.Reflection.CustomAttributeData customAttributeData = global::System.Reflection.CustomAttributeData.GetCustomAttributes(type).FirstOrDefault((global::System.Reflection.CustomAttributeData cad) => cad.Constructor.DeclaringType.FullName == typeof(global::Microsoft.Practices.Prism.Modularity.ModuleAttribute).FullName);
				if (customAttributeData != null)
				{
					foreach (global::System.Reflection.CustomAttributeNamedArgument customAttributeNamedArgument in customAttributeData.NamedArguments)
					{
						string name2 = customAttributeNamedArgument.MemberInfo.Name;
						string a;
						if ((a = name2) != null)
						{
							if (!(a == "ModuleName"))
							{
								if (!(a == "OnDemand"))
								{
									if (a == "StartupLoaded")
									{
										flag = !(bool)customAttributeNamedArgument.TypedValue.Value;
									}
								}
								else
								{
									flag = (bool)customAttributeNamedArgument.TypedValue.Value;
								}
							}
							else
							{
								name = (string)customAttributeNamedArgument.TypedValue.Value;
							}
						}
					}
				}
				global::System.Collections.Generic.IEnumerable<global::System.Reflection.CustomAttributeData> enumerable = from cad in global::System.Reflection.CustomAttributeData.GetCustomAttributes(type)
				where cad.Constructor.DeclaringType.FullName == typeof(global::Microsoft.Practices.Prism.Modularity.ModuleDependencyAttribute).FullName
				select cad;
				foreach (global::System.Reflection.CustomAttributeData customAttributeData2 in enumerable)
				{
					list.Add((string)customAttributeData2.ConstructorArguments[0].Value);
				}
				global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo = new global::Microsoft.Practices.Prism.Modularity.ModuleInfo(name, type.AssemblyQualifiedName)
				{
					InitializationMode = (flag ? global::Microsoft.Practices.Prism.Modularity.InitializationMode.OnDemand : global::Microsoft.Practices.Prism.Modularity.InitializationMode.WhenAvailable),
					Ref = type.Assembly.CodeBase
				};
				moduleInfo.DependsOn.AddRange(list);
				return moduleInfo;
			}
		}
	}
}
