using System;
using System.Collections.Generic;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000077 RID: 119
	internal class FieldPositionAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x060005E9 RID: 1513 RVA: 0x000178CC File Offset: 0x00015ACC
		internal FieldPositionAction(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> fields, global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo, global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason reason, global::Infragistics.Windows.DataPresenter.FixedFieldLocation location) : base(fields[0].DataPresenter)
		{
			this._fl = fields[0].Owner;
			this._fields = global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.Field>(fields);
			this._layoutInfo = ((layoutInfo != null) ? layoutInfo.Clone() : null);
			this._reason = reason;
			this._location = location;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0001792C File Offset: 0x00015B2C
		protected internal override bool CanPerform(object context)
		{
			global::Infragistics.Windows.DataPresenter.Field[] fields = this._fields;
			int i = 0;
			while (i < fields.Length)
			{
				global::Infragistics.Windows.DataPresenter.Field field = fields[i];
				bool result;
				if (!global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(field))
				{
					result = false;
				}
				else if ((this._reason == global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Fixed || this._reason == global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Unfixed) && !field.IsFixedLocationAllowed(this._location))
				{
					result = false;
				}
				else
				{
					if ((global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Displayed != this._reason && global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Hidden != this._reason) || global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Never != field.AllowHidingResolved)
					{
						i++;
						continue;
					}
					result = false;
				}
				return result;
			}
			return true;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000179A4 File Offset: 0x00015BA4
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			if (fieldLayout == this._fl && (customizationType & global::Infragistics.Windows.DataPresenter.CustomizationType.FieldPosition) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				return null;
			}
			return base.OnCustomizationsChanged(fieldLayout, customizationType);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000179C0 File Offset: 0x00015BC0
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			if (!this.CanPerform(context))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fields)
			{
				global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs fieldPositionChangingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs(field, this._reason);
				dataPresenter.RaiseFieldPositionChanging(fieldPositionChangingEventArgs);
				if (fieldPositionChangingEventArgs.Cancel)
				{
					return null;
				}
			}
			global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation = this._fields[0].FixedLocation;
			foreach (global::Infragistics.Windows.DataPresenter.Field field2 in this._fields)
			{
				global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation2 = field2.FixedLocation;
				if (fixedLocation2 != fixedLocation)
				{
					return null;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason reason;
			switch (this._reason)
			{
			case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Moved:
				reason = global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Moved;
				break;
			case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Fixed:
				reason = global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Unfixed;
				break;
			case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Unfixed:
				reason = global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Fixed;
				break;
			case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Hidden:
				reason = global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Displayed;
				break;
			case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Displayed:
				reason = global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Hidden;
				break;
			default:
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldPositionAction result = new global::Infragistics.Windows.DataPresenter.FieldPositionAction(this._fields, this._fl.GetFieldLayoutInfo(true, true), reason, fixedLocation);
			this._fl.SetFieldLayoutInfo(this._layoutInfo, false, true);
			foreach (global::Infragistics.Windows.DataPresenter.Field field3 in this._fields)
			{
				field3.SetFixedLocation(this._location);
			}
			this._fl.InvalidateGeneratedStyles(false, false);
			foreach (global::Infragistics.Windows.DataPresenter.Field field4 in this._fields)
			{
				dataPresenter.RaiseFieldPositionChanged(new global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangedEventArgs(field4, this._reason));
			}
			return result;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00017B50 File Offset: 0x00015D50
		internal static global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason GetUndoReason(global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason reason)
		{
			switch (reason)
			{
			case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Moved:
				return global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Moved;
			case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Fixed:
				return global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Unfixed;
			case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Unfixed:
				return global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Fixed;
			case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Hidden:
				return global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Displayed;
			case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Displayed:
				return global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Hidden;
			default:
				return reason;
			}
		}

		// Token: 0x040001C6 RID: 454
		private global::Infragistics.Windows.DataPresenter.Field[] _fields;

		// Token: 0x040001C7 RID: 455
		private global::Infragistics.Windows.DataPresenter.LayoutInfo _layoutInfo;

		// Token: 0x040001C8 RID: 456
		private global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason _reason;

		// Token: 0x040001C9 RID: 457
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fl;

		// Token: 0x040001CA RID: 458
		private global::Infragistics.Windows.DataPresenter.FixedFieldLocation _location;
	}
}
