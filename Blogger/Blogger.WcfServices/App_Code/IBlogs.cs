using Blogger.ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBlogs" in both code and config file together.
[ServiceContract]
public interface IBlogs
{
    [OperationContract]
    IEnumerable<BlogDto> GetBlogs();

    [OperationContract]
    int Save(string title, string content);

    [OperationContract]
    int Delete(int id);

    [OperationContract]
    int Edit(int id, string title, string content);

    [OperationContract]
    BlogDto GetByTitle(string title);
}
