using System;

namespace DependencyInjectiion
{
    class Program
    {        static void Main()
        { 
            BusinessLogicService objbusiness = new BusinessLogicService(new TeacherService());
            Console.ReadKey();
        }
    } 
      public class BusinessLogicService
    {
        private IService _IService;
        public BusinessLogicService(IService _IService)
        {
            this._IService = _IService;
            this._IService.GetFirstName();
            this._IService.GetLastName();
        }
        }
  public interface IService
    {
        void GetFirstName();
        void GetLastName();
    } 
    //Service Class
    public class StudentService : IService
    {
        public void GetFirstName()
        {
            Console.WriteLine("Student First Name");
        }
        public void GetLastName()
        {
            Console.WriteLine("Student Last Name");
        }
    }
    public class TeacherService : IService
    {        public void GetFirstName()
        {
            Console.WriteLine("Teacher First Name");
        }

        public void GetLastName()
        {
            Console.WriteLine("Teacher Last Name");
        }
    }
}
