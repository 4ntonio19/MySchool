﻿using MySchool.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities.School
{
    public class Schools
    {
        public Schools(string name, Address address, Email email, string phone, Document document)
        {
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
            Document = document;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public Email Email { get; set; }
        public string Phone { get; set; }
        public Document Document { get; set; }
    }
}
