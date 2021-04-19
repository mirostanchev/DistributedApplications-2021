using Blogger.ApplicationServices;
using Blogger.ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Ratings" in code, svc and config file together.
public class Ratings : IRatings
{
    private readonly RatingsManagementService service;

    public Ratings()
    {
        this.service = new RatingsManagementService();
    }

    public int Delete(int id)
    {
        return service.Delete(id);
    }

    public int Edit(int id, bool isPositive)
    {
        return service.Edit(new RatingDto(){ Id = id, IsPositive = isPositive});
    }

    public RatingDto GetById(int id)
    {
        return service.GetById(id);
    }

    public IEnumerable<RatingDto> GetRatings()
    {
        return service.GetAll();
    }

    public int Save(bool isPositive)
    {
        return service.Save(new RatingDto() { IsPositive = isPositive});
    }
}
