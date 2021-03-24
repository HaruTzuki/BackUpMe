using BackUpMe.Common.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUpMe.Infastructure.Model
{
	public class ActivityJob
	{
		private int _Id = 0;
		public int Id
		{
			get
			{
				return _Id;
			}
			set
			{
				if (value != _Id)
				{
					_Id = value;
				}
			}
		}
		private int? _JobId;
		public int? JobId
		{
			get
			{
				return _JobId;
			}
			set
			{
				if (value != _JobId)
				{
					_JobId = value;
				}
			}
		}
		private Job _Job;
		public Job Job
		{
			get
			{
				return _Job;
			}
			set
			{
				if(value != _Job)
				{
					_Job = value;
				}
			}
		}
		private DateTime? _StartedExecutionDate = DateTime.Now;
		public DateTime? StartedExecutionDate
		{
			get
			{
				return _StartedExecutionDate;
			}
			set
			{
				if(value != _StartedExecutionDate)
				{
					_StartedExecutionDate = value;
				}
			}
		}
		private DateTime? _FinishedExecutionDate = DateTime.Now;
		public DateTime? FinishedExecutionDate
		{
			get
			{
				return _FinishedExecutionDate;
			}
			set
			{
				if (value != _FinishedExecutionDate)
				{
					_FinishedExecutionDate = value;
				}
			}
		}
		private StatusType _StatusType = StatusType.NotRunning;
		public StatusType StatusType
		{
			get
			{
				return _StatusType;
			}
			set
			{
				if(value != _StatusType)
				{
					_StatusType = value;
				}
			}
		}
		private string _Message = "";
		public string Message
		{
			get
			{
				return _Message;
			}
			set
			{
				if (value != _Message)
				{
					_Message = value;
				}
			}
		}
		private bool _IsRunning = false;
		public bool IsRunning
		{
			get
			{
				return _IsRunning;
			}
			set
			{
				if (value != _IsRunning)
				{
					_IsRunning = value;
				}
			}
		}
	}
}
