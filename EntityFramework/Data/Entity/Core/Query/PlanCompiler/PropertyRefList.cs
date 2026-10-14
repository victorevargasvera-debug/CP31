using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000360 RID: 864
	internal class PropertyRefList
	{
		// Token: 0x06002A12 RID: 10770 RVA: 0x0008823E File Offset: 0x0008643E
		internal PropertyRefList() : this(false)
		{
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00088247 File Offset: 0x00086447
		private PropertyRefList(bool allProps)
		{
			this.m_propertyReferences = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef>();
			if (allProps)
			{
				this.MakeAllProperties();
			}
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x00088263 File Offset: 0x00086463
		private void MakeAllProperties()
		{
			this.m_allProperties = true;
			this.m_propertyReferences.Clear();
			this.m_propertyReferences.Add(global::System.Data.Entity.Core.Query.PlanCompiler.AllPropertyRef.Instance, global::System.Data.Entity.Core.Query.PlanCompiler.AllPropertyRef.Instance);
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x0008828C File Offset: 0x0008648C
		internal void Add(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef property)
		{
			if (this.m_allProperties)
			{
				return;
			}
			if (property is global::System.Data.Entity.Core.Query.PlanCompiler.AllPropertyRef)
			{
				this.MakeAllProperties();
				return;
			}
			this.m_propertyReferences[property] = property;
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000882B4 File Offset: 0x000864B4
		internal void Append(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefs)
		{
			if (this.m_allProperties)
			{
				return;
			}
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef property in propertyRefs.m_propertyReferences.Keys)
			{
				this.Add(property);
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x00088318 File Offset: 0x00086518
		internal bool AllProperties
		{
			get
			{
				return this.m_allProperties;
			}
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x00088320 File Offset: 0x00086520
		internal global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList Clone()
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = new global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList(this.m_allProperties);
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef property in this.m_propertyReferences.Keys)
			{
				propertyRefList.Add(property);
			}
			return propertyRefList;
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00088388 File Offset: 0x00086588
		internal bool Contains(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef p)
		{
			return this.m_allProperties || this.m_propertyReferences.ContainsKey(p);
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06002A1A RID: 10778 RVA: 0x000883A0 File Offset: 0x000865A0
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> Properties
		{
			get
			{
				return this.m_propertyReferences.Keys;
			}
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000883B0 File Offset: 0x000865B0
		public override string ToString()
		{
			string text = "{";
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in this.m_propertyReferences.Keys)
			{
				string str = text;
				global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef2 = propertyRef;
				text = str + ((propertyRef2 != null) ? propertyRef2.ToString() : null) + ",";
			}
			text += "}";
			return text;
		}

		// Token: 0x04000E6F RID: 3695
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> m_propertyReferences;

		// Token: 0x04000E70 RID: 3696
		private bool m_allProperties;

		// Token: 0x04000E71 RID: 3697
		internal static global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList All = new global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList(true);
	}
}
