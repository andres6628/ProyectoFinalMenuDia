﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatosLinq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AppMenuDia")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertBEBIDAS(BEBIDAS instance);
    partial void UpdateBEBIDAS(BEBIDAS instance);
    partial void DeleteBEBIDAS(BEBIDAS instance);
    partial void InsertENTRADAS(ENTRADAS instance);
    partial void UpdateENTRADAS(ENTRADAS instance);
    partial void DeleteENTRADAS(ENTRADAS instance);
    partial void InsertMENU_DEL_DIA(MENU_DEL_DIA instance);
    partial void UpdateMENU_DEL_DIA(MENU_DEL_DIA instance);
    partial void DeleteMENU_DEL_DIA(MENU_DEL_DIA instance);
    partial void InsertSEGUNDOS(SEGUNDOS instance);
    partial void UpdateSEGUNDOS(SEGUNDOS instance);
    partial void DeleteSEGUNDOS(SEGUNDOS instance);
    partial void InsertSOPAS(SOPAS instance);
    partial void UpdateSOPAS(SOPAS instance);
    partial void DeleteSOPAS(SOPAS instance);
    partial void InsertPEDIDOS(PEDIDOS instance);
    partial void UpdatePEDIDOS(PEDIDOS instance);
    partial void DeletePEDIDOS(PEDIDOS instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::DatosLinq.Properties.Settings.Default.AppMenuDiaConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BEBIDAS> BEBIDAS
		{
			get
			{
				return this.GetTable<BEBIDAS>();
			}
		}
		
		public System.Data.Linq.Table<ENTRADAS> ENTRADAS
		{
			get
			{
				return this.GetTable<ENTRADAS>();
			}
		}
		
		public System.Data.Linq.Table<MENU_DEL_DIA> MENU_DEL_DIA
		{
			get
			{
				return this.GetTable<MENU_DEL_DIA>();
			}
		}
		
		public System.Data.Linq.Table<SEGUNDOS> SEGUNDOS
		{
			get
			{
				return this.GetTable<SEGUNDOS>();
			}
		}
		
		public System.Data.Linq.Table<SOPAS> SOPAS
		{
			get
			{
				return this.GetTable<SOPAS>();
			}
		}
		
		public System.Data.Linq.Table<PEDIDOS> PEDIDOS
		{
			get
			{
				return this.GetTable<PEDIDOS>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BEBIDAS")]
	public partial class BEBIDAS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_BEB;
		
		private string _NOM_BEB;
		
		private System.Data.Linq.Binary _IMG_BEB;
		
		private string _ING_BEB;
		
		private EntitySet<MENU_DEL_DIA> _MENU_DEL_DIA;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_BEBChanging(int value);
    partial void OnID_BEBChanged();
    partial void OnNOM_BEBChanging(string value);
    partial void OnNOM_BEBChanged();
    partial void OnIMG_BEBChanging(System.Data.Linq.Binary value);
    partial void OnIMG_BEBChanged();
    partial void OnING_BEBChanging(string value);
    partial void OnING_BEBChanged();
    #endregion
		
		public BEBIDAS()
		{
			this._MENU_DEL_DIA = new EntitySet<MENU_DEL_DIA>(new Action<MENU_DEL_DIA>(this.attach_MENU_DEL_DIA), new Action<MENU_DEL_DIA>(this.detach_MENU_DEL_DIA));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_BEB", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_BEB
		{
			get
			{
				return this._ID_BEB;
			}
			set
			{
				if ((this._ID_BEB != value))
				{
					this.OnID_BEBChanging(value);
					this.SendPropertyChanging();
					this._ID_BEB = value;
					this.SendPropertyChanged("ID_BEB");
					this.OnID_BEBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOM_BEB", DbType="VarChar(50)")]
		public string NOM_BEB
		{
			get
			{
				return this._NOM_BEB;
			}
			set
			{
				if ((this._NOM_BEB != value))
				{
					this.OnNOM_BEBChanging(value);
					this.SendPropertyChanging();
					this._NOM_BEB = value;
					this.SendPropertyChanged("NOM_BEB");
					this.OnNOM_BEBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMG_BEB", DbType="Image", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary IMG_BEB
		{
			get
			{
				return this._IMG_BEB;
			}
			set
			{
				if ((this._IMG_BEB != value))
				{
					this.OnIMG_BEBChanging(value);
					this.SendPropertyChanging();
					this._IMG_BEB = value;
					this.SendPropertyChanged("IMG_BEB");
					this.OnIMG_BEBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ING_BEB", DbType="VarChar(200)")]
		public string ING_BEB
		{
			get
			{
				return this._ING_BEB;
			}
			set
			{
				if ((this._ING_BEB != value))
				{
					this.OnING_BEBChanging(value);
					this.SendPropertyChanging();
					this._ING_BEB = value;
					this.SendPropertyChanged("ING_BEB");
					this.OnING_BEBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BEBIDAS_MENU_DEL_DIA", Storage="_MENU_DEL_DIA", ThisKey="ID_BEB", OtherKey="ID_BEB_PER")]
		public EntitySet<MENU_DEL_DIA> MENU_DEL_DIA
		{
			get
			{
				return this._MENU_DEL_DIA;
			}
			set
			{
				this._MENU_DEL_DIA.Assign(value);
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
		
		private void attach_MENU_DEL_DIA(MENU_DEL_DIA entity)
		{
			this.SendPropertyChanging();
			entity.BEBIDAS = this;
		}
		
		private void detach_MENU_DEL_DIA(MENU_DEL_DIA entity)
		{
			this.SendPropertyChanging();
			entity.BEBIDAS = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ENTRADAS")]
	public partial class ENTRADAS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_ENT;
		
		private string _NOM_ENT;
		
		private System.Data.Linq.Binary _IMG_ENT;
		
		private string _ING_ENT;
		
		private EntitySet<MENU_DEL_DIA> _MENU_DEL_DIA;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_ENTChanging(int value);
    partial void OnID_ENTChanged();
    partial void OnNOM_ENTChanging(string value);
    partial void OnNOM_ENTChanged();
    partial void OnIMG_ENTChanging(System.Data.Linq.Binary value);
    partial void OnIMG_ENTChanged();
    partial void OnING_ENTChanging(string value);
    partial void OnING_ENTChanged();
    #endregion
		
		public ENTRADAS()
		{
			this._MENU_DEL_DIA = new EntitySet<MENU_DEL_DIA>(new Action<MENU_DEL_DIA>(this.attach_MENU_DEL_DIA), new Action<MENU_DEL_DIA>(this.detach_MENU_DEL_DIA));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_ENT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_ENT
		{
			get
			{
				return this._ID_ENT;
			}
			set
			{
				if ((this._ID_ENT != value))
				{
					this.OnID_ENTChanging(value);
					this.SendPropertyChanging();
					this._ID_ENT = value;
					this.SendPropertyChanged("ID_ENT");
					this.OnID_ENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOM_ENT", DbType="VarChar(50)")]
		public string NOM_ENT
		{
			get
			{
				return this._NOM_ENT;
			}
			set
			{
				if ((this._NOM_ENT != value))
				{
					this.OnNOM_ENTChanging(value);
					this.SendPropertyChanging();
					this._NOM_ENT = value;
					this.SendPropertyChanged("NOM_ENT");
					this.OnNOM_ENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMG_ENT", DbType="Image", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary IMG_ENT
		{
			get
			{
				return this._IMG_ENT;
			}
			set
			{
				if ((this._IMG_ENT != value))
				{
					this.OnIMG_ENTChanging(value);
					this.SendPropertyChanging();
					this._IMG_ENT = value;
					this.SendPropertyChanged("IMG_ENT");
					this.OnIMG_ENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ING_ENT", DbType="VarChar(200)")]
		public string ING_ENT
		{
			get
			{
				return this._ING_ENT;
			}
			set
			{
				if ((this._ING_ENT != value))
				{
					this.OnING_ENTChanging(value);
					this.SendPropertyChanging();
					this._ING_ENT = value;
					this.SendPropertyChanged("ING_ENT");
					this.OnING_ENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ENTRADAS_MENU_DEL_DIA", Storage="_MENU_DEL_DIA", ThisKey="ID_ENT", OtherKey="ID_ENT_PER")]
		public EntitySet<MENU_DEL_DIA> MENU_DEL_DIA
		{
			get
			{
				return this._MENU_DEL_DIA;
			}
			set
			{
				this._MENU_DEL_DIA.Assign(value);
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
		
		private void attach_MENU_DEL_DIA(MENU_DEL_DIA entity)
		{
			this.SendPropertyChanging();
			entity.ENTRADAS = this;
		}
		
		private void detach_MENU_DEL_DIA(MENU_DEL_DIA entity)
		{
			this.SendPropertyChanging();
			entity.ENTRADAS = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MENU_DEL_DIA")]
	public partial class MENU_DEL_DIA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _NUM_MEN;
		
		private System.Nullable<int> _ID_SOP_PER;
		
		private System.Nullable<int> _ID_SEG_PER;
		
		private System.Nullable<int> _ID_BEB_PER;
		
		private System.Nullable<int> _ID_ENT_PER;
		
		private System.Nullable<System.DateTime> _FEC_MEN;
		
		private EntitySet<PEDIDOS> _PEDIDOS;
		
		private EntityRef<BEBIDAS> _BEBIDAS;
		
		private EntityRef<ENTRADAS> _ENTRADAS;
		
		private EntityRef<SEGUNDOS> _SEGUNDOS;
		
		private EntityRef<SOPAS> _SOPAS;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNUM_MENChanging(int value);
    partial void OnNUM_MENChanged();
    partial void OnID_SOP_PERChanging(System.Nullable<int> value);
    partial void OnID_SOP_PERChanged();
    partial void OnID_SEG_PERChanging(System.Nullable<int> value);
    partial void OnID_SEG_PERChanged();
    partial void OnID_BEB_PERChanging(System.Nullable<int> value);
    partial void OnID_BEB_PERChanged();
    partial void OnID_ENT_PERChanging(System.Nullable<int> value);
    partial void OnID_ENT_PERChanged();
    partial void OnFEC_MENChanging(System.Nullable<System.DateTime> value);
    partial void OnFEC_MENChanged();
    #endregion
		
		public MENU_DEL_DIA()
		{
			this._PEDIDOS = new EntitySet<PEDIDOS>(new Action<PEDIDOS>(this.attach_PEDIDOS), new Action<PEDIDOS>(this.detach_PEDIDOS));
			this._BEBIDAS = default(EntityRef<BEBIDAS>);
			this._ENTRADAS = default(EntityRef<ENTRADAS>);
			this._SEGUNDOS = default(EntityRef<SEGUNDOS>);
			this._SOPAS = default(EntityRef<SOPAS>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUM_MEN", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int NUM_MEN
		{
			get
			{
				return this._NUM_MEN;
			}
			set
			{
				if ((this._NUM_MEN != value))
				{
					this.OnNUM_MENChanging(value);
					this.SendPropertyChanging();
					this._NUM_MEN = value;
					this.SendPropertyChanged("NUM_MEN");
					this.OnNUM_MENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_SOP_PER", DbType="Int")]
		public System.Nullable<int> ID_SOP_PER
		{
			get
			{
				return this._ID_SOP_PER;
			}
			set
			{
				if ((this._ID_SOP_PER != value))
				{
					if (this._SOPAS.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_SOP_PERChanging(value);
					this.SendPropertyChanging();
					this._ID_SOP_PER = value;
					this.SendPropertyChanged("ID_SOP_PER");
					this.OnID_SOP_PERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_SEG_PER", DbType="Int")]
		public System.Nullable<int> ID_SEG_PER
		{
			get
			{
				return this._ID_SEG_PER;
			}
			set
			{
				if ((this._ID_SEG_PER != value))
				{
					if (this._SEGUNDOS.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_SEG_PERChanging(value);
					this.SendPropertyChanging();
					this._ID_SEG_PER = value;
					this.SendPropertyChanged("ID_SEG_PER");
					this.OnID_SEG_PERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_BEB_PER", DbType="Int")]
		public System.Nullable<int> ID_BEB_PER
		{
			get
			{
				return this._ID_BEB_PER;
			}
			set
			{
				if ((this._ID_BEB_PER != value))
				{
					if (this._BEBIDAS.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_BEB_PERChanging(value);
					this.SendPropertyChanging();
					this._ID_BEB_PER = value;
					this.SendPropertyChanged("ID_BEB_PER");
					this.OnID_BEB_PERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_ENT_PER", DbType="Int")]
		public System.Nullable<int> ID_ENT_PER
		{
			get
			{
				return this._ID_ENT_PER;
			}
			set
			{
				if ((this._ID_ENT_PER != value))
				{
					if (this._ENTRADAS.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_ENT_PERChanging(value);
					this.SendPropertyChanging();
					this._ID_ENT_PER = value;
					this.SendPropertyChanged("ID_ENT_PER");
					this.OnID_ENT_PERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FEC_MEN", DbType="Date")]
		public System.Nullable<System.DateTime> FEC_MEN
		{
			get
			{
				return this._FEC_MEN;
			}
			set
			{
				if ((this._FEC_MEN != value))
				{
					this.OnFEC_MENChanging(value);
					this.SendPropertyChanging();
					this._FEC_MEN = value;
					this.SendPropertyChanged("FEC_MEN");
					this.OnFEC_MENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MENU_DEL_DIA_PEDIDOS", Storage="_PEDIDOS", ThisKey="NUM_MEN", OtherKey="ID_MEN_PER")]
		public EntitySet<PEDIDOS> PEDIDOS
		{
			get
			{
				return this._PEDIDOS;
			}
			set
			{
				this._PEDIDOS.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BEBIDAS_MENU_DEL_DIA", Storage="_BEBIDAS", ThisKey="ID_BEB_PER", OtherKey="ID_BEB", IsForeignKey=true)]
		public BEBIDAS BEBIDAS
		{
			get
			{
				return this._BEBIDAS.Entity;
			}
			set
			{
				BEBIDAS previousValue = this._BEBIDAS.Entity;
				if (((previousValue != value) 
							|| (this._BEBIDAS.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BEBIDAS.Entity = null;
						previousValue.MENU_DEL_DIA.Remove(this);
					}
					this._BEBIDAS.Entity = value;
					if ((value != null))
					{
						value.MENU_DEL_DIA.Add(this);
						this._ID_BEB_PER = value.ID_BEB;
					}
					else
					{
						this._ID_BEB_PER = default(Nullable<int>);
					}
					this.SendPropertyChanged("BEBIDAS");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ENTRADAS_MENU_DEL_DIA", Storage="_ENTRADAS", ThisKey="ID_ENT_PER", OtherKey="ID_ENT", IsForeignKey=true)]
		public ENTRADAS ENTRADAS
		{
			get
			{
				return this._ENTRADAS.Entity;
			}
			set
			{
				ENTRADAS previousValue = this._ENTRADAS.Entity;
				if (((previousValue != value) 
							|| (this._ENTRADAS.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ENTRADAS.Entity = null;
						previousValue.MENU_DEL_DIA.Remove(this);
					}
					this._ENTRADAS.Entity = value;
					if ((value != null))
					{
						value.MENU_DEL_DIA.Add(this);
						this._ID_ENT_PER = value.ID_ENT;
					}
					else
					{
						this._ID_ENT_PER = default(Nullable<int>);
					}
					this.SendPropertyChanged("ENTRADAS");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SEGUNDOS_MENU_DEL_DIA", Storage="_SEGUNDOS", ThisKey="ID_SEG_PER", OtherKey="ID_SEG", IsForeignKey=true)]
		public SEGUNDOS SEGUNDOS
		{
			get
			{
				return this._SEGUNDOS.Entity;
			}
			set
			{
				SEGUNDOS previousValue = this._SEGUNDOS.Entity;
				if (((previousValue != value) 
							|| (this._SEGUNDOS.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SEGUNDOS.Entity = null;
						previousValue.MENU_DEL_DIA.Remove(this);
					}
					this._SEGUNDOS.Entity = value;
					if ((value != null))
					{
						value.MENU_DEL_DIA.Add(this);
						this._ID_SEG_PER = value.ID_SEG;
					}
					else
					{
						this._ID_SEG_PER = default(Nullable<int>);
					}
					this.SendPropertyChanged("SEGUNDOS");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SOPAS_MENU_DEL_DIA", Storage="_SOPAS", ThisKey="ID_SOP_PER", OtherKey="ID_SOP", IsForeignKey=true)]
		public SOPAS SOPAS
		{
			get
			{
				return this._SOPAS.Entity;
			}
			set
			{
				SOPAS previousValue = this._SOPAS.Entity;
				if (((previousValue != value) 
							|| (this._SOPAS.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SOPAS.Entity = null;
						previousValue.MENU_DEL_DIA.Remove(this);
					}
					this._SOPAS.Entity = value;
					if ((value != null))
					{
						value.MENU_DEL_DIA.Add(this);
						this._ID_SOP_PER = value.ID_SOP;
					}
					else
					{
						this._ID_SOP_PER = default(Nullable<int>);
					}
					this.SendPropertyChanged("SOPAS");
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
		
		private void attach_PEDIDOS(PEDIDOS entity)
		{
			this.SendPropertyChanging();
			entity.MENU_DEL_DIA = this;
		}
		
		private void detach_PEDIDOS(PEDIDOS entity)
		{
			this.SendPropertyChanging();
			entity.MENU_DEL_DIA = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SEGUNDOS")]
	public partial class SEGUNDOS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_SEG;
		
		private string _NOM_SEG;
		
		private System.Data.Linq.Binary _IMG_SEG;
		
		private string _ING_SEG;
		
		private EntitySet<MENU_DEL_DIA> _MENU_DEL_DIA;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_SEGChanging(int value);
    partial void OnID_SEGChanged();
    partial void OnNOM_SEGChanging(string value);
    partial void OnNOM_SEGChanged();
    partial void OnIMG_SEGChanging(System.Data.Linq.Binary value);
    partial void OnIMG_SEGChanged();
    partial void OnING_SEGChanging(string value);
    partial void OnING_SEGChanged();
    #endregion
		
		public SEGUNDOS()
		{
			this._MENU_DEL_DIA = new EntitySet<MENU_DEL_DIA>(new Action<MENU_DEL_DIA>(this.attach_MENU_DEL_DIA), new Action<MENU_DEL_DIA>(this.detach_MENU_DEL_DIA));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_SEG", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_SEG
		{
			get
			{
				return this._ID_SEG;
			}
			set
			{
				if ((this._ID_SEG != value))
				{
					this.OnID_SEGChanging(value);
					this.SendPropertyChanging();
					this._ID_SEG = value;
					this.SendPropertyChanged("ID_SEG");
					this.OnID_SEGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOM_SEG", DbType="VarChar(50)")]
		public string NOM_SEG
		{
			get
			{
				return this._NOM_SEG;
			}
			set
			{
				if ((this._NOM_SEG != value))
				{
					this.OnNOM_SEGChanging(value);
					this.SendPropertyChanging();
					this._NOM_SEG = value;
					this.SendPropertyChanged("NOM_SEG");
					this.OnNOM_SEGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMG_SEG", DbType="Image", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary IMG_SEG
		{
			get
			{
				return this._IMG_SEG;
			}
			set
			{
				if ((this._IMG_SEG != value))
				{
					this.OnIMG_SEGChanging(value);
					this.SendPropertyChanging();
					this._IMG_SEG = value;
					this.SendPropertyChanged("IMG_SEG");
					this.OnIMG_SEGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ING_SEG", DbType="VarChar(200)")]
		public string ING_SEG
		{
			get
			{
				return this._ING_SEG;
			}
			set
			{
				if ((this._ING_SEG != value))
				{
					this.OnING_SEGChanging(value);
					this.SendPropertyChanging();
					this._ING_SEG = value;
					this.SendPropertyChanged("ING_SEG");
					this.OnING_SEGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SEGUNDOS_MENU_DEL_DIA", Storage="_MENU_DEL_DIA", ThisKey="ID_SEG", OtherKey="ID_SEG_PER")]
		public EntitySet<MENU_DEL_DIA> MENU_DEL_DIA
		{
			get
			{
				return this._MENU_DEL_DIA;
			}
			set
			{
				this._MENU_DEL_DIA.Assign(value);
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
		
		private void attach_MENU_DEL_DIA(MENU_DEL_DIA entity)
		{
			this.SendPropertyChanging();
			entity.SEGUNDOS = this;
		}
		
		private void detach_MENU_DEL_DIA(MENU_DEL_DIA entity)
		{
			this.SendPropertyChanging();
			entity.SEGUNDOS = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SOPAS")]
	public partial class SOPAS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_SOP;
		
		private string _NOM_SOP;
		
		private System.Data.Linq.Binary _IMG_SOP;
		
		private string _ING_SOP;
		
		private EntitySet<MENU_DEL_DIA> _MENU_DEL_DIA;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_SOPChanging(int value);
    partial void OnID_SOPChanged();
    partial void OnNOM_SOPChanging(string value);
    partial void OnNOM_SOPChanged();
    partial void OnIMG_SOPChanging(System.Data.Linq.Binary value);
    partial void OnIMG_SOPChanged();
    partial void OnING_SOPChanging(string value);
    partial void OnING_SOPChanged();
    #endregion
		
		public SOPAS()
		{
			this._MENU_DEL_DIA = new EntitySet<MENU_DEL_DIA>(new Action<MENU_DEL_DIA>(this.attach_MENU_DEL_DIA), new Action<MENU_DEL_DIA>(this.detach_MENU_DEL_DIA));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_SOP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_SOP
		{
			get
			{
				return this._ID_SOP;
			}
			set
			{
				if ((this._ID_SOP != value))
				{
					this.OnID_SOPChanging(value);
					this.SendPropertyChanging();
					this._ID_SOP = value;
					this.SendPropertyChanged("ID_SOP");
					this.OnID_SOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOM_SOP", DbType="VarChar(50)")]
		public string NOM_SOP
		{
			get
			{
				return this._NOM_SOP;
			}
			set
			{
				if ((this._NOM_SOP != value))
				{
					this.OnNOM_SOPChanging(value);
					this.SendPropertyChanging();
					this._NOM_SOP = value;
					this.SendPropertyChanged("NOM_SOP");
					this.OnNOM_SOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMG_SOP", DbType="Image", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary IMG_SOP
		{
			get
			{
				return this._IMG_SOP;
			}
			set
			{
				if ((this._IMG_SOP != value))
				{
					this.OnIMG_SOPChanging(value);
					this.SendPropertyChanging();
					this._IMG_SOP = value;
					this.SendPropertyChanged("IMG_SOP");
					this.OnIMG_SOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ING_SOP", DbType="VarChar(200)")]
		public string ING_SOP
		{
			get
			{
				return this._ING_SOP;
			}
			set
			{
				if ((this._ING_SOP != value))
				{
					this.OnING_SOPChanging(value);
					this.SendPropertyChanging();
					this._ING_SOP = value;
					this.SendPropertyChanged("ING_SOP");
					this.OnING_SOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SOPAS_MENU_DEL_DIA", Storage="_MENU_DEL_DIA", ThisKey="ID_SOP", OtherKey="ID_SOP_PER")]
		public EntitySet<MENU_DEL_DIA> MENU_DEL_DIA
		{
			get
			{
				return this._MENU_DEL_DIA;
			}
			set
			{
				this._MENU_DEL_DIA.Assign(value);
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
		
		private void attach_MENU_DEL_DIA(MENU_DEL_DIA entity)
		{
			this.SendPropertyChanging();
			entity.SOPAS = this;
		}
		
		private void detach_MENU_DEL_DIA(MENU_DEL_DIA entity)
		{
			this.SendPropertyChanging();
			entity.SOPAS = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PEDIDOS")]
	public partial class PEDIDOS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_PED;
		
		private System.Nullable<int> _CAN_PED;
		
		private string _NOM_CLI_PED;
		
		private System.Nullable<int> _ID_MEN_PER;
		
		private EntityRef<MENU_DEL_DIA> _MENU_DEL_DIA;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_PEDChanging(int value);
    partial void OnID_PEDChanged();
    partial void OnCAN_PEDChanging(System.Nullable<int> value);
    partial void OnCAN_PEDChanged();
    partial void OnNOM_CLI_PEDChanging(string value);
    partial void OnNOM_CLI_PEDChanged();
    partial void OnID_MEN_PERChanging(System.Nullable<int> value);
    partial void OnID_MEN_PERChanged();
    #endregion
		
		public PEDIDOS()
		{
			this._MENU_DEL_DIA = default(EntityRef<MENU_DEL_DIA>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_PED", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_PED
		{
			get
			{
				return this._ID_PED;
			}
			set
			{
				if ((this._ID_PED != value))
				{
					this.OnID_PEDChanging(value);
					this.SendPropertyChanging();
					this._ID_PED = value;
					this.SendPropertyChanged("ID_PED");
					this.OnID_PEDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CAN_PED", DbType="Int")]
		public System.Nullable<int> CAN_PED
		{
			get
			{
				return this._CAN_PED;
			}
			set
			{
				if ((this._CAN_PED != value))
				{
					this.OnCAN_PEDChanging(value);
					this.SendPropertyChanging();
					this._CAN_PED = value;
					this.SendPropertyChanged("CAN_PED");
					this.OnCAN_PEDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOM_CLI_PED", DbType="VarChar(50)")]
		public string NOM_CLI_PED
		{
			get
			{
				return this._NOM_CLI_PED;
			}
			set
			{
				if ((this._NOM_CLI_PED != value))
				{
					this.OnNOM_CLI_PEDChanging(value);
					this.SendPropertyChanging();
					this._NOM_CLI_PED = value;
					this.SendPropertyChanged("NOM_CLI_PED");
					this.OnNOM_CLI_PEDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_MEN_PER", DbType="Int")]
		public System.Nullable<int> ID_MEN_PER
		{
			get
			{
				return this._ID_MEN_PER;
			}
			set
			{
				if ((this._ID_MEN_PER != value))
				{
					if (this._MENU_DEL_DIA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_MEN_PERChanging(value);
					this.SendPropertyChanging();
					this._ID_MEN_PER = value;
					this.SendPropertyChanged("ID_MEN_PER");
					this.OnID_MEN_PERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MENU_DEL_DIA_PEDIDOS", Storage="_MENU_DEL_DIA", ThisKey="ID_MEN_PER", OtherKey="NUM_MEN", IsForeignKey=true)]
		public MENU_DEL_DIA MENU_DEL_DIA
		{
			get
			{
				return this._MENU_DEL_DIA.Entity;
			}
			set
			{
				MENU_DEL_DIA previousValue = this._MENU_DEL_DIA.Entity;
				if (((previousValue != value) 
							|| (this._MENU_DEL_DIA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MENU_DEL_DIA.Entity = null;
						previousValue.PEDIDOS.Remove(this);
					}
					this._MENU_DEL_DIA.Entity = value;
					if ((value != null))
					{
						value.PEDIDOS.Add(this);
						this._ID_MEN_PER = value.NUM_MEN;
					}
					else
					{
						this._ID_MEN_PER = default(Nullable<int>);
					}
					this.SendPropertyChanged("MENU_DEL_DIA");
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
