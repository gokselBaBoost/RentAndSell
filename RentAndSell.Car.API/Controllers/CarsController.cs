using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentAndSell.Car.API.Commons.Enums;
using RentAndSell.Car.API.Data;
using RentAndSell.Car.API.Data.Entities.Concrete;

namespace RentAndSell.Car.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private static List<Araba> cars = new List<Araba>();
        private CarRentDbContext _dbContext;
        private IQueryable<Araba> _activeAndNotDeletedCars;
        public CarsController(CarRentDbContext dbContext)
        {
            _dbContext = dbContext;
            _activeAndNotDeletedCars = _dbContext.Arabalar.Where(a => a.IsActive == true && a.IsDeleted == false);
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_activeAndNotDeletedCars.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_activeAndNotDeletedCars.Where(a => a.Id == id).SingleOrDefault());
        }

        [HttpPost]
        public ActionResult Post(Araba car)
        {
            _dbContext.Arabalar.Add(car);
            
            //ArabaTarihce arabaTarihce = new ArabaTarihce();
            //arabaTarihce.Marka = car.Marka;
            //arabaTarihce.Model = car.Model;
            //arabaTarihce.Yili = car.Yili;
            //arabaTarihce.YakitTuru = car.YakitTuru;
            //arabaTarihce.SanzimanTipi = car.SanzimanTipi;
            //arabaTarihce.MotorTipi = car.MotorTipi;
            //arabaTarihce.IsActive = car.IsActive;
            //arabaTarihce.IsDeleted = car.IsDeleted;
            //arabaTarihce.IslemTipi = IslemTipi.Inserted;
            //arabaTarihce.IslemZamani = DateTime.Now;

            //_dbContext.ArabaTarihcesi.Add(arabaTarihce);

            _dbContext.SaveChanges();

            return Created();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Araba car)
        {
            //Araba? readAraba = _activeAndNotDeletedCars.AsNoTracking()
            //                                     .Where(a => a.Id == id)
            //                                     .SingleOrDefault();

            Araba? readAraba = _activeAndNotDeletedCars.Where(a => a.Id == id)
                                                       .SingleOrDefault();


            if (readAraba != null)
            {
                readAraba.Marka = car.Marka;
                readAraba.Model = car.Model;
                readAraba.Yili = car.Yili;
                readAraba.MotorTipi = car.MotorTipi;
                readAraba.SanzimanTipi = car.SanzimanTipi;
                readAraba.YakitTuru = car.YakitTuru;
                readAraba.Updated = DateTime.Now;

                //ArabaTarihce arabaTarihce = new ArabaTarihce();
                //arabaTarihce.Marka = car.Marka;
                //arabaTarihce.Model = car.Model;
                //arabaTarihce.Yili = car.Yili;
                //arabaTarihce.YakitTuru = car.YakitTuru;
                //arabaTarihce.SanzimanTipi = car.SanzimanTipi;
                //arabaTarihce.MotorTipi = car.MotorTipi;
                //arabaTarihce.IsActive = car.IsActive;
                //arabaTarihce.IsDeleted = car.IsDeleted;
                //arabaTarihce.IslemTipi = IslemTipi.Updated;
                //arabaTarihce.IslemZamani = DateTime.Now;

                //_dbContext.ArabaTarihcesi.Add(arabaTarihce);

                //_dbContext.Arabalar.Update(readAraba);
                _dbContext.SaveChanges();
                return NoContent();
            }

            return StatusCode(503, "Güncelleme İşlemi yapılamadı");
            
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Araba? readAraba = _activeAndNotDeletedCars.AsNoTracking()
                                                 .Where(a => a.Id == id)
                                                 .SingleOrDefault();

            if (readAraba != null)
            {
                _dbContext.Arabalar.Remove(readAraba);


                //ArabaTarihce arabaTarihce = new ArabaTarihce();
                //arabaTarihce.Marka = readAraba.Marka;
                //arabaTarihce.Model = readAraba.Model;
                //arabaTarihce.Yili = readAraba.Yili;
                //arabaTarihce.YakitTuru = readAraba.YakitTuru;
                //arabaTarihce.SanzimanTipi = readAraba.SanzimanTipi;
                //arabaTarihce.MotorTipi = readAraba.MotorTipi;
                //arabaTarihce.IsActive = readAraba.IsActive;
                //arabaTarihce.IsDeleted = readAraba.IsDeleted;
                //arabaTarihce.IslemTipi = IslemTipi.Deleted;
                //arabaTarihce.IslemZamani = DateTime.Now;

                //_dbContext.ArabaTarihcesi.Add(arabaTarihce);

                _dbContext.SaveChanges();
                return NoContent();
            }

            return StatusCode(503, "Silme İşlemi yapılamadı");
        }


        [HttpGet("Yili/{year:range(1980,2024)}")]
        public ActionResult Filter(int year)
        {
            return Ok(_activeAndNotDeletedCars.AsNoTracking().Where(a => a.Yili == year).ToList());
        }

        [HttpGet("Yili/{year:range(1980,2024)}/Markasi/{brand:alpha}")]
        public ActionResult Filter(int year, string brand)
        {
            return Ok(_activeAndNotDeletedCars.AsNoTracking().Where(a => a.Yili == year && a.Marka == brand).ToList());
        }

        [HttpGet("Yili/{year:range(1980,2024)}/Markasi/{brand:alpha}/Modeli/{model}")]
        public ActionResult Filter(int year, string brand, string model)
        {
            return Ok(_activeAndNotDeletedCars.AsNoTracking()
                                              .Where(a => a.Yili == year && a.Marka == brand && a.Model == model)
                                              .ToList());
        }
    }
}
