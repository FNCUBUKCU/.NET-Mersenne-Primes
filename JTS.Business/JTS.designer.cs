﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JTS.Business
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="JTS")]
	public partial class JTSDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertjob(job instance);
    partial void Updatejob(job instance);
    partial void Deletejob(job instance);
    #endregion
		
		public JTSDataContext() : 
				base(global::JTS.Business.Properties.Settings.Default.JTSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public JTSDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JTSDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JTSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JTSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<job> jobs
		{
			get
			{
				return this.GetTable<job>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.jobs")]
	public partial class job : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _job_id;
		
		private long _n;
		
		private string _mac;
		
		private System.DateTime _assign_date;
		
		private byte _status;
		
		private System.Nullable<System.DateTime> _complete_date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onjob_idChanging(System.Guid value);
    partial void Onjob_idChanged();
    partial void OnnChanging(long value);
    partial void OnnChanged();
    partial void OnmacChanging(string value);
    partial void OnmacChanged();
    partial void Onassign_dateChanging(System.DateTime value);
    partial void Onassign_dateChanged();
    partial void OnstatusChanging(byte value);
    partial void OnstatusChanged();
    partial void Oncomplete_dateChanging(System.Nullable<System.DateTime> value);
    partial void Oncomplete_dateChanged();
    #endregion
		
		public job()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_job_id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid job_id
		{
			get
			{
				return this._job_id;
			}
			set
			{
				if ((this._job_id != value))
				{
					this.Onjob_idChanging(value);
					this.SendPropertyChanging();
					this._job_id = value;
					this.SendPropertyChanged("job_id");
					this.Onjob_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_n", DbType="BigInt NOT NULL")]
		public long n
		{
			get
			{
				return this._n;
			}
			set
			{
				if ((this._n != value))
				{
					this.OnnChanging(value);
					this.SendPropertyChanging();
					this._n = value;
					this.SendPropertyChanged("n");
					this.OnnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mac", DbType="Char(12) NOT NULL", CanBeNull=false)]
		public string mac
		{
			get
			{
				return this._mac;
			}
			set
			{
				if ((this._mac != value))
				{
					this.OnmacChanging(value);
					this.SendPropertyChanging();
					this._mac = value;
					this.SendPropertyChanged("mac");
					this.OnmacChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_assign_date", DbType="SmallDateTime NOT NULL")]
		public System.DateTime assign_date
		{
			get
			{
				return this._assign_date;
			}
			set
			{
				if ((this._assign_date != value))
				{
					this.Onassign_dateChanging(value);
					this.SendPropertyChanging();
					this._assign_date = value;
					this.SendPropertyChanged("assign_date");
					this.Onassign_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="TinyInt NOT NULL")]
		public byte status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_complete_date", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> complete_date
		{
			get
			{
				return this._complete_date;
			}
			set
			{
				if ((this._complete_date != value))
				{
					this.Oncomplete_dateChanging(value);
					this.SendPropertyChanging();
					this._complete_date = value;
					this.SendPropertyChanged("complete_date");
					this.Oncomplete_dateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591