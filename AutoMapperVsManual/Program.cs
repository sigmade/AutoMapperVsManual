using AutoMapper;
using AutoMapperVsManual;
using System.Diagnostics;


var config = new MapperConfiguration(cfg => {
    cfg.CreateMap<Source, Dest>();
});

IMapper mapper = config.CreateMapper();

var source = DataGen.NewSource();
var timer = new Stopwatch();

timer.Start();
var dest = source.ToDest();
timer.Stop();
TimeSpan timeSpan = timer.Elapsed;
Console.WriteLine($"  StaticMethod {timeSpan:s\\.ffff} sec");

timer.Restart();

var destAM = mapper.Map<Source, Dest>(source);
timer.Stop();
TimeSpan timeSpan2 = timer.Elapsed;
Console.WriteLine($"  Automapper {timeSpan2:s\\.ffff} sec");

Console.ReadKey();
