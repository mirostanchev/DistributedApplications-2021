using Blogger.ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRatings" in both code and config file together.
[ServiceContract]
public interface IRatings
{
    [OperationContract]
    IEnumerable<RatingDto> GetRatings();

    [OperationContract]
    int Save(bool isPositive);

    [OperationContract]
    int Delete(int id);

    [OperationContract]
    int Edit(int id, bool isPositive);

    [OperationContract]
    RatingDto GetById(int id);
}
