using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WEBAPI.MODELSACCESS;

public partial class Student
{
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }
    
    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? EMailAddress { get; set; }

    public string? StudentId { get; set; }

    public string? Level { get; set; }

    public string? Room { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? IdNumber { get; set; }

    public string? HomePhone { get; set; }

    public string? MobilePhone { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? StateProvince { get; set; }

    public string? ZipPostalCode { get; set; }

    public string? CountryRegion { get; set; }

    public string? WebPage { get; set; }

}

public class someglobalvariables
{
    public int currentstudentnumber = 1000;

}