using System;

namespace DependencyInjectiion
{
    //Client Class -The client class is a class which depends on the service class
    //Service Class- Service class is a class which provides service to the client class
    //Injector class-Injactor class is a class which injects objects from service class to client class

    class Program
    {
        static void Main(string[] args)
        { 
            //Injection
            BusinessLogicservice objbusiness = new BusinessLogicservice(new TeacherService());

            Console.ReadKey();
        }
    } 
    //Client Class
    public class BusinessLogicservice
        {
        private Iservice _iService;
        public BusinessLogicservice(Iservice _iService)
        {
            this._iService = _iService;
            this._iService.GetFirstName();
            this._iService.GetLastName();
        }


        }
  public interface Iservice
    {
        void GetFirstName();
        void GetLastName();


    } 
    //Service Class
    public class StudentService : Iservice
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
    public class TeacherService : Iservice
    {
        public void GetFirstName()
        {
            Console.WriteLine("Teacher First Name");
        }

        public void GetLastName()
        {
            Console.WriteLine("Teacher Last Name");
        }
    }
}
