using Blogger.ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuthors" in both code and config file together.
[ServiceContract]
public interface IAuthors
{
    [OperationContract]
    IEnumerable<AuthorDto> GetAuthors();

    [OperationContract]
    int Save(string firstName, string lastName, string email);

    [OperationContract]
    int Delete(int id);

    [OperationContract]
    int Edit(int id, string firstName, string lastName, string email);

    [OperationContract]
    AuthorDto GetByEmail(string email);
}
