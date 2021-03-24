using BackUpMe.Common.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUpMe.Infastructure.Model
{
	public class Job
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
				if(value != _Id)
				{
					_Id = value;
				}
			}
		}
		private string _JobName = "";
		public string JobName
		{
			get
			{
				return _JobName;
			}
			set
			{
				if (value != _JobName)
				{
					_JobName = value;
				}
			}
		}
		private string _SourcePath = "";
		public string SourcePath
		{
			get
			{
				return _SourcePath;
			}
			set
			{
				if(value != _SourcePath)
				{
					_SourcePath = value;
				}
			}
		}
		private string _DestinationPath = "";
		public string DestinationPath
		{
			get
			{
				return _DestinationPath;
			}
			set
			{
				if(value != _DestinationPath)
				{
					_DestinationPath = value;
				}
			}
		}
		private BackUpType _BackUpType = BackUpType.EveryDay;
		public BackUpType BackUpType
		{
			get
			{
				return _BackUpType;
			}
			set
			{
				if(value != _BackUpType)
				{
					_BackUpType = value;
				}
			}
		}
		private byte _DayMonth = 1;
		public byte DayMonth
		{
			get
			{
				return _DayMonth;
			}
			set
			{
				if(value != _DayMonth)
				{
					_DayMonth = value;
				}
			}
		}
		private DateTime _TimeToExecute;
		public DateTime TimeToExecute
		{
			get
			{
				return _TimeToExecute;
			}
			set
			{
				if(value!= _TimeToExecute)
				{
					_TimeToExecute = value;
				}
			}
		}
	}
}
