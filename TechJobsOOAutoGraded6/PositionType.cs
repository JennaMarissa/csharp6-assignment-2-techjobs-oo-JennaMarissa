﻿using System;
namespace TechJobsOOAutoGraded6
{
	public class PositionType : JobField
	{
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public PositionType()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        //public PositionType(string value) : this()
        //{
        //    Value = value;
        //}

        public PositionType(string value) : base(value)
        {
        }

        // DONE TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.
        //public override string ToString()
        //{
        //    return Value;
        //}

        //public override bool Equals(object obj)
        //{
        //    return obj is PositionType positiontype &&
        //           Id == positiontype.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}
    }
}

