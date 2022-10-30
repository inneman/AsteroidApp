using System;
using System.Collections.Generic;
using System.Text;

namespace AsteroidApp.Models
{
    class DangerousObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Is_potentially_hazardous_asteroid { get; set; }

        public string Nasa_jpl_url { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} \t Jméno: {Name.Substring(0, (Name.Length > 20 ? 20 : Name.Length)),-20} " +
                $"\t Nebezpečný: {Is_potentially_hazardous_asteroid,-20}" +
                $" Odkaz: {Nasa_jpl_url} \n";
        }
    }
}
