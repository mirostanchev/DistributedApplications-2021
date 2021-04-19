using Blogger.ApplicationServices.DTOs;
using Blogger.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.ApplicationServices.Helpers
{
    public static class RatingConvertHelper
    {
        public static Rating ToRatingEntity(this RatingDto ratingDto)
        {
            return new Rating()
            {
                Id = ratingDto.Id,
                IsPositive = ratingDto.IsPositive,
            };
        }

        public static RatingDto ToRatingDto(this Rating rating)
        {
            return new RatingDto()
            {
                Id = rating.Id,
                IsPositive = rating.IsPositive,
            };
        }

        public static IEnumerable<RatingDto> ToRatingDtos(this IEnumerable<Rating> ratings)
        {
            return ratings.Select(r => r.ToRatingDto());
        }
    }
}
