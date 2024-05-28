using System.Collections.Generic;
using System.Linq;

using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                  new Car {name="Tesla Model S",
                    shortdesc="Быстрый автомобиль",
                    longdesc="Красивый, быстрый и очень тихий автомобиль компании Tesla",
                    img="https://cdn.pixabay.com/photo/2021/04/08/16/28/tesla-6162269_1280.jpg",
                    price=45000,
                    isFavourite=true,
                    available=true,
                    Category=_categoryCars.AllCategories.First()
                  },
                   new Car {name="Ford Fiesta",
                    shortdesc="тихий и спокойный",
                    longdesc="Удобный автомобиль для городской жизни",
                    img="https://cdn.pixabay.com/photo/2018/02/17/19/40/ford-fiesta-st-3160717_1280.jpg",
                    price=11000,
                    isFavourite=false,
                    available=true,
                    Category=_categoryCars.AllCategories.Last()
                  },
                   new Car {name="BMW M3",
                    shortdesc="Дерзкий и стильный",
                    longdesc="Удобный автомобиль для городской жизни",
                    img="https://cdn.pixabay.com/photo/2016/10/04/05/16/stance-1713593_1280.jpg",
                    price=65000,
                    isFavourite=true,
                    available=true,
                    Category=_categoryCars.AllCategories.Last()
                  },
                   new Car {name="Mercedes C class",
                    shortdesc="Уютный и большой",
                    longdesc="Удобный автомобиль для городской жизни",
                    img="https://cdn.pixabay.com/photo/2016/05/03/23/46/mercedes-benz-1370536_1280.jpg",
                    price=40000,
                    isFavourite=false,
                    available=false,
                    Category=_categoryCars.AllCategories.Last()
                  },
                   new Car {name="Nissan Leaf",
                    shortdesc="Безшумный и экономичный",
                    longdesc="Уютный автомобиль для городской жизни",
                    img="https://cdn.pixabay.com/photo/2017/02/10/19/09/car-2056009_1280.jpg",
                    price=14000,
                    isFavourite=true,
                    available=true,
                    Category=_categoryCars.AllCategories.First()
                  },
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
