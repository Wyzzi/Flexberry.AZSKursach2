﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.AZSKursach
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Чек.
    /// </summary>
    // *** Start programmer edit section *** (Чек CustomAttributes)

    // *** End programmer edit section *** (Чек CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЧекE", new string[] {
            "Дата as \'Дата\'",
            "Номер as \'Номер\'",
            "Клиент as \'ФИО клиента\'",
            "Сумма as \'Сумма\'",
            "ЗаправкаАвто as \'Заправка автомобиля\'"})]
    [AssociatedDetailViewAttribute("ЧекE", "ТЧТовары", "ТЧТоварыE", true, "", "Товары", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("ЧекE", "Клиент", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наимен")]
    [MasterViewDefineAttribute("ЧекE", "ЗаправкаАвто", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "КолТоп")]
    [View("ЧекL", new string[] {
            "Дата as \'Дата\'",
            "Номер as \'Номер\'",
            "Клиент.Наимен as \'ФИО клиента\'",
            "Сумма as \'Сумма\'",
            "ЗаправкаАвто.КолТоп as \'Количество топлива\'"})]
    public class Чек : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомер;
        
        private float fСумма;
        
        private System.DateTime fДата;
        
        private IIS.AZSKursach.Клиент fКлиент;
        
        private IIS.AZSKursach.ЗаправкаАвто fЗаправкаАвто;
        
        private IIS.AZSKursach.DetailArrayOfТЧТовары fТЧТовары;
        
        // *** Start programmer edit section *** (Чек CustomMembers)

        // *** End programmer edit section *** (Чек CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (Чек.Дата CustomAttributes)

        // *** End programmer edit section *** (Чек.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (Чек.Дата Get start)

                // *** End programmer edit section *** (Чек.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (Чек.Дата Get end)

                // *** End programmer edit section *** (Чек.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Чек.Дата Set start)

                // *** End programmer edit section *** (Чек.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (Чек.Дата Set end)

                // *** End programmer edit section *** (Чек.Дата Set end)
            }
        }
        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (Чек.Номер CustomAttributes)

        // *** End programmer edit section *** (Чек.Номер CustomAttributes)
        public virtual int Номер
        {
            get
            {
                // *** Start programmer edit section *** (Чек.Номер Get start)

                // *** End programmer edit section *** (Чек.Номер Get start)
                int result = this.fНомер;
                // *** Start programmer edit section *** (Чек.Номер Get end)

                // *** End programmer edit section *** (Чек.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Чек.Номер Set start)

                // *** End programmer edit section *** (Чек.Номер Set start)
                this.fНомер = value;
                // *** Start programmer edit section *** (Чек.Номер Set end)

                // *** End programmer edit section *** (Чек.Номер Set end)
            }
        }
        
        /// <summary>
        /// Сумма.
        /// </summary>
        // *** Start programmer edit section *** (Чек.Сумма CustomAttributes)

        // *** End programmer edit section *** (Чек.Сумма CustomAttributes)
        public virtual float Сумма
        {
            get
            {
                // *** Start programmer edit section *** (Чек.Сумма Get start)

                // *** End programmer edit section *** (Чек.Сумма Get start)
                float result = this.fСумма;
                // *** Start programmer edit section *** (Чек.Сумма Get end)

                // *** End programmer edit section *** (Чек.Сумма Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Чек.Сумма Set start)

                // *** End programmer edit section *** (Чек.Сумма Set start)
                this.fСумма = value;
                // *** Start programmer edit section *** (Чек.Сумма Set end)

                // *** End programmer edit section *** (Чек.Сумма Set end)
            }
        }
        
        /// <summary>
        /// Чек.
        /// </summary>
        // *** Start programmer edit section *** (Чек.ЗаправкаАвто CustomAttributes)

        // *** End programmer edit section *** (Чек.ЗаправкаАвто CustomAttributes)
        [PropertyStorage(new string[] {
                "ЗаправкаАвто"})]
        [NotNull()]
        public virtual IIS.AZSKursach.ЗаправкаАвто ЗаправкаАвто
        {
            get
            {
                // *** Start programmer edit section *** (Чек.ЗаправкаАвто Get start)

                // *** End programmer edit section *** (Чек.ЗаправкаАвто Get start)
                IIS.AZSKursach.ЗаправкаАвто result = this.fЗаправкаАвто;
                // *** Start programmer edit section *** (Чек.ЗаправкаАвто Get end)

                // *** End programmer edit section *** (Чек.ЗаправкаАвто Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Чек.ЗаправкаАвто Set start)

                // *** End programmer edit section *** (Чек.ЗаправкаАвто Set start)
                this.fЗаправкаАвто = value;
                // *** Start programmer edit section *** (Чек.ЗаправкаАвто Set end)

                // *** End programmer edit section *** (Чек.ЗаправкаАвто Set end)
            }
        }
        
        /// <summary>
        /// Чек.
        /// </summary>
        // *** Start programmer edit section *** (Чек.Клиент CustomAttributes)

        // *** End programmer edit section *** (Чек.Клиент CustomAttributes)
        [PropertyStorage(new string[] {
                "Клиент"})]
        [NotNull()]
        public virtual IIS.AZSKursach.Клиент Клиент
        {
            get
            {
                // *** Start programmer edit section *** (Чек.Клиент Get start)

                // *** End programmer edit section *** (Чек.Клиент Get start)
                IIS.AZSKursach.Клиент result = this.fКлиент;
                // *** Start programmer edit section *** (Чек.Клиент Get end)

                // *** End programmer edit section *** (Чек.Клиент Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Чек.Клиент Set start)

                // *** End programmer edit section *** (Чек.Клиент Set start)
                this.fКлиент = value;
                // *** Start programmer edit section *** (Чек.Клиент Set end)

                // *** End programmer edit section *** (Чек.Клиент Set end)
            }
        }
        
        /// <summary>
        /// Чек.
        /// </summary>
        // *** Start programmer edit section *** (Чек.ТЧТовары CustomAttributes)

        // *** End programmer edit section *** (Чек.ТЧТовары CustomAttributes)
        public virtual IIS.AZSKursach.DetailArrayOfТЧТовары ТЧТовары
        {
            get
            {
                // *** Start programmer edit section *** (Чек.ТЧТовары Get start)

                // *** End programmer edit section *** (Чек.ТЧТовары Get start)
                if ((this.fТЧТовары == null))
                {
                    this.fТЧТовары = new IIS.AZSKursach.DetailArrayOfТЧТовары(this);
                }
                IIS.AZSKursach.DetailArrayOfТЧТовары result = this.fТЧТовары;
                // *** Start programmer edit section *** (Чек.ТЧТовары Get end)

                // *** End programmer edit section *** (Чек.ТЧТовары Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Чек.ТЧТовары Set start)

                // *** End programmer edit section *** (Чек.ТЧТовары Set start)
                this.fТЧТовары = value;
                // *** Start programmer edit section *** (Чек.ТЧТовары Set end)

                // *** End programmer edit section *** (Чек.ТЧТовары Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЧекE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЧекE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЧекE", typeof(IIS.AZSKursach.Чек));
                }
            }
            
            /// <summary>
            /// "ЧекL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЧекL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЧекL", typeof(IIS.AZSKursach.Чек));
                }
            }
        }
    }
}
