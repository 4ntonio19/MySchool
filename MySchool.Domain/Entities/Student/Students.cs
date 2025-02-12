﻿using MySchool.Common.Entities;
using MySchool.Domain.Entities.School;
using MySchool.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities.Student
{
    public class Students : Entity
    {
        public Students(int id)
        {
            Id = id;
        }
        public Students(Name name, Document document, string age, Email email, Address address, Schools schools)
        {
            Name = name;
            Document = document;
            Age = age;
            Email = email;
            Address = address;
            Schools = schools;
        }

        public int Id { get; set; }
        public Name Name { get; set; }
        public Document Document { get; set; }
        public string Age { get; set; }
        public Email Email { get; set; }
        public Address Address { get; set; }
        public Schools Schools { get; set; }
    }
}
