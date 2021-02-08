using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Entities.Concrete.Color entity)
        {
            using (var context = new NorthwindRentACarContext())
            {
                var addedColor = context.Entry(entity);
                addedColor.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Entities.Concrete.Color entity)
        {
            using (NorthwindRentACarContext context = new NorthwindRentACarContext())
            {
                var deletedColor = context.Entry(entity);
                deletedColor.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Entities.Concrete.Color Get(Expression<Func<Entities.Concrete.Color, bool>> filter)
        {
            using (NorthwindRentACarContext context = new NorthwindRentACarContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Entities.Concrete.Color> GetAll(Expression<Func<Entities.Concrete.Color, bool>> filter = null)
        {
            using (NorthwindRentACarContext context = new NorthwindRentACarContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Entities.Concrete.Color entity)
        {
            using (NorthwindRentACarContext context = new NorthwindRentACarContext())
            {
                var updatedColor = context.Entry(entity);
                updatedColor.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
