//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class vWeatherHistory
    {
        public int Historyid { get; set; }
        public string CityName { get; set; }
        public Nullable<double> Temperature { get; set; }
        public Nullable<System.DateTime> WeatherDate { get; set; }
        public Nullable<double> Pressure { get; set; }
        public Nullable<double> Humidity { get; set; }
        public Nullable<double> WindSpeed { get; set; }
    }
}