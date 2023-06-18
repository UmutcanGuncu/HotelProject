using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDAL _testimonialDAL;

        public TestimonialManager(ITestimonialDAL testimonialDAL)
        {
            _testimonialDAL = testimonialDAL;
        }

        public void Delete(Testimonial t)
        {
            _testimonialDAL.Delete(t);
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDAL.GetById(id);
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDAL.GetList();
        }

        public void Insert(Testimonial t)
        {
            _testimonialDAL.Insert(t);
        }

        public void Update(Testimonial t)
        {
            _testimonialDAL.Update(t);
        }
    }
}

