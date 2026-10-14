using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000043 RID: 67
	public class ModuleInfoGroup : global::Microsoft.Practices.Prism.Modularity.IModuleCatalogItem, global::System.Collections.Generic.IList<global::Microsoft.Practices.Prism.Modularity.ModuleInfo>, global::System.Collections.Generic.ICollection<global::Microsoft.Practices.Prism.Modularity.ModuleInfo>, global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x000060DE File Offset: 0x000042DE
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x000060E6 File Offset: 0x000042E6
		public global::Microsoft.Practices.Prism.Modularity.InitializationMode InitializationMode { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x000060EF File Offset: 0x000042EF
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x000060F7 File Offset: 0x000042F7
		public string Ref { get; set; }

		// Token: 0x060001A4 RID: 420 RVA: 0x00006100 File Offset: 0x00004300
		public void Add(global::Microsoft.Practices.Prism.Modularity.ModuleInfo item)
		{
			this.ForwardValues(item);
			this.modules.Add(item);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00006115 File Offset: 0x00004315
		protected void ForwardValues(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentNullException("moduleInfo");
			}
			if (moduleInfo.Ref == null)
			{
				moduleInfo.Ref = this.Ref;
			}
			if (moduleInfo.InitializationMode == global::Microsoft.Practices.Prism.Modularity.InitializationMode.WhenAvailable && this.InitializationMode != global::Microsoft.Practices.Prism.Modularity.InitializationMode.WhenAvailable)
			{
				moduleInfo.InitializationMode = this.InitializationMode;
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00006155 File Offset: 0x00004355
		public void Clear()
		{
			this.modules.Clear();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006162 File Offset: 0x00004362
		public bool Contains(global::Microsoft.Practices.Prism.Modularity.ModuleInfo item)
		{
			return this.modules.Contains(item);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00006170 File Offset: 0x00004370
		public void CopyTo(global::Microsoft.Practices.Prism.Modularity.ModuleInfo[] array, int arrayIndex)
		{
			this.modules.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000617F File Offset: 0x0000437F
		public int Count
		{
			get
			{
				return this.modules.Count;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000618C File Offset: 0x0000438C
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000618F File Offset: 0x0000438F
		public bool Remove(global::Microsoft.Practices.Prism.Modularity.ModuleInfo item)
		{
			return this.modules.Remove(item);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000619D File Offset: 0x0000439D
		public global::System.Collections.Generic.IEnumerator<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> GetEnumerator()
		{
			return this.modules.GetEnumerator();
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000061AA File Offset: 0x000043AA
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000061B2 File Offset: 0x000043B2
		int global::System.Collections.IList.Add(object value)
		{
			this.Add((global::Microsoft.Practices.Prism.Modularity.ModuleInfo)value);
			return 1;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000061C4 File Offset: 0x000043C4
		bool global::System.Collections.IList.Contains(object value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo = value as global::Microsoft.Practices.Prism.Modularity.ModuleInfo;
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentException(global::Microsoft.Practices.Prism.Properties.Resources.ValueMustBeOfTypeModuleInfo, "value");
			}
			return this.Contains(moduleInfo);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00006200 File Offset: 0x00004400
		public int IndexOf(object value)
		{
			return this.modules.IndexOf((global::Microsoft.Practices.Prism.Modularity.ModuleInfo)value);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00006214 File Offset: 0x00004414
		public void Insert(int index, object value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo = value as global::Microsoft.Practices.Prism.Modularity.ModuleInfo;
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentException(global::Microsoft.Practices.Prism.Properties.Resources.ValueMustBeOfTypeModuleInfo, "value");
			}
			this.modules.Insert(index, moduleInfo);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00006256 File Offset: 0x00004456
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00006259 File Offset: 0x00004459
		void global::System.Collections.IList.Remove(object value)
		{
			this.Remove((global::Microsoft.Practices.Prism.Modularity.ModuleInfo)value);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00006268 File Offset: 0x00004468
		public void RemoveAt(int index)
		{
			this.modules.RemoveAt(index);
		}

		// Token: 0x17000048 RID: 72
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (global::Microsoft.Practices.Prism.Modularity.ModuleInfo)value;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000628E File Offset: 0x0000448E
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			((global::System.Collections.ICollection)this.modules).CopyTo(array, index);
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000629D File Offset: 0x0000449D
		public bool IsSynchronized
		{
			get
			{
				return ((global::System.Collections.ICollection)this.modules).IsSynchronized;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000062AA File Offset: 0x000044AA
		public object SyncRoot
		{
			get
			{
				return ((global::System.Collections.ICollection)this.modules).SyncRoot;
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000062B7 File Offset: 0x000044B7
		public int IndexOf(global::Microsoft.Practices.Prism.Modularity.ModuleInfo item)
		{
			return this.modules.IndexOf(item);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000062C5 File Offset: 0x000044C5
		public void Insert(int index, global::Microsoft.Practices.Prism.Modularity.ModuleInfo item)
		{
			this.modules.Insert(index, item);
		}

		// Token: 0x1700004B RID: 75
		public global::Microsoft.Practices.Prism.Modularity.ModuleInfo this[int index]
		{
			get
			{
				return this.modules[index];
			}
			set
			{
				this.modules[index] = value;
			}
		}

		// Token: 0x0400006B RID: 107
		private readonly global::System.Collections.ObjectModel.Collection<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> modules = new global::System.Collections.ObjectModel.Collection<global::Microsoft.Practices.Prism.Modularity.ModuleInfo>();
	}
}
