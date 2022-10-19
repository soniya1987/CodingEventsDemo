﻿using System;

namespace CodingEventsDemo.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int NumberOfAttendees { get; set; }
        public int MustRegister{ get; set; }
        public int  Id { get; }
        private static int nextId = 1;
        public Event()
        {
            Id = nextId;
            nextId++;
        }
        public Event(string name, string description, string location, int numberOfAttendees, int mustRegister) : this()
        {
            Name = name;
            Description = description;
            Location = location;
            NumberOfAttendees = numberOfAttendees;
            MustRegister= mustRegister;
        }


        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
