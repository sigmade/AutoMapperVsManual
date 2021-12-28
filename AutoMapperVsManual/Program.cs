// See https://aka.ms/new-console-template for more information
using AutoMapper;
using AutoMapperVsManual;

Console.WriteLine("Hello, World!");

var config = new MapperConfiguration(cfg => {
    cfg.CreateMap<Driver, Insured>();
});

IMapper mapper = config.CreateMapper();


var driver = new Driver { Id = 1, DriveClass = 2};


var insured = driver.ToInsured();
var insuredAM = mapper.Map<Driver, Insured>(driver);

Console.WriteLine(insuredAM);