using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using System.Web.Http.Controllers;

namespace HelloWorldAPI.CastleDI
{
    public class DIInstaller: IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(

                        Classes.FromThisAssembly().BasedOn<IHttpController>().LifestyleTransient(),

                        Classes.FromAssemblyNamed("HelloWorld.Service")
                            .Where(type => type.Name.EndsWith("Service")).WithServiceAllInterfaces().LifestylePerWebRequest(),

                        Classes.FromAssemblyNamed("HelloWorld.Repository")
                            .Where(type => type.Name.EndsWith("Repository") || type.Name.EndsWith("Provider")).WithServiceAllInterfaces().LifestylePerWebRequest()
                        );
        }
    }
}