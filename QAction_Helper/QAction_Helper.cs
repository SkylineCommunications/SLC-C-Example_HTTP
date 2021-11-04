// --- auto-generated code --- do not modify ---
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Skyline.DataMiner.Scripting
{
public static class Parameter
{
	/// <summary>PID: 10 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int statuscode_10 = 10;
	/// <summary>PID: 10 | Type: read</summary>
	public const int statuscode = 10;
	/// <summary>PID: 20 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int xmlresponsecontent_20 = 20;
	/// <summary>PID: 20 | Type: read</summary>
	public const int xmlresponsecontent = 20;
	public class Write
	{
	}
	public class Alarms
	{
		/// <summary>PID: 100</summary>
		public const int tablePid = 100;
		/// <summary>IDX: 0</summary>
		public const int indexColumn = 0;
		/// <summary>PID: 101</summary>
		public const int indexColumnPid = 101;
		public class Pid
		{
			/// <summary>PID: 101 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int alarmsid_101 = 101;
			/// <summary>PID: 101 | Type: read</summary>
			public const int alarmsid = 101;
			/// <summary>PID: 102 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int alarmsdisplayname_102 = 102;
			/// <summary>PID: 102 | Type: read</summary>
			public const int alarmsdisplayname = 102;
			/// <summary>PID: 103 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int alarmstype_103 = 103;
			/// <summary>PID: 103 | Type: read</summary>
			public const int alarmstype = 103;
			/// <summary>PID: 104 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int alarmssource_104 = 104;
			/// <summary>PID: 104 | Type: read</summary>
			public const int alarmssource = 104;
			/// <summary>PID: 105 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int alarmsseverity_105 = 105;
			/// <summary>PID: 105 | Type: read</summary>
			public const int alarmsseverity = 105;
			/// <summary>PID: 106 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int alarmsdisplaykey_106 = 106;
			/// <summary>PID: 106 | Type: read</summary>
			public const int alarmsdisplaykey = 106;
			public class Write
			{
			}
		}
		public class Idx
		{
			/// <summary>IDX: 0 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int alarmsid_101 = 0;
			/// <summary>IDX: 0 | Type: read</summary>
			public const int alarmsid = 0;
			/// <summary>IDX: 1 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int alarmsdisplayname_102 = 1;
			/// <summary>IDX: 1 | Type: read</summary>
			public const int alarmsdisplayname = 1;
			/// <summary>IDX: 2 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int alarmstype_103 = 2;
			/// <summary>IDX: 2 | Type: read</summary>
			public const int alarmstype = 2;
			/// <summary>IDX: 3 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int alarmssource_104 = 3;
			/// <summary>IDX: 3 | Type: read</summary>
			public const int alarmssource = 3;
			/// <summary>IDX: 4 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int alarmsseverity_105 = 4;
			/// <summary>IDX: 4 | Type: read</summary>
			public const int alarmsseverity = 4;
			/// <summary>IDX: 5 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int alarmsdisplaykey_106 = 5;
			/// <summary>IDX: 5 | Type: read</summary>
			public const int alarmsdisplaykey = 5;
		}
	}
}
public class WriteParameters
{
	public SLProtocolExt Protocol;
	public WriteParameters(SLProtocolExt protocol)
	{
		Protocol = protocol;
	}
}
public interface SLProtocolExt : SLProtocol
{
	/// <summary>PID: 100</summary>
	AlarmsQActionTable alarms { get; set; }
	object Statuscode_10 { get; set; }
	object Statuscode { get; set; }
	object Xmlresponsecontent_20 { get; set; }
	object Xmlresponsecontent { get; set; }
	object Alarmsid_101 { get; set; }
	object Alarmsid { get; set; }
	object Alarmsdisplayname_102 { get; set; }
	object Alarmsdisplayname { get; set; }
	object Alarmstype_103 { get; set; }
	object Alarmstype { get; set; }
	object Alarmssource_104 { get; set; }
	object Alarmssource { get; set; }
	object Alarmsseverity_105 { get; set; }
	object Alarmsseverity { get; set; }
	object Alarmsdisplaykey_106 { get; set; }
	object Alarmsdisplaykey { get; set; }
	WriteParameters Write { get; set; }
}
public class ConcreteSLProtocolExt : ConcreteSLProtocol, SLProtocolExt
{
	/// <summary>PID: 100</summary>
	public AlarmsQActionTable alarms { get; set; }
	/// <summary>PID: 10  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Statuscode_10 {get { return GetParameter(10); }set { SetParameter(10, value); }}
	/// <summary>PID: 10  | Type: read</summary>
	public System.Object Statuscode {get { return GetParameter(10); }set { SetParameter(10, value); }}
	/// <summary>PID: 20  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Xmlresponsecontent_20 {get { return GetParameter(20); }set { SetParameter(20, value); }}
	/// <summary>PID: 20  | Type: read</summary>
	public System.Object Xmlresponsecontent {get { return GetParameter(20); }set { SetParameter(20, value); }}
	/// <summary>PID: 101  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Alarmsid_101 {get { return GetParameter(101); }set { SetParameter(101, value); }}
	/// <summary>PID: 101  | Type: read</summary>
	public System.Object Alarmsid {get { return GetParameter(101); }set { SetParameter(101, value); }}
	/// <summary>PID: 102  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Alarmsdisplayname_102 {get { return GetParameter(102); }set { SetParameter(102, value); }}
	/// <summary>PID: 102  | Type: read</summary>
	public System.Object Alarmsdisplayname {get { return GetParameter(102); }set { SetParameter(102, value); }}
	/// <summary>PID: 103  | Type: read | DISCREETS: Internal = internal, Input = input, Output = output</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Alarmstype_103 {get { return GetParameter(103); }set { SetParameter(103, value); }}
	/// <summary>PID: 103  | Type: read | DISCREETS: Internal = internal, Input = input, Output = output</summary>
	public System.Object Alarmstype {get { return GetParameter(103); }set { SetParameter(103, value); }}
	/// <summary>PID: 104  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Alarmssource_104 {get { return GetParameter(104); }set { SetParameter(104, value); }}
	/// <summary>PID: 104  | Type: read</summary>
	public System.Object Alarmssource {get { return GetParameter(104); }set { SetParameter(104, value); }}
	/// <summary>PID: 105  | Type: read | DISCREETS: Critical = critical, Major = major, Minor = minor, Warning = warning, Normal = normal</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Alarmsseverity_105 {get { return GetParameter(105); }set { SetParameter(105, value); }}
	/// <summary>PID: 105  | Type: read | DISCREETS: Critical = critical, Major = major, Minor = minor, Warning = warning, Normal = normal</summary>
	public System.Object Alarmsseverity {get { return GetParameter(105); }set { SetParameter(105, value); }}
	/// <summary>PID: 106  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Alarmsdisplaykey_106 {get { return GetParameter(106); }set { SetParameter(106, value); }}
	/// <summary>PID: 106  | Type: read</summary>
	public System.Object Alarmsdisplaykey {get { return GetParameter(106); }set { SetParameter(106, value); }}
	public WriteParameters Write { get; set; }
	public ConcreteSLProtocolExt()
	{
		alarms = new AlarmsQActionTable(this, 100, "alarms");
		Write = new WriteParameters(this);
	}
}
/// <summary>IDX: 0</summary>
public class AlarmsQActionTable : QActionTable, IEnumerable<AlarmsQActionRow>
{
	public AlarmsQActionTable(SLProtocol protocol, int tableId, string tableName) : base(protocol, tableId, tableName) { }
	IEnumerator IEnumerable.GetEnumerator() { return (IEnumerator) GetEnumerator(); }
	public IEnumerator<AlarmsQActionRow> GetEnumerator() { return new QActionTableEnumerator<AlarmsQActionRow>(this); }
}
/// <summary>IDX: 0</summary>
public class AlarmsQActionRow : QActionTableRow
{
	/// <summary>PID: 101 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Alarmsid_101 { get { if (base.Columns.ContainsKey(0)) { return base.Columns[0]; } else { return null; } } set { if (base.Columns.ContainsKey(0)) { base.Columns[0] = value; } else { base.Columns.Add(0, value); } } }
	/// <summary>PID: 101 | Type: read</summary>
	public System.Object Alarmsid { get { if (base.Columns.ContainsKey(0)) { return base.Columns[0]; } else { return null; } } set { if (base.Columns.ContainsKey(0)) { base.Columns[0] = value; } else { base.Columns.Add(0, value); } } }
	/// <summary>PID: 102 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Alarmsdisplayname_102 { get { if (base.Columns.ContainsKey(1)) { return base.Columns[1]; } else { return null; } } set { if (base.Columns.ContainsKey(1)) { base.Columns[1] = value; } else { base.Columns.Add(1, value); } } }
	/// <summary>PID: 102 | Type: read</summary>
	public System.Object Alarmsdisplayname { get { if (base.Columns.ContainsKey(1)) { return base.Columns[1]; } else { return null; } } set { if (base.Columns.ContainsKey(1)) { base.Columns[1] = value; } else { base.Columns.Add(1, value); } } }
	/// <summary>PID: 103 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Alarmstype_103 { get { if (base.Columns.ContainsKey(2)) { return base.Columns[2]; } else { return null; } } set { if (base.Columns.ContainsKey(2)) { base.Columns[2] = value; } else { base.Columns.Add(2, value); } } }
	/// <summary>PID: 103 | Type: read</summary>
	public System.Object Alarmstype { get { if (base.Columns.ContainsKey(2)) { return base.Columns[2]; } else { return null; } } set { if (base.Columns.ContainsKey(2)) { base.Columns[2] = value; } else { base.Columns.Add(2, value); } } }
	/// <summary>PID: 104 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Alarmssource_104 { get { if (base.Columns.ContainsKey(3)) { return base.Columns[3]; } else { return null; } } set { if (base.Columns.ContainsKey(3)) { base.Columns[3] = value; } else { base.Columns.Add(3, value); } } }
	/// <summary>PID: 104 | Type: read</summary>
	public System.Object Alarmssource { get { if (base.Columns.ContainsKey(3)) { return base.Columns[3]; } else { return null; } } set { if (base.Columns.ContainsKey(3)) { base.Columns[3] = value; } else { base.Columns.Add(3, value); } } }
	/// <summary>PID: 105 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Alarmsseverity_105 { get { if (base.Columns.ContainsKey(4)) { return base.Columns[4]; } else { return null; } } set { if (base.Columns.ContainsKey(4)) { base.Columns[4] = value; } else { base.Columns.Add(4, value); } } }
	/// <summary>PID: 105 | Type: read</summary>
	public System.Object Alarmsseverity { get { if (base.Columns.ContainsKey(4)) { return base.Columns[4]; } else { return null; } } set { if (base.Columns.ContainsKey(4)) { base.Columns[4] = value; } else { base.Columns.Add(4, value); } } }
	/// <summary>PID: 106 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Alarmsdisplaykey_106 { get { if (base.Columns.ContainsKey(5)) { return base.Columns[5]; } else { return null; } } set { if (base.Columns.ContainsKey(5)) { base.Columns[5] = value; } else { base.Columns.Add(5, value); } } }
	/// <summary>PID: 106 | Type: read</summary>
	public System.Object Alarmsdisplaykey { get { if (base.Columns.ContainsKey(5)) { return base.Columns[5]; } else { return null; } } set { if (base.Columns.ContainsKey(5)) { base.Columns[5] = value; } else { base.Columns.Add(5, value); } } }
	public AlarmsQActionRow() : base(0, 6) { }
	public AlarmsQActionRow(System.Object[] oRow) : base(0, 6, oRow) { }
	public static implicit operator AlarmsQActionRow(System.Object[] source) { return new AlarmsQActionRow(source); }
	public static implicit operator System.Object[](AlarmsQActionRow source) { return source.ToObjectArray(); }
}
}
