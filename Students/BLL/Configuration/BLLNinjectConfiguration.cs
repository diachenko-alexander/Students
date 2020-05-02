using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using DAL.Repositories;
using Ninject.Modules;

namespace BLL.Configuration
{
    public class BLLNinjectConfiguration : NinjectModule
    {
        private readonly string _connectionString;

        public BLLNinjectConfiguration(string connectionString)
        {
            _connectionString = connectionString;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(_connectionString);

            //Services
            Bind<IStudentService>().To<StudentServises>();
            Bind<IAuditoryService>().To<AuditoryService>();
            Bind<ICourseService>().To<CourseService>();
            Bind<IScheduleService>().To<ScheduleService>();
            Bind<ITrainerService>().To<TrainerService>();
        }
    } 
}
