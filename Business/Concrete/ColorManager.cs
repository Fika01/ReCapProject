using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class ColorManager : IColorService

    {
        IColorDal _colorDal;

        public ColorManager()
        {
        }

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public ColorManager(InMemoryColorDal ınMemoryColorDal)
        {
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
    }
}
