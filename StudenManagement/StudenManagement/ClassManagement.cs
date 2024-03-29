﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenManagement
{
    public class ClassManagement
    {
        public Class[] GetClasses()
        {
            var db = new OOPCSEntities();
            return db.Class.ToArray();
        }

        public void AddClass(string name , string description)
        {
            var newClass = new Class();
            newClass.Name = name;
            newClass.Description = description;

            var db = new OOPCSEntities();
            db.Class.Add(newClass);
            db.SaveChanges();
        }

        public void EditClass(int id , string name , string description)
        {
            var db = new OOPCSEntities();
            var oldClass = db.Class.Find(id);

            oldClass.Name = name;
            oldClass.Description = description;
            db.Entry(oldClass).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteClass(int id)
        {
            var db = new OOPCSEntities();
            var @class = db.Class.Find(id);
            db.Class.Remove(@class);
            //db.Entry(@class).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        public Class GetClass(int id)
        {
            var db = new OOPCSEntities();
            return db.Class.Find(id);
        }
    }
}
