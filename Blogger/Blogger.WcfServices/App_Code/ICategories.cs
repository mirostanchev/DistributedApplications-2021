﻿using Blogger.ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICategories" in both code and config file together.
[ServiceContract]
public interface ICategories
{
    [OperationContract]
    IEnumerable<CategoryDto> GetCategories();

    [OperationContract]
    int Save(string name, bool isActive);

    [OperationContract]
    int Delete(int id);

    [OperationContract]
    int Edit(int id, string name, bool isActive);

    [OperationContract]
    CategoryDto GetByName(string name);
}
