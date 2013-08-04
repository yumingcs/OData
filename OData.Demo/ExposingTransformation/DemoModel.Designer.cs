﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("ODataDemoModel", "FK_Employee_Address", "Address", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ExposingTransformation.Address), "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ExposingTransformation.Employee), true)]
[assembly: EdmRelationshipAttribute("ODataDemoModel", "FK_Employee_Department", "Department", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ExposingTransformation.Department), "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ExposingTransformation.Employee), true)]

#endregion

namespace ExposingTransformation
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ODataDemoEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ODataDemoEntities object using the connection string found in the 'ODataDemoEntities' section of the application configuration file.
        /// </summary>
        public ODataDemoEntities() : base("name=ODataDemoEntities", "ODataDemoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ODataDemoEntities object.
        /// </summary>
        public ODataDemoEntities(string connectionString) : base(connectionString, "ODataDemoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ODataDemoEntities object.
        /// </summary>
        public ODataDemoEntities(EntityConnection connection) : base(connection, "ODataDemoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Address> Address
        {
            get
            {
                if ((_Address == null))
                {
                    _Address = base.CreateObjectSet<Address>("Address");
                }
                return _Address;
            }
        }
        private ObjectSet<Address> _Address;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Department> Department
        {
            get
            {
                if ((_Department == null))
                {
                    _Department = base.CreateObjectSet<Department>("Department");
                }
                return _Department;
            }
        }
        private ObjectSet<Department> _Department;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> Employee
        {
            get
            {
                if ((_Employee == null))
                {
                    _Employee = base.CreateObjectSet<Employee>("Employee");
                }
                return _Employee;
            }
        }
        private ObjectSet<Employee> _Employee;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Address EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAddress(Address address)
        {
            base.AddObject("Address", address);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Department EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDepartment(Department department)
        {
            base.AddObject("Department", department);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employee EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployee(Employee employee)
        {
            base.AddObject("Employee", employee);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ODataDemoModel", Name="Address")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Address : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Address object.
        /// </summary>
        /// <param name="addressID">Initial value of the AddressID property.</param>
        /// <param name="streetNumber">Initial value of the StreetNumber property.</param>
        /// <param name="streetName">Initial value of the StreetName property.</param>
        public static Address CreateAddress(global::System.Int32 addressID, global::System.Int32 streetNumber, global::System.String streetName)
        {
            Address address = new Address();
            address.AddressID = addressID;
            address.StreetNumber = streetNumber;
            address.StreetName = streetName;
            return address;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AddressID
        {
            get
            {
                return _AddressID;
            }
            set
            {
                if (_AddressID != value)
                {
                    OnAddressIDChanging(value);
                    ReportPropertyChanging("AddressID");
                    _AddressID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AddressID");
                    OnAddressIDChanged();
                }
            }
        }
        private global::System.Int32 _AddressID;
        partial void OnAddressIDChanging(global::System.Int32 value);
        partial void OnAddressIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StreetNumber
        {
            get
            {
                return _StreetNumber;
            }
            set
            {
                OnStreetNumberChanging(value);
                ReportPropertyChanging("StreetNumber");
                _StreetNumber = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StreetNumber");
                OnStreetNumberChanged();
            }
        }
        private global::System.Int32 _StreetNumber;
        partial void OnStreetNumberChanging(global::System.Int32 value);
        partial void OnStreetNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String StreetName
        {
            get
            {
                return _StreetName;
            }
            set
            {
                OnStreetNameChanging(value);
                ReportPropertyChanging("StreetName");
                _StreetName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("StreetName");
                OnStreetNameChanged();
            }
        }
        private global::System.String _StreetName;
        partial void OnStreetNameChanging(global::System.String value);
        partial void OnStreetNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ODataDemoModel", "FK_Employee_Address", "Employee")]
        public EntityCollection<Employee> Employee
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Employee>("ODataDemoModel.FK_Employee_Address", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Employee>("ODataDemoModel.FK_Employee_Address", "Employee", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ODataDemoModel", Name="Department")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Department : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Department object.
        /// </summary>
        /// <param name="departmentID">Initial value of the DepartmentID property.</param>
        /// <param name="departmentName">Initial value of the DepartmentName property.</param>
        public static Department CreateDepartment(global::System.Int32 departmentID, global::System.String departmentName)
        {
            Department department = new Department();
            department.DepartmentID = departmentID;
            department.DepartmentName = departmentName;
            return department;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DepartmentID
        {
            get
            {
                return _DepartmentID;
            }
            set
            {
                if (_DepartmentID != value)
                {
                    OnDepartmentIDChanging(value);
                    ReportPropertyChanging("DepartmentID");
                    _DepartmentID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DepartmentID");
                    OnDepartmentIDChanged();
                }
            }
        }
        private global::System.Int32 _DepartmentID;
        partial void OnDepartmentIDChanging(global::System.Int32 value);
        partial void OnDepartmentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DepartmentName
        {
            get
            {
                return _DepartmentName;
            }
            set
            {
                OnDepartmentNameChanging(value);
                ReportPropertyChanging("DepartmentName");
                _DepartmentName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DepartmentName");
                OnDepartmentNameChanged();
            }
        }
        private global::System.String _DepartmentName;
        partial void OnDepartmentNameChanging(global::System.String value);
        partial void OnDepartmentNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ODataDemoModel", "FK_Employee_Department", "Employee")]
        public EntityCollection<Employee> Employee
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Employee>("ODataDemoModel.FK_Employee_Department", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Employee>("ODataDemoModel.FK_Employee_Department", "Employee", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ODataDemoModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="employeeID">Initial value of the EmployeeID property.</param>
        /// <param name="departmentID">Initial value of the DepartmentID property.</param>
        /// <param name="addressID">Initial value of the AddressID property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        public static Employee CreateEmployee(global::System.Int32 employeeID, global::System.Int32 departmentID, global::System.Int32 addressID, global::System.String firstName, global::System.String lastName)
        {
            Employee employee = new Employee();
            employee.EmployeeID = employeeID;
            employee.DepartmentID = departmentID;
            employee.AddressID = addressID;
            employee.FirstName = firstName;
            employee.LastName = lastName;
            return employee;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                if (_EmployeeID != value)
                {
                    OnEmployeeIDChanging(value);
                    ReportPropertyChanging("EmployeeID");
                    _EmployeeID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmployeeID");
                    OnEmployeeIDChanged();
                }
            }
        }
        private global::System.Int32 _EmployeeID;
        partial void OnEmployeeIDChanging(global::System.Int32 value);
        partial void OnEmployeeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DepartmentID
        {
            get
            {
                return _DepartmentID;
            }
            set
            {
                OnDepartmentIDChanging(value);
                ReportPropertyChanging("DepartmentID");
                _DepartmentID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DepartmentID");
                OnDepartmentIDChanged();
            }
        }
        private global::System.Int32 _DepartmentID;
        partial void OnDepartmentIDChanging(global::System.Int32 value);
        partial void OnDepartmentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AddressID
        {
            get
            {
                return _AddressID;
            }
            set
            {
                OnAddressIDChanging(value);
                ReportPropertyChanging("AddressID");
                _AddressID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AddressID");
                OnAddressIDChanged();
            }
        }
        private global::System.Int32 _AddressID;
        partial void OnAddressIDChanging(global::System.Int32 value);
        partial void OnAddressIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ODataDemoModel", "FK_Employee_Address", "Address")]
        public Address Address
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Address>("ODataDemoModel.FK_Employee_Address", "Address").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Address>("ODataDemoModel.FK_Employee_Address", "Address").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Address> AddressReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Address>("ODataDemoModel.FK_Employee_Address", "Address");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Address>("ODataDemoModel.FK_Employee_Address", "Address", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ODataDemoModel", "FK_Employee_Department", "Department")]
        public Department Department
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("ODataDemoModel.FK_Employee_Department", "Department").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("ODataDemoModel.FK_Employee_Department", "Department").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Department> DepartmentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("ODataDemoModel.FK_Employee_Department", "Department");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Department>("ODataDemoModel.FK_Employee_Department", "Department", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
