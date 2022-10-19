using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerLib.Models
{
	public class CONFIG_JOB_STEP
	{

		#region Extra Properties

		#endregion

		#region Properties

		[Key, Column(Order = 1)]
		public string JOB_ID { get; set; }
		[Key, Column(Order = 2)]
		public int CODE_COMP { get; set; }
		[Key, Column(Order = 3)]
		public int CODE_ORG { get; set; }
		[Key, Column(Order = 4)]
		public string STEP_ID { get; set; }
		public string STEP_NAME { get; set; }
		public int STEP_ORDER { get; set; }
		public string PROG_ARGUMENT { get; set; }
		public string PROG_NAME { get; set; }
		public int PROCESS_STATUS { get; set; }
		public int STEP_STATUS { get; set; }
		public int PROCESS_PERCENT { get; set; }
		public DateTime? AUDIT_CREATED_DATE { get; set; }
		public string AUDIT_CREATED_USER { get; set; }
		public DateTime? AUDIT_UPDATED_DATE { get; set; }
		public string AUDIT_UPDATED_USER { get; set; }
		#endregion

	}
	[Table("CONFIG_JOB_STEP")]
	public class _CONFIG_JOB_STEP
	{
		public _CONFIG_JOB_STEP() { }

		public _CONFIG_JOB_STEP(bool setDefaultValue)
		{
			CODE_COMP = 0;
			CODE_ORG = 0;
			JOB_ID = "";
			STEP_ID = "";
			STEP_NAME = "";
			STEP_ORDER = 0;
			PROG_ARGUMENT = "";
			PROG_NAME = "";
			PROCESS_STATUS = 0;
			STEP_STATUS = 0;
			PROCESS_PERCENT = 0;
			AUDIT_CREATED_DATE = null;
			AUDIT_CREATED_USER = "";
			AUDIT_UPDATED_DATE = null;
			AUDIT_UPDATED_USER = "";
		}

		#region Properties

		[Key, Column(Order = 1)]
		public string JOB_ID { get; set; }
		[Key, Column(Order = 2)]
		public int CODE_COMP { get; set; }
		[Key, Column(Order = 3)]
		public int CODE_ORG { get; set; }
		[Key, Column(Order = 4)]
		public string STEP_ID { get; set; }
		public string STEP_NAME { get; set; }
		public int STEP_ORDER { get; set; }
		public string PROG_ARGUMENT { get; set; }
		public string PROG_NAME { get; set; }
		public int PROCESS_STATUS { get; set; }
		public int STEP_STATUS { get; set; }
		public int PROCESS_PERCENT { get; set; }
		public DateTime? AUDIT_CREATED_DATE { get; set; }
		public string AUDIT_CREATED_USER { get; set; }
		public DateTime? AUDIT_UPDATED_DATE { get; set; }
		public string AUDIT_UPDATED_USER { get; set; }
		#endregion

	}
}
