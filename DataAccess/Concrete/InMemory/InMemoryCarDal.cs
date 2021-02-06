using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2015,DailyPrice=200,Description="Araba1"},
                new Car{CarId=2,BrandId=2,ColorId=2,ModelYear=2017,DailyPrice=150,Description="Araba2"},
                new Car{CarId=3,BrandId=3,ColorId=3,ModelYear=2020,DailyPrice=500,Description="Araba3"},
                new Car{CarId=4,BrandId=4,ColorId=2,ModelYear=2018,DailyPrice=300,Description="Araba4"},
                new Car{CarId=5,BrandId=1,ColorId=2,ModelYear=2021,DailyPrice=600,Description="Araba5"},
                new Car{CarId=6,BrandId=2,ColorId=3,ModelYear=2016,DailyPrice=300,Description="Araba6"},
                new Car{CarId=7,BrandId=6,ColorId=1,ModelYear=2017,DailyPrice=200,Description="Araba7"},
                new Car{CarId=8,BrandId=2,ColorId=1,ModelYear=2014,DailyPrice=100,Description="Araba8"},
                new Car{CarId=9,BrandId=4,ColorId=3,ModelYear=2018,DailyPrice=200,Description="Araba9"},
                new Car{CarId=10,BrandId=3,ColorId=2,ModelYear=2019,DailyPrice=340,Description="Araba10"}


            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId); //car sınıfını çağırdık .cars daki ıd ile dışarıdan gönderilen ıd birbirine eşit olan satırı silecek. 
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
