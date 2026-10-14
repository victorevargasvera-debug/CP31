using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000484 RID: 1156
	[global::System.Serializable]
	internal class RelationshipNavigation
	{
		// Token: 0x06003936 RID: 14646 RVA: 0x000BC784 File Offset: 0x000BA984
		internal RelationshipNavigation(string relationshipName, string from, string to, global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor fromAccessor, global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor toAccessor)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(relationshipName, "relationshipName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(from, "from");
			global::System.Data.Entity.Utilities.Check.NotEmpty(to, "to");
			this._relationshipName = relationshipName;
			this._from = from;
			this._to = to;
			this._fromAccessor = fromAccessor;
			this._toAccessor = toAccessor;
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x000BC7E0 File Offset: 0x000BA9E0
		internal RelationshipNavigation(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, string from, string to, global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor fromAccessor, global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor toAccessor)
		{
			this._associationType = associationType;
			this._relationshipName = associationType.FullName;
			this._from = from;
			this._to = to;
			this._fromAccessor = fromAccessor;
			this._toAccessor = toAccessor;
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x000BC819 File Offset: 0x000BAA19
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationType AssociationType
		{
			get
			{
				return this._associationType;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x000BC821 File Offset: 0x000BAA21
		internal string RelationshipName
		{
			get
			{
				return this._relationshipName;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600393A RID: 14650 RVA: 0x000BC829 File Offset: 0x000BAA29
		internal string From
		{
			get
			{
				return this._from;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x0600393B RID: 14651 RVA: 0x000BC831 File Offset: 0x000BAA31
		internal string To
		{
			get
			{
				return this._to;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x0600393C RID: 14652 RVA: 0x000BC839 File Offset: 0x000BAA39
		internal global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor ToPropertyAccessor
		{
			get
			{
				return this._toAccessor;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x0600393D RID: 14653 RVA: 0x000BC841 File Offset: 0x000BAA41
		internal bool IsInitialized
		{
			get
			{
				return this._toAccessor != null && this._fromAccessor != null;
			}
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x000BC856 File Offset: 0x000BAA56
		internal void InitializeAccessors(global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor fromAccessor, global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor toAccessor)
		{
			this._fromAccessor = fromAccessor;
			this._toAccessor = toAccessor;
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x0600393F RID: 14655 RVA: 0x000BC868 File Offset: 0x000BAA68
		internal global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation Reverse
		{
			get
			{
				if (this._reverse == null || !this._reverse.IsInitialized)
				{
					this._reverse = ((this._associationType != null) ? new global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation(this._associationType, this._to, this._from, this._toAccessor, this._fromAccessor) : new global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation(this._relationshipName, this._to, this._from, this._toAccessor, this._fromAccessor));
				}
				return this._reverse;
			}
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x000BC8E8 File Offset: 0x000BAAE8
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation relationshipNavigation = obj as global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation;
			return this == relationshipNavigation || (this != null && relationshipNavigation != null && this.RelationshipName == relationshipNavigation.RelationshipName && this.From == relationshipNavigation.From && this.To == relationshipNavigation.To);
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x000BC941 File Offset: 0x000BAB41
		public override int GetHashCode()
		{
			return this.RelationshipName.GetHashCode();
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x000BC94E File Offset: 0x000BAB4E
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "RelationshipNavigation: ({0},{1},{2})", new object[]
			{
				this._relationshipName,
				this._from,
				this._to
			});
		}

		// Token: 0x0400130A RID: 4874
		private readonly string _relationshipName;

		// Token: 0x0400130B RID: 4875
		private readonly string _from;

		// Token: 0x0400130C RID: 4876
		private readonly string _to;

		// Token: 0x0400130D RID: 4877
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation _reverse;

		// Token: 0x0400130E RID: 4878
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor _fromAccessor;

		// Token: 0x0400130F RID: 4879
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor _toAccessor;

		// Token: 0x04001310 RID: 4880
		[global::System.NonSerialized]
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationType _associationType;
	}
}
