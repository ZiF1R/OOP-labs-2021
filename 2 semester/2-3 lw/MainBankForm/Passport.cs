﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace _2_lw
{
    [Serializable]
    [DataContract]
    public class Passport
    {
        [DataMember]
        [Required]
        [StringLength(14, ErrorMessage = "Passport number must be 14-symbol string!")]
        private string number;

        [DataMember]
        public DateTimeOffset ExpiresDate { get; set; }

        public string Number
        {
            get => this.number;
            set
            {
                if (value.Length == 14)
                    this.number = value;
            }
        }

        public Passport() { }

        public Passport(string number, DateTimeOffset expiresDate)
        {
            this.ExpiresDate = expiresDate;
            this.Number = number;
        }

        public override string ToString()
        {
            return $"{this.Number}:{this.ExpiresDate}";
        }
    }
}
