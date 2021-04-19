using Blogger.ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IComments" in both code and config file together.
[ServiceContract]
public interface IComments
{
    [OperationContract]
    IEnumerable<CommentDto> GetComments();

    [OperationContract]
    int Save(string content, bool isVisible);

    [OperationContract]
    int Delete(int id);

    [OperationContract]
    int Edit(int id, string content, bool isVisible);

    [OperationContract]
    CommentDto GetById(int id);
}
