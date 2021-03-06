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

namespace DBGurus_Issue_Log
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbIssue")]
	public partial class IssueDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertClient(Client instance);
    partial void UpdateClient(Client instance);
    partial void DeleteClient(Client instance);
    partial void InsertIssue(Issue instance);
    partial void UpdateIssue(Issue instance);
    partial void DeleteIssue(Issue instance);
    partial void InsertStatus(Status instance);
    partial void UpdateStatus(Status instance);
    partial void DeleteStatus(Status instance);
    #endregion
		
		public IssueDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["dbIssueConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public IssueDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IssueDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IssueDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IssueDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Client> Clients
		{
			get
			{
				return this.GetTable<Client>();
			}
		}
		
		public System.Data.Linq.Table<Issue> Issues
		{
			get
			{
				return this.GetTable<Issue>();
			}
		}
		
		public System.Data.Linq.Table<Status> Status
		{
			get
			{
				return this.GetTable<Status>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Client")]
	public partial class Client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ClientID;
		
		private string _ClientName;
		
		private string _UserName;
		
		private string _Email;
		
		private string _Phone;
		
		private string _State;
		
		private EntitySet<Issue> _Issues;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClientIDChanging(int value);
    partial void OnClientIDChanged();
    partial void OnClientNameChanging(string value);
    partial void OnClientNameChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    #endregion
		
		public Client()
		{
			this._Issues = new EntitySet<Issue>(new Action<Issue>(this.attach_Issues), new Action<Issue>(this.detach_Issues));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ClientID
		{
			get
			{
				return this._ClientID;
			}
			set
			{
				if ((this._ClientID != value))
				{
					this.OnClientIDChanging(value);
					this.SendPropertyChanging();
					this._ClientID = value;
					this.SendPropertyChanged("ClientID");
					this.OnClientIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientName", DbType="VarChar(200)")]
		public string ClientName
		{
			get
			{
				return this._ClientName;
			}
			set
			{
				if ((this._ClientName != value))
				{
					this.OnClientNameChanging(value);
					this.SendPropertyChanging();
					this._ClientName = value;
					this.SendPropertyChanged("ClientName");
					this.OnClientNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(10)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(3)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_Issue", Storage="_Issues", ThisKey="ClientID", OtherKey="ClientID")]
		public EntitySet<Issue> Issues
		{
			get
			{
				return this._Issues;
			}
			set
			{
				this._Issues.Assign(value);
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
		
		private void attach_Issues(Issue entity)
		{
			this.SendPropertyChanging();
			entity.Client = this;
		}
		
		private void detach_Issues(Issue entity)
		{
			this.SendPropertyChanging();
			entity.Client = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Issue")]
	public partial class Issue : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IssueID;
		
		private System.Nullable<int> _ClientID;
		
		private System.Nullable<int> _StatusID;
		
		private string _Issue1;
		
		private string _Resolution;
		
		private System.Nullable<System.DateTime> _ResolvedDate;
		
		private EntityRef<Client> _Client;
		
		private EntityRef<Status> _Status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIssueIDChanging(int value);
    partial void OnIssueIDChanged();
    partial void OnClientIDChanging(System.Nullable<int> value);
    partial void OnClientIDChanged();
    partial void OnStatusIDChanging(System.Nullable<int> value);
    partial void OnStatusIDChanged();
    partial void OnIssue1Changing(string value);
    partial void OnIssue1Changed();
    partial void OnResolutionChanging(string value);
    partial void OnResolutionChanged();
    partial void OnResolvedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnResolvedDateChanged();
    #endregion
		
		public Issue()
		{
			this._Client = default(EntityRef<Client>);
			this._Status = default(EntityRef<Status>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IssueID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IssueID
		{
			get
			{
				return this._IssueID;
			}
			set
			{
				if ((this._IssueID != value))
				{
					this.OnIssueIDChanging(value);
					this.SendPropertyChanging();
					this._IssueID = value;
					this.SendPropertyChanged("IssueID");
					this.OnIssueIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientID", DbType="Int")]
		public System.Nullable<int> ClientID
		{
			get
			{
				return this._ClientID;
			}
			set
			{
				if ((this._ClientID != value))
				{
					if (this._Client.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClientIDChanging(value);
					this.SendPropertyChanging();
					this._ClientID = value;
					this.SendPropertyChanged("ClientID");
					this.OnClientIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusID", DbType="Int")]
		public System.Nullable<int> StatusID
		{
			get
			{
				return this._StatusID;
			}
			set
			{
				if ((this._StatusID != value))
				{
					if (this._Status.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStatusIDChanging(value);
					this.SendPropertyChanging();
					this._StatusID = value;
					this.SendPropertyChanged("StatusID");
					this.OnStatusIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Issue", Storage="_Issue1", DbType="VarChar(MAX)")]
		public string Issue1
		{
			get
			{
				return this._Issue1;
			}
			set
			{
				if ((this._Issue1 != value))
				{
					this.OnIssue1Changing(value);
					this.SendPropertyChanging();
					this._Issue1 = value;
					this.SendPropertyChanged("Issue1");
					this.OnIssue1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Resolution", DbType="VarChar(MAX)")]
		public string Resolution
		{
			get
			{
				return this._Resolution;
			}
			set
			{
				if ((this._Resolution != value))
				{
					this.OnResolutionChanging(value);
					this.SendPropertyChanging();
					this._Resolution = value;
					this.SendPropertyChanged("Resolution");
					this.OnResolutionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResolvedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ResolvedDate
		{
			get
			{
				return this._ResolvedDate;
			}
			set
			{
				if ((this._ResolvedDate != value))
				{
					this.OnResolvedDateChanging(value);
					this.SendPropertyChanging();
					this._ResolvedDate = value;
					this.SendPropertyChanged("ResolvedDate");
					this.OnResolvedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_Issue", Storage="_Client", ThisKey="ClientID", OtherKey="ClientID", IsForeignKey=true, DeleteRule="CASCADE")]
		public Client Client
		{
			get
			{
				return this._Client.Entity;
			}
			set
			{
				Client previousValue = this._Client.Entity;
				if (((previousValue != value) 
							|| (this._Client.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Client.Entity = null;
						previousValue.Issues.Remove(this);
					}
					this._Client.Entity = value;
					if ((value != null))
					{
						value.Issues.Add(this);
						this._ClientID = value.ClientID;
					}
					else
					{
						this._ClientID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Client");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Status_Issue", Storage="_Status", ThisKey="StatusID", OtherKey="StatusID", IsForeignKey=true, DeleteRule="CASCADE")]
		public Status Status
		{
			get
			{
				return this._Status.Entity;
			}
			set
			{
				Status previousValue = this._Status.Entity;
				if (((previousValue != value) 
							|| (this._Status.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Status.Entity = null;
						previousValue.Issues.Remove(this);
					}
					this._Status.Entity = value;
					if ((value != null))
					{
						value.Issues.Add(this);
						this._StatusID = value.StatusID;
					}
					else
					{
						this._StatusID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Status");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Status")]
	public partial class Status : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StatusID;
		
		private string _StatusName;
		
		private EntitySet<Issue> _Issues;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStatusIDChanging(int value);
    partial void OnStatusIDChanged();
    partial void OnStatusNameChanging(string value);
    partial void OnStatusNameChanged();
    #endregion
		
		public Status()
		{
			this._Issues = new EntitySet<Issue>(new Action<Issue>(this.attach_Issues), new Action<Issue>(this.detach_Issues));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int StatusID
		{
			get
			{
				return this._StatusID;
			}
			set
			{
				if ((this._StatusID != value))
				{
					this.OnStatusIDChanging(value);
					this.SendPropertyChanging();
					this._StatusID = value;
					this.SendPropertyChanged("StatusID");
					this.OnStatusIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusName", DbType="VarChar(50)")]
		public string StatusName
		{
			get
			{
				return this._StatusName;
			}
			set
			{
				if ((this._StatusName != value))
				{
					this.OnStatusNameChanging(value);
					this.SendPropertyChanging();
					this._StatusName = value;
					this.SendPropertyChanged("StatusName");
					this.OnStatusNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Status_Issue", Storage="_Issues", ThisKey="StatusID", OtherKey="StatusID")]
		public EntitySet<Issue> Issues
		{
			get
			{
				return this._Issues;
			}
			set
			{
				this._Issues.Assign(value);
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
		
		private void attach_Issues(Issue entity)
		{
			this.SendPropertyChanging();
			entity.Status = this;
		}
		
		private void detach_Issues(Issue entity)
		{
			this.SendPropertyChanging();
			entity.Status = null;
		}
	}
}
#pragma warning restore 1591
