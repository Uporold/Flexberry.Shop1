//------------------------------------------------------------------------------
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
    /// Order status.
    /// </summary>
    // *** Start programmer edit section *** (OrderStatus CustomAttributes)

    // *** End programmer edit section *** (OrderStatus CustomAttributes)
    public enum OrderStatus
    {
        
        // *** Start programmer edit section *** (OrderStatus.New CustomAttributes)

        // *** End programmer edit section *** (OrderStatus.New CustomAttributes)
        [Caption("Новый")]
        New,
        
        // *** Start programmer edit section *** (OrderStatus.Paid CustomAttributes)

        // *** End programmer edit section *** (OrderStatus.Paid CustomAttributes)
        [Caption("Оплаченный")]
        Paid,
        
        // *** Start programmer edit section *** (OrderStatus.Canceled CustomAttributes)

        // *** End programmer edit section *** (OrderStatus.Canceled CustomAttributes)
        [Caption("Отмененный")]
        Canceled,
    }
}
