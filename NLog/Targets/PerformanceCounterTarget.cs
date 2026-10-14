using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x0200004E RID: 78
	[global::NLog.Targets.Target("PerfCounter")]
	public class PerformanceCounterTarget : global::NLog.Targets.Target, global::NLog.Config.IInstallable
	{
		// Token: 0x060006FD RID: 1789 RVA: 0x0001138B File Offset: 0x0000F58B
		public PerformanceCounterTarget()
		{
			this.CounterType = global::System.Diagnostics.PerformanceCounterType.NumberOfItems32;
			this.IncrementValue = new global::NLog.Layouts.SimpleLayout("1");
			this.InstanceName = string.Empty;
			this.CounterHelp = string.Empty;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000113C4 File Offset: 0x0000F5C4
		public PerformanceCounterTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x000113D3 File Offset: 0x0000F5D3
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x000113DB File Offset: 0x0000F5DB
		public bool AutoCreate { get; set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x000113E4 File Offset: 0x0000F5E4
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x000113EC File Offset: 0x0000F5EC
		[global::NLog.Config.RequiredParameter]
		public string CategoryName { get; set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x000113F5 File Offset: 0x0000F5F5
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x000113FD File Offset: 0x0000F5FD
		[global::NLog.Config.RequiredParameter]
		public string CounterName { get; set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00011406 File Offset: 0x0000F606
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x0001140E File Offset: 0x0000F60E
		public string InstanceName { get; set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00011417 File Offset: 0x0000F617
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x0001141F File Offset: 0x0000F61F
		public string CounterHelp { get; set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00011428 File Offset: 0x0000F628
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x00011430 File Offset: 0x0000F630
		[global::System.ComponentModel.DefaultValue(global::System.Diagnostics.PerformanceCounterType.NumberOfItems32)]
		public global::System.Diagnostics.PerformanceCounterType CounterType { get; set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00011439 File Offset: 0x0000F639
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00011441 File Offset: 0x0000F641
		[global::System.ComponentModel.DefaultValue(1)]
		public global::NLog.Layouts.Layout IncrementValue { get; set; }

		// Token: 0x0600070D RID: 1805 RVA: 0x0001144C File Offset: 0x0000F64C
		public void Install(global::NLog.Config.InstallationContext installationContext)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::NLog.Targets.PerformanceCounterTarget>> dictionary = base.LoggingConfiguration.AllTargets.OfType<global::NLog.Targets.PerformanceCounterTarget>().BucketSort((global::NLog.Targets.PerformanceCounterTarget c) => c.CategoryName);
			string categoryName = this.CategoryName;
			if (dictionary[categoryName].Any((global::NLog.Targets.PerformanceCounterTarget c) => c.created))
			{
				installationContext.Trace("Category '{0}' has already been installed.", new object[]
				{
					categoryName
				});
				return;
			}
			try
			{
				global::System.Diagnostics.PerformanceCounterCategoryType performanceCounterCategoryType;
				global::System.Diagnostics.CounterCreationDataCollection counterCreationDataCollection = global::NLog.Targets.PerformanceCounterTarget.GetCounterCreationDataCollection(dictionary[this.CategoryName], out performanceCounterCategoryType);
				if (global::System.Diagnostics.PerformanceCounterCategory.Exists(categoryName))
				{
					installationContext.Debug("Deleting category '{0}'", new object[]
					{
						categoryName
					});
					global::System.Diagnostics.PerformanceCounterCategory.Delete(categoryName);
				}
				installationContext.Debug("Creating category '{0}' with {1} counter(s) (Type: {2})", new object[]
				{
					categoryName,
					counterCreationDataCollection.Count,
					performanceCounterCategoryType
				});
				foreach (object obj in counterCreationDataCollection)
				{
					global::System.Diagnostics.CounterCreationData counterCreationData = (global::System.Diagnostics.CounterCreationData)obj;
					installationContext.Trace("  Counter: '{0}' Type: ({1}) Help: {2}", new object[]
					{
						counterCreationData.CounterName,
						counterCreationData.CounterType,
						counterCreationData.CounterHelp
					});
				}
				global::System.Diagnostics.PerformanceCounterCategory.Create(categoryName, "Category created by NLog", performanceCounterCategoryType, counterCreationDataCollection);
			}
			catch (global::System.Exception ex)
			{
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
				if (!installationContext.IgnoreFailures)
				{
					installationContext.Error("Error creating category '{0}': {1}", new object[]
					{
						categoryName,
						ex.Message
					});
					throw;
				}
				installationContext.Warning("Error creating category '{0}': {1}", new object[]
				{
					categoryName,
					ex.Message
				});
				if (ex.MustBeRethrown())
				{
					throw;
				}
			}
			finally
			{
				foreach (global::NLog.Targets.PerformanceCounterTarget performanceCounterTarget in dictionary[categoryName])
				{
					performanceCounterTarget.created = true;
				}
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000116BC File Offset: 0x0000F8BC
		public void Uninstall(global::NLog.Config.InstallationContext installationContext)
		{
			string categoryName = this.CategoryName;
			if (global::System.Diagnostics.PerformanceCounterCategory.Exists(categoryName))
			{
				installationContext.Debug("Deleting category '{0}'", new object[]
				{
					categoryName
				});
				global::System.Diagnostics.PerformanceCounterCategory.Delete(categoryName);
				return;
			}
			installationContext.Debug("Category '{0}' does not exist.", new object[]
			{
				categoryName
			});
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00011709 File Offset: 0x0000F909
		public bool? IsInstalled(global::NLog.Config.InstallationContext installationContext)
		{
			if (!global::System.Diagnostics.PerformanceCounterCategory.Exists(this.CategoryName))
			{
				return new bool?(false);
			}
			return new bool?(global::System.Diagnostics.PerformanceCounterCategory.CounterExists(this.CounterName, this.CategoryName));
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00011738 File Offset: 0x0000F938
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			if (this.EnsureInitialized())
			{
				string text = this.IncrementValue.Render(logEvent);
				long value;
				if (long.TryParse(text, out value))
				{
					this.perfCounter.IncrementBy(value);
					return;
				}
				global::NLog.Common.InternalLogger.Error<string, string, string>("PerfCounterTarget(Name={0}): Error incrementing PerfCounter {1}. IncrementValue must be an integer but was <{2}>", base.Name, this.CounterName, text);
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00011789 File Offset: 0x0000F989
		protected override void CloseTarget()
		{
			base.CloseTarget();
			if (this.perfCounter != null)
			{
				this.perfCounter.Close();
				this.perfCounter = null;
			}
			this.initialized = false;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000117B4 File Offset: 0x0000F9B4
		private static global::System.Diagnostics.CounterCreationDataCollection GetCounterCreationDataCollection(global::System.Collections.Generic.IEnumerable<global::NLog.Targets.PerformanceCounterTarget> countersInCategory, out global::System.Diagnostics.PerformanceCounterCategoryType categoryType)
		{
			categoryType = global::System.Diagnostics.PerformanceCounterCategoryType.SingleInstance;
			global::System.Diagnostics.CounterCreationDataCollection counterCreationDataCollection = new global::System.Diagnostics.CounterCreationDataCollection();
			foreach (global::NLog.Targets.PerformanceCounterTarget performanceCounterTarget in countersInCategory)
			{
				if (!string.IsNullOrEmpty(performanceCounterTarget.InstanceName))
				{
					categoryType = global::System.Diagnostics.PerformanceCounterCategoryType.MultiInstance;
				}
				counterCreationDataCollection.Add(new global::System.Diagnostics.CounterCreationData(performanceCounterTarget.CounterName, performanceCounterTarget.CounterHelp, performanceCounterTarget.CounterType));
			}
			return counterCreationDataCollection;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00011830 File Offset: 0x0000FA30
		private bool EnsureInitialized()
		{
			if (!this.initialized)
			{
				this.initialized = true;
				if (this.AutoCreate)
				{
					using (global::NLog.Config.InstallationContext installationContext = new global::NLog.Config.InstallationContext())
					{
						this.Install(installationContext);
					}
				}
				try
				{
					this.perfCounter = new global::System.Diagnostics.PerformanceCounter(this.CategoryName, this.CounterName, this.InstanceName, false);
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Error(ex, "PerfCounterTarget(Name={0}): Cannot open performance counter {1}/{2}/{3}.", new object[]
					{
						base.Name,
						this.CategoryName,
						this.CounterName,
						this.InstanceName
					});
					if (ex.MustBeRethrown())
					{
						throw;
					}
				}
			}
			return this.perfCounter != null;
		}

		// Token: 0x04000157 RID: 343
		private global::System.Diagnostics.PerformanceCounter perfCounter;

		// Token: 0x04000158 RID: 344
		private bool initialized;

		// Token: 0x04000159 RID: 345
		private bool created;
	}
}
