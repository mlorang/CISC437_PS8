using System;
using AutoMapper;

using WebRest.EF.Models;

namespace WebRestAPI.Code;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Address, Address>();
        CreateMap<Employer, Employer>();
        CreateMap<Enrollment, Enrollment>();
        CreateMap<Instructor, Instructor>();
        CreateMap<InstructorAddress, InstructorAddress>();
        CreateMap<Location, Location>();
        CreateMap<Section, Section>();
        CreateMap<StudentAddress, StudentAddress>();
        CreateMap<Student, Student>();
        CreateMap<StudentEmployer, StudentEmployer>();
        CreateMap<Zipcode, Zipcode>();

    }
}
