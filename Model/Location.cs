﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SensorDataGenerator.Model
{
    /// <summary>
    /// Represents a location/project placeholder
    /// </summary>
    class Location
    {
        /// <summary>
        /// Max number of people of the location
        /// </summary>
        public int MaxPersons { get; set; }
        /// <summary>
        /// Current number of people
        /// </summary>
        public int CurrentPersons { get; set; }
        /// <summary>
        /// Sensors in the location to monitor 
        /// </summary>
        public List<SensorData> Sensors { get; set; }
        /// <summary>
        /// The current datatime to calculate for
        /// </summary>
        public DateTime CalculatingDateTime { get; set; }

        /// <summary>
        /// Constructor for the location
        /// </summary>
        /// <param name="_calculatingDateTime">The date we are calculating for</param>
        public Location(DateTime _calculatingDateTime, int _sensors)
        {
            MaxPersons = 100;
            CurrentPersons = 0;
            CalculatingDateTime = _calculatingDateTime;
            Sensors = new List<SensorData>();
            for (int i = 0; i < _sensors; i++)
            {
                Sensors.Add(new SensorData(i, Helper.DateToStamp(_calculatingDateTime)));
            }
        }
    }
}
