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

namespace ProjetASP.net
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CarRental")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMessage(Message instance);
    partial void UpdateMessage(Message instance);
    partial void DeleteMessage(Message instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertVoiture(Voiture instance);
    partial void UpdateVoiture(Voiture instance);
    partial void DeleteVoiture(Voiture instance);
    partial void InsertReservation(Reservation instance);
    partial void UpdateReservation(Reservation instance);
    partial void DeleteReservation(Reservation instance);
    #endregion
		
		public DataBaseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CarRentalConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Message> Messages
		{
			get
			{
				return this.GetTable<Message>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Voiture> Voitures
		{
			get
			{
				return this.GetTable<Voiture>();
			}
		}
		
		public System.Data.Linq.Table<Reservation> Reservations
		{
			get
			{
				return this.GetTable<Reservation>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Messages")]
	public partial class Message : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nom;
		
		private string _Email;
		
		private string _Description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Message()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Email;
		
		private string _Password;
		
		private string _Address;
		
		private string _Phone;
		
		private string _Role;
		
		private string _Status;
		
		private System.Nullable<int> _Category;
		
		private EntitySet<Voiture> _Voitures;
		
		private EntitySet<Reservation> _Reservations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnRoleChanging(string value);
    partial void OnRoleChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnCategoryChanging(System.Nullable<int> value);
    partial void OnCategoryChanged();
    #endregion
		
		public User()
		{
			this._Voitures = new EntitySet<Voiture>(new Action<Voiture>(this.attach_Voitures), new Action<Voiture>(this.detach_Voitures));
			this._Reservations = new EntitySet<Reservation>(new Action<Reservation>(this.attach_Reservations), new Action<Reservation>(this.detach_Reservations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(500)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this.OnRoleChanging(value);
					this.SendPropertyChanging();
					this._Role = value;
					this.SendPropertyChanged("Role");
					this.OnRoleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(50)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="Int")]
		public System.Nullable<int> Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Voiture", Storage="_Voitures", ThisKey="Id", OtherKey="Proprietaire")]
		public EntitySet<Voiture> Voitures
		{
			get
			{
				return this._Voitures;
			}
			set
			{
				this._Voitures.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Reservation", Storage="_Reservations", ThisKey="Id", OtherKey="Locataire")]
		public EntitySet<Reservation> Reservations
		{
			get
			{
				return this._Reservations;
			}
			set
			{
				this._Reservations.Assign(value);
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
		
		private void attach_Voitures(Voiture entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Voitures(Voiture entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Voitures")]
	public partial class Voiture : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nom;
		
		private string _Immatriculation;
		
		private string _Couleur;
		
		private System.Nullable<int> _Kilometrage;
		
		private System.Nullable<int> _Modele;
		
		private string _Transition;
		
		private int _Proprietaire;
		
		private System.Nullable<int> _Offre;
		
		private string _Image;
		
		private System.Nullable<int> _Prix;
		
		private string _Marque;
		
		private EntitySet<Reservation> _Reservations;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnImmatriculationChanging(string value);
    partial void OnImmatriculationChanged();
    partial void OnCouleurChanging(string value);
    partial void OnCouleurChanged();
    partial void OnKilometrageChanging(System.Nullable<int> value);
    partial void OnKilometrageChanged();
    partial void OnModeleChanging(System.Nullable<int> value);
    partial void OnModeleChanged();
    partial void OnTransitionChanging(string value);
    partial void OnTransitionChanged();
    partial void OnProprietaireChanging(int value);
    partial void OnProprietaireChanged();
    partial void OnOffreChanging(System.Nullable<int> value);
    partial void OnOffreChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnPrixChanging(System.Nullable<int> value);
    partial void OnPrixChanged();
    partial void OnMarqueChanging(string value);
    partial void OnMarqueChanged();
    #endregion
		
		public Voiture()
		{
			this._Reservations = new EntitySet<Reservation>(new Action<Reservation>(this.attach_Reservations), new Action<Reservation>(this.detach_Reservations));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Immatriculation", DbType="VarChar(50)")]
		public string Immatriculation
		{
			get
			{
				return this._Immatriculation;
			}
			set
			{
				if ((this._Immatriculation != value))
				{
					this.OnImmatriculationChanging(value);
					this.SendPropertyChanging();
					this._Immatriculation = value;
					this.SendPropertyChanged("Immatriculation");
					this.OnImmatriculationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Couleur", DbType="VarChar(50)")]
		public string Couleur
		{
			get
			{
				return this._Couleur;
			}
			set
			{
				if ((this._Couleur != value))
				{
					this.OnCouleurChanging(value);
					this.SendPropertyChanging();
					this._Couleur = value;
					this.SendPropertyChanged("Couleur");
					this.OnCouleurChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kilometrage", DbType="Int")]
		public System.Nullable<int> Kilometrage
		{
			get
			{
				return this._Kilometrage;
			}
			set
			{
				if ((this._Kilometrage != value))
				{
					this.OnKilometrageChanging(value);
					this.SendPropertyChanging();
					this._Kilometrage = value;
					this.SendPropertyChanged("Kilometrage");
					this.OnKilometrageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modele", DbType="Int")]
		public System.Nullable<int> Modele
		{
			get
			{
				return this._Modele;
			}
			set
			{
				if ((this._Modele != value))
				{
					this.OnModeleChanging(value);
					this.SendPropertyChanging();
					this._Modele = value;
					this.SendPropertyChanged("Modele");
					this.OnModeleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Transition", DbType="VarChar(50)")]
		public string Transition
		{
			get
			{
				return this._Transition;
			}
			set
			{
				if ((this._Transition != value))
				{
					this.OnTransitionChanging(value);
					this.SendPropertyChanging();
					this._Transition = value;
					this.SendPropertyChanged("Transition");
					this.OnTransitionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Proprietaire", DbType="Int NOT NULL")]
		public int Proprietaire
		{
			get
			{
				return this._Proprietaire;
			}
			set
			{
				if ((this._Proprietaire != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProprietaireChanging(value);
					this.SendPropertyChanging();
					this._Proprietaire = value;
					this.SendPropertyChanged("Proprietaire");
					this.OnProprietaireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Offre", DbType="Int")]
		public System.Nullable<int> Offre
		{
			get
			{
				return this._Offre;
			}
			set
			{
				if ((this._Offre != value))
				{
					this.OnOffreChanging(value);
					this.SendPropertyChanging();
					this._Offre = value;
					this.SendPropertyChanged("Offre");
					this.OnOffreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarChar(250)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prix", DbType="Int")]
		public System.Nullable<int> Prix
		{
			get
			{
				return this._Prix;
			}
			set
			{
				if ((this._Prix != value))
				{
					this.OnPrixChanging(value);
					this.SendPropertyChanging();
					this._Prix = value;
					this.SendPropertyChanged("Prix");
					this.OnPrixChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Marque", DbType="VarChar(50)")]
		public string Marque
		{
			get
			{
				return this._Marque;
			}
			set
			{
				if ((this._Marque != value))
				{
					this.OnMarqueChanging(value);
					this.SendPropertyChanging();
					this._Marque = value;
					this.SendPropertyChanged("Marque");
					this.OnMarqueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Voiture_Reservation", Storage="_Reservations", ThisKey="Id", OtherKey="Voiture")]
		public EntitySet<Reservation> Reservations
		{
			get
			{
				return this._Reservations;
			}
			set
			{
				this._Reservations.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Voiture", Storage="_User", ThisKey="Proprietaire", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Voitures.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Voitures.Add(this);
						this._Proprietaire = value.Id;
					}
					else
					{
						this._Proprietaire = default(int);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Voiture1 = this;
		}
		
		private void detach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Voiture1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reservations")]
	public partial class Reservation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Voiture;
		
		private System.Nullable<int> _Locataire;
		
		private string _Nom;
		
		private string _Email;
		
		private string _Phone;
		
		private string _Adresse;
		
		private System.Nullable<System.DateTime> _DateDebut;
		
		private string _Paiment;
		
		private System.Nullable<System.DateTime> _DateFin;
		
		private System.Nullable<int> _Status;
		
		private EntityRef<User> _User;
		
		private EntityRef<Voiture> _Voiture1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnVoitureChanging(int value);
    partial void OnVoitureChanged();
    partial void OnLocataireChanging(System.Nullable<int> value);
    partial void OnLocataireChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnAdresseChanging(string value);
    partial void OnAdresseChanged();
    partial void OnDateDebutChanging(System.Nullable<System.DateTime> value);
    partial void OnDateDebutChanged();
    partial void OnPaimentChanging(string value);
    partial void OnPaimentChanged();
    partial void OnDateFinChanging(System.Nullable<System.DateTime> value);
    partial void OnDateFinChanged();
    partial void OnStatusChanging(System.Nullable<int> value);
    partial void OnStatusChanged();
    #endregion
		
		public Reservation()
		{
			this._User = default(EntityRef<User>);
			this._Voiture1 = default(EntityRef<Voiture>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Voiture", DbType="Int NOT NULL")]
		public int Voiture
		{
			get
			{
				return this._Voiture;
			}
			set
			{
				if ((this._Voiture != value))
				{
					if (this._Voiture1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnVoitureChanging(value);
					this.SendPropertyChanging();
					this._Voiture = value;
					this.SendPropertyChanged("Voiture");
					this.OnVoitureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Locataire", DbType="Int")]
		public System.Nullable<int> Locataire
		{
			get
			{
				return this._Locataire;
			}
			set
			{
				if ((this._Locataire != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLocataireChanging(value);
					this.SendPropertyChanging();
					this._Locataire = value;
					this.SendPropertyChanged("Locataire");
					this.OnLocataireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="VarChar(50)")]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adresse", DbType="VarChar(500)")]
		public string Adresse
		{
			get
			{
				return this._Adresse;
			}
			set
			{
				if ((this._Adresse != value))
				{
					this.OnAdresseChanging(value);
					this.SendPropertyChanging();
					this._Adresse = value;
					this.SendPropertyChanged("Adresse");
					this.OnAdresseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateDebut", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateDebut
		{
			get
			{
				return this._DateDebut;
			}
			set
			{
				if ((this._DateDebut != value))
				{
					this.OnDateDebutChanging(value);
					this.SendPropertyChanging();
					this._DateDebut = value;
					this.SendPropertyChanged("DateDebut");
					this.OnDateDebutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Paiment", DbType="VarChar(100)")]
		public string Paiment
		{
			get
			{
				return this._Paiment;
			}
			set
			{
				if ((this._Paiment != value))
				{
					this.OnPaimentChanging(value);
					this.SendPropertyChanging();
					this._Paiment = value;
					this.SendPropertyChanged("Paiment");
					this.OnPaimentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateFin", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateFin
		{
			get
			{
				return this._DateFin;
			}
			set
			{
				if ((this._DateFin != value))
				{
					this.OnDateFinChanging(value);
					this.SendPropertyChanging();
					this._DateFin = value;
					this.SendPropertyChanged("DateFin");
					this.OnDateFinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int")]
		public System.Nullable<int> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Reservation", Storage="_User", ThisKey="Locataire", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Reservations.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Reservations.Add(this);
						this._Locataire = value.Id;
					}
					else
					{
						this._Locataire = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Voiture_Reservation", Storage="_Voiture1", ThisKey="Voiture", OtherKey="Id", IsForeignKey=true)]
		public Voiture Voiture1
		{
			get
			{
				return this._Voiture1.Entity;
			}
			set
			{
				Voiture previousValue = this._Voiture1.Entity;
				if (((previousValue != value) 
							|| (this._Voiture1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Voiture1.Entity = null;
						previousValue.Reservations.Remove(this);
					}
					this._Voiture1.Entity = value;
					if ((value != null))
					{
						value.Reservations.Add(this);
						this._Voiture = value.Id;
					}
					else
					{
						this._Voiture = default(int);
					}
					this.SendPropertyChanged("Voiture1");
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
