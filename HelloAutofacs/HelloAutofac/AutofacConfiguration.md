## Autofac in DotNet Core 3.X
### What is Autofac?
Autofac is an IoC container for Microsoft .NET. 
It manages the dependencies between classes so that applications 
stay easy to change as they grow in size and complexity. 
This is achieved by treating regular .NET classes as components.

### How to use Autpfac in ASP core 3.0
    https://docs.autofac.org/en/latest/index.html
    https://autofaccn.readthedocs.io/en/latest/integration/aspnetcore.html
    https://dotnetcorecentral.com/blog/autofac-in-asp-net-core-web-application/
    https://stackoverflow.com/questions/58133507/configureservices-returning-a-system-iserviceprovider-isnt-supported

###### Prerequisite : install autofac Dlls from NuGet 
    1. Installing NuGet package Autofac 5.1.3.
    2. Installing NuGet package Autofac.Extensions.DependencyInjection 6.0.0.

###### Program.cs file.
    1. Add "using Autofac.Extensions.DependencyInjection;".
    2. Add "UseServiceProviderFactory".
        //// AutoFac #1 on Program 
        //// Autofac provider to the generic hosting mechanism.
        .UseServiceProviderFactory(new AutofacServiceProviderFactory())
###### Startup.cs file.
    1. Add "using Autofac;" 
           "using Autofac.Extensions.DependencyInjection;".    

    2. Add ILifetimeScope type property called AutofacContainer.
        ////------ AutoFac #2 : Add AutofacContainer property.
        public ILifetimeScope AutofacContainer { get; private set; }

    3. Add GetAutofacRoot on mehtod Configure() for configuring the HTTP request pipeline.
        ////------ AutoFac #3 :
        // If, for some reason, you need a reference to the built container, 
        // you can use the convenience extension method GetAutofacRoot.
        this.AutofacContainer = app.ApplicationServices.GetAutofacRoot();

    4. Create ConfigureContainer method, Register your Module here!
        ////------  AutoFac #4 :
        // ConfigureContainer is where you can register things directly
        // with Autofac. This runs after ConfigureServices so the things
        // here will override registrations made in ConfigureServices.
        // Don't build the container; that gets done for you by the factory.
        public void ConfigureContainer(ContainerBuilder builder)
        {
            // Register your own things directly with Autofac, like:
            // Encapsulated Configuration
            //builder.RegisterModule(new CarTransportModule()
            //{
            //    ObeySpeedLimit = true
            //});
            //builder.RegisterModule(new CarTransportModule());
            //builder.RegisterModule(new MyApplicationModule());
            builder.RegisterType<DataProvider>().As<IDataProvider>();
        }

###### Add you Module 
    1. Add interface "IDataProvider";
    2. Add class to implement interface "DataProvider.cs";
    3. Register them on method ConfigureContainer;

##### Add controller to test Autofac
    1. Create a folder "Controllers";
    2. Add a controller "Autofac" by select "API Controller - Empty";
    3. Add codes.

##### Set Web Application to start Web API
    Becasue the project "HelloAutofac" is created by "Create a new ASP.NET Core Web application.  -- Empty";
    1. The method "ConfigureServices" is empty, not data;
    2. The mehtod "Configure" to use "await context.Response.WriteAsync("Hello World!");".
    for our web api works we will do:
    1. In the method "ConfigureServices" add "services.AddControllers();"
    2. "endpoints.MapControllers();" replace WriteAsync("Hello World!").

##### Launch HelloAutofac
    Open file "Properties/launchSettings.json" 
    and Add "launchUrl": "api/autofac",
    Run the project "HelloAutofac" on "IIS Express" mode. We see "Test data IoC container Autofac!" on web browser!

##### Next Step:
    1. create the Module inherited Autofac.Module;
    2. wrok with MediatR;