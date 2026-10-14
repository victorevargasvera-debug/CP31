using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000041 RID: 65
	public class ModuleDependencySolver
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00005DA8 File Offset: 0x00003FA8
		public void AddModule(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.StringCannotBeNullOrEmpty, new object[]
				{
					"name"
				}));
			}
			this.AddToDependencyMatrix(name);
			this.AddToKnownModules(name);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00005DF0 File Offset: 0x00003FF0
		public void AddDependency(string dependingModule, string dependentModule)
		{
			if (string.IsNullOrEmpty(dependingModule))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.StringCannotBeNullOrEmpty, new object[]
				{
					"dependingModule"
				}));
			}
			if (string.IsNullOrEmpty(dependentModule))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.StringCannotBeNullOrEmpty, new object[]
				{
					"dependentModule"
				}));
			}
			if (!this.knownModules.Contains(dependingModule))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.DependencyForUnknownModule, new object[]
				{
					dependingModule
				}));
			}
			this.AddToDependencyMatrix(dependentModule);
			this.dependencyMatrix.Add(dependentModule, dependingModule);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00005E9A File Offset: 0x0000409A
		private void AddToDependencyMatrix(string module)
		{
			if (!this.dependencyMatrix.ContainsKey(module))
			{
				this.dependencyMatrix.Add(module);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00005EB6 File Offset: 0x000040B6
		private void AddToKnownModules(string module)
		{
			if (!this.knownModules.Contains(module))
			{
				this.knownModules.Add(module);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00005ED4 File Offset: 0x000040D4
		public string[] Solve()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			while (list.Count < this.dependencyMatrix.Count)
			{
				global::System.Collections.Generic.List<string> list2 = this.FindLeaves(list);
				if (list2.Count == 0 && list.Count < this.dependencyMatrix.Count)
				{
					throw new global::Microsoft.Practices.Prism.Modularity.CyclicDependencyFoundException(global::Microsoft.Practices.Prism.Properties.Resources.CyclicDependencyFound);
				}
				list.AddRange(list2);
			}
			list.Reverse();
			if (list.Count > this.knownModules.Count)
			{
				string text = this.FindMissingModules(list);
				throw new global::Microsoft.Practices.Prism.Modularity.ModularityException(text, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.DependencyOnMissingModule, new object[]
				{
					text
				}));
			}
			return list.ToArray();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00005F7C File Offset: 0x0000417C
		private string FindMissingModules(global::System.Collections.Generic.List<string> skip)
		{
			string text = "";
			foreach (string text2 in skip)
			{
				if (!this.knownModules.Contains(text2))
				{
					text += ", ";
					text += text2;
				}
			}
			return text.Substring(2);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00005FF4 File Offset: 0x000041F4
		public int ModuleCount
		{
			get
			{
				return this.dependencyMatrix.Count;
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00006004 File Offset: 0x00004204
		private global::System.Collections.Generic.List<string> FindLeaves(global::System.Collections.Generic.List<string> skip)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (string text in this.dependencyMatrix.Keys)
			{
				if (!skip.Contains(text))
				{
					int num = 0;
					foreach (string item in this.dependencyMatrix[text])
					{
						if (!skip.Contains(item))
						{
							num++;
						}
					}
					if (num == 0)
					{
						list.Add(text);
					}
				}
			}
			return list;
		}

		// Token: 0x04000066 RID: 102
		private readonly global::Microsoft.Practices.Prism.ListDictionary<string, string> dependencyMatrix = new global::Microsoft.Practices.Prism.ListDictionary<string, string>();

		// Token: 0x04000067 RID: 103
		private readonly global::System.Collections.Generic.List<string> knownModules = new global::System.Collections.Generic.List<string>();
	}
}
