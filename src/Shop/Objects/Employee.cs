﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Shop
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Employee.
    /// </summary>
    // *** Start programmer edit section *** (Employee CustomAttributes)

    // *** End programmer edit section *** (Employee CustomAttributes)
    [AutoAltered()]
    [Caption("Сотрудник")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("EmployeeE", new string[] {
            "Number as \'Табельный номер\'",
            "LastName as \'Фамилия\'",
            "FirstName as \'Имя\'",
            "MiddleName as \'Отчество\'",
            "PhoneNumber as \'Телефон\'",
            "Email as \'Электронная почта\'",
            "Position as \'Должность\'"})]
    [View("EmployeeL", new string[] {
            "Number as \'Табельный номер\'",
            "LastName as \'Фамилия\'",
            "FirstName as \'Имя\'",
            "MiddleName as \'Отчество\'",
            "PhoneNumber as \'Телефон\'",
            "Email as \'Электронная почта\'",
            "Position as \'Должность\'"})]
    public class Employee : ICSSoft.STORMNET.DataObject
    {
        
        private int fNumber = 1;
        
        private string fLastName;
        
        private string fFirstName;
        
        private string fMiddleName;
        
        private string fPhoneNumber;
        
        private string fEmail;
        
        private IIS.Shop.PositionList fPosition;
        
        // *** Start programmer edit section *** (Employee CustomMembers)

        // *** End programmer edit section *** (Employee CustomMembers)

        
        /// <summary>
        /// Number.
        /// </summary>
        // *** Start programmer edit section *** (Employee.Number CustomAttributes)

        // *** End programmer edit section *** (Employee.Number CustomAttributes)
        [NotNull()]
        public virtual int Number
        {
            get
            {
                // *** Start programmer edit section *** (Employee.Number Get start)

                // *** End programmer edit section *** (Employee.Number Get start)
                int result = this.fNumber;
                // *** Start programmer edit section *** (Employee.Number Get end)

                // *** End programmer edit section *** (Employee.Number Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Employee.Number Set start)

                // *** End programmer edit section *** (Employee.Number Set start)
                this.fNumber = value;
                // *** Start programmer edit section *** (Employee.Number Set end)

                // *** End programmer edit section *** (Employee.Number Set end)
            }
        }
        
        /// <summary>
        /// LastName.
        /// </summary>
        // *** Start programmer edit section *** (Employee.LastName CustomAttributes)

        // *** End programmer edit section *** (Employee.LastName CustomAttributes)
        [StrLen(255)]
        public virtual string LastName
        {
            get
            {
                // *** Start programmer edit section *** (Employee.LastName Get start)

                // *** End programmer edit section *** (Employee.LastName Get start)
                string result = this.fLastName;
                // *** Start programmer edit section *** (Employee.LastName Get end)

                // *** End programmer edit section *** (Employee.LastName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Employee.LastName Set start)

                // *** End programmer edit section *** (Employee.LastName Set start)
                this.fLastName = value;
                // *** Start programmer edit section *** (Employee.LastName Set end)

                // *** End programmer edit section *** (Employee.LastName Set end)
            }
        }
        
        /// <summary>
        /// FirstName.
        /// </summary>
        // *** Start programmer edit section *** (Employee.FirstName CustomAttributes)

        // *** End programmer edit section *** (Employee.FirstName CustomAttributes)
        [StrLen(255)]
        public virtual string FirstName
        {
            get
            {
                // *** Start programmer edit section *** (Employee.FirstName Get start)

                // *** End programmer edit section *** (Employee.FirstName Get start)
                string result = this.fFirstName;
                // *** Start programmer edit section *** (Employee.FirstName Get end)

                // *** End programmer edit section *** (Employee.FirstName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Employee.FirstName Set start)

                // *** End programmer edit section *** (Employee.FirstName Set start)
                this.fFirstName = value;
                // *** Start programmer edit section *** (Employee.FirstName Set end)

                // *** End programmer edit section *** (Employee.FirstName Set end)
            }
        }
        
        /// <summary>
        /// MiddleName.
        /// </summary>
        // *** Start programmer edit section *** (Employee.MiddleName CustomAttributes)

        // *** End programmer edit section *** (Employee.MiddleName CustomAttributes)
        [StrLen(255)]
        public virtual string MiddleName
        {
            get
            {
                // *** Start programmer edit section *** (Employee.MiddleName Get start)

                // *** End programmer edit section *** (Employee.MiddleName Get start)
                string result = this.fMiddleName;
                // *** Start programmer edit section *** (Employee.MiddleName Get end)

                // *** End programmer edit section *** (Employee.MiddleName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Employee.MiddleName Set start)

                // *** End programmer edit section *** (Employee.MiddleName Set start)
                this.fMiddleName = value;
                // *** Start programmer edit section *** (Employee.MiddleName Set end)

                // *** End programmer edit section *** (Employee.MiddleName Set end)
            }
        }
        
        /// <summary>
        /// PhoneNumber.
        /// </summary>
        // *** Start programmer edit section *** (Employee.PhoneNumber CustomAttributes)

        // *** End programmer edit section *** (Employee.PhoneNumber CustomAttributes)
        [StrLen(255)]
        public virtual string PhoneNumber
        {
            get
            {
                // *** Start programmer edit section *** (Employee.PhoneNumber Get start)

                // *** End programmer edit section *** (Employee.PhoneNumber Get start)
                string result = this.fPhoneNumber;
                // *** Start programmer edit section *** (Employee.PhoneNumber Get end)

                // *** End programmer edit section *** (Employee.PhoneNumber Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Employee.PhoneNumber Set start)

                // *** End programmer edit section *** (Employee.PhoneNumber Set start)
                this.fPhoneNumber = value;
                // *** Start programmer edit section *** (Employee.PhoneNumber Set end)

                // *** End programmer edit section *** (Employee.PhoneNumber Set end)
            }
        }
        
        /// <summary>
        /// Email.
        /// </summary>
        // *** Start programmer edit section *** (Employee.Email CustomAttributes)

        // *** End programmer edit section *** (Employee.Email CustomAttributes)
        [StrLen(255)]
        public virtual string Email
        {
            get
            {
                // *** Start programmer edit section *** (Employee.Email Get start)

                // *** End programmer edit section *** (Employee.Email Get start)
                string result = this.fEmail;
                // *** Start programmer edit section *** (Employee.Email Get end)

                // *** End programmer edit section *** (Employee.Email Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Employee.Email Set start)

                // *** End programmer edit section *** (Employee.Email Set start)
                this.fEmail = value;
                // *** Start programmer edit section *** (Employee.Email Set end)

                // *** End programmer edit section *** (Employee.Email Set end)
            }
        }
        
        /// <summary>
        /// Position.
        /// </summary>
        // *** Start programmer edit section *** (Employee.Position CustomAttributes)

        // *** End programmer edit section *** (Employee.Position CustomAttributes)
        public virtual IIS.Shop.PositionList Position
        {
            get
            {
                // *** Start programmer edit section *** (Employee.Position Get start)

                // *** End programmer edit section *** (Employee.Position Get start)
                IIS.Shop.PositionList result = this.fPosition;
                // *** Start programmer edit section *** (Employee.Position Get end)

                // *** End programmer edit section *** (Employee.Position Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Employee.Position Set start)

                // *** End programmer edit section *** (Employee.Position Set start)
                this.fPosition = value;
                // *** Start programmer edit section *** (Employee.Position Set end)

                // *** End programmer edit section *** (Employee.Position Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "EmployeeE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EmployeeE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EmployeeE", typeof(IIS.Shop.Employee));
                }
            }
            
            /// <summary>
            /// "EmployeeL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EmployeeL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EmployeeL", typeof(IIS.Shop.Employee));
                }
            }
        }
    }
}
