using Blogger.ApplicationServices.DTOs;
using Blogger.ApplicationServices.Helpers;
using Blogger.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.ApplicationServices
{
    public class RatingsManagementService : BaseManagementService
    {
        public int Delete(int id)
        {
            try
            {
                Rating rating = context.Ratings.Find(id);
                if (rating == null)
                {
                    return -1;
                }

                context.Ratings.Remove(rating);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Edit(RatingDto ratingDto)
        {
            try
            {
                Rating rating = context.Ratings.Find(ratingDto.Id);
                if (rating == null)
                {
                    return -1;
                }

                rating.IsPositive = ratingDto.IsPositive;
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public RatingDto GetById(int id)
        {
            return context.Ratings.AsNoTracking().SingleOrDefault(r => r.Id == id)?.ToRatingDto(); ;
        }

        public IEnumerable<RatingDto> GetAll()
        {
            return context.Ratings.AsNoTracking().AsEnumerable().ToRatingDtos();
        }

        public int Save(RatingDto ratingDto)
        {
            try
            {
                context.Ratings.Add(ratingDto.ToRatingEntity());
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
